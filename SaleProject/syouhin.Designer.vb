<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class syouhin
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCd = New System.Windows.Forms.TextBox()
        Me.txtNm = New System.Windows.Forms.TextBox()
        Me.txtSkubunc = New System.Windows.Forms.TextBox()
        Me.txtSiiretanka = New System.Windows.Forms.TextBox()
        Me.txtUritanka = New System.Windows.Forms.TextBox()
        Me.btnTouroku = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSyouhinkensaku = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(70, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "コード番号"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(70, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "商品名"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(70, 162)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "商品区分"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(70, 213)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "仕入単価"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(70, 262)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 18)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "売上単価"
        '
        'txtCd
        '
        Me.txtCd.Location = New System.Drawing.Point(201, 45)
        Me.txtCd.Name = "txtCd"
        Me.txtCd.Size = New System.Drawing.Size(358, 25)
        Me.txtCd.TabIndex = 5
        '
        'txtNm
        '
        Me.txtNm.Location = New System.Drawing.Point(201, 104)
        Me.txtNm.Name = "txtNm"
        Me.txtNm.Size = New System.Drawing.Size(358, 25)
        Me.txtNm.TabIndex = 6
        '
        'txtSkubunc
        '
        Me.txtSkubunc.Location = New System.Drawing.Point(201, 159)
        Me.txtSkubunc.Name = "txtSkubunc"
        Me.txtSkubunc.Size = New System.Drawing.Size(358, 25)
        Me.txtSkubunc.TabIndex = 7
        '
        'txtSiiretanka
        '
        Me.txtSiiretanka.Location = New System.Drawing.Point(201, 210)
        Me.txtSiiretanka.Name = "txtSiiretanka"
        Me.txtSiiretanka.Size = New System.Drawing.Size(358, 25)
        Me.txtSiiretanka.TabIndex = 8
        '
        'txtUritanka
        '
        Me.txtUritanka.Location = New System.Drawing.Point(201, 259)
        Me.txtUritanka.Name = "txtUritanka"
        Me.txtUritanka.Size = New System.Drawing.Size(360, 25)
        Me.txtUritanka.TabIndex = 9
        '
        'btnTouroku
        '
        Me.btnTouroku.Location = New System.Drawing.Point(299, 339)
        Me.btnTouroku.Name = "btnTouroku"
        Me.btnTouroku.Size = New System.Drawing.Size(119, 41)
        Me.btnTouroku.TabIndex = 10
        Me.btnTouroku.Text = "登録・訂正"
        Me.btnTouroku.UseVisualStyleBackColor = True
        Me.btnTouroku.Visible = False
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(622, 339)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(119, 41)
        Me.btnCancel.TabIndex = 11
        Me.btnCancel.Text = "終了"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSyouhinkensaku
        '
        Me.btnSyouhinkensaku.Location = New System.Drawing.Point(622, 41)
        Me.btnSyouhinkensaku.Name = "btnSyouhinkensaku"
        Me.btnSyouhinkensaku.Size = New System.Drawing.Size(119, 41)
        Me.btnSyouhinkensaku.TabIndex = 12
        Me.btnSyouhinkensaku.Text = "商品検索"
        Me.btnSyouhinkensaku.UseVisualStyleBackColor = True
        '
        'syouhin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnSyouhinkensaku)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnTouroku)
        Me.Controls.Add(Me.txtUritanka)
        Me.Controls.Add(Me.txtSiiretanka)
        Me.Controls.Add(Me.txtSkubunc)
        Me.Controls.Add(Me.txtNm)
        Me.Controls.Add(Me.txtCd)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "syouhin"
        Me.Text = "商品画面"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCd As TextBox
    Friend WithEvents txtNm As TextBox
    Friend WithEvents txtSkubunc As TextBox
    Friend WithEvents txtSiiretanka As TextBox
    Friend WithEvents txtUritanka As TextBox
    Friend WithEvents btnTouroku As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSyouhinkensaku As Button
End Class
