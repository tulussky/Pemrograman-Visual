Public Class FrmArray
    Private Sub btnTampil_Click(sender As Object, e As EventArgs) Handles BtnTampil.Click
        'MessageBox.Show(Hitung(txtpanjang.Text, txtlebar.Text))
        'For i As Integer = 0 To nilai.Length - 1
        'lstNilai.Items.Add(nilai(i))
        'Next
        MessageBox.Show(nilai2D(1, 2))
    End Sub

    Private Sub txtPanjang_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpanjang.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtLebar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtlebar.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class