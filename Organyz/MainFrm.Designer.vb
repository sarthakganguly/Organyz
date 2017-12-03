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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.devLinkLBL = New System.Windows.Forms.LinkLabel()
        Me.loadExtBut = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'folderPathTBox
        '
        Me.folderPathTBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.folderPathTBox.Location = New System.Drawing.Point(12, 38)
        Me.folderPathTBox.Name = "folderPathTBox"
        Me.folderPathTBox.Size = New System.Drawing.Size(308, 23)
        Me.folderPathTBox.TabIndex = 0
        Me.folderPathTBox.Text = "C:\Users\admin\Desktop"
        '
        'setFolderPathBut
        '
        Me.setFolderPathBut.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.setFolderPathBut.Location = New System.Drawing.Point(326, 37)
        Me.setFolderPathBut.Name = "setFolderPathBut"
        Me.setFolderPathBut.Size = New System.Drawing.Size(121, 25)
        Me.setFolderPathBut.TabIndex = 1
        Me.setFolderPathBut.Text = "Choose Directory"
        Me.setFolderPathBut.UseVisualStyleBackColor = True
        '
        'extractFilesBut
        '
        Me.extractFilesBut.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.extractFilesBut.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.extractFilesBut.Location = New System.Drawing.Point(150, 81)
        Me.extractFilesBut.Name = "extractFilesBut"
        Me.extractFilesBut.Size = New System.Drawing.Size(170, 57)
        Me.extractFilesBut.TabIndex = 2
        Me.extractFilesBut.Text = "Organize"
        Me.extractFilesBut.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(264, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Enter the directory that you want organized."
        '
        'devLinkLBL
        '
        Me.devLinkLBL.AutoSize = True
        Me.devLinkLBL.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.devLinkLBL.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.devLinkLBL.Location = New System.Drawing.Point(388, 125)
        Me.devLinkLBL.Name = "devLinkLBL"
        Me.devLinkLBL.Size = New System.Drawing.Size(59, 13)
        Me.devLinkLBL.TabIndex = 4
        Me.devLinkLBL.TabStop = True
        Me.devLinkLBL.Text = "Developer"
        '
        'loadExtBut
        '
        Me.loadExtBut.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loadExtBut.Location = New System.Drawing.Point(326, 68)
        Me.loadExtBut.Name = "loadExtBut"
        Me.loadExtBut.Size = New System.Drawing.Size(121, 27)
        Me.loadExtBut.TabIndex = 5
        Me.loadExtBut.Text = "Load Extensions"
        Me.loadExtBut.UseVisualStyleBackColor = True
        '
        'MainFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(459, 162)
        Me.Controls.Add(Me.loadExtBut)
        Me.Controls.Add(Me.devLinkLBL)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.extractFilesBut)
        Me.Controls.Add(Me.setFolderPathBut)
        Me.Controls.Add(Me.folderPathTBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "MainFrm"
        Me.Text = "Organyz"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents folderPathTBox As TextBox
    Friend WithEvents setFolderPathBut As Button
    Friend WithEvents openFolderDlg As FolderBrowserDialog
    Friend WithEvents extractFilesBut As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents devLinkLBL As LinkLabel
    Friend WithEvents loadExtBut As Button
End Class
