Imports System.Configuration
Public Class Settings
    Dim PreviousState As Integer
    Private Sub Settings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.TurionVidsIcon
        With PlayerComboBox
            .Items.Add("Windows Media Player")
            .Items.Add("VLC")
        End With
        Select Case My.Settings.Player
            Case 0
                PlayerComboBox.SelectedIndex = 0
                PreviousState = 0
                CurrentPlayerLabel.Text = "Actuel : Windows Media Player"
            Case 1
                PlayerComboBox.SelectedIndex = 1
                PreviousState = 1
                CurrentPlayerLabel.Text = "Actuel : VLC"
        End Select
    End Sub

    Private Sub ValidateSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ValidateSettings.Click
        Dim PlayerSetting As Integer
        Select Case PlayerComboBox.SelectedIndex
            Case 0
                PlayerSetting = 0
            Case 1
                PlayerSetting = 1
        End Select

        My.Settings.Player = PlayerSetting
        My.Settings.Save()
        If Not PreviousState = PlayerSetting Then
            MessageBox.Show("Vous avez changé un reglage qui requiert le relancement de l'application", "Remarque", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Player.Quit() ' To avoid dll problems
            Application.Restart()
        End If
        Me.Close()
    End Sub

    Private Sub CancelSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelSettings.Click
        Me.Close()
    End Sub
End Class
