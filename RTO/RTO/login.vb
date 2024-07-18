Imports System.Data.OleDb



Public Class login

    Public Property xyz As String

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Integer
        Dim con As OleDbConnection
        Dim cmd As OleDbCommand
        Dim dr As OleDbDataReader
        a = 0
        con = New OleDbConnection("Provider= Microsoft.ACE.OLEDB.12.0; Data Source = D:\Rajat\RTO\DB\DB.accdb")
        con.Open()

        xyz = TextBox1.Text

        cmd = New OleDbCommand("select * from login", con)
        dr = cmd.ExecuteReader
        While (dr.Read())
            If TextBox1.Text = dr(0) And TextBox2.Text = dr(4) Then
                a = 1

                MsgBox("Login successfull..!")
                Me.Hide()
                mainmenu.Show()

                Exit While
            End If
        End While
        If a = 0 Then
            MsgBox("Invalid details...!")
        End If

        TextBox1.Text = ""
        TextBox2.Text = ""

        dr.Close()
        con.Close()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Forget.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()

    End Sub
End Class