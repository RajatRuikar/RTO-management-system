
Public Class mainmenu
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Hide()
        login.Show()
    End Sub

    Private Sub AddUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddUserToolStripMenuItem.Click
        Me.Hide()
        Newuser.Show()
    End Sub



    Private Sub GovernmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GovernmentToolStripMenuItem.Click
        Me.Hide()
        govreg.Show()

    End Sub

    Private Sub CommercialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CommercialToolStripMenuItem.Click
        Me.Hide()
        comreg.Show()

    End Sub

    Private Sub PrivateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrivateToolStripMenuItem.Click
        Me.Hide()
        prireg.Show()

    End Sub

    Private Sub LearningToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LearningToolStripMenuItem1.Click
        Me.Hide()
        lerlic.Show()

    End Sub

    Private Sub PermanentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PermanentToolStripMenuItem.Click
        Me.Hide()
        perlic.Show()

    End Sub

    Private Sub RenewalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RenewalToolStripMenuItem.Click
        Me.Hide()
        renlic.Show()

    End Sub

    Private Sub UpdateMobileNumberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateMobileNumberToolStripMenuItem.Click
        Me.Hide()
        updmob.Show()

    End Sub

    Private Sub ChangeOfAddressToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeOfAddressToolStripMenuItem.Click
        Me.Hide()
        chaadd.Show()

    End Sub

    Private Sub DrvingTestToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DrvingTestToolStripMenuItem.Click
        Me.Hide()
        drites.Show()

    End Sub

    Private Sub VechicalOwnershipTransferToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Hide()
        vecowntran.Show()

    End Sub

    Private Sub VechicalDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Hide()
        vecdet.Show()

    End Sub

    Private Sub ChallanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChallanToolStripMenuItem.Click
        Me.Hide()
        cha.Show()

    End Sub

    Private Sub LockSystemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LockSystemToolStripMenuItem.Click
        Me.Enabled = False
        Locsys.Show()

    End Sub

    Private Sub mainmenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub AccountDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AccountDetailsToolStripMenuItem.Click
        Me.Hide()
        login.Show()

    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Me.Hide()
        Accdet.Show()

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub LearningToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LearningToolStripMenuItem.Click

    End Sub

    Private Sub PernamentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PernamentToolStripMenuItem.Click


    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub VehicleDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VehicleDetailsToolStripMenuItem.Click
        Me.Hide()
        vecrep.Show()

    End Sub

    Private Sub LicenseDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LicenseDetailsToolStripMenuItem.Click
        Me.Hide()
        licrep.Show()

    End Sub

    Private Sub ChallanDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChallanDetailsToolStripMenuItem.Click
        Me.Hide()
        charep.Show()

    End Sub

    Private Sub LogOutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem1.Click
        Me.Hide()
        login.Show()

    End Sub

End Class