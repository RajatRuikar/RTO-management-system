Imports System.Data.OleDb
Public Class Locsys

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.Hide()
        login.Show()

    End Sub

    Private Sub Locsys_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Label2.Text = login.xyz
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim con As OleDbConnection
        Dim cmd As OleDbCommand
        Dim dr As OleDbDataReader
        Dim X As String

        con = New OleDbConnection("Provider= Microsoft.ACE.OLEDB.12.0; Data Source = D:\Rajat\RTO\DB\DB.accdb")
        con.Open()
        X = Label2.Text
        cmd = New OleDbCommand("select * from login where uname = '" & X & "'", con)
        dr = cmd.ExecuteReader
        If dr.Read() Then
            If TextBox1.Text = dr(4) Then
                Me.Hide()
                mainmenu.Enabled = True
            Else
                MsgBox("Worng Password")

            End If
        Else

        End If

        con.Close()
        dr.Close()
    End Sub
End Class