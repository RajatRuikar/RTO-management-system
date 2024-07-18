Imports System.Data.OleDb

Public Class Accdet
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        mainmenu.Show()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Accdet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim a As String
        Dim con As OleDbConnection
        Dim cmd As OleDbCommand
        Dim dr As OleDbDataReader

        con = New OleDbConnection("Provider= Microsoft.ACE.OLEDB.12.0; Data Source = D:\Rajat\RTO\DB\DB.accdb")
        con.Open()

        a = login.xyz
        cmd = New OleDbCommand("select * from login where uname='" & a & "'", con)
        dr = cmd.ExecuteReader

        If dr.Read Then
            TextBox1.Text = a
            TextBox2.Text = dr(1)
            TextBox3.Text = dr(2)
            TextBox4.Text = dr(3)
            TextBox5.Text = dr(5)
            TextBox6.Text = dr(6)
            TextBox7.Text = dr(7)
            TextBox8.Text = dr(8)
        End If

        dr.Close()
        con.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Dim a As String
        Dim con As OleDbConnection
        Dim cmd As OleDbCommand
        Dim dr As OleDbDataReader

        con = New OleDbConnection("Provider= Microsoft.ACE.OLEDB.12.0; Data Source = D:\Rajat\RTO\DB\DB.accdb")
        con.Open()

        a = Label2.Text = login.xyz

        cmd = New OleDbCommand("select * from login where uname='" & a & "'", con)
        dr = cmd.ExecuteReader

        If dr.Read Then
            TextBox2.Text = dr(2)
            TextBox3.Text = dr(3)
            TextBox4.Text = dr(4)
            TextBox5.Text = dr(6)
            TextBox6.Text = dr(7)
            TextBox7.Text = dr(8)
            TextBox8.Text = dr(9)
        End If

        dr.Close()
        con.Close()
    End Sub
End Class