<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        Button1 = New Button()
        Label1 = New Label()
        RichTextBox1 = New RichTextBox()
        CheckedListBox1 = New CheckedListBox()
        Panel2 = New Panel()
        Button2 = New Button()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(RichTextBox1)
        Panel1.Controls.Add(CheckedListBox1)
        Panel1.Location = New Point(4, 9)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(867, 419)
        Panel1.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.Enabled = False
        Button1.Location = New Point(19, 377)
        Button1.Name = "Button1"
        Button1.Size = New Size(146, 23)
        Button1.TabIndex = 3
        Button1.Text = "Kill SMB Links"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(637, 381)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 15)
        Label1.TabIndex = 2
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Location = New Point(19, 193)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.ReadOnly = True
        RichTextBox1.Size = New Size(845, 165)
        RichTextBox1.TabIndex = 1
        RichTextBox1.Text = ""
        ' 
        ' CheckedListBox1
        ' 
        CheckedListBox1.CheckOnClick = True
        CheckedListBox1.FormattingEnabled = True
        CheckedListBox1.Location = New Point(21, 15)
        CheckedListBox1.Name = "CheckedListBox1"
        CheckedListBox1.Size = New Size(843, 166)
        CheckedListBox1.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Panel1)
        Panel2.Enabled = False
        Panel2.Location = New Point(8, 12)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(874, 439)
        Panel2.TabIndex = 1
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(171, 377)
        Button2.Name = "Button2"
        Button2.Size = New Size(101, 23)
        Button2.TabIndex = 4
        Button2.Text = "Add SMB Link"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(894, 457)
        Controls.Add(Panel2)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "Form1"
        Text = "SMB Link Manager"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button2 As Button

End Class
