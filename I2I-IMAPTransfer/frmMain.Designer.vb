<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.txtErrorLog = New System.Windows.Forms.TextBox
        Me.lbProcess = New System.Windows.Forms.ListBox
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtUploadServer1 = New System.Windows.Forms.TextBox
        Me.txtUploadPassword1 = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtUploadUsername1 = New System.Windows.Forms.TextBox
        Me.btnStartSingleUpload = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtDownloadServer1 = New System.Windows.Forms.TextBox
        Me.txtDownloadPassword1 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtDownloadUsername1 = New System.Windows.Forms.TextBox
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.Label20 = New System.Windows.Forms.Label
        Me.btnStartMassUpload = New System.Windows.Forms.Button
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtUploadServer2 = New System.Windows.Forms.TextBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtDownloadServer2 = New System.Windows.Forms.TextBox
        Me.btnOpenFile = New System.Windows.Forms.Button
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel
        Me.chkTransferDeletedItems = New System.Windows.Forms.CheckBox
        Me.chkTransferSentItems = New System.Windows.Forms.CheckBox
        Me.txtTargetFolderDeleted = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtSourceFolderDeleted = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtTargetFolderSent = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtSourceFolderSent = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtLicense = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.Label8 = New System.Windows.Forms.Label
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtErrorLog
        '
        Me.txtErrorLog.Location = New System.Drawing.Point(12, 346)
        Me.txtErrorLog.Multiline = True
        Me.txtErrorLog.Name = "txtErrorLog"
        Me.txtErrorLog.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtErrorLog.Size = New System.Drawing.Size(717, 150)
        Me.txtErrorLog.TabIndex = 8
        Me.txtErrorLog.TabStop = False
        '
        'lbProcess
        '
        Me.lbProcess.FormattingEnabled = True
        Me.lbProcess.Location = New System.Drawing.Point(12, 167)
        Me.lbProcess.Name = "lbProcess"
        Me.lbProcess.Size = New System.Drawing.Size(717, 173)
        Me.lbProcess.TabIndex = 9
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(1, 9)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(740, 152)
        Me.TabControl1.TabIndex = 10
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.btnStartSingleUpload)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(732, 126)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Single User Transfer"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtUploadServer1)
        Me.GroupBox2.Controls.Add(Me.txtUploadPassword1)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtUploadUsername1)
        Me.GroupBox2.Location = New System.Drawing.Point(328, 13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(315, 93)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "IMAP Upload Server"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Server"
        '
        'txtUploadServer1
        '
        Me.txtUploadServer1.Location = New System.Drawing.Point(117, 19)
        Me.txtUploadServer1.Name = "txtUploadServer1"
        Me.txtUploadServer1.Size = New System.Drawing.Size(174, 20)
        Me.txtUploadServer1.TabIndex = 4
        '
        'txtUploadPassword1
        '
        Me.txtUploadPassword1.Location = New System.Drawing.Point(117, 67)
        Me.txtUploadPassword1.Name = "txtUploadPassword1"
        Me.txtUploadPassword1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtUploadPassword1.Size = New System.Drawing.Size(97, 20)
        Me.txtUploadPassword1.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Username"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 70)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Password"
        '
        'txtUploadUsername1
        '
        Me.txtUploadUsername1.Location = New System.Drawing.Point(117, 43)
        Me.txtUploadUsername1.Name = "txtUploadUsername1"
        Me.txtUploadUsername1.Size = New System.Drawing.Size(174, 20)
        Me.txtUploadUsername1.TabIndex = 5
        '
        'btnStartSingleUpload
        '
        Me.btnStartSingleUpload.Location = New System.Drawing.Point(650, 19)
        Me.btnStartSingleUpload.Name = "btnStartSingleUpload"
        Me.btnStartSingleUpload.Size = New System.Drawing.Size(75, 87)
        Me.btnStartSingleUpload.TabIndex = 10
        Me.btnStartSingleUpload.Text = "Start"
        Me.btnStartSingleUpload.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtDownloadServer1)
        Me.GroupBox1.Controls.Add(Me.txtDownloadPassword1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtDownloadUsername1)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(315, 93)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "IMAP Download Server"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Server"
        '
        'txtDownloadServer1
        '
        Me.txtDownloadServer1.Location = New System.Drawing.Point(117, 19)
        Me.txtDownloadServer1.Name = "txtDownloadServer1"
        Me.txtDownloadServer1.Size = New System.Drawing.Size(174, 20)
        Me.txtDownloadServer1.TabIndex = 1
        '
        'txtDownloadPassword1
        '
        Me.txtDownloadPassword1.Location = New System.Drawing.Point(117, 67)
        Me.txtDownloadPassword1.Name = "txtDownloadPassword1"
        Me.txtDownloadPassword1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtDownloadPassword1.Size = New System.Drawing.Size(97, 20)
        Me.txtDownloadPassword1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Password"
        '
        'txtDownloadUsername1
        '
        Me.txtDownloadUsername1.Location = New System.Drawing.Point(117, 43)
        Me.txtDownloadUsername1.Name = "txtDownloadUsername1"
        Me.txtDownloadUsername1.Size = New System.Drawing.Size(174, 20)
        Me.txtDownloadUsername1.TabIndex = 2
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label20)
        Me.TabPage2.Controls.Add(Me.btnStartMassUpload)
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Controls.Add(Me.btnOpenFile)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(732, 126)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Mass Upload"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label20.Location = New System.Drawing.Point(392, 105)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(287, 13)
        Me.Label20.TabIndex = 14
        Me.Label20.Text = "* Examine SampleAccountFile.txt for accounts file structure."
        '
        'btnStartMassUpload
        '
        Me.btnStartMassUpload.Enabled = False
        Me.btnStartMassUpload.Location = New System.Drawing.Point(565, 15)
        Me.btnStartMassUpload.Name = "btnStartMassUpload"
        Me.btnStartMassUpload.Size = New System.Drawing.Size(150, 87)
        Me.btnStartMassUpload.TabIndex = 13
        Me.btnStartMassUpload.Text = "Start Mass Upload"
        Me.btnStartMassUpload.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.txtUploadServer2)
        Me.GroupBox4.Location = New System.Drawing.Point(7, 63)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(368, 51)
        Me.GroupBox4.TabIndex = 12
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "IMAP Upload Server"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(13, 22)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(38, 13)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Server"
        '
        'txtUploadServer2
        '
        Me.txtUploadServer2.Location = New System.Drawing.Point(117, 19)
        Me.txtUploadServer2.Name = "txtUploadServer2"
        Me.txtUploadServer2.Size = New System.Drawing.Size(239, 20)
        Me.txtUploadServer2.TabIndex = 4
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.txtDownloadServer2)
        Me.GroupBox3.Location = New System.Drawing.Point(7, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(368, 51)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "IMAP Download Server"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Server"
        '
        'txtDownloadServer2
        '
        Me.txtDownloadServer2.Location = New System.Drawing.Point(117, 19)
        Me.txtDownloadServer2.Name = "txtDownloadServer2"
        Me.txtDownloadServer2.Size = New System.Drawing.Size(239, 20)
        Me.txtDownloadServer2.TabIndex = 1
        '
        'btnOpenFile
        '
        Me.btnOpenFile.Location = New System.Drawing.Point(395, 15)
        Me.btnOpenFile.Name = "btnOpenFile"
        Me.btnOpenFile.Size = New System.Drawing.Size(150, 87)
        Me.btnOpenFile.TabIndex = 0
        Me.btnOpenFile.Text = "Load accounts from file"
        Me.btnOpenFile.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.LinkLabel2)
        Me.TabPage3.Controls.Add(Me.chkTransferDeletedItems)
        Me.TabPage3.Controls.Add(Me.chkTransferSentItems)
        Me.TabPage3.Controls.Add(Me.txtTargetFolderDeleted)
        Me.TabPage3.Controls.Add(Me.Label15)
        Me.TabPage3.Controls.Add(Me.txtSourceFolderDeleted)
        Me.TabPage3.Controls.Add(Me.Label16)
        Me.TabPage3.Controls.Add(Me.txtTargetFolderSent)
        Me.TabPage3.Controls.Add(Me.Label14)
        Me.TabPage3.Controls.Add(Me.txtSourceFolderSent)
        Me.TabPage3.Controls.Add(Me.Label13)
        Me.TabPage3.Controls.Add(Me.txtLicense)
        Me.TabPage3.Controls.Add(Me.Label12)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(732, 126)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Settings"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(374, 12)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(80, 13)
        Me.LinkLabel2.TabIndex = 12
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "(?) License Info"
        Me.ToolTip1.SetToolTip(Me.LinkLabel2, "Chilkat IMAP is a commercial component we used to handle IMAP protocol. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "You can" & _
                " buy a license from their website or use it for 30 days.")
        '
        'chkTransferDeletedItems
        '
        Me.chkTransferDeletedItems.AutoSize = True
        Me.chkTransferDeletedItems.Location = New System.Drawing.Point(10, 84)
        Me.chkTransferDeletedItems.Name = "chkTransferDeletedItems"
        Me.chkTransferDeletedItems.Size = New System.Drawing.Size(143, 17)
        Me.chkTransferDeletedItems.TabIndex = 11
        Me.chkTransferDeletedItems.Text = "Transfer ""Deleted Items"""
        Me.chkTransferDeletedItems.UseVisualStyleBackColor = True
        '
        'chkTransferSentItems
        '
        Me.chkTransferSentItems.AutoSize = True
        Me.chkTransferSentItems.Checked = True
        Me.chkTransferSentItems.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkTransferSentItems.Location = New System.Drawing.Point(9, 37)
        Me.chkTransferSentItems.Name = "chkTransferSentItems"
        Me.chkTransferSentItems.Size = New System.Drawing.Size(128, 17)
        Me.chkTransferSentItems.TabIndex = 10
        Me.chkTransferSentItems.Text = "Transfer ""Sent Items"""
        Me.chkTransferSentItems.UseVisualStyleBackColor = True
        '
        'txtTargetFolderDeleted
        '
        Me.txtTargetFolderDeleted.Enabled = False
        Me.txtTargetFolderDeleted.Location = New System.Drawing.Point(486, 100)
        Me.txtTargetFolderDeleted.Name = "txtTargetFolderDeleted"
        Me.txtTargetFolderDeleted.Size = New System.Drawing.Size(99, 20)
        Me.txtTargetFolderDeleted.TabIndex = 9
        Me.txtTargetFolderDeleted.Text = "Trash"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(297, 104)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(189, 13)
        Me.Label15.TabIndex = 8
        Me.Label15.Text = "Target folder name for ""Deleted Items"""
        '
        'txtSourceFolderDeleted
        '
        Me.txtSourceFolderDeleted.Enabled = False
        Me.txtSourceFolderDeleted.Location = New System.Drawing.Point(198, 100)
        Me.txtSourceFolderDeleted.Name = "txtSourceFolderDeleted"
        Me.txtSourceFolderDeleted.Size = New System.Drawing.Size(99, 20)
        Me.txtSourceFolderDeleted.TabIndex = 7
        Me.txtSourceFolderDeleted.Text = "Deleted Items"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(6, 104)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(192, 13)
        Me.Label16.TabIndex = 6
        Me.Label16.Text = "Source folder name for ""Deleted Items"""
        '
        'txtTargetFolderSent
        '
        Me.txtTargetFolderSent.Location = New System.Drawing.Point(486, 54)
        Me.txtTargetFolderSent.Name = "txtTargetFolderSent"
        Me.txtTargetFolderSent.Size = New System.Drawing.Size(99, 20)
        Me.txtTargetFolderSent.TabIndex = 5
        Me.txtTargetFolderSent.Text = "Sent"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(297, 58)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(174, 13)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Target folder name for ""Sent Items"""
        '
        'txtSourceFolderSent
        '
        Me.txtSourceFolderSent.Location = New System.Drawing.Point(198, 54)
        Me.txtSourceFolderSent.Name = "txtSourceFolderSent"
        Me.txtSourceFolderSent.Size = New System.Drawing.Size(99, 20)
        Me.txtSourceFolderSent.TabIndex = 3
        Me.txtSourceFolderSent.Text = "Sent Items"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 57)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(177, 13)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Source folder name for ""Sent Items"""
        '
        'txtLicense
        '
        Me.txtLicense.Location = New System.Drawing.Point(199, 9)
        Me.txtLicense.Name = "txtLicense"
        Me.txtLicense.Size = New System.Drawing.Size(169, 20)
        Me.txtLicense.TabIndex = 1
        Me.txtLicense.Text = "Anything for 30-day trial"
        Me.ToolTip1.SetToolTip(Me.txtLicense, "Chilkat IMAP is a commercial component we used to handle IMAP protocol. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "You can" & _
                " buy a license from their website or use it for 30 days.")
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(7, 12)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(165, 13)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Chilkat IMAP Compenent License"
        Me.ToolTip1.SetToolTip(Me.Label12, "Chilkat IMAP is a commercial component we used to handle IMAP protocol. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "You can" & _
                " buy a license from their website or use it for 30 days.")
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.PictureBox1)
        Me.TabPage4.Controls.Add(Me.LinkLabel1)
        Me.TabPage4.Controls.Add(Me.Label19)
        Me.TabPage4.Controls.Add(Me.Label18)
        Me.TabPage4.Controls.Add(Me.Label17)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(732, 126)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "About"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(109, 64)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(151, 13)
        Me.LinkLabel1.TabIndex = 3
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "http://code.google.com/p/i2i/"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(109, 35)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(244, 13)
        Me.Label19.TabIndex = 2
        Me.Label19.Text = "You can use and distribute I2I under GNU GPL v3"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(14, 35)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(0, 13)
        Me.Label18.TabIndex = 1
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label17.Location = New System.Drawing.Point(109, 6)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(226, 22)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "I2I - IMAP Data Transfer"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Server"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(117, 19)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(174, 20)
        Me.TextBox3.TabIndex = 4
        Me.TextBox3.Text = "mail.endersys.com"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(117, 67)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox4.Size = New System.Drawing.Size(97, 20)
        Me.TextBox4.TabIndex = 6
        Me.TextBox4.Text = "test"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(13, 46)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 13)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Username"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(13, 70)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 13)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Password"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(117, 43)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(174, 20)
        Me.TextBox5.TabIndex = 5
        Me.TextBox5.Text = "imaptest"
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipTitle = "About Chilkat IMAP Compenent"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(743, 502)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.lbProcess)
        Me.Controls.Add(Me.txtErrorLog)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "I2I - IMAP to IMAP Mailbox Transfer"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtErrorLog As System.Windows.Forms.TextBox
    Friend WithEvents lbProcess As System.Windows.Forms.ListBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtUploadServer1 As System.Windows.Forms.TextBox
    Friend WithEvents txtUploadPassword1 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtUploadUsername1 As System.Windows.Forms.TextBox
    Friend WithEvents btnStartSingleUpload As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDownloadServer1 As System.Windows.Forms.TextBox
    Friend WithEvents txtDownloadPassword1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDownloadUsername1 As System.Windows.Forms.TextBox
    Friend WithEvents btnOpenFile As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtUploadServer2 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtDownloadServer2 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents btnStartMassUpload As System.Windows.Forms.Button
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtLicense As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents txtTargetFolderSent As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtSourceFolderSent As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtTargetFolderDeleted As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtSourceFolderDeleted As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents chkTransferDeletedItems As System.Windows.Forms.CheckBox
    Friend WithEvents chkTransferSentItems As System.Windows.Forms.CheckBox
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel

End Class
