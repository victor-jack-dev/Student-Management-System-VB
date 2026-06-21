<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDashboard
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
        btnEnterMarks = New Button()
        btnViewRecords = New Button()
        btnExportToExcel = New Button()
        btnAbout = New Button()
        btnLogOut = New Button()
        lblTitle = New Label()
        SuspendLayout()
        ' 
        ' btnEnterMarks
        ' 
        btnEnterMarks.Location = New Point(19, 100)
        btnEnterMarks.Margin = New Padding(4)
        btnEnterMarks.Name = "btnEnterMarks"
        btnEnterMarks.Size = New Size(152, 31)
        btnEnterMarks.TabIndex = 1
        btnEnterMarks.Text = "Enter Marks"
        btnEnterMarks.UseVisualStyleBackColor = True
        ' 
        ' btnViewRecords
        ' 
        btnViewRecords.Location = New Point(13, 192)
        btnViewRecords.Margin = New Padding(4)
        btnViewRecords.Name = "btnViewRecords"
        btnViewRecords.Size = New Size(152, 31)
        btnViewRecords.TabIndex = 2
        btnViewRecords.Text = "View Records"
        btnViewRecords.UseVisualStyleBackColor = True
        ' 
        ' btnExportToExcel
        ' 
        btnExportToExcel.Location = New Point(19, 274)
        btnExportToExcel.Margin = New Padding(4)
        btnExportToExcel.Name = "btnExportToExcel"
        btnExportToExcel.Size = New Size(146, 31)
        btnExportToExcel.TabIndex = 3
        btnExportToExcel.Text = "Export To Excel"
        btnExportToExcel.UseVisualStyleBackColor = True
        ' 
        ' btnAbout
        ' 
        btnAbout.Location = New Point(32, 400)
        btnAbout.Margin = New Padding(4)
        btnAbout.Name = "btnAbout"
        btnAbout.Size = New Size(96, 31)
        btnAbout.TabIndex = 4
        btnAbout.Text = "About"
        btnAbout.UseVisualStyleBackColor = True
        ' 
        ' btnLogOut
        ' 
        btnLogOut.BackColor = Color.IndianRed
        btnLogOut.Location = New Point(783, 470)
        btnLogOut.Margin = New Padding(4)
        btnLogOut.Name = "btnLogOut"
        btnLogOut.Size = New Size(96, 31)
        btnLogOut.TabIndex = 5
        btnLogOut.Text = "Log Out"
        btnLogOut.UseVisualStyleBackColor = False
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(19, 31)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(234, 30)
        lblTitle.TabIndex = 6
        lblTitle.Text = "SCHOOL DASHBOARD"
        ' 
        ' frmDashboard
        ' 
        AutoScaleDimensions = New SizeF(9F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1029, 600)
        Controls.Add(lblTitle)
        Controls.Add(btnLogOut)
        Controls.Add(btnAbout)
        Controls.Add(btnExportToExcel)
        Controls.Add(btnViewRecords)
        Controls.Add(btnEnterMarks)
        Font = New Font("Segoe UI", 11.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(4)
        Name = "frmDashboard"
        Text = "frmDashboard"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnEnterMarks As Button
    Friend WithEvents btnViewRecords As Button
    Friend WithEvents btnExportToExcel As Button
    Friend WithEvents btnAbout As Button
    Friend WithEvents btnLogOut As Button
    Friend WithEvents lblTitle As Label
End Class
