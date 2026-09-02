Imports System.Diagnostics.Eventing.Reader

Public Class Form1
    Private Sub BtnInput_TextChanged(sender As Object, e As EventArgs)
        Dim nilaiUjian As Integer

        If Not Integer.TryParse(txtNilai.Text, nilaiUjian) Then
            MessageBox.Show("Input harus berupa angka!")
            txtNilai.Focus()
            Return
        End If

        If nilaiUjian < 0 Or nilaiUjian > 100 Then
            MessageBox.Show("Input harus antara 0 hingga 100!")
            txtNilai.Focus()
            Return
        End If

        If nilaiUjian <= 50 Then
            picImage.Image = Image.FromFile("Assets\images1.jpg")
        ElseIf nilaiUjian <= 75 Then
            picImage.Image = Image.FromFile("Assets\images2.jpg")
        Else
            picImage.Image = Image.FromFile("Assets\images3.jpg")
        End If


    End Sub

    Private Sub txtNilai_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNilai.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class
