Public Class resultform
    Public newresult As String = "", subject As String

    Private Sub confirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles confirm.Click
        'If scenariodefaults.phase <= 5 Then scenariodefaults.quit = False
        Me.Close()
    End Sub
    Private Sub resultform_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'If scenariodefaults.phase = 1 Then
        '    If scenariodefaults.p1 = scenariodefaults.player1.Text Then
        '        If supercedes.Checked Then player1_cinc_superceding = True Else player1_cinc_superceding = False
        '        If attached.Checked Then player1_cinc_attached = True Else player1_cinc_attached = False
        '    Else
        '        If supercedes.Checked Then player2_cinc_superceding = True Else player2_cinc_superceding = False
        '        If attached.Checked Then player2_cinc_attached = True Else player2_cinc_attached = False
        '    End If
        'End If

        'If scenariodefaults.phase <= 5 And scenariodefaults.quit Then quitprogram()
    End Sub
    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub adjust_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles adjust.Click
        If Me.Tag <> "" Then
            If Not generals Is Nothing Then generals(Me.Tag).deployed = True
        Else
            casualties.ShowDialog()
        End If


    End Sub

    Private Sub leader_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If leader.Checked Then
        '    If Me.Tag = scenariodefaults.player1.Text Then
        '        casualties.p1_ldr.Value = casualties.p1_ldr.Value + 1
        '        casualties.p1_ldr_c.Text = "[1]"
        '        'player1_cinc_dead = True
        '    Else
        '        casualties.p2_ldr.Value = casualties.p2_ldr.Value + 1
        '        casualties.p2_ldr_c.Text = "[1]"
        '        'player2_cinc_dead = True
        '    End If
        'Else
        '    If Me.Tag = scenariodefaults.player1.Text Then
        '        casualties.p1_ldr.Value = casualties.p1_ldr.Value - 1
        '        casualties.p1_ldr_c.Text = "[ ]"
        '        ''player1_cinc_dead = False
        '    Else
        '        casualties.p2_ldr.Value = casualties.p2_ldr.Value - 1
        '        casualties.p2_ldr_c.Text = "[ ]"
        '        'player2_cinc_dead = False
        '    End If
        'End If
    End Sub

    Private Sub arty_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles reverse.Click
        scenariodefaults.quit = False
        goback = True
        Me.Hide()
    End Sub
    Private Sub first_player_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles first_player.Click
        Me.Tag = "First" : Me.Hide()
    End Sub

    Private Sub second_player_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles second_player.Click
        Me.Tag = "Second" : Me.Hide()
    End Sub

    Private Sub quality_check_Click(sender As Object, e As EventArgs) Handles quality_check.Click
        Dim failed As Boolean = False
        Dim d As Integer = dice(10)
        If Tag = "firing" Then
            If d + Val(Firing_1914.cover.Text) < Val(Firing_1914.target_quality.Tag) Then failed = True
        ElseIf Tag = "close combat" Then
            If subject = close_combat.attacker.Text Then
                If d + Val(close_combat.att_cover.Text) < Val(close_combat.att_quality.Tag) Then failed = True
            Else
                If d + Val(close_combat.def_cover.Text) < Val(close_combat.def_quality.Tag) Then failed = True
            End If

        Else
        End If
        If failed Then
            result.Text = result.Text + vbNewLine + "Failed quality test and loses a further element"
        Else
            result.Text = result.Text + vbNewLine + "Passed quality test"
        End If

    End Sub

    Private Sub morale_check_Click(sender As Object, e As EventArgs) Handles morale_check.Click
        If Tag = "firing" Then
            With morale_test
                .reset_form()
                .Tag = "firing"
                .Player.Text = p2 + " Firing Morale Test"
                .set_subject(Firing_1914.cover.Text)
                .target_entrenched.Checked = Firing_1914.target_entrenched.Checked
                .set_subject(IIf(Firing_1914.gun_fp + Firing_1914.how_fp > 0, "Arty Fire", IIf(Firing_1914.hmg_fp > 0, "MG Fire", "Not")))
                .set_subject(Firing_1914.target_quality.AccessibleName)
                .s3.Checked = True
                '.s3.BackColor = golden
                .close_combat.Enabled = False
                .cc1.Checked = True
                '.cc1.BackColor = golden
                .ShowDialog()
                .reset_form()
                .Tag = ""
            End With
        ElseIf Tag = "close combat" And subject = close_combat.attacker.Text Then
            With morale_test
                .reset_form()
                .Tag = "close combat"
                .Player.Text = subject + " Close Combat Morale Test"
                .set_subject(close_combat.att_cover.Text)
                .target_entrenched.Checked = close_combat.att_entrenched.Checked
                .set_subject(close_combat.att_quality.AccessibleName)
                .set_subject(close_combat.att_suppression.Text)
                .close_combat.Enabled = True
                .cc1.Enabled = False
                .cc3.Checked = IIf(close_combat.result > 1 And close_combat.loser = close_combat.attacker.Text, True, False)
                .cc3.BackColor = IIf(.cc3.Checked, golden, but_col)
                .cc2.Checked = IIf(close_combat.result > 1 And close_combat.loser <> close_combat.attacker.Text, True, False)
                .cc2.BackColor = IIf(.cc2.Checked, golden, but_col)
                .ShowDialog()
                .reset_form()
                .Tag = ""
            End With
        ElseIf Tag = "close combat" And subject = close_combat.defender.Text Then
            With morale_test
                .reset_form()
                .Tag = "close combat"
                .Player.Text = subject + " Close Combat Morale Test"
                .set_subject(close_combat.def_cover.Text)
                .target_entrenched.Checked = close_combat.def_entrenched.Checked
                .set_subject(close_combat.def_quality.AccessibleName)
                .set_subject(close_combat.def_suppression.Text)
                .close_combat.Enabled = True
                .cc3.Checked = IIf(close_combat.result > 1 And close_combat.loser = close_combat.defender.Text, True, False)
                '.cc3.BackColor = IIf(.cc3.Checked, golden, but_col)
                .cc2.Checked = IIf(close_combat.result > 1 And close_combat.loser <> close_combat.defender.Text, True, False)
                '.cc2.BackColor = IIf(.cc2.Checked, golden, but_col)
                .ShowDialog()
                .reset_form()
                .Tag = ""
            End With

        Else
        End If
    End Sub
End Class