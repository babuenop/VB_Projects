'
' Created by SharpDevelop.
' User: abuen
' Date: 23/8/2016
' Time: 20:28
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
	
	Sub BtnGenerarClick(sender As Object, e As EventArgs)
		Dim rnd As Random = New Random()
		txtnum.Text = rnd.Next(1,10)
		
	End Sub
End Class
