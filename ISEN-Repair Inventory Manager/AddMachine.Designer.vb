<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddMachine
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddMachine))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.NewIDBox = New System.Windows.Forms.TextBox()
        Me.NewGivenByBox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.NewSerieCheckBox = New System.Windows.Forms.CheckBox()
        Me.NewDetailsBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NewNameBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.AddCompCancelButton = New System.Windows.Forms.Button()
        Me.AddComputerButton = New System.Windows.Forms.Button()
        Me.NewEtatBox = New System.Windows.Forms.ComboBox()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.NewEtatBox)
        Me.GroupBox2.Controls.Add(Me.NewIDBox)
        Me.GroupBox2.Controls.Add(Me.NewGivenByBox)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.NewSerieCheckBox)
        Me.GroupBox2.Controls.Add(Me.NewDetailsBox)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.NewNameBox)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(194, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(508, 169)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Information et détails"
        '
        'NewIDBox
        '
        Me.NewIDBox.Location = New System.Drawing.Point(37, 16)
        Me.NewIDBox.Name = "NewIDBox"
        Me.NewIDBox.ReadOnly = True
        Me.NewIDBox.Size = New System.Drawing.Size(79, 20)
        Me.NewIDBox.TabIndex = 0
        Me.NewIDBox.TabStop = False
        '
        'NewGivenByBox
        '
        Me.NewGivenByBox.Location = New System.Drawing.Point(251, 47)
        Me.NewGivenByBox.Name = "NewGivenByBox"
        Me.NewGivenByBox.Size = New System.Drawing.Size(176, 20)
        Me.NewGivenByBox.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(174, 50)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Provenance :"
        '
        'NewSerieCheckBox
        '
        Me.NewSerieCheckBox.AutoSize = True
        Me.NewSerieCheckBox.Location = New System.Drawing.Point(433, 49)
        Me.NewSerieCheckBox.Name = "NewSerieCheckBox"
        Me.NewSerieCheckBox.Size = New System.Drawing.Size(59, 17)
        Me.NewSerieCheckBox.TabIndex = 3
        Me.NewSerieCheckBox.Text = "Serie ?"
        Me.NewSerieCheckBox.UseVisualStyleBackColor = True
        '
        'NewDetailsBox
        '
        Me.NewDetailsBox.Location = New System.Drawing.Point(58, 77)
        Me.NewDetailsBox.Multiline = True
        Me.NewDetailsBox.Name = "NewDetailsBox"
        Me.NewDetailsBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.NewDetailsBox.Size = New System.Drawing.Size(434, 84)
        Me.NewDetailsBox.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Etat :"
        '
        'NewNameBox
        '
        Me.NewNameBox.Location = New System.Drawing.Point(154, 16)
        Me.NewNameBox.Name = "NewNameBox"
        Me.NewNameBox.Size = New System.Drawing.Size(339, 20)
        Me.NewNameBox.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Détails :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(122, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nom :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID :"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(176, 183)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'AddCompCancelButton
        '
        Me.AddCompCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.AddCompCancelButton.Location = New System.Drawing.Point(276, 187)
        Me.AddCompCancelButton.Name = "AddCompCancelButton"
        Me.AddCompCancelButton.Size = New System.Drawing.Size(163, 23)
        Me.AddCompCancelButton.TabIndex = 6
        Me.AddCompCancelButton.Text = "Annuler"
        Me.AddCompCancelButton.UseVisualStyleBackColor = True
        '
        'AddComputerButton
        '
        Me.AddComputerButton.Location = New System.Drawing.Point(526, 187)
        Me.AddComputerButton.Name = "AddComputerButton"
        Me.AddComputerButton.Size = New System.Drawing.Size(176, 23)
        Me.AddComputerButton.TabIndex = 5
        Me.AddComputerButton.Text = "Ajouter"
        Me.AddComputerButton.UseVisualStyleBackColor = True
        '
        'NewEtatBox
        '
        Me.NewEtatBox.FormattingEnabled = True
        Me.NewEtatBox.Items.AddRange(New Object() {"R.I.P", "Peut faire l'affaire", "En état", "Neuf"})
        Me.NewEtatBox.Location = New System.Drawing.Point(45, 47)
        Me.NewEtatBox.Name = "NewEtatBox"
        Me.NewEtatBox.Size = New System.Drawing.Size(121, 21)
        Me.NewEtatBox.TabIndex = 1
        '
        'AddMachine
        '
        Me.AcceptButton = Me.AddComputerButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.AddCompCancelButton
        Me.ClientSize = New System.Drawing.Size(714, 220)
        Me.Controls.Add(Me.AddComputerButton)
        Me.Controls.Add(Me.AddCompCancelButton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddMachine"
        Me.ShowIcon = False
        Me.Text = "Ajouter un ordinateur"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents NewGivenByBox As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents NewSerieCheckBox As CheckBox
    Friend WithEvents NewDetailsBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents NewNameBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents NewIDBox As TextBox
    Friend WithEvents AddCompCancelButton As Button
    Friend WithEvents AddComputerButton As Button
    Friend WithEvents NewEtatBox As ComboBox
End Class
