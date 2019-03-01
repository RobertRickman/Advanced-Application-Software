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
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.btnRandom = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnAverage = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lstNames = New System.Windows.Forms.ListBox()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.lstAge = New System.Windows.Forms.ListBox()
        Me.lstYear = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnDisplay
        '
        Me.btnDisplay.BackColor = System.Drawing.Color.Olive
        Me.btnDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplay.Location = New System.Drawing.Point(224, 446)
        Me.btnDisplay.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(124, 70)
        Me.btnDisplay.TabIndex = 4
        Me.btnDisplay.Text = "Dislplay All"
        Me.btnDisplay.UseVisualStyleBackColor = False
        '
        'btnRandom
        '
        Me.btnRandom.BackColor = System.Drawing.Color.Olive
        Me.btnRandom.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRandom.Location = New System.Drawing.Point(433, 447)
        Me.btnRandom.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnRandom.Name = "btnRandom"
        Me.btnRandom.Size = New System.Drawing.Size(140, 69)
        Me.btnRandom.TabIndex = 5
        Me.btnRandom.Text = "Random Selection"
        Me.btnRandom.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Olive
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(857, 446)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 70)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnAverage
        '
        Me.btnAverage.BackColor = System.Drawing.Color.Olive
        Me.btnAverage.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAverage.Location = New System.Drawing.Point(655, 447)
        Me.btnAverage.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAverage.Name = "btnAverage"
        Me.btnAverage.Size = New System.Drawing.Size(128, 70)
        Me.btnAverage.TabIndex = 6
        Me.btnAverage.Text = "Average Age"
        Me.btnAverage.UseVisualStyleBackColor = False
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(65, 74)
        Me.txtName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(281, 29)
        Me.txtName.TabIndex = 0
        '
        'txtAge
        '
        Me.txtAge.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAge.Location = New System.Drawing.Point(401, 74)
        Me.txtAge.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(159, 29)
        Me.txtAge.TabIndex = 1
        '
        'txtYear
        '
        Me.txtYear.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYear.Location = New System.Drawing.Point(729, 74)
        Me.txtYear.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(159, 29)
        Me.txtYear.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(140, 36)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 24)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Enter Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(417, 36)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 24)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Enter Age:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(604, 36)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(382, 24)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Enter Year You Graduated High School:"
        '
        'lstNames
        '
        Me.lstNames.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lstNames.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstNames.FormattingEnabled = True
        Me.lstNames.ItemHeight = 24
        Me.lstNames.Location = New System.Drawing.Point(65, 154)
        Me.lstNames.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lstNames.Name = "lstNames"
        Me.lstNames.Size = New System.Drawing.Size(192, 196)
        Me.lstNames.TabIndex = 13
        '
        'btnEnter
        '
        Me.btnEnter.BackColor = System.Drawing.Color.Olive
        Me.btnEnter.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnter.Location = New System.Drawing.Point(65, 447)
        Me.btnEnter.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(100, 69)
        Me.btnEnter.TabIndex = 3
        Me.btnEnter.Text = "Enter"
        Me.btnEnter.UseVisualStyleBackColor = False
        '
        'lstAge
        '
        Me.lstAge.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lstAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstAge.FormattingEnabled = True
        Me.lstAge.ItemHeight = 24
        Me.lstAge.Location = New System.Drawing.Point(401, 154)
        Me.lstAge.Margin = New System.Windows.Forms.Padding(4)
        Me.lstAge.Name = "lstAge"
        Me.lstAge.Size = New System.Drawing.Size(192, 196)
        Me.lstAge.TabIndex = 14
        '
        'lstYear
        '
        Me.lstYear.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lstYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstYear.FormattingEnabled = True
        Me.lstYear.ItemHeight = 24
        Me.lstYear.Location = New System.Drawing.Point(729, 154)
        Me.lstYear.Margin = New System.Windows.Forms.Padding(4)
        Me.lstYear.Name = "lstYear"
        Me.lstYear.Size = New System.Drawing.Size(192, 196)
        Me.lstYear.TabIndex = 15
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1037, 554)
        Me.Controls.Add(Me.lstYear)
        Me.Controls.Add(Me.lstAge)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lstNames)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtYear)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.btnAverage)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnRandom)
        Me.Controls.Add(Me.btnDisplay)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDisplay As Button
    Friend WithEvents btnRandom As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnAverage As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtAge As TextBox
    Friend WithEvents txtYear As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lstNames As ListBox
    Friend WithEvents btnEnter As Button
    Friend WithEvents lstAge As ListBox
    Friend WithEvents lstYear As ListBox
End Class
