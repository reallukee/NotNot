Imports System
Imports System.IO

Public Class Notify

    Sub New(Text As String, Interval As Integer)
        InitializeComponent()

        Notify_Info.Text = Text
        Expiration.Interval = Interval
    End Sub


    Private Sub Notify_Shown(Sender As Object, E As EventArgs) Handles MyBase.Shown
        Expiration.Start()
    End Sub


    Private Sub Expiration_Tick(Sender As Object, E As EventArgs) Handles Expiration.Tick
        If Expiration.Interval <> 50 Then
            Expiration.Interval = 50
        Else
            If Opacity >= 0.1 Then
                Opacity -= 0.05
            Else
                Dispose()
            End If
        End If
    End Sub

End Class