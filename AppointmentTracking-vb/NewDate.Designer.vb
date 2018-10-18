<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewDate
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbDate = New MetroFramework.Controls.MetroDateTime()
        Me.cbHour = New MetroFramework.Controls.MetroComboBox()
        Me.cbMin = New MetroFramework.Controls.MetroComboBox()
        Me.cbAmPm = New MetroFramework.Controls.MetroComboBox()
        Me.btnOkay = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(272, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Specify the postponed appointment date and time below"
        '
        'cbDate
        '
        Me.cbDate.Location = New System.Drawing.Point(26, 96)
        Me.cbDate.MinimumSize = New System.Drawing.Size(0, 29)
        Me.cbDate.Name = "cbDate"
        Me.cbDate.Size = New System.Drawing.Size(170, 29)
        Me.cbDate.Style = MetroFramework.MetroColorStyle.Yellow
        Me.cbDate.TabIndex = 1
        Me.cbDate.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'cbHour
        '
        Me.cbHour.FormattingEnabled = True
        Me.cbHour.ItemHeight = 23
        Me.cbHour.Location = New System.Drawing.Point(203, 96)
        Me.cbHour.Name = "cbHour"
        Me.cbHour.Size = New System.Drawing.Size(73, 29)
        Me.cbHour.Style = MetroFramework.MetroColorStyle.Yellow
        Me.cbHour.TabIndex = 2
        Me.cbHour.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.cbHour.UseSelectable = True
        '
        'cbMin
        '
        Me.cbMin.FormattingEnabled = True
        Me.cbMin.ItemHeight = 23
        Me.cbMin.Location = New System.Drawing.Point(282, 96)
        Me.cbMin.Name = "cbMin"
        Me.cbMin.Size = New System.Drawing.Size(73, 29)
        Me.cbMin.Style = MetroFramework.MetroColorStyle.Yellow
        Me.cbMin.TabIndex = 3
        Me.cbMin.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.cbMin.UseSelectable = True
        '
        'cbAmPm
        '
        Me.cbAmPm.FormattingEnabled = True
        Me.cbAmPm.ItemHeight = 23
        Me.cbAmPm.Items.AddRange(New Object() {"AM", "PM"})
        Me.cbAmPm.Location = New System.Drawing.Point(361, 96)
        Me.cbAmPm.Name = "cbAmPm"
        Me.cbAmPm.Size = New System.Drawing.Size(73, 29)
        Me.cbAmPm.Style = MetroFramework.MetroColorStyle.Yellow
        Me.cbAmPm.TabIndex = 4
        Me.cbAmPm.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.cbAmPm.UseSelectable = True
        '
        'btnOkay
        '
        Me.btnOkay.Location = New System.Drawing.Point(359, 135)
        Me.btnOkay.Name = "btnOkay"
        Me.btnOkay.Size = New System.Drawing.Size(75, 23)
        Me.btnOkay.Style = MetroFramework.MetroColorStyle.Yellow
        Me.btnOkay.TabIndex = 5
        Me.btnOkay.Text = "Okay"
        Me.btnOkay.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btnOkay.UseSelectable = True
        '
        'NewDate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 173)
        Me.Controls.Add(Me.btnOkay)
        Me.Controls.Add(Me.cbAmPm)
        Me.Controls.Add(Me.cbMin)
        Me.Controls.Add(Me.cbHour)
        Me.Controls.Add(Me.cbDate)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.White
        Me.MaximizeBox = False
        Me.Name = "NewDate"
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow
        Me.Style = MetroFramework.MetroColorStyle.Yellow
        Me.Text = "NewDate"
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cbDate As MetroFramework.Controls.MetroDateTime
    Friend WithEvents cbHour As MetroFramework.Controls.MetroComboBox
    Friend WithEvents cbMin As MetroFramework.Controls.MetroComboBox
    Friend WithEvents cbAmPm As MetroFramework.Controls.MetroComboBox
    Friend WithEvents btnOkay As MetroFramework.Controls.MetroButton
End Class
