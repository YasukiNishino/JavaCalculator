Public Class Form1

    Dim FirstNum As Double
    Dim SecondNum As Double
    Dim result As Double
    '＋,－,×,÷を文字列として宣言
    Dim ope As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.MaximizeBox = False

    End Sub

    Private Sub Number_Click(sender As Object, e As EventArgs) Handles MyBase.Click, btn9.Click, btn8.Click, btn7.Click,
                                                                              btn6.Click, btn5.Click, btn4.Click, btn3.Click,
                                                                              btn2.Click, btn1.Click, btn0.Click, btnPoint.Click
        '変数名bにbuttonコントロールを定義
        Try
            Dim b As Button = sender

            If (txtRecord.Text = "0") Then

                txtRecord.Text = b.Text

            ElseIf (b.Text = ".") Then

                If (Not txtRecord.Text.Contains(".")) Then

                    txtRecord.Text = txtRecord.Text + b.Text

                End If

            Else

                txtRecord.Text = txtRecord.Text + b.Text

            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnBackSpace_Click(sender As Object, e As EventArgs) Handles btnBackSpace.Click

        If (txtRecord.Text.Length > 0) Then

            txtRecord.Text = txtRecord.Text.Remove(txtRecord.Text.Length - 1)

        End If

        If (txtRecord.Text = "") Then

            txtRecord.Text = "0"

        End If

    End Sub

    Private Sub Ope_Click(sender As Object, e As EventArgs) Handles btnTimes.Click, btnPlus.Click,
                                                                    btnMinus.Click, btnDivide.Click

        Dim b As Button = sender

        Try
            FirstNum = txtRecord.Text
            ope = b.Text
            txtRecord.Text = "0"
            lblPlural.Text = FirstNum & b.Text

        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnEqual_Click(sender As Object, e As EventArgs) Handles btnEqual.Click

        Try
            SecondNum = txtRecord.Text

            Select Case ope

                Case "+"
                    result = FirstNum + SecondNum
                    txtRecord.Text = result.ToString()

                    If txtRecord.Text.Length < 15 Then
                        txtRecord.Text = txtRecord.Text
                    ElseIf txtRecord.Text.Length > 15 Then
                        txtRecord.Text = txtRecord.Text("E8")

                    End If


                Case "-"
                    result = FirstNum - SecondNum
                    txtRecord.Text = result.ToString()

                    If txtRecord.Text.Length < 15 Then
                        txtRecord.Text = txtRecord.Text
                    ElseIf txtRecord.Text.Length > 15 Then
                        txtRecord.Text = txtRecord.Text("E8")

                    End If

                Case "×"
                    result = FirstNum * SecondNum
                    txtRecord.Text = result.ToString

                    If txtRecord.Text.Length < 15 Then
                        txtRecord.Text = txtRecord.Text
                    ElseIf txtRecord.Text.Length > 15 Then
                        txtRecord.Text = txtRecord.Text("E")

                    End If

                Case "÷"
                    result = FirstNum / SecondNum
                    txtRecord.Text = result.ToString

                    If txtRecord.Text.Length < 15 Then
                        txtRecord.Text = txtRecord.Text
                    ElseIf txtRecord.Text.Length > 15 Then
                        txtRecord.Text = txtRecord.Text("E8")

                    End If

            End Select


        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnPlusMinus_Click(sender As Object, e As EventArgs) Handles btnPlusMinus.Click

        If (txtRecord.Text.Contains("-")) Then

            txtRecord.Text = txtRecord.Text.Remove(0, 1)

        Else

            txtRecord.Text = "-" + txtRecord.Text

        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        txtRecord.Text = "0"
        lblPlural.Text = " "

    End Sub
End Class

