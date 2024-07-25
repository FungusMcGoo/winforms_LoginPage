Imports System.Data.SqlClient
Imports Microsoft.SqlServer
Public Class MELogin

    '(LocalDb)\MSSQLLocalDB
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim conStr As String = "Server=(localdb)\MSSQLLocalDB;Integrated Security=true;Database=MONOLITHIC;"
        If String.IsNullOrEmpty(txtboxUser.Text) Then
            MessageBox.Show("Please enter your username.")
            Return
        End If

        If String.IsNullOrEmpty(txtboxPass.Text) Then
            MessageBox.Show("Please enter your password.")
            Return
        End If

        Using conSql As New SqlConnection(conStr)
            Try
                conSql.Open()
                Dim query As String = "SELECT COUNT(*) FROM ME_users WHERE ME_username=@ME_username AND ME_password=@ME_password"
                Using cmdSql As New SqlCommand(query, conSql)

                    cmdSql.Parameters.AddWithValue("@ME_username", txtboxUser.Text)
                    cmdSql.Parameters.AddWithValue("@ME_password", txtboxPass.Text)
                    Dim result As Integer = Convert.ToInt32(cmdSql.ExecuteScalar()) 'da fuq is dis??
                    If result > 0 Then
                        MessageBox.Show("Login Successful.")
                        MEmain.Show()
                        Me.Hide()
                    Else
                        MessageBox.Show("Invalid Username or Password.")
                    End If
                End Using
            Catch ex As SqlException '?? check for sql faiL?
                MessageBox.Show("Error connecting to database: " & ex.Message)

            End Try
        End Using
    End Sub
End Class
