<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu))
        Me.NouvInscription = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GererInscriptions = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Bilan = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NouvInscription
        '
        Me.NouvInscription.Location = New System.Drawing.Point(13, 172)
        Me.NouvInscription.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.NouvInscription.Name = "NouvInscription"
        Me.NouvInscription.Size = New System.Drawing.Size(135, 50)
        Me.NouvInscription.TabIndex = 0
        Me.NouvInscription.Text = "Nouvelle inscription"
        Me.NouvInscription.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(13, 13)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(371, 84)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'GererInscriptions
        '
        Me.GererInscriptions.Location = New System.Drawing.Point(154, 172)
        Me.GererInscriptions.Name = "GererInscriptions"
        Me.GererInscriptions.Size = New System.Drawing.Size(125, 49)
        Me.GererInscriptions.TabIndex = 2
        Me.GererInscriptions.Text = "Gérer les inscriptions"
        Me.GererInscriptions.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(285, 172)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(145, 49)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Consulter les Inscriptions"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Bilan
        '
        Me.Bilan.Location = New System.Drawing.Point(12, 243)
        Me.Bilan.Name = "Bilan"
        Me.Bilan.Size = New System.Drawing.Size(417, 57)
        Me.Bilan.TabIndex = 4
        Me.Bilan.Text = "Bilan"
        Me.Bilan.UseVisualStyleBackColor = True
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(447, 312)
        Me.Controls.Add(Me.Bilan)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GererInscriptions)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.NouvInscription)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Menu"
        Me.Text = "Parcoursdev - Menu"
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents NouvInscription As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GererInscriptions As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Bilan As Button
End Class
