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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CLEAR = New System.Windows.Forms.Button()
        Me.EXT = New System.Windows.Forms.Button()
        Me.TOTAL = New System.Windows.Forms.TextBox()
        Me.TRANSM = New System.Windows.Forms.TextBox()
        Me.REMARKS = New System.Windows.Forms.TextBox()
        Me.PRELIM = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MIDTERM = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FINALS = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CALC = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(228, 15)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(143, 18)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Total Final Grade:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(228, 242)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 18)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Remarks:"
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(459, 46)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(222, 375)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(487, 15)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(167, 18)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Grade Transmutation"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(228, 140)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(121, 18)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Transmutation:"
        '
        'CLEAR
        '
        Me.CLEAR.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.CLEAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CLEAR.Location = New System.Drawing.Point(35, 306)
        Me.CLEAR.Margin = New System.Windows.Forms.Padding(4)
        Me.CLEAR.Name = "CLEAR"
        Me.CLEAR.Size = New System.Drawing.Size(156, 54)
        Me.CLEAR.TabIndex = 7
        Me.CLEAR.Text = "CLEA&R"
        Me.CLEAR.UseVisualStyleBackColor = False
        '
        'EXT
        '
        Me.EXT.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.EXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EXT.Location = New System.Drawing.Point(35, 368)
        Me.EXT.Margin = New System.Windows.Forms.Padding(4)
        Me.EXT.Name = "EXT"
        Me.EXT.Size = New System.Drawing.Size(156, 54)
        Me.EXT.TabIndex = 8
        Me.EXT.Text = "&EXIT"
        Me.EXT.UseVisualStyleBackColor = False
        '
        'TOTAL
        '
        Me.TOTAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TOTAL.Location = New System.Drawing.Point(271, 46)
        Me.TOTAL.Multiline = True
        Me.TOTAL.Name = "TOTAL"
        Me.TOTAL.Size = New System.Drawing.Size(140, 70)
        Me.TOTAL.TabIndex = 9
        Me.TOTAL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TRANSM
        '
        Me.TRANSM.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TRANSM.Location = New System.Drawing.Point(271, 177)
        Me.TRANSM.Multiline = True
        Me.TRANSM.Name = "TRANSM"
        Me.TRANSM.Size = New System.Drawing.Size(120, 40)
        Me.TRANSM.TabIndex = 10
        Me.TRANSM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REMARKS
        '
        Me.REMARKS.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REMARKS.Location = New System.Drawing.Point(271, 278)
        Me.REMARKS.Multiline = True
        Me.REMARKS.Name = "REMARKS"
        Me.REMARKS.Size = New System.Drawing.Size(120, 40)
        Me.REMARKS.TabIndex = 11
        Me.REMARKS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PRELIM
        '
        Me.PRELIM.Location = New System.Drawing.Point(35, 46)
        Me.PRELIM.Margin = New System.Windows.Forms.Padding(4)
        Me.PRELIM.Name = "PRELIM"
        Me.PRELIM.Size = New System.Drawing.Size(144, 22)
        Me.PRELIM.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 15)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "PRELIM GRADE (30%)"
        '
        'MIDTERM
        '
        Me.MIDTERM.Location = New System.Drawing.Point(35, 120)
        Me.MIDTERM.Margin = New System.Windows.Forms.Padding(4)
        Me.MIDTERM.Name = "MIDTERM"
        Me.MIDTERM.Size = New System.Drawing.Size(144, 22)
        Me.MIDTERM.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(32, 90)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(197, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "MIDTERM GRADE (30%)"
        '
        'FINALS
        '
        Me.FINALS.Location = New System.Drawing.Point(35, 195)
        Me.FINALS.Margin = New System.Windows.Forms.Padding(4)
        Me.FINALS.Name = "FINALS"
        Me.FINALS.Size = New System.Drawing.Size(144, 22)
        Me.FINALS.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(35, 162)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(176, 18)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "FINALS GRADE (40%)"
        '
        'CALC
        '
        Me.CALC.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.CALC.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CALC.Location = New System.Drawing.Point(35, 242)
        Me.CALC.Margin = New System.Windows.Forms.Padding(4)
        Me.CALC.Name = "CALC"
        Me.CALC.Size = New System.Drawing.Size(156, 56)
        Me.CALC.TabIndex = 6
        Me.CALC.Text = "&CALCULATE"
        Me.CALC.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Honeydew
        Me.ClientSize = New System.Drawing.Size(752, 442)
        Me.Controls.Add(Me.CALC)
        Me.Controls.Add(Me.REMARKS)
        Me.Controls.Add(Me.FINALS)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TRANSM)
        Me.Controls.Add(Me.TOTAL)
        Me.Controls.Add(Me.MIDTERM)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CLEAR)
        Me.Controls.Add(Me.EXT)
        Me.Controls.Add(Me.PRELIM)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Simple Grade Calculator"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents CLEAR As System.Windows.Forms.Button
    Friend WithEvents EXT As System.Windows.Forms.Button
    Friend WithEvents TOTAL As System.Windows.Forms.TextBox
    Friend WithEvents TRANSM As System.Windows.Forms.TextBox
    Friend WithEvents REMARKS As System.Windows.Forms.TextBox
    Friend WithEvents PRELIM As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MIDTERM As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents FINALS As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CALC As System.Windows.Forms.Button

End Class
