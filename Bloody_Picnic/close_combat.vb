Imports System.ComponentModel

Public Class close_combat
    Public def_suppression As RadioButton, att_suppression As RadioButton, def_cover As RadioButton, att_cover As RadioButton, def_size As RadioButton, att_size As RadioButton
    Public def_supports As RadioButton, att_supports As RadioButton, def_quality As RadioButton, att_quality As RadioButton
    Public winner As String = "", loser As String = "", result As Integer = 0
    Public Sub reset_form()
        For Each c As Control In Controls
            If TypeOf c Is GroupBox Then reset_radio_buttons(c)
            If TypeOf c Is CheckBox Then
                Dim chk As CheckBox = DirectCast(c, CheckBox)
                chk.Checked = False
                chk.BackColor = but_col
            End If
        Next
        aq3.Checked = True
        dq3.Checked = True
        ac1.Checked = True
        dc1.Checked = True
        as3.Checked = True
        ds3.Checked = True
        asu1.Checked = True
        dsu1.Checked = True
        att_strength.Text = 0
        def_strength.Text = 0
        asp1.Checked = True
        dsp1.Checked = True
        For Each c As Control In Controls
            If TypeOf c Is RadioButton Then
                Dim chk As RadioButton = DirectCast(c, RadioButton)
                chk.BackColor = golden
            End If
        Next
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
    Private Sub fight_Click(sender As Object, e As EventArgs) Handles fight.Click
        If Val(att_strength.Text) = 0 Or Val(def_strength.Text) = 0 Then Exit Sub
        Dim att As Integer = dice(10), def As Integer = dice(10), msg_loser As String = "", msg_winner As String = ""
        att = att + Val(att_strength.Text) - 1
        def = def + Val(def_strength.Text) - 1
        att = att + 8 - Val(att_quality.Tag)
        def = def + 8 - Val(def_quality.Tag)
        def = def + Val(def_cover.Tag)
        If def_entrenched.Checked And att_entrenched.Checked Then att = att + Val(def_cover.Tag) - 1
        att = att + Val(att_supports.Tag)
        def = def + Val(def_supports.Tag)
        att = att + Val(att_suppression.Tag)
        def = def + Val(def_suppression.Tag)
        att = att + Val(att_size.Tag)
        def = def + Val(def_size.Tag)
        def = def + IIf(def_flank.Checked, -2, 0)
        If (att_cover.Text = "0" And att_cav.Checked) Or (def_cover.Text = "1" And def_entrenched.Checked And att_cav.Checked) Then att = att + 2
        If (def_cover.Text = "0" And def_cav.Checked) Or (def_cover.Text = "1" And att_entrenched.Checked And def_cav.Checked) Then def = def + 2
        If att_cav.Checked And att_cav_dis.Checked And def_cav.Checked Then att = att - 2
        If def_cav.Checked And def_cav_dis.Checked And att_cav.Checked Then def = def - 2

        Dim pursuit As Boolean = False
        result = Math.Abs(att - def)
        If att_entrenched.Checked And def_entrenched.Checked And result <> 0 Then result = result - 1
        If att > def And result > 1 Then
            winner = attacker.Text : loser = defender.Text
            If result > 5 And dice(10) < Val(att_quality.Tag) Then pursuit = True
        ElseIf def > att And result > 1 Then
            winner = defender.Text : loser = attacker.Text
        Else
            winner = "Draw"
            If def < att Then loser = defender.Text Else loser = attacker.Text
        End If
        If result > 5 Then
            msg_loser = loser + " routs immediately" + vbNewLine + close_combat_results(IIf(loser = defender.Text, Val(def_strength.Text), Val(att_strength.Text)), 1, 3, IIf(loser = defender.Text, Val(def_quality.Tag), Val(att_quality.Tag)))
            msg_winner = winner + " has won the close combat" + IIf(winner = defender.Text, " and holds their ground", "") + IIf(winner = attacker.Text, IIf(pursuit, " Cavalry will pursue, or Infantry will follow up", " seizes the position"), "") + vbNewLine
            msg_winner = msg_winner + close_combat_results(checks_required(Val(att_strength.Text), Val(def_strength.Text), 2, IIf(winner = attacker.Text, Val(def_strength.Text), Val(att_strength.Text))), 0, 1, IIf(loser = defender.Text, 1 + Val(def_quality.Tag), 1 + Val(att_quality.Tag)))
            With resultform
                .Tag = "close combat"
                .subject = loser
                .quality_check.Visible = True
                .morale_check.Visible = True
                .result.Text = msg_loser
                .ShowDialog()
                .subject = winner
                .result.Text = msg_winner
                .ShowDialog()
                .quality_check.Visible = False
                .morale_check.Visible = False
            End With
        ElseIf result > 1 Then
            msg_loser = loser + " retires immediately " + IIf(loser = defender.Text, " a minimum of 100m", " half a move and a minimum of 50m") + vbNewLine
            msg_loser = msg_loser + close_combat_results(IIf(loser = defender.Text, Val(def_strength.Text), Val(att_strength.Text)), 1, 3, IIf(loser = defender.Text, Val(def_quality.Tag), Val(att_quality.Tag)))
            msg_winner = winner + " has won the close combat" + IIf(winner = defender.Text, " and holds their ground", " seizes the position") + vbNewLine
            msg_winner = msg_winner + close_combat_results(checks_required(Val(att_strength.Text), Val(def_strength.Text), 3, IIf(winner = attacker.Text, Val(def_strength.Text), Val(att_strength.Text))), 0, 1, IIf(loser = defender.Text, Val(def_quality.Tag), Val(att_quality.Tag)))
            With resultform
                .Tag = "close combat"
                .subject = loser
                .quality_check.Visible = True
                .morale_check.Visible = True
                .result.Text = msg_loser
                .ShowDialog()
                .result.Text = msg_winner
                .subject = winner
                .ShowDialog()
                .subject = winner
                .quality_check.Visible = False
                .morale_check.Visible = False
            End With
        Else
            Dim msg As String = "A draw, close combat continues in the next phase." + vbNewLine + "No one retires" + vbNewLine
            If Val(def_strength.Text) <= Val(att_strength.Text) Then
                msg_loser = msg + defender.Text + " suffers " + close_combat_results(Val(def_strength.Text), 0, IIf(result = 1 And loser = defender.Text, 2, 1), Val(def_quality.Tag))
                msg_winner = msg + attacker.Text + " suffers " + close_combat_results(checks_required(Val(att_strength.Text), Val(def_strength.Text), 4, "attacker"), 0, IIf(result = 1 And loser = attacker.Text, 2, 1), Val(att_quality.Tag))

            Else
                msg_loser = msg + defender.Text + " suffers " + close_combat_results(checks_required(Val(att_strength.Text), Val(def_strength.Text), 4, "defender"), 0, IIf(result = 1 And loser = defender.Text, 2, 1), Val(def_quality.Tag))
                msg_winner = msg + attacker.Text + " suffers " + close_combat_results(Val(att_strength.Text), 0, IIf(result = 1 And loser = attacker.Text, 2, 1), Val(att_quality.Tag))
            End If
            With resultform
                .Tag = "close combat"
                .subject = loser
                .result.Text = msg_loser
                .quality_check.Visible = True
                .morale_check.Visible = True
                .ShowDialog()
                .subject = IIf(attacker.Text = loser, defender.Text, attacker.Text)
                .result.Text = msg_winner
                .ShowDialog()
                .quality_check.Visible = False
                .morale_check.Visible = False
            End With

        End If
    End Sub

    Private Sub swap_attacker(sender As Object, e As EventArgs) Handles attacker.Click, defender.Click
        Dim tmp As String = attacker.Text
        attacker.Text = defender.Text
        defender.Text = tmp
    End Sub
    Private Sub check_color(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
  att_entrenched.CheckedChanged, def_entrenched.CheckedChanged,
att_cav.CheckedChanged, att_cav_dis.CheckedChanged, def_cav.CheckedChanged, def_cav_dis.CheckedChanged,
def_flank.CheckedChanged

        If sender.checked Then sender.backcolor = golden Else sender.backcolor = but_col
    End Sub

    Private Sub def_morale_Click(sender As Object, e As EventArgs) Handles def_morale.Click
        With morale_test
            .reset_form()
            .Tag = "pre combat"
            .Player.Text = p2 + " Pre-Close Combat Morale Test"
            .set_subject(def_cover.Text)
            .target_entrenched.Checked = def_entrenched.Checked
            .set_subject("Not")
            .set_subject(def_quality.AccessibleName)
            .set_subject(def_suppression.Text)
            .close_combat.Enabled = False
            .cc1.Checked = True
            .cc1.BackColor = golden
            .ShowDialog()
            .reset_form()
            .Tag = ""
        End With

    End Sub

    Private Sub reverse_Click(sender As Object, e As EventArgs) Handles reverse.Click
        scenariodefaults.quit = False
        goback = True
        Me.Hide()

    End Sub

    Private Sub nextphase_Click(sender As Object, e As EventArgs) Handles nextphase.Click
        scenariodefaults.quit = False
        Me.Hide()

    End Sub

    Private Sub Reset_Click(sender As Object, e As EventArgs) Handles Reset.Click
        reset_form()
    End Sub

    Private Function checks_required(att As Integer, def As Integer, factor As Integer, winner As String)
        checks_required = 0
        If winner = "attacker" Then
            If def * factor > att Then checks_required = att Else checks_required = def * factor
        Else
            If att * factor > def Then checks_required = def Else checks_required = att * factor
        End If
    End Function
    Private Function close_combat_results(checks As Integer, capture As Integer, kill As Integer, quality As Integer)
        close_combat_results = ""
        Dim captured As Integer = 0, kills As Integer = 0, suppressions As Integer = 0, d As Integer = 0
        For i As Integer = 1 To checks
            d = dice(10)
            If d >= quality Then
            ElseIf d > kills Then
                suppressions = suppressions + 1
            ElseIf d > capture Then
                kills = kills + 1
            Else
                captured = captured + 1
            End If
        Next
        If captured + kills + suppressions = 0 Then
            close_combat_results = " no effects"
        Else
            close_combat_results = IIf(captured > 0, Str(captured) + " elements captured, ", "") + IIf(kills > 0, Str(kills) + " elements killed, ", "") + IIf(suppressions > 0, Str(suppressions) + " suppression points", "")
        End If
    End Function
    Private Sub select_suppression(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dsu1.CheckedChanged, dsu2.CheckedChanged, dsu3.CheckedChanged, asu1.CheckedChanged, asu2.CheckedChanged
        If Strings.Left(sender.name, 1) = "d" Then
            def_suppression = def_supp_options.Controls.OfType(Of RadioButton).FirstOrDefault(Function(r) r.Checked = True)
        Else
            att_suppression = att_supp_options.Controls.OfType(Of RadioButton).FirstOrDefault(Function(r) r.Checked = True)
        End If
        If sender.checked Then sender.backcolor = golden Else sender.backcolor = but_col
    End Sub
    Private Sub select_cover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dc1.CheckedChanged, dc2.CheckedChanged, dc3.CheckedChanged, dc4.CheckedChanged, ac1.CheckedChanged, ac2.CheckedChanged, ac3.CheckedChanged, ac4.CheckedChanged
        If Strings.Left(sender.name, 1) = "d" Then
            def_cover = def_cover_options.Controls.OfType(Of RadioButton).FirstOrDefault(Function(r) r.Checked = True)
        Else
            att_cover = att_cover_options.Controls.OfType(Of RadioButton).FirstOrDefault(Function(r) r.Checked = True)
        End If
        If sender.checked Then sender.backcolor = golden Else sender.backcolor = but_col
    End Sub
    Private Sub select_quality(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dq2.CheckedChanged, dq3.CheckedChanged, dq4.CheckedChanged, dq1.CheckedChanged, aq4.CheckedChanged, aq3.CheckedChanged, aq2.CheckedChanged, aq1.CheckedChanged
        If Strings.Left(sender.name, 1) = "d" Then
            def_quality = def_quality_options.Controls.OfType(Of RadioButton).FirstOrDefault(Function(r) r.Checked = True)
        Else
            att_quality = att_quality_options.Controls.OfType(Of RadioButton).FirstOrDefault(Function(r) r.Checked = True)
        End If
        If sender.checked Then sender.backcolor = golden Else sender.backcolor = but_col
    End Sub
    Private Sub select_size(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ds1.CheckedChanged, ds2.CheckedChanged, ds3.CheckedChanged, ds4.CheckedChanged, ds5.CheckedChanged, as5.CheckedChanged, as1.CheckedChanged, as2.CheckedChanged, as3.CheckedChanged, as4.CheckedChanged
        If Strings.Left(sender.name, 1) = "d" Then
            def_size = def_size_options.Controls.OfType(Of RadioButton).FirstOrDefault(Function(r) r.Checked = True)
        Else
            att_size = att_size_options.Controls.OfType(Of RadioButton).FirstOrDefault(Function(r) r.Checked = True)
        End If
        If sender.checked Then sender.backcolor = golden Else sender.backcolor = but_col
    End Sub
    Private Sub select_supports(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dsp1.CheckedChanged, dsp2.CheckedChanged, dsp3.CheckedChanged, asp1.CheckedChanged, asp2.CheckedChanged, asp3.CheckedChanged
        If Strings.Left(sender.name, 1) = "d" Then
            def_supports = def_support_options.Controls.OfType(Of RadioButton).FirstOrDefault(Function(r) r.Checked = True)
        Else
            att_supports = att_support_options.Controls.OfType(Of RadioButton).FirstOrDefault(Function(r) r.Checked = True)
        End If
        If sender.checked Then sender.backcolor = golden Else sender.backcolor = but_col
    End Sub
    Private Sub inc_dec_strength(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles inc_def.Click, dec_def.Click, inc_att.Click, dec_att.Click
        If (sender.name = "dec_def" And def_strength.Text = 0) Or (sender.name = "dec_att" And att_strength.Text = 0) Then Exit Sub
        If InStr(sender.name, "def") > 0 Then
            def_strength.Text = def_strength.Text + IIf(Strings.Left(sender.name, 3) = "dec", -1, 1)
        Else
            att_strength.Text = att_strength.Text + IIf(Strings.Left(sender.name, 3) = "dec", -1, 1)
        End If
    End Sub

    Private Sub close_combat_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If scenariodefaults.quit Then quitprogram()

    End Sub
End Class