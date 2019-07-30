Imports System
Imports System.IO
Imports System.Security
Imports System.Security.Cryptography

Public Class frmMain
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtDestinationEncrypt As System.Windows.Forms.TextBox
    Friend WithEvents btnEncrypt As System.Windows.Forms.Button
    Friend WithEvents txtConPassEncrypt As System.Windows.Forms.TextBox
    Friend WithEvents txtPassEncrypt As System.Windows.Forms.TextBox
    Friend WithEvents txtFileToEncrypt As System.Windows.Forms.TextBox
    Friend WithEvents pbStatus As System.Windows.Forms.ProgressBar
    Friend WithEvents txtDestinationDecrypt As System.Windows.Forms.TextBox
    Friend WithEvents btnDecrypt As System.Windows.Forms.Button
    Friend WithEvents txtConPassDecrypt As System.Windows.Forms.TextBox
    Friend WithEvents txtPassDecrypt As System.Windows.Forms.TextBox
    Friend WithEvents txtFileToDecrypt As System.Windows.Forms.TextBox
    Friend WithEvents btnChangeEncrypt As System.Windows.Forms.Button
    Friend WithEvents btnBrowseEncrypt As System.Windows.Forms.Button
    Friend WithEvents btnChangeDecrypt As System.Windows.Forms.Button
    Friend WithEvents btnBrowseDecrypt As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents FolderBrowserDialog As System.Windows.Forms.FolderBrowserDialog
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnChangeEncrypt = New System.Windows.Forms.Button()
        Me.txtDestinationEncrypt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnEncrypt = New System.Windows.Forms.Button()
        Me.txtConPassEncrypt = New System.Windows.Forms.TextBox()
        Me.txtPassEncrypt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnBrowseEncrypt = New System.Windows.Forms.Button()
        Me.txtFileToEncrypt = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnChangeDecrypt = New System.Windows.Forms.Button()
        Me.txtDestinationDecrypt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnDecrypt = New System.Windows.Forms.Button()
        Me.txtConPassDecrypt = New System.Windows.Forms.TextBox()
        Me.txtPassDecrypt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnBrowseDecrypt = New System.Windows.Forms.Button()
        Me.txtFileToDecrypt = New System.Windows.Forms.TextBox()
        Me.pbStatus = New System.Windows.Forms.ProgressBar()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.FolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(493, 232)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage1.Controls.Add(Me.btnChangeEncrypt)
        Me.TabPage1.Controls.Add(Me.txtDestinationEncrypt)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.btnEncrypt)
        Me.TabPage1.Controls.Add(Me.txtConPassEncrypt)
        Me.TabPage1.Controls.Add(Me.txtPassEncrypt)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.btnBrowseEncrypt)
        Me.TabPage1.Controls.Add(Me.txtFileToEncrypt)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(485, 199)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Encrypt File"
        '
        'btnChangeEncrypt
        '
        Me.btnChangeEncrypt.Enabled = False
        Me.btnChangeEncrypt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangeEncrypt.Location = New System.Drawing.Point(372, 64)
        Me.btnChangeEncrypt.Name = "btnChangeEncrypt"
        Me.btnChangeEncrypt.Size = New System.Drawing.Size(108, 35)
        Me.btnChangeEncrypt.TabIndex = 11
        Me.btnChangeEncrypt.Text = "Change"
        '
        'txtDestinationEncrypt
        '
        Me.txtDestinationEncrypt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDestinationEncrypt.Location = New System.Drawing.Point(177, 68)
        Me.txtDestinationEncrypt.Name = "txtDestinationEncrypt"
        Me.txtDestinationEncrypt.ReadOnly = True
        Me.txtDestinationEncrypt.Size = New System.Drawing.Size(184, 26)
        Me.txtDestinationEncrypt.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(145, 31)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "File destination"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnEncrypt
        '
        Me.btnEncrypt.Enabled = False
        Me.btnEncrypt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEncrypt.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEncrypt.Location = New System.Drawing.Point(372, 133)
        Me.btnEncrypt.Name = "btnEncrypt"
        Me.btnEncrypt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnEncrypt.Size = New System.Drawing.Size(108, 58)
        Me.btnEncrypt.TabIndex = 8
        Me.btnEncrypt.Text = "ENCRYPT"
        '
        'txtConPassEncrypt
        '
        Me.txtConPassEncrypt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConPassEncrypt.Location = New System.Drawing.Point(177, 165)
        Me.txtConPassEncrypt.Name = "txtConPassEncrypt"
        Me.txtConPassEncrypt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConPassEncrypt.Size = New System.Drawing.Size(184, 26)
        Me.txtConPassEncrypt.TabIndex = 7
        '
        'txtPassEncrypt
        '
        Me.txtPassEncrypt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassEncrypt.Location = New System.Drawing.Point(177, 133)
        Me.txtPassEncrypt.Name = "txtPassEncrypt"
        Me.txtPassEncrypt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassEncrypt.Size = New System.Drawing.Size(184, 26)
        Me.txtPassEncrypt.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 28)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "File to encrypt"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 159)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(168, 32)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Confirm password"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 30)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Type password"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnBrowseEncrypt
        '
        Me.btnBrowseEncrypt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowseEncrypt.Location = New System.Drawing.Point(372, 22)
        Me.btnBrowseEncrypt.Name = "btnBrowseEncrypt"
        Me.btnBrowseEncrypt.Size = New System.Drawing.Size(108, 36)
        Me.btnBrowseEncrypt.TabIndex = 2
        Me.btnBrowseEncrypt.Text = "Browse"
        '
        'txtFileToEncrypt
        '
        Me.txtFileToEncrypt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFileToEncrypt.Location = New System.Drawing.Point(177, 27)
        Me.txtFileToEncrypt.Name = "txtFileToEncrypt"
        Me.txtFileToEncrypt.ReadOnly = True
        Me.txtFileToEncrypt.Size = New System.Drawing.Size(184, 26)
        Me.txtFileToEncrypt.TabIndex = 1
        Me.txtFileToEncrypt.Text = "Click Browse to load file."
        '
        'TabPage2
        '
        Me.TabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage2.Controls.Add(Me.btnChangeDecrypt)
        Me.TabPage2.Controls.Add(Me.txtDestinationDecrypt)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.btnDecrypt)
        Me.TabPage2.Controls.Add(Me.txtConPassDecrypt)
        Me.TabPage2.Controls.Add(Me.txtPassDecrypt)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.btnBrowseDecrypt)
        Me.TabPage2.Controls.Add(Me.txtFileToDecrypt)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(485, 199)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Decrypt File"
        '
        'btnChangeDecrypt
        '
        Me.btnChangeDecrypt.Enabled = False
        Me.btnChangeDecrypt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangeDecrypt.Location = New System.Drawing.Point(372, 65)
        Me.btnChangeDecrypt.Name = "btnChangeDecrypt"
        Me.btnChangeDecrypt.Size = New System.Drawing.Size(108, 35)
        Me.btnChangeDecrypt.TabIndex = 22
        Me.btnChangeDecrypt.Text = "Change"
        '
        'txtDestinationDecrypt
        '
        Me.txtDestinationDecrypt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDestinationDecrypt.Location = New System.Drawing.Point(177, 69)
        Me.txtDestinationDecrypt.Name = "txtDestinationDecrypt"
        Me.txtDestinationDecrypt.ReadOnly = True
        Me.txtDestinationDecrypt.Size = New System.Drawing.Size(184, 26)
        Me.txtDestinationDecrypt.TabIndex = 21
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(156, 25)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "File destination"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnDecrypt
        '
        Me.btnDecrypt.Enabled = False
        Me.btnDecrypt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDecrypt.Location = New System.Drawing.Point(372, 135)
        Me.btnDecrypt.Name = "btnDecrypt"
        Me.btnDecrypt.Size = New System.Drawing.Size(108, 58)
        Me.btnDecrypt.TabIndex = 19
        Me.btnDecrypt.Text = "DECRYPT"
        '
        'txtConPassDecrypt
        '
        Me.txtConPassDecrypt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConPassDecrypt.Location = New System.Drawing.Point(177, 165)
        Me.txtConPassDecrypt.Name = "txtConPassDecrypt"
        Me.txtConPassDecrypt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConPassDecrypt.Size = New System.Drawing.Size(184, 26)
        Me.txtConPassDecrypt.TabIndex = 18
        '
        'txtPassDecrypt
        '
        Me.txtPassDecrypt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassDecrypt.Location = New System.Drawing.Point(177, 132)
        Me.txtPassDecrypt.Name = "txtPassDecrypt"
        Me.txtPassDecrypt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassDecrypt.Size = New System.Drawing.Size(184, 26)
        Me.txtPassDecrypt.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(131, 26)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "File to decrypt"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label7.Location = New System.Drawing.Point(3, 157)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(161, 36)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Confirm password"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(1, 129)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(144, 25)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Type password"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'btnBrowseDecrypt
        '
        Me.btnBrowseDecrypt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowseDecrypt.Location = New System.Drawing.Point(372, 22)
        Me.btnBrowseDecrypt.Name = "btnBrowseDecrypt"
        Me.btnBrowseDecrypt.Size = New System.Drawing.Size(108, 37)
        Me.btnBrowseDecrypt.TabIndex = 13
        Me.btnBrowseDecrypt.Text = "Browse"
        '
        'txtFileToDecrypt
        '
        Me.txtFileToDecrypt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFileToDecrypt.Location = New System.Drawing.Point(177, 27)
        Me.txtFileToDecrypt.Name = "txtFileToDecrypt"
        Me.txtFileToDecrypt.ReadOnly = True
        Me.txtFileToDecrypt.Size = New System.Drawing.Size(184, 26)
        Me.txtFileToDecrypt.TabIndex = 12
        Me.txtFileToDecrypt.Text = "Click Browse to load file."
        '
        'pbStatus
        '
        Me.pbStatus.Location = New System.Drawing.Point(0, 238)
        Me.pbStatus.Name = "pbStatus"
        Me.pbStatus.Size = New System.Drawing.Size(493, 41)
        Me.pbStatus.TabIndex = 1
        '
        'frmMain
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(492, 281)
        Me.Controls.Add(Me.pbStatus)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmMain"
        Me.Text = "Encrypt / Decrypt File (Using Rijndael)"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region



