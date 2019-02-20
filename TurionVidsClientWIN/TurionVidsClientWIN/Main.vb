Public Class Main
    Public Shared clientver As String = "0.1b"
    Dim CurrentVideoID
    Dim inited As Integer = 1 'To prevent videoQualityChanged event being triggered at initialization

    Function init()
        Player.Init()
        BottomBarStatus.Text = "Attente..."
        If APIrequest.Status = 1 Then
            BottomBarStatus.Text = "OK"
        ElseIf 0 Then
            BottomBarStatus.Text = "Erreur API server-side"
        Else
            BottomBarStatus.Text = "Erreur"
        End If
        With (ResComboBox)
            .Items.Clear()
            .Items.Add("360p")
            .Items.Add("HD")
            .SelectedIndex = 0
        End With
        VideoTitleLabel.Text = ""
        VideoUploaderLabel.Text = ""
        VideoDateLabel.Text = ""
        VideoDescriptionTextBox.Text = ""
        Player.Playlist.Clear()
        RefreshVideoList()
        Return (1)
    End Function
    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not My.Settings.Player = 0 And Not My.Settings.Player = 1 Then
            My.Settings.Reset()
            My.Settings.Save()
            MessageBox.Show("Un problème de configuration à été détecté et les paramètres de TurionVids ont été" & vbNewLine & "remis à zéro.", "C'est pas normal", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Me.Text = "TurionVids Client " & clientver
        Me.Icon = My.Resources.TurionVidsIcon
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        VideoListPanel.AutoScroll = True
        Me.Show()
        init()
        'Play(3707060724)
    End Sub
    Private Sub Main_Close(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.FormClosed
        Player.Quit()
        My.Settings.Save()
    End Sub

    Private Sub QuitterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitterToolStripMenuItem.Click
        If MessageBox.Show("Voulez vous vraiment quitter ?", "Quitter ou ne pas quitter, telle est la question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            End
        End If
    End Sub

    Private Sub InitialisationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InitialisationToolStripMenuItem.Click
        init()
    End Sub
    Function CheckUpdates()
        Dim NewVersion = UpdateManager.Check()
        If TypeOf (NewVersion) Is Integer Then
            MessageBox.Show("Impossible de vérifier les mises à jour" _
                            & vbNewLine & "(êtes-vous connecté à internet ?)", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.None)
        Else
            If Not NewVersion = clientver Then
                If MessageBox.Show("Nouvelle version : " & NewVersion & " disponible." _
                                   & vbNewLine & "Voulez vous ouvrir le navigateur sur la page de téléchargement ?", "Nouvelle version disponible", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                    Process.Start(UpdateManager.DlUrl)
                End If
            Else
                MessageBox.Show("Pas de nouvelle mise à jour", "TurionVids est à jour", MessageBoxButtons.OK, MessageBoxIcon.None)
            End If
        End If
    End Function

    Function Play(ByVal vid As Int64, Optional ByVal pos As Double = 0)
        CurrentVideoID = vid
        BottomBarStatus.Text = "API GET name"
        VideoTitleLabel.Text = APIrequest.Name(vid)
        BottomBarStatus.Text = "API GET uploader"
        VideoUploaderLabel.Text = APIrequest.Uploader(vid)
        BottomBarStatus.Text = "API GET upload_date"
        VideoDateLabel.Text = APIrequest.UploadDate(vid)
        BottomBarStatus.Text = "API GET description"
        VideoDescriptionTextBox.Text = APIrequest.Description(vid)
        Player.Playlist.Clear()
        If ResComboBox.SelectedIndex = 0 Then
            BottomBarStatus.Text = "API GET sd_playback_url"
            Player.OpenURL(APIrequest.VideoURL(vid))
            Player.Position(pos)
            BottomBarStatus.Text = "OK"
        ElseIf ResComboBox.SelectedIndex = 1 Then
            BottomBarStatus.Text = "API GET hd_playback_url"
            Player.OpenURL(APIrequest.HDVideoURL(vid))
            Player.Position(pos)
            BottomBarStatus.Text = "OK"
        End If
    End Function

    Function RefreshVideoList()
        VideoListPanel.Controls.Clear()

        If Not TypeOf (APIrequest.VideoList) Is Array Then ' if apiRequest fail, it will return 0 (integer); and not an array
            Dim ErrorLabel As New Label
            With ErrorLabel
                .Text = "Impossible d'actualiser la liste des vidéos" _
                    & vbNewLine & "Veuillez réessayer plus tard" _
                    & vbNewLine & "(êtes-vous connecté à internet ?" _
                    & vbNewLine & "TurionVids est-il à jour ?)"
                .Location = New System.Drawing.Point(100, 20)
                .Size = New System.Drawing.Size(200, 52)
            End With
            VideoListPanel.Controls.Add(ErrorLabel)
            Dim RetryButton As New Button
            With RetryButton
                .Text = "Réessayer"
                .Location = New System.Drawing.Point(100, 76)
            End With
            VideoListPanel.Controls.Add(RetryButton)
            AddHandler RetryButton.Click, Function(sender, e) init()
            Dim UpdateButton As New Button
            With UpdateButton
                .Text = "Vérifier mise à jour"
                .Location = New System.Drawing.Point(190, 76)
                .Size = New System.Drawing.Size(110, 23)
            End With
            VideoListPanel.Controls.Add(UpdateButton)
            AddHandler UpdateButton.Click, Function(sender, e) CheckUpdates()

        Else
            Dim videoList As Array = APIrequest.VideoList
            Dim prevX As Integer = 0

            Dim VideoPanel(videoList.Length - 1) As Panel
            Dim VideoTitle(videoList.Length - 1) As Label
            Dim VideoUploader(videoList.Length - 1) As Label
            Dim VideoDate(videoList.Length - 1) As Label
            Dim VideoThumbnail(videoList.Length - 1) As PictureBox

            For x = 0 To videoList.Length - 1 ' -1 because this function return the number of items starting from 1, but when you select an item in an array, you start from 0... Visual Basic Logic
                Dim v_id As Int64 = videoList(x)
                Console.Write(x) 'DEBUG
                VideoPanel(x) = New Panel
                With VideoPanel(x)
                    .BackColor = Color.LightSteelBlue
                    .Size = New System.Drawing.Size(379, 78)
                    .Name = "Panel_" & v_id
                    .Location = New System.Drawing.Point(3, 3 + prevX)
                    .TabIndex = x + 1
                End With
                AddHandler VideoPanel(x).Click, Function(sender, e) Play(v_id)
                VideoListPanel.Controls.Add(VideoPanel(x))
                prevX = prevX + 78 + 3 ' Last panel location + panel height + Xoffset

                VideoTitle(x) = New Label
                With VideoTitle(x)
                    .Name = "TitleLabel_" & v_id
                    .Text = APIrequest.Name(v_id)
                    .Size = New System.Drawing.Size(376, 13)
                    .Location = New System.Drawing.Point(134, 7)
                    .Font = New Font(VideoTitle(x).Font, FontStyle.Bold)
                End With
                VideoPanel(x).Controls.Add(VideoTitle(x))
                AddHandler VideoTitle(x).Click, Function(sender, e) Play(v_id)

                VideoUploader(x) = New Label
                With VideoUploader(x)
                    .Name = "UploaderLabel_" & v_id
                    .Text = APIrequest.Uploader(v_id)
                    .Size = New System.Drawing.Size(376, 13)
                    .Location = New System.Drawing.Point(137, 24)
                End With
                VideoPanel(x).Controls.Add(VideoUploader(x))
                AddHandler VideoUploader(x).Click, Function(sender, e) Play(v_id)

                VideoDate(x) = New Label
                With VideoDate(x)
                    .Name = "DateLabel_" & v_id
                    .Text = APIrequest.UploadDate(v_id)
                    .Size = New System.Drawing.Size(376, 13)
                    .Location = New System.Drawing.Point(137, 41)
                End With
                VideoPanel(x).Controls.Add(VideoDate(x))
                AddHandler VideoDate(x).Click, Function(sender, e) Play(v_id)

                VideoThumbnail(x) = New PictureBox
                With VideoThumbnail(x)
                    .Size = New System.Drawing.Size(128, 72)
                    .SizeMode = PictureBoxSizeMode.StretchImage
                    .Location = New System.Drawing.Point(3, 3)
                    .ImageLocation = APIrequest.ThumbnailURL(v_id)
                End With
                VideoPanel(x).Controls.Add(VideoThumbnail(x))
                AddHandler VideoThumbnail(x).Click, Function(sender, e) Play(v_id)
            Next
        End If
    End Function

    Private Sub OuvrirVideoIDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OuvrirVideoIDToolStripMenuItem.Click
        Dim v_id As Int64
        Dim UserInput As String
        UserInput = InputBox("Tapez le VideoID", "Ouvrir un VideoID", "")
        If UserInput = "" Then
            Exit Sub
        End If
        Try
            v_id = Convert.ToInt64(UserInput)
        Catch ex As Exception
            MessageBox.Show("Pas un nombre")
            Exit Sub
        End Try
        If APIrequest.VideoExist(v_id) = 1 Then
            Play(v_id)
        Else
            MessageBox.Show("Video inéxistante")
        End If
    End Sub

    Private Sub ResComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResComboBox.SelectedIndexChanged
        If inited < 1 Then 'To prevent this event being triggered at initialization
            Dim currentpos As Double = Player.Position()
            'WMPlayer.playlistCollection.remove(WMPlayer.currentPlaylist)
            Player.Playlist.Clear()
            Player.StopPlayback()
            Play(CurrentVideoID, currentpos)
        Else
            inited = 0
        End If
    End Sub

    Private Sub FullScreenButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FullScreenButton.Click
        Player.FullScreen()
    End Sub

    Private Sub CheckForUpdates_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckForUpdates.Click
        CheckUpdates()
    End Sub

    Private Sub RéglagesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RéglagesToolStripMenuItem.Click
        Settings.Show()
    End Sub

    Private Sub AProposToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AProposToolStripMenuItem.Click
        About.Show()
    End Sub
End Class

Public Class APIrequest
    Private Shared apiURL As String = "http://turion64.fr.nf/video/api.php"
    Private Shared webClient As New System.Net.WebClient
    Private Shared Function AskAPI(ByVal arg As String)
        Dim apiResp As String
        Try
            apiResp = webClient.DownloadString(apiURL & arg)
        Catch ex As Exception
            Return 0
            Exit Function
        End Try
        Return apiResp
    End Function
    Shared Function Status()
        Dim apiResp As String = AskAPI("?want=api_status")
        If apiResp = "ok:ok" Then
            Return 1
        Else
            Return 0
        End If
    End Function
    Shared Function Version()
        Dim apiResp As String = AskAPI("?want=api_ver")
        If apiResp.Contains("ok:") Then
            Dim tmp = apiResp.Split(":")
            apiResp = tmp(1)
            Return apiResp
        Else
            Return 0
        End If
    End Function
    Shared Function VideoURL(ByVal vid As Int64)
        Dim apiResp As String = AskAPI("?v_id=" & vid & "&want=video_url")
        If apiResp.Contains("ok:") Then
            Dim tmp = apiResp.ToList
            tmp.RemoveRange(0, 3)
            Dim tmp2 As String = String.Join("", tmp.ToArray())
            Return (tmp2)
        Else
            Return 0
        End If
    End Function
    Shared Function HDVideoURL(ByVal vid As Int64)
        Dim apiResp As String = AskAPI("?v_id=" & vid & "&want=hd_video_url")
        If apiResp.Contains("ok:") Then
            Dim tmp = apiResp.ToList
            tmp.RemoveRange(0, 3)
            Dim tmp2 As String = String.Join("", tmp.ToArray())
            Return (tmp2)
        Else
            Return 0
        End If
    End Function
    Shared Function Description(ByVal vid As Int64)
        Dim apiResp As String = AskAPI("?v_id=" & vid & "&want=description")
        If apiResp.Contains("ok:") Then
            Dim tmp = apiResp.ToList
            tmp.RemoveRange(0, 3) 'removing "ok:"
            Dim tmp2 As String = String.Join("", tmp.ToArray()) 'replace api's New Line character to VB new line character
            tmp2 = tmp2.Replace(vbLf, vbCrLf)
            'tmp2 = System.Text.Encoding.Default.GetString(System.Text.Encoding.UTF8.GetBytes(tmp2))   'marche po :(
            Return (tmp2)
        Else
            Return 0
        End If
    End Function
    Shared Function Uploader(ByVal vid As Int64)
        Dim apiResp As String = AskAPI("?v_id=" & vid & "&want=uploader")
        If apiResp.Contains("ok:") Then
            Dim tmp = apiResp.ToList
            tmp.RemoveRange(0, 3) 'removing "ok:"
            Dim tmp2 As String = String.Join("", tmp.ToArray())
            'tmp2 = System.Text.Encoding.Default.GetString(System.Text.Encoding.UTF8.GetBytes(tmp2))
            Return (tmp2)
        Else
            Return 0
        End If
    End Function
    Shared Function Name(ByVal vid As Int64)
        Dim apiResp As String = AskAPI("?v_id=" & vid & "&want=name")
        If apiResp.Contains("ok:") Then
            Dim tmp = apiResp.ToList
            tmp.RemoveRange(0, 3) 'removing "ok:"
            Dim tmp2 As String = String.Join("", tmp.ToArray())
            'tmp2 = System.Text.Encoding.Default.GetString(System.Text.Encoding.UTF8.GetBytes(tmp2))
            Return (tmp2)
        Else
            Return 0
        End If
    End Function
    Shared Function ThumbnailURL(ByVal vid As Int64)
        Dim apiResp As String = AskAPI("?v_id=" & vid & "&want=thumbnail_url")
        If apiResp.Contains("ok:") Then
            Dim tmp = apiResp.ToList
            tmp.RemoveRange(0, 3) 'removing "ok:"
            Dim tmp2 As String = String.Join("", tmp.ToArray())
            Return (tmp2)
        Else
            Return 0
        End If
    End Function
    Shared Function UploadDate(ByVal vid As Int64)
        Dim apiResp As String = AskAPI("?v_id=" & vid & "&want=date")
        If apiResp.Contains("ok:") Then
            Dim tmp = apiResp.ToList
            tmp.RemoveRange(0, 3) 'removing "ok:"
            Dim tmp2 As String = String.Join("", tmp.ToArray())
            'TODO : String split at delimiter "-"
            Return (tmp2)
        Else
            Return 0
        End If
    End Function
    Shared Function VideoList()
        Dim apiResp As String = AskAPI("?want=video_list")
        If apiResp.Contains("ok:") Then
            Dim tmp = apiResp.ToList
            tmp.RemoveRange(0, 3) 'removing "ok:"
            Dim tmp2 As String = String.Join("", tmp.ToArray())
            Dim tmp3 As Array = tmp2.Split(vbLf)
            Return (tmp3)
        Else
            Return 0
        End If
    End Function
    Shared Function VideoExist(ByVal vid As Int64)
        Dim apiResp As String = AskAPI("?v_id=" & vid & "&want=date") 'TODO : Implement a real api function (server-side) to check if a video exist
        If apiResp.Contains("ok") Then
            Return 1
            Exit Function
        ElseIf apiResp.Contains("error:non-existant-vid") Then
            Return 0
            Exit Function
        End If
        Return 0
    End Function
End Class

Public Class Player
    Private Shared usedPlayer As Integer '0 = WMP ; 1 = VLC
    Shared WithEvents VLCPlayer As AxAXVLC.AxVLCPlugin2 = Nothing
    Shared Function Init() 'Select which player to use
        Dim debug As Boolean = 0
        Dim UserPlayer = My.Settings.Player ' 0 = WMP ; 1 = VLC
        Dim osVer As Integer = System.Environment.OSVersion.Version.Major & System.Environment.OSVersion.Version.Minor
        If osVer < 61 Or UserPlayer = 1 Or debug Then 'detect if user is running windows XP (51) or Vista (60) because WMP11 doesnt support MP4 files. Because the app is not targeting Windows 10, the max it can return is "6.2" even if its running on Win10 (10.0)
            Dim VLC32b As Object = My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\VideoLAN\VLC", False) 'Detect if VLC 32bits is installed (64bits will not work... ActiveX bullshit)
            If VLC32b Is Nothing Then
                If UserPlayer = 1 Then
                    MessageBox.Show("Vous avez selectionné VLC comme lecteur, mais VLC 32Bits n'est pas installé," _
                           & vbNewLine & "WMPlayer à été redéfini comme lecteur par défaut pour TurionVids", "Remarque", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    My.Settings.Player = 0
                    My.Settings.Save()
                Else
                    MessageBox.Show("Vous utiliser Windows XP ou Vista, et ces OS ne supportent pas la lecture des MP4 nativement;" _
                           & vbNewLine & "MAIS TurionVidsWIN peut utiliser VLC à la place, mais VLC n'est pas installé sur cet ordinateur." _
                           & vbNewLine & "Vous pouvez télécharger VLC *32bits* (même sur un système 64bits) à l'adresse : https://www.videolan.org/ et l'installer." _
                           & vbNewLine & vbNewLine & "TL;DR : Installez VLC *32bits* pour que TurionVidsWIN fonctionne sur ce système")
                    usedPlayer = 0 'Trying to use WMP anyway
                    Return 0
                End If
            Else
                If UserPlayer = 1 Then
                    'Do nothing because the user want VLC to be used
                Else
                    MessageBox.Show("Vous allez passer en mode de compatibilité (VLC instead of WMP)" _
                                    & vbNewLine & "Des messages d'erreurs vont s'afficher, faites 'OK' et le programme fonctionnera normalement" _
                                    & vbNewLine & "(Je n'arrive pas à empecher qu'ils s'affichent)", "Mode de compatibilité")
                    My.Settings.Player = 1
                    My.Settings.Save()
                End If
                Main.WMPlayer.Hide()
                Try
                    Main.WMPlayer.Dispose()
                Catch ex As Exception
                    MessageBox.Show("Failed to dispose WMPlayer, will just hide it")
                End Try
                usedPlayer = 1 'using VLC media player
                'TODO : INIT VLC PLAYER : LOAD DLL (safely) AND ADD IT TO THE FORM
                Try
                    VLCPlayer.Dispose()
                Catch ex As Exception
                End Try
                Try
                    VLCPlayer = New AxAXVLC.AxVLCPlugin2
                Catch ex As Exception
                    MessageBox.Show("Failed to load VLC ActiveX")
                    Return 0
                    Exit Function
                End Try

                CType(VLCPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
                Main.SuspendLayout()
                Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
                With VLCPlayer
                    .Enabled = True
                    .Name = "VLCPlayer"
                    .OcxState = CType(resources.GetObject("VLCPlayer.OcxState"), System.Windows.Forms.AxHost.State)
                    .Location = New System.Drawing.Point(7, 31)
                    .Size = New System.Drawing.Size(492, 332)
                    Main.Controls.Add(VLCPlayer)
                    .CreateControl()
                    .Visible = True
                    .CtlVisible = True
                    .Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
                End With
                CType(VLCPlayer, System.ComponentModel.ISupportInitialize).EndInit()
                Main.ResumeLayout(True)
                VLCPlayer.Show()

            End If
            Return 1
        Else
            usedPlayer = 0 'using WMP
            Main.WMPlayer.stretchToFit = True
            Main.WMPlayer.URL = ".mov" ' if nothing, WMP will say the file type is unknown
            Main.WMPlayer.settings.volume = 100
            Return 1
        End If
    End Function
    Shared Function Quit()
        Try
            Select Case usedPlayer
                Case Is = 0
                    Main.WMPlayer.Ctlcontrols.stop()
                    Main.WMPlayer.Dispose()
                Case Is = 1
                    VLCPlayer.playlist.stop()
                    VLCPlayer.playlist.stop_async()
                    VLCPlayer.Dispose()
            End Select
        Catch ex As Exception

        End Try
        Return 1
    End Function
    Shared Function OpenURL(ByVal url As String)
        Select Case usedPlayer
            Case Is = 0
                Main.WMPlayer.URL = url
            Case Is = 1
                VLCPlayer.playlist.items.clear()
                VLCPlayer.playlist.add(url)
                VLCPlayer.playlist.next()
                VLCPlayer.playlist.play()
        End Select
        Return 1
    End Function
    Shared Function FullScreen()
        Select Case usedPlayer
            Case Is = 0
                Main.WMPlayer.fullScreen = 1
            Case Is = 1
                VLCPlayer.FullscreenEnabled = 1
                VLCPlayer.video.fullscreen = 1
        End Select
        Return 1
    End Function
    Shared Function Position(Optional ByVal pos = Nothing)
        If pos = Nothing Then
            Select Case usedPlayer
                Case Is = 0
                    Dim currentpos As Double = Main.WMPlayer.Ctlcontrols.currentPosition
                    Return currentpos
                Case Is = 1
                    Dim currentpos As Double = VLCPlayer.input.position
                    Return currentpos
            End Select
        Else
            Select Case usedPlayer
                Case Is = 0
                    Main.WMPlayer.Ctlcontrols.currentPosition = pos
                    Return 1
                Case Is = 1
                    VLCPlayer.input.position = pos
                    Return 1
            End Select
        End If
    End Function
    Shared Function StopPlayback()
        Select Case usedPlayer
            Case Is = 0
                Main.WMPlayer.Ctlcontrols.stop()
            Case Is = 1
                VLCPlayer.playlist.stop()
                VLCPlayer.playlist.stop_async()
        End Select
        Return 1
    End Function
    Public Class Playlist
        Shared Function Clear()
            Select Case usedPlayer
                Case Is = 0
                    Main.WMPlayer.playlistCollection.remove(Main.WMPlayer.currentPlaylist) 'not working at the moment
                Case Is = 1
                    VLCPlayer.playlist.items.clear()
            End Select
            Return 1
        End Function
    End Class
End Class
Public Class UpdateManager
    Private Shared verURL As String = "http://turion64.fr.nf/projets/TurionVidsClient/verinfo/manifest.ver"
    Private Shared Function SafeClient(ByVal url As String)
        Dim webClient As New System.Net.WebClient
        Dim resp As String
        Try
            resp = webClient.DownloadString(url)
        Catch ex As Exception
            Return 0
            Exit Function
        End Try
        Return resp
    End Function
    Shared Function Check()
        Dim tmp As String = SafeClient(verURL)
        Dim tmp2 As Array = tmp.Split(vbLf)
        Return tmp2(0)
    End Function
    Shared Function DlUrl()
        Dim tmp As String = SafeClient(verURL)
        Dim tmp2 As Array = tmp.Split(vbLf)
        Return tmp2(1)
    End Function
End Class
' wasting my time to write software no one will use