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
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnReview = New System.Windows.Forms.Button()
        Me.chkCrystal = New System.Windows.Forms.CheckBox()
        Me.cboFinish = New System.Windows.Forms.ComboBox()
        Me.cboLights = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(100, 230)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(112, 44)
        Me.btnSubmit.TabIndex = 0
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnReview
        '
        Me.btnReview.Location = New System.Drawing.Point(308, 230)
        Me.btnReview.Margin = New System.Windows.Forms.Padding(4)
        Me.btnReview.Name = "btnReview"
        Me.btnReview.Size = New System.Drawing.Size(143, 44)
        Me.btnReview.TabIndex = 1
        Me.btnReview.Text = "Review Order:"
        Me.btnReview.UseVisualStyleBackColor = True
        '
        'chkCrystal
        '
        Me.chkCrystal.AutoSize = True
        Me.chkCrystal.Location = New System.Drawing.Point(32, 154)
        Me.chkCrystal.Margin = New System.Windows.Forms.Padding(4)
        Me.chkCrystal.Name = "chkCrystal"
        Me.chkCrystal.Size = New System.Drawing.Size(248, 28)
        Me.chkCrystal.TabIndex = 2
        Me.chkCrystal.Text = "Include Crystal Trimmings"
        Me.chkCrystal.UseVisualStyleBackColor = True
        '
        'cboFinish
        '
        Me.cboFinish.FormattingEnabled = True
        Me.cboFinish.Location = New System.Drawing.Point(89, 43)
        Me.cboFinish.Margin = New System.Windows.Forms.Padding(4)
        Me.cboFinish.Name = "cboFinish"
        Me.cboFinish.Size = New System.Drawing.Size(180, 32)
        Me.cboFinish.TabIndex = 3
        '
        'cboLights
        '
        Me.cboLights.FormattingEnabled = True
        Me.cboLights.Location = New System.Drawing.Point(180, 95)
        Me.cboLights.Margin = New System.Windows.Forms.Padding(4)
        Me.cboLights.Name = "cboLights"
        Me.cboLights.Size = New System.Drawing.Size(50, 32)
        Me.cboLights.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 51)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 24)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Finish:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 103)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(158, 24)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Number of Lights:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(507, 376)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboLights)
        Me.Controls.Add(Me.cboFinish)
        Me.Controls.Add(Me.chkCrystal)
        Me.Controls.Add(Me.btnReview)
        Me.Controls.Add(Me.btnSubmit)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Custom Chandelier Creators"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnReview As Button
    Friend WithEvents chkCrystal As CheckBox
    Friend WithEvents cboFinish As ComboBox
    Friend WithEvents cboLights As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
