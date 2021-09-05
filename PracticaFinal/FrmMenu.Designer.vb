<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMenu
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMenu))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MantenimientoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HerramientasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SumadoraToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CasaDeCambioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NominaSemanalToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirDelSistemaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MantenimientoToolStripMenuItem, Me.ConsultaToolStripMenuItem, Me.ReporteToolStripMenuItem, Me.HerramientasToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(466, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MantenimientoToolStripMenuItem
        '
        Me.MantenimientoToolStripMenuItem.Name = "MantenimientoToolStripMenuItem"
        Me.MantenimientoToolStripMenuItem.Size = New System.Drawing.Size(101, 20)
        Me.MantenimientoToolStripMenuItem.Text = "&Mantenimiento"
        '
        'ConsultaToolStripMenuItem
        '
        Me.ConsultaToolStripMenuItem.Name = "ConsultaToolStripMenuItem"
        Me.ConsultaToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.ConsultaToolStripMenuItem.Text = "&Consulta"
        '
        'ReporteToolStripMenuItem
        '
        Me.ReporteToolStripMenuItem.Name = "ReporteToolStripMenuItem"
        Me.ReporteToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ReporteToolStripMenuItem.Text = "&Reporte"
        '
        'HerramientasToolStripMenuItem
        '
        Me.HerramientasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SumadoraToolStripMenuItem1, Me.CasaDeCambioToolStripMenuItem, Me.NominaSemanalToolStripMenuItem1, Me.SalirDelSistemaToolStripMenuItem1})
        Me.HerramientasToolStripMenuItem.Name = "HerramientasToolStripMenuItem"
        Me.HerramientasToolStripMenuItem.Size = New System.Drawing.Size(90, 20)
        Me.HerramientasToolStripMenuItem.Text = "&Herramientas"
        '
        'SumadoraToolStripMenuItem1
        '
        Me.SumadoraToolStripMenuItem1.Name = "SumadoraToolStripMenuItem1"
        Me.SumadoraToolStripMenuItem1.Size = New System.Drawing.Size(165, 22)
        Me.SumadoraToolStripMenuItem1.Text = "&Sumadora"
        '
        'CasaDeCambioToolStripMenuItem
        '
        Me.CasaDeCambioToolStripMenuItem.Name = "CasaDeCambioToolStripMenuItem"
        Me.CasaDeCambioToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.CasaDeCambioToolStripMenuItem.Text = "&Casa de cambio"
        '
        'NominaSemanalToolStripMenuItem1
        '
        Me.NominaSemanalToolStripMenuItem1.Name = "NominaSemanalToolStripMenuItem1"
        Me.NominaSemanalToolStripMenuItem1.Size = New System.Drawing.Size(165, 22)
        Me.NominaSemanalToolStripMenuItem1.Text = "&Nomina Semanal"
        '
        'SalirDelSistemaToolStripMenuItem1
        '
        Me.SalirDelSistemaToolStripMenuItem1.Name = "SalirDelSistemaToolStripMenuItem1"
        Me.SalirDelSistemaToolStripMenuItem1.Size = New System.Drawing.Size(165, 22)
        Me.SalirDelSistemaToolStripMenuItem1.Text = "&Salir del Sistema"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PracticaFinal.My.Resources.Resources.LOGO_UTESA__1_
        Me.PictureBox1.Location = New System.Drawing.Point(60, 36)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(336, 262)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(337, 310)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(129, 25)
        Me.LinkLabel1.TabIndex = 2
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Pagina Web"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel2.Location = New System.Drawing.Point(12, 310)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(95, 25)
        Me.LinkLabel2.TabIndex = 3
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Carreras"
        '
        'FrmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(466, 335)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MantenimientoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReporteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HerramientasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SumadoraToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CasaDeCambioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NominaSemanalToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SalirDelSistemaToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents LinkLabel2 As LinkLabel
End Class
