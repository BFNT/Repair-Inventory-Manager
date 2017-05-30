Imports System.Data.SQLite
Public Class Main
    Dim manualID_selected As Boolean = False

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckIfFirstRun()
        ListAllInv()

        If HWCheck.Checked And OSCheck.Checked And DrvCheck.Checked And ActivateCheck.Checked Then SoftCheck.Enabled = True Else SoftCheck.Enabled = False
        If HWCheck.Checked And OSCheck.Checked And DrvCheck.Checked Then
            ActivateCheck.Enabled = True
            OS.Enabled = True
        Else
            ActivateCheck.Enabled = False
            OS.Enabled = False
        End If
        If HWCheck.Checked And OSCheck.Checked Then DrvCheck.Enabled = True Else DrvCheck.Enabled = False
        If HWCheck.Checked Then OSCheck.Enabled = True Else OSCheck.Enabled = False
    End Sub

    Private Sub CheckIfFirstRun()
        If Not My.Computer.FileSystem.FileExists("db.sqlite") Then
            If MsgBox("La base de données SQLite est introuvable ou inaccesible, souhaitez-vous la régénérer ?", 4161, "Base SQLite absente ou inacessible") = 1 Then
                RegenerateDB()
            Else
                End
            End If
        End If
    End Sub

    Private Sub RegenerateDB()
        Dim genesis_seq As String = "
            CREATE TABLE `computers_desc` (
	        `id`	TEXT NOT NULL DEFAULT 0000000000 UNIQUE,
	        `name`	TEXT NOT NULL DEFAULT 'ComputerOfDoom',
	        `etat`	INTEGER NOT NULL DEFAULT 0,
        	`serial`	NUMERIC NOT NULL DEFAULT 0,
	        `comms`	TEXT NOT NULL DEFAULT 'N/A',
	        `gived`	INTEGER NOT NULL DEFAULT 0,
	        `giveTo`	TEXT NOT NULL DEFAULT 'N/A',
	        `getBy`	NUMERIC NOT NULL DEFAULT 'ISEN'
        );
            CREATE TABLE `computers_progress` (
	        `id`	TEXT NOT NULL DEFAULT 0000000000 UNIQUE,
	        `hardware_complete`	NUMERIC NOT NULL DEFAULT 0,
	        `os_complete`	NUMERIC NOT NULL DEFAULT 0,
	        `drivers_complete`	NUMERIC NOT NULL DEFAULT 0,
	        `activate_complete`	NUMERIC NOT NULL DEFAULT 0,
	        `soft_complete`	NUMERIC NOT NULL DEFAULT 0,
	        `arch`	INTEGER NOT NULL DEFAULT 1,
	        `ram`	TEXT NOT NULL DEFAULT '1G',
	        `os`	INTEGER NOT NULL DEFAULT 1
        );
            CREATE TABLE `credits` (
	        `pseudo`	TEXT DEFAULT 'JackCarterSmith' UNIQUE,
	        `contact`	TEXT DEFAULT 'j@bfnt.io' UNIQUE,
        	`commentaire`	TEXT DEFAULT 'Vous m avez trouvé !' UNIQUE
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

    Private Sub ListAllInv()
        Dim dtr As SQLiteDataReader

        InvList.ValueMember = "Equippements"
        InvList.DisplayMember = "Nom"
        Try
            StatusLabel.Text = "Récupération des données depuis la base SQLite..."
            Using con As New SQLiteConnection("URI=file:db.sqlite")
                con.Open()
                Using cmd As New SQLiteCommand(con)
                    cmd.CommandText = "SELECT name FROM computers_desc;"
                    dtr = cmd.ExecuteReader()
                    While dtr.Read()
                        InvList.Items.Add(dtr.GetString(0))
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
        Dim dtr As SQLiteDataReader
        Dim entriesRow As DataRow = Nothing

        Try
            StatusLabel.Text = "Récupération des données depuis la base SQLite..."
            Using con As New SQLiteConnection("URI=file:db.sqlite")
                con.Open()
                Using cmd As New SQLiteCommand(con)
                    cmd.CommandText = "SELECT * FROM computers_desc WHERE _rowid_=" & InvList.SelectedIndex + 1 & ";"
                    dtr = cmd.ExecuteReader()
                    While dtr.Read()
                        IDBox.Text = dtr.GetString(0)
                        NameBox.Text = dtr.GetString(1)
                        InvSearchBar.Text = dtr.GetString(1)
                        If dtr.GetInt32(2) = 0 Then
                            EtatBox.Text = "R.I.P"
                        ElseIf dtr.GetInt32(2) = 1 Then
                            EtatBox.Text = "Peu faire l'affaire"
                        ElseIf dtr.GetInt32(2) = 2 Then
                            EtatBox.Text = "En état"
                        ElseIf dtr.GetInt32(2) = 3 Then
                            EtatBox.Text = "Neuf"
                        End If
                        If dtr.GetInt32(3) = 1 Then SerieCheckBox.Checked = True
                        DetailsBox.Text = dtr.GetString(4)
                        If dtr.GetInt32(5) = 1 Then EmpruntCheckBox.Checked = True
                        EmprunterName.Text = dtr.GetString(6)
                        GivenByBox.Text = dtr.GetString(7)
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

    Private Sub IDBox_Click(sender As Object, e As EventArgs)
        IDBox.Text = ""
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
        addMachineForm.Show()
        addMachineForm = Nothing
    End Sub
End Class
