<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GestionInscriptions
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GestionInscriptions))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ComboNumCandidats = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Supprimer = New System.Windows.Forms.Button()
        Me.Modifier = New System.Windows.Forms.Button()
        Me.ComboNomPreCandidats = New System.Windows.Forms.ComboBox()
        Me.Consulter = New System.Windows.Forms.Button()
        Me.Fermer = New System.Windows.Forms.Button()
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"),System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(10, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(219, 58)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = false
        '
        'ComboNumCandidats
        '
        Me.ComboNumCandidats.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboNumCandidats.FormattingEnabled = true
        Me.ComboNumCandidats.Location = New System.Drawing.Point(234, 41)
        Me.ComboNumCandidats.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboNumCandidats.Name = "ComboNumCandidats"
        Me.ComboNumCandidats.Size = New System.Drawing.Size(54, 21)
        Me.ComboNumCandidats.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(234, 24)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Sélectionnez un candidat :"
        '
        'Supprimer
        '
        Me.Supprimer.Location = New System.Drawing.Point(168, 96)
        Me.Supprimer.Margin = New System.Windows.Forms.Padding(2)
        Me.Supprimer.Name = "Supprimer"
        Me.Supprimer.Size = New System.Drawing.Size(72, 24)
        Me.Supprimer.TabIndex = 5
        Me.Supprimer.Text = "Suprimer"
        Me.Supprimer.UseVisualStyleBackColor = true
        '
        'Modifier
        '
        Me.Modifier.Location = New System.Drawing.Point(245, 96)
        Me.Modifier.Margin = New System.Windows.Forms.Padding(2)
        Me.Modifier.Name = "Modifier"
        Me.Modifier.Size = New System.Drawing.Size(56, 24)
        Me.Modifier.TabIndex = 6
        Me.Modifier.Text = "Modifier"
        Me.Modifier.UseVisualStyleBackColor = true
        '
        'ComboNomPreCandidats
        '
        Me.ComboNomPreCandidats.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboNomPreCandidats.FormattingEnabled = true
        Me.ComboNomPreCandidats.Location = New System.Drawing.Point(291, 41)
        Me.ComboNomPreCandidats.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboNomPreCandidats.Name = "ComboNomPreCandidats"
        Me.ComboNomPreCandidats.Size = New System.Drawing.Size(209, 21)
        Me.ComboNomPreCandidats.TabIndex = 7
        '
        'Consulter
        '
        Me.Consulter.Location = New System.Drawing.Point(433, 84)
        Me.Consulter.Margin = New System.Windows.Forms.Padding(2)
        Me.Consulter.Name = "Consulter"
        Me.Consulter.Size = New System.Drawing.Size(96, 32)
        Me.Consulter.TabIndex = 8
        Me.Consulter.Text = "Consulter"
        Me.Consulter.UseVisualStyleBackColor = true
        Me.Consulter.Visible = false
        '
        'Fermer
        '
        Me.Fermer.Location = New System.Drawing.Point(333, 84)
        Me.Fermer.Margin = New System.Windows.Forms.Padding(2)
        Me.Fermer.Name = "Fermer"
        Me.Fermer.Size = New System.Drawing.Size(88, 32)
        Me.Fermer.TabIndex = 9
        Me.Fermer.Text = "Fermer"
        Me.Fermer.UseVisualStyleBackColor = true
        Me.Fermer.Visible = false
        '
        'GestionInscriptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(549, 127)
        Me.Controls.Add(Me.Fermer)
        Me.Controls.Add(Me.Consulter)
        Me.Controls.Add(Me.ComboNomPreCandidats)
        Me.Controls.Add(Me.Modifier)
        Me.Controls.Add(Me.Supprimer)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboNumCandidats)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "GestionInscriptions"
        Me.Text = "Gérer les inscriptions"
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ComboNumCandidats As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Supprimer As Button
    Friend WithEvents Modifier As Button
    Friend WithEvents ComboNomPreCandidats As ComboBox
    Friend WithEvents Consulter As Button
    Friend WithEvents Fermer As Button
End Class
