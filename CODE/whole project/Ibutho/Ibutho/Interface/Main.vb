Public Class Main

    Private Sub loginbtn_Click(sender As System.Object, e As System.EventArgs)
        LoginForm.Show()

    End Sub

    Private Sub LoginToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LoginToolStripMenuItem.Click
        FormSetup(LoginForm)
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        FormSetup(LoginForm)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()

    End Sub

    Friend Sub FormSetup(ByVal ChildForm As Form)
        Try
            If ActiveMdiChild.Name <> ChildForm.Name Then
                Me.ActiveMdiChild.Close()
            End If
        Catch ex As Exception

        End Try

        With ChildForm
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()

        End With
    End Sub
End Class