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
        Me.QuitterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddComputerToolMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnleverPCsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GénérerDesIDsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DBToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImporterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExporterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.StatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.InvList = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NameBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DetailsBox = New System.Windows.Forms.TextBox()
        Me.EmpruntCheckBox = New System.Windows.Forms.CheckBox()
        Me.EmprunterName = New System.Windows.Forms.TextBox()
        Me.SerieCheckBox = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.IDBox = New System.Windows.Forms.MaskedTextBox()
        Me.GivenByBox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.EtatBox = New System.Windows.Forms.TextBox()
        Me.OpenBackupFile = New System.Windows.Forms.OpenFileDialog()
        Me.SaveBackupFile = New System.Windows.Forms.SaveFileDialog()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuitterToolStripMenuItem, Me.AddComputerToolMenuItem, Me.EnleverPCsToolStripMenuItem, Me.GénérerDesIDsToolStripMenuItem, Me.DBToolStripMenuItem, Me.AboutToolMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(874, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'QuitterToolStripMenuItem
        '
        Me.QuitterToolStripMenuItem.Name = "QuitterToolStripMenuItem"
        Me.QuitterToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.QuitterToolStripMenuItem.Text = "Quitter"
        '
        'AddComputerToolMenuItem
        '
        Me.AddComputerToolMenuItem.Name = "AddComputerToolMenuItem"
        Me.AddComputerToolMenuItem.Size = New System.Drawing.Size(81, 20)
        Me.AddComputerToolMenuItem.Text = "Ajouter PCs"
        '
        'EnleverPCsToolStripMenuItem
        '
        Me.EnleverPCsToolStripMenuItem.Name = "EnleverPCsToolStripMenuItem"
        Me.EnleverPCsToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.EnleverPCsToolStripMenuItem.Text = "Enlever PCs"
        '
        'GénérerDesIDsToolStripMenuItem
        '
        Me.GénérerDesIDsToolStripMenuItem.Name = "GénérerDesIDsToolStripMenuItem"
        Me.GénérerDesIDsToolStripMenuItem.Size = New System.Drawing.Size(100, 20)
        Me.GénérerDesIDsToolStripMenuItem.Text = "Générer des IDs"
        '
        'DBToolStripMenuItem
        '
        Me.DBToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImporterToolStripMenuItem, Me.ExporterToolStripMenuItem})
        Me.DBToolStripMenuItem.Name = "DBToolStripMenuItem"
        Me.DBToolStripMenuItem.Size = New System.Drawing.Size(34, 20)
        Me.DBToolStripMenuItem.Text = "DB"
        Me.DBToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'ImporterToolStripMenuItem
        '
        Me.ImporterToolStripMenuItem.Name = "ImporterToolStripMenuItem"
        Me.ImporterToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.ImporterToolStripMenuItem.Text = "Importer"
        '
        'ExporterToolStripMenuItem
        '
        Me.ExporterToolStripMenuItem.Name = "ExporterToolStripMenuItem"
        Me.ExporterToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.ExporterToolStripMenuItem.Text = "Exporter"
        '
        'AboutToolMenuItem
        '
        Me.AboutToolMenuItem.Name = "AboutToolMenuItem"
        Me.AboutToolMenuItem.Size = New System.Drawing.Size(24, 20)
        Me.AboutToolMenuItem.Text = "?"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusLabel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 375)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(874, 22)
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
        Me.GroupBox1.Controls.Add(Me.InvList)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(336, 339)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Inventaire"
        '
        'InvList
        '
        Me.InvList.FormattingEnabled = True
        Me.InvList.Location = New System.Drawing.Point(6, 17)
        Me.InvList.Name = "InvList"
        Me.InvList.ScrollAlwaysVisible = True
        Me.InvList.Size = New System.Drawing.Size(324, 316)
        Me.InvList.TabIndex = 1
        Me.InvList.TabStop = False
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(58, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Détails :"
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
        Me.Label5.Location = New System.Drawing.Point(7, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Etat :"
        '
        'DetailsBox
        '
        Me.DetailsBox.Location = New System.Drawing.Point(109, 77)
        Me.DetailsBox.Multiline = True
        Me.DetailsBox.Name = "DetailsBox"
        Me.DetailsBox.ReadOnly = True
        Me.DetailsBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DetailsBox.Size = New System.Drawing.Size(383, 84)
        Me.DetailsBox.TabIndex = 9
        Me.DetailsBox.TabStop = False
        '
        'EmpruntCheckBox
        '
        Me.EmpruntCheckBox.AutoSize = True
        Me.EmpruntCheckBox.Enabled = False
        Me.EmpruntCheckBox.Location = New System.Drawing.Point(5, 168)
        Me.EmpruntCheckBox.Name = "EmpruntCheckBox"
        Me.EmpruntCheckBox.Size = New System.Drawing.Size(98, 17)
        Me.EmpruntCheckBox.TabIndex = 10
        Me.EmpruntCheckBox.TabStop = False
        Me.EmpruntCheckBox.Text = "Emprunté  par :"
        Me.EmpruntCheckBox.UseVisualStyleBackColor = True
        '
        'EmprunterName
        '
        Me.EmprunterName.Location = New System.Drawing.Point(109, 166)
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
        Me.SerieCheckBox.Location = New System.Drawing.Point(433, 49)
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
        Me.GroupBox2.Controls.Add(Me.GivenByBox)
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
        Me.GroupBox2.Location = New System.Drawing.Point(366, 169)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(508, 191)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Information et détails"
        '
        'IDBox
        '
        Me.IDBox.AllowDrop = True
        Me.IDBox.AsciiOnly = True
        Me.IDBox.Location = New System.Drawing.Point(37, 16)
        Me.IDBox.Mask = "9999999999"
        Me.IDBox.Name = "IDBox"
        Me.IDBox.Size = New System.Drawing.Size(79, 20)
        Me.IDBox.TabIndex = 0
        Me.IDBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GivenByBox
        '
        Me.GivenByBox.Location = New System.Drawing.Point(251, 47)
        Me.GivenByBox.Name = "GivenByBox"
        Me.GivenByBox.ReadOnly = True
        Me.GivenByBox.Size = New System.Drawing.Size(176, 20)
        Me.GivenByBox.TabIndex = 16
        Me.GivenByBox.TabStop = False
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
        'OpenBackupFile
        '
        Me.OpenBackupFile.DefaultExt = "sqlite"
        Me.OpenBackupFile.Filter = "Fichier SQLite|*.sqlite"
        Me.OpenBackupFile.Title = "Importer la DB"
        '
        'SaveBackupFile
        '
        Me.SaveBackupFile.DefaultExt = "sqlite"
        Me.SaveBackupFile.Filter = "Fichier SQLite|*.sqlite"
        Me.SaveBackupFile.Title = "Exporter la DB"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(874, 397)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(890, 436)
        Me.MinimumSize = New System.Drawing.Size(890, 436)
        Me.Name = "Main"
        Me.Text = "ISEN-Repair Inventory Manager"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents StatusLabel As ToolStripStatusLabel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents InvList As ListBox
    Friend WithEvents AboutToolMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents NameBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DetailsBox As TextBox
    Friend WithEvents EmpruntCheckBox As CheckBox
    Friend WithEvents EmprunterName As TextBox
    Friend WithEvents SerieCheckBox As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents EtatBox As TextBox
    Friend WithEvents GivenByBox As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents IDBox As MaskedTextBox
    Private WithEvents AddComputerToolMenuItem As ToolStripMenuItem
    Friend WithEvents GénérerDesIDsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DBToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenBackupFile As OpenFileDialog
    Friend WithEvents SaveBackupFile As SaveFileDialog
    Friend WithEvents ImporterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExporterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuitterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnleverPCsToolStripMenuItem As ToolStripMenuItem
End Class
