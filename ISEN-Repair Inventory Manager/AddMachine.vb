Imports System.Data.SQLite

Public Class AddMachine
    Public Shared newID As String

    Private Sub AddMachine_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim addMachine_IdForm As AddMachine_ID
        addMachine_IdForm = New AddMachine_ID()
        addMachine_IdForm.ShowDialog()
        addMachine_IdForm = Nothing

        NewIDBox.Text = newID
        NewNameBox.Focus()
        NewEtatBox.SelectedIndex = 0
    End Sub

    Private Function CheckToNumeric(control As CheckBox) As String
        If control.Checked Then Return "1"
        Return "0"
    End Function

    Private Sub AddCompCancelButton_Click(sender As Object, e As EventArgs) Handles AddCompCancelButton.Click
        Me.Close()
    End Sub

    Private Sub AddComputerButton_Click(sender As Object, e As EventArgs) Handles AddComputerButton.Click
        If NewNameBox.Text = "" Then MsgBox("Vous ne pouvez pas laisser un nom vide !", 48, "Erreur de saisie") : Exit Sub
        If NewDetailsBox.Text = "" Then NewDetailsBox.Text = "N/A"
        If NewGivenByBox.Text = "" Then NewGivenByBox.Text = "N/A"

        Try
            Main.StatusLabel.Text = "Tentative d'ajout de l'ordinateur à la base de données..."
            Using con As New SQLiteConnection("URI=file:db.sqlite")
                con.Open()
                Dim cmd As New SQLiteCommand(con)
                cmd.CommandText = "INSERT INTO computers_desc VALUES ('" & NewIDBox.Text & "','" & NewNameBox.Text & "'," & NewEtatBox.SelectedIndex & "," & CheckToNumeric(NewSerieCheckBox) & ",'" & Replace(NewDetailsBox.Text, "'", "_*_") & "',0,'N/A','" & NewGivenByBox.Text & "');"
                If cmd.ExecuteNonQuery() <> 1 Then MsgBox("Erreur inconnue au niveau de la base de données !", 16, "Defaillance générale !") : End
                cmd.CommandText = "INSERT INTO computers_progress VALUES ('" & NewIDBox.Text & "',0,0,0,0,0,1,1,1);"
                If cmd.ExecuteNonQuery() <> 1 Then MsgBox("Erreur inconnue au niveau de la base de données !", 16, "Defaillance générale !") : End
                con.Close()
            End Using
            Main.log.Info("Computer " & NewIDBox.Text & " added")
            Main.StatusLabel.Text = "Ordinateur ajouté avec succés dans la base de données."
            Main.ListAllInv()
            Me.Close()
        Catch ex As Exception
            Main.StatusLabel.Text = "Une erreur avec la base SQLite s'est produite !"
            MsgBox(ex.Message)
        End Try
    End Sub
End Class