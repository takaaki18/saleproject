<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class itiranmeisai
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
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.columnDenno = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnUriagebi = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnTcd = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnUriage = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnSyouhizei = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnZeikomi = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.columnDenno, Me.columnUriagebi, Me.columnTcd, Me.columnUriage, Me.columnSyouhizei, Me.columnZeikomi})
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(37, 35)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(739, 291)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'columnDenno
        '
        Me.columnDenno.Text = "見積NO"
        '
        'columnUriagebi
        '
        Me.columnUriagebi.Text = "売上日"
        '
        'columnTcd
        '
        Me.columnTcd.Text = "得意先コード"
        Me.columnTcd.Width = 80
        '
        'columnUriage
        '
        Me.columnUriage.Text = "商品代金"
        Me.columnUriage.Width = 80
        '
        'columnSyouhizei
        '
        Me.columnSyouhizei.Text = "消費税"
        Me.columnSyouhizei.Width = 80
        '
        'columnZeikomi
        '
        Me.columnZeikomi.Text = "合計金額"
        Me.columnZeikomi.Width = 80
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(657, 357)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(118, 42)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "終了"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(37, 357)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(118, 42)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "csv出力"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'itiranmeisai
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(826, 419)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ListView1)
        Me.Name = "itiranmeisai"
        Me.Text = "明細一覧画面"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListView1 As ListView
    Friend WithEvents columnDenno As ColumnHeader
    Friend WithEvents columnUriagebi As ColumnHeader
    Friend WithEvents columnTcd As ColumnHeader
    Friend WithEvents columnUriage As ColumnHeader
    Friend WithEvents columnSyouhizei As ColumnHeader
    Friend WithEvents columnZeikomi As ColumnHeader
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
