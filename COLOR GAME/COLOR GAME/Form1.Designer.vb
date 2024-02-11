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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OrangeBtn = New System.Windows.Forms.Button()
        Me.GrayBtn = New System.Windows.Forms.Button()
        Me.PurpleBtn = New System.Windows.Forms.Button()
        Me.PinkBtn = New System.Windows.Forms.Button()
        Me.BrownBtn = New System.Windows.Forms.Button()
        Me.YellowBtn = New System.Windows.Forms.Button()
        Me.GreenBtn = New System.Windows.Forms.Button()
        Me.BlueBtn = New System.Windows.Forms.Button()
        Me.RedBtn = New System.Windows.Forms.Button()
        Me.StartOver = New System.Windows.Forms.Button()
        Me.Print = New System.Windows.Forms.Button()
        Me.Fnt = New System.Windows.Forms.Button()
        Me.Ext = New System.Windows.Forms.Button()
        Me.FontDialog = New System.Windows.Forms.FontDialog()
        Me.PrintForm = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(58, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(246, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Click a color button:"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Controls.Add(Me.OrangeBtn, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.GrayBtn, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.PurpleBtn, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.PinkBtn, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.BrownBtn, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.YellowBtn, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.GreenBtn, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.BlueBtn, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.RedBtn, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(60, 83)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(367, 262)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'OrangeBtn
        '
        Me.OrangeBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OrangeBtn.Font = New System.Drawing.Font("Arial Narrow", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrangeBtn.Location = New System.Drawing.Point(247, 177)
        Me.OrangeBtn.Name = "OrangeBtn"
        Me.OrangeBtn.Size = New System.Drawing.Size(117, 82)
        Me.OrangeBtn.TabIndex = 9
        Me.OrangeBtn.Text = "&Orange"
        Me.OrangeBtn.UseVisualStyleBackColor = True
        '
        'GrayBtn
        '
        Me.GrayBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrayBtn.Font = New System.Drawing.Font("Arial Narrow", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrayBtn.Location = New System.Drawing.Point(125, 177)
        Me.GrayBtn.Name = "GrayBtn"
        Me.GrayBtn.Size = New System.Drawing.Size(116, 82)
        Me.GrayBtn.TabIndex = 8
        Me.GrayBtn.Text = "Gr&ay"
        Me.GrayBtn.UseVisualStyleBackColor = True
        '
        'PurpleBtn
        '
        Me.PurpleBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PurpleBtn.Font = New System.Drawing.Font("Arial Narrow", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PurpleBtn.Location = New System.Drawing.Point(3, 177)
        Me.PurpleBtn.Name = "PurpleBtn"
        Me.PurpleBtn.Size = New System.Drawing.Size(116, 82)
        Me.PurpleBtn.TabIndex = 7
        Me.PurpleBtn.Text = "P&urple"
        Me.PurpleBtn.UseVisualStyleBackColor = True
        '
        'PinkBtn
        '
        Me.PinkBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PinkBtn.Font = New System.Drawing.Font("Arial Narrow", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PinkBtn.Location = New System.Drawing.Point(247, 90)
        Me.PinkBtn.Name = "PinkBtn"
        Me.PinkBtn.Size = New System.Drawing.Size(117, 81)
        Me.PinkBtn.TabIndex = 6
        Me.PinkBtn.Text = "Pin&k"
        Me.PinkBtn.UseVisualStyleBackColor = True
        '
        'BrownBtn
        '
        Me.BrownBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BrownBtn.Font = New System.Drawing.Font("Arial Narrow", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BrownBtn.Location = New System.Drawing.Point(125, 90)
        Me.BrownBtn.Name = "BrownBtn"
        Me.BrownBtn.Size = New System.Drawing.Size(116, 81)
        Me.BrownBtn.TabIndex = 5
        Me.BrownBtn.Text = "Bro&wn"
        Me.BrownBtn.UseVisualStyleBackColor = True
        '
        'YellowBtn
        '
        Me.YellowBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.YellowBtn.Font = New System.Drawing.Font("Arial Narrow", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.YellowBtn.Location = New System.Drawing.Point(3, 90)
        Me.YellowBtn.Name = "YellowBtn"
        Me.YellowBtn.Size = New System.Drawing.Size(116, 81)
        Me.YellowBtn.TabIndex = 4
        Me.YellowBtn.Text = "&Yellow"
        Me.YellowBtn.UseVisualStyleBackColor = True
        '
        'GreenBtn
        '
        Me.GreenBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GreenBtn.Font = New System.Drawing.Font("Arial Narrow", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GreenBtn.Location = New System.Drawing.Point(247, 3)
        Me.GreenBtn.Name = "GreenBtn"
        Me.GreenBtn.Size = New System.Drawing.Size(117, 81)
        Me.GreenBtn.TabIndex = 3
        Me.GreenBtn.Text = "&Green"
        Me.GreenBtn.UseVisualStyleBackColor = True
        '
        'BlueBtn
        '
        Me.BlueBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BlueBtn.Font = New System.Drawing.Font("Arial Narrow", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BlueBtn.Location = New System.Drawing.Point(125, 3)
        Me.BlueBtn.Name = "BlueBtn"
        Me.BlueBtn.Size = New System.Drawing.Size(116, 81)
        Me.BlueBtn.TabIndex = 2
        Me.BlueBtn.Text = "&Blue"
        Me.BlueBtn.UseVisualStyleBackColor = True
        '
        'RedBtn
        '
        Me.RedBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RedBtn.Font = New System.Drawing.Font("Arial Narrow", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RedBtn.Location = New System.Drawing.Point(3, 3)
        Me.RedBtn.Name = "RedBtn"
        Me.RedBtn.Size = New System.Drawing.Size(116, 81)
        Me.RedBtn.TabIndex = 1
        Me.RedBtn.Text = "&Red"
        Me.RedBtn.UseVisualStyleBackColor = True
        '
        'StartOver
        '
        Me.StartOver.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartOver.Location = New System.Drawing.Point(12, 366)
        Me.StartOver.Name = "StartOver"
        Me.StartOver.Size = New System.Drawing.Size(108, 41)
        Me.StartOver.TabIndex = 10
        Me.StartOver.Text = "&Start Over"
        Me.StartOver.UseVisualStyleBackColor = True
        '
        'Print
        '
        Me.Print.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Print.Location = New System.Drawing.Point(156, 366)
        Me.Print.Name = "Print"
        Me.Print.Size = New System.Drawing.Size(84, 41)
        Me.Print.TabIndex = 11
        Me.Print.Text = "&Print"
        Me.Print.UseVisualStyleBackColor = True
        '
        'Fnt
        '
        Me.Fnt.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fnt.Location = New System.Drawing.Point(272, 366)
        Me.Fnt.Name = "Fnt"
        Me.Fnt.Size = New System.Drawing.Size(80, 41)
        Me.Fnt.TabIndex = 12
        Me.Fnt.Text = "&Font"
        Me.Fnt.UseVisualStyleBackColor = True
        '
        'Ext
        '
        Me.Ext.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ext.Location = New System.Drawing.Point(390, 366)
        Me.Ext.Name = "Ext"
        Me.Ext.Size = New System.Drawing.Size(75, 41)
        Me.Ext.TabIndex = 13
        Me.Ext.Text = "&Exit"
        Me.Ext.UseVisualStyleBackColor = True
        '
        'PrintForm
        '
        Me.PrintForm.DocumentName = "document"
        Me.PrintForm.Form = Me
        Me.PrintForm.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm.PrinterSettings = CType(resources.GetObject("PrintForm.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm.PrintFileName = Nothing
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(490, 440)
        Me.Controls.Add(Me.Ext)
        Me.Controls.Add(Me.Fnt)
        Me.Controls.Add(Me.Print)
        Me.Controls.Add(Me.StartOver)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Color Game"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OrangeBtn As System.Windows.Forms.Button
    Friend WithEvents GrayBtn As System.Windows.Forms.Button
    Friend WithEvents PurpleBtn As System.Windows.Forms.Button
    Friend WithEvents PinkBtn As System.Windows.Forms.Button
    Friend WithEvents BrownBtn As System.Windows.Forms.Button
    Friend WithEvents YellowBtn As System.Windows.Forms.Button
    Friend WithEvents GreenBtn As System.Windows.Forms.Button
    Friend WithEvents BlueBtn As System.Windows.Forms.Button
    Friend WithEvents RedBtn As System.Windows.Forms.Button
    Friend WithEvents StartOver As System.Windows.Forms.Button
    Friend WithEvents Print As System.Windows.Forms.Button
    Friend WithEvents Fnt As System.Windows.Forms.Button
    Friend WithEvents Ext As System.Windows.Forms.Button
    Friend WithEvents FontDialog As System.Windows.Forms.FontDialog
    Friend WithEvents PrintForm As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm

End Class
