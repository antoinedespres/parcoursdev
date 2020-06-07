<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuBilan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuBilan))
        Me.BilanIndividuel = New System.Windows.Forms.Button()
        Me.BtnBilanMatiere = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnCloture = New System.Windows.Forms.Button()
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'BilanIndividuel
        '
        Me.BilanIndividuel.Location = New System.Drawing.Point(12, 133)
        Me.BilanIndividuel.Margin = New System.Windows.Forms.Padding(2)
        Me.BilanIndividuel.Name = "BilanIndividuel"
        Me.BilanIndividuel.Size = New System.Drawing.Size(129, 63)
        Me.BilanIndividuel.TabIndex = 0
        Me.BilanIndividuel.Text = "Bilan individuel"
        Me.BilanIndividuel.UseVisualStyleBackColor = true
        '
        'BtnBilanMatiere
        '
        Me.BtnBilanMatiere.Location = New System.Drawing.Point(157, 133)
        Me.BtnBilanMatiere.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnBilanMatiere.Name = "BtnBilanMatiere"
        Me.BtnBilanMatiere.Size = New System.Drawing.Size(129, 63)
        Me.BtnBilanMatiere.TabIndex = 1
        Me.BtnBilanMatiere.Text = "Bilan par matière"
        Me.BtnBilanMatiere.UseVisualStyleBackColor = true
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"),System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(237, 52)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = false
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(13, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Sélectionnez le type de bilan"
        '
        'BtnCloture
        '
        Me.BtnCloture.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.BtnCloture.ForeColor = System.Drawing.Color.Red
        Me.BtnCloture.Location = New System.Drawing.Point(283, 12)
        Me.BtnCloture.Name = "BtnCloture"
        Me.BtnCloture.Size = New System.Drawing.Size(146, 64)
        Me.BtnCloture.TabIndex = 4
        Me.BtnCloture.Text = "Clôturer les inscriptions"
        Me.BtnCloture.UseVisualStyleBackColor = true
        '
        'MenuBilan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(441, 210)
        Me.Controls.Add(Me.BtnCloture)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnBilanMatiere)
        Me.Controls.Add(Me.BilanIndividuel)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "MenuBilan"
        Me.Text = "Bilan des inscriptions"
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents BilanIndividuel As Button
    Friend WithEvents BtnBilanMatiere As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnCloture As Button
End Class
