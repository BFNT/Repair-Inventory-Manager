Public Class AddMachine_ID
    Private Sub AddMachine_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles AddMachine_ID_CancelButton.Click
        Me.Close()
    End Sub

    Private Sub CheckIDAlreadyUsed(idToCheck As String)
        Main.RequestToSQLite("")
    End Sub

    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        If newIDBox.ValidateText And newIDBox.Text.Length() = 10 Then
            AddMachine.newID = newIDBox.Text

        Else
            MsgBox("Format d'ID incorrect, entrer uniquement 10 chiffres.", 48, "Entrée incorrect")
        End If
    End Sub
End Class