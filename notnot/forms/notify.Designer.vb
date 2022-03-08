<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Notify
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Notify))
        Me.Notify_Info = New System.Windows.Forms.Label()
        Me.Expiration = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Notify_Info
        '
        Me.Notify_Info.AutoSize = True
        Me.Notify_Info.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Notify_Info.ForeColor = System.Drawing.Color.Black
        Me.Notify_Info.Location = New System.Drawing.Point(0, 0)
        Me.Notify_Info.Margin = New System.Windows.Forms.Padding(0)
        Me.Notify_Info.Name = "Notify_Info"
        Me.Notify_Info.Padding = New System.Windows.Forms.Padding(15, 10, 15, 10)
        Me.Notify_Info.Size = New System.Drawing.Size(69, 41)
        Me.Notify_Info.TabIndex = 1
        Me.Notify_Info.Text = "Info"
        Me.Notify_Info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Expiration
        '
        Me.Expiration.Interval = 1000
        '
        'Notify
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(500, 500)
        Me.Controls.Add(Me.Notify_Info)
        Me.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Notify"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Notify"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents Notify_Info As Label
    Private WithEvents Expiration As Timer
End Class
