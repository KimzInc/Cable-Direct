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
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.radBusiness = New System.Windows.Forms.RadioButton()
        Me.radResidential = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTtlDue = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lstPremium = New System.Windows.Forms.ListBox()
        Me.lstConnection = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(292, 286)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(87, 27)
        Me.btnCalc.TabIndex = 0
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(457, 286)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(87, 27)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'radBusiness
        '
        Me.radBusiness.AutoSize = True
        Me.radBusiness.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radBusiness.Location = New System.Drawing.Point(55, 51)
        Me.radBusiness.Name = "radBusiness"
        Me.radBusiness.Size = New System.Drawing.Size(70, 19)
        Me.radBusiness.TabIndex = 2
        Me.radBusiness.TabStop = True
        Me.radBusiness.Text = "Business"
        Me.radBusiness.UseVisualStyleBackColor = True
        '
        'radResidential
        '
        Me.radResidential.AutoSize = True
        Me.radResidential.Checked = True
        Me.radResidential.Location = New System.Drawing.Point(55, 96)
        Me.radResidential.Name = "radResidential"
        Me.radResidential.Size = New System.Drawing.Size(82, 19)
        Me.radResidential.TabIndex = 3
        Me.radResidential.TabStop = True
        Me.radResidential.Text = "Residential"
        Me.radResidential.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(75, 267)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Total Due:"
        '
        'lblTtlDue
        '
        Me.lblTtlDue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTtlDue.Location = New System.Drawing.Point(78, 286)
        Me.lblTtlDue.Name = "lblTtlDue"
        Me.lblTtlDue.Size = New System.Drawing.Size(116, 26)
        Me.lblTtlDue.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(318, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 15)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Premium Channels:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(477, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Connections:"
        '
        'lstPremium
        '
        Me.lstPremium.FormattingEnabled = True
        Me.lstPremium.ItemHeight = 15
        Me.lstPremium.Location = New System.Drawing.Point(321, 70)
        Me.lstPremium.Name = "lstPremium"
        Me.lstPremium.Size = New System.Drawing.Size(58, 94)
        Me.lstPremium.TabIndex = 8
        '
        'lstConnection
        '
        Me.lstConnection.FormattingEnabled = True
        Me.lstConnection.ItemHeight = 15
        Me.lstConnection.Location = New System.Drawing.Point(480, 70)
        Me.lstConnection.Name = "lstConnection"
        Me.lstConnection.Size = New System.Drawing.Size(64, 94)
        Me.lstConnection.TabIndex = 9
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(606, 350)
        Me.Controls.Add(Me.lstConnection)
        Me.Controls.Add(Me.lstPremium)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblTtlDue)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.radResidential)
        Me.Controls.Add(Me.radBusiness)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalc)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmMain"
        Me.Text = "Cable Direct"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalc As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents radBusiness As RadioButton
    Friend WithEvents radResidential As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTtlDue As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lstPremium As ListBox
    Friend WithEvents lstConnection As ListBox
End Class
