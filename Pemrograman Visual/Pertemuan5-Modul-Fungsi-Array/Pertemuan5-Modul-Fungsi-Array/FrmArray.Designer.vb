<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmArray
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
        BtnTampil = New Button()
        txtlebar = New TextBox()
        txtpanjang = New TextBox()
        lblPanjang = New Label()
        lblLebar = New Label()
        lstNilai = New ListBox()
        SuspendLayout()
        ' 
        ' BtnTampil
        ' 
        BtnTampil.Location = New Point(426, 117)
        BtnTampil.Name = "BtnTampil"
        BtnTampil.Size = New Size(75, 23)
        BtnTampil.TabIndex = 0
        BtnTampil.Text = "Tampilkan"
        BtnTampil.UseVisualStyleBackColor = True
        ' 
        ' txtlebar
        ' 
        txtlebar.Location = New Point(483, 69)
        txtlebar.Name = "txtlebar"
        txtlebar.Size = New Size(100, 23)
        txtlebar.TabIndex = 1
        ' 
        ' txtpanjang
        ' 
        txtpanjang.Location = New Point(347, 69)
        txtpanjang.Name = "txtpanjang"
        txtpanjang.Size = New Size(100, 23)
        txtpanjang.TabIndex = 2
        ' 
        ' lblPanjang
        ' 
        lblPanjang.AutoSize = True
        lblPanjang.Location = New Point(337, 51)
        lblPanjang.Name = "lblPanjang"
        lblPanjang.Size = New Size(110, 15)
        lblPanjang.TabIndex = 3
        lblPanjang.Text = "Masukkan Panjang:"
        ' 
        ' lblLebar
        ' 
        lblLebar.AutoSize = True
        lblLebar.Location = New Point(483, 51)
        lblLebar.Name = "lblLebar"
        lblLebar.Size = New Size(96, 15)
        lblLebar.TabIndex = 4
        lblLebar.Text = "Masukkan Lebar:"
        ' 
        ' lstNilai
        ' 
        lstNilai.FormattingEnabled = True
        lstNilai.Location = New Point(426, 146)
        lstNilai.Name = "lstNilai"
        lstNilai.Size = New Size(157, 139)
        lstNilai.TabIndex = 5
        ' 
        ' FrmArray
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lstNilai)
        Controls.Add(lblLebar)
        Controls.Add(lblPanjang)
        Controls.Add(txtpanjang)
        Controls.Add(txtlebar)
        Controls.Add(BtnTampil)
        Name = "FrmArray"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BtnTampil As Button
    Friend WithEvents txtlebar As TextBox
    Friend WithEvents txtpanjang As TextBox
    Friend WithEvents lblPanjang As Label
    Friend WithEvents lblLebar As Label
    Friend WithEvents lstNilai As ListBox

End Class
