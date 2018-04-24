Imports System.Data.OleDb

Public Class Form1

    Dim provider As String
    Dim datafile As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'had no clue how to do this part. please fill in if you can
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
        'Change the following to your access database location
        datafile = "C:\Users\Jimmy\Documents\customers.accdb"
        connString = provider & datafile
        myConnection.ConnectionString = connString

        'the query:
        Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM [EMPLOYEE] WHERE [EmailAddress] = '" & TextBox1.Text & "' AND [EmployeePassword] = '" & TextBox2.Text & "'", myConnection)
        Dim dr As OleDbDataReader = cmd.ExecuteReader

        If TextBox1.Text = dr("EmailAddress") And TextBox2.Text = dr("EmployeePassword") Then
            MsgBox("Welcome " & dr("FirstName") & " " & dr("LastName"), MsgBoxStyle.Information, "Welcome")

            'called all types of access to the menu form2
            If dr("EmployeeType") = "Admin" Then
                Form2.Show()

            ElseIf dr("EmployeeType") = "Manager" Then
                Form2.Show()

            Else
                Form2.Show()

            End If

        Else
            MsgBox("Sorry, username or password incorrect", MsgBoxStyle.Critical, "Invalid Login")

        End If

    End Sub
End Class
