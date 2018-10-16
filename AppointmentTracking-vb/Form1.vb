Imports MetroFramework
Public Class Form1
    'Reference LINQ2SQL class
    Public doAction As New FunctionsDataContext()
    ''' <summary>
    ''' doAction.Method() calls come from LinqSQL => Functions.dbml file
    ''' These methods are Stored Procedures which can be found in the Appointments db => Stored Procedures
    ''' </summary>
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SplitContainer1.Panel1Collapsed = False
        SplitContainer1.Panel2Collapsed = True

        'set the min date to today
        cbDate.MinDate = Date.Today
        'Add time from Functions => SetTime Module
        SetTime.setHour()
        SetTime.setMinute()
        SetTime.setAmPm()

        'Check for current day appointments
        Dim checkAppointment = From AT_Appointments In doAction.AT_Appointments
                               Where AT_Appointments.AppointmentDate = Date.Today.ToLongDateString() And AT_Appointments.Status = "Upcoming"

        If checkAppointment.Count >= 1 Then
            btnViewAppointments.Visible = True
            pnlAlert.Visible = True
            lblAppointments.Text = "You have " & checkAppointment.Count() & " appointment(s) today"
        End If

        'Loop through and display appointments for current day
        For Each Appointment In doAction.AT_Appointments
            If Appointment.AppointmentDate = Date.Today.ToLongDateString() _
                And Appointment.Status = "Upcoming" Then

                'Create a new instance of the Appointment card
                Dim NewCard As New AppointmentCard()

                NewCard.lblType.Text = Appointment.AppointmentType
                NewCard.lblDetails.Text = Appointment.AppointmentDetails
                NewCard.lblTime.Text = Appointment.AppointmentTime
                NewCard.lblStatus.Text = Appointment.Status
                'Add the card(s) to the form
                FlowLayoutPanel1.Controls.Add(NewCard)
            End If
        Next
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'Save the appointment to the database by calling the LinqSQL => Functions =>CreateNewAppointment method
        Try
            doAction.CreateNewAppointment(cbDate.Text, cbHour.Text & ":" & cbMin.Text & " " & cbAmPm.Text, txtType.Text, txtDetails.Text, "Upcoming")
            txtGetDetails.Text = "You have created a " & txtType.Text & " Appointment for " & vbNewLine _
                & cbDate.Text & " at " & cbHour.Text & ":" & cbMin.Text & " " & cbAmPm.Text & vbNewLine
        Catch ex As Exception
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
        pnlAlert.Visible = False
    End Sub

    Private Sub btnAppointmentEntry_Click(sender As Object, e As EventArgs) Handles btnAppointmentEntry.Click
        SplitContainer1.Panel1Collapsed = False
        SplitContainer1.Panel2Collapsed = True
        pnlAlert.Visible = True
    End Sub

    Private Sub btnManage_Click(sender As Object, e As EventArgs) Handles btnManage.Click
        'Open Manage Appointments and view appointments for current day and allow to update status
        Me.Hide()
        ManageAppointments.Show()
        Me.Close()
        Dim getAppointments = From AT_Appointments In doAction.AT_Appointments
                              Where AT_Appointments.AppointmentDate = Date.Today.ToLongDateString() And AT_Appointments.Status = "Upcoming"


        If getAppointments.Count >= 1 Then
            For Each Appointment In getAppointments
                ManageAppointments.cbTime.Items.Add(Appointment.AppointmentTime)
            Next
        End If


    End Sub

    Private Sub txtDetails_TextChanged(sender As Object, e As EventArgs) Handles txtDetails.TextChanged
        'Enable the save button if the details contains content
        If txtDetails.Text.Count And txtType.Text.Count >= 1 Then
            btnAdd.Enabled = True
        Else
            btnAdd.Enabled = False
        End If
    End Sub
#End Region

End Class
