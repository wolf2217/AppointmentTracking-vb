Public Class ManageAppointments
    Public doAction As New FunctionsDataContext()
    Private Sub cbTime_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTime.SelectedIndexChanged
        'Search todays appointments from time of appointment
        Dim AppointmentDetails = From AT_Appointments In doAction.AT_Appointments
                                 Where AT_Appointments.AppointmentTime = cbTime.Text

        If AppointmentDetails.Count = 1 Then
            For Each appointment In AppointmentDetails
                txtAppointmentDetails.Text = appointment.AppointmentDetails
                txtAppointmentType.Text = appointment.AppointmentType
                txtDate.Text = appointment.AppointmentDate
                txtStatus.Text = appointment.Status
                txtTime.Text = appointment.AppointmentTime
            Next
        End If

    End Sub
End Class