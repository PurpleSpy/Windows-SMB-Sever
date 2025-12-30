Imports System.Text.RegularExpressions
Imports System.Xml.Schema

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = If(Security.Principal.WindowsPrincipal.Current.IsInRole("ADMINISTRATORS"), "ADMIN", "USER" & vbCrLf & "Please Restart as Admin to use program")
        If Security.Principal.WindowsPrincipal.Current.IsInRole("ADMINISTRATORS") Then
            Panel2.Enabled = True
            initCheckbox()

            Dim incheckup As New Timer
            AddHandler incheckup.Tick, AddressOf autoupdate
            incheckup.Interval = 30000
            incheckup.Enabled = True

        Else
            writeText("Please restart program in admin mode to continue")
        End If




    End Sub



    Sub initCheckbox()
        CheckedListBox1.Enabled = False
        CheckedListBox1.Items.Clear()

        Dim startdetails As New ProcessStartInfo("powershell", "net share")
        Dim pshell As New Process
        pshell.StartInfo = startdetails
        startdetails.CreateNoWindow = True
        startdetails.RedirectStandardError = True
        startdetails.RedirectStandardOutput = True
        pshell.Start()

        Dim detailofrun As String = pshell.StandardOutput.ReadToEnd

        Dim searchPattern As New Text.RegularExpressions.Regex("^([a-z\$\-0-9_]*) *([a-z]+\:\\[a-z0-9\-_]*|)", RegexOptions.IgnoreCase Or RegexOptions.Multiline)
        Dim srx As New Text.RegularExpressions.Regex("----*")


        For Each itm As Match In searchPattern.Matches(detailofrun)
            If itm.Groups(1).Value.ToLower = "" Or itm.Groups(1).Value.ToLower = "share" Or itm.Groups(1).Value.ToLower = " " Or itm.Groups(0).Value.ToLower = "" Or itm.Groups(1).Value.ToLower = "the" Or srx.IsMatch(itm.Groups(1).Value.ToLower) Then
                Continue For
            End If

            CheckedListBox1.Items.Add(itm.Groups(1).Value & vbTab & vbTab & vbTab & itm.Groups(2).Value)


        Next



        CheckedListBox1.Enabled = True

        If CheckedListBox1.Items.Count > 0 Then
            Button1.Enabled = True
        Else
            Button1.Enabled = False
        End If
    End Sub

    Sub processKillLink()
        Panel1.Enabled = False

        writeText("Started killing links")

        For Each itm As String In CheckedListBox1.CheckedItems
            killSMBLink(itm.Split(vbTab)(0))

        Next


        writeText("Completed killing links")

        initCheckbox()

        Panel1.Enabled = True
    End Sub

    Sub killSMBLink(Smbshare)
        Dim procstart As New ProcessStartInfo("powershell", New String() {"Remove-SmbShare", "-Name", """" & Smbshare & """", "-force"})
        procstart.CreateNoWindow = True
        procstart.RedirectStandardError = True
        procstart.RedirectStandardOutput = True
        procstart.RedirectStandardInput = True

        Try

            Dim cpr As New Process
            cpr.StartInfo = procstart
            cpr.Start()

            Dim errorlines As String = cpr.StandardError.ReadToEnd

            writeText("Removed SMB Share " & Smbshare & cpr.StandardOutput.ReadToEnd)

            writeText("Did not remove SMB Share because " & Smbshare & errorlines)

        Catch ex As Exception

            writeText("Failed to remove " & Smbshare)

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        processKillLink()
    End Sub

    Sub autoupdate(sender As Object, e As EventArgs)
        initCheckbox()
    End Sub


    Sub writeText(text As String)
        RichTextBox1.Text += vbCrLf & text
    End Sub

    Private Sub CheckedListBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles CheckedListBox1.MouseDown
        Dim therewasacheckbox As Boolean = (CheckedListBox1.CheckedItems.Count > 0)

        If e.Button = MouseButtons.Right Then

            For i As Integer = 0 To CheckedListBox1.Items.Count - 1

                CheckedListBox1.SetItemChecked(i, Not therewasacheckbox)
            Next

        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If LinkAdd.ShowDialog = DialogResult.OK Then

            For Each itm As ListViewItem In LinkAdd.ListView1.Items

                Dim procstart As New ProcessStartInfo("net", "share " & itm.SubItems(1).Text & "=" & itm.Text & " /GRANT:" & itm.SubItems(2).Text & "," & itm.SubItems(3).Text)
                procstart.CreateNoWindow = True
                procstart.RedirectStandardOutput = True

                Try
                    writeText("Attempting to forge link")
                    Dim xct As Process = Process.Start(procstart)

                    writeText(xct.StandardOutput.ReadToEnd)

                Catch ex As Exception

                End Try

            Next
        End If

        initCheckbox()
    End Sub
End Class

