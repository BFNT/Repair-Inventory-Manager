Public Class EditSpecs
    Public Sub New(id As String, name As String, stat As String, givedBy As String, serial As Boolean, details As String, emprunt As Boolean, empruntBy As String,
                   HW As Boolean, OS As Boolean, DRV As Boolean, ACT As Boolean, SFT As Boolean, procArch As String, ram As String, typeOS As String)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        NewIDBox.Text = id
        NameBox.Text = name
        EtatBox.Text = stat
        GivedByBox.Text = givedBy
        SerieCheckBox.Checked = serial
        DetailsBox.Text = details
        EmpruntCheckBox.Checked = emprunt
        EmprunterName.Text = empruntBy
        HWCheck.Checked = HW
        OSCheck.Checked = OS
        DrvCheck.Checked = DRV
        ActivateCheck.Checked = ACT
        SoftCheck.Checked = SFT
        Select Case procArch
            Case "32bits"
                ProcArchCmbBox.SelectedIndex = 0
            Case "64bits"
                ProcArchCmbBox.SelectedIndex = 1
        End Select
        Select Case ram
            Case "<1G"
                RAMCmbBox.SelectedIndex = 0
            Case "1G"
                RAMCmbBox.SelectedIndex = 1
            Case "2G"
                RAMCmbBox.SelectedIndex = 2
            Case "3G"
                RAMCmbBox.SelectedIndex = 3
            Case "4G"
                RAMCmbBox.SelectedIndex = 4
            Case ">4G"
                RAMCmbBox.SelectedIndex = 5
        End Select
        Select Case typeOS
            Case "Win XP PRO SP3"
                OSCmbBox.SelectedIndex = 0
            Case "WIN 7 SP1"
                OSCmbBox.SelectedIndex = 1
            Case "WIN 10"
                OSCmbBox.SelectedIndex = 2
            Case "UNIX"
                OSCmbBox.SelectedIndex = 3
            Case "Inconnue"
                OSCmbBox.SelectedIndex = 4
        End Select
    End Sub

    Private Sub SaveEditButton_Click(sender As Object, e As EventArgs) Handles SaveEditButton.Click

    End Sub
End Class