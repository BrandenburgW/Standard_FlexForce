<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BSS
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
        Me.gcBSS = New DevExpress.XtraGrid.GridControl()
        Me.gvBSS = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbssID_temp = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIMEI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBesuch_erfasst_durch = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colkundengruppe = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colx3Kein_Gespraech = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colx4gesprochen_mit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colx100Unterschrift = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colx101Zeit_Unterschrift = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colx102Besuchsinfo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colx103Neuanlage = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colx104Totmeldung = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colx105Tot_Grund = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colx200Datum_intern = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colx201Zeit_intern = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colx300Datum_intern = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colx301Zeit_intern = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colexport_am = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colexport_durch = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVerarbeitungsstatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colx900CreateDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colx901CreateUser = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colx902EditDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colx903EditUser = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.gcBSS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvBSS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gcBSS
        '
        Me.gcBSS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcBSS.Location = New System.Drawing.Point(0, 0)
        Me.gcBSS.MainView = Me.gvBSS
        Me.gcBSS.Name = "gcBSS"
        Me.gcBSS.Size = New System.Drawing.Size(1143, 576)
        Me.gcBSS.TabIndex = 0
        Me.gcBSS.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvBSS})
        '
        'gvBSS
        '
        Me.gvBSS.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.colbssID_temp, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.colIMEI, Me.colBesuch_erfasst_durch, Me.colkundengruppe, Me.colx3Kein_Gespraech, Me.colx4gesprochen_mit, Me.colx100Unterschrift, Me.colx101Zeit_Unterschrift, Me.colx102Besuchsinfo, Me.colx103Neuanlage, Me.colx104Totmeldung, Me.colx105Tot_Grund, Me.colx200Datum_intern, Me.colx201Zeit_intern, Me.colx300Datum_intern, Me.colx301Zeit_intern, Me.colexport_am, Me.colexport_durch, Me.colVerarbeitungsstatus, Me.colx900CreateDate, Me.colx901CreateUser, Me.colx902EditDate, Me.colx903EditUser})
        Me.gvBSS.GridControl = Me.gcBSS
        Me.gvBSS.Name = "gvBSS"
        Me.gvBSS.OptionsBehavior.Editable = False
        Me.gvBSS.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplace
        Me.gvBSS.OptionsView.ColumnAutoWidth = False
        Me.gvBSS.OptionsView.ShowAutoFilterRow = True
        Me.gvBSS.OptionsView.ShowFooter = True
        Me.gvBSS.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
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
        'colbssID_temp
        '
        Me.colbssID_temp.Caption = "BSSID_temp"
        Me.colbssID_temp.FieldName = "bssID_temp"
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
        'GridColumn4
        '
        Me.GridColumn4.Caption = "ComberaID"
        Me.GridColumn4.FieldName = "x1combera_id"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.AllowEdit = False
        Me.GridColumn4.OptionsColumn.AllowFocus = False
        Me.GridColumn4.OptionsColumn.ReadOnly = True
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 4
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
        Me.GridColumn5.VisibleIndex = 5
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
        Me.GridColumn6.VisibleIndex = 6
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
        'colIMEI
        '
        Me.colIMEI.FieldName = "IMEI"
        Me.colIMEI.Name = "colIMEI"
        Me.colIMEI.OptionsColumn.AllowEdit = False
        Me.colIMEI.OptionsColumn.AllowFocus = False
        Me.colIMEI.OptionsColumn.ReadOnly = True
        Me.colIMEI.Visible = True
        Me.colIMEI.VisibleIndex = 8
        '
        'colBesuch_erfasst_durch
        '
        Me.colBesuch_erfasst_durch.FieldName = "Besuch_erfasst_durch"
        Me.colBesuch_erfasst_durch.Name = "colBesuch_erfasst_durch"
        Me.colBesuch_erfasst_durch.OptionsColumn.AllowEdit = False
        Me.colBesuch_erfasst_durch.OptionsColumn.AllowFocus = False
        Me.colBesuch_erfasst_durch.OptionsColumn.ReadOnly = True
        Me.colBesuch_erfasst_durch.Visible = True
        Me.colBesuch_erfasst_durch.VisibleIndex = 9
        '
        'colkundengruppe
        '
        Me.colkundengruppe.FieldName = "kundengruppe"
        Me.colkundengruppe.Name = "colkundengruppe"
        Me.colkundengruppe.OptionsColumn.AllowEdit = False
        Me.colkundengruppe.OptionsColumn.AllowFocus = False
        Me.colkundengruppe.OptionsColumn.ReadOnly = True
        Me.colkundengruppe.Visible = True
        Me.colkundengruppe.VisibleIndex = 10
        '
        'colx3Kein_Gespraech
        '
        Me.colx3Kein_Gespraech.Caption = "Kein_Gespraech"
        Me.colx3Kein_Gespraech.FieldName = "x3Kein_Gespraech"
        Me.colx3Kein_Gespraech.Name = "colx3Kein_Gespraech"
        Me.colx3Kein_Gespraech.OptionsColumn.AllowEdit = False
        Me.colx3Kein_Gespraech.OptionsColumn.AllowFocus = False
        Me.colx3Kein_Gespraech.OptionsColumn.ReadOnly = True
        Me.colx3Kein_Gespraech.Visible = True
        Me.colx3Kein_Gespraech.VisibleIndex = 11
        '
        'colx4gesprochen_mit
        '
        Me.colx4gesprochen_mit.Caption = "gesprochen_mit"
        Me.colx4gesprochen_mit.FieldName = "x4gesprochen_mit"
        Me.colx4gesprochen_mit.Name = "colx4gesprochen_mit"
        Me.colx4gesprochen_mit.OptionsColumn.AllowEdit = False
        Me.colx4gesprochen_mit.OptionsColumn.AllowFocus = False
        Me.colx4gesprochen_mit.OptionsColumn.ReadOnly = True
        Me.colx4gesprochen_mit.Visible = True
        Me.colx4gesprochen_mit.VisibleIndex = 12
        '
        'colx100Unterschrift
        '
        Me.colx100Unterschrift.Caption = "Unterschrift"
        Me.colx100Unterschrift.FieldName = "x100Unterschrift"
        Me.colx100Unterschrift.Name = "colx100Unterschrift"
        Me.colx100Unterschrift.OptionsColumn.AllowEdit = False
        Me.colx100Unterschrift.OptionsColumn.AllowFocus = False
        Me.colx100Unterschrift.OptionsColumn.ReadOnly = True
        Me.colx100Unterschrift.Visible = True
        Me.colx100Unterschrift.VisibleIndex = 13
        '
        'colx101Zeit_Unterschrift
        '
        Me.colx101Zeit_Unterschrift.Caption = "Zeit_Unterschrift"
        Me.colx101Zeit_Unterschrift.FieldName = "x101Zeit_Unterschrift"
        Me.colx101Zeit_Unterschrift.Name = "colx101Zeit_Unterschrift"
        Me.colx101Zeit_Unterschrift.OptionsColumn.AllowEdit = False
        Me.colx101Zeit_Unterschrift.OptionsColumn.AllowFocus = False
        Me.colx101Zeit_Unterschrift.OptionsColumn.ReadOnly = True
        Me.colx101Zeit_Unterschrift.Visible = True
        Me.colx101Zeit_Unterschrift.VisibleIndex = 14
        '
        'colx102Besuchsinfo
        '
        Me.colx102Besuchsinfo.Caption = "Besuchsinfo"
        Me.colx102Besuchsinfo.FieldName = "x102Besuchsinfo"
        Me.colx102Besuchsinfo.Name = "colx102Besuchsinfo"
        Me.colx102Besuchsinfo.OptionsColumn.AllowEdit = False
        Me.colx102Besuchsinfo.OptionsColumn.AllowFocus = False
        Me.colx102Besuchsinfo.OptionsColumn.ReadOnly = True
        Me.colx102Besuchsinfo.Visible = True
        Me.colx102Besuchsinfo.VisibleIndex = 15
        '
        'colx103Neuanlage
        '
        Me.colx103Neuanlage.Caption = "Neuanlage"
        Me.colx103Neuanlage.FieldName = "x103Neuanlage"
        Me.colx103Neuanlage.Name = "colx103Neuanlage"
        Me.colx103Neuanlage.OptionsColumn.AllowEdit = False
        Me.colx103Neuanlage.OptionsColumn.AllowFocus = False
        Me.colx103Neuanlage.OptionsColumn.ReadOnly = True
        Me.colx103Neuanlage.Visible = True
        Me.colx103Neuanlage.VisibleIndex = 16
        '
        'colx104Totmeldung
        '
        Me.colx104Totmeldung.Caption = "Totmeldung"
        Me.colx104Totmeldung.FieldName = "x104Totmeldung"
        Me.colx104Totmeldung.Name = "colx104Totmeldung"
        Me.colx104Totmeldung.OptionsColumn.AllowEdit = False
        Me.colx104Totmeldung.OptionsColumn.AllowFocus = False
        Me.colx104Totmeldung.OptionsColumn.ReadOnly = True
        Me.colx104Totmeldung.Visible = True
        Me.colx104Totmeldung.VisibleIndex = 17
        '
        'colx105Tot_Grund
        '
        Me.colx105Tot_Grund.Caption = "Tot_Grund"
        Me.colx105Tot_Grund.FieldName = "x105Tot_Grund"
        Me.colx105Tot_Grund.Name = "colx105Tot_Grund"
        Me.colx105Tot_Grund.OptionsColumn.AllowEdit = False
        Me.colx105Tot_Grund.OptionsColumn.AllowFocus = False
        Me.colx105Tot_Grund.OptionsColumn.ReadOnly = True
        Me.colx105Tot_Grund.Visible = True
        Me.colx105Tot_Grund.VisibleIndex = 18
        '
        'colx200Datum_intern
        '
        Me.colx200Datum_intern.FieldName = "x200Datum_intern"
        Me.colx200Datum_intern.Name = "colx200Datum_intern"
        Me.colx200Datum_intern.OptionsColumn.AllowEdit = False
        Me.colx200Datum_intern.OptionsColumn.AllowFocus = False
        Me.colx200Datum_intern.OptionsColumn.ReadOnly = True
        '
        'colx201Zeit_intern
        '
        Me.colx201Zeit_intern.FieldName = "x201Zeit_intern"
        Me.colx201Zeit_intern.Name = "colx201Zeit_intern"
        Me.colx201Zeit_intern.OptionsColumn.AllowEdit = False
        Me.colx201Zeit_intern.OptionsColumn.AllowFocus = False
        Me.colx201Zeit_intern.OptionsColumn.ReadOnly = True
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
        'colexport_am
        '
        Me.colexport_am.FieldName = "export_am"
        Me.colexport_am.Name = "colexport_am"
        Me.colexport_am.OptionsColumn.AllowEdit = False
        Me.colexport_am.OptionsColumn.AllowFocus = False
        Me.colexport_am.OptionsColumn.ReadOnly = True
        Me.colexport_am.Visible = True
        Me.colexport_am.VisibleIndex = 19
        '
        'colexport_durch
        '
        Me.colexport_durch.FieldName = "export_durch"
        Me.colexport_durch.Name = "colexport_durch"
        Me.colexport_durch.OptionsColumn.AllowEdit = False
        Me.colexport_durch.OptionsColumn.AllowFocus = False
        Me.colexport_durch.OptionsColumn.ReadOnly = True
        Me.colexport_durch.Visible = True
        Me.colexport_durch.VisibleIndex = 20
        '
        'colVerarbeitungsstatus
        '
        Me.colVerarbeitungsstatus.FieldName = "Verarbeitungsstatus"
        Me.colVerarbeitungsstatus.Name = "colVerarbeitungsstatus"
        Me.colVerarbeitungsstatus.OptionsColumn.AllowEdit = False
        Me.colVerarbeitungsstatus.OptionsColumn.AllowFocus = False
        Me.colVerarbeitungsstatus.OptionsColumn.ReadOnly = True
        Me.colVerarbeitungsstatus.Visible = True
        Me.colVerarbeitungsstatus.VisibleIndex = 21
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
        'BSS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.gcBSS)
        Me.Name = "BSS"
        Me.Size = New System.Drawing.Size(1143, 576)
        CType(Me.gcBSS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvBSS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gcBSS As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvBSS As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbssID_temp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIMEI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBesuch_erfasst_durch As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colkundengruppe As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colx3Kein_Gespraech As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colx4gesprochen_mit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colx100Unterschrift As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colx101Zeit_Unterschrift As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colx102Besuchsinfo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colx103Neuanlage As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colx104Totmeldung As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colx105Tot_Grund As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colx200Datum_intern As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colx201Zeit_intern As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colx300Datum_intern As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colx301Zeit_intern As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colexport_am As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colexport_durch As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVerarbeitungsstatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colx900CreateDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colx901CreateUser As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colx902EditDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colx903EditUser As DevExpress.XtraGrid.Columns.GridColumn
End Class
