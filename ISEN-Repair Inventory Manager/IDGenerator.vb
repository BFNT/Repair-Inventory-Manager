Imports System.Drawing.Printing
Imports System.Text

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

    Private Sub GenerateMultiIDButton_Click(sender As Object, e As EventArgs) Handles GenerateMultiIDButton.Click
        Dim s As String = "0123456789"
        Dim r As New Random
        Dim sb As New StringBuilder
        IDListBox.Items.Clear()

        For i As Integer = 1 To 32
            sb.Clear()
            For j As Integer = 1 To 10
                Dim idx As Integer = r.Next(0, 9)
                sb.Append(s.Substring(idx, 1))
            Next
            IDListBox.Items.Add(sb)
        Next
        PreviewButton.Enabled = True : PrintButton.Enabled = True
    End Sub

    Private Sub PreviewButton_Click(sender As Object, e As EventArgs) Handles PreviewButton.Click
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintButton_Click(sender As Object, e As EventArgs) Handles PrintButton.Click
        PrintDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage

    End Sub
End Class