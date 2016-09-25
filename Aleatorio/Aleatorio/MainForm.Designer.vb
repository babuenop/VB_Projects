'
' Created by SharpDevelop.
' User: abuen
' Date: 23/8/2016
' Time: 20:28
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
		Me.txtnum = New System.Windows.Forms.TextBox()
		Me.btnGenerar = New System.Windows.Forms.Button()
		Me.SuspendLayout
		'
		'txtnum
		'
		Me.txtnum.Location = New System.Drawing.Point(28, 24)
		Me.txtnum.Name = "txtnum"
		Me.txtnum.Size = New System.Drawing.Size(100, 20)
		Me.txtnum.TabIndex = 0
		'
		'btnGenerar
		'
		Me.btnGenerar.Location = New System.Drawing.Point(159, 20)
		Me.btnGenerar.Name = "btnGenerar"
		Me.btnGenerar.Size = New System.Drawing.Size(75, 23)
		Me.btnGenerar.TabIndex = 1
		Me.btnGenerar.Text = "Generar"
		Me.btnGenerar.UseVisualStyleBackColor = true
		AddHandler Me.btnGenerar.Click, AddressOf Me.BtnGenerarClick
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(284, 261)
		Me.Controls.Add(Me.btnGenerar)
		Me.Controls.Add(Me.txtnum)
		Me.Name = "MainForm"
		Me.Text = "Aleatorio"
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private btnGenerar As System.Windows.Forms.Button
	Private txtnum As System.Windows.Forms.TextBox
End Class
