Imports System.Data.Common
Imports System.Data.Odbc
Public Class Form1
    Public conn As OdbcConnection
    Public cmd As OdbcCommand
    Public dr As OdbcDataReader

    Sub koneksi()
        conn = New OdbcConnection("Dsn=konek_dblatihan;Database=db_latihan;Uid=root;Pwd=")
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
                MsgBox("koneksi berhasil")
            End If
        Catch ex As Exception
            MsgBox("Koneksi Gagal.." & ex.Message)
        End Try
    End Sub

    Sub IsiComboBox()
        Try
            Dim query As String = "SELECT kode_pelanggan FROM tbl_pelanggan"
            cmd = New OdbcCommand(query, conn)
            dr = cmd.ExecuteReader()
            cbopelanggan.Items.Clear()
            While dr.Read()
                cbopelanggan.Items.Add(dr("kode_pelanggan").ToString())
            End While
            dr.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub
    Sub tampilbarang()
        Try
            Dim query As String = "SELECT Nama_Barang, harga_beli, harga_jual FROM tblbarang"
            cmd = New OdbcCommand(query, conn)
            dr = cmd.ExecuteReader()
            cbobarang.Items.Clear()
            While dr.Read()
                cbobarang.Items.Add(dr("Nama_Barang").ToString())
            End While
            dr.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try

        If cbobarang.SelectedIndex <> -1 Then
            Try
                Dim selectedBarang As String = cbobarang.SelectedItem.ToString()
                Dim query As String = "SELECT Harga_Beli, Harga_Jual FROM tblbarang WHERE Nama_Barang = ?"
                cmd = New OdbcCommand(query, conn)
                cmd.Parameters.AddWithValue("?", selectedBarang)
                dr = cmd.ExecuteReader()
                If dr.Read() Then
                    txthargakotor.Text = dr("Harga_Beli").ToString()
                    txthargabersih.Text = dr("Harga_Jual").ToString()
                End If
                dr.Close()
            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
            End Try
        Else
            txthargakotor.Text = ""
            txthargabersih.Text = ""
        End If
    End Sub

    Private Sub cbobarang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbobarang.SelectedIndexChanged
        Try
            Dim selectedBarang As String = cbobarang.SelectedItem.ToString()
            Dim query As String = "SELECT harga_beli, kode_barang, jenis, harga_jual FROM tblbarang WHERE Nama_Barang = ?"
            cmd = New OdbcCommand(query, conn)
            cmd.Parameters.Add(New OdbcParameter("namaBarang", selectedBarang))
            dr = cmd.ExecuteReader()

            If dr.Read() Then
                txtkodebarang.Text = dr("kode_barang").ToString()
                txtjenis.Text = dr("jenis").ToString()
                txthargakotor.Text = dr("harga_beli").ToString()
                txthargabersih.Text = dr("harga_jual").ToString()
            End If

            dr.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub

    Sub simpanpenjualan()
        Dim nofaktur = txtfaktur.Text
        Dim tgl = txttanggal.Text
        Dim kodepelanggan = cbopelanggan.Text
        Dim totalpembelian = txttotal.Text
        Dim query As String = "INSERT INTO tbl_penjualan (faktur_penjualan, tgl_penjualan, kode_pelanggan, total) VALUES (?, ?, ?, ?)"
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            cmd = New OdbcCommand(query, conn)
            cmd.Parameters.AddWithValue("?", nofaktur)
            cmd.Parameters.AddWithValue("?", tgl)
            cmd.Parameters.AddWithValue("?", kodepelanggan)
            cmd.Parameters.AddWithValue("?", totalpembelian)
            cmd.ExecuteNonQuery()
            MsgBox("Data penjualan berhasil disimpan ke dalam tabel.")
        Catch ex As Exception
            MsgBox("Kesalahan saat menyimpan data: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Sub simpandetail()
        Dim nofaktur = txtfaktur.Text
        Dim kodebarang = txtkodebarang.Text
        Dim hargajual = txthargabersih.Text
        Dim jumlahbeli = txtjumlahbeli.Text
        Dim subtotal = txtsubtotal.Text
        Dim query As String = "INSERT INTO tbl_penjualan_rinci (faktur_penjualan, kode_barang, harga_jual, jumlah, sub_total) VALUES (?, ?, ?, ?, ?)"

        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            cmd = New OdbcCommand(query, conn)
            cmd.Parameters.AddWithValue("?", nofaktur)
            cmd.Parameters.AddWithValue("?", kodebarang)
            cmd.Parameters.AddWithValue("?", hargajual)
            cmd.Parameters.AddWithValue("?", jumlahbeli)
            cmd.Parameters.AddWithValue("?", subtotal)
            cmd.ExecuteNonQuery()
            MsgBox("Data detail penjualan berhasil disimpan ke dalam tabel.")
        Catch ex As Exception
            MsgBox("Kesalahan saat menyimpan data detail penjualan: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Sub tampilreport()
        Try
            dataGridView1.Rows.Clear()

            Dim query As String = "SELECT faktur_penjualan, kode_barang, harga_jual, jumlah, sub_total FROM tbl_penjualan_rinci"
            cmd = New OdbcCommand(query, conn)
            dr = cmd.ExecuteReader()

            While dr.Read()
                dataGridView1.Rows.Add(dr("faktur_penjualan").ToString(), dr("kode_barang").ToString(), dr("harga_jual").ToString(), dr("jumlah").ToString(), dr("sub_total").ToString())
            End While

            dr.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        IsiComboBox()
        tampilbarang()
        tampilreport()
    End Sub


    Private Sub cbopelanggan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbopelanggan.SelectedIndexChanged
        Try
            Dim selectedKode As String = cbopelanggan.SelectedItem.ToString()
            Dim query As String = "SELECT nama_pelanggan FROM tbl_pelanggan WHERE kode_pelanggan = ?"
            cmd = New OdbcCommand(query, conn)
            cmd.Parameters.Add(New OdbcParameter("namaBarang", selectedKode))
            dr = cmd.ExecuteReader()
            If dr.Read() Then
                txtpelanggan.Text = dr("nama_pelanggan").ToString()
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub txtjumlahbeli_TextChanged(sender As Object, e As EventArgs) Handles txtjumlahbeli.TextChanged
        Try
            Dim jumlahbeli As Integer = Integer.Parse(txtjumlahbeli.Text)
            Dim hargabeli As Double = Double.Parse(txthargabersih.Text)
            Dim subtotal As Double = jumlahbeli * hargabeli
            txtsubtotal.Text = subtotal
            txttotal.Text = subtotal
        Catch ex As Exception

            MsgBox("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        Call simpanpenjualan()
        Call simpandetail()
    End Sub


End Class
