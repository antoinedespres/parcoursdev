<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BilanMatiere
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BilanMatiere))
        Me.ComboBoxMatieres = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBoxRegionNomPre = New System.Windows.Forms.ListBox()
        Me.Fermer = New System.Windows.Forms.Button()
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'ComboBoxMatieres
        '
        Me.ComboBoxMatieres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxMatieres.FormattingEnabled = true
        Me.ComboBoxMatieres.Location = New System.Drawing.Point(326, 59)
        Me.ComboBoxMatieres.MaxDropDownItems = 15
        Me.ComboBoxMatieres.Name = "ComboBoxMatieres"
        Me.ComboBoxMatieres.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxMatieres.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"),System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(278, 68)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = false
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(326, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Sélection de la matière :"
        '
        'ListBoxRegionNomPre
        '
        Me.ListBoxRegionNomPre.FormattingEnabled = true
        Me.ListBoxRegionNomPre.Location = New System.Drawing.Point(67, 140)
        Me.ListBoxRegionNomPre.Name = "ListBoxRegionNomPre"
        Me.ListBoxRegionNomPre.Size = New System.Drawing.Size(340, 212)
        Me.ListBoxRegionNomPre.TabIndex = 4
        '
        'Fermer
        '
        Me.Fermer.Location = New System.Drawing.Point(215, 369)
        Me.Fermer.Name = "Fermer"
        Me.Fermer.Size = New System.Drawing.Size(75, 23)
        Me.Fermer.TabIndex = 5
        Me.Fermer.Text = "Fermer"
        Me.Fermer.UseVisualStyleBackColor = true
        '
        'BilanMatiere
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(470, 404)
        Me.Controls.Add(Me.Fermer)
        Me.Controls.Add(Me.ListBoxRegionNomPre)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ComboBoxMatieres)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "BilanMatiere"
        Me.Text = "Bilan par matières"
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents ComboBoxMatieres As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ListBoxRegionNomPre As ListBox
    Friend WithEvents Fermer As Button
End Class
