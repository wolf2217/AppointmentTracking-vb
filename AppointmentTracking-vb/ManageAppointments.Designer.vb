<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageAppointments
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
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
        Me.txtAppointmentType = New MetroFramework.Controls.MetroTextBox()
        Me.txtAppointmentDetails = New MetroFramework.Controls.MetroTextBox()
        Me.txtDate = New MetroFramework.Controls.MetroTextBox()
        Me.txtTime = New MetroFramework.Controls.MetroTextBox()
        Me.txtStatus = New MetroFramework.Controls.MetroTextBox()
        Me.cbTime = New MetroFramework.Controls.MetroComboBox()
        Me.btnUpdate = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'txtAppointmentType
        '
        '
        '
        '
        Me.txtAppointmentType.CustomButton.Image = Nothing
        Me.txtAppointmentType.CustomButton.Location = New System.Drawing.Point(469, 1)
        Me.txtAppointmentType.CustomButton.Name = ""
        Me.txtAppointmentType.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtAppointmentType.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtAppointmentType.CustomButton.TabIndex = 1
        Me.txtAppointmentType.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtAppointmentType.CustomButton.UseSelectable = True
        Me.txtAppointmentType.CustomButton.Visible = False
        Me.txtAppointmentType.Lines = New String(-1) {}
        Me.txtAppointmentType.Location = New System.Drawing.Point(23, 88)
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
        Me.txtAppointmentType.Size = New System.Drawing.Size(491, 23)
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
        Me.txtAppointmentDetails.Location = New System.Drawing.Point(23, 129)
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
        Me.txtDate.Location = New System.Drawing.Point(23, 233)
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
        Me.txtTime.Location = New System.Drawing.Point(210, 233)
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
        'txtStatus
        '
        '
        '
        '
        Me.txtStatus.CustomButton.Image = Nothing
        Me.txtStatus.CustomButton.Location = New System.Drawing.Point(156, 1)
        Me.txtStatus.CustomButton.Name = ""
        Me.txtStatus.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtStatus.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtStatus.CustomButton.TabIndex = 1
        Me.txtStatus.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtStatus.CustomButton.UseSelectable = True
        Me.txtStatus.CustomButton.Visible = False
        Me.txtStatus.Lines = New String(-1) {}
        Me.txtStatus.Location = New System.Drawing.Point(336, 233)
        Me.txtStatus.MaxLength = 32767
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtStatus.PromptText = "Status of appointment"
        Me.txtStatus.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtStatus.SelectedText = ""
        Me.txtStatus.SelectionLength = 0
        Me.txtStatus.SelectionStart = 0
        Me.txtStatus.ShortcutsEnabled = True
        Me.txtStatus.Size = New System.Drawing.Size(178, 23)
        Me.txtStatus.Style = MetroFramework.MetroColorStyle.Red
        Me.txtStatus.TabIndex = 4
        Me.txtStatus.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.txtStatus.UseSelectable = True
        Me.txtStatus.WaterMark = "Status of appointment"
        Me.txtStatus.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtStatus.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
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
        Me.btnUpdate.Location = New System.Drawing.Point(438, 275)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.Style = MetroFramework.MetroColorStyle.Red
        Me.btnUpdate.TabIndex = 6
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btnUpdate.UseSelectable = True
        '
        'ManageAppointments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(541, 314)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.cbTime)
        Me.Controls.Add(Me.txtStatus)
        Me.Controls.Add(Me.txtTime)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.txtAppointmentDetails)
        Me.Controls.Add(Me.txtAppointmentType)
        Me.Name = "ManageAppointments"
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow
        Me.Style = MetroFramework.MetroColorStyle.Red
        Me.Text = "Manage Appointments"
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtAppointmentType As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtAppointmentDetails As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtDate As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtTime As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtStatus As MetroFramework.Controls.MetroTextBox
    Friend WithEvents cbTime As MetroFramework.Controls.MetroComboBox
    Friend WithEvents btnUpdate As MetroFramework.Controls.MetroButton
End Class
