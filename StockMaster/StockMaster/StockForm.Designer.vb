<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StockForm
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
        Dim StockCodeLabel As System.Windows.Forms.Label
        Dim SupplierRefLabel As System.Windows.Forms.Label
        Dim DeadCodeLabel As System.Windows.Forms.Label
        Dim AmountTakenLabel As System.Windows.Forms.Label
        Dim CostValueLabel As System.Windows.Forms.Label
        Dim PCMarkUpLabel As System.Windows.Forms.Label
        Me.label7 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.DgvLocationQty = New System.Windows.Forms.DataGridView()
        Me.TxtDelHangersQty = New System.Windows.Forms.TextBox()
        Me.TxtDelGarmentsQty = New System.Windows.Forms.TextBox()
        Me.TxtDelBoxesQty = New System.Windows.Forms.TextBox()
        Me.TxtPcMarkUp = New System.Windows.Forms.TextBox()
        Me.TxtCostValue = New System.Windows.Forms.TextBox()
        Me.TxtAmountTaken = New System.Windows.Forms.TextBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.CboSeason = New System.Windows.Forms.ComboBox()
        Me.TxtSupplierRef = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.ChkZeroQty = New System.Windows.Forms.CheckBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.TxtStockCode = New System.Windows.Forms.TextBox()
        Me.CmdCancel = New System.Windows.Forms.Button()
        Me.CmdOK = New System.Windows.Forms.Button()
        Me.ChkDeadCode = New System.Windows.Forms.CheckBox()
        StockCodeLabel = New System.Windows.Forms.Label()
        SupplierRefLabel = New System.Windows.Forms.Label()
        DeadCodeLabel = New System.Windows.Forms.Label()
        AmountTakenLabel = New System.Windows.Forms.Label()
        CostValueLabel = New System.Windows.Forms.Label()
        PCMarkUpLabel = New System.Windows.Forms.Label()
        CType(Me.DgvLocationQty, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(63, 401)
        Me.label7.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(74, 20)
        Me.label7.TabIndex = 151
        Me.label7.Text = "Hangers:"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(612, 49)
        Me.label6.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(164, 20)
        Me.label6.TabIndex = 150
        Me.label6.Text = "Location Stock Levels"
        '
        'DgvLocationQty
        '
        Me.DgvLocationQty.AllowUserToAddRows = False
        Me.DgvLocationQty.AllowUserToDeleteRows = False
        Me.DgvLocationQty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvLocationQty.Location = New System.Drawing.Point(492, 81)
        Me.DgvLocationQty.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.DgvLocationQty.Name = "DgvLocationQty"
        Me.DgvLocationQty.ReadOnly = True
        Me.DgvLocationQty.RowHeadersWidth = 62
        Me.DgvLocationQty.Size = New System.Drawing.Size(523, 429)
        Me.DgvLocationQty.TabIndex = 149
        '
        'TxtDelHangersQty
        '
        Me.TxtDelHangersQty.Location = New System.Drawing.Point(177, 401)
        Me.TxtDelHangersQty.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.TxtDelHangersQty.Name = "TxtDelHangersQty"
        Me.TxtDelHangersQty.Size = New System.Drawing.Size(143, 26)
        Me.TxtDelHangersQty.TabIndex = 148
        '
        'TxtDelGarmentsQty
        '
        Me.TxtDelGarmentsQty.Location = New System.Drawing.Point(181, 535)
        Me.TxtDelGarmentsQty.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.TxtDelGarmentsQty.Name = "TxtDelGarmentsQty"
        Me.TxtDelGarmentsQty.Size = New System.Drawing.Size(137, 26)
        Me.TxtDelGarmentsQty.TabIndex = 147
        '
        'TxtDelBoxesQty
        '
        Me.TxtDelBoxesQty.Location = New System.Drawing.Point(177, 471)
        Me.TxtDelBoxesQty.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.TxtDelBoxesQty.Name = "TxtDelBoxesQty"
        Me.TxtDelBoxesQty.Size = New System.Drawing.Size(143, 26)
        Me.TxtDelBoxesQty.TabIndex = 146
        '
        'TxtPcMarkUp
        '
        Me.TxtPcMarkUp.Location = New System.Drawing.Point(151, 309)
        Me.TxtPcMarkUp.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.TxtPcMarkUp.Name = "TxtPcMarkUp"
        Me.TxtPcMarkUp.Size = New System.Drawing.Size(216, 26)
        Me.TxtPcMarkUp.TabIndex = 145
        '
        'TxtCostValue
        '
        Me.TxtCostValue.Location = New System.Drawing.Point(151, 209)
        Me.TxtCostValue.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.TxtCostValue.Name = "TxtCostValue"
        Me.TxtCostValue.Size = New System.Drawing.Size(216, 26)
        Me.TxtCostValue.TabIndex = 144
        '
        'TxtAmountTaken
        '
        Me.TxtAmountTaken.Location = New System.Drawing.Point(151, 259)
        Me.TxtAmountTaken.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.TxtAmountTaken.Name = "TxtAmountTaken"
        Me.TxtAmountTaken.Size = New System.Drawing.Size(216, 26)
        Me.TxtAmountTaken.TabIndex = 143
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(53, 539)
        Me.label5.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(84, 20)
        Me.label5.TabIndex = 142
        Me.label5.Text = "Garments:"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(80, 474)
        Me.label4.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(57, 20)
        Me.label4.TabIndex = 141
        Me.label4.Text = "Boxes:"
        '
        'CboSeason
        '
        Me.CboSeason.FormattingEnabled = True
        Me.CboSeason.Location = New System.Drawing.Point(151, 118)
        Me.CboSeason.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.CboSeason.Name = "CboSeason"
        Me.CboSeason.Size = New System.Drawing.Size(320, 28)
        Me.CboSeason.TabIndex = 140
        '
        'TxtSupplierRef
        '
        Me.TxtSupplierRef.Location = New System.Drawing.Point(151, 68)
        Me.TxtSupplierRef.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.TxtSupplierRef.Name = "TxtSupplierRef"
        Me.TxtSupplierRef.Size = New System.Drawing.Size(320, 26)
        Me.TxtSupplierRef.TabIndex = 139
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(239, 164)
        Me.label3.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(74, 20)
        Me.label3.TabIndex = 138
        Me.label3.Text = "Zero Qty:"
        '
        'ChkZeroQty
        '
        Me.ChkZeroQty.AutoSize = True
        Me.ChkZeroQty.Location = New System.Drawing.Point(373, 171)
        Me.ChkZeroQty.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.ChkZeroQty.Name = "ChkZeroQty"
        Me.ChkZeroQty.Size = New System.Drawing.Size(22, 21)
        Me.ChkZeroQty.TabIndex = 137
        Me.ChkZeroQty.UseVisualStyleBackColor = True
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(175, 353)
        Me.label2.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(107, 20)
        Me.label2.TabIndex = 136
        Me.label2.Text = "Delivered Qty:"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(69, 124)
        Me.label1.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(68, 20)
        Me.label1.TabIndex = 135
        Me.label1.Text = "Season:"
        '
        'TxtStockCode
        '
        Me.TxtStockCode.Location = New System.Drawing.Point(151, 18)
        Me.TxtStockCode.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.TxtStockCode.Name = "TxtStockCode"
        Me.TxtStockCode.Size = New System.Drawing.Size(320, 26)
        Me.TxtStockCode.TabIndex = 134
        '
        'CmdCancel
        '
        Me.CmdCancel.Location = New System.Drawing.Point(887, 524)
        Me.CmdCancel.Margin = New System.Windows.Forms.Padding(11, 8, 11, 8)
        Me.CmdCancel.Name = "CmdCancel"
        Me.CmdCancel.Size = New System.Drawing.Size(125, 58)
        Me.CmdCancel.TabIndex = 127
        Me.CmdCancel.Text = "Cancel"
        Me.CmdCancel.UseVisualStyleBackColor = True
        '
        'CmdOK
        '
        Me.CmdOK.Location = New System.Drawing.Point(745, 522)
        Me.CmdOK.Margin = New System.Windows.Forms.Padding(11, 8, 11, 8)
        Me.CmdOK.Name = "CmdOK"
        Me.CmdOK.Size = New System.Drawing.Size(123, 58)
        Me.CmdOK.TabIndex = 126
        Me.CmdOK.Text = "Button1"
        Me.CmdOK.UseVisualStyleBackColor = True
        '
        'StockCodeLabel
        '
        StockCodeLabel.AutoSize = True
        StockCodeLabel.Location = New System.Drawing.Point(41, 21)
        StockCodeLabel.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        StockCodeLabel.Name = "StockCodeLabel"
        StockCodeLabel.Size = New System.Drawing.Size(96, 20)
        StockCodeLabel.TabIndex = 128
        StockCodeLabel.Text = "Stock Code:"
        '
        'SupplierRefLabel
        '
        SupplierRefLabel.AutoSize = True
        SupplierRefLabel.Location = New System.Drawing.Point(36, 74)
        SupplierRefLabel.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        SupplierRefLabel.Name = "SupplierRefLabel"
        SupplierRefLabel.Size = New System.Drawing.Size(101, 20)
        SupplierRefLabel.TabIndex = 129
        SupplierRefLabel.Text = "Supplier Ref:"
        '
        'DeadCodeLabel
        '
        DeadCodeLabel.AutoSize = True
        DeadCodeLabel.Location = New System.Drawing.Point(43, 172)
        DeadCodeLabel.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        DeadCodeLabel.Name = "DeadCodeLabel"
        DeadCodeLabel.Size = New System.Drawing.Size(94, 20)
        DeadCodeLabel.TabIndex = 130
        DeadCodeLabel.Text = "Dead Code:"
        '
        'ChkDeadCode
        '
        Me.ChkDeadCode.Location = New System.Drawing.Point(151, 153)
        Me.ChkDeadCode.Margin = New System.Windows.Forms.Padding(11, 8, 11, 8)
        Me.ChkDeadCode.Name = "ChkDeadCode"
        Me.ChkDeadCode.Size = New System.Drawing.Size(69, 64)
        Me.ChkDeadCode.TabIndex = 125
        Me.ChkDeadCode.UseVisualStyleBackColor = True
        '
        'AmountTakenLabel
        '
        AmountTakenLabel.AutoSize = True
        AmountTakenLabel.Location = New System.Drawing.Point(20, 259)
        AmountTakenLabel.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        AmountTakenLabel.Name = "AmountTakenLabel"
        AmountTakenLabel.Size = New System.Drawing.Size(117, 20)
        AmountTakenLabel.TabIndex = 131
        AmountTakenLabel.Text = "Amount Taken:"
        '
        'CostValueLabel
        '
        CostValueLabel.AutoSize = True
        CostValueLabel.Location = New System.Drawing.Point(46, 209)
        CostValueLabel.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        CostValueLabel.Name = "CostValueLabel"
        CostValueLabel.Size = New System.Drawing.Size(91, 20)
        CostValueLabel.TabIndex = 132
        CostValueLabel.Text = "Cost Value:"
        '
        'PCMarkUpLabel
        '
        PCMarkUpLabel.AutoSize = True
        PCMarkUpLabel.Location = New System.Drawing.Point(43, 314)
        PCMarkUpLabel.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        PCMarkUpLabel.Name = "PCMarkUpLabel"
        PCMarkUpLabel.Size = New System.Drawing.Size(94, 20)
        PCMarkUpLabel.TabIndex = 133
        PCMarkUpLabel.Text = "PCMark Up:"
        '
        'StockForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1037, 599)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.DgvLocationQty)
        Me.Controls.Add(Me.TxtDelHangersQty)
        Me.Controls.Add(Me.TxtDelGarmentsQty)
        Me.Controls.Add(Me.TxtDelBoxesQty)
        Me.Controls.Add(Me.TxtPcMarkUp)
        Me.Controls.Add(Me.TxtCostValue)
        Me.Controls.Add(Me.TxtAmountTaken)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.CboSeason)
        Me.Controls.Add(Me.TxtSupplierRef)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.ChkZeroQty)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.TxtStockCode)
        Me.Controls.Add(Me.CmdCancel)
        Me.Controls.Add(Me.CmdOK)
        Me.Controls.Add(StockCodeLabel)
        Me.Controls.Add(SupplierRefLabel)
        Me.Controls.Add(DeadCodeLabel)
        Me.Controls.Add(Me.ChkDeadCode)
        Me.Controls.Add(AmountTakenLabel)
        Me.Controls.Add(CostValueLabel)
        Me.Controls.Add(PCMarkUpLabel)
        Me.Name = "StockForm"
        Me.Text = "Stock"
        CType(Me.DgvLocationQty, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents label7 As Label
    Private WithEvents label6 As Label
    Private WithEvents DgvLocationQty As DataGridView
    Private WithEvents TxtDelHangersQty As TextBox
    Private WithEvents TxtDelGarmentsQty As TextBox
    Private WithEvents TxtDelBoxesQty As TextBox
    Private WithEvents TxtPcMarkUp As TextBox
    Private WithEvents TxtCostValue As TextBox
    Private WithEvents TxtAmountTaken As TextBox
    Private WithEvents label5 As Label
    Private WithEvents label4 As Label
    Private WithEvents CboSeason As ComboBox
    Private WithEvents TxtSupplierRef As TextBox
    Private WithEvents label3 As Label
    Private WithEvents ChkZeroQty As CheckBox
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Public WithEvents TxtStockCode As TextBox
    Friend WithEvents CmdCancel As Button
    Friend WithEvents CmdOK As Button
    Friend WithEvents ChkDeadCode As CheckBox
End Class
