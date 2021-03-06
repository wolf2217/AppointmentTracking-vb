﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ManageAppointments
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.txtAppointmentType = New MetroFramework.Controls.MetroTextBox()
        Me.txtAppointmentDetails = New MetroFramework.Controls.MetroTextBox()
        Me.txtDate = New MetroFramework.Controls.MetroTextBox()
        Me.txtTime = New MetroFramework.Controls.MetroTextBox()
        Me.cbTime = New MetroFramework.Controls.MetroComboBox()
        Me.btnUpdate = New MetroFramework.Controls.MetroButton()
        Me.txtID = New MetroFramework.Controls.MetroTextBox()
        Me.pnlStatus = New System.Windows.Forms.Panel()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.pnlTimer = New System.Windows.Forms.Timer(Me.components)
        Me.btnDelete = New MetroFramework.Controls.MetroButton()
        Me.cbSetStatus = New MetroFramework.Controls.MetroComboBox()
        Me.txtStatus = New MetroFramework.Controls.MetroTextBox()
        Me.txtLocation = New MetroFramework.Controls.MetroTextBox()
        Me.pnlStatus.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtAppointmentType
        '
        '
        '
        '
        Me.txtAppointmentType.CustomButton.Image = Nothing
        Me.txtAppointmentType.CustomButton.Location = New System.Drawing.Point(421, 1)
        Me.txtAppointmentType.CustomButton.Name = ""
        Me.txtAppointmentType.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtAppointmentType.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtAppointmentType.CustomButton.TabIndex = 1
        Me.txtAppointmentType.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtAppointmentType.CustomButton.UseSelectable = True
        Me.txtAppointmentType.CustomButton.Visible = False
        Me.txtAppointmentType.Lines = New String(-1) {}
        Me.txtAppointmentType.Location = New System.Drawing.Point(71, 118)
        Me.txtAppointmentType.MaxLength = 32767
        Me.txtAppointmentType.Name = "txtAppointmentType"
        Me.txtAppointmentType.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAppointmentType.PromptText = "Appointment Type"
        Me.txtAppointmentType.ReadOnly = True
        Me.txtAppointmentType.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtAppointmentType.SelectedText = ""
        Me.txtAppointmentType.SelectionLength = 0
        Me.txtAppointmentType.SelectionStart = 0
        Me.txtAppointmentType.ShortcutsEnabled = True
        Me.txtAppointmentType.Size = New System.Drawing.Size(443, 23)
        Me.txtAppointmentType.Style = MetroFramework.MetroColorStyle.Red
        Me.txtAppointmentType.TabIndex = 0
        Me.txtAppointmentType.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.txtAppointmentType.UseSelectable = True
        Me.txtAppointmentType.WaterMark = "Appointment Type"
        Me.txtAppointmentType.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtAppointmentType.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtAppointmentDetails
        '
        '
        '
        '
        Me.txtAppointmentDetails.CustomButton.Image = Nothing
        Me.txtAppointmentDetails.CustomButton.Location = New System.Drawing.Point(403, 1)
        Me.txtAppointmentDetails.CustomButton.Name = ""
        Me.txtAppointmentDetails.CustomButton.Size = New System.Drawing.Size(87, 87)
        Me.txtAppointmentDetails.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtAppointmentDetails.CustomButton.TabIndex = 1
        Me.txtAppointmentDetails.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtAppointmentDetails.CustomButton.UseSelectable = True
        Me.txtAppointmentDetails.CustomButton.Visible = False
        Me.txtAppointmentDetails.Lines = New String(-1) {}
        Me.txtAppointmentDetails.Location = New System.Drawing.Point(23, 159)
        Me.txtAppointmentDetails.MaxLength = 32767
        Me.txtAppointmentDetails.Multiline = True
        Me.txtAppointmentDetails.Name = "txtAppointmentDetails"
        Me.txtAppointmentDetails.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAppointmentDetails.PromptText = "Details of your appointment"
        Me.txtAppointmentDetails.ReadOnly = True
        Me.txtAppointmentDetails.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtAppointmentDetails.SelectedText = ""
        Me.txtAppointmentDetails.SelectionLength = 0
        Me.txtAppointmentDetails.SelectionStart = 0
        Me.txtAppointmentDetails.ShortcutsEnabled = True
        Me.txtAppointmentDetails.Size = New System.Drawing.Size(491, 89)
        Me.txtAppointmentDetails.Style = MetroFramework.MetroColorStyle.Red
        Me.txtAppointmentDetails.TabIndex = 1
        Me.txtAppointmentDetails.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.txtAppointmentDetails.UseSelectable = True
        Me.txtAppointmentDetails.WaterMark = "Details of your appointment"
        Me.txtAppointmentDetails.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtAppointmentDetails.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtDate
        '
        '
        '
        '
        Me.txtDate.CustomButton.Image = Nothing
        Me.txtDate.CustomButton.Location = New System.Drawing.Point(159, 1)
        Me.txtDate.CustomButton.Name = ""
        Me.txtDate.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtDate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtDate.CustomButton.TabIndex = 1
        Me.txtDate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtDate.CustomButton.UseSelectable = True
        Me.txtDate.CustomButton.Visible = False
        Me.txtDate.Lines = New String(-1) {}
        Me.txtDate.Location = New System.Drawing.Point(25, 284)
        Me.txtDate.MaxLength = 32767
        Me.txtDate.Name = "txtDate"
        Me.txtDate.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDate.PromptText = "Date of your appointment"
        Me.txtDate.ReadOnly = True
        Me.txtDate.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtDate.SelectedText = ""
        Me.txtDate.SelectionLength = 0
        Me.txtDate.SelectionStart = 0
        Me.txtDate.ShortcutsEnabled = True
        Me.txtDate.Size = New System.Drawing.Size(181, 23)
        Me.txtDate.Style = MetroFramework.MetroColorStyle.Red
        Me.txtDate.TabIndex = 2
        Me.txtDate.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.txtDate.UseSelectable = True
        Me.txtDate.WaterMark = "Date of your appointment"
        Me.txtDate.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtDate.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtTime
        '
        '
        '
        '
        Me.txtTime.CustomButton.Image = Nothing
        Me.txtTime.CustomButton.Location = New System.Drawing.Point(98, 1)
        Me.txtTime.CustomButton.Name = ""
        Me.txtTime.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtTime.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtTime.CustomButton.TabIndex = 1
        Me.txtTime.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtTime.CustomButton.UseSelectable = True
        Me.txtTime.CustomButton.Visible = False
        Me.txtTime.Lines = New String(-1) {}
        Me.txtTime.Location = New System.Drawing.Point(212, 284)
        Me.txtTime.MaxLength = 32767
        Me.txtTime.Name = "txtTime"
        Me.txtTime.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTime.PromptText = "Time of appointment"
        Me.txtTime.ReadOnly = True
        Me.txtTime.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtTime.SelectedText = ""
        Me.txtTime.SelectionLength = 0
        Me.txtTime.SelectionStart = 0
        Me.txtTime.ShortcutsEnabled = True
        Me.txtTime.Size = New System.Drawing.Size(120, 23)
        Me.txtTime.Style = MetroFramework.MetroColorStyle.Red
        Me.txtTime.TabIndex = 3
        Me.txtTime.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.txtTime.UseSelectable = True
        Me.txtTime.WaterMark = "Time of appointment"
        Me.txtTime.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtTime.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'cbTime
        '
        Me.cbTime.FormattingEnabled = True
        Me.cbTime.ItemHeight = 23
        Me.cbTime.Location = New System.Drawing.Point(271, 24)
        Me.cbTime.Name = "cbTime"
        Me.cbTime.PromptText = "Search By Time"
        Me.cbTime.Size = New System.Drawing.Size(159, 29)
        Me.cbTime.Style = MetroFramework.MetroColorStyle.Red
        Me.cbTime.TabIndex = 5
        Me.cbTime.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.cbTime.UseSelectable = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(357, 323)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.Style = MetroFramework.MetroColorStyle.Red
        Me.btnUpdate.TabIndex = 6
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btnUpdate.UseSelectable = True
        '
        'txtID
        '
        '
        '
        '
        Me.txtID.CustomButton.Image = Nothing
        Me.txtID.CustomButton.Location = New System.Drawing.Point(20, 1)
        Me.txtID.CustomButton.Name = ""
        Me.txtID.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtID.CustomButton.TabIndex = 1
        Me.txtID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtID.CustomButton.UseSelectable = True
        Me.txtID.CustomButton.Visible = False
        Me.txtID.Lines = New String(-1) {}
        Me.txtID.Location = New System.Drawing.Point(23, 118)
        Me.txtID.MaxLength = 32767
        Me.txtID.Name = "txtID"
        Me.txtID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtID.PromptText = "ID"
        Me.txtID.ReadOnly = True
        Me.txtID.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtID.SelectedText = ""
        Me.txtID.SelectionLength = 0
        Me.txtID.SelectionStart = 0
        Me.txtID.ShortcutsEnabled = True
        Me.txtID.Size = New System.Drawing.Size(42, 23)
        Me.txtID.Style = MetroFramework.MetroColorStyle.Red
        Me.txtID.TabIndex = 7
        Me.txtID.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.txtID.UseSelectable = True
        Me.txtID.WaterMark = "ID"
        Me.txtID.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtID.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'pnlStatus
        '
        Me.pnlStatus.BackColor = System.Drawing.Color.DarkRed
        Me.pnlStatus.Controls.Add(Me.lblStatus)
        Me.pnlStatus.ForeColor = System.Drawing.Color.White
        Me.pnlStatus.Location = New System.Drawing.Point(-2, 72)
        Me.pnlStatus.Name = "pnlStatus"
        Me.pnlStatus.Size = New System.Drawing.Size(545, 22)
        Me.pnlStatus.TabIndex = 8
        Me.pnlStatus.Visible = False
        '
        'lblStatus
        '
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(3, 2)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(539, 17)
        Me.lblStatus.TabIndex = 0
        Me.lblStatus.Text = "Your appointment status was updated successfully!"
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'pnlTimer
        '
        Me.pnlTimer.Interval = 3000
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Firebrick
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(438, 323)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.Style = MetroFramework.MetroColorStyle.Red
        Me.btnDelete.TabIndex = 9
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btnDelete.UseCustomBackColor = True
        Me.btnDelete.UseCustomForeColor = True
        Me.btnDelete.UseSelectable = True
        '
        'cbSetStatus
        '
        Me.cbSetStatus.FormattingEnabled = True
        Me.cbSetStatus.ItemHeight = 23
        Me.cbSetStatus.Items.AddRange(New Object() {"Postponed", "Cancelled"})
        Me.cbSetStatus.Location = New System.Drawing.Point(25, 320)
        Me.cbSetStatus.Name = "cbSetStatus"
        Me.cbSetStatus.PromptText = "Change Status"
        Me.cbSetStatus.Size = New System.Drawing.Size(326, 29)
        Me.cbSetStatus.Style = MetroFramework.MetroColorStyle.Red
        Me.cbSetStatus.TabIndex = 10
        Me.cbSetStatus.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.cbSetStatus.UseSelectable = True
        '
        'txtStatus
        '
        '
        '
        '
        Me.txtStatus.CustomButton.Image = Nothing
        Me.txtStatus.CustomButton.Location = New System.Drawing.Point(153, 1)
        Me.txtStatus.CustomButton.Name = ""
        Me.txtStatus.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtStatus.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtStatus.CustomButton.TabIndex = 1
        Me.txtStatus.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtStatus.CustomButton.UseSelectable = True
        Me.txtStatus.CustomButton.Visible = False
        Me.txtStatus.Lines = New String(-1) {}
        Me.txtStatus.Location = New System.Drawing.Point(338, 284)
        Me.txtStatus.MaxLength = 32767
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtStatus.PromptText = "Status"
        Me.txtStatus.ReadOnly = True
        Me.txtStatus.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtStatus.SelectedText = ""
        Me.txtStatus.SelectionLength = 0
        Me.txtStatus.SelectionStart = 0
        Me.txtStatus.ShortcutsEnabled = True
        Me.txtStatus.Size = New System.Drawing.Size(175, 23)
        Me.txtStatus.Style = MetroFramework.MetroColorStyle.Red
        Me.txtStatus.TabIndex = 11
        Me.txtStatus.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.txtStatus.UseSelectable = True
        Me.txtStatus.WaterMark = "Status"
        Me.txtStatus.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtStatus.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtLocation
        '
        '
        '
        '
        Me.txtLocation.CustomButton.Image = Nothing
        Me.txtLocation.CustomButton.Location = New System.Drawing.Point(412, 1)
        Me.txtLocation.CustomButton.Name = ""
        Me.txtLocation.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtLocation.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtLocation.CustomButton.TabIndex = 1
        Me.txtLocation.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtLocation.CustomButton.UseSelectable = True
        Me.txtLocation.CustomButton.Visible = False
        Me.txtLocation.Lines = New String(-1) {}
        Me.txtLocation.Location = New System.Drawing.Point(23, 254)
        Me.txtLocation.MaxLength = 32767
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLocation.PromptText = "Location"
        Me.txtLocation.ReadOnly = True
        Me.txtLocation.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtLocation.SelectedText = ""
        Me.txtLocation.SelectionLength = 0
        Me.txtLocation.SelectionStart = 0
        Me.txtLocation.ShortcutsEnabled = True
        Me.txtLocation.Size = New System.Drawing.Size(490, 23)
        Me.txtLocation.Style = MetroFramework.MetroColorStyle.Red
        Me.txtLocation.TabIndex = 12
        Me.txtLocation.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.txtLocation.UseSelectable = True
        Me.txtLocation.WaterMark = "Location"
        Me.txtLocation.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtLocation.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'ManageAppointments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(541, 378)
        Me.Controls.Add(Me.txtLocation)
        Me.Controls.Add(Me.txtStatus)
        Me.Controls.Add(Me.cbSetStatus)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.pnlStatus)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.cbTime)
        Me.Controls.Add(Me.txtTime)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.txtAppointmentDetails)
        Me.Controls.Add(Me.txtAppointmentType)
        Me.Name = "ManageAppointments"
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow
        Me.Style = MetroFramework.MetroColorStyle.Red
        Me.Text = "Manage Appointments"
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.pnlStatus.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtAppointmentType As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtAppointmentDetails As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtDate As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtTime As MetroFramework.Controls.MetroTextBox
    Friend WithEvents cbTime As MetroFramework.Controls.MetroComboBox
    Friend WithEvents btnUpdate As MetroFramework.Controls.MetroButton
    Friend WithEvents txtID As MetroFramework.Controls.MetroTextBox
    Friend WithEvents pnlStatus As Panel
    Friend WithEvents lblStatus As Label
    Friend WithEvents pnlTimer As Timer
    Friend WithEvents btnDelete As MetroFramework.Controls.MetroButton
    Friend WithEvents cbSetStatus As MetroFramework.Controls.MetroComboBox
    Friend WithEvents txtStatus As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtLocation As MetroFramework.Controls.MetroTextBox
End Class
