Public Class CR1_pt2

    Private Sub Label3_Click(sender As System.Object, e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label7_Click(sender As System.Object, e As System.EventArgs) Handles Label7.Click

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        'pulls all the records from the previous entry and fills the textboxes with the data
        'edits the record enterd previously if there are mistakes
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        'writes the data to the data base
        'clears and loads the form again
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        'writes data to the database
        'loads cr1 pt 3
        Main.FormSetup(CR1_pt3)
    End Sub
End Class