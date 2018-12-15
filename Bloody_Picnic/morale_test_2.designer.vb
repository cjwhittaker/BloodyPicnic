<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class morale_test
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
        Me.get_result = New System.Windows.Forms.Button()
        Me.ok_button = New System.Windows.Forms.Button()
        Me.target_entrenched = New System.Windows.Forms.CheckBox()
        Me.behind_flank = New System.Windows.Forms.CheckBox()
        Me.quality = New System.Windows.Forms.GroupBox()
        Me.veteran = New System.Windows.Forms.RadioButton()
        Me.regular = New System.Windows.Forms.RadioButton()
        Me.reservist = New System.Windows.Forms.RadioButton()
        Me.militia = New System.Windows.Forms.RadioButton()
        Me.context = New System.Windows.Forms.GroupBox()
        Me.t3 = New System.Windows.Forms.RadioButton()
        Me.t5 = New System.Windows.Forms.RadioButton()
        Me.t4 = New System.Windows.Forms.RadioButton()
        Me.t2 = New System.Windows.Forms.RadioButton()
        Me.t1 = New System.Windows.Forms.RadioButton()
        Me.unit_type = New System.Windows.Forms.GroupBox()
        Me.hq2 = New System.Windows.Forms.RadioButton()
        Me.hq3 = New System.Windows.Forms.RadioButton()
        Me.hq1 = New System.Windows.Forms.RadioButton()
        Me.losses = New System.Windows.Forms.GroupBox()
        Me.l1 = New System.Windows.Forms.RadioButton()
        Me.l4 = New System.Windows.Forms.RadioButton()
        Me.l3 = New System.Windows.Forms.RadioButton()
        Me.l2 = New System.Windows.Forms.RadioButton()
        Me.cover = New System.Windows.Forms.GroupBox()
        Me.c0 = New System.Windows.Forms.RadioButton()
        Me.c3 = New System.Windows.Forms.RadioButton()
        Me.c2 = New System.Windows.Forms.RadioButton()
        Me.c1 = New System.Windows.Forms.RadioButton()
        Me.suppression = New System.Windows.Forms.GroupBox()
        Me.s2 = New System.Windows.Forms.RadioButton()
        Me.s3 = New System.Windows.Forms.RadioButton()
        Me.s1 = New System.Windows.Forms.RadioButton()
        Me.under_fire = New System.Windows.Forms.GroupBox()
        Me.f2 = New System.Windows.Forms.RadioButton()
        Me.f3 = New System.Windows.Forms.RadioButton()
        Me.f1 = New System.Windows.Forms.RadioButton()
        Me.Player = New System.Windows.Forms.Label()
        Me.close_combat = New System.Windows.Forms.GroupBox()
        Me.cc2 = New System.Windows.Forms.RadioButton()
        Me.cc3 = New System.Windows.Forms.RadioButton()
        Me.cc1 = New System.Windows.Forms.RadioButton()
        Me.quality.SuspendLayout()
        Me.context.SuspendLayout()
        Me.unit_type.SuspendLayout()
        Me.losses.SuspendLayout()
        Me.cover.SuspendLayout()
        Me.suppression.SuspendLayout()
        Me.under_fire.SuspendLayout()
        Me.close_combat.SuspendLayout()
        Me.SuspendLayout()
        '
        'get_result
        '
        Me.get_result.Font = New System.Drawing.Font("Calibri", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.get_result.Location = New System.Drawing.Point(225, 599)
        Me.get_result.Name = "get_result"
        Me.get_result.Size = New System.Drawing.Size(211, 40)
        Me.get_result.TabIndex = 14
        Me.get_result.Text = "Test Morale"
        Me.get_result.UseVisualStyleBackColor = True
        '
        'ok_button
        '
        Me.ok_button.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ok_button.Location = New System.Drawing.Point(508, 599)
        Me.ok_button.Name = "ok_button"
        Me.ok_button.Size = New System.Drawing.Size(51, 40)
        Me.ok_button.TabIndex = 14
        Me.ok_button.Text = "OK"
        Me.ok_button.UseVisualStyleBackColor = True
        Me.ok_button.Visible = False
        '
        'target_entrenched
        '
        Me.target_entrenched.Appearance = System.Windows.Forms.Appearance.Button
        Me.target_entrenched.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.target_entrenched.Location = New System.Drawing.Point(110, 321)
        Me.target_entrenched.Name = "target_entrenched"
        Me.target_entrenched.Size = New System.Drawing.Size(418, 31)
        Me.target_entrenched.TabIndex = 47
        Me.target_entrenched.Tag = "1"
        Me.target_entrenched.Text = "Entrenched"
        Me.target_entrenched.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.target_entrenched.UseVisualStyleBackColor = True
        '
        'behind_flank
        '
        Me.behind_flank.Appearance = System.Windows.Forms.Appearance.Button
        Me.behind_flank.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.behind_flank.Location = New System.Drawing.Point(110, 520)
        Me.behind_flank.Name = "behind_flank"
        Me.behind_flank.Size = New System.Drawing.Size(418, 31)
        Me.behind_flank.TabIndex = 56
        Me.behind_flank.Tag = "-2"
        Me.behind_flank.Text = "En behind flank <200"
        Me.behind_flank.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.behind_flank.UseVisualStyleBackColor = True
        '
        'quality
        '
        Me.quality.Controls.Add(Me.veteran)
        Me.quality.Controls.Add(Me.regular)
        Me.quality.Controls.Add(Me.reservist)
        Me.quality.Controls.Add(Me.militia)
        Me.quality.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.quality.Location = New System.Drawing.Point(99, 46)
        Me.quality.Margin = New System.Windows.Forms.Padding(0)
        Me.quality.Name = "quality"
        Me.quality.Padding = New System.Windows.Forms.Padding(0)
        Me.quality.Size = New System.Drawing.Size(446, 51)
        Me.quality.TabIndex = 63
        Me.quality.TabStop = False
        Me.quality.Text = "Quality"
        '
        'veteran
        '
        Me.veteran.AccessibleName = "5"
        Me.veteran.Appearance = System.Windows.Forms.Appearance.Button
        Me.veteran.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.veteran.Location = New System.Drawing.Point(329, 13)
        Me.veteran.Name = "veteran"
        Me.veteran.Size = New System.Drawing.Size(100, 31)
        Me.veteran.TabIndex = 52
        Me.veteran.TabStop = True
        Me.veteran.Tag = "5"
        Me.veteran.Text = "Veteran"
        Me.veteran.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.veteran.UseVisualStyleBackColor = True
        '
        'regular
        '
        Me.regular.AccessibleName = "6"
        Me.regular.Appearance = System.Windows.Forms.Appearance.Button
        Me.regular.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regular.Location = New System.Drawing.Point(223, 13)
        Me.regular.Name = "regular"
        Me.regular.Size = New System.Drawing.Size(100, 31)
        Me.regular.TabIndex = 51
        Me.regular.TabStop = True
        Me.regular.Tag = "6"
        Me.regular.Text = "Regular"
        Me.regular.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.regular.UseVisualStyleBackColor = True
        '
        'reservist
        '
        Me.reservist.AccessibleName = "7"
        Me.reservist.Appearance = System.Windows.Forms.Appearance.Button
        Me.reservist.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reservist.Location = New System.Drawing.Point(117, 13)
        Me.reservist.Name = "reservist"
        Me.reservist.Size = New System.Drawing.Size(100, 31)
        Me.reservist.TabIndex = 50
        Me.reservist.TabStop = True
        Me.reservist.Tag = "7"
        Me.reservist.Text = "Reservist"
        Me.reservist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.reservist.UseVisualStyleBackColor = True
        '
        'militia
        '
        Me.militia.AccessibleName = "8"
        Me.militia.Appearance = System.Windows.Forms.Appearance.Button
        Me.militia.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.militia.Location = New System.Drawing.Point(11, 13)
        Me.militia.Name = "militia"
        Me.militia.Size = New System.Drawing.Size(100, 31)
        Me.militia.TabIndex = 49
        Me.militia.TabStop = True
        Me.militia.Tag = "8"
        Me.militia.Text = "Militia"
        Me.militia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.militia.UseVisualStyleBackColor = True
        '
        'context
        '
        Me.context.Controls.Add(Me.t3)
        Me.context.Controls.Add(Me.t5)
        Me.context.Controls.Add(Me.t4)
        Me.context.Controls.Add(Me.t2)
        Me.context.Controls.Add(Me.t1)
        Me.context.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.context.Location = New System.Drawing.Point(99, 101)
        Me.context.Margin = New System.Windows.Forms.Padding(0)
        Me.context.Name = "context"
        Me.context.Padding = New System.Windows.Forms.Padding(0)
        Me.context.Size = New System.Drawing.Size(446, 51)
        Me.context.TabIndex = 64
        Me.context.TabStop = False
        Me.context.Text = "Context"
        '
        't3
        '
        Me.t3.Appearance = System.Windows.Forms.Appearance.Button
        Me.t3.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t3.Location = New System.Drawing.Point(179, 13)
        Me.t3.Name = "t3"
        Me.t3.Size = New System.Drawing.Size(80, 31)
        Me.t3.TabIndex = 53
        Me.t3.TabStop = True
        Me.t3.Tag = "3"
        Me.t3.Text = "Retire"
        Me.t3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.t3.UseVisualStyleBackColor = True
        '
        't5
        '
        Me.t5.Appearance = System.Windows.Forms.Appearance.Button
        Me.t5.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t5.Location = New System.Drawing.Point(347, 13)
        Me.t5.Name = "t5"
        Me.t5.Size = New System.Drawing.Size(82, 31)
        Me.t5.TabIndex = 52
        Me.t5.TabStop = True
        Me.t5.Tag = "5"
        Me.t5.Text = "Pursue"
        Me.t5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.t5.UseVisualStyleBackColor = True
        '
        't4
        '
        Me.t4.Appearance = System.Windows.Forms.Appearance.Button
        Me.t4.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t4.Location = New System.Drawing.Point(263, 13)
        Me.t4.Name = "t4"
        Me.t4.Size = New System.Drawing.Size(80, 31)
        Me.t4.TabIndex = 51
        Me.t4.TabStop = True
        Me.t4.Tag = "4"
        Me.t4.Text = "Rout"
        Me.t4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.t4.UseVisualStyleBackColor = True
        '
        't2
        '
        Me.t2.Appearance = System.Windows.Forms.Appearance.Button
        Me.t2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t2.Location = New System.Drawing.Point(95, 13)
        Me.t2.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.t2.Name = "t2"
        Me.t2.Size = New System.Drawing.Size(80, 31)
        Me.t2.TabIndex = 50
        Me.t2.TabStop = True
        Me.t2.Tag = "2"
        Me.t2.Text = "Halt"
        Me.t2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.t2.UseVisualStyleBackColor = True
        '
        't1
        '
        Me.t1.Appearance = System.Windows.Forms.Appearance.Button
        Me.t1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t1.Location = New System.Drawing.Point(11, 13)
        Me.t1.Name = "t1"
        Me.t1.Size = New System.Drawing.Size(80, 31)
        Me.t1.TabIndex = 49
        Me.t1.TabStop = True
        Me.t1.Tag = "1"
        Me.t1.Text = "Advance"
        Me.t1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.t1.UseVisualStyleBackColor = True
        '
        'unit_type
        '
        Me.unit_type.Controls.Add(Me.hq2)
        Me.unit_type.Controls.Add(Me.hq3)
        Me.unit_type.Controls.Add(Me.hq1)
        Me.unit_type.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.unit_type.Location = New System.Drawing.Point(99, 156)
        Me.unit_type.Margin = New System.Windows.Forms.Padding(0)
        Me.unit_type.Name = "unit_type"
        Me.unit_type.Padding = New System.Windows.Forms.Padding(0)
        Me.unit_type.Size = New System.Drawing.Size(446, 51)
        Me.unit_type.TabIndex = 65
        Me.unit_type.TabStop = False
        Me.unit_type.Text = "Unit Type"
        '
        'hq2
        '
        Me.hq2.Appearance = System.Windows.Forms.Appearance.Button
        Me.hq2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hq2.Location = New System.Drawing.Point(153, 13)
        Me.hq2.Name = "hq2"
        Me.hq2.Size = New System.Drawing.Size(133, 31)
        Me.hq2.TabIndex = 51
        Me.hq2.TabStop = True
        Me.hq2.Tag = "-1"
        Me.hq2.Text = "Element"
        Me.hq2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.hq2.UseVisualStyleBackColor = True
        '
        'hq3
        '
        Me.hq3.Appearance = System.Windows.Forms.Appearance.Button
        Me.hq3.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hq3.Location = New System.Drawing.Point(295, 13)
        Me.hq3.Name = "hq3"
        Me.hq3.Size = New System.Drawing.Size(134, 31)
        Me.hq3.TabIndex = 50
        Me.hq3.TabStop = True
        Me.hq3.Tag = "-2"
        Me.hq3.Text = "Element in CC"
        Me.hq3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.hq3.UseVisualStyleBackColor = True
        '
        'hq1
        '
        Me.hq1.Appearance = System.Windows.Forms.Appearance.Button
        Me.hq1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hq1.Location = New System.Drawing.Point(11, 13)
        Me.hq1.Name = "hq1"
        Me.hq1.Size = New System.Drawing.Size(133, 31)
        Me.hq1.TabIndex = 49
        Me.hq1.TabStop = True
        Me.hq1.Tag = "0"
        Me.hq1.Text = "Unit"
        Me.hq1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.hq1.UseVisualStyleBackColor = True
        '
        'losses
        '
        Me.losses.Controls.Add(Me.l1)
        Me.losses.Controls.Add(Me.l4)
        Me.losses.Controls.Add(Me.l3)
        Me.losses.Controls.Add(Me.l2)
        Me.losses.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.losses.Location = New System.Drawing.Point(99, 211)
        Me.losses.Margin = New System.Windows.Forms.Padding(0)
        Me.losses.Name = "losses"
        Me.losses.Padding = New System.Windows.Forms.Padding(0)
        Me.losses.Size = New System.Drawing.Size(446, 51)
        Me.losses.TabIndex = 67
        Me.losses.TabStop = False
        Me.losses.Text = "Losses"
        '
        'l1
        '
        Me.l1.Appearance = System.Windows.Forms.Appearance.Button
        Me.l1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l1.Location = New System.Drawing.Point(11, 13)
        Me.l1.Name = "l1"
        Me.l1.Size = New System.Drawing.Size(100, 31)
        Me.l1.TabIndex = 53
        Me.l1.TabStop = True
        Me.l1.Tag = "0"
        Me.l1.Text = "None"
        Me.l1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.l1.UseVisualStyleBackColor = True
        '
        'l4
        '
        Me.l4.Appearance = System.Windows.Forms.Appearance.Button
        Me.l4.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l4.Location = New System.Drawing.Point(329, 13)
        Me.l4.Name = "l4"
        Me.l4.Size = New System.Drawing.Size(100, 31)
        Me.l4.TabIndex = 52
        Me.l4.TabStop = True
        Me.l4.Tag = "-3"
        Me.l4.Text = ">50%"
        Me.l4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.l4.UseVisualStyleBackColor = True
        '
        'l3
        '
        Me.l3.Appearance = System.Windows.Forms.Appearance.Button
        Me.l3.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l3.Location = New System.Drawing.Point(221, 13)
        Me.l3.Name = "l3"
        Me.l3.Size = New System.Drawing.Size(100, 31)
        Me.l3.TabIndex = 51
        Me.l3.TabStop = True
        Me.l3.Tag = "-2"
        Me.l3.Text = "<=50%"
        Me.l3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.l3.UseVisualStyleBackColor = True
        '
        'l2
        '
        Me.l2.Appearance = System.Windows.Forms.Appearance.Button
        Me.l2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l2.Location = New System.Drawing.Point(116, 13)
        Me.l2.Name = "l2"
        Me.l2.Size = New System.Drawing.Size(100, 31)
        Me.l2.TabIndex = 49
        Me.l2.TabStop = True
        Me.l2.Tag = "-1"
        Me.l2.Text = "<=25%"
        Me.l2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.l2.UseVisualStyleBackColor = True
        '
        'cover
        '
        Me.cover.Controls.Add(Me.c0)
        Me.cover.Controls.Add(Me.c3)
        Me.cover.Controls.Add(Me.c2)
        Me.cover.Controls.Add(Me.c1)
        Me.cover.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cover.Location = New System.Drawing.Point(99, 266)
        Me.cover.Margin = New System.Windows.Forms.Padding(0)
        Me.cover.Name = "cover"
        Me.cover.Padding = New System.Windows.Forms.Padding(0)
        Me.cover.Size = New System.Drawing.Size(446, 51)
        Me.cover.TabIndex = 68
        Me.cover.TabStop = False
        Me.cover.Text = "Cover"
        '
        'c0
        '
        Me.c0.Appearance = System.Windows.Forms.Appearance.Button
        Me.c0.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c0.Location = New System.Drawing.Point(11, 13)
        Me.c0.Name = "c0"
        Me.c0.Size = New System.Drawing.Size(100, 31)
        Me.c0.TabIndex = 53
        Me.c0.TabStop = True
        Me.c0.Tag = "0"
        Me.c0.Text = "0"
        Me.c0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.c0.UseVisualStyleBackColor = True
        '
        'c3
        '
        Me.c3.Appearance = System.Windows.Forms.Appearance.Button
        Me.c3.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c3.Location = New System.Drawing.Point(329, 13)
        Me.c3.Name = "c3"
        Me.c3.Size = New System.Drawing.Size(100, 31)
        Me.c3.TabIndex = 52
        Me.c3.TabStop = True
        Me.c3.Tag = "3"
        Me.c3.Text = "3"
        Me.c3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.c3.UseVisualStyleBackColor = True
        '
        'c2
        '
        Me.c2.Appearance = System.Windows.Forms.Appearance.Button
        Me.c2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c2.Location = New System.Drawing.Point(221, 13)
        Me.c2.Name = "c2"
        Me.c2.Size = New System.Drawing.Size(100, 31)
        Me.c2.TabIndex = 51
        Me.c2.TabStop = True
        Me.c2.Tag = "2"
        Me.c2.Text = "2"
        Me.c2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.c2.UseVisualStyleBackColor = True
        '
        'c1
        '
        Me.c1.Appearance = System.Windows.Forms.Appearance.Button
        Me.c1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1.Location = New System.Drawing.Point(116, 13)
        Me.c1.Name = "c1"
        Me.c1.Size = New System.Drawing.Size(100, 31)
        Me.c1.TabIndex = 49
        Me.c1.TabStop = True
        Me.c1.Tag = "1"
        Me.c1.Text = "1"
        Me.c1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.c1.UseVisualStyleBackColor = True
        '
        'suppression
        '
        Me.suppression.Controls.Add(Me.s2)
        Me.suppression.Controls.Add(Me.s3)
        Me.suppression.Controls.Add(Me.s1)
        Me.suppression.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.suppression.Location = New System.Drawing.Point(99, 356)
        Me.suppression.Margin = New System.Windows.Forms.Padding(0)
        Me.suppression.Name = "suppression"
        Me.suppression.Padding = New System.Windows.Forms.Padding(0)
        Me.suppression.Size = New System.Drawing.Size(446, 51)
        Me.suppression.TabIndex = 69
        Me.suppression.TabStop = False
        Me.suppression.Text = "Suppression"
        '
        's2
        '
        Me.s2.Appearance = System.Windows.Forms.Appearance.Button
        Me.s2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.s2.Location = New System.Drawing.Point(153, 13)
        Me.s2.Name = "s2"
        Me.s2.Size = New System.Drawing.Size(133, 31)
        Me.s2.TabIndex = 51
        Me.s2.TabStop = True
        Me.s2.Tag = "-1"
        Me.s2.Text = "Partial"
        Me.s2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.s2.UseVisualStyleBackColor = True
        '
        's3
        '
        Me.s3.Appearance = System.Windows.Forms.Appearance.Button
        Me.s3.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.s3.Location = New System.Drawing.Point(296, 13)
        Me.s3.Name = "s3"
        Me.s3.Size = New System.Drawing.Size(133, 31)
        Me.s3.TabIndex = 50
        Me.s3.TabStop = True
        Me.s3.Tag = "-2"
        Me.s3.Text = "Full"
        Me.s3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.s3.UseVisualStyleBackColor = True
        '
        's1
        '
        Me.s1.Appearance = System.Windows.Forms.Appearance.Button
        Me.s1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.s1.Location = New System.Drawing.Point(11, 13)
        Me.s1.Name = "s1"
        Me.s1.Size = New System.Drawing.Size(133, 31)
        Me.s1.TabIndex = 49
        Me.s1.TabStop = True
        Me.s1.Tag = "0"
        Me.s1.Text = "None"
        Me.s1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.s1.UseVisualStyleBackColor = True
        '
        'under_fire
        '
        Me.under_fire.Controls.Add(Me.f2)
        Me.under_fire.Controls.Add(Me.f3)
        Me.under_fire.Controls.Add(Me.f1)
        Me.under_fire.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.under_fire.Location = New System.Drawing.Point(99, 411)
        Me.under_fire.Margin = New System.Windows.Forms.Padding(0)
        Me.under_fire.Name = "under_fire"
        Me.under_fire.Padding = New System.Windows.Forms.Padding(0)
        Me.under_fire.Size = New System.Drawing.Size(446, 51)
        Me.under_fire.TabIndex = 70
        Me.under_fire.TabStop = False
        Me.under_fire.Text = "Under Fire"
        '
        'f2
        '
        Me.f2.Appearance = System.Windows.Forms.Appearance.Button
        Me.f2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.f2.Location = New System.Drawing.Point(153, 13)
        Me.f2.Name = "f2"
        Me.f2.Size = New System.Drawing.Size(133, 31)
        Me.f2.TabIndex = 51
        Me.f2.TabStop = True
        Me.f2.Tag = "-1"
        Me.f2.Text = "MG Fire"
        Me.f2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.f2.UseVisualStyleBackColor = True
        '
        'f3
        '
        Me.f3.Appearance = System.Windows.Forms.Appearance.Button
        Me.f3.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.f3.Location = New System.Drawing.Point(296, 13)
        Me.f3.Name = "f3"
        Me.f3.Size = New System.Drawing.Size(133, 31)
        Me.f3.TabIndex = 50
        Me.f3.TabStop = True
        Me.f3.Tag = "-2"
        Me.f3.Text = "Arty Fire"
        Me.f3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.f3.UseVisualStyleBackColor = True
        '
        'f1
        '
        Me.f1.Appearance = System.Windows.Forms.Appearance.Button
        Me.f1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.f1.Location = New System.Drawing.Point(11, 13)
        Me.f1.Name = "f1"
        Me.f1.Size = New System.Drawing.Size(133, 31)
        Me.f1.TabIndex = 49
        Me.f1.TabStop = True
        Me.f1.Tag = "0"
        Me.f1.Text = "Not"
        Me.f1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.f1.UseVisualStyleBackColor = True
        '
        'Player
        '
        Me.Player.BackColor = System.Drawing.Color.Transparent
        Me.Player.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Player.Location = New System.Drawing.Point(77, 9)
        Me.Player.MinimumSize = New System.Drawing.Size(300, 0)
        Me.Player.Name = "Player"
        Me.Player.Size = New System.Drawing.Size(500, 31)
        Me.Player.TabIndex = 52
        Me.Player.Text = "Label1"
        Me.Player.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'close_combat
        '
        Me.close_combat.Controls.Add(Me.cc2)
        Me.close_combat.Controls.Add(Me.cc3)
        Me.close_combat.Controls.Add(Me.cc1)
        Me.close_combat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.close_combat.Location = New System.Drawing.Point(99, 466)
        Me.close_combat.Margin = New System.Windows.Forms.Padding(0)
        Me.close_combat.Name = "close_combat"
        Me.close_combat.Padding = New System.Windows.Forms.Padding(0)
        Me.close_combat.Size = New System.Drawing.Size(446, 51)
        Me.close_combat.TabIndex = 71
        Me.close_combat.TabStop = False
        Me.close_combat.Text = "Close Combat"
        '
        'cc2
        '
        Me.cc2.Appearance = System.Windows.Forms.Appearance.Button
        Me.cc2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cc2.Location = New System.Drawing.Point(153, 13)
        Me.cc2.Name = "cc2"
        Me.cc2.Size = New System.Drawing.Size(133, 31)
        Me.cc2.TabIndex = 51
        Me.cc2.TabStop = True
        Me.cc2.Tag = "2"
        Me.cc2.Text = "Won"
        Me.cc2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cc2.UseVisualStyleBackColor = True
        '
        'cc3
        '
        Me.cc3.Appearance = System.Windows.Forms.Appearance.Button
        Me.cc3.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cc3.Location = New System.Drawing.Point(296, 13)
        Me.cc3.Name = "cc3"
        Me.cc3.Size = New System.Drawing.Size(133, 31)
        Me.cc3.TabIndex = 50
        Me.cc3.TabStop = True
        Me.cc3.Tag = "-2"
        Me.cc3.Text = "Lost"
        Me.cc3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cc3.UseVisualStyleBackColor = True
        '
        'cc1
        '
        Me.cc1.Appearance = System.Windows.Forms.Appearance.Button
        Me.cc1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cc1.Location = New System.Drawing.Point(11, 13)
        Me.cc1.Name = "cc1"
        Me.cc1.Size = New System.Drawing.Size(133, 31)
        Me.cc1.TabIndex = 49
        Me.cc1.TabStop = True
        Me.cc1.Tag = "0"
        Me.cc1.Text = "N/A"
        Me.cc1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cc1.UseVisualStyleBackColor = True
        '
        'morale_test
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(684, 661)
        Me.Controls.Add(Me.close_combat)
        Me.Controls.Add(Me.Player)
        Me.Controls.Add(Me.under_fire)
        Me.Controls.Add(Me.suppression)
        Me.Controls.Add(Me.cover)
        Me.Controls.Add(Me.losses)
        Me.Controls.Add(Me.unit_type)
        Me.Controls.Add(Me.context)
        Me.Controls.Add(Me.quality)
        Me.Controls.Add(Me.behind_flank)
        Me.Controls.Add(Me.target_entrenched)
        Me.Controls.Add(Me.ok_button)
        Me.Controls.Add(Me.get_result)
        Me.Name = "morale_test"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Morale Test"
        Me.quality.ResumeLayout(False)
        Me.context.ResumeLayout(False)
        Me.unit_type.ResumeLayout(False)
        Me.losses.ResumeLayout(False)
        Me.cover.ResumeLayout(False)
        Me.suppression.ResumeLayout(False)
        Me.under_fire.ResumeLayout(False)
        Me.close_combat.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents get_result As System.Windows.Forms.Button
    Friend WithEvents ok_button As System.Windows.Forms.Button
    Friend WithEvents target_entrenched As CheckBox
    Friend WithEvents behind_flank As CheckBox
    Friend WithEvents quality As GroupBox
    Friend WithEvents veteran As RadioButton
    Friend WithEvents regular As RadioButton
    Friend WithEvents reservist As RadioButton
    Friend WithEvents militia As RadioButton
    Friend WithEvents context As GroupBox
    Friend WithEvents t3 As RadioButton
    Friend WithEvents t5 As RadioButton
    Friend WithEvents t4 As RadioButton
    Friend WithEvents t2 As RadioButton
    Friend WithEvents t1 As RadioButton
    Friend WithEvents unit_type As GroupBox
    Friend WithEvents hq2 As RadioButton
    Friend WithEvents hq3 As RadioButton
    Friend WithEvents hq1 As RadioButton
    Friend WithEvents losses As GroupBox
    Friend WithEvents l1 As RadioButton
    Friend WithEvents l4 As RadioButton
    Friend WithEvents l3 As RadioButton
    Friend WithEvents l2 As RadioButton
    Friend WithEvents cover As GroupBox
    Friend WithEvents c0 As RadioButton
    Friend WithEvents c3 As RadioButton
    Friend WithEvents c2 As RadioButton
    Friend WithEvents c1 As RadioButton
    Friend WithEvents suppression As GroupBox
    Friend WithEvents s2 As RadioButton
    Friend WithEvents s3 As RadioButton
    Friend WithEvents s1 As RadioButton
    Friend WithEvents under_fire As GroupBox
    Friend WithEvents f2 As RadioButton
    Friend WithEvents f3 As RadioButton
    Friend WithEvents f1 As RadioButton
    Friend WithEvents Player As Label
    Friend WithEvents close_combat As GroupBox
    Friend WithEvents cc2 As RadioButton
    Friend WithEvents cc3 As RadioButton
    Friend WithEvents cc1 As RadioButton
End Class
