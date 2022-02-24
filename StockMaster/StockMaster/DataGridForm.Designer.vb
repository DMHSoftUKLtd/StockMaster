<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataGridForm
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
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TSSLFunction = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.TSSCount = New System.Windows.Forms.ToolStripStatusLabel()
        Me.DgvRecords = New System.Windows.Forms.DataGridView()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.toolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.TsbNew = New System.Windows.Forms.ToolStripButton()
        Me.TsbRecord = New System.Windows.Forms.ToolStripButton()
        Me.TsbDelete = New System.Windows.Forms.ToolStripButton()
        Me.TsbRefresh = New System.Windows.Forms.ToolStripButton()
        Me.TsbPrint = New System.Windows.Forms.ToolStripButton()
        Me.TsbFind = New System.Windows.Forms.ToolStripButton()
        Me.TSBBalances = New System.Windows.Forms.ToolStripButton()
        Me.TsbClose = New System.Windows.Forms.ToolStripButton()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.StatusStrip1.SuspendLayout()
        CType(Me.DgvRecords, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.toolStrip1.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(75, 25)
        Me.ToolStripStatusLabel3.Text = "Records"
        '
        'TSSLFunction
        '
        Me.TSSLFunction.Name = "TSSLFunction"
        Me.TSSLFunction.Size = New System.Drawing.Size(108, 25)
        Me.TSSLFunction.Text = "Warehouses"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSSLFunction, Me.TSSCount, Me.ToolStripStatusLabel3})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 12)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(3, 0, 32, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1501, 32)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'TSSCount
        '
        Me.TSSCount.Name = "TSSCount"
        Me.TSSCount.Size = New System.Drawing.Size(52, 25)
        Me.TSSCount.Text = "0000"
        '
        'DgvRecords
        '
        Me.DgvRecords.AllowUserToAddRows = False
        Me.DgvRecords.AllowUserToDeleteRows = False
        Me.DgvRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvRecords.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvRecords.Location = New System.Drawing.Point(0, 0)
        Me.DgvRecords.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.DgvRecords.Name = "DgvRecords"
        Me.DgvRecords.ReadOnly = True
        Me.DgvRecords.RowHeadersWidth = 51
        Me.DgvRecords.Size = New System.Drawing.Size(1501, 865)
        Me.DgvRecords.TabIndex = 0
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.DgvRecords)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.StatusStrip1)
        Me.SplitContainer2.Size = New System.Drawing.Size(1501, 917)
        Me.SplitContainer2.SplitterDistance = 865
        Me.SplitContainer2.SplitterWidth = 8
        Me.SplitContainer2.TabIndex = 0
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.toolStrip1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1501, 996)
        Me.SplitContainer1.SplitterDistance = 71
        Me.SplitContainer1.SplitterWidth = 8
        Me.SplitContainer1.TabIndex = 4
        '
        'toolStrip1
        '
        Me.toolStrip1.AutoSize = False
        Me.toolStrip1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.toolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.toolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TsbNew, Me.TsbRecord, Me.TsbDelete, Me.TsbRefresh, Me.TsbPrint, Me.TsbFind, Me.TSBBalances, Me.TsbClose})
        Me.toolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.toolStrip1.Name = "toolStrip1"
        Me.toolStrip1.Padding = New System.Windows.Forms.Padding(0, 0, 4, 0)
        Me.toolStrip1.Size = New System.Drawing.Size(1501, 72)
        Me.toolStrip1.TabIndex = 2
        Me.toolStrip1.Text = "toolStrip1"
        '
        'TsbNew
        '
        Me.TsbNew.AutoSize = False
        Me.TsbNew.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.TsbNew.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TsbNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsbNew.Name = "TsbNew"
        Me.TsbNew.Size = New System.Drawing.Size(43, 55)
        Me.TsbNew.Text = "New"
        Me.TsbNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'TsbRecord
        '
        Me.TsbRecord.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TsbRecord.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsbRecord.Name = "TsbRecord"
        Me.TsbRecord.Size = New System.Drawing.Size(82, 67)
        Me.TsbRecord.Text = "Record"
        Me.TsbRecord.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'TsbDelete
        '
        Me.TsbDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsbDelete.Name = "TsbDelete"
        Me.TsbDelete.Size = New System.Drawing.Size(78, 67)
        Me.TsbDelete.Text = "Delete"
        Me.TsbDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'TsbRefresh
        '
        Me.TsbRefresh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TsbRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsbRefresh.Name = "TsbRefresh"
        Me.TsbRefresh.Size = New System.Drawing.Size(88, 67)
        Me.TsbRefresh.Text = "Refresh"
        Me.TsbRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'TsbPrint
        '
        Me.TsbPrint.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TsbPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsbPrint.Name = "TsbPrint"
        Me.TsbPrint.Size = New System.Drawing.Size(62, 67)
        Me.TsbPrint.Text = "Print"
        Me.TsbPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.TsbPrint.Visible = False
        '
        'TsbFind
        '
        Me.TsbFind.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TsbFind.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsbFind.Name = "TsbFind"
        Me.TsbFind.Size = New System.Drawing.Size(56, 67)
        Me.TsbFind.Text = "Find"
        Me.TsbFind.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'TSBBalances
        '
        Me.TSBBalances.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TSBBalances.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSBBalances.Name = "TSBBalances"
        Me.TSBBalances.Size = New System.Drawing.Size(99, 67)
        Me.TSBBalances.Text = "Balances"
        Me.TSBBalances.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.TSBBalances.Visible = False
        '
        'TsbClose
        '
        Me.TsbClose.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TsbClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsbClose.Name = "TsbClose"
        Me.TsbClose.Size = New System.Drawing.Size(66, 67)
        Me.TsbClose.Text = "Close"
        Me.TsbClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'DataGridForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1501, 996)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "DataGridForm"
        Me.Text = "DataGridForm"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.DgvRecords, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.Panel2.PerformLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.toolStrip1.ResumeLayout(False)
        Me.toolStrip1.PerformLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents TSSLFunction As ToolStripStatusLabel
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents TSSCount As ToolStripStatusLabel
    Friend WithEvents DgvRecords As DataGridView
    Public WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents SplitContainer1 As SplitContainer
    Private WithEvents toolStrip1 As ToolStrip
    Private WithEvents TsbNew As ToolStripButton
    Private WithEvents TsbRecord As ToolStripButton
    Private WithEvents TsbDelete As ToolStripButton
    Public WithEvents TsbRefresh As ToolStripButton
    Private WithEvents TsbPrint As ToolStripButton
    Private WithEvents TsbFind As ToolStripButton
    Private WithEvents TSBBalances As ToolStripButton
    Private WithEvents TsbClose As ToolStripButton
    Friend WithEvents BindingSource1 As BindingSource
End Class
