<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.MetroStyleManager1 = New MetroFramework.Components.MetroStyleManager(Me.components)
        Me.cbDate = New MetroFramework.Controls.MetroDateTime()
        Me.cbHour = New MetroFramework.Controls.MetroComboBox()
        Me.cbMin = New MetroFramework.Controls.MetroComboBox()
        Me.cbAmPm = New MetroFramework.Controls.MetroComboBox()
        Me.btnAdd = New MetroFramework.Controls.MetroButton()
        Me.txtDetails = New MetroFramework.Controls.MetroTextBox()
        Me.txtType = New MetroFramework.Controls.MetroTextBox()
        Me.ContextType = New MetroFramework.Controls.MetroContextMenu(Me.components)
        Me.BeautyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DoctorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JobToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MechanicToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtGetDetails = New MetroFramework.Controls.MetroTextBox()
        Me.btnEdit = New MetroFramework.Controls.MetroButton()
        Me.btnRestart = New MetroFramework.Controls.MetroButton()
        Me.lblAppointments = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.btnViewAppointments = New MetroFramework.Controls.MetroButton()
        Me.btnAppointmentEntry = New MetroFramework.Controls.MetroButton()
        Me.btnConfirm = New MetroFramework.Controls.MetroButton()
        CType(Me.MetroStyleManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextType.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MetroStyleManager1
        '
        Me.MetroStyleManager1.Owner = Nothing
        '
        'cbDate
        '
        Me.cbDate.Location = New System.Drawing.Point(12, 13)
        Me.cbDate.MinimumSize = New System.Drawing.Size(0, 29)
        Me.cbDate.Name = "cbDate"
        Me.cbDate.Size = New System.Drawing.Size(275, 29)
        Me.cbDate.Style = MetroFramework.MetroColorStyle.Red
        Me.cbDate.TabIndex = 0
        Me.cbDate.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'cbHour
        '
        Me.cbHour.FormattingEnabled = True
        Me.cbHour.ItemHeight = 23
        Me.cbHour.Location = New System.Drawing.Point(13, 48)
        Me.cbHour.Name = "cbHour"
        Me.cbHour.PromptText = "Hour"
        Me.cbHour.Size = New System.Drawing.Size(94, 29)
        Me.cbHour.Style = MetroFramework.MetroColorStyle.Red
        Me.cbHour.TabIndex = 1
        Me.cbHour.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.cbHour.UseSelectable = True
        '
        'cbMin
        '
        Me.cbMin.FormattingEnabled = True
        Me.cbMin.ItemHeight = 23
        Me.cbMin.Location = New System.Drawing.Point(114, 48)
        Me.cbMin.Name = "cbMin"
        Me.cbMin.PromptText = "Mins"
        Me.cbMin.Size = New System.Drawing.Size(82, 29)
        Me.cbMin.Style = MetroFramework.MetroColorStyle.Red
        Me.cbMin.TabIndex = 2
        Me.cbMin.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.cbMin.UseSelectable = True
        '
        'cbAmPm
        '
        Me.cbAmPm.FormattingEnabled = True
        Me.cbAmPm.ItemHeight = 23
        Me.cbAmPm.Location = New System.Drawing.Point(203, 48)
        Me.cbAmPm.Name = "cbAmPm"
        Me.cbAmPm.PromptText = "AM/PM"
        Me.cbAmPm.Size = New System.Drawing.Size(79, 29)
        Me.cbAmPm.Style = MetroFramework.MetroColorStyle.Red
        Me.cbAmPm.TabIndex = 3
        Me.cbAmPm.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.cbAmPm.UseSelectable = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(12, 182)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(467, 23)
        Me.btnAdd.Style = MetroFramework.MetroColorStyle.Green
        Me.btnAdd.TabIndex = 6
        Me.btnAdd.Text = "Save Appointment Now"
        Me.btnAdd.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btnAdd.UseSelectable = True
        '
        'txtDetails
        '
        '
        '
        '
        Me.txtDetails.CustomButton.Image = Nothing
        Me.txtDetails.CustomButton.Location = New System.Drawing.Point(405, 2)
        Me.txtDetails.CustomButton.Name = ""
        Me.txtDetails.CustomButton.Size = New System.Drawing.Size(59, 59)
        Me.txtDetails.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtDetails.CustomButton.TabIndex = 1
        Me.txtDetails.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtDetails.CustomButton.UseSelectable = True
        Me.txtDetails.CustomButton.Visible = False
        Me.txtDetails.Lines = New String(-1) {}
        Me.txtDetails.Location = New System.Drawing.Point(13, 112)
        Me.txtDetails.MaxLength = 32767
        Me.txtDetails.Multiline = True
        Me.txtDetails.Name = "txtDetails"
        Me.txtDetails.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDetails.PromptText = "Details of your appointment"
        Me.txtDetails.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtDetails.SelectedText = ""
        Me.txtDetails.SelectionLength = 0
        Me.txtDetails.SelectionStart = 0
        Me.txtDetails.ShortcutsEnabled = True
        Me.txtDetails.Size = New System.Drawing.Size(467, 64)
        Me.txtDetails.Style = MetroFramework.MetroColorStyle.Red
        Me.txtDetails.TabIndex = 5
        Me.txtDetails.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.txtDetails.UseSelectable = True
        Me.txtDetails.WaterMark = "Details of your appointment"
        Me.txtDetails.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtDetails.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtType
        '
        '
        '
        '
        Me.txtType.CustomButton.Image = Nothing
        Me.txtType.CustomButton.Location = New System.Drawing.Point(445, 1)
        Me.txtType.CustomButton.Name = ""
        Me.txtType.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtType.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtType.CustomButton.TabIndex = 1
        Me.txtType.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtType.CustomButton.UseSelectable = True
        Me.txtType.CustomButton.Visible = False
        Me.txtType.Lines = New String(-1) {}
        Me.txtType.Location = New System.Drawing.Point(13, 83)
        Me.txtType.MaxLength = 32767
        Me.txtType.Name = "txtType"
        Me.txtType.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtType.PromptText = "Doctor, Mechanic, Salon etc."
        Me.txtType.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtType.SelectedText = ""
        Me.txtType.SelectionLength = 0
        Me.txtType.SelectionStart = 0
        Me.txtType.ShortcutsEnabled = True
        Me.txtType.Size = New System.Drawing.Size(467, 23)
        Me.txtType.Style = MetroFramework.MetroColorStyle.Red
        Me.txtType.TabIndex = 4
        Me.txtType.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.txtType.UseSelectable = True
        Me.txtType.WaterMark = "Doctor, Mechanic, Salon etc."
        Me.txtType.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtType.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'ContextType
        '
        Me.ContextType.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BeautyToolStripMenuItem, Me.DoctorToolStripMenuItem, Me.JobToolStripMenuItem, Me.MechanicToolStripMenuItem})
        Me.ContextType.Name = "MetroContextMenu1"
        Me.ContextType.Size = New System.Drawing.Size(152, 108)
        Me.ContextType.Style = MetroFramework.MetroColorStyle.Red
        Me.ContextType.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'BeautyToolStripMenuItem
        '
        Me.BeautyToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BeautyToolStripMenuItem.Name = "BeautyToolStripMenuItem"
        Me.BeautyToolStripMenuItem.Size = New System.Drawing.Size(151, 26)
        Me.BeautyToolStripMenuItem.Text = "&Beauty"
        '
        'DoctorToolStripMenuItem
        '
        Me.DoctorToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DoctorToolStripMenuItem.Name = "DoctorToolStripMenuItem"
        Me.DoctorToolStripMenuItem.Size = New System.Drawing.Size(151, 26)
        Me.DoctorToolStripMenuItem.Text = "&Doctor"
        '
        'JobToolStripMenuItem
        '
        Me.JobToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JobToolStripMenuItem.Name = "JobToolStripMenuItem"
        Me.JobToolStripMenuItem.Size = New System.Drawing.Size(151, 26)
        Me.JobToolStripMenuItem.Text = "&Job"
        '
        'MechanicToolStripMenuItem
        '
        Me.MechanicToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MechanicToolStripMenuItem.Name = "MechanicToolStripMenuItem"
        Me.MechanicToolStripMenuItem.Size = New System.Drawing.Size(151, 26)
        Me.MechanicToolStripMenuItem.Text = "&Mechanic"
        '
        'txtGetDetails
        '
        '
        '
        '
        Me.txtGetDetails.CustomButton.Image = Nothing
        Me.txtGetDetails.CustomButton.Location = New System.Drawing.Point(358, 1)
        Me.txtGetDetails.CustomButton.Name = ""
        Me.txtGetDetails.CustomButton.Size = New System.Drawing.Size(113, 113)
        Me.txtGetDetails.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtGetDetails.CustomButton.TabIndex = 1
        Me.txtGetDetails.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtGetDetails.CustomButton.UseSelectable = True
        Me.txtGetDetails.CustomButton.Visible = False
        Me.txtGetDetails.Lines = New String(-1) {}
        Me.txtGetDetails.Location = New System.Drawing.Point(13, 211)
        Me.txtGetDetails.MaxLength = 32767
        Me.txtGetDetails.Multiline = True
        Me.txtGetDetails.Name = "txtGetDetails"
        Me.txtGetDetails.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtGetDetails.ReadOnly = True
        Me.txtGetDetails.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtGetDetails.SelectedText = ""
        Me.txtGetDetails.SelectionLength = 0
        Me.txtGetDetails.SelectionStart = 0
        Me.txtGetDetails.ShortcutsEnabled = True
        Me.txtGetDetails.Size = New System.Drawing.Size(472, 115)
        Me.txtGetDetails.Style = MetroFramework.MetroColorStyle.Red
        Me.txtGetDetails.TabIndex = 5
        Me.txtGetDetails.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.txtGetDetails.UseSelectable = True
        Me.txtGetDetails.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtGetDetails.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(12, 332)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(133, 23)
        Me.btnEdit.TabIndex = 7
        Me.btnEdit.Text = "Edit this appointment"
        Me.btnEdit.UseSelectable = True
        '
        'btnRestart
        '
        Me.btnRestart.Location = New System.Drawing.Point(293, 13)
        Me.btnRestart.Name = "btnRestart"
        Me.btnRestart.Size = New System.Drawing.Size(75, 29)
        Me.btnRestart.Style = MetroFramework.MetroColorStyle.Red
        Me.btnRestart.TabIndex = 9
        Me.btnRestart.Text = "Restart"
        Me.btnRestart.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btnRestart.UseSelectable = True
        '
        'lblAppointments
        '
        Me.lblAppointments.AutoSize = True
        Me.lblAppointments.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAppointments.ForeColor = System.Drawing.Color.LightCoral
        Me.lblAppointments.Location = New System.Drawing.Point(14, 15)
        Me.lblAppointments.Name = "lblAppointments"
        Me.lblAppointments.Size = New System.Drawing.Size(0, 18)
        Me.lblAppointments.TabIndex = 10
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 32)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(323, 345)
        Me.FlowLayoutPanel1.TabIndex = 11
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(8, 36)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.cbDate)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cbAmPm)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnAdd)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnRestart)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cbHour)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnEdit)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtDetails)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnConfirm)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cbMin)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtGetDetails)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtType)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnAppointmentEntry)
        Me.SplitContainer1.Panel2.Controls.Add(Me.FlowLayoutPanel1)
        Me.SplitContainer1.Panel2Collapsed = True
        Me.SplitContainer1.Size = New System.Drawing.Size(499, 391)
        Me.SplitContainer1.SplitterDistance = 166
        Me.SplitContainer1.TabIndex = 12
        '
        'btnViewAppointments
        '
        Me.btnViewAppointments.ForeColor = System.Drawing.Color.LightCoral
        Me.btnViewAppointments.Location = New System.Drawing.Point(218, 10)
        Me.btnViewAppointments.Name = "btnViewAppointments"
        Me.btnViewAppointments.Size = New System.Drawing.Size(116, 23)
        Me.btnViewAppointments.Style = MetroFramework.MetroColorStyle.Green
        Me.btnViewAppointments.TabIndex = 13
        Me.btnViewAppointments.Text = "View Appointment"
        Me.btnViewAppointments.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btnViewAppointments.UseSelectable = True
        Me.btnViewAppointments.Visible = False
        '
        'btnAppointmentEntry
        '
        Me.btnAppointmentEntry.Location = New System.Drawing.Point(3, 3)
        Me.btnAppointmentEntry.Name = "btnAppointmentEntry"
        Me.btnAppointmentEntry.Size = New System.Drawing.Size(159, 23)
        Me.btnAppointmentEntry.Style = MetroFramework.MetroColorStyle.Red
        Me.btnAppointmentEntry.TabIndex = 0
        Me.btnAppointmentEntry.Text = "Back to appointment entry"
        Me.btnAppointmentEntry.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btnAppointmentEntry.UseSelectable = True
        '
        'btnConfirm
        '
        Me.btnConfirm.Location = New System.Drawing.Point(315, 332)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(170, 23)
        Me.btnConfirm.Style = MetroFramework.MetroColorStyle.Red
        Me.btnConfirm.TabIndex = 6
        Me.btnConfirm.Text = "Confirm this appointment"
        Me.btnConfirm.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btnConfirm.UseSelectable = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(518, 432)
        Me.ContextMenuStrip = Me.ContextType
        Me.Controls.Add(Me.btnViewAppointments)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.lblAppointments)
        Me.DisplayHeader = False
        Me.Name = "Form1"
        Me.Padding = New System.Windows.Forms.Padding(20, 30, 20, 20)
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow
        Me.Style = MetroFramework.MetroColorStyle.Red
        Me.Text = "Form1"
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        CType(Me.MetroStyleManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextType.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroStyleManager1 As MetroFramework.Components.MetroStyleManager
    Friend WithEvents cbDate As MetroFramework.Controls.MetroDateTime
    Friend WithEvents cbHour As MetroFramework.Controls.MetroComboBox
    Friend WithEvents cbMin As MetroFramework.Controls.MetroComboBox
    Friend WithEvents cbAmPm As MetroFramework.Controls.MetroComboBox
    Friend WithEvents btnAdd As MetroFramework.Controls.MetroButton
    Friend WithEvents txtDetails As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtType As MetroFramework.Controls.MetroTextBox
    Friend WithEvents ContextType As MetroFramework.Controls.MetroContextMenu
    Friend WithEvents txtGetDetails As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnEdit As MetroFramework.Controls.MetroButton
    Friend WithEvents BeautyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DoctorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents JobToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MechanicToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnRestart As MetroFramework.Controls.MetroButton
    Friend WithEvents lblAppointments As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents btnViewAppointments As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAppointmentEntry As MetroFramework.Controls.MetroButton
    Friend WithEvents btnConfirm As MetroFramework.Controls.MetroButton
End Class
