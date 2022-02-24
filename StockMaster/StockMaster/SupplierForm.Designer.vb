<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SupplierForm
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
        Me.tabControl1 = New System.Windows.Forms.TabControl()
        Me.tabPage1 = New System.Windows.Forms.TabPage()
        Me.TxtWebsiteAddress = New System.Windows.Forms.TextBox()
        Me.label11 = New System.Windows.Forms.Label()
        Me.TxtEmailAddress = New System.Windows.Forms.TextBox()
        Me.TxtFaxNumber = New System.Windows.Forms.TextBox()
        Me.TxtTelephoneNumber1 = New System.Windows.Forms.TextBox()
        Me.TxtPostCode = New System.Windows.Forms.TextBox()
        Me.TxtAddressLine4 = New System.Windows.Forms.TextBox()
        Me.TxtAddressLine3 = New System.Windows.Forms.TextBox()
        Me.TxtAddressLine2 = New System.Windows.Forms.TextBox()
        Me.TxtAddressLine1 = New System.Windows.Forms.TextBox()
        Me.TxtContactName = New System.Windows.Forms.TextBox()
        Me.TxtSupplierName = New System.Windows.Forms.TextBox()
        Me.TxtSupplierRef = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tabPage2 = New System.Windows.Forms.TabPage()
        Me.gridTrans = New System.Windows.Forms.DataGridView()
        Me.tabPage3 = New System.Windows.Forms.TabPage()
        Me.TxtMemo = New System.Windows.Forms.TextBox()
        Me.CmdOK = New System.Windows.Forms.Button()
        Me.CmdCancel = New System.Windows.Forms.Button()
        Me.CmdClear = New System.Windows.Forms.Button()
        Me.tabControl1.SuspendLayout()
        Me.tabPage1.SuspendLayout()
        Me.tabPage2.SuspendLayout()
        CType(Me.gridTrans, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabControl1
        '
        Me.tabControl1.Controls.Add(Me.tabPage1)
        Me.tabControl1.Controls.Add(Me.tabPage2)
        Me.tabControl1.Controls.Add(Me.tabPage3)
        Me.tabControl1.Location = New System.Drawing.Point(17, 15)
        Me.tabControl1.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.tabControl1.Name = "tabControl1"
        Me.tabControl1.SelectedIndex = 0
        Me.tabControl1.Size = New System.Drawing.Size(1136, 696)
        Me.tabControl1.TabIndex = 12
        '
        'tabPage1
        '
        Me.tabPage1.Controls.Add(Me.TxtWebsiteAddress)
        Me.tabPage1.Controls.Add(Me.label11)
        Me.tabPage1.Controls.Add(Me.TxtEmailAddress)
        Me.tabPage1.Controls.Add(Me.TxtFaxNumber)
        Me.tabPage1.Controls.Add(Me.TxtTelephoneNumber1)
        Me.tabPage1.Controls.Add(Me.TxtPostCode)
        Me.tabPage1.Controls.Add(Me.TxtAddressLine4)
        Me.tabPage1.Controls.Add(Me.TxtAddressLine3)
        Me.tabPage1.Controls.Add(Me.TxtAddressLine2)
        Me.tabPage1.Controls.Add(Me.TxtAddressLine1)
        Me.tabPage1.Controls.Add(Me.TxtContactName)
        Me.tabPage1.Controls.Add(Me.TxtSupplierName)
        Me.tabPage1.Controls.Add(Me.TxtSupplierRef)
        Me.tabPage1.Controls.Add(Me.Label1)
        Me.tabPage1.Controls.Add(Me.Label10)
        Me.tabPage1.Controls.Add(Me.Label2)
        Me.tabPage1.Controls.Add(Me.Label9)
        Me.tabPage1.Controls.Add(Me.Label3)
        Me.tabPage1.Controls.Add(Me.Label4)
        Me.tabPage1.Controls.Add(Me.Label5)
        Me.tabPage1.Controls.Add(Me.Label6)
        Me.tabPage1.Location = New System.Drawing.Point(4, 29)
        Me.tabPage1.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.tabPage1.Name = "tabPage1"
        Me.tabPage1.Padding = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.tabPage1.Size = New System.Drawing.Size(1128, 663)
        Me.tabPage1.TabIndex = 0
        Me.tabPage1.Text = "Details"
        Me.tabPage1.UseVisualStyleBackColor = True
        '
        'TxtWebsiteAddress
        '
        Me.TxtWebsiteAddress.Location = New System.Drawing.Point(195, 569)
        Me.TxtWebsiteAddress.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.TxtWebsiteAddress.MaxLength = 255
        Me.TxtWebsiteAddress.Name = "TxtWebsiteAddress"
        Me.TxtWebsiteAddress.Size = New System.Drawing.Size(896, 26)
        Me.TxtWebsiteAddress.TabIndex = 11
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.Location = New System.Drawing.Point(75, 561)
        Me.label11.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(74, 20)
        Me.label11.TabIndex = 46
        Me.label11.Text = "WebSite:"
        '
        'TxtEmailAddress
        '
        Me.TxtEmailAddress.Location = New System.Drawing.Point(195, 519)
        Me.TxtEmailAddress.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.TxtEmailAddress.MaxLength = 255
        Me.TxtEmailAddress.Name = "TxtEmailAddress"
        Me.TxtEmailAddress.Size = New System.Drawing.Size(896, 26)
        Me.TxtEmailAddress.TabIndex = 10
        '
        'TxtFaxNumber
        '
        Me.TxtFaxNumber.Location = New System.Drawing.Point(195, 469)
        Me.TxtFaxNumber.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.TxtFaxNumber.MaxLength = 20
        Me.TxtFaxNumber.Name = "TxtFaxNumber"
        Me.TxtFaxNumber.Size = New System.Drawing.Size(380, 26)
        Me.TxtFaxNumber.TabIndex = 9
        '
        'TxtTelephoneNumber1
        '
        Me.TxtTelephoneNumber1.Location = New System.Drawing.Point(195, 419)
        Me.TxtTelephoneNumber1.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.TxtTelephoneNumber1.MaxLength = 20
        Me.TxtTelephoneNumber1.Name = "TxtTelephoneNumber1"
        Me.TxtTelephoneNumber1.Size = New System.Drawing.Size(380, 26)
        Me.TxtTelephoneNumber1.TabIndex = 8
        '
        'TxtPostCode
        '
        Me.TxtPostCode.Location = New System.Drawing.Point(195, 369)
        Me.TxtPostCode.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.TxtPostCode.MaxLength = 11
        Me.TxtPostCode.Name = "TxtPostCode"
        Me.TxtPostCode.Size = New System.Drawing.Size(216, 26)
        Me.TxtPostCode.TabIndex = 7
        '
        'TxtAddressLine4
        '
        Me.TxtAddressLine4.Location = New System.Drawing.Point(195, 319)
        Me.TxtAddressLine4.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.TxtAddressLine4.MaxLength = 60
        Me.TxtAddressLine4.Name = "TxtAddressLine4"
        Me.TxtAddressLine4.Size = New System.Drawing.Size(905, 26)
        Me.TxtAddressLine4.TabIndex = 6
        '
        'TxtAddressLine3
        '
        Me.TxtAddressLine3.Location = New System.Drawing.Point(195, 269)
        Me.TxtAddressLine3.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.TxtAddressLine3.MaxLength = 60
        Me.TxtAddressLine3.Name = "TxtAddressLine3"
        Me.TxtAddressLine3.Size = New System.Drawing.Size(905, 26)
        Me.TxtAddressLine3.TabIndex = 5
        '
        'TxtAddressLine2
        '
        Me.TxtAddressLine2.Location = New System.Drawing.Point(195, 219)
        Me.TxtAddressLine2.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.TxtAddressLine2.MaxLength = 60
        Me.TxtAddressLine2.Name = "TxtAddressLine2"
        Me.TxtAddressLine2.Size = New System.Drawing.Size(905, 26)
        Me.TxtAddressLine2.TabIndex = 4
        '
        'TxtAddressLine1
        '
        Me.TxtAddressLine1.Location = New System.Drawing.Point(195, 169)
        Me.TxtAddressLine1.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.TxtAddressLine1.MaxLength = 60
        Me.TxtAddressLine1.Name = "TxtAddressLine1"
        Me.TxtAddressLine1.Size = New System.Drawing.Size(905, 26)
        Me.TxtAddressLine1.TabIndex = 3
        '
        'TxtContactName
        '
        Me.TxtContactName.Location = New System.Drawing.Point(195, 119)
        Me.TxtContactName.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.TxtContactName.MaxLength = 60
        Me.TxtContactName.Name = "TxtContactName"
        Me.TxtContactName.Size = New System.Drawing.Size(905, 26)
        Me.TxtContactName.TabIndex = 2
        '
        'TxtSupplierName
        '
        Me.TxtSupplierName.Location = New System.Drawing.Point(195, 69)
        Me.TxtSupplierName.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.TxtSupplierName.MaxLength = 60
        Me.TxtSupplierName.Name = "TxtSupplierName"
        Me.TxtSupplierName.Size = New System.Drawing.Size(905, 26)
        Me.TxtSupplierName.TabIndex = 1
        '
        'TxtSupplierRef
        '
        Me.TxtSupplierRef.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSupplierRef.Location = New System.Drawing.Point(195, 11)
        Me.TxtSupplierRef.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.TxtSupplierRef.MaxLength = 8
        Me.TxtSupplierRef.Name = "TxtSupplierRef"
        Me.TxtSupplierRef.Size = New System.Drawing.Size(295, 32)
        Me.TxtSupplierRef.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 21)
        Me.Label1.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 20)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Supplier Ref:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(97, 511)
        Me.Label10.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 20)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "EMail:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 68)
        Me.Label2.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 20)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Supplier Name:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(110, 475)
        Me.Label9.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 20)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "Fax:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 122)
        Me.Label3.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 20)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Contact Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(77, 168)
        Me.Label4.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 20)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Address:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(62, 368)
        Me.Label5.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 20)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Post Code:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(61, 425)
        Me.Label6.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 20)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Telephone:"
        '
        'tabPage2
        '
        Me.tabPage2.Controls.Add(Me.gridTrans)
        Me.tabPage2.Location = New System.Drawing.Point(4, 29)
        Me.tabPage2.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.tabPage2.Name = "tabPage2"
        Me.tabPage2.Padding = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.tabPage2.Size = New System.Drawing.Size(1128, 663)
        Me.tabPage2.TabIndex = 1
        Me.tabPage2.Text = "Items"
        Me.tabPage2.UseVisualStyleBackColor = True
        '
        'gridTrans
        '
        Me.gridTrans.AllowUserToAddRows = False
        Me.gridTrans.AllowUserToDeleteRows = False
        Me.gridTrans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridTrans.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridTrans.Location = New System.Drawing.Point(8, 6)
        Me.gridTrans.Margin = New System.Windows.Forms.Padding(11, 8, 11, 8)
        Me.gridTrans.Name = "gridTrans"
        Me.gridTrans.ReadOnly = True
        Me.gridTrans.RowHeadersWidth = 62
        Me.gridTrans.Size = New System.Drawing.Size(1112, 651)
        Me.gridTrans.TabIndex = 34
        '
        'tabPage3
        '
        Me.tabPage3.Controls.Add(Me.TxtMemo)
        Me.tabPage3.Location = New System.Drawing.Point(4, 29)
        Me.tabPage3.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.tabPage3.Name = "tabPage3"
        Me.tabPage3.Padding = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.tabPage3.Size = New System.Drawing.Size(1128, 663)
        Me.tabPage3.TabIndex = 2
        Me.tabPage3.Text = "Memo"
        Me.tabPage3.UseVisualStyleBackColor = True
        '
        'TxtMemo
        '
        Me.TxtMemo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtMemo.Location = New System.Drawing.Point(8, 6)
        Me.TxtMemo.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.TxtMemo.Multiline = True
        Me.TxtMemo.Name = "TxtMemo"
        Me.TxtMemo.Size = New System.Drawing.Size(1112, 651)
        Me.TxtMemo.TabIndex = 0
        '
        'CmdOK
        '
        Me.CmdOK.Location = New System.Drawing.Point(668, 717)
        Me.CmdOK.Margin = New System.Windows.Forms.Padding(11, 8, 11, 8)
        Me.CmdOK.Name = "CmdOK"
        Me.CmdOK.Size = New System.Drawing.Size(141, 58)
        Me.CmdOK.TabIndex = 13
        Me.CmdOK.Text = "Button1"
        Me.CmdOK.UseVisualStyleBackColor = True
        '
        'CmdCancel
        '
        Me.CmdCancel.Location = New System.Drawing.Point(830, 717)
        Me.CmdCancel.Margin = New System.Windows.Forms.Padding(11, 8, 11, 8)
        Me.CmdCancel.Name = "CmdCancel"
        Me.CmdCancel.Size = New System.Drawing.Size(141, 58)
        Me.CmdCancel.TabIndex = 14
        Me.CmdCancel.Text = "Cancel"
        Me.CmdCancel.UseVisualStyleBackColor = True
        '
        'CmdClear
        '
        Me.CmdClear.Location = New System.Drawing.Point(993, 717)
        Me.CmdClear.Margin = New System.Windows.Forms.Padding(11, 8, 11, 8)
        Me.CmdClear.Name = "CmdClear"
        Me.CmdClear.Size = New System.Drawing.Size(141, 58)
        Me.CmdClear.TabIndex = 15
        Me.CmdClear.Text = "Clear"
        Me.CmdClear.UseVisualStyleBackColor = True
        '
        'SupplierForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1168, 787)
        Me.Controls.Add(Me.tabControl1)
        Me.Controls.Add(Me.CmdOK)
        Me.Controls.Add(Me.CmdCancel)
        Me.Controls.Add(Me.CmdClear)
        Me.Name = "SupplierForm"
        Me.Text = "Supplier"
        Me.tabControl1.ResumeLayout(False)
        Me.tabPage1.ResumeLayout(False)
        Me.tabPage1.PerformLayout()
        Me.tabPage2.ResumeLayout(False)
        CType(Me.gridTrans, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPage3.ResumeLayout(False)
        Me.tabPage3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents tabControl1 As TabControl
    Private WithEvents tabPage1 As TabPage
    Private WithEvents TxtWebsiteAddress As TextBox
    Private WithEvents label11 As Label
    Private WithEvents TxtEmailAddress As TextBox
    Private WithEvents TxtFaxNumber As TextBox
    Private WithEvents TxtTelephoneNumber1 As TextBox
    Private WithEvents TxtPostCode As TextBox
    Private WithEvents TxtAddressLine4 As TextBox
    Private WithEvents TxtAddressLine3 As TextBox
    Private WithEvents TxtAddressLine2 As TextBox
    Private WithEvents TxtAddressLine1 As TextBox
    Private WithEvents TxtContactName As TextBox
    Private WithEvents TxtSupplierName As TextBox
    Public WithEvents TxtSupplierRef As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Private WithEvents tabPage2 As TabPage
    Friend WithEvents gridTrans As DataGridView
    Private WithEvents tabPage3 As TabPage
    Private WithEvents TxtMemo As TextBox
    Friend WithEvents CmdOK As Button
    Friend WithEvents CmdCancel As Button
    Friend WithEvents CmdClear As Button
End Class
