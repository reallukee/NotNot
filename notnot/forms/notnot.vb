Public Class NotNot

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub


    Private FullScreen_ As Boolean
    Public Property FullScreen As Boolean
        Get
            Return FullScreen_
        End Get

        Set(Value As Boolean)
            Select Case (Value)
                Case True
                    FormBorderStyle = FormBorderStyle.None
                    WindowState = FormWindowState.Maximized

                Case False
                    FormBorderStyle = FormBorderStyle.Sizable
                    WindowState = FormWindowState.Normal

            End Select

            FullScreen_ = Value
        End Set
    End Property

    Public Shared ViewerCount As Integer = 1
    Dim Old_Opacity As Double
    Dim Old_Size As Size
    Dim Old_TopMost As Boolean
    Dim Old_FullScreen As Boolean
    Dim Old_Location As Point

    Public Sub SetTheme(Theme As Integer)
        Select Case Theme
            Case 0
                Dim Color1 As Color = Color.FromArgb(255, 215, 150)
                Dim Color2 As Color = Color.FromArgb(255, 225, 175)
                Dim Color3 As Color = Color.FromArgb(255, 235, 200)
                Dim Color4 As Color = Color.FromArgb(255, 245, 225)

            Case Else
                Return

        End Select
    End Sub


    Private Sub NotNot_Load(Sender As Object, E As EventArgs) Handles MyBase.Load
        Dim ViewerTest As New Viewer3

        With ViewerTest
            .Name = $"{ViewerCount}"
        End With

        Viewers.Controls.Add(ViewerTest)
        ViewerCount += 1
    End Sub


    Private Sub Action_Menu_AddViewer_Click(Sender As Object, E As EventArgs) Handles Action_Menu_AddViewer.Click
        Dim ViewerTest As New Viewer3

        With ViewerTest
            .Name = $"{ViewerCount}"
        End With

        Viewers.Controls.Add(ViewerTest)
        ViewerCount += 1
    End Sub


    Private Sub Viewers_Info_DoubleClick(Sender As Object, E As EventArgs) Handles Viewers_Info.DoubleClick
        Dim ViewerTest As New Viewer3

        With ViewerTest
            .Name = $"{ViewerCount}"
        End With

        Viewers.Controls.Add(ViewerTest)
        ViewerCount += 1
    End Sub


    Private Sub Action_Menu_FitSize_Click(Sender As Object, E As EventArgs)
        Size = MinimumSize
        CenterToScreen()
    End Sub


    Private Sub Viewers_ControlAdded(Sender As Object, E As ControlEventArgs) Handles Viewers.ControlAdded
        If Viewers.Controls.Count > 0 Then
            If Viewers.Controls.Count > 1 Then
                Viewers_Info.Visible = False
                Viewers_Info.Enabled = False
                Info_Panel.Visible = False
            End If

            If Viewers.Controls.Count = 7 Then
                Action_Menu_AddViewer.Enabled = False
            End If
        Else
            Return
        End If

        Dim W As Integer = Viewers.Width
        Dim H As Integer = Viewers.Height
        Dim FW As Integer = 0
        Dim FH As Integer = 0

        Select Case Viewers.Controls.Count
            Case 2
                Viewers.Controls(1).Size = New Size(W, H)
                Viewers.Controls(1).Location = New Point(0, 0)
                MinimumSize = New Size(550, 550)

                If TypeOf Viewers.Controls(1) Is Viewer3 Then
                    Dim Temp As Viewer3 = Viewers.Controls(1)
                    Temp.Separator_X.Visible = False
                    Temp.Separator_Y.Visible = False
                End If

            Case 3
                For I As Integer = 1 To Viewers.Controls.Count - 1
                    Dim Temp As Viewer3 = Viewers.Controls(I)
                    Viewers.Controls(I).Size = New Size(W / 2, H)
                    Viewers.Controls(I).Location = New Point(FW, 0)
                    FW += W / 2

                    If I = 2 Then
                        Temp.Separator_Y.Visible = False
                        Temp.Separator_X.Visible = False
                    Else
                        Temp.Separator_Y.Visible = True
                        Temp.Separator_X.Visible = False
                    End If
                Next

                MinimumSize = New Size(1100, 650)

            Case 4
                For I As Integer = 1 To Viewers.Controls.Count - 1
                    Dim Temp As Viewer3 = Viewers.Controls(I)
                    Viewers.Controls(I).Size = New Size(W / 3, H)
                    Viewers.Controls(I).Location = New Point(FW, 0)
                    FW += W / 3

                    If I = 3 Then
                        Temp.Separator_Y.Visible = False
                        Temp.Separator_X.Visible = False
                    Else
                        Temp.Separator_Y.Visible = True
                        Temp.Separator_X.Visible = False
                    End If
                Next

                MinimumSize = New Size(1650, 875)

            Case 5
                For I As Integer = 1 To Viewers.Controls.Count - 1
                    Dim Temp As Viewer3 = Viewers.Controls(I)
                    Viewers.Controls(I).Size = New Size(W / 2, H / 2)
                    Viewers.Controls(I).Location = New Point(FW, FH)
                    FW += W / 2

                    If I = 2 Then
                        FW = 0
                        FH += H / 2
                    End If

                    Select Case I
                        Case 1
                            Temp.Separator_Y.Visible = True
                            Temp.Separator_X.Visible = True

                        Case 2
                            Temp.Separator_Y.Visible = False
                            Temp.Separator_X.Visible = True

                        Case 3
                            Temp.Separator_Y.Visible = True
                            Temp.Separator_X.Visible = False

                        Case 4
                            Temp.Separator_Y.Visible = False
                            Temp.Separator_X.Visible = False

                    End Select
                Next

                MinimumSize = New Size(1650, 900)

            Case 6
                For I As Integer = 1 To Viewers.Controls.Count - 1
                    Dim Temp As Viewer3 = Viewers.Controls(I)
                    Viewers.Controls(I).Size = New Size(W / 3, H / 2)
                    Viewers.Controls(I).Location = New Point(FW, FH)
                    FW += W / 3

                    If I = 3 Then
                        Temp.Separator_Y.Visible = False
                        Temp.Separator_X.Visible = True
                    Else
                        Temp.Separator_Y.Visible = True
                        Temp.Separator_X.Visible = True
                    End If
                Next

                FH += H / 2
                FW = 0

                For I As Integer = 4 To Viewers.Controls.Count - 1
                    Dim Temp As Viewer3 = Viewers.Controls(I)
                    Viewers.Controls(I).Size = New Size(W / 2, H / 2)
                    Viewers.Controls(I).Location = New Point(FW, FH)
                    FW += W / 2

                    If I = 5 Then
                        Temp.Separator_Y.Visible = False
                        Temp.Separator_X.Visible = False
                    Else
                        Temp.Separator_Y.Visible = True
                        Temp.Separator_X.Visible = False
                    End If
                Next

                MinimumSize = New Size(1650, 900)

            Case 7
                For I As Integer = 1 To Viewers.Controls.Count - 1
                    Dim Temp As Viewer3 = Viewers.Controls(I)
                    Viewers.Controls(I).Size = New Size(W / 3, H / 2)
                    Viewers.Controls(I).Location = New Point(FW, FH)
                    FW += W / 3

                    If I = 3 Then
                        FW = 0
                        FH += H / 2
                    End If

                    Select Case I
                        Case 1
                            Temp.Separator_Y.Visible = True
                            Temp.Separator_X.Visible = True

                        Case 2
                            Temp.Separator_Y.Visible = True
                            Temp.Separator_X.Visible = True

                        Case 3
                            Temp.Separator_Y.Visible = False
                            Temp.Separator_X.Visible = True

                        Case 4
                            Temp.Separator_Y.Visible = True
                            Temp.Separator_X.Visible = False

                        Case 5
                            Temp.Separator_Y.Visible = True
                            Temp.Separator_X.Visible = False

                        Case 6
                            Temp.Separator_Y.Visible = False
                            Temp.Separator_X.Visible = False

                    End Select
                Next

                MinimumSize = New Size(1650, 900)

        End Select

        ViewerCount = 1

        For I As Integer = 1 To Viewers.Controls.Count - 1
            Viewers.Controls(I).Name = $"{ViewerCount}"
            ViewerCount += 1
        Next
    End Sub


    Private Sub Viewers_ControlRemoved(Sender As Object, E As ControlEventArgs) Handles Viewers.ControlRemoved
        If Viewers.Controls.Count > 0 Then
            If Viewers.Controls.Count = 1 Then
                Viewers_Info.Visible = True
                Viewers_Info.Enabled = True
                Info_Panel.Visible = True
            End If

            If Viewers.Controls.Count < 7 Then
                Action_Menu_AddViewer.Enabled = True
            End If
        Else
            Return
        End If

        Dim W As Integer = Viewers.Width
        Dim H As Integer = Viewers.Height
        Dim FW As Integer = 0
        Dim FH As Integer = 0

        Select Case Viewers.Controls.Count
            Case 2
                Viewers.Controls(1).Size = New Size(W, H)
                Viewers.Controls(1).Location = New Point(0, 0)
                MinimumSize = New Size(550, 550)

                If TypeOf Viewers.Controls(1) Is Viewer3 Then
                    Dim Temp As Viewer3 = Viewers.Controls(1)
                    Temp.Separator_X.Visible = False
                    Temp.Separator_Y.Visible = False
                End If

            Case 3
                For I As Integer = 1 To Viewers.Controls.Count - 1
                    Dim Temp As Viewer3 = Viewers.Controls(I)
                    Viewers.Controls(I).Size = New Size(W / 2, H)
                    Viewers.Controls(I).Location = New Point(FW, 0)
                    FW += W / 2

                    If I = 2 Then
                        Temp.Separator_Y.Visible = False
                        Temp.Separator_X.Visible = False
                    Else
                        Temp.Separator_Y.Visible = True
                        Temp.Separator_X.Visible = False
                    End If
                Next

                MinimumSize = New Size(1100, 650)

            Case 4
                For I As Integer = 1 To Viewers.Controls.Count - 1
                    Dim Temp As Viewer3 = Viewers.Controls(I)
                    Viewers.Controls(I).Size = New Size(W / 3, H)
                    Viewers.Controls(I).Location = New Point(FW, 0)
                    FW += W / 3

                    If I = 3 Then
                        Temp.Separator_Y.Visible = False
                        Temp.Separator_X.Visible = False
                    Else
                        Temp.Separator_Y.Visible = True
                        Temp.Separator_X.Visible = False
                    End If
                Next

                MinimumSize = New Size(1650, 875)

            Case 5
                For I As Integer = 1 To Viewers.Controls.Count - 1
                    Dim Temp As Viewer3 = Viewers.Controls(I)
                    Viewers.Controls(I).Size = New Size(W / 2, H / 2)
                    Viewers.Controls(I).Location = New Point(FW, FH)
                    FW += W / 2

                    If I = 2 Then
                        FW = 0
                        FH += H / 2
                    End If

                    Select Case I
                        Case 1
                            Temp.Separator_Y.Visible = True
                            Temp.Separator_X.Visible = True

                        Case 2
                            Temp.Separator_Y.Visible = False
                            Temp.Separator_X.Visible = True

                        Case 3
                            Temp.Separator_Y.Visible = True
                            Temp.Separator_X.Visible = False

                        Case 4
                            Temp.Separator_Y.Visible = False
                            Temp.Separator_X.Visible = False

                    End Select
                Next

                MinimumSize = New Size(1650, 900)

            Case 6
                For I As Integer = 1 To Viewers.Controls.Count - 1
                    Dim Temp As Viewer3 = Viewers.Controls(I)
                    Viewers.Controls(I).Size = New Size(W / 3, H / 2)
                    Viewers.Controls(I).Location = New Point(FW, FH)
                    FW += W / 3

                    If I = 3 Then
                        Temp.Separator_Y.Visible = False
                        Temp.Separator_X.Visible = True
                    Else
                        Temp.Separator_Y.Visible = True
                        Temp.Separator_X.Visible = True
                    End If
                Next

                FH += H / 2
                FW = 0

                For I As Integer = 4 To Viewers.Controls.Count - 1
                    Dim Temp As Viewer3 = Viewers.Controls(I)
                    Viewers.Controls(I).Size = New Size(W / 2, H / 2)
                    Viewers.Controls(I).Location = New Point(FW, FH)
                    FW += W / 2

                    If I = 5 Then
                        Temp.Separator_Y.Visible = False
                        Temp.Separator_X.Visible = False
                    Else
                        Temp.Separator_Y.Visible = True
                        Temp.Separator_X.Visible = False
                    End If
                Next

                MinimumSize = New Size(1650, 900)

            Case 7
                For I As Integer = 1 To Viewers.Controls.Count - 1
                    Dim Temp As Viewer3 = Viewers.Controls(I)
                    Viewers.Controls(I).Size = New Size(W / 3, H / 2)
                    Viewers.Controls(I).Location = New Point(FW, FH)
                    FW += W / 3

                    If I = 3 Then
                        FW = 0
                        FH += H / 2
                    End If

                    Select Case I
                        Case 1
                            Temp.Separator_Y.Visible = True
                            Temp.Separator_X.Visible = True

                        Case 2
                            Temp.Separator_Y.Visible = True
                            Temp.Separator_X.Visible = True

                        Case 3
                            Temp.Separator_Y.Visible = False
                            Temp.Separator_X.Visible = True

                        Case 4
                            Temp.Separator_Y.Visible = True
                            Temp.Separator_X.Visible = False

                        Case 5
                            Temp.Separator_Y.Visible = True
                            Temp.Separator_X.Visible = False

                        Case 6
                            Temp.Separator_Y.Visible = False
                            Temp.Separator_X.Visible = False

                    End Select
                Next

                MinimumSize = New Size(1650, 900)

        End Select

        ViewerCount = 1

        For I As Integer = 1 To Viewers.Controls.Count - 1
            Viewers.Controls(I).Name = $"{ViewerCount}"
            ViewerCount += 1
        Next
    End Sub


    Private Sub NotNot_Resize(Sender As Object, E As EventArgs) Handles MyBase.Resize
        Dim W As Integer = Viewers.Width
        Dim H As Integer = Viewers.Height
        Dim FW As Integer = 0
        Dim FH As Integer = 0

        Select Case Viewers.Controls.Count
            Case 2
                Viewers.Controls(1).Size = New Size(W, H)
                Viewers.Controls(1).Location = New Point(0, 0)

                If SquareMode_Panel.Visible = False Then
                    MinimumSize = New Size(550, 550)
                End If

            Case 3
                For I As Integer = 1 To Viewers.Controls.Count - 1
                    Viewers.Controls(I).Size = New Size(W / 2, H)
                    Viewers.Controls(I).Location = New Point(FW, 0)
                    FW += W / 2
                Next

                If SquareMode_Panel.Visible = False Then
                    MinimumSize = New Size(1100, 650)
                End If

            Case 4
                For I As Integer = 1 To Viewers.Controls.Count - 1
                    Viewers.Controls(I).Size = New Size(W / 3, H)
                    Viewers.Controls(I).Location = New Point(FW, 0)
                    FW += W / 3
                Next

                If SquareMode_Panel.Visible = False Then
                    MinimumSize = New Size(1650, 875)
                End If

            Case 5
                For I As Integer = 1 To Viewers.Controls.Count - 1
                    Viewers.Controls(I).Size = New Size(W / 2, H / 2)
                    Viewers.Controls(I).Location = New Point(FW, FH)
                    FW += W / 2

                    If I = 2 Then
                        FW = 0
                        FH += H / 2
                    End If
                Next

                If SquareMode_Panel.Visible = False Then
                    MinimumSize = New Size(1650, 900)
                End If

            Case 6
                For I As Integer = 1 To Viewers.Controls.Count - 1
                    Viewers.Controls(I).Size = New Size(W / 3, H / 2)
                    Viewers.Controls(I).Location = New Point(FW, FH)
                    FW += W / 3
                Next

                FH += H / 2
                FW = 0

                For I As Integer = 4 To Viewers.Controls.Count - 1
                    Viewers.Controls(I).Size = New Size(W / 2, H / 2)
                    Viewers.Controls(I).Location = New Point(FW, FH)
                    FW += W / 2
                Next

                If SquareMode_Panel.Visible = False Then
                    MinimumSize = New Size(1650, 900)
                End If

            Case 7
                For I As Integer = 1 To Viewers.Controls.Count - 1
                    Viewers.Controls(I).Size = New Size(W / 3, H / 2)
                    Viewers.Controls(I).Location = New Point(FW, FH)
                    FW += W / 3

                    If I = 3 Then
                        FW = 0
                        FH += H / 2
                    End If
                Next

                If SquareMode_Panel.Visible = False Then
                    MinimumSize = New Size(1650, 900)
                End If

        End Select
    End Sub


    Private Sub Expf_CenterOnScreen_Click(Sender As Object, E As EventArgs) Handles Expf_CenterOnScreen.Click
        CenterToScreen()
    End Sub


    Private Sub Expf_BetterSize_Click(Sender As Object, E As EventArgs) Handles Expf_BetterSize.Click
        Size = MinimumSize
    End Sub


    Private Sub Action_Menu_SquareMode_Click(sender As Object, e As EventArgs) Handles Action_Menu_SquareMode.Click
        Old_Opacity = Opacity
        Old_Size = Size
        Old_TopMost = TopMost
        Old_FullScreen = FullScreen
        Old_Location = Location

        For Each C As Control In Controls
            If C.Name = "SquareMode_Panel" Then
                C.Visible = True
                C.Enabled = True
            Else
                C.Visible = False
                C.Enabled = False
            End If
        Next

        MaximumSize = New Size(168, 167)
        MinimumSize = New Size(168, 167)
        Size = New Size(1, 1)
        Location = New Point(16, 16)
        SquareMode_Panel.Dock = DockStyle.Fill
        TopMost = True
        MaximizeBox = False
        MinimizeBox = False
        ShowInTaskbar = False
        Opacity = 0.5
        FullScreen = False

        For Each F As Form In Application.OpenForms
            If F.Name = "Notify" Then
                F.Dispose()
                Exit For
            End If
        Next

        Dim NewNotify As Form = New Notify($"Square Mode: Enabled", 500)
        NewNotify.Name = "Notify"
        Dim R As Rectangle = Screen.PrimaryScreen.Bounds
        NewNotify.Location = New Point(R.Width - NewNotify.Width - 16, R.Height - NewNotify.Height - 16)
        NewNotify.Opacity = 1.0F
        NewNotify.Show()
    End Sub


    Private Sub SquareMode_Menu_Disable_Click(Sender As Object, E As EventArgs) Handles SquareMode_Menu_Disable.Click
        For Each C As Control In Controls
            If C.Name = "SquareMode_Panel" Then
                C.Visible = False
                C.Enabled = False
            Else
                If C.Name = "Info_Panel" And Viewers.Controls.Count > 1 Then
                    C.Visible = False
                    C.Enabled = False
                Else
                    C.Visible = True
                    C.Enabled = True
                End If
            End If
        Next

        MaximumSize = New Size(0, 0)
        MinimumSize = New Size(0, 0)
        Size = Old_Size
        Location = Old_Location
        SquareMode_Panel.Dock = DockStyle.None
        TopMost = Old_TopMost
        MaximizeBox = True
        MinimizeBox = True
        ShowInTaskbar = True
        Opacity = Old_Opacity
        FullScreen = Old_FullScreen

        For Each F As Form In Application.OpenForms
            If F.Name = "Notify" Then
                F.Dispose()
                Exit For
            End If
        Next

        Dim NewNotify As Form = New Notify($"Square Mode: Disabled", 500)
        NewNotify.Name = "Notify"
        Dim R As Rectangle = Screen.PrimaryScreen.Bounds
        NewNotify.Location = New Point(R.Width - NewNotify.Width - 16, R.Height - NewNotify.Height - 16)
        NewNotify.Opacity = 1.0F
        NewNotify.Show()
    End Sub


    Private Sub Action_Menu_MoreOpacity_Click(Sender As Object, E As EventArgs) Handles Action_Menu_MoreOpacity.Click
        If Opacity < 1.0 Then
            If Action_Menu_LessOpacity.Enabled = False Then
                Action_Menu_LessOpacity.Enabled = True
            End If

            For Each F As Form In Application.OpenForms
                If F.Name = "Notify" Then
                    F.Dispose()
                    Exit For
                End If
            Next

            Opacity += 0.1
            Dim NewNotify As Form = New Notify($"Opacity: {Math.Round(Opacity * 10)}0%", 500)
            NewNotify.Name = "Notify"
            Dim R As Rectangle = Screen.PrimaryScreen.Bounds
            NewNotify.Location = New Point(R.Width - NewNotify.Width - 16, R.Height - NewNotify.Height - 16)
            NewNotify.Opacity = Opacity
            NewNotify.Show()

            If Opacity >= 1.0 Then
                Action_Menu_MoreOpacity.Enabled = False
            End If
        End If
    End Sub


    Private Sub Action_Menu_LessOpacity_Click(Sender As Object, E As EventArgs) Handles Action_Menu_LessOpacity.Click
        If Opacity > 0.3 Then
            If Action_Menu_MoreOpacity.Enabled = False Then
                Action_Menu_MoreOpacity.Enabled = True
            End If

            For Each F As Form In Application.OpenForms
                If F.Name = "Notify" Then
                    F.Dispose()
                    Exit For
                End If
            Next

            Opacity -= 0.1
            Dim NewNotify As Form = New Notify($"Opacity: {Math.Round(Opacity * 10)}0%", 500)
            NewNotify.Name = "Notify"
            Dim R As Rectangle = Screen.PrimaryScreen.Bounds
            NewNotify.Location = New Point(R.Width - NewNotify.Width - 16, R.Height - NewNotify.Height - 16)
            NewNotify.Opacity = Opacity
            NewNotify.Show()

            If Opacity <= 0.3 Then
                Action_Menu_LessOpacity.Enabled = False
            End If
        End If
    End Sub


    Private Sub Action_Menu_FullScreen_Click(Sender As Object, E As EventArgs) Handles Action_Menu_FullScreen.Click
        If FullScreen = True Then
            Action_Menu_FullScreen.Text = ""
            FullScreen = False
        Else
            Action_Menu_FullScreen.Text = ""
            FullScreen = True
        End If

        For Each F As Form In Application.OpenForms
            If F.Name = "Notify" Then
                F.Dispose()
                Exit For
            End If
        Next

        Dim NewNotify As Form = New Notify($"Full screen: {FullScreen.ToString().ToUpper()}", 500)
        NewNotify.Name = "Notification"
        Dim R As Rectangle = Screen.PrimaryScreen.Bounds
        NewNotify.Location = New Point(R.Width - NewNotify.Width - 16, R.Height - NewNotify.Height - 16)
        NewNotify.Opacity = Opacity
        NewNotify.Show()
    End Sub


    Private Sub Action_Menu_AlwaysOnTop_Click(Sender As Object, E As EventArgs) Handles Action_Menu_AlwaysOnTop.Click
        If TopMost = True Then
            Action_Menu_AlwaysOnTop.Text = ""
            TopMost = False
        Else
            Action_Menu_AlwaysOnTop.Text = ""
            TopMost = True
        End If

        For Each F As Form In Application.OpenForms
            If F.Name = "Notify" Then
                F.Dispose()
                Exit For
            End If
        Next

        Dim NewNotify As Form = New Notify($"Always on top: {TopMost.ToString().ToUpper()}", 500)
        NewNotify.Name = "Notification"
        Dim R As Rectangle = Screen.PrimaryScreen.Bounds
        NewNotify.Location = New Point(R.Width - NewNotify.Width - 16, R.Height - NewNotify.Height - 16)
        NewNotify.Opacity = Opacity
        NewNotify.Show()
    End Sub


    Private Sub NotNot_FormClosing(Sender As Object, E As FormClosingEventArgs) Handles MyBase.FormClosing
        If SquareMode_Panel.Visible = True Then
            For Each C As Control In Controls
                If C.Name = "SquareMode_Panel" Then
                    C.Visible = False
                    C.Enabled = False
                Else
                    If C.Name = "Info_Panel" And Viewers.Controls.Count > 1 Then
                        C.Visible = False
                        C.Enabled = False
                    Else
                        C.Visible = True
                        C.Enabled = True
                    End If
                End If
            Next

            MaximumSize = New Size(0, 0)
            MinimumSize = New Size(0, 0)
            Size = Old_Size
            Location = Old_Location
            SquareMode_Panel.Dock = DockStyle.None
            TopMost = Old_TopMost
            MaximizeBox = True
            MinimizeBox = True
            ShowInTaskbar = True
            Opacity = Old_Opacity
            FullScreen = Old_FullScreen

            For Each F As Form In Application.OpenForms
                If F.Name = "Notify" Then
                    F.Dispose()
                    Exit For
                End If
            Next

            Dim NewNotify As Form = New Notify($"NotNot is running in background", 500)
            NewNotify.Name = "Notify"
            Dim R As Rectangle = Screen.PrimaryScreen.Bounds
            NewNotify.Location = New Point(R.Width - NewNotify.Width - 16, R.Height - NewNotify.Height - 16)
            NewNotify.Opacity = Opacity
            NewNotify.Show()
        Else
            Hide()
        End If

        E.Cancel = True
    End Sub


    Private Sub Expf_SuperExit_Click(Sender As Object, E As EventArgs) Handles Expf_SuperExit.Click
        End
    End Sub


    Private Sub CMenu_SquareMode_Click(Sender As Object, E As EventArgs) Handles CMenu_SquareMode.Click
        If SquareMode_Panel.Visible = False Then
            Old_Opacity = Opacity
            Old_Size = Size
            Old_TopMost = TopMost
            Old_FullScreen = FullScreen
            Old_Location = Location

            For Each C As Control In Controls
                If C.Name = "SquareMode_Panel" Then
                    C.Visible = True
                    C.Enabled = True
                Else
                    C.Visible = False
                    C.Enabled = False
                End If
            Next

            MaximumSize = New Size(168, 167)
            MinimumSize = New Size(168, 167)
            Size = New Size(1, 1)
            Location = New Point(16, 16)
            SquareMode_Panel.Dock = DockStyle.Fill
            TopMost = True
            MaximizeBox = False
            MinimizeBox = False
            ShowInTaskbar = False
            Opacity = 0.5
            FullScreen = False

            For Each F As Form In Application.OpenForms
                If F.Name = "Notify" Then
                    F.Dispose()
                    Exit For
                End If
            Next

            Dim NewNotify As Form = New Notify($"Square Mode: Enabled", 500)
            NewNotify.Name = "Notify"
            Dim R As Rectangle = Screen.PrimaryScreen.Bounds
            NewNotify.Location = New Point(R.Width - NewNotify.Width - 16, R.Height - NewNotify.Height - 16)
            NewNotify.Opacity = 1.0F
            NewNotify.Show()
        Else
            For Each C As Control In Controls
                If C.Name = "SquareMode_Panel" Then
                    C.Visible = False
                    C.Enabled = False
                Else
                    If C.Name = "Info_Panel" And Viewers.Controls.Count > 1 Then
                        C.Visible = False
                        C.Enabled = False
                    Else
                        C.Visible = True
                        C.Enabled = True
                    End If
                End If
            Next

            MaximumSize = New Size(0, 0)
            MinimumSize = New Size(0, 0)
            Size = Old_Size
            Location = Old_Location
            SquareMode_Panel.Dock = DockStyle.None
            TopMost = Old_TopMost
            MaximizeBox = True
            MinimizeBox = True
            ShowInTaskbar = True
            Opacity = Old_Opacity
            FullScreen = Old_FullScreen

            For Each F As Form In Application.OpenForms
                If F.Name = "Notify" Then
                    F.Dispose()
                    Exit For
                End If
            Next

            Dim NewNotify As Form = New Notify($"Square Mode: Disabled", 500)
            NewNotify.Name = "Notify"
            Dim R As Rectangle = Screen.PrimaryScreen.Bounds
            NewNotify.Location = New Point(R.Width - NewNotify.Width - 16, R.Height - NewNotify.Height - 16)
            NewNotify.Opacity = 1.0F
            NewNotify.Show()
        End If
    End Sub


    Private Sub CMenu_ShowHide_Click(Sender As Object, E As EventArgs) Handles CMenu_ShowHide.Click
        Visible = Not Visible
    End Sub


    Private Sub CMenu_Close_Click(Sender As Object, E As EventArgs) Handles CMenu_Close.Click
        End
    End Sub

End Class
