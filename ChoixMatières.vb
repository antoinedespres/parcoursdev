Public Class ChoixMatières
    Private Sub ChoixMatières_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tabRégions() As String = {"Auvergne", "Bordelais", "Bourgogne",
                                      "Bretagne", "Corse", "Nord", "Normandie",
                                      "Paris", "Poitou", "Roussillon"}
        'RegionBox.Items.AddRange(tabRégions)

        Dim tabÉcrit() As String = {"Algorithmique", "Base de données", "Droit",
                                    "Expression", "Gestion", "Langage C",
                                    "Langage Java", "Mathématiques",
                                    "Programmation web", "Réseau",
                                    "Système", "Visual Basic .NET"}

        Dim tabOral() As String = {"Anglais", "Chinois", "Espagnol"}
    End Sub
End Class