Imports System.Text

Public Class IDGenerator
    Private Sub IDGenerator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        GenerateNewIDBarcode()
    End Sub

    Private Sub GenerateNewIDBarcode()
        'Génération d'un nouvel ID
        Dim s As String = "0123456789"
        Dim r As New Random
        Dim sb As New StringBuilder
generate:
        sb.Clear()
        For i As Integer = 1 To 10
            Dim idx As Integer = r.Next(0, 9)
            sb.Append(s.Substring(idx, 1))
        Next

        'Vérification si pas déjà existant
        If Not Main.CheckIDAlreadyUsed(sb.ToString()) Then Barcode1.DataToEncode = sb.ToString() Else GoTo generate
    End Sub

    Private Sub GenerateNewIDButton_Click(sender As Object, e As EventArgs) Handles GenerateNewIDButton.Click
        GenerateNewIDBarcode()
    End Sub

    Private Sub CloseButtonNewID_Click(sender As Object, e As EventArgs) Handles CloseButtonNewID.Click
        Me.Close()
    End Sub
End Class