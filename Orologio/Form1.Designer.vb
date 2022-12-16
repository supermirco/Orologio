<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla nell'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.LblOre = New System.Windows.Forms.Label()
        Me.LblMinuti = New System.Windows.Forms.Label()
        Me.LblSecondi = New System.Windows.Forms.Label()
        Me.BtnStart = New System.Windows.Forms.Button()
        Me.BtnStop = New System.Windows.Forms.Button()
        Me.LblNome = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LblInfoOre = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LblOre
        '
        Me.LblOre.AutoSize = True
        Me.LblOre.CausesValidation = False
        Me.LblOre.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblOre.Location = New System.Drawing.Point(12, 230)
        Me.LblOre.Name = "LblOre"
        Me.LblOre.Size = New System.Drawing.Size(68, 73)
        Me.LblOre.TabIndex = 0
        Me.LblOre.Text = "0"
        '
        'LblMinuti
        '
        Me.LblMinuti.AutoSize = True
        Me.LblMinuti.CausesValidation = False
        Me.LblMinuti.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMinuti.Location = New System.Drawing.Point(121, 230)
        Me.LblMinuti.Name = "LblMinuti"
        Me.LblMinuti.Size = New System.Drawing.Size(68, 73)
        Me.LblMinuti.TabIndex = 1
        Me.LblMinuti.Text = "0"
        '
        'LblSecondi
        '
        Me.LblSecondi.AutoSize = True
        Me.LblSecondi.CausesValidation = False
        Me.LblSecondi.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSecondi.Location = New System.Drawing.Point(232, 230)
        Me.LblSecondi.Name = "LblSecondi"
        Me.LblSecondi.Size = New System.Drawing.Size(68, 73)
        Me.LblSecondi.TabIndex = 2
        Me.LblSecondi.Text = "0"
        '
        'BtnStart
        '
        Me.BtnStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnStart.Location = New System.Drawing.Point(12, 459)
        Me.BtnStart.Name = "BtnStart"
        Me.BtnStart.Size = New System.Drawing.Size(128, 47)
        Me.BtnStart.TabIndex = 3
        Me.BtnStart.Text = "Start"
        Me.BtnStart.UseVisualStyleBackColor = True
        '
        'BtnStop
        '
        Me.BtnStop.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnStop.Location = New System.Drawing.Point(212, 459)
        Me.BtnStop.Name = "BtnStop"
        Me.BtnStop.Size = New System.Drawing.Size(128, 47)
        Me.BtnStop.TabIndex = 4
        Me.BtnStop.Text = "Stop"
        Me.BtnStop.UseVisualStyleBackColor = True
        '
        'LblNome
        '
        Me.LblNome.AutoSize = True
        Me.LblNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNome.Location = New System.Drawing.Point(71, 26)
        Me.LblNome.Name = "LblNome"
        Me.LblNome.Size = New System.Drawing.Size(205, 39)
        Me.LblNome.TabIndex = 5
        Me.LblNome.Text = "OROLOGIO"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'LblInfoOre
        '
        Me.LblInfoOre.AutoSize = True
        Me.LblInfoOre.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInfoOre.Location = New System.Drawing.Point(32, 201)
        Me.LblInfoOre.Name = "LblInfoOre"
        Me.LblInfoOre.Size = New System.Drawing.Size(54, 29)
        Me.LblInfoOre.TabIndex = 6
        Me.LblInfoOre.Text = "Ore"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(129, 201)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 29)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Minuti"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(231, 201)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 29)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Secondi"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(352, 530)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblInfoOre)
        Me.Controls.Add(Me.LblNome)
        Me.Controls.Add(Me.BtnStop)
        Me.Controls.Add(Me.BtnStart)
        Me.Controls.Add(Me.LblSecondi)
        Me.Controls.Add(Me.LblMinuti)
        Me.Controls.Add(Me.LblOre)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblOre As System.Windows.Forms.Label
    Friend WithEvents LblMinuti As System.Windows.Forms.Label
    Friend WithEvents LblSecondi As System.Windows.Forms.Label
    Friend WithEvents BtnStart As System.Windows.Forms.Button
    Friend WithEvents BtnStop As System.Windows.Forms.Button
    Friend WithEvents LblNome As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents LblInfoOre As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
