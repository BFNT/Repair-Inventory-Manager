Public Class IDGenerator
    Private Sub IDGenerator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        GenerateNewIDBarcode()
    End Sub

    Private Sub GenerateNewIDBarcode()
generate:
        'Génération d'un nouvel ID
        Dim newIDRandom As String = Main.GenerateRandomID()
        'Vérification si pas déjà existant
        If Not Main.CheckIDAlreadyUsed(newIDRandom) Then
            newRandomIDBox.Text = newIDRandom
            Barcode1.DataToEncode = newIDRandom
        Else
            GoTo generate
        End If
    End Sub

    Private Sub newRandomIDBox_TextChanged(sender As Object, e As EventArgs) Handles newRandomIDBox.TextChanged
        If newRandomIDBox.Text.Length() = 10 Then Barcode1.DataToEncode = newRandomIDBox.Text
    End Sub

    Private Sub newRandomIDBox_KeyDown(sender As Object, e As KeyEventArgs) Handles newRandomIDBox.KeyDown
        newRandomIDBox.Text = newRandomIDBox.Text & Main.ScannerInterpreterFRLayout(e)
    End Sub

    Private Sub GenerateNewIDButton_Click(sender As Object, e As EventArgs) Handles GenerateNewIDButton.Click
        GenerateNewIDBarcode()
    End Sub
End Class