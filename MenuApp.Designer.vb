<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuApp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuApp))
        Me.NouvInscription = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GererInscriptions = New System.Windows.Forms.Button()
        Me.BtnConsulterInscriptions = New System.Windows.Forms.Button()
        Me.Bilan = New System.Windows.Forms.Button()
        Me.LabelSlogan = New System.Windows.Forms.Label()
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'NouvInscription
        '
        Me.NouvInscription.Location = New System.Drawing.Point(10, 140)
        Me.NouvInscription.Margin = New System.Windows.Forms.Padding(2)
        Me.NouvInscription.Name = "NouvInscription"
        Me.NouvInscription.Size = New System.Drawing.Size(101, 41)
        Me.NouvInscription.TabIndex = 0
        Me.NouvInscription.Text = "Nouvelle inscription"
        Me.NouvInscription.UseVisualStyleBackColor = true
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"),System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(33, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(278, 68)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = false
        '
        'GererInscriptions
        '
        Me.GererInscriptions.Location = New System.Drawing.Point(116, 140)
        Me.GererInscriptions.Margin = New System.Windows.Forms.Padding(2)
        Me.GererInscriptions.Name = "GererInscriptions"
        Me.GererInscriptions.Size = New System.Drawing.Size(94, 40)
        Me.GererInscriptions.TabIndex = 2
        Me.GererInscriptions.Text = "Gérer les inscriptions"
        Me.GererInscriptions.UseVisualStyleBackColor = true
        '
        'BtnConsulterInscriptions
        '
        Me.BtnConsulterInscriptions.Location = New System.Drawing.Point(214, 140)
        Me.BtnConsulterInscriptions.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnConsulterInscriptions.Name = "BtnConsulterInscriptions"
        Me.BtnConsulterInscriptions.Size = New System.Drawing.Size(109, 40)
        Me.BtnConsulterInscriptions.TabIndex = 3
        Me.BtnConsulterInscriptions.Text = "Consulter les Inscriptions"
        Me.BtnConsulterInscriptions.UseVisualStyleBackColor = true
        '
        'Bilan
        '
        Me.Bilan.Location = New System.Drawing.Point(9, 197)
        Me.Bilan.Margin = New System.Windows.Forms.Padding(2)
        Me.Bilan.Name = "Bilan"
        Me.Bilan.Size = New System.Drawing.Size(313, 46)
        Me.Bilan.TabIndex = 4
        Me.Bilan.Text = "Bilan des inscriptions"
        Me.Bilan.UseVisualStyleBackColor = true
        '
        'LabelSlogan
        '
        Me.LabelSlogan.AutoSize = true
        Me.LabelSlogan.Location = New System.Drawing.Point(80, 83)
        Me.LabelSlogan.Name = "LabelSlogan"
        Me.LabelSlogan.Size = New System.Drawing.Size(188, 13)
        Me.LabelSlogan.TabIndex = 5
        Me.LabelSlogan.Text = "Entrez dans le monde de l'informatique"
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(335, 254)
        Me.Controls.Add(Me.LabelSlogan)
        Me.Controls.Add(Me.Bilan)
        Me.Controls.Add(Me.BtnConsulterInscriptions)
        Me.Controls.Add(Me.GererInscriptions)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.NouvInscription)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Menu"
        Me.Text = "Parcoursdev - Menu"
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents NouvInscription As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GererInscriptions As Button
    Friend WithEvents BtnConsulterInscriptions As Button
    Friend WithEvents Bilan As Button
    Friend WithEvents LabelSlogan As Label
End Class
