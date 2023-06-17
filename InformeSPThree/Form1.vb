Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CargarReporte()
        Dim oReporte As New SPprueba
        oReporte.DataSourceConnections.Item(0).SetLogon("sa", "system")
        oReporte.SetParameterValue("@texto", txtBuscar.Text)
        Me.crvReportes.ReportSource = oReporte
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        CargarReporte()
    End Sub
End Class
