Imports System.IO

Public Class Logger
    'DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")

    Dim logFileName As String = "logs\" & DateTime.Now.ToString("yyyy-MM-dd") & ".txt"

    Public Sub Load()
        If Not My.Computer.FileSystem.DirectoryExists("logs") Then My.Computer.FileSystem.CreateDirectory("logs")
        If Not My.Computer.FileSystem.FileExists(logFileName) Then File.WriteAllLines(logFileName, {"LOG FILE - " & DateTime.Now.ToString("dd/MM/yyyy"), "--------------------", "[INFO] Loading software"})
    End Sub

    Public Sub Info(str As String)
        Dim objWriter As New StreamWriter(logFileName, True)
        Try
            objWriter.WriteLineAsync("[" & DateTime.Now.ToString("HH:mm:ss") & "][INFO] " & str)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        objWriter.Close()
    End Sub

    Public Sub Warn(str As String)
        Dim objWriter As New StreamWriter(logFileName, True)
        Try
            objWriter.WriteLineAsync("[" & DateTime.Now.ToString("HH:mm:ss") & "][WARN] " & str)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        objWriter.Close()
    End Sub

    Public Sub Critical(str As String)
        Dim objWriter As New StreamWriter(logFileName, True)
        Try
            objWriter.WriteLineAsync("[" & DateTime.Now.ToString("HH:mm:ss") & "][CRITICAL] " & str)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        objWriter.Close()
    End Sub
End Class
