<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SeasonForm
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
        Me.CmdCancel = New System.Windows.Forms.Button()
        Me.TxtSeasonName = New System.Windows.Forms.TextBox()
        Me.LblSeasonID = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.CmdOK = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CmdCancel
        '
        Me.CmdCancel.Location = New System.Drawing.Point(445, 100)
        Me.CmdCancel.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.CmdCancel.Name = "CmdCancel"
        Me.CmdCancel.Size = New System.Drawing.Size(117, 46)
        Me.CmdCancel.TabIndex = 29
        Me.CmdCancel.Text = "Cancel"
        Me.CmdCancel.UseVisualStyleBackColor = True
        '
        'TxtSeasonName
        '
        Me.TxtSeasonName.Location = New System.Drawing.Point(139, 62)
        Me.TxtSeasonName.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.TxtSeasonName.Name = "TxtSeasonName"
        Me.TxtSeasonName.Size = New System.Drawing.Size(433, 26)
        Me.TxtSeasonName.TabIndex = 28
        '
        'LblSeasonID
        '
        Me.LblSeasonID.BackColor = System.Drawing.Color.MistyRose
        Me.LblSeasonID.Location = New System.Drawing.Point(135, 9)
        Me.LblSeasonID.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.LblSeasonID.Name = "LblSeasonID"
        Me.LblSeasonID.Size = New System.Drawing.Size(135, 37)
        Me.LblSeasonID.TabIndex = 27
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(17, 65)
        Me.label2.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(114, 20)
        Me.label2.TabIndex = 26
        Me.label2.Text = "Season Name:"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(17, 26)
        Me.label1.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(89, 20)
        Me.label1.TabIndex = 25
        Me.label1.Text = "Season ID:"
        '
        'CmdOK
        '
        Me.CmdOK.Location = New System.Drawing.Point(312, 100)
        Me.CmdOK.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.CmdOK.Name = "CmdOK"
        Me.CmdOK.Size = New System.Drawing.Size(117, 46)
        Me.CmdOK.TabIndex = 24
        Me.CmdOK.Text = "OK"
        Me.CmdOK.UseVisualStyleBackColor = True
        '
        'SeasonForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(588, 159)
        Me.Controls.Add(Me.CmdCancel)
        Me.Controls.Add(Me.TxtSeasonName)
        Me.Controls.Add(Me.LblSeasonID)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.CmdOK)
        Me.Name = "SeasonForm"
        Me.Text = "SeasonForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents CmdCancel As Button
    Private WithEvents TxtSeasonName As TextBox
    Private WithEvents LblSeasonID As Label
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Private WithEvents CmdOK As Button
End Class
