Imports System.Data.SQLite
Imports System.Text

Public Class Main
    Public Declare Sub Sleep Lib "kernel32" (ByVal dwMilliseconds As Long)

    Dim manualID_selected As Boolean = False
    Dim idList As New ArrayList
    Public log As New Logger

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        log.Load()
        CheckIfFirstRun()
        ListAllInv()
    End Sub

    ''' <summary>
    ''' Function to check if app is running for the first time
    ''' </summary>
    Private Sub CheckIfFirstRun()
        log.Info("Check and load of database")
        If Not My.Computer.FileSystem.FileExists("db.sqlite") Then
            If MsgBox("La base de données SQLite est introuvable ou inaccessible, souhaitez-vous la régénérer ?", 4161, "Base SQLite absente ou inaccessible") = 1 Then
                RegenerateDB()
            Else
                End
            End If
        End If
    End Sub

    ''' <summary>
    ''' Check if an ID is already used in the SQLite DB
    ''' </summary>
    ''' <param name="idToCheck">ID to check</param>
    ''' <returns>True = ID already used</returns>
    Public Function CheckIDAlreadyUsed(idToCheck As String) As Boolean
        Dim dtr As SQLiteDataReader

        Try
            Using con As New SQLiteConnection("URI=file:db.sqlite")
                con.Open()
                Using cmd As New SQLiteCommand(con)
                    cmd.CommandText = "SELECT * FROM computers_desc WHERE id=" & idToCheck & ";"
                    dtr = cmd.ExecuteReader()
                    While dtr.Read()
                        Return True
                    End While
                    Return False
                End Using
                con.Close()
            End Using

        Catch ex As Exception
            StatusLabel.Text = "Une erreur avec la base SQLite s'est produite !"
            MsgBox(ex.Message)
        End Try

        Return True
    End Function

    ''' <summary>
    ''' ID Generator with 10 digits from 0 to 9 returned with String
    ''' </summary>
    ''' <returns>String correspond to ID generate</returns>
    Public Function GenerateRandomID() As String
        Dim s As String = "0123456789"
        Dim r As New Random
        Dim sb As New StringBuilder

        sb.Clear()
        For i As Integer = 1 To 10
            Dim idx As Integer = r.Next(0, 9)
            sb.Append(s.Substring(idx, 1))
        Next

        Return sb.ToString()
    End Function

    ''' <summary>
    ''' Convert US key from barcode scanner to FR key
    ''' </summary>
    ''' <param name="scanKey">Event of keyDown</param>
    ''' <returns>Converted string key</returns>
    Public Function ScannerInterpreterFRLayout(scanKey As KeyEventArgs) As String
        Select Case scanKey.KeyCode.ToString()
            Case "D0"
                Return "0"
            Case "D1"
                Return "1"
            Case "D2"
                Return "2"
            Case "D3"
                Return "3"
            Case "D4"
                Return "4"
            Case "D5"
                Return "5"
            Case "D6"
                Return "6"
            Case "D7"
                Return "7"
            Case "D8"
                Return "8"
            Case "D9"
                Return "9"
        End Select
        Return Nothing
    End Function

    ''' <summary>
    ''' Construct the basic structure of SQLite DB
    ''' </summary>
    Private Sub RegenerateDB()
        log.Warn("Reconstruct database...")
        Dim genesis_seq As String = "
            CREATE TABLE `computers_desc` (
	        `id`	TEXT NOT NULL DEFAULT 0000000000 UNIQUE,
	        `name`	TEXT NOT NULL DEFAULT 'ComputerOfDoom',
	        `etat`	INTEGER NOT NULL DEFAULT 0,
        	`serial`	NUMERIC NOT NULL DEFAULT 0,
	        `comms`	TEXT NOT NULL DEFAULT 'N/A',
	        `gived`	NUMERIC NOT NULL DEFAULT 0,
	        `giveTo`	TEXT NOT NULL DEFAULT 'N/A',
	        `getBy`	TEXT NOT NULL DEFAULT 'ISEN'
        );
            CREATE TABLE `computers_progress` (
	        `id`	TEXT NOT NULL DEFAULT 0000000000 UNIQUE,
	        `hardware_complete`	NUMERIC NOT NULL DEFAULT 0,
	        `os_complete`	NUMERIC NOT NULL DEFAULT 0,
	        `drivers_complete`	NUMERIC NOT NULL DEFAULT 0,
	        `activate_complete`	NUMERIC NOT NULL DEFAULT 0,
	        `soft_complete`	NUMERIC NOT NULL DEFAULT 0,
	        `arch`	INTEGER NOT NULL DEFAULT 1,
	        `ram`	INTEGER NOT NULL DEFAULT 1,
	        `os`	INTEGER NOT NULL DEFAULT 1
        );
            CREATE TABLE `credits` (
	        `pseudo`	TEXT DEFAULT 'JackCarterSmith' UNIQUE,
	        `contact`	TEXT DEFAULT 'j@bfnt.io' UNIQUE,
        	`commentaire`	TEXT DEFAULT 'Vous avez trouvé un easter egg, félicitations !' UNIQUE
        );"

        Try
            StatusLabel.Text = "Reconstructions de la base SQLite..."
            Using con As New SQLiteConnection("URI=file:db.sqlite")
                con.Open()
                Dim cmd As New SQLiteCommand(genesis_seq, con)
                cmd.ExecuteNonQuery()
                con.Close()
            End Using
            StatusLabel.Text = "La base SQLite a été reconstruite avec succès !"
        Catch ex As Exception
            StatusLabel.Text = "Une erreur avec la base SQLite s'est produite !"
            MsgBox(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Liste all object from DB into list dialog
    ''' </summary>
    Public Sub ListAllInv()
        idList.Clear()
        Dim dtr As SQLiteDataReader

        InvList.Items.Clear()
        InvList.ValueMember = "Equippements"
        InvList.DisplayMember = "Nom"
        Try
            StatusLabel.Text = "Récupération des données depuis la base SQLite..."
            Using con As New SQLiteConnection("URI=file:db.sqlite")
                con.Open()
                Using cmd As New SQLiteCommand(con)
                    cmd.CommandText = "SELECT id,name FROM computers_desc;"
                    dtr = cmd.ExecuteReader()
                    While dtr.Read()
                        idList.Add(dtr.GetString(0))
                        InvList.Items.Add(dtr.GetString(1))
                    End While
                End Using
                con.Close()
            End Using

            StatusLabel.Text = "Récupération avec succés de la base SQLite."
        Catch ex As Exception
            StatusLabel.Text = "Une erreur avec la base SQLite s'est produite !"
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub InvList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles InvList.SelectedIndexChanged
        IDBox.Text = idList(InvList.SelectedIndex)
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AboutToolMenuItem.Click
        Dim aboutForm As About
        aboutForm = New About()
        aboutForm.Show()
        aboutForm = Nothing
    End Sub

    Private Sub AddComputerToolMenuItem_Click(sender As Object, e As EventArgs) Handles AddComputerToolMenuItem.Click
        Dim addMachineForm As AddMachine
        addMachineForm = New AddMachine()
        addMachineForm.ShowDialog()
        addMachineForm = Nothing
    End Sub

    Private Sub IDBox_TextChanged(sender As Object, e As EventArgs) Handles IDBox.TextChanged
        If IDBox.Text = "666" Then
            manualID_selected = True
            NameBox.Text = "DELL Fuel Burning Serial - Complete Collection"
            EtatBox.Text = "Détonateur armé"
            SerieCheckBox.Checked = True
            DetailsBox.Text = "DEADDEADDEADDEADDEADDEADDEADDEADDEADDEADDEADDEADDEADDEADDEADDEADDEADDEADDEADDEADDEADDEADDEADDEADDEADDEADDEADDEADDEADDEADDEADDEADDEADDEADDEADDEADDEADDEADDEADDEADDEADDEADDEADDEADDEADDEADDEADDEADDEADDEADDEADDEADDEADDEADDEADDEADDEADDEADDEADDEADDEADDEADDEADDEADDEADDEADDEADDEADDEADDEADDEADDEAD"
            EmpruntCheckBox.Checked = False
            EmprunterName.Text = "Fuyez pauvre fou !"
            GivenByBox.Text = "Enfer"
            StatusLabel.Text = "Vous avez trouvé un easter egg, félicitations !"
        End If
        If IDBox.Text.Length() = 10 Then
            Dim dtr As SQLiteDataReader

            Try
                Using con As New SQLiteConnection("URI=file:db.sqlite")
                    con.Open()
                    Using cmd As New SQLiteCommand(con)
                        cmd.CommandText = "SELECT * FROM computers_desc WHERE id='" & IDBox.Text & "';"
                        dtr = cmd.ExecuteReader()
                        Dim id_found As Boolean = False
                        While dtr.Read()
                            id_found = True
                            manualID_selected = True
                            TrashButton.Enabled = True
                            EditButton.Enabled = True
                            StatusLabel.Text = "ID trouvé !"
                            NameBox.Text = dtr.GetString(1)
                            If dtr.GetInt32(2) = 0 Then
                                EtatBox.Text = "R.I.P"
                            ElseIf dtr.GetInt32(2) = 1 Then
                                EtatBox.Text = "Peu faire l'affaire"
                            ElseIf dtr.GetInt32(2) = 2 Then
                                EtatBox.Text = "En état"
                            ElseIf dtr.GetInt32(2) = 3 Then
                                EtatBox.Text = "Neuf"
                            End If
                            SerieCheckBox.Checked = dtr.GetBoolean(3)
                            DetailsBox.Text = Replace(dtr.GetString(4), "_*_", "'")
                            EmpruntCheckBox.Checked = dtr.GetBoolean(5)
                            EmprunterName.Text = dtr.GetString(6)
                            GivenByBox.Text = dtr.GetString(7)
                            RequestComputerProgress(IDBox.Text)
                        End While
                        If Not id_found Then StatusLabel.Text = "ID introuvable !"
                    End Using
                    con.Close()
                End Using
            Catch ex As Exception
                StatusLabel.Text = "Une erreur avec la base SQLite s'est produite !"
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub IDBox_MouseClick(sender As Object, e As MouseEventArgs) Handles IDBox.MouseClick
        If manualID_selected Then IDBox.Clear() : manualID_selected = False : TrashButton.Enabled = False : EditButton.Enabled = False
    End Sub

    Private Sub RequestComputerProgress(machineID As String)
        Dim dtr As SQLiteDataReader

        Try
            Using con As New SQLiteConnection("URI=file:db.sqlite")
                con.Open()
                Using cmd As New SQLiteCommand(con)
                    cmd.CommandText = "SELECT * FROM computers_progress WHERE id='" & machineID & "';"
                    dtr = cmd.ExecuteReader()
                    While dtr.Read()
                        HWCheck.Checked = dtr.GetBoolean(1)
                        OSCheck.Checked = dtr.GetBoolean(2)
                        DrvCheck.Checked = dtr.GetBoolean(3)
                        ActivateCheck.Checked = dtr.GetBoolean(4)
                        SoftCheck.Checked = dtr.GetBoolean(5)
                        Dim advIntPerc As Integer = 0
                        For index As Integer = 1 To 5
                            If dtr.GetBoolean(index) Then advIntPerc = advIntPerc + 1
                        Next
                        ComputerRepairGlobalProgress.Value = advIntPerc * 100 / 5
                        Select Case dtr.GetInt32(6)
                            Case 1
                                ArchBox.Text = "32bits"
                            Case 2
                                ArchBox.Text = "64bits"
                        End Select
                        Select Case dtr.GetInt32(7)
                            Case 1
                                MemBox.Text = "<1G"
                            Case 2
                                MemBox.Text = "1G"
                            Case 3
                                MemBox.Text = "2G"
                            Case 4
                                MemBox.Text = "3G"
                            Case 5
                                MemBox.Text = "4G"
                            Case 6
                                MemBox.Text = ">4G"
                        End Select
                        Select Case dtr.GetInt32(8)
                            Case 1
                                OSBox.Text = "Win XP PRO SP3"
                            Case 2
                                OSBox.Text = "WIN 7 SP1"
                            Case 3
                                OSBox.Text = "WIN 10"
                            Case 4
                                OSBox.Text = "UNIX"
                            Case 5
                                OSBox.Text = "Inconnue"
                        End Select
                    End While
                End Using
                con.Close()
            End Using

            If HWCheck.Checked And OSCheck.Checked And DrvCheck.Checked And SoftCheck.Checked And ActivateCheck.Checked Then SendOutButton.Enabled = True Else SendOutButton.Enabled = False
        Catch ex As Exception
            StatusLabel.Text = "Une erreur avec la base SQLite s'est produite !"
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TrashButton_Click(sender As Object, e As EventArgs) Handles TrashButton.Click
        If MsgBox("ATTENTION ! Voulez vous vraiment supprimer cette ordinateur de la base de données ?", 292, "Trash") = 7 Then Exit Sub

        Try
            StatusLabel.Text = "Supression d'un ordinateur de la base de données..."
            Using con As New SQLiteConnection("URI=file:db.sqlite")
                con.Open()
                Dim cmd As New SQLiteCommand(con)
                cmd.CommandText = "DELETE FROM computers_desc WHERE id='" & IDBox.Text & "';"
                If cmd.ExecuteNonQuery() <> 1 Then MsgBox("Erreur inconnue au niveau de la base de données !", 16, "Defaillance générale !") : End
                cmd.CommandText = "DELETE FROM computers_progress WHERE id='" & IDBox.Text & "';"
                If cmd.ExecuteNonQuery() <> 1 Then MsgBox("Erreur inconnue au niveau de la base de données !", 16, "Defaillance générale !") : End
                con.Close()
            End Using
            StatusLabel.Text = "Ordinateur supprimé avec succès !"
            ListAllInv()
        Catch ex As Exception
            StatusLabel.Text = "Une erreur avec la base SQLite s'est produite !"
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub IDBox_KeyDown(sender As Object, e As KeyEventArgs) Handles IDBox.KeyDown
        If IDBox.Text.Length() = 10 And Not e.KeyCode.ToString() = "Return" Then IDBox.Text = ""
        IDBox.Text = IDBox.Text & ScannerInterpreterFRLayout(e)
    End Sub

    Private Sub GénérerDesIDsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GénérerDesIDsToolStripMenuItem.Click
        Dim idGeneratorForm As IDGenerator
        idGeneratorForm = New IDGenerator()
        idGeneratorForm.Show()
        idGeneratorForm = Nothing
    End Sub

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        Dim editForm As EditSpecs
        editForm = New EditSpecs(IDBox.Text, NameBox.Text, EtatBox.Text, GivenByBox.Text, SerieCheckBox.Checked, DetailsBox.Text, EmpruntCheckBox.Checked, EmprunterName.Text, HWCheck.Checked, OSCheck.Checked, DrvCheck.Checked, ActivateCheck.Checked, SoftCheck.Checked, ArchBox.Text, MemBox.Text, OSBox.Text)
        editForm.ShowDialog()
        editForm = Nothing
        Dim tempStor As String = IDBox.Text
        IDBox.Text = Nothing
        IDBox.Text = tempStor
    End Sub
End Class
