Imports MetroFramework
Public Class Form1
    'Reference LINQ2SQL class
    Public doAction As New FunctionsDataContext()
    Public grabStats As New Stats
    ''' <summary>
    ''' doAction.Method() calls come from LinqSQL => Functions.dbml file
    ''' These methods are Stored Procedures which can be found in the Appointments db => Stored Procedures
    ''' </summary>
    ''' 
#Region "Functions"
    Private Function getAllAppointments()
        'Query all appointments not marked Completed
        Dim getAppointments = From AT_Appointments In doAction.AT_Appointments
                              Where Not AT_Appointments.Status = "Completed"

        If getAppointments.Count >= 1 Then
            FlowDashboardPanel.Controls.Clear()
            'loop through all active appointments
            For Each Appointment In doAction.AT_Appointments
                'Create a new appointment card instance
                Dim NewCard As New AppointmentCard()
                NewCard.lblType.Text = Appointment.AppointmentType
                NewCard.lblDetails.Text = Appointment.AppointmentDetails
                NewCard.lblDate.Text = Appointment.AppointmentDate
                NewCard.lblTime.Text = Appointment.AppointmentTime
                NewCard.lblStatus.Text = Appointment.Status
                'Add the card(s) to the form
                FlowDashboardPanel.Controls.Add(NewCard)
            Next
        End If
        Return 0
    End Function

    Private Function getTodaysAppointments()
        'Loop through and display appointments for current day
        For Each Appointment In doAction.AT_Appointments
            If Appointment.AppointmentDate = Date.Today.ToLongDateString() _
                And Appointment.Status = "Upcoming" Then

                'Create a new instance of the Appointment card
                Dim NewCard As New AppointmentCard()

                NewCard.lblType.Text = Appointment.AppointmentType
                NewCard.lblDetails.Text = Appointment.AppointmentDetails
                NewCard.lblTime.Text = Appointment.AppointmentTime
                NewCard.lblDate.Text = Appointment.AppointmentDate
                NewCard.lblStatus.Text = Appointment.Status
                'Add the card(s) to the form
                FlowLayoutPanel1.Controls.Add(NewCard)
            End If
        Next
        Return 0
    End Function
#End Region

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            tabContainer.TabPages(2).Text = "Today's Appointments (" & checkAppointment.Count() & ")"
        End If

        getTodaysAppointments()

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'Save the appointment to the database by calling the LinqSQL => Functions =>CreateNewAppointment method
        Try
            doAction.CreateNewAppointment(cbDate.Text, cbHour.Text & ":" & cbMin.Text & " " & cbAmPm.Text, txtType.Text, txtDetails.Text, txtLocation.Text, "Upcoming")
            txtGetDetails.Text = "You have created a " & txtType.Text & " Appointment for " & vbNewLine _
                & cbDate.Text & " at " & cbHour.Text & ":" & cbMin.Text & " " & cbAmPm.Text & vbNewLine
            btnAllAppointments.PerformClick()
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
#End Region

    Private Sub btnRestart_Click(sender As Object, e As EventArgs) Handles btnRestart.Click
        'Restart the application once debugged before entring data
        'Application will exit debug mode so data will be saved until you exit application
        Application.Restart()
    End Sub

    Private Sub btnViewAppointments_Click(sender As Object, e As EventArgs)
        'View Appointments
        tabContainer.SelectTab(2)
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

    Private Sub btnAllAppointments_Click(sender As Object, e As EventArgs) Handles btnAllAppointments.Click
        getAllAppointments()
    End Sub
End Class
