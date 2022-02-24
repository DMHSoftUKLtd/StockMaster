<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ShopAdjustmentForm
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TxtSID = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTotalLoss = New System.Windows.Forms.TextBox()
        Me.txtTotalGain = New System.Windows.Forms.TextBox()
        Me.dgvItems = New System.Windows.Forms.DataGridView()
        Me.stockCodeCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TransFromQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TransToQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitPrices = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CmdDeleteFromGrid = New System.Windows.Forms.Button()
        Me.cboType = New System.Windows.Forms.ComboBox()
        Me.txtAdjustHangers = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CmdAddToGrid = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtShopName = New System.Windows.Forms.TextBox()
        Me.DtpDate = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CmdOK = New System.Windows.Forms.Button()
        Me.txtCurrentHangers = New System.Windows.Forms.TextBox()
        Me.CmdCancel = New System.Windows.Forms.Button()
        Me.CmdClear = New System.Windows.Forms.Button()
        Me.txtShopRef = New System.Windows.Forms.TextBox()
        Me.txtReference = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtStockCode = New System.Windows.Forms.TextBox()
        CType(Me.dgvItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtSID
        '
        Me.TxtSID.Location = New System.Drawing.Point(757, 15)
        Me.TxtSID.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.TxtSID.Name = "TxtSID"
        Me.TxtSID.Size = New System.Drawing.Size(147, 26)
        Me.TxtSID.TabIndex = 111
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(540, 15)
        Me.Label11.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(207, 26)
        Me.Label11.TabIndex = 110
        Me.Label11.Text = "Shop Adjustment ID"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(326, 671)
        Me.Label9.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(111, 26)
        Me.Label9.TabIndex = 99
        Me.Label9.Text = "Total Gain"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(515, 671)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 26)
        Me.Label6.TabIndex = 101
        Me.Label6.Text = "Total Loss"
        '
        'txtTotalLoss
        '
        Me.txtTotalLoss.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalLoss.Location = New System.Drawing.Point(525, 718)
        Me.txtTotalLoss.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txtTotalLoss.Name = "txtTotalLoss"
        Me.txtTotalLoss.Size = New System.Drawing.Size(104, 32)
        Me.txtTotalLoss.TabIndex = 102
        '
        'txtTotalGain
        '
        Me.txtTotalGain.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalGain.Location = New System.Drawing.Point(334, 718)
        Me.txtTotalGain.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txtTotalGain.Name = "txtTotalGain"
        Me.txtTotalGain.Size = New System.Drawing.Size(127, 32)
        Me.txtTotalGain.TabIndex = 100
        '
        'dgvItems
        '
        Me.dgvItems.AllowUserToAddRows = False
        Me.dgvItems.AllowUserToDeleteRows = False
        Me.dgvItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvItems.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.stockCodeCol, Me.TransFromQty, Me.TransToQty, Me.UnitPrices})
        Me.dgvItems.Location = New System.Drawing.Point(14, 296)
        Me.dgvItems.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.dgvItems.Name = "dgvItems"
        Me.dgvItems.RowHeadersWidth = 51
        Me.dgvItems.Size = New System.Drawing.Size(1067, 369)
        Me.dgvItems.TabIndex = 103
        '
        'stockCodeCol
        '
        Me.stockCodeCol.HeaderText = "Stock Code"
        Me.stockCodeCol.MinimumWidth = 6
        Me.stockCodeCol.Name = "stockCodeCol"
        '
        'TransFromQty
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.NullValue = Nothing
        Me.TransFromQty.DefaultCellStyle = DataGridViewCellStyle3
        Me.TransFromQty.HeaderText = "Adjustment Type"
        Me.TransFromQty.MinimumWidth = 6
        Me.TransFromQty.Name = "TransFromQty"
        '
        'TransToQty
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N0"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.TransToQty.DefaultCellStyle = DataGridViewCellStyle4
        Me.TransToQty.HeaderText = "Adjustment Qty"
        Me.TransToQty.MinimumWidth = 6
        Me.TransToQty.Name = "TransToQty"
        '
        'UnitPrices
        '
        Me.UnitPrices.HeaderText = "UnitPrices"
        Me.UnitPrices.MinimumWidth = 6
        Me.UnitPrices.Name = "UnitPrices"
        Me.UnitPrices.Visible = False
        '
        'CmdDeleteFromGrid
        '
        Me.CmdDeleteFromGrid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdDeleteFromGrid.Location = New System.Drawing.Point(868, 198)
        Me.CmdDeleteFromGrid.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.CmdDeleteFromGrid.Name = "CmdDeleteFromGrid"
        Me.CmdDeleteFromGrid.Size = New System.Drawing.Size(56, 64)
        Me.CmdDeleteFromGrid.TabIndex = 91
        Me.CmdDeleteFromGrid.Text = "-"
        Me.CmdDeleteFromGrid.UseVisualStyleBackColor = True
        '
        'cboType
        '
        Me.cboType.AutoCompleteCustomSource.AddRange(New String() {"Gain", "Loss"})
        Me.cboType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboType.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboType.FormattingEnabled = True
        Me.cboType.Items.AddRange(New Object() {"Loss", "Gain"})
        Me.cboType.Location = New System.Drawing.Point(357, 238)
        Me.cboType.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.cboType.Name = "cboType"
        Me.cboType.Size = New System.Drawing.Size(264, 34)
        Me.cboType.TabIndex = 88
        '
        'txtAdjustHangers
        '
        Me.txtAdjustHangers.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdjustHangers.Location = New System.Drawing.Point(631, 238)
        Me.txtAdjustHangers.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txtAdjustHangers.Name = "txtAdjustHangers"
        Me.txtAdjustHangers.Size = New System.Drawing.Size(116, 32)
        Me.txtAdjustHangers.TabIndex = 89
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(626, 198)
        Me.Label8.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(168, 26)
        Me.Label8.TabIndex = 98
        Me.Label8.Text = "Adjustment Qty:"
        '
        'CmdAddToGrid
        '
        Me.CmdAddToGrid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdAddToGrid.Location = New System.Drawing.Point(804, 198)
        Me.CmdAddToGrid.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.CmdAddToGrid.Name = "CmdAddToGrid"
        Me.CmdAddToGrid.Size = New System.Drawing.Size(56, 65)
        Me.CmdAddToGrid.TabIndex = 90
        Me.CmdAddToGrid.Text = "+"
        Me.CmdAddToGrid.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(352, 198)
        Me.Label7.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(181, 26)
        Me.Label7.TabIndex = 97
        Me.Label7.Text = "Adjustment Type:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(62, 145)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(134, 26)
        Me.Label5.TabIndex = 105
        Me.Label5.Text = "Shop Name:"
        '
        'txtShopName
        '
        Me.txtShopName.Enabled = False
        Me.txtShopName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtShopName.Location = New System.Drawing.Point(206, 145)
        Me.txtShopName.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txtShopName.Name = "txtShopName"
        Me.txtShopName.Size = New System.Drawing.Size(272, 32)
        Me.txtShopName.TabIndex = 106
        '
        'DtpDate
        '
        Me.DtpDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpDate.Location = New System.Drawing.Point(206, 9)
        Me.DtpDate.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.DtpDate.Name = "DtpDate"
        Me.DtpDate.Size = New System.Drawing.Size(324, 32)
        Me.DtpDate.TabIndex = 84
        Me.DtpDate.Value = New Date(2017, 9, 1, 0, 0, 0, 0)
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(14, 9)
        Me.Label10.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(182, 26)
        Me.Label10.TabIndex = 109
        Me.Label10.Text = "Transaction Date:"
        '
        'CmdOK
        '
        Me.CmdOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.CmdOK.Location = New System.Drawing.Point(700, 677)
        Me.CmdOK.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.CmdOK.Name = "CmdOK"
        Me.CmdOK.Size = New System.Drawing.Size(107, 64)
        Me.CmdOK.TabIndex = 92
        Me.CmdOK.Text = "Add"
        Me.CmdOK.UseVisualStyleBackColor = True
        '
        'txtCurrentHangers
        '
        Me.txtCurrentHangers.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCurrentHangers.Location = New System.Drawing.Point(217, 238)
        Me.txtCurrentHangers.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txtCurrentHangers.Name = "txtCurrentHangers"
        Me.txtCurrentHangers.Size = New System.Drawing.Size(125, 32)
        Me.txtCurrentHangers.TabIndex = 95
        '
        'CmdCancel
        '
        Me.CmdCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.CmdCancel.Location = New System.Drawing.Point(939, 677)
        Me.CmdCancel.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.CmdCancel.Name = "CmdCancel"
        Me.CmdCancel.Size = New System.Drawing.Size(152, 64)
        Me.CmdCancel.TabIndex = 94
        Me.CmdCancel.Text = "Cancel"
        Me.CmdCancel.UseVisualStyleBackColor = True
        '
        'CmdClear
        '
        Me.CmdClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.CmdClear.Location = New System.Drawing.Point(817, 677)
        Me.CmdClear.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.CmdClear.Name = "CmdClear"
        Me.CmdClear.Size = New System.Drawing.Size(107, 64)
        Me.CmdClear.TabIndex = 93
        Me.CmdClear.Text = "Clear"
        Me.CmdClear.UseVisualStyleBackColor = True
        '
        'txtShopRef
        '
        Me.txtShopRef.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtShopRef.Location = New System.Drawing.Point(206, 101)
        Me.txtShopRef.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txtShopRef.MaxLength = 8
        Me.txtShopRef.Name = "txtShopRef"
        Me.txtShopRef.Size = New System.Drawing.Size(112, 32)
        Me.txtShopRef.TabIndex = 86
        '
        'txtReference
        '
        Me.txtReference.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReference.Location = New System.Drawing.Point(206, 57)
        Me.txtReference.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txtReference.MaxLength = 50
        Me.txtReference.Name = "txtReference"
        Me.txtReference.Size = New System.Drawing.Size(240, 32)
        Me.txtReference.TabIndex = 85
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(78, 57)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 26)
        Me.Label1.TabIndex = 108
        Me.Label1.Text = "Reference:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(87, 101)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 26)
        Me.Label2.TabIndex = 107
        Me.Label2.Text = "Shop Ref:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(212, 198)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 26)
        Me.Label4.TabIndex = 96
        Me.Label4.Text = "Current Qty:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 198)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 26)
        Me.Label3.TabIndex = 104
        Me.Label3.Text = "Stock Code:"
        '
        'txtStockCode
        '
        Me.txtStockCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStockCode.Location = New System.Drawing.Point(14, 238)
        Me.txtStockCode.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txtStockCode.MaxLength = 30
        Me.txtStockCode.Name = "txtStockCode"
        Me.txtStockCode.Size = New System.Drawing.Size(192, 32)
        Me.txtStockCode.TabIndex = 87
        '
        'ShopAdjustmentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1103, 768)
        Me.Controls.Add(Me.TxtSID)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtTotalLoss)
        Me.Controls.Add(Me.txtTotalGain)
        Me.Controls.Add(Me.dgvItems)
        Me.Controls.Add(Me.CmdDeleteFromGrid)
        Me.Controls.Add(Me.cboType)
        Me.Controls.Add(Me.txtAdjustHangers)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.CmdAddToGrid)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtShopName)
        Me.Controls.Add(Me.DtpDate)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.CmdOK)
        Me.Controls.Add(Me.txtCurrentHangers)
        Me.Controls.Add(Me.CmdCancel)
        Me.Controls.Add(Me.CmdClear)
        Me.Controls.Add(Me.txtShopRef)
        Me.Controls.Add(Me.txtReference)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtStockCode)
        Me.Name = "ShopAdjustmentForm"
        Me.Text = "Shop Adjustment"
        CType(Me.dgvItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtSID As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtTotalLoss As TextBox
    Friend WithEvents txtTotalGain As TextBox
    Friend WithEvents dgvItems As DataGridView
    Private WithEvents stockCodeCol As DataGridViewTextBoxColumn
    Private WithEvents TransFromQty As DataGridViewTextBoxColumn
    Private WithEvents TransToQty As DataGridViewTextBoxColumn
    Private WithEvents UnitPrices As DataGridViewTextBoxColumn
    Friend WithEvents CmdDeleteFromGrid As Button
    Friend WithEvents cboType As ComboBox
    Friend WithEvents txtAdjustHangers As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents CmdAddToGrid As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtShopName As TextBox
    Friend WithEvents DtpDate As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents CmdOK As Button
    Friend WithEvents txtCurrentHangers As TextBox
    Friend WithEvents CmdCancel As Button
    Friend WithEvents CmdClear As Button
    Friend WithEvents txtShopRef As TextBox
    Friend WithEvents txtReference As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtStockCode As TextBox
End Class
