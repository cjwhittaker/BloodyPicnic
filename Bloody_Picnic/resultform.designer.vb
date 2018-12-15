<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class resultform
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(resultform))
        Me.result = New System.Windows.Forms.Label()
        Me.reverse = New System.Windows.Forms.Button()
        Me.first_player = New System.Windows.Forms.Button()
        Me.second_player = New System.Windows.Forms.Button()
        Me.adjust = New System.Windows.Forms.Button()
        Me.confirm = New System.Windows.Forms.Button()
        Me.morale_check = New System.Windows.Forms.Button()
        Me.quality_check = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'result
        '
        Me.result.BackColor = System.Drawing.Color.Transparent
        Me.result.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.result.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.result.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.result.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.result.Location = New System.Drawing.Point(12, 22)
        Me.result.Name = "result"
        Me.result.Size = New System.Drawing.Size(655, 543)
        Me.result.TabIndex = 1
        Me.result.Text = "Label1"
        Me.result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'reverse
        '
        Me.reverse.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reverse.Location = New System.Drawing.Point(11, 593)
        Me.reverse.Name = "reverse"
        Me.reverse.Size = New System.Drawing.Size(56, 56)
        Me.reverse.TabIndex = 39
        Me.reverse.Text = "<"
        Me.reverse.UseVisualStyleBackColor = True
        '
        'first_player
        '
        Me.first_player.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.first_player.Location = New System.Drawing.Point(174, 593)
        Me.first_player.Name = "first_player"
        Me.first_player.Size = New System.Drawing.Size(94, 56)
        Me.first_player.TabIndex = 37
        Me.first_player.Text = "First"
        Me.first_player.UseVisualStyleBackColor = True
        Me.first_player.Visible = False
        '
        'second_player
        '
        Me.second_player.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.second_player.Location = New System.Drawing.Point(375, 593)
        Me.second_player.Name = "second_player"
        Me.second_player.Size = New System.Drawing.Size(94, 56)
        Me.second_player.TabIndex = 38
        Me.second_player.Text = "Second"
        Me.second_player.UseVisualStyleBackColor = True
        Me.second_player.Visible = False
        '
        'adjust
        '
        Me.adjust.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adjust.Location = New System.Drawing.Point(271, 593)
        Me.adjust.Name = "adjust"
        Me.adjust.Size = New System.Drawing.Size(94, 56)
        Me.adjust.TabIndex = 34
        Me.adjust.Text = "Adjust Cas"
        Me.adjust.UseVisualStyleBackColor = True
        Me.adjust.Visible = False
        '
        'confirm
        '
        Me.confirm.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.confirm.Location = New System.Drawing.Point(573, 593)
        Me.confirm.Name = "confirm"
        Me.confirm.Size = New System.Drawing.Size(94, 56)
        Me.confirm.TabIndex = 31
        Me.confirm.Text = "OK"
        Me.confirm.UseVisualStyleBackColor = True
        '
        'morale_check
        '
        Me.morale_check.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.morale_check.Location = New System.Drawing.Point(489, 593)
        Me.morale_check.Name = "morale_check"
        Me.morale_check.Size = New System.Drawing.Size(78, 56)
        Me.morale_check.TabIndex = 41
        Me.morale_check.Text = "Morale Check"
        Me.morale_check.UseVisualStyleBackColor = True
        Me.morale_check.Visible = False
        '
        'quality_check
        '
        Me.quality_check.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quality_check.Location = New System.Drawing.Point(405, 593)
        Me.quality_check.Name = "quality_check"
        Me.quality_check.Size = New System.Drawing.Size(78, 56)
        Me.quality_check.TabIndex = 42
        Me.quality_check.Text = "Quality Check"
        Me.quality_check.UseVisualStyleBackColor = True
        Me.quality_check.Visible = False
        '
        'resultform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 661)
        Me.Controls.Add(Me.quality_check)
        Me.Controls.Add(Me.morale_check)
        Me.Controls.Add(Me.reverse)
        Me.Controls.Add(Me.first_player)
        Me.Controls.Add(Me.second_player)
        Me.Controls.Add(Me.adjust)
        Me.Controls.Add(Me.confirm)
        Me.Controls.Add(Me.result)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(700, 700)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(700, 700)
        Me.Name = "resultform"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Result"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents result As System.Windows.Forms.Label
    Friend WithEvents reverse As Button
    Friend WithEvents first_player As Button
    Friend WithEvents second_player As Button
    Friend WithEvents adjust As Button
    Friend WithEvents confirm As Button
    Friend WithEvents morale_check As Button
    Friend WithEvents quality_check As Button
End Class
