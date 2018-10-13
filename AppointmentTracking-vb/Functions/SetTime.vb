Module SetTime

    Public Function setHour()
        For h = 1 To 12
            Form1.cbHour.Items.Add(h)
        Next
        Return 0
    End Function

    Public Function setMinute()
        For m = 0 To 59 Step 5
            Form1.cbMin.Items.Add(m)
        Next
        Return 0
    End Function

    Public Function setAmPm()
        Form1.cbAmPm.Items.Add("AM")
        Form1.cbAmPm.Items.Add("PM")
        Return 0
    End Function

End Module
