<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Recap
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Recap))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelNom = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LabelPrenom = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LabelAdresse = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LabelRegion = New System.Windows.Forms.Label()
        Me.GroupBoxEcrit = New System.Windows.Forms.GroupBox()
        Me.LabelEcrit4 = New System.Windows.Forms.Label()
        Me.LabelEcrit3 = New System.Windows.Forms.Label()
        Me.LabelEcrit2 = New System.Windows.Forms.Label()
        Me.LabelEcrit1 = New System.Windows.Forms.Label()
        Me.GroupBoxOral = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Retour = New System.Windows.Forms.Button()
        Me.Abandonner = New System.Windows.Forms.Button()
        Me.Enregistrer = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LabelFacultative = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.LabelCP = New System.Windows.Forms.Label()
        Me.LabelVille = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LabelAge = New System.Windows.Forms.Label()
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBoxEcrit.SuspendLayout
        Me.GroupBoxOral.SuspendLayout
        Me.SuspendLayout
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Parcoursdev.My.Resources.Resources.logo_large
        Me.PictureBox1.Location = New System.Drawing.Point(10, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(236, 57)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = false
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(8, 76)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Nom :"
        '
        'LabelNom
        '
        Me.LabelNom.AutoSize = true
        Me.LabelNom.Location = New System.Drawing.Point(58, 76)
        Me.LabelNom.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelNom.Name = "LabelNom"
        Me.LabelNom.Size = New System.Drawing.Size(39, 13)
        Me.LabelNom.TabIndex = 6
        Me.LabelNom.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Location = New System.Drawing.Point(8, 93)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Prénom :"
        '
        'LabelPrenom
        '
        Me.LabelPrenom.AutoSize = true
        Me.LabelPrenom.Location = New System.Drawing.Point(58, 93)
        Me.LabelPrenom.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelPrenom.Name = "LabelPrenom"
        Me.LabelPrenom.Size = New System.Drawing.Size(39, 13)
        Me.LabelPrenom.TabIndex = 8
        Me.LabelPrenom.Text = "Label4"
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Location = New System.Drawing.Point(10, 121)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Adresse :"
        '
        'LabelAdresse
        '
        Me.LabelAdresse.AutoSize = true
        Me.LabelAdresse.Location = New System.Drawing.Point(60, 121)
        Me.LabelAdresse.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelAdresse.Name = "LabelAdresse"
        Me.LabelAdresse.Size = New System.Drawing.Size(39, 13)
        Me.LabelAdresse.TabIndex = 10
        Me.LabelAdresse.Text = "Label6"
        '
        'Label7
        '
        Me.Label7.AutoSize = true
        Me.Label7.Location = New System.Drawing.Point(212, 76)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Région :"
        '
        'LabelRegion
        '
        Me.LabelRegion.AutoSize = true
        Me.LabelRegion.Location = New System.Drawing.Point(268, 76)
        Me.LabelRegion.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelRegion.Name = "LabelRegion"
        Me.LabelRegion.Size = New System.Drawing.Size(39, 13)
        Me.LabelRegion.TabIndex = 12
        Me.LabelRegion.Text = "Label8"
        '
        'GroupBoxEcrit
        '
        Me.GroupBoxEcrit.Controls.Add(Me.LabelEcrit4)
        Me.GroupBoxEcrit.Controls.Add(Me.LabelEcrit3)
        Me.GroupBoxEcrit.Controls.Add(Me.LabelEcrit2)
        Me.GroupBoxEcrit.Controls.Add(Me.LabelEcrit1)
        Me.GroupBoxEcrit.Location = New System.Drawing.Point(10, 176)
        Me.GroupBoxEcrit.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBoxEcrit.Name = "GroupBoxEcrit"
        Me.GroupBoxEcrit.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBoxEcrit.Size = New System.Drawing.Size(150, 90)
        Me.GroupBoxEcrit.TabIndex = 13
        Me.GroupBoxEcrit.TabStop = false
        Me.GroupBoxEcrit.Text = "Épreuves écrites"
        '
        'LabelEcrit4
        '
        Me.LabelEcrit4.AutoSize = true
        Me.LabelEcrit4.Location = New System.Drawing.Point(5, 64)
        Me.LabelEcrit4.Name = "LabelEcrit4"
        Me.LabelEcrit4.Size = New System.Drawing.Size(39, 13)
        Me.LabelEcrit4.TabIndex = 3
        Me.LabelEcrit4.Text = "Label8"
        '
        'LabelEcrit3
        '
        Me.LabelEcrit3.AutoSize = true
        Me.LabelEcrit3.Location = New System.Drawing.Point(5, 51)
        Me.LabelEcrit3.Name = "LabelEcrit3"
        Me.LabelEcrit3.Size = New System.Drawing.Size(39, 13)
        Me.LabelEcrit3.TabIndex = 2
        Me.LabelEcrit3.Text = "Label6"
        '
        'LabelEcrit2
        '
        Me.LabelEcrit2.AutoSize = true
        Me.LabelEcrit2.Location = New System.Drawing.Point(5, 38)
        Me.LabelEcrit2.Name = "LabelEcrit2"
        Me.LabelEcrit2.Size = New System.Drawing.Size(39, 13)
        Me.LabelEcrit2.TabIndex = 1
        Me.LabelEcrit2.Text = "Label4"
        '
        'LabelEcrit1
        '
        Me.LabelEcrit1.AutoSize = true
        Me.LabelEcrit1.Location = New System.Drawing.Point(5, 25)
        Me.LabelEcrit1.Name = "LabelEcrit1"
        Me.LabelEcrit1.Size = New System.Drawing.Size(39, 13)
        Me.LabelEcrit1.TabIndex = 0
        Me.LabelEcrit1.Text = "Label2"
        '
        'GroupBoxOral
        '
        Me.GroupBoxOral.Controls.Add(Me.Label12)
        Me.GroupBoxOral.Controls.Add(Me.Label11)
        Me.GroupBoxOral.Controls.Add(Me.Label10)
        Me.GroupBoxOral.Location = New System.Drawing.Point(168, 176)
        Me.GroupBoxOral.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBoxOral.Name = "GroupBoxOral"
        Me.GroupBoxOral.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBoxOral.Size = New System.Drawing.Size(134, 90)
        Me.GroupBoxOral.TabIndex = 14
        Me.GroupBoxOral.TabStop = false
        Me.GroupBoxOral.Text = "Épreuves orales"
        '
        'Label12
        '
        Me.Label12.AutoSize = true
        Me.Label12.Location = New System.Drawing.Point(5, 52)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 13)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Label12"
        '
        'Label11
        '
        Me.Label11.AutoSize = true
        Me.Label11.Location = New System.Drawing.Point(6, 39)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 13)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Label11"
        '
        'Label10
        '
        Me.Label10.AutoSize = true
        Me.Label10.Location = New System.Drawing.Point(6, 26)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Label10"
        '
        'Retour
        '
        Me.Retour.Location = New System.Drawing.Point(13, 315)
        Me.Retour.Name = "Retour"
        Me.Retour.Size = New System.Drawing.Size(75, 23)
        Me.Retour.TabIndex = 15
        Me.Retour.Text = "Retour"
        Me.Retour.UseVisualStyleBackColor = true
        '
        'Abandonner
        '
        Me.Abandonner.Location = New System.Drawing.Point(221, 315)
        Me.Abandonner.Name = "Abandonner"
        Me.Abandonner.Size = New System.Drawing.Size(75, 23)
        Me.Abandonner.TabIndex = 16
        Me.Abandonner.Text = "Abandonner"
        Me.Abandonner.UseVisualStyleBackColor = true
        '
        'Enregistrer
        '
        Me.Enregistrer.Location = New System.Drawing.Point(221, 344)
        Me.Enregistrer.Name = "Enregistrer"
        Me.Enregistrer.Size = New System.Drawing.Size(75, 23)
        Me.Enregistrer.TabIndex = 17
        Me.Enregistrer.Text = "Enregistrer"
        Me.Enregistrer.UseVisualStyleBackColor = true
        '
        'Label9
        '
        Me.Label9.AutoSize = true
        Me.Label9.Location = New System.Drawing.Point(10, 278)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(105, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Épreuve facultative :"
        '
        'LabelFacultative
        '
        Me.LabelFacultative.AutoSize = true
        Me.LabelFacultative.Location = New System.Drawing.Point(122, 278)
        Me.LabelFacultative.Name = "LabelFacultative"
        Me.LabelFacultative.Size = New System.Drawing.Size(39, 13)
        Me.LabelFacultative.TabIndex = 19
        Me.LabelFacultative.Text = "Label2"
        '
        'Label13
        '
        Me.Label13.AutoSize = true
        Me.Label13.Location = New System.Drawing.Point(11, 134)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(69, 13)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "Code postal :"
        '
        'Label14
        '
        Me.Label14.AutoSize = true
        Me.Label14.Location = New System.Drawing.Point(11, 147)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(32, 13)
        Me.Label14.TabIndex = 21
        Me.Label14.Text = "Ville :"
        '
        'LabelCP
        '
        Me.LabelCP.AutoSize = true
        Me.LabelCP.Location = New System.Drawing.Point(86, 134)
        Me.LabelCP.Name = "LabelCP"
        Me.LabelCP.Size = New System.Drawing.Size(45, 13)
        Me.LabelCP.TabIndex = 22
        Me.LabelCP.Text = "Label15"
        '
        'LabelVille
        '
        Me.LabelVille.AutoSize = true
        Me.LabelVille.Location = New System.Drawing.Point(49, 147)
        Me.LabelVille.Name = "LabelVille"
        Me.LabelVille.Size = New System.Drawing.Size(45, 13)
        Me.LabelVille.TabIndex = 23
        Me.LabelVille.Text = "Label15"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(214, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Âge :"
        '
        'LabelAge
        '
        Me.LabelAge.AutoSize = true
        Me.LabelAge.Location = New System.Drawing.Point(268, 93)
        Me.LabelAge.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelAge.Name = "LabelAge"
        Me.LabelAge.Size = New System.Drawing.Size(39, 13)
        Me.LabelAge.TabIndex = 25
        Me.LabelAge.Text = "Label8"
        '
        'Recap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(347, 380)
        Me.Controls.Add(Me.LabelAge)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LabelVille)
        Me.Controls.Add(Me.LabelCP)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.LabelFacultative)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Enregistrer)
        Me.Controls.Add(Me.Abandonner)
        Me.Controls.Add(Me.Retour)
        Me.Controls.Add(Me.GroupBoxOral)
        Me.Controls.Add(Me.GroupBoxEcrit)
        Me.Controls.Add(Me.LabelRegion)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.LabelAdresse)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LabelPrenom)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LabelNom)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Recap"
        Me.Text = "Récapitulatif d'inscription"
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBoxEcrit.ResumeLayout(false)
        Me.GroupBoxEcrit.PerformLayout
        Me.GroupBoxOral.ResumeLayout(false)
        Me.GroupBoxOral.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelNom As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LabelPrenom As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LabelAdresse As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents LabelRegion As Label
    Friend WithEvents GroupBoxEcrit As GroupBox
    Friend WithEvents GroupBoxOral As GroupBox
    Friend WithEvents Retour As Button
    Friend WithEvents Abandonner As Button
    Friend WithEvents Enregistrer As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents LabelEcrit4 As Label
    Friend WithEvents LabelEcrit3 As Label
    Friend WithEvents LabelEcrit2 As Label
    Friend WithEvents LabelEcrit1 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents LabelFacultative As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents LabelCP As Label
    Friend WithEvents LabelVille As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LabelAge As Label
End Class
