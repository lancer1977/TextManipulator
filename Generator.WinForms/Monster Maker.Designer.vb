<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Monster_Maker
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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.cmbSize = New System.Windows.Forms.ComboBox()
        Me.cmbEnemyType = New System.Windows.Forms.ComboBox()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NumericUpDown3 = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NumericUpDown4 = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NumericUpDown5 = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.NumericUpDown6 = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.NumericUpDown7 = New System.Windows.Forms.NumericUpDown()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.NumericUpDown8 = New System.Windows.Forms.NumericUpDown()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.NumericUpDown9 = New System.Windows.Forms.NumericUpDown()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.NumericUpDown10 = New System.Windows.Forms.NumericUpDown()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.NumericUpDown11 = New System.Windows.Forms.NumericUpDown()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.NumericUpDown12 = New System.Windows.Forms.NumericUpDown()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown12, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Chaotic Evil", "Chaotic Good", "Chaotic Neutral", "Neutral Good", "True Neutral", "Neutral Evil", "Lawful Evil", "Lawful Neutral", "Lawful Good"})
        Me.ComboBox1.Location = New System.Drawing.Point(12, 12)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(102, 21)
        Me.ComboBox1.TabIndex = 0
        Me.ComboBox1.Text = "Alignment"
        '
        'cmbSize
        '
        Me.cmbSize.FormattingEnabled = True
        Me.cmbSize.Items.AddRange(New Object() {"Colossal", "Diminutive", "Gargantuan", "Huge", "Large", "Medium", "Small", "Tiny"})
        Me.cmbSize.Location = New System.Drawing.Point(12, 39)
        Me.cmbSize.Name = "cmbSize"
        Me.cmbSize.Size = New System.Drawing.Size(102, 21)
        Me.cmbSize.Sorted = True
        Me.cmbSize.TabIndex = 71
        Me.cmbSize.Text = "Size"
        '
        'cmbEnemyType
        '
        Me.cmbEnemyType.FormattingEnabled = True
        Me.cmbEnemyType.Items.AddRange(New Object() {"Aberration", "Animal", "Construct", "Dragon", "Fey", "Humanoid (aquatic)", "Humanoid (dwarf)", "Humanoid (elf)", "Humanoid (giant)", "Humanoid (gnoll)", "Humanoid (gnome)", "Humanoid (goblinoid)", "Humanoid (halfling)", "Humanoid (human)", "Humanoid (orc)", "Humanoid (other subtype)", "Humanoid (reptilian)", "Magical beast", "Monstrous humanoid", "Ooze", "Outsider (air)", "Outsider (chaotic)", "Outsider (earth)", "Outsider (evil)", "Outsider (fire)", "Outsider (good)", "Outsider (lawful)", "Outsider (native)", "Outsider (water)", "Plant", "Undead", "Vermin"})
        Me.cmbEnemyType.Location = New System.Drawing.Point(11, 66)
        Me.cmbEnemyType.Name = "cmbEnemyType"
        Me.cmbEnemyType.Size = New System.Drawing.Size(103, 21)
        Me.cmbEnemyType.TabIndex = 104
        Me.cmbEnemyType.Text = "Type"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(12, 94)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(102, 20)
        Me.NumericUpDown1.TabIndex = 105
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Low-Light", "Darkvision", "Normal"})
        Me.ComboBox2.Location = New System.Drawing.Point(12, 121)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(101, 21)
        Me.ComboBox2.TabIndex = 106
        Me.ComboBox2.Text = "Vision"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(136, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 107
        Me.Label1.Text = "Init Mod"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(135, 154)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 13)
        Me.Label2.TabIndex = 109
        Me.Label2.Text = "Natural AC or other"
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.Location = New System.Drawing.Point(11, 148)
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(102, 20)
        Me.NumericUpDown2.TabIndex = 108
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(135, 180)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 13)
        Me.Label3.TabIndex = 111
        Me.Label3.Text = "HD"
        '
        'NumericUpDown3
        '
        Me.NumericUpDown3.Location = New System.Drawing.Point(11, 174)
        Me.NumericUpDown3.Name = "NumericUpDown3"
        Me.NumericUpDown3.Size = New System.Drawing.Size(102, 20)
        Me.NumericUpDown3.TabIndex = 110
        Me.NumericUpDown3.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(136, 206)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(22, 13)
        Me.Label4.TabIndex = 113
        Me.Label4.Text = "SR"
        '
        'NumericUpDown4
        '
        Me.NumericUpDown4.Location = New System.Drawing.Point(12, 200)
        Me.NumericUpDown4.Name = "NumericUpDown4"
        Me.NumericUpDown4.Size = New System.Drawing.Size(102, 20)
        Me.NumericUpDown4.TabIndex = 112
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(136, 232)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 115
        Me.Label5.Text = "Speed"
        '
        'NumericUpDown5
        '
        Me.NumericUpDown5.Location = New System.Drawing.Point(12, 226)
        Me.NumericUpDown5.Name = "NumericUpDown5"
        Me.NumericUpDown5.Size = New System.Drawing.Size(102, 20)
        Me.NumericUpDown5.TabIndex = 114
        Me.NumericUpDown5.Value = New Decimal(New Integer() {30, 0, 0, 0})
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(135, 283)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(20, 13)
        Me.Label6.TabIndex = 117
        Me.Label6.Text = "Str"
        '
        'NumericUpDown6
        '
        Me.NumericUpDown6.Location = New System.Drawing.Point(11, 277)
        Me.NumericUpDown6.Name = "NumericUpDown6"
        Me.NumericUpDown6.Size = New System.Drawing.Size(102, 20)
        Me.NumericUpDown6.TabIndex = 116
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(136, 309)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(26, 13)
        Me.Label7.TabIndex = 119
        Me.Label7.Text = "Dex"
        '
        'NumericUpDown7
        '
        Me.NumericUpDown7.Location = New System.Drawing.Point(12, 303)
        Me.NumericUpDown7.Name = "NumericUpDown7"
        Me.NumericUpDown7.Size = New System.Drawing.Size(102, 20)
        Me.NumericUpDown7.TabIndex = 118
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(11, 251)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(102, 20)
        Me.TextBox1.TabIndex = 120
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(136, 254)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(146, 13)
        Me.Label8.TabIndex = 121
        Me.Label8.Text = "Attack String (seperate with ,)"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(135, 358)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(19, 13)
        Me.Label9.TabIndex = 125
        Me.Label9.Text = "Int"
        '
        'NumericUpDown8
        '
        Me.NumericUpDown8.Location = New System.Drawing.Point(11, 352)
        Me.NumericUpDown8.Name = "NumericUpDown8"
        Me.NumericUpDown8.Size = New System.Drawing.Size(102, 20)
        Me.NumericUpDown8.TabIndex = 124
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(134, 332)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(26, 13)
        Me.Label10.TabIndex = 123
        Me.Label10.Text = "Con"
        '
        'NumericUpDown9
        '
        Me.NumericUpDown9.Location = New System.Drawing.Point(10, 326)
        Me.NumericUpDown9.Name = "NumericUpDown9"
        Me.NumericUpDown9.Size = New System.Drawing.Size(102, 20)
        Me.NumericUpDown9.TabIndex = 122
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(136, 405)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(26, 13)
        Me.Label11.TabIndex = 129
        Me.Label11.Text = "Cha"
        '
        'NumericUpDown10
        '
        Me.NumericUpDown10.Location = New System.Drawing.Point(12, 399)
        Me.NumericUpDown10.Name = "NumericUpDown10"
        Me.NumericUpDown10.Size = New System.Drawing.Size(102, 20)
        Me.NumericUpDown10.TabIndex = 128
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(135, 379)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(25, 13)
        Me.Label12.TabIndex = 127
        Me.Label12.Text = "Wis"
        '
        'NumericUpDown11
        '
        Me.NumericUpDown11.Location = New System.Drawing.Point(11, 373)
        Me.NumericUpDown11.Name = "NumericUpDown11"
        Me.NumericUpDown11.Size = New System.Drawing.Size(102, 20)
        Me.NumericUpDown11.TabIndex = 126
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(136, 427)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(121, 13)
        Me.Label13.TabIndex = 131
        Me.Label13.Text = "Skill@Num#Skill@Num "
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(11, 424)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(102, 20)
        Me.TextBox2.TabIndex = 130
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(136, 454)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(64, 13)
        Me.Label14.TabIndex = 133
        Me.Label14.Text = "Note@Note"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(11, 451)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(102, 20)
        Me.TextBox3.TabIndex = 132
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(134, 483)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(71, 13)
        Me.Label15.TabIndex = 135
        Me.Label15.Text = "Attack Bonus"
        '
        'NumericUpDown12
        '
        Me.NumericUpDown12.Location = New System.Drawing.Point(10, 477)
        Me.NumericUpDown12.Name = "NumericUpDown12"
        Me.NumericUpDown12.Size = New System.Drawing.Size(102, 20)
        Me.NumericUpDown12.TabIndex = 134
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(137, 512)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(60, 13)
        Me.Label16.TabIndex = 137
        Me.Label16.Text = "Feat@Feat"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(12, 509)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(102, 20)
        Me.TextBox4.TabIndex = 136
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(307, 9)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 138
        Me.Button1.Text = "Clipboard"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(307, 55)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(102, 20)
        Me.TextBox5.TabIndex = 139
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(237, 58)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(35, 13)
        Me.Label17.TabIndex = 140
        Me.Label17.Text = "Name"
        '
        'Monster_Maker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(446, 541)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.NumericUpDown12)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.NumericUpDown10)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.NumericUpDown11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.NumericUpDown8)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.NumericUpDown9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.NumericUpDown7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.NumericUpDown6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.NumericUpDown5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.NumericUpDown4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.NumericUpDown3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.NumericUpDown2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.cmbEnemyType)
        Me.Controls.Add(Me.cmbSize)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "Monster_Maker"
        Me.Text = "Monster_Maker"
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown12, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Public WithEvents cmbSize As System.Windows.Forms.ComboBox
    Public WithEvents cmbEnemyType As System.Windows.Forms.ComboBox
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown3 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown4 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown5 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown6 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown7 As System.Windows.Forms.NumericUpDown
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown8 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown9 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown10 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown11 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown12 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
End Class
