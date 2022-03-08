Imports System.IO

Public Class Viewer3

    Public WithEvents TextBoxViewer As New TextBox
    Public WithEvents RichTextBoxViewer As New RichTextBox
    Public WithEvents PictureBoxViewer As New PictureBox
    Public BackText As String

    Public Class TextBox
        Inherits Windows.Forms.TextBox

        Private Edit_ As Boolean
        Public Property Edit As Boolean
            Get
                Return Edit_
            End Get

            Set(Value As Boolean)
                Edit_ = Value
            End Set
        End Property

        Private FileName_ As String
        Public Property FileName As String
            Get
                Return FileName_
            End Get

            Set(Value As String)
                FileName_ = Value
            End Set
        End Property

        Private Exists_ As Boolean
        Public Property Exists As Boolean
            Get
                Return Exists_
            End Get

            Set(Value As Boolean)
                Exists_ = Value
            End Set
        End Property

    End Class


    Public Class RichTextBox
        Inherits Windows.Forms.RichTextBox

        Private Edit_ As Boolean
        Public Property Edit As Boolean
            Get
                Return Edit_
            End Get

            Set(Value As Boolean)
                Edit_ = Value
            End Set
        End Property

        Private FileName_ As String
        Public Property FileName As String
            Get
                Return FileName_
            End Get

            Set(Value As String)
                FileName_ = Value
            End Set
        End Property

        Private Exists_ As Boolean
        Public Property Exists As Boolean
            Get
                Return Exists_
            End Get

            Set(Value As Boolean)
                Exists_ = Value
            End Set
        End Property
    End Class


    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub


    Private Sub Action_Menu_Close_Click(Sender As Object, E As EventArgs) Handles Action_Menu_Close.Click
        Dispose()
    End Sub


    Public Sub New()
        InitializeComponent()

        With RichTextBoxViewer
            .Dock = DockStyle.Fill
            .Multiline = True
            .Font = New Font("Tahoma", 11.0F)
            .ForeColor = Color.Black
            .BackColor = Color.White
            .ScrollBars = RichTextBoxScrollBars.ForcedVertical
            .BorderStyle = BorderStyle.None
            .AllowDrop = True
            .ContextMenuStrip = CMenu

            AddHandler RichTextBoxViewer.MouseHover, AddressOf RichTextBoxViewer_MouseHover
        End With

        With PictureBoxViewer
            .Dock = DockStyle.Fill
            .ForeColor = Color.Black
            .BackColor = Color.White
            .BorderStyle = BorderStyle.None
            .SizeMode = PictureBoxSizeMode.Zoom
            .AllowDrop = True

            AddHandler PictureBoxViewer.MouseHover, AddressOf PictureBoxViewer_MouseHover
        End With

        With TextBoxViewer
            .Dock = DockStyle.Fill
            .Multiline = True
            .Font = New Font("Tahoma", 11.0F)
            .ForeColor = Color.Black
            .BackColor = Color.White
            .ScrollBars = ScrollBars.Vertical
            .BorderStyle = BorderStyle.None
            .AllowDrop = True
            .ContextMenuStrip = CMenu

            AddHandler TextBoxViewer.MouseHover, AddressOf TextBoxViewer_MouseHover
        End With

        Viewers.Controls.Add(TextBoxViewer)
        ActiveControl = TextBoxViewer
        Viewers_Info.Visible = False
        Viewers_Info.Enabled = False
    End Sub


    Private Sub RichTextBoxViewer_MouseHover(Sender As Object, E As EventArgs) Handles RichTextBoxViewer.MouseHover
        ' NotNot.Text = Name
    End Sub


    Private Sub PictureBoxViewer_MouseHover(Sender As Object, E As EventArgs) Handles PictureBoxViewer.MouseHover
        ' NotNot.Text = Name
    End Sub


    Private Sub TextBoxViewer_MouseHover(Sender As Object, E As EventArgs) Handles TextBoxViewer.MouseHover
        ' NotNot.Text = Name
    End Sub


    Public Function OpenRTFFile(FileName As String)
        If Viewers.Contains(RichTextBoxViewer) = False Then
            If Viewers.Contains(PictureBoxViewer) Then
                Viewers.Controls.Remove(PictureBoxViewer)
                PictureBoxViewer.Image.Dispose()
            End If

            If Viewers.Contains(TextBoxViewer) Then
                Viewers.Controls.Remove(TextBoxViewer)
                TextBoxViewer.Text = ""
            End If
        End If

        Try
            RichTextBoxViewer.LoadFile(FileName)
            Viewers.Controls.Add(RichTextBoxViewer)
            ActiveControl = RichTextBoxViewer
            BackText = RichTextBoxViewer.Text
        Catch
            Return False
        End Try

        Return True
    End Function


    Public Function OpenTXTFile(FileName As String)
        If Viewers.Contains(TextBoxViewer) = False Then
            If Viewers.Contains(RichTextBoxViewer) Then
                Viewers.Controls.Remove(RichTextBoxViewer)
                RichTextBoxViewer.Text = ""
            End If

            If Viewers.Contains(PictureBoxViewer) Then
                Viewers.Controls.Remove(PictureBoxViewer)
                PictureBoxViewer.Image.Dispose()
            End If
        End If

        Try
            TextBoxViewer.Text = File.ReadAllText(FileName)
            Viewers.Controls.Add(TextBoxViewer)
            ActiveControl = TextBoxViewer
            BackText = TextBoxViewer.Text
        Catch
            Return False
        End Try

        Return True
    End Function


    Public Function OpenImageFile(FileName As String)
        If Viewers.Contains(PictureBoxViewer) = False Then
            If Viewers.Contains(RichTextBoxViewer) Then
                Viewers.Controls.Remove(RichTextBoxViewer)
                RichTextBoxViewer.Text = ""
            End If

            If Viewers.Contains(TextBoxViewer) Then
                Viewers.Controls.Remove(TextBoxViewer)
                TextBoxViewer.Text = ""
            End If
        End If

        Try
            PictureBoxViewer.Image = Image.FromFile(FileName)
            Viewers.Controls.Add(PictureBoxViewer)
            ActiveControl = PictureBoxViewer
        Catch
            Return False
        End Try

        Return True
    End Function


    Private Sub Action_Menu_Open_Click(sender As Object, e As EventArgs) Handles Action_Menu_Open.Click
        If Ofd.ShowDialog() = DialogResult.OK Then
            If Path.GetExtension(Ofd.FileName) = ".rtf" Then
                If OpenRTFFile(Ofd.FileName) = True Then
                    Viewers_Info.Visible = False
                    Viewers_Info.Enabled = False
                End If
            Else
                If OpenImageFile(Ofd.FileName) = False Then
                    If OpenTXTFile(Ofd.FileName) = True Then
                        Viewers_Info.Visible = False
                        Viewers_Info.Enabled = False
                    End If
                Else
                    Viewers_Info.Visible = False
                    Viewers_Info.Enabled = False
                End If
            End If
        End If
    End Sub


    Private Sub Action_Menu_Save_Click(Sender As Object, E As EventArgs) Handles Action_Menu_Save.Click
        If Sfd.ShowDialog() = DialogResult.OK Then
            If Viewers.Contains(RichTextBoxViewer) Then
                Try
                    RichTextBoxViewer.SaveFile(Sfd.FileName)
                Catch
                    Return
                End Try
            End If

            If Viewers.Contains(TextBoxViewer) Then
                Try
                    File.WriteAllText(Sfd.FileName, TextBoxViewer.Text)
                Catch
                    Return
                End Try
            End If
        End If
    End Sub


    Private Sub Action_Menu_New_Click(Sender As Object, E As EventArgs) Handles Action_Menu_New.Click
        If Viewers.Contains(TextBoxViewer) = False Then
            If Viewers.Contains(RichTextBoxViewer) Then
                Viewers.Controls.Remove(RichTextBoxViewer)
                RichTextBoxViewer.Text = ""
            End If

            If Viewers.Contains(PictureBoxViewer) Then
                Viewers.Controls.Remove(PictureBoxViewer)
                PictureBoxViewer.Image.Dispose()
            End If

            Viewers.Controls.Add(TextBoxViewer)
            ActiveControl = TextBoxViewer
            Viewers_Info.Visible = False
            Viewers_Info.Enabled = False
        Else
            TextBoxViewer.Text = ""
        End If
    End Sub


    Private Sub Viewers_Info_DoubleClick(Sender As Object, E As EventArgs) Handles Viewers_Info.DoubleClick
        If Viewers.Contains(TextBoxViewer) = False Then
            If Viewers.Contains(RichTextBoxViewer) Then
                Viewers.Controls.Remove(RichTextBoxViewer)
                RichTextBoxViewer.Text = ""
            End If

            If Viewers.Contains(PictureBoxViewer) Then
                Viewers.Controls.Remove(PictureBoxViewer)
                PictureBoxViewer.Image.Dispose()
            End If

            Viewers.Controls.Add(TextBoxViewer)
            ActiveControl = TextBoxViewer
            Viewers_Info.Visible = False
            Viewers_Info.Enabled = False
        Else
            TextBoxViewer.Text = ""
        End If
    End Sub


    Private Sub Action_Menu_Clear_Click(Sender As Object, E As EventArgs) Handles Action_Menu_Clear.Click
        For Each C As Control In Viewers.Controls
            If TypeOf C IsNot Label Then
                Viewers.Controls.Remove(C)
            End If
        Next

        Viewers_Info.Visible = True
        Viewers_Info.Enabled = True
    End Sub


    Private Sub CMenu_Opened(Sender As Object, E As EventArgs) Handles CMenu.Opened
        If TypeOf CMenu.SourceControl Is TextBox Then
            CMenu_Redo.Visible = False
        Else
            CMenu_Redo.Visible = True
        End If
    End Sub

End Class
