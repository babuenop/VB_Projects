'
' Created by SharpDevelop.
' User: abuen
' Date: 18/8/2016
' Time: 21:04
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
		Dim Cantidad As Integer
		Dim i As Integer
		lstValor.Items.Clear
		Cantidad = txtNombre.Text.Length
		
		lstValor.Items.Add("Tiene " & Cantidad & " Letras")
		lstValor.Items.Add(txtNombre.Text.Substring(3))
		lstValor.Items.Add(txtNombre.Text.Substring(3,2))
		lstValor.Items.Add("Escalera")
		
		For i=1 To txtNombre.Text.Length
			lstValor.Items.Add(txtNombre.Text.Substring(0,i))
		Next
		
		lstValor.Items.Add("Escalera al reves")		
		
		For i=1 To txtNombre.Text.Length
			lstValor.Items.Add(txtNombre.Text.Substring(Cantidad-i,i))
		Next
		
		lstValor.Items.Add("Escalera al reves 2")		
		
		For i=txtNombre.Text.Length To 0 Step -1
			lstValor.Items.Add(txtNombre.Text.Substring(i))
			
		Next
		
	End Sub
End Class
