''' <summary>
''' Formulaire de gestion des inscriptions (sélection du candidat)
''' </summary>
Public Class GestionInscriptions

    ''' <summary>
    ''' Chargement du formulaire
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub GestionInscriptions_Load(sender As Object, e As EventArgs) _
        Handles MyBase.Load
        ChargerListes()
    End Sub

    ''' <summary>
    ''' Changement de l'index sélectionné dans la ComboBox des num de candidat
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ComboNumCandidats_SelectedIndexChanged(sender As Object, e As EventArgs) _
        Handles ComboNumCandidats.SelectedIndexChanged
        ComboNomPreCandidats.SelectedIndex = ComboNumCandidats.SelectedIndex
    End Sub

    ''' <summary>
    ''' Changement de l'index sélectionné dans la ComboBox des Nom et Prénom de candidat
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ComboNomPreCandidats_SelectedIndexChanged(sender As Object, e As EventArgs) _
        Handles ComboNomPreCandidats.SelectedIndexChanged
        ComboNumCandidats.SelectedIndex = ComboNomPreCandidats.SelectedIndex
    End Sub

    ''' <summary>
    ''' Affichage du récapitulatif du candidat et d'une MsgBox pour confirmation
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Supprimer_Click(sender As Object, e As EventArgs) _
        Handles Supprimer.Click
        If getIndex(ComboNumCandidats.SelectedItem) = -1 Then
            MsgBox("Sélection incorrecte.")
        Else
        
        LoadRecap()        

            If MsgBox("Êtes-vous sûr de supprimer le candidat numéro " & ComboNumCandidats.SelectedItem & " ?", vbYesNo) = vbYes Then
                ListCandidats.RemoveAt(GetIndex(ComboNumCandidats.SelectedItem))
                ChargerListes()
            End If
        End If
        Recap.Close()
    End Sub

    ''' <summary>
    ''' Chargement de la liste des numéros et de celle des Nom et Prénom
    ''' </summary>
    Private Sub ChargerListes()
        ComboNumCandidats.Items.Clear()
        ComboNomPreCandidats.Items.Clear()
        For Each ca In ListCandidats
            ComboNumCandidats.Items.Add(ca.NumCandidat)
            ComboNomPreCandidats.Items.Add(ca.Nom & " " & ca.Prenom)
        Next
    End Sub


    ''' <summary>
    ''' Préremplissage du formulaire de récapitulatif en fonction du candidat
    ''' </summary>
    Private Sub LoadRecap()
        Recap.Show()
        Recap.LabelNom.Text = ListCandidats(GetIndex(ComboNumCandidats.SelectedItem)).Nom
        Recap.LabelPrenom.Text = ListCandidats(GetIndex(ComboNumCandidats.SelectedItem)).Prenom
        Recap.LabelAdresse.Text = ListCandidats(GetIndex(ComboNumCandidats.SelectedItem)).Adresse
        Recap.LabelCP.Text = ListCandidats(GetIndex(ComboNumCandidats.SelectedItem)).CodPostal
        Recap.LabelVille.Text = ListCandidats(GetIndex(ComboNumCandidats.SelectedItem)).Ville
        Recap.LabelAge.Text = ListCandidats(GetIndex(ComboNumCandidats.SelectedItem)).Age
        Recap.LabelRegion.Text = ListCandidats(GetIndex(ComboNumCandidats.SelectedItem)).Region
        Dim i As Integer
        For Each mat In ListCandidats(GetIndex(ComboNumCandidats.SelectedItem)).Matieres
            If i < 4 Then
                Recap.GroupBoxEcrit.Controls(i).Text = ListCandidats(GetIndex(ComboNumCandidats.SelectedItem)).Matieres(i)
            ElseIf i < 7 Then
                Recap.GroupBoxOral.Controls(i - 4).Text = ListCandidats(GetIndex(ComboNumCandidats.SelectedItem)).Matieres(i)
            ElseIf i = 7 Then
                If mat.Equals("") Then
                    Recap.LabelFacultative.Text = "Aucune matière facultative"
                Else
                    Recap.LabelFacultative.Text = ListCandidats(GetIndex(ComboNumCandidats.SelectedItem)).Matieres(i)
                End If
            End If
            i += 1
        Next

        Recap.Enregistrer.Visible = False
        Recap.Retour.Visible = False
        Recap.Abandonner.Visible = False
    End Sub

    ''' <summary>
    ''' Affichage du formulaire de modification d'inscription
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Modifier_Click(sender As Object, e As EventArgs) _
        Handles Modifier.Click
        'si NumIndex<0 ne pas Ouvrir
        If getIndex(ComboNumCandidats.SelectedItem) = -1 Then
            MsgBox("Sélection incorrecte.")
        Else
            Modification.Show()
        End If
    End Sub


    ''' <summary>
    ''' Fermeture du formulaire
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Fermer_Click(sender As Object, e As EventArgs) _
        Handles Fermer.Click
        Me.Close()
    End Sub

    ''' <summary>
    ''' Ouverture du récapitulatif de l'inscription du candidat
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Consulter_Click(sender As Object, e As EventArgs) _
        Handles Consulter.Click
        If getIndex(ComboNumCandidats.SelectedItem) = -1 Then
            MsgBox("Sélection incorrecte.")
        Else
            LoadRecap()
        End If
    End Sub
End Class