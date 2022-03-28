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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        CType(Me.DgvItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'CmdDeleteFromGrid
        '
        Me.CmdDeleteFromGrid.Location = New System.Drawing.Point(909, 102)
        Me.CmdDeleteFromGrid.Margin = New System.Windows.Forms.Padding(11, 8, 11, 8)
        Me.CmdDeleteFromGrid.Name = "CmdDeleteFromGrid"
        Me.CmdDeleteFromGrid.Size = New System.Drawing.Size(142, 49)
        Me.CmdDeleteFromGrid.TabIndex = 304
        Me.CmdDeleteFromGrid.Text = "Remove"
        Me.CmdDeleteFromGrid.UseVisualStyleBackColor = True
        '
        'TxtNetCostLine
        '
        Me.TxtNetCostLine.Location = New System.Drawing.Point(909, 55)
        Me.TxtNetCostLine.Margin = New System.Windows.Forms.Padding(11, 8, 11, 8)
        Me.TxtNetCostLine.Name = "TxtNetCostLine"
        Me.TxtNetCostLine.Size = New System.Drawing.Size(142, 31)
        Me.TxtNetCostLine.TabIndex = 302
        '
        'CmdAddToGrid
        '
        Me.CmdAddToGrid.Location = New System.Drawing.Point(724, 102)
        Me.CmdAddToGrid.Margin = New System.Windows.Forms.Padding(11, 8, 11, 8)
        Me.CmdAddToGrid.Name = "CmdAddToGrid"
        Me.CmdAddToGrid.Size = New System.Drawing.Size(163, 49)
        Me.CmdAddToGrid.TabIndex = 303
        Me.CmdAddToGrid.Text = "Add"
        Me.CmdAddToGrid.UseVisualStyleBackColor = True
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label25.Location = New System.Drawing.Point(909, 0)
        Me.Label25.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(95, 25)
        Me.Label25.TabIndex = 342
        Me.Label25.Text = "Net Cost"
        '
        'TxtQtyHangers
        '
        Me.TxtQtyHangers.Location = New System.Drawing.Point(724, 55)
        Me.TxtQtyHangers.Margin = New System.Windows.Forms.Padding(11, 8, 11, 8)
        Me.TxtQtyHangers.Name = "TxtQtyHangers"
        Me.TxtQtyHangers.Size = New System.Drawing.Size(163, 31)
        Me.TxtQtyHangers.TabIndex = 301
        '
        'TxtQtyBoxes
        '
        Me.TxtQtyBoxes.Location = New System.Drawing.Point(580, 55)
        Me.TxtQtyBoxes.Margin = New System.Windows.Forms.Padding(11, 8, 11, 8)
        Me.TxtQtyBoxes.Name = "TxtQtyBoxes"
        Me.TxtQtyBoxes.Size = New System.Drawing.Size(122, 31)
        Me.TxtQtyBoxes.TabIndex = 300
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label22.Location = New System.Drawing.Point(724, 0)
        Me.Label22.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(132, 25)
        Me.Label22.TabIndex = 341
        Me.Label22.Text = "Qty Hangers"
        '
        'TxtStockCode
        '
        Me.TxtStockCode.Location = New System.Drawing.Point(11, 55)
        Me.TxtStockCode.Margin = New System.Windows.Forms.Padding(11, 8, 11, 8)
        Me.TxtStockCode.Name = "TxtStockCode"
        Me.TxtStockCode.Size = New System.Drawing.Size(384, 31)
        Me.TxtStockCode.TabIndex = 298
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.label1.Location = New System.Drawing.Point(580, 0)
        Me.label1.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(111, 25)
        Me.label1.TabIndex = 340
        Me.label1.Text = "Qty Boxes"
        '
        'TxtQtyGarments
        '
        Me.TxtQtyGarments.Location = New System.Drawing.Point(451, 55)
        Me.TxtQtyGarments.Margin = New System.Windows.Forms.Padding(11, 8, 11, 8)
        Me.TxtQtyGarments.Name = "TxtQtyGarments"
        Me.TxtQtyGarments.Size = New System.Drawing.Size(107, 31)
        Me.TxtQtyGarments.TabIndex = 299
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(184, 200)
        Me.Label24.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(24, 25)
        Me.Label24.TabIndex = 319
        Me.Label24.Text = "£"
        '
        'label28
        '
        Me.label28.AutoSize = True
        Me.label28.Location = New System.Drawing.Point(184, 160)
        Me.label28.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.label28.Name = "label28"
        Me.label28.Size = New System.Drawing.Size(24, 25)
        Me.label28.TabIndex = 320
        Me.label28.Text = "£"
        '
        'TxtOrderID
        '
        Me.TxtOrderID.Location = New System.Drawing.Point(249, 8)
        Me.TxtOrderID.Margin = New System.Windows.Forms.Padding(11, 8, 11, 8)
        Me.TxtOrderID.Name = "TxtOrderID"
        Me.TxtOrderID.Size = New System.Drawing.Size(284, 31)
        Me.TxtOrderID.TabIndex = 316
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(184, 110)
        Me.Label23.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(24, 25)
        Me.Label23.TabIndex = 321
        Me.Label23.Text = "£"
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.label11.Location = New System.Drawing.Point(451, 0)
        Me.label11.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(105, 47)
        Me.label11.TabIndex = 339
        Me.label11.Text = "Qty Garments"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(184, 55)
        Me.Label19.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(24, 25)
        Me.Label19.TabIndex = 322
        Me.Label19.Text = "£"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(184, 0)
        Me.Label14.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(24, 25)
        Me.Label14.TabIndex = 323
        Me.Label14.Text = "£"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label21.Location = New System.Drawing.Point(11, 0)
        Me.Label21.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(123, 25)
        Me.Label21.TabIndex = 338
        Me.Label21.Text = "Stock Code"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 0)
        Me.Label6.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 25)
        Me.Label6.TabIndex = 324
        Me.Label6.Text = "Net:"
        '
        'TxtTotalOrderPrice
        '
        Me.TxtTotalOrderPrice.Location = New System.Drawing.Point(234, 208)
        Me.TxtTotalOrderPrice.Margin = New System.Windows.Forms.Padding(11, 8, 11, 8)
        Me.TxtTotalOrderPrice.Name = "TxtTotalOrderPrice"
        Me.TxtTotalOrderPrice.Size = New System.Drawing.Size(233, 31)
        Me.TxtTotalOrderPrice.TabIndex = 318
        '
        'TxtTotalGarments
        '
        Me.TxtTotalGarments.Location = New System.Drawing.Point(11, 33)
        Me.TxtTotalGarments.Margin = New System.Windows.Forms.Padding(11, 8, 11, 8)
        Me.TxtTotalGarments.Name = "TxtTotalGarments"
        Me.TxtTotalGarments.Size = New System.Drawing.Size(139, 31)
        Me.TxtTotalGarments.TabIndex = 350
        '
        'TxtVATAmount
        '
        Me.TxtVATAmount.Location = New System.Drawing.Point(230, 168)
        Me.TxtVATAmount.Margin = New System.Windows.Forms.Padding(7, 8, 7, 8)
        Me.TxtVATAmount.Name = "TxtVATAmount"
        Me.TxtVATAmount.Size = New System.Drawing.Size(233, 31)
        Me.TxtVATAmount.TabIndex = 311
        Me.TxtVATAmount.Text = "0.00"
        '
        'TxtTotalNet
        '
        Me.TxtTotalNet.Location = New System.Drawing.Point(234, 8)
        Me.TxtTotalNet.Margin = New System.Windows.Forms.Padding(11, 8, 11, 8)
        Me.TxtTotalNet.Name = "TxtTotalNet"
        Me.TxtTotalNet.Size = New System.Drawing.Size(233, 31)
        Me.TxtTotalNet.TabIndex = 317
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(11, 200)
        Me.Label9.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 25)
        Me.Label9.TabIndex = 343
        Me.Label9.Text = "Total:"
        '
        'label27
        '
        Me.label27.AutoSize = True
        Me.label27.Location = New System.Drawing.Point(7, 160)
        Me.label27.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.label27.Name = "label27"
        Me.label27.Size = New System.Drawing.Size(156, 25)
        Me.label27.TabIndex = 344
        Me.label27.Text = "Purchase VAT:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label7.Location = New System.Drawing.Point(11, 55)
        Me.Label7.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 50)
        Me.Label7.TabIndex = 346
        Me.Label7.Text = "Delivery Charges:"
        '
        'TxtShipperName
        '
        Me.TxtShipperName.Location = New System.Drawing.Point(249, 60)
        Me.TxtShipperName.Margin = New System.Windows.Forms.Padding(11, 8, 11, 8)
        Me.TxtShipperName.Name = "TxtShipperName"
        Me.TxtShipperName.Size = New System.Drawing.Size(284, 31)
        Me.TxtShipperName.TabIndex = 306
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label8.Location = New System.Drawing.Point(11, 110)
        Me.Label8.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(135, 25)
        Me.Label8.TabIndex = 345
        Me.Label8.Text = "Commission:"
        '
        'TxtCommission
        '
        Me.TxtCommission.Location = New System.Drawing.Point(234, 118)
        Me.TxtCommission.Margin = New System.Windows.Forms.Padding(11, 8, 11, 8)
        Me.TxtCommission.Name = "TxtCommission"
        Me.TxtCommission.Size = New System.Drawing.Size(233, 31)
        Me.TxtCommission.TabIndex = 310
        Me.TxtCommission.Text = "0.00"
        '
        'TxtDeliveryCharges
        '
        Me.TxtDeliveryCharges.Location = New System.Drawing.Point(234, 63)
        Me.TxtDeliveryCharges.Margin = New System.Windows.Forms.Padding(11, 8, 11, 8)
        Me.TxtDeliveryCharges.Name = "TxtDeliveryCharges"
        Me.TxtDeliveryCharges.Size = New System.Drawing.Size(233, 31)
        Me.TxtDeliveryCharges.TabIndex = 309
        Me.TxtDeliveryCharges.Text = "0.00"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label2.Location = New System.Drawing.Point(11, 52)
        Me.Label2.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 25)
        Me.Label2.TabIndex = 328
        Me.Label2.Text = "Shipper:"
        '
        'TxtShipperInvoiceNumber
        '
        Me.TxtShipperInvoiceNumber.Location = New System.Drawing.Point(249, 100)
        Me.TxtShipperInvoiceNumber.Margin = New System.Windows.Forms.Padding(11, 8, 11, 8)
        Me.TxtShipperInvoiceNumber.Name = "TxtShipperInvoiceNumber"
        Me.TxtShipperInvoiceNumber.Size = New System.Drawing.Size(284, 31)
        Me.TxtShipperInvoiceNumber.TabIndex = 307
        '
        'TxtSuppliersInvoiceNumber
        '
        Me.TxtSuppliersInvoiceNumber.Location = New System.Drawing.Point(249, 151)
        Me.TxtSuppliersInvoiceNumber.Margin = New System.Windows.Forms.Padding(11, 8, 11, 8)
        Me.TxtSuppliersInvoiceNumber.Name = "TxtSuppliersInvoiceNumber"
        Me.TxtSuppliersInvoiceNumber.Size = New System.Drawing.Size(284, 31)
        Me.TxtSuppliersInvoiceNumber.TabIndex = 308
        '
        'TxtTotalBoxes
        '
        Me.TxtTotalBoxes.Location = New System.Drawing.Point(195, 33)
        Me.TxtTotalBoxes.Margin = New System.Windows.Forms.Padding(11, 8, 11, 8)
        Me.TxtTotalBoxes.Name = "TxtTotalBoxes"
        Me.TxtTotalBoxes.Size = New System.Drawing.Size(139, 31)
        Me.TxtTotalBoxes.TabIndex = 349
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label3.Location = New System.Drawing.Point(11, 92)
        Me.Label3.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(199, 25)
        Me.Label3.TabIndex = 327
        Me.Label3.Text = "Shipper Invoice No:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label4.Location = New System.Drawing.Point(11, 143)
        Me.Label4.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(215, 25)
        Me.Label4.TabIndex = 326
        Me.Label4.Text = "Suppliers Invoice No:"
        '
        'TxtTotalHangers
        '
        Me.TxtTotalHangers.Location = New System.Drawing.Point(383, 33)
        Me.TxtTotalHangers.Margin = New System.Windows.Forms.Padding(11, 8, 11, 8)
        Me.TxtTotalHangers.Name = "TxtTotalHangers"
        Me.TxtTotalHangers.Size = New System.Drawing.Size(139, 31)
        Me.TxtTotalHangers.TabIndex = 348
        '
        'label31
        '
        Me.label31.AutoSize = True
        Me.label31.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.label31.Location = New System.Drawing.Point(7, 298)
        Me.label31.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.label31.Name = "label31"
        Me.label31.Size = New System.Drawing.Size(74, 25)
        Me.label31.TabIndex = 337
        Me.label31.Text = "Notes:"
        '
        'TxtNotes
        '
        Me.TxtNotes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtNotes.Location = New System.Drawing.Point(223, 306)
        Me.TxtNotes.Margin = New System.Windows.Forms.Padding(11, 8, 11, 8)
        Me.TxtNotes.Multiline = True
        Me.TxtNotes.Name = "TxtNotes"
        Me.TxtNotes.Size = New System.Drawing.Size(424, 268)
        Me.TxtNotes.TabIndex = 305
        '
        'TxtWarehouseName
        '
        Me.TxtWarehouseName.Location = New System.Drawing.Point(223, 53)
        Me.TxtWarehouseName.Margin = New System.Windows.Forms.Padding(11, 8, 11, 8)
        Me.TxtWarehouseName.Name = "TxtWarehouseName"
        Me.TxtWarehouseName.Size = New System.Drawing.Size(424, 31)
        Me.TxtWarehouseName.TabIndex = 315
        '
        'label26
        '
        Me.label26.AutoSize = True
        Me.label26.Location = New System.Drawing.Point(11, 0)
        Me.label26.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.label26.Name = "label26"
        Me.label26.Size = New System.Drawing.Size(131, 25)
        Me.label26.TabIndex = 353
        Me.label26.Text = "Total Loose:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(11, 0)
        Me.Label13.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(105, 25)
        Me.Label13.TabIndex = 329
        Me.Label13.Text = "Order No:"
        '
        'label12
        '
        Me.label12.AutoSize = True
        Me.label12.Location = New System.Drawing.Point(195, 0)
        Me.label12.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(132, 25)
        Me.label12.TabIndex = 352
        Me.label12.Text = "Total Boxes:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(383, 0)
        Me.Label10.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(123, 25)
        Me.Label10.TabIndex = 351
        Me.Label10.Text = "Total Items:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(11, 131)
        Me.Label17.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(159, 25)
        Me.Label17.TabIndex = 333
        Me.Label17.Text = "Supplier Name:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(11, 45)
        Me.Label20.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(190, 25)
        Me.Label20.TabIndex = 331
        Me.Label20.Text = "Warehouse Name:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label18.Location = New System.Drawing.Point(11, 0)
        Me.Label18.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(167, 25)
        Me.Label18.TabIndex = 330
        Me.Label18.Text = "Warehouse Ref:"
        '
        'TxtSupplierName
        '
        Me.TxtSupplierName.Location = New System.Drawing.Point(223, 139)
        Me.TxtSupplierName.Margin = New System.Windows.Forms.Padding(11, 8, 11, 8)
        Me.TxtSupplierName.Name = "TxtSupplierName"
        Me.TxtSupplierName.Size = New System.Drawing.Size(424, 31)
        Me.TxtSupplierName.TabIndex = 314
        '
        'TxtOurRef
        '
        Me.TxtOurRef.Location = New System.Drawing.Point(219, 225)
        Me.TxtOurRef.Margin = New System.Windows.Forms.Padding(7, 8, 7, 8)
        Me.TxtOurRef.Name = "TxtOurRef"
        Me.TxtOurRef.Size = New System.Drawing.Size(432, 31)
        Me.TxtOurRef.TabIndex = 296
        '
        'TxtWarehouseRef
        '
        Me.TxtWarehouseRef.Location = New System.Drawing.Point(223, 8)
        Me.TxtWarehouseRef.Margin = New System.Windows.Forms.Padding(11, 8, 11, 8)
        Me.TxtWarehouseRef.Name = "TxtWarehouseRef"
        Me.TxtWarehouseRef.Size = New System.Drawing.Size(345, 31)
        Me.TxtWarehouseRef.TabIndex = 293
        '
        'label30
        '
        Me.label30.AutoSize = True
        Me.label30.Location = New System.Drawing.Point(7, 217)
        Me.label30.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.label30.Name = "label30"
        Me.label30.Size = New System.Drawing.Size(92, 25)
        Me.label30.TabIndex = 335
        Me.label30.Text = "Our Ref:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label16.Location = New System.Drawing.Point(11, 90)
        Me.Label16.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(136, 25)
        Me.Label16.TabIndex = 332
        Me.Label16.Text = "Supplier Ref:"
        '
        'CboSeasonName
        '
        Me.CboSeasonName.FormattingEnabled = True
        Me.CboSeasonName.Location = New System.Drawing.Point(219, 263)
        Me.CboSeasonName.Margin = New System.Windows.Forms.Padding(7, 8, 7, 8)
        Me.CboSeasonName.Name = "CboSeasonName"
        Me.CboSeasonName.Size = New System.Drawing.Size(432, 33)
        Me.CboSeasonName.TabIndex = 297
        '
        'TxtSupplierRef
        '
        Me.TxtSupplierRef.Location = New System.Drawing.Point(223, 98)
        Me.TxtSupplierRef.Margin = New System.Windows.Forms.Padding(11, 8, 11, 8)
        Me.TxtSupplierRef.Name = "TxtSupplierRef"
        Me.TxtSupplierRef.Size = New System.Drawing.Size(345, 31)
        Me.TxtSupplierRef.TabIndex = 294
        '
        'label29
        '
        Me.label29.AutoSize = True
        Me.label29.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.label29.Location = New System.Drawing.Point(7, 255)
        Me.label29.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.label29.Name = "label29"
        Me.label29.Size = New System.Drawing.Size(91, 25)
        Me.label29.TabIndex = 336
        Me.label29.Text = "Season:"
        '
        'DgvItems
        '
        Me.DgvItems.AllowUserToAddRows = False
        Me.DgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvItems.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColStockCode, Me.ColQtyLoose, Me.ColQtyBoxes, Me.ColQtyItems, Me.ColNetAmount})
        Me.DgvItems.Location = New System.Drawing.Point(12, 784)
        Me.DgvItems.Margin = New System.Windows.Forms.Padding(11, 8, 11, 8)
        Me.DgvItems.Name = "DgvItems"
        Me.DgvItems.RowHeadersWidth = 51
        Me.DgvItems.Size = New System.Drawing.Size(1212, 339)
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
        Me.Label15.Location = New System.Drawing.Point(11, 177)
        Me.Label15.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(147, 25)
        Me.Label15.TabIndex = 334
        Me.Label15.Text = "Delivery Date:"
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(1021, 1139)
        Me.cmdCancel.Margin = New System.Windows.Forms.Padding(11, 8, 11, 8)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(203, 68)
        Me.cmdCancel.TabIndex = 313
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cmdOK
        '
        Me.cmdOK.Location = New System.Drawing.Point(808, 1139)
        Me.cmdOK.Margin = New System.Windows.Forms.Padding(11, 8, 11, 8)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(191, 68)
        Me.cmdOK.TabIndex = 312
        Me.cmdOK.Text = "OK"
        Me.cmdOK.UseVisualStyleBackColor = True
        '
        'DteMovementDate
        '
        Me.DteMovementDate.Location = New System.Drawing.Point(223, 185)
        Me.DteMovementDate.Margin = New System.Windows.Forms.Padding(11, 8, 11, 8)
        Me.DteMovementDate.Name = "DteMovementDate"
        Me.DteMovementDate.Size = New System.Drawing.Size(424, 31)
        Me.DteMovementDate.TabIndex = 295
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(1027, 220)
        Me.Label5.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(218, 37)
        Me.Label5.TabIndex = 325
        Me.Label5.Text = "Order Totals:"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBox1.Location = New System.Drawing.Point(1628, 1679)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(11, 8, 11, 8)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(187, 29)
        Me.CheckBox1.TabIndex = 354
        Me.CheckBox1.Text = "Direct To Shop"
        Me.CheckBox1.UseVisualStyleBackColor = True
        Me.CheckBox1.Visible = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.51768!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.48232!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 211.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.label26, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtTotalBoxes, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label10, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtTotalHangers, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.label12, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtTotalGarments, 0, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(28, 1134)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.23529!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.76471!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(584, 68)
        Me.TableLayoutPanel1.TabIndex = 355
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 5
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.32919!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.67081!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 144.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 185.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 164.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label21, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TxtStockCode, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.CmdDeleteFromGrid, 4, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.label11, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.CmdAddToGrid, 3, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.TxtNetCostLine, 4, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.label1, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TxtQtyGarments, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label25, 4, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TxtQtyBoxes, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.TxtQtyHangers, 3, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label22, 3, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(12, 608)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1063, 165)
        Me.TableLayoutPanel2.TabIndex = 356
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.21885!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.78116!))
        Me.TableLayoutPanel3.Controls.Add(Me.Label18, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.TxtWarehouseRef, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label20, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.TxtWarehouseName, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label16, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.TxtSupplierRef, 1, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.Label17, 0, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.TxtSupplierName, 1, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.DteMovementDate, 1, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.Label15, 0, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.TxtOurRef, 1, 5)
        Me.TableLayoutPanel3.Controls.Add(Me.label30, 0, 5)
        Me.TableLayoutPanel3.Controls.Add(Me.CboSeasonName, 1, 6)
        Me.TableLayoutPanel3.Controls.Add(Me.label29, 0, 6)
        Me.TableLayoutPanel3.Controls.Add(Me.TxtNotes, 1, 7)
        Me.TableLayoutPanel3.Controls.Add(Me.label31, 0, 7)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(12, 12)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 8
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 284.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(658, 582)
        Me.TableLayoutPanel3.TabIndex = 357
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.93382!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.06618!))
        Me.TableLayoutPanel4.Controls.Add(Me.Label13, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.Label3, 0, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.Label4, 0, 3)
        Me.TableLayoutPanel4.Controls.Add(Me.TxtOrderID, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.TxtShipperName, 1, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.TxtShipperInvoiceNumber, 1, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.TxtSuppliersInvoiceNumber, 1, 3)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(691, 12)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 4
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.14035!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.85965!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(544, 202)
        Me.TableLayoutPanel4.TabIndex = 358
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 3
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.63713!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.36287!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 263.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.Label6, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.Label7, 0, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.Label8, 0, 2)
        Me.TableLayoutPanel5.Controls.Add(Me.label27, 0, 3)
        Me.TableLayoutPanel5.Controls.Add(Me.Label9, 0, 4)
        Me.TableLayoutPanel5.Controls.Add(Me.TxtTotalOrderPrice, 2, 4)
        Me.TableLayoutPanel5.Controls.Add(Me.Label24, 1, 4)
        Me.TableLayoutPanel5.Controls.Add(Me.TxtVATAmount, 2, 3)
        Me.TableLayoutPanel5.Controls.Add(Me.Label14, 1, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.TxtCommission, 2, 2)
        Me.TableLayoutPanel5.Controls.Add(Me.TxtTotalNet, 2, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.TxtDeliveryCharges, 2, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.label28, 1, 3)
        Me.TableLayoutPanel5.Controls.Add(Me.Label19, 1, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.Label23, 1, 2)
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(691, 275)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 5
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(487, 246)
        Me.TableLayoutPanel5.TabIndex = 359
        '
        'PurchaseOrderForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1248, 1217)
        Me.Controls.Add(Me.TableLayoutPanel5)
        Me.Controls.Add(Me.TableLayoutPanel4)
        Me.Controls.Add(Me.TableLayoutPanel3)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.DgvItems)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CheckBox1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "PurchaseOrderForm"
        Me.Text = "PurchaseOrderForm"
        CType(Me.DgvItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
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
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
End Class
