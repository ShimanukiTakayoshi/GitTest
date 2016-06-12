<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGitStudy
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
        Me.btnRed = New System.Windows.Forms.Button()
        Me.lblRump = New System.Windows.Forms.Label()
        Me.btnGreen = New System.Windows.Forms.Button()
        Me.btnYellow = New System.Windows.Forms.Button()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnRed
        '
        Me.btnRed.Location = New System.Drawing.Point(34, 55)
        Me.btnRed.Name = "btnRed"
        Me.btnRed.Size = New System.Drawing.Size(63, 51)
        Me.btnRed.TabIndex = 0
        Me.btnRed.Text = "赤ランプ"
        Me.btnRed.UseVisualStyleBackColor = True
        '
        'lblRump
        '
        Me.lblRump.AutoSize = True
        Me.lblRump.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRump.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblRump.Font = New System.Drawing.Font("ＭＳ ゴシック", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblRump.Location = New System.Drawing.Point(68, 144)
        Me.lblRump.Name = "lblRump"
        Me.lblRump.Size = New System.Drawing.Size(136, 39)
        Me.lblRump.TabIndex = 1
        Me.lblRump.Text = "ランプ"
        '
        'btnGreen
        '
        Me.btnGreen.Location = New System.Drawing.Point(103, 55)
        Me.btnGreen.Name = "btnGreen"
        Me.btnGreen.Size = New System.Drawing.Size(63, 51)
        Me.btnGreen.TabIndex = 2
        Me.btnGreen.Text = "緑ランプ"
        Me.btnGreen.UseVisualStyleBackColor = True
        '
        'btnYellow
        '
        Me.btnYellow.Location = New System.Drawing.Point(172, 55)
        Me.btnYellow.Name = "btnYellow"
        Me.btnYellow.Size = New System.Drawing.Size(63, 51)
        Me.btnYellow.TabIndex = 3
        Me.btnYellow.Text = "黄ランプ"
        Me.btnYellow.UseVisualStyleBackColor = True
        '
        'btnEnd
        '
        Me.btnEnd.Location = New System.Drawing.Point(51, 223)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(183, 28)
        Me.btnEnd.TabIndex = 4
        Me.btnEnd.Text = "End"
        Me.btnEnd.UseVisualStyleBackColor = True
        '
        'frmGitStudy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.btnYellow)
        Me.Controls.Add(Me.btnGreen)
        Me.Controls.Add(Me.lblRump)
        Me.Controls.Add(Me.btnRed)
        Me.Name = "frmGitStudy"
        Me.Text = "GitStudy"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnRed As System.Windows.Forms.Button
    Friend WithEvents lblRump As System.Windows.Forms.Label
    Friend WithEvents btnGreen As System.Windows.Forms.Button
    Friend WithEvents btnYellow As System.Windows.Forms.Button
    Friend WithEvents btnEnd As System.Windows.Forms.Button

End Class
