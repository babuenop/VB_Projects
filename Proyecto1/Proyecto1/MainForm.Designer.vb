'
' Created by SharpDevelop.
' User: abuen
' Date: 16/8/2016
' Time: 20:47
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
		Me.textBox2 = New System.Windows.Forms.TextBox()
		Me.button1 = New System.Windows.Forms.Button()
		Me.button2 = New System.Windows.Forms.Button()
		Me.textBox1 = New System.Windows.Forms.TextBox()
		Me.button3 = New System.Windows.Forms.Button()
		Me.button4 = New System.Windows.Forms.Button()
		Me.button5 = New System.Windows.Forms.Button()
		Me.btnfunc3 = New System.Windows.Forms.Button()
		Me.SuspendLayout
		'
		'textBox2
		'
		Me.textBox2.Location = New System.Drawing.Point(13, 55)
		Me.textBox2.Name = "textBox2"
		Me.textBox2.Size = New System.Drawing.Size(100, 20)
		Me.textBox2.TabIndex = 1
		'
		'button1
		'
		Me.button1.Location = New System.Drawing.Point(170, 24)
		Me.button1.Name = "button1"
		Me.button1.Size = New System.Drawing.Size(75, 23)
		Me.button1.TabIndex = 2
		Me.button1.Text = "Subrutina1"
		Me.button1.UseVisualStyleBackColor = true
		AddHandler Me.button1.Click, AddressOf Me.Button1Click
		'
		'button2
		'
		Me.button2.Location = New System.Drawing.Point(170, 51)
		Me.button2.Name = "button2"
		Me.button2.Size = New System.Drawing.Size(75, 23)
		Me.button2.TabIndex = 3
		Me.button2.Text = "Subrutina2"
		Me.button2.UseVisualStyleBackColor = true
		AddHandler Me.button2.Click, AddressOf Me.Button2Click
		'
		'textBox1
		'
		Me.textBox1.Location = New System.Drawing.Point(13, 26)
		Me.textBox1.Name = "textBox1"
		Me.textBox1.Size = New System.Drawing.Size(100, 20)
		Me.textBox1.TabIndex = 4
		'
		'button3
		'
		Me.button3.Location = New System.Drawing.Point(170, 81)
		Me.button3.Name = "button3"
		Me.button3.Size = New System.Drawing.Size(75, 23)
		Me.button3.TabIndex = 5
		Me.button3.Text = "Subrutina3"
		Me.button3.UseVisualStyleBackColor = true
		AddHandler Me.button3.Click, AddressOf Me.Button3Click
		'
		'button4
		'
		Me.button4.Location = New System.Drawing.Point(286, 23)
		Me.button4.Name = "button4"
		Me.button4.Size = New System.Drawing.Size(75, 23)
		Me.button4.TabIndex = 6
		Me.button4.Text = "Funcion1"
		Me.button4.UseVisualStyleBackColor = true
		AddHandler Me.button4.Click, AddressOf Me.Button4Click
		'
		'button5
		'
		Me.button5.Location = New System.Drawing.Point(286, 51)
		Me.button5.Name = "button5"
		Me.button5.Size = New System.Drawing.Size(75, 23)
		Me.button5.TabIndex = 7
		Me.button5.Text = "Funcion2"
		Me.button5.UseVisualStyleBackColor = true
		AddHandler Me.button5.Click, AddressOf Me.Button5Click
		'
		'btnfunc3
		'
		Me.btnfunc3.Location = New System.Drawing.Point(286, 80)
		Me.btnfunc3.Name = "btnfunc3"
		Me.btnfunc3.Size = New System.Drawing.Size(75, 23)
		Me.btnfunc3.TabIndex = 8
		Me.btnfunc3.Text = "Funcion3"
		Me.btnfunc3.UseVisualStyleBackColor = true
		AddHandler Me.btnfunc3.Click, AddressOf Me.Btnfunc3Click
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(445, 261)
		Me.Controls.Add(Me.btnfunc3)
		Me.Controls.Add(Me.button5)
		Me.Controls.Add(Me.button4)
		Me.Controls.Add(Me.button3)
		Me.Controls.Add(Me.textBox1)
		Me.Controls.Add(Me.button2)
		Me.Controls.Add(Me.button1)
		Me.Controls.Add(Me.textBox2)
		Me.Name = "MainForm"
		Me.Text = "Proyecto1"
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private btnfunc3 As System.Windows.Forms.Button
	Private button5 As System.Windows.Forms.Button
	Private button4 As System.Windows.Forms.Button
	Private button3 As System.Windows.Forms.Button
	Private button1 As System.Windows.Forms.Button
	Private textBox1 As System.Windows.Forms.TextBox
	Private button2 As System.Windows.Forms.Button
	Private textBox2 As System.Windows.Forms.TextBox
End Class
