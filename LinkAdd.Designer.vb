<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LinkAdd
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Button1 = New Button()
        Button2 = New Button()
        ListView1 = New ListView()
        folderpath = New ColumnHeader()
        Foldername = New ColumnHeader()
        Personview = New ColumnHeader()
        readwrite = New ColumnHeader()
        Cs1 = New ContextMenuStrip(components)
        ToolStripMenuItem1 = New ToolStripMenuItem()
        ReadToolStripMenuItem = New ToolStripMenuItem()
        WriteToolStripMenuItem = New ToolStripMenuItem()
        CVTS = New ToolStripMenuItem()
        EveryoneToolStripMenuItem = New ToolStripMenuItem()
        OpenFolderToolStripMenuItem = New ToolStripMenuItem()
        DeleteToolStripMenuItem = New ToolStripMenuItem()
        Button3 = New Button()
        Cs1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(701, 415)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 0
        Button1.Text = "Ok"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(620, 415)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 0
        Button2.Text = "Cancel"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' ListView1
        ' 
        ListView1.Columns.AddRange(New ColumnHeader() {folderpath, Foldername, Personview, readwrite})
        ListView1.ContextMenuStrip = Cs1
        ListView1.FullRowSelect = True
        ListView1.GridLines = True
        ListView1.Location = New Point(12, 30)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(764, 239)
        ListView1.TabIndex = 1
        ListView1.UseCompatibleStateImageBehavior = False
        ListView1.View = View.Details
        ' 
        ' folderpath
        ' 
        folderpath.Text = "Folder Path"
        folderpath.Width = 90
        ' 
        ' Foldername
        ' 
        Foldername.Text = "Folder Name"
        Foldername.Width = 90
        ' 
        ' Personview
        ' 
        Personview.Text = "Visablitly"
        Personview.Width = 90
        ' 
        ' readwrite
        ' 
        readwrite.Text = "Read/write"
        readwrite.Width = 90
        ' 
        ' Cs1
        ' 
        Cs1.Items.AddRange(New ToolStripItem() {ToolStripMenuItem1, CVTS, OpenFolderToolStripMenuItem, DeleteToolStripMenuItem})
        Cs1.Name = "Cs1"
        Cs1.Size = New Size(160, 92)
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.DropDownItems.AddRange(New ToolStripItem() {ReadToolStripMenuItem, WriteToolStripMenuItem})
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(159, 22)
        ToolStripMenuItem1.Text = "Change R/W"
        ' 
        ' ReadToolStripMenuItem
        ' 
        ReadToolStripMenuItem.Name = "ReadToolStripMenuItem"
        ReadToolStripMenuItem.Size = New Size(100, 22)
        ReadToolStripMenuItem.Text = "Read"
        ' 
        ' WriteToolStripMenuItem
        ' 
        WriteToolStripMenuItem.Name = "WriteToolStripMenuItem"
        WriteToolStripMenuItem.Size = New Size(100, 22)
        WriteToolStripMenuItem.Text = "Full"
        ' 
        ' CVTS
        ' 
        CVTS.DropDownItems.AddRange(New ToolStripItem() {EveryoneToolStripMenuItem})
        CVTS.Name = "CVTS"
        CVTS.Size = New Size(159, 22)
        CVTS.Text = "Change Visiblity"
        ' 
        ' EveryoneToolStripMenuItem
        ' 
        EveryoneToolStripMenuItem.Name = "EveryoneToolStripMenuItem"
        EveryoneToolStripMenuItem.Size = New Size(122, 22)
        EveryoneToolStripMenuItem.Text = "Everyone"
        ' 
        ' OpenFolderToolStripMenuItem
        ' 
        OpenFolderToolStripMenuItem.Name = "OpenFolderToolStripMenuItem"
        OpenFolderToolStripMenuItem.Size = New Size(159, 22)
        OpenFolderToolStripMenuItem.Text = "Open Folder"
        ' 
        ' DeleteToolStripMenuItem
        ' 
        DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        DeleteToolStripMenuItem.Size = New Size(159, 22)
        DeleteToolStripMenuItem.Text = "Delete"
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(12, 275)
        Button3.Name = "Button3"
        Button3.Size = New Size(125, 23)
        Button3.TabIndex = 2
        Button3.Text = "Share Folder"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' LinkAdd
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button3)
        Controls.Add(ListView1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        MaximizeBox = False
        Name = "LinkAdd"
        Text = "Add a Share Folder"
        Cs1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents folderpath As ColumnHeader
    Friend WithEvents Foldername As ColumnHeader
    Friend WithEvents Personview As ColumnHeader
    Friend WithEvents readwrite As ColumnHeader
    Friend WithEvents Button3 As Button
    Friend WithEvents Cs1 As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ReadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WriteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CVTS As ToolStripMenuItem
    Friend WithEvents EveryoneToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFolderToolStripMenuItem As ToolStripMenuItem
End Class
