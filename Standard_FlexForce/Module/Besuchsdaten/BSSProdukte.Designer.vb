<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BSSProdukte
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
        Me.gcBSSProdukte = New DevExpress.XtraGrid.GridControl()
        Me.gvBSSProdukte = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbssID_temp = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBereich = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSort = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colArtID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colx5Artikelname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Zahl1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Zahl2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Zahl3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.JN1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.JN2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.droplistitemID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.droplisttext = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colx300Datum_intern = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colx301Zeit_intern = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVerarbeitungsstatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colx900CreateDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colx901CreateUser = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colx902EditDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colx903EditUser = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.gcBSSProdukte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvBSSProdukte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gcBSSProdukte
        '
        Me.gcBSSProdukte.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcBSSProdukte.Location = New System.Drawing.Point(0, 0)
        Me.gcBSSProdukte.MainView = Me.gvBSSProdukte
        Me.gcBSSProdukte.Name = "gcBSSProdukte"
        Me.gcBSSProdukte.Size = New System.Drawing.Size(1143, 576)
        Me.gcBSSProdukte.TabIndex = 0
        Me.gcBSSProdukte.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvBSSProdukte})
        '
        'gvBSSProdukte
        '
        Me.gvBSSProdukte.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.colbssID_temp, Me.GridColumn2, Me.GridColumn3, Me.GridColumn5, Me.GridColumn6, Me.GridColumn4, Me.GridColumn7, Me.colBereich, Me.colSort, Me.colArtID, Me.colx5Artikelname, Me.Zahl1, Me.Zahl2, Me.Zahl3, Me.JN1, Me.JN2, Me.droplistitemID, Me.droplisttext, Me.colx300Datum_intern, Me.colx301Zeit_intern, Me.colVerarbeitungsstatus, Me.colx900CreateDate, Me.colx901CreateUser, Me.colx902EditDate, Me.colx903EditUser})
        Me.gvBSSProdukte.GridControl = Me.gcBSSProdukte
        Me.gvBSSProdukte.Name = "gvBSSProdukte"
        Me.gvBSSProdukte.OptionsBehavior.Editable = False
        Me.gvBSSProdukte.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplace
        Me.gvBSSProdukte.OptionsView.ColumnAutoWidth = False
        Me.gvBSSProdukte.OptionsView.ShowAutoFilterRow = True
        Me.gvBSSProdukte.OptionsView.ShowFooter = True
        Me.gvBSSProdukte.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "BSSID"
        Me.GridColumn1.FieldName = "bssProdID"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.OptionsColumn.AllowFocus = False
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'colbssID_temp
        '
        Me.colbssID_temp.Caption = "BSSID_temp"
        Me.colbssID_temp.FieldName = "bssID"
        Me.colbssID_temp.Name = "colbssID_temp"
        Me.colbssID_temp.OptionsColumn.AllowEdit = False
        Me.colbssID_temp.OptionsColumn.AllowFocus = False
        Me.colbssID_temp.OptionsColumn.ReadOnly = True
        Me.colbssID_temp.Visible = True
        Me.colbssID_temp.VisibleIndex = 1
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
        Me.GridColumn2.VisibleIndex = 2
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
        Me.GridColumn3.VisibleIndex = 3
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
        Me.GridColumn4.VisibleIndex = 6
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
        Me.GridColumn7.VisibleIndex = 7
        '
        'colBereich
        '
        Me.colBereich.Caption = "Bereich"
        Me.colBereich.FieldName = "Bereich"
        Me.colBereich.Name = "colBereich"
        Me.colBereich.OptionsColumn.AllowEdit = False
        Me.colBereich.OptionsColumn.AllowFocus = False
        Me.colBereich.OptionsColumn.ReadOnly = True
        Me.colBereich.Visible = True
        Me.colBereich.VisibleIndex = 8
        '
        'colSort
        '
        Me.colSort.Caption = "Sort"
        Me.colSort.FieldName = "x3Sort"
        Me.colSort.Name = "colSort"
        Me.colSort.OptionsColumn.AllowEdit = False
        Me.colSort.OptionsColumn.AllowFocus = False
        Me.colSort.OptionsColumn.ReadOnly = True
        Me.colSort.Visible = True
        Me.colSort.VisibleIndex = 9
        '
        'colArtID
        '
        Me.colArtID.Caption = "ArtID"
        Me.colArtID.FieldName = "artid"
        Me.colArtID.Name = "colArtID"
        Me.colArtID.OptionsColumn.AllowEdit = False
        Me.colArtID.OptionsColumn.AllowFocus = False
        Me.colArtID.OptionsColumn.ReadOnly = True
        Me.colArtID.Visible = True
        Me.colArtID.VisibleIndex = 10
        '
        'colx5Artikelname
        '
        Me.colx5Artikelname.Caption = "Artikel"
        Me.colx5Artikelname.FieldName = "x5Artikelname"
        Me.colx5Artikelname.Name = "colx5Artikelname"
        Me.colx5Artikelname.OptionsColumn.AllowEdit = False
        Me.colx5Artikelname.OptionsColumn.AllowFocus = False
        Me.colx5Artikelname.OptionsColumn.ReadOnly = True
        Me.colx5Artikelname.Visible = True
        Me.colx5Artikelname.VisibleIndex = 11
        '
        'Zahl1
        '
        Me.Zahl1.Caption = "Zahl1"
        Me.Zahl1.FieldName = "Zahl1"
        Me.Zahl1.Name = "Zahl1"
        Me.Zahl1.OptionsColumn.AllowEdit = False
        Me.Zahl1.OptionsColumn.AllowFocus = False
        Me.Zahl1.OptionsColumn.ReadOnly = True
        Me.Zahl1.Visible = True
        Me.Zahl1.VisibleIndex = 12
        '
        'Zahl2
        '
        Me.Zahl2.Caption = "Zahl2"
        Me.Zahl2.FieldName = "Zahl2"
        Me.Zahl2.Name = "Zahl2"
        Me.Zahl2.OptionsColumn.AllowEdit = False
        Me.Zahl2.OptionsColumn.AllowFocus = False
        Me.Zahl2.OptionsColumn.ReadOnly = True
        Me.Zahl2.Visible = True
        Me.Zahl2.VisibleIndex = 13
        '
        'Zahl3
        '
        Me.Zahl3.Caption = "Zahl3"
        Me.Zahl3.FieldName = "Zahl3"
        Me.Zahl3.Name = "Zahl3"
        Me.Zahl3.OptionsColumn.AllowEdit = False
        Me.Zahl3.OptionsColumn.AllowFocus = False
        Me.Zahl3.OptionsColumn.ReadOnly = True
        Me.Zahl3.Visible = True
        Me.Zahl3.VisibleIndex = 14
        '
        'JN1
        '
        Me.JN1.Caption = "JN1"
        Me.JN1.FieldName = "JN1"
        Me.JN1.Name = "JN1"
        Me.JN1.OptionsColumn.AllowEdit = False
        Me.JN1.OptionsColumn.AllowFocus = False
        Me.JN1.OptionsColumn.ReadOnly = True
        Me.JN1.Visible = True
        Me.JN1.VisibleIndex = 15
        '
        'JN2
        '
        Me.JN2.Caption = "JN2"
        Me.JN2.FieldName = "JN2"
        Me.JN2.Name = "JN2"
        Me.JN2.OptionsColumn.AllowEdit = False
        Me.JN2.OptionsColumn.AllowFocus = False
        Me.JN2.OptionsColumn.ReadOnly = True
        Me.JN2.Visible = True
        Me.JN2.VisibleIndex = 16
        '
        'droplistitemID
        '
        Me.droplistitemID.Caption = "DroplistItem_ID"
        Me.droplistitemID.FieldName = "droplistitemID"
        Me.droplistitemID.Name = "droplistitemID"
        Me.droplistitemID.OptionsColumn.AllowEdit = False
        Me.droplistitemID.OptionsColumn.AllowFocus = False
        Me.droplistitemID.OptionsColumn.ReadOnly = True
        Me.droplistitemID.Visible = True
        Me.droplistitemID.VisibleIndex = 17
        '
        'droplisttext
        '
        Me.droplisttext.Caption = "Droplist_Text"
        Me.droplisttext.FieldName = "droplisttext"
        Me.droplisttext.Name = "droplisttext"
        Me.droplisttext.OptionsColumn.AllowEdit = False
        Me.droplisttext.OptionsColumn.AllowFocus = False
        Me.droplisttext.OptionsColumn.ReadOnly = True
        Me.droplisttext.Visible = True
        Me.droplisttext.VisibleIndex = 18
        '
        'colx300Datum_intern
        '
        Me.colx300Datum_intern.FieldName = "x300Datum_intern"
        Me.colx300Datum_intern.Name = "colx300Datum_intern"
        Me.colx300Datum_intern.OptionsColumn.AllowEdit = False
        Me.colx300Datum_intern.OptionsColumn.AllowFocus = False
        Me.colx300Datum_intern.OptionsColumn.ReadOnly = True
        '
        'colx301Zeit_intern
        '
        Me.colx301Zeit_intern.FieldName = "x301Zeit_intern"
        Me.colx301Zeit_intern.Name = "colx301Zeit_intern"
        Me.colx301Zeit_intern.OptionsColumn.AllowEdit = False
        Me.colx301Zeit_intern.OptionsColumn.AllowFocus = False
        Me.colx301Zeit_intern.OptionsColumn.ReadOnly = True
        '
        'colVerarbeitungsstatus
        '
        Me.colVerarbeitungsstatus.FieldName = "Verarbeitungsstatus"
        Me.colVerarbeitungsstatus.Name = "colVerarbeitungsstatus"
        Me.colVerarbeitungsstatus.OptionsColumn.AllowEdit = False
        Me.colVerarbeitungsstatus.OptionsColumn.AllowFocus = False
        Me.colVerarbeitungsstatus.OptionsColumn.ReadOnly = True
        Me.colVerarbeitungsstatus.Visible = True
        Me.colVerarbeitungsstatus.VisibleIndex = 19
        '
        'colx900CreateDate
        '
        Me.colx900CreateDate.FieldName = "x900CreateDate"
        Me.colx900CreateDate.Name = "colx900CreateDate"
        Me.colx900CreateDate.OptionsColumn.AllowEdit = False
        Me.colx900CreateDate.OptionsColumn.AllowFocus = False
        Me.colx900CreateDate.OptionsColumn.ReadOnly = True
        '
        'colx901CreateUser
        '
        Me.colx901CreateUser.FieldName = "x901CreateUser"
        Me.colx901CreateUser.Name = "colx901CreateUser"
        Me.colx901CreateUser.OptionsColumn.AllowEdit = False
        Me.colx901CreateUser.OptionsColumn.AllowFocus = False
        Me.colx901CreateUser.OptionsColumn.ReadOnly = True
        '
        'colx902EditDate
        '
        Me.colx902EditDate.FieldName = "x902EditDate"
        Me.colx902EditDate.Name = "colx902EditDate"
        Me.colx902EditDate.OptionsColumn.AllowEdit = False
        Me.colx902EditDate.OptionsColumn.AllowFocus = False
        Me.colx902EditDate.OptionsColumn.ReadOnly = True
        '
        'colx903EditUser
        '
        Me.colx903EditUser.FieldName = "x903EditUser"
        Me.colx903EditUser.Name = "colx903EditUser"
        Me.colx903EditUser.OptionsColumn.AllowEdit = False
        Me.colx903EditUser.OptionsColumn.AllowFocus = False
        Me.colx903EditUser.OptionsColumn.ReadOnly = True
        '
        'BSSProdukte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.gcBSSProdukte)
        Me.Name = "BSSProdukte"
        Me.Size = New System.Drawing.Size(1143, 576)
        CType(Me.gcBSSProdukte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvBSSProdukte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gvBSSProdukte As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbssID_temp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBereich As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSort As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colArtID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colx5Artikelname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Zahl1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Zahl2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Zahl3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents JN1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents JN2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents droplistitemID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents droplisttext As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colx300Datum_intern As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colx301Zeit_intern As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVerarbeitungsstatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colx900CreateDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colx901CreateUser As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colx902EditDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colx903EditUser As DevExpress.XtraGrid.Columns.GridColumn
    Public WithEvents gcBSSProdukte As DevExpress.XtraGrid.GridControl
End Class
