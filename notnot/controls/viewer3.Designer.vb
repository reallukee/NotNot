<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Viewer3
    Inherits System.Windows.Forms.UserControl

    'UserControl esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Separator_Y = New System.Windows.Forms.Panel()
        Me.Separator_X = New System.Windows.Forms.Panel()
        Me.Action_Panel = New System.Windows.Forms.Panel()
        Me.Action_Menu = New System.Windows.Forms.MenuStrip()
        Me.Action_Menu_Close = New System.Windows.Forms.ToolStripMenuItem()
        Me.Action_Menu_New = New System.Windows.Forms.ToolStripMenuItem()
        Me.Action_Menu_Open = New System.Windows.Forms.ToolStripMenuItem()
        Me.Action_Menu_Save = New System.Windows.Forms.ToolStripMenuItem()
        Me.Action_Menu_Clear = New System.Windows.Forms.ToolStripMenuItem()
        Me.Separator = New System.Windows.Forms.Panel()
        Me.Viewers = New System.Windows.Forms.Panel()
        Me.Viewers_Info = New System.Windows.Forms.Label()
        Me.Ofd = New System.Windows.Forms.OpenFileDialog()
        Me.Sfd = New System.Windows.Forms.SaveFileDialog()
        Me.CMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CMenu_Undo = New System.Windows.Forms.ToolStripMenuItem()
        Me.CMenu_Redo = New System.Windows.Forms.ToolStripMenuItem()
        Me.CMenu_Separator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CMenu_Cut = New System.Windows.Forms.ToolStripMenuItem()
        Me.CMenu_Copy = New System.Windows.Forms.ToolStripMenuItem()
        Me.CMenu_Paste = New System.Windows.Forms.ToolStripMenuItem()
        Me.CMenu_Delete = New System.Windows.Forms.ToolStripMenuItem()
        Me.CMenu_Separator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CMenu_SelectAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.Action_Panel.SuspendLayout()
        Me.Action_Menu.SuspendLayout()
        Me.Viewers.SuspendLayout()
        Me.CMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'Separator_Y
        '
        Me.Separator_Y.BackColor = System.Drawing.Color.Silver
        Me.Separator_Y.Dock = System.Windows.Forms.DockStyle.Right
        Me.Separator_Y.Location = New System.Drawing.Point(549, 0)
        Me.Separator_Y.Name = "Separator_Y"
        Me.Separator_Y.Size = New System.Drawing.Size(1, 549)
        Me.Separator_Y.TabIndex = 1
        '
        'Separator_X
        '
        Me.Separator_X.BackColor = System.Drawing.Color.Silver
        Me.Separator_X.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Separator_X.Location = New System.Drawing.Point(0, 548)
        Me.Separator_X.Name = "Separator_X"
        Me.Separator_X.Size = New System.Drawing.Size(549, 1)
        Me.Separator_X.TabIndex = 2
        '
        'Action_Panel
        '
        Me.Action_Panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Action_Panel.Controls.Add(Me.Action_Menu)
        Me.Action_Panel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Action_Panel.Location = New System.Drawing.Point(0, 497)
        Me.Action_Panel.Name = "Action_Panel"
        Me.Action_Panel.Size = New System.Drawing.Size(549, 51)
        Me.Action_Panel.TabIndex = 3
        '
        'Action_Menu
        '
        Me.Action_Menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Action_Menu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Action_Menu.Font = New System.Drawing.Font("Segoe Fluent Icons", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Action_Menu.GripMargin = New System.Windows.Forms.Padding(2)
        Me.Action_Menu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.Action_Menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Action_Menu_Close, Me.Action_Menu_New, Me.Action_Menu_Open, Me.Action_Menu_Save, Me.Action_Menu_Clear})
        Me.Action_Menu.Location = New System.Drawing.Point(0, 0)
        Me.Action_Menu.Name = "Action_Menu"
        Me.Action_Menu.Padding = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.Action_Menu.ShowItemToolTips = True
        Me.Action_Menu.Size = New System.Drawing.Size(549, 51)
        Me.Action_Menu.TabIndex = 0
        '
        'Action_Menu_Close
        '
        Me.Action_Menu_Close.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Action_Menu_Close.Font = New System.Drawing.Font("Segoe MDL2 Assets", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Action_Menu_Close.Name = "Action_Menu_Close"
        Me.Action_Menu_Close.Padding = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.Action_Menu_Close.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.Action_Menu_Close.Size = New System.Drawing.Size(41, 45)
        Me.Action_Menu_Close.Text = ""
        Me.Action_Menu_Close.ToolTipText = "Close (CTRL+ALT+W)"
        '
        'Action_Menu_New
        '
        Me.Action_Menu_New.Name = "Action_Menu_New"
        Me.Action_Menu_New.Padding = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.Action_Menu_New.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.Action_Menu_New.Size = New System.Drawing.Size(45, 45)
        Me.Action_Menu_New.Text = ""
        Me.Action_Menu_New.ToolTipText = "New (CTRL+ALT+N)"
        '
        'Action_Menu_Open
        '
        Me.Action_Menu_Open.Name = "Action_Menu_Open"
        Me.Action_Menu_Open.Padding = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.Action_Menu_Open.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.Action_Menu_Open.Size = New System.Drawing.Size(45, 45)
        Me.Action_Menu_Open.Text = ""
        Me.Action_Menu_Open.ToolTipText = "Open (CTRL+ALT+O)"
        '
        'Action_Menu_Save
        '
        Me.Action_Menu_Save.Name = "Action_Menu_Save"
        Me.Action_Menu_Save.Padding = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.Action_Menu_Save.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.Action_Menu_Save.Size = New System.Drawing.Size(45, 45)
        Me.Action_Menu_Save.Text = ""
        Me.Action_Menu_Save.ToolTipText = "Save (CTRL+ALT+S)"
        '
        'Action_Menu_Clear
        '
        Me.Action_Menu_Clear.Name = "Action_Menu_Clear"
        Me.Action_Menu_Clear.Padding = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.Action_Menu_Clear.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.Action_Menu_Clear.Size = New System.Drawing.Size(45, 45)
        Me.Action_Menu_Clear.Text = ""
        Me.Action_Menu_Clear.ToolTipText = "Clear (CTRL+ALT+Q)"
        '
        'Separator
        '
        Me.Separator.BackColor = System.Drawing.Color.Silver
        Me.Separator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Separator.Location = New System.Drawing.Point(0, 496)
        Me.Separator.Name = "Separator"
        Me.Separator.Size = New System.Drawing.Size(549, 1)
        Me.Separator.TabIndex = 4
        '
        'Viewers
        '
        Me.Viewers.AllowDrop = True
        Me.Viewers.BackColor = System.Drawing.Color.White
        Me.Viewers.Controls.Add(Me.Viewers_Info)
        Me.Viewers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Viewers.Location = New System.Drawing.Point(0, 0)
        Me.Viewers.Name = "Viewers"
        Me.Viewers.Size = New System.Drawing.Size(549, 496)
        Me.Viewers.TabIndex = 5
        '
        'Viewers_Info
        '
        Me.Viewers_Info.AllowDrop = True
        Me.Viewers_Info.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Viewers_Info.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Viewers_Info.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Viewers_Info.Location = New System.Drawing.Point(0, 0)
        Me.Viewers_Info.Name = "Viewers_Info"
        Me.Viewers_Info.Size = New System.Drawing.Size(549, 496)
        Me.Viewers_Info.TabIndex = 6
        Me.Viewers_Info.Text = "Drag and Drop" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "or" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Double Click "
        Me.Viewers_Info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Ofd
        '
        Me.Ofd.DefaultExt = "All Files|*.*"
        Me.Ofd.Filter = "All Files|*.*"
        Me.Ofd.Title = "Open"
        '
        'Sfd
        '
        Me.Sfd.Title = "Save"
        '
        'CMenu
        '
        Me.CMenu.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.CMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CMenu_Undo, Me.CMenu_Redo, Me.CMenu_Separator1, Me.CMenu_Cut, Me.CMenu_Copy, Me.CMenu_Paste, Me.CMenu_Delete, Me.CMenu_Separator2, Me.CMenu_SelectAll})
        Me.CMenu.Name = "CMenu"
        Me.CMenu.Size = New System.Drawing.Size(246, 198)
        '
        'CMenu_Undo
        '
        Me.CMenu_Undo.Name = "CMenu_Undo"
        Me.CMenu_Undo.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.CMenu_Undo.Size = New System.Drawing.Size(245, 22)
        Me.CMenu_Undo.Text = "Undo"
        '
        'CMenu_Redo
        '
        Me.CMenu_Redo.Name = "CMenu_Redo"
        Me.CMenu_Redo.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.CMenu_Redo.Size = New System.Drawing.Size(245, 22)
        Me.CMenu_Redo.Text = "Redo"
        '
        'CMenu_Separator1
        '
        Me.CMenu_Separator1.Name = "CMenu_Separator1"
        Me.CMenu_Separator1.Size = New System.Drawing.Size(242, 6)
        '
        'CMenu_Cut
        '
        Me.CMenu_Cut.Name = "CMenu_Cut"
        Me.CMenu_Cut.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.CMenu_Cut.Size = New System.Drawing.Size(245, 22)
        Me.CMenu_Cut.Text = "Cut"
        '
        'CMenu_Copy
        '
        Me.CMenu_Copy.Name = "CMenu_Copy"
        Me.CMenu_Copy.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CMenu_Copy.Size = New System.Drawing.Size(245, 22)
        Me.CMenu_Copy.Text = "Copy"
        '
        'CMenu_Paste
        '
        Me.CMenu_Paste.Name = "CMenu_Paste"
        Me.CMenu_Paste.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.CMenu_Paste.Size = New System.Drawing.Size(245, 22)
        Me.CMenu_Paste.Text = "Paste"
        '
        'CMenu_Delete
        '
        Me.CMenu_Delete.Name = "CMenu_Delete"
        Me.CMenu_Delete.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.Delete), System.Windows.Forms.Keys)
        Me.CMenu_Delete.Size = New System.Drawing.Size(245, 22)
        Me.CMenu_Delete.Text = "Delete"
        '
        'CMenu_Separator2
        '
        Me.CMenu_Separator2.Name = "CMenu_Separator2"
        Me.CMenu_Separator2.Size = New System.Drawing.Size(242, 6)
        '
        'CMenu_SelectAll
        '
        Me.CMenu_SelectAll.Name = "CMenu_SelectAll"
        Me.CMenu_SelectAll.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.CMenu_SelectAll.Size = New System.Drawing.Size(245, 22)
        Me.CMenu_SelectAll.Text = "Select All"
        '
        'Viewer3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Viewers)
        Me.Controls.Add(Me.Separator)
        Me.Controls.Add(Me.Action_Panel)
        Me.Controls.Add(Me.Separator_X)
        Me.Controls.Add(Me.Separator_Y)
        Me.Name = "Viewer3"
        Me.Size = New System.Drawing.Size(550, 549)
        Me.Action_Panel.ResumeLayout(False)
        Me.Action_Panel.PerformLayout()
        Me.Action_Menu.ResumeLayout(False)
        Me.Action_Menu.PerformLayout()
        Me.Viewers.ResumeLayout(False)
        Me.CMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Separator_Y As Panel
    Friend WithEvents Separator_X As Panel
    Friend WithEvents Action_Panel As Panel
    Friend WithEvents Action_Menu As MenuStrip
    Friend WithEvents Separator As Panel
    Friend WithEvents Action_Menu_Close As ToolStripMenuItem
    Friend WithEvents Viewers As Panel
    Friend WithEvents Action_Menu_New As ToolStripMenuItem
    Friend WithEvents Action_Menu_Open As ToolStripMenuItem
    Friend WithEvents Ofd As OpenFileDialog
    Friend WithEvents Action_Menu_Clear As ToolStripMenuItem
    Friend WithEvents Action_Menu_Save As ToolStripMenuItem
    Friend WithEvents Viewers_Info As Label
    Friend WithEvents Sfd As SaveFileDialog
    Friend WithEvents CMenu As ContextMenuStrip
    Friend WithEvents CMenu_Undo As ToolStripMenuItem
    Friend WithEvents CMenu_Redo As ToolStripMenuItem
    Friend WithEvents CMenu_Separator1 As ToolStripSeparator
    Friend WithEvents CMenu_Cut As ToolStripMenuItem
    Friend WithEvents CMenu_Copy As ToolStripMenuItem
    Friend WithEvents CMenu_Paste As ToolStripMenuItem
    Friend WithEvents CMenu_Delete As ToolStripMenuItem
    Friend WithEvents CMenu_Separator2 As ToolStripSeparator
    Friend WithEvents CMenu_SelectAll As ToolStripMenuItem
End Class
