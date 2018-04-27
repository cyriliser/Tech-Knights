Public Class LoginForm

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        EmployeeTA.FillBy(LoginDS.EMPLOYEE, UsernameTextBox.Text, PasswordTextBox.Text)
        If LoginDS.EMPLOYEE.Rows.Count > 0 Then
            If LoginDS.EMPLOYEE.Rows(0).Item(9).ToString = "active" Then
                MsgBox("welcome to Ibutho Admin Syestem " & vbLf & vbLf &
                                  "user " & vbTab & vbTab & LoginDS.EMPLOYEE.Rows(0).Item(1).ToString & vbLf &
                                 "employeetype: " & vbTab & LoginDS.EMPLOYEE.Rows(0).Item(3).ToString)
                Main.FormSetup(Home)
            Else
                MsgBox("account disabled contact manager for more info")

            End If
        Else
            MsgBox("account not authorized")
        End If

        Me.Close()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub UsernameTextBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles UsernameTextBox.TextChanged

    End Sub

    Private Sub PasswordTextBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles PasswordTextBox.TextChanged

    End Sub

    Private Sub LoginForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        UsernameTextBox.Text = "siya@gmail.com"
        PasswordTextBox.Text = "qwerty"
    End Sub
End Class
