'
' Created by SharpDevelop.
' User: abuen
' Date: 25/8/2016
' Time: 21:01
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Public Class Calcular
	Dim Mensaje As String
	Sub New()
		Mensaje="Sin parametro" 
	End Sub
	
	Sub New (ByVal c As String)
		Mensaje= c
	End Sub
	
	Function Saludar() As String
		Return "hola"	
	End Function
		
	Function Sumar(ByVal n1 As Integer, ByVal n2 As Integer) As Integer
		Dim total As Integer
		total= n1+n2
		Return total
	End Function
	
	Function dMensaje() As String
		Return Mensaje
	End Function
		
End Class
