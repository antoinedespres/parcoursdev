Imports System.Net.Cache

Public Class ChoixRegionMatieres
    Dim _tempsRestant = 90
    Dim _nbOptionsEcrit As Integer = 0
    Dim _nbOptionsOral As Integer = 0

    Private Sub ChoixRegionMatieres_Load(sender As Object, e As EventArgs) _
        Handles MyBase.Load
        Dim tabRegions() As String = {"Auvergne", "Bordelais", "Bourgogne",
                                      "Bretagne", "Corse", "Nord", "Normandie",
                                      "Paris", "Poitou", "Roussillon"}
        ComboBoxRegions.Items.AddRange(tabRegions)
        ComboBoxRegions.SelectedIndex = 0

        Dim tabEcrit() As String = {"Algorithmique", "Base de données", "Droit",
                                    "Expression", "Gestion", "Langage C", "Langage Java",
                                    "Mathématiques", "Programmation web",
                                    "Réseau", "Système", "Visual Basic .NET"}

        For i = 0 To tabEcrit.Length - 1
            GroupBoxEcrit.Controls(i).Text = tabEcrit(tabEcrit.Length - i - 1)
        Next

        Dim tabOral() As String = {"Droit", "Expression", "Gestion",
                                   "Mathématiques", "Réseau", "Système",
                                   "Anglais", "Chinois", "Espagnol"}
        For j = 0 To tabOral.Length - 1
            GroupBoxOral.Controls(j).Text = tabOral(tabOral.Length - j - 1)
        Next

        IDCandidat.Text = "Candidat : " & Inscription.NomCandidat.Text & " " &
                          Inscription.PrenomCandidat.Text
        NbEpvEcritRest.Text = Parcoursdev.MAXEpreuvesEcrit & " épreuves à sélectionner."
        NbEpvOralRest.Text = Parcoursdev.MAXEpreuvesOral & " épreuves à sélectionner."
        TimerRegionMatiere.Interval = 1000
        RadioButtonOui.Enabled = False
        RadioButtonNon.Enabled = False
        LabelEPVFacultative.Visible = False
        ComboBoxFacultative.Visible = False
    End Sub

    Private Sub TimerRegionMatiere_Tick(sender As Object, e As EventArgs) _
        Handles TimerRegionMatiere.Tick
        _tempsRestant = _tempsRestant - 1
        If _tempsRestant > 0 Then
            Me.Text = "Choix région et matières " & TimeString & " " &
                      _tempsRestant
        Else
            Me.Close()
            MsgBox("Temps écoulé.")
        End If
    End Sub

    Private Sub abandon_Click(sender As Object, e As EventArgs) _
        Handles abandonBoutton.Click
        Inscription.Close()
        Me.Close()
    End Sub

    Private Sub Validation_Click(sender As Object, e As EventArgs) _
        Handles ValidBoutton.Click
        If Verif(GroupBoxEcrit, GroupBoxOral, LabelEPVFacultative, _nbOptionsEcrit, _nbOptionsOral, RadioButtonOui, ComboBoxFacultative) = True Then
            TimerRegionMatiere.Stop()
            Me.Hide()
            Recap.Show()
        End If
    End Sub

    Private Sub Ecrit_CheckedChanged(sender As Object, e As EventArgs) _
        Handles CheckBox1.CheckedChanged, CheckBox2.CheckedChanged,
                CheckBox3.CheckedChanged, CheckBox4.CheckedChanged,
                CheckBox5.CheckedChanged, CheckBox6.CheckedChanged,
                CheckBox7.CheckedChanged, CheckBox8.CheckedChanged,
                CheckBox9.CheckedChanged, CheckBox10.CheckedChanged,
                CheckBox11.CheckedChanged, CheckBox12.CheckedChanged
        GroupBoxEcrit.ForeColor = Color.Black
        For Each control In GroupBoxOral.Controls
            If control.Text = sender.Text Then
                control.Enabled = Not control.Enabled
            End If
        Next
        If sender.Checked Then
            _nbOptionsEcrit += 1
            If _nbOptionsEcrit > MAXEpreuvesEcrit Then
                MsgBox("Impossible de sélectionner plus de " &
                       MAXEpreuvesEcrit & " épreuves écrites.")
                sender.Checked = False
            End If
        Else
            _nbOptionsEcrit -= 1
        End If
        NbEpvEcritRest.Text = MAXEpreuvesEcrit - _nbOptionsEcrit &
                              If(MAXEpreuvesEcrit - _nbOptionsEcrit > 1,
                                  " épreuves ", " épreuve ") &
                              "à sélectionner."
        VerifEpv()
    End Sub

    Private Sub Oral_CheckedChanged(sender As Object, e As EventArgs) _
        Handles CheckBox13.CheckedChanged, CheckBox14.CheckedChanged, CheckBox15.CheckedChanged,
                CheckBox16.CheckedChanged, CheckBox17.CheckedChanged, CheckBox18.CheckedChanged,
                CheckBox19.CheckedChanged, CheckBox20.CheckedChanged, CheckBox21.CheckedChanged
        GroupBoxOral.ForeColor = Color.Black
        For Each control In GroupBoxEcrit.Controls
            If control.Text = sender.Text Then
                control.Enabled = Not control.Enabled
            End If
        Next
        If sender.Checked Then
            _nbOptionsOral += 1
            If _nbOptionsOral > MAXEpreuvesOral Then
                MsgBox("Impossible de sélectionner plus de " _
                       & MAXEpreuvesOral & " épreuves orales.")
                sender.Checked = False
            End If
        Else
            _nbOptionsOral -= 1
        End If
        NbEpvOralRest.Text = MAXEpreuvesOral - _nbOptionsOral &
                             IIf(MAXEpreuvesOral - _nbOptionsOral > 1, 
                                 " épreuves ", " épreuve ") & 
                             "à sélectionner."
        VerifEpv()
    End Sub

    Private Sub Fermeture_FormClosing(sender As Object, e As FormClosingEventArgs) _
        Handles Me.FormClosing
        Inscription.Show()
        Inscription.TimerInscription.Start()
    End Sub

    Private Sub Facultatif_CheckedChanged(sender As Object, e As EventArgs) _
        Handles RadioButtonOui.CheckedChanged
        If RadioButtonOui.Checked = True Then
            ComboBoxFacultative.Visible = True
        Else
            ComboBoxFacultative.Visible = False
            ComboBoxFacultative.Items.Clear()
        End If
    End Sub

    Private Sub ChargerListe(ByRef gb As GroupBox)
        For Each control As CheckBox In gb.Controls
            If control.Checked = False And Not ComboBoxFacultative.Items.Contains(control.Text) _
               And control.Enabled = True Then
                ComboBoxFacultative.Items.Add(control.Text)
            End If
        Next
    End Sub

    Sub VerifEpv()
        If _nbOptionsEcrit = MAXEpreuvesEcrit And _nbOptionsOral =
                                                  MAXEpreuvesOral Then
            RadioButtonOui.Enabled = True
            RadioButtonNon.Enabled = True
            RadioButtonNon.Checked = True
        Else
            RadioButtonOui.Enabled = False
            RadioButtonNon.Enabled = False
            ComboBoxFacultative.Visible = False
        End If
    End Sub

    Private Sub ComboBoxFacultative_VisibleChanged(sender As Object, e As EventArgs) _
        Handles ComboBoxFacultative.VisibleChanged
        LabelEPVFacultative.Visible = sender.Visible
        If sender.Visible = True Then
            ComboBoxFacultative.Items.Clear()
            ChargerListe(GroupBoxEcrit)
            ChargerListe(GroupBoxOral)
        Else
            ComboBoxFacultative.Items.Clear()
        End If
    End Sub
End Class