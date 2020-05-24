Public Class tokuikensaku
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        lstTokui.Items.Clear()
        Me.Close()
    End Sub

    Private Sub tokuikensaku_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cm As SqlClient.SqlCommand
        Dim rs As SqlClient.SqlDataReader
        Dim cn As SqlClient.SqlConnection = New SqlClient.SqlConnection()
        cn.ConnectionString = "Data Source=localhost;Initial Catalog=hanbai;Integrated Security=True"
        cn.Open()
        cm = New SqlClient.SqlCommand("select * from T_Tokui", cn)
        rs = cm.ExecuteReader
        rs.Read()
        If rs.HasRows = True Then
            lstTokui.Items.Add(rs("N_Cd").ToString() + " " + rs("C_Nm").ToString())
            Do While (rs.Read())
                lstTokui.Items.Add(rs("N_Cd").ToString() + " " + rs("C_Nm").ToString())
            Loop
        End If
        rs.Close()
        cn.Close()
    End Sub

    Private Sub btnTorikomi_Click(sender As Object, e As EventArgs) Handles btnTorikomi.Click
        Dim m_SearchZip As String
        Dim m_SearchAdd1 As String
        Dim m_SearchAdd2 As String
        Dim m_SearchTkname As String
        Dim m_SearchTkubunc As Integer
        Dim m_SearchKisyu As Long
        Dim m_SearchTcode As Integer

        Dim moji As String
        Dim moji1 As String
        Dim strSQL As String
        Dim cm As SqlClient.SqlCommand
        Dim rs As SqlClient.SqlDataReader
        Dim cn As SqlClient.SqlConnection = New SqlClient.SqlConnection()
        cn.ConnectionString = "Data Source=localhost;Initial Catalog=hanbai;Integrated Security=True"
        moji = lstTokui.Text

        '得意先が選択されているとき
        If moji <> "" Then
            moji1 = moji.Substring(0, 2)
            m_SearchTcode = Integer.Parse(moji1)
            cn.Open()
            strSQL = "select * from T_Tokui inner join T_Tokuikubun On T_Tokui.N_Tknc = T_Tokuikubun.N_Tkcd"
            strSQL = strSQL & " where N_Cd=" & m_SearchTcode
            cm = New SqlClient.SqlCommand(strSQL, cn)
            rs = cm.ExecuteReader
            rs.Read()
            m_SearchZip = rs("C_Zip").ToString()
            m_SearchAdd1 = rs("C_Add1").ToString()
            m_SearchAdd2 = rs("C_Add2").ToString()
            m_SearchTkubunc = Integer.Parse(rs("N_Tknc").ToString())
            m_SearchTkname = rs("C_Nm").ToString()
            m_SearchKisyu = Integer.Parse(rs("N_Kisyu").ToString())
            rs.Close()
            cn.Close()

            '得意検索画面に値を表示
            lstTokui.Items.Clear()
            Dim tokuiFrm As New tokui()
            tokuiFrm.txtCd.Text = m_SearchTcode
            tokuiFrm.txtZip.Text = m_SearchZip
            tokuiFrm.txtAdd1.Text = m_SearchAdd1
            tokuiFrm.txtAdd2.Text = m_SearchAdd2
            tokuiFrm.txtNm.Text = m_SearchTkname
            tokuiFrm.txtTkubunc.Text = m_SearchTkubunc
            tokuiFrm.txtKisyu.Text = m_SearchKisyu
            tokuiFrm.btnTouroku.Visible = True
            tokuiFrm.Show()
            Me.Close()
        Else
            MessageBox.Show("得意先が選択されていません")
        End If
    End Sub

    Private Sub lstTokui_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstTokui.SelectedIndexChanged

    End Sub
End Class