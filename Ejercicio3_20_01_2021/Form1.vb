Public Class Form1
    Dim M, Num1, Num2, Num3 As Double
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""

        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.FormBorderStyle = FormBorderStyle.FixedSingle

        Me.Text = "Ejercicio Precio - 20-01-2021"
        Label1.Text = "Introduzca el precio del producto en el establecimineto número 1 , en €"
        Label2.Text = "Introduzca el precio del producto en el establecimineto número 2 , en €"
        Label3.Text = "Introduzca el precio del producto en el establecimineto número 3 , en €"
        Label4.Text = ""
        Button1.Text = "Calcular"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Num1 = Val(TextBox1.Text)
        Num2 = Val(TextBox2.Text)
        Num3 = Val(TextBox3.Text)
        M = (Num1 + Num2 + Num3) / 3
        Label4.Text = ("El precio medio del producto es " & M & " €")
    End Sub
End Class
