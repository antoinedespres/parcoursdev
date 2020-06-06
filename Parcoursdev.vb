Public Module Parcoursdev

    Public ListCandidats As List(Of Candidat) = New List(Of Candidat)()

    Public Const MAXEpreuvesEcrit = 4
    Public Const MAXEpreuvesOral = 3

    Public Structure Candidat
        Public NumCandidat As Integer
        Public nom, prenom, adresse, codepostal, ville As String
        Public age As Integer
        Public Region As String
        Public matieres() As String
    End Structure
    Dim NumAuto As Integer = 1

    Sub Main()
        LireFichiers()
        Application.Run(Menu)
    End Sub

    Sub LireFichiers()
        'TODO
    End Sub

    Sub ajout(nom As String, prenom As String, adresse As String, codepostal As String, ville As String, age As Integer,
              Region As String, matieres() As String)
        Dim c As New Candidat With {
                .NumCandidat = NumAuto,
                .nom = nom,
                .prenom = prenom,
                .adresse = adresse,
                .codepostal = codepostal,
                .ville = ville,
                .age = age,
                .Region = Region,
                .matieres = matieres
                }
        NumAuto += 1
        ListCandidats.Add(c)
    End Sub

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
            Case " Programmation web"
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

    Public Function Verif(ByRef GroupBoxEcrit As GroupBox, ByRef GroupBoxOral As GroupBox, ByRef LabelEPVFacultative As Label,
                          ByRef nbOptionsEcrit As Integer, ByRef nbOptionsOral As Integer, ByRef RadioButtonOui As RadioButton,
                          ByRef ComboBoxFacultative As ComboBox)
        Dim correct As Boolean = True
        GroupBoxEcrit.ForeColor = Color.Black
        GroupBoxOral.ForeColor = Color.Black
        LabelEPVFacultative.ForeColor = Color.Black

        If MAXEpreuvesOral - nbOptionsOral > 0 Then
            GroupBoxOral.ForeColor = Color.Red
            correct = False
        End If
        If MAXEpreuvesEcrit - nbOptionsEcrit > 0 Then
            GroupBoxEcrit.ForeColor = Color.Red
            correct = False
        End If
        If RadioButtonOui.Checked And ComboBoxFacultative.SelectedItem = "" Then
            LabelEPVFacultative.ForeColor = Color.Red
            correct = False
        End If

        Return correct
    End Function

    Public Function Verif(ByRef NomCandidat As String, ByRef PrenomCandidat As String, ByRef VilleCandidat As String, ByRef CPCandidat As String,
                          ByRef LabelNom As Label, LabelPrenom As Label, ByRef LabelVille As Label, ByRef LabelCP As Label,
                          ByRef GroupBoxEcrit As GroupBox, ByRef GroupBoxOral As GroupBox, ByRef LabelEPVFacultative As Label,
                          ByRef nbOptionsEcrit As Integer, ByRef nbOptionsOral As Integer, ByRef RadioButtonOui As RadioButton,
                          ByRef ComboBoxFacultative As ComboBox)
        Dim a As Boolean = Verif(NomCandidat, PrenomCandidat, VilleCandidat, CPCandidat,
                     LabelNom, LabelPrenom, LabelVille, LabelCP)
        Dim b As Boolean = Verif(GroupBoxEcrit, GroupBoxOral, LabelEPVFacultative,
                     nbOptionsEcrit, nbOptionsOral, RadioButtonOui, ComboBoxFacultative)
        Return a And b
    End Function
End Module
