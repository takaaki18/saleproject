Public Class syouhinkubun
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub syouhinkubun_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cm As SqlClient.SqlCommand
        Dim rs As SqlClient.SqlDataReader
        Dim cn As SqlClient.SqlConnection = New SqlClient.SqlConnection()
        cn.ConnectionString = "Data Source=localhost;Initial Catalog=hanbai;Integrated Security=True"
        cn.Open()
        cm = New SqlClient.SqlCommand("select * from T_Syouhinkubun", cn)
        rs = cm.ExecuteReader
        rs.Read()
        If rs.HasRows = True Then
            lstSyouhinkubun.Items.Add(rs("N_Skcd").ToString() + " " + rs("C_Sknm").ToString())
            Do While (rs.Read())
                lstSyouhinkubun.Items.Add(rs("N_Skcd").ToString() + " " + rs("C_Sknm").ToString())
            Loop
        End If
        rs.Close()
        cn.Close()
    End Sub
End Class