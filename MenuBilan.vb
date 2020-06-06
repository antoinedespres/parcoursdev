Public Class MenuBilan
    Private Sub BilanIndividuel_Click(sender As Object, e As EventArgs) Handles BilanIndividuel.Click
        GestionInscriptions.Show()
        GestionInscriptions.Supprimer.Visible = False
        GestionInscriptions.Modifier.Visible = False
        GestionInscriptions.Consulter.Visible = True
        GestionInscriptions.Fermer.Visible = True
    End Sub
End Class