<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menu
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
        Me.btntokui = New System.Windows.Forms.Button()
        Me.btnsyouhin = New System.Windows.Forms.Button()
        Me.btnnyukin = New System.Windows.Forms.Button()
        Me.btnuriage = New System.Windows.Forms.Button()
        Me.btnend = New System.Windows.Forms.Button()
        Me.btntokuikubun = New System.Windows.Forms.Button()
        Me.btnsyouhinkubun = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btntokui
        '
        Me.btntokui.Location = New System.Drawing.Point(36, 37)
        Me.btntokui.Name = "btntokui"
        Me.btntokui.Size = New System.Drawing.Size(133, 51)
        Me.btntokui.TabIndex = 0
        Me.btntokui.Text = "得意先"
        Me.btntokui.UseVisualStyleBackColor = True
        '
        'btnsyouhin
        '
        Me.btnsyouhin.Location = New System.Drawing.Point(246, 37)
        Me.btnsyouhin.Name = "btnsyouhin"
        Me.btnsyouhin.Size = New System.Drawing.Size(133, 51)
        Me.btnsyouhin.TabIndex = 1
        Me.btnsyouhin.Text = "商品"
        Me.btnsyouhin.UseVisualStyleBackColor = True
        '
        'btnnyukin
        '
        Me.btnnyukin.Location = New System.Drawing.Point(246, 235)
        Me.btnnyukin.Name = "btnnyukin"
        Me.btnnyukin.Size = New System.Drawing.Size(133, 51)
        Me.btnnyukin.TabIndex = 9
        Me.btnnyukin.Text = "明細一覧"
        Me.btnnyukin.UseVisualStyleBackColor = True
        '
        'btnuriage
        '
        Me.btnuriage.Location = New System.Drawing.Point(36, 235)
        Me.btnuriage.Name = "btnuriage"
        Me.btnuriage.Size = New System.Drawing.Size(133, 51)
        Me.btnuriage.TabIndex = 11
        Me.btnuriage.Text = "見積明細"
        Me.btnuriage.UseVisualStyleBackColor = True
        '
        'btnend
        '
        Me.btnend.Location = New System.Drawing.Point(427, 235)
        Me.btnend.Name = "btnend"
        Me.btnend.Size = New System.Drawing.Size(133, 51)
        Me.btnend.TabIndex = 13
        Me.btnend.Text = "終了"
        Me.btnend.UseVisualStyleBackColor = True
        '
        'btntokuikubun
        '
        Me.btntokuikubun.Location = New System.Drawing.Point(36, 133)
        Me.btntokuikubun.Name = "btntokuikubun"
        Me.btntokuikubun.Size = New System.Drawing.Size(133, 51)
        Me.btntokuikubun.TabIndex = 2
        Me.btntokuikubun.Text = "得意先区分"
        Me.btntokuikubun.UseVisualStyleBackColor = True
        '
        'btnsyouhinkubun
        '
        Me.btnsyouhinkubun.Location = New System.Drawing.Point(246, 133)
        Me.btnsyouhinkubun.Name = "btnsyouhinkubun"
        Me.btnsyouhinkubun.Size = New System.Drawing.Size(133, 51)
        Me.btnsyouhinkubun.TabIndex = 3
        Me.btnsyouhinkubun.Text = "商品区分"
        Me.btnsyouhinkubun.UseVisualStyleBackColor = True
        '
        'menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(605, 340)
        Me.Controls.Add(Me.btnend)
        Me.Controls.Add(Me.btnuriage)
        Me.Controls.Add(Me.btnnyukin)
        Me.Controls.Add(Me.btnsyouhinkubun)
        Me.Controls.Add(Me.btntokuikubun)
        Me.Controls.Add(Me.btnsyouhin)
        Me.Controls.Add(Me.btntokui)
        Me.Name = "menu"
        Me.Text = "メニュー 画面"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btntokui As Button
    Friend WithEvents btnsyouhin As Button
    Friend WithEvents btnnyukin As Button
    Friend WithEvents btnuriage As Button
    Friend WithEvents btnend As Button
    Friend WithEvents btntokuikubun As Button
    Friend WithEvents btnsyouhinkubun As Button
End Class
