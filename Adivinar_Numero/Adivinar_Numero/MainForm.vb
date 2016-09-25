'
' Created by SharpDevelop.
' User: abuen
' Date: 23/8/2016
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
	
	Sub BtnInicioClick(sender As Object, e As EventArgs)
		Dim rnd As Random = New Random()
		txtCompu.Text = rnd.Next(1,101)
	End Sub
	
	Sub BtnVerificarClick(sender As Object, e As EventArgs)
		If txtUsuario.Text>txtCompu.Text Then
			MessageBox.Show("Muy Alto") 
			If txtUsuario.Text<txtCompu.Text Then
				MessageBox.Show("Muy Bajo")
			
			End If
		Else 
			MessageBox.Show("Correcto") 
		End If
		
	End Sub
End Class

--Agregar el contador--
--Hacer este mismo programa pero al reves 
--Mostrar las cantidad de intentos 
 