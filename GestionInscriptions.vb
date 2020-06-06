Public Class GestionInscriptions

    Private Sub GestionInscriptions_Load(sender As Object, e As EventArgs) _
        Handles MyBase.Load
        For Each ca In ListCandidats
            ComboNumCandidats.Items.Add(ca.NumCandidat)
            ComboNomPreCandidats.Items.Add(ca.nom & " " & ca.prenom)
        Next
    End Sub

    Private Sub ComboNumCandidats_SelectedIndexChanged(sender As Object, e As EventArgs) _
        Handles ComboNumCandidats.SelectedIndexChanged
        ComboNomPreCandidats.SelectedIndex = ComboNumCandidats.SelectedIndex
    End Sub

    Private Sub ComboNomPreCandidats_SelectedIndexChanged(sender As Object, e As EventArgs) _
        Handles ComboNomPreCandidats.SelectedIndexChanged
        ComboNumCandidats.SelectedIndex = ComboNomPreCandidats.SelectedIndex
    End Sub

    Private Sub Supprimer_Click(sender As Object, e As EventArgs) _
        Handles Supprimer.Click
        If getIndex(ComboNumCandidats.SelectedItem) = -1 Then
            MsgBox("Sélection incorrecte.")
        Else

            If MsgBox("Êtes-vous sûr de supprimer le candidat numéro " & ComboNumCandidats.SelectedItem & " ?", vbYesNo) = vbYes Then
                ListCandidats.RemoveAt(GetIndex(ComboNumCandidats.SelectedItem))
                ComboNumCandidats.Items.Clear()
                ComboNomPreCandidats.Items.Clear()
                For Each ca In ListCandidats
                    ComboNumCandidats.Items.Add(ca.NumCandidat)
                    ComboNomPreCandidats.Items.Add(ca.nom & " " & ca.prenom)
                Next
            End If
        End If
        Recap.Close()
    End Sub

    Private Sub loadRecap()
        Recap.Show()
        Recap.LabelNom.Text = ListCandidats(GetIndex(ComboNumCandidats.SelectedItem)).nom
        Recap.LabelPrenom.Text = ListCandidats(GetIndex(ComboNumCandidats.SelectedItem)).prenom
        Recap.LabelAdresse.Text = ListCandidats(GetIndex(ComboNumCandidats.SelectedItem)).adresse
        Recap.LabelCP.Text = ListCandidats(GetIndex(ComboNumCandidats.SelectedItem)).codepostal
        Recap.LabelVille.Text = ListCandidats(GetIndex(ComboNumCandidats.SelectedItem)).ville
        Recap.LabelAge.Text = ListCandidats(GetIndex(ComboNumCandidats.SelectedItem)).age
        Recap.LabelRegion.Text = ListCandidats(GetIndex(ComboNumCandidats.SelectedItem)).Region
        Dim i As Integer
        For Each mat In ListCandidats(GetIndex(ComboNumCandidats.SelectedItem)).matieres
            If i < 4 Then
                Recap.GroupBoxEcrit.Controls(i).Text = ListCandidats(GetIndex(ComboNumCandidats.SelectedItem)).matieres(i)
            ElseIf i < 7 Then
                Recap.GroupBoxOral.Controls(i - 4).Text = ListCandidats(GetIndex(ComboNumCandidats.SelectedItem)).matieres(i)
            ElseIf i = 7 Then
                If mat.Equals("") Then
                    Recap.LabelFacultative.Text = "Aucune matière facultative"
                Else
                    Recap.LabelFacultative.Text = ListCandidats(GetIndex(ComboNumCandidats.SelectedItem)).matieres(i)
                End If
            End If
            i += 1
        Next

        Recap.Enregistrer.Visible = False
        Recap.Retour.Visible = False
        Recap.Abandonner.Visible = False
    End Sub

    Private Sub Modifier_Click(sender As Object, e As EventArgs) Handles Modifier.Click
        'si NumIndex<0 ne pas Ouvrir
        If getIndex(ComboNumCandidats.SelectedItem) = -1 Then
            MsgBox("Sélection incorrecte.")
        Else
            Modification.Show()
        End If
    End Sub

    Private Sub Fermer_Click(sender As Object, e As EventArgs) Handles Fermer.Click
        Me.Close()
    End Sub

    Private Sub Consulter_Click(sender As Object, e As EventArgs) Handles Consulter.Click

    End Sub
End Class