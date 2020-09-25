Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub b_hitung_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_hitung.Click
        If cb_humadity.Text = "Normal" Then
            Label_Hasil.Text = "YA"
        ElseIf cb_humadity.Text = "Tinggi" Then
            If cb_outlook.Text = "Berawan" Then
                Label_Hasil.Text = "YA"
            ElseIf cb_outlook.Text = "Cerah" Then
                Label_Hasil.Text = "Tidak"
            ElseIf cb_outlook.Text = "Hujan" Then
                Label_Hasil.Text = "YA"
            End If
        Else
            Label_Hasil.Text = "Silahkan Pilih Data"
        End If
    End Sub
End Class
