Public Class morale_test
    Public rally_ends As Boolean = False, rallied As Boolean = False, tester As cunit, immediate As Boolean, modifier As Integer = 0, rallying As Boolean, result As String = ""
    Public subject_quality As RadioButton, subject_context As RadioButton, subject_type As RadioButton, subject_losses As RadioButton
    Public subject_cover As RadioButton, subject_fire As RadioButton, subject_suppression As RadioButton, subject_combat As RadioButton
    Public Sub reset_form()
        For Each c As Control In Controls
            If TypeOf c Is GroupBox Then reset_radio_buttons(c, False, but_col)
            If TypeOf c Is CheckBox Then
                Dim chk As CheckBox = DirectCast(c, CheckBox)
                chk.Checked = False
                chk.BackColor = but_col
            End If
        Next
        t2.Checked = True
        hq1.Checked = True
        l1.Checked = True
        f1.Checked = True
        For Each c As Control In Controls
            If TypeOf c Is RadioButton Then
                For Each r As Control In c.Controls
                    If TypeOf r Is RadioButton Then
                        Dim chk As RadioButton = DirectCast(r, RadioButton)
                        If chk.Checked Then chk.BackColor = golden
                    End If
                Next
            End If
        Next
    End Sub

    Private Sub reset_radio_buttons(gp As GroupBox, setting As Boolean, col As Color)
        For Each c As Control In gp.Controls
            If TypeOf c Is RadioButton Then
                Dim chk As RadioButton = DirectCast(c, RadioButton)
                If chk.Enabled = False Then chk.Enabled = True
                chk.Checked = setting
                chk.BackColor = col
            End If
        Next
    End Sub
    Public Sub set_subject(info As String)
        For Each c As Control In Controls
            If TypeOf c Is GroupBox Then
                For Each r As Control In c.Controls
                    If TypeOf r Is RadioButton And r.Text = info Then
                        Dim chk As RadioButton = DirectCast(r, RadioButton)
                        chk.Checked = True
                        chk.BackColor = golden
                    End If
                Next
            End If
        Next
    End Sub

    Private Sub select_modifiers(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If sender.backcolor = golden Then sender.backcolor = defa Else sender.backcolor = golden
    End Sub
    Private Sub check_color(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles target_entrenched.CheckedChanged, behind_flank.CheckedChanged
        If sender.checked Then
            sender.backcolor = Color.Goldenrod
            If sender.name = "target_entrenched" Then c1.Checked = True
        Else
            sender.backcolor = Control.DefaultBackColor
            If sender.name = "target_entrenched" Then c0.Checked = True
        End If
    End Sub

    Private Sub select_quality(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles militia.CheckedChanged, reservist.CheckedChanged, regular.CheckedChanged, veteran.CheckedChanged
        subject_quality = quality.Controls.OfType(Of RadioButton).FirstOrDefault(Function(r) r.Checked = True)
        If sender.checked Then sender.backcolor = golden Else sender.backcolor = defa
    End Sub
    Private Sub select_context(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t1.CheckedChanged, t2.CheckedChanged, t3.CheckedChanged, t4.CheckedChanged, t5.CheckedChanged
        subject_context = context.Controls.OfType(Of RadioButton).FirstOrDefault(Function(r) r.Checked = True)
        If sender.checked Then sender.backcolor = golden Else sender.backcolor = defa
    End Sub
    Private Sub select_subject_type(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hq1.CheckedChanged, hq2.CheckedChanged, hq3.CheckedChanged
        subject_type = unit_type.Controls.OfType(Of RadioButton).FirstOrDefault(Function(r) r.Checked = True)
        If sender.checked Then sender.backcolor = golden Else sender.backcolor = defa
    End Sub
    Private Sub select_losses(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles l1.CheckedChanged, l2.CheckedChanged, l3.CheckedChanged, l4.CheckedChanged
        subject_losses = losses.Controls.OfType(Of RadioButton).FirstOrDefault(Function(r) r.Checked = True)
        If sender.checked Then sender.backcolor = golden Else sender.backcolor = defa
    End Sub
    Private Sub select_cover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c1.CheckedChanged, c2.CheckedChanged, c3.CheckedChanged, c0.CheckedChanged
        subject_cover = cover.Controls.OfType(Of RadioButton).FirstOrDefault(Function(r) r.Checked = True)
        If sender.checked Then sender.backcolor = golden Else sender.backcolor = defa
    End Sub
    Private Sub select_subject_fire(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles f1.CheckedChanged, f2.CheckedChanged, f3.CheckedChanged
        subject_fire = under_fire.Controls.OfType(Of RadioButton).FirstOrDefault(Function(r) r.Checked = True)
        If sender.checked Then sender.backcolor = golden Else sender.backcolor = defa
    End Sub

    Private Sub select_subject_suppression(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles s1.CheckedChanged, s2.CheckedChanged, s3.CheckedChanged
        subject_suppression = suppression.Controls.OfType(Of RadioButton).FirstOrDefault(Function(r) r.Checked = True)
        If sender.checked Then sender.backcolor = golden Else sender.backcolor = defa
    End Sub
    Private Sub select_combat(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cc1.CheckedChanged, cc2.CheckedChanged, cc1.CheckedChanged
        subject_combat = close_combat.Controls.OfType(Of RadioButton).FirstOrDefault(Function(r) r.Checked = True)
        If sender.checked Then sender.backcolor = golden Else sender.backcolor = defa
    End Sub


    Public Sub testing(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles get_result.Click
        modifier = Val(subject_cover.Text) + Val(subject_fire.Tag) + Val(subject_losses.Tag) + Val(subject_suppression.Tag) + Val(subject_type.Tag) + Val(subject_combat.Tag)
        modifier = modifier + IIf(behind_flank.Checked, Val(behind_flank.Tag), 0)
        If Val(subject_cover.Text) > 1 And target_entrenched.Checked Then modifier = modifier + 1
        Dim score As Integer = (dice(10) + modifier) - Val(subject_quality.Tag)
        For i As Integer = 0 To 4
            If i = 4 Then result = morale_effects(i, Val(subject_context.Tag)) : Exit For
            If score >= morale_effects(i, 0) Then result = morale_effects(i, Val(subject_context.Tag)) : Exit For
        Next
        For i As Integer = 0 To 6
            If result = morale_effects(5, i) Then result = morale_effects(6, i) : Exit For
        Next
        If Tag = "firing" Or Tag = "close combat" Then
            resultform.result.Text = resultform.result.Text + vbNewLine + "Morale Test Result" + vbNewLine + result
            Close()
            Exit Sub
        ElseIf Tag = "rally" Or Tag = "pre combat" Then
            With resultform
                .result.Text = result
                .ShowDialog()
            End With
            Close()
        Else
        End If

    End Sub

    Private Sub ok_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ok_button.Click
        Me.Close()
    End Sub

    Private Sub rally_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        reset_form()
    End Sub

    Private Sub rally_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'reset_form()
    End Sub

End Class