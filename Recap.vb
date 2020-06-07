''' <summary>
''' Formulaire de récapitulatif d'inscription
''' </summary>
Public Class Recap

    ''' <summary>
    ''' Chargement du formulaire
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Recap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelNom.Text = Inscription.NomCandidat.Text
        LabelPrenom.Text = Inscription.PrenomCandidat.Text
        LabelAdresse.Text = Inscription.AdresseCandidat.Text
        LabelCP.Text = Inscription.CPCandidat.Text
        LabelVille.Text = Inscription.VilleCandidat.Text
        LabelAge.Text = Inscription.HScrollBarAge.Value
        LabelFacultative.Text = ChoixRegionMatieres.ComboBoxFacultative.Text
        LabelRegion.Text = ChoixRegionMatieres.ComboBoxRegions.SelectedItem

        Load_Mat(ChoixRegionMatieres.GroupBoxEcrit.Controls, GroupBoxEcrit)
        Load_Mat(ChoixRegionMatieres.GroupBoxOral.Controls, GroupBoxOral)

    End Sub

    ''' <summary>
    ''' Chargement de la liste des épreuves choisies (écrit ou oral)
    ''' </summary>
    ''' <param name="Source"></param>
    ''' <param name="Dest"></param>
    Private Sub Load_Mat(ByRef Source, ByRef Dest)
        Dim i As Integer = 0
        For Each cb As CheckBox In Source
            If cb.Checked Then
                Dest.Controls(i).Text = cb.Text
                i += 1
            End If
        Next
    End Sub

    ''' <summary>
    ''' Retour au choix de la région de pasasge et des épreuves
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Retour_Click(sender As Object, e As EventArgs) _
        Handles Retour.Click
        ChoixRegionMatieres.Show()
        ChoixRegionMatieres.TimerRegionMatiere.Start()
        Dim i As Integer = 0
        For Each mat In ChoixRegionMatieres.ComboBoxFacultative.Items
            If mat = LabelFacultative.Text Then
                ChoixRegionMatieres.ComboBoxFacultative.SelectedIndex = i
            End If
            i += 1
        Next
        Me.Close()
    End Sub

    ''' <summary>
    ''' Abandon de l'inscription (rien n'est enregistré)
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Abandonner_Click(sender As Object, e As EventArgs) _
        Handles Abandonner.Click
        ChoixRegionMatieres.Close()
        Inscription.Close()
        Me.Close()
    End Sub

    ''' <summary>
    ''' Enregistrement de l'inscription
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Enregistrer_Click(sender As Object, e As EventArgs) _
        Handles Enregistrer.Click
        Dim i As Integer = 0
        Dim matieres(7) As String
        For Each mat As Label In GroupBoxEcrit.Controls
            matieres(i) = mat.Text
            i += 1
        Next
        For Each mat As Label In GroupBoxOral.Controls
            matieres(i) = mat.Text
            i += 1
        Next
        matieres(i) = LabelFacultative.Text
        ajout(LabelNom.Text, LabelPrenom.Text, LabelAdresse.Text, LabelCP.Text, LabelVille.Text, LabelAge.Text, LabelRegion.Text, matieres)
        MsgBox("Le candidat numéro " & ListCandidats.Last().NumCandidat & " a bien été enregistré.")
        ChoixRegionMatieres.Close()
        Inscription.Close()
        Me.Close()
    End Sub
End Class
