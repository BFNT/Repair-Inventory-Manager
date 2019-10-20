<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddMachine_ID
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.newIDBox = New System.Windows.Forms.MaskedTextBox()
        Me.AddMachine_ID_CancelButton = New System.Windows.Forms.Button()
        Me.NextButton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RandomIDButton = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(331, 62)
        Me.Label1.TabIndex = 100
        Me.Label1.Text = "Scanner un ID" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ou entrez le manuellement"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'newIDBox
        '
        Me.newIDBox.AllowDrop = True
        Me.newIDBox.AsciiOnly = True
        Me.newIDBox.BeepOnError = True
        Me.newIDBox.Location = New System.Drawing.Point(6, 16)
        Me.newIDBox.Mask = "9999999999"
        Me.newIDBox.Name = "newIDBox"
        Me.newIDBox.Size = New System.Drawing.Size(100, 20)
        Me.newIDBox.TabIndex = 0
        Me.newIDBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'AddMachine_ID_CancelButton
        '
        Me.AddMachine_ID_CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.AddMachine_ID_CancelButton.Location = New System.Drawing.Point(146, 132)
        Me.AddMachine_ID_CancelButton.Name = "AddMachine_ID_CancelButton"
        Me.AddMachine_ID_CancelButton.Size = New System.Drawing.Size(75, 23)
        Me.AddMachine_ID_CancelButton.TabIndex = 0
        Me.AddMachine_ID_CancelButton.TabStop = False
        Me.AddMachine_ID_CancelButton.Text = "Annuler"
        Me.AddMachine_ID_CancelButton.UseVisualStyleBackColor = True
        '
        'NextButton
        '
        Me.NextButton.Location = New System.Drawing.Point(273, 132)
        Me.NextButton.Name = "NextButton"
        Me.NextButton.Size = New System.Drawing.Size(75, 23)
        Me.NextButton.TabIndex = 1
        Me.NextButton.TabStop = False
        Me.NextButton.Text = "Suivant"
        Me.NextButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.newIDBox)
        Me.GroupBox1.Location = New System.Drawing.Point(129, 74)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(112, 42)
        Me.GroupBox1.TabIndex = 101
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Nouvel ID"
        '
        'RandomIDButton
        '
        Me.RandomIDButton.Enabled = False
        Me.RandomIDButton.Location = New System.Drawing.Point(247, 88)
        Me.RandomIDButton.Name = "RandomIDButton"
        Me.RandomIDButton.Size = New System.Drawing.Size(59, 23)
        Me.RandomIDButton.TabIndex = 102
        Me.RandomIDButton.TabStop = False
        Me.RandomIDButton.Text = "Aléatoire"
        Me.RandomIDButton.UseVisualStyleBackColor = True
        '
        'AddMachine_ID
        '
        Me.AcceptButton = Me.NextButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.AddMachine_ID_CancelButton
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(360, 167)
        Me.Controls.Add(Me.RandomIDButton)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.NextButton)
        Me.Controls.Add(Me.AddMachine_ID_CancelButton)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(376, 206)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(376, 206)
        Me.Name = "AddMachine_ID"
        Me.ShowIcon = False
        Me.Text = "Ajouter un ordinateur"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents newIDBox As MaskedTextBox
    Friend WithEvents AddMachine_ID_CancelButton As Button
    Friend WithEvents NextButton As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RandomIDButton As Button
End Class
