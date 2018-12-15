<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class movement
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
        Me.Player = New System.Windows.Forms.Label()
        Me.quality = New System.Windows.Forms.GroupBox()
        Me.veteran = New System.Windows.Forms.RadioButton()
        Me.regular = New System.Windows.Forms.RadioButton()
        Me.reservist = New System.Windows.Forms.RadioButton()
        Me.militia = New System.Windows.Forms.RadioButton()
        Me.suppressions = New System.Windows.Forms.GroupBox()
        Me.s4 = New System.Windows.Forms.RadioButton()
        Me.s3 = New System.Windows.Forms.RadioButton()
        Me.s2 = New System.Windows.Forms.RadioButton()
        Me.s1 = New System.Windows.Forms.RadioButton()
        Me.s0 = New System.Windows.Forms.RadioButton()
        Me.hq = New System.Windows.Forms.GroupBox()
        Me.hq2 = New System.Windows.Forms.RadioButton()
        Me.hq3 = New System.Windows.Forms.RadioButton()
        Me.hq1 = New System.Windows.Forms.RadioButton()
        Me.troop_types = New System.Windows.Forms.GroupBox()
        Me.t3 = New System.Windows.Forms.RadioButton()
        Me.t5 = New System.Windows.Forms.RadioButton()
        Me.t4 = New System.Windows.Forms.RadioButton()
        Me.t2 = New System.Windows.Forms.RadioButton()
        Me.t1 = New System.Windows.Forms.RadioButton()
        Me.terrain_types = New System.Windows.Forms.GroupBox()
        Me.te2 = New System.Windows.Forms.RadioButton()
        Me.te3 = New System.Windows.Forms.RadioButton()
        Me.te1 = New System.Windows.Forms.RadioButton()
        Me.obstacles = New System.Windows.Forms.GroupBox()
        Me.o2 = New System.Windows.Forms.RadioButton()
        Me.o3 = New System.Windows.Forms.RadioButton()
        Me.o1 = New System.Windows.Forms.RadioButton()
        Me.formation = New System.Windows.Forms.GroupBox()
        Me.deployed = New System.Windows.Forms.RadioButton()
        Me.limbered = New System.Windows.Forms.RadioButton()
        Me.column = New System.Windows.Forms.RadioButton()
        Me.dispersed = New System.Windows.Forms.RadioButton()
        Me.get_result = New System.Windows.Forms.Button()
        Me.Reset = New System.Windows.Forms.Button()
        Me.rally = New System.Windows.Forms.Button()
        Me.underfire = New System.Windows.Forms.GroupBox()
        Me.f0 = New System.Windows.Forms.RadioButton()
        Me.f2 = New System.Windows.Forms.RadioButton()
        Me.f3 = New System.Windows.Forms.RadioButton()
        Me.f1 = New System.Windows.Forms.RadioButton()
        Me.recover = New System.Windows.Forms.Button()
        Me.reverse = New System.Windows.Forms.Button()
        Me.nextphase = New System.Windows.Forms.Button()
        Me.quality.SuspendLayout()
        Me.suppressions.SuspendLayout()
        Me.hq.SuspendLayout()
        Me.troop_types.SuspendLayout()
        Me.terrain_types.SuspendLayout()
        Me.obstacles.SuspendLayout()
        Me.formation.SuspendLayout()
        Me.underfire.SuspendLayout()
        Me.SuspendLayout()
        '
        'Player
        '
        Me.Player.BackColor = System.Drawing.Color.Transparent
        Me.Player.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Player.Location = New System.Drawing.Point(93, 9)
        Me.Player.MinimumSize = New System.Drawing.Size(300, 0)
        Me.Player.Name = "Player"
        Me.Player.Size = New System.Drawing.Size(500, 31)
        Me.Player.TabIndex = 11
        Me.Player.Text = "Label1"
        Me.Player.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'quality
        '
        Me.quality.Controls.Add(Me.veteran)
        Me.quality.Controls.Add(Me.regular)
        Me.quality.Controls.Add(Me.reservist)
        Me.quality.Controls.Add(Me.militia)
        Me.quality.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.quality.Location = New System.Drawing.Point(109, 60)
        Me.quality.Margin = New System.Windows.Forms.Padding(0)
        Me.quality.Name = "quality"
        Me.quality.Padding = New System.Windows.Forms.Padding(0)
        Me.quality.Size = New System.Drawing.Size(446, 51)
        Me.quality.TabIndex = 62
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
        'suppressions
        '
        Me.suppressions.Controls.Add(Me.s4)
        Me.suppressions.Controls.Add(Me.s3)
        Me.suppressions.Controls.Add(Me.s2)
        Me.suppressions.Controls.Add(Me.s1)
        Me.suppressions.Controls.Add(Me.s0)
        Me.suppressions.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.suppressions.Location = New System.Drawing.Point(109, 249)
        Me.suppressions.Margin = New System.Windows.Forms.Padding(0)
        Me.suppressions.Name = "suppressions"
        Me.suppressions.Padding = New System.Windows.Forms.Padding(0)
        Me.suppressions.Size = New System.Drawing.Size(446, 51)
        Me.suppressions.TabIndex = 63
        Me.suppressions.TabStop = False
        Me.suppressions.Text = "Suppression"
        '
        's4
        '
        Me.s4.Appearance = System.Windows.Forms.Appearance.Button
        Me.s4.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.s4.Location = New System.Drawing.Point(343, 13)
        Me.s4.Name = "s4"
        Me.s4.Size = New System.Drawing.Size(86, 31)
        Me.s4.TabIndex = 53
        Me.s4.TabStop = True
        Me.s4.Tag = "Veteran"
        Me.s4.Text = "4"
        Me.s4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.s4.UseVisualStyleBackColor = True
        '
        's3
        '
        Me.s3.Appearance = System.Windows.Forms.Appearance.Button
        Me.s3.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.s3.Location = New System.Drawing.Point(260, 13)
        Me.s3.Name = "s3"
        Me.s3.Size = New System.Drawing.Size(80, 31)
        Me.s3.TabIndex = 52
        Me.s3.TabStop = True
        Me.s3.Tag = "Veteran"
        Me.s3.Text = "3"
        Me.s3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.s3.UseVisualStyleBackColor = True
        '
        's2
        '
        Me.s2.Appearance = System.Windows.Forms.Appearance.Button
        Me.s2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.s2.Location = New System.Drawing.Point(177, 13)
        Me.s2.Name = "s2"
        Me.s2.Size = New System.Drawing.Size(80, 31)
        Me.s2.TabIndex = 51
        Me.s2.TabStop = True
        Me.s2.Tag = "Regular"
        Me.s2.Text = "2"
        Me.s2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.s2.UseVisualStyleBackColor = True
        '
        's1
        '
        Me.s1.Appearance = System.Windows.Forms.Appearance.Button
        Me.s1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.s1.Location = New System.Drawing.Point(94, 13)
        Me.s1.Name = "s1"
        Me.s1.Size = New System.Drawing.Size(80, 31)
        Me.s1.TabIndex = 50
        Me.s1.TabStop = True
        Me.s1.Tag = "Reservist"
        Me.s1.Text = "1"
        Me.s1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.s1.UseVisualStyleBackColor = True
        '
        's0
        '
        Me.s0.Appearance = System.Windows.Forms.Appearance.Button
        Me.s0.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.s0.Location = New System.Drawing.Point(11, 13)
        Me.s0.Name = "s0"
        Me.s0.Size = New System.Drawing.Size(80, 31)
        Me.s0.TabIndex = 49
        Me.s0.TabStop = True
        Me.s0.Tag = "Militia"
        Me.s0.Text = "0"
        Me.s0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.s0.UseVisualStyleBackColor = True
        '
        'hq
        '
        Me.hq.Controls.Add(Me.hq2)
        Me.hq.Controls.Add(Me.hq3)
        Me.hq.Controls.Add(Me.hq1)
        Me.hq.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.hq.Location = New System.Drawing.Point(109, 312)
        Me.hq.Margin = New System.Windows.Forms.Padding(0)
        Me.hq.Name = "hq"
        Me.hq.Padding = New System.Windows.Forms.Padding(0)
        Me.hq.Size = New System.Drawing.Size(446, 51)
        Me.hq.TabIndex = 64
        Me.hq.TabStop = False
        Me.hq.Text = "Formation HQ"
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
        Me.hq2.Tag = "2"
        Me.hq2.Text = "<1000m"
        Me.hq2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.hq2.UseVisualStyleBackColor = True
        '
        'hq3
        '
        Me.hq3.Appearance = System.Windows.Forms.Appearance.Button
        Me.hq3.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hq3.Location = New System.Drawing.Point(296, 13)
        Me.hq3.Name = "hq3"
        Me.hq3.Size = New System.Drawing.Size(133, 31)
        Me.hq3.TabIndex = 50
        Me.hq3.TabStop = True
        Me.hq3.Tag = "0"
        Me.hq3.Text = ">1000m"
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
        Me.hq1.Tag = "3"
        Me.hq1.Text = "<250m"
        Me.hq1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.hq1.UseVisualStyleBackColor = True
        '
        'troop_types
        '
        Me.troop_types.Controls.Add(Me.t3)
        Me.troop_types.Controls.Add(Me.t5)
        Me.troop_types.Controls.Add(Me.t4)
        Me.troop_types.Controls.Add(Me.t2)
        Me.troop_types.Controls.Add(Me.t1)
        Me.troop_types.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.troop_types.Location = New System.Drawing.Point(109, 123)
        Me.troop_types.Margin = New System.Windows.Forms.Padding(0)
        Me.troop_types.Name = "troop_types"
        Me.troop_types.Padding = New System.Windows.Forms.Padding(0)
        Me.troop_types.Size = New System.Drawing.Size(446, 51)
        Me.troop_types.TabIndex = 63
        Me.troop_types.TabStop = False
        Me.troop_types.Text = "Troop Type"
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
        Me.t3.Tag = "Cavalry"
        Me.t3.Text = "Cav"
        Me.t3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.t3.UseVisualStyleBackColor = True
        '
        't5
        '
        Me.t5.Appearance = System.Windows.Forms.Appearance.Button
        Me.t5.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t5.Location = New System.Drawing.Point(349, 13)
        Me.t5.Name = "t5"
        Me.t5.Size = New System.Drawing.Size(80, 31)
        Me.t5.TabIndex = 52
        Me.t5.TabStop = True
        Me.t5.Tag = "Horse Artillery"
        Me.t5.Text = "H Arty"
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
        Me.t4.Tag = "Artillery"
        Me.t4.Text = "Arty"
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
        Me.t2.Tag = "Infantry"
        Me.t2.Text = "Inf"
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
        Me.t1.Tag = "HQ"
        Me.t1.Text = "HQ"
        Me.t1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.t1.UseVisualStyleBackColor = True
        '
        'terrain_types
        '
        Me.terrain_types.Controls.Add(Me.te2)
        Me.terrain_types.Controls.Add(Me.te3)
        Me.terrain_types.Controls.Add(Me.te1)
        Me.terrain_types.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.terrain_types.Location = New System.Drawing.Point(109, 375)
        Me.terrain_types.Margin = New System.Windows.Forms.Padding(0)
        Me.terrain_types.Name = "terrain_types"
        Me.terrain_types.Padding = New System.Windows.Forms.Padding(0)
        Me.terrain_types.Size = New System.Drawing.Size(446, 51)
        Me.terrain_types.TabIndex = 64
        Me.terrain_types.TabStop = False
        Me.terrain_types.Text = "Terrain"
        '
        'te2
        '
        Me.te2.Appearance = System.Windows.Forms.Appearance.Button
        Me.te2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.te2.Location = New System.Drawing.Point(153, 13)
        Me.te2.Name = "te2"
        Me.te2.Size = New System.Drawing.Size(133, 31)
        Me.te2.TabIndex = 51
        Me.te2.TabStop = True
        Me.te2.Tag = "1"
        Me.te2.Text = "Poor"
        Me.te2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.te2.UseVisualStyleBackColor = True
        '
        'te3
        '
        Me.te3.Appearance = System.Windows.Forms.Appearance.Button
        Me.te3.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.te3.Location = New System.Drawing.Point(296, 13)
        Me.te3.Name = "te3"
        Me.te3.Size = New System.Drawing.Size(133, 31)
        Me.te3.TabIndex = 50
        Me.te3.TabStop = True
        Me.te3.Tag = "0"
        Me.te3.Text = "Difficult"
        Me.te3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.te3.UseVisualStyleBackColor = True
        '
        'te1
        '
        Me.te1.Appearance = System.Windows.Forms.Appearance.Button
        Me.te1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.te1.Location = New System.Drawing.Point(11, 13)
        Me.te1.Name = "te1"
        Me.te1.Size = New System.Drawing.Size(133, 31)
        Me.te1.TabIndex = 49
        Me.te1.TabStop = True
        Me.te1.Tag = "2"
        Me.te1.Text = "Good"
        Me.te1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.te1.UseVisualStyleBackColor = True
        '
        'obstacles
        '
        Me.obstacles.Controls.Add(Me.o2)
        Me.obstacles.Controls.Add(Me.o3)
        Me.obstacles.Controls.Add(Me.o1)
        Me.obstacles.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.obstacles.Location = New System.Drawing.Point(109, 438)
        Me.obstacles.Margin = New System.Windows.Forms.Padding(0)
        Me.obstacles.Name = "obstacles"
        Me.obstacles.Padding = New System.Windows.Forms.Padding(0)
        Me.obstacles.Size = New System.Drawing.Size(446, 51)
        Me.obstacles.TabIndex = 65
        Me.obstacles.TabStop = False
        Me.obstacles.Text = "Obstacles"
        '
        'o2
        '
        Me.o2.Appearance = System.Windows.Forms.Appearance.Button
        Me.o2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.o2.Location = New System.Drawing.Point(153, 13)
        Me.o2.Name = "o2"
        Me.o2.Size = New System.Drawing.Size(133, 31)
        Me.o2.TabIndex = 51
        Me.o2.TabStop = True
        Me.o2.Tag = "1"
        Me.o2.Text = "Minor"
        Me.o2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.o2.UseVisualStyleBackColor = True
        '
        'o3
        '
        Me.o3.Appearance = System.Windows.Forms.Appearance.Button
        Me.o3.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.o3.Location = New System.Drawing.Point(296, 13)
        Me.o3.Name = "o3"
        Me.o3.Size = New System.Drawing.Size(133, 31)
        Me.o3.TabIndex = 50
        Me.o3.TabStop = True
        Me.o3.Tag = "0"
        Me.o3.Text = "Major"
        Me.o3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.o3.UseVisualStyleBackColor = True
        '
        'o1
        '
        Me.o1.Appearance = System.Windows.Forms.Appearance.Button
        Me.o1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.o1.Location = New System.Drawing.Point(11, 13)
        Me.o1.Name = "o1"
        Me.o1.Size = New System.Drawing.Size(133, 31)
        Me.o1.TabIndex = 49
        Me.o1.TabStop = True
        Me.o1.Tag = "2"
        Me.o1.Text = "None"
        Me.o1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.o1.UseVisualStyleBackColor = True
        '
        'formation
        '
        Me.formation.Controls.Add(Me.deployed)
        Me.formation.Controls.Add(Me.limbered)
        Me.formation.Controls.Add(Me.column)
        Me.formation.Controls.Add(Me.dispersed)
        Me.formation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.formation.Location = New System.Drawing.Point(109, 186)
        Me.formation.Margin = New System.Windows.Forms.Padding(0)
        Me.formation.Name = "formation"
        Me.formation.Padding = New System.Windows.Forms.Padding(0)
        Me.formation.Size = New System.Drawing.Size(446, 51)
        Me.formation.TabIndex = 66
        Me.formation.TabStop = False
        Me.formation.Text = "Formation"
        '
        'deployed
        '
        Me.deployed.Appearance = System.Windows.Forms.Appearance.Button
        Me.deployed.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deployed.Location = New System.Drawing.Point(11, 13)
        Me.deployed.Name = "deployed"
        Me.deployed.Size = New System.Drawing.Size(100, 31)
        Me.deployed.TabIndex = 53
        Me.deployed.TabStop = True
        Me.deployed.Tag = "0"
        Me.deployed.Text = "Deployed"
        Me.deployed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.deployed.UseVisualStyleBackColor = True
        '
        'limbered
        '
        Me.limbered.Appearance = System.Windows.Forms.Appearance.Button
        Me.limbered.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.limbered.Location = New System.Drawing.Point(329, 13)
        Me.limbered.Name = "limbered"
        Me.limbered.Size = New System.Drawing.Size(100, 31)
        Me.limbered.TabIndex = 52
        Me.limbered.TabStop = True
        Me.limbered.Tag = "1"
        Me.limbered.Text = "Limbered"
        Me.limbered.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.limbered.UseVisualStyleBackColor = True
        '
        'column
        '
        Me.column.Appearance = System.Windows.Forms.Appearance.Button
        Me.column.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.column.Location = New System.Drawing.Point(221, 13)
        Me.column.Name = "column"
        Me.column.Size = New System.Drawing.Size(100, 31)
        Me.column.TabIndex = 51
        Me.column.TabStop = True
        Me.column.Tag = "1"
        Me.column.Text = "Column"
        Me.column.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.column.UseVisualStyleBackColor = True
        '
        'dispersed
        '
        Me.dispersed.Appearance = System.Windows.Forms.Appearance.Button
        Me.dispersed.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dispersed.Location = New System.Drawing.Point(116, 13)
        Me.dispersed.Name = "dispersed"
        Me.dispersed.Size = New System.Drawing.Size(100, 31)
        Me.dispersed.TabIndex = 49
        Me.dispersed.TabStop = True
        Me.dispersed.Tag = "-1"
        Me.dispersed.Text = "Dispersed"
        Me.dispersed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.dispersed.UseVisualStyleBackColor = True
        '
        'get_result
        '
        Me.get_result.Font = New System.Drawing.Font("Calibri", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.get_result.Location = New System.Drawing.Point(325, 593)
        Me.get_result.Name = "get_result"
        Me.get_result.Size = New System.Drawing.Size(168, 54)
        Me.get_result.TabIndex = 67
        Me.get_result.Text = "Move"
        Me.get_result.UseVisualStyleBackColor = True
        '
        'Reset
        '
        Me.Reset.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Reset.Location = New System.Drawing.Point(508, 593)
        Me.Reset.Name = "Reset"
        Me.Reset.Size = New System.Drawing.Size(95, 54)
        Me.Reset.TabIndex = 54
        Me.Reset.Text = "Reset Form"
        Me.Reset.UseVisualStyleBackColor = True
        '
        'rally
        '
        Me.rally.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rally.Location = New System.Drawing.Point(83, 593)
        Me.rally.Name = "rally"
        Me.rally.Size = New System.Drawing.Size(93, 54)
        Me.rally.TabIndex = 68
        Me.rally.Text = "Rally Unit"
        Me.rally.UseVisualStyleBackColor = True
        '
        'underfire
        '
        Me.underfire.Controls.Add(Me.f0)
        Me.underfire.Controls.Add(Me.f2)
        Me.underfire.Controls.Add(Me.f3)
        Me.underfire.Controls.Add(Me.f1)
        Me.underfire.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.underfire.Location = New System.Drawing.Point(109, 501)
        Me.underfire.Margin = New System.Windows.Forms.Padding(0)
        Me.underfire.Name = "underfire"
        Me.underfire.Padding = New System.Windows.Forms.Padding(0)
        Me.underfire.Size = New System.Drawing.Size(446, 51)
        Me.underfire.TabIndex = 66
        Me.underfire.TabStop = False
        Me.underfire.Text = "Under Fire"
        '
        'f0
        '
        Me.f0.Appearance = System.Windows.Forms.Appearance.Button
        Me.f0.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.f0.Location = New System.Drawing.Point(11, 13)
        Me.f0.Name = "f0"
        Me.f0.Size = New System.Drawing.Size(100, 31)
        Me.f0.TabIndex = 52
        Me.f0.TabStop = True
        Me.f0.Tag = "1"
        Me.f0.Text = "No Effect"
        Me.f0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.f0.UseVisualStyleBackColor = True
        '
        'f2
        '
        Me.f2.Appearance = System.Windows.Forms.Appearance.Button
        Me.f2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.f2.Location = New System.Drawing.Point(221, 13)
        Me.f2.Name = "f2"
        Me.f2.Size = New System.Drawing.Size(100, 31)
        Me.f2.TabIndex = 51
        Me.f2.TabStop = True
        Me.f2.Tag = "-1"
        Me.f2.Text = "MG < T1"
        Me.f2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.f2.UseVisualStyleBackColor = True
        '
        'f3
        '
        Me.f3.Appearance = System.Windows.Forms.Appearance.Button
        Me.f3.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.f3.Location = New System.Drawing.Point(329, 13)
        Me.f3.Name = "f3"
        Me.f3.Size = New System.Drawing.Size(100, 31)
        Me.f3.TabIndex = 50
        Me.f3.TabStop = True
        Me.f3.Tag = "-2"
        Me.f3.Text = "Arty < T2"
        Me.f3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.f3.UseVisualStyleBackColor = True
        '
        'f1
        '
        Me.f1.Appearance = System.Windows.Forms.Appearance.Button
        Me.f1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.f1.Location = New System.Drawing.Point(116, 13)
        Me.f1.Name = "f1"
        Me.f1.Size = New System.Drawing.Size(100, 31)
        Me.f1.TabIndex = 49
        Me.f1.TabStop = True
        Me.f1.Tag = "0"
        Me.f1.Text = "SA open"
        Me.f1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.f1.UseVisualStyleBackColor = True
        '
        'recover
        '
        Me.recover.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.recover.Location = New System.Drawing.Point(191, 593)
        Me.recover.Name = "recover"
        Me.recover.Size = New System.Drawing.Size(119, 54)
        Me.recover.TabIndex = 69
        Me.recover.Text = "Rally Suppression"
        Me.recover.UseVisualStyleBackColor = True
        '
        'reverse
        '
        Me.reverse.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reverse.Location = New System.Drawing.Point(12, 593)
        Me.reverse.Name = "reverse"
        Me.reverse.Size = New System.Drawing.Size(56, 54)
        Me.reverse.TabIndex = 70
        Me.reverse.Text = "<"
        Me.reverse.UseVisualStyleBackColor = True
        '
        'nextphase
        '
        Me.nextphase.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nextphase.Location = New System.Drawing.Point(618, 593)
        Me.nextphase.Name = "nextphase"
        Me.nextphase.Size = New System.Drawing.Size(54, 54)
        Me.nextphase.TabIndex = 71
        Me.nextphase.Text = ">"
        Me.nextphase.UseVisualStyleBackColor = True
        '
        'movement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 661)
        Me.Controls.Add(Me.nextphase)
        Me.Controls.Add(Me.reverse)
        Me.Controls.Add(Me.recover)
        Me.Controls.Add(Me.underfire)
        Me.Controls.Add(Me.rally)
        Me.Controls.Add(Me.Reset)
        Me.Controls.Add(Me.get_result)
        Me.Controls.Add(Me.formation)
        Me.Controls.Add(Me.obstacles)
        Me.Controls.Add(Me.terrain_types)
        Me.Controls.Add(Me.hq)
        Me.Controls.Add(Me.troop_types)
        Me.Controls.Add(Me.suppressions)
        Me.Controls.Add(Me.quality)
        Me.Controls.Add(Me.Player)
        Me.Name = "movement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Movement Phase"
        Me.quality.ResumeLayout(False)
        Me.suppressions.ResumeLayout(False)
        Me.hq.ResumeLayout(False)
        Me.troop_types.ResumeLayout(False)
        Me.terrain_types.ResumeLayout(False)
        Me.obstacles.ResumeLayout(False)
        Me.formation.ResumeLayout(False)
        Me.underfire.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Player As Label
    Friend WithEvents quality As GroupBox
    Friend WithEvents veteran As RadioButton
    Friend WithEvents regular As RadioButton
    Friend WithEvents reservist As RadioButton
    Friend WithEvents militia As RadioButton
    Friend WithEvents suppressions As GroupBox
    Friend WithEvents s3 As RadioButton
    Friend WithEvents s2 As RadioButton
    Friend WithEvents s1 As RadioButton
    Friend WithEvents s0 As RadioButton
    Friend WithEvents hq As GroupBox
    Friend WithEvents hq2 As RadioButton
    Friend WithEvents hq3 As RadioButton
    Friend WithEvents hq1 As RadioButton
    Friend WithEvents troop_types As GroupBox
    Friend WithEvents t3 As RadioButton
    Friend WithEvents t5 As RadioButton
    Friend WithEvents t4 As RadioButton
    Friend WithEvents t2 As RadioButton
    Friend WithEvents t1 As RadioButton
    Friend WithEvents terrain_types As GroupBox
    Friend WithEvents te2 As RadioButton
    Friend WithEvents te3 As RadioButton
    Friend WithEvents te1 As RadioButton
    Friend WithEvents obstacles As GroupBox
    Friend WithEvents o2 As RadioButton
    Friend WithEvents o3 As RadioButton
    Friend WithEvents o1 As RadioButton
    Friend WithEvents formation As GroupBox
    Friend WithEvents deployed As RadioButton
    Friend WithEvents limbered As RadioButton
    Friend WithEvents column As RadioButton
    Friend WithEvents dispersed As RadioButton
    Friend WithEvents get_result As Button
    Friend WithEvents Reset As Button
    Friend WithEvents rally As Button
    Friend WithEvents underfire As GroupBox
    Friend WithEvents f2 As RadioButton
    Friend WithEvents f3 As RadioButton
    Friend WithEvents f1 As RadioButton
    Friend WithEvents recover As Button
    Friend WithEvents s4 As RadioButton
    Friend WithEvents reverse As Button
    Friend WithEvents nextphase As Button
    Friend WithEvents f0 As RadioButton
End Class