#Region "1. Variables "

    '*************************
    '**  Variables
    '*************************

    Dim strFileToEncrypt As String
    Dim strFileToDecrypt As String
    Dim strOutputEncrypt As String
    Dim strOutputDecrypt As String
    Dim fsInput As System.IO.FileStream
    Dim fsOutput As System.IO.FileStream

#End Region


#Region "2. Membuat Key "

    '*************************
    '** Membuat Key
    '*************************

    Private Function CreateKey(ByVal strPassword As String) As Byte()
        'Mengubah strPassword ke array dan menyimapan di chrData.
        Dim chrData() As Char = strPassword.ToCharArray
        'Menggunakan intLength utuk mendapatkan ukuran strPassword.
        Dim intLength As Integer = chrData.GetUpperBound(0)
        'Menyatakan bytDataToHash dan membuatnya dalam ukuran yg sama sebagai chrData.
        Dim bytDataToHash(intLength) As Byte

        'Menggunakan For Next untuk mengubah dan menyimpan chrData menjadi bytDataToHash.
        For i As Integer = 0 To chrData.GetUpperBound(0)
            bytDataToHash(i) = CByte(Asc(chrData(i)))
        Next

        'Meyatakan tipe hash.
        Dim SHA512 As New System.Security.Cryptography.SHA512Managed
        'Menyatakane bytResult, Hash bytDataToHash dan menyimpannya ke bytResult.
        Dim bytResult As Byte() = SHA512.ComputeHash(bytDataToHash)
        'Menyatakan bytKey(31).  akan menjadi 256 bits.
        Dim bytKey(31) As Byte

        'Menggunakan For Next untuk meletakkan ukuran tertentu (256 bits) dari 
        'bytResult menjadi bytKey. 0 ke 31 akan menempatkan yang pertama 256 bits
        'dari 512 bits menjadi bytKey.
        For i As Integer = 0 To 31
            bytKey(i) = bytResult(i)
        Next

        Return bytKey 'mengembalikan nilai key.
    End Function

