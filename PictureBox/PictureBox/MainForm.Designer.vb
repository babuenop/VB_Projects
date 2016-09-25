'
' Created by SharpDevelop.
' User: abuen
' Date: 22/9/2016
' Time: 20:47
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
		Me.cohete = New System.Windows.Forms.PictureBox()
		Me.btnInicio = New System.Windows.Forms.Button()
		Me.timer1 = New System.Windows.Forms.Timer(Me.components)
		CType(Me.cohete,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'cohete
		'
		Me.cohete.Image = CType(resources.GetObject("cohete.Image"),System.Drawing.Image)
		Me.cohete.Location = New System.Drawing.Point(12, 368)
		Me.cohete.Name = "cohete"
		Me.cohete.Size = New System.Drawing.Size(37, 35)
		Me.cohete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.cohete.TabIndex = 0
		Me.cohete.TabStop = false
		'
		'btnInicio
		'
		Me.btnInicio.Location = New System.Drawing.Point(381, 12)
		Me.btnInicio.Name = "btnInicio"
		Me.btnInicio.Size = New System.Drawing.Size(75, 23)
		Me.btnInicio.TabIndex = 1
		Me.btnInicio.Text = "Inicio"
		Me.btnInicio.UseVisualStyleBackColor = true
		AddHandler Me.btnInicio.Click, AddressOf Me.BtnInicioClick
		'
		'timer1
		'
		AddHandler Me.timer1.Tick, AddressOf Me.Timer1Tick
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(468, 415)
		Me.Controls.Add(Me.btnInicio)
		Me.Controls.Add(Me.cohete)
		Me.KeyPreview = true
		Me.Name = "MainForm"
		Me.Text = "PictureBox"
		CType(Me.cohete,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
	End Sub
	Private timer1 As System.Windows.Forms.Timer
	Private btnInicio As System.Windows.Forms.Button
	Private cohete As System.Windows.Forms.PictureBox
End Class
