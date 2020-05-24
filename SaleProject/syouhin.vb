Public Class syouhin
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSyouhinkensaku_Click(sender As Object, e As EventArgs) Handles btnSyouhinkensaku.Click
        商品検索画面.Show()
        Me.Close()
    End Sub

    Private Sub btnTouroku_Click(sender As Object, e As EventArgs) Handles btnTouroku.Click
        Dim intN_Cd As Integer
        Dim strSQL As String
        Dim strC_Nm As String
        Dim strN_Sknc As String
        Dim strN_Siire As Integer
        Dim strC_Uri As Integer

        Dim cm As SqlClient.SqlCommand
        Dim rs As SqlClient.SqlDataReader
        Dim cn As SqlClient.SqlConnection = New SqlClient.SqlConnection()
        cn.ConnectionString = "Data Source=localhost;Initial Catalog=hanbai;Integrated Security=True"
        cn.Open()
        strSQL = "select * from T_Syouhin where N_Cd=(select max(N_Cd) from T_Syouhin)"
        cm = New SqlClient.SqlCommand(strSQL, cn)
        rs = cm.ExecuteReader
        rs.Read()
        intN_Cd = Integer.Parse(rs("N_Cd").ToString())
        rs.Close()

        If (txtNm.Text <> "") Then
            '新規データの登録
            If (intN_Cd <= Integer.Parse(txtCd.Text)) Then
                '登録数+1を取得(新規登録する際の番号)
                intN_Cd = intN_Cd + 1

                strC_Nm = txtNm.Text
                strN_Sknc = txtSkubunc.Text
                strN_Siire = txtSiiretanka.Text
                strC_Uri = txtUritanka.Text

                strSQL = "insert into T_Syouhin"
                strSQL = strSQL + "(N_Cd, C_Nm, N_Sknc, N_Siire, N_Uri) values "
                strSQL = strSQL + "(" & intN_Cd & "," & "'" & strC_Nm & "'" & "," & strN_Sknc &
                        "," & strN_Siire & "," & strC_Uri & ")"

                'SQL確認用
                Console.WriteLine(strSQL)

                cm = New SqlClient.SqlCommand(strSQL, cn)
                cm.ExecuteReader()
                cn.Close()
                MsgBox("データを新規作成しますか？", MsgBoxStyle.YesNo Or MsgBoxStyle.Exclamation, "データの新規作成")
                MessageBox.Show("データを新規作成しました")
                Me.Close()
            Else
                '更新処理
                intN_Cd = Integer.Parse(txtCd.Text)
                strC_Nm = txtNm.Text
                strN_Sknc = txtSkubunc.Text
                strN_Siire = txtSiiretanka.Text
                strC_Uri = txtUritanka.Text

                strSQL = "update T_Syouhin set N_Cd =" & intN_Cd & ", C_Nm =" & "'" & strC_Nm & "'" &
                    ", N_Sknc = " & strN_Sknc & ", N_Siire = " & strN_Siire &
                    ", N_Uri = " & strC_Uri & " where N_Cd = " & intN_Cd

                'SQL確認用
                Console.WriteLine(strSQL)

                cm = New SqlClient.SqlCommand(strSQL, cn)
                cm.ExecuteReader()
                cn.Close()
                MsgBox("データを更新しますか？", MsgBoxStyle.YesNo Or MsgBoxStyle.Exclamation, "データの更新処理")
                MessageBox.Show("データの更新をしました")
                Me.Close()
            End If
        Else
            MessageBox.Show("商品が入力されていません")
        End If

    End Sub

End Class