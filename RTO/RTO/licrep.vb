Public Class licrep
    Private Sub RegistrationBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles RegistrationBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.RegistrationBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DBDataSet4)

    End Sub

    Private Sub licrep_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DBDataSet4.Registration' table. You can move, or remove it, as needed.
        Me.RegistrationTableAdapter.Fill(Me.DBDataSet4.Registration)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        mainmenu.Show()

    End Sub
End Class