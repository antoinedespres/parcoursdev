Public Class Modification
    Dim _nbOptionsEcrit As Integer = 0
    Dim _nbOptionsOral As Integer = 0

    Dim Index As Integer
    Private Sub Modification_Load(sender As Object, e As EventArgs) _
        Handles MyBase.Load
        NomCandidat.MaxLength = 15
        PrenomCandidat.MaxLength = 20
        AdresseCandidat.MaxLength = 30
        CPCandidat.MaxLength = 5
        VilleCandidat.MaxLength = 15


        Dim tabRegions() As String = {"Auvergne", "Bordelais", "Bourgogne",
                                      "Bretagne", "Corse", "Nord", "Normandie",
                                      "Paris", "Poitou", "Roussillon"}
        ComboBoxRegions.Items.AddRange(tabRegions)
        ComboBoxRegions.SelectedIndex = 0

        Dim tabEcrit() As String = {"Algorithmique", "Base de données", "Droit",
                                    "Expression", "Gestion", "Langage C",
                                    "Langage Java", "Mathématiques",
                                    "Programmation web", "Réseau", "Système",
                                    "Visual Basic .NET"}

        For i = 0 To tabEcrit.Length - 1
            GroupBoxEcrit.Controls(i).Text = tabEcrit(tabEcrit.Length - i - 1)
        Next

        Dim tabOral() As String = {"Droit", "Expression", "Gestion",
                                   "Mathématiques", "Réseau", "Système",
                                   "Anglais", "Chinois", "Espagnol"}
        For j = 0 To tabOral.Length - 1
            GroupBoxOral.Controls(j).Text = tabOral(tabOral.Length - j - 1)
        Next

        NbEpvEcritRest.Text = Parcoursdev.MAXEpreuvesEcrit & 
                              " épreuves à sélectionner."
        NbEpvOralRest.Text = Parcoursdev.MAXEpreuvesOral & 
                             " épreuves à sélectionner."
        RadioButtonOui.Enabled = True
        RadioButtonNon.Enabled = True
        RadioButtonOui.Checked = False
        LabelEPVFacultative.Visible = False
        ComboBoxFacultative.Visible = False

        Index = GetIndex(GestionInscriptions.ComboNumCandidats.SelectedItem)
        Load_Champs(Index)
    End Sub
    
    Private Sub Load_Champs(ByVal NumIndex As Integer)

        CandidatNum.Text = "Candidat numéro :"
        NumCandidat.Text=ListCandidats(NumIndex).NumCandidat
        NomCandidat.Text = ListCandidats(NumIndex).nom
        PrenomCandidat.Text = ListCandidats(NumIndex).prenom
        AdresseCandidat.Text = ListCandidats(NumIndex).adresse
        CPCandidat.Text = ListCandidats(NumIndex).codepostal
        VilleCandidat.Text = ListCandidats(NumIndex).ville
        HScrollBarAge.Value = ListCandidats(NumIndex).age
        LabelAgeSelect.Text = ListCandidats(NumIndex).age & "ans"

        Dim i As Integer = 0
        For Each reg In ComboBoxRegions.Items
            If reg = ListCandidats(NumIndex).Region Then
                ComboBoxRegions.SelectedIndex = i
            End If
            i += 1
        Next

        i = 0
        For Each Mata In ListCandidats(NumIndex).matieres
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
                    Dim j As Integer = 0
                    For Each matb In ComboBoxFacultative.Items
                        If String.Equals(Mata, matb) Then
                            ComboBoxFacultative.SelectedIndex = j
                        End If
                        j += 1
                    Next
                End If

            End If
            i += 1
        Next
    End Sub

    Private Sub Ecrit_CheckedChanged(sender As Object, e As EventArgs) _
        Handles CheckBox1.CheckedChanged, CheckBox2.CheckedChanged,
                CheckBox3.CheckedChanged, CheckBox4.CheckedChanged,
                CheckBox5.CheckedChanged, CheckBox6.CheckedChanged,
                CheckBox7.CheckedChanged, CheckBox8.CheckedChanged,
                CheckBox9.CheckedChanged, CheckBox10.CheckedChanged,
                CheckBox11.CheckedChanged, CheckBox12.CheckedChanged
        GroupBoxEcrit.ForeColor=Color.Black
        For Each control in GroupBoxOral.Controls
            If control.Text = sender.Text Then
                control.Enabled = Not control.Enabled
            End If
        Next
        If sender.Checked Then
            _nbOptionsEcrit += 1
            If _nbOptionsEcrit > MAXEpreuvesEcrit Then
                MsgBox("Impossible de sélectionner plus de " &
                       MAXEpreuvesEcrit & " épreuves écrites.")
                sender.Checked = false
            End If
        Else
            _nbOptionsEcrit -= 1
        End If
        NbEpvEcritRest.Text = MAXEpreuvesEcrit - _nbOptionsEcrit &
                              If(MAXEpreuvesEcrit - _nbOptionsEcrit > 1,
                                  " épreuves ", " épreuve ") &
                              "à sélectionner."
        VerifEpv()
    End Sub

    Private Sub Oral_CheckedChanged(sender As Object, e As EventArgs) _
        Handles CheckBox13.CheckedChanged, CheckBox14.CheckedChanged,
                CheckBox15.CheckedChanged, CheckBox16.CheckedChanged,
                CheckBox17.CheckedChanged, CheckBox18.CheckedChanged,
                CheckBox19.CheckedChanged, CheckBox20.CheckedChanged,
                CheckBox21.CheckedChanged
        GroupBoxOral.ForeColor=Color.Black
        For Each control in GroupBoxEcrit.Controls
            If control.Text = sender.Text Then
                control.Enabled = Not control.Enabled
            End If
        Next
        If sender.Checked Then
            _nbOptionsOral += 1
            If _nbOptionsOral > MAXEpreuvesOral Then
                MsgBox("Impossible de sélectionner plus de " & MAXEpreuvesOral &
                       " épreuves orales.")
                sender.Checked = false
            End If
        Else
            _nbOptionsOral -= 1
        End If
        NbEpvOralRest.Text = MAXEpreuvesOral - _nbOptionsOral &
                             If(MAXEpreuvesOral - _nbOptionsOral > 1,
                                " épreuves ", " épreuve ") & 
                             "à sélectionner."
        VerifEpv()
    End Sub

    Sub VerifEpv()
        If _nbOptionsEcrit = MAXEpreuvesEcrit And _
           _nbOptionsOral = MAXEpreuvesOral Then
            RadioButtonOui.Enabled = True
            RadioButtonNon.Enabled = True
            RadioButtonNon.Checked = True
        Else
            RadioButtonOui.Enabled = False
            RadioButtonNon.Enabled = False
            ComboBoxFacultative.Visible = False
        End If
    End Sub

    Private Sub Facultatif_CheckedChanged(sender As Object, e As EventArgs) _
        Handles RadioButtonOui.CheckedChanged
        If RadioButtonOui.Checked = True Then
            ComboBoxFacultative.Visible = True
        Else
            ComboBoxFacultative.Visible = False
            ComboBoxFacultative.Items.Clear()
        End If
    End Sub

    Private Sub ChargerListe(ByRef gb As GroupBox)
        For Each control As CheckBox In gb.Controls
            If control.Checked = False And Not _
                ComboBoxFacultative.Items.Contains(control.Text) _
                And control.Enabled = True Then
                ComboBoxFacultative.Items.Add(control.Text)
            End If
        Next
    End Sub

    Private Sub ComboBoxFacultative_VisibleChanged(sender As Object, e As EventArgs) _
        Handles ComboBoxFacultative.VisibleChanged
        LabelEPVFacultative.Visible = sender.Visible
        If sender.Visible = True Then
            ComboBoxFacultative.Items.Clear()
            ChargerListe(GroupBoxEcrit)
            ChargerListe(GroupBoxOral)
        Else
            ComboBoxFacultative.Items.Clear()
        End If
    End Sub

    Private Sub HScrollBarAge_Scroll(sender As Object, e As ScrollEventArgs) _
        Handles HScrollBarAge.Scroll
        LabelAgeSelect.Text = HScrollBarAge.Value & " ans"
    End Sub

    Private Sub Annuler_Click(sender As Object, e As EventArgs) _
        Handles Annuler.Click
        If MsgBox("Êtes-vous sûr de vouloir fermer sans enregistrer ?", vbYesNo, "Avertissement") = vbYes Then
            GestionInscriptions.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Enregistrer_Click(sender As Object, e As EventArgs) _
        Handles Enregistrer.Click

        If Verif(NomCandidat.Text, PrenomCandidat.Text, VilleCandidat.Text, CPCandidat.Text,
                          LabelNom, LabelPrenom, LabelVille, LabelCP,
                          GroupBoxEcrit, GroupBoxOral,  LabelEPVFacultative,
                          _nbOptionsEcrit, _nbOptionsOral, RadioButtonOui,
                          ComboBoxFacultative ) = True Then
            
            Dim matTab(7) As String
            Dim i As Integer = 0
            For Each cb As CheckBox In GroupBoxEcrit.Controls
                If cb.Checked Then
                    matTab(i)= cb.Text
                    i += 1
                End If
            Next
            For Each cb As CheckBox In GroupBoxOral.Controls
                If cb.Checked Then
                    matTab(i)= cb.Text
                    i += 1
                End If
            Next
            matTab(i) = ComboBoxFacultative.SelectedItem

            ListCandidats(Index) = new Candidat() With {
                    .NumCandidat = NumCandidat.Text,
                    .nom = NomCandidat.Text,
                    .prenom = PrenomCandidat.Text,
                    .adresse = AdresseCandidat.Text,
                    .codepostal = CPCandidat.text,
                    .ville = VilleCandidat.Text,
                    .age = HScrollBarAge.Value,
                    .Region = ComboBoxRegions.SelectedItem,
                    .matieres = matTab
                    }
            GestionInscriptions.Close()
            GestionInscriptions.Show()
            Me.Close()
        Else 
            MsgBox("Certains champs n'ont pas été remplis correctement.")
        End If
    End Sub
End Class