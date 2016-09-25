'
' Created by SharpDevelop.
' User: abuen
' Date: 18/8/2016
' Time: 20:46
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
		Dim i As Integer

		lstValor.Items.Add("Ascendente")
		
		For i = 1 To 5 Step 1 
			lstValor.Items.Add(i)
		Next
		
		lstValor.Items.Add("descendente")
		
		For i = 5 To 1 Step -1
			lstValor.Items.Add(i)
		Next
		
		lstValor.Items.Add("while")
		i=1
		While i<=5
			lstValor.Items.Add(i)
			i+=1
		End While
		
		lstValor.Items.Add("while al reves")
		i=5
		While i>=1
			lstValor.Items.Add(i)
			i= i-1
		End While
		
		
	End Sub
End Class
