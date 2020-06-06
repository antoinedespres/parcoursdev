Public Class ConsulterInscriptions

    Private Sub ConsulterInscriptions_Load(sender As Object, e As EventArgs) _
        Handles MyBase.Load
        Dim tableau(ListCandidats.Count - 1) As String
        LabelFacultative.Text = ""
        Dim i as Integer = 0
        For Each Candi In ListCandidats
            tableau(i)= Candi.nom & " " & Candi.prenom & " " & Candi.NumCandidat
            i+=1
        Next
        Array.Sort(tableau)
        Dim j As Integer = 0
        For Each mot In tableau
            ListBoxNomPreNumCand.Items.Add(tableau(j))
            j += 1
        Next

        ' a essayer
        ' ListBoxNomPreNum.Items.AddRange(tableau)
    End Sub

    Private Sub ListBoxNumCand_SelectedIndexChanged(sender As Object, e As EventArgs) _
        Handles ListBoxNomPreNumCand.SelectedIndexChanged

        ListBoxEcrit.Items.Clear()
        ListBoxOral.Items.Clear()
        Dim i As Integer = 0
        For Each mat In ListCandidats(GetIndex(getNum(ListBoxNomPreNumCand.SelectedItem))).matieres
            If i < 4 Then
                ListBoxEcrit.Items.Add(mat.Substring(0, 3).ToUpper())
            ElseIf i < 7 Then
                ListBoxOral.Items.Add(mat.Substring(0, 3).ToUpper())
            ElseIf i = 7 Then
                If mat.Equals("") Then
                    LabelFacultative.Text = "Aucune matière facultative"
                Else
                    LabelFacultative.Text = mat.Substring(0, 3).ToUpper()
                End If
            End If
            i += 1
        Next
    End Sub
    Private Sub Fermer_Click(sender As Object, e As EventArgs) _
        Handles Fermer.Click
        Me.Close()
    End Sub

    Private Const nbMots As Integer = 2
    Private Function getNum(ByVal mot As String)
        Dim tab(nbMots) As String
        tab = mot.Split(" ")
        If IsNumeric(tab(nbMots)) Then
            Return CType(tab(nbMots), Integer)
        End If
        Return -1
    End Function
End Class