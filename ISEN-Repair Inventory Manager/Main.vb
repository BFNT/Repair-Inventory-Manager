Imports System.ComponentModel
Imports System.Data.SQLite
Public Class Main
    Private idSelected As Boolean = False

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListAllInv()

        If HWCheck.Checked And OSCheck.Checked And DrvCheck.Checked And ActivateCheck.Checked Then SoftCheck.Enabled = True Else SoftCheck.Enabled = False
        If HWCheck.Checked And OSCheck.Checked And DrvCheck.Checked Then
            ActivateCheck.Enabled = True
            OSChoice.Enabled = True
        Else
            ActivateCheck.Enabled = False
            OSChoice.Enabled = False
        End If
        If HWCheck.Checked And OSCheck.Checked Then DrvCheck.Enabled = True Else DrvCheck.Enabled = False
        If HWCheck.Checked Then OSCheck.Enabled = True Else OSCheck.Enabled = False
    End Sub

    Private Sub ListAllInv()
        StatusLabel.Text = "Récupération des données depuis la base SQLite..."
        Dim connectStr As String = "Data Source=Northwind.sqlite"
        Dim SQLiteCommand As String = "SELECT..."
        Dim dt As DataTable = Nothing
        Dim ds As New DataSet

        Try
            Using con As New SQLiteConnection(connectStr)
                Using cmd As New SQLiteCommand(SQLiteCommand, con)
                    con.Open()
                    Using da As New SQLiteDataAdapter(cmd)
                        da.Fill(ds)
                        dt = ds.Tables(0)
                    End Using
                End Using
            End Using

            InvList.ValueMember = "Equippement"
            InvList.DisplayMember = "ID"
            InvList.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub InvList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles InvList.SelectedIndexChanged
        Try
            DisplayInvList(InvList.SelectedValue)
        Catch ex As Exception

        End Try
    End Sub

    Public Sub DisplayInvList(entriesId As String)
        Dim connectStr As String = "Data Source=Northwind.sqlite"
        Dim SQLiteCommand As String = "SELECT * FROM Inventory WHERE EntriesID=" & entriesId
        Dim dt As DataTable = Nothing
        Dim ds As New DataSet
        Dim entriesRow As DataRow = Nothing

        Try
            Using con As New SQLiteConnection(connectStr)
                Using cmd As New SQLiteCommand(SQLiteCommand, con)
                    con.Open()
                    Using da As New SQLiteDataAdapter(cmd)
                        da.Fill(ds)
                        dt = ds.Tables(0)
                    End Using
                End Using
            End Using

            entriesRow = dt.Rows(0)

            If entriesRow IsNot Nothing Then
                IDBox.Text = entriesRow("entriesID")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub QuitterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitterToolStripMenuItem.Click
        End
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Me.Hide()
        Dim aboutForm As About
        aboutForm = New About()
        aboutForm.Show()
        aboutForm = Nothing
    End Sub

    Private Sub IDBox_Click(sender As Object, e As EventArgs) Handles IDBox.Click
        If idSelected Then IDBox.Text = ""
    End Sub

    Private Sub ImporterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImporterToolStripMenuItem.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub ExporterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExporterToolStripMenuItem.Click
        SaveFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As CancelEventArgs) Handles OpenFileDialog1.FileOk

    End Sub

    Private Sub SaveFileDialog1_FileOk(sender As Object, e As CancelEventArgs) Handles SaveFileDialog1.FileOk

    End Sub
End Class
