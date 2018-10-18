Imports System.ComponentModel

Public Class AppointmentCard
    Private Sub AppointmentCard_Load(sender As Object, e As EventArgs) Handles Me.Load
        If lblStatus.Text = "Postponed" Then
            lblStatus.ForeColor = Color.Yellow
        ElseIf lblStatus.Text = "Cancelled" Then
            lblStatus.ForeColor = Color.Crimson
        End If
    End Sub

    Private Sub lblTime_Click(sender As Object, e As EventArgs) Handles lblTime.Click
        ManageAppointments.Show()
        ManageAppointments.cbTime.Items.Add(lblTime.Text)
        ManageAppointments.cbTime.SelectedIndex = 0
    End Sub
End Class
