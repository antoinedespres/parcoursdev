Public Class Inscription
    Public Const AGEMIN = 18
    Public Const AGEMAX = 55
    Dim _tempsRestant = 60

    Private Sub Inscription_Load(sender As Object, e As EventArgs) _
        Handles MyBase.Load
        NomCandidat.MaxLength = 15
        PrenomCandidat.MaxLength = 20
        AdresseCandidat.MaxLength = 30
        CPCandidat.MaxLength = 5
        VilleCandidat.MaxLength = 15

        HScrollBarAge.Minimum = AGEMIN
        'Décalage à cause de la largeur du slider
        HScrollBarAge.Maximum = AGEMAX + (HScrollBarAge.LargeChange - 1)
        LabelAgeSelect.Text = HScrollBarAge.Value & " ans"

        TimerInscription.Interval = 1000
        TimerInscription.Start()
    End Sub

    Private Sub TimerInscription_Tick(sender As Object, e As EventArgs) _
        Handles TimerInscription.Tick
        _tempsRestant -= 1
        If _tempsRestant > 0 Then
            Me.Text = "Inscription " & TimeString & " " & _tempsRestant
        Else
            Me.Close()
            MsgBox("Temps écoulé.")
        End If
    End Sub

    Private Sub HScrollBarAge_Scroll(sender As Object, e As ScrollEventArgs) _
        Handles HScrollBarAge.Scroll
        LabelAgeSelect.Text = HScrollBarAge.Value & " ans"
    End Sub

    Private Sub Abandonner_Click(sender As Object, e As EventArgs) Handles Abandonner.Click
        Me.Close()
    End Sub

    Private Sub Enregistrer_Click(sender As Object, e As EventArgs) Handles Enregistrer.Click
        If Verif() = True Then
            TimerInscription.Stop()
            ChoixRegionMatieres.Show()
            ChoixRegionMatieres.TimerRegionMatiere.Start()
            Me.Hide()
        End If
    End Sub

    Sub Textuel_keypress(sender As Object, e As KeyPressEventArgs) _
        Handles NomCandidat.KeyPress, PrenomCandidat.KeyPress, VilleCandidat.KeyPress
        If e.KeyChar = vbBack Then Exit Sub
        If Not Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Sub Numeric_keypress(sender As Object, e As KeyPressEventArgs) _
        Handles CPCandidat.KeyPress
        LabelCP.ForeColor = Color.Black

        If e.KeyChar = vbBack Then Exit Sub
        If Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Function Verif()

        Dim correct As Boolean = True
        If NomCandidat.Text = "" Then
            correct = False
            LabelNom.ForeColor = Color.Red
        End If
        If PrenomCandidat.Text = "" Then
            correct = False
            LabelPrenom.ForeColor = Color.Red
        End If

        If VilleCandidat.Text = "" Then
            correct = False
            LabelVille.ForeColor = Color.Red
        End If

        If CPCandidat.Text.Length <> 5 Then
            LabelCP.ForeColor = Color.Red
            correct = False
        End If

        If CPCandidat.Text.Length > 1 Then
            If CPCandidat.Text.Substring(0, 2) = "00" Then
                LabelCP.ForeColor = Color.Red
                correct = False
            End If
        End If
        Return correct
    End Function
End Class