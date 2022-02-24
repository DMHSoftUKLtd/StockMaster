<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WarehouseTransferForm
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
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.label14 = New System.Windows.Forms.Label()
        Me.label15 = New System.Windows.Forms.Label()
        Me.label16 = New System.Windows.Forms.Label()
        Me.TxtOutHangers = New System.Windows.Forms.TextBox()
        Me.TxtOutBoxes = New System.Windows.Forms.TextBox()
        Me.TxtOutGarments = New System.Windows.Forms.TextBox()
        Me.TxtQtyToTransfer = New System.Windows.Forms.TextBox()
        Me.label17 = New System.Windows.Forms.Label()
        Me.label11 = New System.Windows.Forms.Label()
        Me.label12 = New System.Windows.Forms.Label()
        Me.label13 = New System.Windows.Forms.Label()
        Me.TxtToQtyHangers = New System.Windows.Forms.TextBox()
        Me.TxtToQtyBoxes = New System.Windows.Forms.TextBox()
        Me.TxtToQtyGarments = New System.Windows.Forms.TextBox()
        Me.TxtCurrQtyHangers = New System.Windows.Forms.TextBox()
        Me.TxtCurrQtyBoxes = New System.Windows.Forms.TextBox()
        Me.TxtCurrQtyGarments = New System.Windows.Forms.TextBox()
        Me.label10 = New System.Windows.Forms.Label()
        Me.label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CmdDeleteFromGrid = New System.Windows.Forms.Button()
        Me.TxtInHangers = New System.Windows.Forms.TextBox()
        Me.txtToWarehouseName = New System.Windows.Forms.TextBox()
        Me.TxtToWarehouseRef = New System.Windows.Forms.TextBox()
        Me.txtFromWarehouseName = New System.Windows.Forms.TextBox()
        Me.TxtTFNote = New System.Windows.Forms.TextBox()
        Me.TxtFromWarehouseRef = New System.Windows.Forms.TextBox()
        Me.TxtTransferID = New System.Windows.Forms.TextBox()
        Me.DgvRecords = New System.Windows.Forms.DataGridView()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CmdAddToGrid = New System.Windows.Forms.Button()
        Me.TxtStockCode = New System.Windows.Forms.TextBox()
        Me.CmdClear = New System.Windows.Forms.Button()
        Me.CmdOK = New System.Windows.Forms.Button()
        Me.CmdCancel = New System.Windows.Forms.Button()
        Me.DtpDate = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.DgvRecords, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column3.Frozen = True
        Me.Column3.HeaderText = "Current Qty Hangers"
        Me.Column3.MinimumWidth = 8
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 120
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column1.Frozen = True
        Me.Column1.HeaderText = "Current Qty Garments"
        Me.Column1.MinimumWidth = 8
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 120
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column5.FillWeight = 162.2788!
        Me.Column5.Frozen = True
        Me.Column5.HeaderText = "Stock Code"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 160
        '
        'Column8
        '
        Me.Column8.HeaderText = "Qty Hanger In"
        Me.Column8.MinimumWidth = 8
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 150
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column2.Frozen = True
        Me.Column2.HeaderText = "Current Qty Boxes"
        Me.Column2.MinimumWidth = 8
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 150
        '
        'label14
        '
        Me.label14.AutoSize = True
        Me.label14.Location = New System.Drawing.Point(947, 217)
        Me.label14.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.label14.Name = "label14"
        Me.label14.Size = New System.Drawing.Size(137, 20)
        Me.label14.TabIndex = 152
        Me.label14.Text = "Total Qty Hangers"
        '
        'label15
        '
        Me.label15.AutoSize = True
        Me.label15.Location = New System.Drawing.Point(964, 169)
        Me.label15.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.label15.Name = "label15"
        Me.label15.Size = New System.Drawing.Size(120, 20)
        Me.label15.TabIndex = 151
        Me.label15.Text = "Total Qty Boxes"
        '
        'label16
        '
        Me.label16.AutoSize = True
        Me.label16.Location = New System.Drawing.Point(937, 117)
        Me.label16.Margin = New System.Windows.Forms.Padding(12, 0, 12, 0)
        Me.label16.Name = "label16"
        Me.label16.Size = New System.Drawing.Size(147, 20)
        Me.label16.TabIndex = 150
        Me.label16.Text = "Total Qty Garments"
        '
        'TxtOutHangers
        '
        Me.TxtOutHangers.Location = New System.Drawing.Point(1094, 218)
        Me.TxtOutHangers.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.TxtOutHangers.Name = "TxtOutHangers"
        Me.TxtOutHangers.Size = New System.Drawing.Size(79, 26)
        Me.TxtOutHangers.TabIndex = 149
        '
        'TxtOutBoxes
        '
        Me.TxtOutBoxes.Location = New System.Drawing.Point(1094, 166)
        Me.TxtOutBoxes.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.TxtOutBoxes.Name = "TxtOutBoxes"
        Me.TxtOutBoxes.Size = New System.Drawing.Size(79, 26)
        Me.TxtOutBoxes.TabIndex = 148
        '
        'TxtOutGarments
        '
        Me.TxtOutGarments.Location = New System.Drawing.Point(1094, 114)
        Me.TxtOutGarments.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.TxtOutGarments.Name = "TxtOutGarments"
        Me.TxtOutGarments.Size = New System.Drawing.Size(79, 26)
        Me.TxtOutGarments.TabIndex = 147
        '
        'TxtQtyToTransfer
        '
        Me.TxtQtyToTransfer.Location = New System.Drawing.Point(632, 343)
        Me.TxtQtyToTransfer.Margin = New System.Windows.Forms.Padding(12, 11, 12, 11)
        Me.TxtQtyToTransfer.Name = "TxtQtyToTransfer"
        Me.TxtQtyToTransfer.Size = New System.Drawing.Size(96, 26)
        Me.TxtQtyToTransfer.TabIndex = 145
        '
        'label17
        '
        Me.label17.AutoSize = True
        Me.label17.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.label17.Location = New System.Drawing.Point(1008, 294)
        Me.label17.Margin = New System.Windows.Forms.Padding(12, 0, 12, 0)
        Me.label17.Name = "label17"
        Me.label17.Size = New System.Drawing.Size(76, 20)
        Me.label17.TabIndex = 146
        Me.label17.Text = "Total Qty:"
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.Location = New System.Drawing.Point(333, 346)
        Me.label11.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(161, 20)
        Me.label11.TabIndex = 144
        Me.label11.Text = "Transfer Qty Hangers"
        '
        'label12
        '
        Me.label12.AutoSize = True
        Me.label12.Location = New System.Drawing.Point(350, 306)
        Me.label12.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(144, 20)
        Me.label12.TabIndex = 143
        Me.label12.Text = "Transfer Qty Boxes"
        '
        'label13
        '
        Me.label13.AutoSize = True
        Me.label13.Location = New System.Drawing.Point(323, 267)
        Me.label13.Margin = New System.Windows.Forms.Padding(12, 0, 12, 0)
        Me.label13.Name = "label13"
        Me.label13.Size = New System.Drawing.Size(171, 20)
        Me.label13.TabIndex = 142
        Me.label13.Text = "Transfer Qty Garments"
        '
        'TxtToQtyHangers
        '
        Me.TxtToQtyHangers.Location = New System.Drawing.Point(511, 343)
        Me.TxtToQtyHangers.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.TxtToQtyHangers.Name = "TxtToQtyHangers"
        Me.TxtToQtyHangers.Size = New System.Drawing.Size(100, 26)
        Me.TxtToQtyHangers.TabIndex = 141
        '
        'TxtToQtyBoxes
        '
        Me.TxtToQtyBoxes.Location = New System.Drawing.Point(511, 303)
        Me.TxtToQtyBoxes.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.TxtToQtyBoxes.Name = "TxtToQtyBoxes"
        Me.TxtToQtyBoxes.Size = New System.Drawing.Size(100, 26)
        Me.TxtToQtyBoxes.TabIndex = 140
        '
        'TxtToQtyGarments
        '
        Me.TxtToQtyGarments.Location = New System.Drawing.Point(511, 261)
        Me.TxtToQtyGarments.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.TxtToQtyGarments.Name = "TxtToQtyGarments"
        Me.TxtToQtyGarments.Size = New System.Drawing.Size(100, 26)
        Me.TxtToQtyGarments.TabIndex = 139
        '
        'TxtCurrQtyHangers
        '
        Me.TxtCurrQtyHangers.Location = New System.Drawing.Point(210, 345)
        Me.TxtCurrQtyHangers.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.TxtCurrQtyHangers.Name = "TxtCurrQtyHangers"
        Me.TxtCurrQtyHangers.Size = New System.Drawing.Size(95, 26)
        Me.TxtCurrQtyHangers.TabIndex = 138
        '
        'TxtCurrQtyBoxes
        '
        Me.TxtCurrQtyBoxes.Location = New System.Drawing.Point(210, 303)
        Me.TxtCurrQtyBoxes.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.TxtCurrQtyBoxes.Name = "TxtCurrQtyBoxes"
        Me.TxtCurrQtyBoxes.Size = New System.Drawing.Size(95, 26)
        Me.TxtCurrQtyBoxes.TabIndex = 137
        '
        'TxtCurrQtyGarments
        '
        Me.TxtCurrQtyGarments.Location = New System.Drawing.Point(210, 258)
        Me.TxtCurrQtyGarments.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.TxtCurrQtyGarments.Name = "TxtCurrQtyGarments"
        Me.TxtCurrQtyGarments.Size = New System.Drawing.Size(95, 26)
        Me.TxtCurrQtyGarments.TabIndex = 136
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Location = New System.Drawing.Point(31, 345)
        Me.label10.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(155, 20)
        Me.label10.TabIndex = 135
        Me.label10.Text = "Current Qty Hangers"
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Location = New System.Drawing.Point(48, 306)
        Me.label8.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(138, 20)
        Me.label8.TabIndex = 134
        Me.label8.Text = "Current Qty Boxes"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(670, 30)
        Me.Label9.Margin = New System.Windows.Forms.Padding(12, 0, 12, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(121, 20)
        Me.Label9.TabIndex = 132
        Me.Label9.Text = "Record Number"
        '
        'CmdDeleteFromGrid
        '
        Me.CmdDeleteFromGrid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdDeleteFromGrid.Location = New System.Drawing.Point(840, 317)
        Me.CmdDeleteFromGrid.Margin = New System.Windows.Forms.Padding(12, 11, 12, 11)
        Me.CmdDeleteFromGrid.Name = "CmdDeleteFromGrid"
        Me.CmdDeleteFromGrid.Size = New System.Drawing.Size(81, 48)
        Me.CmdDeleteFromGrid.TabIndex = 117
        Me.CmdDeleteFromGrid.Text = "-"
        Me.CmdDeleteFromGrid.UseVisualStyleBackColor = True
        '
        'TxtInHangers
        '
        Me.TxtInHangers.Location = New System.Drawing.Point(1094, 288)
        Me.TxtInHangers.Margin = New System.Windows.Forms.Padding(12, 11, 12, 11)
        Me.TxtInHangers.Name = "TxtInHangers"
        Me.TxtInHangers.Size = New System.Drawing.Size(79, 26)
        Me.TxtInHangers.TabIndex = 124
        '
        'txtToWarehouseName
        '
        Me.txtToWarehouseName.Location = New System.Drawing.Point(430, 160)
        Me.txtToWarehouseName.Margin = New System.Windows.Forms.Padding(12, 11, 12, 11)
        Me.txtToWarehouseName.Name = "txtToWarehouseName"
        Me.txtToWarehouseName.Size = New System.Drawing.Size(460, 26)
        Me.txtToWarehouseName.TabIndex = 123
        Me.txtToWarehouseName.TabStop = False
        '
        'TxtToWarehouseRef
        '
        Me.TxtToWarehouseRef.Location = New System.Drawing.Point(210, 160)
        Me.TxtToWarehouseRef.Margin = New System.Windows.Forms.Padding(12, 11, 12, 11)
        Me.TxtToWarehouseRef.MaxLength = 8
        Me.TxtToWarehouseRef.Name = "TxtToWarehouseRef"
        Me.TxtToWarehouseRef.Size = New System.Drawing.Size(196, 26)
        Me.TxtToWarehouseRef.TabIndex = 114
        '
        'txtFromWarehouseName
        '
        Me.txtFromWarehouseName.Location = New System.Drawing.Point(430, 117)
        Me.txtFromWarehouseName.Margin = New System.Windows.Forms.Padding(12, 11, 12, 11)
        Me.txtFromWarehouseName.Name = "txtFromWarehouseName"
        Me.txtFromWarehouseName.Size = New System.Drawing.Size(460, 26)
        Me.txtFromWarehouseName.TabIndex = 122
        Me.txtFromWarehouseName.TabStop = False
        '
        'TxtTFNote
        '
        Me.TxtTFNote.Location = New System.Drawing.Point(210, 72)
        Me.TxtTFNote.Margin = New System.Windows.Forms.Padding(12, 11, 12, 11)
        Me.TxtTFNote.MaxLength = 30
        Me.TxtTFNote.Name = "TxtTFNote"
        Me.TxtTFNote.Size = New System.Drawing.Size(436, 26)
        Me.TxtTFNote.TabIndex = 112
        '
        'TxtFromWarehouseRef
        '
        Me.TxtFromWarehouseRef.Location = New System.Drawing.Point(210, 117)
        Me.TxtFromWarehouseRef.Margin = New System.Windows.Forms.Padding(12, 11, 12, 11)
        Me.TxtFromWarehouseRef.MaxLength = 8
        Me.TxtFromWarehouseRef.Name = "TxtFromWarehouseRef"
        Me.TxtFromWarehouseRef.Size = New System.Drawing.Size(196, 26)
        Me.TxtFromWarehouseRef.TabIndex = 113
        '
        'TxtTransferID
        '
        Me.TxtTransferID.Location = New System.Drawing.Point(815, 27)
        Me.TxtTransferID.Margin = New System.Windows.Forms.Padding(12, 11, 12, 11)
        Me.TxtTransferID.Name = "TxtTransferID"
        Me.TxtTransferID.Size = New System.Drawing.Size(132, 26)
        Me.TxtTransferID.TabIndex = 121
        '
        'DgvRecords
        '
        Me.DgvRecords.AllowUserToAddRows = False
        Me.DgvRecords.AllowUserToDeleteRows = False
        Me.DgvRecords.AllowUserToResizeColumns = False
        Me.DgvRecords.ColumnHeadersHeight = 29
        Me.DgvRecords.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column5, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column6, Me.Column7, Me.Column8})
        Me.DgvRecords.Location = New System.Drawing.Point(21, 391)
        Me.DgvRecords.Margin = New System.Windows.Forms.Padding(12, 11, 12, 11)
        Me.DgvRecords.Name = "DgvRecords"
        Me.DgvRecords.RowHeadersWidth = 51
        Me.DgvRecords.Size = New System.Drawing.Size(1210, 350)
        Me.DgvRecords.TabIndex = 133
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column4.Frozen = True
        Me.Column4.HeaderText = "Qty Garment Out"
        Me.Column4.MinimumWidth = 8
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 150
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column6.Frozen = True
        Me.Column6.HeaderText = "Qty Boxes Out"
        Me.Column6.MinimumWidth = 8
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 150
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column7.Frozen = True
        Me.Column7.HeaderText = "Qty Hangers Out"
        Me.Column7.MinimumWidth = 8
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 150
        '
        'CmdAddToGrid
        '
        Me.CmdAddToGrid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdAddToGrid.Location = New System.Drawing.Point(752, 317)
        Me.CmdAddToGrid.Margin = New System.Windows.Forms.Padding(12, 11, 12, 11)
        Me.CmdAddToGrid.Name = "CmdAddToGrid"
        Me.CmdAddToGrid.Size = New System.Drawing.Size(81, 48)
        Me.CmdAddToGrid.TabIndex = 116
        Me.CmdAddToGrid.Text = "+"
        Me.CmdAddToGrid.UseVisualStyleBackColor = True
        '
        'TxtStockCode
        '
        Me.TxtStockCode.Location = New System.Drawing.Point(210, 223)
        Me.TxtStockCode.Margin = New System.Windows.Forms.Padding(12, 11, 12, 11)
        Me.TxtStockCode.MaxLength = 30
        Me.TxtStockCode.Name = "TxtStockCode"
        Me.TxtStockCode.Size = New System.Drawing.Size(401, 26)
        Me.TxtStockCode.TabIndex = 115
        '
        'CmdClear
        '
        Me.CmdClear.Location = New System.Drawing.Point(1111, 763)
        Me.CmdClear.Margin = New System.Windows.Forms.Padding(12, 11, 12, 11)
        Me.CmdClear.Name = "CmdClear"
        Me.CmdClear.Size = New System.Drawing.Size(120, 36)
        Me.CmdClear.TabIndex = 120
        Me.CmdClear.Text = "Clear"
        Me.CmdClear.UseVisualStyleBackColor = True
        '
        'CmdOK
        '
        Me.CmdOK.Location = New System.Drawing.Point(854, 763)
        Me.CmdOK.Margin = New System.Windows.Forms.Padding(12, 11, 12, 11)
        Me.CmdOK.Name = "CmdOK"
        Me.CmdOK.Size = New System.Drawing.Size(125, 36)
        Me.CmdOK.TabIndex = 118
        Me.CmdOK.Text = "Ok"
        Me.CmdOK.UseVisualStyleBackColor = True
        '
        'CmdCancel
        '
        Me.CmdCancel.Location = New System.Drawing.Point(991, 763)
        Me.CmdCancel.Margin = New System.Windows.Forms.Padding(12, 11, 12, 11)
        Me.CmdCancel.Name = "CmdCancel"
        Me.CmdCancel.Size = New System.Drawing.Size(114, 36)
        Me.CmdCancel.TabIndex = 119
        Me.CmdCancel.Text = "Cancel"
        Me.CmdCancel.UseVisualStyleBackColor = True
        '
        'DtpDate
        '
        Me.DtpDate.Location = New System.Drawing.Point(210, 27)
        Me.DtpDate.Margin = New System.Windows.Forms.Padding(12, 11, 12, 11)
        Me.DtpDate.Name = "DtpDate"
        Me.DtpDate.Size = New System.Drawing.Size(436, 26)
        Me.DtpDate.TabIndex = 111
        Me.DtpDate.Value = New Date(2017, 9, 1, 0, 0, 0, 0)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 264)
        Me.Label6.Margin = New System.Windows.Forms.Padding(12, 0, 12, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(165, 20)
        Me.Label6.TabIndex = 126
        Me.Label6.Text = "Current Qty Garments"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label5.Location = New System.Drawing.Point(90, 229)
        Me.Label5.Margin = New System.Windows.Forms.Padding(12, 0, 12, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 20)
        Me.Label5.TabIndex = 127
        Me.Label5.Text = "Stock Code:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label4.Location = New System.Drawing.Point(138, 30)
        Me.Label4.Margin = New System.Windows.Forms.Padding(12, 0, 12, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 20)
        Me.Label4.TabIndex = 131
        Me.Label4.Text = "Date:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label3.Location = New System.Drawing.Point(69, 163)
        Me.Label3.Margin = New System.Windows.Forms.Padding(12, 0, 12, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 20)
        Me.Label3.TabIndex = 128
        Me.Label3.Text = "To Warehouse:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label2.Location = New System.Drawing.Point(50, 126)
        Me.Label2.Margin = New System.Windows.Forms.Padding(12, 0, 12, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 20)
        Me.Label2.TabIndex = 129
        Me.Label2.Text = "From Warehouse:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(92, 75)
        Me.Label1.Margin = New System.Windows.Forms.Padding(12, 0, 12, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 20)
        Me.Label1.TabIndex = 130
        Me.Label1.Text = "TF Note No:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label7.Location = New System.Drawing.Point(628, 309)
        Me.Label7.Margin = New System.Windows.Forms.Padding(12, 0, 12, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 20)
        Me.Label7.TabIndex = 125
        Me.Label7.Text = "Transfer Qty:"
        '
        'WarehouseTransferForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1251, 823)
        Me.Controls.Add(Me.label14)
        Me.Controls.Add(Me.label15)
        Me.Controls.Add(Me.label16)
        Me.Controls.Add(Me.TxtOutHangers)
        Me.Controls.Add(Me.TxtOutBoxes)
        Me.Controls.Add(Me.TxtOutGarments)
        Me.Controls.Add(Me.TxtQtyToTransfer)
        Me.Controls.Add(Me.label17)
        Me.Controls.Add(Me.label11)
        Me.Controls.Add(Me.label12)
        Me.Controls.Add(Me.label13)
        Me.Controls.Add(Me.TxtToQtyHangers)
        Me.Controls.Add(Me.TxtToQtyBoxes)
        Me.Controls.Add(Me.TxtToQtyGarments)
        Me.Controls.Add(Me.TxtCurrQtyHangers)
        Me.Controls.Add(Me.TxtCurrQtyBoxes)
        Me.Controls.Add(Me.TxtCurrQtyGarments)
        Me.Controls.Add(Me.label10)
        Me.Controls.Add(Me.label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.CmdDeleteFromGrid)
        Me.Controls.Add(Me.TxtInHangers)
        Me.Controls.Add(Me.txtToWarehouseName)
        Me.Controls.Add(Me.TxtToWarehouseRef)
        Me.Controls.Add(Me.txtFromWarehouseName)
        Me.Controls.Add(Me.TxtTFNote)
        Me.Controls.Add(Me.TxtFromWarehouseRef)
        Me.Controls.Add(Me.TxtTransferID)
        Me.Controls.Add(Me.DgvRecords)
        Me.Controls.Add(Me.CmdAddToGrid)
        Me.Controls.Add(Me.TxtStockCode)
        Me.Controls.Add(Me.CmdClear)
        Me.Controls.Add(Me.CmdOK)
        Me.Controls.Add(Me.CmdCancel)
        Me.Controls.Add(Me.DtpDate)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label7)
        Me.Name = "WarehouseTransferForm"
        Me.Text = "Warehouse Transfer"
        CType(Me.DgvRecords, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents Column3 As DataGridViewTextBoxColumn
    Private WithEvents Column1 As DataGridViewTextBoxColumn
    Private WithEvents Column5 As DataGridViewTextBoxColumn
    Private WithEvents Column8 As DataGridViewTextBoxColumn
    Private WithEvents Column2 As DataGridViewTextBoxColumn
    Private WithEvents label14 As Label
    Private WithEvents label15 As Label
    Friend WithEvents label16 As Label
    Private WithEvents TxtOutHangers As TextBox
    Private WithEvents TxtOutBoxes As TextBox
    Private WithEvents TxtOutGarments As TextBox
    Friend WithEvents TxtQtyToTransfer As TextBox
    Friend WithEvents label17 As Label
    Private WithEvents label11 As Label
    Private WithEvents label12 As Label
    Friend WithEvents label13 As Label
    Private WithEvents TxtToQtyHangers As TextBox
    Private WithEvents TxtToQtyBoxes As TextBox
    Private WithEvents TxtToQtyGarments As TextBox
    Private WithEvents TxtCurrQtyHangers As TextBox
    Private WithEvents TxtCurrQtyBoxes As TextBox
    Private WithEvents TxtCurrQtyGarments As TextBox
    Private WithEvents label10 As Label
    Private WithEvents label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents CmdDeleteFromGrid As Button
    Friend WithEvents TxtInHangers As TextBox
    Friend WithEvents txtToWarehouseName As TextBox
    Friend WithEvents TxtToWarehouseRef As TextBox
    Friend WithEvents txtFromWarehouseName As TextBox
    Friend WithEvents TxtTFNote As TextBox
    Friend WithEvents TxtFromWarehouseRef As TextBox
    Friend WithEvents TxtTransferID As TextBox
    Friend WithEvents DgvRecords As DataGridView
    Private WithEvents Column4 As DataGridViewTextBoxColumn
    Private WithEvents Column6 As DataGridViewTextBoxColumn
    Private WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents CmdAddToGrid As Button
    Friend WithEvents TxtStockCode As TextBox
    Friend WithEvents CmdClear As Button
    Friend WithEvents CmdOK As Button
    Friend WithEvents CmdCancel As Button
    Friend WithEvents DtpDate As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
End Class
