Imports System.IO

''' <summary>
''' Menu de bilan d'inscription, permet le choix du bilan
''' </summary>
Public Class MenuBilan

    ''' <summary>
    ''' Chargement du formulaire
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub MenuBilan_Load(sender As Object, e As EventArgs) _
        Handles MyBase.Load
    End Sub

    ''' <summary>
    ''' Affichage du formulaire de choix du candidat pour bilan individuel
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BilanIndividuel_Click(sender As Object, e As EventArgs) _
        Handles BilanIndividuel.Click

        GestionInscriptions.Show()
        GestionInscriptions.Supprimer.Visible = False
        GestionInscriptions.Modifier.Visible = False
        GestionInscriptions.Consulter.Visible = True
        GestionInscriptions.Fermer.Visible = True
    End Sub

    ''' <summary>
    ''' Affichage du formulaire de bilan par matière
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnBilanMatiere_Click(sender As Object, e As EventArgs) _
        Handles BtnBilanMatiere.Click
        BilanMatiere.Show()
    End Sub

    ''' <summary>
    ''' Clôture des inscriptions (génération de fichiers et fermeture)
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnCloture_Click(sender As Object, e As EventArgs) _
        Handles BtnCloture.Click
        If MsgBox("Êtes-vous sûr de vouloir clôturer les inscriptions ?" &
                  vbCrLf & "Cette action est irréversible et fermera Parcoursdev.", vbYesNo,
                  "AVERTISSEMENT") = vbYes Then
            GenerationListingOpti()
            ListCandidats.Clear()
            MsgBox("Merci d'avoir utilisé Parcoursdev.")
            MenuApp.Close()
        End If
    End Sub

    ''' <summary>
    ''' Génération du listing par tri à bulles
    ''' </summary>
    Private Sub GenerationListingOpti()
        Dim matieresTab As List(Of String) = New List(Of String)()
        matieresTab.AddRange(TabEcrit)
        For Each mat In TabOral
            If Not matieresTab.Contains(mat) Then
                matieresTab.Add(mat)
            End If
        Next

        TrierListe()
        Dim compteur As Integer
        For Each matiere In matieresTab
            For Each reg In TabRegions
                Dim tabCandidatAdd As List(Of String) = New List(Of String)
                For Each candidat In ListCandidats
                    If candidat.Region = reg Then
                        compteur = 0
                        For Each mat In candidat.Matieres
                            If mat = matiere Then
                                tabCandidatAdd.Add(candidat.Nom & " " & candidat.Prenom & " " & candidat.NumCandidat & GetTypeMat(compteur))
                                Exit For
                            End If
                            compteur += 1
                        Next
                    End If
                Next
                'S'il existe au moins un candidat passant cette matière dans cette région...
                '... on crée le fichier
                If tabCandidatAdd.Count > 0 Then
                    Dim fs As FileStream = File.Create(PathSaveListing & matiere & "_" & reg & ".txt")
                    fs.Close()
                    Dim f As New StreamWriter(PathSaveListing & matiere & "_" & reg & ".txt", True)
                    For Each Candidat In tabCandidatAdd
                        f.WriteLine(Candidat)
                    Next
                    f.Close()
                End If
            Next
        Next

    End Sub


    Dim ListATrier As List(Of String) = New List(Of String)()

    ''' <summary>
    ''' Comparaison de deux candidats par ordre alphabétique
    ''' </summary>
    ''' <param name="Cd1">Candidat 1</param>
    ''' <param name="Cd2">Candidat 2</param>
    ''' <returns></returns>
    Private Function CompareCandidat(ByRef Cd1 As Candidat, ByRef Cd2 As Candidat)
        ListATrier.Clear()
        ListATrier.Add(Cd1.Nom & " " & Cd1.Prenom & " " & Cd1.NumCandidat)
        ListATrier.Add(Cd2.Nom & " " & Cd2.Prenom & " " & Cd2.NumCandidat)
        ListATrier.Sort()
        If ListATrier(0) = Cd1.Nom & " " & Cd1.Prenom & " " & Cd1.NumCandidat Then
            Return True
        End If
        Return False
    End Function

    ''' <summary>
    ''' Tri de la liste
    ''' </summary>
    Private Sub TrierListe()
        Dim canTemp As Candidat
        Dim trie As Boolean
        For i As Integer = ListCandidats.Count - 1 To 1 Step -1
            trie = True
            For j As Integer = 0 To i - 1
                If CompareCandidat(ListCandidats(j + 1), ListCandidats(j)) Then
                    canTemp = ListCandidats(j + 1)
                    ListCandidats(j + 1) = ListCandidats(j)
                    ListCandidats(j) = canTemp
                    trie = False
                End If
            Next
            If trie Then
                Exit Sub
            End If
        Next
    End Sub

    ''' <summary>
    ''' Retourne le type d'épreuve (écrite, orale, facultative)
    ''' </summary>
    ''' <param name="Index">La position de l'épreuve dans le tableau</param>
    ''' <returns></returns>
    Private Function GetTypeMat(ByVal Index As Integer)
        If Index < 4 Then
            Return " Écrit"
        ElseIf Index < 7 Then
            Return " Oral"
        ElseIf Index = 7 Then
            Return " Facultative (oral)"
        Else
            Return " Erreur"
        End If
    End Function
End Class