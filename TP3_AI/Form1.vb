Public Class Form1

    Dim A(,) As Integer
    Dim Vector(,) As Integer
    Dim VectorT(,) As Integer
    Dim Ejemplo(,) As Integer
    Dim EjemploVect(,) As Integer
    Dim MPesosFinal(,) As Integer
    Dim valX As Integer
    Dim valY As Integer
    Dim valXE As Integer
    Dim valYE As Integer
    Dim paso As Integer
    Dim patron As Integer


    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim contador As Integer
        ReDim MPesosFinal(99, 99)

        DataGridView1.RowCount = 10
        DataGridView1.ColumnCount = 10
        DataGridView1.RowHeadersVisible = False
        DataGridView1.ColumnHeadersVisible = False
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells

        DataGridView3.RowCount = 10
        DataGridView3.ColumnCount = 10
        DataGridView3.RowHeadersVisible = False
        DataGridView3.ColumnHeadersVisible = False
        DataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells

        Dim width = DataGridView1.Columns.GetColumnsWidth(DataGridViewElementStates.None)
        Dim height = DataGridView1.Rows.GetRowsHeight(DataGridViewElementStates.None)

        DataGridView1.ClientSize = New Size(width, height)
        DataGridView3.ClientSize = New Size(width, height)

        Dim i, j As Integer

        ReDim A(9, 9)
        ReDim Ejemplo(9, 9) 'Matriz de ejemplo a detectar
        ReDim Vector(0, 99) 'Vector patron
        ReDim VectorT(99, 0) 'Vector Traspuesto 
        ReDim EjemploVect(99, 0) 'Ejemplo pasado a Vector 

        paso = 0
        contador = 0

        'limpio las matrices
        For i = 0 To 9
            For j = 0 To 9
                A(i, j) = -1
                MPesosFinal(i, j) = 0
            Next j
        Next i

        valX = 0
        valY = 0
        'Dibugo el aro
        A(5, 2) = 1
        A(6, 2) = 1

        A(4, 3) = 1
        A(5, 3) = 1
        A(6, 3) = 1
        A(7, 3) = 1

        A(3, 4) = 1
        A(4, 4) = 1
        A(7, 4) = 1
        A(8, 4) = 1
        A(3, 5) = 1
        A(4, 5) = 1
        A(7, 5) = 1
        A(8, 5) = 1

        A(4, 6) = 1
        A(5, 6) = 1
        A(6, 6) = 1
        A(7, 6) = 1

        A(6, 7) = 1
        A(5, 7) = 1

        For i = 0 To 9
            For j = 0 To 9
                Ejemplo(i, j) = A(i, j)
                DataGridView1.Item(i, j).Value = IIf(A(i, j) = 1, "X", "")
                DataGridView3.Item(i, j).Value = IIf(Ejemplo(i, j) = 1, "X", "")
                Vector(0, contador) = A(i, j)
                VectorT(contador, 0) = A(i, j)
                EjemploVect(contador, 0) = A(i, j)
                contador = contador + 1
            Next j
        Next i

    End Sub
    Private Function Entrena(ByVal A As Integer(,))
        Dim M(9, 9) As Integer 'A * traspuesta
        Dim P(9, 9) As Integer 'Matriz de Pesos del patron

        M = MultiplicaMatrices(Vector, VectorT)

        P = RestaMatrisIdentidad(M)

        'Sumarizo pesos (se genera la matriz de pesos final)
        MPesosFinal = SumaMatrices(P, MPesosFinal)

        Me.Refresh()

        patron += 1
        lblPatron.Text = patron

    End Function

    Private Function MultiplicaMatrices(ByVal V As Integer(,), ByVal VT As Integer(,)) As Integer(,)
        Dim i, j As Integer
        Dim M(,) As Integer

        ReDim M(99, 99)

        For i = 0 To 99
            For j = 0 To 99
                M(j, i) = V(0, i) * VT(j, 0)
            Next
        Next

        Return M
    End Function
    Private Function MultiplicaVectorMatriz(ByVal Vej As Integer(,), ByVal Mpesos As Integer(,)) As Integer(,)
        Dim i, j As Integer
        Dim M(,) As Integer

        ReDim M(99, 0)

        For i = 0 To 99
            For j = 0 To 99
                M(i, 0) += Vej(j, 0) * Mpesos(i, j)
            Next
        Next

        Return M
    End Function

    Private Function RestaMatrisIdentidad(ByVal A As Integer(,)) As Integer(,)
        Dim i, j As Integer

        For i = 0 To 99
            For j = 0 To 99
                If j = i Then
                    A(i, j) = 0
                End If
            Next
        Next

        Return A
    End Function

    Private Function SumaMatrices(ByVal A As Integer(,), ByVal B As Integer(,)) As Integer(,)

        Dim i, j As Integer
        Dim S(99, 99) As Integer

        For i = 0 To 99
            For j = 0 To 99
                S(i, j) = A(i, j) + B(i, j)
            Next
        Next

        Return S
    End Function

    Private Sub btnEntrenar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEntrenar.Click
        Call Entrena(A)
    End Sub

    Private Sub ProcesarEjemplo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEjecutar.Click
        Dim EjemploVectAnt As Integer(,)
        Dim cont, minx, maxx, miny, maxy As Integer
        Dim centrox, centroy As Integer
        Dim MFinal As Integer(,)
        cont = 0

        DataGridView3.Enabled = False
        btnSubeEjemplo.Enabled = False
        btnBajaEjemplo.Enabled = False
        btnDerEjemplo.Enabled = False
        bntIzqEjemplo.Enabled = False

        Me.Refresh()
        paso += 1
        lblPaso.Text = paso

        EjemploVectAnt = EjemploVect

        EjemploVect = MultiplicaVectorMatriz(EjemploVect, MPesosFinal)

        ReDim MFinal(9, 9)

        For i = 0 To 9
            For j = 0 To 9

                DataGridView3.Item(i, j).Value = IIf(EjemploVect(cont, 0) >= 1, "X", "") 'EjemploVect(cont, 0) 
                MFinal(i, j) = IIf(EjemploVect(cont, 0) >= 1, 1, -1)
                cont += 1
            Next j
        Next i

        For i = 0 To 99

            If EjemploVect(i, 0) >= 1 Then
                EjemploVect(i, 0) = 1
            Else
                EjemploVect(i, 0) = -1
            End If

        Next i


        If VerificaConvergencia(EjemploVect, EjemploVectAnt) Then
            lblFin.Text = "MEJOR RESULTADO OBTENIDO (CONVERGENCIA)!!"
            'busco el centro
            minx = 99
            maxx = 0
            miny = 99
            maxy = 0

            For i = 0 To 9 'fila
                For j = 0 To 9 'col
                    If MFinal(j, i) = 1 Then
                        If j < minx Then
                            minx = j
                        End If
                        If j > maxx Then
                            maxx = j
                        End If

                        If i < miny Then
                            miny = i
                        End If
                        If i > maxy Then
                            maxy = i
                        End If

                    End If
                Next j
            Next i

            'coloreo centro
            centrox = minx + Int((maxx - minx) / 2)
            centroy = miny + Int((maxy - miny) / 2)

            DataGridView3.Item(centrox, centroy).Style.BackColor = Color.Coral
            DataGridView3.Item(centrox, centroy + 1).Style.BackColor = Color.Coral
            DataGridView3.Item(centrox + 1, centroy).Style.BackColor = Color.Coral
            DataGridView3.Item(centrox + 1, centroy + 1).Style.BackColor = Color.Coral


        End If

    End Sub
    Private Function VerificaConvergencia(ByVal Anterior As Integer(,), ByVal Actual As Integer(,)) As Boolean
        Dim bHayDatos As Boolean
        VerificaConvergencia = False

        For i = 0 To 99

            If (Anterior(i, 0) <> -1 Or Actual(i, 0) <> -1) Then
                bHayDatos = True
            End If

            If (Anterior(i, 0) <> Actual(i, 0)) Then
                Exit Function
            End If

        Next
        If bHayDatos Then
            VerificaConvergencia = True
        End If
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSube.Click
        Dim cant As Integer
        cant = 0

        If valY < -1 Then Exit Sub

        'limpio la matriz
        For i = 0 To 9
            For j = 0 To 9
                A(i, j) = -1
                Vector(0, cant) = -1
                VectorT(cant, 0) = -1
                cant += 1
            Next j
        Next i

        valY -= 1

        A(5 + valX, 2 + valY) = 1
        A(6 + valX, 2 + valY) = 1

        A(4 + valX, 3 + valY) = 1
        A(5 + valX, 3 + valY) = 1
        A(6 + valX, 3 + valY) = 1
        A(7 + valX, 3 + valY) = 1

        A(3 + valX, 4 + valY) = 1
        A(4 + valX, 4 + valY) = 1
        A(7 + valX, 4 + valY) = 1
        A(8 + valX, 4 + valY) = 1
        A(3 + valX, 5 + valY) = 1
        A(4 + valX, 5 + valY) = 1
        A(7 + valX, 5 + valY) = 1
        A(8 + valX, 5 + valY) = 1

        A(4 + valX, 6 + valY) = 1
        A(5 + valX, 6 + valY) = 1
        A(6 + valX, 6 + valY) = 1
        A(7 + valX, 6 + valY) = 1

        A(6 + valX, 7 + valY) = 1
        A(5 + valX, 7 + valY) = 1

        cant = 0
        For i = 0 To 9
            For j = 0 To 9
                DataGridView1.Item(i, j).Value = IIf(A(i, j) = 1, "X", "")
                Vector(0, cant) = A(i, j)
                VectorT(cant, 0) = A(i, j)
                cant += 1
            Next j
        Next i


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIzq.Click
        Dim cant As Integer
        cant = 0

        If valX < -2 Then Exit Sub

        'limpio la matriz
        For i = 0 To 9
            For j = 0 To 9
                A(i, j) = -1
                Vector(0, cant) = -1
                VectorT(cant, 0) = -1
                cant += 1
            Next j
        Next i
        valX -= 1

        A(5 + valX, 2 + valY) = 1
        A(6 + valX, 2 + valY) = 1

        A(4 + valX, 3 + valY) = 1
        A(5 + valX, 3 + valY) = 1
        A(6 + valX, 3 + valY) = 1
        A(7 + valX, 3 + valY) = 1

        A(3 + valX, 4 + valY) = 1
        A(4 + valX, 4 + valY) = 1
        A(7 + valX, 4 + valY) = 1
        A(8 + valX, 4 + valY) = 1
        A(3 + valX, 5 + valY) = 1
        A(4 + valX, 5 + valY) = 1
        A(7 + valX, 5 + valY) = 1
        A(8 + valX, 5 + valY) = 1

        A(4 + valX, 6 + valY) = 1
        A(5 + valX, 6 + valY) = 1
        A(6 + valX, 6 + valY) = 1
        A(7 + valX, 6 + valY) = 1

        A(6 + valX, 7 + valY) = 1
        A(5 + valX, 7 + valY) = 1

        cant = 0
        For i = 0 To 9
            For j = 0 To 9
                DataGridView1.Item(i, j).Value = IIf(A(i, j) = 1, "X", "")
                Vector(0, cant) = A(i, j)
                VectorT(cant, 0) = A(i, j)
                cant += 1
            Next j
        Next i
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDer.Click
        Dim cant As Integer
        cant = 0

        If valX > 0 Then Exit Sub
        'limpio la matriz
        For i = 0 To 9
            For j = 0 To 9
                A(i, j) = -1
                Vector(0, cant) = -1
                VectorT(cant, 0) = -1
                cant += 1
            Next j
        Next i

        valX += 1

        A(5 + valX, 2 + valY) = 1
        A(6 + valX, 2 + valY) = 1

        A(4 + valX, 3 + valY) = 1
        A(5 + valX, 3 + valY) = 1
        A(6 + valX, 3 + valY) = 1
        A(7 + valX, 3 + valY) = 1

        A(3 + valX, 4 + valY) = 1
        A(4 + valX, 4 + valY) = 1
        A(7 + valX, 4 + valY) = 1
        A(8 + valX, 4 + valY) = 1
        A(3 + valX, 5 + valY) = 1
        A(4 + valX, 5 + valY) = 1
        A(7 + valX, 5 + valY) = 1
        A(8 + valX, 5 + valY) = 1

        A(4 + valX, 6 + valY) = 1
        A(5 + valX, 6 + valY) = 1
        A(6 + valX, 6 + valY) = 1
        A(7 + valX, 6 + valY) = 1

        A(6 + valX, 7 + valY) = 1
        A(5 + valX, 7 + valY) = 1

        cant = 0
        For i = 0 To 9
            For j = 0 To 9
                DataGridView1.Item(i, j).Value = IIf(A(i, j) = 1, "X", "")
                Vector(0, cant) = A(i, j)
                VectorT(cant, 0) = A(i, j)
                cant += 1
            Next j
        Next i
    End Sub

    Private Sub btnBaja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBaja.Click
        Dim cant As Integer
        cant = 0

        If valY > 1 Then Exit Sub

        'limpio la matriz
        For i = 0 To 9
            For j = 0 To 9
                A(i, j) = -1
                Vector(0, cant) = -1
                VectorT(cant, 0) = -1
                cant += 1
            Next j
        Next i

        valY += 1

        A(5 + valX, 2 + valY) = 1
        A(6 + valX, 2 + valY) = 1

        A(4 + valX, 3 + valY) = 1
        A(5 + valX, 3 + valY) = 1
        A(6 + valX, 3 + valY) = 1
        A(7 + valX, 3 + valY) = 1

        A(3 + valX, 4 + valY) = 1
        A(4 + valX, 4 + valY) = 1
        A(7 + valX, 4 + valY) = 1
        A(8 + valX, 4 + valY) = 1
        A(3 + valX, 5 + valY) = 1
        A(4 + valX, 5 + valY) = 1
        A(7 + valX, 5 + valY) = 1
        A(8 + valX, 5 + valY) = 1

        A(4 + valX, 6 + valY) = 1
        A(5 + valX, 6 + valY) = 1
        A(6 + valX, 6 + valY) = 1
        A(7 + valX, 6 + valY) = 1

        A(6 + valX, 7 + valY) = 1
        A(5 + valX, 7 + valY) = 1

        cant = 0
        For i = 0 To 9
            For j = 0 To 9
                DataGridView1.Item(i, j).Value = IIf(A(i, j) = 1, "X", "")
                Vector(0, cant) = A(i, j)
                VectorT(cant, 0) = A(i, j)
                cant += 1
            Next j
        Next i
    End Sub


    Private Sub DataGridView3_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView3.CellContentClick

        If DataGridView3.CurrentCell.Value = "X" Then
            DataGridView3.CurrentCell.Value = ""
        Else
            DataGridView3.CurrentCell.Value = "X"
        End If

    End Sub

    Private Sub btnSubeEjemplo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubeEjemplo.Click
        Dim cant As Integer
        cant = 0

        If valYE < -1 Then Exit Sub

        'limpio la matriz
        For i = 0 To 9
            For j = 0 To 9
                Ejemplo(i, j) = -1
                EjemploVect(cant, 0) = -1
                cant += 1
            Next j
        Next i

        valYE -= 1

        Ejemplo(5 + valXE, 2 + valYE) = 1
        Ejemplo(6 + valXE, 2 + valYE) = 1

        Ejemplo(4 + valXE, 3 + valYE) = 1
        Ejemplo(5 + valXE, 3 + valYE) = 1
        Ejemplo(6 + valXE, 3 + valYE) = 1
        Ejemplo(7 + valXE, 3 + valYE) = 1

        Ejemplo(3 + valXE, 4 + valYE) = 1
        Ejemplo(4 + valXE, 4 + valYE) = 1
        Ejemplo(7 + valXE, 4 + valYE) = 1
        Ejemplo(8 + valXE, 4 + valYE) = 1
        Ejemplo(3 + valXE, 5 + valYE) = 1
        Ejemplo(4 + valXE, 5 + valYE) = 1
        Ejemplo(7 + valXE, 5 + valYE) = 1
        Ejemplo(8 + valXE, 5 + valYE) = 1

        Ejemplo(4 + valXE, 6 + valYE) = 1
        Ejemplo(5 + valXE, 6 + valYE) = 1
        Ejemplo(6 + valXE, 6 + valYE) = 1
        Ejemplo(7 + valXE, 6 + valYE) = 1

        Ejemplo(6 + valXE, 7 + valYE) = 1
        Ejemplo(5 + valXE, 7 + valYE) = 1

        cant = 0
        For i = 0 To 9
            For j = 0 To 9
                DataGridView3.Item(i, j).Value = IIf(Ejemplo(i, j) = 1, "X", "")
                EjemploVect(cant, 0) = Ejemplo(i, j)
                cant += 1
            Next j
        Next i

    End Sub

    Private Sub btnBajaEjemplo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBajaEjemplo.Click
        Dim cant As Integer
        cant = 0

        If valYE > 1 Then Exit Sub

        'limpio la matriz
        For i = 0 To 9
            For j = 0 To 9
                Ejemplo(i, j) = -1
                EjemploVect(cant, 0) = -1
                cant += 1
            Next j
        Next i

        valYE += 1

        Ejemplo(5 + valXE, 2 + valYE) = 1
        Ejemplo(6 + valXE, 2 + valYE) = 1

        Ejemplo(4 + valXE, 3 + valYE) = 1
        Ejemplo(5 + valXE, 3 + valYE) = 1
        Ejemplo(6 + valXE, 3 + valYE) = 1
        Ejemplo(7 + valXE, 3 + valYE) = 1

        Ejemplo(3 + valXE, 4 + valYE) = 1
        Ejemplo(4 + valXE, 4 + valYE) = 1
        Ejemplo(7 + valXE, 4 + valYE) = 1
        Ejemplo(8 + valXE, 4 + valYE) = 1
        Ejemplo(3 + valXE, 5 + valYE) = 1
        Ejemplo(4 + valXE, 5 + valYE) = 1
        Ejemplo(7 + valXE, 5 + valYE) = 1
        Ejemplo(8 + valXE, 5 + valYE) = 1

        Ejemplo(4 + valXE, 6 + valYE) = 1
        Ejemplo(5 + valXE, 6 + valYE) = 1
        Ejemplo(6 + valXE, 6 + valYE) = 1
        Ejemplo(7 + valXE, 6 + valYE) = 1

        Ejemplo(6 + valXE, 7 + valYE) = 1
        Ejemplo(5 + valXE, 7 + valYE) = 1

        cant = 0
        For i = 0 To 9
            For j = 0 To 9
                DataGridView3.Item(i, j).Value = IIf(Ejemplo(i, j) = 1, "X", "")
                EjemploVect(cant, 0) = Ejemplo(i, j)

                cant += 1
            Next j
        Next i
    End Sub

    Private Sub btnDerEjemplo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDerEjemplo.Click
        Dim cant As Integer
        cant = 0

        If valXE > 0 Then Exit Sub

        'limpio la matriz
        For i = 0 To 9
            For j = 0 To 9
                Ejemplo(i, j) = -1
                EjemploVect(cant, 0) = -1
                cant += 1
            Next j
        Next i

        valXE += 1

        Ejemplo(5 + valXE, 2 + valYE) = 1
        Ejemplo(6 + valXE, 2 + valYE) = 1

        Ejemplo(4 + valXE, 3 + valYE) = 1
        Ejemplo(5 + valXE, 3 + valYE) = 1
        Ejemplo(6 + valXE, 3 + valYE) = 1
        Ejemplo(7 + valXE, 3 + valYE) = 1

        Ejemplo(3 + valXE, 4 + valYE) = 1
        Ejemplo(4 + valXE, 4 + valYE) = 1
        Ejemplo(7 + valXE, 4 + valYE) = 1
        Ejemplo(8 + valXE, 4 + valYE) = 1
        Ejemplo(3 + valXE, 5 + valYE) = 1
        Ejemplo(4 + valXE, 5 + valYE) = 1
        Ejemplo(7 + valXE, 5 + valYE) = 1
        Ejemplo(8 + valXE, 5 + valYE) = 1

        Ejemplo(4 + valXE, 6 + valYE) = 1
        Ejemplo(5 + valXE, 6 + valYE) = 1
        Ejemplo(6 + valXE, 6 + valYE) = 1
        Ejemplo(7 + valXE, 6 + valYE) = 1

        Ejemplo(6 + valXE, 7 + valYE) = 1
        Ejemplo(5 + valXE, 7 + valYE) = 1

        cant = 0
        For i = 0 To 9
            For j = 0 To 9
                DataGridView3.Item(i, j).Value = IIf(Ejemplo(i, j) = 1, "X", "")
                EjemploVect(cant, 0) = Ejemplo(i, j)
                cant += 1
            Next j
        Next i

    End Sub

    Private Sub bntIzqEjemplo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bntIzqEjemplo.Click
        Dim cant As Integer
        cant = 0

        If valXE < -2 Then Exit Sub
        valXE -= 1

        'limpio la matriz
        For i = 0 To 9
            For j = 0 To 9
                Ejemplo(i, j) = -1
                EjemploVect(cant, 0) = -1
                cant += 1
            Next j
        Next i

        Ejemplo(5 + valXE, 2 + valYE) = 1
        Ejemplo(6 + valXE, 2 + valYE) = 1

        Ejemplo(4 + valXE, 3 + valYE) = 1
        Ejemplo(5 + valXE, 3 + valYE) = 1
        Ejemplo(6 + valXE, 3 + valYE) = 1
        Ejemplo(7 + valXE, 3 + valYE) = 1

        Ejemplo(3 + valXE, 4 + valYE) = 1
        Ejemplo(4 + valXE, 4 + valYE) = 1
        Ejemplo(7 + valXE, 4 + valYE) = 1
        Ejemplo(8 + valXE, 4 + valYE) = 1
        Ejemplo(3 + valXE, 5 + valYE) = 1
        Ejemplo(4 + valXE, 5 + valYE) = 1
        Ejemplo(7 + valXE, 5 + valYE) = 1
        Ejemplo(8 + valXE, 5 + valYE) = 1

        Ejemplo(4 + valXE, 6 + valYE) = 1
        Ejemplo(5 + valXE, 6 + valYE) = 1
        Ejemplo(6 + valXE, 6 + valYE) = 1
        Ejemplo(7 + valXE, 6 + valYE) = 1

        Ejemplo(6 + valXE, 7 + valYE) = 1
        Ejemplo(5 + valXE, 7 + valYE) = 1

        cant = 0
        For i = 0 To 9
            For j = 0 To 9
                DataGridView3.Item(i, j).Value = IIf(Ejemplo(i, j) = 1, "X", "")
                EjemploVect(cant, 0) = Ejemplo(i, j)
                cant += 1
            Next j
        Next i

    End Sub

    Private Sub DataGridView3_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView3.CellMouseClick
        Dim cant As Integer

        If DataGridView3.CurrentCell.Value = "X" Then
            DataGridView3.CurrentCell.Value = ""
        Else
            DataGridView3.CurrentCell.Value = "X"
        End If

        'limpio
        For i = 0 To 99
            EjemploVect(i, 0) = -1
        Next i

        For i = 0 To 9
            For j = 0 To 9
                If DataGridView3.Item(i, j).Value = "X" Then
                    Ejemplo(i, j) = 1
                Else
                    Ejemplo(i, j) = -1
                End If
            Next j
        Next i

        cant = 0

        For i = 0 To 9
            For j = 0 To 9
                EjemploVect(cant, 0) = Ejemplo(j, i)
                cant += 1
            Next j
        Next i

    End Sub

    Private Sub btnNuevoEjemplo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoEjemplo.Click
        Dim cant As Integer
        lblFin.Text = ""

        valYE = 0
        valXE = 0
        paso = 0
        lblPaso.Text = 0
        DataGridView3.Enabled = True
        btnSubeEjemplo.Enabled = True
        btnBajaEjemplo.Enabled = True
        btnDerEjemplo.Enabled = True
        bntIzqEjemplo.Enabled = True


        For i = 0 To 9
            For j = 0 To 9
                Ejemplo(i, j) = -1
                DataGridView3.Item(j, i).Style.BackColor = Color.White
            Next j
        Next i

        'Dibugo el aro
        Ejemplo(5, 2) = 1
        Ejemplo(6, 2) = 1

        Ejemplo(4, 3) = 1
        Ejemplo(5, 3) = 1
        Ejemplo(6, 3) = 1
        Ejemplo(7, 3) = 1

        Ejemplo(3, 4) = 1
        Ejemplo(4, 4) = 1
        Ejemplo(7, 4) = 1
        Ejemplo(8, 4) = 1
        Ejemplo(3, 5) = 1
        Ejemplo(4, 5) = 1
        Ejemplo(7, 5) = 1
        Ejemplo(8, 5) = 1

        Ejemplo(4, 6) = 1
        Ejemplo(5, 6) = 1
        Ejemplo(6, 6) = 1
        Ejemplo(7, 6) = 1

        Ejemplo(6, 7) = 1
        Ejemplo(5, 7) = 1

        cant = 0
        For i = 0 To 9
            For j = 0 To 9
                DataGridView3.Item(i, j).Value = IIf(Ejemplo(i, j) = 1, "X", "")
                EjemploVect(cant, 0) = Ejemplo(i, j)
                cant += 1
            Next j
        Next i

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub
End Class
