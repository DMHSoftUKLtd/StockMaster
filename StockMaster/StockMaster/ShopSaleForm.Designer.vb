<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ShopSaleForm
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
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.TxtStockCode = New System.Windows.Forms.TextBox()
        Me.cmdDelToGrid = New System.Windows.Forms.Button()
        Me.cmdAddToGrid = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdOK = New System.Windows.Forms.Button()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtSoldToDate = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtCurrentQty = New System.Windows.Forms.TextBox()
        Me.txtDelivered = New System.Windows.Forms.TextBox()
        Me.lblShopName = New System.Windows.Forms.Label()
        Me.txtNetSale = New System.Windows.Forms.TextBox()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.DgvRecords = New System.Windows.Forms.DataGridView()
        Me.DtpTransaction = New System.Windows.Forms.DateTimePicker()
        Me.txtTotalDelivered = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtTotalSold = New System.Windows.Forms.TextBox()
        Me.txtTotalCurrQty = New System.Windows.Forms.TextBox()
        Me.txtShopRef = New System.Windows.Forms.TextBox()
        Me.txtTotalGarments = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtVAT = New System.Windows.Forms.TextBox()
        Me.txtNet = New System.Windows.Forms.TextBox()
        Me.txtVATRate = New System.Windows.Forms.TextBox()
        Me.txtSalesID = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DgvRecords, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(121, 169)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(8)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(177, 27)
        Me.CheckBox1.TabIndex = 204
        Me.CheckBox1.Text = "Enter A Zero Stock"
        Me.CheckBox1.UseVisualStyleBackColor = True
        Me.CheckBox1.Visible = False
        '
        'TxtStockCode
        '
        Me.TxtStockCode.Location = New System.Drawing.Point(510, 91)
        Me.TxtStockCode.Margin = New System.Windows.Forms.Padding(11)
        Me.TxtStockCode.Name = "TxtStockCode"
        Me.TxtStockCode.Size = New System.Drawing.Size(343, 26)
        Me.TxtStockCode.TabIndex = 166
        '
        'cmdDelToGrid
        '
        Me.cmdDelToGrid.Location = New System.Drawing.Point(1733, 62)
        Me.cmdDelToGrid.Margin = New System.Windows.Forms.Padding(11)
        Me.cmdDelToGrid.Name = "cmdDelToGrid"
        Me.cmdDelToGrid.Size = New System.Drawing.Size(167, 51)
        Me.cmdDelToGrid.TabIndex = 170
        Me.cmdDelToGrid.Text = "Delete"
        Me.cmdDelToGrid.UseVisualStyleBackColor = True
        '
        'cmdAddToGrid
        '
        Me.cmdAddToGrid.Location = New System.Drawing.Point(1575, 61)
        Me.cmdAddToGrid.Margin = New System.Windows.Forms.Padding(11)
        Me.cmdAddToGrid.Name = "cmdAddToGrid"
        Me.cmdAddToGrid.Size = New System.Drawing.Size(151, 52)
        Me.cmdAddToGrid.TabIndex = 169
        Me.cmdAddToGrid.Text = "Add"
        Me.cmdAddToGrid.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(1830, 560)
        Me.cmdCancel.Margin = New System.Windows.Forms.Padding(11)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(83, 72)
        Me.cmdCancel.TabIndex = 173
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cmdOK
        '
        Me.cmdOK.Location = New System.Drawing.Point(1733, 560)
        Me.cmdOK.Margin = New System.Windows.Forms.Padding(11)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(93, 72)
        Me.cmdOK.TabIndex = 172
        Me.cmdOK.Text = "OK"
        Me.cmdOK.UseVisualStyleBackColor = True
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(987, 61)
        Me.Label20.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(41, 20)
        Me.Label20.TabIndex = 198
        Me.Label20.Text = "Sold"
        '
        'txtSoldToDate
        '
        Me.txtSoldToDate.Location = New System.Drawing.Point(977, 91)
        Me.txtSoldToDate.Margin = New System.Windows.Forms.Padding(11)
        Me.txtSoldToDate.Name = "txtSoldToDate"
        Me.txtSoldToDate.Size = New System.Drawing.Size(103, 26)
        Me.txtSoldToDate.TabIndex = 197
        Me.txtSoldToDate.TabStop = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(862, 61)
        Me.Label19.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(75, 20)
        Me.Label19.TabIndex = 200
        Me.Label19.Text = "Delivered"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(1101, 61)
        Me.Label18.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(90, 20)
        Me.Label18.TabIndex = 195
        Me.Label18.Text = "Current Qty"
        '
        'txtCurrentQty
        '
        Me.txtCurrentQty.Location = New System.Drawing.Point(1102, 91)
        Me.txtCurrentQty.Margin = New System.Windows.Forms.Padding(11)
        Me.txtCurrentQty.Name = "txtCurrentQty"
        Me.txtCurrentQty.Size = New System.Drawing.Size(120, 26)
        Me.txtCurrentQty.TabIndex = 196
        Me.txtCurrentQty.TabStop = False
        '
        'txtDelivered
        '
        Me.txtDelivered.Location = New System.Drawing.Point(866, 91)
        Me.txtDelivered.Margin = New System.Windows.Forms.Padding(11)
        Me.txtDelivered.Name = "txtDelivered"
        Me.txtDelivered.Size = New System.Drawing.Size(103, 26)
        Me.txtDelivered.TabIndex = 199
        Me.txtDelivered.TabStop = False
        '
        'lblShopName
        '
        Me.lblShopName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblShopName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblShopName.Location = New System.Drawing.Point(23, 100)
        Me.lblShopName.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.lblShopName.Name = "lblShopName"
        Me.lblShopName.Size = New System.Drawing.Size(474, 61)
        Me.lblShopName.TabIndex = 203
        '
        'txtNetSale
        '
        Me.txtNetSale.Location = New System.Drawing.Point(1391, 91)
        Me.txtNetSale.Margin = New System.Windows.Forms.Padding(11)
        Me.txtNetSale.Name = "txtNetSale"
        Me.txtNetSale.Size = New System.Drawing.Size(162, 26)
        Me.txtNetSale.TabIndex = 168
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(1226, 91)
        Me.txtQty.Margin = New System.Windows.Forms.Padding(11)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(152, 26)
        Me.txtQty.TabIndex = 167
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(1416, 61)
        Me.Label14.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(74, 20)
        Me.Label14.TabIndex = 193
        Me.Label14.Text = "Net Sale:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(1245, 61)
        Me.Label13.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(68, 20)
        Me.Label13.TabIndex = 194
        Me.Label13.Text = "Quantity"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(366, 322)
        Me.Label15.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(23, 20)
        Me.Label15.TabIndex = 182
        Me.Label15.Text = "%"
        '
        'DgvRecords
        '
        Me.DgvRecords.AllowUserToAddRows = False
        Me.DgvRecords.AllowUserToDeleteRows = False
        Me.DgvRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvRecords.Location = New System.Drawing.Point(510, 139)
        Me.DgvRecords.Margin = New System.Windows.Forms.Padding(11)
        Me.DgvRecords.Name = "DgvRecords"
        Me.DgvRecords.RowHeadersVisible = False
        Me.DgvRecords.RowHeadersWidth = 51
        Me.DgvRecords.Size = New System.Drawing.Size(1403, 399)
        Me.DgvRecords.TabIndex = 171
        '
        'DtpTransaction
        '
        Me.DtpTransaction.Location = New System.Drawing.Point(173, 20)
        Me.DtpTransaction.Margin = New System.Windows.Forms.Padding(11)
        Me.DtpTransaction.Name = "DtpTransaction"
        Me.DtpTransaction.Size = New System.Drawing.Size(288, 26)
        Me.DtpTransaction.TabIndex = 164
        '
        'txtTotalDelivered
        '
        Me.txtTotalDelivered.Enabled = False
        Me.txtTotalDelivered.Location = New System.Drawing.Point(1008, 560)
        Me.txtTotalDelivered.Margin = New System.Windows.Forms.Padding(11)
        Me.txtTotalDelivered.Name = "txtTotalDelivered"
        Me.txtTotalDelivered.Size = New System.Drawing.Size(113, 26)
        Me.txtTotalDelivered.TabIndex = 190
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(506, 61)
        Me.Label12.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(96, 20)
        Me.Label12.TabIndex = 201
        Me.Label12.Text = "Stock Code:"
        '
        'txtTotalSold
        '
        Me.txtTotalSold.Enabled = False
        Me.txtTotalSold.Location = New System.Drawing.Point(1146, 560)
        Me.txtTotalSold.Margin = New System.Windows.Forms.Padding(11)
        Me.txtTotalSold.Name = "txtTotalSold"
        Me.txtTotalSold.Size = New System.Drawing.Size(140, 26)
        Me.txtTotalSold.TabIndex = 192
        '
        'txtTotalCurrQty
        '
        Me.txtTotalCurrQty.Enabled = False
        Me.txtTotalCurrQty.Location = New System.Drawing.Point(1310, 560)
        Me.txtTotalCurrQty.Margin = New System.Windows.Forms.Padding(11)
        Me.txtTotalCurrQty.Name = "txtTotalCurrQty"
        Me.txtTotalCurrQty.Size = New System.Drawing.Size(159, 26)
        Me.txtTotalCurrQty.TabIndex = 191
        '
        'txtShopRef
        '
        Me.txtShopRef.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtShopRef.Location = New System.Drawing.Point(173, 63)
        Me.txtShopRef.Margin = New System.Windows.Forms.Padding(11)
        Me.txtShopRef.Name = "txtShopRef"
        Me.txtShopRef.Size = New System.Drawing.Size(141, 26)
        Me.txtShopRef.TabIndex = 165
        '
        'txtTotalGarments
        '
        Me.txtTotalGarments.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtTotalGarments.Location = New System.Drawing.Point(151, 463)
        Me.txtTotalGarments.Margin = New System.Windows.Forms.Padding(11)
        Me.txtTotalGarments.Name = "txtTotalGarments"
        Me.txtTotalGarments.Size = New System.Drawing.Size(203, 26)
        Me.txtTotalGarments.TabIndex = 187
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(736, 560)
        Me.Label11.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 20)
        Me.Label11.TabIndex = 189
        Me.Label11.Text = "Totals:"
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtTotal.Location = New System.Drawing.Point(151, 415)
        Me.txtTotal.Margin = New System.Windows.Forms.Padding(11)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(203, 26)
        Me.txtTotal.TabIndex = 186
        Me.txtTotal.TabStop = False
        '
        'txtVAT
        '
        Me.txtVAT.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtVAT.Location = New System.Drawing.Point(151, 367)
        Me.txtVAT.Margin = New System.Windows.Forms.Padding(11)
        Me.txtVAT.Name = "txtVAT"
        Me.txtVAT.Size = New System.Drawing.Size(203, 26)
        Me.txtVAT.TabIndex = 183
        Me.txtVAT.TabStop = False
        '
        'txtNet
        '
        Me.txtNet.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtNet.Location = New System.Drawing.Point(151, 271)
        Me.txtNet.Margin = New System.Windows.Forms.Padding(11)
        Me.txtNet.Name = "txtNet"
        Me.txtNet.Size = New System.Drawing.Size(203, 26)
        Me.txtNet.TabIndex = 180
        Me.txtNet.TabStop = False
        '
        'txtVATRate
        '
        Me.txtVATRate.Location = New System.Drawing.Point(151, 319)
        Me.txtVATRate.Margin = New System.Windows.Forms.Padding(11)
        Me.txtVATRate.Name = "txtVATRate"
        Me.txtVATRate.Size = New System.Drawing.Size(203, 26)
        Me.txtVATRate.TabIndex = 176
        '
        'txtSalesID
        '
        Me.txtSalesID.BackColor = System.Drawing.Color.White
        Me.txtSalesID.Location = New System.Drawing.Point(568, 20)
        Me.txtSalesID.Margin = New System.Windows.Forms.Padding(11)
        Me.txtSalesID.Name = "txtSalesID"
        Me.txtSalesID.Size = New System.Drawing.Size(128, 26)
        Me.txtSalesID.TabIndex = 174
        Me.txtSalesID.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Fuchsia
        Me.Label10.Location = New System.Drawing.Point(50, 55)
        Me.Label10.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(118, 26)
        Me.Label10.TabIndex = 202
        Me.Label10.Text = "Shop Ref:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 463)
        Me.Label9.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(123, 20)
        Me.Label9.TabIndex = 188
        Me.Label9.Text = "Total Garments:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(81, 421)
        Me.Label8.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 20)
        Me.Label8.TabIndex = 185
        Me.Label8.Text = "Total:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(85, 370)
        Me.Label7.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 20)
        Me.Label7.TabIndex = 184
        Me.Label7.Text = "VAT:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(91, 271)
        Me.Label6.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 20)
        Me.Label6.TabIndex = 179
        Me.Label6.Text = "Net:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(188, 201)
        Me.Label5.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(215, 37)
        Me.Label5.TabIndex = 178
        Me.Label5.Text = "Sales Totals:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(46, 325)
        Me.Label4.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 20)
        Me.Label4.TabIndex = 181
        Me.Label4.Text = "VAT Rate:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 19)
        Me.Label2.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 20)
        Me.Label2.TabIndex = 177
        Me.Label2.Text = "Transaction Date:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(472, 25)
        Me.Label1.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 20)
        Me.Label1.TabIndex = 175
        Me.Label1.Text = "Sales ID:"
        '
        'ShopSaleForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1929, 641)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.TxtStockCode)
        Me.Controls.Add(Me.cmdDelToGrid)
        Me.Controls.Add(Me.cmdAddToGrid)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.txtSoldToDate)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txtCurrentQty)
        Me.Controls.Add(Me.txtDelivered)
        Me.Controls.Add(Me.lblShopName)
        Me.Controls.Add(Me.txtNetSale)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.DgvRecords)
        Me.Controls.Add(Me.DtpTransaction)
        Me.Controls.Add(Me.txtTotalDelivered)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtTotalSold)
        Me.Controls.Add(Me.txtTotalCurrQty)
        Me.Controls.Add(Me.txtShopRef)
        Me.Controls.Add(Me.txtTotalGarments)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtVAT)
        Me.Controls.Add(Me.txtNet)
        Me.Controls.Add(Me.txtVATRate)
        Me.Controls.Add(Me.txtSalesID)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ShopSaleForm"
        Me.Text = "Shop Sale"
        CType(Me.DgvRecords, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents TxtStockCode As TextBox
    Friend WithEvents cmdDelToGrid As Button
    Friend WithEvents cmdAddToGrid As Button
    Friend WithEvents cmdCancel As Button
    Friend WithEvents cmdOK As Button
    Friend WithEvents Label20 As Label
    Friend WithEvents txtSoldToDate As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents txtCurrentQty As TextBox
    Friend WithEvents txtDelivered As TextBox
    Friend WithEvents lblShopName As Label
    Friend WithEvents txtNetSale As TextBox
    Friend WithEvents txtQty As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents DgvRecords As DataGridView
    Friend WithEvents DtpTransaction As DateTimePicker
    Friend WithEvents txtTotalDelivered As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtTotalSold As TextBox
    Friend WithEvents txtTotalCurrQty As TextBox
    Friend WithEvents txtShopRef As TextBox
    Friend WithEvents txtTotalGarments As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtVAT As TextBox
    Friend WithEvents txtNet As TextBox
    Friend WithEvents txtVATRate As TextBox
    Friend WithEvents txtSalesID As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
