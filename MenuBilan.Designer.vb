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
        Me.BilanIndividuel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BilanIndividuel
        '
        Me.BilanIndividuel.Location = New System.Drawing.Point(412, 203)
        Me.BilanIndividuel.Name = "BilanIndividuel"
        Me.BilanIndividuel.Size = New System.Drawing.Size(172, 78)
        Me.BilanIndividuel.TabIndex = 0
        Me.BilanIndividuel.Text = "Bilan Individuel"
        Me.BilanIndividuel.UseVisualStyleBackColor = True
        '
        'MenuBilan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BilanIndividuel)
        Me.Name = "MenuBilan"
        Me.Text = "MenuBilan"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BilanIndividuel As Button
End Class
