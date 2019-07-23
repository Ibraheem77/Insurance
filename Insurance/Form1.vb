Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        cmbcover.Items.Add("Medical")
            cmbcover.Items.Add("Motor")
            cmbcover.Items.Add("business")

            cmbcompany.Items.Add("AIG")
            cmbcompany.Items.Add("Britam")
            cmbcompany.Items.Add("Jubilee")
            cmbcompany.Items.Add("NHIF")
        ListBox1.Items.Add("Id Number" + vbTab + "Client Name" + vbTab + "Policy Number" + vbTab + "Type of cover" + vbTab + vbTab + "Company" + vbTab + vbTab + "Premium" + vbTab + vbTab + "Tax" + vbTab + vbTab + "Total Premium")

    End Sub

    Private Sub btncalculate_Click(sender As Object, e As EventArgs) Handles btncalculate.Click


        Dim idnumber, client As String
        Dim policynum, premiumamt, taxamt As Double

        idnumber = txtidnum.Text
        client = txtclient.Text
        policynum = txtpolicynum.Text
        premiumamt = txtpremium.Text

        taxamt = (0.15 * premiumamt)
        txttax.Text = taxamt

        calculate(taxamt, premiumamt)

    End Sub

    Function calculate(ByVal taxamt As Double, ByVal premiumamt As Double) As Double
        Dim totalamt As Double

        totalamt = taxamt + premiumamt
        txttotal.Text = totalamt

        Return totalamt
    End Function

    Private Sub iexit_Click(sender As Object, e As EventArgs) Handles iexit.Click
        Dim iexit As DialogResult
        iexit = MessageBox.Show("Confirm if you want to exit", "Insurance Agency Registation", MessageBoxButtons.YesNo,
                              MessageBoxIcon.Question)
        If iexit = DialogResult.Yes Then
            Application.Exit()

        End If

    End Sub



    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        ListBox1.Items.Add(txtidnum.Text + vbTab + txtclient.Text + vbTab + vbTab + txtpolicynum.Text + vbTab + vbTab +
                           cmbcover.Text + vbTab + vbTab + vbTab + cmbcompany.Text + vbTab + vbTab + txtpremium.Text + vbTab + vbTab + txttax.Text + vbTab + vbTab + txttotal.Text)
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        DataGridView1.Rows.Add(txtidnum.Text, txtclient.Text, txtpolicynum.Text, cmbcover.Text, cmbcompany.Text,
                               txtpremium.Text, txttax.Text, txttotal.Text)
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        txtidnum.Text = ""
        txtclient.Text = ""
        txtpolicynum.Text = ""
        cmbcover.Text = ""
        cmbcompany.Text = ""
        txtpremium.Text = ""
        txttax.Text = ""
        txttotal.Text = ""
    End Sub

End Class
