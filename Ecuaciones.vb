Public Class frmEcuaciones
    Private Sub frmEcuaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'al cargar el formulario marca la opción de ecuación de primer grado
        rbPrimerGrado.Checked = True
        txtB.Focus()
    End Sub
    'radiobuttons
    Private Sub rbPrimerGrado_CheckedChanged(sender As Object, e As EventArgs) Handles rbPrimerGrado.CheckedChanged
        CheckRadioButton()
    End Sub

    Private Sub rbSegundoGrado_CheckedChanged(sender As Object, e As EventArgs) Handles rbSegundoGrado.CheckedChanged
        CheckRadioButton()
    End Sub

    'click en el botón calcular
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        CalcularEcuaciones()
    End Sub

    'al hacer click en el botón salir se cierra el formualrio
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Application.Exit()
    End Sub


#Region "procedimientos"

    Private Sub CalcularEcuaciones()
        'variables
        Dim A As Single
        Dim B As Single
        Dim C As Single
        'si el valor introducido contiene "." como separador decimal muestra un mensaje
        If txtA.Text.Contains(".") Or txtB.Text.Contains(".") Or txtC.Text.Contains(".") Then
            lblResultado.Text = "El separador decimal debe ser la 'coma', no el 'punto'"
        Else
            Try
                If rbPrimerGrado.Checked Then
                    'comprobar que los coeficientes introducidos están en el formato correcto
                    A = Single.Parse(txtB.Text)
                    B = Single.Parse(txtC.Text)
                    'procedimiento que calcula la ecuación de primer grado
                    PrimerGrado(A, B)
                Else
                    'comprobar que los coeficientes introducidos están en el formato correcto
                    A = Single.Parse(txtA.Text)
                    B = Single.Parse(txtB.Text)
                    C = Single.Parse(txtC.Text)
                    'si el parámetro A de la ecuación de segundo grado es cero, 
                    'resuleve la ecuación como si fuese de primer grado
                    If A = 0 Then
                        PrimerGrado(B, C)
                    Else
                        SegundoGrado(A, B, C)
                    End If
                End If
            Catch ex As Exception
                lblResultado.Text = "Los argumentos nos son válidos."
                'vaciar los cuadros de texto
                txtA.Clear()
                txtB.Clear()
                txtC.Clear()
            End Try
        End If
    End Sub

    'ecuaciones de primer grado
    Sub PrimerGrado(a As Single, b As Single)
        'variable
        Dim incog As Single
        'si el coeficiente A es distinto de cero calcula la ecuación de primer grado
        If a <> 0 Then
            incog = -b / a
            'si el resultado es -0 muestra 0
            If incog = -0 Then
                lblResultado.Text = "La solución de la ecuación es: " & vbCrLf & vbCrLf & "x = " & Math.Round(-incog, 4)
            Else
                lblResultado.Text = "La solución de la ecuación es: " & vbCrLf & vbCrLf & "x = " & Math.Round(incog, 4)
            End If

        Else
            lblResultado.Text = "El parámetro A no puede ser 0."
        End If
    End Sub

    'ecuaciones de segundo grado
    Sub SegundoGrado(a As Single, b As Single, c As Single)
        'variables
        Dim incog1 As Single
        Dim incog2 As Single
        Dim raiz As Single
        'raiz, operación que está dentro de la raíz cuadrada
        raiz = b ^ 2 - (4 * a * c)

        If raiz > 0 Then
            ' es la raiz de un número positivo y mayor que cero
            'calcular los dos resultados posibles
            incog1 = (-b + Math.Sqrt(raiz)) / 2 * a
            incog2 = (-b - Math.Sqrt(raiz)) / 2 * a

            lblResultado.Text = "La solución de la ecuación es:" & vbCrLf & vbCrLf &
            "x1 = " & Math.Round(incog1, 4) & vbCrLf &
            "x2 = " & Math.Round(incog2, 4)

        ElseIf raiz = 0 Then
            'si es la raiz de cero el resultado es único
            incog1 = -b / 2 * a

            lblResultado.Text = "La solución de la ecuación es :" & vbCrLf & vbCrLf &
            "x = " & Math.Round(incog1, 4)
        Else
            lblResultado.Text = "La ecuación no tiene soluciones reales."
        End If

    End Sub

    'procedimiento para adaptar el formulario a ambos tipos de ecuaciones
    Sub CheckRadioButton()
        'variable
        Dim posicion As Point

        If rbPrimerGrado.Checked Then
            'focus en el cuadro de texto del primer coeficiente
            txtB.Focus()

            'coordenadas del panel - ecuación de primer grado
            posicion.X = 23
            posicion.Y = 229
            PanelEcPrimGrado.Location = posicion

            'cambiar el encabezado del formulario para ecuación de primer grado
            lblTitulo.Text = "Método para resolver la incógnita de una ecuación de primer grado."
            lblsubtitulo.Text = "Introduce los coeficientes 'A' y 'B'  : "
            lblFormula.Text = "Ax + B = 0"

            'ocultar las partes que sólo son para las ecuaciones de segundo grado
            txtA.Hide()
            lblX2.Hide()

            'limpiar resultado
            txtA.Clear()
            txtB.Clear()
            txtC.Clear()
            lblResultado.Text = ""
        Else
            'focus en el cuadro de texto del primer coeficiente
            txtA.Focus()

            'coordenadas del panel - ecuación de primer grado
            posicion.X = 230
            posicion.Y = 229
            PanelEcPrimGrado.Location = posicion

            'cambiar el encabezado del formulario para ecuación de segundo grado
            lblTitulo.Text = "Método para resolver las incógnitas de una ecuación de segundo grado."
            lblsubtitulo.Text = "Introduce los coeficientes 'A', 'B' y 'C' : "
            lblFormula.Text = "Ax^2 + Bx + C = 0"

            'mostrar las partes que sólo son para las ecuaciones de segundo grado
            txtA.Show()
            lblX2.Show()

            'limpiar resultado y cuadros de texto
            txtA.Clear()
            txtB.Clear()
            txtC.Clear()
            lblResultado.Text = ""
        End If
    End Sub
#End Region


End Class
