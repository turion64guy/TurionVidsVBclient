<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class About
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
        Me.DevLabel = New System.Windows.Forms.Label()
        Me.DateLabel = New System.Windows.Forms.Label()
        Me.TurionVidsLabel1 = New System.Windows.Forms.Label()
        Me.TurionVidsLabel2 = New System.Windows.Forms.Label()
        Me.TurionVidsLinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.TurionVidsLinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.VersionLabel = New System.Windows.Forms.Label()
        Me.GithubLinkLabel = New System.Windows.Forms.LinkLabel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DevLabel
        '
        Me.DevLabel.AutoSize = True
        Me.DevLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DevLabel.Location = New System.Drawing.Point(138, 90)
        Me.DevLabel.Name = "DevLabel"
        Me.DevLabel.Size = New System.Drawing.Size(114, 18)
        Me.DevLabel.TabIndex = 0
        Me.DevLabel.Text = "Turion 64 Guy"
        '
        'DateLabel
        '
        Me.DateLabel.AutoSize = True
        Me.DateLabel.Location = New System.Drawing.Point(221, 108)
        Me.DateLabel.Name = "DateLabel"
        Me.DateLabel.Size = New System.Drawing.Size(31, 13)
        Me.DateLabel.TabIndex = 1
        Me.DateLabel.Text = "2019"
        '
        'TurionVidsLabel1
        '
        Me.TurionVidsLabel1.AutoSize = True
        Me.TurionVidsLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TurionVidsLabel1.Location = New System.Drawing.Point(138, 9)
        Me.TurionVidsLabel1.Name = "TurionVidsLabel1"
        Me.TurionVidsLabel1.Size = New System.Drawing.Size(281, 39)
        Me.TurionVidsLabel1.TabIndex = 2
        Me.TurionVidsLabel1.Text = "TurionVids Client"
        '
        'TurionVidsLabel2
        '
        Me.TurionVidsLabel2.AutoSize = True
        Me.TurionVidsLabel2.Location = New System.Drawing.Point(348, 43)
        Me.TurionVidsLabel2.Name = "TurionVidsLabel2"
        Me.TurionVidsLabel2.Size = New System.Drawing.Size(69, 13)
        Me.TurionVidsLabel2.TabIndex = 3
        Me.TurionVidsLabel2.Text = "For Windows"
        '
        'TurionVidsLinkLabel1
        '
        Me.TurionVidsLinkLabel1.AutoSize = True
        Me.TurionVidsLinkLabel1.Location = New System.Drawing.Point(142, 48)
        Me.TurionVidsLinkLabel1.Name = "TurionVidsLinkLabel1"
        Me.TurionVidsLinkLabel1.Size = New System.Drawing.Size(133, 13)
        Me.TurionVidsLinkLabel1.TabIndex = 4
        Me.TurionVidsLinkLabel1.TabStop = True
        Me.TurionVidsLinkLabel1.Text = "http://turion64.fr.nf/video/"
        '
        'TurionVidsLinkLabel2
        '
        Me.TurionVidsLinkLabel2.AutoSize = True
        Me.TurionVidsLinkLabel2.Location = New System.Drawing.Point(142, 61)
        Me.TurionVidsLinkLabel2.Name = "TurionVidsLinkLabel2"
        Me.TurionVidsLinkLabel2.Size = New System.Drawing.Size(219, 13)
        Me.TurionVidsLinkLabel2.TabIndex = 5
        Me.TurionVidsLinkLabel2.TabStop = True
        Me.TurionVidsLinkLabel2.Text = "http://turion64.fr.nf/projets/TurionVidsClient/"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(113, 113)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(113, 113)
        Me.Panel1.TabIndex = 7
        '
        'VersionLabel
        '
        Me.VersionLabel.AutoSize = True
        Me.VersionLabel.Location = New System.Drawing.Point(387, 4)
        Me.VersionLabel.Name = "VersionLabel"
        Me.VersionLabel.Size = New System.Drawing.Size(0, 13)
        Me.VersionLabel.TabIndex = 8
        '
        'GithubLinkLabel
        '
        Me.GithubLinkLabel.AutoSize = True
        Me.GithubLinkLabel.Location = New System.Drawing.Point(142, 74)
        Me.GithubLinkLabel.Name = "GithubLinkLabel"
        Me.GithubLinkLabel.Size = New System.Drawing.Size(254, 13)
        Me.GithubLinkLabel.TabIndex = 9
        Me.GithubLinkLabel.TabStop = True
        Me.GithubLinkLabel.Text = "https://github.com/turion64guy/TurionVidsVBclient/"
        '
        'About
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(431, 137)
        Me.Controls.Add(Me.GithubLinkLabel)
        Me.Controls.Add(Me.VersionLabel)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TurionVidsLinkLabel2)
        Me.Controls.Add(Me.TurionVidsLinkLabel1)
        Me.Controls.Add(Me.TurionVidsLabel2)
        Me.Controls.Add(Me.TurionVidsLabel1)
        Me.Controls.Add(Me.DateLabel)
        Me.Controls.Add(Me.DevLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "About"
        Me.Text = "A propos"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DevLabel As System.Windows.Forms.Label
    Friend WithEvents DateLabel As System.Windows.Forms.Label
    Friend WithEvents TurionVidsLabel1 As System.Windows.Forms.Label
    Friend WithEvents TurionVidsLabel2 As System.Windows.Forms.Label
    Friend WithEvents TurionVidsLinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents TurionVidsLinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents VersionLabel As System.Windows.Forms.Label
    Friend WithEvents GithubLinkLabel As System.Windows.Forms.LinkLabel
End Class
