Public Class Form1
    Dim num1, num2, num3 As Long

    ' ######################################################################################################
    ' RADIO BUTTONS
    ' ######################################################################################################
    ' COMMAND BUTTON
    Private Sub btnCalc1_Click(sender As Object, e As EventArgs) Handles btnCalc1.Click
        num1 = CInt(ValidNum(txtNum11.Text))
        num2 = CInt(ValidNum(txtNum11.Text))
        If rbtPow.Checked Then
            num3 = (num1 ^ num2)
        ElseIf rbtMod.Checked Then
            num3 = num1 Mod num2
        ElseIf rbtDiv.Checked Then
            num3 = num1 \ num2
        End If
        txtRes1.Text = num3
    End Sub

    ' ######################################################################################################
    ' RADIO BUTTON CHANGED
    Private Sub rbtPow_CheckedChanged(sender As Object, e As EventArgs) Handles rbtPow.CheckedChanged
        num1 = CInt(ValidNum(txtNum11.Text))
        num2 = CInt(ValidNum(txtNum21.Text))
        num3 = num1 ^ num2
        txtRes1.Text = num3
    End Sub
    Private Sub rbtMod_CheckedChanged(sender As Object, e As EventArgs) Handles rbtMod.CheckedChanged

        num1 = CInt(ValidNum(txtNum11.Text))
        num2 = CInt(ValidNum(txtNum21.Text))
        num3 = num1 Mod num2
        txtRes1.Text = num3
    End Sub
    Private Sub rbtDiv_CheckedChanged(sender As Object, e As EventArgs) Handles rbtDiv.CheckedChanged
        num1 = CInt(ValidNum(txtNum11.Text))
        num2 = CInt(ValidNum(txtNum21.Text))
        num3 = num1 \ num2
        txtRes1.Text = num3
    End Sub
    ' ######################################################################################################
    ' USING SENDER OBJECT HANDLING EVENT
    Private Sub rbtHandlers(sender As Object, e As EventArgs) Handles rbtPow.CheckedChanged, rbtMod.CheckedChanged, rbtDiv.CheckedChanged
        Dim rbt As RadioButton = CType(sender, RadioButton)


        num1 = CInt(ValidNum(txtNum11.Text))
        num2 = CInt(ValidNum(txtNum21.Text))

        Select Case rbt.Name
            Case "rbtPow"
                num3 = (num1 ^ num2).ToString("E10")
            Case "rbtMod"
                num3 = num1 Mod num2
            Case "rbtDiv"
                num3 = num1 \ num2
        End Select
        txtRes1.Text = num3
    End Sub
    ' ######################################################################################################

    ' ######################################################################################################
    ' CHECK BUTTONS
    ' ######################################################################################################
    ' CHECK BOX TICK CHANGE
    Private Sub chkHandlers(sender As Object, e As EventArgs) Handles chkPow.Click, chkMod.Click, chkDiv.Click
        Dim chk As CheckBox = CType(sender, CheckBox)
        num1 = CInt(ValidNum(txtNum12.Text))
        num2 = CInt(ValidNum(txtNum22.Text))
        Select Case chk.Name
            Case "chkPow"
                chkPow.Checked = True
                chkMod.Checked = False
                chkDiv.Checked = False
                num3 = (num1 ^ num2).ToString("E10")
            Case "chkMod"
                chkMod.Checked = True
                chkPow.Checked = False
                chkDiv.Checked = False
                num3 = num1 Mod num2
            Case "chkDiv"
                chkDiv.Checked = True
                chkMod.Checked = False
                chkPow.Checked = False
                num3 = num1 \ num2
        End Select
        txtRes2.Text = num3
    End Sub

    ' ######################################################################################################
    ' A SIMPLE FUNCTION TO VALIDATE inputs
    Function ValidNum(str As String)
        If IsNumeric(str) Then
            Return str
        End If
        Return 1
    End Function
    ' ######################################################################################################
    ' CLEAR
    Private Sub btnClear1_Click(sender As Object, e As EventArgs) Handles btnClear1.Click
        txtNum11.Clear()
        txtNum21.Clear()
        txtRes1.Clear()
    End Sub
    Private Sub btnClear2_Click(sender As Object, e As EventArgs) Handles btnClear2.Click
        txtNum12.Clear()
        txtNum22.Clear()
        txtRes2.Clear()
    End Sub
End Class
