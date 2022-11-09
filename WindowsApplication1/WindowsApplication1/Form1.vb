Public Class Form1
    Dim Operacion As String
    Dim ValorResultado As Nullable(Of Double) = Nothing
    Dim Valor2 As Nullable(Of Double) = Nothing
    Dim Bandera As Boolean
    Public Sub OperacionProceso()
        Bandera = True
        Valor2 = Val(tbresultado.Text)
        If ValorResultado IsNot Nothing Then
            Select Case Operacion
                Case "+"
                    ValorResultado = ValorResultado + Valor2
                Case "-"
                    ValorResultado -= Valor2
                Case "*"
                    ValorResultado *= Valor2
                Case "/"
                    ValorResultado /= Valor2
            End Select
            tbresultado.Text = ValorResultado
        Else
            ValorResultado = Valor2
        End If
    End Sub
    Public Sub DeterminarConcatenar()
        If Bandera = True Then
            tbresultado.Text = ""
            Bandera = False
        ElseIf tbresultado.Text = "0" Then
            tbresultado.Text = ""
        End If
    End Sub

    Private Sub bt7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt7.Click
        DeterminarConcatenar()
        tbresultado.Text &= "7"
    End Sub

    Private Sub bt9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt9.Click
        DeterminarConcatenar()
        tbresultado.Text &= "9"
    End Sub

    Private Sub bt6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt6.Click
        DeterminarConcatenar()
        tbresultado.Text &= "6"
    End Sub

    Private Sub btsuma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btsuma.Click
        OperacionProceso()
        Operacion = "+"
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbresultado.TextChanged

    End Sub

    Private Sub bt0_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles bt0.Click
        DeterminarConcatenar()
        tbresultado.Text &= "0"
    End Sub

    Private Sub bt1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt1.Click
        DeterminarConcatenar()
        tbresultado.Text &= "1"
    End Sub

    Private Sub bt2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt2.Click
        DeterminarConcatenar()
        tbresultado.Text &= "2"
    End Sub

    Private Sub bt3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt3.Click
        DeterminarConcatenar()
        tbresultado.Text &= "3"
    End Sub

    Private Sub bt4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt4.Click
        DeterminarConcatenar()
        tbresultado.Text &= "4"
    End Sub

    Private Sub bt5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt5.Click
        DeterminarConcatenar()
        tbresultado.Text &= "5"
    End Sub

    Private Sub bt8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt8.Click
        DeterminarConcatenar()
        tbresultado.Text &= "8"
    End Sub

    Private Sub btpunto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btpunto.Click
        DeterminarConcatenar()
        If InStr(tbresultado.Text, ".", CompareMethod.Text) = 0 Then tbresultado.Text &= "."

    End Sub

    Private Sub btmultiplicacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btmultiplicacion.Click
        OperacionProceso()
        Operacion = "*"
    End Sub

    Private Sub btresta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btresta.Click
        OperacionProceso()
        Operacion = "-"
    End Sub

    Private Sub btdivision_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btdivision.Click
        OperacionProceso()
        Operacion = "/"
    End Sub

    Private Sub btigual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btigual.Click
        OperacionProceso()
        Operacion = "="
    End Sub

    Private Sub btlimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btlimpiar.Click
        tbresultado.Text = "0"
        Valor2 = Nothing
        ValorResultado = Nothing
    End Sub
End Class
