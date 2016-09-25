'
' Created by SharpDevelop.
' User: abuen
' Date: 30/8/2016
' Time: 20:43
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Public Partial Class MainForm
		Dim vTxt(7) As TextBox
		Dim vBtnN(4) As Button
		Dim vOper(4) As Button
		Dim IdOperacion As Integer
		
	Public Sub New()
		
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
		IdOperacion=0
		vTxt(0) = txtnum1
		vTxt(1) = txtnum2
		vTxt(2) = txtnum3
		vTxt(3) = txtnum4
		vTxt(4) = txtnum5
		vTxt(5) = txtnum6
		vTxt(6) = txtnum7
		
		vBtnN = New Button() {btnnum1,btnnum2,btnnum3, btnnum4}
		vOper = New Button() {vOper0,vOper1,vOper2,vOper3}
		
	End Sub
'	
	
	Sub BtnllenarClick(sender As Object, e As EventArgs)
		
		Dim i As Integer
		Dim rnd As Random = New Random
				
		For i = 0 To 3 		
			vBtnN(i).Text = rnd.Next(1,15)
			vBtnN(i).Tag = "0"
		Next
		txtindice.Text= "0"
		
		For i = 0 To 3
			vBtnN(i).Enabled = True
			vOper(i).Enabled = False
		Next
		
		btnllenar.Enabled=False
	End Sub
	
	Sub Btnnum1Click(sender As Object, e As EventArgs)
		CargarNumero(0)
		Deshabilitar()
		HabilitarOper()
		btnnum1.Tag =("1")
	End Sub
	
	Sub Btnnum2Click(sender As Object, e As EventArgs)
		CargarNumero(1)
		Deshabilitar()
		HabilitarOper()
		btnnum2.Tag =("1")
	End Sub
	
	Sub Btnnum3Click(sender As Object, e As EventArgs)
		CargarNumero(2)
		Deshabilitar()
		HabilitarOper()
		btnnum3.Tag =("1")
	End Sub
	
	Sub Btnnum4Click(sender As Object, e As EventArgs)
		CargarNumero(3)
		Deshabilitar()
		HabilitarOper()
		btnnum4.Tag =("1")
		Me.btnnum1.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray
	End Sub
	
	Private Sub CargarNumero (ByVal n As Integer) 
		vTxt(txtindice.Text).Text = vBtnN(n).Text
		txtindice.Text= txtindice.Text+1
	End Sub
	
	Private Sub CargarOper (ByVal n As Integer) 
		vTxt(txtindice.Text).Text = vOper(n).Text
		txtindice.Text= txtindice.Text+1
		Habilitar()
		DeshabilitarOper()
	End Sub
		
	Sub Habilitar()
		Dim i As Integer
		For i=0 To 3
			If vBtnN(i).Tag = "0" Then
				vBtnN(i).Enabled = True
				
			End If
		Next
	End Sub
	
	Sub Deshabilitar()
	Dim i As Integer
	For i= 0 To 3
	vBtnN(i).Enabled = False
		Next	
	End Sub
	
	Sub DeshabilitarOper()
	Dim i As Integer
	For i= 0 To 3
	vOper(i).Enabled = False
		Next	
	End Sub
	
	Sub HabilitarOper()
	Dim i As Integer
	For i= 0 To 3
	vOper(i).Enabled = True
		Next	
	End Sub
	
	Sub SelOperacion(ByVal i As Integer, ByVal n As Integer)
		If i=0 Then
			Dim calcular As Calcular = New Calcular
			txtR_Parcial.Text = Calcular.Sumar (txtR_Parcial.Text,vTxt(txtindice.Text).text).ToString
		End If
		If i=1 Then
			Dim calcular As Calcular = New Calcular
			txtR_Parcial.Text = Calcular.Restar (txtR_Parcial.Text,vTxt(txtindice.Text).Text).ToString
		End If
		If i=2 Then
			Dim calcular As Calcular = New Calcular
			txtR_Parcial.Text = Calcular.Multiplicar (txtR_Parcial.Text,vTxt(txtindice.Text).Text).ToString
		End If
		If i=3 Then
			Dim calcular As Calcular = New Calcular
			txtR_Parcial.Text = Calcular.Dividir (txtR_Parcial.Text,vTxt(txtindice.Text).Text).ToString
		End If
	End Sub
	

	
	Sub VOper0Click(sender As Object, e As EventArgs)
		CargarOper(0)
		IdOperacion=0
	End Sub
	
	Sub VOper1Click(sender As Object, e As EventArgs)
		CargarOper(1)	
		IdOperacion=1
	End Sub
	
	Sub VOper2Click(sender As Object, e As EventArgs)
		CargarOper(2)
		IdOperacion=2
	End Sub
	
	Sub VOper3Click(sender As Object, e As EventArgs)
		CargarOper(3)
		IdOperacion=3
	End Sub
	
	Sub Label1Click(sender As Object, e As EventArgs)
		
	End Sub
	
	Sub Txtnum1TextChanged(sender As Object, e As EventArgs)
		txtR_Parcial.Text = txtnum1.Text.ToString
	End Sub
	
	Sub Txtnum3TextChanged(sender As Object, e As EventArgs)
		SelOperacion(IdOperacion,txtindice.Text)
	End Sub
	
	Sub TxtNum5TextChanged(sender As Object, e As EventArgs)
		SelOperacion(IdOperacion,txtindice.Text)
	End Sub
	
	Sub TxtNum7TextChanged(sender As Object, e As EventArgs)
		SelOperacion(IdOperacion,txtindice.Text)
	End Sub
End Class
