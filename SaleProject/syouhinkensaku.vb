Public Class 商品検索画面
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        lstSyouhin.Items.Clear()
        Me.Close()
    End Sub

    Private Sub syouhinkensaku_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cm As SqlClient.SqlCommand
        Dim rs As SqlClient.SqlDataReader
        Dim cn As SqlClient.SqlConnection = New SqlClient.SqlConnection()
        cn.ConnectionString = "Data Source=localhost;Initial Catalog=hanbai;Integrated Security=True"
        cn.Open()
        cm = New SqlClient.SqlCommand("select * from T_Syouhin", cn)
        rs = cm.ExecuteReader
        rs.Read()
        If rs.HasRows = True Then
            lstSyouhin.Items.Add(rs("N_Cd").ToString() + " " + rs("C_Nm").ToString())
            Do While (rs.Read())
                lstSyouhin.Items.Add(rs("N_Cd").ToString() + " " + rs("C_Nm").ToString())
            Loop
        End If
        rs.Close()
        cn.Close()
    End Sub

    Private Sub btnTorikomi_Click(sender As Object, e As EventArgs) Handles btnTorikomi.Click
        Dim s_SearchCd As Integer
        Dim s_SearchNm As String
        Dim s_SearchTkubunc As Integer
        Dim s_SearchSiire As Integer
        Dim s_SearchUri As Integer
        Dim m_SearchScode As Integer

        Dim moji As String
        Dim moji1 As String
        Dim strSQL As String
        Dim cm As SqlClient.SqlCommand
        Dim rs As SqlClient.SqlDataReader
        Dim cn As SqlClient.SqlConnection = New SqlClient.SqlConnection()
        cn.ConnectionString = "Data Source=localhost;Initial Catalog=hanbai;Integrated Security=True"
        moji = lstSyouhin.Text

        '得意先が選択されているとき
        If moji <> "" Then
            moji1 = moji.Substring(0, 2)
            m_SearchScode = Integer.Parse(moji1)
            cn.Open()
            strSQL = "select * from T_Syouhin inner join T_Syouhinkubun On T_Syouhin.N_Sknc = T_Syouhinkubun.N_Skcd"
            strSQL = strSQL & " where N_Cd=" & m_SearchScode
            cm = New SqlClient.SqlCommand(strSQL, cn)
            rs = cm.ExecuteReader
            rs.Read()
            s_SearchCd = Integer.Parse(rs("N_Cd").ToString())
            s_SearchNm = rs("C_Nm").ToString()
            s_SearchTkubunc = rs("N_Sknc").ToString()
            s_SearchSiire = Integer.Parse(rs("N_Siire").ToString())
            s_SearchUri = Integer.Parse(rs("N_Uri").ToString())
            rs.Close()
            cn.Close()

            '得意検索画面に値を表示
            lstSyouhin.Items.Clear()
            Dim syouhinFrm As New syouhin()
            syouhinFrm.txtCd.Text = s_SearchCd
            syouhinFrm.txtNm.Text = s_SearchNm
            syouhinFrm.txtSkubunc.Text = s_SearchTkubunc
            syouhinFrm.txtSiiretanka.Text = s_SearchSiire
            syouhinFrm.txtUritanka.Text = s_SearchUri
            syouhinFrm.btnTouroku.Visible = True
            syouhinFrm.Show()
            Me.Close()
        Else
            MessageBox.Show("商品が選択されていません")
        End If
    End Sub
End Class