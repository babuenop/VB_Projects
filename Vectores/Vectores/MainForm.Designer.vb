'
' Created by SharpDevelop.
' User: abuen
' Date: 30/8/2016
' Time: 20:43
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class MainForm
	Inherits System.Windows.Forms.Form
	
	''' <summary>
	''' Designer variable used to keep track of non-visual components.
	''' </summary>
	Private components As System.ComponentModel.IContainer
	
	''' <summary>
	''' Disposes resources used by the form.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If components IsNot Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(disposing)
	End Sub
	
	''' <summary>
	''' This method is required for Windows Forms designer support.
	''' Do not change the method contents inside the source code editor. The Forms designer might
	''' not be able to load this method if it was changed manually.
	''' </summary>
	Private Sub InitializeComponent()
		Me.txtnum1 = New System.Windows.Forms.TextBox()
		Me.txtnum2 = New System.Windows.Forms.TextBox()
		Me.txtnum3 = New System.Windows.Forms.TextBox()
		Me.btnllenar = New System.Windows.Forms.Button()
		Me.btnnum1 = New System.Windows.Forms.Button()
		Me.btnnum2 = New System.Windows.Forms.Button()
		Me.btnnum3 = New System.Windows.Forms.Button()
		Me.txtindice = New System.Windows.Forms.TextBox()
		Me.vOper0 = New System.Windows.Forms.Button()
		Me.vOper1 = New System.Windows.Forms.Button()
		Me.vOper2 = New System.Windows.Forms.Button()
		Me.vOper3 = New System.Windows.Forms.Button()
		Me.btnnum4 = New System.Windows.Forms.Button()
		Me.txtNum4 = New System.Windows.Forms.TextBox()
		Me.txtNum5 = New System.Windows.Forms.TextBox()
		Me.txtNum6 = New System.Windows.Forms.TextBox()
		Me.txtNum7 = New System.Windows.Forms.TextBox()
		Me.textBox2 = New System.Windows.Forms.TextBox()
		Me.label1 = New System.Windows.Forms.Label()
		Me.label2 = New System.Windows.Forms.Label()
		Me.txtR_Parcial = New System.Windows.Forms.TextBox()
		Me.SuspendLayout
		'
		'txtnum1
		'
		Me.txtnum1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtnum1.Location = New System.Drawing.Point(30, 40)
		Me.txtnum1.MaxLength = 2
		Me.txtnum1.Name = "txtnum1"
		Me.txtnum1.Size = New System.Drawing.Size(40, 26)
		Me.txtnum1.TabIndex = 0
		Me.txtnum1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		AddHandler Me.txtnum1.TextChanged, AddressOf Me.Txtnum1TextChanged
		'
		'txtnum2
		'
		Me.txtnum2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtnum2.Location = New System.Drawing.Point(90, 40)
		Me.txtnum2.MaxLength = 2
		Me.txtnum2.Name = "txtnum2"
		Me.txtnum2.Size = New System.Drawing.Size(40, 26)
		Me.txtnum2.TabIndex = 1
		Me.txtnum2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'txtnum3
		'
		Me.txtnum3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtnum3.Location = New System.Drawing.Point(150, 40)
		Me.txtnum3.MaxLength = 2
		Me.txtnum3.Name = "txtnum3"
		Me.txtnum3.Size = New System.Drawing.Size(40, 26)
		Me.txtnum3.TabIndex = 2
		Me.txtnum3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		AddHandler Me.txtnum3.TextChanged, AddressOf Me.Txtnum3TextChanged
		'
		'btnllenar
		'
		Me.btnllenar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnllenar.Location = New System.Drawing.Point(510, 40)
		Me.btnllenar.Name = "btnllenar"
		Me.btnllenar.Size = New System.Drawing.Size(75, 26)
		Me.btnllenar.TabIndex = 0
		Me.btnllenar.Text = "Iniciar"
		Me.btnllenar.UseVisualStyleBackColor = true
		AddHandler Me.btnllenar.Click, AddressOf Me.BtnllenarClick
		'
		'btnnum1
		'
		Me.btnnum1.BackColor = System.Drawing.SystemColors.ActiveCaption
		Me.btnnum1.Enabled = false
		Me.btnnum1.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray
		Me.btnnum1.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.btnnum1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnnum1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
		Me.btnnum1.Location = New System.Drawing.Point(30, 90)
		Me.btnnum1.Name = "btnnum1"
		Me.btnnum1.Size = New System.Drawing.Size(40, 30)
		Me.btnnum1.TabIndex = 0
		Me.btnnum1.UseVisualStyleBackColor = false
		AddHandler Me.btnnum1.Click, AddressOf Me.Btnnum1Click
		'
		'btnnum2
		'
		Me.btnnum2.BackColor = System.Drawing.SystemColors.ActiveCaption
		Me.btnnum2.Enabled = false
		Me.btnnum2.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray
		Me.btnnum2.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.btnnum2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnnum2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
		Me.btnnum2.Location = New System.Drawing.Point(150, 90)
		Me.btnnum2.Name = "btnnum2"
		Me.btnnum2.Size = New System.Drawing.Size(40, 30)
		Me.btnnum2.TabIndex = 0
		Me.btnnum2.UseVisualStyleBackColor = false
		AddHandler Me.btnnum2.Click, AddressOf Me.Btnnum2Click
		'
		'btnnum3
		'
		Me.btnnum3.BackColor = System.Drawing.SystemColors.ActiveCaption
		Me.btnnum3.Enabled = false
		Me.btnnum3.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray
		Me.btnnum3.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.btnnum3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnnum3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
		Me.btnnum3.Location = New System.Drawing.Point(270, 89)
		Me.btnnum3.Name = "btnnum3"
		Me.btnnum3.Size = New System.Drawing.Size(40, 30)
		Me.btnnum3.TabIndex = 0
		Me.btnnum3.UseVisualStyleBackColor = false
		AddHandler Me.btnnum3.Click, AddressOf Me.Btnnum3Click
		'
		'txtindice
		'
		Me.txtindice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtindice.Location = New System.Drawing.Point(446, 94)
		Me.txtindice.Name = "txtindice"
		Me.txtindice.Size = New System.Drawing.Size(34, 26)
		Me.txtindice.TabIndex = 7
		'
		'vOper0
		'
		Me.vOper0.BackColor = System.Drawing.SystemColors.Menu
		Me.vOper0.Enabled = false
		Me.vOper0.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.vOper0.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.vOper0.Location = New System.Drawing.Point(30, 140)
		Me.vOper0.Name = "vOper0"
		Me.vOper0.Size = New System.Drawing.Size(40, 30)
		Me.vOper0.TabIndex = 8
		Me.vOper0.Text = "+"
		Me.vOper0.UseVisualStyleBackColor = false
		AddHandler Me.vOper0.Click, AddressOf Me.VOper0Click
		'
		'vOper1
		'
		Me.vOper1.Enabled = false
		Me.vOper1.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.vOper1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.vOper1.Location = New System.Drawing.Point(150, 140)
		Me.vOper1.Name = "vOper1"
		Me.vOper1.Size = New System.Drawing.Size(40, 30)
		Me.vOper1.TabIndex = 9
		Me.vOper1.Text = "-"
		Me.vOper1.UseVisualStyleBackColor = true
		AddHandler Me.vOper1.Click, AddressOf Me.VOper1Click
		'
		'vOper2
		'
		Me.vOper2.Enabled = false
		Me.vOper2.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.vOper2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.vOper2.Location = New System.Drawing.Point(270, 140)
		Me.vOper2.Name = "vOper2"
		Me.vOper2.Size = New System.Drawing.Size(40, 30)
		Me.vOper2.TabIndex = 10
		Me.vOper2.Text = "*"
		Me.vOper2.UseVisualStyleBackColor = true
		AddHandler Me.vOper2.Click, AddressOf Me.VOper2Click
		'
		'vOper3
		'
		Me.vOper3.Enabled = false
		Me.vOper3.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.vOper3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.vOper3.Location = New System.Drawing.Point(390, 140)
		Me.vOper3.Name = "vOper3"
		Me.vOper3.Size = New System.Drawing.Size(40, 30)
		Me.vOper3.TabIndex = 13
		Me.vOper3.Text = "/"
		Me.vOper3.UseVisualStyleBackColor = true
		AddHandler Me.vOper3.Click, AddressOf Me.VOper3Click
		'
		'btnnum4
		'
		Me.btnnum4.BackColor = System.Drawing.SystemColors.ActiveCaption
		Me.btnnum4.Enabled = false
		Me.btnnum4.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray
		Me.btnnum4.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.btnnum4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnnum4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
		Me.btnnum4.Location = New System.Drawing.Point(390, 90)
		Me.btnnum4.Name = "btnnum4"
		Me.btnnum4.Size = New System.Drawing.Size(40, 30)
		Me.btnnum4.TabIndex = 0
		Me.btnnum4.UseVisualStyleBackColor = false
		AddHandler Me.btnnum4.Click, AddressOf Me.Btnnum4Click
		'
		'txtNum4
		'
		Me.txtNum4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtNum4.Location = New System.Drawing.Point(210, 40)
		Me.txtNum4.MaxLength = 2
		Me.txtNum4.Name = "txtNum4"
		Me.txtNum4.Size = New System.Drawing.Size(40, 26)
		Me.txtNum4.TabIndex = 3
		Me.txtNum4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'txtNum5
		'
		Me.txtNum5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtNum5.Location = New System.Drawing.Point(270, 40)
		Me.txtNum5.MaxLength = 2
		Me.txtNum5.Name = "txtNum5"
		Me.txtNum5.Size = New System.Drawing.Size(40, 26)
		Me.txtNum5.TabIndex = 4
		Me.txtNum5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		AddHandler Me.txtNum5.TextChanged, AddressOf Me.TxtNum5TextChanged
		'
		'txtNum6
		'
		Me.txtNum6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtNum6.Location = New System.Drawing.Point(330, 40)
		Me.txtNum6.MaxLength = 2
		Me.txtNum6.Name = "txtNum6"
		Me.txtNum6.Size = New System.Drawing.Size(40, 26)
		Me.txtNum6.TabIndex = 5
		Me.txtNum6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'txtNum7
		'
		Me.txtNum7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtNum7.Location = New System.Drawing.Point(390, 40)
		Me.txtNum7.MaxLength = 2
		Me.txtNum7.Name = "txtNum7"
		Me.txtNum7.Size = New System.Drawing.Size(40, 26)
		Me.txtNum7.TabIndex = 6
		Me.txtNum7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		AddHandler Me.txtNum7.TextChanged, AddressOf Me.TxtNum7TextChanged
		'
		'textBox2
		'
		Me.textBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.textBox2.Location = New System.Drawing.Point(390, 223)
		Me.textBox2.Name = "textBox2"
		Me.textBox2.Size = New System.Drawing.Size(40, 26)
		Me.textBox2.TabIndex = 20
		Me.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'label1
		'
		Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label1.Location = New System.Drawing.Point(30, 226)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(160, 23)
		Me.label1.TabIndex = 21
		Me.label1.Text = "Resultado Parcial"
		Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'label2
		'
		Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label2.Location = New System.Drawing.Point(270, 226)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(100, 23)
		Me.label2.TabIndex = 22
		Me.label2.Text = "Resultado"
		Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'txtR_Parcial
		'
		Me.txtR_Parcial.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtR_Parcial.Location = New System.Drawing.Point(175, 223)
		Me.txtR_Parcial.Name = "txtR_Parcial"
		Me.txtR_Parcial.Size = New System.Drawing.Size(75, 26)
		Me.txtR_Parcial.TabIndex = 23
		Me.txtR_Parcial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Menu
		Me.ClientSize = New System.Drawing.Size(605, 292)
		Me.Controls.Add(Me.txtR_Parcial)
		Me.Controls.Add(Me.label2)
		Me.Controls.Add(Me.label1)
		Me.Controls.Add(Me.textBox2)
		Me.Controls.Add(Me.txtNum7)
		Me.Controls.Add(Me.txtNum6)
		Me.Controls.Add(Me.txtNum5)
		Me.Controls.Add(Me.txtNum4)
		Me.Controls.Add(Me.btnnum4)
		Me.Controls.Add(Me.vOper3)
		Me.Controls.Add(Me.vOper2)
		Me.Controls.Add(Me.vOper1)
		Me.Controls.Add(Me.vOper0)
		Me.Controls.Add(Me.txtindice)
		Me.Controls.Add(Me.btnnum3)
		Me.Controls.Add(Me.btnnum2)
		Me.Controls.Add(Me.btnnum1)
		Me.Controls.Add(Me.btnllenar)
		Me.Controls.Add(Me.txtnum3)
		Me.Controls.Add(Me.txtnum2)
		Me.Controls.Add(Me.txtnum1)
		Me.ForeColor = System.Drawing.SystemColors.ControlText
		Me.KeyPreview = true
		Me.Name = "MainForm"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Vectores"
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private txtR_Parcial As System.Windows.Forms.TextBox
	Private label2 As System.Windows.Forms.Label
	Private label1 As System.Windows.Forms.Label
	Private textBox2 As System.Windows.Forms.TextBox
	Private txtNum7 As System.Windows.Forms.TextBox
	Private txtNum6 As System.Windows.Forms.TextBox
	Private txtNum5 As System.Windows.Forms.TextBox
	Private txtNum4 As System.Windows.Forms.TextBox
	Private btnnum4 As System.Windows.Forms.Button
	Private vOper3 As System.Windows.Forms.Button
	Private vOper2 As System.Windows.Forms.Button
	Private vOper1 As System.Windows.Forms.Button
	Private vOper0 As System.Windows.Forms.Button
	Private txtindice As System.Windows.Forms.TextBox
	Private btnnum3 As System.Windows.Forms.Button
	Private btnnum2 As System.Windows.Forms.Button
	Private btnnum1 As System.Windows.Forms.Button
	Private btnllenar As System.Windows.Forms.Button
	Private txtnum3 As System.Windows.Forms.TextBox
	Private txtnum2 As System.Windows.Forms.TextBox
	Private txtnum1 As System.Windows.Forms.TextBox
	


End Class
