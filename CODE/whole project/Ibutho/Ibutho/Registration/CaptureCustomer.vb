Public Class CaptureCustomer

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        'set a variable current reg type to hold the type of registration in progres
        'make if a friend to be accessible on other forms
        'will help decide which forms to load
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        'set a variable current reg type to hold the type of registration in progres
        'make if a friend to be accessible on other forms
        'will help decide which forms to load
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        'set a variable current reg type to hold the type of registration in progres
        'make if a friend to be accessible on other forms
        'will help decide which forms to load
    End Sub

    Private Sub Reg_Co_op_Btn_Click(sender As System.Object, e As System.EventArgs) Handles Reg_Co_op_Btn.Click
        'set a variable current reg type to hold the type of registration in progres
        'make if a friend to be accessible on other forms
        'will help decide which forms to load

        'write data to data base
        Dim physicalAddress As String = P_O_BOX_No.Text & ":" & street_name.Text & ":" & town.Text & ":" & p_Code.Text
        CustomerTA.Insert(first_nane.Text, surname.Text, physicalAddress, email.Text, tell.Text, cell.Text, 0.0, nationality.Text, passport.Text, designation.Text, fax.Text, title.Text, initials.Text)

        'load cr1 pt1(application statement)
        Main.FormSetup(CR1_pt1)

    End Sub

    Private Sub IDno_TextChanged(sender As System.Object, e As System.EventArgs) Handles IDno.TextChanged

    End Sub
End Class