'
' Created by SharpDevelop.
' User: abuen
' Date: 13/9/2016
' Time: 21:00
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Public Partial Class MainForm
	Dim vBoton (4) As Button
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	Sub Button1Click(sender As Object, e As EventArgs)
		Dim btnN1 As Button = New Button()
		Dim Boton As Button
		For i=1 To 4 
			Boton = New Button()
			Boton.Text =i 
			Boton.Size = New Point (30,30)
			Boton.Location = New Point ( 50*i,50) 
			vBoton(i)= Boton 
			Controls.Add(Boton)
			AddHandler Boton.Click, AddressOf Boton_Click
			
		Next
		timer1.Enabled=True
		timer2.Enabled=True
		
		btnN1.Text = "Boton Creado"
		btnN1.Size = New Point (100,25) 
		btnN1.Location = New Point (100,150)
		Controls.Add(btnN1)
		AddHandler btnN1.Click, AddressOf btnN1_Click
	End Sub
	
	Sub btnN1_Click (ByVal sender As Object, ByVal e As EventArgs) 
		Dim btn As Button
		btn = CType (sender, Button) 
		txtN1.Text = btn.Text
	End Sub
	
	Sub Boton_Click (ByVal sender As Object, ByVal e As EventArgs)
		Dim btn As Button 
		btn = CType (sender, Button) 
		txtN1.Text = btn.Text
		btn.Location = New Point (btn.Location.X, btn.Location.Y+2) 
	End Sub
	
	Sub Timer1Tick(sender As Object, e As EventArgs)
		Dim rnd As Random = New Random()
		Dim i As Integer
		i = rnd.Next (1,5)
		vBoton(i).Location = New Point(vBoton(i).Location.X, vBoton(i).Location.Y+2)
	End Sub
	
	Sub Timer2Tick(sender As Object, e As EventArgs)
		cohete.Location = New Point(cohete.Location.X, cohete.Location.Y-2)
	End Sub
End Class
