<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dashMarkt_Produkte
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
        Me.gcdashProd = New DevExpress.XtraGrid.GridControl()
        Me.gvdashProd = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.gcdashProd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvdashProd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gcdashProd
        '
        Me.gcdashProd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcdashProd.Location = New System.Drawing.Point(0, 0)
        Me.gcdashProd.MainView = Me.gvdashProd
        Me.gcdashProd.Name = "gcdashProd"
        Me.gcdashProd.Size = New System.Drawing.Size(579, 430)
        Me.gcdashProd.TabIndex = 0
        Me.gcdashProd.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvdashProd})
        '
        'gvdashProd
        '
        Me.gvdashProd.GridControl = Me.gcdashProd
        Me.gvdashProd.Name = "gvdashProd"
        Me.gvdashProd.OptionsView.ColumnAutoWidth = False
        Me.gvdashProd.OptionsView.ShowGroupPanel = False
        '
        'dashMarkt_Produkte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.gcdashProd)
        Me.Name = "dashMarkt_Produkte"
        Me.Size = New System.Drawing.Size(579, 430)
        CType(Me.gcdashProd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvdashProd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gcdashProd As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvdashProd As DevExpress.XtraGrid.Views.Grid.GridView
End Class
