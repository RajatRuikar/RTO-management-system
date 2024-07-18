Imports System.Data.OleDb
Public Class Newuser

    Public Sub check(ByVal ra As Integer)
        If ra = 0 Then
            Button1.Enabled = True
        Else
            Button1.Enabled = False
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As OleDbConnection
        Dim cmd As OleDbCommand
        Dim dr As OleDbDataReader

        TextBox1.Text = TextBox1.Text.Trim
        TextBox2.Text = TextBox2.Text.Trim
        TextBox3.Text = TextBox3.Text.Trim
        TextBox4.Text = TextBox4.Text.Trim
        TextBox5.Text = TextBox5.Text.Trim

        con = New OleDbConnection("Provider= Microsoft.ACE.OLEDB.12.0; Data Source = D:\Rajat\RTO\DB\DB.accdb")
        con.Open()

        cmd = New OleDbCommand("select * from login", con)
        dr = cmd.ExecuteReader

        Dim a, d As String
        Dim z, y As Integer
        z = 0
        y = 0

        a = TextBox1.Text & "." & TextBox2.Text & "@rto.in"
        Dim B As String
        B = "none"

        If RadioButton1.Checked Then
            B = RadioButton1.Text

        ElseIf RadioButton2.Checked Then

            B = RadioButton2.Text
        ElseIf RadioButton3.Checked Then

            B = RadioButton3.Text
        Else
            MsgBox("Enter Gender")
        End If
        Dim x As String

        While (dr.Read())
            If (dr(0).Equals(a)) Then
                z = z + 1
                a = TextBox1.Text & "." & TextBox2.Text & z & "@rto.in"
            End If
        End While

        d = DateTimePicker1.Value.ToShortDateString
        x = d.Substring(6)
        x = TextBox1.Text & "@" & x
        cmd = New OleDbCommand("insert into login values('" & a & "','" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & x & "','" & TextBox5.Text & "','" & TextBox4.Text & "','" & B & "','" & TextBox1.Text & "@" & d & "' )", con)

        y = cmd.ExecuteNonQuery

        If y > 0 Then
            MsgBox("User Added Successfully...!")
        Else
            MsgBox("Operation Failed")
        End If

        con.Close()
        dr.Close()

    End Sub

    Private Sub Newuser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker1.MaxDate.AddYears(-21)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        mainmenu.Show()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim ni As Integer
        ni = 0
        If Trim(TextBox1.Text) = "" Then
            Label5.Text = "Please Enter First Name"
            ni = 1
            check(ni)
        Else
            ni = 0
            check(ni)
            Label5.Text = ""
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Dim ni As Integer
        ni = 0
        If Trim(TextBox1.Text) = "" Then
            Label9.Text = "Please Enter Last Name"
            ni = 1
            check(ni)
        Else
            ni = 0
            check(ni)
            Label9.Text = ""
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        Dim ni As Integer

        If RadioButton1.Checked = False And RadioButton2.Checked = False And RadioButton3.Checked = False Then
            Label13.Text = " Please Enter your Gender"
            ni = 1
            check(ni)
        Else
            ni = 0
            check(ni)
            Label13.Text = ""
        End If

        ni = 0
        If Trim(TextBox1.Text) = "" Then
            Label10.Text = "Please Enter Mobile Number"
            ni = 1
            check(ni)
        Else
            ni = 0
            check(ni)
            Label10.Text = ""
        End If
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        Dim ni As Integer
        ni = 0
        If Trim(TextBox1.Text) = "" Then
            Label12.Text = "Please Enter Address"
            ni = 1
            check(ni)
        Else
            ni = 0
            check(ni)
            Label12.Text = ""
        End If
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        Dim ni As Integer
        ni = 0
        If Trim(TextBox1.Text) = "" Then
            Label11.Text = "Please Enter Email address"
            ni = 1
            check(ni)
        Else
            ni = 0
            check(ni)
            Label11.Text = ""
        End If
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.Click
        Dim ni As Integer
        ni = 0
        If Trim(TextBox1.Text) = "" Then
            Label5.Text = "Please Enter First Name"
            ni = 1
            check(ni)
        Else
            ni = 0
            check(ni)
            Label5.Text = ""
        End If
    End Sub

    Private Sub TextBox2_Click(sender As Object, e As EventArgs) Handles TextBox2.Click
        Dim ni As Integer
        ni = 0
        If Trim(TextBox1.Text) = "" Then
            Label9.Text = "Please Enter Last Name"
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
        If Trim(TextBox1.Text) = "" Then
            Label10.Text = "Please Enter Mobile Number"
            ni = 1
            check(ni)
        Else
            ni = 0
            check(ni)
            Label10.Text = ""
        End If
    End Sub

    Private Sub TextBox4_Click(sender As Object, e As EventArgs) Handles TextBox4.Click
        Dim ni As Integer
        ni = 0
        If Trim(TextBox1.Text) = "" Then
            Label11.Text = "Please Enter Email address"
            ni = 1
            check(ni)
        Else
            ni = 0
            check(ni)
            Label11.Text = ""
        End If
    End Sub

    Private Sub TextBox5_Click(sender As Object, e As EventArgs) Handles TextBox5.Click
        Dim ni As Integer
        ni = 0
        If Trim(TextBox1.Text) = "" Then
            Label12.Text = "Please Enter Address"
            ni = 1
            check(ni)
        Else
            ni = 0
            check(ni)
            Label12.Text = ""
        End If
    End Sub
End Class
