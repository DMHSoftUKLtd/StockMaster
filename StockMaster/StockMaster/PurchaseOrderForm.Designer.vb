<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PurchaseOrderForm
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
        Me.CmdDeleteFromGrid = New System.Windows.Forms.Button()
        Me.TxtNetCostLine = New System.Windows.Forms.TextBox()
        Me.CmdAddToGrid = New System.Windows.Forms.Button()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.TxtQtyHangers = New System.Windows.Forms.TextBox()
        Me.TxtQtyBoxes = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.TxtStockCode = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.TxtQtyGarments = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.label28 = New System.Windows.Forms.Label()
        Me.TxtOrderID = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.label11 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtTotalOrderPrice = New System.Windows.Forms.TextBox()
        Me.TxtTotalGarments = New System.Windows.Forms.TextBox()
        Me.TxtVATAmount = New System.Windows.Forms.TextBox()
        Me.TxtTotalNet = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.label27 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtShipperName = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtCommission = New System.Windows.Forms.TextBox()
        Me.TxtDeliveryCharges = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtShipperInvoiceNumber = New System.Windows.Forms.TextBox()
        Me.TxtSuppliersInvoiceNumber = New System.Windows.Forms.TextBox()
        Me.TxtTotalBoxes = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtTotalHangers = New System.Windows.Forms.TextBox()
        Me.label31 = New System.Windows.Forms.Label()
        Me.TxtNotes = New System.Windows.Forms.TextBox()
        Me.TxtWarehouseName = New System.Windows.Forms.TextBox()
        Me.label26 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TxtSupplierName = New System.Windows.Forms.TextBox()
        Me.TxtOurRef = New System.Windows.Forms.TextBox()
        Me.TxtWarehouseRef = New System.Windows.Forms.TextBox()
        Me.label30 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.CboSeasonName = New System.Windows.Forms.ComboBox()
        Me.TxtSupplierRef = New System.Windows.Forms.TextBox()
        Me.label29 = New System.Windows.Forms.Label()
        Me.DgvItems = New System.Windows.Forms.DataGridView()
        Me.ColStockCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColQtyLoose = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColQtyBoxes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColQtyItems = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColNetAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdOK = New System.Windows.Forms.Button()
        Me.DteMovementDate = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        CType(Me.DgvItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CmdDeleteFromGrid
        '
        Me.CmdDeleteFromGrid.Location = New System.Drawing.Point(691, 559)
        Me.CmdDeleteFromGrid.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.CmdDeleteFromGrid.Name = "CmdDeleteFromGrid"
        Me.CmdDeleteFromGrid.Size = New System.Drawing.Size(139, 39)
        Me.CmdDeleteFromGrid.TabIndex = 304
        Me.CmdDeleteFromGrid.Text = "Remove"
        Me.CmdDeleteFromGrid.UseVisualStyleBackColor = True
        '
        'TxtNetCostLine
        '
        Me.TxtNetCostLine.Location = New System.Drawing.Point(798, 521)
        Me.TxtNetCostLine.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.TxtNetCostLine.Name = "TxtNetCostLine"
        Me.TxtNetCostLine.Size = New System.Drawing.Size(164, 26)
        Me.TxtNetCostLine.TabIndex = 302
        '
        'CmdAddToGrid
        '
        Me.CmdAddToGrid.Location = New System.Drawing.Point(538, 559)
        Me.CmdAddToGrid.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.CmdAddToGrid.Name = "CmdAddToGrid"
        Me.CmdAddToGrid.Size = New System.Drawing.Size(139, 39)
        Me.CmdAddToGrid.TabIndex = 303
        Me.CmdAddToGrid.Text = "Add"
        Me.CmdAddToGrid.UseVisualStyleBackColor = True
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label25.Location = New System.Drawing.Point(822, 490)
        Me.Label25.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(71, 20)
        Me.Label25.TabIndex = 342
        Me.Label25.Text = "Net Cost"
        '
        'TxtQtyHangers
        '
        Me.TxtQtyHangers.Location = New System.Drawing.Point(647, 521)
        Me.TxtQtyHangers.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.TxtQtyHangers.Name = "TxtQtyHangers"
        Me.TxtQtyHangers.Size = New System.Drawing.Size(129, 26)
        Me.TxtQtyHangers.TabIndex = 301
        '
        'TxtQtyBoxes
        '
        Me.TxtQtyBoxes.Location = New System.Drawing.Point(494, 521)
        Me.TxtQtyBoxes.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.TxtQtyBoxes.Name = "TxtQtyBoxes"
        Me.TxtQtyBoxes.Size = New System.Drawing.Size(113, 26)
        Me.TxtQtyBoxes.TabIndex = 300
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label22.Location = New System.Drawing.Point(642, 490)
        Me.Label22.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(98, 20)
        Me.Label22.TabIndex = 341
        Me.Label22.Text = "Qty Hangers"
        '
        'TxtStockCode
        '
        Me.TxtStockCode.Location = New System.Drawing.Point(21, 521)
        Me.TxtStockCode.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.TxtStockCode.Name = "TxtStockCode"
        Me.TxtStockCode.Size = New System.Drawing.Size(289, 26)
        Me.TxtStockCode.TabIndex = 298
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.label1.Location = New System.Drawing.Point(502, 490)
        Me.label1.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(81, 20)
        Me.label1.TabIndex = 340
        Me.label1.Text = "Qty Boxes"
        '
        'TxtQtyGarments
        '
        Me.TxtQtyGarments.Location = New System.Drawing.Point(326, 521)
        Me.TxtQtyGarments.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.TxtQtyGarments.Name = "TxtQtyGarments"
        Me.TxtQtyGarments.Size = New System.Drawing.Size(152, 26)
        Me.TxtQtyGarments.TabIndex = 299
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(822, 436)
        Me.Label24.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(18, 20)
        Me.Label24.TabIndex = 319
        Me.Label24.Text = "£"
        '
        'label28
        '
        Me.label28.AutoSize = True
        Me.label28.Location = New System.Drawing.Point(822, 386)
        Me.label28.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.label28.Name = "label28"
        Me.label28.Size = New System.Drawing.Size(18, 20)
        Me.label28.TabIndex = 320
        Me.label28.Text = "£"
        '
        'TxtOrderID
        '
        Me.TxtOrderID.Location = New System.Drawing.Point(780, 22)
        Me.TxtOrderID.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.TxtOrderID.Name = "TxtOrderID"
        Me.TxtOrderID.Size = New System.Drawing.Size(260, 26)
        Me.TxtOrderID.TabIndex = 316
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(822, 336)
        Me.Label23.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(18, 20)
        Me.Label23.TabIndex = 321
        Me.Label23.Text = "£"
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.label11.Location = New System.Drawing.Point(339, 490)
        Me.label11.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(108, 20)
        Me.label11.TabIndex = 339
        Me.label11.Text = "Qty Garments"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(822, 286)
        Me.Label19.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(18, 20)
        Me.Label19.TabIndex = 322
        Me.Label19.Text = "£"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(822, 236)
        Me.Label14.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(18, 20)
        Me.Label14.TabIndex = 323
        Me.Label14.Text = "£"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label21.Location = New System.Drawing.Point(17, 482)
        Me.Label21.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(92, 20)
        Me.Label21.TabIndex = 338
        Me.Label21.Text = "Stock Code"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(768, 234)
        Me.Label6.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 20)
        Me.Label6.TabIndex = 324
        Me.Label6.Text = "Net:"
        '
        'TxtTotalOrderPrice
        '
        Me.TxtTotalOrderPrice.Location = New System.Drawing.Point(856, 434)
        Me.TxtTotalOrderPrice.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.TxtTotalOrderPrice.Name = "TxtTotalOrderPrice"
        Me.TxtTotalOrderPrice.Size = New System.Drawing.Size(176, 26)
        Me.TxtTotalOrderPrice.TabIndex = 318
        '
        'TxtTotalGarments
        '
        Me.TxtTotalGarments.Location = New System.Drawing.Point(358, 983)
        Me.TxtTotalGarments.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.TxtTotalGarments.Name = "TxtTotalGarments"
        Me.TxtTotalGarments.Size = New System.Drawing.Size(105, 26)
        Me.TxtTotalGarments.TabIndex = 350
        '
        'TxtVATAmount
        '
        Me.TxtVATAmount.Location = New System.Drawing.Point(856, 384)
        Me.TxtVATAmount.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.TxtVATAmount.Name = "TxtVATAmount"
        Me.TxtVATAmount.Size = New System.Drawing.Size(176, 26)
        Me.TxtVATAmount.TabIndex = 311
        Me.TxtVATAmount.Text = "0.00"
        '
        'TxtTotalNet
        '
        Me.TxtTotalNet.Location = New System.Drawing.Point(856, 234)
        Me.TxtTotalNet.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.TxtTotalNet.Name = "TxtTotalNet"
        Me.TxtTotalNet.Size = New System.Drawing.Size(176, 26)
        Me.TxtTotalNet.TabIndex = 317
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(758, 434)
        Me.Label9.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 20)
        Me.Label9.TabIndex = 343
        Me.Label9.Text = "Total:"
        '
        'label27
        '
        Me.label27.AutoSize = True
        Me.label27.Location = New System.Drawing.Point(691, 384)
        Me.label27.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.label27.Name = "label27"
        Me.label27.Size = New System.Drawing.Size(115, 20)
        Me.label27.TabIndex = 344
        Me.label27.Text = "Purchase VAT:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label7.Location = New System.Drawing.Point(674, 284)
        Me.Label7.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(132, 20)
        Me.Label7.TabIndex = 346
        Me.Label7.Text = "Delivery Charges:"
        '
        'TxtShipperName
        '
        Me.TxtShipperName.Location = New System.Drawing.Point(780, 60)
        Me.TxtShipperName.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.TxtShipperName.Name = "TxtShipperName"
        Me.TxtShipperName.Size = New System.Drawing.Size(260, 26)
        Me.TxtShipperName.TabIndex = 306
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label8.Location = New System.Drawing.Point(707, 334)
        Me.Label8.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(99, 20)
        Me.Label8.TabIndex = 345
        Me.Label8.Text = "Commission:"
        '
        'TxtCommission
        '
        Me.TxtCommission.Location = New System.Drawing.Point(856, 334)
        Me.TxtCommission.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.TxtCommission.Name = "TxtCommission"
        Me.TxtCommission.Size = New System.Drawing.Size(176, 26)
        Me.TxtCommission.TabIndex = 310
        Me.TxtCommission.Text = "0.00"
        '
        'TxtDeliveryCharges
        '
        Me.TxtDeliveryCharges.Location = New System.Drawing.Point(856, 284)
        Me.TxtDeliveryCharges.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.TxtDeliveryCharges.Name = "TxtDeliveryCharges"
        Me.TxtDeliveryCharges.Size = New System.Drawing.Size(176, 26)
        Me.TxtDeliveryCharges.TabIndex = 309
        Me.TxtDeliveryCharges.Text = "0.00"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label2.Location = New System.Drawing.Point(696, 60)
        Me.Label2.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 20)
        Me.Label2.TabIndex = 328
        Me.Label2.Text = "Shipper:"
        '
        'TxtShipperInvoiceNumber
        '
        Me.TxtShipperInvoiceNumber.Location = New System.Drawing.Point(780, 99)
        Me.TxtShipperInvoiceNumber.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.TxtShipperInvoiceNumber.Name = "TxtShipperInvoiceNumber"
        Me.TxtShipperInvoiceNumber.Size = New System.Drawing.Size(260, 26)
        Me.TxtShipperInvoiceNumber.TabIndex = 307
        '
        'TxtSuppliersInvoiceNumber
        '
        Me.TxtSuppliersInvoiceNumber.Location = New System.Drawing.Point(780, 137)
        Me.TxtSuppliersInvoiceNumber.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.TxtSuppliersInvoiceNumber.Name = "TxtSuppliersInvoiceNumber"
        Me.TxtSuppliersInvoiceNumber.Size = New System.Drawing.Size(260, 26)
        Me.TxtSuppliersInvoiceNumber.TabIndex = 308
        '
        'TxtTotalBoxes
        '
        Me.TxtTotalBoxes.Location = New System.Drawing.Point(479, 983)
        Me.TxtTotalBoxes.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.TxtTotalBoxes.Name = "TxtTotalBoxes"
        Me.TxtTotalBoxes.Size = New System.Drawing.Size(105, 26)
        Me.TxtTotalBoxes.TabIndex = 349
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label3.Location = New System.Drawing.Point(618, 102)
        Me.Label3.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(146, 20)
        Me.Label3.TabIndex = 327
        Me.Label3.Text = "Shipper Invoice No:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label4.Location = New System.Drawing.Point(607, 143)
        Me.Label4.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(157, 20)
        Me.Label4.TabIndex = 326
        Me.Label4.Text = "Suppliers Invoice No:"
        '
        'TxtTotalHangers
        '
        Me.TxtTotalHangers.Location = New System.Drawing.Point(600, 983)
        Me.TxtTotalHangers.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.TxtTotalHangers.Name = "TxtTotalHangers"
        Me.TxtTotalHangers.Size = New System.Drawing.Size(105, 26)
        Me.TxtTotalHangers.TabIndex = 348
        '
        'label31
        '
        Me.label31.AutoSize = True
        Me.label31.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.label31.Location = New System.Drawing.Point(103, 298)
        Me.label31.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.label31.Name = "label31"
        Me.label31.Size = New System.Drawing.Size(55, 20)
        Me.label31.TabIndex = 337
        Me.label31.Text = "Notes:"
        '
        'TxtNotes
        '
        Me.TxtNotes.Location = New System.Drawing.Point(174, 294)
        Me.TxtNotes.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.TxtNotes.Multiline = True
        Me.TxtNotes.Name = "TxtNotes"
        Me.TxtNotes.Size = New System.Drawing.Size(417, 115)
        Me.TxtNotes.TabIndex = 305
        '
        'TxtWarehouseName
        '
        Me.TxtWarehouseName.Location = New System.Drawing.Point(174, 67)
        Me.TxtWarehouseName.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.TxtWarehouseName.Name = "TxtWarehouseName"
        Me.TxtWarehouseName.Size = New System.Drawing.Size(417, 26)
        Me.TxtWarehouseName.TabIndex = 315
        '
        'label26
        '
        Me.label26.AutoSize = True
        Me.label26.Location = New System.Drawing.Point(1956, 890)
        Me.label26.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.label26.Name = "label26"
        Me.label26.Size = New System.Drawing.Size(96, 20)
        Me.label26.TabIndex = 353
        Me.label26.Text = "Total Loose:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(687, 28)
        Me.Label13.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(77, 20)
        Me.Label13.TabIndex = 329
        Me.Label13.Text = "Order No:"
        '
        'label12
        '
        Me.label12.AutoSize = True
        Me.label12.Location = New System.Drawing.Point(1731, 197)
        Me.label12.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(96, 20)
        Me.label12.TabIndex = 352
        Me.label12.Text = "Total Boxes:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(1731, 217)
        Me.Label10.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(92, 20)
        Me.Label10.TabIndex = 351
        Me.Label10.Text = "Total Items:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(41, 147)
        Me.Label17.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(117, 20)
        Me.Label17.TabIndex = 333
        Me.Label17.Text = "Supplier Name:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(17, 67)
        Me.Label20.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(141, 20)
        Me.Label20.TabIndex = 331
        Me.Label20.Text = "Warehouse Name:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label18.Location = New System.Drawing.Point(33, 32)
        Me.Label18.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(125, 20)
        Me.Label18.TabIndex = 330
        Me.Label18.Text = "Warehouse Ref:"
        '
        'TxtSupplierName
        '
        Me.TxtSupplierName.Location = New System.Drawing.Point(174, 143)
        Me.TxtSupplierName.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.TxtSupplierName.Name = "TxtSupplierName"
        Me.TxtSupplierName.Size = New System.Drawing.Size(417, 26)
        Me.TxtSupplierName.TabIndex = 314
        '
        'TxtOurRef
        '
        Me.TxtOurRef.Location = New System.Drawing.Point(174, 219)
        Me.TxtOurRef.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.TxtOurRef.Name = "TxtOurRef"
        Me.TxtOurRef.Size = New System.Drawing.Size(351, 26)
        Me.TxtOurRef.TabIndex = 296
        '
        'TxtWarehouseRef
        '
        Me.TxtWarehouseRef.Location = New System.Drawing.Point(174, 29)
        Me.TxtWarehouseRef.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.TxtWarehouseRef.Name = "TxtWarehouseRef"
        Me.TxtWarehouseRef.Size = New System.Drawing.Size(260, 26)
        Me.TxtWarehouseRef.TabIndex = 293
        '
        'label30
        '
        Me.label30.AutoSize = True
        Me.label30.Location = New System.Drawing.Point(89, 222)
        Me.label30.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.label30.Name = "label30"
        Me.label30.Size = New System.Drawing.Size(69, 20)
        Me.label30.TabIndex = 335
        Me.label30.Text = "Our Ref:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label16.Location = New System.Drawing.Point(57, 103)
        Me.Label16.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(101, 20)
        Me.Label16.TabIndex = 332
        Me.Label16.Text = "Supplier Ref:"
        '
        'CboSeasonName
        '
        Me.CboSeasonName.FormattingEnabled = True
        Me.CboSeasonName.Location = New System.Drawing.Point(174, 257)
        Me.CboSeasonName.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.CboSeasonName.Name = "CboSeasonName"
        Me.CboSeasonName.Size = New System.Drawing.Size(417, 28)
        Me.CboSeasonName.TabIndex = 297
        '
        'TxtSupplierRef
        '
        Me.TxtSupplierRef.Location = New System.Drawing.Point(174, 105)
        Me.TxtSupplierRef.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.TxtSupplierRef.Name = "TxtSupplierRef"
        Me.TxtSupplierRef.Size = New System.Drawing.Size(260, 26)
        Me.TxtSupplierRef.TabIndex = 294
        '
        'label29
        '
        Me.label29.AutoSize = True
        Me.label29.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.label29.Location = New System.Drawing.Point(90, 260)
        Me.label29.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.label29.Name = "label29"
        Me.label29.Size = New System.Drawing.Size(68, 20)
        Me.label29.TabIndex = 336
        Me.label29.Text = "Season:"
        '
        'DgvItems
        '
        Me.DgvItems.AllowUserToAddRows = False
        Me.DgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvItems.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColStockCode, Me.ColQtyLoose, Me.ColQtyBoxes, Me.ColQtyItems, Me.ColNetAmount})
        Me.DgvItems.Location = New System.Drawing.Point(17, 610)
        Me.DgvItems.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.DgvItems.Name = "DgvItems"
        Me.DgvItems.RowHeadersWidth = 51
        Me.DgvItems.Size = New System.Drawing.Size(1015, 361)
        Me.DgvItems.TabIndex = 347
        '
        'ColStockCode
        '
        Me.ColStockCode.FillWeight = 180.0!
        Me.ColStockCode.HeaderText = "Stock Code"
        Me.ColStockCode.MinimumWidth = 8
        Me.ColStockCode.Name = "ColStockCode"
        Me.ColStockCode.Width = 180
        '
        'ColQtyLoose
        '
        Me.ColQtyLoose.FillWeight = 50.0!
        Me.ColQtyLoose.HeaderText = "Qty Garments"
        Me.ColQtyLoose.MinimumWidth = 8
        Me.ColQtyLoose.Name = "ColQtyLoose"
        Me.ColQtyLoose.Width = 80
        '
        'ColQtyBoxes
        '
        Me.ColQtyBoxes.FillWeight = 90.0!
        Me.ColQtyBoxes.HeaderText = "Qty Boxes"
        Me.ColQtyBoxes.MinimumWidth = 8
        Me.ColQtyBoxes.Name = "ColQtyBoxes"
        Me.ColQtyBoxes.Width = 70
        '
        'ColQtyItems
        '
        Me.ColQtyItems.FillWeight = 90.0!
        Me.ColQtyItems.HeaderText = "Qty Hangers"
        Me.ColQtyItems.MinimumWidth = 8
        Me.ColQtyItems.Name = "ColQtyItems"
        Me.ColQtyItems.Width = 90
        '
        'ColNetAmount
        '
        Me.ColNetAmount.FillWeight = 140.0!
        Me.ColNetAmount.HeaderText = "Net Amount"
        Me.ColNetAmount.MinimumWidth = 8
        Me.ColNetAmount.Name = "ColNetAmount"
        Me.ColNetAmount.Width = 140
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label15.Location = New System.Drawing.Point(51, 181)
        Me.Label15.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(107, 20)
        Me.Label15.TabIndex = 334
        Me.Label15.Text = "Delivery Date:"
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(880, 983)
        Me.cmdCancel.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(152, 54)
        Me.cmdCancel.TabIndex = 313
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cmdOK
        '
        Me.cmdOK.Location = New System.Drawing.Point(721, 983)
        Me.cmdOK.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(143, 54)
        Me.cmdOK.TabIndex = 312
        Me.cmdOK.Text = "OK"
        Me.cmdOK.UseVisualStyleBackColor = True
        '
        'DteMovementDate
        '
        Me.DteMovementDate.Location = New System.Drawing.Point(174, 181)
        Me.DteMovementDate.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.DteMovementDate.Name = "DteMovementDate"
        Me.DteMovementDate.Size = New System.Drawing.Size(417, 26)
        Me.DteMovementDate.TabIndex = 295
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(770, 176)
        Me.Label5.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(218, 37)
        Me.Label5.TabIndex = 325
        Me.Label5.Text = "Order Totals:"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBox1.Location = New System.Drawing.Point(1221, 1343)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(147, 27)
        Me.CheckBox1.TabIndex = 354
        Me.CheckBox1.Text = "Direct To Shop"
        Me.CheckBox1.UseVisualStyleBackColor = True
        Me.CheckBox1.Visible = False
        '
        'PurchaseOrderForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1057, 1049)
        Me.Controls.Add(Me.CmdDeleteFromGrid)
        Me.Controls.Add(Me.TxtNetCostLine)
        Me.Controls.Add(Me.CmdAddToGrid)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.TxtQtyHangers)
        Me.Controls.Add(Me.TxtQtyBoxes)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.TxtStockCode)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.TxtQtyGarments)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.label28)
        Me.Controls.Add(Me.TxtOrderID)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.label11)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtTotalOrderPrice)
        Me.Controls.Add(Me.TxtTotalGarments)
        Me.Controls.Add(Me.TxtVATAmount)
        Me.Controls.Add(Me.TxtTotalNet)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.label27)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtShipperName)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtCommission)
        Me.Controls.Add(Me.TxtDeliveryCharges)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtShipperInvoiceNumber)
        Me.Controls.Add(Me.TxtSuppliersInvoiceNumber)
        Me.Controls.Add(Me.TxtTotalBoxes)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtTotalHangers)
        Me.Controls.Add(Me.label31)
        Me.Controls.Add(Me.TxtNotes)
        Me.Controls.Add(Me.TxtWarehouseName)
        Me.Controls.Add(Me.label26)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.label12)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.TxtSupplierName)
        Me.Controls.Add(Me.TxtOurRef)
        Me.Controls.Add(Me.TxtWarehouseRef)
        Me.Controls.Add(Me.label30)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.CboSeasonName)
        Me.Controls.Add(Me.TxtSupplierRef)
        Me.Controls.Add(Me.label29)
        Me.Controls.Add(Me.DgvItems)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.DteMovementDate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CheckBox1)
        Me.Name = "PurchaseOrderForm"
        Me.Text = "PurchaseOrderForm"
        CType(Me.DgvItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents CmdDeleteFromGrid As Button
    Private WithEvents TxtNetCostLine As TextBox
    Private WithEvents CmdAddToGrid As Button
    Friend WithEvents Label25 As Label
    Private WithEvents TxtQtyHangers As TextBox
    Private WithEvents TxtQtyBoxes As TextBox
    Friend WithEvents Label22 As Label
    Private WithEvents TxtStockCode As TextBox
    Friend WithEvents label1 As Label
    Private WithEvents TxtQtyGarments As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents label28 As Label
    Public WithEvents TxtOrderID As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents label11 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label6 As Label
    Private WithEvents TxtTotalOrderPrice As TextBox
    Private WithEvents TxtTotalGarments As TextBox
    Private WithEvents TxtVATAmount As TextBox
    Private WithEvents TxtTotalNet As TextBox
    Friend WithEvents Label9 As Label
    Private WithEvents label27 As Label
    Friend WithEvents Label7 As Label
    Private WithEvents TxtShipperName As TextBox
    Friend WithEvents Label8 As Label
    Private WithEvents TxtCommission As TextBox
    Private WithEvents TxtDeliveryCharges As TextBox
    Friend WithEvents Label2 As Label
    Private WithEvents TxtShipperInvoiceNumber As TextBox
    Private WithEvents TxtSuppliersInvoiceNumber As TextBox
    Private WithEvents TxtTotalBoxes As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Private WithEvents TxtTotalHangers As TextBox
    Private WithEvents label31 As Label
    Private WithEvents TxtNotes As TextBox
    Private WithEvents TxtWarehouseName As TextBox
    Friend WithEvents label26 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents label12 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label18 As Label
    Private WithEvents TxtSupplierName As TextBox
    Private WithEvents TxtOurRef As TextBox
    Private WithEvents TxtWarehouseRef As TextBox
    Private WithEvents label30 As Label
    Friend WithEvents Label16 As Label
    Private WithEvents CboSeasonName As ComboBox
    Private WithEvents TxtSupplierRef As TextBox
    Private WithEvents label29 As Label
    Private WithEvents DgvItems As DataGridView
    Private WithEvents ColStockCode As DataGridViewTextBoxColumn
    Private WithEvents ColQtyLoose As DataGridViewTextBoxColumn
    Private WithEvents ColQtyBoxes As DataGridViewTextBoxColumn
    Private WithEvents ColQtyItems As DataGridViewTextBoxColumn
    Private WithEvents ColNetAmount As DataGridViewTextBoxColumn
    Friend WithEvents Label15 As Label
    Friend WithEvents cmdCancel As Button
    Friend WithEvents cmdOK As Button
    Private WithEvents DteMovementDate As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents CheckBox1 As CheckBox
End Class
