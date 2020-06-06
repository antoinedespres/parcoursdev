Imports System.IO

Public Class Menu

    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub NouvInscription_Click(sender As Object, e As EventArgs) _
        Handles NouvInscription.Click
        Inscription.Show()
    End Sub

    Private Sub GererInscriptions_Click(sender As Object, e As EventArgs) _
        Handles GererInscriptions.Click
        GestionInscriptions.Show()
        GestionInscriptions.Supprimer.Visible = True
        GestionInscriptions.Modifier.Visible = True
        GestionInscriptions.Consulter.Visible = False
        GestionInscriptions.Fermer.Visible = False
    End Sub

    'Private Sub Sauver_Inscription(sender As Object, e As EventArgs) _
    '    Handles Me.Closed
    '    Dim Path As String = "\Save"

    '    Dim Save As FileStream = File.Create(Path)

    'End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        ConsulterInscriptions.Show()
    End Sub

    Private Sub Bilan_Click(sender As Object, e As EventArgs) Handles Bilan.Click
        MenuBilan.Visible = True
    End Sub
End Class
