<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

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
        Label1 = New Label()
        txtNumber = New TextBox()
        btnGenerate = New Button()
        lstEven = New ListBox()
        lstOdd = New ListBox()
        Label2 = New Label()
        Label3 = New Label()
        Results = New GroupBox()
        btnClear = New Button()
        Results.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(133, 40)
        Label1.Name = "Label1"
        Label1.Size = New Size(164, 28)
        Label1.TabIndex = 0
        Label1.Text = "Enter a number:"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' txtNumber
        ' 
        txtNumber.BackColor = SystemColors.Info
        txtNumber.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtNumber.Location = New Point(314, 26)
        txtNumber.Multiline = True
        txtNumber.Name = "txtNumber"
        txtNumber.Size = New Size(132, 61)
        txtNumber.TabIndex = 1
        txtNumber.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnGenerate
        ' 
        btnGenerate.BackColor = SystemColors.ButtonShadow
        btnGenerate.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnGenerate.Location = New Point(466, 26)
        btnGenerate.Name = "btnGenerate"
        btnGenerate.Size = New Size(132, 61)
        btnGenerate.TabIndex = 2
        btnGenerate.Text = "Generate"
        btnGenerate.UseVisualStyleBackColor = False
        ' 
        ' lstEven
        ' 
        lstEven.BackColor = SystemColors.GradientInactiveCaption
        lstEven.FormattingEnabled = True
        lstEven.Location = New Point(24, 84)
        lstEven.Name = "lstEven"
        lstEven.Size = New Size(150, 164)
        lstEven.TabIndex = 3
        ' 
        ' lstOdd
        ' 
        lstOdd.BackColor = SystemColors.GradientInactiveCaption
        lstOdd.FormattingEnabled = True
        lstOdd.Location = New Point(295, 84)
        lstOdd.Name = "lstOdd"
        lstOdd.Size = New Size(150, 164)
        lstOdd.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(24, 46)
        Label2.Name = "Label2"
        Label2.Size = New Size(111, 20)
        Label2.TabIndex = 5
        Label2.Text = "Even Numbers"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(295, 46)
        Label3.Name = "Label3"
        Label3.Size = New Size(107, 20)
        Label3.TabIndex = 6
        Label3.Text = "Odd Numbers"
        ' 
        ' Results
        ' 
        Results.Controls.Add(Label2)
        Results.Controls.Add(lstOdd)
        Results.Controls.Add(Label3)
        Results.Controls.Add(lstEven)
        Results.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Results.Location = New Point(133, 156)
        Results.Name = "Results"
        Results.Size = New Size(465, 265)
        Results.TabIndex = 7
        Results.TabStop = False
        Results.Text = "results"
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.Chartreuse
        btnClear.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClear.Location = New Point(411, 93)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(94, 61)
        btnClear.TabIndex = 8
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(btnClear)
        Controls.Add(Results)
        Controls.Add(btnGenerate)
        Controls.Add(txtNumber)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Results"
        Results.ResumeLayout(False)
        Results.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtNumber As TextBox
    Friend WithEvents btnGenerate As Button
    Friend WithEvents lstEven As ListBox
    Friend WithEvents lstOdd As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Results As GroupBox
    Friend WithEvents btnClear As Button

End Class
