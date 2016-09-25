'
' Created by SharpDevelop.
' User: abuen
' Date: 13/9/2016
' Time: 20:45
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Public Partial Class MainForm
	Dim vtxt(3) As TextBox
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
		vtxt = New TextBox (){textBox1, textBox2, textBox2}
		
	End Sub
	
	
	Sub BtnLlenarClick(sender As Object, e As EventArgs)
				
	End Sub
End Class
