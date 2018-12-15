Public Class Firing_1914
    Public factor_selected As Boolean, sa_fp As Integer, gun_fp As Integer, how_fp As Integer, hmg_fp As Integer
    Public target_quality As RadioButton, target_size As RadioButton, target_formation As RadioButton, target_cover As RadioButton
    Private Sub resetform()
        resetbuttons(Panel1)
        resetbuttons(Panel2)
        reset_radio_buttons(quality)
        reset_radio_buttons(firersize)
        reset_radio_buttons(formation)
        reset_radio_buttons(cover)
        target_quality = New RadioButton
        target_size = New RadioButton
        target_formation = New RadioButton
        target_cover = New RadioButton
        regular.Checked = True
        normal.Checked = True
        deployed.Checked = True
        c0.Checked = True
        sa_fp = 0
        gun_fp = 0
        how_fp = 0
        hmg_fp = 0
        firepoints.Text = 0
    End Sub
    Private Sub resetbuttons(o As Object)
        For Each c As Control In o.controls
            If TypeOf c Is CheckBox Then
                Dim chk As CheckBox = DirectCast(c, CheckBox)
                chk.Checked = False
                chk.BackColor = but_col
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
    Private Sub check_color(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
  target_entrenched.CheckedChanged, target_mounted.CheckedChanged,
target_moving.CheckedChanged, firer_moving.CheckedChanged, firer_suppressed.CheckedChanged, firing_gas_masks.CheckedChanged,
firer_hmg.CheckedChanged, indirect_fire.CheckedChanged

        If sender.checked Then sender.backcolor = golden Else sender.backcolor = defa
        If sender.name = "indirect_fire" And Not firer_suppressed.Checked Then
            dec_fire_points.Visible = sender.checked
            inc_fire_points.Visible = sender.checked
            fall_of_shot.Visible = sender.checked
            strength.Text = IIf(sender.checked, "Artillery Batterys", "Total Fire Points")
            For Each c As Control In Panel2.Controls
                If c.Tag = "df" Then c.Enabled = Not sender.checked
                If c.Tag = "if" Then c.Enabled = sender.checked
            Next
        ElseIf sender.name = "indirect_fire" And firer_suppressed.Checked Then
            sender.checked = False
        End If
    End Sub
    Private Sub select_quality(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles militia.CheckedChanged, reservist.CheckedChanged, regular.CheckedChanged, veteran.CheckedChanged
        target_quality = quality.Controls.OfType(Of RadioButton).FirstOrDefault(Function(r) r.Checked = True)
        If sender.checked Then sender.backcolor = golden Else sender.backcolor = but_col
    End Sub
    Private Sub select_size(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles small.CheckedChanged, large.CheckedChanged, normal.CheckedChanged
        target_size = firersize.Controls.OfType(Of RadioButton).FirstOrDefault(Function(r) r.Checked = True)
        If sender.checked Then sender.backcolor = golden Else sender.backcolor = but_col
    End Sub
    Private Sub select_formation(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dispersed.CheckedChanged, limbered.CheckedChanged, column.CheckedChanged, deployed.CheckedChanged
        target_formation = formation.Controls.OfType(Of RadioButton).FirstOrDefault(Function(r) r.Checked = True)
        If sender.checked Then sender.backcolor = golden Else sender.backcolor = but_col
    End Sub
    Private Sub select_cover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c0.CheckedChanged, c1.CheckedChanged, c2.CheckedChanged, c3.CheckedChanged
        target_cover = cover.Controls.OfType(Of RadioButton).FirstOrDefault(Function(r) r.Checked = True)
        If sender.checked Then sender.backcolor = golden Else sender.backcolor = but_col
    End Sub

    Private Sub fire_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fire.Click
        Dim cas As Integer, supp As Integer, modifier As Single, msg As String = "", d As Integer = 0, c As Integer = 0
        Dim effect As Integer = 0, f As Integer = firepoints.Text
        If f <= 0 Then Exit Sub
        Dim fp As Integer = 0
        If f <= 0 Then f = 0
        If Not indirect_fire.Checked Then
            modifier = 1
            If column.Checked Or limbered.Checked Then
                modifier = 3
            ElseIf target_moving.Checked Then
                modifier = 2
            ElseIf target_mounted.Checked Then
                modifier = 2
            Else
            End If
            effect = 0
            For i As Integer = 1 To 2
                If firer_hmg.Checked And effect <> 1 Then
                    effect = 1
                    modifier = modifier / 3
                ElseIf target_cover.text = 2 And effect <> 2 Then
                    effect = 2
                    modifier = modifier / 3
                ElseIf target_cover.text = 3 And effect <> 3 Then
                    effect = 3
                    modifier = modifier / 4
                ElseIf dispersed.Checked And effect <> 4 Then
                    effect = 4
                    modifier = modifier / 3
                ElseIf target_cover.text = 1 And effect <> 5 Then
                    effect = 5
                    modifier = modifier / 2
                ElseIf small.checked And effect <> 6 Then
                    effect = 6
                    modifier = modifier / 2
                ElseIf firer_moving.checked And effect <> 7 Then
                    effect = 7
                    modifier = modifier / 2
                ElseIf firing_gas_masks.checked And effect <> 8 Then
                    effect = 8
                    modifier = modifier / 2
                ElseIf firer_suppressed.checked And effect <> 9 Then
                    effect = 9
                    modifier = modifier / 2
                Else
                End If
            Next
            f = Int((f * modifier) + 0.5)
            For i As Integer = 0 To 15
                If f <= firechart(i) Then effect = i + 1 : Exit For
            Next
            modifier = Val(target_size.Tag)
        Else
            fp = Val(firepoints.Text)
            modifier = Val(target_formation.Tag)
        End If
        c = Val(target_cover.Text) + IIf(Val(target_cover.Text) > 0 And target_entrenched.Checked, 3, 0)
        For j As Integer = 3 To 1 Step -1
            If Not indirect_fire.Checked Then
                Select Case j
                    Case 3 : fp = Int(0.5 + (effect * how_fp / Val(firepoints.Text)))
                    Case 2 : fp = Int(0.5 + (effect * gun_fp / Val(firepoints.Text)))
                    Case 1 : fp = Int(0.5 + (effect * sa_fp / Val(firepoints.Text)))
                End Select
            Else
                j = 2
            End If
            For i As Integer = 1 To fp
                d = dice(10) + modifier
                If d >= fire_effects(c, 1 + (j - 1) * 2) Then
                    cas = cas + 1
                ElseIf d >= fire_effects(c, (j - 1) * 2) Then
                    supp = supp + 1
                End If
            Next
            If indirect_fire.Checked Then Exit For
        Next
        If indirect_fire.Checked And supp > 0 And cas > 0 Then cas = 0
        If indirect_fire.Checked And supp > 1 Then supp = 1
        msg = p2 + " Target" + IIf(cas + supp = 0, " suffers no effect", "") + IIf(cas > 0, " loses " + Str(cas) + " elements", "") + IIf(cas > 0 And supp > 0, " and ", "") + IIf(supp > 0, " suffers" + Str(supp) + " suppression points", "")
        With resultform
            .result.Text = msg
            .Tag = "firing"
            .reverse.Visible = False
            .morale_check.Visible = True
            .quality_check.Visible = True
            .ShowDialog()
            .morale_check.Visible = False
            .quality_check.Visible = False
            .reverse.Visible = False
        End With
        If supp + cas > 0 Then

        End If
        'If Not Artillery.Checked Then
        '    If Me.Tag = scenariodefaults.player1.Text Then
        '        casualties.p2_cas.Value = casualties.p2_cas.Value + cas
        '        casualties.p2_cas_c.Text = "[" + Str(cas) + "]"
        '    Else
        '        casualties.p1_cas.Value = casualties.p1_cas.Value + cas
        '        casualties.p1_cas_c.Text = "[" + Str(cas) + "]"
        '    End If
        'Else
        '    If InStr(msg, "damaged") > 0 Then
        '    cas = 0.334
        'ElseIf InStr(msg, "wrecked") > 0 Then
        '    cas = 0.667
        'Else
        '    cas = 0
        'End If

        'If Me.Tag = scenariodefaults.player1.Text Then
        '    casualties.p2_art.Value = casualties.p2_art.Value + cas
        '    casualties.p2_art_c.Text = "[" + Str(cas) + "]"
        'Else
        '    casualties.p1_art.Value = casualties.p1_art.Value + cas
        '    casualties.p1_art_c.Text = "[" + Str(cas) + "]"
        'End If
        'End If

        If Not indirect_fire.Checked Then resetform()
    End Sub

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        resetform()
    End Sub

    Private Sub Reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Reset.Click
        resetform()
    End Sub

    Private Sub adjust_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles adjust.Click
        casualties.ShowDialog()
    End Sub

    Private Sub nextphase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        scenariodefaults.quit = False
        Me.Hide()
    End Sub


    Private Sub Firing_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If scenariodefaults.quit Then quitprogram()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles reverse.Click
        scenariodefaults.quit = False
        goback = True
        Me.Hide()
    End Sub

    Private Sub inc_dec_fire_points(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles inc_fire_points.Click, dec_fire_points.Click
        If Strings.Left(sender.name, 3) = "dec" And firepoints.Text = 0 Then Exit Sub
        firepoints.Text = firepoints.Text + IIf(Strings.Left(sender.name, 3) = "dec", -1, 1)
    End Sub

    Private Sub firepoints_Click(sender As Object, e As EventArgs) Handles firepoints.Click
        firepoints.Text = 0
    End Sub

    Private Sub select_factor(sender As Object, e As EventArgs) Handles f1.Click,
        f6.Click, f7.Click, f8.Click, f11.Click, f12.Click, f13.Click, f16.Click, f17.Click, f18.Click, Label19.Click
        If indirect_fire.Checked Then Exit Sub
        With calculator
            .StartPosition = FormStartPosition.Manual
            .Location = New Point(Me.Location.X - 300, Me.Location.Y + 175)
            .factor.Text = sender.text
            .wpn.Text = sender.tag
            .elements.Text = 1
            .multiplier.Text = 1
            .Tag = "1"
            .points.Text = Str(Val(.elements.Text) * Val(.multiplier.Text) * Val(.factor.Text))
            .Show()
        End With
    End Sub

    Private Sub integrated_mgs(sender As Object, e As EventArgs)
        If InStr(sender.text, "Int MG") > 0 Then
            sender.text = Replace(sender.text, " & Int MG", "")
            For Each c As Control In Me.Controls
                If c.Tag = Strings.Left(sender.text, 2) Then c.Text = c.Text - 1
            Next
        Else
            sender.text = sender.text + " & Int MG"
            For Each c As Control In Me.Controls
                If c.Tag = Strings.Left(sender.text, 2) Then c.Text = c.Text + 1
            Next
        End If

    End Sub

    Private Sub firer_quality(sender As Object, e As EventArgs) Handles rifles_quality.Click, carbines_quality.Click
        If indirect_fire.Checked Then Exit Sub

        If sender.Text = "Reg" Then
            sender.Text = "Vet"
            increase_fire_pts(1, sender.name)
        ElseIf sender.Text = "Vet" Then
            sender.Text = "Mil"
            increase_fire_pts(-2, sender.name)
        ElseIf sender.Text = "Mil" Then
            sender.Text = "Reg"
            increase_fire_pts(1, sender.name)
        Else
        End If

    End Sub

    Private Sub nextphase_Click_1(sender As Object, e As EventArgs) Handles nextphase.Click
        scenariodefaults.quit = False
        Me.Hide()

    End Sub

    Private Sub fall_of_shot_Click(sender As Object, e As EventArgs) Handles fall_of_shot.Click
        Dim msg As String = ""
        If dice(6) > 4 Then
            msg = "Artillery Battery on Target"
        Else
            msg = "Artillery off target" + vbNewLine + "fall of shot is " + Str(dice(10) * 50) + "m " + compass(dice(8)) + " of the aiming point"
        End If
        With resultform
            .adjust.Visible = False
            .result.Text = msg
            .ShowDialog()
            .adjust.Visible = True
        End With
    End Sub


    Private Sub firer_size(sender As Object, e As EventArgs) Handles carbines_size.Click, rifles_size.Click
        If indirect_fire.Checked Then Exit Sub
        If sender.Text = "250" Then
            sender.Text = ">300"
            increase_fire_pts(1, sender.name)
        ElseIf sender.Text = ">300" Then
            sender.Text = ">400"
            increase_fire_pts(1, sender.name)
        ElseIf sender.Text = ">400" Then
            sender.Text = "<200"
            increase_fire_pts(-3, sender.name)
        ElseIf sender.Text = "<200" Then
            sender.Text = "<100"
            increase_fire_pts(-1, sender.name)
        ElseIf sender.Text = "<100" Then
            sender.Text = "250"
            increase_fire_pts(3, sender.name)

        Else
        End If

    End Sub
    Private Sub increase_fire_pts(x As Integer, weapon As String)
        weapon = Strings.Left(weapon, InStr(weapon, "_") - 1)
        For Each c As Control In Me.Controls
            If c.Tag = LCase(weapon) Then c.Text = c.Text + x
        Next
    End Sub

    Private Sub arty_size_factors(sender As Object, e As EventArgs) Handles field_arty_size.Click, hmg_size.Click, french_arty_size.Click
        If indirect_fire.Checked Then Exit Sub
        Dim lab As Label = DirectCast(sender, Label)
        Dim wpn As String = lab.AccessibleName

        If sender.Text = "6" Then
            sender.Text = "4"
            increase_arty_pts(6, 4, wpn)
        ElseIf sender.Text = "4" Then
            sender.Text = "2"
            increase_arty_pts(4, 2, wpn)
        ElseIf sender.Text = "2" Then
            sender.text = sender.tag
            increase_arty_pts(2, Val(sender.text), wpn)
        Else
        End If

    End Sub
    Private Sub increase_arty_pts(x As Integer, y As Integer, weapon As String)
        'weapon = Strings.Left(weapon, InStr(weapon, "_") - 1)
        For Each c As Control In Me.Controls
            If c.Tag = LCase(weapon) Then c.Text = Val(c.Text) * y / x
        Next
    End Sub


End Class