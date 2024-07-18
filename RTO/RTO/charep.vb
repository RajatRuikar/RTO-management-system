Public Class charep
    Private Sub ChallanBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ChallanBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ChallanBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DBDataSet2)

    End Sub

    Private Sub charep_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DBDataSet5.Challan' table. You can move, or remove it, as needed.
        Me.ChallanTableAdapter2.Fill(Me.DBDataSet5.Challan)


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        mainmenu.Show()

    End Sub
End Class