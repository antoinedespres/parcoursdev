''' <summary>
'''     Formulaire de modification d'une inscription
''' </summary>
Public Class Modification
    Dim _nbOptionsEcrit As Integer = 0
    Dim _nbOptionsOral As Integer = 0

    Dim _index As Integer

    ''' <summary>
    '''     Chargement du formulaire
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Modification_Load(sender As Object, e As EventArgs) _
        Handles MyBase.Load
        NomCandidat.MaxLength = 15
        PrenomCandidat.MaxLength = 20
        AdresseCandidat.MaxLength = 30
        CPCandidat.MaxLength = 5
        VilleCandidat.MaxLength = 15

        ComboBoxRegions.Items.AddRange(TabRegions)
        ComboBoxRegions.SelectedIndex = 0

        For i = 0 To TabEcrit.Length - 1
            GroupBoxEcrit.Controls(i).Text = TabEcrit(TabEcrit.Length - i - 1)
        Next
        For j = 0 To TabOral.Length - 1
            GroupBoxOral.Controls(j).Text = TabOral(TabOral.Length - j - 1)
        Next

        NbEpvEcritRest.Text = MaxEpreuvesEcrit &
                              " épreuves à sélectionner."
        NbEpvOralRest.Text = MaxEpreuvesOral &
                             " épreuves à sélectionner."
        RadioButtonOui.Enabled = True
        RadioButtonNon.Enabled = True
        RadioButtonOui.Checked = False
        LabelEPVFacultative.Visible = False
        ComboBoxFacultative.Visible = False

        _index = GetIndex(GestionInscriptions.ComboNumCandidats.SelectedItem)
        Load_Champs(_index)
    End Sub

    ''' <summary>
    '''     Préremplissage du formulaire en fonction de l'index du candidat
    ''' </summary>
    ''' <param name="NumIndex">Index du candidat dans la liste ListCandidats</param>
    Private Sub Load_Champs(NumIndex As Integer)

        CandidatNum.Text = "Candidat numéro :"
        NumCandidat.Text = ListCandidats(NumIndex).NumCandidat
        NomCandidat.Text = ListCandidats(NumIndex).Nom
        PrenomCandidat.Text = ListCandidats(NumIndex).Prenom
        AdresseCandidat.Text = ListCandidats(NumIndex).Adresse
        CPCandidat.Text = ListCandidats(NumIndex).CodPostal
        VilleCandidat.Text = ListCandidats(NumIndex).Ville
        HScrollBarAge.Value = ListCandidats(NumIndex).Age
        LabelAgeSelect.Text = ListCandidats(NumIndex).Age & "ans"

        Dim i = 0
        For Each reg In ComboBoxRegions.Items
            If reg = ListCandidats(NumIndex).Region Then
                ComboBoxRegions.SelectedIndex = i
            End If
            i += 1
        Next

        i = 0
        For Each Mata In ListCandidats(NumIndex).Matieres
            If i < 4 Then
                For Each matb In GroupBoxEcrit.Controls
                    If matb.text = Mata Then
                        matb.checked = True
                    End If
                Next
            ElseIf i < 7 Then
                For Each matb In GroupBoxOral.Controls
                    If matb.text = Mata Then
                        matb.checked = True
                    End If
                Next
            ElseIf i = 7 Then
                If Mata = "" Then

                Else
                    RadioButtonOui.Checked = true
                    LabelEPVFacultative.Visible = true
                    ComboBoxFacultative.Visible = true
                    ChargerListe(GroupBoxEcrit)
                    ChargerListe(GroupBoxOral)
                    Dim j = 0
                    For Each matb In ComboBoxFacultative.Items
                        If Equals(Mata, matb) Then
                            ComboBoxFacultative.SelectedIndex = j
                        End If
                        j += 1
                    Next
                End If
            End If
            i += 1
        Next
    End Sub

    ''' <summary>
    ''' Blocage des chiffres dans les champs Nom, Prénom et Ville
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Textuel_keypress(sender As Object, e As KeyPressEventArgs) _
        Handles NomCandidat.KeyPress, PrenomCandidat.KeyPress, VilleCandidat.KeyPress
        LabelNom.ForeColor = Color.Black
        LabelPrenom.ForeColor = Color.Black
        LabelVille.ForeColor = Color.Black
        If e.KeyChar = vbBack Then Exit Sub
        If Not Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ''' <summary>
    ''' Blocage des lettres dans le champ de saisie du code postal
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Numeric_keypress(sender As Object, e As KeyPressEventArgs) _
        Handles CPCandidat.KeyPress
        LabelCP.ForeColor = Color.Black

        If e.KeyChar = vbBack Then Exit Sub
        If Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ''' <summary>
    '''     Gestion du changement d'état sur le GroupBoxEcrit
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Ecrit_CheckedChanged(sender As Object, e As EventArgs) _
        Handles CheckBox1.CheckedChanged, CheckBox2.CheckedChanged,
                CheckBox3.CheckedChanged, CheckBox4.CheckedChanged,
                CheckBox5.CheckedChanged, CheckBox6.CheckedChanged,
                CheckBox7.CheckedChanged, CheckBox8.CheckedChanged,
                CheckBox9.CheckedChanged, CheckBox10.CheckedChanged,
                CheckBox11.CheckedChanged, CheckBox12.CheckedChanged
        GroupBoxEcrit.ForeColor = Color.Black
        For Each control in GroupBoxOral.Controls
            If control.Text = sender.Text Then
                control.Enabled = Not control.Enabled
            End If
        Next
        If sender.Checked Then
            _nbOptionsEcrit += 1
            If _nbOptionsEcrit > MaxEpreuvesEcrit Then
                MsgBox("Impossible de sélectionner plus de " &
                       MaxEpreuvesEcrit & " épreuves écrites.")
                sender.Checked = false
            End If
        Else
            _nbOptionsEcrit -= 1
        End If
        NbEpvEcritRest.Text = MaxEpreuvesEcrit - _nbOptionsEcrit &
                              If(MaxEpreuvesEcrit - _nbOptionsEcrit > 1,
                                 " épreuves ", " épreuve ") &
                              "à sélectionner."
        VerifEpv()
    End Sub

    ''' <summary>
    '''     Gestion du changement d'état sur le GroupBoxOral
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Oral_CheckedChanged(sender As Object, e As EventArgs) _
        Handles CheckBox13.CheckedChanged, CheckBox14.CheckedChanged,
                CheckBox15.CheckedChanged, CheckBox16.CheckedChanged,
                CheckBox17.CheckedChanged, CheckBox18.CheckedChanged,
                CheckBox19.CheckedChanged, CheckBox20.CheckedChanged,
                CheckBox21.CheckedChanged
        GroupBoxOral.ForeColor = Color.Black
        For Each control in GroupBoxEcrit.Controls
            If control.Text = sender.Text Then
                control.Enabled = Not control.Enabled
            End If
        Next
        If sender.Checked Then
            _nbOptionsOral += 1
            If _nbOptionsOral > MaxEpreuvesOral Then
                MsgBox("Impossible de sélectionner plus de " & MaxEpreuvesOral &
                       " épreuves orales.")
                sender.Checked = false
            End If
        Else
            _nbOptionsOral -= 1
        End If
        NbEpvOralRest.Text = MaxEpreuvesOral - _nbOptionsOral &
                             If(MaxEpreuvesOral - _nbOptionsOral > 1,
                                " épreuves ", " épreuve ") &
                             "à sélectionner."
        VerifEpv()
    End Sub

    ''' <summary>
    '''     Vérifie que le bon nombre d'épreuves est choisi
    ''' </summary>
    Sub VerifEpv()
        If _nbOptionsEcrit = MaxEpreuvesEcrit And
           _nbOptionsOral = MaxEpreuvesOral Then
            RadioButtonOui.Enabled = True
            RadioButtonNon.Enabled = True
            RadioButtonNon.Checked = True
        Else
            RadioButtonOui.Enabled = False
            RadioButtonNon.Enabled = False
            ComboBoxFacultative.Visible = False
        End If
    End Sub

    ''' <summary>
    ''' Changement d'état sur le choix d'épreuve facultative
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Facultatif_CheckedChanged(sender As Object, e As EventArgs) _
        Handles RadioButtonOui.CheckedChanged
        If RadioButtonOui.Checked = True Then
            ComboBoxFacultative.Visible = True
        Else
            ComboBoxFacultative.Visible = False
            ComboBoxFacultative.Items.Clear()
        End If
    End Sub

    ''' <summary>
    ''' Chargement de la liste d'épreuves facultative
    ''' </summary>
    ''' <param name="gb"></param>
    Private Sub ChargerListe(ByRef gb As GroupBox)
        For Each control As CheckBox In gb.Controls
            If control.Checked = False And Not _
                                           ComboBoxFacultative.Items.Contains(control.Text) _
               And control.Enabled = True Then
                ComboBoxFacultative.Items.Add(control.Text)
            End If
        Next
    End Sub

    ''' <summary>
    ''' Vidage /Chargement de la liste d'épreuves facultatives sur changement de visibilité
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ComboBoxFacultative_VisibleChanged(sender As Object, e As EventArgs) _
        Handles ComboBoxFacultative.VisibleChanged
        LabelEPVFacultative.Visible = sender.Visible
        If sender.Visible = True Then
            ChargerListe(GroupBoxEcrit)
            ChargerListe(GroupBoxOral)
        Else
            ComboBoxFacultative.Items.Clear()
        End If
    End Sub

    ''' <summary>
    ''' Changement de la valeur de l'âge via Scroll
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub HScrollBarAge_Scroll(sender As Object, e As ScrollEventArgs) _
        Handles HScrollBarAge.Scroll
        LabelAgeSelect.Text = HScrollBarAge.Value & " ans"
    End Sub


    ''' <summary>
    ''' Confirmation avant annulation de modification
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Annuler_Click(sender As Object, e As EventArgs) _
        Handles Annuler.Click
        If MsgBox("Êtes-vous sûr de vouloir fermer sans enregistrer ?", vbYesNo, "Avertissement") = vbYes Then
            GestionInscriptions.Show()
            Me.Close()
        End If
    End Sub

    ''' <summary>
    ''' Enregistrement de la modification
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Enregistrer_Click(sender As Object, e As EventArgs) _
        Handles Enregistrer.Click

        If Verif(NomCandidat.Text, PrenomCandidat.Text, VilleCandidat.Text, CPCandidat.Text,
                 LabelNom, LabelPrenom, LabelVille, LabelCP,
                 GroupBoxEcrit, GroupBoxOral, LabelEPVFacultative,
                 _nbOptionsEcrit, _nbOptionsOral, RadioButtonOui,
                 ComboBoxFacultative) = True Then

            Dim matTab(7) As String
            Dim i = 0
            For Each cb As CheckBox In GroupBoxEcrit.Controls
                If cb.Checked Then
                    matTab(i) = cb.Text
                    i += 1
                End If
            Next
            For Each cb As CheckBox In GroupBoxOral.Controls
                If cb.Checked Then
                    matTab(i) = cb.Text
                    i += 1
                End If
            Next

            If ComboBoxFacultative.SelectedItem Is Nothing Then
                matTab(i) = ""
            Else
                matTab(i) = ComboBoxFacultative.SelectedItem
            End If

            ListCandidats(_index) = new Candidat() With {
                .NumCandidat = NumCandidat.Text,
                .Nom = NomCandidat.Text,
                .Prenom = PrenomCandidat.Text,
                .Adresse = AdresseCandidat.Text,
                .CodPostal = CPCandidat.text,
                .Ville = VilleCandidat.Text,
                .Age = HScrollBarAge.Value,
                .Region = ComboBoxRegions.SelectedItem,
                .Matieres = matTab
                }
            GestionInscriptions.Close()
            GestionInscriptions.Show()
            Me.Close()
        Else
            MsgBox("Certains champs n'ont pas été remplis correctement.")
        End If
    End Sub
End Class