Public Class menu
    Private Sub btnuriage_Click(sender As Object, e As EventArgs) Handles btnuriage.Click
        meisai.Show()
    End Sub

    Private Sub btntokui_Click(sender As Object, e As EventArgs) Handles btntokui.Click
        tokui.Show()
    End Sub

    Private Sub btnsyouhin_Click(sender As Object, e As EventArgs) Handles btnsyouhin.Click
        syouhin.Show()
    End Sub

    Private Sub btntokuikubun_Click(sender As Object, e As EventArgs) Handles btntokuikubun.Click
        tokuikubun.Show()
    End Sub

    Private Sub btnsyouhinkubun_Click(sender As Object, e As EventArgs) Handles btnsyouhinkubun.Click
        syouhinkubun.Show()
    End Sub

    Private Sub btnend_Click(sender As Object, e As EventArgs) Handles btnend.Click
        Me.Close()
    End Sub

    Private Sub btnnyukin_Click(sender As Object, e As EventArgs) Handles btnnyukin.Click
        itiranmeisai.Show()
    End Sub
End Class