Imports MySql.Data.MySqlClient
Public Class Form1

    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox_Id.Focus()
        Label_Tanggal_Hidd.Visible = False
        Label_Jam.Visible = False
        Button_Conn.Visible = False
        Object_Hidden()
    End Sub

    Private Sub TextBox_Id_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Id.TextChanged
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=;database=absen_tekaje"
        Dim READER As MySqlDataReader
        TextBox_Id.MaxLength = 10

        If TextBox_Id.Text.Trim.Length = 10 Then


            Try
                MysqlConn.Open()
                Dim Query As String
                Query = "Select * From absen_tekaje.data_siswa where id_rf='" & TextBox_Id.Text & "'"
                COMMAND = New MySqlCommand(Query, MysqlConn)
                READER = COMMAND.ExecuteReader
                Dim count As Integer
                count = 0
                While READER.Read
                    count = count + 1

                End While

                If count = 1 Then
                    Histori_Tab()
                    Absen_Tab()
                    Object_Tampil()

                    Label_Id.Text = TextBox_Id.Text
                    Label_Nama.Text = READER.GetString("nama_depan")
                    Button_Simb_Ok.Visible = True
                    TextBox_Id.Clear()
                ElseIf count > 1 Then
                    Object_Tampil()
                    Label_Id.Text = TextBox_Id.Text
                    Label_Nama.Text = "Data Double"
                    Button_Simb_Ok.Visible = False
                    Button_Simb_X.Visible = True
                    TextBox_Id.Clear()
                Else
                    Object_Tampil()
                    Label_Id.Text = TextBox_Id.Text
                    Label_Nama.Text = "Not Found"
                    Button_Simb_Ok.Visible = False
                    Button_Simb_X.Visible = True
                    TextBox_Id.Clear()
                End If


                MysqlConn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                MysqlConn.Dispose()
            End Try


        End If
    End Sub

    Private Sub Button_Conn_Click(sender As Object, e As EventArgs) Handles Button_Conn.Click
        Form3.Show()

    End Sub

    Private Sub Histori_Tab()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=;database=absen_tekaje"
        Dim READER As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "insert into absen_tekaje.tab_histori_harian (id_rf,jam_tab) values ('" & TextBox_Id.Text & "','" & Label_Jam.Text & "')"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader

            MysqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

    End Sub

    Private Sub Absen_Tab()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=;database=absen_tekaje"
        Dim READER As MySqlDataReader


        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Select * From absen_tekaje.tab_absen_harian where id_rf='" & TextBox_Id.Text & "' and tgl_tab='" & Label_Tanggal_Hidd.Text & "'"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader
            Dim count As Integer
            count = 0
            While READER.Read
                count = count + 1

            End While

            If count = 1 Then
                Akhir_Tab()
            Else
                Awal_Tab()
            End If


            MysqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

    End Sub

    Private Sub Awal_Tab()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=;database=absen_tekaje"
        Dim READER As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "insert into absen_tekaje.tab_absen_harian (id_rf,jam_masuk,tgl_tab) values ('" & TextBox_Id.Text & "','" & Label_Jam.Text & "','" & Label_Tanggal_Hidd.Text & "')"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader

            MysqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

    End Sub

    Private Sub Akhir_Tab()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=;database=absen_tekaje"
        Dim READER As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "update absen_tekaje.tab_absen_harian set jam_keluar='" & Label_Jam.Text & "' where id_rf='" & TextBox_Id.Text & "' "
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader

            MysqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label_Jam.Text = Format(Now, "HH:mm:ss")
        Label_Jam_Wel.Text = Format(Now, "HH:mm:ss")
        Label_Tanggal.Text = Format(Now, "dd/MM/yyyy")
        Label_Tanggal_Hidd.Text = Format(Now, "yyyy-MM-dd")
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Object_Hidden()
    End Sub

    Private Sub Object_Tampil()
        Label_Id.Visible = True
        Label_Nama.Visible = True
        Label_Jam_Wel.Visible = False
        Label_Welcome.Visible = False
    End Sub

    Private Sub Object_Hidden()
        Label_Nama.Visible = False
        Label_Id.Visible = False
        Label_Jam_Wel.Visible = True
        Label_Welcome.Visible = True
        Button_Simb_X.Visible = False
        Button_Simb_Ok.Visible = False
    End Sub

End Class
