<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtRecord = New System.Windows.Forms.TextBox()
        Me.lblPlural = New System.Windows.Forms.Label()
        Me.btnDivide = New System.Windows.Forms.Button()
        Me.btnTimes = New System.Windows.Forms.Button()
        Me.btnMinus = New System.Windows.Forms.Button()
        Me.btnPlus = New System.Windows.Forms.Button()
        Me.btnEqual = New System.Windows.Forms.Button()
        Me.btnBackSpace = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btn9 = New System.Windows.Forms.Button()
        Me.btn8 = New System.Windows.Forms.Button()
        Me.btn7 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.btn6 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btnPoint = New System.Windows.Forms.Button()
        Me.btn0 = New System.Windows.Forms.Button()
        Me.btnPlusMinus = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtRecord
        '
        Me.txtRecord.Font = New System.Drawing.Font("MS UI Gothic", 20.0!)
        Me.txtRecord.Location = New System.Drawing.Point(22, 70)
        Me.txtRecord.Multiline = True
        Me.txtRecord.Name = "txtRecord"
        Me.txtRecord.Size = New System.Drawing.Size(235, 50)
        Me.txtRecord.TabIndex = 0
        Me.txtRecord.Text = "0"
        Me.txtRecord.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblPlural
        '
        Me.lblPlural.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.lblPlural.Location = New System.Drawing.Point(22, 26)
        Me.lblPlural.Name = "lblPlural"
        Me.lblPlural.Size = New System.Drawing.Size(235, 30)
        Me.lblPlural.TabIndex = 1
        '
        'btnDivide
        '
        Me.btnDivide.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnDivide.Location = New System.Drawing.Point(193, 135)
        Me.btnDivide.Name = "btnDivide"
        Me.btnDivide.Size = New System.Drawing.Size(50, 45)
        Me.btnDivide.TabIndex = 2
        Me.btnDivide.Text = "÷"
        Me.btnDivide.UseVisualStyleBackColor = True
        '
        'btnTimes
        '
        Me.btnTimes.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnTimes.Location = New System.Drawing.Point(193, 186)
        Me.btnTimes.Name = "btnTimes"
        Me.btnTimes.Size = New System.Drawing.Size(50, 45)
        Me.btnTimes.TabIndex = 3
        Me.btnTimes.Text = "×"
        Me.btnTimes.UseVisualStyleBackColor = True
        '
        'btnMinus
        '
        Me.btnMinus.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnMinus.Location = New System.Drawing.Point(193, 237)
        Me.btnMinus.Name = "btnMinus"
        Me.btnMinus.Size = New System.Drawing.Size(50, 45)
        Me.btnMinus.TabIndex = 4
        Me.btnMinus.Text = "-"
        Me.btnMinus.UseVisualStyleBackColor = True
        '
        'btnPlus
        '
        Me.btnPlus.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnPlus.Location = New System.Drawing.Point(193, 288)
        Me.btnPlus.Name = "btnPlus"
        Me.btnPlus.Size = New System.Drawing.Size(50, 45)
        Me.btnPlus.TabIndex = 5
        Me.btnPlus.Text = "+"
        Me.btnPlus.UseVisualStyleBackColor = True
        '
        'btnEqual
        '
        Me.btnEqual.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnEqual.Location = New System.Drawing.Point(193, 339)
        Me.btnEqual.Name = "btnEqual"
        Me.btnEqual.Size = New System.Drawing.Size(50, 45)
        Me.btnEqual.TabIndex = 6
        Me.btnEqual.Text = "="
        Me.btnEqual.UseVisualStyleBackColor = True
        '
        'btnBackSpace
        '
        Me.btnBackSpace.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnBackSpace.Location = New System.Drawing.Point(137, 135)
        Me.btnBackSpace.Name = "btnBackSpace"
        Me.btnBackSpace.Size = New System.Drawing.Size(50, 45)
        Me.btnBackSpace.TabIndex = 7
        Me.btnBackSpace.Text = "↩"
        Me.btnBackSpace.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnClear.Location = New System.Drawing.Point(81, 135)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(50, 45)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "C"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btn9
        '
        Me.btn9.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn9.Location = New System.Drawing.Point(137, 186)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(50, 45)
        Me.btn9.TabIndex = 9
        Me.btn9.Text = "9"
        Me.btn9.UseVisualStyleBackColor = True
        '
        'btn8
        '
        Me.btn8.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn8.Location = New System.Drawing.Point(81, 186)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(50, 45)
        Me.btn8.TabIndex = 10
        Me.btn8.Text = "8"
        Me.btn8.UseVisualStyleBackColor = True
        '
        'btn7
        '
        Me.btn7.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn7.Location = New System.Drawing.Point(25, 186)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(50, 45)
        Me.btn7.TabIndex = 11
        Me.btn7.Text = "7"
        Me.btn7.UseVisualStyleBackColor = True
        '
        'btn4
        '
        Me.btn4.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn4.Location = New System.Drawing.Point(25, 237)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(50, 45)
        Me.btn4.TabIndex = 12
        Me.btn4.Text = "4"
        Me.btn4.UseVisualStyleBackColor = True
        '
        'btn5
        '
        Me.btn5.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn5.Location = New System.Drawing.Point(81, 237)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(50, 45)
        Me.btn5.TabIndex = 13
        Me.btn5.Text = "5"
        Me.btn5.UseVisualStyleBackColor = True
        '
        'btn6
        '
        Me.btn6.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn6.Location = New System.Drawing.Point(137, 237)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(50, 45)
        Me.btn6.TabIndex = 14
        Me.btn6.Text = "6"
        Me.btn6.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn3.Location = New System.Drawing.Point(137, 288)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(50, 45)
        Me.btn3.TabIndex = 15
        Me.btn3.Text = "3"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn2.Location = New System.Drawing.Point(81, 288)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(50, 45)
        Me.btn2.TabIndex = 16
        Me.btn2.Text = "2"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn1
        '
        Me.btn1.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn1.Location = New System.Drawing.Point(25, 288)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(50, 45)
        Me.btn1.TabIndex = 17
        Me.btn1.Text = "1"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'btnPoint
        '
        Me.btnPoint.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnPoint.Location = New System.Drawing.Point(137, 339)
        Me.btnPoint.Name = "btnPoint"
        Me.btnPoint.Size = New System.Drawing.Size(50, 45)
        Me.btnPoint.TabIndex = 18
        Me.btnPoint.Text = "."
        Me.btnPoint.UseVisualStyleBackColor = True
        '
        'btn0
        '
        Me.btn0.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn0.Location = New System.Drawing.Point(81, 339)
        Me.btn0.Name = "btn0"
        Me.btn0.Size = New System.Drawing.Size(50, 45)
        Me.btn0.TabIndex = 19
        Me.btn0.Text = "0"
        Me.btn0.UseVisualStyleBackColor = True
        '
        'btnPlusMinus
        '
        Me.btnPlusMinus.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnPlusMinus.Location = New System.Drawing.Point(25, 339)
        Me.btnPlusMinus.Name = "btnPlusMinus"
        Me.btnPlusMinus.Size = New System.Drawing.Size(50, 45)
        Me.btnPlusMinus.TabIndex = 20
        Me.btnPlusMinus.Text = "+/-"
        Me.btnPlusMinus.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 411)
        Me.Controls.Add(Me.btnPlusMinus)
        Me.Controls.Add(Me.btn0)
        Me.Controls.Add(Me.btnPoint)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn6)
        Me.Controls.Add(Me.btn5)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.btn7)
        Me.Controls.Add(Me.btn8)
        Me.Controls.Add(Me.btn9)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnBackSpace)
        Me.Controls.Add(Me.btnEqual)
        Me.Controls.Add(Me.btnPlus)
        Me.Controls.Add(Me.btnMinus)
        Me.Controls.Add(Me.btnTimes)
        Me.Controls.Add(Me.btnDivide)
        Me.Controls.Add(Me.lblPlural)
        Me.Controls.Add(Me.txtRecord)
        Me.Name = "Form1"
        Me.Text = "電卓"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtRecord As TextBox
    Friend WithEvents lblPlural As Label
    Friend WithEvents btnDivide As Button
    Friend WithEvents btnTimes As Button
    Friend WithEvents btnMinus As Button
    Friend WithEvents btnPlus As Button
    Friend WithEvents btnEqual As Button
    Friend WithEvents btnBackSpace As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btn9 As Button
    Friend WithEvents btn8 As Button
    Friend WithEvents btn7 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn1 As Button
    Friend WithEvents btnPoint As Button
    Friend WithEvents btn0 As Button
    Friend WithEvents btnPlusMinus As Button
End Class
