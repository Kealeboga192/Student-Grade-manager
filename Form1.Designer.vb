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
        Me.txtMaths = New System.Windows.Forms.TextBox()
        Me.txtProgramming = New System.Windows.Forms.TextBox()
        Me.txtComputerHardware = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnAddstudent = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.LblTotalStudents = New System.Windows.Forms.Label()
        Me.lblClassAverage = New System.Windows.Forms.Label()
        Me.dgvStudents = New System.Windows.Forms.DataGridView()
        Me.ColName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColMaths = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColProgramming = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColComputerHadrware = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColAverage = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColGrade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvStudents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(47, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(319, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "STUDENT GRADE MANAGER"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Student Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Maths"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(195, 139)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Programming"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(363, 145)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Computer Hardware"
        '
        'txtMaths
        '
        Me.txtMaths.Location = New System.Drawing.Point(39, 180)
        Me.txtMaths.Name = "txtMaths"
        Me.txtMaths.Size = New System.Drawing.Size(100, 20)
        Me.txtMaths.TabIndex = 5
        '
        'txtProgramming
        '
        Me.txtProgramming.Location = New System.Drawing.Point(202, 178)
        Me.txtProgramming.Name = "txtProgramming"
        Me.txtProgramming.Size = New System.Drawing.Size(100, 20)
        Me.txtProgramming.TabIndex = 6
        '
        'txtComputerHardware
        '
        Me.txtComputerHardware.Location = New System.Drawing.Point(366, 178)
        Me.txtComputerHardware.Name = "txtComputerHardware"
        Me.txtComputerHardware.Size = New System.Drawing.Size(100, 20)
        Me.txtComputerHardware.TabIndex = 7
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(37, 92)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 8
        '
        'btnAddstudent
        '
        Me.btnAddstudent.Location = New System.Drawing.Point(47, 228)
        Me.btnAddstudent.Name = "btnAddstudent"
        Me.btnAddstudent.Size = New System.Drawing.Size(75, 23)
        Me.btnAddstudent.TabIndex = 9
        Me.btnAddstudent.Text = "Add student"
        Me.btnAddstudent.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(202, 228)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(75, 23)
        Me.BtnDelete.TabIndex = 10
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(381, 228)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 11
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'LblTotalStudents
        '
        Me.LblTotalStudents.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblTotalStudents.Location = New System.Drawing.Point(44, 411)
        Me.LblTotalStudents.Name = "LblTotalStudents"
        Me.LblTotalStudents.Size = New System.Drawing.Size(100, 23)
        Me.LblTotalStudents.TabIndex = 13
        '
        'lblClassAverage
        '
        Me.lblClassAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblClassAverage.Location = New System.Drawing.Point(325, 411)
        Me.lblClassAverage.Name = "lblClassAverage"
        Me.lblClassAverage.Size = New System.Drawing.Size(100, 23)
        Me.lblClassAverage.TabIndex = 14
        '
        'dgvStudents
        '
        Me.dgvStudents.AllowUserToAddRows = False
        Me.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStudents.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColName, Me.ColMaths, Me.ColProgramming, Me.ColComputerHadrware, Me.ColAverage, Me.ColGrade, Me.ColStatus})
        Me.dgvStudents.Location = New System.Drawing.Point(33, 269)
        Me.dgvStudents.MultiSelect = False
        Me.dgvStudents.Name = "dgvStudents"
        Me.dgvStudents.ReadOnly = True
        Me.dgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvStudents.Size = New System.Drawing.Size(544, 117)
        Me.dgvStudents.TabIndex = 15
        '
        'ColName
        '
        Me.ColName.HeaderText = "Student Name"
        Me.ColName.Name = "ColName"
        '
        'ColMaths
        '
        Me.ColMaths.HeaderText = "Maths"
        Me.ColMaths.Name = "ColMaths"
        '
        'ColProgramming
        '
        Me.ColProgramming.HeaderText = "Programming"
        Me.ColProgramming.Name = "ColProgramming"
        '
        'ColComputerHadrware
        '
        Me.ColComputerHadrware.HeaderText = "Computer Hardware"
        Me.ColComputerHadrware.Name = "ColComputerHadrware"
        '
        'ColAverage
        '
        Me.ColAverage.HeaderText = "Average"
        Me.ColAverage.Name = "ColAverage"
        '
        'ColGrade
        '
        Me.ColGrade.HeaderText = "Grade"
        Me.ColGrade.Name = "ColGrade"
        '
        'ColStatus
        '
        Me.ColStatus.HeaderText = "Status"
        Me.ColStatus.Name = "ColStatus"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.dgvStudents)
        Me.Controls.Add(Me.lblClassAverage)
        Me.Controls.Add(Me.LblTotalStudents)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.btnAddstudent)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtComputerHardware)
        Me.Controls.Add(Me.txtProgramming)
        Me.Controls.Add(Me.txtMaths)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgvStudents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtMaths As TextBox
    Friend WithEvents txtProgramming As TextBox
    Friend WithEvents txtComputerHardware As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents btnAddstudent As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents LblTotalStudents As Label
    Friend WithEvents lblClassAverage As Label
    Friend WithEvents dgvStudents As DataGridView
    Friend WithEvents ColName As DataGridViewTextBoxColumn
    Friend WithEvents ColMaths As DataGridViewTextBoxColumn
    Friend WithEvents ColProgramming As DataGridViewTextBoxColumn
    Friend WithEvents ColComputerHadrware As DataGridViewTextBoxColumn
    Friend WithEvents ColAverage As DataGridViewTextBoxColumn
    Friend WithEvents ColGrade As DataGridViewTextBoxColumn
    Friend WithEvents ColStatus As DataGridViewTextBoxColumn
End Class
