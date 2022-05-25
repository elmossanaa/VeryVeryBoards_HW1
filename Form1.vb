Public Class Form1

    'VARIABLES ~ CONSTANTS AND PLACEHOLDERS
    Public Const sbWBoots As Integer = 30
    Public Const sbNoBoots As Integer = 20
    Dim totalDaySBWBoots As Integer = 0
    Dim totalDaySBNoBoots As Integer = 0
    Dim noCustomer As Integer = 0
    Dim orange, blue, white, randomColor As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' MessageBox.Show("ENJOY MY APPLICATION :D")

    End Sub

    'Calculate button event
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Check all required text boxes ok
        If (txtName.Text = "" Or txtIDNo.Text = "" Or txtSBWBoots.Text = "" Or txtSBWOBoots.Text = "") Then
            If (txtName.Text = "") Then
                txtName.BackColor = Color.Red
                txtName.Select()
            End If
            If (txtIDNo.Text = "") Then
                txtIDNo.BackColor = Color.Red
                txtIDNo.Select()
            End If
            If (txtSBWOBoots.Text = "") Then
                txtSBWOBoots.BackColor = Color.Red
                txtSBWOBoots.Select()
            End If
            If (txtSBWBoots.Text = "") Then
                txtSBWBoots.BackColor = Color.Red
                txtSBWBoots.Select()
            End If
            MsgBox("Fix Mistakes In Red!!!")
        Else
            txtSBWBoots.BackColor = Color.White
            txtSBWOBoots.BackColor = Color.White
            txtIDNo.BackColor = Color.White
            txtName.BackColor = Color.White
            'Calculate and print
            totalDaySBWBoots += (txtSBWBoots.Text * sbNoBoots)
            totalDaySBNoBoots += (txtSBWOBoots.Text * sbWBoots)
            txtRentalPrice.Text = "$" + ((txtSBWBoots.Text * sbNoBoots) + (txtSBWOBoots.Text * sbWBoots)).ToString()
            ' MessageBox.Show(txtRent.Text.ToString)
            noCustomer += 1
        End If
    End Sub

    'Clear User entry and one time calculation
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtName.Text = ""
        txtIDNo.Text = ""
        txtSBWBoots.Text = ""
        txtSBWOBoots.Text = ""
        txtSBWBoots.Text = ""
        txtSBWOBoots.Text = ""
        txtRentalPrice.Text = ""
        txtName.Select()
    End Sub
    'Focus on first text box
    Private Sub frmSnowboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtName.Select()
    End Sub
    'Print summary
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If String.IsNullOrEmpty(txtRentalPrice.Text) Then
            MessageBox.Show("Credential Error: Calculate your current rental first please !")
        Else
            txtTotalSBWOCost.Text = "$" + totalDaySBWBoots.ToString()
            txtTotalSBWBCost.Text = "$" + totalDaySBNoBoots.ToString()
            txtRentalTotalCost.Text = "$" + (totalDaySBWBoots + totalDaySBNoBoots).ToString()
            txtAvgCost.Text = "$" + ((totalDaySBWBoots + totalDaySBNoBoots) / noCustomer).ToString()
        End If

    End Sub
    'Clear the form data and start fresh
    Private Sub btnClearAll_Click(sender As Object, e As EventArgs) Handles btnClearAll.Click
        txtName.Text = ""
        txtIDNo.Text = ""
        txtSBWBoots.Text = ""
        txtSBWOBoots.Text = ""
        txtSBWBoots.Text = ""
        txtSBWOBoots.Text = ""
        txtRentalPrice.Text = ""
        txtTotalSBWOCost.Text = ""
        txtTotalSBWBCost.Text = ""
        txtRentalTotalCost.Text = ""
        txtAvgCost.Text = ""
        txtName.Select()
        totalDaySBWBoots = 0
        totalDaySBNoBoots = 0
        noCustomer = 0
    End Sub
    'Exit from program
    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Dim result = MessageBox.Show(" Are you sure you want to quit", "Are you sure?", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Me.Close()
        ElseIf result = DialogResult.No Then
            txtName.Select()
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtRentalPrice.TextChanged

    End Sub

    Private Sub FancyBTN_Click(sender As Object, e As EventArgs) Handles fancyBTN.Click
        Timer1.Enabled = True
        Timer1.Start()
        Timer1.Interval = 300
        Me.BackColor = Color.Black

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        orange = Int(Rnd() * 255)
        blue = Int(Rnd() * 255)
        white = Int(Rnd() * 255)
        randomColor = Int(Rnd() * 255)

        ' If (Int((Rnd() * 255 Mod 2)) = 0) Then
        ''  introLabel.ForeColor = Color.Orange
        ' Else
        ' introLabel.ForeColor = Color.Blue
        '  End If
        'introLabel.ForeColor = Color.White

        introLabel.ForeColor = Color.FromArgb(orange, blue, white, randomColor)
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles txtRentalTotalCost.TextChanged

    End Sub
End Class
