Public Class AddMachine
    Public Shared newID As Integer

    Private Sub AddMachine_2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim addMachine_IdForm As AddMachine_ID
        addMachine_IdForm = New AddMachine_ID()
        addMachine_IdForm.Show()
        addMachine_IdForm = Nothing
    End Sub
End Class