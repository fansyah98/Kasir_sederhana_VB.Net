Public Class Form1
    Dim harga_makanan As Integer
    Dim jumlah_uang As Integer
    Dim harga_minuman, jumlah_makan, jumlah_minum, total As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case ComboBox1.Text
            Case "Nasi Goreng"
                Label1.Text = "12000"
                harga_makanan = 12000

            Case "Nasi Kuning"
                Label1.Text = "14000"
                harga_makanan = 14000

            Case "Ayam Bakar Anggara"
                Label1.Text = "10000"
                harga_makanan = 10000

            Case "Nasi Kangkung"
                Label1.Text = "8000"
                harga_makanan = 8000


        End Select
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Select Case ComboBox2.Text
            Case "Tea Jus"
                Label2.Text = "2500"
                harga_minuman = 2500

            Case "Susu"
                Label2.Text = "3500"
                harga_minuman = 3500

            Case "Kopi Kapal Api"
                Label2.Text = "4500"
                harga_minuman = 4500

            Case "Jeruk"
                Label2.Text = "5500"
                harga_minuman = 5500

                TextBox1.Focus()
        End Select
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        jumlah_makan = TextBox1.Text
        jumlah_minum = TextBox1.Text
        total = (harga_makanan * jumlah_makan) + (harga_minuman * jumlah_minum)
        Label5.Text = "Rp." & total.ToString
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs)
        jumlah_uang = Label6.Text
        jumlah_uang = total - jumlah_uang
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = False Then
            ComboBox2.Visible = False
            TextBox2.Visible = False
            Label2.Visible = False
            Label4.Visible = False

        ElseIf CheckBox1.Checked = True Then
            ComboBox2.Visible = True
            Label2.Visible = True
            Label4.Visible = True
            TextBox2.Visible = True
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
