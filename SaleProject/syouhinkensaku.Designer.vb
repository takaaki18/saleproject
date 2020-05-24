<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 商品検索画面
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
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnTorikomi = New System.Windows.Forms.Button()
        Me.lstSyouhin = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(288, 245)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(148, 43)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "終了"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnTorikomi
        '
        Me.btnTorikomi.Location = New System.Drawing.Point(54, 245)
        Me.btnTorikomi.Name = "btnTorikomi"
        Me.btnTorikomi.Size = New System.Drawing.Size(148, 43)
        Me.btnTorikomi.TabIndex = 4
        Me.btnTorikomi.Text = "実行"
        Me.btnTorikomi.UseVisualStyleBackColor = True
        '
        'lstSyouhin
        '
        Me.lstSyouhin.FormattingEnabled = True
        Me.lstSyouhin.ItemHeight = 18
        Me.lstSyouhin.Location = New System.Drawing.Point(54, 34)
        Me.lstSyouhin.Name = "lstSyouhin"
        Me.lstSyouhin.Size = New System.Drawing.Size(382, 166)
        Me.lstSyouhin.TabIndex = 3
        '
        '商品検索画面
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(516, 347)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnTorikomi)
        Me.Controls.Add(Me.lstSyouhin)
        Me.Name = "商品検索画面"
        Me.Text = "syouhinkensaku"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCancel As Button
    Friend WithEvents btnTorikomi As Button
    Friend WithEvents lstSyouhin As ListBox
End Class
