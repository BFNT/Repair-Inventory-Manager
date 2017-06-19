<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditSpecs
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.OSCmbBox = New System.Windows.Forms.ComboBox()
        Me.RAMCmbBox = New System.Windows.Forms.ComboBox()
        Me.ProcArchCmbBox = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ActivateCheck = New System.Windows.Forms.CheckBox()
        Me.SoftCheck = New System.Windows.Forms.CheckBox()
        Me.DrvCheck = New System.Windows.Forms.CheckBox()
        Me.OSCheck = New System.Windows.Forms.CheckBox()
        Me.HWCheck = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.NewIDBox = New System.Windows.Forms.TextBox()
        Me.GivedByBox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.EtatBox = New System.Windows.Forms.TextBox()
        Me.SerieCheckBox = New System.Windows.Forms.CheckBox()
        Me.EmprunterName = New System.Windows.Forms.TextBox()
        Me.EmpruntCheckBox = New System.Windows.Forms.CheckBox()
        Me.DetailsBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NameBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SaveEditButton = New System.Windows.Forms.Button()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.OSCmbBox)
        Me.GroupBox3.Controls.Add(Me.RAMCmbBox)
        Me.GroupBox3.Controls.Add(Me.ProcArchCmbBox)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.ActivateCheck)
        Me.GroupBox3.Controls.Add(Me.SoftCheck)
        Me.GroupBox3.Controls.Add(Me.DrvCheck)
        Me.GroupBox3.Controls.Add(Me.OSCheck)
        Me.GroupBox3.Controls.Add(Me.HWCheck)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 203)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(508, 93)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Avancement"
        '
        'OSCmbBox
        '
        Me.OSCmbBox.FormattingEnabled = True
        Me.OSCmbBox.Items.AddRange(New Object() {"Win XP PRO SP3", "WIN 7 SP1", "WIN 10", "UNIX", "Inconnue"})
        Me.OSCmbBox.Location = New System.Drawing.Point(47, 41)
        Me.OSCmbBox.Name = "OSCmbBox"
        Me.OSCmbBox.Size = New System.Drawing.Size(315, 21)
        Me.OSCmbBox.TabIndex = 16
        '
        'RAMCmbBox
        '
        Me.RAMCmbBox.FormattingEnabled = True
        Me.RAMCmbBox.Items.AddRange(New Object() {"<1G", "1G", "2G", "3G", "4G", ">4G"})
        Me.RAMCmbBox.Location = New System.Drawing.Point(294, 18)
        Me.RAMCmbBox.Name = "RAMCmbBox"
        Me.RAMCmbBox.Size = New System.Drawing.Size(68, 21)
        Me.RAMCmbBox.TabIndex = 15
        '
        'ProcArchCmbBox
        '
        Me.ProcArchCmbBox.FormattingEnabled = True
        Me.ProcArchCmbBox.Items.AddRange(New Object() {"32bits", "64bits"})
        Me.ProcArchCmbBox.Location = New System.Drawing.Point(188, 18)
        Me.ProcArchCmbBox.Name = "ProcArchCmbBox"
        Me.ProcArchCmbBox.Size = New System.Drawing.Size(57, 21)
        Me.ProcArchCmbBox.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(251, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "RAM :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(85, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Proc/Architecture :"
        '
        'ActivateCheck
        '
        Me.ActivateCheck.AutoSize = True
        Me.ActivateCheck.Location = New System.Drawing.Point(72, 67)
        Me.ActivateCheck.Name = "ActivateCheck"
        Me.ActivateCheck.Size = New System.Drawing.Size(73, 17)
        Me.ActivateCheck.TabIndex = 4
        Me.ActivateCheck.TabStop = False
        Me.ActivateCheck.Text = "Activation"
        Me.ActivateCheck.UseVisualStyleBackColor = True
        '
        'SoftCheck
        '
        Me.SoftCheck.AutoSize = True
        Me.SoftCheck.Location = New System.Drawing.Point(151, 67)
        Me.SoftCheck.Name = "SoftCheck"
        Me.SoftCheck.Size = New System.Drawing.Size(68, 17)
        Me.SoftCheck.TabIndex = 3
        Me.SoftCheck.TabStop = False
        Me.SoftCheck.Text = "Software"
        Me.SoftCheck.UseVisualStyleBackColor = True
        '
        'DrvCheck
        '
        Me.DrvCheck.AutoSize = True
        Me.DrvCheck.Location = New System.Drawing.Point(7, 67)
        Me.DrvCheck.Name = "DrvCheck"
        Me.DrvCheck.Size = New System.Drawing.Size(59, 17)
        Me.DrvCheck.TabIndex = 2
        Me.DrvCheck.TabStop = False
        Me.DrvCheck.Text = "Drivers"
        Me.DrvCheck.UseVisualStyleBackColor = True
        '
        'OSCheck
        '
        Me.OSCheck.AutoSize = True
        Me.OSCheck.Location = New System.Drawing.Point(7, 43)
        Me.OSCheck.Name = "OSCheck"
        Me.OSCheck.Size = New System.Drawing.Size(44, 17)
        Me.OSCheck.TabIndex = 1
        Me.OSCheck.TabStop = False
        Me.OSCheck.Text = "O.S"
        Me.OSCheck.UseVisualStyleBackColor = True
        '
        'HWCheck
        '
        Me.HWCheck.AutoSize = True
        Me.HWCheck.Location = New System.Drawing.Point(7, 20)
        Me.HWCheck.Name = "HWCheck"
        Me.HWCheck.Size = New System.Drawing.Size(72, 17)
        Me.HWCheck.TabIndex = 0
        Me.HWCheck.TabStop = False
        Me.HWCheck.Text = "Hardware"
        Me.HWCheck.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.NewIDBox)
        Me.GroupBox2.Controls.Add(Me.GivedByBox)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.EtatBox)
        Me.GroupBox2.Controls.Add(Me.SerieCheckBox)
        Me.GroupBox2.Controls.Add(Me.EmprunterName)
        Me.GroupBox2.Controls.Add(Me.EmpruntCheckBox)
        Me.GroupBox2.Controls.Add(Me.DetailsBox)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.NameBox)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(508, 191)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Information et détails"
        '
        'NewIDBox
        '
        Me.NewIDBox.Location = New System.Drawing.Point(37, 16)
        Me.NewIDBox.Name = "NewIDBox"
        Me.NewIDBox.ReadOnly = True
        Me.NewIDBox.Size = New System.Drawing.Size(79, 20)
        Me.NewIDBox.TabIndex = 17
        Me.NewIDBox.TabStop = False
        '
        'GivedByBox
        '
        Me.GivedByBox.Location = New System.Drawing.Point(251, 47)
        Me.GivedByBox.Name = "GivedByBox"
        Me.GivedByBox.ReadOnly = True
        Me.GivedByBox.Size = New System.Drawing.Size(176, 20)
        Me.GivedByBox.TabIndex = 16
        Me.GivedByBox.TabStop = False
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
        'EtatBox
        '
        Me.EtatBox.Location = New System.Drawing.Point(37, 47)
        Me.EtatBox.Name = "EtatBox"
        Me.EtatBox.ReadOnly = True
        Me.EtatBox.Size = New System.Drawing.Size(131, 20)
        Me.EtatBox.TabIndex = 13
        Me.EtatBox.TabStop = False
        '
        'SerieCheckBox
        '
        Me.SerieCheckBox.AutoSize = True
        Me.SerieCheckBox.Enabled = False
        Me.SerieCheckBox.Location = New System.Drawing.Point(433, 49)
        Me.SerieCheckBox.Name = "SerieCheckBox"
        Me.SerieCheckBox.Size = New System.Drawing.Size(59, 17)
        Me.SerieCheckBox.TabIndex = 12
        Me.SerieCheckBox.TabStop = False
        Me.SerieCheckBox.Text = "Serie ?"
        Me.SerieCheckBox.UseVisualStyleBackColor = True
        '
        'EmprunterName
        '
        Me.EmprunterName.Location = New System.Drawing.Point(109, 166)
        Me.EmprunterName.Name = "EmprunterName"
        Me.EmprunterName.Size = New System.Drawing.Size(150, 20)
        Me.EmprunterName.TabIndex = 11
        Me.EmprunterName.TabStop = False
        '
        'EmpruntCheckBox
        '
        Me.EmpruntCheckBox.AutoSize = True
        Me.EmpruntCheckBox.Location = New System.Drawing.Point(5, 168)
        Me.EmpruntCheckBox.Name = "EmpruntCheckBox"
        Me.EmpruntCheckBox.Size = New System.Drawing.Size(98, 17)
        Me.EmpruntCheckBox.TabIndex = 10
        Me.EmpruntCheckBox.TabStop = False
        Me.EmpruntCheckBox.Text = "Emprunté  par :"
        Me.EmpruntCheckBox.UseVisualStyleBackColor = True
        '
        'DetailsBox
        '
        Me.DetailsBox.Location = New System.Drawing.Point(109, 77)
        Me.DetailsBox.Multiline = True
        Me.DetailsBox.Name = "DetailsBox"
        Me.DetailsBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DetailsBox.Size = New System.Drawing.Size(383, 84)
        Me.DetailsBox.TabIndex = 9
        Me.DetailsBox.TabStop = False
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
        'NameBox
        '
        Me.NameBox.Location = New System.Drawing.Point(154, 16)
        Me.NameBox.Name = "NameBox"
        Me.NameBox.ReadOnly = True
        Me.NameBox.Size = New System.Drawing.Size(339, 20)
        Me.NameBox.TabIndex = 5
        Me.NameBox.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(58, 80)
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
        'SaveEditButton
        '
        Me.SaveEditButton.Location = New System.Drawing.Point(166, 302)
        Me.SaveEditButton.Name = "SaveEditButton"
        Me.SaveEditButton.Size = New System.Drawing.Size(194, 44)
        Me.SaveEditButton.TabIndex = 7
        Me.SaveEditButton.Text = "Enregistrer"
        Me.SaveEditButton.UseVisualStyleBackColor = True
        '
        'EditSpecs
        '
        Me.AcceptButton = Me.SaveEditButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 351)
        Me.Controls.Add(Me.SaveEditButton)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(550, 390)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(550, 390)
        Me.Name = "EditSpecs"
        Me.ShowIcon = False
        Me.Text = "Editeur d'entrée"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ActivateCheck As CheckBox
    Friend WithEvents SoftCheck As CheckBox
    Friend WithEvents DrvCheck As CheckBox
    Friend WithEvents OSCheck As CheckBox
    Friend WithEvents HWCheck As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GivedByBox As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents EtatBox As TextBox
    Friend WithEvents SerieCheckBox As CheckBox
    Friend WithEvents EmprunterName As TextBox
    Friend WithEvents EmpruntCheckBox As CheckBox
    Friend WithEvents DetailsBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents NameBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents NewIDBox As TextBox
    Friend WithEvents RAMCmbBox As ComboBox
    Friend WithEvents ProcArchCmbBox As ComboBox
    Friend WithEvents OSCmbBox As ComboBox
    Friend WithEvents SaveEditButton As Button
End Class
