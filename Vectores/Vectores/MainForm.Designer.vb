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
		Me.txtnum1.Location = New System.Drawing.Point(22, 37)
		Me.txtnum1.Name = "txtnum1"
		Me.txtnum1.Size = New System.Drawing.Size(34, 20)
		Me.txtnum1.TabIndex = 0
		'
		'txtnum2
		'
		Me.txtnum2.Location = New System.Drawing.Point(62, 37)
		Me.txtnum2.Name = "txtnum2"
		Me.txtnum2.Size = New System.Drawing.Size(36, 20)
		Me.txtnum2.TabIndex = 1
		'
		'txtnum3
		'
		Me.txtnum3.Location = New System.Drawing.Point(104, 37)
		Me.txtnum3.Name = "txtnum3"
		Me.txtnum3.Size = New System.Drawing.Size(34, 20)
		Me.txtnum3.TabIndex = 2
		'
		'btnllenar
		'
		Me.btnllenar.Location = New System.Drawing.Point(443, 35)
		Me.btnllenar.Name = "btnllenar"
		Me.btnllenar.Size = New System.Drawing.Size(75, 22)
		Me.btnllenar.TabIndex = 3
		Me.btnllenar.Text = "llenar"
		Me.btnllenar.UseVisualStyleBackColor = true
		AddHandler Me.btnllenar.Click, AddressOf Me.BtnllenarClick
		'
		'btnnum1
		'
		Me.btnnum1.Location = New System.Drawing.Point(22, 90)
		Me.btnnum1.Name = "btnnum1"
		Me.btnnum1.Size = New System.Drawing.Size(34, 23)
		Me.btnnum1.TabIndex = 4
		Me.btnnum1.UseVisualStyleBackColor = true
		AddHandler Me.btnnum1.Click, AddressOf Me.Btnnum1Click
		'
		'btnnum2
		'
		Me.btnnum2.Location = New System.Drawing.Point(104, 90)
		Me.btnnum2.Name = "btnnum2"
		Me.btnnum2.Size = New System.Drawing.Size(34, 23)
		Me.btnnum2.TabIndex = 5
		Me.btnnum2.UseVisualStyleBackColor = true
		AddHandler Me.btnnum2.Click, AddressOf Me.Btnnum2Click
		'
		'btnnum3
		'
		Me.btnnum3.Location = New System.Drawing.Point(192, 90)
		Me.btnnum3.Name = "btnnum3"
		Me.btnnum3.Size = New System.Drawing.Size(38, 23)
		Me.btnnum3.TabIndex = 6
		Me.btnnum3.UseVisualStyleBackColor = true
		AddHandler Me.btnnum3.Click, AddressOf Me.Btnnum3Click
		'
		'txtindice
		'
		Me.txtindice.Location = New System.Drawing.Point(340, 90)
		Me.txtindice.Name = "txtindice"
		Me.txtindice.Size = New System.Drawing.Size(55, 20)
		Me.txtindice.TabIndex = 7
		'
		'vOper0
		'
		Me.vOper0.Location = New System.Drawing.Point(22, 139)
		Me.vOper0.Name = "vOper0"
		Me.vOper0.Size = New System.Drawing.Size(34, 23)
		Me.vOper0.TabIndex = 8
		Me.vOper0.Text = "+"
		Me.vOper0.UseVisualStyleBackColor = true
		AddHandler Me.vOper0.Click, AddressOf Me.VOper0Click
		'
		'vOper1
		'
		Me.vOper1.Location = New System.Drawing.Point(104, 139)
		Me.vOper1.Name = "vOper1"
		Me.vOper1.Size = New System.Drawing.Size(34, 23)
		Me.vOper1.TabIndex = 9
		Me.vOper1.Text = "-"
		Me.vOper1.UseVisualStyleBackColor = true
		AddHandler Me.vOper1.Click, AddressOf Me.VOper1Click
		'
		'vOper2
		'
		Me.vOper2.Location = New System.Drawing.Point(192, 139)
		Me.vOper2.Name = "vOper2"
		Me.vOper2.Size = New System.Drawing.Size(38, 23)
		Me.vOper2.TabIndex = 10
		Me.vOper2.Text = "*"
		Me.vOper2.UseVisualStyleBackColor = true
		AddHandler Me.vOper2.Click, AddressOf Me.VOper2Click
		'
		'btnHabilitar
		'
		Me.btnHabilitar.Location = New System.Drawing.Point(443, 90)
		Me.btnHabilitar.Name = "btnHabilitar"
		Me.btnHabilitar.Size = New System.Drawing.Size(75, 23)
		Me.btnHabilitar.TabIndex = 12
		Me.btnHabilitar.Text = "Habilitar"
		Me.btnHabilitar.UseVisualStyleBackColor = true
		AddHandler Me.btnHabilitar.Click, AddressOf Me.BtnHabilitarClick
		'
		'vOper3
		'
		Me.vOper3.Location = New System.Drawing.Point(280, 139)
		Me.vOper3.Name = "vOper3"
		Me.vOper3.Size = New System.Drawing.Size(38, 23)
		Me.vOper3.TabIndex = 13
		Me.vOper3.Text = "*"
		Me.vOper3.UseVisualStyleBackColor = true
		AddHandler Me.vOper3.Click, AddressOf Me.VOper3Click
		'
		'btnnum4
		'
		Me.btnnum4.Location = New System.Drawing.Point(280, 90)
		Me.btnnum4.Name = "btnnum4"
		Me.btnnum4.Size = New System.Drawing.Size(38, 23)
		Me.btnnum4.TabIndex = 14
		Me.btnnum4.UseVisualStyleBackColor = true
		AddHandler Me.btnnum4.Click, AddressOf Me.Btnnum4Click
		'
		'txtNum4
		'
		Me.txtNum4.Location = New System.Drawing.Point(148, 37)
		Me.txtNum4.Name = "txtNum4"
		Me.txtNum4.Size = New System.Drawing.Size(38, 20)
		Me.txtNum4.TabIndex = 15
		'
		'txtNum5
		'
		Me.txtNum5.Location = New System.Drawing.Point(192, 37)
		Me.txtNum5.Name = "txtNum5"
		Me.txtNum5.Size = New System.Drawing.Size(38, 20)
		Me.txtNum5.TabIndex = 16
		'
		'txtNum6
		'
		Me.txtNum6.Location = New System.Drawing.Point(236, 37)
		Me.txtNum6.Name = "txtNum6"
		Me.txtNum6.Size = New System.Drawing.Size(38, 20)
		Me.txtNum6.TabIndex = 17
		'
		'txtNum7
		'
		Me.txtNum7.Location = New System.Drawing.Point(280, 37)
		Me.txtNum7.Name = "txtNum7"
		Me.txtNum7.Size = New System.Drawing.Size(38, 20)
		Me.txtNum7.TabIndex = 18
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
