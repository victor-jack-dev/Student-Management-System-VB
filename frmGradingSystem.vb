Imports System.IO
Public Class frmgradingsystem

    Private Sub btnCaclulate_Click(sender As Object, e As EventArgs) Handles btnCaclulate.Click
        Dim marks As Integer = Val(txtMarks.Text)
        Dim grade As String
        Dim remark As String
        If marks < 0 Or marks > 100 Then
            MessageBox.Show("Marks must be between 0 and 100.")
            Exit Sub
        End If
        If txtMarks.Text = "" Then
            MessageBox.Show("Please enter marks.")
            txtMarks.Focus()
            Exit Sub
        End If

        If Not IsNumeric(txtMarks.Text) Then
            MessageBox.Show("Marks must be numeric.")
            txtMarks.Focus()
            Exit Sub
        End If
        'Check if input is a valid number
        If Not Integer.TryParse(txtMarks.Text, marks) Then
            MessageBox.Show("Please enter valid numeric marks")
            Exit Sub
        End If

        'Check valid range
        If marks < 0 Or marks > 100 Then
            MessageBox.Show("Marks must be between 0 and 100")
            Exit Sub
        End If

        'Grade calculation
        If marks >= 80 Then
            grade = "A"
            remark = "Excellent"

        ElseIf marks >= 70 Then
            grade = "B"
            remark = "Very Good"

        ElseIf marks >= 60 Then
            grade = "C"
            remark = "Good"

        ElseIf marks >= 45 Then
            grade = "D"
            remark = "Pass"

        Else
            grade = "E"
            remark = "Fail"
        End If

        'Display results
        txtGrade.Text = grade
        txtRemark.Text = remark

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtSearch.Text = "" Then
            MessageBox.Show("Search for a student first.")
            Exit Sub
        End If

        Dim lines As New List(Of String)
        Dim found As Boolean = False

        For Each line As String In IO.File.ReadAllLines("students.txt")

            If line.ToLower().StartsWith(txtSearch.Text.ToLower() & ",") Then

                Dim updatedRecord As String =
                    txtName.Text & "," &
                    txtMarks.Text & "," &
                    txtGrade.Text & "," &
                    txtRemark.Text

                lines.Add(updatedRecord)

                found = True

            Else

                lines.Add(line)

            End If

        Next

        IO.File.WriteAllLines("students.txt", lines)

        If found Then
            MessageBox.Show("Student record updated successfully!")
        Else
            MessageBox.Show("Student not found.")
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim found As Boolean = False

        If Not IO.File.Exists("students.txt") Then
            MessageBox.Show("No records found.")
            Exit Sub
        End If

        Dim lines() As String = IO.File.ReadAllLines("students.txt")

        For Each line As String In lines

            If line.ToLower().StartsWith(txtSearch.Text.ToLower() & ",") Then

                Dim data() As String = line.Split(","c)

                txtName.Text = data(0)
                txtMarks.Text = data(1)
                txtGrade.Text = data(2)
                txtRemark.Text = data(3)

                MessageBox.Show("Record loaded successfully.")

                found = True
                Exit For

            End If

        Next

        If found = False Then
            MessageBox.Show("Student not found.")
        End If

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim studentData As String

        studentData = txtName.Text & "," & txtMarks.Text & "," & txtGrade.Text & "," & txtRemark.Text

        File.AppendAllText("students.txt", studentData & Environment.NewLine)

        MessageBox.Show("Student data saved successfully!")

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtName.Clear()
        txtMarks.Clear()
        txtGrade.Clear()
        txtRemark.Clear()
        txtSearch.Clear()

        txtName.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        frmDashboard.Show()

        Me.Close()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim result As DialogResult

        result = MessageBox.Show(
            "Are you sure you want to delete this student?",
            "Confirm Delete",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question)

        If result = DialogResult.No Then
        End If

        If Not IO.File.Exists("students.txt") Then
            MessageBox.Show("No records found.")
            Exit Sub
        End If

        Dim lines As New List(Of String)
        Dim found As Boolean = False

        For Each line As String In IO.File.ReadAllLines("students.txt")

            If line.ToLower().StartsWith(txtSearch.Text.ToLower() & ",") Then
                found = True
            Else
                lines.Add(line)
            End If

        Next

        If found Then

            IO.File.WriteAllLines("students.txt", lines)

            MessageBox.Show("Student record deleted successfully!")

        Else

            MessageBox.Show("Student not found.")

        End If

    End Sub

End Class