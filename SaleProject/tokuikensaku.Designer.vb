<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tokuikensaku
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
        Me.lstTokui = New System.Windows.Forms.ListBox()
        Me.btnTorikomi = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstTokui
        '
        Me.lstTokui.FormattingEnabled = True
        Me.lstTokui.ItemHeight = 18
        Me.lstTokui.Location = New System.Drawing.Point(53, 46)
        Me.lstTokui.Name = "lstTokui"
        Me.lstTokui.Size = New System.Drawing.Size(366, 184)
        Me.lstTokui.TabIndex = 0
        '
        'btnTorikomi
        '
        Me.btnTorikomi.Location = New System.Drawing.Point(53, 266)
        Me.btnTorikomi.Name = "btnTorikomi"
        Me.btnTorikomi.Size = New System.Drawing.Size(148, 43)
        Me.btnTorikomi.TabIndex = 1
        Me.btnTorikomi.Text = "実行"
        Me.btnTorikomi.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(271, 266)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(148, 43)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "終了"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'tokuikensaku
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(519, 365)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnTorikomi)
        Me.Controls.Add(Me.lstTokui)
        Me.Name = "tokuikensaku"
        Me.Text = "得意先検索画面"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstTokui As ListBox
    Friend WithEvents btnTorikomi As Button
    Friend WithEvents btnCancel As Button
End Class
