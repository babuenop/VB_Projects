﻿'
' Created by SharpDevelop.
' User: abuen
' Date: 18/8/2016
' Time: 20:46
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
		Me.button1 = New System.Windows.Forms.Button()
		Me.lstValor = New System.Windows.Forms.ListBox()
		Me.SuspendLayout
		'
		'button1
		'
		Me.button1.Location = New System.Drawing.Point(13, 13)
		Me.button1.Name = "button1"
		Me.button1.Size = New System.Drawing.Size(75, 23)
		Me.button1.TabIndex = 0
		Me.button1.Text = "Ejecutar"
		Me.button1.UseVisualStyleBackColor = true
		AddHandler Me.button1.Click, AddressOf Me.Button1Click
		'
		'lstValor
		'
		Me.lstValor.FormattingEnabled = true
		Me.lstValor.Location = New System.Drawing.Point(13, 54)
		Me.lstValor.Name = "lstValor"
		Me.lstValor.Size = New System.Drawing.Size(120, 173)
		Me.lstValor.TabIndex = 1
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(284, 261)
		Me.Controls.Add(Me.lstValor)
		Me.Controls.Add(Me.button1)
		Me.Name = "MainForm"
		Me.Text = "Ciclos"
		Me.ResumeLayout(false)
	End Sub
	Private lstValor As System.Windows.Forms.ListBox
	Private button1 As System.Windows.Forms.Button
End Class
