Imports MySql.Data.MySqlClient
Public Class Form3
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=astrindo1;userid=root;password=;database=absen_tekaje"

        Try
            MysqlConn.Open()
            MessageBox.Show("Koneksi Sukses")
            Me.Hide()
            Form1.Show()
            Form1.TextBox_Id.Focus()
            MysqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form1.Show()
        Form1.TextBox_Id.Focus()
        Me.Hide()
    End Sub
End Class