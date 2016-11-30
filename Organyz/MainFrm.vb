Imports System.IO

Public Class MainFrm

    Private Function setInitFileExtensions()
        Dim fileExtGlobal As New List(Of String)
        fileExtGlobal.Add("txt")
        fileExtGlobal.Add("mp4")
        fileExtGlobal.Add("mp3")
        fileExtGlobal.Add("jpg")
        fileExtGlobal.Add("png")
        fileExtGlobal.Add("xlsx")
        fileExtGlobal.Add("pdf")
        Return fileExtGlobal
    End Function

    Private Sub setFolderPathBut_Click(sender As Object, e As EventArgs) Handles setFolderPathBut.Click
        Dim dlgResult = openFolderDlg.ShowDialog()
        folderPathTBox.Text = openFolderDlg.SelectedPath
    End Sub

    Private Sub extractFiles(ByVal path As String)

        ' get all file extensions to be extracted
        Dim fileExtensions = setInitFileExtensions()

        For Each fileType As String In fileExtensions
            extractANDMoveFiles(path, fileType)
        Next

    End Sub

    ' Sub proc actually doing the heavy lifting (moving) files
    ' Call this from the Extract Files Button Click Event
    Private Sub extractANDMoveFiles(ByVal path As String, ByVal extType As String)
        Dim count As Short = 0

        For Each file As String In Directory.GetFiles(path, ".")
            Dim ext = retFileExtensions(file)

            ' choose an extType collection instead of the raw ext type itself
            ' for example, jpg, png etc should be stored in a Pictures Folder
            ' p - created just to make things simple, a little extra space won't
            ' matter much in the end :) It will get deallocated after this sub
            If ext.Equals(extType) Then
                Dim p = path + "\" + extType + "\" + file.Substring(file.LastIndexOf("\") + 1)
                My.Computer.FileSystem.MoveFile(file, p)
            End If

        Next
    End Sub

    Private Function extToCategory(ByVal ext As String)
        Dim catList As New List(Of String)
        Dim catType As String = ""
        Select Case ext
            Case "txt" Or "md"
                catType = "Text Files"
            Case "png" Or "jpg" Or "bmp"
                catType = "Images"
            Case Else

        End Select
        Return catType
    End Function

    ' Extract Files Button Click Handler
    Private Sub extractFilesBut_Click(sender As Object, e As EventArgs) Handles extractFilesBut.Click
        extractFiles(folderPathTBox.Text)
    End Sub

    ' Required to get the file extension of the file
    ' to be moved
    Private Function retFileExtensions(ByVal filename As String)
        Dim ext As String = ""
        ext = filename.Substring(filename.LastIndexOf(".") + 1)
        Return ext
    End Function

End Class
