Public Class Students
    Public Property name As String
    Public Property Maths As Double
    Public Property programming As Double
    Public Property computerHardware As Double
    Public Property average As Double
    Public Property grade As String
    Public Property status As String

    Public Sub New(studentname As String, Maths As Double, programming As Double, computerHardware As Double)
        Me.name = studentname
        Me.Maths = Maths
        Me.programming = programming
        Me.computerHardware = computerHardware

        CalculateGrade()
    End Sub
    Private Sub CalculateGrade()
        average = (Maths + programming + computerHardware / 3)
        If average >= 80 Then
            grade = "A"
        ElseIf average >= 70 Then
            grade = "B"
        ElseIf average >= 60 Then
            grade = "C"
        ElseIf average >= 50 Then
            grade = "D"
        Else grade = "F"
        End If
        If average >= 50 Then
            status = "Pass"
        Else
            status = "Fail"
        End If
    End Sub

End Class
