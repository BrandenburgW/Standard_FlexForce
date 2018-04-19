<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Artikelstamm
    Inherits System.Windows.Forms.UserControl

    'UserControl überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.gcArtstamm = New DevExpress.XtraGrid.GridControl()
        Me.gvArtstamm = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.gcArtstamm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvArtstamm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gcArtstamm
        '
        Me.gcArtstamm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcArtstamm.Location = New System.Drawing.Point(0, 0)
        Me.gcArtstamm.MainView = Me.gvArtstamm
        Me.gcArtstamm.Name = "gcArtstamm"
        Me.gcArtstamm.Size = New System.Drawing.Size(1143, 576)
        Me.gcArtstamm.TabIndex = 0
        Me.gcArtstamm.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvArtstamm})
        '
        'gvArtstamm
        '
        Me.gvArtstamm.GridControl = Me.gcArtstamm
        Me.gvArtstamm.Name = "gvArtstamm"
        Me.gvArtstamm.OptionsBehavior.Editable = False
        Me.gvArtstamm.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplace
        Me.gvArtstamm.OptionsView.ColumnAutoWidth = False
        Me.gvArtstamm.OptionsView.ShowAutoFilterRow = True
        Me.gvArtstamm.OptionsView.ShowFooter = True
        Me.gvArtstamm.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        '
        'Artikelstamm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.gcArtstamm)
        Me.Name = "Artikelstamm"
        Me.Size = New System.Drawing.Size(1143, 576)
        CType(Me.gcArtstamm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvArtstamm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gcArtstamm As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvArtstamm As DevExpress.XtraGrid.Views.Grid.GridView
End Class
