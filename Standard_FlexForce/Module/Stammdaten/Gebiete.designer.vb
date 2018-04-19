<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Gebiete
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
        Me.gcGebiete = New DevExpress.XtraGrid.GridControl()
        Me.gvGebiete = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.gcGebiete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvGebiete, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gcGebiete
        '
        Me.gcGebiete.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcGebiete.Location = New System.Drawing.Point(0, 0)
        Me.gcGebiete.MainView = Me.gvGebiete
        Me.gcGebiete.Name = "gcGebiete"
        Me.gcGebiete.Size = New System.Drawing.Size(1143, 576)
        Me.gcGebiete.TabIndex = 0
        Me.gcGebiete.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvGebiete})
        '
        'gvGebiete
        '
        Me.gvGebiete.GridControl = Me.gcGebiete
        Me.gvGebiete.Name = "gvGebiete"
        Me.gvGebiete.OptionsBehavior.Editable = False
        Me.gvGebiete.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplace
        Me.gvGebiete.OptionsView.ColumnAutoWidth = False
        Me.gvGebiete.OptionsView.ShowAutoFilterRow = True
        Me.gvGebiete.OptionsView.ShowFooter = True
        Me.gvGebiete.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        '
        'Gebiete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.gcGebiete)
        Me.Name = "Gebiete"
        Me.Size = New System.Drawing.Size(1143, 576)
        CType(Me.gcGebiete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvGebiete, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gcGebiete As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvGebiete As DevExpress.XtraGrid.Views.Grid.GridView
End Class
