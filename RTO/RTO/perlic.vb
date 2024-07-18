Imports System.Data.OleDb

Public Class perlic

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        mainmenu.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As OleDbConnection
        Dim cmd, cmd1, cmd2 As OleDbCommand
        Dim dr, dr2, dr1 As OleDbDataReader

        con = New OleDbConnection("Provider= Microsoft.ACE.OLEDB.12.0; Data Source = D:\Rajat\RTO\DB\DB.accdb")
        con.Open()

        cmd = New OleDbCommand("select * from Registration", con)
        dr = cmd.ExecuteReader
        cmd1 = New OleDbCommand("select * from Permanent", con)
        dr1 = cmd1.ExecuteReader
        cmd2 = New OleDbCommand("select * from Learning", con)
        dr2 = cmd1.ExecuteReader

        Dim B As String
        B = "none"

        If RadioButton1.Checked Then
            B = RadioButton1.Text

        ElseIf RadioButton2.Checked Then

            B = RadioButton2.Text
        ElseIf RadioButton3.Checked Then

            B = RadioButton3.Checked
        Else
            MsgBox("Enter Gender")
        End If



        cmd = New OleDbCommand("insert into Registration values('" & TextBox2.Text & "','" & TextBox3.Text & "','" & B & "','" & TextBox4.Text & "','" & DateTimePicker1.Value.ToShortDateString & "','" & ComboBox1.SelectedItem & "','" & TextBox5.Text & "','" & DateTimePicker1.Value.ToShortDateString & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & ComboBox2.SelectedItem & "','" & B & "','" & ComboBox3.SelectedItem & " )", con)
        cmd1 = New OleDbCommand("insert into Permanent values('" & TextBox8.Text & "','" & TextBox1.Text & "','" & DateTimePicker1.Value.AddMonths(120) & "','" & TextBox2.Text & "','" & DateTimePicker1.Value.AddMonths(1 / 4) & ")", con)

        Dim y, z As Integer
        y = cmd.ExecuteNonQuery
        z = cmd1.ExecuteNonQuery
        If y > 0 And z > 0 Then
            MsgBox("Registration Added Successfully...!")
        Else
            MsgBox("Operation Failed")
        End If

        con.Close()
        dr.Close()
        dr1.Close()

    End Sub
End Class