#End Region


#Region "3. Membuat IV "

    '*************************
    '** Membuat IV
    '*************************

    Private Function CreateIV(ByVal strPassword As String) As Byte()
        'Mengubah strPassword menjadi array dan menyimpannya di chrData.
        Dim chrData() As Char = strPassword.ToCharArray
        'Menggunakan intLength untuk mendapatkan ukuran strPassword.
        Dim intLength As Integer = chrData.GetUpperBound(0)
        'Menyatakan bytDataToHash dan membuatnya dalam ukuran yg sama sebagai chrData.
        Dim bytDataToHash(intLength) As Byte

        'Menggunakan For Next untuk mengubah dan menyimpan chrData menjadi bytDataToHash.
        For i As Integer = 0 To chrData.GetUpperBound(0)
            bytDataToHash(i) = CByte(Asc(chrData(i)))
        Next

        'Meyatakan tipe hash.
        Dim SHA512 As New System.Security.Cryptography.SHA512Managed
        'Menyatakane bytResult, Hash bytDataToHash dan menyimpannya ke bytResult.
        Dim bytResult As Byte() = SHA512.ComputeHash(bytDataToHash)
        'Menyatakan bytIV(15).  akan menjadi 128 bits.
        Dim bytIV(15) As Byte

        'Menggunakan For Next untuk meletakkan ukuran tertentu (128 bits) dari
        'bytResult menjadi bytIV. 0 To 30 untuk bytKey menggunakan yg pertama 256 bits.
        'dari hashed password. 32 To 47 akan menempatkan yang berikutnya 128 bits menjadi bytIV.
        For i As Integer = 32 To 47
            bytIV(i - 32) = bytResult(i)
        Next

        Return bytIV 'mengembalikan nilai IV
    End Function

