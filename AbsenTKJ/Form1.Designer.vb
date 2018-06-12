<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label_Id = New System.Windows.Forms.Label()
        Me.TextBox_Id = New System.Windows.Forms.TextBox()
        Me.Label_Nama = New System.Windows.Forms.Label()
        Me.Button_Conn = New System.Windows.Forms.Button()
        Me.Label_Jam = New System.Windows.Forms.Label()
        Me.Label_Tanggal = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label_Tanggal_Hidd = New System.Windows.Forms.Label()
        Me.Button_Simb_Ok = New System.Windows.Forms.Button()
        Me.Label_Jam_Wel = New System.Windows.Forms.Label()
        Me.Button_Simb_X = New System.Windows.Forms.Button()
        Me.Label_Welcome = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(12, 240)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID"
        '
        'Label_Id
        '
        Me.Label_Id.AutoSize = True
        Me.Label_Id.BackColor = System.Drawing.Color.Transparent
        Me.Label_Id.Location = New System.Drawing.Point(532, 225)
        Me.Label_Id.Name = "Label_Id"
        Me.Label_Id.Size = New System.Drawing.Size(47, 13)
        Me.Label_Id.TabIndex = 1
        Me.Label_Id.Text = "Label ID"
        '
        'TextBox_Id
        '
        Me.TextBox_Id.Location = New System.Drawing.Point(36, 237)
        Me.TextBox_Id.Name = "TextBox_Id"
        Me.TextBox_Id.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Id.TabIndex = 2
        '
        'Label_Nama
        '
        Me.Label_Nama.AutoSize = True
        Me.Label_Nama.BackColor = System.Drawing.Color.Transparent
        Me.Label_Nama.Font = New System.Drawing.Font("Modern No. 20", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Nama.Location = New System.Drawing.Point(254, 90)
        Me.Label_Nama.Name = "Label_Nama"
        Me.Label_Nama.Size = New System.Drawing.Size(107, 38)
        Me.Label_Nama.TabIndex = 3
        Me.Label_Nama.Text = "Name"
        '
        'Button_Conn
        '
        Me.Button_Conn.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Conn.Location = New System.Drawing.Point(625, 4)
        Me.Button_Conn.Name = "Button_Conn"
        Me.Button_Conn.Size = New System.Drawing.Size(19, 18)
        Me.Button_Conn.TabIndex = 4
        Me.Button_Conn.UseVisualStyleBackColor = True
        '
        'Label_Jam
        '
        Me.Label_Jam.AutoSize = True
        Me.Label_Jam.Location = New System.Drawing.Point(530, 56)
        Me.Label_Jam.Name = "Label_Jam"
        Me.Label_Jam.Size = New System.Drawing.Size(49, 13)
        Me.Label_Jam.TabIndex = 5
        Me.Label_Jam.Text = "00:00:00"
        '
        'Label_Tanggal
        '
        Me.Label_Tanggal.AutoSize = True
        Me.Label_Tanggal.BackColor = System.Drawing.Color.Transparent
        Me.Label_Tanggal.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Tanggal.Location = New System.Drawing.Point(517, 13)
        Me.Label_Tanggal.Name = "Label_Tanggal"
        Me.Label_Tanggal.Size = New System.Drawing.Size(104, 21)
        Me.Label_Tanggal.TabIndex = 6
        Me.Label_Tanggal.Text = "00-00-0000"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Label_Tanggal_Hidd
        '
        Me.Label_Tanggal_Hidd.AutoSize = True
        Me.Label_Tanggal_Hidd.Location = New System.Drawing.Point(520, 34)
        Me.Label_Tanggal_Hidd.Name = "Label_Tanggal_Hidd"
        Me.Label_Tanggal_Hidd.Size = New System.Drawing.Size(59, 13)
        Me.Label_Tanggal_Hidd.TabIndex = 7
        Me.Label_Tanggal_Hidd.Text = "Tgl Hidden"
        '
        'Button_Simb_Ok
        '
        Me.Button_Simb_Ok.Image = CType(resources.GetObject("Button_Simb_Ok.Image"), System.Drawing.Image)
        Me.Button_Simb_Ok.Location = New System.Drawing.Point(599, 212)
        Me.Button_Simb_Ok.Name = "Button_Simb_Ok"
        Me.Button_Simb_Ok.Size = New System.Drawing.Size(38, 38)
        Me.Button_Simb_Ok.TabIndex = 8
        Me.Button_Simb_Ok.UseVisualStyleBackColor = True
        '
        'Label_Jam_Wel
        '
        Me.Label_Jam_Wel.AutoSize = True
        Me.Label_Jam_Wel.BackColor = System.Drawing.Color.Transparent
        Me.Label_Jam_Wel.Font = New System.Drawing.Font("Modern No. 20", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Jam_Wel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label_Jam_Wel.Location = New System.Drawing.Point(242, 92)
        Me.Label_Jam_Wel.Name = "Label_Jam_Wel"
        Me.Label_Jam_Wel.Size = New System.Drawing.Size(143, 38)
        Me.Label_Jam_Wel.TabIndex = 9
        Me.Label_Jam_Wel.Text = "20:20:20"
        '
        'Button_Simb_X
        '
        Me.Button_Simb_X.Image = CType(resources.GetObject("Button_Simb_X.Image"), System.Drawing.Image)
        Me.Button_Simb_X.Location = New System.Drawing.Point(599, 212)
        Me.Button_Simb_X.Name = "Button_Simb_X"
        Me.Button_Simb_X.Size = New System.Drawing.Size(38, 38)
        Me.Button_Simb_X.TabIndex = 7
        Me.Button_Simb_X.UseVisualStyleBackColor = True
        '
        'Label_Welcome
        '
        Me.Label_Welcome.AutoSize = True
        Me.Label_Welcome.BackColor = System.Drawing.Color.Transparent
        Me.Label_Welcome.Font = New System.Drawing.Font("Oxygen", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Welcome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label_Welcome.Location = New System.Drawing.Point(234, 128)
        Me.Label_Welcome.Name = "Label_Welcome"
        Me.Label_Welcome.Size = New System.Drawing.Size(161, 41)
        Me.Label_Welcome.TabIndex = 10
        Me.Label_Welcome.Text = "Welcome"
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 10000
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(103, 108)
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(649, 262)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label_Welcome)
        Me.Controls.Add(Me.Button_Simb_Ok)
        Me.Controls.Add(Me.Button_Simb_X)
        Me.Controls.Add(Me.Label_Jam_Wel)
        Me.Controls.Add(Me.Label_Tanggal_Hidd)
        Me.Controls.Add(Me.Label_Tanggal)
        Me.Controls.Add(Me.Label_Jam)
        Me.Controls.Add(Me.Button_Conn)
        Me.Controls.Add(Me.Label_Nama)
        Me.Controls.Add(Me.TextBox_Id)
        Me.Controls.Add(Me.Label_Id)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Opacity = 0.8R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "My Absen"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label_Id As System.Windows.Forms.Label
    Friend WithEvents TextBox_Id As System.Windows.Forms.TextBox
    Friend WithEvents Label_Nama As System.Windows.Forms.Label
    Friend WithEvents Button_Conn As System.Windows.Forms.Button
    Friend WithEvents Label_Jam As System.Windows.Forms.Label
    Friend WithEvents Label_Tanggal As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label_Tanggal_Hidd As System.Windows.Forms.Label
    Friend WithEvents Button_Simb_Ok As System.Windows.Forms.Button
    Friend WithEvents Label_Jam_Wel As System.Windows.Forms.Label
    Friend WithEvents Button_Simb_X As System.Windows.Forms.Button
    Friend WithEvents Label_Welcome As System.Windows.Forms.Label
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
