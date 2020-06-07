Imports System.IO

''' <summary>
''' Menu de l'application (ouvert au lancement)
''' </summary>
Public Class MenuApp

    ''' <summary>
    ''' Sub de chargement du formulaire
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If File.Exists(PathSaveApp & FileName) Then
            Dim f As New StreamReader(PathSaveApp & FileName)
            NumAuto = f.ReadLine
            While f.Peek >= 0
                Dim num As Integer = f.ReadLine
                Dim nom As String = f.ReadLine
                Dim prenom As String = f.ReadLine
                Dim adresse As String = f.ReadLine
                Dim codepostal As String = f.ReadLine
                Dim ville As String = f.ReadLine
                Dim age As Integer = f.ReadLine
                Dim region As String = f.ReadLine
                Dim mat(7) As String
                For j As Integer = 0 To 7
                    mat(j) = f.ReadLine
                Next

                ajout(num, nom, prenom, adresse, codepostal, ville, age, region, mat)

            End While
            f.Close()
            If ListCandidats.Count = 0 Then
                NumAuto = 1
            End If
        End If

    End Sub

    ''' <summary>
    ''' Ouverture du formulaire d'inscription
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub NouvInscription_Click(sender As Object, e As EventArgs) _
        Handles NouvInscription.Click
        Inscription.Show()
    End Sub

    ''' <summary>
    ''' Ouverture du formulaire de gestion des inscriptions
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub GererInscriptions_Click(sender As Object, e As EventArgs) _
        Handles GererInscriptions.Click
        GestionInscriptions.Show()
        GestionInscriptions.Supprimer.Visible = True
        GestionInscriptions.Modifier.Visible = True
        GestionInscriptions.Consulter.Visible = False
        GestionInscriptions.Fermer.Visible = False
    End Sub

    ''' <summary>
    ''' Sauvegarde des inscriptions à la fermeture
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Sauver_Inscription(sender As Object, e As EventArgs) _
        Handles Me.Closed
        If Not Directory.Exists(PathSaveApp) Then
            Directory.CreateDirectory(PathSaveApp)
        End If
        If Not File.Exists(PathSaveApp & FileName) Then
            Dim fs As FileStream = File.Create(PathSaveApp & FileName)
            fs.Close()
        End If
        Dim f As New StreamWriter(PathSaveApp & FileName)
        f.WriteLine(Parcoursdev.NumAuto)
        For Each candid In ListCandidats
            f.WriteLine(candid.NumCandidat)
            f.WriteLine(candid.Nom)
            f.WriteLine(candid.Prenom)
            f.WriteLine(candid.Adresse)
            f.WriteLine(candid.CodPostal)
            f.WriteLine(candid.Ville)
            f.WriteLine(candid.Age)
            f.WriteLine(candid.Region)
            For Each mat In candid.Matieres
                f.WriteLine(mat)
            Next
        Next
        f.Close()
    End Sub

    ''' <summary>
    ''' Ouverture du formulaire de consultation des inscriptions
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnConsulterInscriptions_Click(sender As Object, e As EventArgs) _
        Handles BtnConsulterInscriptions.Click
        ConsulterInscriptions.Show()
    End Sub

    ''' <summary>
    ''' Ouverture du formulaire de choix de bilan
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Bilan_Click(sender As Object, e As EventArgs) _
        Handles Bilan.Click
        MenuBilan.Visible = True
    End Sub
End Class