<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        cbopelanggan = New ComboBox()
        cbobarang = New ComboBox()
        txtpelanggan = New TextBox()
        txtfaktur = New TextBox()
        dataGridView1 = New DataGridView()
        faktur_penjualan = New DataGridViewTextBoxColumn()
        kode_barang = New DataGridViewTextBoxColumn()
        harga_jual = New DataGridViewTextBoxColumn()
        jumlah = New DataGridViewTextBoxColumn()
        sub_total = New DataGridViewTextBoxColumn()
        btnsimpan = New Button()
        btncetak = New Button()
        btnbatal = New Button()
        Label5 = New Label()
        Label7 = New Label()
        txthargakotor = New TextBox()
        txthargabersih = New TextBox()
        txtkodebarang = New TextBox()
        Label8 = New Label()
        Label9 = New Label()
        txtjumlahbeli = New TextBox()
        txtjenis = New TextBox()
        Label10 = New Label()
        txtsubtotal = New TextBox()
        txttanggal = New DateTimePicker()
        Label11 = New Label()
        txttotal = New TextBox()
        Label12 = New Label()
        Label13 = New Label()
        CType(dataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(32, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(63, 15)
        Label1.TabIndex = 0
        Label1.Text = "Pelanggan"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(32, 69)
        Label2.Name = "Label2"
        Label2.Size = New Size(98, 15)
        Label2.TabIndex = 0
        Label2.Text = "Nama Pelanggan"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(32, 113)
        Label3.Name = "Label3"
        Label3.Size = New Size(44, 15)
        Label3.TabIndex = 0
        Label3.Text = "Barang"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(292, 29)
        Label4.Name = "Label4"
        Label4.Size = New Size(95, 15)
        Label4.TabIndex = 0
        Label4.Text = "Faktur Penjualan"
        ' 
        ' cbopelanggan
        ' 
        cbopelanggan.FormattingEnabled = True
        cbopelanggan.Location = New Point(147, 26)
        cbopelanggan.Name = "cbopelanggan"
        cbopelanggan.Size = New Size(121, 23)
        cbopelanggan.TabIndex = 1
        ' 
        ' cbobarang
        ' 
        cbobarang.FormattingEnabled = True
        cbobarang.Location = New Point(147, 113)
        cbobarang.Name = "cbobarang"
        cbobarang.Size = New Size(121, 23)
        cbobarang.TabIndex = 2
        ' 
        ' txtpelanggan
        ' 
        txtpelanggan.Location = New Point(151, 67)
        txtpelanggan.Name = "txtpelanggan"
        txtpelanggan.Size = New Size(117, 23)
        txtpelanggan.TabIndex = 3
        ' 
        ' txtfaktur
        ' 
        txtfaktur.Location = New Point(393, 26)
        txtfaktur.Name = "txtfaktur"
        txtfaktur.Size = New Size(154, 23)
        txtfaktur.TabIndex = 4
        ' 
        ' dataGridView1
        ' 
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dataGridView1.Columns.AddRange(New DataGridViewColumn() {faktur_penjualan, kode_barang, harga_jual, jumlah, sub_total})
        dataGridView1.Location = New Point(50, 169)
        dataGridView1.Name = "dataGridView1"
        dataGridView1.RowTemplate.Height = 25
        dataGridView1.Size = New Size(675, 158)
        dataGridView1.TabIndex = 5
        ' 
        ' faktur_penjualan
        ' 
        faktur_penjualan.HeaderText = "Faktur Penjualan"
        faktur_penjualan.Name = "faktur_penjualan"
        ' 
        ' kode_barang
        ' 
        kode_barang.HeaderText = "Kode Barang"
        kode_barang.Name = "kode_barang"
        ' 
        ' harga_jual
        ' 
        harga_jual.HeaderText = "Harga Jual"
        harga_jual.Name = "harga_jual"
        ' 
        ' jumlah
        ' 
        jumlah.HeaderText = "Jumlah Beli"
        jumlah.Name = "jumlah"
        ' 
        ' sub_total
        ' 
        sub_total.HeaderText = "Total"
        sub_total.Name = "sub_total"
        ' 
        ' btnsimpan
        ' 
        btnsimpan.Location = New Point(55, 346)
        btnsimpan.Name = "btnsimpan"
        btnsimpan.Size = New Size(75, 23)
        btnsimpan.TabIndex = 6
        btnsimpan.Text = "Simpan"
        btnsimpan.UseVisualStyleBackColor = True
        ' 
        ' btncetak
        ' 
        btncetak.Location = New Point(55, 375)
        btncetak.Name = "btncetak"
        btncetak.Size = New Size(75, 23)
        btncetak.TabIndex = 7
        btncetak.Text = "Cetak"
        btncetak.UseVisualStyleBackColor = True
        ' 
        ' btnbatal
        ' 
        btnbatal.Location = New Point(55, 404)
        btnbatal.Name = "btnbatal"
        btnbatal.Size = New Size(75, 23)
        btnbatal.TabIndex = 8
        btnbatal.Text = "Batal"
        btnbatal.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(440, 346)
        Label5.Name = "Label5"
        Label5.Size = New Size(71, 15)
        Label5.TabIndex = 0
        Label5.Text = "Harga Kotor"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(436, 387)
        Label7.Name = "Label7"
        Label7.Size = New Size(74, 15)
        Label7.TabIndex = 0
        Label7.Text = "Harga Bersih"
        ' 
        ' txthargakotor
        ' 
        txthargakotor.Location = New Point(554, 343)
        txthargakotor.Name = "txthargakotor"
        txthargakotor.Size = New Size(156, 23)
        txthargakotor.TabIndex = 9
        ' 
        ' txthargabersih
        ' 
        txthargabersih.Location = New Point(554, 387)
        txthargabersih.Name = "txthargabersih"
        txthargabersih.Size = New Size(152, 23)
        txthargabersih.TabIndex = 11
        ' 
        ' txtkodebarang
        ' 
        txtkodebarang.Location = New Point(393, 61)
        txtkodebarang.Name = "txtkodebarang"
        txtkodebarang.Size = New Size(154, 23)
        txtkodebarang.TabIndex = 12
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(292, 61)
        Label8.Name = "Label8"
        Label8.Size = New Size(74, 15)
        Label8.TabIndex = 0
        Label8.Text = "Kode Barang"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(292, 130)
        Label9.Name = "Label9"
        Label9.Size = New Size(67, 15)
        Label9.TabIndex = 0
        Label9.Text = "Jumlah Beli"
        ' 
        ' txtjumlahbeli
        ' 
        txtjumlahbeli.Location = New Point(393, 130)
        txtjumlahbeli.Name = "txtjumlahbeli"
        txtjumlahbeli.Size = New Size(156, 23)
        txtjumlahbeli.TabIndex = 13
        ' 
        ' txtjenis
        ' 
        txtjenis.Location = New Point(393, 98)
        txtjenis.Name = "txtjenis"
        txtjenis.Size = New Size(141, 23)
        txtjenis.TabIndex = 14
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(292, 101)
        Label10.Name = "Label10"
        Label10.Size = New Size(32, 15)
        Label10.TabIndex = 0
        Label10.Text = "Jenis"
        ' 
        ' txtsubtotal
        ' 
        txtsubtotal.Location = New Point(308, 347)
        txtsubtotal.Name = "txtsubtotal"
        txtsubtotal.Size = New Size(100, 23)
        txtsubtotal.TabIndex = 15
        ' 
        ' txttanggal
        ' 
        txttanggal.Location = New Point(579, 58)
        txttanggal.Name = "txttanggal"
        txttanggal.Size = New Size(200, 23)
        txttanggal.TabIndex = 16
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(588, 29)
        Label11.Name = "Label11"
        Label11.Size = New Size(51, 15)
        Label11.TabIndex = 0
        Label11.Text = "Tanggal "
        ' 
        ' txttotal
        ' 
        txttotal.Location = New Point(308, 392)
        txttotal.Name = "txttotal"
        txttotal.Size = New Size(100, 23)
        txttotal.TabIndex = 17
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(230, 350)
        Label12.Name = "Label12"
        Label12.Size = New Size(55, 15)
        Label12.TabIndex = 18
        Label12.Text = "Sub Total"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(236, 395)
        Label13.Name = "Label13"
        Label13.Size = New Size(32, 15)
        Label13.TabIndex = 18
        Label13.Text = "Total"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label13)
        Controls.Add(Label12)
        Controls.Add(txttotal)
        Controls.Add(txttanggal)
        Controls.Add(txtsubtotal)
        Controls.Add(txtjenis)
        Controls.Add(txtjumlahbeli)
        Controls.Add(txtkodebarang)
        Controls.Add(txthargabersih)
        Controls.Add(txthargakotor)
        Controls.Add(btnbatal)
        Controls.Add(btncetak)
        Controls.Add(btnsimpan)
        Controls.Add(dataGridView1)
        Controls.Add(txtfaktur)
        Controls.Add(txtpelanggan)
        Controls.Add(cbobarang)
        Controls.Add(cbopelanggan)
        Controls.Add(Label9)
        Controls.Add(Label10)
        Controls.Add(Label8)
        Controls.Add(Label11)
        Controls.Add(Label4)
        Controls.Add(Label7)
        Controls.Add(Label5)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        CType(dataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cbopelanggan As ComboBox
    Friend WithEvents cbobarang As ComboBox
    Friend WithEvents txtpelanggan As TextBox
    Friend WithEvents txtfaktur As TextBox
    Friend WithEvents dataGridView1 As DataGridView
    Friend WithEvents btnsimpan As Button
    Friend WithEvents btncetak As Button
    Friend WithEvents btnbatal As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txthargakotor As TextBox
    Friend WithEvents txthargabersih As TextBox
    Friend WithEvents txtkodebarang As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtjumlahbeli As TextBox
    Friend WithEvents txtjenis As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtsubtotal As TextBox
    Friend WithEvents txttanggal As DateTimePicker
    Friend WithEvents Label11 As Label
    Friend WithEvents txttotal As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents faktur_penjualan As DataGridViewTextBoxColumn
    Friend WithEvents kode_barang As DataGridViewTextBoxColumn
    Friend WithEvents harga_jual As DataGridViewTextBoxColumn
    Friend WithEvents jumlah As DataGridViewTextBoxColumn
    Friend WithEvents sub_total As DataGridViewTextBoxColumn
End Class
