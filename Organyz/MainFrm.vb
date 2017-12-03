Imports System.IO

Public Class MainFrm

    Dim GLOBALERRORLOG As StreamWriter
    Dim fileExt(), catExt() As String

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

    End Sub

    Private Sub setFolderPathBut_Click(sender As Object, e As EventArgs) Handles setFolderPathBut.Click
        Dim dlgResult = openFolderDlg.ShowDialog()
        folderPathTBox.Text = openFolderDlg.SelectedPath
    End Sub

    Private Sub extractANDMoveFiles(ByVal path As String)
        Dim count As Short = 0

        For Each file As String In Directory.GetFiles(path, ".")
            Dim ext As String = retFileExtensions(file)
            Dim str = catExt(Array.IndexOf(catExt, ext))
            'Dim str = extToCategory(ext)

            Try
                Dim p = path + "\" + str + "\" + file.Substring(file.LastIndexOf("\") + 1)
                My.Computer.FileSystem.MoveFile(file, p)
            Catch ex As Exception

            End Try

        Next

    End Sub

    Private Sub extractFilesBut_Click(sender As Object, e As EventArgs) Handles extractFilesBut.Click
        loadFromTXT("C:\Users\admin\Documents\Visual Studio 2015\Projects\Organyz\Organyz\My Project\extensions.csv")
        extractANDMoveFiles(folderPathTBox.Text)
    End Sub

    Private Function retFileExtensions(ByVal filename As String) As String
        Dim ext As String = ""
        ext = filename.Substring(filename.LastIndexOf(".") + 1)
        Return ext
    End Function

    Private Sub MainFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        devLinkLBL.Links.Add(0, 9, "www.thecodepost.org")
    End Sub
    Private Sub devLinkLBL_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles devLinkLBL.LinkClicked
        System.Diagnostics.Process.Start(e.Link.LinkData.ToString)
    End Sub

#Region "Extract and parse inputs"
    Private Sub loadFromTXT(ByVal path As String)
        If File.Exists(path) Then
            Dim fileReader As New System.IO.StreamReader(path)
            'fileReader = My.Computer.FileSystem.OpenTextFileReader(path)
            extractFromCSV(fileReader.ReadToEnd)
        End If
    End Sub

    Private Function getLength(ByVal strBuffer As String) As Integer
        Dim i As Integer
        Dim lines() As String = strBuffer.Split(",")
        For Each line As String In lines
            i = i + 1
        Next
        Return i
    End Function
    Private Sub extractFromCSV(ByVal strBuffer As String)

        ReDim fileExt(getLength(strBuffer))
        ReDim catExt(getLength(strBuffer))

        Dim lines() As String = strBuffer.Split(",")

        Dim count As Int16 = 0
        Console.WriteLine("###############################################")

        For Each line As String In lines

            Dim fileANDext() As String = line.Split(".")

            Dim ext As String = line.Substring(0, line.IndexOf("."))
            fileExt(count) = fileANDext(0)

            Dim category As String = line.Substring(line.IndexOf("."))
            catExt(count) = fileANDext(1)

            Console.WriteLine("Extension:" + fileExt(count))
            Console.WriteLine("Category:" + catExt(count))

            count = count + 1

            Console.WriteLine()

        Next

    End Sub

    Private Sub loadExtBut_Click(sender As Object, e As EventArgs) Handles loadExtBut.Click
        loadFromTXT("C:\Users\admin\Documents\Visual Studio 2015\Projects\Organyz\Organyz\My Project\extensions.csv")

    End Sub

#End Region

#Region "Junk"
    Private Function extToCategory(ByVal ext As String)
        Dim catList As New List(Of String)
        Dim catType As String = ""
        Select Case ext
            Case "txt", "TXT"
                catType = "Text Files"
            Case "xlsx", "xls"
                catType = "Spreadsheets"
            Case "bmp", "png", "jpg", "gif", "jpeg"
                catType = "Images"
            Case "doc", "pdf", "docx"
                catType = "Documents"
            Case "msi"
                catType = "Installers"
            Case "zip", "rar", "tar", "gz"
                catType = "Archives"
            Case "iso", "img"
                catType = "Disk Images"
            Case "mp3"
                catType = "Music"
            Case "mp4", "mkv"
                catType = "Videos"
            Case Else
                catType = "Others"
        End Select

        Return catType
    End Function
#End Region

End Class
