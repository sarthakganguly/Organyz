<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainFrm
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
        Me.folderPathTBox = New System.Windows.Forms.TextBox()
        Me.setFolderPathBut = New System.Windows.Forms.Button()
        Me.openFolderDlg = New System.Windows.Forms.FolderBrowserDialog()
        Me.extractFilesBut = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'folderPathTBox
        '
        Me.folderPathTBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.folderPathTBox.Location = New System.Drawing.Point(102, 83)
        Me.folderPathTBox.Name = "folderPathTBox"
        Me.folderPathTBox.Size = New System.Drawing.Size(319, 23)
        Me.folderPathTBox.TabIndex = 0
        Me.folderPathTBox.Text = "C:\Users\admin\Desktop\Test Folder"
        '
        'setFolderPathBut
        '
        Me.setFolderPathBut.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.setFolderPathBut.Location = New System.Drawing.Point(427, 82)
        Me.setFolderPathBut.Name = "setFolderPathBut"
        Me.setFolderPathBut.Size = New System.Drawing.Size(106, 25)
        Me.setFolderPathBut.TabIndex = 1
        Me.setFolderPathBut.Text = "Choose Directory"
        Me.setFolderPathBut.UseVisualStyleBackColor = True
        '
        'extractFilesBut
        '
        Me.extractFilesBut.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.extractFilesBut.Location = New System.Drawing.Point(271, 152)
        Me.extractFilesBut.Name = "extractFilesBut"
        Me.extractFilesBut.Size = New System.Drawing.Size(75, 23)
        Me.extractFilesBut.TabIndex = 2
        Me.extractFilesBut.Text = "Extract File names"
        Me.extractFilesBut.UseVisualStyleBackColor = True
        '
        'MainFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(616, 326)
        Me.Controls.Add(Me.extractFilesBut)
        Me.Controls.Add(Me.setFolderPathBut)
        Me.Controls.Add(Me.folderPathTBox)
        Me.Name = "MainFrm"
        Me.Text = "Organyz"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents folderPathTBox As TextBox
    Friend WithEvents setFolderPathBut As Button
    Friend WithEvents openFolderDlg As FolderBrowserDialog
    Friend WithEvents extractFilesBut As Button
End Class
