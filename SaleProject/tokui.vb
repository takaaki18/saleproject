Public Class tokui
    Private Sub btnTokuikensaku_Click(sender As Object, e As EventArgs) Handles btnTokuikensaku.Click
        tokuikensaku.Show()
        Me.Close()
    End Sub

    Private Sub btnTouroku_Click(sender As Object, e As EventArgs) Handles btnTouroku.Click
        Dim intN_Cd As Integer
        Dim strSQL As String
        Dim strC_Zip As String
        Dim strC_Add1 As String
        Dim strC_Add2 As String
        Dim strC_Nm As String
        Dim intN_Tkubunc As Integer
        Dim lngN_kisyu As Long
        Dim cm As SqlClient.SqlCommand
        Dim rs As SqlClient.SqlDataReader
        Dim cn As SqlClient.SqlConnection = New SqlClient.SqlConnection()
        cn.ConnectionString = "Data Source=localhost;Initial Catalog=hanbai;Integrated Security=True"
        cn.Open()
        strSQL = "select * from T_Tokui where N_Cd=(select max(N_Cd) from T_Tokui)"
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

                strC_Zip = txtZip.Text
                strC_Add1 = txtAdd1.Text
                strC_Add2 = txtAdd2.Text
                strC_Nm = txtNm.Text
                If (txtTkubunc.Text = "") Then
                    txtTkubunc.Text = "0"
                End If
                If (txtKisyu.Text = "") Then
                    txtKisyu.Text = "0"
                End If
                intN_Tkubunc = Integer.Parse(txtTkubunc.Text)
                lngN_kisyu = Long.Parse(txtKisyu.Text)
                strSQL = "insert into T_Tokui"
                strSQL = strSQL + "(N_Cd, C_Zip, C_Add1, C_Add2, C_Nm, N_Tknc, N_Kisyu) values "
                strSQL = strSQL + "(" & intN_Cd & "," & strC_Zip & "," & "'" & strC_Add1 & "'" &
                        "," & "'" & strC_Add2 & "'" & "," & "'" & strC_Nm & "'" & "," & intN_Tkubunc & "," & lngN_kisyu & ")"

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
                strC_Zip = txtZip.Text
                strC_Add1 = txtAdd1.Text
                strC_Add2 = txtAdd2.Text
                strC_Nm = txtNm.Text
                intN_Tkubunc = Integer.Parse(txtTkubunc.Text)
                lngN_kisyu = Long.Parse(txtKisyu.Text)
                strSQL = "update T_Tokui set C_Zip =" & strC_Zip & ", C_Add1 =" & "'" & strC_Add1 & "'" &
                    ", C_Add2 = " & "'" & strC_Add2 & "'" & ", C_Nm = " & "'" & strC_Nm & "'" &
                    ", N_Tknc = " & intN_Tkubunc & ", N_Kisyu = " & lngN_kisyu & " where N_Cd = " & intN_Cd

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
            MessageBox.Show("得意先が入力されていません")
        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class