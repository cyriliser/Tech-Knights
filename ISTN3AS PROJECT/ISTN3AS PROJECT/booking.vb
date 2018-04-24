Public Class booking

    Private Sub BOOKINGBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.BOOKINGBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Group4DataSet1)

    End Sub


    Private Sub BOOKINGBindingNavigatorSaveItem_Click_1(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.BOOKINGBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Group4DataSet1)

    End Sub

    Private Sub booking_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Group4DataSet1.BOOKING' table. You can move, or remove it, as needed.
        Me.BOOKINGTableAdapter.Fill(Me.Group4DataSet1.BOOKING)

    End Sub
End Class