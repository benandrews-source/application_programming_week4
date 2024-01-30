<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

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
        Me.lblSoupTotal = New System.Windows.Forms.Label()
        Me.lblShelterTotal = New System.Windows.Forms.Label()
        Me.lblHumaneTotal = New System.Windows.Forms.Label()
        Me.lblMedTotal = New System.Windows.Forms.Label()
        Me.btnAddHours = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lstMissions = New System.Windows.Forms.ListBox()
        Me.lstTotals = New System.Windows.Forms.ListBox()
        Me.txtHoursInput = New System.Windows.Forms.TextBox()
        Me.lblHours = New System.Windows.Forms.Label()
        Me.lblSoupKitchen = New System.Windows.Forms.Label()
        Me.lblShelter = New System.Windows.Forms.Label()
        Me.lblHumaneSociety = New System.Windows.Forms.Label()
        Me.lblMedicalClinic = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblSoupTotal
        '
        Me.lblSoupTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSoupTotal.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSoupTotal.Location = New System.Drawing.Point(666, 103)
        Me.lblSoupTotal.Name = "lblSoupTotal"
        Me.lblSoupTotal.Size = New System.Drawing.Size(100, 43)
        Me.lblSoupTotal.TabIndex = 0
        '
        'lblShelterTotal
        '
        Me.lblShelterTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblShelterTotal.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShelterTotal.Location = New System.Drawing.Point(666, 204)
        Me.lblShelterTotal.Name = "lblShelterTotal"
        Me.lblShelterTotal.Size = New System.Drawing.Size(100, 43)
        Me.lblShelterTotal.TabIndex = 1
        '
        'lblHumaneTotal
        '
        Me.lblHumaneTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHumaneTotal.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHumaneTotal.Location = New System.Drawing.Point(666, 292)
        Me.lblHumaneTotal.Name = "lblHumaneTotal"
        Me.lblHumaneTotal.Size = New System.Drawing.Size(100, 43)
        Me.lblHumaneTotal.TabIndex = 2
        '
        'lblMedTotal
        '
        Me.lblMedTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMedTotal.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMedTotal.Location = New System.Drawing.Point(666, 382)
        Me.lblMedTotal.Name = "lblMedTotal"
        Me.lblMedTotal.Size = New System.Drawing.Size(100, 43)
        Me.lblMedTotal.TabIndex = 3
        '
        'btnAddHours
        '
        Me.btnAddHours.Location = New System.Drawing.Point(93, 281)
        Me.btnAddHours.Name = "btnAddHours"
        Me.btnAddHours.Size = New System.Drawing.Size(108, 51)
        Me.btnAddHours.TabIndex = 2
        Me.btnAddHours.Text = "&Add Hours"
        Me.btnAddHours.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(96, 357)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(108, 51)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "Clos&e"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lstMissions
        '
        Me.lstMissions.FormattingEnabled = True
        Me.lstMissions.ItemHeight = 16
        Me.lstMissions.Location = New System.Drawing.Point(38, 103)
        Me.lstMissions.Name = "lstMissions"
        Me.lstMissions.Size = New System.Drawing.Size(205, 132)
        Me.lstMissions.TabIndex = 1
        '
        'lstTotals
        '
        Me.lstTotals.FormattingEnabled = True
        Me.lstTotals.ItemHeight = 16
        Me.lstTotals.Location = New System.Drawing.Point(278, 92)
        Me.lstTotals.Name = "lstTotals"
        Me.lstTotals.Size = New System.Drawing.Size(319, 324)
        Me.lstTotals.TabIndex = 7
        Me.lstTotals.TabStop = False
        '
        'txtHoursInput
        '
        Me.txtHoursInput.Location = New System.Drawing.Point(93, 67)
        Me.txtHoursInput.Name = "txtHoursInput"
        Me.txtHoursInput.Size = New System.Drawing.Size(100, 22)
        Me.txtHoursInput.TabIndex = 0
        '
        'lblHours
        '
        Me.lblHours.AutoSize = True
        Me.lblHours.Location = New System.Drawing.Point(93, 24)
        Me.lblHours.Name = "lblHours"
        Me.lblHours.Size = New System.Drawing.Size(98, 16)
        Me.lblHours.TabIndex = 9
        Me.lblHours.Text = "Hours Donated"
        '
        'lblSoupKitchen
        '
        Me.lblSoupKitchen.Location = New System.Drawing.Point(666, 67)
        Me.lblSoupKitchen.Name = "lblSoupKitchen"
        Me.lblSoupKitchen.Size = New System.Drawing.Size(85, 16)
        Me.lblSoupKitchen.TabIndex = 10
        Me.lblSoupKitchen.Text = "Soup Kitchen"
        '
        'lblShelter
        '
        Me.lblShelter.Location = New System.Drawing.Point(666, 160)
        Me.lblShelter.Name = "lblShelter"
        Me.lblShelter.Size = New System.Drawing.Size(100, 34)
        Me.lblShelter.TabIndex = 11
        Me.lblShelter.Text = "Homeless Shelter"
        '
        'lblHumaneSociety
        '
        Me.lblHumaneSociety.Location = New System.Drawing.Point(666, 247)
        Me.lblHumaneSociety.Name = "lblHumaneSociety"
        Me.lblHumaneSociety.Size = New System.Drawing.Size(85, 37)
        Me.lblHumaneSociety.TabIndex = 12
        Me.lblHumaneSociety.Text = "Humane Society"
        '
        'lblMedicalClinic
        '
        Me.lblMedicalClinic.Location = New System.Drawing.Point(666, 345)
        Me.lblMedicalClinic.Name = "lblMedicalClinic"
        Me.lblMedicalClinic.Size = New System.Drawing.Size(100, 24)
        Me.lblMedicalClinic.TabIndex = 13
        Me.lblMedicalClinic.Text = "Medical Clinic"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblMedicalClinic)
        Me.Controls.Add(Me.lblHumaneSociety)
        Me.Controls.Add(Me.lblShelter)
        Me.Controls.Add(Me.lblSoupKitchen)
        Me.Controls.Add(Me.lblHours)
        Me.Controls.Add(Me.txtHoursInput)
        Me.Controls.Add(Me.lstTotals)
        Me.Controls.Add(Me.lstMissions)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnAddHours)
        Me.Controls.Add(Me.lblMedTotal)
        Me.Controls.Add(Me.lblHumaneTotal)
        Me.Controls.Add(Me.lblShelterTotal)
        Me.Controls.Add(Me.lblSoupTotal)
        Me.Name = "frmMain"
        Me.Text = "Mission Hours"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSoupTotal As Label
    Friend WithEvents lblShelterTotal As Label
    Friend WithEvents lblHumaneTotal As Label
    Friend WithEvents lblMedTotal As Label
    Friend WithEvents btnAddHours As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents lstMissions As ListBox
    Friend WithEvents lstTotals As ListBox
    Friend WithEvents txtHoursInput As TextBox
    Friend WithEvents lblHours As Label
    Friend WithEvents lblSoupKitchen As Label
    Friend WithEvents lblShelter As Label
    Friend WithEvents lblHumaneSociety As Label
    Friend WithEvents lblMedicalClinic As Label
End Class
