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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtRemainingBudget = New System.Windows.Forms.TextBox()
        Me.txtTotalExpenses = New System.Windows.Forms.TextBox()
        Me.txtOtherExpenses = New System.Windows.Forms.TextBox()
        Me.txtSchoolExpenses = New System.Windows.Forms.TextBox()
        Me.txtUtilityExpenses = New System.Windows.Forms.TextBox()
        Me.txtTransfortExpenses = New System.Windows.Forms.TextBox()
        Me.txtMonthlyBudget = New System.Windows.Forms.TextBox()
        Me.txtFoodExpenses = New System.Windows.Forms.TextBox()
        Me.txtStudentName = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblStudentName = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(121, 156)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Student Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(121, 189)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Monthly Budget:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(121, 222)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Food Expenses:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(121, 255)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Transport Expenses:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(121, 288)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Utility Expenses:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(121, 321)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "School Expenses:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(121, 354)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Other Expenses:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(247, 409)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Total Expenses"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(247, 446)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(94, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Remaining Budget"
        '
        'txtRemainingBudget
        '
        Me.txtRemainingBudget.Location = New System.Drawing.Point(390, 443)
        Me.txtRemainingBudget.Name = "txtRemainingBudget"
        Me.txtRemainingBudget.Size = New System.Drawing.Size(154, 20)
        Me.txtRemainingBudget.TabIndex = 26
        '
        'txtTotalExpenses
        '
        Me.txtTotalExpenses.Location = New System.Drawing.Point(390, 409)
        Me.txtTotalExpenses.Name = "txtTotalExpenses"
        Me.txtTotalExpenses.Size = New System.Drawing.Size(154, 20)
        Me.txtTotalExpenses.TabIndex = 25
        '
        'txtOtherExpenses
        '
        Me.txtOtherExpenses.Location = New System.Drawing.Point(264, 351)
        Me.txtOtherExpenses.Name = "txtOtherExpenses"
        Me.txtOtherExpenses.Size = New System.Drawing.Size(154, 20)
        Me.txtOtherExpenses.TabIndex = 6
        '
        'txtSchoolExpenses
        '
        Me.txtSchoolExpenses.Location = New System.Drawing.Point(264, 318)
        Me.txtSchoolExpenses.Name = "txtSchoolExpenses"
        Me.txtSchoolExpenses.Size = New System.Drawing.Size(154, 20)
        Me.txtSchoolExpenses.TabIndex = 5
        '
        'txtUtilityExpenses
        '
        Me.txtUtilityExpenses.Location = New System.Drawing.Point(264, 285)
        Me.txtUtilityExpenses.Name = "txtUtilityExpenses"
        Me.txtUtilityExpenses.Size = New System.Drawing.Size(154, 20)
        Me.txtUtilityExpenses.TabIndex = 4
        '
        'txtTransfortExpenses
        '
        Me.txtTransfortExpenses.Location = New System.Drawing.Point(264, 252)
        Me.txtTransfortExpenses.Name = "txtTransfortExpenses"
        Me.txtTransfortExpenses.Size = New System.Drawing.Size(154, 20)
        Me.txtTransfortExpenses.TabIndex = 3
        '
        'txtMonthlyBudget
        '
        Me.txtMonthlyBudget.Location = New System.Drawing.Point(264, 186)
        Me.txtMonthlyBudget.Name = "txtMonthlyBudget"
        Me.txtMonthlyBudget.Size = New System.Drawing.Size(154, 20)
        Me.txtMonthlyBudget.TabIndex = 1
        '
        'txtFoodExpenses
        '
        Me.txtFoodExpenses.Location = New System.Drawing.Point(264, 219)
        Me.txtFoodExpenses.Name = "txtFoodExpenses"
        Me.txtFoodExpenses.Size = New System.Drawing.Size(154, 20)
        Me.txtFoodExpenses.TabIndex = 2
        '
        'txtStudentName
        '
        Me.txtStudentName.Location = New System.Drawing.Point(264, 153)
        Me.txtStudentName.Name = "txtStudentName"
        Me.txtStudentName.Size = New System.Drawing.Size(154, 20)
        Me.txtStudentName.TabIndex = 0
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(642, 424)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(100, 35)
        Me.btnCalculate.TabIndex = 7
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblStudentName
        '
        Me.lblStudentName.AutoSize = True
        Me.lblStudentName.Location = New System.Drawing.Point(327, 476)
        Me.lblStudentName.Name = "lblStudentName"
        Me.lblStudentName.Size = New System.Drawing.Size(0, 13)
        Me.lblStudentName.TabIndex = 28
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(642, 383)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 35)
        Me.btnClear.TabIndex = 29
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1063, 569)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblStudentName)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtRemainingBudget)
        Me.Controls.Add(Me.txtTotalExpenses)
        Me.Controls.Add(Me.txtOtherExpenses)
        Me.Controls.Add(Me.txtSchoolExpenses)
        Me.Controls.Add(Me.txtUtilityExpenses)
        Me.Controls.Add(Me.txtTransfortExpenses)
        Me.Controls.Add(Me.txtMonthlyBudget)
        Me.Controls.Add(Me.txtFoodExpenses)
        Me.Controls.Add(Me.txtStudentName)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtRemainingBudget As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalExpenses As System.Windows.Forms.TextBox
    Friend WithEvents txtOtherExpenses As System.Windows.Forms.TextBox
    Friend WithEvents txtSchoolExpenses As System.Windows.Forms.TextBox
    Friend WithEvents txtUtilityExpenses As System.Windows.Forms.TextBox
    Friend WithEvents txtTransfortExpenses As System.Windows.Forms.TextBox
    Friend WithEvents txtMonthlyBudget As System.Windows.Forms.TextBox
    Friend WithEvents txtFoodExpenses As System.Windows.Forms.TextBox
    Friend WithEvents txtStudentName As System.Windows.Forms.TextBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents lblStudentName As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button

End Class
