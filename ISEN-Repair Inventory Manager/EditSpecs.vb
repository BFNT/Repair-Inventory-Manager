Imports System.Data.SQLite

Public Class EditSpecs
    Public Sub New(id As String, name As String, stat As String, givedBy As String, serial As Boolean, details As String, emprunt As Boolean, empruntBy As String,
                   HW As Boolean, OS As Boolean, DRV As Boolean, ACT As Boolean, SFT As Boolean, procArch As String, ram As String, typeOS As String)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        IDBox.Text = id
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

    Private Function BooleanToNumeric(entry As Boolean) As String
        If entry Then Return "1"
        Return "0"
    End Function

    Private Sub SaveEditButton_Click(sender As Object, e As EventArgs) Handles SaveEditButton.Click
        If MsgBox("Enregistrer les données ?", 292, "Enregistrer") = 7 Then Exit Sub

        Try
            Main.StatusLabel.Text = "Modification d'un ordinateur de la base de données..."
            Using con As New SQLiteConnection("URI=file:db.sqlite")
                con.Open()
                Dim cmd As New SQLiteCommand(con)
                cmd.CommandText = "UPDATE `computers_desc` SET `giveTo`='" & EmprunterName.Text & "', `gived`=" & BooleanToNumeric(EmpruntCheckBox.Checked) & " WHERE id='" & IDBox.Text & "';"
                If cmd.ExecuteNonQuery() <> 1 Then MsgBox("Erreur inconnue au niveau de la base de données !", 16, "Defaillance générale !") : End
                cmd.CommandText = "UPDATE `computers_progress` SET `hardware_complete`=" & BooleanToNumeric(HWCheck.Checked) & ", `os_complete`=" & BooleanToNumeric(OSCheck.Checked) & ", `drivers_complete`=" & BooleanToNumeric(DrvCheck.Checked) & ", `activate_complete`=" & BooleanToNumeric(ActivateCheck.Checked) & ", `soft_complete`=" & BooleanToNumeric(SoftCheck.Checked) & ", `arch`=" & (ProcArchCmbBox.SelectedIndex + 1) & ", `ram`=" & (RAMCmbBox.SelectedIndex + 1) & ", `os`=" & (OSCmbBox.SelectedIndex + 1) & " WHERE id='" & IDBox.Text & "';"
                If cmd.ExecuteNonQuery() <> 1 Then MsgBox("Erreur inconnue au niveau de la base de données !", 16, "Defaillance générale !") : End
                con.Close()
            End Using
            Main.StatusLabel.Text = "Ordinateur enregistré avec succès !"
            Main.log.Info("Edited computer " & IDBox.Text)
        Catch ex As Exception
            Main.StatusLabel.Text = "Une erreur avec la base SQLite s'est produite !"
            MsgBox(ex.Message)
        End Try
        Me.Close()
    End Sub
End Class