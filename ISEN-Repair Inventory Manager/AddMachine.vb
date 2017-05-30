Public Class AddMachine
    Public Shared newID As String

    Private Sub AddMachine_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'If HWCheck.Checked And OSCheck.Checked And DrvCheck.Checked And ActivateCheck.Checked Then SoftCheck.Enabled = True Else SoftCheck.Enabled = False
        'If HWCheck.Checked And OSCheck.Checked And DrvCheck.Checked Then
        'ActivateCheck.Enabled = True
        'OS.Enabled = True
        'Else
        'ActivateCheck.Enabled = False
        'OS.Enabled = False
        'End If
        'If HWCheck.Checked And OSCheck.Checked Then DrvCheck.Enabled = True Else DrvCheck.Enabled = False
        'If HWCheck.Checked Then OSCheck.Enabled = True Else OSCheck.Enabled = False

        Dim addMachine_IdForm As AddMachine_ID
        addMachine_IdForm = New AddMachine_ID()
        addMachine_IdForm.ShowDialog()
        addMachine_IdForm = Nothing
    End Sub
End Class