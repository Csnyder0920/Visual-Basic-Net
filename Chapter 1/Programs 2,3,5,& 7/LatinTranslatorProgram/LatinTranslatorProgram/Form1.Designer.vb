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
        Me.lblLeft = New System.Windows.Forms.Label()
        Me.lblMiddle = New System.Windows.Forms.Label()
        Me.lblRight = New System.Windows.Forms.Label()
        Me.btnLeft = New System.Windows.Forms.Button()
        Me.btnMiddle = New System.Windows.Forms.Button()
        Me.btnRight = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblLeft
        '
        Me.lblLeft.AutoSize = True
        Me.lblLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLeft.Location = New System.Drawing.Point(16, 93)
        Me.lblLeft.Name = "lblLeft"
        Me.lblLeft.Size = New System.Drawing.Size(126, 37)
        Me.lblLeft.TabIndex = 0
        Me.lblLeft.Text = "sinister"
        Me.lblLeft.Visible = False
        '
        'lblMiddle
        '
        Me.lblMiddle.AutoSize = True
        Me.lblMiddle.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMiddle.Location = New System.Drawing.Point(143, 93)
        Me.lblMiddle.Name = "lblMiddle"
        Me.lblMiddle.Size = New System.Drawing.Size(137, 37)
        Me.lblMiddle.TabIndex = 1
        Me.lblMiddle.Text = "medium"
        Me.lblMiddle.Visible = False
        '
        'lblRight
        '
        Me.lblRight.AutoSize = True
        Me.lblRight.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRight.Location = New System.Drawing.Point(279, 93)
        Me.lblRight.Name = "lblRight"
        Me.lblRight.Size = New System.Drawing.Size(110, 37)
        Me.lblRight.TabIndex = 2
        Me.lblRight.Text = "dexter"
        Me.lblRight.Visible = False
        '
        'btnLeft
        '
        Me.btnLeft.Location = New System.Drawing.Point(12, 175)
        Me.btnLeft.Name = "btnLeft"
        Me.btnLeft.Size = New System.Drawing.Size(112, 58)
        Me.btnLeft.TabIndex = 3
        Me.btnLeft.Text = "Left"
        Me.btnLeft.UseVisualStyleBackColor = True
        '
        'btnMiddle
        '
        Me.btnMiddle.Location = New System.Drawing.Point(150, 175)
        Me.btnMiddle.Name = "btnMiddle"
        Me.btnMiddle.Size = New System.Drawing.Size(112, 58)
        Me.btnMiddle.TabIndex = 4
        Me.btnMiddle.Text = "Middle"
        Me.btnMiddle.UseVisualStyleBackColor = True
        '
        'btnRight
        '
        Me.btnRight.Location = New System.Drawing.Point(286, 175)
        Me.btnRight.Name = "btnRight"
        Me.btnRight.Size = New System.Drawing.Size(112, 58)
        Me.btnRight.TabIndex = 5
        Me.btnRight.Text = "Right"
        Me.btnRight.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(150, 253)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(112, 39)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 320)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnRight)
        Me.Controls.Add(Me.btnMiddle)
        Me.Controls.Add(Me.btnLeft)
        Me.Controls.Add(Me.lblRight)
        Me.Controls.Add(Me.lblMiddle)
        Me.Controls.Add(Me.lblLeft)
        Me.Name = "Form1"
        Me.Text = "Latin Translator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblLeft As Label
    Friend WithEvents lblMiddle As Label
    Friend WithEvents lblRight As Label
    Friend WithEvents btnLeft As Button
    Friend WithEvents btnMiddle As Button
    Friend WithEvents btnRight As Button
    Friend WithEvents btnExit As Button

    Private Sub btnLeft_Click(sender As Object, e As EventArgs) Handles btnLeft.Click
        lblLeft.Visible = True
    End Sub

    Private Sub btnMiddle_Click(sender As Object, e As EventArgs) Handles btnMiddle.Click
        lblMiddle.Visible = True
    End Sub

    Private Sub btnRight_Click(sender As Object, e As EventArgs) Handles btnRight.Click
        lblRight.Visible = True
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
