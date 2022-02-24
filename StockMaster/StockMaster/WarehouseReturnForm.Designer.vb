<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WarehouseReturnForm
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
        Me.txtTotalItems = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.txtTransferQty = New System.Windows.Forms.TextBox()
        Me.txtSupplierName = New System.Windows.Forms.TextBox()
        Me.txtSupplierRef = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtReturnID = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DtpDate = New System.Windows.Forms.DateTimePicker()
        Me.DgvRecords = New System.Windows.Forms.DataGridView()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtWarehouseName = New System.Windows.Forms.TextBox()
        Me.txtCurrentQty = New System.Windows.Forms.TextBox()
        Me.txtStockCode = New System.Windows.Forms.TextBox()
        Me.txtWarehouseRef = New System.Windows.Forms.TextBox()
        Me.txtReference = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdClearGrid = New System.Windows.Forms.Button()
        Me.cmdClear = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdOK = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        CType(Me.DgvRecords, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtTotalItems
        '
        Me.txtTotalItems.Location = New System.Drawing.Point(600, 418)
        Me.txtTotalItems.Margin = New System.Windows.Forms.Padding(11)
        Me.txtTotalItems.Name = "txtTotalItems"
        Me.txtTotalItems.Size = New System.Drawing.Size(208, 26)
        Me.txtTotalItems.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(459, 418)
        Me.Label10.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(92, 20)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Total Items:"
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(316, 78)
        Me.cmdAdd.Margin = New System.Windows.Forms.Padding(11)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(164, 54)
        Me.cmdAdd.TabIndex = 1
        Me.cmdAdd.Text = "Add"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'txtTransferQty
        '
        Me.txtTransferQty.Location = New System.Drawing.Point(131, 78)
        Me.txtTransferQty.Margin = New System.Windows.Forms.Padding(11)
        Me.txtTransferQty.Name = "txtTransferQty"
        Me.txtTransferQty.Size = New System.Drawing.Size(163, 26)
        Me.txtTransferQty.TabIndex = 0
        '
        'txtSupplierName
        '
        Me.txtSupplierName.Location = New System.Drawing.Point(424, 36)
        Me.txtSupplierName.Margin = New System.Windows.Forms.Padding(11)
        Me.txtSupplierName.Name = "txtSupplierName"
        Me.txtSupplierName.Size = New System.Drawing.Size(384, 26)
        Me.txtSupplierName.TabIndex = 7
        Me.txtSupplierName.TabStop = False
        '
        'txtSupplierRef
        '
        Me.txtSupplierRef.Location = New System.Drawing.Point(131, 33)
        Me.txtSupplierRef.Margin = New System.Windows.Forms.Padding(11)
        Me.txtSupplierRef.MaxLength = 8
        Me.txtSupplierRef.Name = "txtSupplierRef"
        Me.txtSupplierRef.Size = New System.Drawing.Size(224, 26)
        Me.txtSupplierRef.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 81)
        Me.Label8.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 20)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Transfer Qty:"
        '
        'txtReturnID
        '
        Me.txtReturnID.Enabled = False
        Me.txtReturnID.Location = New System.Drawing.Point(157, 35)
        Me.txtReturnID.Margin = New System.Windows.Forms.Padding(11)
        Me.txtReturnID.Name = "txtReturnID"
        Me.txtReturnID.Size = New System.Drawing.Size(162, 26)
        Me.txtReturnID.TabIndex = 14
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(60, 38)
        Me.Label11.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(75, 20)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "ReturnID"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(369, 35)
        Me.Label9.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 20)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Date:"
        '
        'DtpDate
        '
        Me.DtpDate.CustomFormat = "dd-MM-yyyy"
        Me.DtpDate.Location = New System.Drawing.Point(439, 35)
        Me.DtpDate.Margin = New System.Windows.Forms.Padding(11)
        Me.DtpDate.Name = "DtpDate"
        Me.DtpDate.Size = New System.Drawing.Size(369, 26)
        Me.DtpDate.TabIndex = 0
        Me.DtpDate.Value = New Date(2016, 2, 7, 0, 0, 0, 0)
        '
        'DgvRecords
        '
        Me.DgvRecords.AllowUserToAddRows = False
        Me.DgvRecords.AllowUserToDeleteRows = False
        Me.DgvRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvRecords.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column3, Me.Column4, Me.Column5})
        Me.DgvRecords.Location = New System.Drawing.Point(4, 154)
        Me.DgvRecords.Margin = New System.Windows.Forms.Padding(11)
        Me.DgvRecords.Name = "DgvRecords"
        Me.DgvRecords.RowHeadersWidth = 51
        Me.DgvRecords.Size = New System.Drawing.Size(804, 253)
        Me.DgvRecords.TabIndex = 5
        '
        'Column3
        '
        Me.Column3.HeaderText = "Stock Code"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 125
        '
        'Column4
        '
        Me.Column4.HeaderText = "Qty"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 125
        '
        'Column5
        '
        Me.Column5.HeaderText = "Value"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.Visible = False
        Me.Column5.Width = 125
        '
        'txtWarehouseName
        '
        Me.txtWarehouseName.Location = New System.Drawing.Point(439, 115)
        Me.txtWarehouseName.Margin = New System.Windows.Forms.Padding(11)
        Me.txtWarehouseName.Name = "txtWarehouseName"
        Me.txtWarehouseName.Size = New System.Drawing.Size(369, 26)
        Me.txtWarehouseName.TabIndex = 12
        Me.txtWarehouseName.TabStop = False
        '
        'txtCurrentQty
        '
        Me.txtCurrentQty.Location = New System.Drawing.Point(157, 211)
        Me.txtCurrentQty.Margin = New System.Windows.Forms.Padding(11)
        Me.txtCurrentQty.Name = "txtCurrentQty"
        Me.txtCurrentQty.Size = New System.Drawing.Size(88, 26)
        Me.txtCurrentQty.TabIndex = 5
        '
        'txtStockCode
        '
        Me.txtStockCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtStockCode.Location = New System.Drawing.Point(157, 163)
        Me.txtStockCode.Margin = New System.Windows.Forms.Padding(11)
        Me.txtStockCode.MaxLength = 30
        Me.txtStockCode.Name = "txtStockCode"
        Me.txtStockCode.Size = New System.Drawing.Size(364, 26)
        Me.txtStockCode.TabIndex = 4
        '
        'txtWarehouseRef
        '
        Me.txtWarehouseRef.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtWarehouseRef.Location = New System.Drawing.Point(157, 115)
        Me.txtWarehouseRef.Margin = New System.Windows.Forms.Padding(11)
        Me.txtWarehouseRef.MaxLength = 8
        Me.txtWarehouseRef.Name = "txtWarehouseRef"
        Me.txtWarehouseRef.Size = New System.Drawing.Size(183, 26)
        Me.txtWarehouseRef.TabIndex = 2
        '
        'txtReference
        '
        Me.txtReference.Location = New System.Drawing.Point(157, 73)
        Me.txtReference.Margin = New System.Windows.Forms.Padding(11)
        Me.txtReference.MaxLength = 50
        Me.txtReference.Name = "txtReference"
        Me.txtReference.Size = New System.Drawing.Size(305, 26)
        Me.txtReference.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(362, 121)
        Me.Label5.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 20)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(41, 211)
        Me.Label4.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Current Qty:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 163)
        Me.Label3.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Stock Code:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 121)
        Me.Label2.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Warehouse Ref:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(362, 39)
        Me.Label7.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 20)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 79)
        Me.Label1.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Reference:"
        '
        'cmdClearGrid
        '
        Me.cmdClearGrid.Location = New System.Drawing.Point(502, 78)
        Me.cmdClearGrid.Margin = New System.Windows.Forms.Padding(11)
        Me.cmdClearGrid.Name = "cmdClearGrid"
        Me.cmdClearGrid.Size = New System.Drawing.Size(168, 54)
        Me.cmdClearGrid.TabIndex = 2
        Me.cmdClearGrid.Text = "Delete"
        Me.cmdClearGrid.UseVisualStyleBackColor = True
        '
        'cmdClear
        '
        Me.cmdClear.Location = New System.Drawing.Point(673, 776)
        Me.cmdClear.Margin = New System.Windows.Forms.Padding(11)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(163, 43)
        Me.cmdClear.TabIndex = 26
        Me.cmdClear.Text = "Clear"
        Me.cmdClear.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 34)
        Me.Label6.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 20)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Supplier Ref:"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(1517, 652)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(11)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(168, 24)
        Me.CheckBox1.TabIndex = 21
        Me.CheckBox1.Text = "Return To Supplier"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(506, 776)
        Me.cmdCancel.Margin = New System.Windows.Forms.Padding(11)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(163, 43)
        Me.cmdCancel.TabIndex = 25
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cmdOK
        '
        Me.cmdOK.Location = New System.Drawing.Point(333, 776)
        Me.cmdOK.Margin = New System.Windows.Forms.Padding(11)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(163, 43)
        Me.cmdOK.TabIndex = 24
        Me.cmdOK.Text = "OK"
        Me.cmdOK.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtReturnID)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.DtpDate)
        Me.GroupBox1.Controls.Add(Me.txtWarehouseName)
        Me.GroupBox1.Controls.Add(Me.txtCurrentQty)
        Me.GroupBox1.Controls.Add(Me.txtStockCode)
        Me.GroupBox1.Controls.Add(Me.txtWarehouseRef)
        Me.GroupBox1.Controls.Add(Me.txtReference)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(20, 20)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(11)
        Me.GroupBox1.Size = New System.Drawing.Size(820, 259)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Current"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtTotalItems)
        Me.GroupBox2.Controls.Add(Me.cmdClearGrid)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.cmdAdd)
        Me.GroupBox2.Controls.Add(Me.txtTransferQty)
        Me.GroupBox2.Controls.Add(Me.txtSupplierName)
        Me.GroupBox2.Controls.Add(Me.txtSupplierRef)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.DgvRecords)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(20, 301)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(11)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(11)
        Me.GroupBox2.Size = New System.Drawing.Size(820, 462)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Return To:"
        '
        'WarehouseReturnForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(857, 826)
        Me.Controls.Add(Me.cmdClear)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "WarehouseReturnForm"
        Me.Text = "Warehouse Return"
        CType(Me.DgvRecords, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtTotalItems As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cmdAdd As Button
    Friend WithEvents txtTransferQty As TextBox
    Friend WithEvents txtSupplierName As TextBox
    Friend WithEvents txtSupplierRef As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtReturnID As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents DtpDate As DateTimePicker
    Friend WithEvents DgvRecords As DataGridView
    Private WithEvents Column3 As DataGridViewTextBoxColumn
    Private WithEvents Column4 As DataGridViewTextBoxColumn
    Private WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents txtWarehouseName As TextBox
    Friend WithEvents txtCurrentQty As TextBox
    Friend WithEvents txtStockCode As TextBox
    Friend WithEvents txtWarehouseRef As TextBox
    Friend WithEvents txtReference As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmdClearGrid As Button
    Friend WithEvents cmdClear As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents cmdCancel As Button
    Friend WithEvents cmdOK As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
End Class
