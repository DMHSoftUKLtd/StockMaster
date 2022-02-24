<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ShopForm
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
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CmdClear = New System.Windows.Forms.Button()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboWType = New System.Windows.Forms.ComboBox()
        Me.TxteMail = New System.Windows.Forms.TextBox()
        Me.TxtFax = New System.Windows.Forms.TextBox()
        Me.TxtTelephone1 = New System.Windows.Forms.TextBox()
        Me.TxtPostCode = New System.Windows.Forms.TextBox()
        Me.TxtAddress4 = New System.Windows.Forms.TextBox()
        Me.TxtAddress3 = New System.Windows.Forms.TextBox()
        Me.TxtAddress2 = New System.Windows.Forms.TextBox()
        Me.TxtAddress1 = New System.Windows.Forms.TextBox()
        Me.TxtContactName = New System.Windows.Forms.TextBox()
        Me.TxtShopName = New System.Windows.Forms.TextBox()
        Me.TxtShopRef = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.gridTrans = New System.Windows.Forms.DataGridView()
        Me.TxtMemo = New System.Windows.Forms.TextBox()
        Me.CmdOK = New System.Windows.Forms.Button()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.CmdCancel = New System.Windows.Forms.Button()
        Me.label13 = New System.Windows.Forms.Label()
        Me.TxtTotalValue = New System.Windows.Forms.Label()
        Me.TxtTotalItems = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.gridStocks = New System.Windows.Forms.DataGridView()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.gridTrans, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.gridStocks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(71, 437)
        Me.Label11.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 20)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "EMail"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(80, 395)
        Me.Label8.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 20)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Fax:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(31, 350)
        Me.Label7.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 20)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Telephone:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(32, 305)
        Me.Label6.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 20)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Post Code:"
        '
        'CmdClear
        '
        Me.CmdClear.Location = New System.Drawing.Point(831, 551)
        Me.CmdClear.Margin = New System.Windows.Forms.Padding(11, 8, 11, 8)
        Me.CmdClear.Name = "CmdClear"
        Me.CmdClear.Size = New System.Drawing.Size(181, 32)
        Me.CmdClear.TabIndex = 15
        Me.CmdClear.Text = "Clear"
        Me.CmdClear.UseVisualStyleBackColor = True
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Orange
        Me.TabPage1.Controls.Add(Me.Label11)
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
        Me.TabPage1.Controls.Add(Me.TxtTelephone1)
        Me.TabPage1.Controls.Add(Me.TxtPostCode)
        Me.TabPage1.Controls.Add(Me.TxtAddress4)
        Me.TabPage1.Controls.Add(Me.TxtAddress3)
        Me.TabPage1.Controls.Add(Me.TxtAddress2)
        Me.TabPage1.Controls.Add(Me.TxtAddress1)
        Me.TabPage1.Controls.Add(Me.TxtContactName)
        Me.TabPage1.Controls.Add(Me.TxtShopName)
        Me.TabPage1.Controls.Add(Me.TxtShopRef)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(11, 8, 11, 8)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(11, 8, 11, 8)
        Me.TabPage1.Size = New System.Drawing.Size(988, 489)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "General"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(51, 143)
        Me.Label5.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 20)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Address"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(401, 16)
        Me.Label4.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 20)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Type:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 95)
        Me.Label3.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 20)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Contact Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 59)
        Me.Label2.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 20)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Shop Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 20)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Shop Ref:"
        '
        'cboWType
        '
        Me.cboWType.FormattingEnabled = True
        Me.cboWType.Items.AddRange(New Object() {"Shop", "Concession"})
        Me.cboWType.Location = New System.Drawing.Point(470, 13)
        Me.cboWType.Margin = New System.Windows.Forms.Padding(11, 8, 11, 8)
        Me.cboWType.Name = "cboWType"
        Me.cboWType.Size = New System.Drawing.Size(393, 28)
        Me.cboWType.TabIndex = 2
        '
        'TxteMail
        '
        Me.TxteMail.Location = New System.Drawing.Point(156, 431)
        Me.TxteMail.Margin = New System.Windows.Forms.Padding(11, 8, 11, 8)
        Me.TxteMail.MaxLength = 255
        Me.TxteMail.Name = "TxteMail"
        Me.TxteMail.Size = New System.Drawing.Size(816, 26)
        Me.TxteMail.TabIndex = 11
        '
        'TxtFax
        '
        Me.TxtFax.Location = New System.Drawing.Point(156, 389)
        Me.TxtFax.Margin = New System.Windows.Forms.Padding(11, 8, 11, 8)
        Me.TxtFax.MaxLength = 20
        Me.TxtFax.Name = "TxtFax"
        Me.TxtFax.Size = New System.Drawing.Size(272, 26)
        Me.TxtFax.TabIndex = 12
        '
        'TxtTelephone1
        '
        Me.TxtTelephone1.Location = New System.Drawing.Point(156, 347)
        Me.TxtTelephone1.Margin = New System.Windows.Forms.Padding(11, 8, 11, 8)
        Me.TxtTelephone1.MaxLength = 20
        Me.TxtTelephone1.Name = "TxtTelephone1"
        Me.TxtTelephone1.Size = New System.Drawing.Size(272, 26)
        Me.TxtTelephone1.TabIndex = 9
        '
        'TxtPostCode
        '
        Me.TxtPostCode.Location = New System.Drawing.Point(156, 305)
        Me.TxtPostCode.Margin = New System.Windows.Forms.Padding(11, 8, 11, 8)
        Me.TxtPostCode.MaxLength = 10
        Me.TxtPostCode.Name = "TxtPostCode"
        Me.TxtPostCode.Size = New System.Drawing.Size(223, 26)
        Me.TxtPostCode.TabIndex = 8
        '
        'TxtAddress4
        '
        Me.TxtAddress4.Location = New System.Drawing.Point(156, 263)
        Me.TxtAddress4.Margin = New System.Windows.Forms.Padding(11, 8, 11, 8)
        Me.TxtAddress4.MaxLength = 50
        Me.TxtAddress4.Name = "TxtAddress4"
        Me.TxtAddress4.Size = New System.Drawing.Size(816, 26)
        Me.TxtAddress4.TabIndex = 7
        '
        'TxtAddress3
        '
        Me.TxtAddress3.Location = New System.Drawing.Point(156, 221)
        Me.TxtAddress3.Margin = New System.Windows.Forms.Padding(11, 8, 11, 8)
        Me.TxtAddress3.MaxLength = 50
        Me.TxtAddress3.Name = "TxtAddress3"
        Me.TxtAddress3.Size = New System.Drawing.Size(816, 26)
        Me.TxtAddress3.TabIndex = 6
        '
        'TxtAddress2
        '
        Me.TxtAddress2.Location = New System.Drawing.Point(156, 179)
        Me.TxtAddress2.Margin = New System.Windows.Forms.Padding(11, 8, 11, 8)
        Me.TxtAddress2.MaxLength = 50
        Me.TxtAddress2.Name = "TxtAddress2"
        Me.TxtAddress2.Size = New System.Drawing.Size(816, 26)
        Me.TxtAddress2.TabIndex = 5
        '
        'TxtAddress1
        '
        Me.TxtAddress1.Location = New System.Drawing.Point(156, 137)
        Me.TxtAddress1.Margin = New System.Windows.Forms.Padding(11, 8, 11, 8)
        Me.TxtAddress1.MaxLength = 50
        Me.TxtAddress1.Name = "TxtAddress1"
        Me.TxtAddress1.Size = New System.Drawing.Size(816, 26)
        Me.TxtAddress1.TabIndex = 4
        '
        'TxtContactName
        '
        Me.TxtContactName.Location = New System.Drawing.Point(156, 95)
        Me.TxtContactName.Margin = New System.Windows.Forms.Padding(11, 8, 11, 8)
        Me.TxtContactName.MaxLength = 50
        Me.TxtContactName.Name = "TxtContactName"
        Me.TxtContactName.Size = New System.Drawing.Size(816, 26)
        Me.TxtContactName.TabIndex = 3
        '
        'TxtShopName
        '
        Me.TxtShopName.Location = New System.Drawing.Point(156, 53)
        Me.TxtShopName.Margin = New System.Windows.Forms.Padding(11, 8, 11, 8)
        Me.TxtShopName.MaxLength = 50
        Me.TxtShopName.Name = "TxtShopName"
        Me.TxtShopName.Size = New System.Drawing.Size(816, 26)
        Me.TxtShopName.TabIndex = 1
        '
        'TxtShopRef
        '
        Me.TxtShopRef.Location = New System.Drawing.Point(156, 16)
        Me.TxtShopRef.Margin = New System.Windows.Forms.Padding(11, 8, 11, 8)
        Me.TxtShopRef.MaxLength = 8
        Me.TxtShopRef.Name = "TxtShopRef"
        Me.TxtShopRef.Size = New System.Drawing.Size(223, 26)
        Me.TxtShopRef.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.gridTrans)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(11, 8, 11, 8)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(11, 8, 11, 8)
        Me.TabPage2.Size = New System.Drawing.Size(1332, 489)
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
        Me.gridTrans.Size = New System.Drawing.Size(1310, 473)
        Me.gridTrans.TabIndex = 0
        '
        'TxtMemo
        '
        Me.TxtMemo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtMemo.Location = New System.Drawing.Point(11, 8)
        Me.TxtMemo.Margin = New System.Windows.Forms.Padding(11, 8, 11, 8)
        Me.TxtMemo.Multiline = True
        Me.TxtMemo.Name = "TxtMemo"
        Me.TxtMemo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtMemo.Size = New System.Drawing.Size(1310, 782)
        Me.TxtMemo.TabIndex = 0
        '
        'CmdOK
        '
        Me.CmdOK.Location = New System.Drawing.Point(436, 551)
        Me.CmdOK.Margin = New System.Windows.Forms.Padding(11, 8, 11, 8)
        Me.CmdOK.Name = "CmdOK"
        Me.CmdOK.Size = New System.Drawing.Size(181, 32)
        Me.CmdOK.TabIndex = 13
        Me.CmdOK.Text = "Button1"
        Me.CmdOK.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.TxtMemo)
        Me.TabPage4.Location = New System.Drawing.Point(4, 29)
        Me.TabPage4.Margin = New System.Windows.Forms.Padding(11, 8, 11, 8)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(11, 8, 11, 8)
        Me.TabPage4.Size = New System.Drawing.Size(1332, 798)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Memo"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'CmdCancel
        '
        Me.CmdCancel.Location = New System.Drawing.Point(628, 551)
        Me.CmdCancel.Margin = New System.Windows.Forms.Padding(11, 8, 11, 8)
        Me.CmdCancel.Name = "CmdCancel"
        Me.CmdCancel.Size = New System.Drawing.Size(181, 32)
        Me.CmdCancel.TabIndex = 14
        Me.CmdCancel.Text = "Cancel"
        Me.CmdCancel.UseVisualStyleBackColor = True
        '
        'label13
        '
        Me.label13.AutoSize = True
        Me.label13.Location = New System.Drawing.Point(824, 446)
        Me.label13.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.label13.Name = "label13"
        Me.label13.Size = New System.Drawing.Size(18, 20)
        Me.label13.TabIndex = 6
        Me.label13.Text = "0"
        '
        'TxtTotalValue
        '
        Me.TxtTotalValue.AutoSize = True
        Me.TxtTotalValue.Location = New System.Drawing.Point(912, 446)
        Me.TxtTotalValue.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.TxtTotalValue.Name = "TxtTotalValue"
        Me.TxtTotalValue.Size = New System.Drawing.Size(54, 20)
        Me.TxtTotalValue.TabIndex = 5
        Me.TxtTotalValue.Text = "£0000"
        '
        'TxtTotalItems
        '
        Me.TxtTotalItems.AutoSize = True
        Me.TxtTotalItems.Location = New System.Drawing.Point(666, 446)
        Me.TxtTotalItems.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.TxtTotalItems.Name = "TxtTotalItems"
        Me.TxtTotalItems.Size = New System.Drawing.Size(18, 20)
        Me.TxtTotalItems.TabIndex = 4
        Me.TxtTotalItems.Text = "0"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(499, 446)
        Me.Label12.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 20)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Totals:"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.label13)
        Me.TabPage3.Controls.Add(Me.TxtTotalValue)
        Me.TabPage3.Controls.Add(Me.TxtTotalItems)
        Me.TabPage3.Controls.Add(Me.Label12)
        Me.TabPage3.Controls.Add(Me.gridStocks)
        Me.TabPage3.Location = New System.Drawing.Point(4, 29)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(11, 8, 11, 8)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(11, 8, 11, 8)
        Me.TabPage3.Size = New System.Drawing.Size(988, 489)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Stock"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'gridStocks
        '
        Me.gridStocks.AllowUserToAddRows = False
        Me.gridStocks.AllowUserToDeleteRows = False
        Me.gridStocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridStocks.Dock = System.Windows.Forms.DockStyle.Top
        Me.gridStocks.Location = New System.Drawing.Point(11, 8)
        Me.gridStocks.Margin = New System.Windows.Forms.Padding(11, 8, 11, 8)
        Me.gridStocks.Name = "gridStocks"
        Me.gridStocks.ReadOnly = True
        Me.gridStocks.RowHeadersVisible = False
        Me.gridStocks.RowHeadersWidth = 62
        Me.gridStocks.Size = New System.Drawing.Size(966, 430)
        Me.gridStocks.TabIndex = 0
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
        Me.TabControl1.Size = New System.Drawing.Size(996, 522)
        Me.TabControl1.TabIndex = 12
        '
        'ShopForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1025, 612)
        Me.Controls.Add(Me.CmdClear)
        Me.Controls.Add(Me.CmdOK)
        Me.Controls.Add(Me.CmdCancel)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "ShopForm"
        Me.Text = "ShopForm"
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.gridTrans, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.gridStocks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label11 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents CmdClear As Button
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cboWType As ComboBox
    Friend WithEvents TxteMail As TextBox
    Friend WithEvents TxtFax As TextBox
    Friend WithEvents TxtTelephone1 As TextBox
    Friend WithEvents TxtPostCode As TextBox
    Friend WithEvents TxtAddress4 As TextBox
    Friend WithEvents TxtAddress3 As TextBox
    Friend WithEvents TxtAddress2 As TextBox
    Friend WithEvents TxtAddress1 As TextBox
    Friend WithEvents TxtContactName As TextBox
    Friend WithEvents TxtShopName As TextBox
    Public WithEvents TxtShopRef As TextBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents gridTrans As DataGridView
    Friend WithEvents TxtMemo As TextBox
    Friend WithEvents CmdOK As Button
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents CmdCancel As Button
    Friend WithEvents label13 As Label
    Friend WithEvents TxtTotalValue As Label
    Friend WithEvents TxtTotalItems As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TabPage3 As TabPage
    Private WithEvents gridStocks As DataGridView
    Friend WithEvents TabControl1 As TabControl
End Class
