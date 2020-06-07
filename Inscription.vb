''' <summary>
''' Formulaire de nouvelle inscription
''' </summary>
Public Class Inscription
    Public Const AGEMIN = 18
    Public Const AGEMAX = 55
    Dim _tempsRestant = 60

    ''' <summary>
    ''' Chargement du formulaire
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
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

    ''' <summary>
    ''' Décrémentation du compte à rebours et affichage de MsgBox si temps écoulé
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub TimerInscription_Tick(sender As Object, e As EventArgs) _
        Handles TimerInscription.Tick
        _tempsRestant -= 1
        If _tempsRestant > 0 Then
            Me.Text = "Inscription " & TimeString & ", " & _tempsRestant & 
                      " secondes"
        Else
            Me.Close()
            MsgBox("Temps écoulé.")
        End If
    End Sub

    ''' <summary>
    ''' Changement de l'âge via Scroll
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub HScrollBarAge_Scroll(sender As Object, e As ScrollEventArgs) _
        Handles HScrollBarAge.Scroll
        LabelAgeSelect.Text = HScrollBarAge.Value & " ans"
    End Sub

    ''' <summary>
    ''' Fermeture au clic sur le bouton d'abandon
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Abandonner_Click(sender As Object, e As EventArgs) _
        Handles Abandonner.Click
        Me.Close()
    End Sub

    ''' <summary>
    ''' Passage au formulaire suivant (choix des matières)
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Enregistrer_Click(sender As Object, e As EventArgs) _
        Handles Enregistrer.Click
        If Verif(NomCandidat.Text , PrenomCandidat.Text , VilleCandidat.Text , 
                 CPCandidat.Text , LabelNom , LabelPrenom,  LabelVille , LabelCP) = True Then
            TimerInscription.Stop()
            ChoixRegionMatieres.Show()
            ChoixRegionMatieres.TimerRegionMatiere.Start()
            Me.Hide()
        End If
    End Sub

    ''' <summary>
    ''' Blocage des chiffres dans les champs Nom, Prénom et Ville
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Textuel_keypress(sender As Object, e As KeyPressEventArgs) _
        Handles NomCandidat.KeyPress, PrenomCandidat.KeyPress, VilleCandidat.KeyPress
        LabelNom.ForeColor = Color.Black
        LabelPrenom.ForeColor = Color.Black
        LabelVille.ForeColor = Color.Black
        If e.KeyChar = vbBack Then Exit Sub
        If Not Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ''' <summary>
    ''' Blocage des lettres dans le champ de saisie du code postal
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Numeric_keypress(sender As Object, e As KeyPressEventArgs) _
        Handles CPCandidat.KeyPress
        LabelCP.ForeColor = Color.Black

        If e.KeyChar = vbBack Then Exit Sub
        If Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class