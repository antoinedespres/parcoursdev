<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inscription
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inscription))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LabelAge = New System.Windows.Forms.Label()
        Me.LabelAgeSelect = New System.Windows.Forms.Label()
        Me.HScrollBarAge = New System.Windows.Forms.HScrollBar()
        Me.LabelVille = New System.Windows.Forms.Label()
        Me.LabelCP = New System.Windows.Forms.Label()
        Me.VilleCandidat = New System.Windows.Forms.TextBox()
        Me.CPCandidat = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.LabelAdresse = New System.Windows.Forms.Label()
        Me.LabelPrenom = New System.Windows.Forms.Label()
        Me.LabelNom = New System.Windows.Forms.Label()
        Me.AdresseCandidat = New System.Windows.Forms.TextBox()
        Me.PrenomCandidat = New System.Windows.Forms.TextBox()
        Me.NomCandidat = New System.Windows.Forms.TextBox()
        Me.TimerInscription = New System.Windows.Forms.Timer(Me.components)
        Me.Abandonner = New System.Windows.Forms.Button()
        Me.Enregistrer = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LabelAge)
        Me.GroupBox1.Controls.Add(Me.LabelAgeSelect)
        Me.GroupBox1.Controls.Add(Me.HScrollBarAge)
        Me.GroupBox1.Controls.Add(Me.LabelVille)
        Me.GroupBox1.Controls.Add(Me.LabelCP)
        Me.GroupBox1.Controls.Add(Me.VilleCandidat)
        Me.GroupBox1.Controls.Add(Me.CPCandidat)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.LabelAdresse)
        Me.GroupBox1.Controls.Add(Me.LabelPrenom)
        Me.GroupBox1.Controls.Add(Me.LabelNom)
        Me.GroupBox1.Controls.Add(Me.AdresseCandidat)
        Me.GroupBox1.Controls.Add(Me.PrenomCandidat)
        Me.GroupBox1.Controls.Add(Me.NomCandidat)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 117)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(335, 213)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = false
        Me.GroupBox1.Text = "Coordonnées"
        '
        'LabelAge
        '
        Me.LabelAge.AutoSize = true
        Me.LabelAge.Location = New System.Drawing.Point(47, 187)
        Me.LabelAge.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelAge.Name = "LabelAge"
        Me.LabelAge.Size = New System.Drawing.Size(26, 13)
        Me.LabelAge.TabIndex = 13
        Me.LabelAge.Text = "Âge"
        '
        'LabelAgeSelect
        '
        Me.LabelAgeSelect.AutoSize = true
        Me.LabelAgeSelect.Location = New System.Drawing.Point(286, 187)
        Me.LabelAgeSelect.Name = "LabelAgeSelect"
        Me.LabelAgeSelect.Size = New System.Drawing.Size(25, 13)
        Me.LabelAgeSelect.TabIndex = 12
        Me.LabelAgeSelect.Text = "âge"
        '
        'HScrollBarAge
        '
        Me.HScrollBarAge.Location = New System.Drawing.Point(90, 181)
        Me.HScrollBarAge.Maximum = 55
        Me.HScrollBarAge.Minimum = 18
        Me.HScrollBarAge.Name = "HScrollBarAge"
        Me.HScrollBarAge.Size = New System.Drawing.Size(180, 20)
        Me.HScrollBarAge.TabIndex = 5
        Me.HScrollBarAge.Value = 18
        '
        'LabelVille
        '
        Me.LabelVille.AutoSize = true
        Me.LabelVille.Location = New System.Drawing.Point(47, 150)
        Me.LabelVille.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelVille.Name = "LabelVille"
        Me.LabelVille.Size = New System.Drawing.Size(26, 13)
        Me.LabelVille.TabIndex = 11
        Me.LabelVille.Text = "Ville"
        '
        'LabelCP
        '
        Me.LabelCP.AutoSize = true
        Me.LabelCP.Location = New System.Drawing.Point(9, 124)
        Me.LabelCP.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelCP.Name = "LabelCP"
        Me.LabelCP.Size = New System.Drawing.Size(63, 13)
        Me.LabelCP.TabIndex = 10
        Me.LabelCP.Text = "Code postal"
        '
        'VilleCandidat
        '
        Me.VilleCandidat.Location = New System.Drawing.Point(90, 143)
        Me.VilleCandidat.MaxLength = 15
        Me.VilleCandidat.Name = "VilleCandidat"
        Me.VilleCandidat.Size = New System.Drawing.Size(180, 20)
        Me.VilleCandidat.TabIndex = 4
        '
        'CPCandidat
        '
        Me.CPCandidat.Location = New System.Drawing.Point(90, 117)
        Me.CPCandidat.MaxLength = 5
        Me.CPCandidat.Name = "CPCandidat"
        Me.CPCandidat.Size = New System.Drawing.Size(100, 20)
        Me.CPCandidat.TabIndex = 3
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(8, -91)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(91, 20)
        Me.TextBox1.TabIndex = 7
        '
        'LabelAdresse
        '
        Me.LabelAdresse.AutoSize = true
        Me.LabelAdresse.Location = New System.Drawing.Point(27, 92)
        Me.LabelAdresse.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelAdresse.Name = "LabelAdresse"
        Me.LabelAdresse.Size = New System.Drawing.Size(45, 13)
        Me.LabelAdresse.TabIndex = 6
        Me.LabelAdresse.Text = "Adresse"
        '
        'LabelPrenom
        '
        Me.LabelPrenom.AutoSize = true
        Me.LabelPrenom.Location = New System.Drawing.Point(29, 60)
        Me.LabelPrenom.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelPrenom.Name = "LabelPrenom"
        Me.LabelPrenom.Size = New System.Drawing.Size(43, 13)
        Me.LabelPrenom.TabIndex = 5
        Me.LabelPrenom.Text = "Prénom"
        '
        'LabelNom
        '
        Me.LabelNom.AutoSize = true
        Me.LabelNom.Location = New System.Drawing.Point(44, 30)
        Me.LabelNom.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelNom.Name = "LabelNom"
        Me.LabelNom.Size = New System.Drawing.Size(29, 13)
        Me.LabelNom.TabIndex = 4
        Me.LabelNom.Text = "Nom"
        '
        'AdresseCandidat
        '
        Me.AdresseCandidat.Location = New System.Drawing.Point(90, 92)
        Me.AdresseCandidat.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.AdresseCandidat.MaxLength = 30
        Me.AdresseCandidat.Name = "AdresseCandidat"
        Me.AdresseCandidat.Size = New System.Drawing.Size(180, 20)
        Me.AdresseCandidat.TabIndex = 2
        '
        'PrenomCandidat
        '
        Me.PrenomCandidat.Location = New System.Drawing.Point(90, 60)
        Me.PrenomCandidat.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PrenomCandidat.MaxLength = 20
        Me.PrenomCandidat.Name = "PrenomCandidat"
        Me.PrenomCandidat.Size = New System.Drawing.Size(180, 20)
        Me.PrenomCandidat.TabIndex = 1
        '
        'NomCandidat
        '
        Me.NomCandidat.Location = New System.Drawing.Point(90, 30)
        Me.NomCandidat.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.NomCandidat.MaxLength = 15
        Me.NomCandidat.Name = "NomCandidat"
        Me.NomCandidat.Size = New System.Drawing.Size(180, 20)
        Me.NomCandidat.TabIndex = 0
        '
        'TimerInscription
        '
        Me.TimerInscription.Interval = 1000
        '
        'Abandonner
        '
        Me.Abandonner.Location = New System.Drawing.Point(29, 363)
        Me.Abandonner.Name = "Abandonner"
        Me.Abandonner.Size = New System.Drawing.Size(115, 38)
        Me.Abandonner.TabIndex = 1
        Me.Abandonner.Text = "Abandonner"
        Me.Abandonner.UseVisualStyleBackColor = true
        '
        'Enregistrer
        '
        Me.Enregistrer.Location = New System.Drawing.Point(166, 363)
        Me.Enregistrer.Name = "Enregistrer"
        Me.Enregistrer.Size = New System.Drawing.Size(115, 38)
        Me.Enregistrer.TabIndex = 2
        Me.Enregistrer.Text = "Enregistrer"
        Me.Enregistrer.UseVisualStyleBackColor = true
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Parcoursdev.My.Resources.Resources.logo_large
        Me.PictureBox1.Location = New System.Drawing.Point(29, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(236, 57)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = false
        '
        'Inscription
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(356, 429)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Enregistrer)
        Me.Controls.Add(Me.Abandonner)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Inscription"
        Me.Text = "Inscription"
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents AdresseCandidat As TextBox
    Friend WithEvents PrenomCandidat As TextBox
    Friend WithEvents NomCandidat As TextBox
    Friend WithEvents LabelNom As Label
    Friend WithEvents LabelAdresse As Label
    Friend WithEvents LabelPrenom As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents CPCandidat As TextBox
    Friend WithEvents LabelCP As Label
    Friend WithEvents VilleCandidat As TextBox
    Friend WithEvents LabelVille As Label
    Friend WithEvents TimerInscription As Timer
    Friend WithEvents HScrollBarAge As HScrollBar
    Friend WithEvents Abandonner As Button
    Friend WithEvents Enregistrer As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LabelAge As Label
    Friend WithEvents LabelAgeSelect As Label
End Class
