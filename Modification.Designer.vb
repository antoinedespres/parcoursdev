<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Modification
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.NumCandidat = New System.Windows.Forms.Label()
        Me.CandidatNum = New System.Windows.Forms.Label()
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.NbEpvEcritRest = New System.Windows.Forms.Label()
        Me.GroupBoxEcrit = New System.Windows.Forms.GroupBox()
        Me.CheckBox12 = New System.Windows.Forms.CheckBox()
        Me.CheckBox11 = New System.Windows.Forms.CheckBox()
        Me.CheckBox10 = New System.Windows.Forms.CheckBox()
        Me.CheckBox9 = New System.Windows.Forms.CheckBox()
        Me.CheckBox8 = New System.Windows.Forms.CheckBox()
        Me.CheckBox7 = New System.Windows.Forms.CheckBox()
        Me.CheckBox6 = New System.Windows.Forms.CheckBox()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.NbEpvOralRest = New System.Windows.Forms.Label()
        Me.GroupBoxOral = New System.Windows.Forms.GroupBox()
        Me.CheckBox21 = New System.Windows.Forms.CheckBox()
        Me.CheckBox20 = New System.Windows.Forms.CheckBox()
        Me.CheckBox19 = New System.Windows.Forms.CheckBox()
        Me.CheckBox18 = New System.Windows.Forms.CheckBox()
        Me.CheckBox17 = New System.Windows.Forms.CheckBox()
        Me.CheckBox16 = New System.Windows.Forms.CheckBox()
        Me.CheckBox15 = New System.Windows.Forms.CheckBox()
        Me.CheckBox14 = New System.Windows.Forms.CheckBox()
        Me.CheckBox13 = New System.Windows.Forms.CheckBox()
        Me.PanelFacultatif = New System.Windows.Forms.Panel()
        Me.LabelEPVFacultative = New System.Windows.Forms.Label()
        Me.ComboBoxFacultative = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RadioButtonNon = New System.Windows.Forms.RadioButton()
        Me.RadioButtonOui = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBoxRegions = New System.Windows.Forms.ComboBox()
        Me.Annuler = New System.Windows.Forms.Button()
        Me.Enregistrer = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBoxEcrit.SuspendLayout
        Me.GroupBoxOral.SuspendLayout
        Me.PanelFacultatif.SuspendLayout
        Me.SuspendLayout
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.NumCandidat)
        Me.GroupBox1.Controls.Add(Me.CandidatNum)
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
        Me.GroupBox1.Location = New System.Drawing.Point(251, 9)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(671, 124)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = false
        Me.GroupBox1.Text = "Coordonnées"
        '
        'NumCandidat
        '
        Me.NumCandidat.AutoSize = true
        Me.NumCandidat.Location = New System.Drawing.Point(627, 28)
        Me.NumCandidat.Name = "NumCandidat"
        Me.NumCandidat.Size = New System.Drawing.Size(14, 13)
        Me.NumCandidat.TabIndex = 15
        Me.NumCandidat.Text = "X"
        '
        'CandidatNum
        '
        Me.CandidatNum.AutoSize = true
        Me.CandidatNum.Location = New System.Drawing.Point(533, 28)
        Me.CandidatNum.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.CandidatNum.Name = "CandidatNum"
        Me.CandidatNum.Size = New System.Drawing.Size(93, 13)
        Me.CandidatNum.TabIndex = 14
        Me.CandidatNum.Text = "Candidat numéro :"
        '
        'LabelAge
        '
        Me.LabelAge.AutoSize = true
        Me.LabelAge.Location = New System.Drawing.Point(371, 95)
        Me.LabelAge.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelAge.Name = "LabelAge"
        Me.LabelAge.Size = New System.Drawing.Size(26, 13)
        Me.LabelAge.TabIndex = 13
        Me.LabelAge.Text = "Âge"
        '
        'LabelAgeSelect
        '
        Me.LabelAgeSelect.AutoSize = true
        Me.LabelAgeSelect.Location = New System.Drawing.Point(610, 95)
        Me.LabelAgeSelect.Name = "LabelAgeSelect"
        Me.LabelAgeSelect.Size = New System.Drawing.Size(25, 13)
        Me.LabelAgeSelect.TabIndex = 12
        Me.LabelAgeSelect.Text = "âge"
        '
        'HScrollBarAge
        '
        Me.HScrollBarAge.Location = New System.Drawing.Point(414, 89)
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
        Me.LabelVille.Location = New System.Drawing.Point(371, 67)
        Me.LabelVille.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelVille.Name = "LabelVille"
        Me.LabelVille.Size = New System.Drawing.Size(26, 13)
        Me.LabelVille.TabIndex = 11
        Me.LabelVille.Text = "Ville"
        '
        'LabelCP
        '
        Me.LabelCP.AutoSize = true
        Me.LabelCP.Location = New System.Drawing.Point(333, 33)
        Me.LabelCP.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelCP.Name = "LabelCP"
        Me.LabelCP.Size = New System.Drawing.Size(63, 13)
        Me.LabelCP.TabIndex = 10
        Me.LabelCP.Text = "Code postal"
        '
        'VilleCandidat
        '
        Me.VilleCandidat.Location = New System.Drawing.Point(414, 60)
        Me.VilleCandidat.MaxLength = 15
        Me.VilleCandidat.Name = "VilleCandidat"
        Me.VilleCandidat.Size = New System.Drawing.Size(180, 20)
        Me.VilleCandidat.TabIndex = 4
        '
        'CPCandidat
        '
        Me.CPCandidat.Location = New System.Drawing.Point(414, 26)
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
        Me.AdresseCandidat.Margin = New System.Windows.Forms.Padding(2)
        Me.AdresseCandidat.MaxLength = 30
        Me.AdresseCandidat.Name = "AdresseCandidat"
        Me.AdresseCandidat.Size = New System.Drawing.Size(180, 20)
        Me.AdresseCandidat.TabIndex = 2
        '
        'PrenomCandidat
        '
        Me.PrenomCandidat.Location = New System.Drawing.Point(90, 60)
        Me.PrenomCandidat.Margin = New System.Windows.Forms.Padding(2)
        Me.PrenomCandidat.MaxLength = 20
        Me.PrenomCandidat.Name = "PrenomCandidat"
        Me.PrenomCandidat.Size = New System.Drawing.Size(180, 20)
        Me.PrenomCandidat.TabIndex = 1
        '
        'NomCandidat
        '
        Me.NomCandidat.Location = New System.Drawing.Point(90, 30)
        Me.NomCandidat.Margin = New System.Windows.Forms.Padding(2)
        Me.NomCandidat.MaxLength = 15
        Me.NomCandidat.Name = "NomCandidat"
        Me.NomCandidat.Size = New System.Drawing.Size(180, 20)
        Me.NomCandidat.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Parcoursdev.My.Resources.Resources.logo_large
        Me.PictureBox1.Location = New System.Drawing.Point(12, 18)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(236, 57)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = false
        '
        'NbEpvEcritRest
        '
        Me.NbEpvEcritRest.AutoSize = true
        Me.NbEpvEcritRest.Location = New System.Drawing.Point(10, 339)
        Me.NbEpvEcritRest.Name = "NbEpvEcritRest"
        Me.NbEpvEcritRest.Size = New System.Drawing.Size(39, 13)
        Me.NbEpvEcritRest.TabIndex = 12
        Me.NbEpvEcritRest.Text = "Label3"
        '
        'GroupBoxEcrit
        '
        Me.GroupBoxEcrit.Controls.Add(Me.CheckBox12)
        Me.GroupBoxEcrit.Controls.Add(Me.CheckBox11)
        Me.GroupBoxEcrit.Controls.Add(Me.CheckBox10)
        Me.GroupBoxEcrit.Controls.Add(Me.CheckBox9)
        Me.GroupBoxEcrit.Controls.Add(Me.CheckBox8)
        Me.GroupBoxEcrit.Controls.Add(Me.CheckBox7)
        Me.GroupBoxEcrit.Controls.Add(Me.CheckBox6)
        Me.GroupBoxEcrit.Controls.Add(Me.CheckBox5)
        Me.GroupBoxEcrit.Controls.Add(Me.CheckBox4)
        Me.GroupBoxEcrit.Controls.Add(Me.CheckBox3)
        Me.GroupBoxEcrit.Controls.Add(Me.CheckBox2)
        Me.GroupBoxEcrit.Controls.Add(Me.CheckBox1)
        Me.GroupBoxEcrit.Location = New System.Drawing.Point(10, 152)
        Me.GroupBoxEcrit.Name = "GroupBoxEcrit"
        Me.GroupBoxEcrit.Size = New System.Drawing.Size(281, 184)
        Me.GroupBoxEcrit.TabIndex = 11
        Me.GroupBoxEcrit.TabStop = false
        Me.GroupBoxEcrit.Text = "Épeuves écrites"
        '
        'CheckBox12
        '
        Me.CheckBox12.AutoSize = true
        Me.CheckBox12.Location = New System.Drawing.Point(141, 140)
        Me.CheckBox12.Name = "CheckBox12"
        Me.CheckBox12.Size = New System.Drawing.Size(87, 17)
        Me.CheckBox12.TabIndex = 11
        Me.CheckBox12.Text = "CheckBox12"
        Me.CheckBox12.UseVisualStyleBackColor = true
        '
        'CheckBox11
        '
        Me.CheckBox11.AutoSize = true
        Me.CheckBox11.Location = New System.Drawing.Point(141, 116)
        Me.CheckBox11.Name = "CheckBox11"
        Me.CheckBox11.Size = New System.Drawing.Size(87, 17)
        Me.CheckBox11.TabIndex = 10
        Me.CheckBox11.Text = "CheckBox11"
        Me.CheckBox11.UseVisualStyleBackColor = true
        '
        'CheckBox10
        '
        Me.CheckBox10.AutoSize = true
        Me.CheckBox10.Location = New System.Drawing.Point(141, 92)
        Me.CheckBox10.Name = "CheckBox10"
        Me.CheckBox10.Size = New System.Drawing.Size(87, 17)
        Me.CheckBox10.TabIndex = 9
        Me.CheckBox10.Text = "CheckBox10"
        Me.CheckBox10.UseVisualStyleBackColor = true
        '
        'CheckBox9
        '
        Me.CheckBox9.AutoSize = true
        Me.CheckBox9.Location = New System.Drawing.Point(141, 68)
        Me.CheckBox9.Name = "CheckBox9"
        Me.CheckBox9.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox9.TabIndex = 8
        Me.CheckBox9.Text = "CheckBox9"
        Me.CheckBox9.UseVisualStyleBackColor = true
        '
        'CheckBox8
        '
        Me.CheckBox8.AutoSize = true
        Me.CheckBox8.Location = New System.Drawing.Point(141, 44)
        Me.CheckBox8.Name = "CheckBox8"
        Me.CheckBox8.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox8.TabIndex = 7
        Me.CheckBox8.Text = "CheckBox8"
        Me.CheckBox8.UseVisualStyleBackColor = true
        '
        'CheckBox7
        '
        Me.CheckBox7.AutoSize = true
        Me.CheckBox7.Location = New System.Drawing.Point(141, 20)
        Me.CheckBox7.Name = "CheckBox7"
        Me.CheckBox7.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox7.TabIndex = 6
        Me.CheckBox7.Text = "CheckBox7"
        Me.CheckBox7.UseVisualStyleBackColor = true
        '
        'CheckBox6
        '
        Me.CheckBox6.AutoSize = true
        Me.CheckBox6.Location = New System.Drawing.Point(18, 140)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox6.TabIndex = 5
        Me.CheckBox6.Text = "CheckBox6"
        Me.CheckBox6.UseVisualStyleBackColor = true
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = true
        Me.CheckBox5.Location = New System.Drawing.Point(18, 116)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox5.TabIndex = 4
        Me.CheckBox5.Text = "CheckBox5"
        Me.CheckBox5.UseVisualStyleBackColor = true
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = true
        Me.CheckBox4.Location = New System.Drawing.Point(18, 92)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox4.TabIndex = 3
        Me.CheckBox4.Text = "CheckBox4"
        Me.CheckBox4.UseVisualStyleBackColor = true
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = true
        Me.CheckBox3.Location = New System.Drawing.Point(18, 68)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox3.TabIndex = 2
        Me.CheckBox3.Text = "CheckBox3"
        Me.CheckBox3.UseVisualStyleBackColor = true
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = true
        Me.CheckBox2.Location = New System.Drawing.Point(18, 44)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox2.TabIndex = 1
        Me.CheckBox2.Text = "CheckBox2"
        Me.CheckBox2.UseVisualStyleBackColor = true
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = true
        Me.CheckBox1.Location = New System.Drawing.Point(18, 20)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = "CheckBox1"
        Me.CheckBox1.UseVisualStyleBackColor = true
        '
        'NbEpvOralRest
        '
        Me.NbEpvOralRest.AutoSize = true
        Me.NbEpvOralRest.Location = New System.Drawing.Point(338, 300)
        Me.NbEpvOralRest.Name = "NbEpvOralRest"
        Me.NbEpvOralRest.Size = New System.Drawing.Size(39, 13)
        Me.NbEpvOralRest.TabIndex = 14
        Me.NbEpvOralRest.Text = "Label4"
        '
        'GroupBoxOral
        '
        Me.GroupBoxOral.Controls.Add(Me.CheckBox21)
        Me.GroupBoxOral.Controls.Add(Me.CheckBox20)
        Me.GroupBoxOral.Controls.Add(Me.CheckBox19)
        Me.GroupBoxOral.Controls.Add(Me.CheckBox18)
        Me.GroupBoxOral.Controls.Add(Me.CheckBox17)
        Me.GroupBoxOral.Controls.Add(Me.CheckBox16)
        Me.GroupBoxOral.Controls.Add(Me.CheckBox15)
        Me.GroupBoxOral.Controls.Add(Me.CheckBox14)
        Me.GroupBoxOral.Controls.Add(Me.CheckBox13)
        Me.GroupBoxOral.Location = New System.Drawing.Point(341, 152)
        Me.GroupBoxOral.Name = "GroupBoxOral"
        Me.GroupBoxOral.Size = New System.Drawing.Size(248, 145)
        Me.GroupBoxOral.TabIndex = 13
        Me.GroupBoxOral.TabStop = false
        Me.GroupBoxOral.Text = "Épreuves orales"
        '
        'CheckBox21
        '
        Me.CheckBox21.AutoSize = true
        Me.CheckBox21.Location = New System.Drawing.Point(137, 92)
        Me.CheckBox21.Name = "CheckBox21"
        Me.CheckBox21.Size = New System.Drawing.Size(87, 17)
        Me.CheckBox21.TabIndex = 8
        Me.CheckBox21.Text = "CheckBox21"
        Me.CheckBox21.UseVisualStyleBackColor = true
        '
        'CheckBox20
        '
        Me.CheckBox20.AutoSize = true
        Me.CheckBox20.Location = New System.Drawing.Point(137, 68)
        Me.CheckBox20.Name = "CheckBox20"
        Me.CheckBox20.Size = New System.Drawing.Size(87, 17)
        Me.CheckBox20.TabIndex = 7
        Me.CheckBox20.Text = "CheckBox20"
        Me.CheckBox20.UseVisualStyleBackColor = true
        '
        'CheckBox19
        '
        Me.CheckBox19.AutoSize = true
        Me.CheckBox19.Location = New System.Drawing.Point(137, 44)
        Me.CheckBox19.Name = "CheckBox19"
        Me.CheckBox19.Size = New System.Drawing.Size(87, 17)
        Me.CheckBox19.TabIndex = 6
        Me.CheckBox19.Text = "CheckBox19"
        Me.CheckBox19.UseVisualStyleBackColor = true
        '
        'CheckBox18
        '
        Me.CheckBox18.AutoSize = true
        Me.CheckBox18.Location = New System.Drawing.Point(137, 20)
        Me.CheckBox18.Name = "CheckBox18"
        Me.CheckBox18.Size = New System.Drawing.Size(87, 17)
        Me.CheckBox18.TabIndex = 5
        Me.CheckBox18.Text = "CheckBox18"
        Me.CheckBox18.UseVisualStyleBackColor = true
        '
        'CheckBox17
        '
        Me.CheckBox17.AutoSize = true
        Me.CheckBox17.Location = New System.Drawing.Point(6, 116)
        Me.CheckBox17.Name = "CheckBox17"
        Me.CheckBox17.Size = New System.Drawing.Size(87, 17)
        Me.CheckBox17.TabIndex = 4
        Me.CheckBox17.Text = "CheckBox17"
        Me.CheckBox17.UseVisualStyleBackColor = true
        '
        'CheckBox16
        '
        Me.CheckBox16.AutoSize = true
        Me.CheckBox16.Location = New System.Drawing.Point(6, 92)
        Me.CheckBox16.Name = "CheckBox16"
        Me.CheckBox16.Size = New System.Drawing.Size(87, 17)
        Me.CheckBox16.TabIndex = 3
        Me.CheckBox16.Text = "CheckBox16"
        Me.CheckBox16.UseVisualStyleBackColor = true
        '
        'CheckBox15
        '
        Me.CheckBox15.AutoSize = true
        Me.CheckBox15.Location = New System.Drawing.Point(6, 68)
        Me.CheckBox15.Name = "CheckBox15"
        Me.CheckBox15.Size = New System.Drawing.Size(87, 17)
        Me.CheckBox15.TabIndex = 2
        Me.CheckBox15.Text = "CheckBox15"
        Me.CheckBox15.UseVisualStyleBackColor = true
        '
        'CheckBox14
        '
        Me.CheckBox14.AutoSize = true
        Me.CheckBox14.Location = New System.Drawing.Point(6, 44)
        Me.CheckBox14.Name = "CheckBox14"
        Me.CheckBox14.Size = New System.Drawing.Size(87, 17)
        Me.CheckBox14.TabIndex = 1
        Me.CheckBox14.Text = "CheckBox14"
        Me.CheckBox14.UseVisualStyleBackColor = true
        '
        'CheckBox13
        '
        Me.CheckBox13.AutoSize = true
        Me.CheckBox13.Location = New System.Drawing.Point(6, 20)
        Me.CheckBox13.Name = "CheckBox13"
        Me.CheckBox13.Size = New System.Drawing.Size(87, 17)
        Me.CheckBox13.TabIndex = 0
        Me.CheckBox13.Text = "CheckBox13"
        Me.CheckBox13.UseVisualStyleBackColor = true
        '
        'PanelFacultatif
        '
        Me.PanelFacultatif.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelFacultatif.Controls.Add(Me.LabelEPVFacultative)
        Me.PanelFacultatif.Controls.Add(Me.ComboBoxFacultative)
        Me.PanelFacultatif.Controls.Add(Me.Label2)
        Me.PanelFacultatif.Controls.Add(Me.RadioButtonNon)
        Me.PanelFacultatif.Controls.Add(Me.RadioButtonOui)
        Me.PanelFacultatif.Location = New System.Drawing.Point(632, 152)
        Me.PanelFacultatif.Name = "PanelFacultatif"
        Me.PanelFacultatif.Size = New System.Drawing.Size(291, 114)
        Me.PanelFacultatif.TabIndex = 15
        '
        'LabelEPVFacultative
        '
        Me.LabelEPVFacultative.AutoSize = true
        Me.LabelEPVFacultative.Location = New System.Drawing.Point(93, 44)
        Me.LabelEPVFacultative.Name = "LabelEPVFacultative"
        Me.LabelEPVFacultative.Size = New System.Drawing.Size(99, 13)
        Me.LabelEPVFacultative.TabIndex = 4
        Me.LabelEPVFacultative.Text = "Épreuve facultative"
        '
        'ComboBoxFacultative
        '
        Me.ComboBoxFacultative.FormattingEnabled = true
        Me.ComboBoxFacultative.Location = New System.Drawing.Point(93, 63)
        Me.ComboBoxFacultative.Name = "ComboBoxFacultative"
        Me.ComboBoxFacultative.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxFacultative.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(15, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(259, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Souhaitez-vous participer à une épreuve facultative ?"
        '
        'RadioButtonNon
        '
        Me.RadioButtonNon.AutoSize = true
        Me.RadioButtonNon.Checked = true
        Me.RadioButtonNon.Location = New System.Drawing.Point(18, 68)
        Me.RadioButtonNon.Name = "RadioButtonNon"
        Me.RadioButtonNon.Size = New System.Drawing.Size(45, 17)
        Me.RadioButtonNon.TabIndex = 1
        Me.RadioButtonNon.TabStop = true
        Me.RadioButtonNon.Text = "Non"
        Me.RadioButtonNon.UseVisualStyleBackColor = true
        '
        'RadioButtonOui
        '
        Me.RadioButtonOui.AutoSize = true
        Me.RadioButtonOui.Location = New System.Drawing.Point(18, 44)
        Me.RadioButtonOui.Name = "RadioButtonOui"
        Me.RadioButtonOui.Size = New System.Drawing.Size(41, 17)
        Me.RadioButtonOui.TabIndex = 0
        Me.RadioButtonOui.Text = "Oui"
        Me.RadioButtonOui.UseVisualStyleBackColor = true
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(14, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Région de passage"
        '
        'ComboBoxRegions
        '
        Me.ComboBoxRegions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxRegions.FormattingEnabled = true
        Me.ComboBoxRegions.Location = New System.Drawing.Point(118, 114)
        Me.ComboBoxRegions.Name = "ComboBoxRegions"
        Me.ComboBoxRegions.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxRegions.TabIndex = 16
        '
        'Annuler
        '
        Me.Annuler.Location = New System.Drawing.Point(632, 300)
        Me.Annuler.Name = "Annuler"
        Me.Annuler.Size = New System.Drawing.Size(75, 23)
        Me.Annuler.TabIndex = 18
        Me.Annuler.Text = "Annuler"
        Me.Annuler.UseVisualStyleBackColor = true
        '
        'Enregistrer
        '
        Me.Enregistrer.Location = New System.Drawing.Point(714, 300)
        Me.Enregistrer.Name = "Enregistrer"
        Me.Enregistrer.Size = New System.Drawing.Size(75, 23)
        Me.Enregistrer.TabIndex = 19
        Me.Enregistrer.Text = "Enregistrer"
        Me.Enregistrer.UseVisualStyleBackColor = true
        '
        'Modification
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(940, 366)
        Me.Controls.Add(Me.Enregistrer)
        Me.Controls.Add(Me.Annuler)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBoxRegions)
        Me.Controls.Add(Me.PanelFacultatif)
        Me.Controls.Add(Me.NbEpvOralRest)
        Me.Controls.Add(Me.GroupBoxOral)
        Me.Controls.Add(Me.NbEpvEcritRest)
        Me.Controls.Add(Me.GroupBoxEcrit)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Modification"
        Me.Text = "Modification"
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBoxEcrit.ResumeLayout(false)
        Me.GroupBoxEcrit.PerformLayout
        Me.GroupBoxOral.ResumeLayout(false)
        Me.GroupBoxOral.PerformLayout
        Me.PanelFacultatif.ResumeLayout(false)
        Me.PanelFacultatif.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LabelAge As Label
    Friend WithEvents LabelAgeSelect As Label
    Friend WithEvents HScrollBarAge As HScrollBar
    Friend WithEvents LabelVille As Label
    Friend WithEvents LabelCP As Label
    Friend WithEvents VilleCandidat As TextBox
    Friend WithEvents CPCandidat As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents LabelAdresse As Label
    Friend WithEvents LabelPrenom As Label
    Friend WithEvents LabelNom As Label
    Friend WithEvents AdresseCandidat As TextBox
    Friend WithEvents PrenomCandidat As TextBox
    Friend WithEvents NomCandidat As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents NbEpvEcritRest As Label
    Friend WithEvents GroupBoxEcrit As GroupBox
    Friend WithEvents CheckBox12 As CheckBox
    Friend WithEvents CheckBox11 As CheckBox
    Friend WithEvents CheckBox10 As CheckBox
    Friend WithEvents CheckBox9 As CheckBox
    Friend WithEvents CheckBox8 As CheckBox
    Friend WithEvents CheckBox7 As CheckBox
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents NbEpvOralRest As Label
    Friend WithEvents GroupBoxOral As GroupBox
    Friend WithEvents CheckBox21 As CheckBox
    Friend WithEvents CheckBox20 As CheckBox
    Friend WithEvents CheckBox19 As CheckBox
    Friend WithEvents CheckBox18 As CheckBox
    Friend WithEvents CheckBox17 As CheckBox
    Friend WithEvents CheckBox16 As CheckBox
    Friend WithEvents CheckBox15 As CheckBox
    Friend WithEvents CheckBox14 As CheckBox
    Friend WithEvents CheckBox13 As CheckBox
    Friend WithEvents PanelFacultatif As Panel
    Friend WithEvents LabelEPVFacultative As Label
    Friend WithEvents ComboBoxFacultative As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents RadioButtonNon As RadioButton
    Friend WithEvents RadioButtonOui As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBoxRegions As ComboBox
    Friend WithEvents CandidatNum As Label
    Friend WithEvents Annuler As Button
    Friend WithEvents Enregistrer As Button
    Friend WithEvents NumCandidat As Label
End Class
