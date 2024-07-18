Imports System.Data.OleDb

Public Class prireg
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        mainmenu.Show()

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

        cmd = New OleDbCommand("select * from Vehicle", con)
        dr = cmd.ExecuteReader

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


        cmd = New OleDbCommand("insert into Vehicale values('" & TextBox1.Text & "','" & TextBox3.Text & "','" & TextBox2.Text & "','" & TextBox6.Text & "','" & TextBox5.Text & "','" & ComboBox1.SelectedItem & "','" & ComboBox2.SelectedItem & "','" & TextBox10.Text & "','" & TextBox8.Text & "','" & TextBox4.Text & "','" & TextBox9.Text & "','" & B & "','" & DateTimePicker1.Value.ToShortDateString & "' )", con)
        Dim y As Integer
        y = cmd.ExecuteNonQuery
        If y > 0 Then
            MsgBox("Registration Added Successfully...!")
        Else
            MsgBox("Operation Failed")
        End If

        con.Close()
        dr.Close()

    End Sub

    Private Sub comreg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Heavy Vehicle")
        ComboBox1.Items.Add("Light Vehicle")


    End Sub




    Private Sub ComboBox2_Click(sender As Object, e As EventArgs) Handles ComboBox2.Click
        ComboBox2.Items.Clear()
        If ComboBox1.SelectedItem = "Heavy Vehicle" Then

            ComboBox2.Items.Add("Six wheeler")
            ComboBox2.Items.Add("Eight wheeler")
            ComboBox2.Items.Add("Ten wheeler")
            ComboBox2.Items.Add("Fourteen wheeler")
            ComboBox2.Items.Add("Sixteen wheeler")
            Label14.Visible = False

        ElseIf ComboBox1.SelectedItem = "Light Vehicle" Then
            ComboBox2.Items.Add("Two wheeler")
            ComboBox2.Items.Add("Three wheeler")
            Label14.Visible = False

        Else
            Label14.Visible = True

        End If

    End Sub




    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Label14.Visible = False
    End Sub


End Class