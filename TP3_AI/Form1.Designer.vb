<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnEntrenar = New System.Windows.Forms.Button()
        Me.cmdEjecutar = New System.Windows.Forms.Button()
        Me.btnSube = New System.Windows.Forms.Button()
        Me.btnBaja = New System.Windows.Forms.Button()
        Me.btnIzq = New System.Windows.Forms.Button()
        Me.btnDer = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.btnDerEjemplo = New System.Windows.Forms.Button()
        Me.bntIzqEjemplo = New System.Windows.Forms.Button()
        Me.btnBajaEjemplo = New System.Windows.Forms.Button()
        Me.btnSubeEjemplo = New System.Windows.Forms.Button()
        Me.lblPaso = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblPatron = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnNuevoEjemplo = New System.Windows.Forms.Button()
        Me.lblFin = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView1.Location = New System.Drawing.Point(115, 45)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataGridView1.Size = New System.Drawing.Size(257, 212)
        Me.DataGridView1.TabIndex = 1
        '
        'btnEntrenar
        '
        Me.btnEntrenar.Location = New System.Drawing.Point(394, 146)
        Me.btnEntrenar.Name = "btnEntrenar"
        Me.btnEntrenar.Size = New System.Drawing.Size(75, 23)
        Me.btnEntrenar.TabIndex = 2
        Me.btnEntrenar.Text = "Entrenar"
        Me.btnEntrenar.UseVisualStyleBackColor = True
        '
        'cmdEjecutar
        '
        Me.cmdEjecutar.Location = New System.Drawing.Point(379, 318)
        Me.cmdEjecutar.Name = "cmdEjecutar"
        Me.cmdEjecutar.Size = New System.Drawing.Size(103, 43)
        Me.cmdEjecutar.TabIndex = 4
        Me.cmdEjecutar.Text = "Procesar Ejemplo"
        Me.cmdEjecutar.UseVisualStyleBackColor = True
        '
        'btnSube
        '
        Me.btnSube.Location = New System.Drawing.Point(36, 117)
        Me.btnSube.Name = "btnSube"
        Me.btnSube.Size = New System.Drawing.Size(37, 23)
        Me.btnSube.TabIndex = 5
        Me.btnSube.Text = "subir"
        Me.btnSube.UseVisualStyleBackColor = True
        '
        'btnBaja
        '
        Me.btnBaja.Location = New System.Drawing.Point(36, 175)
        Me.btnBaja.Name = "btnBaja"
        Me.btnBaja.Size = New System.Drawing.Size(37, 23)
        Me.btnBaja.TabIndex = 6
        Me.btnBaja.Text = "bajar"
        Me.btnBaja.UseVisualStyleBackColor = True
        '
        'btnIzq
        '
        Me.btnIzq.Location = New System.Drawing.Point(12, 146)
        Me.btnIzq.Name = "btnIzq"
        Me.btnIzq.Size = New System.Drawing.Size(37, 23)
        Me.btnIzq.TabIndex = 7
        Me.btnIzq.Text = "izq"
        Me.btnIzq.UseVisualStyleBackColor = True
        '
        'btnDer
        '
        Me.btnDer.Location = New System.Drawing.Point(55, 146)
        Me.btnDer.Name = "btnDer"
        Me.btnDer.Size = New System.Drawing.Size(41, 23)
        Me.btnDer.TabIndex = 8
        Me.btnDer.Text = "der"
        Me.btnDer.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 69)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Ubique el patron a gusto y luego presione Gererar Patron"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(102, 271)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(272, 23)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Una vez generado 1 o mas patrones, pruebe el modelo ->"
        '
        'DataGridView3
        '
        Me.DataGridView3.AllowUserToAddRows = False
        Me.DataGridView3.AllowUserToDeleteRows = False
        Me.DataGridView3.AllowUserToResizeColumns = False
        Me.DataGridView3.AllowUserToResizeRows = False
        Me.DataGridView3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView3.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView3.Location = New System.Drawing.Point(114, 297)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.DataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataGridView3.Size = New System.Drawing.Size(258, 233)
        Me.DataGridView3.TabIndex = 13
        '
        'btnDerEjemplo
        '
        Me.btnDerEjemplo.Location = New System.Drawing.Point(58, 383)
        Me.btnDerEjemplo.Name = "btnDerEjemplo"
        Me.btnDerEjemplo.Size = New System.Drawing.Size(41, 23)
        Me.btnDerEjemplo.TabIndex = 17
        Me.btnDerEjemplo.Text = "der"
        Me.btnDerEjemplo.UseVisualStyleBackColor = True
        '
        'bntIzqEjemplo
        '
        Me.bntIzqEjemplo.Location = New System.Drawing.Point(15, 383)
        Me.bntIzqEjemplo.Name = "bntIzqEjemplo"
        Me.bntIzqEjemplo.Size = New System.Drawing.Size(37, 23)
        Me.bntIzqEjemplo.TabIndex = 16
        Me.bntIzqEjemplo.Text = "izq"
        Me.bntIzqEjemplo.UseVisualStyleBackColor = True
        '
        'btnBajaEjemplo
        '
        Me.btnBajaEjemplo.Location = New System.Drawing.Point(39, 412)
        Me.btnBajaEjemplo.Name = "btnBajaEjemplo"
        Me.btnBajaEjemplo.Size = New System.Drawing.Size(37, 23)
        Me.btnBajaEjemplo.TabIndex = 15
        Me.btnBajaEjemplo.Text = "bajar"
        Me.btnBajaEjemplo.UseVisualStyleBackColor = True
        '
        'btnSubeEjemplo
        '
        Me.btnSubeEjemplo.Location = New System.Drawing.Point(39, 354)
        Me.btnSubeEjemplo.Name = "btnSubeEjemplo"
        Me.btnSubeEjemplo.Size = New System.Drawing.Size(37, 23)
        Me.btnSubeEjemplo.TabIndex = 14
        Me.btnSubeEjemplo.Text = "subir"
        Me.btnSubeEjemplo.UseVisualStyleBackColor = True
        '
        'lblPaso
        '
        Me.lblPaso.AutoSize = True
        Me.lblPaso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaso.Location = New System.Drawing.Point(498, 393)
        Me.lblPaso.Name = "lblPaso"
        Me.lblPaso.Size = New System.Drawing.Size(16, 16)
        Me.lblPaso.TabIndex = 18
        Me.lblPaso.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(391, 393)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Ejecutando Paso:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(391, 194)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Patron Nro:"
        '
        'lblPatron
        '
        Me.lblPatron.AutoSize = True
        Me.lblPatron.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatron.Location = New System.Drawing.Point(498, 194)
        Me.lblPatron.Name = "lblPatron"
        Me.lblPatron.Size = New System.Drawing.Size(16, 16)
        Me.lblPatron.TabIndex = 20
        Me.lblPatron.Text = "0"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(102, 533)
        Me.Label4.Margin = New System.Windows.Forms.Padding(0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(220, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Haga Click en la grilla para modificar el dibujo"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(166, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(122, 24)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "PATRONES"
        '
        'btnNuevoEjemplo
        '
        Me.btnNuevoEjemplo.Location = New System.Drawing.Point(379, 436)
        Me.btnNuevoEjemplo.Name = "btnNuevoEjemplo"
        Me.btnNuevoEjemplo.Size = New System.Drawing.Size(103, 43)
        Me.btnNuevoEjemplo.TabIndex = 24
        Me.btnNuevoEjemplo.Text = "Nuevo Ejemplo"
        Me.btnNuevoEjemplo.UseVisualStyleBackColor = True
        '
        'lblFin
        '
        Me.lblFin.AutoSize = True
        Me.lblFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFin.Location = New System.Drawing.Point(55, 576)
        Me.lblFin.Name = "lblFin"
        Me.lblFin.Size = New System.Drawing.Size(0, 16)
        Me.lblFin.TabIndex = 25
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(541, 601)
        Me.Controls.Add(Me.lblFin)
        Me.Controls.Add(Me.btnNuevoEjemplo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblPatron)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblPaso)
        Me.Controls.Add(Me.btnDerEjemplo)
        Me.Controls.Add(Me.bntIzqEjemplo)
        Me.Controls.Add(Me.btnBajaEjemplo)
        Me.Controls.Add(Me.btnSubeEjemplo)
        Me.Controls.Add(Me.DataGridView3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDer)
        Me.Controls.Add(Me.btnIzq)
        Me.Controls.Add(Me.btnBaja)
        Me.Controls.Add(Me.btnSube)
        Me.Controls.Add(Me.cmdEjecutar)
        Me.Controls.Add(Me.btnEntrenar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "IA"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnEntrenar As System.Windows.Forms.Button
    Friend WithEvents cmdEjecutar As System.Windows.Forms.Button
    Friend WithEvents btnSube As System.Windows.Forms.Button
    Friend WithEvents btnBaja As System.Windows.Forms.Button
    Friend WithEvents btnIzq As System.Windows.Forms.Button
    Friend WithEvents btnDer As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataGridView3 As System.Windows.Forms.DataGridView
    Friend WithEvents btnDerEjemplo As System.Windows.Forms.Button
    Friend WithEvents bntIzqEjemplo As System.Windows.Forms.Button
    Friend WithEvents btnBajaEjemplo As System.Windows.Forms.Button
    Friend WithEvents btnSubeEjemplo As System.Windows.Forms.Button
    Friend WithEvents lblPaso As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblPatron As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnNuevoEjemplo As System.Windows.Forms.Button
    Friend WithEvents lblFin As System.Windows.Forms.Label

End Class
