Public Class Register

    Private Sub CUSTOMERBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.CUSTOMERBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Group4DataSet)

    End Sub


    Private Sub CUSTOMERBindingNavigatorSaveItem_Click_1(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.CUSTOMERBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Group4DataSet)

    End Sub

    Private Sub Register_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Group4DataSet.CUSTOMER' table. You can move, or remove it, as needed.
        Me.CUSTOMERTableAdapter.Fill(Me.Group4DataSet.CUSTOMER)

    End Sub

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click

    End Sub
End Class