Public Class vecrep
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) 

    End Sub

    Private Sub vecrep_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Vehrep.Vehicle' table. You can move, or remove it, as needed.
        Me.VehicleTableAdapter.Fill(Me.Vehrep.Vehicle)

    End Sub

    Private Sub VehicleBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles VehicleBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.VehicleBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Vehrep)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        mainmenu.Show()

    End Sub
End Class