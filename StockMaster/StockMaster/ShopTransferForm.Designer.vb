<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ShopTransferForm
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
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtTransferID = New System.Windows.Forms.TextBox()
        Me.DgvRecords = New System.Windows.Forms.DataGridView()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CmdDeleteFromGrid = New System.Windows.Forms.Button()
        Me.CmdAddToGrid = New System.Windows.Forms.Button()
        Me.txtTotalTransferTo = New System.Windows.Forms.TextBox()
        Me.TxtTransferFromQty = New System.Windows.Forms.TextBox()
        Me.TxtCurrentQty = New System.Windows.Forms.TextBox()
        Me.TxtStockCode = New System.Windows.Forms.TextBox()
        Me.txtToShopName = New System.Windows.Forms.TextBox()
        Me.TxtToShopRef = New System.Windows.Forms.TextBox()
        Me.txtFromShopName = New System.Windows.Forms.TextBox()
        Me.TxtFromShopRef = New System.Windows.Forms.TextBox()
        Me.TxtTFNote = New System.Windows.Forms.TextBox()
        Me.CmdClear = New System.Windows.Forms.Button()
        Me.CmdOK = New System.Windows.Forms.Button()
        Me.CmdCancel = New System.Windows.Forms.Button()
        Me.DtpDate = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DgvRecords, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(10, 27)
        Me.Label9.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(121, 20)
        Me.Label9.TabIndex = 112
        Me.Label9.Text = "Record Number"
        '
        'TxtTransferID
        '
        Me.TxtTransferID.Location = New System.Drawing.Point(153, 24)
        Me.TxtTransferID.Margin = New System.Windows.Forms.Padding(11)
        Me.TxtTransferID.Name = "TxtTransferID"
        Me.TxtTransferID.Size = New System.Drawing.Size(364, 26)
        Me.TxtTransferID.TabIndex = 114
        '
        'DgvRecords
        '
        Me.DgvRecords.AllowUserToAddRows = False
        Me.DgvRecords.AllowUserToDeleteRows = False
        Me.DgvRecords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvRecords.ColumnHeadersHeight = 29
        Me.DgvRecords.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column5, Me.Column6, Me.Column7, Me.Column8})
        Me.DgvRecords.Location = New System.Drawing.Point(20, 414)
        Me.DgvRecords.Margin = New System.Windows.Forms.Padding(11)
        Me.DgvRecords.Name = "DgvRecords"
        Me.DgvRecords.RowHeadersWidth = 51
        Me.DgvRecords.Size = New System.Drawing.Size(957, 421)
        Me.DgvRecords.TabIndex = 108
        '
        'Column5
        '
        Me.Column5.FillWeight = 162.2788!
        Me.Column5.HeaderText = "Stock Code"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.FillWeight = 61.57903!
        Me.Column6.HeaderText = "Current Qty"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.FillWeight = 76.14214!
        Me.Column7.HeaderText = "Qty"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.HeaderText = "To Qty"
        Me.Column8.MinimumWidth = 6
        Me.Column8.Name = "Column8"
        Me.Column8.Visible = False
        '
        'CmdDeleteFromGrid
        '
        Me.CmdDeleteFromGrid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdDeleteFromGrid.Location = New System.Drawing.Point(698, 318)
        Me.CmdDeleteFromGrid.Margin = New System.Windows.Forms.Padding(11)
        Me.CmdDeleteFromGrid.Name = "CmdDeleteFromGrid"
        Me.CmdDeleteFromGrid.Size = New System.Drawing.Size(100, 72)
        Me.CmdDeleteFromGrid.TabIndex = 107
        Me.CmdDeleteFromGrid.Text = "-"
        Me.CmdDeleteFromGrid.UseVisualStyleBackColor = True
        '
        'CmdAddToGrid
        '
        Me.CmdAddToGrid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdAddToGrid.Location = New System.Drawing.Point(552, 318)
        Me.CmdAddToGrid.Margin = New System.Windows.Forms.Padding(11)
        Me.CmdAddToGrid.Name = "CmdAddToGrid"
        Me.CmdAddToGrid.Size = New System.Drawing.Size(124, 72)
        Me.CmdAddToGrid.TabIndex = 106
        Me.CmdAddToGrid.Text = "+"
        Me.CmdAddToGrid.UseVisualStyleBackColor = True
        '
        'txtTotalTransferTo
        '
        Me.txtTotalTransferTo.Location = New System.Drawing.Point(802, 857)
        Me.txtTotalTransferTo.Margin = New System.Windows.Forms.Padding(11)
        Me.txtTotalTransferTo.Name = "txtTotalTransferTo"
        Me.txtTotalTransferTo.Size = New System.Drawing.Size(175, 26)
        Me.txtTotalTransferTo.TabIndex = 124
        '
        'TxtTransferFromQty
        '
        Me.TxtTransferFromQty.Location = New System.Drawing.Point(153, 366)
        Me.TxtTransferFromQty.Margin = New System.Windows.Forms.Padding(11)
        Me.TxtTransferFromQty.Name = "TxtTransferFromQty"
        Me.TxtTransferFromQty.Size = New System.Drawing.Size(364, 26)
        Me.TxtTransferFromQty.TabIndex = 105
        '
        'TxtCurrentQty
        '
        Me.TxtCurrentQty.Location = New System.Drawing.Point(153, 318)
        Me.TxtCurrentQty.Margin = New System.Windows.Forms.Padding(11)
        Me.TxtCurrentQty.Name = "TxtCurrentQty"
        Me.TxtCurrentQty.Size = New System.Drawing.Size(364, 26)
        Me.TxtCurrentQty.TabIndex = 122
        '
        'TxtStockCode
        '
        Me.TxtStockCode.Location = New System.Drawing.Point(153, 278)
        Me.TxtStockCode.Margin = New System.Windows.Forms.Padding(11)
        Me.TxtStockCode.MaxLength = 30
        Me.TxtStockCode.Name = "TxtStockCode"
        Me.TxtStockCode.Size = New System.Drawing.Size(364, 26)
        Me.TxtStockCode.TabIndex = 104
        '
        'txtToShopName
        '
        Me.txtToShopName.Location = New System.Drawing.Point(339, 221)
        Me.txtToShopName.Margin = New System.Windows.Forms.Padding(11)
        Me.txtToShopName.Name = "txtToShopName"
        Me.txtToShopName.Size = New System.Drawing.Size(528, 26)
        Me.txtToShopName.TabIndex = 117
        Me.txtToShopName.TabStop = False
        '
        'TxtToShopRef
        '
        Me.TxtToShopRef.Location = New System.Drawing.Point(153, 221)
        Me.TxtToShopRef.Margin = New System.Windows.Forms.Padding(11)
        Me.TxtToShopRef.MaxLength = 8
        Me.TxtToShopRef.Name = "TxtToShopRef"
        Me.TxtToShopRef.Size = New System.Drawing.Size(164, 26)
        Me.TxtToShopRef.TabIndex = 103
        '
        'txtFromShopName
        '
        Me.txtFromShopName.Location = New System.Drawing.Point(339, 169)
        Me.txtFromShopName.Margin = New System.Windows.Forms.Padding(11)
        Me.txtFromShopName.Name = "txtFromShopName"
        Me.txtFromShopName.Size = New System.Drawing.Size(528, 26)
        Me.txtFromShopName.TabIndex = 116
        Me.txtFromShopName.TabStop = False
        '
        'TxtFromShopRef
        '
        Me.TxtFromShopRef.Location = New System.Drawing.Point(153, 166)
        Me.TxtFromShopRef.Margin = New System.Windows.Forms.Padding(11)
        Me.TxtFromShopRef.MaxLength = 8
        Me.TxtFromShopRef.Name = "TxtFromShopRef"
        Me.TxtFromShopRef.Size = New System.Drawing.Size(164, 26)
        Me.TxtFromShopRef.TabIndex = 102
        '
        'TxtTFNote
        '
        Me.TxtTFNote.Location = New System.Drawing.Point(153, 118)
        Me.TxtTFNote.Margin = New System.Windows.Forms.Padding(11)
        Me.TxtTFNote.MaxLength = 30
        Me.TxtTFNote.Name = "TxtTFNote"
        Me.TxtTFNote.Size = New System.Drawing.Size(364, 26)
        Me.TxtTFNote.TabIndex = 101
        '
        'CmdClear
        '
        Me.CmdClear.Location = New System.Drawing.Point(840, 905)
        Me.CmdClear.Margin = New System.Windows.Forms.Padding(11)
        Me.CmdClear.Name = "CmdClear"
        Me.CmdClear.Size = New System.Drawing.Size(137, 43)
        Me.CmdClear.TabIndex = 111
        Me.CmdClear.Text = "Clear"
        Me.CmdClear.UseVisualStyleBackColor = True
        '
        'CmdOK
        '
        Me.CmdOK.Location = New System.Drawing.Point(569, 905)
        Me.CmdOK.Margin = New System.Windows.Forms.Padding(11)
        Me.CmdOK.Name = "CmdOK"
        Me.CmdOK.Size = New System.Drawing.Size(116, 43)
        Me.CmdOK.TabIndex = 109
        Me.CmdOK.Text = "Ok"
        Me.CmdOK.UseVisualStyleBackColor = True
        '
        'CmdCancel
        '
        Me.CmdCancel.Location = New System.Drawing.Point(707, 905)
        Me.CmdCancel.Margin = New System.Windows.Forms.Padding(11)
        Me.CmdCancel.Name = "CmdCancel"
        Me.CmdCancel.Size = New System.Drawing.Size(124, 43)
        Me.CmdCancel.TabIndex = 110
        Me.CmdCancel.Text = "Cancel"
        Me.CmdCancel.UseVisualStyleBackColor = True
        '
        'DtpDate
        '
        Me.DtpDate.Location = New System.Drawing.Point(153, 70)
        Me.DtpDate.Margin = New System.Windows.Forms.Padding(11)
        Me.DtpDate.Name = "DtpDate"
        Me.DtpDate.Size = New System.Drawing.Size(364, 26)
        Me.DtpDate.TabIndex = 100
        Me.DtpDate.Value = New Date(2017, 9, 1, 0, 0, 0, 0)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label7.Location = New System.Drawing.Point(31, 372)
        Me.Label7.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 20)
        Me.Label7.TabIndex = 123
        Me.Label7.Text = "Transfer Qty:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(39, 321)
        Me.Label6.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 20)
        Me.Label6.TabIndex = 121
        Me.Label6.Text = "Current Qty:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label5.Location = New System.Drawing.Point(35, 278)
        Me.Label5.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 20)
        Me.Label5.TabIndex = 120
        Me.Label5.Text = "Stock Code:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label4.Location = New System.Drawing.Point(83, 76)
        Me.Label4.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 20)
        Me.Label4.TabIndex = 115
        Me.Label4.Text = "Date:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label3.Location = New System.Drawing.Point(58, 224)
        Me.Label3.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 20)
        Me.Label3.TabIndex = 119
        Me.Label3.Text = "To Shop:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label2.Location = New System.Drawing.Point(43, 175)
        Me.Label2.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 20)
        Me.Label2.TabIndex = 118
        Me.Label2.Text = "From Shop"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 128)
        Me.Label1.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 20)
        Me.Label1.TabIndex = 113
        Me.Label1.Text = "TF Note No:"
        '
        'ShopTransferForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1009, 961)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TxtTransferID)
        Me.Controls.Add(Me.DgvRecords)
        Me.Controls.Add(Me.CmdDeleteFromGrid)
        Me.Controls.Add(Me.CmdAddToGrid)
        Me.Controls.Add(Me.txtTotalTransferTo)
        Me.Controls.Add(Me.TxtTransferFromQty)
        Me.Controls.Add(Me.TxtCurrentQty)
        Me.Controls.Add(Me.TxtStockCode)
        Me.Controls.Add(Me.txtToShopName)
        Me.Controls.Add(Me.TxtToShopRef)
        Me.Controls.Add(Me.txtFromShopName)
        Me.Controls.Add(Me.TxtFromShopRef)
        Me.Controls.Add(Me.TxtTFNote)
        Me.Controls.Add(Me.CmdClear)
        Me.Controls.Add(Me.CmdOK)
        Me.Controls.Add(Me.CmdCancel)
        Me.Controls.Add(Me.DtpDate)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ShopTransferForm"
        Me.Text = "Shop Transfer"
        CType(Me.DgvRecords, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label9 As Label
    Friend WithEvents TxtTransferID As TextBox
    Friend WithEvents DgvRecords As DataGridView
    Private WithEvents Column5 As DataGridViewTextBoxColumn
    Private WithEvents Column6 As DataGridViewTextBoxColumn
    Private WithEvents Column7 As DataGridViewTextBoxColumn
    Private WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents CmdDeleteFromGrid As Button
    Friend WithEvents CmdAddToGrid As Button
    Friend WithEvents txtTotalTransferTo As TextBox
    Friend WithEvents TxtTransferFromQty As TextBox
    Friend WithEvents TxtCurrentQty As TextBox
    Friend WithEvents TxtStockCode As TextBox
    Friend WithEvents txtToShopName As TextBox
    Friend WithEvents TxtToShopRef As TextBox
    Friend WithEvents txtFromShopName As TextBox
    Friend WithEvents TxtFromShopRef As TextBox
    Friend WithEvents TxtTFNote As TextBox
    Friend WithEvents CmdClear As Button
    Friend WithEvents CmdOK As Button
    Friend WithEvents CmdCancel As Button
    Friend WithEvents DtpDate As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
