﻿'
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Mainform))
        Me.cohete = New System.Windows.Forms.PictureBox()
        Me.btnInicio = New System.Windows.Forms.Button()
        Me.timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.timerAsteroide = New System.Windows.Forms.Timer(Me.components)
        Me.timerBasura = New System.Windows.Forms.Timer(Me.components)
        Me.pictureBox = New System.Windows.Forms.PictureBox()
        CType(Me.cohete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cohete
        '
        Me.cohete.Image = CType(resources.GetObject("cohete.Image"), System.Drawing.Image)
        Me.cohete.Location = New System.Drawing.Point(60, 383)
        Me.cohete.Name = "cohete"
        Me.cohete.Size = New System.Drawing.Size(40, 70)
        Me.cohete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.cohete.TabIndex = 0
        Me.cohete.TabStop = False
        '
        'timer1
        '
        '
        'pictureBox
        '
        Me.pictureBox.Location = New System.Drawing.Point(47, 175)
        Me.pictureBox.Name = "pictureBox"
        Me.pictureBox.Size = New System.Drawing.Size(100, 50)
        Me.pictureBox.TabIndex = 2
        Me.pictureBox.TabStop = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(697, 521)
        Me.Controls.Add(Me.pictureBox)
        Me.Controls.Add(Me.btnInicio)
        Me.Controls.Add(Me.cohete)
        Me.KeyPreview = True
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PictureBox"
        CType(Me.cohete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub
    Private pictureBox As System.Windows.Forms.PictureBox
    Private timerBasura As System.Windows.Forms.Timer
    Private timerAsteroide As System.Windows.Forms.Timer
    Private timer1 As System.Windows.Forms.Timer
    Private btnInicio As System.Windows.Forms.Button
    Private cohete As System.Windows.Forms.PictureBox
End Class