#End Region


#Region "4. Encrypt / Decrypt File "

    '****************************
    '** Encrypt/Decrypt File
    '****************************

    Private Enum CryptoAction
        'menentukan enumeration untuk CryptoAction.
        ActionEncrypt = 1
        ActionDecrypt = 2
    End Enum

    Private Sub EncryptOrDecryptFile(ByVal strInputFile As String, ByVal strOutputFile As String, ByVal bytKey() As Byte, ByVal bytIV() As Byte, ByVal Direction As CryptoAction)
        Try 'Dalam hal terjadi kesalahan.

            'Setup file streams to untuk menangani input dan output.
            fsInput = New System.IO.FileStream(strInputFile, FileMode.Open, FileAccess.Read)
            fsOutput = New System.IO.FileStream(strOutputFile, FileMode.OpenOrCreate, FileAccess.Write)
            fsOutput.SetLength(0) 'meyakinkan fsOutput kosong

            'Menentukan variables untuk proses encrypt/decrypt.
            Dim bytBuffer(4096) As Byte 'memegang blok byte untuk diproses
            Dim lngBytesProcessed As Long = 0 'menjalankan hitungan byte yang diproses
            Dim lngFileLength As Long = fsInput.Length 'panjang file input
            Dim intBytesInCurrentBlock As Integer 'current bytes being processed
            Dim csCryptoStream As CryptoStream
            'menyatakan CryptoServiceProvider.
            Dim cspRijndael As New System.Security.Cryptography.RijndaelManaged
            'Setup Progress Bar
            pbStatus.Value = 0
            pbStatus.Maximum = 100

            'Menentukan apakah enkripsi atau dekripsi dan pengaturan CryptoStream.
            Select Case Direction
                Case CryptoAction.ActionEncrypt
                    csCryptoStream = New CryptoStream(fsOutput, cspRijndael.CreateEncryptor(bytKey, bytIV), CryptoStreamMode.Write)

                Case CryptoAction.ActionDecrypt
                    csCryptoStream = New CryptoStream(fsOutput, cspRijndael.CreateDecryptor(bytKey, bytIV), CryptoStreamMode.Write)
            End Select

            'Gunakan While untuk mengulang sampai semua file diproses.
            While lngBytesProcessed < lngFileLength
                'Baca file dengan inputt filestream.
                intBytesInCurrentBlock = fsInput.Read(bytBuffer, 0, 4096)
                'Tulis file keluaran dengan cryptostream.
                csCryptoStream.Write(bytBuffer, 0, intBytesInCurrentBlock)
                'Update lngBytesProcessed
                lngBytesProcessed = lngBytesProcessed + CLng(intBytesInCurrentBlock)
                'Update Progress Bar
                pbStatus.Value = CInt((lngBytesProcessed / lngFileLength) * 100)
            End While

            'Menutup FileStreams and CryptoStream.
            csCryptoStream.Close()
            fsInput.Close()
            fsOutput.Close()

            'Jika mengenkripsi maka hapus file asli yang tidak dienkripsi.
            If Direction = CryptoAction.ActionEncrypt Then
                Dim fileOriginal As New FileInfo(strFileToEncrypt)
                fileOriginal.Delete()
            End If

            'Jika mendekripsi maka hapus file yang dienkripsi.
            If Direction = CryptoAction.ActionDecrypt Then
                Dim fileEncrypted As New FileInfo(strFileToDecrypt)
                fileEncrypted.Delete()
            End If

            'Perbarui pengguna saat file selesai.
            Dim Wrap As String = Chr(13) + Chr(10)
            If Direction = CryptoAction.ActionEncrypt Then
                MsgBox("Encryption Complete" + Wrap + Wrap + _
                        "Total bytes processed = " + _
                        lngBytesProcessed.ToString, _
                        MsgBoxStyle.Information, "Done")

                'Update progress bar and textboxes.
                pbStatus.Value = 0
                txtFileToEncrypt.Text = "Click Browse to load file."
                txtPassEncrypt.Text = ""
                txtConPassEncrypt.Text = ""
                txtDestinationEncrypt.Text = ""
                btnChangeEncrypt.Enabled = False
                btnEncrypt.Enabled = False

            Else
                'Perbarui pengguna saat file selesai.
                MsgBox("Decryption Complete" + Wrap + Wrap + _
                       "Total bytes processed = " + _
                        lngBytesProcessed.ToString, _
                        MsgBoxStyle.Information, "Done")

                'Update the progress bar and textboxes.
                pbStatus.Value = 0
                txtFileToDecrypt.Text = "Click Browse to load file."
                txtPassDecrypt.Text = ""
                txtConPassDecrypt.Text = ""
                txtDestinationDecrypt.Text = ""
                btnChangeDecrypt.Enabled = False
                btnDecrypt.Enabled = False
            End If


            'Catch file tidak ditemukan kesalahan.
        Catch When Err.Number = 53 'jika file tidak ditemukan
            MsgBox("Please check to make sure the path and filename" + _
                    "are correct and if the file exists.", _
                     MsgBoxStyle.Exclamation, "Invalid Path or Filename")

            'Catch semua kesalahan lainnya. Dan hapus sebagian file.
        Catch
            fsInput.Close()
            fsOutput.Close()

            If Direction = CryptoAction.ActionDecrypt Then
                Dim fileDelete As New FileInfo(txtDestinationDecrypt.Text)
                fileDelete.Delete()
                pbStatus.Value = 0
                txtPassDecrypt.Text = ""
                txtConPassDecrypt.Text = ""

                MsgBox("Please check to make sure that you entered the correct" + _
                        "password.", MsgBoxStyle.Exclamation, "Invalid Password")
            Else
                Dim fileDelete As New FileInfo(txtDestinationEncrypt.Text)
                fileDelete.Delete()

                pbStatus.Value = 0
                txtPassEncrypt.Text = ""
                txtConPassEncrypt.Text = ""

                MsgBox("This file cannot be encrypted.", _
                        MsgBoxStyle.Exclamation, "Invalid File")

            End If

        End Try
    End Sub

