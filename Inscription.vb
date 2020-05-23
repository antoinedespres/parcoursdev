Public Class Inscription 'temps 1 minute
    Const AGEMIN = 18
    Const AGEMAX = 55
    Dim _tempsRestant = 60
    Private Sub Inscription_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NomCadidat.MaxLength = 15
        PrenomCadidat.MaxLength = 20
        AdresseCadidat.MaxLength = 15
        CPCandidat.MaxLength = 5
        VilleCandidat.MaxLength = 15
        HScrollBarAge.Minimum = AGEMIN
        'Décalage à cause de la largeur du slider
        HScrollBarAge.Maximum = AGEMAX + (HScrollBarAge.LargeChange - 1)

        TimerInscription.Interval = 1000
        TimerInscription.Start()
        'timerTick(sender, e) 'à quoi ça sert ce truc
    End Sub

    Private Sub TimerInscription_Tick(sender As System.Object, e As System.EventArgs) _
        Handles TimerInscription.Tick
        _tempsRestant = _tempsRestant - 1
        If _tempsRestant > 0 Then
            Me.Text = "Inscription " & TimeString & " " & _tempsRestant
        Else
            Me.Close()
            MsgBox("Temps écoulé")
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
        Verif()

        'Pour chaque champ stocker la valeur dans un type structuré

    End Sub

    Sub Textuel_keypress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) _
        Handles NomCadidat.KeyPress, PrenomCadidat.KeyPress, VilleCandidat.KeyPress
        If e.KeyChar = vbBack Then Exit Sub
        If Not Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Sub Numeric_keypress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) _
        Handles CPCandidat.KeyPress
        LabelCP.ForeColor = Color.Black

        If e.KeyChar = vbBack Then Exit Sub
        If Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Sub Verif()
        If CPCandidat.Text.Substring(0, 2) = "00" Or CPCandidat.Text.Length <> 5 Then
            LabelCP.ForeColor = Color.Red
        End If
    End Sub
End Class