Imports MetroFramework
Public Class Form1
    'Reference LINQ2SQL class
    Public doAction As New FunctionsDataContext()
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Height = 230
        'set the min date to today
        cbDate.MinDate = Date.Today
        'Add time from Functions => SetTime Module
        SetTime.setHour()
        SetTime.setMinute()
        SetTime.setAmPm()
    End Sub

    Private Sub cbDate_ValueChanged(sender As Object, e As EventArgs) Handles cbDate.ValueChanged
        'Display appointment details
        pnlDetails.Visible = True
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Me.Height = 398
        'Read the details of the appointment
        txtGetDetails.Text = "You have created a " & txtType.Text & " Appointment for " & vbNewLine _
            & cbDate.Text & " at " & cbHour.Text & ":" & cbMin.Text & " " & cbAmPm.Text & vbNewLine & vbNewLine _
            & "Click confirm below to confirm"
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        'Cancel the save and go back to edit

        'Adjust form height
        Me.Height = 230
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        'save this appointment to the db

        'Adjust form height
        Me.Height = 230
    End Sub

#Region "Context Menu Options"
    Private Sub BeautyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BeautyToolStripMenuItem.Click
        'Add Beauty to appointment type
        txtType.Text = "Beauty"
    End Sub

    Private Sub DoctorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DoctorToolStripMenuItem.Click
        'Add Doctor to appointment type
        txtType.Text = "Doctor's"
    End Sub

    Private Sub JobToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JobToolStripMenuItem.Click
        'Add Job to appointment type
        txtType.Text = "Job Inquiry"
    End Sub

    Private Sub MechanicToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MechanicToolStripMenuItem.Click
        'Add Mechanic to appointment type
        txtType.Text = "Mechanic Shop"
    End Sub
#End Region

End Class
