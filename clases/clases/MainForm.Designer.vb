'
' Created by SharpDevelop.
' User: abuen
' Date: 25/8/2016
' Time: 20:53
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
		Me.txtresultado = New System.Windows.Forms.TextBox()
		Me.btnEjecutar = New System.Windows.Forms.Button()
		Me.txtSuma = New System.Windows.Forms.TextBox()
		Me.txtMensaje = New System.Windows.Forms.TextBox()
		Me.SuspendLayout
		'
		'txtresultado
		'
		Me.txtresultado.Location = New System.Drawing.Point(30, 27)
		Me.txtresultado.Name = "txtresultado"
		Me.txtresultado.Size = New System.Drawing.Size(100, 20)
		Me.txtresultado.TabIndex = 0
		'
		'btnEjecutar
		'
		Me.btnEjecutar.Location = New System.Drawing.Point(169, 27)
		Me.btnEjecutar.Name = "btnEjecutar"
		Me.btnEjecutar.Size = New System.Drawing.Size(75, 23)
		Me.btnEjecutar.TabIndex = 1
		Me.btnEjecutar.Text = "Ejecutar"
		Me.btnEjecutar.UseVisualStyleBackColor = true
		AddHandler Me.btnEjecutar.Click, AddressOf Me.BtnEjecutarClick
		'
		'txtSuma
		'
		Me.txtSuma.Location = New System.Drawing.Point(30, 69)
		Me.txtSuma.Name = "txtSuma"
		Me.txtSuma.Size = New System.Drawing.Size(100, 20)
		Me.txtSuma.TabIndex = 2
		'
		'txtMensaje
		'
		Me.txtMensaje.Location = New System.Drawing.Point(30, 115)
		Me.txtMensaje.Name = "txtMensaje"
		Me.txtMensaje.Size = New System.Drawing.Size(214, 20)
		Me.txtMensaje.TabIndex = 3
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(284, 261)
		Me.Controls.Add(Me.txtMensaje)
		Me.Controls.Add(Me.txtSuma)
		Me.Controls.Add(Me.btnEjecutar)
		Me.Controls.Add(Me.txtresultado)
		Me.Name = "MainForm"
		Me.Text = "clases"
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private txtMensaje As System.Windows.Forms.TextBox
	Private txtSuma As System.Windows.Forms.TextBox
	Private btnEjecutar As System.Windows.Forms.Button
	Private txtresultado As System.Windows.Forms.TextBox
End Class
