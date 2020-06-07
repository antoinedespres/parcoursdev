''' <summary>
''' Formulaire de consultation des inscriptions
''' </summary>
Public Class ConsulterInscriptions
    Private Const NbMots As Integer = 2

    ''' <summary>
    ''' Chargement du formulaire
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ConsulterInscriptions_Load(sender As Object, e As EventArgs) _
        Handles MyBase.Load
        Dim tableau(ListCandidats.Count - 1) As String
        LabelFacultative.Text = ""
        Dim i As Integer = 0
        For Each Candi In ListCandidats
            tableau(i) = Candi.Nom & " " & Candi.Prenom & " " & Candi.NumCandidat
            i += 1
        Next
        Array.Sort(tableau)
        Dim j As Integer = 0
        For Each mot In tableau
            ListBoxNomPreNumCand.Items.Add(tableau(j))
            j += 1
        Next

    End Sub

    ''' <summary>
    ''' Changement du candidat sélectionné (mise à jour des autres ListBox)
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ListBoxNumCand_SelectedIndexChanged(sender As Object, e As EventArgs) _
        Handles ListBoxNomPreNumCand.SelectedIndexChanged

        ListBoxEcrit.Items.Clear()
        ListBoxOral.Items.Clear()
        Dim i As Integer = 0
        For Each mat In ListCandidats(GetIndex(getNum(ListBoxNomPreNumCand.SelectedItem))).Matieres
            If i < 4 Then
                ListBoxEcrit.Items.Add(GetTrigramme(mat))
            ElseIf i < 7 Then
                ListBoxOral.Items.Add(GetTrigramme(mat))
            ElseIf i = 7 Then
                If mat.Equals("") Then
                    LabelFacultative.Text = "Aucune matière facultative"
                Else
                    LabelFacultative.Text = GetTrigramme(mat)
                End If
            End If
            i += 1
        Next
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
    ''' Obtention du numéro de candidat dans la ListBox
    ''' </summary>
    ''' <param name="chaine">Chaîne de caractères Nom Prénom Numéro</param>
    ''' <returns></returns>
    Private Function getNum(ByVal chaine As String)
        Dim tab(NbMots) As String
        tab = chaine.Split(" ")
        If IsNumeric(tab(NbMots)) Then
            Return CType(tab(NbMots), Integer)
        End If
        Return -1
    End Function
End Class