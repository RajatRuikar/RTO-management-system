Imports System.Data.OleDb


Public Class cha





    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        mainmenu.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As OleDbConnection
        Dim cmd As OleDbCommand
        Dim dr As OleDbDataReader

        con = New OleDbConnection("Provider= Microsoft.ACE.OLEDB.12.0; Data Source = D:\Rajat\RTO\DB\DB.accdb")
        con.Open()

        cmd = New OleDbCommand("select * from Challan", con)
        dr = cmd.ExecuteReader

        Dim a As String

        If RadioButton1.Checked Then
            a = RadioButton1.Text

        ElseIf RadioButton2.Checked Then

            a = RadioButton2.Text
        ElseIf RadioButton3.Checked Then

            a = RadioButton3.Text
        Else
            MsgBox("Enter Gender")
        End If
        Dim f As Integer
        f = 0
        Dim X As String
        X = ""
        If CheckBox1.Checked = True Then
            X = CheckBox1.Text
            f = 1000
        End If

        If CheckBox2.Checked = True Then
            X = X & "," & CheckBox2.Text
            f = f + 1000
        End If

        If CheckBox3.Checked = True Then
            X = X & "," & CheckBox3.Text
            f = f + 1000
        End If

        If CheckBox4.Checked = True Then
            X = X & "," & CheckBox4.Text
            f = f + 1000
        End If

        If CheckBox5.Checked = True Then
            X = X & "," & CheckBox5.Text
            f = f + 1000
        End If
        Dim m As Integer

        m = Conversion.Int(TextBox9.Text)
        If CheckBox6.Checked = True Then
            X = X & "," & TextBox8.Text
            f = f + m
        End If

        cmd = New OleDbCommand("insert into Challan values('" & TextBox1.Text & "','" & a & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & X & "','" & TextBox8.Text & "','" & TextBox9.Text & "','" & TextBox10.Text & "')", con)

        Dim y As Integer
        y = cmd.ExecuteNonQuery
        If y > 0 Then
            MsgBox("Challan Added Successfully...!")
        Else
            MsgBox("Operation Failed")
        End If

        con.Close()
        dr.Close()


    End Sub

    Private Sub TextBox9_Click(sender As Object, e As EventArgs) Handles TextBox9.Click
        If TextBox8.Text = "" Then
            Label13.Visible = True
        Else
            Label13.Visible = False

        End If
    End Sub

    Private Sub TextBox8_Click(sender As Object, e As EventArgs) Handles TextBox8.Click
        If CheckBox6.Checked = True Then
            Label14.Visible = False
        Else
            Label14.Visible = True

        End If
    End Sub

    Private Sub TextBox10_Click(sender As Object, e As EventArgs) Handles TextBox10.Click
        Dim f As Integer
        f = 0

        If CheckBox1.Checked = True Then

            f = 1000
        End If

        If CheckBox2.Checked = True Then

            f = f + 1000
        End If

        If CheckBox3.Checked = True Then

            f = f + 1000
        End If

        If CheckBox4.Checked = True Then

            f = f + 1000
        End If

        If CheckBox5.Checked = True Then

            f = f + 1000
        End If
        Dim m As Integer

        m = Conversion.Int(TextBox9.Text)
        If CheckBox6.Checked = True Then
            f = f + m
        End If
        TextBox10.Text = f
    End Sub
End Class