'
' Created by SharpDevelop.
' User: abueno
' Date: 24/9/2016
' Time: 22:35
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Public Class Calcular
	Function Sumar (ByVal n1 As Integer, ByVal n2 As Integer)
		Dim total As Integer
		total= n1+n2
		Return total
	End Function
	Function Restar(ByVal n1 As Integer, ByVal n2 As Integer)
		Dim total As Integer
		total= n1-n2
		Return total
	End Function
	Function Multiplicar(ByVal n1 As Integer, ByVal n2 As Integer)
		Dim total As Integer
		total= n1*n2
		Return total
	End Function
	Function Dividir(ByVal n1 As Integer, ByVal n2 As Integer)
		Dim total As Integer
		total= n1/n2
		Return total
	End Function
End Class
