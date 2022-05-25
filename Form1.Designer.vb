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
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtAvgCost = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtRentalTotalCost = New System.Windows.Forms.TextBox()
        Me.txtRentalPrice = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTotalSBWBCost = New System.Windows.Forms.TextBox()
        Me.txtTotalSBWOCost = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.btnClearAll = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.txtIDNo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.nameLbl = New System.Windows.Forms.Label()
        Me.txtSBWOBoots = New System.Windows.Forms.TextBox()
        Me.txtSBWBoots = New System.Windows.Forms.TextBox()
        Me.boardRentalBootsLabel = New System.Windows.Forms.Label()
        Me.boardRentalLabel = New System.Windows.Forms.Label()
        Me.introLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Form = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.fancyBTN = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Nirmala UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label9.Location = New System.Drawing.Point(492, 384)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(164, 25)
        Me.Label9.TabIndex = 55
        Me.Label9.Text = "Overall Total Price"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label8.Font = New System.Drawing.Font("Adobe Myungjo Std M", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(242, 106)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(156, 25)
        Me.Label8.TabIndex = 54
        Me.Label8.Text = "Credentials"
        '
        'txtAvgCost
        '
        Me.txtAvgCost.Location = New System.Drawing.Point(678, 413)
        Me.txtAvgCost.Name = "txtAvgCost"
        Me.txtAvgCost.ReadOnly = True
        Me.txtAvgCost.Size = New System.Drawing.Size(100, 20)
        Me.txtAvgCost.TabIndex = 52
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Nirmala UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label3.Location = New System.Drawing.Point(522, 408)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 25)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "Avg Total"
        '
        'txtRentalTotalCost
        '
        Me.txtRentalTotalCost.Location = New System.Drawing.Point(678, 387)
        Me.txtRentalTotalCost.Name = "txtRentalTotalCost"
        Me.txtRentalTotalCost.ReadOnly = True
        Me.txtRentalTotalCost.Size = New System.Drawing.Size(100, 20)
        Me.txtRentalTotalCost.TabIndex = 50
        '
        'txtRentalPrice
        '
        Me.txtRentalPrice.Location = New System.Drawing.Point(299, 256)
        Me.txtRentalPrice.Name = "txtRentalPrice"
        Me.txtRentalPrice.ReadOnly = True
        Me.txtRentalPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtRentalPrice.TabIndex = 49
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Nirmala UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label2.Location = New System.Drawing.Point(116, 252)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(168, 25)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Current Total Price"
        '
        'txtTotalSBWBCost
        '
        Me.txtTotalSBWBCost.Location = New System.Drawing.Point(678, 355)
        Me.txtTotalSBWBCost.Name = "txtTotalSBWBCost"
        Me.txtTotalSBWBCost.ReadOnly = True
        Me.txtTotalSBWBCost.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalSBWBCost.TabIndex = 47
        '
        'txtTotalSBWOCost
        '
        Me.txtTotalSBWOCost.Location = New System.Drawing.Point(678, 329)
        Me.txtTotalSBWOCost.Name = "txtTotalSBWOCost"
        Me.txtTotalSBWOCost.ReadOnly = True
        Me.txtTotalSBWOCost.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalSBWOCost.TabIndex = 46
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Nirmala UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label5.Location = New System.Drawing.Point(418, 355)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(242, 25)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Total Board with Boots Cost"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Nirmala UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label6.Location = New System.Drawing.Point(515, 329)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(149, 25)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "Total Board Cost"
        '
        'cmdExit
        '
        Me.cmdExit.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.cmdExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdExit.Font = New System.Drawing.Font("Minion Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.Location = New System.Drawing.Point(241, 374)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(75, 25)
        Me.cmdExit.TabIndex = 43
        Me.cmdExit.Text = "Exit"
        Me.cmdExit.UseVisualStyleBackColor = False
        '
        'btnClearAll
        '
        Me.btnClearAll.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnClearAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClearAll.Font = New System.Drawing.Font("Minion Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearAll.Location = New System.Drawing.Point(286, 343)
        Me.btnClearAll.Name = "btnClearAll"
        Me.btnClearAll.Size = New System.Drawing.Size(75, 25)
        Me.btnClearAll.TabIndex = 42
        Me.btnClearAll.Text = "Clear all"
        Me.btnClearAll.UseVisualStyleBackColor = False
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPrint.Font = New System.Drawing.Font("Minion Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(201, 343)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 25)
        Me.btnPrint.TabIndex = 41
        Me.btnPrint.Text = "Print Form"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClear.Font = New System.Drawing.Font("Minion Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(286, 309)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 28)
        Me.btnClear.TabIndex = 40
        Me.btnClear.Text = "Clear "
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCalculate.Font = New System.Drawing.Font("Minion Pro", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(201, 309)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 28)
        Me.btnCalculate.TabIndex = 39
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'txtIDNo
        '
        Me.txtIDNo.Location = New System.Drawing.Point(299, 176)
        Me.txtIDNo.Name = "txtIDNo"
        Me.txtIDNo.Size = New System.Drawing.Size(100, 20)
        Me.txtIDNo.TabIndex = 38
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Nirmala UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label4.Location = New System.Drawing.Point(154, 173)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 25)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Driver License"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(299, 150)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 36
        '
        'nameLbl
        '
        Me.nameLbl.AutoSize = True
        Me.nameLbl.Font = New System.Drawing.Font("Nirmala UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameLbl.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.nameLbl.Location = New System.Drawing.Point(187, 147)
        Me.nameLbl.Name = "nameLbl"
        Me.nameLbl.Size = New System.Drawing.Size(97, 25)
        Me.nameLbl.TabIndex = 35
        Me.nameLbl.Text = "Full Name"
        '
        'txtSBWOBoots
        '
        Me.txtSBWOBoots.Location = New System.Drawing.Point(299, 230)
        Me.txtSBWOBoots.Name = "txtSBWOBoots"
        Me.txtSBWOBoots.Size = New System.Drawing.Size(100, 20)
        Me.txtSBWOBoots.TabIndex = 34
        '
        'txtSBWBoots
        '
        Me.txtSBWBoots.Location = New System.Drawing.Point(299, 204)
        Me.txtSBWBoots.Name = "txtSBWBoots"
        Me.txtSBWBoots.Size = New System.Drawing.Size(100, 20)
        Me.txtSBWBoots.TabIndex = 33
        '
        'boardRentalBootsLabel
        '
        Me.boardRentalBootsLabel.AutoSize = True
        Me.boardRentalBootsLabel.Font = New System.Drawing.Font("Nirmala UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boardRentalBootsLabel.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.boardRentalBootsLabel.Location = New System.Drawing.Point(22, 227)
        Me.boardRentalBootsLabel.Name = "boardRentalBootsLabel"
        Me.boardRentalBootsLabel.Size = New System.Drawing.Size(262, 25)
        Me.boardRentalBootsLabel.TabIndex = 32
        Me.boardRentalBootsLabel.Text = "# of Board With Boots Rentals"
        '
        'boardRentalLabel
        '
        Me.boardRentalLabel.AutoSize = True
        Me.boardRentalLabel.Font = New System.Drawing.Font("Nirmala UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boardRentalLabel.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.boardRentalLabel.Location = New System.Drawing.Point(119, 201)
        Me.boardRentalLabel.Name = "boardRentalLabel"
        Me.boardRentalLabel.Size = New System.Drawing.Size(165, 25)
        Me.boardRentalLabel.TabIndex = 31
        Me.boardRentalLabel.Text = "# of Board Rentals"
        '
        'introLabel
        '
        Me.introLabel.AutoSize = True
        Me.introLabel.Font = New System.Drawing.Font("Palatino Linotype", 27.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.introLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.introLabel.Location = New System.Drawing.Point(304, 18)
        Me.introLabel.Name = "introLabel"
        Me.introLabel.Size = New System.Drawing.Size(279, 51)
        Me.introLabel.TabIndex = 30
        Me.introLabel.Text = "Very Very Boards"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(310, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Very Very Boards"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(423, 106)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(355, 170)
        Me.PictureBox1.TabIndex = 56
        Me.PictureBox1.TabStop = False
        '
        'Form
        '
        Me.Form.AutoSize = True
        Me.Form.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Form.Font = New System.Drawing.Font("Adobe Myungjo Std M", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Form.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Form.Location = New System.Drawing.Point(608, 294)
        Me.Form.Name = "Form"
        Me.Form.Size = New System.Drawing.Size(78, 25)
        Me.Form.TabIndex = 57
        Me.Form.Text = "Form"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label7.Font = New System.Drawing.Font("Adobe Myungjo Std M", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(232, 106)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(156, 25)
        Me.Label7.TabIndex = 54
        Me.Label7.Text = "Credentials"
        '
        'Timer1
        '
        '
        'fancyBTN
        '
        Me.fancyBTN.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.fancyBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.fancyBTN.Font = New System.Drawing.Font("Minion Pro", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fancyBTN.Location = New System.Drawing.Point(217, 405)
        Me.fancyBTN.Name = "fancyBTN"
        Me.fancyBTN.Size = New System.Drawing.Size(125, 28)
        Me.fancyBTN.TabIndex = 58
        Me.fancyBTN.Text = "Click For Fun ;D"
        Me.fancyBTN.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.fancyBTN)
        Me.Controls.Add(Me.Form)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtAvgCost)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtRentalTotalCost)
        Me.Controls.Add(Me.txtRentalPrice)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtTotalSBWBCost)
        Me.Controls.Add(Me.txtTotalSBWOCost)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.btnClearAll)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtIDNo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.nameLbl)
        Me.Controls.Add(Me.txtSBWOBoots)
        Me.Controls.Add(Me.txtSBWBoots)
        Me.Controls.Add(Me.boardRentalBootsLabel)
        Me.Controls.Add(Me.boardRentalLabel)
        Me.Controls.Add(Me.introLabel)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtAvgCost As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtRentalTotalCost As TextBox
    Friend WithEvents txtRentalPrice As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTotalSBWBCost As TextBox
    Friend WithEvents txtTotalSBWOCost As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cmdExit As Button
    Friend WithEvents btnClearAll As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnCalculate As Button
    Friend WithEvents txtIDNo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents nameLbl As Label
    Friend WithEvents txtSBWOBoots As TextBox
    Friend WithEvents txtSBWBoots As TextBox
    Friend WithEvents boardRentalBootsLabel As Label
    Friend WithEvents boardRentalLabel As Label
    Friend WithEvents introLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Form As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents fancyBTN As Button
End Class
