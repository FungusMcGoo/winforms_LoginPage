Imports System.Data.SqlClient
Imports Microsoft.SqlServer
Public Class MELogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        'SQL Server Express Localdb connection string
        Dim conStr As String = "Server=(localdb)\MSSQLLocalDB;Integrated Security=true;Database=MONOLITHIC;"

        'Error if attempting to login while username field is left empty
        If String.IsNullOrEmpty(txtboxUser.Text) Then
            MessageBox.Show("Please enter your username.")
            Return
        End If

        'Error if attempting to login while password field is left empty
        If String.IsNullOrEmpty(txtboxPass.Text) Then
            MessageBox.Show("Please enter your password.")
            Return
        End If

        Using conSql As New SqlConnection(conStr)
            Try
                conSql.Open()
                Dim query As String = "SELECT COUNT(*) FROM ME_users WHERE ME_username=@ME_username AND ME_password=@ME_password"
                Using cmdSql As New SqlCommand(query, conSql)

                    'Replace @ME_username and @ME_password with your databases column names
                    cmdSql.Parameters.AddWithValue("@ME_username", txtboxUser.Text)
                    cmdSql.Parameters.AddWithValue("@ME_password", txtboxPass.Text)

                    Dim result As Integer = Convert.ToInt32(cmdSql.ExecuteScalar())
                    If result > 0 Then
                        'If user/pass matches, hide login and show main form
                        MessageBox.Show("Login Successful.")
                        MEmain.Show()
                        Me.Hide()
                    Else
                        MessageBox.Show("Invalid Username or Password.")
                    End If
                End Using
            Catch ex As SqlException 'Check for SQL failures- this is helpful for troubleshooting connectivity to database
                MessageBox.Show("Error connecting to database: " & ex.Message)
            End Try
        End Using
    End Sub
End Class
