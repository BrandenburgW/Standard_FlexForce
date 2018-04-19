<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dashMarkt_Fragen
    Inherits System.Windows.Forms.UserControl

    'UserControl überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.vgFragen = New DevExpress.XtraVerticalGrid.VGridControl()
        CType(Me.vgFragen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'vgFragen
        '
        Me.vgFragen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.vgFragen.Location = New System.Drawing.Point(0, 0)
        Me.vgFragen.Name = "vgFragen"
        Me.vgFragen.RecordWidth = 200
        Me.vgFragen.RowHeaderWidth = 300
        Me.vgFragen.Size = New System.Drawing.Size(243, 425)
        Me.vgFragen.TabIndex = 0
        '
        'dashMarkt_Fragen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.vgFragen)
        Me.Name = "dashMarkt_Fragen"
        Me.Size = New System.Drawing.Size(243, 425)
        CType(Me.vgFragen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents vgFragen As DevExpress.XtraVerticalGrid.VGridControl
End Class
