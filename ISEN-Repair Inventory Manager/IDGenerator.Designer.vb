<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class IDGenerator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IDGenerator))
        Me.Barcode1 = New IDAutomation.Windows.Forms.LinearBarCode.Barcode()
        Me.GenerateNewIDButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.newRandomIDBox = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PreviewButton = New System.Windows.Forms.Button()
        Me.GenerateMultiIDButton = New System.Windows.Forms.Button()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.IDListBox = New System.Windows.Forms.ListBox()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Barcode1
        '
        Me.Barcode1.ApplyTilde = False
        Me.Barcode1.BarHeightCM = 1.0!
        Me.Barcode1.BearerBarHorizontal = 0
        Me.Barcode1.BearerBarVertical = 0
        Me.Barcode1.CaptionAbove = ""
        Me.Barcode1.CaptionBelow = ""
        Me.Barcode1.CaptionBottomAlignment = System.Drawing.StringAlignment.Center
        Me.Barcode1.CaptionBottomColor = System.Drawing.Color.Black
        Me.Barcode1.CaptionBottomSpace = 0.1!
        Me.Barcode1.CaptionFontAbove = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Barcode1.CaptionFontBelow = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Barcode1.CaptionTopAlignment = System.Drawing.StringAlignment.Center
        Me.Barcode1.CaptionTopColor = System.Drawing.Color.Black
        Me.Barcode1.CaptionTopSpace = 0.1!
        Me.Barcode1.CharacterGrouping = 0
        Me.Barcode1.CheckCharacter = False
        Me.Barcode1.CheckCharacterInText = True
        Me.Barcode1.CODABARStartChar = "A"
        Me.Barcode1.CODABARStopChar = "B"
        Me.Barcode1.Code128Set = IDAutomation.Windows.Forms.LinearBarCode.Code128CharacterSets.[Auto]
        Me.Barcode1.DataToEncode = "0123456789"
        Me.Barcode1.DoPaint = True
        Me.Barcode1.FitControlToBarcode = True
        Me.Barcode1.LeftMarginCM = 0.2!
        Me.Barcode1.Location = New System.Drawing.Point(21, 57)
        Me.Barcode1.Name = "Barcode1"
        Me.Barcode1.NarrowToWideRatio = 2.0!
        Me.Barcode1.OneBitPerPixelImage = False
        Me.Barcode1.PostnetHeightShort = 0.127!
        Me.Barcode1.PostnetHeightTall = 0.3226!
        Me.Barcode1.PostnetSpacing = 0.064!
        Me.Barcode1.Resolution = IDAutomation.Windows.Forms.LinearBarCode.Resolutions.Screen
        Me.Barcode1.ResolutionCustomDPI = 96.0!
        Me.Barcode1.ResolutionPrinterToUse = ""
        Me.Barcode1.RotationAngle = IDAutomation.Windows.Forms.LinearBarCode.RotationAngles.Zero_Degrees
        Me.Barcode1.ShowText = True
        Me.Barcode1.ShowTextLocation = IDAutomation.Windows.Forms.LinearBarCode.HRTextPositions.Bottom
        Me.Barcode1.Size = New System.Drawing.Size(171, 74)
        Me.Barcode1.SuppSeparationCM = 0.5!
        Me.Barcode1.SymbologyID = IDAutomation.Windows.Forms.LinearBarCode.Symbologies.Code39
        Me.Barcode1.TabIndex = 100
        Me.Barcode1.TabStop = False
        Me.Barcode1.TextFontColor = System.Drawing.Color.Black
        Me.Barcode1.TextMarginCM = 0.1!
        Me.Barcode1.TopMarginCM = 0.2!
        Me.Barcode1.UPCESystem = "0"
        Me.Barcode1.WhiteBarIncrease = 0!
        Me.Barcode1.XDimensionCM = 0.0298!
        Me.Barcode1.XDimensionMILS = 11.7714!
        '
        'GenerateNewIDButton
        '
        Me.GenerateNewIDButton.Location = New System.Drawing.Point(8, 175)
        Me.GenerateNewIDButton.Name = "GenerateNewIDButton"
        Me.GenerateNewIDButton.Size = New System.Drawing.Size(198, 39)
        Me.GenerateNewIDButton.TabIndex = 0
        Me.GenerateNewIDButton.Text = "Générer nouvel ID"
        Me.GenerateNewIDButton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(8, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(198, 127)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'newRandomIDBox
        '
        Me.newRandomIDBox.AllowDrop = True
        Me.newRandomIDBox.AsciiOnly = True
        Me.newRandomIDBox.Location = New System.Drawing.Point(60, 149)
        Me.newRandomIDBox.Mask = "9999999999"
        Me.newRandomIDBox.Name = "newRandomIDBox"
        Me.newRandomIDBox.Size = New System.Drawing.Size(100, 20)
        Me.newRandomIDBox.TabIndex = 1
        Me.newRandomIDBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Barcode1)
        Me.GroupBox1.Controls.Add(Me.newRandomIDBox)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.GenerateNewIDButton)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(216, 226)
        Me.GroupBox1.TabIndex = 101
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Simple"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PictureBox2)
        Me.GroupBox2.Controls.Add(Me.PreviewButton)
        Me.GroupBox2.Controls.Add(Me.GenerateMultiIDButton)
        Me.GroupBox2.Controls.Add(Me.PrintButton)
        Me.GroupBox2.Controls.Add(Me.IDListBox)
        Me.GroupBox2.Location = New System.Drawing.Point(234, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(267, 226)
        Me.GroupBox2.TabIndex = 102
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Multiple"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(113, 19)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(133, 51)
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'PreviewButton
        '
        Me.PreviewButton.Enabled = False
        Me.PreviewButton.Location = New System.Drawing.Point(97, 120)
        Me.PreviewButton.Name = "PreviewButton"
        Me.PreviewButton.Size = New System.Drawing.Size(165, 23)
        Me.PreviewButton.TabIndex = 4
        Me.PreviewButton.Text = "Visualiser"
        Me.PreviewButton.UseVisualStyleBackColor = True
        '
        'GenerateMultiIDButton
        '
        Me.GenerateMultiIDButton.Location = New System.Drawing.Point(97, 76)
        Me.GenerateMultiIDButton.Name = "GenerateMultiIDButton"
        Me.GenerateMultiIDButton.Size = New System.Drawing.Size(165, 38)
        Me.GenerateMultiIDButton.TabIndex = 3
        Me.GenerateMultiIDButton.Text = "Générer des IDs"
        Me.GenerateMultiIDButton.UseVisualStyleBackColor = True
        '
        'PrintButton
        '
        Me.PrintButton.Enabled = False
        Me.PrintButton.Location = New System.Drawing.Point(97, 149)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(165, 61)
        Me.PrintButton.TabIndex = 2
        Me.PrintButton.Text = "Imprimer"
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'IDListBox
        '
        Me.IDListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.IDListBox.FormattingEnabled = True
        Me.IDListBox.Items.AddRange(New Object() {"0123456789"})
        Me.IDListBox.Location = New System.Drawing.Point(6, 16)
        Me.IDListBox.Name = "IDListBox"
        Me.IDListBox.ScrollAlwaysVisible = True
        Me.IDListBox.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.IDListBox.Size = New System.Drawing.Size(85, 197)
        Me.IDListBox.TabIndex = 0
        '
        'PrintDocument1
        '
        Me.PrintDocument1.DocumentName = "NewIDTemplate"
        '
        'PrintDialog1
        '
        Me.PrintDialog1.AllowPrintToFile = False
        Me.PrintDialog1.Document = Me.PrintDocument1
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.ShowIcon = False
        Me.PrintPreviewDialog1.Visible = False
        '
        'IDGenerator
        '
        Me.AcceptButton = Me.GenerateNewIDButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(514, 243)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(530, 282)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(530, 282)
        Me.Name = "IDGenerator"
        Me.ShowIcon = False
        Me.Text = "Générer de nouveaux IDs"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Barcode1 As Barcode
    Friend WithEvents GenerateNewIDButton As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents newRandomIDBox As MaskedTextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents IDListBox As ListBox
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintButton As Button
    Friend WithEvents GenerateMultiIDButton As Button
    Friend WithEvents PreviewButton As Button
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PictureBox2 As PictureBox
End Class
