Public Class movement
    Public mover_quality As RadioButton, mover_type As RadioButton, mover_suppression As RadioButton, mover_formation As RadioButton
    Public mover_hq As RadioButton, mover_terrain As RadioButton, mover_obstacle As RadioButton, mover_fire As RadioButton
    Private Sub reset_form()
        For Each c As Control In Controls
            If TypeOf c Is GroupBox Then reset_radio_buttons(c)
        Next
        regular.Checked = True
        t2.Checked = True
        deployed.Checked = True
        s0.Checked = True
        hq3.Checked = True
        te1.Checked = True
        o1.Checked = True
        f0.Checked = True

    End Sub

    Private Sub reset_radio_buttons(gp As GroupBox)
        For Each c As Control In gp.Controls
            If TypeOf c Is RadioButton Then
                Dim chk As RadioButton = DirectCast(c, RadioButton)
                chk.Checked = False
                chk.BackColor = but_col
            End If
        Next
    End Sub
    Private Sub select_quality(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles militia.CheckedChanged, reservist.CheckedChanged, regular.CheckedChanged, veteran.CheckedChanged
        mover_quality = quality.Controls.OfType(Of RadioButton).FirstOrDefault(Function(r) r.Checked = True)
        If sender.checked Then sender.backcolor = golden Else sender.backcolor = defa
    End Sub

    Private Sub get_result_Click(sender As Object, e As EventArgs) Handles get_result.Click
        If mover_suppression.Text = "4" Then Exit Sub
        Dim msg As String = "", n As Integer = 0, r As Integer = 0, d As Integer = dice(10)
        If d + Val(mover_hq.Tag) + Val(mover_fire.Tag) + Val(mover_formation.Tag) - Val(mover_suppression.Text) < Val(mover_quality.Tag) Then
            msg = "Unit cannot advance, but it may retire " + IIf(InStr(mover_type.Name, "Arty") > 0, vbNewLine + " Or unlimber", "")
        Else
            For i As Integer = 0 To 4
                If movement_rate(i, 0) = mover_type.Tag Then n = i : Exit For
            Next
            msg = mover_type.Tag + " basic move is" + Str(Val(movement_rate(n, 1)) * IIf(mover_suppression.Text <> "0", (4 - Val(mover_suppression.Text)) / 4, 1)) + "m"
            If mover_formation.Text = "Column" Then
                If mover_type.Tag = "Cavalry" Then
                    msg = msg + vbNewLine + "Plus 200m for moving in Column"
                ElseIf mover_type.Tag = "Infantry" Then
                    msg = msg + vbNewLine + "Plus 100m for moving in Column "
                Else
                End If
            End If
            If mover_terrain.Text <> "Good" Then
                If mover_terrain.Text = "Poor" Then
                    For i As Integer = 1 To movement_rate(n, 2)
                        r = r + dice(movement_rate(n, 3)) * 50
                    Next
                Else
                    For i As Integer = 1 To movement_rate(n, 4)
                        r = r + dice(movement_rate(n, 5)) * 50
                    Next
                End If
                msg = msg + vbNewLine + "Reduced by " + Str(r) + "m for moving through " + mover_terrain.Text + " terrain"
            End If
            If mover_obstacle.Text <> "None" Then
                If mover_obstacle.Text = "Minor" Then
                    For i As Integer = 1 To movement_rate(n, 6)
                        r = r + dice(movement_rate(n, 7)) * 50
                    Next
                Else
                    For i As Integer = 1 To movement_rate(n, 8)
                        r = r + dice(movement_rate(n, 9)) * 50
                    Next
                End If
                msg = msg + vbNewLine + "Reduced by " + Str(r) + "m for crossing a " + mover_obstacle.Text + " obstacle"
            End If
        End If
        With resultform
            .result.Text = msg
            .ShowDialog()
        End With
    End Sub


    Private Sub Reset_Click(sender As Object, e As EventArgs) Handles Reset.Click
        reset_form()
    End Sub

    Private Sub rally_Click(sender As Object, e As EventArgs) Handles rally.Click
        With morale_test
            .reset_form()
            .Tag = "rally"
            .Player.Text = p1 + " Morale Test to Rally"
            .set_subject("Rout")
            .set_subject(mover_quality.Text)
            .s2.Checked = IIf(Val(mover_suppression.Text) > 0, True, False)
            .s2.BackColor = IIf(.s2.Checked, golden, but_col)
            .s1.Checked = IIf(Val(mover_suppression.Text) = 0, True, False)
            .s1.BackColor = IIf(.s1.Checked, golden, but_col)
            .c0.Checked = True
            .c0.BackColor = golden
            .l1.Checked = True
            .l1.BackColor = golden
            .hq1.Checked = True
            .hq1.BackColor = golden
            .close_combat.Enabled = False
            .cc1.Checked = True
            .cc1.BackColor = golden
            .ShowDialog()
            .reset_form()
            .Tag = ""
        End With

    End Sub

    Private Sub recover_Click(sender As Object, e As EventArgs) Handles recover.Click
        Dim x As Integer = 0
        For i As Integer = 1 To Val(mover_suppression.Text)
            If dice(10) + Val(mover_fire.Tag) >= Val(mover_quality.AccessibleName) Then x = x + 1
        Next
        With resultform
            .result.Text = "Suppression Recovery" + vbNewLine + Str(x) + " suppression points have been recovered"
            .ShowDialog()
        End With
    End Sub
    Private Sub select_fire(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles f0.CheckedChanged, f1.CheckedChanged, f2.CheckedChanged, f3.CheckedChanged
        mover_fire = underfire.Controls.OfType(Of RadioButton).FirstOrDefault(Function(r) r.Checked = True)
        If sender.checked Then sender.backcolor = golden Else sender.backcolor = defa
    End Sub

    Private Sub select_type(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t1.CheckedChanged, t2.CheckedChanged, t3.CheckedChanged, t4.CheckedChanged, t5.CheckedChanged
        mover_type = troop_types.Controls.OfType(Of RadioButton).FirstOrDefault(Function(r) r.Checked = True)
        If sender.checked Then sender.backcolor = golden Else sender.backcolor = defa
    End Sub

    Private Sub select_formation(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dispersed.CheckedChanged, limbered.CheckedChanged, column.CheckedChanged, deployed.CheckedChanged
        mover_formation = formation.Controls.OfType(Of RadioButton).FirstOrDefault(Function(r) r.Checked = True)
        If sender.checked Then sender.backcolor = golden Else sender.backcolor = defa
    End Sub

    Private Sub nextphase_Click(sender As Object, e As EventArgs) Handles nextphase.Click
        scenariodefaults.quit = False
        Me.Hide()
    End Sub

    Private Sub reverse_Click(sender As Object, e As EventArgs) Handles reverse.Click
        scenariodefaults.quit = False
        goback = True
        Me.Hide()

    End Sub

    Private Sub select_suppression(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles s0.CheckedChanged, s1.CheckedChanged, s2.CheckedChanged, s3.CheckedChanged, s4.CheckedChanged
        mover_suppression = suppressions.Controls.OfType(Of RadioButton).FirstOrDefault(Function(r) r.Checked = True)
        If sender.checked Then sender.backcolor = golden Else sender.backcolor = defa
    End Sub
    Private Sub select_hq(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hq1.CheckedChanged, hq2.CheckedChanged, hq3.CheckedChanged
        mover_hq = hq.Controls.OfType(Of RadioButton).FirstOrDefault(Function(r) r.Checked = True)
        If sender.checked Then sender.backcolor = golden Else sender.backcolor = defa
    End Sub
    Private Sub select_terrain(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles te1.CheckedChanged, te2.CheckedChanged, te3.CheckedChanged
        mover_terrain = terrain_types.Controls.OfType(Of RadioButton).FirstOrDefault(Function(r) r.Checked = True)
        If sender.checked Then sender.backcolor = golden Else sender.backcolor = defa
    End Sub
    Private Sub select_obstacle(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles o1.CheckedChanged, o2.CheckedChanged, o3.CheckedChanged
        mover_obstacle = obstacles.Controls.OfType(Of RadioButton).FirstOrDefault(Function(r) r.Checked = True)
        If sender.checked Then sender.backcolor = golden Else sender.backcolor = defa
    End Sub

    Private Sub movement_Load(sender As Object, e As EventArgs) Handles Me.Load
        reset_form()
    End Sub


    Private Sub movement_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If scenariodefaults.quit Then quitprogram()
    End Sub
End Class