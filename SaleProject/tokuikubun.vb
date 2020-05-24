Public Class tokuikubun

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub tokuikubun_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cm As SqlClient.SqlCommand
        Dim rs As SqlClient.SqlDataReader
        Dim cn As SqlClient.SqlConnection = New SqlClient.SqlConnection()
        cn.ConnectionString = "Data Source=localhost;Initial Catalog=hanbai;Integrated Security=True"
        cn.Open()
        cm = New SqlClient.SqlCommand("select * from T_Tokuikubun", cn)
        rs = cm.ExecuteReader
        rs.Read()
        If rs.HasRows = True Then
            lstTokuikubun.Items.Add(rs("N_Tkcd").ToString() + " " + rs("C_Tknm").ToString())
            Do While (rs.Read())
                lstTokuikubun.Items.Add(rs("N_Tkcd").ToString() + " " + rs("C_Tknm").ToString())
            Loop
        End If
        rs.Close()
        cn.Close()
    End Sub

End Class