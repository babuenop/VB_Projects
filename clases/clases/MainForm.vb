﻿'
' Created by SharpDevelop.
' User: abuen
' Date: 25/8/2016
' Time: 20:53
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Public Partial Class MainForm
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	Sub BtnEjecutarClick(sender As Object, e As EventArgs)
		Dim calcular As Calcular = New Calcular("con") 
		txtresultado.Text = Calcular.Saludar
		txtSuma.Text = Calcular.Sumar (5,8).ToString
		txtMensaje.Text = calcular.dMensaje
		
		
	End Sub
End Class
