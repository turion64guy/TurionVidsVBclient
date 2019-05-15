Public Class About
    WithEvents animTimer As New Timer
    Dim mode As Boolean ' 0=zoom ; 1=dezoom
    Dim angle As Single
    Dim TvidsLogo As Image = My.Resources.TurionVidsLogo
    Dim prevX As Integer = TvidsLogo.Width
    Dim prevY As Integer = TvidsLogo.Height
    Dim Xloc As Integer = 0
    Dim Yloc As Integer = 0

    Private Sub About_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.TurionVidsIcon
        VersionLabel.Text = "v" & Main.clientver
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        animTimer.Interval = 35
        animTimer.Start()
    End Sub
    Private Sub About_Close() Handles MyBase.FormClosing
        animTimer.Stop()
        animTimer.Dispose()
    End Sub
    Private Sub TurionVidsLinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles TurionVidsLinkLabel1.LinkClicked
        Process.Start("http://turion64.fr.nf/video/")
    End Sub
    Private Sub TurionVidsLinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles TurionVidsLinkLabel2.LinkClicked
        Process.Start("http://turion64.fr.nf/projets/TurionVidsClient/")
    End Sub
    Private Sub GithubLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles GithubLinkLabel.LinkClicked
        Process.Start("https://github.com/turion64guy/TurionVidsVBclient/")
    End Sub
    Private Sub animTimerSub() Handles animTimer.Tick
        Dim x As Integer
        Dim y As Integer
        Dim MaxSize As Integer = 600
        Dim MinSize As Integer = 70
        Dim totalVertical As Integer = 5
        Dim totalHorizontal As Integer = 5
        Dim angleInterval = 5
        Dim added As Integer = 10

        totalVertical = (totalVertical - 1) / 2
        totalHorizontal = (totalHorizontal - 1) / 2
        angle = angle + angleInterval

        Dim TvidsLogoCache As Image = TvidsLogo.Clone
        Dim imgClone As Image = TvidsLogoCache.Clone
        Dim image As Graphics = Graphics.FromImage(TvidsLogoCache)
        image.Clear(Me.BackColor)
        'Translate to the center of the image
        image.TranslateTransform(imgClone.Width / 2, imgClone.Height / 2)
        'Rotate about center of image
        image.RotateTransform(angle)
        'Translate back
        image.TranslateTransform(-imgClone.Width / 2, -imgClone.Height / 2)

        Select Case mode
            Case 0
                'zoom mode
                x = prevX + added
                y = prevY + added
                Xloc = Xloc - added / 2
                Yloc = Yloc - added / 2
                If x >= MaxSize Then
                    mode = Not (mode) ' invert boolean
                End If
            Case 1
                x = prevX - added
                y = prevY - added
                Xloc = Xloc + added / 2
                Yloc = Yloc + added / 2
                If x <= MinSize Then
                    mode = Not (mode) ' invert boolean
                End If
        End Select
        prevX = x
        prevY = y

        'Draw the image
        For b = (-totalHorizontal) To totalHorizontal
            For a = (-totalVertical) To totalVertical
                image.DrawImage(imgClone, Xloc + (prevX * a), Yloc + (prevX * b), x + 1, y + 1)
            Next
        Next
        'Display the results in a PictureBox
        PictureBox1.Image = TvidsLogoCache.Clone
        imgClone.Dispose()
        'imgOrig.Dispose()
        image.Dispose()

        If angle >= 3600 Then
            angle = 0
        End If
    End Sub
End Class