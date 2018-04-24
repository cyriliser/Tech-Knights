<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register
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
        Dim CustomerIDLabel As System.Windows.Forms.Label
        Dim FirstNameLabel As System.Windows.Forms.Label
        Dim LastNameLabel As System.Windows.Forms.Label
        Dim PhysicalAddressLabel As System.Windows.Forms.Label
        Dim EmailAddressLabel As System.Windows.Forms.Label
        Dim TellLabel As System.Windows.Forms.Label
        Dim CellLabel As System.Windows.Forms.Label
        Dim BalanceLabel As System.Windows.Forms.Label
        Dim NationalityLabel As System.Windows.Forms.Label
        Dim PassPortNumberLabel As System.Windows.Forms.Label
        Dim DesignitionLabel As System.Windows.Forms.Label
        Dim FaxLabel As System.Windows.Forms.Label
        Dim TittleLabel As System.Windows.Forms.Label
        Dim InitialsLabel As System.Windows.Forms.Label
        Me.Group4DataSet = New ISTN3AS_PROJECT.group4DataSet()
        Me.CUSTOMERBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CUSTOMERTableAdapter = New ISTN3AS_PROJECT.group4DataSetTableAdapters.CUSTOMERTableAdapter()
        Me.TableAdapterManager = New ISTN3AS_PROJECT.group4DataSetTableAdapters.TableAdapterManager()
        Me.CustomerIDTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.PhysicalAddressTextBox = New System.Windows.Forms.TextBox()
        Me.EmailAddressTextBox = New System.Windows.Forms.TextBox()
        Me.TellTextBox = New System.Windows.Forms.TextBox()
        Me.CellTextBox = New System.Windows.Forms.TextBox()
        Me.BalanceTextBox = New System.Windows.Forms.TextBox()
        Me.NationalityTextBox = New System.Windows.Forms.TextBox()
        Me.PassPortNumberTextBox = New System.Windows.Forms.TextBox()
        Me.DesignitionTextBox = New System.Windows.Forms.TextBox()
        Me.FaxTextBox = New System.Windows.Forms.TextBox()
        Me.TittleTextBox = New System.Windows.Forms.TextBox()
        Me.InitialsTextBox = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CustomerIDLabel = New System.Windows.Forms.Label()
        FirstNameLabel = New System.Windows.Forms.Label()
        LastNameLabel = New System.Windows.Forms.Label()
        PhysicalAddressLabel = New System.Windows.Forms.Label()
        EmailAddressLabel = New System.Windows.Forms.Label()
        TellLabel = New System.Windows.Forms.Label()
        CellLabel = New System.Windows.Forms.Label()
        BalanceLabel = New System.Windows.Forms.Label()
        NationalityLabel = New System.Windows.Forms.Label()
        PassPortNumberLabel = New System.Windows.Forms.Label()
        DesignitionLabel = New System.Windows.Forms.Label()
        FaxLabel = New System.Windows.Forms.Label()
        TittleLabel = New System.Windows.Forms.Label()
        InitialsLabel = New System.Windows.Forms.Label()
        CType(Me.Group4DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CUSTOMERBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Group4DataSet
        '
        Me.Group4DataSet.DataSetName = "group4DataSet"
        Me.Group4DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CUSTOMERBindingSource
        '
        Me.CUSTOMERBindingSource.DataMember = "CUSTOMER"
        Me.CUSTOMERBindingSource.DataSource = Me.Group4DataSet
        '
        'CUSTOMERTableAdapter
        '
        Me.CUSTOMERTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CUSTOMERTableAdapter = Me.CUSTOMERTableAdapter
        Me.TableAdapterManager.UpdateOrder = ISTN3AS_PROJECT.group4DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CustomerIDLabel
        '
        CustomerIDLabel.AutoSize = True
        CustomerIDLabel.BackColor = System.Drawing.Color.Transparent
        CustomerIDLabel.Location = New System.Drawing.Point(56, 63)
        CustomerIDLabel.Name = "CustomerIDLabel"
        CustomerIDLabel.Size = New System.Drawing.Size(93, 20)
        CustomerIDLabel.TabIndex = 4
        CustomerIDLabel.Text = "Customer ID:"
        '
        'CustomerIDTextBox
        '
        Me.CustomerIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERBindingSource, "CustomerID", True))
        Me.CustomerIDTextBox.Location = New System.Drawing.Point(243, 60)
        Me.CustomerIDTextBox.Name = "CustomerIDTextBox"
        Me.CustomerIDTextBox.Size = New System.Drawing.Size(271, 27)
        Me.CustomerIDTextBox.TabIndex = 5
        '
        'FirstNameLabel
        '
        FirstNameLabel.AutoSize = True
        FirstNameLabel.BackColor = System.Drawing.Color.Transparent
        FirstNameLabel.Location = New System.Drawing.Point(56, 96)
        FirstNameLabel.Name = "FirstNameLabel"
        FirstNameLabel.Size = New System.Drawing.Size(81, 20)
        FirstNameLabel.TabIndex = 6
        FirstNameLabel.Text = "First Name:"
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERBindingSource, "FirstName", True))
        Me.FirstNameTextBox.Location = New System.Drawing.Point(243, 93)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(271, 27)
        Me.FirstNameTextBox.TabIndex = 7
        '
        'LastNameLabel
        '
        LastNameLabel.AutoSize = True
        LastNameLabel.BackColor = System.Drawing.Color.Transparent
        LastNameLabel.Location = New System.Drawing.Point(56, 129)
        LastNameLabel.Name = "LastNameLabel"
        LastNameLabel.Size = New System.Drawing.Size(79, 20)
        LastNameLabel.TabIndex = 8
        LastNameLabel.Text = "Last Name:"
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERBindingSource, "LastName", True))
        Me.LastNameTextBox.Location = New System.Drawing.Point(243, 126)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(271, 27)
        Me.LastNameTextBox.TabIndex = 9
        '
        'PhysicalAddressLabel
        '
        PhysicalAddressLabel.AutoSize = True
        PhysicalAddressLabel.BackColor = System.Drawing.Color.Transparent
        PhysicalAddressLabel.Location = New System.Drawing.Point(56, 162)
        PhysicalAddressLabel.Name = "PhysicalAddressLabel"
        PhysicalAddressLabel.Size = New System.Drawing.Size(123, 20)
        PhysicalAddressLabel.TabIndex = 10
        PhysicalAddressLabel.Text = "Physical Address:"
        '
        'PhysicalAddressTextBox
        '
        Me.PhysicalAddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERBindingSource, "PhysicalAddress", True))
        Me.PhysicalAddressTextBox.Location = New System.Drawing.Point(243, 159)
        Me.PhysicalAddressTextBox.Name = "PhysicalAddressTextBox"
        Me.PhysicalAddressTextBox.Size = New System.Drawing.Size(271, 27)
        Me.PhysicalAddressTextBox.TabIndex = 11
        '
        'EmailAddressLabel
        '
        EmailAddressLabel.AutoSize = True
        EmailAddressLabel.BackColor = System.Drawing.Color.Transparent
        EmailAddressLabel.Location = New System.Drawing.Point(56, 195)
        EmailAddressLabel.Name = "EmailAddressLabel"
        EmailAddressLabel.Size = New System.Drawing.Size(103, 20)
        EmailAddressLabel.TabIndex = 12
        EmailAddressLabel.Text = "Email Address:"
        '
        'EmailAddressTextBox
        '
        Me.EmailAddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERBindingSource, "EmailAddress", True))
        Me.EmailAddressTextBox.Location = New System.Drawing.Point(243, 192)
        Me.EmailAddressTextBox.Name = "EmailAddressTextBox"
        Me.EmailAddressTextBox.Size = New System.Drawing.Size(271, 27)
        Me.EmailAddressTextBox.TabIndex = 13
        '
        'TellLabel
        '
        TellLabel.AutoSize = True
        TellLabel.BackColor = System.Drawing.Color.Transparent
        TellLabel.Location = New System.Drawing.Point(56, 228)
        TellLabel.Name = "TellLabel"
        TellLabel.Size = New System.Drawing.Size(34, 20)
        TellLabel.TabIndex = 14
        TellLabel.Text = "Tell:"
        '
        'TellTextBox
        '
        Me.TellTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERBindingSource, "Tell", True))
        Me.TellTextBox.Location = New System.Drawing.Point(243, 225)
        Me.TellTextBox.Name = "TellTextBox"
        Me.TellTextBox.Size = New System.Drawing.Size(271, 27)
        Me.TellTextBox.TabIndex = 15
        '
        'CellLabel
        '
        CellLabel.AutoSize = True
        CellLabel.BackColor = System.Drawing.Color.Transparent
        CellLabel.Location = New System.Drawing.Point(56, 261)
        CellLabel.Name = "CellLabel"
        CellLabel.Size = New System.Drawing.Size(37, 20)
        CellLabel.TabIndex = 16
        CellLabel.Text = "Cell:"
        '
        'CellTextBox
        '
        Me.CellTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERBindingSource, "Cell", True))
        Me.CellTextBox.Location = New System.Drawing.Point(243, 258)
        Me.CellTextBox.Name = "CellTextBox"
        Me.CellTextBox.Size = New System.Drawing.Size(271, 27)
        Me.CellTextBox.TabIndex = 17
        '
        'BalanceLabel
        '
        BalanceLabel.AutoSize = True
        BalanceLabel.BackColor = System.Drawing.Color.Transparent
        BalanceLabel.Location = New System.Drawing.Point(56, 294)
        BalanceLabel.Name = "BalanceLabel"
        BalanceLabel.Size = New System.Drawing.Size(65, 20)
        BalanceLabel.TabIndex = 18
        BalanceLabel.Text = "Balance:"
        '
        'BalanceTextBox
        '
        Me.BalanceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERBindingSource, "Balance", True))
        Me.BalanceTextBox.Location = New System.Drawing.Point(243, 291)
        Me.BalanceTextBox.Name = "BalanceTextBox"
        Me.BalanceTextBox.Size = New System.Drawing.Size(271, 27)
        Me.BalanceTextBox.TabIndex = 19
        '
        'NationalityLabel
        '
        NationalityLabel.AutoSize = True
        NationalityLabel.BackColor = System.Drawing.Color.Transparent
        NationalityLabel.Location = New System.Drawing.Point(56, 327)
        NationalityLabel.Name = "NationalityLabel"
        NationalityLabel.Size = New System.Drawing.Size(82, 20)
        NationalityLabel.TabIndex = 20
        NationalityLabel.Text = "Nationality:"
        '
        'NationalityTextBox
        '
        Me.NationalityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERBindingSource, "Nationality", True))
        Me.NationalityTextBox.Location = New System.Drawing.Point(243, 324)
        Me.NationalityTextBox.Name = "NationalityTextBox"
        Me.NationalityTextBox.Size = New System.Drawing.Size(271, 27)
        Me.NationalityTextBox.TabIndex = 21
        '
        'PassPortNumberLabel
        '
        PassPortNumberLabel.AutoSize = True
        PassPortNumberLabel.BackColor = System.Drawing.Color.Transparent
        PassPortNumberLabel.Location = New System.Drawing.Point(56, 357)
        PassPortNumberLabel.Name = "PassPortNumberLabel"
        PassPortNumberLabel.Size = New System.Drawing.Size(125, 20)
        PassPortNumberLabel.TabIndex = 22
        PassPortNumberLabel.Text = "PassPort Number:"
        '
        'PassPortNumberTextBox
        '
        Me.PassPortNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERBindingSource, "PassPortNumber", True))
        Me.PassPortNumberTextBox.Location = New System.Drawing.Point(243, 357)
        Me.PassPortNumberTextBox.Name = "PassPortNumberTextBox"
        Me.PassPortNumberTextBox.Size = New System.Drawing.Size(271, 27)
        Me.PassPortNumberTextBox.TabIndex = 23
        '
        'DesignitionLabel
        '
        DesignitionLabel.AutoSize = True
        DesignitionLabel.BackColor = System.Drawing.Color.Transparent
        DesignitionLabel.Location = New System.Drawing.Point(56, 393)
        DesignitionLabel.Name = "DesignitionLabel"
        DesignitionLabel.Size = New System.Drawing.Size(86, 20)
        DesignitionLabel.TabIndex = 24
        DesignitionLabel.Text = "Designition:"
        '
        'DesignitionTextBox
        '
        Me.DesignitionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERBindingSource, "Designition", True))
        Me.DesignitionTextBox.Location = New System.Drawing.Point(243, 390)
        Me.DesignitionTextBox.Name = "DesignitionTextBox"
        Me.DesignitionTextBox.Size = New System.Drawing.Size(271, 27)
        Me.DesignitionTextBox.TabIndex = 25
        '
        'FaxLabel
        '
        FaxLabel.AutoSize = True
        FaxLabel.BackColor = System.Drawing.Color.Transparent
        FaxLabel.Location = New System.Drawing.Point(56, 426)
        FaxLabel.Name = "FaxLabel"
        FaxLabel.Size = New System.Drawing.Size(32, 20)
        FaxLabel.TabIndex = 26
        FaxLabel.Text = "Fax:"
        '
        'FaxTextBox
        '
        Me.FaxTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERBindingSource, "Fax", True))
        Me.FaxTextBox.Location = New System.Drawing.Point(243, 423)
        Me.FaxTextBox.Name = "FaxTextBox"
        Me.FaxTextBox.Size = New System.Drawing.Size(271, 27)
        Me.FaxTextBox.TabIndex = 27
        '
        'TittleLabel
        '
        TittleLabel.AutoSize = True
        TittleLabel.BackColor = System.Drawing.Color.Transparent
        TittleLabel.Location = New System.Drawing.Point(56, 459)
        TittleLabel.Name = "TittleLabel"
        TittleLabel.Size = New System.Drawing.Size(45, 20)
        TittleLabel.TabIndex = 28
        TittleLabel.Text = "Tittle:"
        '
        'TittleTextBox
        '
        Me.TittleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERBindingSource, "Tittle", True))
        Me.TittleTextBox.Location = New System.Drawing.Point(243, 456)
        Me.TittleTextBox.Name = "TittleTextBox"
        Me.TittleTextBox.Size = New System.Drawing.Size(271, 27)
        Me.TittleTextBox.TabIndex = 29
        '
        'InitialsLabel
        '
        InitialsLabel.AutoSize = True
        InitialsLabel.BackColor = System.Drawing.Color.Transparent
        InitialsLabel.Location = New System.Drawing.Point(56, 492)
        InitialsLabel.Name = "InitialsLabel"
        InitialsLabel.Size = New System.Drawing.Size(58, 20)
        InitialsLabel.TabIndex = 30
        InitialsLabel.Text = "Initials:"
        '
        'InitialsTextBox
        '
        Me.InitialsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CUSTOMERBindingSource, "Initials", True))
        Me.InitialsTextBox.Location = New System.Drawing.Point(243, 489)
        Me.InitialsTextBox.Name = "InitialsTextBox"
        Me.InitialsTextBox.Size = New System.Drawing.Size(271, 27)
        Me.InitialsTextBox.TabIndex = 31
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.ISTN3AS_PROJECT.My.Resources.Resources.corporate_background_blue
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Location = New System.Drawing.Point(667, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 541)
        Me.Panel1.TabIndex = 32
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(48, 455)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(109, 38)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(48, 403)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(109, 38)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Next"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Impact", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(54, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(241, 36)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Register Customer."
        '
        'Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ISTN3AS_PROJECT.My.Resources.Resources._02_BLUE
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(866, 543)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(CustomerIDLabel)
        Me.Controls.Add(Me.CustomerIDTextBox)
        Me.Controls.Add(FirstNameLabel)
        Me.Controls.Add(Me.FirstNameTextBox)
        Me.Controls.Add(LastNameLabel)
        Me.Controls.Add(Me.LastNameTextBox)
        Me.Controls.Add(PhysicalAddressLabel)
        Me.Controls.Add(Me.PhysicalAddressTextBox)
        Me.Controls.Add(EmailAddressLabel)
        Me.Controls.Add(Me.EmailAddressTextBox)
        Me.Controls.Add(TellLabel)
        Me.Controls.Add(Me.TellTextBox)
        Me.Controls.Add(CellLabel)
        Me.Controls.Add(Me.CellTextBox)
        Me.Controls.Add(BalanceLabel)
        Me.Controls.Add(Me.BalanceTextBox)
        Me.Controls.Add(NationalityLabel)
        Me.Controls.Add(Me.NationalityTextBox)
        Me.Controls.Add(PassPortNumberLabel)
        Me.Controls.Add(Me.PassPortNumberTextBox)
        Me.Controls.Add(DesignitionLabel)
        Me.Controls.Add(Me.DesignitionTextBox)
        Me.Controls.Add(FaxLabel)
        Me.Controls.Add(Me.FaxTextBox)
        Me.Controls.Add(TittleLabel)
        Me.Controls.Add(Me.TittleTextBox)
        Me.Controls.Add(InitialsLabel)
        Me.Controls.Add(Me.InitialsTextBox)
        Me.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Register"
        Me.Text = "Register"
        CType(Me.Group4DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CUSTOMERBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Group4DataSet As ISTN3AS_PROJECT.group4DataSet
    Friend WithEvents CUSTOMERBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CUSTOMERTableAdapter As ISTN3AS_PROJECT.group4DataSetTableAdapters.CUSTOMERTableAdapter
    Friend WithEvents TableAdapterManager As ISTN3AS_PROJECT.group4DataSetTableAdapters.TableAdapterManager
    Friend WithEvents CustomerIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FirstNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LastNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PhysicalAddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmailAddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TellTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CellTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BalanceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NationalityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PassPortNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DesignitionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FaxTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TittleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents InitialsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
