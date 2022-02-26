<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingForm
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.CmdBackup = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtAdd1 = New System.Windows.Forms.TextBox()
        Me.txtWWW = New System.Windows.Forms.TextBox()
        Me.txtAdd2 = New System.Windows.Forms.TextBox()
        Me.txtFax = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TCBackUpRestore = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.lblBackupinfo = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.lblRestoreInfo = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.CmdRestore = New System.Windows.Forms.Button()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.txtAdd3 = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCompanyName = New System.Windows.Forms.TextBox()
        Me.txtVATRate = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtVATReg = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtTelephone = New System.Windows.Forms.TextBox()
        Me.txtAdd4 = New System.Windows.Forms.TextBox()
        Me.txtPostCode = New System.Windows.Forms.TextBox()
        Me.CmdOK = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TCBackUpRestore.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CmdCancel
        '
        Me.CmdCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdCancel.Location = New System.Drawing.Point(659, 682)
        Me.CmdCancel.Margin = New System.Windows.Forms.Padding(12, 11, 12, 11)
        Me.CmdCancel.Name = "CmdCancel"
        Me.CmdCancel.Size = New System.Drawing.Size(118, 36)
        Me.CmdCancel.TabIndex = 14
        Me.CmdCancel.Text = "Cancel"
        Me.CmdCancel.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.CmdBackup)
        Me.GroupBox2.Controls.Add(Me.ComboBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 22)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(12, 11, 12, 11)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(12, 11, 12, 11)
        Me.GroupBox2.Size = New System.Drawing.Size(392, 243)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Backup Database"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(15, 41)
        Me.Label11.Margin = New System.Windows.Forms.Padding(12, 0, 12, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(454, 37)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Select Database from the list"
        '
        'CmdBackup
        '
        Me.CmdBackup.Location = New System.Drawing.Point(12, 137)
        Me.CmdBackup.Margin = New System.Windows.Forms.Padding(12, 11, 12, 11)
        Me.CmdBackup.Name = "CmdBackup"
        Me.CmdBackup.Size = New System.Drawing.Size(325, 85)
        Me.CmdBackup.TabIndex = 1
        Me.CmdBackup.Text = "Create Backup"
        Me.CmdBackup.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(12, 81)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(12, 11, 12, 11)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(360, 41)
        Me.ComboBox1.TabIndex = 0
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(162, 462)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(12, 11, 12, 11)
        Me.txtEmail.MaxLength = 250
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(561, 26)
        Me.txtEmail.TabIndex = 9
        '
        'txtAdd1
        '
        Me.txtAdd1.Location = New System.Drawing.Point(162, 78)
        Me.txtAdd1.Margin = New System.Windows.Forms.Padding(12, 11, 12, 11)
        Me.txtAdd1.MaxLength = 60
        Me.txtAdd1.Name = "txtAdd1"
        Me.txtAdd1.Size = New System.Drawing.Size(561, 26)
        Me.txtAdd1.TabIndex = 1
        '
        'txtWWW
        '
        Me.txtWWW.Location = New System.Drawing.Point(162, 414)
        Me.txtWWW.Margin = New System.Windows.Forms.Padding(12, 11, 12, 11)
        Me.txtWWW.MaxLength = 90
        Me.txtWWW.Name = "txtWWW"
        Me.txtWWW.Size = New System.Drawing.Size(561, 26)
        Me.txtWWW.TabIndex = 8
        '
        'txtAdd2
        '
        Me.txtAdd2.Location = New System.Drawing.Point(162, 126)
        Me.txtAdd2.Margin = New System.Windows.Forms.Padding(12, 11, 12, 11)
        Me.txtAdd2.MaxLength = 10
        Me.txtAdd2.Name = "txtAdd2"
        Me.txtAdd2.Size = New System.Drawing.Size(561, 26)
        Me.txtAdd2.TabIndex = 2
        '
        'txtFax
        '
        Me.txtFax.Location = New System.Drawing.Point(162, 366)
        Me.txtFax.Margin = New System.Windows.Forms.Padding(12, 11, 12, 11)
        Me.txtFax.MaxLength = 20
        Me.txtFax.Name = "txtFax"
        Me.txtFax.Size = New System.Drawing.Size(561, 26)
        Me.txtFax.TabIndex = 7
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TCBackUpRestore)
        Me.TabPage2.Location = New System.Drawing.Point(8, 34)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(12, 11, 12, 11)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(12, 11, 12, 11)
        Me.TabPage2.Size = New System.Drawing.Size(759, 619)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Backup / Restore"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TCBackUpRestore
        '
        Me.TCBackUpRestore.Controls.Add(Me.TabPage3)
        Me.TCBackUpRestore.Controls.Add(Me.TabPage4)
        Me.TCBackUpRestore.Location = New System.Drawing.Point(12, 21)
        Me.TCBackUpRestore.Margin = New System.Windows.Forms.Padding(12, 11, 12, 11)
        Me.TCBackUpRestore.Name = "TCBackUpRestore"
        Me.TCBackUpRestore.SelectedIndex = 0
        Me.TCBackUpRestore.Size = New System.Drawing.Size(743, 592)
        Me.TCBackUpRestore.TabIndex = 2
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.Orange
        Me.TabPage3.Controls.Add(Me.lblBackupinfo)
        Me.TabPage3.Controls.Add(Me.GroupBox2)
        Me.TabPage3.Location = New System.Drawing.Point(8, 34)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(12, 11, 12, 11)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(12, 11, 12, 11)
        Me.TabPage3.Size = New System.Drawing.Size(727, 550)
        Me.TabPage3.TabIndex = 0
        Me.TabPage3.Text = "Backup"
        '
        'lblBackupinfo
        '
        Me.lblBackupinfo.AutoSize = True
        Me.lblBackupinfo.Location = New System.Drawing.Point(24, 293)
        Me.lblBackupinfo.Margin = New System.Windows.Forms.Padding(12, 0, 12, 0)
        Me.lblBackupinfo.Name = "lblBackupinfo"
        Me.lblBackupinfo.Size = New System.Drawing.Size(57, 20)
        Me.lblBackupinfo.TabIndex = 2
        Me.lblBackupinfo.Text = "Label9"
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.Coral
        Me.TabPage4.Controls.Add(Me.lblRestoreInfo)
        Me.TabPage4.Controls.Add(Me.GroupBox3)
        Me.TabPage4.Location = New System.Drawing.Point(8, 34)
        Me.TabPage4.Margin = New System.Windows.Forms.Padding(12, 11, 12, 11)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(12, 11, 12, 11)
        Me.TabPage4.Size = New System.Drawing.Size(727, 550)
        Me.TabPage4.TabIndex = 1
        Me.TabPage4.Text = "Restore"
        '
        'lblRestoreInfo
        '
        Me.lblRestoreInfo.AutoSize = True
        Me.lblRestoreInfo.Location = New System.Drawing.Point(33, 346)
        Me.lblRestoreInfo.Margin = New System.Windows.Forms.Padding(12, 0, 12, 0)
        Me.lblRestoreInfo.Name = "lblRestoreInfo"
        Me.lblRestoreInfo.Size = New System.Drawing.Size(66, 20)
        Me.lblRestoreInfo.TabIndex = 2
        Me.lblRestoreInfo.Text = "Label12"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.CmdRestore)
        Me.GroupBox3.Controls.Add(Me.ComboBox3)
        Me.GroupBox3.Controls.Add(Me.ComboBox2)
        Me.GroupBox3.Location = New System.Drawing.Point(28, 21)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(12, 11, 12, 11)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(12, 11, 12, 11)
        Me.GroupBox3.Size = New System.Drawing.Size(412, 314)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Restore Database"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(24, 111)
        Me.Label14.Margin = New System.Windows.Forms.Padding(12, 0, 12, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(220, 20)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "Select backup file from the list"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(15, 30)
        Me.Label13.Margin = New System.Windows.Forms.Padding(12, 0, 12, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(250, 20)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "Select dabase you want to restore"
        '
        'CmdRestore
        '
        Me.CmdRestore.Location = New System.Drawing.Point(9, 202)
        Me.CmdRestore.Margin = New System.Windows.Forms.Padding(12, 11, 12, 11)
        Me.CmdRestore.Name = "CmdRestore"
        Me.CmdRestore.Size = New System.Drawing.Size(371, 85)
        Me.CmdRestore.TabIndex = 2
        Me.CmdRestore.Text = "Restore Backup"
        Me.CmdRestore.UseVisualStyleBackColor = True
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(19, 142)
        Me.ComboBox3.Margin = New System.Windows.Forms.Padding(12, 11, 12, 11)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(361, 28)
        Me.ComboBox3.TabIndex = 1
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(19, 72)
        Me.ComboBox2.Margin = New System.Windows.Forms.Padding(12, 11, 12, 11)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(294, 28)
        Me.ComboBox2.TabIndex = 0
        '
        'txtAdd3
        '
        Me.txtAdd3.Location = New System.Drawing.Point(162, 174)
        Me.txtAdd3.Margin = New System.Windows.Forms.Padding(12, 11, 12, 11)
        Me.txtAdd3.MaxLength = 10
        Me.txtAdd3.Name = "txtAdd3"
        Me.txtAdd3.Size = New System.Drawing.Size(561, 26)
        Me.txtAdd3.TabIndex = 3
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(21, 20)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(12, 11, 12, 11)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(775, 661)
        Me.TabControl1.TabIndex = 13
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(8, 34)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(12, 11, 12, 11)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(12, 11, 12, 11)
        Me.TabPage1.Size = New System.Drawing.Size(759, 619)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Company Details"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Peru
        Me.GroupBox1.Controls.Add(Me.txtCompanyName)
        Me.GroupBox1.Controls.Add(Me.txtVATRate)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtVATReg)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label40)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Controls.Add(Me.txtAdd1)
        Me.GroupBox1.Controls.Add(Me.txtWWW)
        Me.GroupBox1.Controls.Add(Me.txtAdd2)
        Me.GroupBox1.Controls.Add(Me.txtFax)
        Me.GroupBox1.Controls.Add(Me.txtAdd3)
        Me.GroupBox1.Controls.Add(Me.txtTelephone)
        Me.GroupBox1.Controls.Add(Me.txtAdd4)
        Me.GroupBox1.Controls.Add(Me.txtPostCode)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 11)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(12, 11, 12, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(12, 11, 12, 11)
        Me.GroupBox1.Size = New System.Drawing.Size(744, 605)
        Me.GroupBox1.TabIndex = 55
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Settings"
        '
        'txtCompanyName
        '
        Me.txtCompanyName.Location = New System.Drawing.Point(162, 30)
        Me.txtCompanyName.Margin = New System.Windows.Forms.Padding(12, 11, 12, 11)
        Me.txtCompanyName.MaxLength = 60
        Me.txtCompanyName.Name = "txtCompanyName"
        Me.txtCompanyName.Size = New System.Drawing.Size(561, 26)
        Me.txtCompanyName.TabIndex = 0
        '
        'txtVATRate
        '
        Me.txtVATRate.Location = New System.Drawing.Point(162, 510)
        Me.txtVATRate.Margin = New System.Windows.Forms.Padding(12, 11, 12, 11)
        Me.txtVATRate.Name = "txtVATRate"
        Me.txtVATRate.Size = New System.Drawing.Size(244, 26)
        Me.txtVATRate.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 30)
        Me.Label1.Margin = New System.Windows.Forms.Padding(12, 0, 12, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 20)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Company Name:"
        '
        'txtVATReg
        '
        Me.txtVATReg.Location = New System.Drawing.Point(162, 558)
        Me.txtVATReg.Margin = New System.Windows.Forms.Padding(12, 11, 12, 11)
        Me.txtVATReg.Name = "txtVATReg"
        Me.txtVATReg.Size = New System.Drawing.Size(561, 26)
        Me.txtVATReg.TabIndex = 11
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(78, 81)
        Me.Label20.Margin = New System.Windows.Forms.Padding(12, 0, 12, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(72, 20)
        Me.Label20.TabIndex = 30
        Me.Label20.Text = "Address:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(48, 561)
        Me.Label10.Margin = New System.Windows.Forms.Padding(12, 0, 12, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(102, 20)
        Me.Label10.TabIndex = 53
        Me.Label10.Text = "VAT Reg No:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(63, 270)
        Me.Label3.Margin = New System.Windows.Forms.Padding(12, 0, 12, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 20)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Post Code:"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(62, 318)
        Me.Label40.Margin = New System.Windows.Forms.Padding(12, 0, 12, 0)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(88, 20)
        Me.Label40.TabIndex = 32
        Me.Label40.Text = "Telephone:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(111, 366)
        Me.Label5.Margin = New System.Windows.Forms.Padding(12, 0, 12, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 20)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Fax:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(79, 417)
        Me.Label6.Margin = New System.Windows.Forms.Padding(12, 0, 12, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 20)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Website:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(35, 465)
        Me.Label7.Margin = New System.Windows.Forms.Padding(12, 0, 12, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(115, 20)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Email Address:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(17, 516)
        Me.Label8.Margin = New System.Windows.Forms.Padding(12, 0, 12, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(133, 20)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Default Vat Rate:"
        '
        'txtTelephone
        '
        Me.txtTelephone.Location = New System.Drawing.Point(162, 318)
        Me.txtTelephone.Margin = New System.Windows.Forms.Padding(12, 11, 12, 11)
        Me.txtTelephone.MaxLength = 20
        Me.txtTelephone.Name = "txtTelephone"
        Me.txtTelephone.Size = New System.Drawing.Size(561, 26)
        Me.txtTelephone.TabIndex = 6
        '
        'txtAdd4
        '
        Me.txtAdd4.Location = New System.Drawing.Point(162, 222)
        Me.txtAdd4.Margin = New System.Windows.Forms.Padding(12, 11, 12, 11)
        Me.txtAdd4.MaxLength = 10
        Me.txtAdd4.Name = "txtAdd4"
        Me.txtAdd4.Size = New System.Drawing.Size(561, 26)
        Me.txtAdd4.TabIndex = 4
        '
        'txtPostCode
        '
        Me.txtPostCode.Location = New System.Drawing.Point(162, 270)
        Me.txtPostCode.Margin = New System.Windows.Forms.Padding(12, 11, 12, 11)
        Me.txtPostCode.MaxLength = 10
        Me.txtPostCode.Name = "txtPostCode"
        Me.txtPostCode.Size = New System.Drawing.Size(244, 26)
        Me.txtPostCode.TabIndex = 5
        '
        'CmdOK
        '
        Me.CmdOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdOK.Location = New System.Drawing.Point(517, 682)
        Me.CmdOK.Margin = New System.Windows.Forms.Padding(12, 11, 12, 11)
        Me.CmdOK.Name = "CmdOK"
        Me.CmdOK.Size = New System.Drawing.Size(118, 36)
        Me.CmdOK.TabIndex = 12
        Me.CmdOK.Text = "OK"
        Me.CmdOK.UseVisualStyleBackColor = True
        '
        'SettingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(798, 738)
        Me.Controls.Add(Me.CmdCancel)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.CmdOK)
        Me.Name = "SettingForm"
        Me.Text = "Settings"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TCBackUpRestore.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CmdCancel As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents CmdBackup As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtAdd1 As TextBox
    Friend WithEvents txtWWW As TextBox
    Friend WithEvents txtAdd2 As TextBox
    Friend WithEvents txtFax As TextBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TCBackUpRestore As TabControl
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents lblBackupinfo As Label
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents lblRestoreInfo As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents CmdRestore As Button
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents txtAdd3 As TextBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtCompanyName As TextBox
    Friend WithEvents txtVATRate As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtVATReg As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtTelephone As TextBox
    Friend WithEvents txtAdd4 As TextBox
    Friend WithEvents txtPostCode As TextBox
    Friend WithEvents CmdOK As Button
End Class
