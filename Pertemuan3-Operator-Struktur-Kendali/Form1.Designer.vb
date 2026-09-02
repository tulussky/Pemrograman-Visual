<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        txtNilai = New TextBox()
        picImage = New PictureBox()
        btnInput = New Button()
        CType(picImage, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtNilai
        ' 
        txtNilai.Location = New Point(175, 172)
        txtNilai.Name = "txtNilai"
        txtNilai.Size = New Size(100, 23)
        txtNilai.TabIndex = 3
        ' 
        ' picImage
        ' 
        picImage.Location = New Point(175, 51)
        picImage.Name = "picImage"
        picImage.Size = New Size(100, 100)
        picImage.SizeMode = PictureBoxSizeMode.Zoom
        picImage.TabIndex = 4
        picImage.TabStop = False
        ' 
        ' btnInput
        ' 
        btnInput.Location = New Point(187, 201)
        btnInput.Name = "btnInput"
        btnInput.Size = New Size(75, 23)
        btnInput.TabIndex = 5
        btnInput.Text = "Input"
        btnInput.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnInput)
        Controls.Add(picImage)
        Controls.Add(txtNilai)
        Name = "Form1"
        Text = "Form1"
        CType(picImage, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents txtNilai As TextBox
    Friend WithEvents picImage As PictureBox
    Friend WithEvents btnInput As Button

End Class
