Imports System.Data.OleDb

Public Class Forget
    Public Sub check(ByVal ra As Integer)
        If ra = 0 Then
            Button1.Enabled = True
        Else
            Button1.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        Dim a, b As Integer
        Dim con As OleDbConnection
        Dim cmd As OleDbCommand
        Dim dr As OleDbDataReader

        TextBox1.Text = TextBox1.Text.Trim
        TextBox2.Text = TextBox2.Text.Trim
        TextBox3.Text = TextBox3.Text.Trim
        TextBox4.Text = TextBox4.Text.Trim

        a = 0
        con = New OleDbConnection("Provider= Microsoft.ACE.OLEDB.12.0; Data Source = D:\Rajat\RTO\DB\DB.accdb")
        con.Open()

        cmd = New OleDbCommand("select * from login", con)
        dr = cmd.ExecuteReader

        While (dr.Read())
            If TextBox1.Text = dr(0) And TextBox2.Text = dr(3) Then
                a = 1
                GoTo check
            End If
        End While
check:
        If TextBox3.Text = TextBox4.Text And a = 1 Then
            cmd = New OleDbCommand("update login set Pass ='" & TextBox3.Text & "' where uname='" & TextBox1.Text & " '  ", con)

            b = cmd.ExecuteNonQuery()
        ElseIf a = 0 Then
            Label5.Visible = True
            Label5.Text = "Invalid Username or Mobile number"

        Else
            Label5.Visible = True
            Label5.Text = "Not match"
        End If

        If b > 0 Then
            MsgBox("Password is Updated Successfully")
            Me.Hide()
            login.Show()
        End If
        dr.Close()
        con.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        login.Show()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim ni As Integer
        ni = 0
        If Trim(TextBox1.Text) = "" Then
            Label6.Text = "Please Enter Username"
            ni = 1
            check(ni)
        Else
            ni = 0
            check(ni)
            Label6.Text = ""
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Dim ni As Integer
        ni = 0
        If Trim(TextBox2.Text) = "" Then
            Label7.Text = "Please Enter mobile Number"
            ni = 1
            check(ni)
        ElseIf TextBox2.TextLength <> 10 Then
            Label7.Text = "Invalid Mobile Number"
            ni = 1
            check(ni)
        Else
            ni = 0
            check(ni)
            Label7.Text = ""
        End If

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        Dim ni As Integer
        ni = 0
        If Trim(TextBox3.Text) = "" Then
            Label8.Text = "Please Enter New Password"
            ni = 1
            check(ni)
        Else
            ni = 0
            check(ni)
            Label8.Text = ""
        End If
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        Dim ni As Integer
        ni = 0
        If Trim(TextBox4.Text) = "" Then
            Label9.Text = "Please Re-Enter Password"
            ni = 1
            check(ni)
        Else
            ni = 0
            check(ni)
            Label9.Text = ""
        End If
    End Sub

    Private Sub TextBox2_Click(sender As Object, e As EventArgs) Handles TextBox2.Click
        Dim ni As Integer
        ni = 0
        If Trim(TextBox2.Text) = "" Then
            Label7.Text = "Please Enter mobile Number"
            ni = 1
            check(ni)
        ElseIf TextBox2.TextLength <> 10 Then
            Label7.Text = "Invalid Mobile Number"
            ni = 1
            check(ni)
        Else
            ni = 0
            check(ni)
            Label7.Text = ""
        End If

    End Sub

    Private Sub TextBox4_Click(sender As Object, e As EventArgs) Handles TextBox4.Click
        Dim ni As Integer
        ni = 0
        If Trim(TextBox4.Text) = "" Then
            Label9.Text = "Please Re-Enter Password"
            ni = 1
            check(ni)
        Else
            ni = 0
            check(ni)
            Label9.Text = ""
        End If
    End Sub

    Private Sub TextBox3_Click(sender As Object, e As EventArgs) Handles TextBox3.Click
        Dim ni As Integer
        ni = 0
        If Trim(TextBox3.Text) = "" Then
            Label8.Text = "Please Enter New Password"
            ni = 1
            check(ni)
        Else
            ni = 0
            check(ni)
            Label8.Text = ""
        End If
    End Sub

    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.Click
        Dim ni As Integer
        ni = 0
        If Trim(TextBox1.Text) = "" Then
            Label6.Text = "Please Enter Username"
            ni = 1
            check(ni)
        Else
            ni = 0
            check(ni)
            Label6.Text = ""
        End If
    End Sub

    Private Sub Forget_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