#End Region


#Region "5. Browse / Change Button "

    '******************************
    '** Browse/Change Buttons
    '******************************

    Private Sub btnBrowseEncrypt_Click(ByVal sender As System.Object, _
                                       ByVal e As System.EventArgs) _
                                       Handles btnBrowseEncrypt.Click
        'Setup the open dialog.
        OpenFileDialog.FileName = ""
        OpenFileDialog.Title = "Choose a file to encrypt"
        OpenFileDialog.InitialDirectory = "C:\"
        OpenFileDialog.Filter = "All Files (*.*) | *.*"

        'Find out if the user chose a file.
        If OpenFileDialog.ShowDialog = DialogResult.OK Then
            strFileToEncrypt = OpenFileDialog.FileName
            txtFileToEncrypt.Text = strFileToEncrypt

            Dim iPosition As Integer = 0
            Dim i As Integer = 0

            'Get the position of the last "\" in the OpenFileDialog.FileName path.
            '-1 is when the character your searching for is not there.
            'IndexOf searches from left to right.
            While strFileToEncrypt.IndexOf("\"c, i) <> -1
                iPosition = strFileToEncrypt.IndexOf("\"c, i)
                i = iPosition + 1
            End While

            'Assign strOutputFile to the position after the last "\" in the path.
            'This position is the beginning of the file name.
            strOutputEncrypt = strFileToEncrypt.Substring(iPosition + 1)
            'Assign S the entire path, ending at the last "\".
            Dim S As String = strFileToEncrypt.Substring(0, iPosition + 1)
            'Replace the "." in the file extension with "_".
            strOutputEncrypt = strOutputEncrypt.Replace("."c, "_"c)
            'The final file name.  XXXXX.encrypt
            txtDestinationEncrypt.Text = S + strOutputEncrypt + ".encrypt"
            'Update buttons.
            btnEncrypt.Enabled = True
            btnChangeEncrypt.Enabled = True

        End If

    End Sub

    Private Sub btnBrowseDecrypt_Click(ByVal sender As System.Object, _
                                       ByVal e As System.EventArgs) _
                                       Handles btnBrowseDecrypt.Click
        'Setup the open dialog.
        OpenFileDialog.FileName = ""
        OpenFileDialog.Title = "Choose a file to decrypt"
        OpenFileDialog.InitialDirectory = "C:\"
        OpenFileDialog.Filter = "Encrypted Files (*.encrypt) | *.encrypt"

        'Find out if the user chose a file.
        If OpenFileDialog.ShowDialog = DialogResult.OK Then
            strFileToDecrypt = OpenFileDialog.FileName
            txtFileToDecrypt.Text = strFileToDecrypt
            Dim iPosition As Integer = 0
            Dim i As Integer = 0
            'Get the position of the last "\" in the OpenFileDialog.FileName path.
            '-1 is when the character your searching for is not there.
            'IndexOf searches from left to right.

            While strFileToDecrypt.IndexOf("\"c, i) <> -1
                iPosition = strFileToDecrypt.IndexOf("\"c, i)
                i = iPosition + 1
            End While

            'strOutputFile = the file path minus the last 8 characters (.encrypt)
            strOutputDecrypt = strFileToDecrypt.Substring(0, strFileToDecrypt.Length - 8)
            'Assign S the entire path, ending at the last "\".
            Dim S As String = strFileToDecrypt.Substring(0, iPosition + 1)
            'Assign strOutputFile to the position after the last "\" in the path.
            strOutputDecrypt = strOutputDecrypt.Substring((iPosition + 1))
            'Replace "_" with "."
            txtDestinationDecrypt.Text = S + strOutputDecrypt.Replace("_"c, "."c)
            'Update buttons
            btnDecrypt.Enabled = True
            btnChangeDecrypt.Enabled = True

        End If
    End Sub

    Private Sub btnChangeEncrypt_Click(ByVal sender As System.Object, _
                                       ByVal e As System.EventArgs) _
                                       Handles btnChangeEncrypt.Click
        'Setup up folder browser.
        FolderBrowserDialog.Description = "Select a folder to place the encrypted file in."
        'If the user selected a folder assign the path to txtDestinationEncrypt.
        If FolderBrowserDialog.ShowDialog = DialogResult.OK Then
            txtDestinationEncrypt.Text = FolderBrowserDialog.SelectedPath + _
                                         "\" + strOutputEncrypt + ".encrypt"
        End If
    End Sub

    Private Sub btnChangeDecrypt_Click(ByVal sender As System.Object, _
                                       ByVal e As System.EventArgs) _
                                       Handles btnChangeDecrypt.Click
        'Setup up folder browser.
        FolderBrowserDialog.Description = "Select a folder for to place the decrypted file in."
        'If the user selected a folder assign the path to txtDestinationDecrypt.
        If FolderBrowserDialog.ShowDialog = DialogResult.OK Then
            txtDestinationDecrypt.Text = FolderBrowserDialog.SelectedPath + _
                                         "\" + strOutputDecrypt.Replace("_"c, "."c)
        End If
    End Sub

#End Region


#Region "6. Tombol Encrypt / Decrypt "

    '******************************
    '** Tombol Encrypt/Decrypt
    '******************************

    Private Sub btnEncrypt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEncrypt.Click
        'Memastikan Password benar.
        If txtConPassEncrypt.Text = txtPassEncrypt.Text Then
            'Menyatakan variables untuk key dan iv.
            'Key perlu menampung 256 bit dan iv 128 bit.
            Dim bytKey As Byte()
            Dim bytIV As Byte()
            'mengirim password ke CreateKey function.
            bytKey = CreateKey(txtPassEncrypt.Text)
            'Mengirim password ke CreateIV function.
            bytIV = CreateIV(txtPassEncrypt.Text)
            'memulai encryption.
            EncryptOrDecryptFile(strFileToEncrypt, txtDestinationEncrypt.Text, bytKey, bytIV, CryptoAction.ActionEncrypt)
        Else
            MsgBox("Please re-enter your password.", MsgBoxStyle.Exclamation)
            txtPassEncrypt.Text = ""
            txtConPassEncrypt.Text = ""
        End If
    End Sub

    Private Sub btnDecrypt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDecrypt.Click
        'Memastikan Password benar.
        If txtConPassDecrypt.Text = txtPassDecrypt.Text Then
            'Menyatakan variables untuk key dan iv.
            'Key perlu menampung 256 bit dan iv 128 bit.
            Dim bytKey As Byte()
            Dim bytIV As Byte()
            'mengirim password ke CreateKey function.
            bytKey = CreateKey(txtPassDecrypt.Text)
            'Mengirim password ke CreateIV function.
            bytIV = CreateIV(txtPassDecrypt.Text)
            'memulai decryption.
            EncryptOrDecryptFile(strFileToDecrypt, txtDestinationDecrypt.Text, bytKey, bytIV, CryptoAction.ActionDecrypt)
        Else
            MsgBox("Please re-enter your password.", MsgBoxStyle.Exclamation)
            txtPassDecrypt.Text = ""
            txtConPassDecrypt.Text = ""
        End If
    End Sub

#End Region




End Class
