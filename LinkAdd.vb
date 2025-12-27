Imports System.Text.RegularExpressions

Public Class LinkAdd
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Using drx As New FolderBrowserDialog

            drx.Multiselect = True

            If drx.ShowDialog = DialogResult.OK Then
                For Each itm As String In drx.SelectedPaths
                    Dim xr As New IO.DirectoryInfo(itm)
                    Dim trx As New ListViewItem(xr.FullName)

                    trx.SubItems.Add(New ListViewItem.ListViewSubItem())
                    trx.SubItems.Add(New ListViewItem.ListViewSubItem())
                    trx.SubItems.Add(New ListViewItem.ListViewSubItem())
                    trx.SubItems.Add(New ListViewItem.ListViewSubItem())
                    trx.SubItems(0).Text = xr.FullName
                    trx.SubItems(1).Text = xr.Name
                    trx.SubItems(2).Text = "Everyone"
                    trx.SubItems(3).Text = "Read"
                    ListView1.Items.Add(trx)

                Next
            End If
        End Using
    End Sub

    Private Sub LinkAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cxt As New ProcessStartInfo("net", "users")
        cxt.CreateNoWindow = True
        cxt.RedirectStandardOutput = True
        Dim scp As Process = Process.Start(cxt)

        Dim userlist As String = scp.StandardOutput.ReadToEnd

        Dim sct As New Text.RegularExpressions.Regex("^(\w+)  ", RegexOptions.IgnoreCase Or RegexOptions.Multiline)


        For Each itm As Match In sct.Matches(userlist)


            CVTS.DropDownItems.Add(itm.Captures(0).Value)
            AddHandler CVTS.DropDownItems(CVTS.DropDownItems.Count - 1).Click, AddressOf CVTSToolStripMenuItem_Click
        Next

    End Sub

    Private Sub ReadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReadToolStripMenuItem.Click, WriteToolStripMenuItem.Click

        If ListView1.SelectedItems.Count > 0 Then
            ListView1.SelectedItems(0).SubItems.Item(3).Text = sender.text
        End If
    End Sub

    Private Sub CVTSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EveryoneToolStripMenuItem.Click

        If ListView1.SelectedItems.Count > 0 Then
            ListView1.SelectedItems(0).SubItems.Item(2).Text = sender.text
        End If
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        If ListView1.SelectedItems.Count > 0 Then
            ListView1.SelectedItems(0).Remove()
        End If

    End Sub

    Private Sub Cs1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Cs1.Opening
        If ListView1.SelectedItems.Count > 0 Then
            Cs1.Enabled = True
        Else
            Cs1.Enabled = False
        End If
    End Sub
End Class