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
        Me.num = New System.Windows.Forms.TextBox()
        Me.Subm = New System.Windows.Forms.Button()
        Me.CLS = New System.Windows.Forms.Button()
        Me.EXT = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter Age: "
        '
        'num
        '
        Me.num.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num.Location = New System.Drawing.Point(179, 33)
        Me.num.Multiline = True
        Me.num.Name = "num"
        Me.num.Size = New System.Drawing.Size(73, 28)
        Me.num.TabIndex = 1
        '
        'Subm
        '
        Me.Subm.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Subm.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Subm.Location = New System.Drawing.Point(88, 81)
        Me.Subm.Name = "Subm"
        Me.Subm.Size = New System.Drawing.Size(96, 38)
        Me.Subm.TabIndex = 2
        Me.Subm.Text = "&SUBMIT"
        Me.Subm.UseVisualStyleBackColor = False
        '
        'CLS
        '
        Me.CLS.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.CLS.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CLS.Location = New System.Drawing.Point(88, 142)
        Me.CLS.Name = "CLS"
        Me.CLS.Size = New System.Drawing.Size(96, 38)
        Me.CLS.TabIndex = 3
        Me.CLS.Text = "CLEA&R"
        Me.CLS.UseVisualStyleBackColor = False
        '
        'EXT
        '
        Me.EXT.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.EXT.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EXT.Location = New System.Drawing.Point(88, 203)
        Me.EXT.Name = "EXT"
        Me.EXT.Size = New System.Drawing.Size(96, 38)
        Me.EXT.TabIndex = 4
        Me.EXT.Text = "&EXIT"
        Me.EXT.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Honeydew
        Me.ClientSize = New System.Drawing.Size(282, 253)
        Me.Controls.Add(Me.EXT)
        Me.Controls.Add(Me.CLS)
        Me.Controls.Add(Me.Subm)
        Me.Controls.Add(Me.num)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Voting Eligibility"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents num As System.Windows.Forms.TextBox
    Friend WithEvents Subm As System.Windows.Forms.Button
    Friend WithEvents CLS As System.Windows.Forms.Button
    Friend WithEvents EXT As System.Windows.Forms.Button

End Class
