Imports System.Net.Cache

''' <summary>
''' Formulaire de choix de la région de passage et des épreuves
''' </summary>
Public Class ChoixRegionMatieres
    Dim _tempsRestant = 90
    Dim _nbOptionsEcrit As Integer = 0
    Dim _nbOptionsOral As Integer = 0

    ''' <summary>
    ''' Chargement du formulaire
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ChoixRegionMatieres_Load(sender As Object, e As EventArgs) _
        Handles MyBase.Load
        
        ComboBoxRegions.Items.AddRange(TabRegions)
        ComboBoxRegions.SelectedIndex = 0

        For i = 0 To TabEcrit.Length - 1
            GroupBoxEcrit.Controls(i).Text = TabEcrit(TabEcrit.Length - i - 1)
        Next
        
        For j = 0 To TabOral.Length - 1
            GroupBoxOral.Controls(j).Text = TabOral(TabOral.Length - j - 1)
        Next

        IDCandidat.Text = "Candidat : " & Inscription.NomCandidat.Text & " " &
                          Inscription.PrenomCandidat.Text
        NbEpvEcritRest.Text = MaxEpreuvesEcrit & " épreuves à sélectionner."
        NbEpvOralRest.Text = MaxEpreuvesOral & " épreuves à sélectionner."
        TimerRegionMatiere.Interval = 1000
        RadioButtonOui.Enabled = False
        RadioButtonNon.Enabled = False
        LabelEPVFacultative.Visible = False
        ComboBoxFacultative.Visible = False
    End Sub

    ''' <summary>
    ''' Décrémentation du compte à rebours et fermeture si temps écoulé
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub TimerRegionMatiere_Tick(sender As Object, e As EventArgs) _
        Handles TimerRegionMatiere.Tick
        _tempsRestant -=1
        If _tempsRestant > 0 Then
            Me.Text = "Choix région et matières " & TimeString & ", " &
                      _tempsRestant & " secondes restantes"
        Else
            Me.Close()
            MsgBox("Temps écoulé.")
        End If
    End Sub

    ''' <summary>
    ''' Gestion de changement d'état dans GroupBoxEcrit
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
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
            If _nbOptionsEcrit > MaxEpreuvesEcrit Then
                MsgBox("Impossible de sélectionner plus de " &
                       MaxEpreuvesEcrit & " épreuves écrites.")
                sender.Checked = False
            End If
        Else
            _nbOptionsEcrit -= 1
        End If
        NbEpvEcritRest.Text = MaxEpreuvesEcrit - _nbOptionsEcrit &
                              If(MaxEpreuvesEcrit - _nbOptionsEcrit > 1,
                                  " épreuves ", " épreuve ") &
                              "à sélectionner."
        VerifEpv()
    End Sub

    ''' <summary>
    ''' Gestion de changement d'état dans GroupBoxOral
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
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
            If _nbOptionsOral > MaxEpreuvesOral Then
                MsgBox("Impossible de sélectionner plus de " _
                       & MaxEpreuvesOral & " épreuves orales.")
                sender.Checked = False
            End If
        Else
            _nbOptionsOral -= 1
        End If
        NbEpvOralRest.Text = MaxEpreuvesOral - _nbOptionsOral &
                             IIf(MaxEpreuvesOral - _nbOptionsOral > 1, 
                                 " épreuves ", " épreuve ") & 
                             "à sélectionner."
        VerifEpv()
    End Sub

    ''' <summary>
    ''' Gestion du changement d'état du choix d'épreuve facultative
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Facultatif_CheckedChanged(sender As Object, e As EventArgs) _
        Handles RadioButtonOui.CheckedChanged
        If RadioButtonOui.Checked = True Then
            ComboBoxFacultative.Visible = True
        Else
            ComboBoxFacultative.Visible = False
            ComboBoxFacultative.Items.Clear()
        End If
    End Sub

    ''' <summary>
    ''' Chargement de la liste d'épreuves facultatives disponibles
    ''' </summary>
    ''' <param name="gb">Une GroupBox (écrit ou oral)</param>
    Private Sub ChargerListe(ByRef gb As GroupBox)
        For Each control As CheckBox In gb.Controls
            If control.Checked = False And Not ComboBoxFacultative.Items.Contains(control.Text) _
               And control.Enabled = True Then
                ComboBoxFacultative.Items.Add(control.Text)
            End If
        Next
    End Sub

    ''' <summary>
    ''' Vérifie que le bon nombre d'épreuves est choisi
    ''' </summary>
    Sub VerifEpv()
        If _nbOptionsEcrit = MaxEpreuvesEcrit And _nbOptionsOral =
                                                  MaxEpreuvesOral Then
            RadioButtonOui.Enabled = True
            RadioButtonNon.Enabled = True
            RadioButtonNon.Checked = True
        Else
            RadioButtonOui.Enabled = False
            RadioButtonNon.Enabled = False
            ComboBoxFacultative.Visible = False
        End If
    End Sub

    ''' <summary>
    ''' Gestion du changement d'état sur la ComboBox d'épreuve facultative
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
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

    ''' <summary>
    ''' Retour au menu au clic sur le bouton d'abandon
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub abandon_Click(sender As Object, e As EventArgs) _
        Handles abandonBoutton.Click
        Inscription.Close()
        Me.Close()
    End Sub

    ''' <summary>
    ''' Affiche le récapitulatif si l'inscription est correcte
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Validation_Click(sender As Object, e As EventArgs) _
        Handles ValidBoutton.Click
        If Verif(GroupBoxEcrit, GroupBoxOral, LabelEPVFacultative, _nbOptionsEcrit, _nbOptionsOral, RadioButtonOui, ComboBoxFacultative) = True Then
            TimerRegionMatiere.Stop()
            Me.Hide()
            Recap.Show()
        End If
    End Sub
End Class