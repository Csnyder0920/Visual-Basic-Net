<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnSetup = New System.Windows.Forms.Button()
        Me.btnPunchLine = New System.Windows.Forms.Button()
        Me.lblSetup = New System.Windows.Forms.Label()
        Me.lblPunchLine = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSetup
        '
        Me.btnSetup.Location = New System.Drawing.Point(125, 230)
        Me.btnSetup.Name = "btnSetup"
        Me.btnSetup.Size = New System.Drawing.Size(135, 50)
        Me.btnSetup.TabIndex = 0
        Me.btnSetup.Text = "Setup"
        Me.btnSetup.UseVisualStyleBackColor = True
        '
        'btnPunchLine
        '
        Me.btnPunchLine.Location = New System.Drawing.Point(294, 230)
        Me.btnPunchLine.Name = "btnPunchLine"
        Me.btnPunchLine.Size = New System.Drawing.Size(135, 50)
        Me.btnPunchLine.TabIndex = 1
        Me.btnPunchLine.Text = "Punch Line"
        Me.btnPunchLine.UseVisualStyleBackColor = True
        '
        'lblSetup
        '
        Me.lblSetup.AutoSize = True
        Me.lblSetup.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSetup.Location = New System.Drawing.Point(24, 40)
        Me.lblSetup.Name = "lblSetup"
        Me.lblSetup.Size = New System.Drawing.Size(500, 74)
        Me.lblSetup.TabIndex = 2
        Me.lblSetup.Text = "How many programmers does it" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " take to change a lightbulb?"
        Me.lblSetup.Visible = False
        '
        'lblPunchLine
        '
        Me.lblPunchLine.AutoSize = True
        Me.lblPunchLine.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPunchLine.Location = New System.Drawing.Point(24, 146)
        Me.lblPunchLine.Name = "lblPunchLine"
        Me.lblPunchLine.Size = New System.Drawing.Size(536, 37)
        Me.lblPunchLine.TabIndex = 3
        Me.lblPunchLine.Text = "None. That's a hardware problem."
        Me.lblPunchLine.Visible = False
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(207, 299)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(135, 35)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(562, 372)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblPunchLine)
        Me.Controls.Add(Me.lblSetup)
        Me.Controls.Add(Me.btnPunchLine)
        Me.Controls.Add(Me.btnSetup)
        Me.Name = "Form1"
        Me.Text = "Joke and Punch Line"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSetup As Button
    Friend WithEvents btnPunchLine As Button
    Friend WithEvents lblSetup As Label
    Friend WithEvents lblPunchLine As Label
    Friend WithEvents btnExit As Button

    Private Sub btnSetup_Click(sender As Object, e As EventArgs) Handles btnSetup.Click
        lblSetup.Visible = True
    End Sub

    Private Sub btnPunchLine_Click(sender As Object, e As EventArgs) Handles btnPunchLine.Click
        lblPunchLine.Visible = True
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
