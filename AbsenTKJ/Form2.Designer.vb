<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.TextBox_Idrf = New System.Windows.Forms.TextBox()
        Me.TextBox_Nis = New System.Windows.Forms.TextBox()
        Me.TextBox_NamaDepan = New System.Windows.Forms.TextBox()
        Me.TextBox_NamaBelakang = New System.Windows.Forms.TextBox()
        Me.ComboBox_Kelas = New System.Windows.Forms.ComboBox()
        Me.ComboBox_Jurusan = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button_Save = New System.Windows.Forms.Button()
        Me.Button_Close = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox_Idrf
        '
        Me.TextBox_Idrf.Location = New System.Drawing.Point(111, 44)
        Me.TextBox_Idrf.Name = "TextBox_Idrf"
        Me.TextBox_Idrf.Size = New System.Drawing.Size(101, 20)
        Me.TextBox_Idrf.TabIndex = 0
        '
        'TextBox_Nis
        '
        Me.TextBox_Nis.Location = New System.Drawing.Point(111, 75)
        Me.TextBox_Nis.Name = "TextBox_Nis"
        Me.TextBox_Nis.Size = New System.Drawing.Size(133, 20)
        Me.TextBox_Nis.TabIndex = 1
        '
        'TextBox_NamaDepan
        '
        Me.TextBox_NamaDepan.Location = New System.Drawing.Point(111, 112)
        Me.TextBox_NamaDepan.Name = "TextBox_NamaDepan"
        Me.TextBox_NamaDepan.Size = New System.Drawing.Size(133, 20)
        Me.TextBox_NamaDepan.TabIndex = 2
        '
        'TextBox_NamaBelakang
        '
        Me.TextBox_NamaBelakang.Location = New System.Drawing.Point(112, 149)
        Me.TextBox_NamaBelakang.Name = "TextBox_NamaBelakang"
        Me.TextBox_NamaBelakang.Size = New System.Drawing.Size(132, 20)
        Me.TextBox_NamaBelakang.TabIndex = 3
        '
        'ComboBox_Kelas
        '
        Me.ComboBox_Kelas.FormattingEnabled = True
        Me.ComboBox_Kelas.Items.AddRange(New Object() {"X", "XI", "XII"})
        Me.ComboBox_Kelas.Location = New System.Drawing.Point(111, 183)
        Me.ComboBox_Kelas.Name = "ComboBox_Kelas"
        Me.ComboBox_Kelas.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox_Kelas.TabIndex = 4
        '
        'ComboBox_Jurusan
        '
        Me.ComboBox_Jurusan.FormattingEnabled = True
        Me.ComboBox_Jurusan.Items.AddRange(New Object() {"TKJ", "TKR", "ACC", "ATP", "APS"})
        Me.ComboBox_Jurusan.Location = New System.Drawing.Point(112, 217)
        Me.ComboBox_Jurusan.Name = "ComboBox_Jurusan"
        Me.ComboBox_Jurusan.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox_Jurusan.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "NO RFID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Nama Belakang"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Nama Depan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "NIS"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 183)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Kelas"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(25, 220)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Jurusan"
        '
        'Button_Save
        '
        Me.Button_Save.Location = New System.Drawing.Point(56, 274)
        Me.Button_Save.Name = "Button_Save"
        Me.Button_Save.Size = New System.Drawing.Size(75, 23)
        Me.Button_Save.TabIndex = 12
        Me.Button_Save.Text = "Save"
        Me.Button_Save.UseVisualStyleBackColor = True
        '
        'Button_Close
        '
        Me.Button_Close.Location = New System.Drawing.Point(157, 274)
        Me.Button_Close.Name = "Button_Close"
        Me.Button_Close.Size = New System.Drawing.Size(75, 23)
        Me.Button_Close.TabIndex = 13
        Me.Button_Close.Text = "Close"
        Me.Button_Close.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 356)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button_Close)
        Me.Controls.Add(Me.Button_Save)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox_Jurusan)
        Me.Controls.Add(Me.ComboBox_Kelas)
        Me.Controls.Add(Me.TextBox_NamaBelakang)
        Me.Controls.Add(Me.TextBox_NamaDepan)
        Me.Controls.Add(Me.TextBox_Nis)
        Me.Controls.Add(Me.TextBox_Idrf)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Data"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox_Idrf As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Nis As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_NamaDepan As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_NamaBelakang As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox_Kelas As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox_Jurusan As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button_Save As System.Windows.Forms.Button
    Friend WithEvents Button_Close As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
End Class
