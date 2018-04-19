<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BSSTXT
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
        Me.gcBSSTXT = New DevExpress.XtraGrid.GridControl()
        Me.gvBSSTXT = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltxtid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colx3Sort = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colx4Fragetext = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAntwort = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.gcBSSTXT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvBSSTXT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gcBSSTXT
        '
        Me.gcBSSTXT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcBSSTXT.Location = New System.Drawing.Point(0, 0)
        Me.gcBSSTXT.MainView = Me.gvBSSTXT
        Me.gcBSSTXT.Name = "gcBSSTXT"
        Me.gcBSSTXT.Size = New System.Drawing.Size(1143, 576)
        Me.gcBSSTXT.TabIndex = 0
        Me.gcBSSTXT.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvBSSTXT})
        '
        'gvBSSTXT
        '
        Me.gvBSSTXT.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.coltxtid, Me.colx3Sort, Me.colx4Fragetext, Me.colAntwort})
        Me.gvBSSTXT.GridControl = Me.gcBSSTXT
        Me.gvBSSTXT.Name = "gvBSSTXT"
        Me.gvBSSTXT.OptionsBehavior.Editable = False
        Me.gvBSSTXT.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplace
        Me.gvBSSTXT.OptionsView.ColumnAutoWidth = False
        Me.gvBSSTXT.OptionsView.ShowAutoFilterRow = True
        Me.gvBSSTXT.OptionsView.ShowFooter = True
        Me.gvBSSTXT.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "BSSID"
        Me.GridColumn1.FieldName = "bssID"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.OptionsColumn.AllowFocus = False
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Debitor"
        Me.GridColumn2.FieldName = "debitoren_nummer"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.OptionsColumn.AllowFocus = False
        Me.GridColumn2.OptionsColumn.ReadOnly = True
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Aktiopnsnr"
        Me.GridColumn3.FieldName = "aktionsnummer"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.OptionsColumn.AllowFocus = False
        Me.GridColumn3.OptionsColumn.ReadOnly = True
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "ComberaID"
        Me.GridColumn4.FieldName = "x1combera_id"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.AllowEdit = False
        Me.GridColumn4.OptionsColumn.AllowFocus = False
        Me.GridColumn4.OptionsColumn.ReadOnly = True
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "MA_ID"
        Me.GridColumn5.FieldName = "maID"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.AllowEdit = False
        Me.GridColumn5.OptionsColumn.AllowFocus = False
        Me.GridColumn5.OptionsColumn.ReadOnly = True
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 4
        Me.GridColumn5.Width = 60
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "ADM_Name"
        Me.GridColumn6.FieldName = "ADM_Name"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.AllowEdit = False
        Me.GridColumn6.OptionsColumn.AllowFocus = False
        Me.GridColumn6.OptionsColumn.ReadOnly = True
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 5
        Me.GridColumn6.Width = 100
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Besuchsdatum"
        Me.GridColumn7.FieldName = "x2Besuchsdatum"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.AllowEdit = False
        Me.GridColumn7.OptionsColumn.AllowFocus = False
        Me.GridColumn7.OptionsColumn.ReadOnly = True
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 6
        Me.GridColumn7.Width = 90
        '
        'coltxtid
        '
        Me.coltxtid.Caption = "Txt_ID"
        Me.coltxtid.FieldName = "txtID"
        Me.coltxtid.Name = "coltxtid"
        Me.coltxtid.OptionsColumn.AllowEdit = False
        Me.coltxtid.OptionsColumn.AllowFocus = False
        Me.coltxtid.OptionsColumn.ReadOnly = True
        Me.coltxtid.Visible = True
        Me.coltxtid.VisibleIndex = 7
        Me.coltxtid.Width = 40
        '
        'colx3Sort
        '
        Me.colx3Sort.Caption = "Sort"
        Me.colx3Sort.FieldName = "x3Sort"
        Me.colx3Sort.Name = "colx3Sort"
        Me.colx3Sort.OptionsColumn.AllowEdit = False
        Me.colx3Sort.OptionsColumn.AllowFocus = False
        Me.colx3Sort.OptionsColumn.ReadOnly = True
        Me.colx3Sort.Visible = True
        Me.colx3Sort.VisibleIndex = 8
        '
        'colx4Fragetext
        '
        Me.colx4Fragetext.Caption = "Fragetext"
        Me.colx4Fragetext.FieldName = "x4Fragetext"
        Me.colx4Fragetext.Name = "colx4Fragetext"
        Me.colx4Fragetext.OptionsColumn.AllowEdit = False
        Me.colx4Fragetext.OptionsColumn.AllowFocus = False
        Me.colx4Fragetext.OptionsColumn.ReadOnly = True
        Me.colx4Fragetext.Visible = True
        Me.colx4Fragetext.VisibleIndex = 9
        Me.colx4Fragetext.Width = 350
        '
        'colAntwort
        '
        Me.colAntwort.Caption = "Antwort"
        Me.colAntwort.FieldName = "Antwort"
        Me.colAntwort.Name = "colAntwort"
        Me.colAntwort.OptionsColumn.AllowEdit = False
        Me.colAntwort.OptionsColumn.AllowFocus = False
        Me.colAntwort.OptionsColumn.ReadOnly = True
        Me.colAntwort.Visible = True
        Me.colAntwort.VisibleIndex = 10
        Me.colAntwort.Width = 200
        '
        'BSSTXT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.gcBSSTXT)
        Me.Name = "BSSTXT"
        Me.Size = New System.Drawing.Size(1143, 576)
        CType(Me.gcBSSTXT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvBSSTXT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gcBSSTXT As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvBSSTXT As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltxtid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colx3Sort As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colx4Fragetext As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAntwort As DevExpress.XtraGrid.Columns.GridColumn
End Class
