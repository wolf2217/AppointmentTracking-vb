Public Class Stats
    Public getStats As New FunctionsDataContext
    Public _Active As Integer
    Public Property ActiveAppointments() As Integer
        Get
            Return _Active
        End Get
        Set(ByVal value As Integer)
            Dim getActive = From AT_Appointments In getStats.AT_Appointments
                            Where Not AT_Appointments.Status = "Completed"

            _Active = getActive.Count()

        End Set
    End Property
End Class
