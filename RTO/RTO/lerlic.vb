Imports System.Data.OleDb

Public Class lerlic

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        mainmenu.Show()

    End Sub

    Private Sub lerlic_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TextBox1.Text = TextBox1.Text.Trim
        TextBox2.Text = TextBox2.Text.Trim
        TextBox3.Text = TextBox3.Text.Trim
        TextBox4.Text = TextBox4.Text.Trim
        TextBox5.Text = TextBox5.Text.Trim
        TextBox6.Text = TextBox1.Text.Trim
        TextBox7.Text = TextBox1.Text.Trim

        ComboBox1.Items.Clear()
        ComboBox2.Items.Clear()
        ComboBox3.Items.Clear()

        ComboBox1.Items.Add("Two wheeler")
        ComboBox1.Items.Add("Three wheeler")
        ComboBox1.Items.Add("Four wheeler")
        ComboBox1.Items.Add("six wheeler")
        ComboBox1.Items.Add("Truck wheeler")

        ComboBox2.Items.Add("Addhar Card")
        ComboBox2.Items.Add("PAN Card")
        ComboBox2.Items.Add("Voter ID")

        ComboBox3.Items.Add("Electric Bill")
        ComboBox3.Items.Add("Addhar Card")
        ComboBox3.Items.Add("Voter ID")


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As OleDbConnection
        Dim cmd, cmd1 As OleDbCommand
        Dim dr, dr1 As OleDbDataReader

        con = New OleDbConnection("Provider= Microsoft.ACE.OLEDB.12.0; Data Source = D:\Rajat\RTO\DB\DB.accdb")
        con.Open()

        cmd = New OleDbCommand("select * from Registration", con)
        dr = cmd.ExecuteReader
        cmd1 = New OleDbCommand("select * from Learning", con)
        dr1 = cmd1.ExecuteReader

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


        cmd = New OleDbCommand("insert into Registration values('" & TextBox2.Text & "','" & TextBox3.Text & "','" & B & "','" & TextBox4.Text & "','" & DateTimePicker1.Value.ToShortDateString & "','" & ComboBox1.SelectedItem & "','" & TextBox5.Text & "','" & DateTimePicker1.Value.ToShortDateString & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & ComboBox2.SelectedItem & "','" & B & "','" & ComboBox3.SelectedItem & " )", con)
        cmd1 = New OleDbCommand("insert into Learning values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & DateTimePicker1.Value.AddMonths(1 / 2) & "','" & DateTimePicker2.Value.ToShortDateString & ")", con)

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