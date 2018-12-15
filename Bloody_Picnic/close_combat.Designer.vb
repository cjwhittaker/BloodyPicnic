<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class close_combat
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
        Me.Player = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.att_entrenched = New System.Windows.Forms.CheckBox()
        Me.att_cover_options = New System.Windows.Forms.GroupBox()
        Me.ac1 = New System.Windows.Forms.RadioButton()
        Me.ac4 = New System.Windows.Forms.RadioButton()
        Me.ac3 = New System.Windows.Forms.RadioButton()
        Me.ac2 = New System.Windows.Forms.RadioButton()
        Me.att_cav_dis = New System.Windows.Forms.CheckBox()
        Me.att_supp_options = New System.Windows.Forms.GroupBox()
        Me.asu1 = New System.Windows.Forms.RadioButton()
        Me.asu2 = New System.Windows.Forms.RadioButton()
        Me.att_cav = New System.Windows.Forms.CheckBox()
        Me.att_size_options = New System.Windows.Forms.GroupBox()
        Me.as5 = New System.Windows.Forms.RadioButton()
        Me.as4 = New System.Windows.Forms.RadioButton()
        Me.as3 = New System.Windows.Forms.RadioButton()
        Me.as2 = New System.Windows.Forms.RadioButton()
        Me.as1 = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.att_quality_options = New System.Windows.Forms.GroupBox()
        Me.aq1 = New System.Windows.Forms.RadioButton()
        Me.aq4 = New System.Windows.Forms.RadioButton()
        Me.aq3 = New System.Windows.Forms.RadioButton()
        Me.aq2 = New System.Windows.Forms.RadioButton()
        Me.att_support_options = New System.Windows.Forms.GroupBox()
        Me.asp1 = New System.Windows.Forms.RadioButton()
        Me.asp3 = New System.Windows.Forms.RadioButton()
        Me.asp2 = New System.Windows.Forms.RadioButton()
        Me.att_strength = New System.Windows.Forms.Label()
        Me.dec_att = New System.Windows.Forms.Button()
        Me.inc_att = New System.Windows.Forms.Button()
        Me.defender = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.def_flank = New System.Windows.Forms.CheckBox()
        Me.def_morale = New System.Windows.Forms.Button()
        Me.def_cav_dis = New System.Windows.Forms.CheckBox()
        Me.def_cav = New System.Windows.Forms.CheckBox()
        Me.def_supp_options = New System.Windows.Forms.GroupBox()
        Me.dsu1 = New System.Windows.Forms.RadioButton()
        Me.dsu3 = New System.Windows.Forms.RadioButton()
        Me.dsu2 = New System.Windows.Forms.RadioButton()
        Me.def_support_options = New System.Windows.Forms.GroupBox()
        Me.dsp1 = New System.Windows.Forms.RadioButton()
        Me.dsp3 = New System.Windows.Forms.RadioButton()
        Me.dsp2 = New System.Windows.Forms.RadioButton()
        Me.dec_def = New System.Windows.Forms.Button()
        Me.def_quality_options = New System.Windows.Forms.GroupBox()
        Me.dq1 = New System.Windows.Forms.RadioButton()
        Me.dq4 = New System.Windows.Forms.RadioButton()
        Me.dq3 = New System.Windows.Forms.RadioButton()
        Me.dq2 = New System.Windows.Forms.RadioButton()
        Me.def_cover_options = New System.Windows.Forms.GroupBox()
        Me.dc1 = New System.Windows.Forms.RadioButton()
        Me.dc4 = New System.Windows.Forms.RadioButton()
        Me.dc3 = New System.Windows.Forms.RadioButton()
        Me.dc2 = New System.Windows.Forms.RadioButton()
        Me.def_size_options = New System.Windows.Forms.GroupBox()
        Me.ds5 = New System.Windows.Forms.RadioButton()
        Me.ds4 = New System.Windows.Forms.RadioButton()
        Me.ds3 = New System.Windows.Forms.RadioButton()
        Me.ds2 = New System.Windows.Forms.RadioButton()
        Me.ds1 = New System.Windows.Forms.RadioButton()
        Me.inc_def = New System.Windows.Forms.Button()
        Me.def_entrenched = New System.Windows.Forms.CheckBox()
        Me.def_strength = New System.Windows.Forms.Label()
        Me.strength = New System.Windows.Forms.Label()
        Me.attacker = New System.Windows.Forms.Label()
        Me.Reset = New System.Windows.Forms.Button()
        Me.fight = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nextphase = New System.Windows.Forms.Button()
        Me.reverse = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.att_cover_options.SuspendLayout()
        Me.att_supp_options.SuspendLayout()
        Me.att_size_options.SuspendLayout()
        Me.att_quality_options.SuspendLayout()
        Me.att_support_options.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.def_supp_options.SuspendLayout()
        Me.def_support_options.SuspendLayout()
        Me.def_quality_options.SuspendLayout()
        Me.def_cover_options.SuspendLayout()
        Me.def_size_options.SuspendLayout()
        Me.SuspendLayout()
        '
        'Player
        '
        Me.Player.BackColor = System.Drawing.Color.Transparent
        Me.Player.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Player.Location = New System.Drawing.Point(95, 9)
        Me.Player.MinimumSize = New System.Drawing.Size(300, 0)
        Me.Player.Name = "Player"
        Me.Player.Size = New System.Drawing.Size(500, 31)
        Me.Player.TabIndex = 11
        Me.Player.Text = "Label1"
        Me.Player.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.att_entrenched)
        Me.Panel2.Controls.Add(Me.att_cover_options)
        Me.Panel2.Controls.Add(Me.att_cav_dis)
        Me.Panel2.Controls.Add(Me.att_supp_options)
        Me.Panel2.Controls.Add(Me.att_cav)
        Me.Panel2.Controls.Add(Me.att_size_options)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.att_quality_options)
        Me.Panel2.Controls.Add(Me.att_support_options)
        Me.Panel2.Controls.Add(Me.att_strength)
        Me.Panel2.Controls.Add(Me.dec_att)
        Me.Panel2.Controls.Add(Me.inc_att)
        Me.Panel2.Location = New System.Drawing.Point(12, 66)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(300, 507)
        Me.Panel2.TabIndex = 64
        '
        'att_entrenched
        '
        Me.att_entrenched.Appearance = System.Windows.Forms.Appearance.Button
        Me.att_entrenched.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.att_entrenched.Location = New System.Drawing.Point(24, 155)
        Me.att_entrenched.Name = "att_entrenched"
        Me.att_entrenched.Size = New System.Drawing.Size(249, 31)
        Me.att_entrenched.TabIndex = 72
        Me.att_entrenched.Text = "Entrenched"
        Me.att_entrenched.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.att_entrenched.UseVisualStyleBackColor = True
        '
        'att_cover_options
        '
        Me.att_cover_options.Controls.Add(Me.ac1)
        Me.att_cover_options.Controls.Add(Me.ac4)
        Me.att_cover_options.Controls.Add(Me.ac3)
        Me.att_cover_options.Controls.Add(Me.ac2)
        Me.att_cover_options.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.att_cover_options.Location = New System.Drawing.Point(16, 101)
        Me.att_cover_options.Margin = New System.Windows.Forms.Padding(0)
        Me.att_cover_options.Name = "att_cover_options"
        Me.att_cover_options.Padding = New System.Windows.Forms.Padding(0)
        Me.att_cover_options.Size = New System.Drawing.Size(269, 48)
        Me.att_cover_options.TabIndex = 63
        Me.att_cover_options.TabStop = False
        Me.att_cover_options.Text = "Cover"
        '
        'ac1
        '
        Me.ac1.Appearance = System.Windows.Forms.Appearance.Button
        Me.ac1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ac1.Location = New System.Drawing.Point(8, 13)
        Me.ac1.Name = "ac1"
        Me.ac1.Size = New System.Drawing.Size(60, 31)
        Me.ac1.TabIndex = 53
        Me.ac1.TabStop = True
        Me.ac1.Tag = "0"
        Me.ac1.Text = "0"
        Me.ac1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ac1.UseVisualStyleBackColor = True
        '
        'ac4
        '
        Me.ac4.Appearance = System.Windows.Forms.Appearance.Button
        Me.ac4.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ac4.Location = New System.Drawing.Point(197, 13)
        Me.ac4.Name = "ac4"
        Me.ac4.Size = New System.Drawing.Size(60, 31)
        Me.ac4.TabIndex = 52
        Me.ac4.TabStop = True
        Me.ac4.Tag = "4"
        Me.ac4.Text = "3"
        Me.ac4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ac4.UseVisualStyleBackColor = True
        '
        'ac3
        '
        Me.ac3.Appearance = System.Windows.Forms.Appearance.Button
        Me.ac3.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ac3.Location = New System.Drawing.Point(134, 13)
        Me.ac3.Name = "ac3"
        Me.ac3.Size = New System.Drawing.Size(60, 31)
        Me.ac3.TabIndex = 51
        Me.ac3.TabStop = True
        Me.ac3.Tag = "2"
        Me.ac3.Text = "2"
        Me.ac3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ac3.UseVisualStyleBackColor = True
        '
        'ac2
        '
        Me.ac2.Appearance = System.Windows.Forms.Appearance.Button
        Me.ac2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ac2.Location = New System.Drawing.Point(71, 13)
        Me.ac2.Name = "ac2"
        Me.ac2.Size = New System.Drawing.Size(60, 31)
        Me.ac2.TabIndex = 49
        Me.ac2.TabStop = True
        Me.ac2.Tag = "1"
        Me.ac2.Text = "1"
        Me.ac2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ac2.UseVisualStyleBackColor = True
        '
        'att_cav_dis
        '
        Me.att_cav_dis.Appearance = System.Windows.Forms.Appearance.Button
        Me.att_cav_dis.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.att_cav_dis.Location = New System.Drawing.Point(23, 465)
        Me.att_cav_dis.Name = "att_cav_dis"
        Me.att_cav_dis.Size = New System.Drawing.Size(250, 31)
        Me.att_cav_dis.TabIndex = 69
        Me.att_cav_dis.TabStop = False
        Me.att_cav_dis.Tag = "-2"
        Me.att_cav_dis.Text = "Cavalry Disadvantaged"
        Me.att_cav_dis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.att_cav_dis.UseVisualStyleBackColor = True
        '
        'att_supp_options
        '
        Me.att_supp_options.Controls.Add(Me.asu1)
        Me.att_supp_options.Controls.Add(Me.asu2)
        Me.att_supp_options.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.att_supp_options.Location = New System.Drawing.Point(16, 246)
        Me.att_supp_options.Margin = New System.Windows.Forms.Padding(0)
        Me.att_supp_options.Name = "att_supp_options"
        Me.att_supp_options.Padding = New System.Windows.Forms.Padding(0)
        Me.att_supp_options.Size = New System.Drawing.Size(269, 48)
        Me.att_supp_options.TabIndex = 63
        Me.att_supp_options.TabStop = False
        Me.att_supp_options.Text = "Suppression"
        '
        'asu1
        '
        Me.asu1.Appearance = System.Windows.Forms.Appearance.Button
        Me.asu1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.asu1.Location = New System.Drawing.Point(7, 14)
        Me.asu1.Name = "asu1"
        Me.asu1.Size = New System.Drawing.Size(120, 31)
        Me.asu1.TabIndex = 53
        Me.asu1.TabStop = True
        Me.asu1.Tag = "0"
        Me.asu1.Text = "None"
        Me.asu1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.asu1.UseVisualStyleBackColor = True
        '
        'asu2
        '
        Me.asu2.Appearance = System.Windows.Forms.Appearance.Button
        Me.asu2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.asu2.Location = New System.Drawing.Point(140, 14)
        Me.asu2.Name = "asu2"
        Me.asu2.Size = New System.Drawing.Size(117, 31)
        Me.asu2.TabIndex = 51
        Me.asu2.TabStop = True
        Me.asu2.Tag = "-1"
        Me.asu2.Text = "Partial"
        Me.asu2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.asu2.UseVisualStyleBackColor = True
        '
        'att_cav
        '
        Me.att_cav.Appearance = System.Windows.Forms.Appearance.Button
        Me.att_cav.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.att_cav.Location = New System.Drawing.Point(23, 428)
        Me.att_cav.Name = "att_cav"
        Me.att_cav.Size = New System.Drawing.Size(250, 31)
        Me.att_cav.TabIndex = 68
        Me.att_cav.Tag = "0"
        Me.att_cav.Text = "Cavalry"
        Me.att_cav.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.att_cav.UseVisualStyleBackColor = True
        '
        'att_size_options
        '
        Me.att_size_options.Controls.Add(Me.as5)
        Me.att_size_options.Controls.Add(Me.as4)
        Me.att_size_options.Controls.Add(Me.as3)
        Me.att_size_options.Controls.Add(Me.as2)
        Me.att_size_options.Controls.Add(Me.as1)
        Me.att_size_options.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.att_size_options.Location = New System.Drawing.Point(16, 192)
        Me.att_size_options.Margin = New System.Windows.Forms.Padding(0)
        Me.att_size_options.Name = "att_size_options"
        Me.att_size_options.Padding = New System.Windows.Forms.Padding(0)
        Me.att_size_options.Size = New System.Drawing.Size(269, 48)
        Me.att_size_options.TabIndex = 62
        Me.att_size_options.TabStop = False
        Me.att_size_options.Text = "Element Size"
        '
        'as5
        '
        Me.as5.Appearance = System.Windows.Forms.Appearance.Button
        Me.as5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.as5.Location = New System.Drawing.Point(211, 12)
        Me.as5.Name = "as5"
        Me.as5.Size = New System.Drawing.Size(46, 31)
        Me.as5.TabIndex = 53
        Me.as5.Tag = "2"
        Me.as5.Text = "400"
        Me.as5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.as5.UseVisualStyleBackColor = True
        '
        'as4
        '
        Me.as4.Appearance = System.Windows.Forms.Appearance.Button
        Me.as4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.as4.Location = New System.Drawing.Point(160, 12)
        Me.as4.Name = "as4"
        Me.as4.Size = New System.Drawing.Size(46, 31)
        Me.as4.TabIndex = 52
        Me.as4.Tag = "1"
        Me.as4.Text = "300"
        Me.as4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.as4.UseVisualStyleBackColor = True
        '
        'as3
        '
        Me.as3.Appearance = System.Windows.Forms.Appearance.Button
        Me.as3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.as3.Location = New System.Drawing.Point(109, 12)
        Me.as3.Name = "as3"
        Me.as3.Size = New System.Drawing.Size(46, 31)
        Me.as3.TabIndex = 51
        Me.as3.Tag = "0"
        Me.as3.Text = "250"
        Me.as3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.as3.UseVisualStyleBackColor = True
        '
        'as2
        '
        Me.as2.Appearance = System.Windows.Forms.Appearance.Button
        Me.as2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.as2.Location = New System.Drawing.Point(58, 12)
        Me.as2.Name = "as2"
        Me.as2.Size = New System.Drawing.Size(46, 31)
        Me.as2.TabIndex = 50
        Me.as2.Tag = "-1"
        Me.as2.Text = "200"
        Me.as2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.as2.UseVisualStyleBackColor = True
        '
        'as1
        '
        Me.as1.Appearance = System.Windows.Forms.Appearance.Button
        Me.as1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.as1.Location = New System.Drawing.Point(7, 12)
        Me.as1.Name = "as1"
        Me.as1.Size = New System.Drawing.Size(46, 31)
        Me.as1.TabIndex = 49
        Me.as1.Tag = "-2"
        Me.as1.Text = "100"
        Me.as1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.as1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(37, 300)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 31)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "Strength"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'att_quality_options
        '
        Me.att_quality_options.Controls.Add(Me.aq1)
        Me.att_quality_options.Controls.Add(Me.aq4)
        Me.att_quality_options.Controls.Add(Me.aq3)
        Me.att_quality_options.Controls.Add(Me.aq2)
        Me.att_quality_options.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.att_quality_options.Location = New System.Drawing.Point(16, 47)
        Me.att_quality_options.Margin = New System.Windows.Forms.Padding(0)
        Me.att_quality_options.Name = "att_quality_options"
        Me.att_quality_options.Padding = New System.Windows.Forms.Padding(0)
        Me.att_quality_options.Size = New System.Drawing.Size(269, 48)
        Me.att_quality_options.TabIndex = 62
        Me.att_quality_options.TabStop = False
        Me.att_quality_options.Text = "Quality"
        '
        'aq1
        '
        Me.aq1.AccessibleName = "Militia"
        Me.aq1.Appearance = System.Windows.Forms.Appearance.Button
        Me.aq1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aq1.Location = New System.Drawing.Point(8, 13)
        Me.aq1.Name = "aq1"
        Me.aq1.Size = New System.Drawing.Size(60, 31)
        Me.aq1.TabIndex = 53
        Me.aq1.TabStop = True
        Me.aq1.Tag = "8"
        Me.aq1.Text = "Mil"
        Me.aq1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.aq1.UseVisualStyleBackColor = True
        '
        'aq4
        '
        Me.aq4.AccessibleName = "Veteran"
        Me.aq4.Appearance = System.Windows.Forms.Appearance.Button
        Me.aq4.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aq4.Location = New System.Drawing.Point(197, 13)
        Me.aq4.Name = "aq4"
        Me.aq4.Size = New System.Drawing.Size(60, 31)
        Me.aq4.TabIndex = 52
        Me.aq4.TabStop = True
        Me.aq4.Tag = "5"
        Me.aq4.Text = "Vet"
        Me.aq4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.aq4.UseVisualStyleBackColor = True
        '
        'aq3
        '
        Me.aq3.AccessibleName = "Regular"
        Me.aq3.Appearance = System.Windows.Forms.Appearance.Button
        Me.aq3.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aq3.Location = New System.Drawing.Point(134, 13)
        Me.aq3.Name = "aq3"
        Me.aq3.Size = New System.Drawing.Size(60, 31)
        Me.aq3.TabIndex = 51
        Me.aq3.TabStop = True
        Me.aq3.Tag = "6"
        Me.aq3.Text = "Reg"
        Me.aq3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.aq3.UseVisualStyleBackColor = True
        '
        'aq2
        '
        Me.aq2.AccessibleName = "Reservist"
        Me.aq2.Appearance = System.Windows.Forms.Appearance.Button
        Me.aq2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aq2.Location = New System.Drawing.Point(71, 13)
        Me.aq2.Name = "aq2"
        Me.aq2.Size = New System.Drawing.Size(60, 31)
        Me.aq2.TabIndex = 49
        Me.aq2.TabStop = True
        Me.aq2.Tag = "7"
        Me.aq2.Text = "Res"
        Me.aq2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.aq2.UseVisualStyleBackColor = True
        '
        'att_support_options
        '
        Me.att_support_options.Controls.Add(Me.asp1)
        Me.att_support_options.Controls.Add(Me.asp3)
        Me.att_support_options.Controls.Add(Me.asp2)
        Me.att_support_options.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.att_support_options.Location = New System.Drawing.Point(16, 337)
        Me.att_support_options.Margin = New System.Windows.Forms.Padding(0)
        Me.att_support_options.Name = "att_support_options"
        Me.att_support_options.Padding = New System.Windows.Forms.Padding(0)
        Me.att_support_options.Size = New System.Drawing.Size(269, 48)
        Me.att_support_options.TabIndex = 62
        Me.att_support_options.TabStop = False
        Me.att_support_options.Text = "Supports"
        '
        'asp1
        '
        Me.asp1.Appearance = System.Windows.Forms.Appearance.Button
        Me.asp1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.asp1.Location = New System.Drawing.Point(7, 14)
        Me.asp1.Name = "asp1"
        Me.asp1.Size = New System.Drawing.Size(80, 31)
        Me.asp1.TabIndex = 53
        Me.asp1.TabStop = True
        Me.asp1.Tag = "0"
        Me.asp1.Text = "None"
        Me.asp1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.asp1.UseVisualStyleBackColor = True
        '
        'asp3
        '
        Me.asp3.Appearance = System.Windows.Forms.Appearance.Button
        Me.asp3.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.asp3.Location = New System.Drawing.Point(177, 14)
        Me.asp3.Name = "asp3"
        Me.asp3.Size = New System.Drawing.Size(80, 31)
        Me.asp3.TabIndex = 52
        Me.asp3.TabStop = True
        Me.asp3.Tag = "1"
        Me.asp3.Text = "<200m"
        Me.asp3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.asp3.UseVisualStyleBackColor = True
        '
        'asp2
        '
        Me.asp2.Appearance = System.Windows.Forms.Appearance.Button
        Me.asp2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.asp2.Location = New System.Drawing.Point(92, 14)
        Me.asp2.Name = "asp2"
        Me.asp2.Size = New System.Drawing.Size(80, 31)
        Me.asp2.TabIndex = 51
        Me.asp2.TabStop = True
        Me.asp2.Tag = "3"
        Me.asp2.Text = "Behind"
        Me.asp2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.asp2.UseVisualStyleBackColor = True
        '
        'att_strength
        '
        Me.att_strength.BackColor = System.Drawing.Color.White
        Me.att_strength.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.att_strength.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.att_strength.Location = New System.Drawing.Point(163, 302)
        Me.att_strength.Name = "att_strength"
        Me.att_strength.Size = New System.Drawing.Size(63, 31)
        Me.att_strength.TabIndex = 64
        Me.att_strength.Text = "0"
        Me.att_strength.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dec_att
        '
        Me.dec_att.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dec_att.Location = New System.Drawing.Point(126, 302)
        Me.dec_att.Name = "dec_att"
        Me.dec_att.Size = New System.Drawing.Size(31, 31)
        Me.dec_att.TabIndex = 66
        Me.dec_att.Text = "<"
        Me.dec_att.UseVisualStyleBackColor = True
        '
        'inc_att
        '
        Me.inc_att.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inc_att.Location = New System.Drawing.Point(233, 302)
        Me.inc_att.Name = "inc_att"
        Me.inc_att.Size = New System.Drawing.Size(31, 31)
        Me.inc_att.TabIndex = 65
        Me.inc_att.Text = ">"
        Me.inc_att.UseVisualStyleBackColor = True
        '
        'defender
        '
        Me.defender.BackColor = System.Drawing.Color.Transparent
        Me.defender.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.defender.Location = New System.Drawing.Point(432, 39)
        Me.defender.Name = "defender"
        Me.defender.Size = New System.Drawing.Size(98, 23)
        Me.defender.TabIndex = 61
        Me.defender.Text = "Defender"
        Me.defender.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.def_flank)
        Me.Panel1.Controls.Add(Me.def_morale)
        Me.Panel1.Controls.Add(Me.def_cav_dis)
        Me.Panel1.Controls.Add(Me.def_cav)
        Me.Panel1.Controls.Add(Me.def_supp_options)
        Me.Panel1.Controls.Add(Me.def_support_options)
        Me.Panel1.Controls.Add(Me.dec_def)
        Me.Panel1.Controls.Add(Me.def_quality_options)
        Me.Panel1.Controls.Add(Me.def_cover_options)
        Me.Panel1.Controls.Add(Me.def_size_options)
        Me.Panel1.Controls.Add(Me.inc_def)
        Me.Panel1.Controls.Add(Me.def_entrenched)
        Me.Panel1.Controls.Add(Me.def_strength)
        Me.Panel1.Controls.Add(Me.strength)
        Me.Panel1.Location = New System.Drawing.Point(371, 66)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(300, 507)
        Me.Panel1.TabIndex = 63
        '
        'def_flank
        '
        Me.def_flank.Appearance = System.Windows.Forms.Appearance.Button
        Me.def_flank.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.def_flank.Location = New System.Drawing.Point(23, 391)
        Me.def_flank.Name = "def_flank"
        Me.def_flank.Size = New System.Drawing.Size(249, 31)
        Me.def_flank.TabIndex = 71
        Me.def_flank.Tag = "-2"
        Me.def_flank.Text = "Attacked in Flank or Rear"
        Me.def_flank.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.def_flank.UseVisualStyleBackColor = True
        '
        'def_morale
        '
        Me.def_morale.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.def_morale.Location = New System.Drawing.Point(23, 12)
        Me.def_morale.Name = "def_morale"
        Me.def_morale.Size = New System.Drawing.Size(249, 29)
        Me.def_morale.TabIndex = 70
        Me.def_morale.Text = "Test Morale"
        Me.def_morale.UseVisualStyleBackColor = True
        '
        'def_cav_dis
        '
        Me.def_cav_dis.Appearance = System.Windows.Forms.Appearance.Button
        Me.def_cav_dis.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.def_cav_dis.Location = New System.Drawing.Point(23, 465)
        Me.def_cav_dis.Name = "def_cav_dis"
        Me.def_cav_dis.Size = New System.Drawing.Size(249, 31)
        Me.def_cav_dis.TabIndex = 69
        Me.def_cav_dis.TabStop = False
        Me.def_cav_dis.Tag = "-2"
        Me.def_cav_dis.Text = "Cavalry Disadvantaged"
        Me.def_cav_dis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.def_cav_dis.UseVisualStyleBackColor = True
        '
        'def_cav
        '
        Me.def_cav.Appearance = System.Windows.Forms.Appearance.Button
        Me.def_cav.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.def_cav.Location = New System.Drawing.Point(23, 428)
        Me.def_cav.Name = "def_cav"
        Me.def_cav.Size = New System.Drawing.Size(249, 31)
        Me.def_cav.TabIndex = 68
        Me.def_cav.Tag = "0"
        Me.def_cav.Text = "Cavalry"
        Me.def_cav.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.def_cav.UseVisualStyleBackColor = True
        '
        'def_supp_options
        '
        Me.def_supp_options.Controls.Add(Me.dsu1)
        Me.def_supp_options.Controls.Add(Me.dsu3)
        Me.def_supp_options.Controls.Add(Me.dsu2)
        Me.def_supp_options.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.def_supp_options.Location = New System.Drawing.Point(15, 246)
        Me.def_supp_options.Margin = New System.Windows.Forms.Padding(0)
        Me.def_supp_options.Name = "def_supp_options"
        Me.def_supp_options.Padding = New System.Windows.Forms.Padding(0)
        Me.def_supp_options.Size = New System.Drawing.Size(269, 48)
        Me.def_supp_options.TabIndex = 62
        Me.def_supp_options.TabStop = False
        Me.def_supp_options.Text = "Suppression"
        '
        'dsu1
        '
        Me.dsu1.Appearance = System.Windows.Forms.Appearance.Button
        Me.dsu1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dsu1.Location = New System.Drawing.Point(7, 14)
        Me.dsu1.Name = "dsu1"
        Me.dsu1.Size = New System.Drawing.Size(80, 31)
        Me.dsu1.TabIndex = 53
        Me.dsu1.TabStop = True
        Me.dsu1.Tag = "0"
        Me.dsu1.Text = "None"
        Me.dsu1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.dsu1.UseVisualStyleBackColor = True
        '
        'dsu3
        '
        Me.dsu3.Appearance = System.Windows.Forms.Appearance.Button
        Me.dsu3.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dsu3.Location = New System.Drawing.Point(177, 14)
        Me.dsu3.Name = "dsu3"
        Me.dsu3.Size = New System.Drawing.Size(80, 31)
        Me.dsu3.TabIndex = 52
        Me.dsu3.TabStop = True
        Me.dsu3.Tag = "-4"
        Me.dsu3.Text = "Full"
        Me.dsu3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.dsu3.UseVisualStyleBackColor = True
        '
        'dsu2
        '
        Me.dsu2.Appearance = System.Windows.Forms.Appearance.Button
        Me.dsu2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dsu2.Location = New System.Drawing.Point(92, 14)
        Me.dsu2.Name = "dsu2"
        Me.dsu2.Size = New System.Drawing.Size(80, 31)
        Me.dsu2.TabIndex = 51
        Me.dsu2.TabStop = True
        Me.dsu2.Tag = "-1"
        Me.dsu2.Text = "Partial"
        Me.dsu2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.dsu2.UseVisualStyleBackColor = True
        '
        'def_support_options
        '
        Me.def_support_options.Controls.Add(Me.dsp1)
        Me.def_support_options.Controls.Add(Me.dsp3)
        Me.def_support_options.Controls.Add(Me.dsp2)
        Me.def_support_options.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.def_support_options.Location = New System.Drawing.Point(15, 337)
        Me.def_support_options.Margin = New System.Windows.Forms.Padding(0)
        Me.def_support_options.Name = "def_support_options"
        Me.def_support_options.Padding = New System.Windows.Forms.Padding(0)
        Me.def_support_options.Size = New System.Drawing.Size(269, 48)
        Me.def_support_options.TabIndex = 62
        Me.def_support_options.TabStop = False
        Me.def_support_options.Text = "Supports"
        '
        'dsp1
        '
        Me.dsp1.Appearance = System.Windows.Forms.Appearance.Button
        Me.dsp1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dsp1.Location = New System.Drawing.Point(7, 14)
        Me.dsp1.Name = "dsp1"
        Me.dsp1.Size = New System.Drawing.Size(80, 31)
        Me.dsp1.TabIndex = 53
        Me.dsp1.TabStop = True
        Me.dsp1.Tag = "0"
        Me.dsp1.Text = "None"
        Me.dsp1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.dsp1.UseVisualStyleBackColor = True
        '
        'dsp3
        '
        Me.dsp3.Appearance = System.Windows.Forms.Appearance.Button
        Me.dsp3.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dsp3.Location = New System.Drawing.Point(177, 14)
        Me.dsp3.Name = "dsp3"
        Me.dsp3.Size = New System.Drawing.Size(80, 31)
        Me.dsp3.TabIndex = 52
        Me.dsp3.TabStop = True
        Me.dsp3.Tag = "1"
        Me.dsp3.Text = "<200m"
        Me.dsp3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.dsp3.UseVisualStyleBackColor = True
        '
        'dsp2
        '
        Me.dsp2.Appearance = System.Windows.Forms.Appearance.Button
        Me.dsp2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dsp2.Location = New System.Drawing.Point(92, 14)
        Me.dsp2.Name = "dsp2"
        Me.dsp2.Size = New System.Drawing.Size(80, 31)
        Me.dsp2.TabIndex = 51
        Me.dsp2.TabStop = True
        Me.dsp2.Tag = "3"
        Me.dsp2.Text = "Behind"
        Me.dsp2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.dsp2.UseVisualStyleBackColor = True
        '
        'dec_def
        '
        Me.dec_def.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dec_def.Location = New System.Drawing.Point(121, 300)
        Me.dec_def.Name = "dec_def"
        Me.dec_def.Size = New System.Drawing.Size(31, 31)
        Me.dec_def.TabIndex = 66
        Me.dec_def.Text = "<"
        Me.dec_def.UseVisualStyleBackColor = True
        '
        'def_quality_options
        '
        Me.def_quality_options.Controls.Add(Me.dq1)
        Me.def_quality_options.Controls.Add(Me.dq4)
        Me.def_quality_options.Controls.Add(Me.dq3)
        Me.def_quality_options.Controls.Add(Me.dq2)
        Me.def_quality_options.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.def_quality_options.Location = New System.Drawing.Point(15, 47)
        Me.def_quality_options.Margin = New System.Windows.Forms.Padding(0)
        Me.def_quality_options.Name = "def_quality_options"
        Me.def_quality_options.Padding = New System.Windows.Forms.Padding(0)
        Me.def_quality_options.Size = New System.Drawing.Size(269, 48)
        Me.def_quality_options.TabIndex = 62
        Me.def_quality_options.TabStop = False
        Me.def_quality_options.Text = "Quality"
        '
        'dq1
        '
        Me.dq1.AccessibleName = "Militia"
        Me.dq1.Appearance = System.Windows.Forms.Appearance.Button
        Me.dq1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dq1.Location = New System.Drawing.Point(8, 13)
        Me.dq1.Name = "dq1"
        Me.dq1.Size = New System.Drawing.Size(60, 31)
        Me.dq1.TabIndex = 53
        Me.dq1.TabStop = True
        Me.dq1.Tag = "8"
        Me.dq1.Text = "Mil"
        Me.dq1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.dq1.UseVisualStyleBackColor = True
        '
        'dq4
        '
        Me.dq4.AccessibleName = "Veteran"
        Me.dq4.Appearance = System.Windows.Forms.Appearance.Button
        Me.dq4.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dq4.Location = New System.Drawing.Point(197, 13)
        Me.dq4.Name = "dq4"
        Me.dq4.Size = New System.Drawing.Size(60, 31)
        Me.dq4.TabIndex = 52
        Me.dq4.TabStop = True
        Me.dq4.Tag = "5"
        Me.dq4.Text = "Vet"
        Me.dq4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.dq4.UseVisualStyleBackColor = True
        '
        'dq3
        '
        Me.dq3.AccessibleName = "Regular"
        Me.dq3.Appearance = System.Windows.Forms.Appearance.Button
        Me.dq3.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dq3.Location = New System.Drawing.Point(134, 13)
        Me.dq3.Name = "dq3"
        Me.dq3.Size = New System.Drawing.Size(60, 31)
        Me.dq3.TabIndex = 51
        Me.dq3.TabStop = True
        Me.dq3.Tag = "6"
        Me.dq3.Text = "Reg"
        Me.dq3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.dq3.UseVisualStyleBackColor = True
        '
        'dq2
        '
        Me.dq2.AccessibleName = "Reservist"
        Me.dq2.Appearance = System.Windows.Forms.Appearance.Button
        Me.dq2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dq2.Location = New System.Drawing.Point(71, 13)
        Me.dq2.Name = "dq2"
        Me.dq2.Size = New System.Drawing.Size(60, 31)
        Me.dq2.TabIndex = 49
        Me.dq2.TabStop = True
        Me.dq2.Tag = "7"
        Me.dq2.Text = "Res"
        Me.dq2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.dq2.UseVisualStyleBackColor = True
        '
        'def_cover_options
        '
        Me.def_cover_options.Controls.Add(Me.dc1)
        Me.def_cover_options.Controls.Add(Me.dc4)
        Me.def_cover_options.Controls.Add(Me.dc3)
        Me.def_cover_options.Controls.Add(Me.dc2)
        Me.def_cover_options.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.def_cover_options.Location = New System.Drawing.Point(15, 101)
        Me.def_cover_options.Margin = New System.Windows.Forms.Padding(0)
        Me.def_cover_options.Name = "def_cover_options"
        Me.def_cover_options.Padding = New System.Windows.Forms.Padding(0)
        Me.def_cover_options.Size = New System.Drawing.Size(269, 48)
        Me.def_cover_options.TabIndex = 62
        Me.def_cover_options.TabStop = False
        Me.def_cover_options.Text = "Cover"
        '
        'dc1
        '
        Me.dc1.Appearance = System.Windows.Forms.Appearance.Button
        Me.dc1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dc1.Location = New System.Drawing.Point(8, 13)
        Me.dc1.Name = "dc1"
        Me.dc1.Size = New System.Drawing.Size(60, 31)
        Me.dc1.TabIndex = 53
        Me.dc1.TabStop = True
        Me.dc1.Tag = "0"
        Me.dc1.Text = "0"
        Me.dc1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.dc1.UseVisualStyleBackColor = True
        '
        'dc4
        '
        Me.dc4.Appearance = System.Windows.Forms.Appearance.Button
        Me.dc4.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dc4.Location = New System.Drawing.Point(197, 13)
        Me.dc4.Name = "dc4"
        Me.dc4.Size = New System.Drawing.Size(60, 31)
        Me.dc4.TabIndex = 52
        Me.dc4.TabStop = True
        Me.dc4.Tag = "4"
        Me.dc4.Text = "3"
        Me.dc4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.dc4.UseVisualStyleBackColor = True
        '
        'dc3
        '
        Me.dc3.Appearance = System.Windows.Forms.Appearance.Button
        Me.dc3.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dc3.Location = New System.Drawing.Point(134, 13)
        Me.dc3.Name = "dc3"
        Me.dc3.Size = New System.Drawing.Size(60, 31)
        Me.dc3.TabIndex = 51
        Me.dc3.TabStop = True
        Me.dc3.Tag = "2"
        Me.dc3.Text = "2"
        Me.dc3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.dc3.UseVisualStyleBackColor = True
        '
        'dc2
        '
        Me.dc2.Appearance = System.Windows.Forms.Appearance.Button
        Me.dc2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dc2.Location = New System.Drawing.Point(71, 13)
        Me.dc2.Name = "dc2"
        Me.dc2.Size = New System.Drawing.Size(60, 31)
        Me.dc2.TabIndex = 49
        Me.dc2.TabStop = True
        Me.dc2.Tag = "1"
        Me.dc2.Text = "1"
        Me.dc2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.dc2.UseVisualStyleBackColor = True
        '
        'def_size_options
        '
        Me.def_size_options.Controls.Add(Me.ds5)
        Me.def_size_options.Controls.Add(Me.ds4)
        Me.def_size_options.Controls.Add(Me.ds3)
        Me.def_size_options.Controls.Add(Me.ds2)
        Me.def_size_options.Controls.Add(Me.ds1)
        Me.def_size_options.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.def_size_options.Location = New System.Drawing.Point(15, 192)
        Me.def_size_options.Margin = New System.Windows.Forms.Padding(0)
        Me.def_size_options.Name = "def_size_options"
        Me.def_size_options.Padding = New System.Windows.Forms.Padding(0)
        Me.def_size_options.Size = New System.Drawing.Size(269, 48)
        Me.def_size_options.TabIndex = 62
        Me.def_size_options.TabStop = False
        Me.def_size_options.Text = "Element Size"
        '
        'ds5
        '
        Me.ds5.Appearance = System.Windows.Forms.Appearance.Button
        Me.ds5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ds5.Location = New System.Drawing.Point(211, 12)
        Me.ds5.Name = "ds5"
        Me.ds5.Size = New System.Drawing.Size(46, 31)
        Me.ds5.TabIndex = 53
        Me.ds5.Tag = "2"
        Me.ds5.Text = "400"
        Me.ds5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ds5.UseVisualStyleBackColor = True
        '
        'ds4
        '
        Me.ds4.Appearance = System.Windows.Forms.Appearance.Button
        Me.ds4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ds4.Location = New System.Drawing.Point(160, 12)
        Me.ds4.Name = "ds4"
        Me.ds4.Size = New System.Drawing.Size(46, 31)
        Me.ds4.TabIndex = 52
        Me.ds4.Tag = "1"
        Me.ds4.Text = "300"
        Me.ds4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ds4.UseVisualStyleBackColor = True
        '
        'ds3
        '
        Me.ds3.Appearance = System.Windows.Forms.Appearance.Button
        Me.ds3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ds3.Location = New System.Drawing.Point(109, 12)
        Me.ds3.Name = "ds3"
        Me.ds3.Size = New System.Drawing.Size(46, 31)
        Me.ds3.TabIndex = 51
        Me.ds3.Tag = "0"
        Me.ds3.Text = "250"
        Me.ds3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ds3.UseVisualStyleBackColor = True
        '
        'ds2
        '
        Me.ds2.Appearance = System.Windows.Forms.Appearance.Button
        Me.ds2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ds2.Location = New System.Drawing.Point(58, 12)
        Me.ds2.Name = "ds2"
        Me.ds2.Size = New System.Drawing.Size(46, 31)
        Me.ds2.TabIndex = 50
        Me.ds2.Tag = "-1"
        Me.ds2.Text = "200"
        Me.ds2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ds2.UseVisualStyleBackColor = True
        '
        'ds1
        '
        Me.ds1.Appearance = System.Windows.Forms.Appearance.Button
        Me.ds1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ds1.Location = New System.Drawing.Point(7, 12)
        Me.ds1.Name = "ds1"
        Me.ds1.Size = New System.Drawing.Size(46, 31)
        Me.ds1.TabIndex = 49
        Me.ds1.Tag = "-2"
        Me.ds1.Text = "100"
        Me.ds1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ds1.UseVisualStyleBackColor = True
        '
        'inc_def
        '
        Me.inc_def.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inc_def.Location = New System.Drawing.Point(228, 300)
        Me.inc_def.Name = "inc_def"
        Me.inc_def.Size = New System.Drawing.Size(31, 31)
        Me.inc_def.TabIndex = 65
        Me.inc_def.Text = ">"
        Me.inc_def.UseVisualStyleBackColor = True
        '
        'def_entrenched
        '
        Me.def_entrenched.Appearance = System.Windows.Forms.Appearance.Button
        Me.def_entrenched.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.def_entrenched.Location = New System.Drawing.Point(23, 155)
        Me.def_entrenched.Name = "def_entrenched"
        Me.def_entrenched.Size = New System.Drawing.Size(249, 31)
        Me.def_entrenched.TabIndex = 38
        Me.def_entrenched.Text = "Entrenched"
        Me.def_entrenched.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.def_entrenched.UseVisualStyleBackColor = True
        '
        'def_strength
        '
        Me.def_strength.BackColor = System.Drawing.Color.White
        Me.def_strength.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.def_strength.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.def_strength.Location = New System.Drawing.Point(158, 300)
        Me.def_strength.Name = "def_strength"
        Me.def_strength.Size = New System.Drawing.Size(63, 31)
        Me.def_strength.TabIndex = 64
        Me.def_strength.Text = "0"
        Me.def_strength.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'strength
        '
        Me.strength.BackColor = System.Drawing.Color.Transparent
        Me.strength.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.strength.Location = New System.Drawing.Point(33, 300)
        Me.strength.Name = "strength"
        Me.strength.Size = New System.Drawing.Size(83, 31)
        Me.strength.TabIndex = 63
        Me.strength.Text = "Strength"
        Me.strength.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'attacker
        '
        Me.attacker.BackColor = System.Drawing.Color.Transparent
        Me.attacker.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.attacker.Location = New System.Drawing.Point(71, 37)
        Me.attacker.Name = "attacker"
        Me.attacker.Size = New System.Drawing.Size(98, 26)
        Me.attacker.TabIndex = 62
        Me.attacker.Text = "Attacker"
        Me.attacker.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Reset
        '
        Me.Reset.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Reset.Location = New System.Drawing.Point(463, 602)
        Me.Reset.Name = "Reset"
        Me.Reset.Size = New System.Drawing.Size(119, 47)
        Me.Reset.TabIndex = 74
        Me.Reset.Text = "Reset Form"
        Me.Reset.UseVisualStyleBackColor = True
        '
        'fight
        '
        Me.fight.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fight.Location = New System.Drawing.Point(227, 602)
        Me.fight.Name = "fight"
        Me.fight.Size = New System.Drawing.Size(204, 47)
        Me.fight.TabIndex = 73
        Me.fight.Text = "Fight the Close Combat"
        Me.fight.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(164, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 26)
        Me.Label2.TabIndex = 75
        Me.Label2.Text = "attacking"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(523, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 26)
        Me.Label3.TabIndex = 76
        Me.Label3.Text = "defending"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'nextphase
        '
        Me.nextphase.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nextphase.Location = New System.Drawing.Point(624, 602)
        Me.nextphase.Name = "nextphase"
        Me.nextphase.Size = New System.Drawing.Size(48, 47)
        Me.nextphase.TabIndex = 63
        Me.nextphase.Text = ">"
        Me.nextphase.UseVisualStyleBackColor = True
        '
        'reverse
        '
        Me.reverse.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reverse.Location = New System.Drawing.Point(12, 602)
        Me.reverse.Name = "reverse"
        Me.reverse.Size = New System.Drawing.Size(48, 47)
        Me.reverse.TabIndex = 62
        Me.reverse.Text = "<"
        Me.reverse.UseVisualStyleBackColor = True
        '
        'close_combat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 661)
        Me.Controls.Add(Me.nextphase)
        Me.Controls.Add(Me.reverse)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Reset)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.fight)
        Me.Controls.Add(Me.defender)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.attacker)
        Me.Controls.Add(Me.Player)
        Me.Name = "close_combat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Close Combat Phase"
        Me.Panel2.ResumeLayout(False)
        Me.att_cover_options.ResumeLayout(False)
        Me.att_supp_options.ResumeLayout(False)
        Me.att_size_options.ResumeLayout(False)
        Me.att_quality_options.ResumeLayout(False)
        Me.att_support_options.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.def_supp_options.ResumeLayout(False)
        Me.def_support_options.ResumeLayout(False)
        Me.def_quality_options.ResumeLayout(False)
        Me.def_cover_options.ResumeLayout(False)
        Me.def_size_options.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Player As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents defender As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents def_cover_options As GroupBox
    Friend WithEvents dc1 As RadioButton
    Friend WithEvents dc4 As RadioButton
    Friend WithEvents dc3 As RadioButton
    Friend WithEvents dc2 As RadioButton
    Friend WithEvents def_size_options As GroupBox
    Friend WithEvents ds1 As RadioButton
    Friend WithEvents def_entrenched As CheckBox
    Friend WithEvents attacker As Label
    Friend WithEvents ds5 As RadioButton
    Friend WithEvents ds4 As RadioButton
    Friend WithEvents ds3 As RadioButton
    Friend WithEvents ds2 As RadioButton
    Friend WithEvents def_cav_dis As CheckBox
    Friend WithEvents def_cav As CheckBox
    Friend WithEvents dec_def As Button
    Friend WithEvents inc_def As Button
    Friend WithEvents def_strength As Label
    Friend WithEvents strength As Label
    Friend WithEvents def_support_options As GroupBox
    Friend WithEvents dsp1 As RadioButton
    Friend WithEvents dsp3 As RadioButton
    Friend WithEvents dsp2 As RadioButton
    Friend WithEvents def_flank As CheckBox
    Friend WithEvents def_morale As Button
    Friend WithEvents def_supp_options As GroupBox
    Friend WithEvents dsu1 As RadioButton
    Friend WithEvents dsu3 As RadioButton
    Friend WithEvents dsu2 As RadioButton
    Friend WithEvents att_supp_options As GroupBox
    Friend WithEvents asu1 As RadioButton
    Friend WithEvents asu2 As RadioButton
    Friend WithEvents att_cover_options As GroupBox
    Friend WithEvents ac1 As RadioButton
    Friend WithEvents ac4 As RadioButton
    Friend WithEvents ac3 As RadioButton
    Friend WithEvents ac2 As RadioButton
    Friend WithEvents att_entrenched As CheckBox
    Friend WithEvents att_size_options As GroupBox
    Friend WithEvents as5 As RadioButton
    Friend WithEvents as4 As RadioButton
    Friend WithEvents as3 As RadioButton
    Friend WithEvents as2 As RadioButton
    Friend WithEvents as1 As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents att_strength As Label
    Friend WithEvents dec_att As Button
    Friend WithEvents inc_att As Button
    Friend WithEvents att_support_options As GroupBox
    Friend WithEvents asp1 As RadioButton
    Friend WithEvents asp3 As RadioButton
    Friend WithEvents asp2 As RadioButton
    Friend WithEvents att_cav_dis As CheckBox
    Friend WithEvents att_cav As CheckBox
    Friend WithEvents Reset As Button
    Friend WithEvents fight As Button
    Friend WithEvents def_quality_options As GroupBox
    Friend WithEvents dq1 As RadioButton
    Friend WithEvents dq4 As RadioButton
    Friend WithEvents dq3 As RadioButton
    Friend WithEvents dq2 As RadioButton
    Friend WithEvents att_quality_options As GroupBox
    Friend WithEvents aq1 As RadioButton
    Friend WithEvents aq4 As RadioButton
    Friend WithEvents aq3 As RadioButton
    Friend WithEvents aq2 As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents nextphase As Button
    Friend WithEvents reverse As Button
End Class
