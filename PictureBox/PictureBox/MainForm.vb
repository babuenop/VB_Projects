'
' Created by SharpDevelop.
' User: abuen
' Date: 22/9/2016
' Time: 20:47
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Public Partial Class MainForm
	Dim y As Integer = 0 
	Dim x As Integer = 0 
	
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	Sub Timer1Tick(sender As Object, e As EventArgs)
		Dim rnd As Random 
	
	cohete.Location = New Point (cohete.Location.X+x,cohete.Location.Y+y)
	If cohete.Bounds.IntersectsWith(btnInicio.Bounds)Then
		timer1.Enabled = False
	End If
	If cohete.Location.X <=0 Then
		cohete.Location = New Point (0, cohete.Location.Y)
		x=-x
		verificadireccion()
	End If
	If cohete.Location.X >= Me.Width-10 Then
		x=-x
		verificadireccion()
	End If
	
	
	If cohete.Location.Y <=0  Then
		cohete.Location = New Point (0, cohete.Location.Y)
		y=-y
		verificadireccion()	
	End If
	If cohete.Location.Y >= Me.Height-10  Then
		y=-y
		verificadireccion()
	End If
	
	
	End Sub
	
	Sub BtnInicioClick(sender As Object, e As EventArgs)
		timer1.Enabled = True		
	End Sub
	Sub form_Key (sender As Object, e As KeyPressEventArgs) Handles me.KeyPress
		MessageBox.Show ("tecla: " + e.KeyChar.ToString())
	End Sub
	
	Protected Overrides Function ProcessCmdKey (ByRef msg As Message, ByVal keyData As Keys) As Boolean 
		Select Case keyData
			Case Keys.Up 
				'MessageBox.Show ("Arriba")
				y -= 1
			Case Keys.Down
				'MessageBox.Show ("Abajo")
				y += 1 
			Case Keys.Left
				'MessageBox.Show ("Abajo")
				x -= 1
			Case Keys.Right
				'MessageBox.Show ("Abajo")
				x += 1
		End Select
		Return MyBase.ProcessCmdKey(msg,keyData)
	End Function
	
	Sub verificadireccion() 
		If x>0 Then
			cohete.Image = Image.FromFile("C:\xampp\htdocs\DS7\Lab4\Image2.png")
		End If
		If x<0 Then
			cohete.Image = Image.FromFile("C:\xampp\htdocs\DS7\Lab4\Image3.png")
		End If
	End Sub
End Class
