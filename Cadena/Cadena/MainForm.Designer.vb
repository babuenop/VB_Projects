'
' Created by SharpDevelop.
' User: abuen
' Date: 18/8/2016
' Time: 21:04
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
		Me.txtNombre = New System.Windows.Forms.TextBox()
		Me.btnEjecutar = New System.Windows.Forms.Button()
		Me.lstValor = New System.Windows.Forms.ListBox()
		Me.SuspendLayout
		'
		'txtNombre
		'
		Me.txtNombre.Location = New System.Drawing.Point(13, 13)
		Me.txtNombre.Name = "txtNombre"
		Me.txtNombre.Size = New System.Drawing.Size(120, 20)
		Me.txtNombre.TabIndex = 0
		'
		'btnEjecutar
		'
		Me.btnEjecutar.Location = New System.Drawing.Point(159, 13)
		Me.btnEjecutar.Name = "btnEjecutar"
		Me.btnEjecutar.Size = New System.Drawing.Size(75, 20)
		Me.btnEjecutar.TabIndex = 1
		Me.btnEjecutar.Text = "Ejecutar"
		Me.btnEjecutar.UseVisualStyleBackColor = true
		AddHandler Me.btnEjecutar.Click, AddressOf Me.BtnEjecutarClick
		'
		'lstValor
		'
		Me.lstValor.FormattingEnabled = true
		Me.lstValor.Location = New System.Drawing.Point(13, 51)
		Me.lstValor.Name = "lstValor"
		Me.lstValor.Size = New System.Drawing.Size(120, 147)
		Me.lstValor.TabIndex = 2
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(284, 261)
		Me.Controls.Add(Me.lstValor)
		Me.Controls.Add(Me.btnEjecutar)
		Me.Controls.Add(Me.txtNombre)
		Me.Name = "MainForm"
		Me.Text = "Cadena"
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private lstValor As System.Windows.Forms.ListBox
	Private btnEjecutar As System.Windows.Forms.Button
	Private txtNombre As System.Windows.Forms.TextBox
End Class
