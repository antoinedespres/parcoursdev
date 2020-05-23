Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tabRégions() As String = {"Auvergne", "Bordelais", "Bourgogne",
                                      "Bretagne", "Corse", "Nord", "Normandie",
                                      "Paris", "Poitou", "Roussillon"}
        'RegionBox.Items.AddRange(tabRégions)

        Dim tabEcrit() As String = {"Algorithmique", "Base de données",
                                    "Langage C", "Langage Java",
                                    "Programmation web", "Visual Basic .NET"}

        Dim tabEcritOral() As String = {"Droit", "Expression", "Gestion",
                                        "Mathématiques", "Réseau", "Système"}

        Dim tabOral() As String = {"Anglais", "Chinois", "Espagnol"}
    End Sub
End Class