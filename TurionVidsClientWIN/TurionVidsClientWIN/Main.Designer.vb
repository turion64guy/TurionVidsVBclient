<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.WMPlayer = New AxWMPLib.AxWindowsMediaPlayer()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.BottomBarStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TopBar = New System.Windows.Forms.ToolStrip()
        Me.ClientTopBarButton = New System.Windows.Forms.ToolStripSplitButton()
        Me.OuvrirVideoIDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InitialisationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RéglagesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutTopBarButton = New System.Windows.Forms.ToolStripSplitButton()
        Me.CheckForUpdates = New System.Windows.Forms.ToolStripMenuItem()
        Me.AProposToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VideoListPanel = New System.Windows.Forms.Panel()
        Me.AboutVideo = New System.Windows.Forms.GroupBox()
        Me.VideoDescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.VideoDateLabel = New System.Windows.Forms.Label()
        Me.VideoUploaderLabel = New System.Windows.Forms.Label()
        Me.VideoTitleLabel = New System.Windows.Forms.Label()
        Me.ResComboBox = New System.Windows.Forms.ComboBox()
        Me.FullScreenButton = New System.Windows.Forms.Button()
        Me.BGWmplayer = New System.ComponentModel.BackgroundWorker()
        Me.ReloadVideoListButton = New System.Windows.Forms.Button()
        CType(Me.WMPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.TopBar.SuspendLayout()
        Me.AboutVideo.SuspendLayout()
        Me.SuspendLayout()
        '
        'WMPlayer
        '
        Me.WMPlayer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WMPlayer.Enabled = True
        Me.WMPlayer.Location = New System.Drawing.Point(7, 31)
        Me.WMPlayer.Name = "WMPlayer"
        Me.WMPlayer.OcxState = CType(resources.GetObject("WMPlayer.OcxState"), System.Windows.Forms.AxHost.State)
        Me.WMPlayer.Size = New System.Drawing.Size(492, 332)
        Me.WMPlayer.TabIndex = 0
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BottomBarStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 609)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(924, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'BottomBarStatus
        '
        Me.BottomBarStatus.Name = "BottomBarStatus"
        Me.BottomBarStatus.Size = New System.Drawing.Size(40, 17)
        Me.BottomBarStatus.Text = "Inactif"
        '
        'TopBar
        '
        Me.TopBar.BackColor = System.Drawing.SystemColors.Control
        Me.TopBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientTopBarButton, Me.AboutTopBarButton})
        Me.TopBar.Location = New System.Drawing.Point(0, 0)
        Me.TopBar.Name = "TopBar"
        Me.TopBar.Size = New System.Drawing.Size(924, 25)
        Me.TopBar.TabIndex = 2
        Me.TopBar.Text = "TopBar"
        '
        'ClientTopBarButton
        '
        Me.ClientTopBarButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ClientTopBarButton.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OuvrirVideoIDToolStripMenuItem, Me.InitialisationToolStripMenuItem, Me.RéglagesToolStripMenuItem, Me.QuitterToolStripMenuItem})
        Me.ClientTopBarButton.Image = CType(resources.GetObject("ClientTopBarButton.Image"), System.Drawing.Image)
        Me.ClientTopBarButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ClientTopBarButton.Name = "ClientTopBarButton"
        Me.ClientTopBarButton.Size = New System.Drawing.Size(54, 22)
        Me.ClientTopBarButton.Text = "Client"
        '
        'OuvrirVideoIDToolStripMenuItem
        '
        Me.OuvrirVideoIDToolStripMenuItem.Name = "OuvrirVideoIDToolStripMenuItem"
        Me.OuvrirVideoIDToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.OuvrirVideoIDToolStripMenuItem.Text = "Ouvrir VideoID"
        '
        'InitialisationToolStripMenuItem
        '
        Me.InitialisationToolStripMenuItem.Name = "InitialisationToolStripMenuItem"
        Me.InitialisationToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.InitialisationToolStripMenuItem.Text = "Initialisation"
        '
        'RéglagesToolStripMenuItem
        '
        Me.RéglagesToolStripMenuItem.Name = "RéglagesToolStripMenuItem"
        Me.RéglagesToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.RéglagesToolStripMenuItem.Text = "Réglages"
        '
        'QuitterToolStripMenuItem
        '
        Me.QuitterToolStripMenuItem.Name = "QuitterToolStripMenuItem"
        Me.QuitterToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.QuitterToolStripMenuItem.Text = "Quitter"
        '
        'AboutTopBarButton
        '
        Me.AboutTopBarButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.AboutTopBarButton.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CheckForUpdates, Me.AProposToolStripMenuItem})
        Me.AboutTopBarButton.Image = CType(resources.GetObject("AboutTopBarButton.Image"), System.Drawing.Image)
        Me.AboutTopBarButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AboutTopBarButton.Name = "AboutTopBarButton"
        Me.AboutTopBarButton.Size = New System.Drawing.Size(56, 22)
        Me.AboutTopBarButton.Text = "About"
        '
        'CheckForUpdates
        '
        Me.CheckForUpdates.Name = "CheckForUpdates"
        Me.CheckForUpdates.Size = New System.Drawing.Size(176, 22)
        Me.CheckForUpdates.Text = "Vérifier mises à jour"
        '
        'AProposToolStripMenuItem
        '
        Me.AProposToolStripMenuItem.Name = "AProposToolStripMenuItem"
        Me.AProposToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.AProposToolStripMenuItem.Text = "A propos"
        '
        'VideoListPanel
        '
        Me.VideoListPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VideoListPanel.BackColor = System.Drawing.SystemColors.ControlLight
        Me.VideoListPanel.Location = New System.Drawing.Point(511, 29)
        Me.VideoListPanel.Name = "VideoListPanel"
        Me.VideoListPanel.Size = New System.Drawing.Size(402, 577)
        Me.VideoListPanel.TabIndex = 3
        '
        'AboutVideo
        '
        Me.AboutVideo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AboutVideo.Controls.Add(Me.VideoDescriptionTextBox)
        Me.AboutVideo.Controls.Add(Me.VideoDateLabel)
        Me.AboutVideo.Controls.Add(Me.VideoUploaderLabel)
        Me.AboutVideo.Controls.Add(Me.VideoTitleLabel)
        Me.AboutVideo.Location = New System.Drawing.Point(13, 396)
        Me.AboutVideo.Name = "AboutVideo"
        Me.AboutVideo.Size = New System.Drawing.Size(492, 210)
        Me.AboutVideo.TabIndex = 5
        Me.AboutVideo.TabStop = False
        Me.AboutVideo.Text = "Informations de la video"
        '
        'VideoDescriptionTextBox
        '
        Me.VideoDescriptionTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VideoDescriptionTextBox.Location = New System.Drawing.Point(10, 71)
        Me.VideoDescriptionTextBox.Multiline = True
        Me.VideoDescriptionTextBox.Name = "VideoDescriptionTextBox"
        Me.VideoDescriptionTextBox.ReadOnly = True
        Me.VideoDescriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.VideoDescriptionTextBox.Size = New System.Drawing.Size(476, 122)
        Me.VideoDescriptionTextBox.TabIndex = 3
        '
        'VideoDateLabel
        '
        Me.VideoDateLabel.AutoSize = True
        Me.VideoDateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VideoDateLabel.Location = New System.Drawing.Point(7, 54)
        Me.VideoDateLabel.Name = "VideoDateLabel"
        Me.VideoDateLabel.Size = New System.Drawing.Size(34, 13)
        Me.VideoDateLabel.TabIndex = 2
        Me.VideoDateLabel.Text = "[date]"
        '
        'VideoUploaderLabel
        '
        Me.VideoUploaderLabel.AutoSize = True
        Me.VideoUploaderLabel.Location = New System.Drawing.Point(7, 37)
        Me.VideoUploaderLabel.Name = "VideoUploaderLabel"
        Me.VideoUploaderLabel.Size = New System.Drawing.Size(54, 13)
        Me.VideoUploaderLabel.TabIndex = 1
        Me.VideoUploaderLabel.Text = "[uploader]"
        '
        'VideoTitleLabel
        '
        Me.VideoTitleLabel.AutoSize = True
        Me.VideoTitleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VideoTitleLabel.Location = New System.Drawing.Point(7, 20)
        Me.VideoTitleLabel.Name = "VideoTitleLabel"
        Me.VideoTitleLabel.Size = New System.Drawing.Size(44, 16)
        Me.VideoTitleLabel.TabIndex = 0
        Me.VideoTitleLabel.Text = "[titre]"
        '
        'ResComboBox
        '
        Me.ResComboBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ResComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ResComboBox.FormattingEnabled = True
        Me.ResComboBox.Location = New System.Drawing.Point(13, 369)
        Me.ResComboBox.Name = "ResComboBox"
        Me.ResComboBox.Size = New System.Drawing.Size(61, 21)
        Me.ResComboBox.TabIndex = 7
        '
        'FullScreenButton
        '
        Me.FullScreenButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.FullScreenButton.Location = New System.Drawing.Point(81, 368)
        Me.FullScreenButton.Name = "FullScreenButton"
        Me.FullScreenButton.Size = New System.Drawing.Size(75, 23)
        Me.FullScreenButton.TabIndex = 8
        Me.FullScreenButton.Text = "Plein écran"
        Me.FullScreenButton.UseVisualStyleBackColor = True
        '
        'ReloadVideoListButton
        '
        Me.ReloadVideoListButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ReloadVideoListButton.BackgroundImage = Global.TurionVidsClientWIN.My.Resources.Resources.reload_icon
        Me.ReloadVideoListButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ReloadVideoListButton.Location = New System.Drawing.Point(871, 7)
        Me.ReloadVideoListButton.Name = "ReloadVideoListButton"
        Me.ReloadVideoListButton.Size = New System.Drawing.Size(23, 23)
        Me.ReloadVideoListButton.TabIndex = 9
        Me.ReloadVideoListButton.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(924, 631)
        Me.Controls.Add(Me.ReloadVideoListButton)
        Me.Controls.Add(Me.FullScreenButton)
        Me.Controls.Add(Me.ResComboBox)
        Me.Controls.Add(Me.AboutVideo)
        Me.Controls.Add(Me.VideoListPanel)
        Me.Controls.Add(Me.TopBar)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.WMPlayer)
        Me.Name = "Main"
        Me.Text = "Main"
        CType(Me.WMPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.TopBar.ResumeLayout(False)
        Me.TopBar.PerformLayout()
        Me.AboutVideo.ResumeLayout(False)
        Me.AboutVideo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents WMPlayer As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents BottomBarStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TopBar As System.Windows.Forms.ToolStrip
    Friend WithEvents ClientTopBarButton As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents RéglagesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuitterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VideoListPanel As System.Windows.Forms.Panel
    Friend WithEvents InitialisationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutVideo As System.Windows.Forms.GroupBox
    Friend WithEvents VideoDescriptionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents VideoDateLabel As System.Windows.Forms.Label
    Friend WithEvents VideoUploaderLabel As System.Windows.Forms.Label
    Friend WithEvents VideoTitleLabel As System.Windows.Forms.Label
    Friend WithEvents OuvrirVideoIDToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents FullScreenButton As System.Windows.Forms.Button
    Friend WithEvents BGWmplayer As System.ComponentModel.BackgroundWorker
    Friend WithEvents AboutTopBarButton As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents CheckForUpdates As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AProposToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReloadVideoListButton As System.Windows.Forms.Button
End Class
