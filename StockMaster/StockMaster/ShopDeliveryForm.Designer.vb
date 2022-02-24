<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ShopDeliveryForm
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
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.DgvRecords = New System.Windows.Forms.DataGridView()
        Me.StockCodeDG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GarmentsDG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValueCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Deliverlabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cmdClear = New System.Windows.Forms.Button()
        Me.cmdClearForm = New System.Windows.Forms.Button()
        Me.txtStockCode = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.txtWarehouseRef = New System.Windows.Forms.TextBox()
        Me.cmdAddItem = New System.Windows.Forms.Button()
        Me.txtQtyHangers = New System.Windows.Forms.TextBox()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.DteDate = New System.Windows.Forms.DateTimePicker()
        Me.txtShopRef = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtShopName = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTotalGarments = New System.Windows.Forms.TextBox()
        Me.txtDelNoteNumber = New System.Windows.Forms.TextBox()
        Me.txtReference = New System.Windows.Forms.TextBox()
        Me.txtWarehouseName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.DgvRecords, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtQty
        '
        Me.txtQty.Enabled = False
        Me.txtQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQty.ForeColor = System.Drawing.Color.Red
        Me.txtQty.Location = New System.Drawing.Point(163, 318)
        Me.txtQty.Margin = New System.Windows.Forms.Padding(8, 10, 8, 10)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(225, 30)
        Me.txtQty.TabIndex = 104
        '
        'DgvRecords
        '
        Me.DgvRecords.AllowUserToAddRows = False
        Me.DgvRecords.AllowUserToDeleteRows = False
        Me.DgvRecords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvRecords.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StockCodeDG, Me.GarmentsDG, Me.ValueCol})
        Me.DgvRecords.Location = New System.Drawing.Point(21, 433)
        Me.DgvRecords.Margin = New System.Windows.Forms.Padding(8, 10, 8, 10)
        Me.DgvRecords.Name = "DgvRecords"
        Me.DgvRecords.RowHeadersWidth = 51
        Me.DgvRecords.Size = New System.Drawing.Size(703, 394)
        Me.DgvRecords.TabIndex = 115
        '
        'StockCodeDG
        '
        Me.StockCodeDG.HeaderText = "Stock Code"
        Me.StockCodeDG.MinimumWidth = 6
        Me.StockCodeDG.Name = "StockCodeDG"
        '
        'GarmentsDG
        '
        Me.GarmentsDG.HeaderText = "Garments"
        Me.GarmentsDG.MinimumWidth = 6
        Me.GarmentsDG.Name = "GarmentsDG"
        '
        'ValueCol
        '
        Me.ValueCol.HeaderText = "Value"
        Me.ValueCol.MinimumWidth = 6
        Me.ValueCol.Name = "ValueCol"
        Me.ValueCol.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(28, 318)
        Me.Label8.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(119, 20)
        Me.Label8.TabIndex = 106
        Me.Label8.Text = "Warehouse Qty"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.Deliverlabel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 955)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(5, 0, 48, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(776, 32)
        Me.StatusStrip1.TabIndex = 119
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(148, 25)
        Me.ToolStripStatusLabel1.Text = "Delivery Lines :    "
        '
        'Deliverlabel
        '
        Me.Deliverlabel.Name = "Deliverlabel"
        Me.Deliverlabel.Size = New System.Drawing.Size(180, 25)
        Me.Deliverlabel.Text = "ToolStripStatusLabel2"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label21.Location = New System.Drawing.Point(55, 278)
        Me.Label21.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(92, 20)
        Me.Label21.TabIndex = 107
        Me.Label21.Text = "Stock Code"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label22.Location = New System.Drawing.Point(55, 374)
        Me.Label22.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(92, 20)
        Me.Label22.TabIndex = 105
        Me.Label22.Text = "Delivery Qty"
        '
        'cmdClear
        '
        Me.cmdClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClear.Location = New System.Drawing.Point(476, 338)
        Me.cmdClear.Margin = New System.Windows.Forms.Padding(8, 10, 8, 10)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(56, 56)
        Me.cmdClear.TabIndex = 97
        Me.cmdClear.Text = "-"
        Me.cmdClear.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdClear.UseVisualStyleBackColor = True
        '
        'cmdClearForm
        '
        Me.cmdClearForm.Location = New System.Drawing.Point(498, 909)
        Me.cmdClearForm.Margin = New System.Windows.Forms.Padding(8, 10, 8, 10)
        Me.cmdClearForm.Name = "cmdClearForm"
        Me.cmdClearForm.Size = New System.Drawing.Size(105, 34)
        Me.cmdClearForm.TabIndex = 100
        Me.cmdClearForm.Text = "Clear"
        Me.cmdClearForm.UseVisualStyleBackColor = True
        '
        'txtStockCode
        '
        Me.txtStockCode.Location = New System.Drawing.Point(163, 272)
        Me.txtStockCode.Margin = New System.Windows.Forms.Padding(8, 10, 8, 10)
        Me.txtStockCode.MaxLength = 30
        Me.txtStockCode.Name = "txtStockCode"
        Me.txtStockCode.Size = New System.Drawing.Size(332, 26)
        Me.txtStockCode.TabIndex = 94
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label16.Location = New System.Drawing.Point(66, 95)
        Me.Label16.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(81, 20)
        Me.Label16.TabIndex = 111
        Me.Label16.Text = "Shop Ref:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(50, 137)
        Me.Label17.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(97, 20)
        Me.Label17.TabIndex = 110
        Me.Label17.Text = "Shop Name:"
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(377, 909)
        Me.cmdAdd.Margin = New System.Windows.Forms.Padding(8, 10, 8, 10)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(105, 34)
        Me.cmdAdd.TabIndex = 98
        Me.cmdAdd.Text = "Add"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'txtWarehouseRef
        '
        Me.txtWarehouseRef.Location = New System.Drawing.Point(163, 180)
        Me.txtWarehouseRef.Margin = New System.Windows.Forms.Padding(8, 10, 8, 10)
        Me.txtWarehouseRef.Name = "txtWarehouseRef"
        Me.txtWarehouseRef.Size = New System.Drawing.Size(184, 26)
        Me.txtWarehouseRef.TabIndex = 93
        '
        'cmdAddItem
        '
        Me.cmdAddItem.Location = New System.Drawing.Point(404, 338)
        Me.cmdAddItem.Margin = New System.Windows.Forms.Padding(8, 10, 8, 10)
        Me.cmdAddItem.Name = "cmdAddItem"
        Me.cmdAddItem.Size = New System.Drawing.Size(56, 56)
        Me.cmdAddItem.TabIndex = 96
        Me.cmdAddItem.Text = "+"
        Me.cmdAddItem.UseVisualStyleBackColor = True
        '
        'txtQtyHangers
        '
        Me.txtQtyHangers.Location = New System.Drawing.Point(163, 368)
        Me.txtQtyHangers.Margin = New System.Windows.Forms.Padding(8, 10, 8, 10)
        Me.txtQtyHangers.Name = "txtQtyHangers"
        Me.txtQtyHangers.Size = New System.Drawing.Size(225, 26)
        Me.txtQtyHangers.TabIndex = 95
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(619, 909)
        Me.cmdCancel.Margin = New System.Windows.Forms.Padding(8, 10, 8, 10)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(105, 34)
        Me.cmdCancel.TabIndex = 99
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'DteDate
        '
        Me.DteDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DteDate.Location = New System.Drawing.Point(163, 8)
        Me.DteDate.Margin = New System.Windows.Forms.Padding(8, 10, 8, 10)
        Me.DteDate.Name = "DteDate"
        Me.DteDate.Size = New System.Drawing.Size(380, 26)
        Me.DteDate.TabIndex = 90
        '
        'txtShopRef
        '
        Me.txtShopRef.Location = New System.Drawing.Point(163, 89)
        Me.txtShopRef.Margin = New System.Windows.Forms.Padding(8, 10, 8, 10)
        Me.txtShopRef.MaxLength = 8
        Me.txtShopRef.Name = "txtShopRef"
        Me.txtShopRef.Size = New System.Drawing.Size(193, 26)
        Me.txtShopRef.TabIndex = 92
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(195, 837)
        Me.Label4.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(182, 29)
        Me.Label4.TabIndex = 116
        Me.Label4.Text = "Delivery Total:"
        '
        'txtShopName
        '
        Me.txtShopName.Location = New System.Drawing.Point(163, 137)
        Me.txtShopName.Margin = New System.Windows.Forms.Padding(8, 10, 8, 10)
        Me.txtShopName.Name = "txtShopName"
        Me.txtShopName.Size = New System.Drawing.Size(593, 26)
        Me.txtShopName.TabIndex = 102
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label18.Location = New System.Drawing.Point(22, 186)
        Me.Label18.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(125, 20)
        Me.Label18.TabIndex = 109
        Me.Label18.Text = "Warehouse Ref:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 52)
        Me.Label3.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 20)
        Me.Label3.TabIndex = 112
        Me.Label3.Text = "Delivery Note No:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label2.Location = New System.Drawing.Point(40, 8)
        Me.Label2.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 20)
        Me.Label2.TabIndex = 113
        Me.Label2.Text = "Delivery Date:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(6, 233)
        Me.Label20.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(141, 20)
        Me.Label20.TabIndex = 108
        Me.Label20.Text = "Warehouse Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(559, 13)
        Me.Label1.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 20)
        Me.Label1.TabIndex = 114
        Me.Label1.Text = "Record No:"
        '
        'txtTotalGarments
        '
        Me.txtTotalGarments.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtTotalGarments.Location = New System.Drawing.Point(549, 844)
        Me.txtTotalGarments.Margin = New System.Windows.Forms.Padding(8, 10, 8, 10)
        Me.txtTotalGarments.Name = "txtTotalGarments"
        Me.txtTotalGarments.Size = New System.Drawing.Size(129, 26)
        Me.txtTotalGarments.TabIndex = 118
        '
        'txtDelNoteNumber
        '
        Me.txtDelNoteNumber.Location = New System.Drawing.Point(664, 10)
        Me.txtDelNoteNumber.Margin = New System.Windows.Forms.Padding(8, 10, 8, 10)
        Me.txtDelNoteNumber.Name = "txtDelNoteNumber"
        Me.txtDelNoteNumber.Size = New System.Drawing.Size(92, 26)
        Me.txtDelNoteNumber.TabIndex = 101
        '
        'txtReference
        '
        Me.txtReference.BackColor = System.Drawing.SystemColors.Window
        Me.txtReference.Location = New System.Drawing.Point(163, 46)
        Me.txtReference.Margin = New System.Windows.Forms.Padding(8, 10, 8, 10)
        Me.txtReference.MaxLength = 90
        Me.txtReference.Name = "txtReference"
        Me.txtReference.Size = New System.Drawing.Size(328, 26)
        Me.txtReference.TabIndex = 91
        '
        'txtWarehouseName
        '
        Me.txtWarehouseName.Location = New System.Drawing.Point(163, 226)
        Me.txtWarehouseName.Margin = New System.Windows.Forms.Padding(8, 10, 8, 10)
        Me.txtWarehouseName.Name = "txtWarehouseName"
        Me.txtWarehouseName.Size = New System.Drawing.Size(561, 26)
        Me.txtWarehouseName.TabIndex = 103
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(393, 844)
        Me.Label5.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 20)
        Me.Label5.TabIndex = 117
        Me.Label5.Text = "Total Garments:"
        '
        'ShopDeliveryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(776, 987)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.DgvRecords)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.cmdClear)
        Me.Controls.Add(Me.cmdClearForm)
        Me.Controls.Add(Me.txtStockCode)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.txtWarehouseRef)
        Me.Controls.Add(Me.cmdAddItem)
        Me.Controls.Add(Me.txtQtyHangers)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.DteDate)
        Me.Controls.Add(Me.txtShopRef)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtShopName)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTotalGarments)
        Me.Controls.Add(Me.txtDelNoteNumber)
        Me.Controls.Add(Me.txtReference)
        Me.Controls.Add(Me.txtWarehouseName)
        Me.Controls.Add(Me.Label5)
        Me.Name = "ShopDeliveryForm"
        Me.Text = "Shop Delivery"
        CType(Me.DgvRecords, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtQty As TextBox
    Friend WithEvents DgvRecords As DataGridView
    Friend WithEvents StockCodeDG As DataGridViewTextBoxColumn
    Friend WithEvents GarmentsDG As DataGridViewTextBoxColumn
    Friend WithEvents ValueCol As DataGridViewTextBoxColumn
    Friend WithEvents Label8 As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents Deliverlabel As ToolStripStatusLabel
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents cmdClear As Button
    Friend WithEvents cmdClearForm As Button
    Friend WithEvents txtStockCode As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents cmdAdd As Button
    Friend WithEvents txtWarehouseRef As TextBox
    Friend WithEvents cmdAddItem As Button
    Friend WithEvents txtQtyHangers As TextBox
    Friend WithEvents cmdCancel As Button
    Friend WithEvents DteDate As DateTimePicker
    Friend WithEvents txtShopRef As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtShopName As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTotalGarments As TextBox
    Friend WithEvents txtDelNoteNumber As TextBox
    Friend WithEvents txtReference As TextBox
    Friend WithEvents txtWarehouseName As TextBox
    Friend WithEvents Label5 As Label
End Class
