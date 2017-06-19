Public Class AddMachine_ID
    Private Sub AddMachine_ID_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NextButton.Enabled = False
        newIDBox.Focus()
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles AddMachine_ID_CancelButton.Click
        Me.Close()
    End Sub

    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        If Not Main.CheckIDAlreadyUsed(newIDBox.Text) Then
            AddMachine.newID = newIDBox.Text
            Me.Close()
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

    Private Sub RandomIDButton_Click(sender As Object, e As EventArgs) Handles RandomIDButton.Click
        newIDBox.Text = Main.GenerateRandomID()
    End Sub

    Private Sub newIDBox_KeyDown(sender As Object, e As KeyEventArgs) Handles newIDBox.KeyDown
        newIDBox.Text = newIDBox.Text & Main.ScannerInterpreterFRLayout(e)
    End Sub
End Class