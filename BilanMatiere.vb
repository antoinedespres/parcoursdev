''' <summary>
''' Formulaire de bilan par matière
''' </summary>
Public Class BilanMatiere

    ''' <summary>
    ''' Chargement du formulaire
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BilanMatiere_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ChargerListeMat()
    End Sub

    ''' <summary>
    ''' Rechargement de la ListBox au changement de région sélectionnée
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ComboBoxMatieres_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxMatieres.SelectedIndexChanged
        ChargerListeCandid()
    End Sub

    ''' <summary>
    ''' Chargement de la liste des matières au complet
    ''' </summary>
    Private Sub ChargerListeMat()
        ComboBoxMatieres.Items.AddRange(TabEcrit)
        For Each mat In TabOral
            If Not ComboBoxMatieres.Items.Contains(mat) Then
                ComboBoxMatieres.Items.Add(mat)
            End If
        Next
    End Sub

    ''' <summary>
    ''' Fermeture du formulaire
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Fermer_Click(sender As Object, e As EventArgs) Handles Fermer.Click
        Me.Close()
    End Sub


    ''' <summary>
    ''' Chargement de la liste des candidats passant l'épreuve de cette matière
    ''' </summary>
    Private Sub ChargerListeCandid()        
        ListBoxRegionNomPre.Items.Clear()
        Dim listeCandid As List(Of String) = New List(Of String)()
        For Each Candi in ListCandidats
            If Candi.Matieres.Contains(ComboBoxMatieres.SelectedItem) Then
                listeCandid.Add(Candi.Region & " " & Candi.Nom & " " & Candi.Prenom)
            End If
        Next
        listeCandid.Sort()
        For Each candi in ListeCandid
            ListBoxRegionNomPre.Items.Add(candi)
        Next
    End Sub
End Class