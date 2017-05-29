<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FichierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjouterUnPCToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.QuitterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.StatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.InvSearchBar = New System.Windows.Forms.TextBox()
        Me.InvList = New System.Windows.Forms.ListBox()
        Me.SendOutButton = New System.Windows.Forms.Button()
        Me.TrashButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NameBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DetailsBox = New System.Windows.Forms.TextBox()
        Me.EmpruntCheckBox = New System.Windows.Forms.CheckBox()
        Me.EmprunterName = New System.Windows.Forms.TextBox()
        Me.SerieCheckBox = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TypeComBox = New System.Windows.Forms.TextBox()
        Me.EtatBox = New System.Windows.Forms.TextBox()
        Me.HWCheck = New System.Windows.Forms.CheckBox()
        Me.OSCheck = New System.Windows.Forms.CheckBox()
        Me.DrvCheck = New System.Windows.Forms.CheckBox()
        Me.SoftCheck = New System.Windows.Forms.CheckBox()
        Me.ActivateCheck = New System.Windows.Forms.CheckBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Mem = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.OS = New System.Windows.Forms.TextBox()
        Me.Arch = New System.Windows.Forms.TextBox()
        Me.EditButton = New System.Windows.Forms.Button()
        Me.IDBox = New System.Windows.Forms.MaskedTextBox()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FichierToolStripMenuItem, Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(875, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FichierToolStripMenuItem
        '
        Me.FichierToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AjouterUnPCToolStripMenuItem, Me.ToolStripSeparator1, Me.QuitterToolStripMenuItem})
        Me.FichierToolStripMenuItem.Name = "FichierToolStripMenuItem"
        Me.FichierToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.FichierToolStripMenuItem.Text = "Fichier"
        '
        'AjouterUnPCToolStripMenuItem
        '
        Me.AjouterUnPCToolStripMenuItem.Name = "AjouterUnPCToolStripMenuItem"
        Me.AjouterUnPCToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AjouterUnPCToolStripMenuItem.Text = "Ajouter un PC"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(149, 6)
        '
        'QuitterToolStripMenuItem
        '
        Me.QuitterToolStripMenuItem.Name = "QuitterToolStripMenuItem"
        Me.QuitterToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.QuitterToolStripMenuItem.Text = "Quitter"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(24, 20)
        Me.ToolStripMenuItem1.Text = "?"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusLabel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 375)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(875, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'StatusLabel
        '
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(67, 17)
        Me.StatusLabel.Text = "StatusLabel"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.InvSearchBar)
        Me.GroupBox1.Controls.Add(Me.InvList)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(336, 339)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Inventaire"
        '
        'InvSearchBar
        '
        Me.InvSearchBar.Location = New System.Drawing.Point(7, 20)
        Me.InvSearchBar.Name = "InvSearchBar"
        Me.InvSearchBar.Size = New System.Drawing.Size(323, 20)
        Me.InvSearchBar.TabIndex = 1
        '
        'InvList
        '
        Me.InvList.FormattingEnabled = True
        Me.InvList.Location = New System.Drawing.Point(6, 48)
        Me.InvList.Name = "InvList"
        Me.InvList.ScrollAlwaysVisible = True
        Me.InvList.Size = New System.Drawing.Size(324, 277)
        Me.InvList.Sorted = True
        Me.InvList.TabIndex = 2
        '
        'SendOutButton
        '
        Me.SendOutButton.Location = New System.Drawing.Point(701, 343)
        Me.SendOutButton.Name = "SendOutButton"
        Me.SendOutButton.Size = New System.Drawing.Size(156, 23)
        Me.SendOutButton.TabIndex = 6
        Me.SendOutButton.TabStop = False
        Me.SendOutButton.Text = "Livré"
        Me.SendOutButton.UseVisualStyleBackColor = True
        '
        'TrashButton
        '
        Me.TrashButton.Location = New System.Drawing.Point(361, 343)
        Me.TrashButton.Name = "TrashButton"
        Me.TrashButton.Size = New System.Drawing.Size(156, 23)
        Me.TrashButton.TabIndex = 7
        Me.TrashButton.TabStop = False
        Me.TrashButton.Text = "Jeté"
        Me.TrashButton.UseVisualStyleBackColor = True
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(122, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nom :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Type :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Commentaires :"
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(262, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Etat :"
        '
        'DetailsBox
        '
        Me.DetailsBox.Location = New System.Drawing.Point(92, 77)
        Me.DetailsBox.Multiline = True
        Me.DetailsBox.Name = "DetailsBox"
        Me.DetailsBox.ReadOnly = True
        Me.DetailsBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DetailsBox.Size = New System.Drawing.Size(400, 84)
        Me.DetailsBox.TabIndex = 9
        Me.DetailsBox.TabStop = False
        '
        'EmpruntCheckBox
        '
        Me.EmpruntCheckBox.AutoSize = True
        Me.EmpruntCheckBox.Enabled = False
        Me.EmpruntCheckBox.Location = New System.Drawing.Point(5, 168)
        Me.EmpruntCheckBox.Name = "EmpruntCheckBox"
        Me.EmpruntCheckBox.Size = New System.Drawing.Size(101, 17)
        Me.EmpruntCheckBox.TabIndex = 10
        Me.EmpruntCheckBox.TabStop = False
        Me.EmpruntCheckBox.Text = "Emprunter  par :"
        Me.EmpruntCheckBox.UseVisualStyleBackColor = True
        '
        'EmprunterName
        '
        Me.EmprunterName.Location = New System.Drawing.Point(106, 166)
        Me.EmprunterName.Name = "EmprunterName"
        Me.EmprunterName.ReadOnly = True
        Me.EmprunterName.Size = New System.Drawing.Size(150, 20)
        Me.EmprunterName.TabIndex = 11
        Me.EmprunterName.TabStop = False
        '
        'SerieCheckBox
        '
        Me.SerieCheckBox.AutoSize = True
        Me.SerieCheckBox.Enabled = False
        Me.SerieCheckBox.Location = New System.Drawing.Point(433, 46)
        Me.SerieCheckBox.Name = "SerieCheckBox"
        Me.SerieCheckBox.Size = New System.Drawing.Size(59, 17)
        Me.SerieCheckBox.TabIndex = 12
        Me.SerieCheckBox.TabStop = False
        Me.SerieCheckBox.Text = "Serie ?"
        Me.SerieCheckBox.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.IDBox)
        Me.GroupBox2.Controls.Add(Me.TextBox4)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.TypeComBox)
        Me.GroupBox2.Controls.Add(Me.EtatBox)
        Me.GroupBox2.Controls.Add(Me.SerieCheckBox)
        Me.GroupBox2.Controls.Add(Me.EmprunterName)
        Me.GroupBox2.Controls.Add(Me.EmpruntCheckBox)
        Me.GroupBox2.Controls.Add(Me.DetailsBox)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.NameBox)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(355, 28)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(508, 191)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Information et détails"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(339, 166)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(153, 20)
        Me.TextBox4.TabIndex = 16
        Me.TextBox4.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(262, 169)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Provenance :"
        '
        'TypeComBox
        '
        Me.TypeComBox.Location = New System.Drawing.Point(45, 44)
        Me.TypeComBox.Name = "TypeComBox"
        Me.TypeComBox.ReadOnly = True
        Me.TypeComBox.Size = New System.Drawing.Size(211, 20)
        Me.TypeComBox.TabIndex = 14
        Me.TypeComBox.TabStop = False
        '
        'EtatBox
        '
        Me.EtatBox.Location = New System.Drawing.Point(296, 44)
        Me.EtatBox.Name = "EtatBox"
        Me.EtatBox.ReadOnly = True
        Me.EtatBox.Size = New System.Drawing.Size(131, 20)
        Me.EtatBox.TabIndex = 13
        Me.EtatBox.TabStop = False
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
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(6, 90)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(496, 23)
        Me.ProgressBar1.TabIndex = 5
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
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(248, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "RAM :"
        '
        'Mem
        '
        Me.Mem.Location = New System.Drawing.Point(291, 17)
        Me.Mem.Name = "Mem"
        Me.Mem.ReadOnly = True
        Me.Mem.Size = New System.Drawing.Size(57, 20)
        Me.Mem.TabIndex = 10
        Me.Mem.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.OS)
        Me.GroupBox3.Controls.Add(Me.Arch)
        Me.GroupBox3.Controls.Add(Me.Mem)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.ProgressBar1)
        Me.GroupBox3.Controls.Add(Me.ActivateCheck)
        Me.GroupBox3.Controls.Add(Me.SoftCheck)
        Me.GroupBox3.Controls.Add(Me.DrvCheck)
        Me.GroupBox3.Controls.Add(Me.OSCheck)
        Me.GroupBox3.Controls.Add(Me.HWCheck)
        Me.GroupBox3.Location = New System.Drawing.Point(355, 219)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(508, 118)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Avancement"
        '
        'OS
        '
        Me.OS.Location = New System.Drawing.Point(57, 41)
        Me.OS.Name = "OS"
        Me.OS.ReadOnly = True
        Me.OS.Size = New System.Drawing.Size(59, 20)
        Me.OS.TabIndex = 13
        '
        'Arch
        '
        Me.Arch.Location = New System.Drawing.Point(188, 18)
        Me.Arch.Name = "Arch"
        Me.Arch.ReadOnly = True
        Me.Arch.Size = New System.Drawing.Size(54, 20)
        Me.Arch.TabIndex = 12
        '
        'EditButton
        '
        Me.EditButton.Location = New System.Drawing.Point(523, 343)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(172, 23)
        Me.EditButton.TabIndex = 8
        Me.EditButton.TabStop = False
        Me.EditButton.Text = "Modifier"
        Me.EditButton.UseVisualStyleBackColor = True
        '
        'IDBox
        '
        Me.IDBox.Location = New System.Drawing.Point(37, 16)
        Me.IDBox.Mask = "9999999999"
        Me.IDBox.Name = "IDBox"
        Me.IDBox.Size = New System.Drawing.Size(79, 20)
        Me.IDBox.TabIndex = 17
        Me.IDBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(875, 397)
        Me.Controls.Add(Me.EditButton)
        Me.Controls.Add(Me.TrashButton)
        Me.Controls.Add(Me.SendOutButton)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.Text = "ISEN-Repair Inventory Manager"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FichierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuitterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents StatusLabel As ToolStripStatusLabel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents InvSearchBar As TextBox
    Friend WithEvents InvList As ListBox
    Friend WithEvents SendOutButton As Button
    Friend WithEvents TrashButton As Button
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents NameBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DetailsBox As TextBox
    Friend WithEvents EmpruntCheckBox As CheckBox
    Friend WithEvents EmprunterName As TextBox
    Friend WithEvents SerieCheckBox As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents HWCheck As CheckBox
    Friend WithEvents OSCheck As CheckBox
    Friend WithEvents DrvCheck As CheckBox
    Friend WithEvents SoftCheck As CheckBox
    Friend WithEvents ActivateCheck As CheckBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Mem As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TypeComBox As TextBox
    Friend WithEvents EtatBox As TextBox
    Friend WithEvents OS As TextBox
    Friend WithEvents Arch As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents EditButton As Button
    Friend WithEvents AjouterUnPCToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents IDBox As MaskedTextBox
End Class
