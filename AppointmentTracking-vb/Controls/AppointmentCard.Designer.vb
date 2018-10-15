<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AppointmentCard
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblType = New System.Windows.Forms.Label()
        Me.lblDetails = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.lblType.Location = New System.Drawing.Point(73, 0)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(123, 18)
        Me.lblType.TabIndex = 0
        Me.lblType.Text = "Appointment Type"
        '
        'lblDetails
        '
        Me.lblDetails.AutoEllipsis = True
        Me.lblDetails.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.lblDetails.ForeColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.lblDetails.Location = New System.Drawing.Point(3, 11)
        Me.lblDetails.Name = "lblDetails"
        Me.lblDetails.Size = New System.Drawing.Size(290, 54)
        Me.lblDetails.TabIndex = 1
        Me.lblDetails.Text = "Appointment Details"
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.lblDetails)
        Me.Panel1.Location = New System.Drawing.Point(3, 29)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(296, 68)
        Me.Panel1.TabIndex = 2
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblTime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.lblTime.Location = New System.Drawing.Point(3, 0)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(64, 18)
        Me.lblTime.TabIndex = 3
        Me.lblTime.Text = "12:30 PM"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(4, 32)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(295, 4)
        Me.Panel2.TabIndex = 2
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.DarkSeaGreen
        Me.lblStatus.Location = New System.Drawing.Point(5, 101)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(64, 13)
        Me.lblStatus.TabIndex = 4
        Me.lblStatus.Text = "Upcoming..."
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.lblTime)
        Me.FlowLayoutPanel1.Controls.Add(Me.lblType)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(6, 6)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(290, 19)
        Me.FlowLayoutPanel1.TabIndex = 5
        '
        'AppointmentCard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "AppointmentCard"
        Me.Size = New System.Drawing.Size(302, 121)
        Me.Panel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblType As Label
    Friend WithEvents lblDetails As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTime As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblStatus As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
End Class
