<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class JoesAutomotive
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
        Me.grpOil = New System.Windows.Forms.GroupBox()
        Me.chkLube = New System.Windows.Forms.CheckBox()
        Me.chkOil = New System.Windows.Forms.CheckBox()
        Me.grpFlushes = New System.Windows.Forms.GroupBox()
        Me.chkTransmission = New System.Windows.Forms.CheckBox()
        Me.chkRadiator = New System.Windows.Forms.CheckBox()
        Me.grpMisc = New System.Windows.Forms.GroupBox()
        Me.chkTire = New System.Windows.Forms.CheckBox()
        Me.chkReplaceMuffer = New System.Windows.Forms.CheckBox()
        Me.chkInspection = New System.Windows.Forms.CheckBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtLabor = New System.Windows.Forms.TextBox()
        Me.txtParts = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.lblTotalFees = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblParts = New System.Windows.Forms.Label()
        Me.lblServicesLabor = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.grpOil.SuspendLayout()
        Me.grpFlushes.SuspendLayout()
        Me.grpMisc.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpOil
        '
        Me.grpOil.Controls.Add(Me.chkLube)
        Me.grpOil.Controls.Add(Me.chkOil)
        Me.grpOil.Location = New System.Drawing.Point(51, 33)
        Me.grpOil.Name = "grpOil"
        Me.grpOil.Size = New System.Drawing.Size(200, 76)
        Me.grpOil.TabIndex = 0
        Me.grpOil.TabStop = False
        Me.grpOil.Text = "Oil && Lube"
        '
        'chkLube
        '
        Me.chkLube.AutoSize = True
        Me.chkLube.Location = New System.Drawing.Point(32, 43)
        Me.chkLube.Name = "chkLube"
        Me.chkLube.Size = New System.Drawing.Size(136, 17)
        Me.chkLube.TabIndex = 1
        Me.chkLube.Text = "Lube Job         ($18.00)"
        Me.chkLube.UseVisualStyleBackColor = True
        '
        'chkOil
        '
        Me.chkOil.AutoSize = True
        Me.chkOil.Location = New System.Drawing.Point(32, 19)
        Me.chkOil.Name = "chkOil"
        Me.chkOil.Size = New System.Drawing.Size(135, 17)
        Me.chkOil.TabIndex = 0
        Me.chkOil.Text = "Oil Change      ($25.00)"
        Me.chkOil.UseVisualStyleBackColor = True
        '
        'grpFlushes
        '
        Me.grpFlushes.Controls.Add(Me.chkTransmission)
        Me.grpFlushes.Controls.Add(Me.chkRadiator)
        Me.grpFlushes.Location = New System.Drawing.Point(269, 33)
        Me.grpFlushes.Name = "grpFlushes"
        Me.grpFlushes.Size = New System.Drawing.Size(221, 76)
        Me.grpFlushes.TabIndex = 1
        Me.grpFlushes.TabStop = False
        Me.grpFlushes.Text = "Flushes"
        '
        'chkTransmission
        '
        Me.chkTransmission.AutoSize = True
        Me.chkTransmission.Location = New System.Drawing.Point(22, 43)
        Me.chkTransmission.Name = "chkTransmission"
        Me.chkTransmission.Size = New System.Drawing.Size(157, 17)
        Me.chkTransmission.TabIndex = 1
        Me.chkTransmission.Text = "Transmission Flush ($20.00)"
        Me.chkTransmission.UseVisualStyleBackColor = True
        '
        'chkRadiator
        '
        Me.chkRadiator.AutoSize = True
        Me.chkRadiator.Location = New System.Drawing.Point(22, 20)
        Me.chkRadiator.Name = "chkRadiator"
        Me.chkRadiator.Size = New System.Drawing.Size(157, 17)
        Me.chkRadiator.TabIndex = 0
        Me.chkRadiator.Text = "Radiator Flush        ($30.00)"
        Me.chkRadiator.UseVisualStyleBackColor = True
        '
        'grpMisc
        '
        Me.grpMisc.Controls.Add(Me.chkTire)
        Me.grpMisc.Controls.Add(Me.chkReplaceMuffer)
        Me.grpMisc.Controls.Add(Me.chkInspection)
        Me.grpMisc.Location = New System.Drawing.Point(51, 115)
        Me.grpMisc.Name = "grpMisc"
        Me.grpMisc.Size = New System.Drawing.Size(200, 100)
        Me.grpMisc.TabIndex = 2
        Me.grpMisc.TabStop = False
        Me.grpMisc.Text = "Misc"
        '
        'chkTire
        '
        Me.chkTire.AutoSize = True
        Me.chkTire.Location = New System.Drawing.Point(32, 70)
        Me.chkTire.Name = "chkTire"
        Me.chkTire.Size = New System.Drawing.Size(147, 17)
        Me.chkTire.TabIndex = 2
        Me.chkTire.Text = "Tire Rotation       ($20.00)"
        Me.chkTire.UseVisualStyleBackColor = True
        '
        'chkReplaceMuffer
        '
        Me.chkReplaceMuffer.AutoSize = True
        Me.chkReplaceMuffer.Location = New System.Drawing.Point(32, 46)
        Me.chkReplaceMuffer.Name = "chkReplaceMuffer"
        Me.chkReplaceMuffer.Size = New System.Drawing.Size(152, 17)
        Me.chkReplaceMuffer.TabIndex = 1
        Me.chkReplaceMuffer.Text = "Replace Muffler  ($100.00)"
        Me.chkReplaceMuffer.UseVisualStyleBackColor = True
        '
        'chkInspection
        '
        Me.chkInspection.AutoSize = True
        Me.chkInspection.Location = New System.Drawing.Point(32, 22)
        Me.chkInspection.Name = "chkInspection"
        Me.chkInspection.Size = New System.Drawing.Size(147, 17)
        Me.chkInspection.TabIndex = 0
        Me.chkInspection.Text = "Inspection           ($15.00)"
        Me.chkInspection.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.txtLabor)
        Me.GroupBox4.Controls.Add(Me.txtParts)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Location = New System.Drawing.Point(269, 115)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(225, 100)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Parts and Labor"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(133, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "($20.00 per hour)"
        '
        'txtLabor
        '
        Me.txtLabor.Location = New System.Drawing.Point(81, 54)
        Me.txtLabor.Name = "txtLabor"
        Me.txtLabor.Size = New System.Drawing.Size(45, 20)
        Me.txtLabor.TabIndex = 3
        '
        'txtParts
        '
        Me.txtParts.Location = New System.Drawing.Point(81, 26)
        Me.txtParts.Name = "txtParts"
        Me.txtParts.Size = New System.Drawing.Size(45, 20)
        Me.txtParts.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Labor"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Parts"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.lblTotalFees)
        Me.GroupBox5.Controls.Add(Me.lblTax)
        Me.GroupBox5.Controls.Add(Me.lblParts)
        Me.GroupBox5.Controls.Add(Me.lblServicesLabor)
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Location = New System.Drawing.Point(51, 221)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(443, 138)
        Me.GroupBox5.TabIndex = 4
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Summary"
        '
        'lblTotalFees
        '
        Me.lblTotalFees.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalFees.Location = New System.Drawing.Point(218, 111)
        Me.lblTotalFees.Name = "lblTotalFees"
        Me.lblTotalFees.Size = New System.Drawing.Size(100, 23)
        Me.lblTotalFees.TabIndex = 7
        '
        'lblTax
        '
        Me.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTax.Location = New System.Drawing.Point(218, 86)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(100, 23)
        Me.lblTax.TabIndex = 6
        '
        'lblParts
        '
        Me.lblParts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblParts.Location = New System.Drawing.Point(218, 60)
        Me.lblParts.Name = "lblParts"
        Me.lblParts.Size = New System.Drawing.Size(100, 23)
        Me.lblParts.TabIndex = 5
        '
        'lblServicesLabor
        '
        Me.lblServicesLabor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblServicesLabor.Location = New System.Drawing.Point(218, 34)
        Me.lblServicesLabor.Name = "lblServicesLabor"
        Me.lblServicesLabor.Size = New System.Drawing.Size(100, 23)
        Me.lblServicesLabor.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(93, 112)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Total Fees"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(93, 86)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Tax ( on parts)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(93, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Parts"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(93, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Services && Labor"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(71, 375)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(104, 23)
        Me.btnCalculate.TabIndex = 5
        Me.btnCalculate.Text = "CalculateTotal"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(221, 375)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(350, 375)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'JoesAutomotive
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(538, 410)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.grpMisc)
        Me.Controls.Add(Me.grpFlushes)
        Me.Controls.Add(Me.grpOil)
        Me.Name = "JoesAutomotive"
        Me.Text = "Joe's Automotive"
        Me.grpOil.ResumeLayout(False)
        Me.grpOil.PerformLayout()
        Me.grpFlushes.ResumeLayout(False)
        Me.grpFlushes.PerformLayout()
        Me.grpMisc.ResumeLayout(False)
        Me.grpMisc.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpOil As GroupBox
    Friend WithEvents chkLube As CheckBox
    Friend WithEvents chkOil As CheckBox
    Friend WithEvents grpFlushes As GroupBox
    Friend WithEvents chkTransmission As CheckBox
    Friend WithEvents chkRadiator As CheckBox
    Friend WithEvents grpMisc As GroupBox
    Friend WithEvents chkTire As CheckBox
    Friend WithEvents chkReplaceMuffer As CheckBox
    Friend WithEvents chkInspection As CheckBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtLabor As TextBox
    Friend WithEvents txtParts As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents lblTotalFees As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents lblParts As Label
    Friend WithEvents lblServicesLabor As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
