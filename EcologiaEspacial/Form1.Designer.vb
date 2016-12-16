<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class asteroide
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(asteroide))
        Me.btnIniciar = New System.Windows.Forms.Button()
        Me.Cohete = New System.Windows.Forms.PictureBox()
        Me.TimerCohete = New System.Windows.Forms.Timer(Me.components)
        Me.TimerBasura = New System.Windows.Forms.Timer(Me.components)
        Me.TimerAsteroide = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.Cohete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnIniciar
        '
        Me.btnIniciar.Location = New System.Drawing.Point(303, 245)
        Me.btnIniciar.Name = "btnIniciar"
        Me.btnIniciar.Size = New System.Drawing.Size(100, 63)
        Me.btnIniciar.TabIndex = 0
        Me.btnIniciar.Text = "Iniciar"
        Me.btnIniciar.UseVisualStyleBackColor = True
        '
        'Cohete
        '
        Me.Cohete.Image = CType(resources.GetObject("Cohete.Image"), System.Drawing.Image)
        Me.Cohete.Location = New System.Drawing.Point(64, 376)
        Me.Cohete.Name = "Cohete"
        Me.Cohete.Size = New System.Drawing.Size(47, 80)
        Me.Cohete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Cohete.TabIndex = 1
        Me.Cohete.TabStop = False
        Me.Cohete.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-11, 288)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(41, 42)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'asteroide
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(700, 517)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Cohete)
        Me.Controls.Add(Me.btnIniciar)
        Me.Name = "asteroide"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ecology Space"
        CType(Me.Cohete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnIniciar As Button
    Friend WithEvents Cohete As PictureBox
    Friend WithEvents TimerCohete As Timer
    Friend WithEvents TimerBasura As Timer
    Friend WithEvents TimerAsteroide As Timer
    Friend WithEvents PictureBox1 As PictureBox
End Class
