<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeForm
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
        Me.CmdOK = New System.Windows.Forms.Button()
        Me.richTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.TxtEmployeeID = New System.Windows.Forms.TextBox()
        Me.TxtFirstName = New System.Windows.Forms.TextBox()
        Me.TxtLastName = New System.Windows.Forms.TextBox()
        Me.TxtLoginCode = New System.Windows.Forms.TextBox()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.CboProfiles = New System.Windows.Forms.ComboBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CmdCancel
        '
        Me.CmdCancel.Location = New System.Drawing.Point(360, 383)
        Me.CmdCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdCancel.Name = "CmdCancel"
        Me.CmdCancel.Size = New System.Drawing.Size(112, 32)
        Me.CmdCancel.TabIndex = 52
        Me.CmdCancel.Text = "Cancel"
        Me.CmdCancel.UseVisualStyleBackColor = True
        '
        'CmdOK
        '
        Me.CmdOK.Location = New System.Drawing.Point(240, 383)
        Me.CmdOK.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdOK.Name = "CmdOK"
        Me.CmdOK.Size = New System.Drawing.Size(112, 32)
        Me.CmdOK.TabIndex = 51
        Me.CmdOK.Text = "Save"
        Me.CmdOK.UseVisualStyleBackColor = True
        '
        'richTextBox1
        '
        Me.richTextBox1.Enabled = False
        Me.richTextBox1.Location = New System.Drawing.Point(149, 240)
        Me.richTextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.richTextBox1.Name = "richTextBox1"
        Me.richTextBox1.Size = New System.Drawing.Size(312, 134)
        Me.richTextBox1.TabIndex = 53
        Me.richTextBox1.Text = "ProfileID | Description" & Global.Microsoft.VisualBasic.ChrW(10) & "---------------------------------------------" & Global.Microsoft.VisualBasic.ChrW(10) & "1" & Global.Microsoft.VisualBasic.ChrW(9) & "| Standar" &
    "d Users" & Global.Microsoft.VisualBasic.ChrW(10) & "2" & Global.Microsoft.VisualBasic.ChrW(9) & "| System Administrator" & Global.Microsoft.VisualBasic.ChrW(10) & "3" & Global.Microsoft.VisualBasic.ChrW(9) & "| System Manager"
        '
        'TxtEmployeeID
        '
        Me.TxtEmployeeID.Location = New System.Drawing.Point(149, 17)
        Me.TxtEmployeeID.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtEmployeeID.Name = "TxtEmployeeID"
        Me.TxtEmployeeID.Size = New System.Drawing.Size(148, 26)
        Me.TxtEmployeeID.TabIndex = 45
        '
        'TxtFirstName
        '
        Me.TxtFirstName.Location = New System.Drawing.Point(149, 55)
        Me.TxtFirstName.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtFirstName.Name = "TxtFirstName"
        Me.TxtFirstName.Size = New System.Drawing.Size(148, 26)
        Me.TxtFirstName.TabIndex = 46
        '
        'TxtLastName
        '
        Me.TxtLastName.Location = New System.Drawing.Point(149, 93)
        Me.TxtLastName.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtLastName.Name = "TxtLastName"
        Me.TxtLastName.Size = New System.Drawing.Size(148, 26)
        Me.TxtLastName.TabIndex = 47
        '
        'TxtLoginCode
        '
        Me.TxtLoginCode.Location = New System.Drawing.Point(149, 129)
        Me.TxtLoginCode.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtLoginCode.Name = "TxtLoginCode"
        Me.TxtLoginCode.Size = New System.Drawing.Size(148, 26)
        Me.TxtLoginCode.TabIndex = 48
        '
        'TxtPassword
        '
        Me.TxtPassword.Location = New System.Drawing.Point(149, 163)
        Me.TxtPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(37)
        Me.TxtPassword.Size = New System.Drawing.Size(148, 26)
        Me.TxtPassword.TabIndex = 49
        '
        'CboProfiles
        '
        Me.CboProfiles.FormattingEnabled = True
        Me.CboProfiles.Items.AddRange(New Object() {"Standard Uers", "System Administrator", "System Manager"})
        Me.CboProfiles.Location = New System.Drawing.Point(149, 200)
        Me.CboProfiles.Margin = New System.Windows.Forms.Padding(4)
        Me.CboProfiles.Name = "CboProfiles"
        Me.CboProfiles.Size = New System.Drawing.Size(180, 28)
        Me.CboProfiles.TabIndex = 50
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(69, 204)
        Me.label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(57, 20)
        Me.label6.TabIndex = 54
        Me.label6.Text = "Profile:"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(36, 170)
        Me.label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(82, 20)
        Me.label5.TabIndex = 55
        Me.label5.Text = "Password:"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(24, 136)
        Me.label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(94, 20)
        Me.label4.TabIndex = 56
        Me.label4.Text = "Login Code:"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(29, 97)
        Me.label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(90, 20)
        Me.label3.TabIndex = 57
        Me.label3.Text = "Last Name:"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(28, 59)
        Me.label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(90, 20)
        Me.label2.TabIndex = 58
        Me.label2.Text = "First Name:"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(13, 21)
        Me.label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(104, 20)
        Me.label1.TabIndex = 59
        Me.label1.Text = "Employee ID:"
        '
        'EmployeeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(487, 425)
        Me.Controls.Add(Me.CmdCancel)
        Me.Controls.Add(Me.CmdOK)
        Me.Controls.Add(Me.richTextBox1)
        Me.Controls.Add(Me.TxtEmployeeID)
        Me.Controls.Add(Me.TxtFirstName)
        Me.Controls.Add(Me.TxtLastName)
        Me.Controls.Add(Me.TxtLoginCode)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.CboProfiles)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Name = "EmployeeForm"
        Me.Text = "EmployeeForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents CmdCancel As Button
    Private WithEvents CmdOK As Button
    Private WithEvents richTextBox1 As RichTextBox
    Private WithEvents TxtEmployeeID As TextBox
    Private WithEvents TxtFirstName As TextBox
    Private WithEvents TxtLastName As TextBox
    Private WithEvents TxtLoginCode As TextBox
    Private WithEvents TxtPassword As TextBox
    Private WithEvents CboProfiles As ComboBox
    Private WithEvents label6 As Label
    Private WithEvents label5 As Label
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
End Class
