<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WarehouseAdjustmentForm
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
        Me.TxtRecordID = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtTotalLoss = New System.Windows.Forms.Label()
        Me.TxtTotalGain = New System.Windows.Forms.Label()
        Me.LblTotalLoss = New System.Windows.Forms.Label()
        Me.lblTotalGain = New System.Windows.Forms.Label()
        Me.dgvItems = New System.Windows.Forms.DataGridView()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CmdRemoveFromGrid = New System.Windows.Forms.Button()
        Me.CboType = New System.Windows.Forms.ComboBox()
        Me.TxtAdjustHangers = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CmdAddToGrid = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtWarehouseName = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CmdOK = New System.Windows.Forms.Button()
        Me.TxtCurrentHangers = New System.Windows.Forms.TextBox()
        Me.CmdCancel = New System.Windows.Forms.Button()
        Me.CmdClear = New System.Windows.Forms.Button()
        Me.TxtWarehouseRef = New System.Windows.Forms.TextBox()
        Me.TxtReference = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtStockCode = New System.Windows.Forms.TextBox()
        CType(Me.dgvItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtRecordID
        '
        Me.TxtRecordID.Location = New System.Drawing.Point(890, 14)
        Me.TxtRecordID.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.TxtRecordID.Name = "TxtRecordID"
        Me.TxtRecordID.Size = New System.Drawing.Size(104, 26)
        Me.TxtRecordID.TabIndex = 97
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(754, 17)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 20)
        Me.Label6.TabIndex = 96
        Me.Label6.Text = "Record ID:"
        '
        'TxtTotalLoss
        '
        Me.TxtTotalLoss.AutoSize = True
        Me.TxtTotalLoss.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TxtTotalLoss.Location = New System.Drawing.Point(403, 586)
        Me.TxtTotalLoss.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.TxtTotalLoss.Name = "TxtTotalLoss"
        Me.TxtTotalLoss.Size = New System.Drawing.Size(29, 22)
        Me.TxtTotalLoss.TabIndex = 109
        Me.TxtTotalLoss.Text = "00"
        '
        'TxtTotalGain
        '
        Me.TxtTotalGain.AutoSize = True
        Me.TxtTotalGain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TxtTotalGain.Location = New System.Drawing.Point(176, 586)
        Me.TxtTotalGain.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.TxtTotalGain.Name = "TxtTotalGain"
        Me.TxtTotalGain.Size = New System.Drawing.Size(29, 22)
        Me.TxtTotalGain.TabIndex = 107
        Me.TxtTotalGain.Text = "00"
        '
        'LblTotalLoss
        '
        Me.LblTotalLoss.AutoSize = True
        Me.LblTotalLoss.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblTotalLoss.Location = New System.Drawing.Point(355, 557)
        Me.LblTotalLoss.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LblTotalLoss.Name = "LblTotalLoss"
        Me.LblTotalLoss.Size = New System.Drawing.Size(88, 22)
        Me.LblTotalLoss.TabIndex = 108
        Me.LblTotalLoss.Text = "Total Loss:"
        '
        'lblTotalGain
        '
        Me.lblTotalGain.AutoSize = True
        Me.lblTotalGain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalGain.Location = New System.Drawing.Point(147, 557)
        Me.lblTotalGain.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblTotalGain.Name = "lblTotalGain"
        Me.lblTotalGain.Size = New System.Drawing.Size(88, 22)
        Me.lblTotalGain.TabIndex = 106
        Me.lblTotalGain.Text = "Total Gain:"
        '
        'dgvItems
        '
        Me.dgvItems.AllowUserToAddRows = False
        Me.dgvItems.AllowUserToDeleteRows = False
        Me.dgvItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvItems.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.dgvItems.Location = New System.Drawing.Point(21, 203)
        Me.dgvItems.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.dgvItems.Name = "dgvItems"
        Me.dgvItems.RowHeadersWidth = 51
        Me.dgvItems.Size = New System.Drawing.Size(997, 348)
        Me.dgvItems.TabIndex = 111
        '
        'Column3
        '
        Me.Column3.HeaderText = "StockCode"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Movement Type"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Qty"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Value"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.Visible = False
        '
        'CmdRemoveFromGrid
        '
        Me.CmdRemoveFromGrid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdRemoveFromGrid.Location = New System.Drawing.Point(959, 123)
        Me.CmdRemoveFromGrid.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.CmdRemoveFromGrid.Name = "CmdRemoveFromGrid"
        Me.CmdRemoveFromGrid.Size = New System.Drawing.Size(56, 64)
        Me.CmdRemoveFromGrid.TabIndex = 91
        Me.CmdRemoveFromGrid.Text = "-"
        Me.CmdRemoveFromGrid.UseVisualStyleBackColor = True
        '
        'CboType
        '
        Me.CboType.AutoCompleteCustomSource.AddRange(New String() {"Gain", "Loss"})
        Me.CboType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboType.FormattingEnabled = True
        Me.CboType.Items.AddRange(New Object() {"Loss", "Gain"})
        Me.CboType.Location = New System.Drawing.Point(386, 153)
        Me.CboType.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.CboType.Name = "CboType"
        Me.CboType.Size = New System.Drawing.Size(212, 28)
        Me.CboType.TabIndex = 88
        '
        'TxtAdjustHangers
        '
        Me.TxtAdjustHangers.Location = New System.Drawing.Point(610, 153)
        Me.TxtAdjustHangers.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.TxtAdjustHangers.Name = "TxtAdjustHangers"
        Me.TxtAdjustHangers.Size = New System.Drawing.Size(268, 26)
        Me.TxtAdjustHangers.TabIndex = 89
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(615, 121)
        Me.Label8.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(122, 20)
        Me.Label8.TabIndex = 98
        Me.Label8.Text = "Adjustment Qty:"
        '
        'CmdAddToGrid
        '
        Me.CmdAddToGrid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdAddToGrid.Location = New System.Drawing.Point(890, 121)
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
        Me.Label7.Location = New System.Drawing.Point(386, 121)
        Me.Label7.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(132, 20)
        Me.Label7.TabIndex = 99
        Me.Label7.Text = "Adjustment Type:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(359, 65)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 20)
        Me.Label5.TabIndex = 104
        Me.Label5.Text = "Name:"
        '
        'TxtWarehouseName
        '
        Me.TxtWarehouseName.Enabled = False
        Me.TxtWarehouseName.Location = New System.Drawing.Point(453, 60)
        Me.TxtWarehouseName.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.TxtWarehouseName.Name = "TxtWarehouseName"
        Me.TxtWarehouseName.Size = New System.Drawing.Size(268, 26)
        Me.TxtWarehouseName.TabIndex = 105
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(106, 15)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(265, 26)
        Me.DateTimePicker1.TabIndex = 84
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(26, 17)
        Me.Label10.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 20)
        Me.Label10.TabIndex = 103
        Me.Label10.Text = "Date:"
        '
        'CmdOK
        '
        Me.CmdOK.Location = New System.Drawing.Point(576, 563)
        Me.CmdOK.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.CmdOK.Name = "CmdOK"
        Me.CmdOK.Size = New System.Drawing.Size(131, 44)
        Me.CmdOK.TabIndex = 92
        Me.CmdOK.Text = "Add"
        Me.CmdOK.UseVisualStyleBackColor = True
        '
        'TxtCurrentHangers
        '
        Me.TxtCurrentHangers.Location = New System.Drawing.Point(231, 153)
        Me.TxtCurrentHangers.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.TxtCurrentHangers.Name = "TxtCurrentHangers"
        Me.TxtCurrentHangers.Size = New System.Drawing.Size(140, 26)
        Me.TxtCurrentHangers.TabIndex = 110
        '
        'CmdCancel
        '
        Me.CmdCancel.Location = New System.Drawing.Point(876, 563)
        Me.CmdCancel.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.CmdCancel.Name = "CmdCancel"
        Me.CmdCancel.Size = New System.Drawing.Size(131, 44)
        Me.CmdCancel.TabIndex = 94
        Me.CmdCancel.Text = "Cancel"
        Me.CmdCancel.UseVisualStyleBackColor = True
        '
        'CmdClear
        '
        Me.CmdClear.Location = New System.Drawing.Point(732, 563)
        Me.CmdClear.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.CmdClear.Name = "CmdClear"
        Me.CmdClear.Size = New System.Drawing.Size(131, 44)
        Me.CmdClear.TabIndex = 93
        Me.CmdClear.Text = "Clear"
        Me.CmdClear.UseVisualStyleBackColor = True
        '
        'TxtWarehouseRef
        '
        Me.TxtWarehouseRef.Location = New System.Drawing.Point(215, 61)
        Me.TxtWarehouseRef.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.TxtWarehouseRef.MaxLength = 8
        Me.TxtWarehouseRef.Name = "TxtWarehouseRef"
        Me.TxtWarehouseRef.Size = New System.Drawing.Size(121, 26)
        Me.TxtWarehouseRef.TabIndex = 86
        '
        'TxtReference
        '
        Me.TxtReference.Location = New System.Drawing.Point(522, 14)
        Me.TxtReference.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.TxtReference.MaxLength = 50
        Me.TxtReference.Name = "TxtReference"
        Me.TxtReference.Size = New System.Drawing.Size(220, 26)
        Me.TxtReference.TabIndex = 85
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(386, 17)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 20)
        Me.Label1.TabIndex = 95
        Me.Label1.Text = "Reference:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 65)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 20)
        Me.Label2.TabIndex = 102
        Me.Label2.Text = "Warehouse Ref:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(242, 121)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 20)
        Me.Label4.TabIndex = 100
        Me.Label4.Text = "Current Qty:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 121)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 20)
        Me.Label3.TabIndex = 101
        Me.Label3.Text = "Stock Code:"
        '
        'TxtStockCode
        '
        Me.TxtStockCode.Location = New System.Drawing.Point(29, 153)
        Me.TxtStockCode.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.TxtStockCode.MaxLength = 30
        Me.TxtStockCode.Name = "TxtStockCode"
        Me.TxtStockCode.Size = New System.Drawing.Size(191, 26)
        Me.TxtStockCode.TabIndex = 87
        '
        'WarehouseAdjustmentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1035, 618)
        Me.Controls.Add(Me.TxtRecordID)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtTotalLoss)
        Me.Controls.Add(Me.TxtTotalGain)
        Me.Controls.Add(Me.LblTotalLoss)
        Me.Controls.Add(Me.lblTotalGain)
        Me.Controls.Add(Me.dgvItems)
        Me.Controls.Add(Me.CmdRemoveFromGrid)
        Me.Controls.Add(Me.CboType)
        Me.Controls.Add(Me.TxtAdjustHangers)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.CmdAddToGrid)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtWarehouseName)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.CmdOK)
        Me.Controls.Add(Me.TxtCurrentHangers)
        Me.Controls.Add(Me.CmdCancel)
        Me.Controls.Add(Me.CmdClear)
        Me.Controls.Add(Me.TxtWarehouseRef)
        Me.Controls.Add(Me.TxtReference)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtStockCode)
        Me.Name = "WarehouseAdjustmentForm"
        Me.Text = "Warehouse Adjustment"
        CType(Me.dgvItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtRecordID As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtTotalLoss As Label
    Friend WithEvents TxtTotalGain As Label
    Friend WithEvents LblTotalLoss As Label
    Friend WithEvents lblTotalGain As Label
    Friend WithEvents dgvItems As DataGridView
    Private WithEvents Column3 As DataGridViewTextBoxColumn
    Private WithEvents Column4 As DataGridViewTextBoxColumn
    Private WithEvents Column5 As DataGridViewTextBoxColumn
    Private WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents CmdRemoveFromGrid As Button
    Friend WithEvents CboType As ComboBox
    Friend WithEvents TxtAdjustHangers As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents CmdAddToGrid As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtWarehouseName As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label10 As Label
    Public WithEvents CmdOK As Button
    Friend WithEvents TxtCurrentHangers As TextBox
    Friend WithEvents CmdCancel As Button
    Friend WithEvents CmdClear As Button
    Friend WithEvents TxtWarehouseRef As TextBox
    Friend WithEvents TxtReference As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtStockCode As TextBox
End Class
