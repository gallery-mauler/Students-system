' MainForm.vb
Public Class MainForm
    ' Code for the main form goes here

    Private Sub ManageStudentsButton_Click(sender As Object, e As EventArgs) Handles ManageStudentsButton.Click
        Dim studentForm As New StudentForm()
        studentForm.ShowDialog()
    End Sub

    Private Sub ManageCoursesButton_Click(sender As Object, e As EventArgs) Handles ManageCoursesButton.Click
        Dim courseForm As New CourseForm()
        courseForm.ShowDialog()
    End Sub

    Private Sub ManageGradesButton_Click(sender As Object, e As EventArgs) Handles ManageGradesButton.Click
        Dim gradeForm As New GradeForm()
        gradeForm.ShowDialog()
    End Sub
End Class
