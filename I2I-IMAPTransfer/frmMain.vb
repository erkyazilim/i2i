Imports System.IO
Imports system.Text
Public Class frmMain

    Dim ImapDownload As New Chilkat.Imap
    Dim ImapUpload As New Chilkat.Imap
    Dim InboxUploaded As Boolean = False
    Dim FilePath As String

    Dim AccountCount As Integer = 0
    Dim UploadedAccountCount As Integer = 0


    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Function PrepareImapDownload(ByVal DownloadServer As String, ByVal Username As String, ByVal Password As String) As Boolean
        Try
            PrepareImapDownload = False

            '  Anything unlocks the component and begins a fully-functional 30-day trial.

            Dim success As Boolean
            success = ImapDownload.UnlockComponent(txtLicense.Text)
            If (success <> True) Then
                ErrorLog(ImapDownload.LastErrorText)
            Else
                '  Connect to an IMAP server.
                success = ImapDownload.Connect(DownloadServer)
                If (success <> True) Then
                    ErrorLog(ImapDownload.LastErrorText)
                Else
                    success = ImapDownload.Login(Username, Password)
                    If (success <> True) Then
                        ErrorLog(ImapDownload.LastErrorText)
                    Else
                        ImapDownload.ReadTimeout = 10

                        PrepareImapDownload = True
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Function

    Private Function DisconnectImapDownload() As Boolean
        Try
            ImapDownload.Disconnect()
        Catch ex As Exception

        End Try
    End Function

    Private Function PrepareImapUpload(ByVal UploadServer As String, ByVal Username As String, ByVal Password As String) As Boolean
        Try
            PrepareImapUpload = False

            '  Anything unlocks the component and begins a fully-functional 30-day trial.

            Dim success As Boolean
            success = ImapUpload.UnlockComponent(txtLicense.Text)
            If (success <> True) Then
                ErrorLog(ImapUpload.LastErrorText)
            Else
                '  Connect to an IMAP server.
                success = ImapUpload.Connect(UploadServer)
                If (success <> True) Then
                    ErrorLog(ImapUpload.LastErrorText)
                Else
                    success = ImapUpload.Login(Username, Password)
                    If (success <> True) Then
                        ErrorLog(ImapUpload.LastErrorText)
                    Else
                        ImapUpload.ReadTimeout = 10

                        PrepareImapUpload = True
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Function

    Private Function DisconnectImapUpload() As Boolean
        Try
            ImapUpload.Disconnect()
        Catch ex As Exception

        End Try
    End Function

    Private Sub btnOpenFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpenFile.Click
        Try
            AccountCount = 0
            Dim openFileDialog1 As New OpenFileDialog()

            openFileDialog1.InitialDirectory = Application.StartupPath
            openFileDialog1.Filter = "accounts file (*.txt)|*.txt"
            openFileDialog1.RestoreDirectory = True

            If openFileDialog1.ShowDialog() = DialogResult.OK Then

                'Read the file 
                FilePath = openFileDialog1.FileName

                Dim fileStream As FileStream = File.OpenRead(FilePath)

                If Not (fileStream Is Nothing) Then
                    Using sr As StreamReader = New StreamReader(fileStream)

                        Dim LineCount As Int16 = 0
                        Dim line As String
                        Do
                            line = sr.ReadLine()
                            If Not line Is Nothing Then LineCount += 1
                        Loop Until line Is Nothing

                        WriteLog("+++++++++++++++++++++++++++++++++++++++++++++++++++")
                        WriteLog(LineCount.ToString & " accounts loaded.")
                        WriteLog("Click ""Start"" to begin transfer...")
                        WriteLog("+++++++++++++++++++++++++++++++++++++++++++++++++++")

                        AccountCount = LineCount


                    End Using

                    btnOpenFile.Enabled = False
                    btnStartBulkUpload.Enabled = True
                End If
                fileStream.Close()

            End If

        Catch ex As Exception


            txtErrorLog.Text += ex.Message.ToString & vbCrLf
            txtErrorLog.Text += "++++++++++++++++++++++++++++++++++++++++++++++++++++++++++" & vbCrLf
            txtErrorLog.Refresh()
        End Try
    End Sub

    Private Sub btnStartBulkUpload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStartBulkUpload.Click
        Try
            Cursor = Cursors.WaitCursor

            txtErrorLog.Text = ""

            btnStartBulkUpload.Enabled = False
            btnCancelBulkUpload.Enabled = True
            txtDownloadServer2.Enabled = False
            txtUploadServer2.Enabled = False


            bwUploader.WorkerSupportsCancellation = True
            bwUploader.WorkerReportsProgress = True
            bwUploader.RunWorkerAsync()

            btnStartBulkUpload.Enabled = False
            btnOpenFile.Enabled = False
            btnCancelBulkUpload.Enabled = True
        Catch ex As Exception
            txtErrorLog.Text += ex.Message.ToString & vbCrLf
            txtErrorLog.Text += "++++++++++++++++++++++++++++++++++++++++++++++++++++++++++" & vbCrLf
            txtErrorLog.Refresh()
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub UploadMailBox(ByVal DownloadServer As String, ByVal DownloadUsername As String, ByVal DownloadPassword As String, ByVal UploadServer As String, ByVal UploadUsername As String, ByVal UploadPassword As String)
        Try
            If PrepareImapDownload(DownloadServer, DownloadUsername, DownloadPassword) And PrepareImapUpload(UploadServer, UploadUsername, UploadPassword) Then

                Dim success As Boolean


                ''''''
                ' The ListMailboxes method returns a Mailboxes object
                ' that contains the collection of mailboxes.
                ' It accepts two arguments: a refName and a wildcardedMailbox.

                Dim refName As String
                refName = ""
                ' refName is usually set to an empty string.
                ' A non-empty reference name argument is the name of a mailbox or a level of
                ' mailbox hierarchy, and indicates the context in which the mailbox
                ' name is interpreted.

                ' Select all mailboxes matching this pattern:
                Dim wildcardedMailbox As String
                wildcardedMailbox = "*"

                Dim mboxes As Chilkat.Mailboxes
                mboxes = ImapDownload.ListMailboxes(refName, wildcardedMailbox)


                If (mboxes Is Nothing) Then
                    ErrorLog(ImapDownload.LastErrorText)
                Else
                    Dim i As Integer
                    Dim mbName As String = ""

                    'SmarterMail bug for Unicode OS's. Mail server creates 2 different IMAP folders (mailboxes) for inbox as "inbox" and "Inbox"
                    'We'll use Inbox as our main mailbox
                    Dim WeGotInbox As Boolean = False

                    For i = 0 To mboxes.Count - 1
                        If mboxes.GetName(i) = "Inbox" Then WeGotInbox = True
                    Next
                    'End of SmarterMail bug check

                    For i = 0 To mboxes.Count - 1


                        'some large mailboxes causes component to logout. So we need to check it and login if not logged in.
                        If Not ImapDownload.IsConnected Then ImapDownload.Connect(DownloadServer)
                        If Not ImapDownload.IsLoggedIn Then ImapDownload.Login(DownloadUsername, DownloadPassword)

                        '  Select an IMAP mailbox (folder)
                        success = ImapDownload.SelectMailbox(mboxes.GetName(i))
                        If (success <> True) Then
                            ErrorLog(ImapDownload.LastErrorText)
                        Else

                            mbName = mboxes.GetName(i)

                            ' Checking if Message exists in folder
                            If ImapDownload.NumMessages > 0 Then

                                '"Sent Items"
                                If mbName = txtSourceFolderSent.Text Then
                                    If chkTransferSentItems.Checked Then mbName = txtTargetFolderSent.Text Else GoTo bypassmailbox
                                End If

                                '"Deleted Items"
                                If mbName = txtSourceFolderDeleted.Text Then
                                    If chkTransferDeletedItems.Checked Then mbName = txtTargetFolderDeleted.Text Else GoTo bypassmailbox
                                End If

                                If mbName = "inbox" And WeGotInbox Then GoTo bypassmailbox
                                If mbName = "inbox" Or mbName = "Inbox" Then
                                    If InboxUploaded Then GoTo bypassmailbox
                                End If

                                'some large mailboxes causes component to logout. So we need to check it and login if not logged in.
                                If Not ImapUpload.IsConnected Then ImapUpload.Connect(UploadServer)
                                If Not ImapUpload.IsLoggedIn Then ImapUpload.Login(UploadUsername, UploadPassword)

                                ' Creating and subscribing folder on Upload Server
                                success = ImapUpload.CreateMailbox(mbName)
                                ImapUpload.Subscribe(mbName)

                                WriteLog("There are " & ImapDownload.NumMessages & " emails in " & mbName & " folder.")



                                'First, SEEN (read) Emails
                                WriteLog("Getting SEEN emails in " & mbName & " folder.")

                                TransferEmails("SEEN", DownloadUsername, mbName)

                                'Second, UNSEEN (Unread) Emails
                                WriteLog("Getting UNSEEN emails in " & mbName & " folder.")

                                TransferEmails("UNSEEN", DownloadUsername, mbName)

                            End If

                        End If

                        If mbName = "inbox" Or mbName = "Inbox" Then
                            InboxUploaded = True
                        End If
