Public Class Form1
    Dim numPrev As Double = 0
    Dim isOperation As Boolean = False
    Dim isPercentClick As Boolean = False
    Dim isPressEqual As Boolean = False

    Private Sub Opreation()
        If isOperation = True Then
            isOperation = False
        End If
    End Sub

    Private Sub ErrorHandler(isError As Boolean)
        If isError = True Then
            btnPlus.Enabled = False
            btnMinus.Enabled = False
            btnMultiple.Enabled = False
            btnDivine.Enabled = False
            btnPercent.Enabled = False
            btnEqual.Enabled = False
            btnDel.Enabled = False
            btnDot.Enabled = False
        Else
            btnPlus.Enabled = True
            btnMinus.Enabled = True
            btnMultiple.Enabled = True
            btnDivine.Enabled = True
            btnPercent.Enabled = True
            btnEqual.Enabled = True
            btnDel.Enabled = True
            btnDot.Enabled = True
            lbHistory.Text = ""
        End If
    End Sub


    Private Sub Calculate()
        If (String.IsNullOrEmpty(lbHistory.Text)) Then
            If (isPercentClick = True) Then
                numPrev = Double.Parse(lbResult.Text) / 100
                isPercentClick = False
            Else
                numPrev = Double.Parse(lbResult.Text)
            End If
        Else
            Dim historyPart() As String = lbHistory.Text.Split(New String() {" "}, StringSplitOptions.None)
            Dim numCurr As Double = Double.Parse(lbResult.Text)
            If (isPercentClick = True) Then
                numCurr = numCurr / 100
                isPercentClick = False
            End If
            If (historyPart(1) = "+") Then
                numPrev = historyPart(0) + numCurr
            ElseIf (historyPart(1) = "-") Then
                numPrev = historyPart(0) - numCurr
            ElseIf (historyPart(1) = "*") Then
                numPrev = historyPart(0) * numCurr
            ElseIf (historyPart(1) = "/") Then
                If numCurr = 0 Then
                    lbResult.Text = "Cannot divine by 0"
                    ErrorHandler(True)
                Else
                    numPrev = historyPart(0) / numCurr
                End If
            End If
        End If
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Opreation()
        If lbResult.Text.Equals("Cannot divine by 0") Then
            ErrorHandler(True)
        End If

        If Not lbResult.Text.Equals("0") Then
            lbResult.Text = lbResult.Text & "0"
        End If
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Opreation()

        If lbResult.Text.Equals("0") Or lbResult.Text.Equals("Cannot divine by 0") Then
            If lbResult.Text.Equals("Cannot divine by 0") Then
                ErrorHandler(False)
            End If
            lbResult.Text = ""
        End If
        lbResult.Text = lbResult.Text & "1"
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Opreation()

        If lbResult.Text.Equals("0") Or lbResult.Text.Equals("Cannot divine by 0") Then
            If lbResult.Text.Equals("Cannot divine by 0") Then
                ErrorHandler(False)
            End If
            lbResult.Text = ""
        End If
        lbResult.Text = lbResult.Text & "2"
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Opreation()

        If lbResult.Text.Equals("0") Or lbResult.Text.Equals("Cannot divine by 0") Then
            If lbResult.Text.Equals("Cannot divine by 0") Then
                ErrorHandler(False)
            End If
            lbResult.Text = ""
        End If
        lbResult.Text = lbResult.Text & "3"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Opreation()

        If lbResult.Text.Equals("0") Or lbResult.Text.Equals("Cannot divine by 0") Then
            If lbResult.Text.Equals("Cannot divine by 0") Then
                ErrorHandler(False)
            End If
            lbResult.Text = ""
        End If
        lbResult.Text = lbResult.Text & "4"
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Opreation()

        If lbResult.Text.Equals("0") Or lbResult.Text.Equals("Cannot divine by 0") Then
            If lbResult.Text.Equals("Cannot divine by 0") Then
                ErrorHandler(False)
            End If
            lbResult.Text = ""
        End If
        lbResult.Text = lbResult.Text & "5"
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Opreation()

        If lbResult.Text.Equals("0") Or lbResult.Text.Equals("Cannot divine by 0") Then
            If lbResult.Text.Equals("Cannot divine by 0") Then
                ErrorHandler(False)
            End If
            lbResult.Text = ""
        End If
        lbResult.Text = lbResult.Text & "6"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Opreation()

        If lbResult.Text.Equals("0") Or lbResult.Text.Equals("Cannot divine by 0") Then
            If lbResult.Text.Equals("Cannot divine by 0") Then
                ErrorHandler(False)
            End If
            lbResult.Text = ""
        End If
        lbResult.Text = lbResult.Text & "7"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Opreation()

        If lbResult.Text.Equals("0") Or lbResult.Text.Equals("Cannot divine by 0") Then
            If lbResult.Text.Equals("Cannot divine by 0") Then
                ErrorHandler(False)
            End If
            lbResult.Text = ""
        End If
        lbResult.Text = lbResult.Text & "8"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Opreation()

        If lbResult.Text.Equals("0") Or lbResult.Text.Equals("Cannot divine by 0") Then
            If lbResult.Text.Equals("Cannot divine by 0") Then
                ErrorHandler(False)
            End If
            lbResult.Text = ""
        End If
        lbResult.Text = lbResult.Text & "9"
    End Sub

    Private Sub btnDot_Click(sender As Object, e As EventArgs) Handles btnDot.Click
        If String.IsNullOrEmpty(lbResult.Text) OrElse Double.Parse(lbResult.Text) = 0 Then
            lbResult.Text = "0."
        ElseIf lbResult.Text.Contains(".") Then
            Return
        Else
            lbResult.Text = lbResult.Text & "."
        End If
    End Sub



    Private Sub btnEqual_Click(sender As Object, e As EventArgs) Handles btnEqual.Click
        Dim historyPart() As String = lbHistory.Text.Split(New String() {" "}, StringSplitOptions.None)
        Dim numCurr As Double = If(String.IsNullOrEmpty(lbResult.Text), 0, Double.Parse(lbResult.Text))
        If (isPercentClick = True) Then
            numCurr = numCurr / 100
            isPercentClick = False
        End If

        lbHistory.Text = numPrev.ToString & " " & historyPart(1) & " " & numCurr & " = "
        If (historyPart(1) = "+") Then
            numPrev = lbHistory.Text.Split(New String() {" "}, StringSplitOptions.None)(0) + numCurr
        ElseIf (historyPart(1) = "-") Then
            numPrev = lbHistory.Text.Split(New String() {" "}, StringSplitOptions.None)(0) - numCurr
        ElseIf (historyPart(1) = "*") Then
            numPrev = lbHistory.Text.Split(New String() {" "}, StringSplitOptions.None)(0) * numCurr
        ElseIf (historyPart(1) = "/") Then
            If numCurr = 0 Then
                lbResult.Text = "Cannot divine by 0"
                ErrorHandler(True)
                Return
            Else
                numPrev = lbHistory.Text.Split(New String() {" "}, StringSplitOptions.None)(0) / numCurr
            End If
        End If
        lbResult.Text = numPrev.ToString
        isPressEqual = True
    End Sub
    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
        If (String.IsNullOrEmpty(lbResult.Text) OrElse isPressEqual = True) Then
            lbHistory.Text = numPrev.ToString & " + "
            lbResult.Text = ""
            isPressEqual = False
            Return
        End If

        Calculate()

        If Not lbResult.Text = "Cannot divine by 0" Then
            lbHistory.Text = numPrev.ToString & " + "
            lbResult.Text = ""
            isOperation = True
        Else
            lbHistory.Text = numPrev.ToString & " / "
            isOperation = False
        End If
    End Sub

    Private Sub btnAC_Click(sender As Object, e As EventArgs) Handles btnAC.Click
        numPrev = 0
        ErrorHandler(False)
        lbResult.Text = ""
    End Sub

    Private Sub btnMinus_Click(sender As Object, e As EventArgs) Handles btnMinus.Click
        If (String.IsNullOrEmpty(lbResult.Text) OrElse isPressEqual = True) Then
            lbHistory.Text = numPrev.ToString & " - "
            lbResult.Text = ""
            isPressEqual = False
            Return
        End If

        Calculate()

        If Not lbResult.Text = "Cannot divine by 0" Then
            lbHistory.Text = numPrev.ToString & " - "
            lbResult.Text = ""
            isOperation = True
        Else
            lbHistory.Text = numPrev.ToString & " / "
            isOperation = False
        End If
    End Sub

    Private Sub btnMultiple_Click(sender As Object, e As EventArgs) Handles btnMultiple.Click
        If (String.IsNullOrEmpty(lbResult.Text) OrElse isPressEqual = True) Then
            lbHistory.Text = numPrev.ToString & " * "
            lbResult.Text = ""
            isPressEqual = False
            Return
        End If

        Calculate()

        If Not lbResult.Text = "Cannot divine by 0" Then
            lbHistory.Text = numPrev.ToString & " * "
            lbResult.Text = ""
            isOperation = True
        Else
            lbHistory.Text = numPrev.ToString & " / "
            isOperation = False
        End If
    End Sub

    Private Sub btnDivine_Click(sender As Object, e As EventArgs) Handles btnDivine.Click
        If (String.IsNullOrEmpty(lbResult.Text) OrElse isPressEqual = True) Then
            lbHistory.Text = numPrev.ToString & " / "
            lbResult.Text = ""
            isPressEqual = False
            Return
        End If

        Calculate()

        lbHistory.Text = numPrev.ToString & " / "
        If Not lbResult.Text = "Cannot divine by 0" Then
            lbResult.Text = ""
            isOperation = True
        Else
            isOperation = False
        End If
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        If lbResult.Text.Length > 0 Then
            lbResult.Text = lbResult.Text.Remove(lbResult.Text.Length - 1)
        End If

    End Sub

    Private Sub btnPercent_Click(sender As Object, e As EventArgs) Handles btnPercent.Click
        isPercentClick = True
        Calculate()

        If Not lbResult.Text = "Cannot divine by 0" Then
            lbHistory.Text = numPrev.ToString
            lbResult.Text = ""
            isOperation = True
        Else
            lbHistory.Text = numPrev.ToString & " / "
            isOperation = False
        End If
    End Sub
End Class
