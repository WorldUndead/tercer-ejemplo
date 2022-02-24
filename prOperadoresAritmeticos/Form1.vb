Public Class Form1

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmult.TextChanged

    End Sub

    Private Sub btncalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncalcular.Click
        'Declaración de variables
        Dim num1 As Integer
        Dim num2 As Integer
        Dim suma, resta, mult As Integer
        Dim div As Double
        Dim potencia As Integer
        Dim raiz As Double

        'Entrada de datos

        num1 = Val(txtnum1.Text)
        num2 = Val(txtnum2.Text)

        'Proceso
        suma = num1 + num2
        resta = num1 - num2
        mult = num1 * num2
        div = num1 / num2
        potencia = num1 ^ num2
        raiz = num1 ^ (1 / num2)

        'Salida de Información
        txtsuma.Text = suma
        txtresta.Text = resta
        txtmult.Text = mult
        txtdiv.Text = div
        txtpot.Text = potencia
        txtraiz.Text = raiz

    End Sub

    Private Sub btnnuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnuevo.Click

        txtnum1.Clear()
        txtnum2.Clear()
        txtsuma.Clear()
        txtresta.Clear()
        txtmult.Clear()
        txtdiv.Clear()
        txtpot.Clear()
        txtraiz.Clear()

    End Sub

    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        End

    End Sub
End Class
