<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CaptureCustomer
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
        Me.cell_no = New System.Windows.Forms.TextBox()
        Me.p_Code = New System.Windows.Forms.TextBox()
        Me.town = New System.Windows.Forms.TextBox()
        Me.surname = New System.Windows.Forms.TextBox()
        Me.IDno = New System.Windows.Forms.TextBox()
        Me.P_O_BOX_No = New System.Windows.Forms.TextBox()
        Me.street_name = New System.Windows.Forms.TextBox()
        Me.first_nane = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cell = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Reg_Co_op_Btn = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.tell = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CustomerDS = New Ibutho.CustomerDS()
        Me.CustomerTA = New Ibutho.CustomerDSTableAdapters.CUSTOMERTableAdapter()
        Me.email = New System.Windows.Forms.TextBox()
        Me.email_label = New System.Windows.Forms.Label()
        Me.nationality = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.passport = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.title = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.fax = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.initials = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.designation = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        CType(Me.CustomerDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cell_no
        '
        Me.cell_no.Location = New System.Drawing.Point(548, 181)
        Me.cell_no.Name = "cell_no"
        Me.cell_no.Size = New System.Drawing.Size(393, 20)
        Me.cell_no.TabIndex = 58
        '
        'p_Code
        '
        Me.p_Code.Location = New System.Drawing.Point(548, 394)
        Me.p_Code.Name = "p_Code"
        Me.p_Code.Size = New System.Drawing.Size(393, 20)
        Me.p_Code.TabIndex = 57
        '
        'town
        '
        Me.town.Location = New System.Drawing.Point(548, 352)
        Me.town.Name = "town"
        Me.town.Size = New System.Drawing.Size(393, 20)
        Me.town.TabIndex = 56
        '
        'surname
        '
        Me.surname.Location = New System.Drawing.Point(550, 101)
        Me.surname.Name = "surname"
        Me.surname.Size = New System.Drawing.Size(393, 20)
        Me.surname.TabIndex = 55
        '
        'IDno
        '
        Me.IDno.Location = New System.Drawing.Point(550, 127)
        Me.IDno.Name = "IDno"
        Me.IDno.Size = New System.Drawing.Size(393, 20)
        Me.IDno.TabIndex = 54
        '
        'P_O_BOX_No
        '
        Me.P_O_BOX_No.Location = New System.Drawing.Point(548, 279)
        Me.P_O_BOX_No.Name = "P_O_BOX_No"
        Me.P_O_BOX_No.Size = New System.Drawing.Size(393, 20)
        Me.P_O_BOX_No.TabIndex = 53
        '
        'street_name
        '
        Me.street_name.Location = New System.Drawing.Point(548, 305)
        Me.street_name.Name = "street_name"
        Me.street_name.Size = New System.Drawing.Size(393, 20)
        Me.street_name.TabIndex = 52
        '
        'first_nane
        '
        Me.first_nane.Location = New System.Drawing.Point(550, 75)
        Me.first_nane.Name = "first_nane"
        Me.first_nane.Size = New System.Drawing.Size(393, 20)
        Me.first_nane.TabIndex = 51
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(343, 362)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(73, 13)
        Me.Label13.TabIndex = 50
        Me.Label13.Text = "Town/Surbub"
        '
        'cell
        '
        Me.cell.AutoSize = True
        Me.cell.Location = New System.Drawing.Point(343, 191)
        Me.cell.Name = "cell"
        Me.cell.Size = New System.Drawing.Size(23, 13)
        Me.cell.TabIndex = 49
        Me.cell.Text = "cell"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(341, 394)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 13)
        Me.Label11.TabIndex = 48
        Me.Label11.Text = "Postal Code"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(344, 282)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 13)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "P O Box No"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(345, 104)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "Surname"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(345, 134)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "ID No"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(343, 308)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Street Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(345, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "First Names"
        '
        'Reg_Co_op_Btn
        '
        Me.Reg_Co_op_Btn.Location = New System.Drawing.Point(1111, 485)
        Me.Reg_Co_op_Btn.Name = "Reg_Co_op_Btn"
        Me.Reg_Co_op_Btn.Size = New System.Drawing.Size(117, 23)
        Me.Reg_Co_op_Btn.TabIndex = 59
        Me.Reg_Co_op_Btn.Text = "Register CoOp"
        Me.Reg_Co_op_Btn.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(347, 485)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(117, 23)
        Me.Button2.TabIndex = 60
        Me.Button2.Text = "Register Company"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(548, 485)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(117, 23)
        Me.Button3.TabIndex = 61
        Me.Button3.Text = "Register CSD"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(799, 485)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(117, 23)
        Me.Button4.TabIndex = 62
        Me.Button4.Text = "Register CIDB"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'tell
        '
        Me.tell.Location = New System.Drawing.Point(548, 209)
        Me.tell.Name = "tell"
        Me.tell.Size = New System.Drawing.Size(393, 20)
        Me.tell.TabIndex = 64
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(342, 216)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 13)
        Me.Label3.TabIndex = 63
        Me.Label3.Text = "tell"
        '
        'CustomerDS
        '
        Me.CustomerDS.DataSetName = "CustomerDS"
        Me.CustomerDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomerTA
        '
        Me.CustomerTA.ClearBeforeFill = True
        '
        'email
        '
        Me.email.Location = New System.Drawing.Point(549, 329)
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(393, 20)
        Me.email.TabIndex = 66
        '
        'email_label
        '
        Me.email_label.AutoSize = True
        Me.email_label.Location = New System.Drawing.Point(344, 332)
        Me.email_label.Name = "email_label"
        Me.email_label.Size = New System.Drawing.Size(31, 13)
        Me.email_label.TabIndex = 65
        Me.email_label.Text = "email"
        '
        'nationality
        '
        Me.nationality.Location = New System.Drawing.Point(550, 422)
        Me.nationality.Name = "nationality"
        Me.nationality.Size = New System.Drawing.Size(393, 20)
        Me.nationality.TabIndex = 68
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(343, 422)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 67
        Me.Label4.Text = "nationality"
        '
        'passport
        '
        Me.passport.Location = New System.Drawing.Point(548, 448)
        Me.passport.Name = "passport"
        Me.passport.Size = New System.Drawing.Size(393, 20)
        Me.passport.TabIndex = 70
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(341, 448)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 69
        Me.Label5.Text = "passport no"
        '
        'title
        '
        Me.title.Location = New System.Drawing.Point(550, 12)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(393, 20)
        Me.title.TabIndex = 72
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(343, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(27, 13)
        Me.Label8.TabIndex = 71
        Me.Label8.Text = "Title"
        '
        'fax
        '
        Me.fax.Location = New System.Drawing.Point(549, 246)
        Me.fax.Name = "fax"
        Me.fax.Size = New System.Drawing.Size(393, 20)
        Me.fax.TabIndex = 74
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(342, 246)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(21, 13)
        Me.Label9.TabIndex = 73
        Me.Label9.Text = "fax"
        '
        'initials
        '
        Me.initials.Location = New System.Drawing.Point(550, 47)
        Me.initials.Name = "initials"
        Me.initials.Size = New System.Drawing.Size(393, 20)
        Me.initials.TabIndex = 76
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(343, 54)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(35, 13)
        Me.Label12.TabIndex = 75
        Me.Label12.Text = "initials"
        '
        'designation
        '
        Me.designation.Location = New System.Drawing.Point(547, 159)
        Me.designation.Name = "designation"
        Me.designation.Size = New System.Drawing.Size(393, 20)
        Me.designation.TabIndex = 78
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(340, 159)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(63, 13)
        Me.Label14.TabIndex = 77
        Me.Label14.Text = "Designation"
        '
        'CaptureCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 520)
        Me.Controls.Add(Me.designation)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.initials)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.fax)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.title)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.passport)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.nationality)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.email)
        Me.Controls.Add(Me.email_label)
        Me.Controls.Add(Me.tell)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Reg_Co_op_Btn)
        Me.Controls.Add(Me.cell_no)
        Me.Controls.Add(Me.p_Code)
        Me.Controls.Add(Me.town)
        Me.Controls.Add(Me.surname)
        Me.Controls.Add(Me.IDno)
        Me.Controls.Add(Me.P_O_BOX_No)
        Me.Controls.Add(Me.street_name)
        Me.Controls.Add(Me.first_nane)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.cell)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "CaptureCustomer"
        Me.Text = "CaptureCustomer"
        CType(Me.CustomerDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cell_no As System.Windows.Forms.TextBox
    Friend WithEvents p_Code As System.Windows.Forms.TextBox
    Friend WithEvents town As System.Windows.Forms.TextBox
    Friend WithEvents surname As System.Windows.Forms.TextBox
    Friend WithEvents IDno As System.Windows.Forms.TextBox
    Friend WithEvents P_O_BOX_No As System.Windows.Forms.TextBox
    Friend WithEvents street_name As System.Windows.Forms.TextBox
    Friend WithEvents first_nane As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cell As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Reg_Co_op_Btn As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents tell As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CustomerDS As Ibutho.CustomerDS
    Friend WithEvents CustomerTA As Ibutho.CustomerDSTableAdapters.CUSTOMERTableAdapter
    Friend WithEvents email As System.Windows.Forms.TextBox
    Friend WithEvents email_label As System.Windows.Forms.Label
    Friend WithEvents nationality As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents passport As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents title As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents fax As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents initials As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents designation As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
End Class
