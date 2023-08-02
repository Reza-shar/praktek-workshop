<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        PictureBox1 = New PictureBox()
        Button1 = New Button()
        OpenFileDialog1 = New OpenFileDialog()
        TrackBar1 = New TrackBar()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TrackBar2 = New TrackBar()
        TextBox3 = New TextBox()
        TrackBar3 = New TrackBar()
        TextBox4 = New TextBox()
        TrackBar4 = New TrackBar()
        Button2 = New Button()
        PictureBox2 = New PictureBox()
        Label1 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(TrackBar1, ComponentModel.ISupportInitialize).BeginInit()
        CType(TrackBar2, ComponentModel.ISupportInitialize).BeginInit()
        CType(TrackBar3, ComponentModel.ISupportInitialize).BeginInit()
        CType(TrackBar4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(12, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(280, 335)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(12, 382)
        Button1.Name = "Button1"
        Button1.Size = New Size(280, 51)
        Button1.TabIndex = 1
        Button1.Text = "..."
        Button1.UseVisualStyleBackColor = True
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' TrackBar1
        ' 
        TrackBar1.Location = New Point(366, 398)
        TrackBar1.Maximum = 100
        TrackBar1.Name = "TrackBar1"
        TrackBar1.Size = New Size(104, 45)
        TrackBar1.TabIndex = 3
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(474, 398)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(44, 23)
        TextBox1.TabIndex = 4
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(474, 427)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(44, 23)
        TextBox2.TabIndex = 6
        ' 
        ' TrackBar2
        ' 
        TrackBar2.Location = New Point(366, 427)
        TrackBar2.Name = "TrackBar2"
        TrackBar2.Size = New Size(104, 45)
        TrackBar2.TabIndex = 5
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(688, 398)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(44, 23)
        TextBox3.TabIndex = 8
        ' 
        ' TrackBar3
        ' 
        TrackBar3.Location = New Point(578, 398)
        TrackBar3.Name = "TrackBar3"
        TrackBar3.Size = New Size(104, 45)
        TrackBar3.TabIndex = 7
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(688, 434)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(44, 23)
        TextBox4.TabIndex = 10
        ' 
        ' TrackBar4
        ' 
        TrackBar4.Location = New Point(578, 427)
        TrackBar4.Maximum = 100
        TrackBar4.Name = "TrackBar4"
        TrackBar4.Size = New Size(104, 45)
        TrackBar4.TabIndex = 9
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(718, 158)
        Button2.Name = "Button2"
        Button2.Size = New Size(57, 51)
        Button2.TabIndex = 13
        Button2.Text = "Enter"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Location = New Point(420, 12)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(280, 335)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 14
        PictureBox2.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(518, 370)
        Label1.Name = "Label1"
        Label1.Size = New Size(96, 15)
        Label1.TabIndex = 15
        Label1.Text = "Pembatas Warna"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 467)
        Controls.Add(Label1)
        Controls.Add(PictureBox2)
        Controls.Add(Button2)
        Controls.Add(TextBox4)
        Controls.Add(TrackBar4)
        Controls.Add(TextBox3)
        Controls.Add(TrackBar3)
        Controls.Add(TextBox2)
        Controls.Add(TrackBar2)
        Controls.Add(TextBox1)
        Controls.Add(TrackBar1)
        Controls.Add(Button1)
        Controls.Add(PictureBox1)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(TrackBar1, ComponentModel.ISupportInitialize).EndInit()
        CType(TrackBar2, ComponentModel.ISupportInitialize).EndInit()
        CType(TrackBar3, ComponentModel.ISupportInitialize).EndInit()
        CType(TrackBar4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents TrackBar1 As TrackBar
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TrackBar2 As TrackBar
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TrackBar3 As TrackBar
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TrackBar4 As TrackBar
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
End Class
