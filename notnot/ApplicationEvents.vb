Imports Microsoft.VisualBasic.ApplicationServices
Imports System.IO

Namespace My
    ' The following events are available for MyApplication:
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.

    ' **NEW** ApplyHighDpiMode: Raised when the application queries the HighDpiMode to set it for the application.

    ' Example:

    ' Private Sub MyApplication_ApplyHighDpiMode(sender As Object, e As ApplyHighDpiModeEventArgs) Handles Me.ApplyHighDpiMode
    '     e.HighDpiMode = HighDpiMode.PerMonitorV2
    ' End Sub

    Partial Friend Class MyApplication

        Private Sub MyApplication_StartupNextInstance(Sender As Object, E As StartupNextInstanceEventArgs) Handles Me.StartupNextInstance
            Dim Viewer As Integer = 1
            Dim Args As String = E.CommandLine(0)

            Try
                Viewer = Char.GetNumericValue(E.CommandLine(1).First)
                Args = Mid(Args, 2)
            Catch
                Viewer = 1
                Args = Args
            End Try

            While NotNot.Viewers.Controls.Count - 1 < Viewer
                Dim ViewerTest As New Viewer3

                With ViewerTest
                    .Name = $"{NotNot.ViewerCount}"
                End With

                NotNot.Viewers.Controls.Add(ViewerTest)
                NotNot.ViewerCount += 1
            End While

            Dim TempViewer As Viewer3 = NotNot.Viewers.Controls(Viewer)

            If TempViewer.Viewers.Contains(TempViewer.RichTextBoxViewer) Then
                TempViewer.Viewers.Controls.Remove(TempViewer.RichTextBoxViewer)
                TempViewer.RichTextBoxViewer.Text = ""
            End If

            If TempViewer.Viewers.Contains(TempViewer.PictureBoxViewer) Then
                TempViewer.Viewers.Controls.Remove(TempViewer.PictureBoxViewer)
                TempViewer.PictureBoxViewer.Image.Dispose()
            End If

            If TempViewer.Viewers.Contains(TempViewer.TextBoxViewer) Then
                TempViewer.Viewers.Controls.Remove(TempViewer.TextBoxViewer)
                TempViewer.TextBoxViewer.Text = ""
            End If

            If Path.GetExtension(Args) = ".rtf" Then
                If TempViewer.OpenRTFFile(Args) = True Then
                    TempViewer.Viewers_Info.Visible = False
                    TempViewer.Viewers_Info.Enabled = False
                End If
            Else
                If TempViewer.OpenImageFile(Args) = False Then
                    If TempViewer.OpenTXTFile(Args) = True Then
                        TempViewer.Viewers_Info.Visible = False
                        TempViewer.Viewers_Info.Enabled = False
                    End If
                Else
                    TempViewer.Viewers_Info.Visible = False
                    TempViewer.Viewers_Info.Enabled = False
                End If
            End If
        End Sub


        Private Sub MyApplication_Startup(Sender As Object, E As StartupEventArgs) Handles Me.Startup
            Dim Viewer As Integer = 1
            Dim Args As String = ""

            If E.CommandLine.Count = 0 Then
                Return
            Else
                Args = E.CommandLine(0)
            End If

            Try
                Viewer = Char.GetNumericValue(E.CommandLine(1).First)
                Args = Mid(Args, 2)
            Catch
                Viewer = 1
                Args = Args
            End Try

            While NotNot.Viewers.Controls.Count - 1 < Viewer
                Dim ViewerTest As New Viewer3

                With ViewerTest
                    .Name = $"{NotNot.ViewerCount}"
                End With

                NotNot.Viewers.Controls.Add(ViewerTest)
                NotNot.ViewerCount += 1
            End While

            Dim TempViewer As Viewer3 = NotNot.Viewers.Controls(Viewer)

            If TempViewer.Viewers.Contains(TempViewer.RichTextBoxViewer) Then
                TempViewer.Viewers.Controls.Remove(TempViewer.RichTextBoxViewer)
                TempViewer.RichTextBoxViewer.Text = ""
            End If

            If TempViewer.Viewers.Contains(TempViewer.PictureBoxViewer) Then
                TempViewer.Viewers.Controls.Remove(TempViewer.PictureBoxViewer)
                TempViewer.PictureBoxViewer.Image.Dispose()
            End If

            If TempViewer.Viewers.Contains(TempViewer.TextBoxViewer) Then
                TempViewer.Viewers.Controls.Remove(TempViewer.TextBoxViewer)
                TempViewer.TextBoxViewer.Text = ""
            End If

            If Path.GetExtension(Args) = ".rtf" Then
                If TempViewer.OpenRTFFile(Args) = True Then
                    TempViewer.Viewers_Info.Visible = False
                    TempViewer.Viewers_Info.Enabled = False
                End If
            Else
                If TempViewer.OpenImageFile(Args) = False Then
                    If TempViewer.OpenTXTFile(Args) = True Then
                        TempViewer.Viewers_Info.Visible = False
                        TempViewer.Viewers_Info.Enabled = False
                    End If
                Else
                    TempViewer.Viewers_Info.Visible = False
                    TempViewer.Viewers_Info.Enabled = False
                End If
            End If
        End Sub

    End Class

End Namespace
