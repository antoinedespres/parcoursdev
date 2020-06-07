''' <summary>
''' Module Parcoursdev, contient le Sub Main()
''' </summary>
Public Module Parcoursdev

    Public ListCandidats As List(Of Candidat) = New List(Of Candidat)()

    Public Const MaxEpreuvesEcrit = 4
    Public Const MaxEpreuvesOral = 3

    Public Structure Candidat
        Public NumCandidat As Integer
        Public Nom, Prenom, Adresse, CodPostal, Ville As String
        Public Age As Integer
        Public Region As String
        Public Matieres() As String
    End Structure

    Public TabRegions() As String = {"Auvergne", "Bordelais", "Bourgogne",
                                     "Bretagne", "Corse", "Nord", "Normandie",
                                     "Paris", "Poitou", "Roussillon"}
    Public TabEcrit() As String = {"Algorithmique", "Base de données", "Droit",
                                   "Expression", "Gestion", "Langage C", "Langage Java",
                                   "Mathématiques", "Programmation web",
                                   "Réseau", "Système", "Visual Basic .NET"}

    Public TabOral() As String = {"Droit", "Expression", "Gestion",
                                  "Mathématiques", "Réseau", "Système",
                                  "Anglais", "Chinois", "Espagnol"}
    Public NumAuto As Integer = 1

    Public PathSaveApp As String = ".\\localdata\\"
    Public PathSaveListing As String = ".\\listing\\"

    Public FileName As String = "data.parcoursdev"

    ''' <summary>
    ''' Point d'entrée de l'application : lecture de fichiers et ouverture du menu
    ''' </summary>
    Sub Main()
        LireFichiers()
        Application.Run(MenuApp)
    End Sub

    ''' <summary>
    ''' Lecture des fichiers
    ''' </summary>
    Sub LireFichiers()
        'TODO
    End Sub

    ''' <summary>
    ''' Ajout d'un nouveau candidat
    ''' </summary>
    ''' <param name="nom">Nom du candidat</param>
    ''' <param name="prenom">Prénom du candidat</param>
    ''' <param name="adresse">Adresse du candidat (facultative)</param>
    ''' <param name="codepostal">Code postal du candidat</param>
    ''' <param name="ville">Ville du candidat</param>
    ''' <param name="age">Âge du candidat</param>
    ''' <param name="Region">Région de passage du concours</param>
    ''' <param name="matieres">Matières choisies</param>
    Sub ajout(numDonne As Integer, nom As String, prenom As String, adresse As String, codepostal As String, ville As String, age As Integer,
              Region As String, matieres() As String)
        Dim c As New Candidat With {
                .NumCandidat = numDonne,
                .Nom = nom,
                .Prenom = prenom,
                .Adresse = adresse,
                .CodPostal = codepostal,
                .Ville = ville,
                .Age = age,
                .Region = Region,
                .Matieres = matieres
                }
        ListCandidats.Add(c)
    End Sub

    Sub ajout(nom As String, prenom As String, adresse As String, codepostal As String,
              ville As String, age As Integer,
              Region As String, matieres() As String)
        ajout(NumAuto, nom, prenom, adresse, codepostal, ville, age, Region, matieres)
        NumAuto += 1
    End Sub

    ''' <summary>
    ''' Obtention de l'index de la liste correspondant au numéro du candidat
    ''' </summary>
    ''' <param name="NumCandidat">Numéro du candidat</param>
    ''' <returns></returns>
    Public Function GetIndex(ByVal NumCandidat As Integer)
        Dim i As Integer
        For Each Candi In ListCandidats
            If Candi.NumCandidat = NumCandidat Then
                Return i
            End If
            i += 1
        Next
        Return -1
    End Function

    ''' <summary>
    ''' Obtention du trigramme de la matière à partir de son nom
    ''' </summary>
    ''' <param name="mat">Nom de la matière</param>
    ''' <returns></returns>
    Public Function GetTrigramme(ByVal mat As String)
        Select Case mat
            Case "Algorithmique"
                Return "ALG"
            Case "Base de données"
                Return "BDD"
            Case "Droit"
                Return "DRO"
            Case "Expression"
                Return "EXP"
            Case "Gestion"
                Return "GES"
            Case "Langage C"
                Return "LAC"
            Case "Langage Java"
                Return "JAV"
            Case "Mathématiques"
                Return "MAT"
            Case "Programmation web"
                Return "WEB"
            Case "Réseau"
                Return "RES"
            Case "Système"
                Return "SYS"
            Case "Visual Basic .NET"
                Return "VBN"
            Case "Anglais"
                Return "ANG"
            Case "Chinois"
                Return "CHI"
            Case "Espagnol"
                Return "ESP"
        End Select
        Return "ERR"
    End Function

    ''' <summary>
    ''' Vérification de la validité des saisies
    ''' </summary>
    ''' <param name="NomCandidat">Nom du candidat</param>
    ''' <param name="PrenomCandidat">Prénom du candidat</param>
    ''' <param name="VilleCandidat">Ville du candidat</param>
    ''' <param name="CPCandidat">Code postal du candidat</param>
    ''' <param name="LabelNom">Label Nom (pour la coloration)</param>
    ''' <param name="LabelPrenom">Label Prénom (pour la coloration</param>
    ''' <param name="LabelVille">Label Ville (pour la coloration)</param>
    ''' <param name="LabelCP">Label Code postal (pour la coloration)</param>
    ''' <returns></returns>
    Public Function Verif(ByRef NomCandidat As String, ByRef PrenomCandidat As String, ByRef VilleCandidat As String, ByRef CPCandidat As String,
                          ByRef LabelNom As Label, LabelPrenom As Label, ByRef LabelVille As Label, ByRef LabelCP As Label)
        LabelNom.ForeColor = Color.Black
        LabelPrenom.ForeColor = Color.Black
        LabelVille.ForeColor = Color.Black
        LabelCP.ForeColor = Color.Black
        Dim correct As Boolean = True
        If NomCandidat = "" Then
            correct = False
            LabelNom.ForeColor = Color.Red
        End If
        If PrenomCandidat = "" Then
            correct = False
            LabelPrenom.ForeColor = Color.Red
        End If

        If VilleCandidat = "" Then
            correct = False
            LabelVille.ForeColor = Color.Red
        End If

        If CPCandidat.Length <> 5 Then
            LabelCP.ForeColor = Color.Red
            correct = False
        End If

        If CPCandidat.Length > 1 Then
            If CPCandidat.Substring(0, 2) = "00" Then
                LabelCP.ForeColor = Color.Red
                correct = False
            End If
        End If
        Return correct
    End Function

    ''' <summary>
    ''' Vérification des choix d'épreuves
    ''' </summary>
    ''' <param name="GroupBoxEcrit">GroupBox d'épreuves écrites</param>
    ''' <param name="GroupBoxOral">GroupBox d'épreuves orales</param>
    ''' <param name="LabelEPVFacultative">Label d'epv facultative (coloration)</param>
    ''' <param name="nbOptionsEcrit">Nombre d'épreuves écrites sélectionnées</param>
    ''' <param name="nbOptionsOral">Nombre d'épreuves orales sélectionnées</param>
    ''' <param name="RadioButtonOui">RadioButton de choix Oui</param>
    ''' <param name="ComboBoxFacultative">ComboBox d'épreuve facultative</param>
    ''' <returns></returns>
    Public Function Verif(ByRef GroupBoxEcrit As GroupBox, ByRef GroupBoxOral As GroupBox, ByRef LabelEPVFacultative As Label,
                          ByRef nbOptionsEcrit As Integer, ByRef nbOptionsOral As Integer, ByRef RadioButtonOui As RadioButton,
                          ByRef ComboBoxFacultative As ComboBox)
        Dim correct As Boolean = True
        GroupBoxEcrit.ForeColor = Color.Black
        GroupBoxOral.ForeColor = Color.Black
        LabelEPVFacultative.ForeColor = Color.Black

        If MaxEpreuvesOral - nbOptionsOral > 0 Then
            GroupBoxOral.ForeColor = Color.Red
            correct = False
        End If
        If MaxEpreuvesEcrit - nbOptionsEcrit > 0 Then
            GroupBoxEcrit.ForeColor = Color.Red
            correct = False
        End If
        If RadioButtonOui.Checked And ComboBoxFacultative.SelectedItem = "" Then
            LabelEPVFacultative.ForeColor = Color.Red
            correct = False
        End If

        Return correct
    End Function

    ''' <summary>
    ''' Vérification de la saisie
    ''' </summary>
    ''' <param name="NomCandidat">Nom du candidat</param>
    ''' <param name="PrenomCandidat">Prénom du candidat</param>
    ''' <param name="VilleCandidat">Ville du candidat</param>
    ''' <param name="CPCandidat">Code postal du candidat</param>
    ''' <param name="LabelNom">Label de Nom (pour la coloration</param>
    ''' <param name="LabelPrenom">Label de Prénom (pour la coloration)</param>
    ''' <param name="LabelVille">Label de Ville (pour la coloration)</param>
    ''' <param name="LabelCP">Label de Code postal (pour la coloration)</param>
    ''' <param name="GroupBoxEcrit">GroupBox d'épreuves écrites</param>
    ''' <param name="GroupBoxOral">GroupBox d'épreuves orales</param>
    ''' <param name="LabelEPVFacultative">Label d'epv facultative (coloration)</param>
    ''' <param name="nbOptionsEcrit">Nombre d'épreuves écrites sélectionnées</param>
    ''' <param name="nbOptionsOral">Nombre d'épreuves orales sélectionnées</param>
    ''' <param name="RadioButtonOui">RadioButton de choix Oui</param>
    ''' <param name="ComboBoxFacultative">ComboBox d'épreuve facultative</param>
    ''' <returns></returns>
    Public Function Verif(ByRef NomCandidat As String, ByRef PrenomCandidat As String,
                          ByRef VilleCandidat As String, ByRef CPCandidat As String,
                          ByRef LabelNom As Label, LabelPrenom As Label, 
                          ByRef LabelVille As Label, ByRef LabelCP As Label,
                          ByRef GroupBoxEcrit As GroupBox, 
                          ByRef GroupBoxOral As GroupBox, 
                          ByRef LabelEPVFacultative As Label,
                          ByRef nbOptionsEcrit As Integer, 
                          ByRef nbOptionsOral As Integer, 
                          ByRef RadioButtonOui As RadioButton,
                          ByRef ComboBoxFacultative As ComboBox)
        Dim a As Boolean = Verif(NomCandidat, PrenomCandidat, VilleCandidat, CPCandidat,
                     LabelNom, LabelPrenom, LabelVille, LabelCP)
        Dim b As Boolean = Verif(GroupBoxEcrit, GroupBoxOral, LabelEPVFacultative,
                     nbOptionsEcrit, nbOptionsOral, RadioButtonOui, ComboBoxFacultative)
        Return a And b
    End Function
End Module
