<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Settings))
        Me.SettingsTabControl = New System.Windows.Forms.TabControl()
        Me.PlayerTabPage = New System.Windows.Forms.TabPage()
        Me.PlayerNoticeLabel = New System.Windows.Forms.Label()
        Me.CurrentPlayerLabel = New System.Windows.Forms.Label()
        Me.PlayerComboBox = New System.Windows.Forms.ComboBox()
        Me.PlayerToUseLabel = New System.Windows.Forms.Label()
        Me.ValidateSettings = New System.Windows.Forms.Button()
        Me.CancelSettings = New System.Windows.Forms.Button()
        Me.SettingsTabControl.SuspendLayout()
        Me.PlayerTabPage.SuspendLayout()
        Me.SuspendLayout()
        '
        'SettingsTabControl
        '
        Me.SettingsTabControl.Controls.Add(Me.PlayerTabPage)
        Me.SettingsTabControl.Location = New System.Drawing.Point(12, 13)
        Me.SettingsTabControl.Name = "SettingsTabControl"
        Me.SettingsTabControl.SelectedIndex = 0
        Me.SettingsTabControl.Size = New System.Drawing.Size(413, 258)
        Me.SettingsTabControl.TabIndex = 1
        '
        'PlayerTabPage
        '
        Me.PlayerTabPage.Controls.Add(Me.PlayerNoticeLabel)
        Me.PlayerTabPage.Controls.Add(Me.CurrentPlayerLabel)
        Me.PlayerTabPage.Controls.Add(Me.PlayerComboBox)
        Me.PlayerTabPage.Controls.Add(Me.PlayerToUseLabel)
        Me.PlayerTabPage.Location = New System.Drawing.Point(4, 22)
        Me.PlayerTabPage.Name = "PlayerTabPage"
        Me.PlayerTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.PlayerTabPage.Size = New System.Drawing.Size(405, 232)
        Me.PlayerTabPage.TabIndex = 0
        Me.PlayerTabPage.Text = "Lecteur"
        Me.PlayerTabPage.UseVisualStyleBackColor = True
        '
        'PlayerNoticeLabel
        '
        Me.PlayerNoticeLabel.AutoSize = True
        Me.PlayerNoticeLabel.Location = New System.Drawing.Point(7, 34)
        Me.PlayerNoticeLabel.Name = "PlayerNoticeLabel"
        Me.PlayerNoticeLabel.Size = New System.Drawing.Size(314, 91)
        Me.PlayerNoticeLabel.TabIndex = 3
        Me.PlayerNoticeLabel.Text = resources.GetString("PlayerNoticeLabel.Text")
        '
        'CurrentPlayerLabel
        '
        Me.CurrentPlayerLabel.AutoSize = True
        Me.CurrentPlayerLabel.Location = New System.Drawing.Point(244, 10)
        Me.CurrentPlayerLabel.Name = "CurrentPlayerLabel"
        Me.CurrentPlayerLabel.Size = New System.Drawing.Size(34, 13)
        Me.CurrentPlayerLabel.TabIndex = 2
        Me.CurrentPlayerLabel.Text = "undef"
        '
        'PlayerComboBox
        '
        Me.PlayerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PlayerComboBox.FormattingEnabled = True
        Me.PlayerComboBox.Location = New System.Drawing.Point(100, 7)
        Me.PlayerComboBox.Name = "PlayerComboBox"
        Me.PlayerComboBox.Size = New System.Drawing.Size(138, 21)
        Me.PlayerComboBox.TabIndex = 1
        '
        'PlayerToUseLabel
        '
        Me.PlayerToUseLabel.AutoSize = True
        Me.PlayerToUseLabel.Location = New System.Drawing.Point(7, 10)
        Me.PlayerToUseLabel.Name = "PlayerToUseLabel"
        Me.PlayerToUseLabel.Size = New System.Drawing.Size(87, 13)
        Me.PlayerToUseLabel.TabIndex = 0
        Me.PlayerToUseLabel.Text = "Lecteur à utiliser "
        '
        'ValidateSettings
        '
        Me.ValidateSettings.Location = New System.Drawing.Point(350, 277)
        Me.ValidateSettings.Name = "ValidateSettings"
        Me.ValidateSettings.Size = New System.Drawing.Size(75, 23)
        Me.ValidateSettings.TabIndex = 2
        Me.ValidateSettings.Text = "OK"
        Me.ValidateSettings.UseVisualStyleBackColor = True
        '
        'CancelSettings
        '
        Me.CancelSettings.Location = New System.Drawing.Point(269, 277)
        Me.CancelSettings.Name = "CancelSettings"
        Me.CancelSettings.Size = New System.Drawing.Size(75, 23)
        Me.CancelSettings.TabIndex = 3
        Me.CancelSettings.Text = "Annuler"
        Me.CancelSettings.UseVisualStyleBackColor = True
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(437, 308)
        Me.Controls.Add(Me.CancelSettings)
        Me.Controls.Add(Me.ValidateSettings)
        Me.Controls.Add(Me.SettingsTabControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Settings"
        Me.Text = "Réglages"
        Me.SettingsTabControl.ResumeLayout(False)
        Me.PlayerTabPage.ResumeLayout(False)
        Me.PlayerTabPage.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SettingsTabControl As System.Windows.Forms.TabControl
    Friend WithEvents PlayerTabPage As System.Windows.Forms.TabPage
    Friend WithEvents PlayerComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents PlayerToUseLabel As System.Windows.Forms.Label
    Friend WithEvents ValidateSettings As System.Windows.Forms.Button
    Friend WithEvents CancelSettings As System.Windows.Forms.Button
    Friend WithEvents PlayerNoticeLabel As System.Windows.Forms.Label
    Friend WithEvents CurrentPlayerLabel As System.Windows.Forms.Label
End Class
