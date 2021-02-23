<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEcuaciones
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.rbPrimerGrado = New System.Windows.Forms.RadioButton()
        Me.rbSegundoGrado = New System.Windows.Forms.RadioButton()
        Me.lblTipoEcuacion = New System.Windows.Forms.Label()
        Me.PanelElegir = New System.Windows.Forms.Panel()
        Me.lblsubtitulo = New System.Windows.Forms.Label()
        Me.lblFormula = New System.Windows.Forms.Label()
        Me.txtA = New System.Windows.Forms.TextBox()
        Me.txtB = New System.Windows.Forms.TextBox()
        Me.lblX2 = New System.Windows.Forms.Label()
        Me.lblCero = New System.Windows.Forms.Label()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.lblResultado = New System.Windows.Forms.Label()
        Me.txtC = New System.Windows.Forms.TextBox()
        Me.lblX = New System.Windows.Forms.Label()
        Me.PanelEcPrimGrado = New System.Windows.Forms.Panel()
        Me.PanelElegir.SuspendLayout()
        Me.PanelEcPrimGrado.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTitulo.Location = New System.Drawing.Point(23, 32)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(641, 60)
        Me.lblTitulo.TabIndex = 88
        Me.lblTitulo.Text = "Método para resolver la incógnita de una ecuación de primer grado."
        '
        'rbPrimerGrado
        '
        Me.rbPrimerGrado.AutoSize = True
        Me.rbPrimerGrado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbPrimerGrado.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.rbPrimerGrado.Location = New System.Drawing.Point(21, 30)
        Me.rbPrimerGrado.Name = "rbPrimerGrado"
        Me.rbPrimerGrado.Size = New System.Drawing.Size(176, 29)
        Me.rbPrimerGrado.TabIndex = 89
        Me.rbPrimerGrado.Text = "Primer grado"
        Me.rbPrimerGrado.UseVisualStyleBackColor = True
        '
        'rbSegundoGrado
        '
        Me.rbSegundoGrado.AutoSize = True
        Me.rbSegundoGrado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbSegundoGrado.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.rbSegundoGrado.Location = New System.Drawing.Point(21, 66)
        Me.rbSegundoGrado.Name = "rbSegundoGrado"
        Me.rbSegundoGrado.Size = New System.Drawing.Size(204, 29)
        Me.rbSegundoGrado.TabIndex = 90
        Me.rbSegundoGrado.Text = "Segundo grado"
        Me.rbSegundoGrado.UseVisualStyleBackColor = True
        '
        'lblTipoEcuacion
        '
        Me.lblTipoEcuacion.AutoSize = True
        Me.lblTipoEcuacion.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTipoEcuacion.Location = New System.Drawing.Point(796, 20)
        Me.lblTipoEcuacion.Name = "lblTipoEcuacion"
        Me.lblTipoEcuacion.Size = New System.Drawing.Size(180, 23)
        Me.lblTipoEcuacion.TabIndex = 3
        Me.lblTipoEcuacion.Text = "Tipo de ecuación"
        '
        'PanelElegir
        '
        Me.PanelElegir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelElegir.Controls.Add(Me.rbSegundoGrado)
        Me.PanelElegir.Controls.Add(Me.rbPrimerGrado)
        Me.PanelElegir.Location = New System.Drawing.Point(786, 31)
        Me.PanelElegir.Name = "PanelElegir"
        Me.PanelElegir.Size = New System.Drawing.Size(245, 109)
        Me.PanelElegir.TabIndex = 4
        '
        'lblsubtitulo
        '
        Me.lblsubtitulo.AutoSize = True
        Me.lblsubtitulo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblsubtitulo.Location = New System.Drawing.Point(23, 118)
        Me.lblsubtitulo.Name = "lblsubtitulo"
        Me.lblsubtitulo.Size = New System.Drawing.Size(418, 28)
        Me.lblsubtitulo.TabIndex = 87
        Me.lblsubtitulo.Text = "Introduce los coeficientes 'A' y 'B' : "
        '
        'lblFormula
        '
        Me.lblFormula.AutoSize = True
        Me.lblFormula.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblFormula.Location = New System.Drawing.Point(23, 162)
        Me.lblFormula.Name = "lblFormula"
        Me.lblFormula.Size = New System.Drawing.Size(126, 28)
        Me.lblFormula.TabIndex = 86
        Me.lblFormula.Text = "Ax + B = 0"
        '
        'txtA
        '
        Me.txtA.Font = New System.Drawing.Font("Century Gothic", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtA.Location = New System.Drawing.Point(23, 239)
        Me.txtA.MaxLength = 5
        Me.txtA.Name = "txtA"
        Me.txtA.Size = New System.Drawing.Size(90, 57)
        Me.txtA.TabIndex = 0
        Me.txtA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtB
        '
        Me.txtB.Font = New System.Drawing.Font("Century Gothic", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtB.Location = New System.Drawing.Point(13, 14)
        Me.txtB.MaxLength = 5
        Me.txtB.Name = "txtB"
        Me.txtB.Size = New System.Drawing.Size(90, 57)
        Me.txtB.TabIndex = 1
        Me.txtB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblX2
        '
        Me.lblX2.AutoSize = True
        Me.lblX2.Font = New System.Drawing.Font("Century Gothic", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblX2.Location = New System.Drawing.Point(119, 249)
        Me.lblX2.Name = "lblX2"
        Me.lblX2.Size = New System.Drawing.Size(123, 47)
        Me.lblX2.TabIndex = 10
        Me.lblX2.Text = "x^2 +"
        '
        'lblCero
        '
        Me.lblCero.AutoSize = True
        Me.lblCero.Font = New System.Drawing.Font("Century Gothic", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblCero.Location = New System.Drawing.Point(288, 24)
        Me.lblCero.Name = "lblCero"
        Me.lblCero.Size = New System.Drawing.Size(77, 47)
        Me.lblCero.TabIndex = 11
        Me.lblCero.Text = "= 0"
        '
        'btnCalcular
        '
        Me.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCalcular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen
        Me.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalcular.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnCalcular.Location = New System.Drawing.Point(786, 253)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(245, 73)
        Me.btnCalcular.TabIndex = 3
        Me.btnCalcular.Text = "&Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnSalir.Location = New System.Drawing.Point(786, 383)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(245, 73)
        Me.btnSalir.TabIndex = 4
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'lblResultado
        '
        Me.lblResultado.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblResultado.Location = New System.Drawing.Point(23, 341)
        Me.lblResultado.Name = "lblResultado"
        Me.lblResultado.Size = New System.Drawing.Size(590, 145)
        Me.lblResultado.TabIndex = 15
        '
        'txtC
        '
        Me.txtC.Font = New System.Drawing.Font("Century Gothic", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtC.Location = New System.Drawing.Point(192, 14)
        Me.txtC.MaxLength = 5
        Me.txtC.Name = "txtC"
        Me.txtC.Size = New System.Drawing.Size(90, 57)
        Me.txtC.TabIndex = 2
        Me.txtC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblX
        '
        Me.lblX.AutoSize = True
        Me.lblX.Font = New System.Drawing.Font("Century Gothic", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblX.Location = New System.Drawing.Point(109, 24)
        Me.lblX.Name = "lblX"
        Me.lblX.Size = New System.Drawing.Size(77, 47)
        Me.lblX.TabIndex = 17
        Me.lblX.Text = "x +"
        '
        'PanelEcPrimGrado
        '
        Me.PanelEcPrimGrado.Controls.Add(Me.lblCero)
        Me.PanelEcPrimGrado.Controls.Add(Me.lblX)
        Me.PanelEcPrimGrado.Controls.Add(Me.txtB)
        Me.PanelEcPrimGrado.Controls.Add(Me.txtC)
        Me.PanelEcPrimGrado.Location = New System.Drawing.Point(263, 226)
        Me.PanelEcPrimGrado.Name = "PanelEcPrimGrado"
        Me.PanelEcPrimGrado.Size = New System.Drawing.Size(382, 81)
        Me.PanelEcPrimGrado.TabIndex = 1
        '
        'frmEcuaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1065, 495)
        Me.Controls.Add(Me.PanelEcPrimGrado)
        Me.Controls.Add(Me.lblResultado)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.lblX2)
        Me.Controls.Add(Me.txtA)
        Me.Controls.Add(Me.lblFormula)
        Me.Controls.Add(Me.lblsubtitulo)
        Me.Controls.Add(Me.lblTipoEcuacion)
        Me.Controls.Add(Me.PanelElegir)
        Me.Controls.Add(Me.lblTitulo)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEcuaciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ecuaciones"
        Me.PanelElegir.ResumeLayout(False)
        Me.PanelElegir.PerformLayout()
        Me.PanelEcPrimGrado.ResumeLayout(False)
        Me.PanelEcPrimGrado.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents rbPrimerGrado As RadioButton
    Friend WithEvents rbSegundoGrado As RadioButton
    Friend WithEvents lblTipoEcuacion As Label
    Friend WithEvents PanelElegir As Panel
    Friend WithEvents lblsubtitulo As Label
    Friend WithEvents lblFormula As Label
    Friend WithEvents txtA As TextBox
    Friend WithEvents txtB As TextBox
    Friend WithEvents lblX2 As Label
    Friend WithEvents lblCero As Label
    Friend WithEvents btnCalcular As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents lblResultado As Label
    Friend WithEvents txtC As TextBox
    Friend WithEvents lblX As Label
    Friend WithEvents PanelEcPrimGrado As Panel
End Class
