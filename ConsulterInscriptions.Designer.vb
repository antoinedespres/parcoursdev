<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsulterInscriptions
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConsulterInscriptions))
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Fermer = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LabelFacultative = New System.Windows.Forms.Label()
        Me.ListBoxOral = New System.Windows.Forms.ListBox()
        Me.ListBoxEcrit = New System.Windows.Forms.ListBox()
        Me.ListBoxNomPreNumCand = New System.Windows.Forms.ListBox()
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Location = New System.Drawing.Point(10, 359)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Épreuve facultative :"
        '
        'Fermer
        '
        Me.Fermer.Location = New System.Drawing.Point(266, 358)
        Me.Fermer.Name = "Fermer"
        Me.Fermer.Size = New System.Drawing.Size(78, 30)
        Me.Fermer.TabIndex = 20
        Me.Fermer.Text = "Fermer"
        Me.Fermer.UseVisualStyleBackColor = true
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Location = New System.Drawing.Point(305, 212)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Oral"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Location = New System.Drawing.Point(305, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Écrit"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(9, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Nom, prénom et numéro"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Parcoursdev.My.Resources.Resources.logo_large
        Me.PictureBox1.Location = New System.Drawing.Point(12, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(303, 71)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = false
        '
        'LabelFacultative
        '
        Me.LabelFacultative.AutoSize = true
        Me.LabelFacultative.Location = New System.Drawing.Point(10, 385)
        Me.LabelFacultative.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelFacultative.Name = "LabelFacultative"
        Me.LabelFacultative.Size = New System.Drawing.Size(59, 13)
        Me.LabelFacultative.TabIndex = 15
        Me.LabelFacultative.Text = "Facultative"
        '
        'ListBoxOral
        '
        Me.ListBoxOral.FormattingEnabled = true
        Me.ListBoxOral.Location = New System.Drawing.Point(308, 232)
        Me.ListBoxOral.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ListBoxOral.Name = "ListBoxOral"
        Me.ListBoxOral.Size = New System.Drawing.Size(64, 108)
        Me.ListBoxOral.TabIndex = 14
        '
        'ListBoxEcrit
        '
        Me.ListBoxEcrit.FormattingEnabled = true
        Me.ListBoxEcrit.Location = New System.Drawing.Point(308, 108)
        Me.ListBoxEcrit.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ListBoxEcrit.Name = "ListBoxEcrit"
        Me.ListBoxEcrit.Size = New System.Drawing.Size(62, 95)
        Me.ListBoxEcrit.TabIndex = 13
        '
        'ListBoxNomPreNumCand
        '
        Me.ListBoxNomPreNumCand.FormattingEnabled = true
        Me.ListBoxNomPreNumCand.Location = New System.Drawing.Point(9, 108)
        Me.ListBoxNomPreNumCand.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ListBoxNomPreNumCand.Name = "ListBoxNomPreNumCand"
        Me.ListBoxNomPreNumCand.Size = New System.Drawing.Size(295, 238)
        Me.ListBoxNomPreNumCand.TabIndex = 12
        '
        'ConsulterInscriptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(388, 400)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Fermer)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LabelFacultative)
        Me.Controls.Add(Me.ListBoxOral)
        Me.Controls.Add(Me.ListBoxEcrit)
        Me.Controls.Add(Me.ListBoxNomPreNumCand)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "ConsulterInscriptions"
        Me.Text = "Consulter les inscriptions"
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents Fermer As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LabelFacultative As Label
    Friend WithEvents ListBoxOral As ListBox
    Friend WithEvents ListBoxEcrit As ListBox
    Friend WithEvents ListBoxNomPreNumCand As ListBox
End Class
