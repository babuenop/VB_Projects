'
' Created by SharpDevelop.
' User: abuen
' Date: 23/8/2016
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
		Me.txtCompu = New System.Windows.Forms.TextBox()
		Me.btnInicio = New System.Windows.Forms.Button()
		Me.txtUsuario = New System.Windows.Forms.TextBox()
		Me.btnVerificar = New System.Windows.Forms.Button()
		Me.SuspendLayout
		'
		'txtCompu
		'
		Me.txtCompu.Location = New System.Drawing.Point(25, 23)
		Me.txtCompu.Name = "txtCompu"
		Me.txtCompu.Size = New System.Drawing.Size(100, 20)
		Me.txtCompu.TabIndex = 0
		'
		'btnInicio
		'
		Me.btnInicio.Location = New System.Drawing.Point(172, 20)
		Me.btnInicio.Name = "btnInicio"
		Me.btnInicio.Size = New System.Drawing.Size(75, 23)
		Me.btnInicio.TabIndex = 1
		Me.btnInicio.Text = "Inicio"
		Me.btnInicio.UseVisualStyleBackColor = true
		AddHandler Me.btnInicio.Click, AddressOf Me.BtnInicioClick
		'
		'txtUsuario
		'
		Me.txtUsuario.Location = New System.Drawing.Point(25, 64)
		Me.txtUsuario.Name = "txtUsuario"
		Me.txtUsuario.Size = New System.Drawing.Size(100, 20)
		Me.txtUsuario.TabIndex = 2
		'
		'btnVerificar
		'
		Me.btnVerificar.Location = New System.Drawing.Point(172, 64)
		Me.btnVerificar.Name = "btnVerificar"
		Me.btnVerificar.Size = New System.Drawing.Size(75, 23)
		Me.btnVerificar.TabIndex = 3
		Me.btnVerificar.Text = "Verificar"
		Me.btnVerificar.UseVisualStyleBackColor = true
		AddHandler Me.btnVerificar.Click, AddressOf Me.BtnVerificarClick
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(284, 261)
		Me.Controls.Add(Me.btnVerificar)
		Me.Controls.Add(Me.txtUsuario)
		Me.Controls.Add(Me.btnInicio)
		Me.Controls.Add(Me.txtCompu)
		Me.Name = "MainForm"
		Me.Text = "Adivinar_Numero"
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private btnVerificar As System.Windows.Forms.Button
	Private txtUsuario As System.Windows.Forms.TextBox
	Private btnInicio As System.Windows.Forms.Button
	Private txtCompu As System.Windows.Forms.TextBox
End Class
