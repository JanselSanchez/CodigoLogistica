Public Class Form1
    Dim prod As Integer = 0
    Dim adm As Integer = 0
    Dim cont As Integer = 0
    Dim venta As Integer = 0
    Dim acum, restante2 As Integer
    Dim restante As Integer
    Dim cantidad_1 As Integer
    Dim cantidad_2 As Integer


    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Lblhorasistema.Text = "Hora Sistema: " + Date.Now.ToLongTimeString
    End Sub

    Private Sub Btnseleccionar_Click(sender As System.Object, e As System.EventArgs) Handles Btnseleccionar.Click
        Dim Cero As Object = ChklDistribucion.GetItemChecked(0)
        Dim Uno As Object = ChklDistribucion.GetItemChecked(1)
        Dim Dos As Object = ChklDistribucion.GetItemChecked(2)
        Dim Tres As Object = ChklDistribucion.GetItemChecked(3)

        CboDepartamento.Items.Clear()
        If ChklDistribucion.CheckedItems.Count < 2 Then
            MessageBox.Show(" Seleccione Almenos Dos Departamentos", "Mensaje del Usuario")
        Else
            If Cero = True Then
                CboDepartamento.Items.Add(ChklDistribucion.Items(0))
            End If

            If Uno = True Then
                CboDepartamento.Items.Add(ChklDistribucion.Items(1))
            End If

            If Dos = True Then
                CboDepartamento.Items.Add(ChklDistribucion.Items(2))
            End If

            If Tres = True Then
                CboDepartamento.Items.Add(ChklDistribucion.Items(3))
            End If

        End If
    End Sub

    Private Sub Btnasignar_Click(sender As System.Object, e As System.EventArgs) Handles Btnasignar.Click
   
        If TxtCantidad1.Text = "" Then
            MessageBox.Show(" Introduzca Cantidad", "Mensaje")
        End If


        Select Case CboDepartamento.SelectedItem
            Case "Administracion"
                adm = 0

            Case "Contabilidad"
                cont = 0

            Case "Produccion"
                prod = 0

            Case "Ventas"
                venta = 0
        End Select

        Lsmostrar.Items.Clear()
        Select Case CboDepartamento.SelectedItem

            Case "Administracion"
                adm = Val(TxtCantidad1.Text)

            Case "Contabilidad"
                cont = Val(TxtCantidad1.Text)

            Case "Produccion"
                prod = Val(TxtCantidad1.Text)

            Case "Ventas"
                venta = Val(TxtCantidad1.Text)
        End Select

        acum = adm + cont + prod + venta
        cantidad_1 = Txtcantidad.Text
        restante2 = cantidad_1 - acum
        LblRestante.Text = restante2.ToString

        
    End Sub

    Private Sub Btnmostrar_Click(sender As System.Object, e As System.EventArgs) Handles Btnmostrar.Click
        Dim n As Integer

        Lsmostrar.Items.Clear()

        Lsmostrar.Items.Add("Administracion = " & adm)
        Lsmostrar.Items.Add("Contabilidad  = " & cont)
        Lsmostrar.Items.Add("Produccion = " & prod)
        Lsmostrar.Items.Add("Ventas = " & venta)

        Label10.Text = "No fueron Asignados: " & restante2 & " Productos"

        LblldyProducto.Text = Txtdescripcion.Text



    End Sub

    Private Sub Btnsalir_Click(sender As System.Object, e As System.EventArgs) Handles Btnsalir.Click
        MessageBox.Show(" Gracias Por Usar nuestra Logistica de parte del SR: Jansel Sanchez")
        End
    End Sub
End Class
