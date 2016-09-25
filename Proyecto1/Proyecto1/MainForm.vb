'
' Created by SharpDevelop.
' User: abuen
' Date: 16/8/2016
' Time: 20:47
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
	
	
	Sub Button1Click(sender As Object, e As EventArgs)
		subrutina1
	End Sub
	
	Sub subrutina1()
		textBox1.Text="Hola"
	End Sub
	
	
	Sub subrutina2(ByVal valor As String)
		textBox2.Text= valor
	End Sub
	
	Sub Button2Click(sender As Object, e As EventArgs)
		subrutina2("Como estas") 
	End Sub
	
	Sub Button3Click(sender As Object, e As EventArgs)
		subrutina3(8)		
	End Sub
	
	Sub subrutina3 (ByVal valor As String)
		textBox2.Text = valor *3 
	End Sub
	
	
	Sub Button4Click(sender As Object, e As EventArgs)
		textBox2.Text = Funcion1()		
	End Sub
	
	Function Funcion1() As String
		Return "Funcion" 
	End Function
	
	Sub Button5Click(sender As Object, e As EventArgs)
		textBox2.Text = Funcion2(8,5) 
	End Sub
	
	Function Funcion2(ByVal n1 As Integer, ByVal n2 As Integer) As Integer
		Dim total As Integer 
		total = n1 + n2 
		Return total
		
	End Function
	
	
	Sub Btnfunc3Click(sender As Object, e As EventArgs)
		textBox2.Text = Funcion3("Caso 3", 7).ToString
	End Sub
	
	Function Funcion3 (ByVal texto As String, ByVal num As Integer) As Integer
		Dim total As Integer
		textBox1.Text = texto
		total = num * 5
		Return total 
	End Function
End Class
