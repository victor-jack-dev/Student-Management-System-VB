
Imports System.Windows
    Imports System.IO
    Public Class frmDashboard
        Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

            MessageBox.Show("Welcome to the Student Management System")

        End Sub
        Private Sub btnGrading_Click(sender As Object, e As EventArgs) Handles btnEnterMarks.Click
        frmgradingsystem.Show()

        Me.Hide()
        End Sub

        Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
            frmLogin.Show()

            Me.Hide()
        End Sub

        Private Sub btnViewRecords_Click(sender As Object, e As EventArgs) Handles btnViewRecords.Click
            frmRecords.Show()

            Me.Close()
        End Sub

        Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
            MessageBox.Show(
            "Student Management System" & vbCrLf &
            "Version 1.0" & vbCrLf &
            "Developed by Victor Jackson")

        End Sub

        Private Sub btnExportToExcel_Click(sender As Object, e As EventArgs) Handles btnExportToExcel.Click
            If Not File.Exists("students.txt") Then

                MessageBox.Show("No student records found to export.")

                Exit Sub

            End If

            Dim saveFile As New SaveFileDialog

            saveFile.Filter = "CSV Files (*.csv)|*.csv"

            saveFile.Title = "Export Student Records"

            saveFile.FileName = "StudentRecords.csv"

            If saveFile.ShowDialog() = DialogResult.OK Then

                File.Copy("students.txt", saveFile.FileName, True)

                MessageBox.Show(
                "Records exported successfully!",
                "Export Complete",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information)

            End If

        End Sub
End Class