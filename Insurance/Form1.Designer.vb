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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.idnumber = New System.Windows.Forms.Label()
        Me.txtidnum = New System.Windows.Forms.TextBox()
        Me.client = New System.Windows.Forms.Label()
        Me.txtclient = New System.Windows.Forms.TextBox()
        Me.policynum = New System.Windows.Forms.Label()
        Me.txtpolicynum = New System.Windows.Forms.TextBox()
        Me.covertype = New System.Windows.Forms.Label()
        Me.insurance = New System.Windows.Forms.Label()
        Me.premiumamt = New System.Windows.Forms.Label()
        Me.txtpremium = New System.Windows.Forms.TextBox()
        Me.taxamt = New System.Windows.Forms.Label()
        Me.txttax = New System.Windows.Forms.TextBox()
        Me.totalamt = New System.Windows.Forms.Label()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btncalculate = New System.Windows.Forms.Button()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.cmbcover = New System.Windows.Forms.ComboBox()
        Me.cmbcompany = New System.Windows.Forms.ComboBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.idnum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cover = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.company = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.premium = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tax = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.iexit = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1307, 64)
        Me.Panel1.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(347, 11)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(518, 39)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Insurance Agency Registration"
        '
        'idnumber
        '
        Me.idnumber.AutoSize = True
        Me.idnumber.Location = New System.Drawing.Point(1059, 116)
        Me.idnumber.Name = "idnumber"
        Me.idnumber.Size = New System.Drawing.Size(56, 13)
        Me.idnumber.TabIndex = 1
        Me.idnumber.Text = "Id Number"
        '
        'txtidnum
        '
        Me.txtidnum.Location = New System.Drawing.Point(1143, 109)
        Me.txtidnum.MaxLength = 8
        Me.txtidnum.Name = "txtidnum"
        Me.txtidnum.Size = New System.Drawing.Size(176, 20)
        Me.txtidnum.TabIndex = 2
        '
        'client
        '
        Me.client.AutoSize = True
        Me.client.Location = New System.Drawing.Point(1059, 165)
        Me.client.Name = "client"
        Me.client.Size = New System.Drawing.Size(33, 13)
        Me.client.TabIndex = 1
        Me.client.Text = "Client"
        '
        'txtclient
        '
        Me.txtclient.Location = New System.Drawing.Point(1143, 158)
        Me.txtclient.MaxLength = 12
        Me.txtclient.Name = "txtclient"
        Me.txtclient.Size = New System.Drawing.Size(176, 20)
        Me.txtclient.TabIndex = 2
        '
        'policynum
        '
        Me.policynum.AutoSize = True
        Me.policynum.Location = New System.Drawing.Point(1059, 212)
        Me.policynum.Name = "policynum"
        Me.policynum.Size = New System.Drawing.Size(75, 13)
        Me.policynum.TabIndex = 1
        Me.policynum.Text = "Policy Number"
        '
        'txtpolicynum
        '
        Me.txtpolicynum.Location = New System.Drawing.Point(1143, 205)
        Me.txtpolicynum.MaxLength = 5
        Me.txtpolicynum.Name = "txtpolicynum"
        Me.txtpolicynum.Size = New System.Drawing.Size(176, 20)
        Me.txtpolicynum.TabIndex = 2
        '
        'covertype
        '
        Me.covertype.AutoSize = True
        Me.covertype.Location = New System.Drawing.Point(1059, 255)
        Me.covertype.Name = "covertype"
        Me.covertype.Size = New System.Drawing.Size(73, 13)
        Me.covertype.TabIndex = 1
        Me.covertype.Text = "Type of cover"
        '
        'insurance
        '
        Me.insurance.AutoSize = True
        Me.insurance.Location = New System.Drawing.Point(1037, 300)
        Me.insurance.Name = "insurance"
        Me.insurance.Size = New System.Drawing.Size(100, 13)
        Me.insurance.TabIndex = 1
        Me.insurance.Text = "Insurance company"
        '
        'premiumamt
        '
        Me.premiumamt.AutoSize = True
        Me.premiumamt.Location = New System.Drawing.Point(1059, 345)
        Me.premiumamt.Name = "premiumamt"
        Me.premiumamt.Size = New System.Drawing.Size(47, 13)
        Me.premiumamt.TabIndex = 1
        Me.premiumamt.Text = "Premium"
        '
        'txtpremium
        '
        Me.txtpremium.Location = New System.Drawing.Point(1143, 338)
        Me.txtpremium.Name = "txtpremium"
        Me.txtpremium.Size = New System.Drawing.Size(176, 20)
        Me.txtpremium.TabIndex = 2
        '
        'taxamt
        '
        Me.taxamt.AutoSize = True
        Me.taxamt.Location = New System.Drawing.Point(1059, 395)
        Me.taxamt.Name = "taxamt"
        Me.taxamt.Size = New System.Drawing.Size(25, 13)
        Me.taxamt.TabIndex = 1
        Me.taxamt.Text = "Tax"
        '
        'txttax
        '
        Me.txttax.Location = New System.Drawing.Point(1143, 388)
        Me.txttax.Name = "txttax"
        Me.txttax.Size = New System.Drawing.Size(176, 20)
        Me.txttax.TabIndex = 2
        '
        'totalamt
        '
        Me.totalamt.AutoSize = True
        Me.totalamt.Location = New System.Drawing.Point(1059, 448)
        Me.totalamt.Name = "totalamt"
        Me.totalamt.Size = New System.Drawing.Size(74, 13)
        Me.totalamt.TabIndex = 1
        Me.totalamt.Text = "Total Premium"
        '
        'txttotal
        '
        Me.txttotal.Location = New System.Drawing.Point(1143, 441)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(176, 20)
        Me.txttotal.TabIndex = 2
        '
        'btnadd
        '
        Me.btnadd.Location = New System.Drawing.Point(1128, 517)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(82, 33)
        Me.btnadd.TabIndex = 3
        Me.btnadd.Text = "Add"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'btnupdate
        '
        Me.btnupdate.Location = New System.Drawing.Point(986, 576)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(82, 31)
        Me.btnupdate.TabIndex = 3
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'btncalculate
        '
        Me.btncalculate.Location = New System.Drawing.Point(986, 517)
        Me.btncalculate.Name = "btncalculate"
        Me.btncalculate.Size = New System.Drawing.Size(82, 33)
        Me.btncalculate.TabIndex = 3
        Me.btncalculate.Text = "Calculate"
        Me.btncalculate.UseVisualStyleBackColor = True
        '
        'btnclear
        '
        Me.btnclear.Location = New System.Drawing.Point(1237, 517)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(82, 33)
        Me.btnclear.TabIndex = 3
        Me.btnclear.Text = "Clear"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'cmbcover
        '
        Me.cmbcover.FormattingEnabled = True
        Me.cmbcover.Location = New System.Drawing.Point(1143, 255)
        Me.cmbcover.Name = "cmbcover"
        Me.cmbcover.Size = New System.Drawing.Size(176, 21)
        Me.cmbcover.TabIndex = 4
        '
        'cmbcompany
        '
        Me.cmbcompany.FormattingEnabled = True
        Me.cmbcompany.Location = New System.Drawing.Point(1143, 292)
        Me.cmbcompany.Name = "cmbcompany"
        Me.cmbcompany.Size = New System.Drawing.Size(176, 21)
        Me.cmbcompany.TabIndex = 4
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(12, 94)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(949, 316)
        Me.ListBox1.TabIndex = 5
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idnum, Me.cname, Me.pnum, Me.cover, Me.company, Me.premium, Me.tax, Me.total})
        Me.DataGridView1.Location = New System.Drawing.Point(68, 448)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(849, 168)
        Me.DataGridView1.TabIndex = 6
        '
        'idnum
        '
        Me.idnum.HeaderText = "ID"
        Me.idnum.Name = "idnum"
        '
        'cname
        '
        Me.cname.HeaderText = "Name"
        Me.cname.Name = "cname"
        '
        'pnum
        '
        Me.pnum.HeaderText = "Policy Num"
        Me.pnum.Name = "pnum"
        '
        'cover
        '
        Me.cover.HeaderText = "Cover"
        Me.cover.Name = "cover"
        '
        'company
        '
        Me.company.HeaderText = "Insurance company"
        Me.company.Name = "company"
        '
        'premium
        '
        Me.premium.HeaderText = "Premium"
        Me.premium.Name = "premium"
        '
        'tax
        '
        Me.tax.HeaderText = "Tax"
        Me.tax.Name = "tax"
        '
        'total
        '
        Me.total.HeaderText = "Total"
        Me.total.Name = "total"
        '
        'iexit
        '
        Me.iexit.Location = New System.Drawing.Point(1237, 577)
        Me.iexit.Name = "iexit"
        Me.iexit.Size = New System.Drawing.Size(82, 29)
        Me.iexit.TabIndex = 3
        Me.iexit.Text = "Exit"
        Me.iexit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1352, 661)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.cmbcompany)
        Me.Controls.Add(Me.cmbcover)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.iexit)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btncalculate)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.totalamt)
        Me.Controls.Add(Me.txttax)
        Me.Controls.Add(Me.taxamt)
        Me.Controls.Add(Me.txtpremium)
        Me.Controls.Add(Me.premiumamt)
        Me.Controls.Add(Me.insurance)
        Me.Controls.Add(Me.covertype)
        Me.Controls.Add(Me.txtpolicynum)
        Me.Controls.Add(Me.policynum)
        Me.Controls.Add(Me.txtclient)
        Me.Controls.Add(Me.client)
        Me.Controls.Add(Me.txtidnum)
        Me.Controls.Add(Me.idnumber)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Insurance"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents idnumber As Label
    Friend WithEvents txtidnum As TextBox
    Friend WithEvents client As Label
    Friend WithEvents txtclient As TextBox
    Friend WithEvents policynum As Label
    Friend WithEvents txtpolicynum As TextBox
    Friend WithEvents covertype As Label
    Friend WithEvents insurance As Label
    Friend WithEvents premiumamt As Label
    Friend WithEvents txtpremium As TextBox
    Friend WithEvents taxamt As Label
    Friend WithEvents txttax As TextBox
    Friend WithEvents totalamt As Label
    Friend WithEvents txttotal As TextBox
    Friend WithEvents btnadd As Button
    Friend WithEvents btnupdate As Button
    Friend WithEvents btncalculate As Button
    Friend WithEvents btnclear As Button
    Friend WithEvents cmbcover As ComboBox
    Friend WithEvents cmbcompany As ComboBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents idnum As DataGridViewTextBoxColumn
    Friend WithEvents cname As DataGridViewTextBoxColumn
    Friend WithEvents pnum As DataGridViewTextBoxColumn
    Friend WithEvents cover As DataGridViewTextBoxColumn
    Friend WithEvents company As DataGridViewTextBoxColumn
    Friend WithEvents premium As DataGridViewTextBoxColumn
    Friend WithEvents tax As DataGridViewTextBoxColumn
    Friend WithEvents total As DataGridViewTextBoxColumn
    Friend WithEvents iexit As Button
End Class
