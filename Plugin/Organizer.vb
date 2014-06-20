
Public Class Organizer

    Implements Versidyne.Plugins.Plugin

    Private ObjHost As Versidyne.Plugins.Host

    Public Sub Initialize(ByVal Host As Versidyne.Plugins.Host) Implements Versidyne.Plugins.Plugin.Initialize

        ObjHost = Host

    End Sub

    Public ReadOnly Property Title() As String Implements Versidyne.Plugins.Plugin.Title

        Get

            Return "Organizer"

        End Get

    End Property

    Public Function Main(ByVal Args As Array) As Integer Implements Versidyne.Plugins.Plugin.Main

        Dim Loc As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)

        Organize(Loc, "\Downloads\")
        Organize(Loc, "\Programs\")
        Organize(Loc, "\Misc\")

        ObjHost.ShowFeedback("Organizer ran successfully.")

        Return 0

    End Function

    Private Sub Organize(ByVal Loc As String, ByVal Dir As String)

        Dim Files As String() = IO.Directory.GetFiles(Loc & Dir)
        Dim File As String
        Dim FileDir As String
        Dim FileName As String
        Dim FileExt As String
        Dim MoveFile As Boolean

        Try

            For Each File In Files

                FileDir = vbNull
                FileExt = vbNull
                MoveFile = True
                FileName = IO.Path.GetFileNameWithoutExtension(File)

                If File.EndsWith(".exe") Then
                    FileDir = "\Programs\Windows\"
                    FileExt = ".exe"
                ElseIf File.EndsWith(".msi") Then
                    FileDir = "\Programs\Windows\"
                    FileExt = ".msi"
                ElseIf File.EndsWith(".deb") Then
                    FileDir = "\Programs\Linux\"
                    FileExt = ".deb"
                ElseIf File.EndsWith(".rpm") Then
                    FileDir = "\Programs\Linux\"
                    FileExt = ".rpm"
                ElseIf File.EndsWith(".bin") Then
                    FileDir = "\Programs\Linux\"
                    FileExt = ".bin"
                ElseIf File.EndsWith(".apk") Then
                    FileDir = "\Programs\Android\"
                    FileExt = ".apk"
                ElseIf File.EndsWith(".air") Then
                    FileDir = "\Programs\"
                    FileExt = ".air"

                ElseIf File.EndsWith(".XWidgetPkg") Then
                    FileDir = "\Widgets\"
                    FileExt = ".XWidgetPkg"

                ElseIf File.EndsWith(".mkv") Then
                    FileDir = "\Videos\"
                    FileExt = ".mkv"
                ElseIf File.EndsWith(".avi") Then
                    FileDir = "\Videos\"
                    FileExt = ".avi"

                ElseIf File.EndsWith(".ogg") Then
                    FileDir = "\Music\"
                    FileExt = ".ogg"
                ElseIf File.EndsWith(".mid") Then
                    FileDir = "\Music\"
                    FileExt = ".mid"
                ElseIf File.EndsWith(".wav") Then
                    FileDir = "\Music\"
                    FileExt = ".wav"
                ElseIf File.EndsWith(".mp3") Then
                    FileDir = "\Music\"
                    FileExt = ".mp3"
                ElseIf File.EndsWith(".m4a") Then
                    FileDir = "\Music\"
                    FileExt = ".m4a"

                ElseIf File.EndsWith(".ico") Then
                    FileDir = "\Pictures\"
                    FileExt = ".ico"
                ElseIf File.EndsWith(".png") Then
                    FileDir = "\Pictures\"
                    FileExt = ".png"
                ElseIf File.EndsWith(".gif") Then
                    FileDir = "\Pictures\"
                    FileExt = ".gif"
                ElseIf File.EndsWith(".jpg") Then
                    FileDir = "\Pictures\"
                    FileExt = ".jpg"
                ElseIf File.EndsWith(".psd") Then
                    FileDir = "\Pictures\"
                    FileExt = ".psd"

                ElseIf File.EndsWith(".torrent") Then
                    FileDir = "\Torrents\"
                    FileExt = ".torrent"

                ElseIf File.EndsWith(".pdf") Then
                    FileDir = "\Documents\"
                    FileExt = ".pdf"
                ElseIf File.EndsWith(".doc") Then
                    FileDir = "\Documents\"
                    FileExt = ".doc"
                ElseIf File.EndsWith(".docx") Then
                    FileDir = "\Documents\"
                    FileExt = ".docx"
                ElseIf File.EndsWith(".csv") Then
                    FileDir = "\Documents\"
                    FileExt = ".csv"
                ElseIf File.EndsWith(".xls") Then
                    FileDir = "\Documents\"
                    FileExt = ".xls"
                ElseIf File.EndsWith(".xlsx") Then
                    FileDir = "\Documents\"
                    FileExt = ".xlsx"
                ElseIf File.EndsWith(".nb") Then
                    FileDir = "\Documents\"
                    FileExt = ".nb"
                ElseIf File.EndsWith(".md") Then
                    FileDir = "\Documents\"
                    FileExt = ".md"
                ElseIf File.EndsWith(".txt") Then
                    FileDir = "\Documents\"
                    FileExt = ".txt"
                ElseIf File.EndsWith(".rtf") Then
                    FileDir = "\Documents\"
                    FileExt = ".rtf"

                ElseIf File.EndsWith(".crx") Then
                    FileDir = "\Extensions\"
                    FileExt = ".crx"
                ElseIf File.EndsWith(".xpi") Then
                    FileDir = "\Extensions\"
                    FileExt = ".xpi"

                ElseIf File.EndsWith(".cpp") Then
                    FileDir = "\Programming\"
                    FileExt = ".cpp"
                ElseIf File.EndsWith(".h") Then
                    FileDir = "\Programming\"
                    FileExt = ".h"
                ElseIf File.EndsWith(".php") Then
                    FileDir = "\Programming\"
                    FileExt = ".php"
                ElseIf File.EndsWith(".py") Then
                    FileDir = "\Programming\"
                    FileExt = ".py"
                ElseIf File.EndsWith(".rb") Then
                    FileDir = "\Programming\"
                    FileExt = ".rb"
                ElseIf File.EndsWith(".vb") Then
                    FileDir = "\Programming\"
                    FileExt = ".vb"
                ElseIf File.EndsWith(".html") Then
                    FileDir = "\Programming\"
                    FileExt = ".html"
                ElseIf File.EndsWith(".cs") Then
                    FileDir = "\Programming\"
                    FileExt = ".cs"
                ElseIf File.EndsWith(".cc") Then
                    FileDir = "\Programming\"
                    FileExt = ".cc"

                ElseIf File.EndsWith(".zip") Then
                    FileDir = "\Archives\"
                    FileExt = ".zip"
                ElseIf File.EndsWith(".rar") Then
                    FileDir = "\Archives\"
                    FileExt = ".rar"
                ElseIf File.EndsWith(".tar") Then
                    FileDir = "\Archives\"
                    FileExt = ".tar"
                ElseIf File.EndsWith(".gz") Then
                    FileDir = "\Archives\"
                    FileExt = ".gz"
                ElseIf File.EndsWith(".tgz") Then
                    FileDir = "\Archives\"
                    FileExt = ".tgz"

                ElseIf File.EndsWith(".sql") Then
                    FileDir = "\Backups\"
                    FileExt = ".sql"

                Else
                    MoveFile = False
                End If

                If (MoveFile) Then
                    IO.File.Move(File, Loc & FileDir & FileName & FileExt)
                End If

            Next

        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf & Loc & FileDir & FileName & FileExt)
        End Try

    End Sub

End Class
