Imports MySql.Data.MySqlClient
Public Class Form2
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Bersihkan()
    End Sub

    Private Sub Button_Close_Click(sender As Object, e As EventArgs) Handles Button_Close.Click
        Bersihkan()
        Me.Hide()
        Form1.Show()
        Form1.TextBox_Id.Focus()
    End Sub

    Private Sub Button_Save_Click(sender As Object, e As EventArgs) Handles Button_Save.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=;database=absen_tekaje"
        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Select * From absen_tekaje.data_siswa where id_rf='" & TextBox_Idrf.Text & "' "
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader
            Dim count As Integer
            count = 0
            While READER.Read
                count = count + 1

            End While

            If (TextBox_Idrf.Text = "") Then
                ErrorProvider1.SetError(TextBox_Idrf, "Tidak Boleh Kosong")
                TextBox_Idrf.Focus()
            ElseIf (TextBox_Nis.Text = "") Then
                ErrorProvider1.SetError(TextBox_Nis, "Tidak Boleh Kosong")
                TextBox_Nis.Focus()
            ElseIf (TextBox_NamaDepan.Text = "") Then
                ErrorProvider1.SetError(TextBox_NamaDepan, "Tidak Boleh Kosong")
                TextBox_NamaDepan.Focus()

            ElseIf count >= 1 Then
                MessageBox.Show("Kartu Sudah Terdaftar")
            Else
                Tambah()
            End If


            MysqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub Tambah()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=;database=absen_tekaje"
        Dim READER As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "insert into absen_tekaje.data_siswa (id_rf,nis,nama_depan,nama_belakang,kelas,jurusan) values ('" & TextBox_Idrf.Text & "','" & TextBox_Nis.Text & "','" & TextBox_NamaDepan.Text & "','" & TextBox_NamaBelakang.Text & "','" & ComboBox_Kelas.Text & "','" & ComboBox_Jurusan.Text & "')"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader

            MessageBox.Show("Data Saved")
            Bersihkan()
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

    Private Sub Bersihkan()
        TextBox_Idrf.Focus()
        TextBox_Idrf.Clear()
        TextBox_Nis.Clear()
        TextBox_NamaBelakang.Clear()
        TextBox_NamaDepan.Clear()

        TextBox_Idrf.MaxLength = 10
        TextBox_Nis.MaxLength = 36
        TextBox_NamaDepan.MaxLength = 50
        TextBox_NamaBelakang.MaxLength = 50
        ComboBox_Kelas.MaxLength = 5
        ComboBox_Jurusan.MaxLength = 5
    End Sub

   
End Class