<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WarehouseForm
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
        Me.components = New System.ComponentModel.Container()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CmdClear = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CmdCancel = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboWType = New System.Windows.Forms.ComboBox()
        Me.CmdOK = New System.Windows.Forms.Button()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TxteMail = New System.Windows.Forms.TextBox()
        Me.TxtFax = New System.Windows.Forms.TextBox()
        Me.TxtWebsite = New System.Windows.Forms.TextBox()
        Me.TxtTelephone1 = New System.Windows.Forms.TextBox()
        Me.TxtPostCode = New System.Windows.Forms.TextBox()
        Me.TxtAddress4 = New System.Windows.Forms.TextBox()
        Me.TxtAddress3 = New System.Windows.Forms.TextBox()
        Me.TxtAddress2 = New System.Windows.Forms.TextBox()
        Me.TxtAddress1 = New System.Windows.Forms.TextBox()
        Me.TxtContactName = New System.Windows.Forms.TextBox()
        Me.TxtWarehouseName = New System.Windows.Forms.TextBox()
        Me.TxtWarehouseRef = New System.Windows.Forms.TextBox()
        Me.TxtMemo = New System.Windows.Forms.TextBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.label9 = New System.Windows.Forms.Label()
        Me.TxtTotalValue = New System.Windows.Forms.Label()
        Me.TxtTotalStock = New System.Windows.Forms.Label()
        Me.gridStock = New System.Windows.Forms.DataGridView()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.gridTrans = New System.Windows.Forms.DataGridView()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.bindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.bindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabPage1.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.gridStock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.gridTrans, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.bindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(613, 19)
        Me.Label4.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 29)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Type:"
        '
        'CmdClear
        '
        Me.CmdClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdClear.Location = New System.Drawing.Point(822, 619)
        Me.CmdClear.Margin = New System.Windows.Forms.Padding(11, 8, 11, 8)
        Me.CmdClear.Name = "CmdClear"
        Me.CmdClear.Size = New System.Drawing.Size(251, 58)
        Me.CmdClear.TabIndex = 15
        Me.CmdClear.Text = "Clear"
        Me.CmdClear.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(161, 513)
        Me.Label11.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(74, 29)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "EMail"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(128, 464)
        Me.Label10.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(107, 29)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Website:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(602, 411)
        Me.Label8.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 29)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Fax:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(98, 415)
        Me.Label7.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(137, 29)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Telephone:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(103, 362)
        Me.Label6.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(132, 29)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Post Code:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(133, 170)
        Me.Label5.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 29)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Address"
        '
        'CmdCancel
        '
        Me.CmdCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdCancel.Location = New System.Drawing.Point(549, 619)
        Me.CmdCancel.Margin = New System.Windows.Forms.Padding(11, 8, 11, 8)
        Me.CmdCancel.Name = "CmdCancel"
        Me.CmdCancel.Size = New System.Drawing.Size(251, 58)
        Me.CmdCancel.TabIndex = 14
        Me.CmdCancel.Text = "Cancel"
        Me.CmdCancel.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(64, 117)
        Me.Label3.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(171, 29)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Contact Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 72)
        Me.Label2.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(213, 29)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Warehouse Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(50, 18)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(185, 29)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Warehouse Ref:"
        '
        'cboWType
        '
        Me.cboWType.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboWType.FormattingEnabled = True
        Me.cboWType.Items.AddRange(New Object() {"Active Warehouse", "WriteOff Warehouse"})
        Me.cboWType.Location = New System.Drawing.Point(709, 15)
        Me.cboWType.Margin = New System.Windows.Forms.Padding(11, 8, 11, 8)
        Me.cboWType.Name = "cboWType"
        Me.cboWType.Size = New System.Drawing.Size(332, 37)
        Me.cboWType.TabIndex = 1
        '
        'CmdOK
        '
        Me.CmdOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdOK.Location = New System.Drawing.Point(276, 619)
        Me.CmdOK.Margin = New System.Windows.Forms.Padding(11, 8, 11, 8)
        Me.CmdOK.Name = "CmdOK"
        Me.CmdOK.Size = New System.Drawing.Size(251, 58)
        Me.CmdOK.TabIndex = 13
        Me.CmdOK.Text = "Button1"
        Me.CmdOK.UseVisualStyleBackColor = True
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Silver
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.cboWType)
        Me.TabPage1.Controls.Add(Me.TxteMail)
        Me.TabPage1.Controls.Add(Me.TxtFax)
        Me.TabPage1.Controls.Add(Me.TxtWebsite)
        Me.TabPage1.Controls.Add(Me.TxtTelephone1)
        Me.TabPage1.Controls.Add(Me.TxtPostCode)
        Me.TabPage1.Controls.Add(Me.TxtAddress4)
        Me.TabPage1.Controls.Add(Me.TxtAddress3)
        Me.TabPage1.Controls.Add(Me.TxtAddress2)
        Me.TabPage1.Controls.Add(Me.TxtAddress1)
        Me.TabPage1.Controls.Add(Me.TxtContactName)
        Me.TabPage1.Controls.Add(Me.TxtWarehouseName)
        Me.TabPage1.Controls.Add(Me.TxtWarehouseRef)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(11, 8, 11, 8)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(11, 8, 11, 8)
        Me.TabPage1.Size = New System.Drawing.Size(1061, 564)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "General"
        '
        'TxteMail
        '
        Me.TxteMail.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxteMail.Location = New System.Drawing.Point(246, 509)
        Me.TxteMail.Margin = New System.Windows.Forms.Padding(11, 8, 11, 8)
        Me.TxteMail.MaxLength = 255
        Me.TxteMail.Name = "TxteMail"
        Me.TxteMail.Size = New System.Drawing.Size(727, 33)
        Me.TxteMail.TabIndex = 12
        '
        'TxtFax
        '
        Me.TxtFax.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFax.Location = New System.Drawing.Point(660, 412)
        Me.TxtFax.Margin = New System.Windows.Forms.Padding(11, 8, 11, 8)
        Me.TxtFax.MaxLength = 20
        Me.TxtFax.Name = "TxtFax"
        Me.TxtFax.Size = New System.Drawing.Size(251, 33)
        Me.TxtFax.TabIndex = 10
        '
        'TxtWebsite
        '
        Me.TxtWebsite.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtWebsite.Location = New System.Drawing.Point(246, 460)
        Me.TxtWebsite.Margin = New System.Windows.Forms.Padding(11, 8, 11, 8)
        Me.TxtWebsite.MaxLength = 255
        Me.TxtWebsite.Name = "TxtWebsite"
        Me.TxtWebsite.Size = New System.Drawing.Size(727, 33)
        Me.TxtWebsite.TabIndex = 11
        '
        'TxtTelephone1
        '
        Me.TxtTelephone1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTelephone1.Location = New System.Drawing.Point(246, 411)
        Me.TxtTelephone1.Margin = New System.Windows.Forms.Padding(11, 8, 11, 8)
        Me.TxtTelephone1.MaxLength = 20
        Me.TxtTelephone1.Name = "TxtTelephone1"
        Me.TxtTelephone1.Size = New System.Drawing.Size(334, 33)
        Me.TxtTelephone1.TabIndex = 9
        '
        'TxtPostCode
        '
        Me.TxtPostCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPostCode.Location = New System.Drawing.Point(246, 362)
        Me.TxtPostCode.Margin = New System.Windows.Forms.Padding(11, 8, 11, 8)
        Me.TxtPostCode.MaxLength = 10
        Me.TxtPostCode.Name = "TxtPostCode"
        Me.TxtPostCode.Size = New System.Drawing.Size(334, 33)
        Me.TxtPostCode.TabIndex = 8
        '
        'TxtAddress4
        '
        Me.TxtAddress4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAddress4.Location = New System.Drawing.Point(246, 313)
        Me.TxtAddress4.Margin = New System.Windows.Forms.Padding(11, 8, 11, 8)
        Me.TxtAddress4.MaxLength = 50
        Me.TxtAddress4.Name = "TxtAddress4"
        Me.TxtAddress4.Size = New System.Drawing.Size(795, 33)
        Me.TxtAddress4.TabIndex = 7
        '
        'TxtAddress3
        '
        Me.TxtAddress3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAddress3.Location = New System.Drawing.Point(246, 264)
        Me.TxtAddress3.Margin = New System.Windows.Forms.Padding(11, 8, 11, 8)
        Me.TxtAddress3.MaxLength = 50
        Me.TxtAddress3.Name = "TxtAddress3"
        Me.TxtAddress3.Size = New System.Drawing.Size(795, 33)
        Me.TxtAddress3.TabIndex = 6
        '
        'TxtAddress2
        '
        Me.TxtAddress2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAddress2.Location = New System.Drawing.Point(246, 215)
        Me.TxtAddress2.Margin = New System.Windows.Forms.Padding(11, 8, 11, 8)
        Me.TxtAddress2.MaxLength = 50
        Me.TxtAddress2.Name = "TxtAddress2"
        Me.TxtAddress2.Size = New System.Drawing.Size(795, 33)
        Me.TxtAddress2.TabIndex = 5
        '
        'TxtAddress1
        '
        Me.TxtAddress1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAddress1.Location = New System.Drawing.Point(246, 166)
        Me.TxtAddress1.Margin = New System.Windows.Forms.Padding(11, 8, 11, 8)
        Me.TxtAddress1.MaxLength = 50
        Me.TxtAddress1.Name = "TxtAddress1"
        Me.TxtAddress1.Size = New System.Drawing.Size(795, 33)
        Me.TxtAddress1.TabIndex = 4
        '
        'TxtContactName
        '
        Me.TxtContactName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtContactName.Location = New System.Drawing.Point(246, 117)
        Me.TxtContactName.Margin = New System.Windows.Forms.Padding(11, 8, 11, 8)
        Me.TxtContactName.MaxLength = 50
        Me.TxtContactName.Name = "TxtContactName"
        Me.TxtContactName.Size = New System.Drawing.Size(795, 33)
        Me.TxtContactName.TabIndex = 3
        '
        'TxtWarehouseName
        '
        Me.TxtWarehouseName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtWarehouseName.Location = New System.Drawing.Point(246, 68)
        Me.TxtWarehouseName.Margin = New System.Windows.Forms.Padding(11, 8, 11, 8)
        Me.TxtWarehouseName.MaxLength = 50
        Me.TxtWarehouseName.Name = "TxtWarehouseName"
        Me.TxtWarehouseName.Size = New System.Drawing.Size(795, 33)
        Me.TxtWarehouseName.TabIndex = 2
        '
        'TxtWarehouseRef
        '
        Me.TxtWarehouseRef.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtWarehouseRef.Location = New System.Drawing.Point(246, 15)
        Me.TxtWarehouseRef.Margin = New System.Windows.Forms.Padding(11, 8, 11, 8)
        Me.TxtWarehouseRef.MaxLength = 8
        Me.TxtWarehouseRef.Name = "TxtWarehouseRef"
        Me.TxtWarehouseRef.Size = New System.Drawing.Size(334, 33)
        Me.TxtWarehouseRef.TabIndex = 0
        '
        'TxtMemo
        '
        Me.TxtMemo.Location = New System.Drawing.Point(20, 15)
        Me.TxtMemo.Margin = New System.Windows.Forms.Padding(11, 8, 11, 8)
        Me.TxtMemo.Multiline = True
        Me.TxtMemo.Name = "TxtMemo"
        Me.TxtMemo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtMemo.Size = New System.Drawing.Size(1505, 885)
        Me.TxtMemo.TabIndex = 0
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.TxtMemo)
        Me.TabPage4.Location = New System.Drawing.Point(4, 29)
        Me.TabPage4.Margin = New System.Windows.Forms.Padding(11, 8, 11, 8)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(11, 8, 11, 8)
        Me.TabPage4.Size = New System.Drawing.Size(1444, 816)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Memo"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label9.Location = New System.Drawing.Point(737, 527)
        Me.label9.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(27, 29)
        Me.label9.TabIndex = 6
        Me.label9.Text = "0"
        '
        'TxtTotalValue
        '
        Me.TxtTotalValue.AutoSize = True
        Me.TxtTotalValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotalValue.Location = New System.Drawing.Point(945, 527)
        Me.TxtTotalValue.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.TxtTotalValue.Name = "TxtTotalValue"
        Me.TxtTotalValue.Size = New System.Drawing.Size(83, 29)
        Me.TxtTotalValue.TabIndex = 5
        Me.TxtTotalValue.Text = "£0000"
        '
        'TxtTotalStock
        '
        Me.TxtTotalStock.AutoSize = True
        Me.TxtTotalStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotalStock.Location = New System.Drawing.Point(625, 527)
        Me.TxtTotalStock.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.TxtTotalStock.Name = "TxtTotalStock"
        Me.TxtTotalStock.Size = New System.Drawing.Size(27, 29)
        Me.TxtTotalStock.TabIndex = 4
        Me.TxtTotalStock.Text = "0"
        '
        'gridStock
        '
        Me.gridStock.AllowUserToAddRows = False
        Me.gridStock.AllowUserToDeleteRows = False
        Me.gridStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gridStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridStock.Dock = System.Windows.Forms.DockStyle.Top
        Me.gridStock.Location = New System.Drawing.Point(11, 8)
        Me.gridStock.Margin = New System.Windows.Forms.Padding(11, 8, 11, 8)
        Me.gridStock.Name = "gridStock"
        Me.gridStock.ReadOnly = True
        Me.gridStock.RowHeadersWidth = 62
        Me.gridStock.Size = New System.Drawing.Size(1039, 500)
        Me.gridStock.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(20, 17)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(11, 8, 11, 8)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1069, 597)
        Me.TabControl1.TabIndex = 12
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.gridTrans)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(11, 8, 11, 8)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(11, 8, 11, 8)
        Me.TabPage2.Size = New System.Drawing.Size(1444, 816)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Transactions"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'gridTrans
        '
        Me.gridTrans.AllowUserToAddRows = False
        Me.gridTrans.AllowUserToDeleteRows = False
        Me.gridTrans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridTrans.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridTrans.Location = New System.Drawing.Point(11, 8)
        Me.gridTrans.Margin = New System.Windows.Forms.Padding(11, 8, 11, 8)
        Me.gridTrans.Name = "gridTrans"
        Me.gridTrans.ReadOnly = True
        Me.gridTrans.RowHeadersVisible = False
        Me.gridTrans.RowHeadersWidth = 62
        Me.gridTrans.Size = New System.Drawing.Size(1422, 800)
        Me.gridTrans.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.label9)
        Me.TabPage3.Controls.Add(Me.TxtTotalValue)
        Me.TabPage3.Controls.Add(Me.TxtTotalStock)
        Me.TabPage3.Controls.Add(Me.Label12)
        Me.TabPage3.Controls.Add(Me.gridStock)
        Me.TabPage3.Location = New System.Drawing.Point(4, 29)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(11, 8, 11, 8)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(11, 8, 11, 8)
        Me.TabPage3.Size = New System.Drawing.Size(1061, 564)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Stock"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(359, 527)
        Me.Label12.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(93, 29)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Totals:"
        '
        'WarehouseForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1093, 694)
        Me.Controls.Add(Me.CmdClear)
        Me.Controls.Add(Me.CmdCancel)
        Me.Controls.Add(Me.CmdOK)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "WarehouseForm"
        Me.Text = "Warehouse"
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.gridStock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.gridTrans, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.bindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents CmdClear As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Private WithEvents bindingSource2 As BindingSource
    Friend WithEvents Label5 As Label
    Friend WithEvents CmdCancel As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cboWType As ComboBox
    Public WithEvents CmdOK As Button
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TxteMail As TextBox
    Friend WithEvents TxtFax As TextBox
    Friend WithEvents TxtWebsite As TextBox
    Friend WithEvents TxtTelephone1 As TextBox
    Friend WithEvents TxtPostCode As TextBox
    Friend WithEvents TxtAddress4 As TextBox
    Friend WithEvents TxtAddress3 As TextBox
    Friend WithEvents TxtAddress2 As TextBox
    Friend WithEvents TxtAddress1 As TextBox
    Friend WithEvents TxtContactName As TextBox
    Friend WithEvents TxtWarehouseName As TextBox
    Friend WithEvents TxtWarehouseRef As TextBox
    Friend WithEvents TxtMemo As TextBox
    Private WithEvents bindingSource1 As BindingSource
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents label9 As Label
    Friend WithEvents TxtTotalValue As Label
    Friend WithEvents TxtTotalStock As Label
    Friend WithEvents gridStock As DataGridView
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents gridTrans As DataGridView
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Label12 As Label
End Class
