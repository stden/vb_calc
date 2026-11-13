<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.ZatrPprodTB = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.ZatrEdProdTB = New System.Windows.Forms.TextBox()
        Me.RezFinTB = New System.Windows.Forms.TextBox()
        Me.KreditTB = New System.Windows.Forms.TextBox()
        Me.NameTB = New System.Windows.Forms.TextBox()
        Me.Таблица = New System.Windows.Forms.DataGridView()
        Me.Объем = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Удельный_вес = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bettaTB = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PriseEdProdTB = New System.Windows.Forms.TextBox()
        Me.Расчёт = New System.Windows.Forms.Button()
        Me.V_Prod_N_TB = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Доход_TB = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Prib_TB = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.A0_TB = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.Таблица, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ZatrPprodTB
        '
        Me.ZatrPprodTB.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ZatrPprodTB.Location = New System.Drawing.Point(105, 220)
        Me.ZatrPprodTB.Name = "ZatrPprodTB"
        Me.ZatrPprodTB.Size = New System.Drawing.Size(128, 20)
        Me.ZatrPprodTB.TabIndex = 1
        Me.ZatrPprodTB.Text = "1"
        Me.ZatrPprodTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox2.Location = New System.Drawing.Point(105, 334)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(128, 20)
        Me.TextBox2.TabIndex = 2
        Me.TextBox2.Text = "1"
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ZatrEdProdTB
        '
        Me.ZatrEdProdTB.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ZatrEdProdTB.Location = New System.Drawing.Point(105, 360)
        Me.ZatrEdProdTB.Name = "ZatrEdProdTB"
        Me.ZatrEdProdTB.Size = New System.Drawing.Size(128, 20)
        Me.ZatrEdProdTB.TabIndex = 3
        Me.ZatrEdProdTB.Text = "1"
        Me.ZatrEdProdTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RezFinTB
        '
        Me.RezFinTB.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RezFinTB.Location = New System.Drawing.Point(506, 161)
        Me.RezFinTB.Name = "RezFinTB"
        Me.RezFinTB.Size = New System.Drawing.Size(128, 20)
        Me.RezFinTB.TabIndex = 4
        Me.RezFinTB.Text = "1000"
        Me.RezFinTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'KreditTB
        '
        Me.KreditTB.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.KreditTB.Location = New System.Drawing.Point(506, 229)
        Me.KreditTB.Name = "KreditTB"
        Me.KreditTB.Size = New System.Drawing.Size(128, 20)
        Me.KreditTB.TabIndex = 5
        Me.KreditTB.Text = "500"
        Me.KreditTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'NameTB
        '
        Me.NameTB.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NameTB.Location = New System.Drawing.Point(764, 82)
        Me.NameTB.Name = "NameTB"
        Me.NameTB.Size = New System.Drawing.Size(128, 20)
        Me.NameTB.TabIndex = 6
        Me.NameTB.Text = "Сапоги-скороходы"
        Me.NameTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Таблица
        '
        Me.Таблица.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Таблица.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Объем, Me.Удельный_вес})
        Me.Таблица.Location = New System.Drawing.Point(704, 293)
        Me.Таблица.Name = "Таблица"
        Me.Таблица.Size = New System.Drawing.Size(214, 150)
        Me.Таблица.TabIndex = 7
        '
        'Объем
        '
        Me.Объем.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Объем.HeaderText = "Объем"
        Me.Объем.Name = "Объем"
        Me.Объем.Width = 67
        '
        'Удельный_вес
        '
        Me.Удельный_вес.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Удельный_вес.HeaderText = "Удельный вес"
        Me.Удельный_вес.Name = "Удельный_вес"
        '
        'bettaTB
        '
        Me.bettaTB.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.bettaTB.Location = New System.Drawing.Point(764, 12)
        Me.bettaTB.Name = "bettaTB"
        Me.bettaTB.Size = New System.Drawing.Size(128, 20)
        Me.bettaTB.TabIndex = 8
        Me.bettaTB.Text = "13"
        Me.bettaTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(762, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 26)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Пpоцентная ставка " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "налога на пpибыль (в %)"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(774, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Название продукции"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(78, 383)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(165, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Затpаты на единицу пpодукции"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(774, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 26)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Рыночная цена" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " единицы пpодукции"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PriseEdProdTB
        '
        Me.PriseEdProdTB.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PriseEdProdTB.Location = New System.Drawing.Point(764, 132)
        Me.PriseEdProdTB.Name = "PriseEdProdTB"
        Me.PriseEdProdTB.Size = New System.Drawing.Size(128, 20)
        Me.PriseEdProdTB.TabIndex = 12
        Me.PriseEdProdTB.Text = "4"
        Me.PriseEdProdTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Расчёт
        '
        Me.Расчёт.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Расчёт.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Расчёт.Location = New System.Drawing.Point(276, 400)
        Me.Расчёт.Name = "Расчёт"
        Me.Расчёт.Size = New System.Drawing.Size(95, 43)
        Me.Расчёт.TabIndex = 14
        Me.Расчёт.Text = "Расчёт"
        Me.Расчёт.UseVisualStyleBackColor = False
        '
        'V_Prod_N_TB
        '
        Me.V_Prod_N_TB.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.V_Prod_N_TB.Location = New System.Drawing.Point(410, 34)
        Me.V_Prod_N_TB.Name = "V_Prod_N_TB"
        Me.V_Prod_N_TB.Size = New System.Drawing.Size(128, 20)
        Me.V_Prod_N_TB.TabIndex = 15
        Me.V_Prod_N_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(398, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Пpи имеющихся сpедствах возможный объем выпуска пpодукции составит "
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Доход_TB)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Prib_TB)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.V_Prod_N_TB)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox1.Location = New System.Drawing.Point(0, 476)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(918, 82)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Результаты"
        '
        'Доход_TB
        '
        Me.Доход_TB.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Доход_TB.Location = New System.Drawing.Point(410, 13)
        Me.Доход_TB.Name = "Доход_TB"
        Me.Доход_TB.Size = New System.Drawing.Size(128, 20)
        Me.Доход_TB.TabIndex = 19
        Me.Доход_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(292, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Доход за реализацию продукции предыдущих периодов"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Prib_TB
        '
        Me.Prib_TB.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Prib_TB.Location = New System.Drawing.Point(410, 57)
        Me.Prib_TB.Name = "Prib_TB"
        Me.Prib_TB.Size = New System.Drawing.Size(128, 20)
        Me.Prib_TB.TabIndex = 17
        Me.Prib_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Прибыль"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Calc.My.Resources.Resources.Схема
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(744, 463)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(761, 216)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(127, 39)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Удельный вес " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "реализации в текущем " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "месяце"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'A0_TB
        '
        Me.A0_TB.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.A0_TB.Location = New System.Drawing.Point(759, 193)
        Me.A0_TB.Name = "A0_TB"
        Me.A0_TB.Size = New System.Drawing.Size(128, 20)
        Me.A0_TB.TabIndex = 18
        Me.A0_TB.Text = "0,20"
        Me.A0_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(747, 277)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(136, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Реализация по периодам"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(918, 558)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.A0_TB)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Расчёт)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PriseEdProdTB)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bettaTB)
        Me.Controls.Add(Me.Таблица)
        Me.Controls.Add(Me.NameTB)
        Me.Controls.Add(Me.KreditTB)
        Me.Controls.Add(Me.RezFinTB)
        Me.Controls.Add(Me.ZatrEdProdTB)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.ZatrPprodTB)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "MainForm"
        Me.Text = "ПРОГРАММА РАСЧЕТА ОБЪЕМА ПРОИЗВОДСТВА       "
        CType(Me.Таблица, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ZatrPprodTB As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents ZatrEdProdTB As System.Windows.Forms.TextBox
    Friend WithEvents RezFinTB As System.Windows.Forms.TextBox
    Friend WithEvents KreditTB As System.Windows.Forms.TextBox
    Friend WithEvents NameTB As System.Windows.Forms.TextBox
    Friend WithEvents Таблица As System.Windows.Forms.DataGridView
    Friend WithEvents Объем As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Удельный_вес As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bettaTB As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PriseEdProdTB As System.Windows.Forms.TextBox
    Friend WithEvents Расчёт As System.Windows.Forms.Button
    Friend WithEvents V_Prod_N_TB As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Prib_TB As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents A0_TB As System.Windows.Forms.TextBox
    Friend WithEvents Доход_TB As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label

End Class
