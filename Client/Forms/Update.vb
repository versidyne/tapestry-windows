Public Class Update

    Private Sub Update_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim APIClient As New Net.WebClient()
        Dim URL As New Uri("http://api.versidyne.com/?session=12345&update=vexis-windows")
        Dim file As String = My.Application.Info.DirectoryPath & "\Patch\update.xml"

        AddHandler APIClient.DownloadProgressChanged, AddressOf DownloadProgressCallback
        AddHandler APIClient.DownloadFileCompleted, AddressOf DownloadFileCallBack2

        APIClient.DownloadFileAsync(URL, file)

    End Sub

    Private Sub DownloadProgressCallback(ByVal sender As Object, ByVal e As Net.DownloadProgressChangedEventArgs)

        ProgressBar1.Value = e.ProgressPercentage
        ToolStripStatusLabel1Output.Text = (e.ProgressPercentage.ToString & " Percent Downloaded")

    End Sub

    Private Sub DownloadFileCallBack2(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)

        'CheckVersion()
        ProgressBar1.Maximum = 100
        Try
            Dim doc = XDocument.Load(My.Application.Info.DirectoryPath & "\Patch\update.xml")
            Dim doc2 = XDocument.Load(My.Application.Info.DirectoryPath & "\update.xml")

            Dim updates = From updater In doc.Descendants() _
            Select New With {.corever = updater.Element("version").Element("corever").Value, _
            .soundver = updater.Element("version").Element("soundver").Value, _
            .gfxver = updater.Element("version").Element("gfxver").Value}

            Dim updates2 = From updater In doc2.Descendants() _
            Select New With {.oldcorever = updater.Element("version").Element("corever").Value, _
            .oldsoundver = updater.Element("version").Element("soundver").Value, _
            .oldgfxver = updater.Element("version").Element("gfxver").Value}

            Dim update = updates(0)
            Dim update2 = updates2(0)

            'corever.Text = "core version: " & update.corever
            'soundver.Text = "sound version: " & update.soundver
            'gfxver.Text = "graphics version: " & update.gfxver
            'yourcorever.Text = "your core version: " & update2.oldcorever
            'yoursoundver.Text = "your sound version: " & update2.oldsoundver
            'yourgfxver.Text = "your graphics version: " & update2.oldgfxver

            If update.corever = update2.oldcorever AndAlso update.soundver = update2.oldsoundver AndAlso update.gfxver = update2.oldgfxver Then
                'corecompare.Text = "You're up-to-date"
            ElseIf update.soundver = update2.oldsoundver AndAlso update.gfxver = update2.oldgfxver Then
                'States that the core files need to be updated - EX. .exe, .dll files
                'corecompare.Text = "Core files need to be updated."
                'goes to sub coredownload to download core files
                Call CoreDownload()
            ElseIf update.corever = update2.oldcorever AndAlso update.gfxver = update2.oldgfxver Then
                'States that the sound files need to be updated. - Ex. .mp3, .midi files
                'corecompare.Text = "Sound files need to be updated."
                'goes to sub sounddownload to download sound files
                SoundDownload()
            ElseIf update.soundver = update2.oldsoundver AndAlso update.corever = update2.oldcorever Then
                'States that the graphic files need to be updated. - Ex. .jpg, .png, .gif files
                'corecompare.Text = "Graphic files need to be updated."
                'goes to sub gfxdownload to download graphic files
                GfxDownload()
            Else
                'States that all types of files need to be updated.
                'corecompare.Text = "Update required"
                'goes to sub downloadall to download all updates
                DownloadAll()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub


    Sub CoreDownload()

        'downloads core files
        Try

            Dim APIClient As New Net.WebClient()
            AddHandler APIClient.DownloadProgressChanged, AddressOf DownloadProgressCallback

            AddHandler APIClient.DownloadFileCompleted, AddressOf DownloadFileUnzip
            Dim url As New Uri("http://thelegend.crzyproductions.com/core.zip")
            Dim file As String = My.Application.Info.DirectoryPath & "\Patch\core.zip"



            APIClient.DownloadFileAsync(url, file)

        Catch ex As Exception
            'Catches error and displays it.
            MessageBox.Show(ex.Message)
        End Try

        'Moves updater.xml out of patch so old one gets replaced.
        Dim FileToCopy As String
        Dim NewCopy As String
        FileToCopy = (My.Application.Info.DirectoryPath & "\Patch\updater.xml")
        NewCopy = (My.Application.Info.DirectoryPath & "\updater.xml")
        'Copies ver.txt to different folder.
        If IO.File.Exists(FileToCopy) = True Then
            IO.File.Delete("update.xml")
            IO.File.Copy(FileToCopy, NewCopy)
        End If

    End Sub

    Sub SoundDownload()

        'Downloads sound files
        Try

            Dim APIClient As New Net.WebClient()
            Dim url As New Uri("http://thelegend.crzyproductions.com/sound.zip")
            Dim file As String = My.Application.Info.DirectoryPath & "\Patch\sound.zip"

            AddHandler APIClient.DownloadProgressChanged, AddressOf DownloadProgressCallback
            AddHandler APIClient.DownloadFileCompleted, AddressOf DownloadFileUnzip

            APIClient.DownloadFileAsync(url, file)
        Catch ex As Exception
            'Catches error and displays it.
            MessageBox.Show(ex.Message)
        End Try

        'Moves updater.xml out of patch so old one gets replaced.
        Dim FileToCopy As String
        Dim NewCopy As String
        FileToCopy = (My.Application.Info.DirectoryPath & "\Patch\updater.xml")
        NewCopy = (My.Application.Info.DirectoryPath & "\updater.xml")
        'Copies ver.txt to different folder.
        If IO.File.Exists(FileToCopy) = True Then
            IO.File.Delete("updater.xml")
            IO.File.Copy(FileToCopy, NewCopy)
        End If

    End Sub

    Sub GfxDownload()

        'Downloads graphic files
        Try
            Dim APIClient As New Net.WebClient()
            Dim url As New Uri("http://thelegend.crzyproductions.com/gfx.zip")
            Dim file As String = My.Application.Info.DirectoryPath & "\Patch\gfx.zip"

            AddHandler APIClient.DownloadProgressChanged, AddressOf DownloadProgressCallback

            AddHandler APIClient.DownloadFileCompleted, AddressOf DownloadFileUnzip

            APIClient.DownloadFileAsync(url, file)
        Catch ex As Exception
            'Catches error and displays it.
            MessageBox.Show(ex.Message)
        End Try

        'Moves updater.xml out of patch so old one gets replaced.
        Dim FileToCopy As String
        Dim NewCopy As String
        FileToCopy = (My.Application.Info.DirectoryPath & "\Patch\updater.xml")
        NewCopy = (My.Application.Info.DirectoryPath & "\updater.xml")
        'Copies ver.txt to different folder.
        If IO.File.Exists(FileToCopy) = True Then
            IO.File.Delete("updater.xml")
            IO.File.Copy(FileToCopy, NewCopy)
        End If

    End Sub

    Sub DownloadAll()

        'Downloads all Files if Needed
        Try

            Dim APIClient As New Net.WebClient()
            Dim url As New Uri("http://thelegend.crzyproductions.com/core.zip")
            Dim file As String = My.Application.Info.DirectoryPath & "\Patch\core.zip"
            Dim url2 As New Uri("http://thelegend.crzyproductions.com/sound.zip")
            Dim file2 As String = My.Application.Info.DirectoryPath & "\Patch\sound.zip"
            Dim url3 As New Uri("http://thelegend.crzyproductions.com/sound.zip")
            Dim file3 As String = My.Application.Info.DirectoryPath & "\Patch\sound.zip"

            AddHandler APIClient.DownloadProgressChanged, AddressOf DownloadProgressCallback

            AddHandler APIClient.DownloadFileCompleted, AddressOf DownloadFileUnzip

            APIClient.DownloadFileAsync(url, file)
            APIClient.DownloadFileAsync(url2, file2)
            APIClient.DownloadFileAsync(url3, file3)

        Catch ex As Exception
            'Catches error and displays it.
            MessageBox.Show(ex.Message)
        End Try

        'Moves updater.xml out of patch so old one gets replaced.
        Dim FileToCopy As String
        Dim NewCopy As String
        FileToCopy = (My.Application.Info.DirectoryPath & "\Patch\updater.xml")
        NewCopy = (My.Application.Info.DirectoryPath & "\updater.xml")
        'Copies ver.txt to different folder.
        If IO.File.Exists(FileToCopy) = True Then
            IO.File.Delete("updater.xml")
            IO.File.Copy(FileToCopy, NewCopy)
        End If

    End Sub

    Private Sub DownloadFileUnzip()

        ProgressBar1.Maximum = 100

        'Unzip and install core files.

        'Dim zipfile As New FastZip
        Try
            If IO.File.Exists("Patch\core.zip") Then
                'This unzips mygame.zip and updates all core files.
                'zipfile.ExtractZip("Patch\core.zip", ".", "")
                ToolStripStatusLabel1Output.Text = " Installed!"
                'Deletes the zip folder to free up space.
                IO.File.Delete("Patch\core.zip")

            ElseIf IO.File.Exists("Patch\sound.zip") Then
                'this unzips sound.zip and updates all sound files.
                'zipfile.ExtractZip("Patch\sound.zip", ".", "")
                ToolStripStatusLabel1Output.Text = " installed!"
                'deletes the zip folder to free up space.
                IO.File.Delete("Patch\sound.zip")

            ElseIf IO.File.Exists("Patch\gfx.zip") Then
                'this unzips gfx.zip and updates all graphic files.
                'zipfile.ExtractZip("Patch\core.zip", ".", "")
                ToolStripStatusLabel1Output.Text = " installed!"
                'deletes the zip folder to free up space.
                IO.File.Delete("Patch\core.zip")

            ElseIf IO.File.Exists("Patch\core.zip") And IO.File.Exists("Patch\sound.zip") Then
                'this unzips gfx.zip and updates all graphic files.
                'zipfile.ExtractZip("Patch\core.zip", ".", "")
                ToolStripStatusLabel1Output.Text = " installed!"
                'deletes the zip folder to free up space.
                IO.File.Delete("Patch\core.zip")

                'this unzips sound.zip and updates all sound files.
                'zipfile.ExtractZip("Patch\sound.zip", ".", "")
                ToolStripStatusLabel1Output.Text = " installed!"
                'deletes the zip folder to free up space.
                IO.File.Delete("Patch\sound.zip")

            ElseIf IO.File.Exists("Patch\sound.zip") And IO.File.Exists("Patch\gfx.zip") Then
                'this unzips sound.zip and updates all sound files.
                'zipfile.ExtractZip("Patch\sound.zip", ".", "")
                ToolStripStatusLabel1Output.Text = " installed!"
                'deletes the zip folder to free up space.
                IO.File.Delete("Patch\sound.zip")

                'this unzips gfx.zip and updates all graphic files.
                'zipfile.ExtractZip("Patch\gfx.zip", ".", "")
                ToolStripStatusLabel1Output.Text = " installed!"
                'deletes the zip folder to free up space.
                IO.File.Delete("Patch\gfx.zip")

            ElseIf IO.File.Exists("Patch\core.zip") And IO.File.Exists("Patch\gfx.zip") Then
                'this unzips core.zip and updates all core files.
                'zipfile.ExtractZip("patch\core.zip", ".", "")
                ToolStripStatusLabel1Output.Text = " installed!"
                'deletes the zip folder to free up space.
                IO.File.Delete("Patch\core.zip")

                'this unzips gfx.zip and updates all graphic files.
                'zipfile.ExtractZip("patch\gfx.zip", ".", "")
                ToolStripStatusLabel1Output.Text = " installed!"
                'deletes the zip folder to free up space.
                IO.File.Delete("Patch\gfx.zip")

            ElseIf IO.File.Exists("Patch\core.zip") And IO.File.Exists("Patch\sound.zip") And IO.File.Exists("Patch\gfx.zip") Then
                'this unzips core.zip and updates all core files.
                'zipfile.ExtractZip("Patch\core.zip", ".", "")
                ToolStripStatusLabel1Output.Text = " installed!"
                'deletes the zip folder to free up space.
                IO.File.Delete("Patch\core.zip")

                'this unzips sound.zip and updates all sound files.
                'zipfile.ExtractZip("Patch\sound.zip", ".", "")
                ToolStripStatusLabel1Output.Text = " installed!"
                'deletes the zip folder to free up space.
                IO.File.Delete("Patch\sound.zip")

                'this unzips gfx.zip and updates all graphic files.
                'zipfile.ExtractZip("Patch\gfx.zip", ".", "")
                ToolStripStatusLabel1Output.Text = " installed!"
                'deletes the zip folder to free up space.
                IO.File.Delete("Patch\gfx.zip")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

End Class