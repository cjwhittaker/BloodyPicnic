Public Class calculator
    Dim entering As Boolean = False
    Private Sub multiplier_Click(sender As Object, e As EventArgs) Handles multiplier.Click
        If multiplier.Text = "1" Then
            '    multiplier.Text = "2"
            'ElseIf multiplier.Text = "2" Then
            multiplier.Text = "0.5"
        ElseIf multiplier.Text = "0.5" Then
            multiplier.Text = "1"
        Else
        End If
        calc_pts()
    End Sub
    Private Sub calc_pts()
        If Me.Tag = "1" Then
            points.Text = (Val(factor.Text) * Val(multiplier.Text) * Val(elements.Text))

            'Else
            '    routers.Text = elements.Text
        End If
    End Sub

    Private Sub clear_elements(sender As Object, e As EventArgs) Handles c.Click

        If Me.Tag = "1" Then
            points.Text = "-" + points.Text
            add_to_fp(add, Nothing)
            elements.Text = 0
            calc_pts()
        End If
        entering = False
    End Sub

    Private Sub add_elements(sender As Object, e As EventArgs) Handles b1.Click, b2.Click, b3.Click, b4.Click, b5.Click, b6.Click, b7.Click, b8.Click, b9.Click, b0.Click
        If Not entering Then
            entering = True
            elements.Text = sender.text
        Else
            elements.Text = elements.Text + sender.text
        End If
        calc_pts()
    End Sub



    Private Sub calculator_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        calc_pts()
        entering = False
        If Me.Tag = "rout" Then
            For Each c As Control In Me.Controls
                If c.Tag <> "c" Then c.Visible = False
            Next
            'routers.Visible = True
            'add_routers.Visible = True
            'routers.Text = "0"
            Me.Width = 224
            Me.Text = "Add Routers"
        Else
            For Each c As Control In Me.Controls
                If c.Name <> "wpn" Then c.Visible = True
            Next
            'routers.Visible = False
            'add_routers.Visible = False
            Me.Width = 344
            Me.Text = "Fire Points calculator"

        End If

    End Sub
    Private Sub calculator_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        If Me.Tag = "rout" Then
            For Each c As Control In Me.Controls
                If c.Tag <> "c" Then c.Visible = True
            Next
            Me.Width = 334
            Me.Text = "Fire Points Calculator"
        End If

    End Sub


    Private Sub add_to_fp(sender As Object, e As EventArgs) Handles add.Click
        If wpn.Text = "hmg" Or wpn.Text = "rifles" Or wpn.Text = "carbines" Then
            Firing_1914.sa_fp = Firing_1914.sa_fp + Val(points.Text)
            If wpn.Text = "hmg" Then Firing_1914.hmg_fp = Firing_1914.hmg_fp + Val(points.Text)
        ElseIf wpn.Text = "how" Then
            Firing_1914.how_fp = Firing_1914.how_fp + Val(points.Text)
        Else
            Firing_1914.gun_fp = Firing_1914.gun_fp + Val(points.Text)
        End If
        Firing_1914.firepoints.Text = Val(Firing_1914.firepoints.Text) + Val(points.Text)
        If Val(Firing_1914.firepoints.Text) < 0 Then Firing_1914.firepoints.Text = "0"
    End Sub
End Class