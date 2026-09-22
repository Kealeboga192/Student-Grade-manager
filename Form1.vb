Imports System.Diagnostics.Eventing.Reader
Imports System.Drawing.Text

Public Class Form1
    Private studentsList As New List(Of Students)
    Private Sub btnAddstudent_Click(sender As Object, e As EventArgs) Handles btnAddstudent.Click
        If txtName.Text = "" Then
            MessageBox.Show("Please enter a name.")
        End If

        Dim marks1 As Double, Marks2 As Double, Marks3 As Double
        If Not Double.TryParse(txtMaths.Text, marks1) OrElse
                Not Double.TryParse(txtProgramming.Text, Marks2) OrElse
                Not Double.TryParse(txtComputerHardware.Text, Marks3) Then
            MessageBox.Show("Please enter valid numeric values for marks.")

        End If
        If marks1 < 0 OrElse marks1 > 100 OrElse Marks2 < 0 OrElse Marks2 > 100 OrElse Marks3 < 0 OrElse Marks3 > 100 Then
            MessageBox.Show("Marks must be between 0 to 100")
        End If

        Dim newStudent As New Students(txtName.Text, marks1, Marks2, Marks3)
        studentsList.Add(newStudent)
        RefreshGrid()
        ClearInputs()
        UpdateSummary()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Try
            If dgvStudents.SelectedRows.Count > 0 Then
                Dim rowIndex As Integer = dgvStudents.SelectedRows(0).Index
                If rowIndex >= 0 AndAlso rowIndex < studentsList.Count Then
                    studentsList.RemoveAt(rowIndex)
                    RefreshGrid()
                    UpdateSummary()
                End If
            Else
                MessageBox.Show("Choose a student to delete.")
            End If
        Catch ex As Exception
            MessageBox.Show($"An unexpected error occurred: {ex.Message}")
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearInputs()
    End Sub

    Private Sub ClearInputs()
        txtName.Clear()
        txtComputerHardware.Clear()
        txtMaths.Clear()
        txtProgramming.Clear()
    End Sub

    Private Sub RefreshGrid()
        dgvStudents.Rows.Clear()
        For Each s As Students In studentsList
            dgvStudents.Rows.Add(s.name, s.Maths, s.programming, s.computerHardware, s.average, s.grade, s.status)
        Next
    End Sub
    Private Sub UpdateSummary()
        LblTotalStudents.Text = "Total Students: " & studentsList.Count

        If studentsList.Count > 0 Then
            Dim average As Double = Math.Round(studentsList.Average(Function(s) s.average), 2)
            lblClassAverage.Text = $"Class average: {average}%"
        Else
            lblClassAverage.Text = "Class average: N/A"
        End If
    End Sub
End Class
