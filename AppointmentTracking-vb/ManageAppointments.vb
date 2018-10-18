Imports System.ComponentModel

Public Class ManageAppointments
    Public doAction As New FunctionsDataContext()
    Private Sub cbTime_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTime.SelectedIndexChanged
        'Search todays appointments from time of appointment
        Dim AppointmentDetails = From AT_Appointments In doAction.AT_Appointments
                                 Where AT_Appointments.AppointmentTime = cbTime.Text

        If AppointmentDetails.Count = 1 Then
            For Each appointment In AppointmentDetails
                txtID.Text = appointment.Id
                txtAppointmentDetails.Text = appointment.AppointmentDetails
                txtAppointmentType.Text = appointment.AppointmentType
                txtDate.Text = appointment.AppointmentDate
                txtStatus.Text = appointment.Status
                txtTime.Text = appointment.AppointmentTime
            Next
        End If

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        'Update the status
        Try
            doAction.UpdateAppointmentStatus(txtID.Text, txtDate.Text, txtTime.Text, txtStatus.Text)
            pnlStatus.Visible = True
            lblStatus.Text = "Appointment was updated successfully"
            pnlTimer.Start()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ManageAppointments_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Form1.Show()
    End Sub

    Private Sub pnlTimer_Tick(sender As Object, e As EventArgs) Handles pnlTimer.Tick
        pnlStatus.Visible = False
        Me.Hide()
        Form1.Show()
        Me.Close()
        pnlTimer.Stop()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        'Delete the appointment from the db
        Try
            doAction.RemoveAppointment(txtID.Text)
            pnlStatus.Visible = True
            lblStatus.Text = "Appointment was removed successfully"
            pnlTimer.Start()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSetStatus.SelectedIndexChanged
        If cbSetStatus.Text = "Postponed" Then
            Overlay.Show()
            NewDate.Show()
        End If
    End Sub
End Class