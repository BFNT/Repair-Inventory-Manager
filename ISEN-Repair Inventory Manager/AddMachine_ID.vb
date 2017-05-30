Imports System.Data.SQLite

Public Class AddMachine_ID
    Private Sub AddMachine_ID_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NextButton.Enabled = False
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles AddMachine_ID_CancelButton.Click
        Me.Close()
    End Sub

    Private Function CheckIDAlreadyUsed(idToCheck As String) As Boolean
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
            Main.StatusLabel.Text = "Une erreur avec la base SQLite s'est produite !"
            MsgBox(ex.Message)
        End Try

        Return True
    End Function

    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        If Not CheckIDAlreadyUsed(newIDBox.Text) Then
            AddMachine.newID = newIDBox.Text

        Else
            MsgBox("ID déjà dans la base de données !", 48, "Entrée incorrect")
        End If
    End Sub

    Private Sub newIDBox_TextChanged(sender As Object, e As EventArgs) Handles newIDBox.TextChanged
        If newIDBox.Text.Length() = 10 Then
            NextButton.Enabled = True
        Else
            NextButton.Enabled = False
        End If
    End Sub
End Class