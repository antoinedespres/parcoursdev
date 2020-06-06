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
        Me.ListBoxNomPreNumCand = New System.Windows.Forms.ListBox()
        Me.ListBoxEcrit = New System.Windows.Forms.ListBox()
        Me.ListBoxOral = New System.Windows.Forms.ListBox()
        Me.LabelFacultative = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Fermer = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'ListBoxNomPreNumCand
        '
        Me.ListBoxNomPreNumCand.FormattingEnabled = True
        Me.ListBoxNomPreNumCand.ItemHeight = 16
        Me.ListBoxNomPreNumCand.Location = New System.Drawing.Point(12, 137)
        Me.ListBoxNomPreNumCand.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ListBoxNomPreNumCand.Name = "ListBoxNomPreNumCand"
        Me.ListBoxNomPreNumCand.Size = New System.Drawing.Size(392, 292)
        Me.ListBoxNomPreNumCand.TabIndex = 0
        '
        'ListBoxEcrit
        '
        Me.ListBoxEcrit.FormattingEnabled = True
        Me.ListBoxEcrit.ItemHeight = 16
        Me.ListBoxEcrit.Location = New System.Drawing.Point(411, 137)
        Me.ListBoxEcrit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ListBoxEcrit.Name = "ListBoxEcrit"
        Me.ListBoxEcrit.Size = New System.Drawing.Size(81, 116)
        Me.ListBoxEcrit.TabIndex = 1
        '
        'ListBoxOral
        '
        Me.ListBoxOral.FormattingEnabled = True
        Me.ListBoxOral.ItemHeight = 16
        Me.ListBoxOral.Location = New System.Drawing.Point(411, 289)
        Me.ListBoxOral.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ListBoxOral.Name = "ListBoxOral"
        Me.ListBoxOral.Size = New System.Drawing.Size(84, 132)
        Me.ListBoxOral.TabIndex = 2
        '
        'LabelFacultative
        '
        Me.LabelFacultative.AutoSize = True
        Me.LabelFacultative.Location = New System.Drawing.Point(13, 478)
        Me.LabelFacultative.Name = "LabelFacultative"
        Me.LabelFacultative.Size = New System.Drawing.Size(76, 17)
        Me.LabelFacultative.TabIndex = 3
        Me.LabelFacultative.Text = "Facultative"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Parcoursdev.My.Resources.Resources.logo_large
        Me.PictureBox1.Location = New System.Drawing.Point(16, 15)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(404, 87)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 115)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(161, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Nom, prénom et numéro"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(407, 113)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Écrit"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(407, 265)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Oral"
        '
        'Fermer
        '
        Me.Fermer.Location = New System.Drawing.Point(354, 444)
        Me.Fermer.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Fermer.Name = "Fermer"
        Me.Fermer.Size = New System.Drawing.Size(104, 37)
        Me.Fermer.TabIndex = 10
        Me.Fermer.Text = "Fermer"
        Me.Fermer.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 445)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(137, 17)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Épreuve facultative :"
        '
        'ConsulterInscriptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 504)
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
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "ConsulterInscriptions"
        Me.Text = "Consultation des inscriptions"
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents ListBoxNomPreNumCand As ListBox
    Friend WithEvents ListBoxEcrit As ListBox
    Friend WithEvents ListBoxOral As ListBox
    Friend WithEvents LabelFacultative As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Fermer As Button
    Friend WithEvents Label5 As Label
End Class
