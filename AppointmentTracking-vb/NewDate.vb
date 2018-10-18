Imports System.ComponentModel

Public Class NewDate
    Private Sub NewDate_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Load hours and minutes into comboboxes
        For h = 1 To 12
            cbHour.Items.Add(h)
        Next
        For m = 0 To 59 Step 5
            cbMin.Items.Add(m)
        Next
    End Sub

    Private Sub btnOkay_Click(sender As Object, e As EventArgs) Handles btnOkay.Click
        'Submit the data to the manage appointments form
        ManageAppointments.txtDate.Text = cbDate.Text
        ManageAppointments.txtDate.Style = MetroFramework.MetroColorStyle.Lime
        ManageAppointments.txtStatus.Text = "Upcoming"
        ManageAppointments.txtTime.Text = cbHour.Text & ":" & cbMin.Text & " " & cbAmPm.Text
        Me.Close()
    End Sub

    Private Sub NewDate_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Overlay.Close()
    End Sub
End Class