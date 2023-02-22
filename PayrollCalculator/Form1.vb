Public Class Form1
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        Label4.Text = ""
        Label5.Text = ""
        Label6.Text = ""
        Label8.Text = ""
        TextBox1.Select()
        TextBox1.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        Dim strIncome
        Dim decIncome
        Dim decFica
        Dim decFederal
        Dim decState
        Dim decNet

        Dim cdecFica = 0.0765D
        Dim cdecFed = 0.22D
        Dim cdecState = 0.04D

        Dim payroll = TextBox1.Text
        Dim Aspayroll = Decimal.Parse(payroll)

        Dim Government = Aspayroll * cdecFica
        Dim Tax = Aspayroll * cdecFica
        Dim Tax2 = cdecFed * Aspayroll
        Dim Tax3 = cdecState * Aspayroll




        Dim Socialism = Aspayroll - Government - Tax - Tax2
        Dim stateTax =
        TextBox1.Text = Tax
        TextBox1.Text = Government

        Dim strSocialism = Socialism.ToString()
        Label6.Text = Tax3
        Label5.Text = Tax2
        Label4.Text = Tax
        Label8.Text = strSocialism







    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class
