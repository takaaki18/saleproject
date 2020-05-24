Public Class itiranmeisai
    Private Sub itiranmeisai_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '明細一覧をListViewに表示
        ListView1.GridLines = True
        ListView1.View = View.Details

        Dim cm As SqlClient.SqlCommand
        Dim rs As SqlClient.SqlDataReader
        Dim cn As SqlClient.SqlConnection = New SqlClient.SqlConnection()
        Dim row() As String
        cn.ConnectionString = "Data Source=localhost;Initial Catalog=hanbai;Integrated Security=True"
        cn.Open()
        cm = New SqlClient.SqlCommand("select * from T_Huriage", cn)
        rs = cm.ExecuteReader
        rs.Read()
        If rs.HasRows = True Then
            Do While (rs.Read())
                row = {rs("N_Denno").ToString(), rs("N_Uriagebi").ToString(), rs("N_Tcd").ToString(), rs("N_Uriage").ToString(), rs("N_Syouhizei").ToString(), rs("N_Zeikomi").ToString()}
                ListView1.Items.Add(New ListViewItem(row))
            Loop
        Else
            MessageBox.Show("データがありません")
        End If
        rs.Close()
        cn.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'csv出力処理
        For Each si As ListViewItem In ListView1.Items
            Dim Items0 As String = si.SubItems(0).Text
            Dim Items1 As String = si.SubItems(1).Text
            Dim Items2 As String = si.SubItems(2).Text
            Dim Items3 As String = si.SubItems(3).Text
            Dim Items4 As String = si.SubItems(4).Text
            Dim Items5 As String = si.SubItems(5).Text

            FileOpen(1, "C:\Users\takaa\OneDrive\デスクトップ\sample.csv", OpenMode.Append)
            PrintLine(1, ",", Items0, ",", Items1, ",", Items2, ",", Items3, ",", Items4, ",", Items5)
            FileClose(1)
        Next
        MessageBox.Show("csv出力が完了しました")
    End Sub
End Class