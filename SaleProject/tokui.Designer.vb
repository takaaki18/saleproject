<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tokui
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCd = New System.Windows.Forms.TextBox()
        Me.txtNm = New System.Windows.Forms.TextBox()
        Me.txtZip = New System.Windows.Forms.TextBox()
        Me.txtAdd1 = New System.Windows.Forms.TextBox()
        Me.txtAdd2 = New System.Windows.Forms.TextBox()
        Me.txtTkubunc = New System.Windows.Forms.TextBox()
        Me.txtKisyu = New System.Windows.Forms.TextBox()
        Me.btnTouroku = New System.Windows.Forms.Button()
        Me.btnTokuikensaku = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(77, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "コード番号"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(77, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "得意先名"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(77, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "郵便番号"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(77, 179)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "住所１"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(77, 227)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 18)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "住所２"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(77, 275)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 18)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "得意先区分"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(77, 325)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 18)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "期首残高"
        '
        'txtCd
        '
        Me.txtCd.Location = New System.Drawing.Point(232, 33)
        Me.txtCd.Name = "txtCd"
        Me.txtCd.Size = New System.Drawing.Size(191, 25)
        Me.txtCd.TabIndex = 8
        '
        'txtNm
        '
        Me.txtNm.Location = New System.Drawing.Point(232, 78)
        Me.txtNm.Name = "txtNm"
        Me.txtNm.Size = New System.Drawing.Size(191, 25)
        Me.txtNm.TabIndex = 9
        '
        'txtZip
        '
        Me.txtZip.Location = New System.Drawing.Point(232, 129)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(191, 25)
        Me.txtZip.TabIndex = 10
        '
        'txtAdd1
        '
        Me.txtAdd1.Location = New System.Drawing.Point(232, 176)
        Me.txtAdd1.Name = "txtAdd1"
        Me.txtAdd1.Size = New System.Drawing.Size(483, 25)
        Me.txtAdd1.TabIndex = 11
        '
        'txtAdd2
        '
        Me.txtAdd2.Location = New System.Drawing.Point(232, 224)
        Me.txtAdd2.Name = "txtAdd2"
        Me.txtAdd2.Size = New System.Drawing.Size(483, 25)
        Me.txtAdd2.TabIndex = 12
        '
        'txtTkubunc
        '
        Me.txtTkubunc.Location = New System.Drawing.Point(232, 272)
        Me.txtTkubunc.Name = "txtTkubunc"
        Me.txtTkubunc.Size = New System.Drawing.Size(191, 25)
        Me.txtTkubunc.TabIndex = 13
        '
        'txtKisyu
        '
        Me.txtKisyu.Location = New System.Drawing.Point(232, 322)
        Me.txtKisyu.Name = "txtKisyu"
        Me.txtKisyu.Size = New System.Drawing.Size(191, 25)
        Me.txtKisyu.TabIndex = 14
        '
        'btnTouroku
        '
        Me.btnTouroku.Location = New System.Drawing.Point(257, 380)
        Me.btnTouroku.Name = "btnTouroku"
        Me.btnTouroku.Size = New System.Drawing.Size(166, 35)
        Me.btnTouroku.TabIndex = 15
        Me.btnTouroku.Text = "登録・訂正"
        Me.btnTouroku.UseVisualStyleBackColor = True
        Me.btnTouroku.Visible = False
        '
        'btnTokuikensaku
        '
        Me.btnTokuikensaku.Location = New System.Drawing.Point(549, 33)
        Me.btnTokuikensaku.Name = "btnTokuikensaku"
        Me.btnTokuikensaku.Size = New System.Drawing.Size(166, 35)
        Me.btnTokuikensaku.TabIndex = 16
        Me.btnTokuikensaku.Text = "得意先検索"
        Me.btnTokuikensaku.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(549, 380)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(166, 35)
        Me.btnCancel.TabIndex = 18
        Me.btnCancel.Text = "終了"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'tokui
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnTokuikensaku)
        Me.Controls.Add(Me.btnTouroku)
        Me.Controls.Add(Me.txtKisyu)
        Me.Controls.Add(Me.txtTkubunc)
        Me.Controls.Add(Me.txtAdd2)
        Me.Controls.Add(Me.txtAdd1)
        Me.Controls.Add(Me.txtZip)
        Me.Controls.Add(Me.txtNm)
        Me.Controls.Add(Me.txtCd)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "tokui"
        Me.Text = "得意先画面"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCd As TextBox
    Friend WithEvents txtNm As TextBox
    Friend WithEvents txtZip As TextBox
    Friend WithEvents txtAdd1 As TextBox
    Friend WithEvents txtAdd2 As TextBox
    Friend WithEvents txtTkubunc As TextBox
    Friend WithEvents txtKisyu As TextBox
    Friend WithEvents btnTouroku As Button
    Friend WithEvents btnTokuikensaku As Button
    Friend WithEvents btnCancel As Button
End Class
