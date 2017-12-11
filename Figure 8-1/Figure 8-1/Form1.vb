Public Class Form1

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Const intMax_SUBSCRIPT As Integer = 4
        Dim intNumbers(intMax_SUBSCRIPT) As Integer
        Dim intCount As Integer

        Dim rand As New Random

        For intCount = 0 To intMax_SUBSCRIPT
            intNumbers(intCount) = rand.Next(100)
        Next

        lbl1st.Text = intNumbers(0).ToString
        lbl2nd.Text = intNumbers(1).ToString
        lbl3rd.Text = intNumbers(2).ToString
        lbl4th.Text = intNumbers(3).ToString
        lbl5th.Text = intNumbers(4).ToString
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
