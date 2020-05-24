<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class syouhinkubun
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
        Me.lstSyouhinkubun = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(265, 270)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(148, 43)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "終了"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'lstSyouhinkubun
        '
        Me.lstSyouhinkubun.FormattingEnabled = True
        Me.lstSyouhinkubun.ItemHeight = 18
        Me.lstSyouhinkubun.Location = New System.Drawing.Point(61, 46)
        Me.lstSyouhinkubun.Name = "lstSyouhinkubun"
        Me.lstSyouhinkubun.Size = New System.Drawing.Size(352, 184)
        Me.lstSyouhinkubun.TabIndex = 3
        '
        'syouhinkubun
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(493, 358)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.lstSyouhinkubun)
        Me.Name = "syouhinkubun"
        Me.Text = "商品区分"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCancel As Button
    Friend WithEvents lstSyouhinkubun As ListBox
End Class
