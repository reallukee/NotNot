<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NotNot
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NotNot))
        Me.Separator_Bottom = New System.Windows.Forms.Panel()
        Me.Action_Panel = New System.Windows.Forms.Panel()
        Me.Action_Menu = New System.Windows.Forms.MenuStrip()
        Me.Expf = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Expf_NotNot = New System.Windows.Forms.ToolStripMenuItem()
        Me.Expf_Separator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Expf_CenterOnScreen = New System.Windows.Forms.ToolStripMenuItem()
        Me.Expf_BetterSize = New System.Windows.Forms.ToolStripMenuItem()
        Me.Expf_SuperExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.Action_Menu_AddViewer = New System.Windows.Forms.ToolStripMenuItem()
        Me.Action_Menu_DragAndDrop = New System.Windows.Forms.ToolStripMenuItem()
        Me.Action_Menu_AlwaysOnTop = New System.Windows.Forms.ToolStripMenuItem()
        Me.Action_Menu_FullScreen = New System.Windows.Forms.ToolStripMenuItem()
        Me.Action_Menu_SquareMode = New System.Windows.Forms.ToolStripMenuItem()
        Me.Action_Menu_LessOpacity = New System.Windows.Forms.ToolStripMenuItem()
        Me.Action_Menu_MoreOpacity = New System.Windows.Forms.ToolStripMenuItem()
        Me.Viewers = New System.Windows.Forms.Panel()
        Me.Viewers_Info = New System.Windows.Forms.Label()
        Me.Info_Panel = New System.Windows.Forms.Panel()
        Me.Info_Menu = New System.Windows.Forms.StatusStrip()
        Me.Version = New System.Windows.Forms.ToolStripStatusLabel()
        Me.CMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CMenu_SquareMode = New System.Windows.Forms.ToolStripMenuItem()
        Me.CMenu_ShowHide = New System.Windows.Forms.ToolStripMenuItem()
        Me.CMenu_DragAndDrop = New System.Windows.Forms.ToolStripMenuItem()
        Me.CMenu_Separator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CMenu_Close = New System.Windows.Forms.ToolStripMenuItem()
        Me.SquareMode_Panel = New System.Windows.Forms.Panel()
        Me.SquareMode_Menu = New System.Windows.Forms.MenuStrip()
        Me.SquareMode_Menu_Disable = New System.Windows.Forms.ToolStripMenuItem()
        Me.Separator_Top = New System.Windows.Forms.Panel()
        Me.NI = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Action_Panel.SuspendLayout()
        Me.Action_Menu.SuspendLayout()
        Me.Expf.SuspendLayout()
        Me.Viewers.SuspendLayout()
        Me.Info_Panel.SuspendLayout()
        Me.Info_Menu.SuspendLayout()
        Me.CMenu.SuspendLayout()
        Me.SquareMode_Panel.SuspendLayout()
        Me.SquareMode_Menu.SuspendLayout()
        Me.SuspendLayout()
        '
        'Separator_Bottom
        '
        Me.Separator_Bottom.BackColor = System.Drawing.Color.Gray
        Me.Separator_Bottom.Dock = System.Windows.Forms.DockStyle.Top
        Me.Separator_Bottom.Location = New System.Drawing.Point(0, 61)
        Me.Separator_Bottom.Name = "Separator_Bottom"
        Me.Separator_Bottom.Size = New System.Drawing.Size(1132, 1)
        Me.Separator_Bottom.TabIndex = 0
        '
        'Action_Panel
        '
        Me.Action_Panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.Action_Panel.Controls.Add(Me.Action_Menu)
        Me.Action_Panel.Dock = System.Windows.Forms.DockStyle.Top
        Me.Action_Panel.Location = New System.Drawing.Point(0, 1)
        Me.Action_Panel.Name = "Action_Panel"
        Me.Action_Panel.Size = New System.Drawing.Size(1132, 60)
        Me.Action_Panel.TabIndex = 1
        '
        'Action_Menu
        '
        Me.Action_Menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.Action_Menu.ContextMenuStrip = Me.Expf
        Me.Action_Menu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Action_Menu.Font = New System.Drawing.Font("Segoe Fluent Icons", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Action_Menu.GripMargin = New System.Windows.Forms.Padding(2)
        Me.Action_Menu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.Action_Menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Action_Menu_AddViewer, Me.Action_Menu_DragAndDrop, Me.Action_Menu_AlwaysOnTop, Me.Action_Menu_FullScreen, Me.Action_Menu_SquareMode, Me.Action_Menu_LessOpacity, Me.Action_Menu_MoreOpacity})
        Me.Action_Menu.Location = New System.Drawing.Point(0, 0)
        Me.Action_Menu.Name = "Action_Menu"
        Me.Action_Menu.Padding = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.Action_Menu.ShowItemToolTips = True
        Me.Action_Menu.Size = New System.Drawing.Size(1132, 60)
        Me.Action_Menu.TabIndex = 0
        '
        'Expf
        '
        Me.Expf.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Expf.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.Expf.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Expf_NotNot, Me.Expf_Separator1, Me.Expf_CenterOnScreen, Me.Expf_BetterSize, Me.Expf_SuperExit})
        Me.Expf.Name = "Expf"
        Me.Expf.Size = New System.Drawing.Size(318, 126)
        '
        'Expf_NotNot
        '
        Me.Expf_NotNot.Name = "Expf_NotNot"
        Me.Expf_NotNot.Size = New System.Drawing.Size(317, 22)
        Me.Expf_NotNot.Text = "NotNot Dev Menu"
        '
        'Expf_Separator1
        '
        Me.Expf_Separator1.Name = "Expf_Separator1"
        Me.Expf_Separator1.Size = New System.Drawing.Size(314, 6)
        '
        'Expf_CenterOnScreen
        '
        Me.Expf_CenterOnScreen.Name = "Expf_CenterOnScreen"
        Me.Expf_CenterOnScreen.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.Expf_CenterOnScreen.Size = New System.Drawing.Size(317, 22)
        Me.Expf_CenterOnScreen.Text = "Center on Screen"
        '
        'Expf_BetterSize
        '
        Me.Expf_BetterSize.Name = "Expf_BetterSize"
        Me.Expf_BetterSize.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.Expf_BetterSize.Size = New System.Drawing.Size(317, 22)
        Me.Expf_BetterSize.Text = "Better Size"
        '
        'Expf_SuperExit
        '
        Me.Expf_SuperExit.Name = "Expf_SuperExit"
        Me.Expf_SuperExit.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.Expf_SuperExit.Size = New System.Drawing.Size(317, 22)
        Me.Expf_SuperExit.Text = "Super Exit"
        '
        'Action_Menu_AddViewer
        '
        Me.Action_Menu_AddViewer.Name = "Action_Menu_AddViewer"
        Me.Action_Menu_AddViewer.Padding = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.Action_Menu_AddViewer.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.Action_Menu_AddViewer.Size = New System.Drawing.Size(45, 54)
        Me.Action_Menu_AddViewer.Text = ""
        Me.Action_Menu_AddViewer.ToolTipText = "Add Viewer (CTRL+N)"
        '
        'Action_Menu_DragAndDrop
        '
        Me.Action_Menu_DragAndDrop.Enabled = False
        Me.Action_Menu_DragAndDrop.Font = New System.Drawing.Font("Segoe MDL2 Assets", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Action_Menu_DragAndDrop.Name = "Action_Menu_DragAndDrop"
        Me.Action_Menu_DragAndDrop.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.Action_Menu_DragAndDrop.Size = New System.Drawing.Size(44, 54)
        Me.Action_Menu_DragAndDrop.Text = ""
        Me.Action_Menu_DragAndDrop.ToolTipText = "Drag and Drop (CTRL+D)"
        '
        'Action_Menu_AlwaysOnTop
        '
        Me.Action_Menu_AlwaysOnTop.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Action_Menu_AlwaysOnTop.Font = New System.Drawing.Font("Segoe MDL2 Assets", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Action_Menu_AlwaysOnTop.Name = "Action_Menu_AlwaysOnTop"
        Me.Action_Menu_AlwaysOnTop.ShortcutKeys = System.Windows.Forms.Keys.F12
        Me.Action_Menu_AlwaysOnTop.Size = New System.Drawing.Size(43, 54)
        Me.Action_Menu_AlwaysOnTop.Text = ""
        Me.Action_Menu_AlwaysOnTop.ToolTipText = "Always on Top (F12)"
        '
        'Action_Menu_FullScreen
        '
        Me.Action_Menu_FullScreen.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Action_Menu_FullScreen.Font = New System.Drawing.Font("Segoe MDL2 Assets", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Action_Menu_FullScreen.Name = "Action_Menu_FullScreen"
        Me.Action_Menu_FullScreen.ShortcutKeys = System.Windows.Forms.Keys.F11
        Me.Action_Menu_FullScreen.Size = New System.Drawing.Size(40, 54)
        Me.Action_Menu_FullScreen.Text = ""
        Me.Action_Menu_FullScreen.ToolTipText = "Full Screen (F11)"
        '
        'Action_Menu_SquareMode
        '
        Me.Action_Menu_SquareMode.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Action_Menu_SquareMode.Name = "Action_Menu_SquareMode"
        Me.Action_Menu_SquareMode.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.Action_Menu_SquareMode.Size = New System.Drawing.Size(43, 54)
        Me.Action_Menu_SquareMode.Text = ""
        Me.Action_Menu_SquareMode.ToolTipText = "Square Mode (CTRL+S)"
        '
        'Action_Menu_LessOpacity
        '
        Me.Action_Menu_LessOpacity.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Action_Menu_LessOpacity.Font = New System.Drawing.Font("Segoe MDL2 Assets", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Action_Menu_LessOpacity.Name = "Action_Menu_LessOpacity"
        Me.Action_Menu_LessOpacity.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Down), System.Windows.Forms.Keys)
        Me.Action_Menu_LessOpacity.Size = New System.Drawing.Size(43, 54)
        Me.Action_Menu_LessOpacity.Text = ""
        Me.Action_Menu_LessOpacity.ToolTipText = "Less Opacity (CTRL+DOWN)"
        '
        'Action_Menu_MoreOpacity
        '
        Me.Action_Menu_MoreOpacity.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Action_Menu_MoreOpacity.Font = New System.Drawing.Font("Segoe MDL2 Assets", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Action_Menu_MoreOpacity.Name = "Action_Menu_MoreOpacity"
        Me.Action_Menu_MoreOpacity.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Up), System.Windows.Forms.Keys)
        Me.Action_Menu_MoreOpacity.Size = New System.Drawing.Size(43, 54)
        Me.Action_Menu_MoreOpacity.Text = ""
        Me.Action_Menu_MoreOpacity.ToolTipText = "More Opacity (CTRL+UP)"
        '
        'Viewers
        '
        Me.Viewers.Controls.Add(Me.Viewers_Info)
        Me.Viewers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Viewers.Location = New System.Drawing.Point(0, 62)
        Me.Viewers.Name = "Viewers"
        Me.Viewers.Size = New System.Drawing.Size(1132, 491)
        Me.Viewers.TabIndex = 2
        '
        'Viewers_Info
        '
        Me.Viewers_Info.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Viewers_Info.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Viewers_Info.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Viewers_Info.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Viewers_Info.Location = New System.Drawing.Point(0, 0)
        Me.Viewers_Info.Name = "Viewers_Info"
        Me.Viewers_Info.Size = New System.Drawing.Size(1132, 491)
        Me.Viewers_Info.TabIndex = 0
        Me.Viewers_Info.Text = "Drag and Drop" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "or" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Double Click "
        Me.Viewers_Info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Info_Panel
        '
        Me.Info_Panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Info_Panel.Controls.Add(Me.Info_Menu)
        Me.Info_Panel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Info_Panel.Location = New System.Drawing.Point(0, 553)
        Me.Info_Panel.Name = "Info_Panel"
        Me.Info_Panel.Size = New System.Drawing.Size(1132, 50)
        Me.Info_Panel.TabIndex = 4
        '
        'Info_Menu
        '
        Me.Info_Menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Info_Menu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Info_Menu.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Info_Menu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.Info_Menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Version})
        Me.Info_Menu.Location = New System.Drawing.Point(0, 0)
        Me.Info_Menu.Name = "Info_Menu"
        Me.Info_Menu.Size = New System.Drawing.Size(1132, 50)
        Me.Info_Menu.TabIndex = 0
        '
        'Version
        '
        Me.Version.ForeColor = System.Drawing.Color.Gray
        Me.Version.Margin = New System.Windows.Forms.Padding(10, 4, 10, 4)
        Me.Version.Name = "Version"
        Me.Version.Size = New System.Drawing.Size(146, 42)
        Me.Version.Text = "NotNot 1.3.0-080322"
        '
        'CMenu
        '
        Me.CMenu.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.CMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CMenu_SquareMode, Me.CMenu_ShowHide, Me.CMenu_DragAndDrop, Me.CMenu_Separator1, Me.CMenu_Close})
        Me.CMenu.Name = "CMenu"
        Me.CMenu.Size = New System.Drawing.Size(173, 98)
        '
        'CMenu_SquareMode
        '
        Me.CMenu_SquareMode.Name = "CMenu_SquareMode"
        Me.CMenu_SquareMode.Size = New System.Drawing.Size(172, 22)
        Me.CMenu_SquareMode.Text = "Square Mode"
        '
        'CMenu_ShowHide
        '
        Me.CMenu_ShowHide.Name = "CMenu_ShowHide"
        Me.CMenu_ShowHide.Size = New System.Drawing.Size(172, 22)
        Me.CMenu_ShowHide.Text = "Show/Hide"
        '
        'CMenu_DragAndDrop
        '
        Me.CMenu_DragAndDrop.Enabled = False
        Me.CMenu_DragAndDrop.Name = "CMenu_DragAndDrop"
        Me.CMenu_DragAndDrop.Size = New System.Drawing.Size(172, 22)
        Me.CMenu_DragAndDrop.Text = "Drag and Drop"
        '
        'CMenu_Separator1
        '
        Me.CMenu_Separator1.Name = "CMenu_Separator1"
        Me.CMenu_Separator1.Size = New System.Drawing.Size(169, 6)
        '
        'CMenu_Close
        '
        Me.CMenu_Close.Name = "CMenu_Close"
        Me.CMenu_Close.Size = New System.Drawing.Size(172, 22)
        Me.CMenu_Close.Text = "Close"
        '
        'SquareMode_Panel
        '
        Me.SquareMode_Panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.SquareMode_Panel.Controls.Add(Me.SquareMode_Menu)
        Me.SquareMode_Panel.Location = New System.Drawing.Point(0, 62)
        Me.SquareMode_Panel.Margin = New System.Windows.Forms.Padding(0)
        Me.SquareMode_Panel.Name = "SquareMode_Panel"
        Me.SquareMode_Panel.Size = New System.Drawing.Size(150, 110)
        Me.SquareMode_Panel.TabIndex = 5
        Me.SquareMode_Panel.Visible = False
        '
        'SquareMode_Menu
        '
        Me.SquareMode_Menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.SquareMode_Menu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SquareMode_Menu.Font = New System.Drawing.Font("Segoe Fluent Icons", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.SquareMode_Menu.GripMargin = New System.Windows.Forms.Padding(2)
        Me.SquareMode_Menu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.SquareMode_Menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SquareMode_Menu_Disable})
        Me.SquareMode_Menu.Location = New System.Drawing.Point(0, 0)
        Me.SquareMode_Menu.Name = "SquareMode_Menu"
        Me.SquareMode_Menu.Padding = New System.Windows.Forms.Padding(47, 22, 47, 22)
        Me.SquareMode_Menu.ShowItemToolTips = True
        Me.SquareMode_Menu.Size = New System.Drawing.Size(150, 110)
        Me.SquareMode_Menu.TabIndex = 0
        '
        'SquareMode_Menu_Disable
        '
        Me.SquareMode_Menu_Disable.Font = New System.Drawing.Font("Segoe MDL2 Assets", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.SquareMode_Menu_Disable.Name = "SquareMode_Menu_Disable"
        Me.SquareMode_Menu_Disable.Padding = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.SquareMode_Menu_Disable.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SquareMode_Menu_Disable.Size = New System.Drawing.Size(56, 66)
        Me.SquareMode_Menu_Disable.Text = ""
        Me.SquareMode_Menu_Disable.ToolTipText = "Square Mode (CTRL+S)"
        '
        'Separator_Top
        '
        Me.Separator_Top.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.Separator_Top.Dock = System.Windows.Forms.DockStyle.Top
        Me.Separator_Top.Location = New System.Drawing.Point(0, 0)
        Me.Separator_Top.Name = "Separator_Top"
        Me.Separator_Top.Size = New System.Drawing.Size(1132, 1)
        Me.Separator_Top.TabIndex = 6
        '
        'NI
        '
        Me.NI.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NI.BalloonTipText = "NotNot"
        Me.NI.BalloonTipTitle = "NotNot"
        Me.NI.ContextMenuStrip = Me.CMenu
        Me.NI.Icon = CType(resources.GetObject("NI.Icon"), System.Drawing.Icon)
        Me.NI.Text = "NotNot"
        Me.NI.Visible = True
        '
        'NotNot
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1132, 603)
        Me.Controls.Add(Me.SquareMode_Panel)
        Me.Controls.Add(Me.Viewers)
        Me.Controls.Add(Me.Info_Panel)
        Me.Controls.Add(Me.Separator_Bottom)
        Me.Controls.Add(Me.Action_Panel)
        Me.Controls.Add(Me.Separator_Top)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.Action_Menu
        Me.MinimumSize = New System.Drawing.Size(550, 550)
        Me.Name = "NotNot"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NotNot 1.3.0-080322"
        Me.Action_Panel.ResumeLayout(False)
        Me.Action_Panel.PerformLayout()
        Me.Action_Menu.ResumeLayout(False)
        Me.Action_Menu.PerformLayout()
        Me.Expf.ResumeLayout(False)
        Me.Viewers.ResumeLayout(False)
        Me.Info_Panel.ResumeLayout(False)
        Me.Info_Panel.PerformLayout()
        Me.Info_Menu.ResumeLayout(False)
        Me.Info_Menu.PerformLayout()
        Me.CMenu.ResumeLayout(False)
        Me.SquareMode_Panel.ResumeLayout(False)
        Me.SquareMode_Panel.PerformLayout()
        Me.SquareMode_Menu.ResumeLayout(False)
        Me.SquareMode_Menu.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Separator_Bottom As Panel
    Friend WithEvents Action_Panel As Panel
    Friend WithEvents Action_Menu As MenuStrip
    Friend WithEvents Action_Menu_AddViewer As ToolStripMenuItem
    Friend WithEvents Viewers As Panel
    Friend WithEvents Viewers_Info As Label
    Friend WithEvents Action_Menu_AlwaysOnTop As ToolStripMenuItem
    Friend WithEvents Action_Menu_FullScreen As ToolStripMenuItem
    Friend WithEvents Action_Menu_MoreOpacity As ToolStripMenuItem
    Friend WithEvents Action_Menu_LessOpacity As ToolStripMenuItem
    Friend WithEvents Info_Panel As Panel
    Friend WithEvents Info_Menu As StatusStrip
    Friend WithEvents Version As ToolStripStatusLabel
    Friend WithEvents Expf As ContextMenuStrip
    Friend WithEvents Expf_CenterOnScreen As ToolStripMenuItem
    Friend WithEvents Expf_BetterSize As ToolStripMenuItem
    Friend WithEvents CMenu As ContextMenuStrip
    Friend WithEvents CMenu_Separator1 As ToolStripSeparator
    Friend WithEvents CMenu_Close As ToolStripMenuItem
    Friend WithEvents SquareMode_Panel As Panel
    Friend WithEvents SquareMode_Menu As MenuStrip
    Friend WithEvents SquareMode_Menu_Disable As ToolStripMenuItem
    Friend WithEvents Action_Menu_SquareMode As ToolStripMenuItem
    Friend WithEvents Action_Menu_DragAndDrop As ToolStripMenuItem
    Friend WithEvents Separator_Top As Panel
    Friend WithEvents CMenu_SquareMode As ToolStripMenuItem
    Friend WithEvents CMenu_ShowHide As ToolStripMenuItem
    Friend WithEvents CMenu_DragAndDrop As ToolStripMenuItem
    Friend WithEvents Expf_NotNot As ToolStripMenuItem
    Friend WithEvents Expf_Separator1 As ToolStripSeparator
    Friend WithEvents Expf_SuperExit As ToolStripMenuItem
    Friend WithEvents NI As NotifyIcon
End Class