bypassmailbox:
                    Next

                    'Delete temp email files on app.path
                    Kill("*.eml")
                End If
            End If
        Catch ex As Exception
            txtErrorLog.Text += ex.Message.ToString & vbCrLf
            txtErrorLog.Text += "++++++++++++++++++++++++++++++++++++++++++++++++++++++++++" & vbCrLf
            txtErrorLog.Refresh()
        Finally
            '  Disconnect from the IMAP server.
            DisconnectImapDownload()
            DisconnectImapUpload()
        End Try
    End Sub

    Private Sub TransferEmails(ByVal Criteria As String, ByVal DownloadUsername As String, ByVal mbName As String)
        Try

            Dim success As Boolean
            ' Get UNSEEN messages.
            Dim msgSet As Chilkat.MessageSet
            msgSet = ImapDownload.Search(Criteria, True)

            ' Fetch all email into a StringArray object.
            ' Each message within the StringArray is the full MIME source of an email.
            Dim sa As Chilkat.StringArray
            sa = ImapDownload.FetchBundleAsMime(msgSet)
            WriteLog(sa.Count & " " & Criteria & " emails for " & DownloadUsername & " in " & mbName & " folder.")
            If sa.Count > 0 Then

                WriteLog("Download starting for " & Criteria & " emails")
                Dim ii As Long
                For ii = 0 To sa.Count - 1
                    ' saving message to file
                    sa.SaveNthToFile(ii, DownloadUsername & "_" & mbName & "_" & ii.ToString & "_ae.eml")
                Next

                Dim email As New Chilkat.Email()

                '  Load each emails from .eml files.
                Dim iii As Long
                For iii = 0 To sa.Count - 1
                    success = email.LoadEml(DownloadUsername & "_" & mbName & "_" & iii.ToString & "_ae.eml")
                    If (success <> True) Then
                        ErrorLog(email.LastErrorText)
                    Else
                        If email.Size > 0 AndAlso Not (ImapDownload.GetMailFlag(email, "Deleted") = 1) Then

                            If Criteria = "SEEN" Then ImapUpload.AppendSeen = True
                            If Criteria = "UNSEEN" Then ImapUpload.AppendSeen = False

                            success = ImapUpload.AppendMail(mbName, email)
                            If (success <> True) Then
                                ErrorLog(ImapUpload.LastErrorText)
                            Else

                                WriteLog("Email " & DownloadUsername & "_" & mbName & "_" & iii.ToString & "_ae.eml uploaded to " & mbName & " on upload server.")

                            End If
                        Else
                            ErrorLog("Zero sized email " & DownloadUsername & "_" & mbName & "_" & iii.ToString & "_ae.eml not processed.")
                        End If

                    End If
                Next
            Else
                WriteLog("Zero " & Criteria & " emails. Bypassing...")
            End If

        Catch ex As Exception
            ErrorLog(ex.Message)
        End Try
    End Sub

    Private Sub btnStartSingleUpload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStartSingleUpload.Click
        Try
            lbProcess.Items.Clear()
            txtErrorLog.Text = ""
            UploadMailBox(txtDownloadServer1.Text, txtDownloadUsername1.Text, txtDownloadPassword1.Text, txtUploadServer1.Text, txtUploadUsername1.Text, txtUploadPassword1.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub chkTransferSentItems_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTransferSentItems.CheckedChanged
        Try
            If chkTransferSentItems.Checked Then
                txtSourceFolderSent.Enabled = True
                txtTargetFolderSent.Enabled = True
            Else
                txtSourceFolderSent.Enabled = False
                txtTargetFolderSent.Enabled = False
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub chkTransferDeletedItems_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTransferDeletedItems.CheckedChanged
        Try
            If chkTransferDeletedItems.Checked Then
                txtSourceFolderDeleted.Enabled = True
                txtTargetFolderDeleted.Enabled = True
            Else
                txtSourceFolderDeleted.Enabled = False
                txtTargetFolderDeleted.Enabled = False
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start(LinkLabel1.Text)
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        System.Diagnostics.Process.Start("http://www.chilkatsoft.com/imap-dotnet.asp")
    End Sub

    Private Sub ErrorLog(ByVal strError As String)
        Try
            Dim ErrLog As String = ""
            ErrLog += "[" & DateTime.Now.ToString & "] " & strError & vbCrLf
            ErrLog += "++++++++++++++++++++++++++++++++++++++++++++++++++++++++++" & vbCrLf

            txtErrorLog.Text += ErrLog
            txtErrorLog.Refresh()

            CreateErrorLogRecord(strError, "i2i")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub WriteLog(ByVal strLog As String)
        Try
            lbProcess.Items.Add("[" & DateTime.Now.ToString & "] " & strLog)
            lbProcess.SelectedIndex = lbProcess.Items.Count - 1

            CreateLogRecord(strLog, "i2i")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CreateLogRecord(ByVal LogMessage As String, ByVal LogRecordName As String)

        Dim FilePath As String
        Dim BytesToWrite() As Byte
        Dim RecordWriter As StreamWriter
        Dim StrNewLine As String

        Try
            FilePath = LogRecordName + ".log"
            If (File.Exists(FilePath)) Then
                RecordWriter = New StreamWriter(File.Open(FilePath, FileMode.Append, FileAccess.Write))
            Else
                RecordWriter = New StreamWriter(File.Open(FilePath, FileMode.Create, FileAccess.Write))
            End If

            StrNewLine = Chr(13) & Chr(10)
            LogMessage = DateTime.Now.ToShortDateString() & " " & DateTime.Now.ToShortTimeString() & " -------- " & LogMessage & StrNewLine
            BytesToWrite = Encoding.UTF8.GetBytes(LogMessage)
            RecordWriter.BaseStream.Write(BytesToWrite, 0, BytesToWrite.Length)
            RecordWriter.Flush()
            RecordWriter.Close()
            RecordWriter.Dispose()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub CreateErrorLogRecord(ByVal LogMessage As String, ByVal LogRecordName As String)

        Dim FilePath As String
        Dim BytesToWrite() As Byte
        Dim RecordWriter As StreamWriter
        Dim StrNewLine As String

        Try
            FilePath = LogRecordName + "_Err.log"
            If (File.Exists(FilePath)) Then
                RecordWriter = New StreamWriter(File.Open(FilePath, FileMode.Append, FileAccess.Write))
            Else
                RecordWriter = New StreamWriter(File.Open(FilePath, FileMode.Create, FileAccess.Write))
            End If

            StrNewLine = Chr(13) & Chr(10)
            LogMessage = DateTime.Now.ToShortDateString() & " " & DateTime.Now.ToShortTimeString() & " -------- " & LogMessage & StrNewLine
            BytesToWrite = Encoding.UTF8.GetBytes(LogMessage)
            RecordWriter.BaseStream.Write(BytesToWrite, 0, BytesToWrite.Length)
            RecordWriter.Flush()
            RecordWriter.Close()
            RecordWriter.Dispose()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub bwUploader_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bwUploader.DoWork

        pbUpload.Maximum = AccountCount
        pbUpload.Minimum = 0


        Dim fileStream As FileStream = File.OpenRead(FilePath)
        If Not (fileStream Is Nothing) Then
            Using sr As StreamReader = New StreamReader(fileStream)
                Dim line As String
                ' Read and display the lines from the file until the end 
                ' of the file is reached.
                Do


                    line = sr.ReadLine()
                    If Not line Is Nothing AndAlso line.Contains(";") Then
                        Dim Username As String = Split(line, ";")(0)
                        Dim Password As String = Split(line, ";")(1)

                        If Len(Username) > 0 AndAlso Len(Password) > 0 Then
                            ' Download & upload proc.
                            InboxUploaded = False
                            WriteLog("Transferring " & Username & " from " & txtDownloadServer2.Text & " to " & txtUploadServer2.Text)

                            UploadMailBox(txtDownloadServer2.Text, Username, Password, txtUploadServer2.Text, Username, Password)
                        End If

                        UploadedAccountCount += 1
                        bwUploader.ReportProgress(UploadedAccountCount)
                    End If

                    If bwUploader.CancellationPending = True Then Exit Do
                Loop Until line Is Nothing
                sr.Close()
            End Using
        End If

        fileStream.Close()

    End Sub

    Private Sub bwUploader_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles bwUploader.ProgressChanged
        pbUpload.Value = e.ProgressPercentage
        lblUploadedCount.Text = pbUpload.Value.ToString & "/" & pbUpload.Maximum.ToString
    End Sub

    Private Sub bwUploader_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bwUploader.RunWorkerCompleted
        If e.Cancelled Then
            MsgBox("Upload cancelled. Some accounts and emails not uploaded to the upload server. Check log files.", My.Application.Info.ProductName, MessageBoxIcon.Warning)

            WriteLog("+++++++++++++++++++++++++++++++++++++++++++++++++++")
            WriteLog("Upload cancelled. Some accounts and emails not uploaded to the upload server. Check log files.")
            WriteLog("+++++++++++++++++++++++++++++++++++++++++++++++++++")

            pbUpload.Value = 0
            UploadedAccountCount = 0
        Else
            WriteLog("+++++++++++++++++++++++++++++++++++++++++++++++++++")
            WriteLog("File End")
            WriteLog("+++++++++++++++++++++++++++++++++++++++++++++++++++")

            pbUpload.Value = 0
            UploadedAccountCount = 0
        End If

        btnOpenFile.Enabled = True
        btnStartBulkUpload.Enabled = False
        btnCancelBulkUpload.Enabled = False
        txtDownloadServer2.Enabled = True
        txtUploadServer2.Enabled = True
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelBulkUpload.Click
        bwUploader.CancelAsync()
    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            btnStartBulkUpload.CheckForIllegalCrossThreadCalls = False
        Catch ex As Exception

        End Try
    End Sub
End Class


