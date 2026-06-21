<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGradingSystem
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
        lblSearch = New Label()
        lblStudentName = New Label()
        lblMarks = New Label()
        lblGrade = New Label()
        lblRemarks = New Label()
        txtSearch = New TextBox()
        txtName = New TextBox()
        txtMarks = New TextBox()
        txtGrade = New TextBox()
        txtRemark = New TextBox()
        btnSearch = New Button()
        btnUpdate = New Button()
        btnCaclulate = New Button()
        btnClear = New Button()
        btnSave = New Button()
        btnDelete = New Button()
        btnExit = New Button()
        SuspendLayout()
        ' 
        ' lblSearch
        ' 
        lblSearch.AutoSize = True
        lblSearch.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSearch.Location = New Point(259, 26)
        lblSearch.Name = "lblSearch"
        lblSearch.Size = New Size(61, 21)
        lblSearch.TabIndex = 0
        lblSearch.Text = "Search"
        ' 
        ' lblStudentName
        ' 
        lblStudentName.AutoSize = True
        lblStudentName.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblStudentName.Location = New Point(163, 95)
        lblStudentName.Name = "lblStudentName"
        lblStudentName.Size = New Size(120, 21)
        lblStudentName.TabIndex = 1
        lblStudentName.Text = "Student Name"
        ' 
        ' lblMarks
        ' 
        lblMarks.AutoSize = True
        lblMarks.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblMarks.Location = New Point(164, 164)
        lblMarks.Name = "lblMarks"
        lblMarks.Size = New Size(56, 21)
        lblMarks.TabIndex = 2
        lblMarks.Text = "Marks"
        ' 
        ' lblGrade
        ' 
        lblGrade.AutoSize = True
        lblGrade.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblGrade.Location = New Point(165, 237)
        lblGrade.Name = "lblGrade"
        lblGrade.Size = New Size(55, 21)
        lblGrade.TabIndex = 3
        lblGrade.Text = "Grade"
        ' 
        ' lblRemarks
        ' 
        lblRemarks.AutoSize = True
        lblRemarks.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblRemarks.Location = New Point(163, 311)
        lblRemarks.Name = "lblRemarks"
        lblRemarks.Size = New Size(75, 21)
        lblRemarks.TabIndex = 4
        lblRemarks.Text = "Remarks"
        ' 
        ' txtSearch
        ' 
        txtSearch.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        txtSearch.Location = New Point(343, 25)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(200, 27)
        txtSearch.TabIndex = 5
        ' 
        ' txtName
        ' 
        txtName.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        txtName.Location = New Point(333, 97)
        txtName.Name = "txtName"
        txtName.Size = New Size(210, 27)
        txtName.TabIndex = 6
        ' 
        ' txtMarks
        ' 
        txtMarks.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        txtMarks.Location = New Point(324, 164)
        txtMarks.Name = "txtMarks"
        txtMarks.Size = New Size(219, 27)
        txtMarks.TabIndex = 7
        ' 
        ' txtGrade
        ' 
        txtGrade.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        txtGrade.Location = New Point(324, 237)
        txtGrade.Name = "txtGrade"
        txtGrade.ReadOnly = True
        txtGrade.Size = New Size(225, 27)
        txtGrade.TabIndex = 8
        ' 
        ' txtRemark
        ' 
        txtRemark.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        txtRemark.Location = New Point(318, 313)
        txtRemark.Name = "txtRemark"
        txtRemark.ReadOnly = True
        txtRemark.Size = New Size(231, 27)
        txtRemark.TabIndex = 9
        ' 
        ' btnSearch
        ' 
        btnSearch.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSearch.Location = New Point(689, 2)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(99, 32)
        btnSearch.TabIndex = 10
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnUpdate.Location = New Point(689, 49)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(99, 31)
        btnUpdate.TabIndex = 11
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnCaclulate
        ' 
        btnCaclulate.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCaclulate.Location = New Point(689, 97)
        btnCaclulate.Name = "btnCaclulate"
        btnCaclulate.Size = New Size(99, 27)
        btnCaclulate.TabIndex = 12
        btnCaclulate.Text = "caclulate"
        btnCaclulate.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClear.Location = New Point(689, 142)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(99, 26)
        btnClear.TabIndex = 13
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnSave
        ' 
        btnSave.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSave.Location = New Point(689, 189)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(99, 28)
        btnSave.TabIndex = 14
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDelete.Location = New Point(689, 235)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(99, 29)
        btnDelete.TabIndex = 15
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnExit.Location = New Point(689, 409)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(99, 29)
        btnExit.TabIndex = 16
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' frmgradingsystem
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(781, 450)
        Controls.Add(btnExit)
        Controls.Add(btnDelete)
        Controls.Add(btnSave)
        Controls.Add(btnClear)
        Controls.Add(btnCaclulate)
        Controls.Add(btnUpdate)
        Controls.Add(btnSearch)
        Controls.Add(txtRemark)
        Controls.Add(txtGrade)
        Controls.Add(txtMarks)
        Controls.Add(txtName)
        Controls.Add(txtSearch)
        Controls.Add(lblRemarks)
        Controls.Add(lblGrade)
        Controls.Add(lblMarks)
        Controls.Add(lblStudentName)
        Controls.Add(lblSearch)
        Name = "frmgradingsystem"
        Text = "frmGradingSystem"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblSearch As Label
    Friend WithEvents lblStudentName As Label
    Friend WithEvents lblMarks As Label
    Friend WithEvents lblGrade As Label
    Friend WithEvents lblRemarks As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtMarks As TextBox
    Friend WithEvents txtGrade As TextBox
    Friend WithEvents txtRemark As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnCaclulate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnExit As Button
End Class
