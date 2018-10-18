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
        Me.btnRestart = New MetroFramework.Controls.MetroButton()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnManage = New MetroFramework.Controls.MetroButton()
        Me.tabContainer = New MetroFramework.Controls.MetroTabControl()
        Me.MetroTabPage1 = New MetroFramework.Controls.MetroTabPage()
        Me.MetroTabPage2 = New MetroFramework.Controls.MetroTabPage()
        Me.MetroTabPage3 = New MetroFramework.Controls.MetroTabPage()
        Me.btnAllAppointments = New MetroFramework.Controls.MetroButton()
        Me.FlowDashboardPanel = New System.Windows.Forms.FlowLayoutPanel()
        CType(Me.MetroStyleManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextType.SuspendLayout()
        Me.tabContainer.SuspendLayout()
        Me.MetroTabPage1.SuspendLayout()
        Me.MetroTabPage2.SuspendLayout()
        Me.MetroTabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'MetroStyleManager1
        '
        Me.MetroStyleManager1.Owner = Nothing
        '
        'cbDate
        '
        Me.cbDate.Location = New System.Drawing.Point(11, 19)
        Me.cbDate.MinimumSize = New System.Drawing.Size(4, 29)
        Me.cbDate.Name = "cbDate"
        Me.cbDate.Size = New System.Drawing.Size(190, 29)
        Me.cbDate.Style = MetroFramework.MetroColorStyle.Red
        Me.cbDate.TabIndex = 0
        Me.cbDate.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'cbHour
        '
        Me.cbHour.FormattingEnabled = True
        Me.cbHour.ItemHeight = 23
        Me.cbHour.Location = New System.Drawing.Point(207, 19)
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
        Me.cbMin.Location = New System.Drawing.Point(307, 19)
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
        Me.cbAmPm.Location = New System.Drawing.Point(395, 19)
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
        Me.btnAdd.Enabled = False
        Me.btnAdd.Location = New System.Drawing.Point(11, 200)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(751, 44)
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
        Me.txtDetails.CustomButton.Location = New System.Drawing.Point(373, 2)
        Me.txtDetails.CustomButton.Name = ""
        Me.txtDetails.CustomButton.Size = New System.Drawing.Size(87, 87)
        Me.txtDetails.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtDetails.CustomButton.TabIndex = 1
        Me.txtDetails.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtDetails.CustomButton.UseSelectable = True
        Me.txtDetails.CustomButton.Visible = False
        Me.txtDetails.Lines = New String(-1) {}
        Me.txtDetails.Location = New System.Drawing.Point(11, 102)
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
        Me.txtDetails.Size = New System.Drawing.Size(463, 92)
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
        Me.txtType.CustomButton.Location = New System.Drawing.Point(441, 1)
        Me.txtType.CustomButton.Name = ""
        Me.txtType.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtType.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtType.CustomButton.TabIndex = 1
        Me.txtType.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtType.CustomButton.UseSelectable = True
        Me.txtType.CustomButton.Visible = False
        Me.txtType.Lines = New String(-1) {}
        Me.txtType.Location = New System.Drawing.Point(11, 73)
        Me.txtType.MaxLength = 32767
        Me.txtType.Name = "txtType"
        Me.txtType.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtType.PromptText = "Doctor, Mechanic, Salon etc."
        Me.txtType.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtType.SelectedText = ""
        Me.txtType.SelectionLength = 0
        Me.txtType.SelectionStart = 0
        Me.txtType.ShortcutsEnabled = True
        Me.txtType.Size = New System.Drawing.Size(463, 23)
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
        Me.txtGetDetails.CustomButton.Location = New System.Drawing.Point(100, 1)
        Me.txtGetDetails.CustomButton.Name = ""
        Me.txtGetDetails.CustomButton.Size = New System.Drawing.Size(173, 173)
        Me.txtGetDetails.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtGetDetails.CustomButton.TabIndex = 1
        Me.txtGetDetails.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtGetDetails.CustomButton.UseSelectable = True
        Me.txtGetDetails.CustomButton.Visible = False
        Me.txtGetDetails.Lines = New String(-1) {}
        Me.txtGetDetails.Location = New System.Drawing.Point(485, 19)
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
        Me.txtGetDetails.Size = New System.Drawing.Size(274, 175)
        Me.txtGetDetails.Style = MetroFramework.MetroColorStyle.Red
        Me.txtGetDetails.TabIndex = 5
        Me.txtGetDetails.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.txtGetDetails.UseSelectable = True
        Me.txtGetDetails.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtGetDetails.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnRestart
        '
        Me.btnRestart.Location = New System.Drawing.Point(11, 250)
        Me.btnRestart.Name = "btnRestart"
        Me.btnRestart.Size = New System.Drawing.Size(751, 25)
        Me.btnRestart.Style = MetroFramework.MetroColorStyle.Red
        Me.btnRestart.TabIndex = 9
        Me.btnRestart.Text = "Restart"
        Me.btnRestart.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btnRestart.UseSelectable = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.FlowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(5, 41)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(749, 273)
        Me.FlowLayoutPanel1.TabIndex = 11
        '
        'btnManage
        '
        Me.btnManage.ForeColor = System.Drawing.Color.LightCoral
        Me.btnManage.Location = New System.Drawing.Point(5, 12)
        Me.btnManage.Name = "btnManage"
        Me.btnManage.Size = New System.Drawing.Size(141, 23)
        Me.btnManage.Style = MetroFramework.MetroColorStyle.Green
        Me.btnManage.TabIndex = 14
        Me.btnManage.Text = "Manage Appointments"
        Me.btnManage.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btnManage.UseSelectable = True
        '
        'tabContainer
        '
        Me.tabContainer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabContainer.Controls.Add(Me.MetroTabPage1)
        Me.tabContainer.Controls.Add(Me.MetroTabPage2)
        Me.tabContainer.Controls.Add(Me.MetroTabPage3)
        Me.tabContainer.Location = New System.Drawing.Point(8, 33)
        Me.tabContainer.Name = "tabContainer"
        Me.tabContainer.SelectedIndex = 0
        Me.tabContainer.Size = New System.Drawing.Size(770, 359)
        Me.tabContainer.Style = MetroFramework.MetroColorStyle.Red
        Me.tabContainer.TabIndex = 15
        Me.tabContainer.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.tabContainer.UseSelectable = True
        '
        'MetroTabPage1
        '
        Me.MetroTabPage1.Controls.Add(Me.FlowDashboardPanel)
        Me.MetroTabPage1.Controls.Add(Me.btnAllAppointments)
        Me.MetroTabPage1.HorizontalScrollbarBarColor = True
        Me.MetroTabPage1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.HorizontalScrollbarSize = 10
        Me.MetroTabPage1.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage1.Name = "MetroTabPage1"
        Me.MetroTabPage1.Size = New System.Drawing.Size(762, 317)
        Me.MetroTabPage1.Style = MetroFramework.MetroColorStyle.Red
        Me.MetroTabPage1.TabIndex = 0
        Me.MetroTabPage1.Text = "Dashboard"
        Me.MetroTabPage1.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroTabPage1.VerticalScrollbarBarColor = True
        Me.MetroTabPage1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.VerticalScrollbarSize = 10
        '
        'MetroTabPage2
        '
        Me.MetroTabPage2.Controls.Add(Me.txtType)
        Me.MetroTabPage2.Controls.Add(Me.btnRestart)
        Me.MetroTabPage2.Controls.Add(Me.btnAdd)
        Me.MetroTabPage2.Controls.Add(Me.cbAmPm)
        Me.MetroTabPage2.Controls.Add(Me.cbDate)
        Me.MetroTabPage2.Controls.Add(Me.cbHour)
        Me.MetroTabPage2.Controls.Add(Me.txtGetDetails)
        Me.MetroTabPage2.Controls.Add(Me.txtDetails)
        Me.MetroTabPage2.Controls.Add(Me.cbMin)
        Me.MetroTabPage2.HorizontalScrollbarBarColor = True
        Me.MetroTabPage2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.HorizontalScrollbarSize = 10
        Me.MetroTabPage2.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage2.Name = "MetroTabPage2"
        Me.MetroTabPage2.Size = New System.Drawing.Size(762, 317)
        Me.MetroTabPage2.Style = MetroFramework.MetroColorStyle.Red
        Me.MetroTabPage2.TabIndex = 1
        Me.MetroTabPage2.Text = "New Appointment"
        Me.MetroTabPage2.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroTabPage2.VerticalScrollbarBarColor = True
        Me.MetroTabPage2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.VerticalScrollbarSize = 10
        '
        'MetroTabPage3
        '
        Me.MetroTabPage3.Controls.Add(Me.FlowLayoutPanel1)
        Me.MetroTabPage3.Controls.Add(Me.btnManage)
        Me.MetroTabPage3.HorizontalScrollbarBarColor = True
        Me.MetroTabPage3.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage3.HorizontalScrollbarSize = 10
        Me.MetroTabPage3.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage3.Name = "MetroTabPage3"
        Me.MetroTabPage3.Size = New System.Drawing.Size(762, 317)
        Me.MetroTabPage3.Style = MetroFramework.MetroColorStyle.Red
        Me.MetroTabPage3.TabIndex = 2
        Me.MetroTabPage3.Text = "Today's Appointments"
        Me.MetroTabPage3.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroTabPage3.VerticalScrollbarBarColor = True
        Me.MetroTabPage3.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage3.VerticalScrollbarSize = 10
        '
        'btnAllAppointments
        '
        Me.btnAllAppointments.ForeColor = System.Drawing.Color.LightCoral
        Me.btnAllAppointments.Location = New System.Drawing.Point(0, 14)
        Me.btnAllAppointments.Name = "btnAllAppointments"
        Me.btnAllAppointments.Size = New System.Drawing.Size(141, 23)
        Me.btnAllAppointments.Style = MetroFramework.MetroColorStyle.Green
        Me.btnAllAppointments.TabIndex = 15
        Me.btnAllAppointments.Text = "View All Appointments"
        Me.btnAllAppointments.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btnAllAppointments.UseSelectable = True
        '
        'FlowDashboardPanel
        '
        Me.FlowDashboardPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowDashboardPanel.AutoScroll = True
        Me.FlowDashboardPanel.BackColor = System.Drawing.Color.Transparent
        Me.FlowDashboardPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FlowDashboardPanel.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp
        Me.FlowDashboardPanel.Location = New System.Drawing.Point(3, 48)
        Me.FlowDashboardPanel.Name = "FlowDashboardPanel"
        Me.FlowDashboardPanel.Size = New System.Drawing.Size(756, 263)
        Me.FlowDashboardPanel.TabIndex = 16
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(789, 405)
        Me.ContextMenuStrip = Me.ContextType
        Me.Controls.Add(Me.tabContainer)
        Me.DisplayHeader = False
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Padding = New System.Windows.Forms.Padding(20, 30, 20, 20)
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow
        Me.Style = MetroFramework.MetroColorStyle.Red
        Me.Text = "Form1"
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        CType(Me.MetroStyleManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextType.ResumeLayout(False)
        Me.tabContainer.ResumeLayout(False)
        Me.MetroTabPage1.ResumeLayout(False)
        Me.MetroTabPage2.ResumeLayout(False)
        Me.MetroTabPage3.ResumeLayout(False)
        Me.ResumeLayout(False)

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
    Friend WithEvents BeautyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DoctorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents JobToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MechanicToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnRestart As MetroFramework.Controls.MetroButton
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents btnManage As MetroFramework.Controls.MetroButton
    Friend WithEvents tabContainer As MetroFramework.Controls.MetroTabControl
    Friend WithEvents MetroTabPage1 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroTabPage2 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroTabPage3 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents btnAllAppointments As MetroFramework.Controls.MetroButton
    Friend WithEvents FlowDashboardPanel As FlowLayoutPanel
End Class
