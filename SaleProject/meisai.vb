Public Class meisai

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub meisai_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim intN_Denno As Integer
        Dim strSQL As String

        '見積Noを新規に採番する
        Dim cm As SqlClient.SqlCommand
        Dim rs As SqlClient.SqlDataReader
        Dim cn As SqlClient.SqlConnection = New SqlClient.SqlConnection()
        cn.ConnectionString = "Data Source=localhost;Initial Catalog=hanbai;Integrated Security=True"
        cn.Open()
        strSQL = "select * from T_Huriage where N_Denno=(select max(N_Denno) from T_Huriage)"
        cm = New SqlClient.SqlCommand(strSQL, cn)
        rs = cm.ExecuteReader
        rs.Read()
        intN_Denno = Integer.Parse(rs("N_Denno").ToString())
        txtMituno.Text = intN_Denno + 1
        rs.Close()
        cn.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'クリアボタン押下処理
        txtTokuisakicd.Clear()
        txtTokuimei.Clear()
        txtShoNm.Clear()
        txtUritanka.Clear()
        txtShoCD.Clear()
        txtUriagegoukei.Clear()
        txtSyouhizei.Clear()
        txtGoukeikingaku.Clear()
    End Sub

    Private Sub txtTokuisakicd_LostFocus(sender As Object, e As EventArgs) Handles txtTokuisakicd.LostFocus
        Dim strTokui As String
        strTokui = txtTokuisakicd.Text
        Dim strSQL As String
        Dim cm As SqlClient.SqlCommand
        Dim rs As SqlClient.SqlDataReader
        Dim cn As SqlClient.SqlConnection = New SqlClient.SqlConnection()

        strSQL = "select * from T_Tokui where N_Cd = " & "'" & strTokui & "'"
        cn.ConnectionString = "Data Source=localhost;Initial Catalog=hanbai;Integrated Security=True"
        cn.Open()
        cm = New SqlClient.SqlCommand(strSQL, cn)
        rs = cm.ExecuteReader
        rs.Read()
        If rs.HasRows = True Then
            txtTokuimei.Text = rs("C_Nm").ToString()
        End If
        rs.Close()
        cn.Close()
    End Sub

    Private Sub txtShoCD_LostFocus(sender As Object, e As EventArgs) Handles txtShoCD.LostFocus
        Dim strShocd = txtShoCD.Text
        Dim cm As SqlClient.SqlCommand
        Dim rs As SqlClient.SqlDataReader
        Dim cn As SqlClient.SqlConnection = New SqlClient.SqlConnection()
        cn.ConnectionString = "Data Source=localhost;Initial Catalog=hanbai;Integrated Security=True"
        cn.Open()
        cm = New SqlClient.SqlCommand("select * from T_Syouhin where N_Cd = " & "'" & strShocd & "'", cn)
        rs = cm.ExecuteReader
        rs.Read()
        If rs.HasRows = True Then
            txtShoNm.Text = rs("C_Nm").ToString()
            txtUritanka.Text = rs("N_Uri").ToString()
        End If
        rs.Close()
        cn.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        '合計金額計算
        txtUriagegoukei.Text = Integer.Parse(txtUritanka.Text) * Integer.Parse(txtSuuryou.Text)
        txtSyouhizei.Text = Integer.Parse(txtUriagegoukei.Text) * 0.1
        txtGoukeikingaku.Text = Integer.Parse(txtUriagegoukei.Text) + Integer.Parse(txtSyouhizei.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        '明細新規登録
        Dim intN_Cd As Integer
        Dim strSQL As String

        Dim strN_Uriagebi As Date
        Dim strN_Tcd As String
        Dim strN_Uriage As Integer
        Dim strN_Syouhizei As Integer
        Dim strN_Zeikomi As Integer

        Dim cm As SqlClient.SqlCommand
        Dim rs As SqlClient.SqlDataReader
        Dim cn As SqlClient.SqlConnection = New SqlClient.SqlConnection()
        cn.ConnectionString = "Data Source=localhost;Initial Catalog=hanbai;Integrated Security=True"
        If (txtTokuisakicd.Text <> "" And txtShoCD.Text <> "" And txtSuuryou.Text <> "" And txtUriagegoukei.Text <> "" And txtSyouhizei.Text <> "" And txtGoukeikingaku.Text <> "") Then
            cn.Open()
            strSQL = "select * from T_Huriage where N_Denno=(select max(N_Denno) from T_Huriage)"
            cm = New SqlClient.SqlCommand(strSQL, cn)

            'SQL確認用
            Console.WriteLine(strSQL)
            rs = cm.ExecuteReader
            rs.Read()
            intN_Cd = Integer.Parse(rs("N_Denno").ToString())
            rs.Close()
            '新規データの登録
            '登録数+1を取得(新規登録する際の番号)
            intN_Cd = intN_Cd + 1

            strN_Uriagebi = DateTimePicker1.Text
            strN_Tcd = txtTokuisakicd.Text
            strN_Uriage = txtUriagegoukei.Text
            strN_Syouhizei = txtSyouhizei.Text
            strN_Zeikomi = txtGoukeikingaku.Text

            strSQL = "insert into T_Huriage"
            strSQL = strSQL + "(N_Denno, N_Uriagebi, N_Tcd, N_Uriage, N_Syouhizei, N_Zeikomi) values "
            strSQL = strSQL + "(" & intN_Cd & "," & "'" & strN_Uriagebi & "'" & "," & strN_Tcd &
                        "," & strN_Uriage & "," & strN_Syouhizei & "," & strN_Zeikomi & ")"

            'SQL確認用
            Console.WriteLine(strSQL)
            cm = New SqlClient.SqlCommand(strSQL, cn)
            cm.ExecuteReader()
            cn.Close()
            MsgBox("データを新規作成しますか？", MsgBoxStyle.YesNo Or MsgBoxStyle.Exclamation, "データの新規作成")
            MessageBox.Show("データを新規作成しました")
            Me.Close()
        Else
            MessageBox.Show("未入力の項目があります")
        End If

    End Sub
End Class