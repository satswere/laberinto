Public Class Form1
    Dim columna, fila As Byte
    Dim cantidad_columnas, cantidad_filas As Integer
    Dim valor As Integer
    Dim opcion_moviemiento As Integer

    Private Sub DgvMatriz_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DgvMatriz.CellFormatting
        'codigo para condicionar el color de las celdas de la tabla

        If (Convert.ToInt32(e.Value) = 0) Then
            e.CellStyle.ForeColor = Color.Black
            e.CellStyle.BackColor = Color.Black
        End If

        If (Convert.ToInt32(e.Value) = 1) Then
            e.CellStyle.ForeColor = Color.White
            e.CellStyle.BackColor = Color.White
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Creacion de la tabla 
        columna = 11
        fila = 11

        cantidad_columnas = columna 'total creado
        cantidad_filas = fila

        DgvMatriz.ColumnCount = columna
        DgvMatriz.RowCount = fila
        'establece tamaño de celdas

        'iniciacion de la matriz
        For x = 0 To columna - 1
            DgvMatriz.Columns(x).HeaderText = x + 1
            'establece tamaño de celdas x2
            DgvMatriz.Columns(x).Width = 40
        Next

        'llenado de la matriz
        For x = 0 To columna - 1
            For y = 0 To fila - 1
                DgvMatriz.Rows(y).Cells(x).Value = 0
            Next
        Next
        'esto hace que se cambie el valor de las columnas
        ' DgvMatriz.Rows(yy).Cells(xx - 2).Value = 1

        'Pausa de un segundo y llamada del laberinto
        delay(1)
        campo_inicial()
        '  laberinto()


    End Sub
    Private Sub campo_inicial()

        Randomize() 'iniciar la semilla

        Dim columna As Integer = CInt(Int((11 * Rnd())))
        Dim fila As Integer = CInt(Int((11 * Rnd())))
        Dim contador As Integer
        contador = 0

        Dim Res = columna Mod 2
        Dim Res2 = fila Mod 2
        Dim valor
        If Res <> 0 And Res2 <> 0 Then
            DgvMatriz.Rows(columna).Cells(fila).Value = 1

            valor = DgvMatriz.Rows(columna).Cells(fila).Value.ToString()
            movimiento(contador, columna, fila)
            ' pregunta(valor As Integer, xx As Integer, yy As Integer)
        Else
            campo_inicial()
        End If
    End Sub

    Private Sub movimiento(cont As Integer, columna_recibda As Integer, fila_recibida As Integer)
        delay(1)

        columna = columna_recibda
        fila = fila_recibida 'la variable global de columna que es la actual en uso

        '   If (cont = 4) Then
        ' cont = 0
        ' movimiento(cont, columna, fila)
        'Else

        ' End If
        Randomize()

        Dim nueva_columna As Integer
        Dim nueva_fila As Integer

        opcion_moviemiento = CInt(Int((4 * Rnd())))

        Select Case opcion_moviemiento
            Case 0 'arriba'
                nueva_columna = (columna_recibda - 2)
                nueva_fila = (fila_recibida)
                comprobar_limite_del_array(nueva_columna, nueva_fila)

            Case 1 'abajo'
                nueva_columna = (columna_recibda + 2)
                nueva_fila = (fila_recibida)
                comprobar_limite_del_array(nueva_columna, nueva_fila)


            Case 2 'izquierda'
                nueva_columna = (columna_recibda)
                nueva_fila = (fila_recibida - 2)
                comprobar_limite_del_array(nueva_columna, nueva_fila)


            Case 3 'derecha'
                nueva_columna = (columna_recibda)
                nueva_fila = (fila_recibida + 2)
                comprobar_limite_del_array(nueva_columna, nueva_fila)


        End Select



    End Sub

    Private Sub comprobar_limite_del_array(posible_columna As Integer, posible_fila As Integer)
        Dim cont As Integer = 0

        If ((posible_columna < cantidad_columnas) And (posible_columna >= 0)) And ((posible_fila < cantidad_filas) And (posible_fila >= 0)) Then
            comprobar_si_es_muro(cont, posible_columna, posible_fila)
        Else
            movimiento(cont, columna, fila)
        End If
    End Sub
    Private Sub comprobar_si_es_muro(valor As Integer, columna_moviemiento As Integer, fila_movimiento As Integer)
        Dim cont As Integer
        Dim posible_pintado As Integer
        cont = 0
        posible_pintado = DgvMatriz.Rows(columna_moviemiento).Cells(fila_movimiento).Value.ToString()
        If (posible_pintado = 0) Then
            cont = 0

            '   columna = columna_moviemiento
            '  fila = fila_movimiento


            Select Case opcion_moviemiento
                Case 0 'arriba'
                    DgvMatriz.Rows(columna - 2).Cells(fila).Value = 1
                    DgvMatriz.Rows(columna - 1).Cells(fila).Value = 1
                    movimiento(cont, columna_moviemiento, fila_movimiento)

                Case 1 'abajo'
                    DgvMatriz.Rows(columna + 2).Cells(fila).Value = 1
                    DgvMatriz.Rows(columna + 1).Cells(fila).Value = 1
                    movimiento(cont, columna_moviemiento, fila_movimiento)

                Case 2 'izquierda'
                    DgvMatriz.Rows(columna).Cells(fila - 2).Value = 1
                    DgvMatriz.Rows(columna).Cells(fila - 1).Value = 1
                    movimiento(cont, columna_moviemiento, fila_movimiento)

                Case 3 'derecha'
                    DgvMatriz.Rows(columna).Cells(fila + 2).Value = 1
                    DgvMatriz.Rows(columna).Cells(fila + 1).Value = 1
                    movimiento(cont, columna_moviemiento, fila_movimiento)

            End Select

        Else
            cont = cont + 1
            movimiento(cont, columna, fila)
        End If
    End Sub
    Private Sub llenado_array()

    End Sub
    Private Sub rutaslaberinto()
        'Modo de empleo del random del 1 al 18
        Dim random_x As Integer = CInt(Int((19 * Rnd()) + 1))
        Dim random_y As Integer = CInt(Int((19 * Rnd()) + 1))
        For x = 1 To columna - 2
            For y = 1 To fila - 2

                If (x = random_x) Then
                    If (y = random_y) Then
                        'obtener el valor de la celda
                        valor = DgvMatriz.Rows(y).Cells(x).Value.ToString()
                        'verificamos si es posible establece muro / se crea muro
                        ' movimiento(random_x, random_y)
                    End If
                End If
            Next
        Next

    End Sub

    Private Sub pregunta(valor As Integer, xx As Integer, yy As Integer)

        Dim norte As Integer
        Dim sur As Integer
        Dim este As Integer
        Dim oeste As Integer

        If (valor = 0) Then
            ' se crea muro
            DgvMatriz.Rows(yy).Cells(xx).Value = 1
            ' se busca valores de alrededor
            oeste = DgvMatriz.Rows(yy - 2).Cells(xx).Value.ToString()
            este = DgvMatriz.Rows(yy + 2).Cells(xx).Value.ToString()
            sur = DgvMatriz.Rows(yy).Cells(xx + 2).Value.ToString()
            norte = DgvMatriz.Rows(yy).Cells(xx - 2).Value.ToString()


            'se crea muros si no hay alguno alrededor.
            If (norte = 0) Then
                DgvMatriz.Rows(yy).Cells(xx - 1).Value = 1
                DgvMatriz.Rows(yy).Cells(xx - 2).Value = 1
            End If

            If (sur = 0) Then
                DgvMatriz.Rows(yy).Cells(xx + 1).Value = 1
                DgvMatriz.Rows(yy).Cells(xx + 2).Value = 1
            End If

            If (este = 0) Then
                DgvMatriz.Rows(yy + 1).Cells(xx).Value = 1
                DgvMatriz.Rows(yy + 2).Cells(xx).Value = 1
            End If

            If (oeste = 0) Then
                DgvMatriz.Rows(yy - 1).Cells(xx).Value = 1
                DgvMatriz.Rows(yy - 2).Cells(xx).Value = 1
            End If

        End If

    End Sub

    Private Sub murosinicio()
        For x = 0 To columna - 1
            For y = 0 To 0
                DgvMatriz.Rows(y).Cells(x).Value = 1
            Next
        Next

        For x = 0 To columna - 1
            For y = 0 To 0
                DgvMatriz.Rows(x).Cells(y).Value = 1
            Next
        Next

        For x = 0 To columna - 1
            For y = 19 To 19
                DgvMatriz.Rows(x).Cells(y).Value = 1
            Next
        Next

        For x = 0 To columna - 1
            For y = 19 To 19
                DgvMatriz.Rows(y).Cells(x).Value = 1
            Next
        Next
    End Sub
    Private Sub laberinto()
        murosinicio()
        delay(1)
        rutaslaberinto()





    End Sub

End Class
