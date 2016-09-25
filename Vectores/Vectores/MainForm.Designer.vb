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
		Me.btnHabilitar = New System.Windows.Forms.Button()
		Me.vOper3 = New System.Windows.Forms.Button()
		Me.btnnum4 = New System.Windows.Forms.Button()
		Me.txtNum4 = New System.Windows.Forms.TextBox()
		Me.txtNum5 = New System.Windows.Forms.TextBox()
		Me.txtNum6 = New System.Windows.Forms.TextBox()
		Me.txtNum7 = New System.Windows.Forms.TextBox()
		Me.SuspendLayout
		'
		'txtnum1
		'
		Me.txtnum1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtnum1.Location = New System.Drawing.Point(30, 40)
		Me.txtnum1.Name = "txtnum1"
		Me.txtnum1.Size = New System.Drawing.Size(40, 26)
		Me.txtnum1.TabIndex = 0
		Me.txtnum1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'txtnum2
		'
		Me.txtnum2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtnum2.Location = New System.Drawing.Point(90, 40)
		Me.txtnum2.Name = "txtnum2"
		Me.txtnum2.Size = New System.Drawing.Size(40, 26)
		Me.txtnum2.TabIndex = 1
		Me.txtnum2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'txtnum3
		'
		Me.txtnum3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtnum3.Location = New System.Drawing.Point(150, 40)
		Me.txtnum3.Name = "txtnum3"
		Me.txtnum3.Size = New System.Drawing.Size(40, 26)
		Me.txtnum3.TabIndex = 2
		Me.txtnum3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'btnllenar
		'
		Me.btnllenar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnllenar.Location = New System.Drawing.Point(510, 90)
		Me.btnllenar.Name = "btnllenar"
		Me.btnllenar.Size = New System.Drawing.Size(75, 30)
		Me.btnllenar.TabIndex = 3
		Me.btnllenar.Text = "Iniciar"
		Me.btnllenar.UseVisualStyleBackColor = true
		AddHandler Me.btnllenar.Click, AddressOf Me.BtnllenarClick
		'
		'btnnum1
		'
		Me.btnnum1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Bold)
		Me.btnnum1.Location = New System.Drawing.Point(30, 90)
		Me.btnnum1.Name = "btnnum1"
		Me.btnnum1.Size = New System.Drawing.Size(40, 30)
		Me.btnnum1.TabIndex = 4
		Me.btnnum1.UseVisualStyleBackColor = true
		AddHandler Me.btnnum1.Click, AddressOf Me.Btnnum1Click
		'
		'btnnum2
		'
		Me.btnnum2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnnum2.Location = New System.Drawing.Point(150, 90)
		Me.btnnum2.Name = "btnnum2"
		Me.btnnum2.Size = New System.Drawing.Size(40, 30)
		Me.btnnum2.TabIndex = 5
		Me.btnnum2.UseVisualStyleBackColor = true
		AddHandler Me.btnnum2.Click, AddressOf Me.Btnnum2Click
		'
		'btnnum3
		'
		Me.btnnum3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnnum3.Location = New System.Drawing.Point(270, 89)
		Me.btnnum3.Name = "btnnum3"
		Me.btnnum3.Size = New System.Drawing.Size(40, 30)
		Me.btnnum3.TabIndex = 6
		Me.btnnum3.UseVisualStyleBackColor = true
		AddHandler Me.btnnum3.Click, AddressOf Me.Btnnum3Click
		'
		'txtindice
		'
		Me.txtindice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtindice.Location = New System.Drawing.Point(449, 90)
		Me.txtindice.Name = "txtindice"
		Me.txtindice.Size = New System.Drawing.Size(34, 26)
		Me.txtindice.TabIndex = 7
		'
		'vOper0
		'
		Me.vOper0.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.vOper0.Location = New System.Drawing.Point(30, 140)
		Me.vOper0.Name = "vOper0"
		Me.vOper0.Size = New System.Drawing.Size(40, 30)
		Me.vOper0.TabIndex = 8
		Me.vOper0.Text = "+"
		Me.vOper0.UseVisualStyleBackColor = true
		AddHandler Me.vOper0.Click, AddressOf Me.VOper0Click
		'
		'vOper1
		'
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
		Me.vOper2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.vOper2.Location = New System.Drawing.Point(270, 140)
		Me.vOper2.Name = "vOper2"
		Me.vOper2.Size = New System.Drawing.Size(40, 30)
		Me.vOper2.TabIndex = 10
		Me.vOper2.Text = "*"
		Me.vOper2.UseVisualStyleBackColor = true
		AddHandler Me.vOper2.Click, AddressOf Me.VOper2Click
		'
		'btnHabilitar
		'
		Me.btnHabilitar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnHabilitar.Location = New System.Drawing.Point(510, 140)
		Me.btnHabilitar.Name = "btnHabilitar"
		Me.btnHabilitar.Size = New System.Drawing.Size(75, 30)
		Me.btnHabilitar.TabIndex = 12
		Me.btnHabilitar.Text = "Habilitar"
		Me.btnHabilitar.UseVisualStyleBackColor = true
		AddHandler Me.btnHabilitar.Click, AddressOf Me.BtnHabilitarClick
		'
		'vOper3
		'
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
		Me.btnnum4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnnum4.Location = New System.Drawing.Point(390, 90)
		Me.btnnum4.Name = "btnnum4"
		Me.btnnum4.Size = New System.Drawing.Size(40, 30)
		Me.btnnum4.TabIndex = 14
		Me.btnnum4.UseVisualStyleBackColor = true
		AddHandler Me.btnnum4.Click, AddressOf Me.Btnnum4Click
		'
		'txtNum4
		'
		Me.txtNum4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtNum4.Location = New System.Drawing.Point(210, 40)
		Me.txtNum4.Name = "txtNum4"
		Me.txtNum4.Size = New System.Drawing.Size(40, 26)
		Me.txtNum4.TabIndex = 15
		Me.txtNum4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'txtNum5
		'
		Me.txtNum5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtNum5.Location = New System.Drawing.Point(270, 40)
		Me.txtNum5.Name = "txtNum5"
		Me.txtNum5.Size = New System.Drawing.Size(40, 26)
		Me.txtNum5.TabIndex = 16
		Me.txtNum5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'txtNum6
		'
		Me.txtNum6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtNum6.Location = New System.Drawing.Point(330, 40)
		Me.txtNum6.Name = "txtNum6"
		Me.txtNum6.Size = New System.Drawing.Size(40, 26)
		Me.txtNum6.TabIndex = 17
		Me.txtNum6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'txtNum7
		'
		Me.txtNum7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtNum7.Location = New System.Drawing.Point(390, 40)
		Me.txtNum7.Name = "txtNum7"
		Me.txtNum7.Size = New System.Drawing.Size(40, 26)
		Me.txtNum7.TabIndex = 18
		Me.txtNum7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(628, 292)
		Me.Controls.Add(Me.txtNum7)
		Me.Controls.Add(Me.txtNum6)
		Me.Controls.Add(Me.txtNum5)
		Me.Controls.Add(Me.txtNum4)
		Me.Controls.Add(Me.btnnum4)
		Me.Controls.Add(Me.vOper3)
		Me.Controls.Add(Me.btnHabilitar)
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
		Me.Name = "MainForm"
		Me.Text = "vectores"
		AddHandler Load, AddressOf Me.MainFormLoad
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private txtNum7 As System.Windows.Forms.TextBox
	Private txtNum6 As System.Windows.Forms.TextBox
	Private txtNum5 As System.Windows.Forms.TextBox
	Private txtNum4 As System.Windows.Forms.TextBox
	Private btnnum4 As System.Windows.Forms.Button
	Private vOper3 As System.Windows.Forms.Button
	Private btnHabilitar As System.Windows.Forms.Button
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
