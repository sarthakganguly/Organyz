Imports System.IO

Public Class MainFrm

    Private Function setInitFileExtensions() As List(Of String)
        Dim fileExtGlobal As New List(Of String)
#Region "         Video"
        fileExtGlobal.Add("mp4")
        fileExtGlobal.Add("mkv")
#End Region
#Region "         Audio"
        fileExtGlobal.Add("mp3")
#End Region
#Region "         Images"
        fileExtGlobal.Add("jpg")
        fileExtGlobal.Add("gif")
        fileExtGlobal.Add("png")
        fileExtGlobal.Add("bmp")
#End Region
#Region "         Text"
        fileExtGlobal.Add("txt")
#End Region
#Region "         Disk Images"
        fileExtGlobal.Add("img")
        fileExtGlobal.Add("iso")
#End Region
#Region "         Archives"
        fileExtGlobal.Add("zip")
        fileExtGlobal.Add("rar")
        fileExtGlobal.Add("tar")
        fileExtGlobal.Add("gz")
#End Region
#Region "         Documents"
        fileExtGlobal.Add("pdf")
        fileExtGlobal.Add("docx")
        fileExtGlobal.Add("doc")
#End Region
#Region "         Spreadsheets"
        fileExtGlobal.Add("xlsx")
        fileExtGlobal.Add("xls")
#End Region
#Region "         Presentations"
        fileExtGlobal.Add("pptx")
        fileExtGlobal.Add("ppt")
#End Region
#Region "         Others"

#End Region
        fileExtGlobal.Add("exe")
        fileExtGlobal.Add("msi")
        Return fileExtGlobal
    End Function

    Private Sub setFolderPathBut_Click(sender As Object, e As EventArgs) Handles setFolderPathBut.Click
        Dim dlgResult = openFolderDlg.ShowDialog()
        folderPathTBox.Text = openFolderDlg.SelectedPath
    End Sub

    ' Sub proc actually doing the heavy lifting (moving) files
    ' Call this from the Extract Files Button Click Event
    Private Sub extractANDMoveFiles(ByVal path As String)
        Dim count As Short = 0

        For Each file As String In Directory.GetFiles(path, ".")
            Dim ext = retFileExtensions(file)

            ' choose an extType collection instead of the raw ext type itself
            ' for example, jpg, png etc should be stored in a Pictures Folder
            ' p - created just to make things simple, a little extra space won't
            ' matter much in the end :) It will get deallocated after this sub
            If setInitFileExtensions.Contains(ext) Then
                Dim str = extToCategory(ext)
                Dim p = path + "\" + str + "\" + file.Substring(file.LastIndexOf("\") + 1)

                My.Computer.FileSystem.MoveFile(file, p)

            End If

        Next
    End Sub

    Private Function extToCategory(ByVal ext As String)
        Dim catList As New List(Of String)
        Dim catType As String = ""
        Select Case ext
            Case "txt"
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

    ' Extract Files Button Click Handler
    Private Sub extractFilesBut_Click(sender As Object, e As EventArgs) Handles extractFilesBut.Click
        extractANDMoveFiles(folderPathTBox.Text)
    End Sub

    ' Required to get the file extension of the file
    ' to be moved
    Private Function retFileExtensions(ByVal filename As String)
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
End Class
