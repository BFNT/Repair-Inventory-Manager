Public Class AddMachine
    Public Shared newID As String

    Private Sub AddMachine_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim addMachine_IdForm As AddMachine_ID
        addMachine_IdForm = New AddMachine_ID()
        addMachine_IdForm.ShowDialog()
        addMachine_IdForm = Nothing

        NewIDBox.Text = newID
        NewNameBox.Focus()
    End Sub

    Private Sub AddCompCancelButton_Click(sender As Object, e As EventArgs) Handles AddCompCancelButton.Click
        Me.Close()
    End Sub
End Class