Imports System.ComponentModel

Public Class AppointmentCard
    Public doAction As New FunctionsDataContext
    Private Sub AppointmentCard_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Set status color
        If lblStatus.Text = "Postponed" Then
            lblStatus.ForeColor = Color.Yellow
        ElseIf lblStatus.Text = "Cancelled" Then
            lblStatus.ForeColor = Color.Crimson
        End If

        'Set today/future colors
        If Not lblDate.Text = Date.Today.ToLongDateString() Then
            lblDate.ForeColor = Color.DimGray
            lblTime.Enabled = False
        End If
    End Sub

    Private Sub lblTime_Click(sender As Object, e As EventArgs) Handles lblTime.Click
        ManageAppointments.Show()
        ManageAppointments.cbTime.Items.Add(lblTime.Text)
        ManageAppointments.cbTime.SelectedIndex = 0
    End Sub
End Class
