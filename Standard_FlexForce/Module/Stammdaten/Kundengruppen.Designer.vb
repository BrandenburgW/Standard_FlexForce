﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Kundengruppen
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
        Me.gcKGR = New DevExpress.XtraGrid.GridControl()
        Me.gvKGR = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.gcKGR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvKGR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gcKGR
        '
        Me.gcKGR.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcKGR.Location = New System.Drawing.Point(0, 0)
        Me.gcKGR.MainView = Me.gvKGR
        Me.gcKGR.Name = "gcKGR"
        Me.gcKGR.Size = New System.Drawing.Size(1143, 576)
        Me.gcKGR.TabIndex = 0
        Me.gcKGR.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvKGR})
        '
        'gvKGR
        '
        Me.gvKGR.GridControl = Me.gcKGR
        Me.gvKGR.Name = "gvKGR"
        Me.gvKGR.OptionsBehavior.Editable = False
        Me.gvKGR.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplace
        Me.gvKGR.OptionsView.ColumnAutoWidth = False
        Me.gvKGR.OptionsView.ShowAutoFilterRow = True
        Me.gvKGR.OptionsView.ShowFooter = True
        Me.gvKGR.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        '
        'Kundengruppen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.gcKGR)
        Me.Name = "Kundengruppen"
        Me.Size = New System.Drawing.Size(1143, 576)
        CType(Me.gcKGR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvKGR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gcKGR As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvKGR As DevExpress.XtraGrid.Views.Grid.GridView
End Class
