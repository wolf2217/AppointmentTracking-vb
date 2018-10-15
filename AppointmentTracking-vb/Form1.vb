Imports MetroFramework
Public Class Form1
    'Reference LINQ2SQL class
    Public doAction As New FunctionsDataContext()
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SplitContainer1.Panel1Collapsed = False
        SplitContainer1.Panel2Collapsed = True
        'Me.Height = 249
        'set the min date to today
        cbDate.MinDate = Date.Today
        'Add time from Functions => SetTime Module
        SetTime.setHour()
        SetTime.setMinute()
        SetTime.setAmPm()

        'Check for current day appointments
        Dim checkAppointment = From AT_Appointments In doAction.AT_Appointments
                               Where AT_Appointments.AppointmentDate = Date.Today.ToLongDateString()

        If checkAppointment.Count >= 1 Then
            btnViewAppointments.Visible = True
            lblAppointments.Text = "You have " & checkAppointment.Count() & " appointment(s) today"
        End If


        'Loop through all appointments for current day
        For Each Appointment In doAction.AT_Appointments
            If Appointment.AppointmentDate = Date.Today.ToLongDateString() Then
                'Create a new instance of the Appointment card
                Dim NewCard As New AppointmentCard()
                'NewCard.lblTime.ForeColor = Color.Lime
                'NewCard.lblType.ForeColor = Color.Lime
                'NewCard.lblDetails.ForeColor = Color.Yellow
                NewCard.lblType.Text = Appointment.AppointmentType
                NewCard.lblDetails.Text = Appointment.AppointmentDetails
                NewCard.lblTime.Text = Appointment.AppointmentTime
                'Add the card(s) to the form
                FlowLayoutPanel1.Controls.Add(NewCard)
            End If
        Next
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'Me.Height = 400
        'Read the details of the appointment
        txtGetDetails.Text = "You have created a " & txtType.Text & " Appointment for " & vbNewLine _
            & cbDate.Text & " at " & cbHour.Text & ":" & cbMin.Text & " " & cbAmPm.Text & vbNewLine & vbNewLine _
            & "Click confirm below to confirm"
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        'Cancel the save and go back to edit
        'Adjust form height
        Me.Height = 249
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click

        Try
            'save this appointment to the db
            doAction.CreateNewAppointment(cbDate.Text, cbHour.Text & ":" & cbMin.Text & " " & cbAmPm.Text, txtType.Text, txtDetails.Text, "Upcoming")
            txtGetDetails.Text.Replace("Click confirm below to confirm", "")
            txtGetDetails.Text = txtGetDetails.Text & vbNewLine & vbNewLine & "YOUR APPOINTMENT HAS BEEN SAVED!"
        Catch ex As Exception
            'Display error if error occured while saving
            txtGetDetails.Text = txtGetDetails.Text & vbNewLine & vbNewLine & "Could not save appointment because " & ex.Message
        End Try
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

    Private Sub btnRestart_Click(sender As Object, e As EventArgs) Handles btnRestart.Click
        'Restart the application once debugged before entring data
        'Application will exit debug mode so data will be saved until you exit application
        Application.Restart()
    End Sub

    Private Sub btnViewAppointments_Click(sender As Object, e As EventArgs) Handles btnViewAppointments.Click
        'View Appointments
        SplitContainer1.Panel1Collapsed = True
        SplitContainer1.Panel2Collapsed = False
    End Sub

    Private Sub btnAppointmentEntry_Click(sender As Object, e As EventArgs) Handles btnAppointmentEntry.Click
        SplitContainer1.Panel1Collapsed = False
        SplitContainer1.Panel2Collapsed = True
    End Sub

    Private Sub btnManage_Click(sender As Object, e As EventArgs) Handles btnManage.Click
        'Open Manage Appointments and view appointments for current day and allow to update status
        ManageAppointments.Show()
        Dim getAppointments = From AT_Appointments In doAction.AT_Appointments
                              Where AT_Appointments.AppointmentDate = Date.Today.ToLongDateString()


        If getAppointments.Count >= 1 Then
            For Each Appointment In getAppointments
                ManageAppointments.cbTime.Items.Add(Appointment.AppointmentTime)
            Next
        End If


    End Sub
#End Region

End Class
