'
' Created by SharpDevelop.
' User: abuen
' Date: 13/9/2016
' Time: 21:00
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class MainForm
	Inherits System.Windows.Forms.Form
	
	''' <summary>
	''' Designer variable used to keep track of non-visual components.
	''' </summary>
	Private components As System.ComponentModel.IContainer
	
	''' <summary>
	''' Disposes resources used by the form.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If components IsNot Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(disposing)
	End Sub
	
	''' <summary>
	''' This method is required for Windows Forms designer support.
	''' Do not change the method contents inside the source code editor. The Forms designer might
	''' not be able to load this method if it was changed manually.
	''' </summary>
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
		Me.btnIniciar = New System.Windows.Forms.Button()
		Me.txtN1 = New System.Windows.Forms.TextBox()
		Me.timer1 = New System.Windows.Forms.Timer(Me.components)
		Me.cohete = New System.Windows.Forms.PictureBox()
		Me.timer2 = New System.Windows.Forms.Timer(Me.components)
		CType(Me.cohete,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'btnIniciar
		'
		Me.btnIniciar.Location = New System.Drawing.Point(197, 12)
		Me.btnIniciar.Name = "btnIniciar"
		Me.btnIniciar.Size = New System.Drawing.Size(75, 23)
		Me.btnIniciar.TabIndex = 0
		Me.btnIniciar.Text = "Iniciar"
		Me.btnIniciar.UseVisualStyleBackColor = true
		AddHandler Me.btnIniciar.Click, AddressOf Me.Button1Click
		'
		'txtN1
		'
		Me.txtN1.Location = New System.Drawing.Point(23, 14)
		Me.txtN1.Name = "txtN1"
		Me.txtN1.Size = New System.Drawing.Size(100, 20)
		Me.txtN1.TabIndex = 1
		'
		'timer1
		'
		Me.timer1.Interval = 200
		AddHandler Me.timer1.Tick, AddressOf Me.Timer1Tick
		'
		'cohete
		'
		Me.cohete.Image = CType(resources.GetObject("cohete.Image"),System.Drawing.Image)
		Me.cohete.Location = New System.Drawing.Point(23, 329)
		Me.cohete.Name = "cohete"
		Me.cohete.Size = New System.Drawing.Size(70, 75)
		Me.cohete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.cohete.TabIndex = 2
		Me.cohete.TabStop = false
		'
		'timer2
		'
		Me.timer2.Interval = 1
		AddHandler Me.timer2.Tick, AddressOf Me.Timer2Tick
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(284, 457)
		Me.Controls.Add(Me.cohete)
		Me.Controls.Add(Me.txtN1)
		Me.Controls.Add(Me.btnIniciar)
		Me.Name = "MainForm"
		Me.Text = "CrearBotones"
		CType(Me.cohete,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private timer2 As System.Windows.Forms.Timer
	Private cohete As System.Windows.Forms.PictureBox
	Private timer1 As System.Windows.Forms.Timer
	Private txtN1 As System.Windows.Forms.TextBox
	Private btnIniciar As System.Windows.Forms.Button
End Class
