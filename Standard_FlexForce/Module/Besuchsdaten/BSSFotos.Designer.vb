<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BSSFotos
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
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.gcBSSFotos = New DevExpress.XtraGrid.GridControl()
        Me.gvBSSFotos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.BSSFotoID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BSSFotoDebitor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BSSFotoAktion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BSSFotoMAID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BSSFotoADM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BSSFotoCID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BSSFotoBesuchsdatum = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BSSFotoDatei = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BSSFotoBezeichnung = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BSSFotoaktiv = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.gcBSSFotos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvBSSFotos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.gcBSSFotos)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.PictureEdit1)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(1321, 533)
        Me.SplitContainerControl1.SplitterPosition = 900
        Me.SplitContainerControl1.TabIndex = 0
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'gcBSSFotos
        '
        Me.gcBSSFotos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcBSSFotos.Location = New System.Drawing.Point(0, 0)
        Me.gcBSSFotos.MainView = Me.gvBSSFotos
        Me.gcBSSFotos.Name = "gcBSSFotos"
        Me.gcBSSFotos.Size = New System.Drawing.Size(900, 533)
        Me.gcBSSFotos.TabIndex = 0
        Me.gcBSSFotos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvBSSFotos})
        '
        'gvBSSFotos
        '
        Me.gvBSSFotos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.BSSFotoID, Me.BSSFotoDebitor, Me.BSSFotoAktion, Me.BSSFotoMAID, Me.BSSFotoADM, Me.BSSFotoCID, Me.BSSFotoBesuchsdatum, Me.BSSFotoDatei, Me.BSSFotoBezeichnung, Me.BSSFotoaktiv})
        Me.gvBSSFotos.GridControl = Me.gcBSSFotos
        Me.gvBSSFotos.Name = "gvBSSFotos"
        Me.gvBSSFotos.OptionsBehavior.Editable = False
        Me.gvBSSFotos.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect
        Me.gvBSSFotos.OptionsView.ColumnAutoWidth = False
        '
        'PictureEdit1
        '
        Me.PictureEdit1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureEdit1.Location = New System.Drawing.Point(0, 0)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.OptionsMask.MaskType = DevExpress.XtraEditors.Controls.PictureEditMaskType.RoundedRect
        Me.PictureEdit1.Properties.Padding = New System.Windows.Forms.Padding(10)
        Me.PictureEdit1.Properties.ShowMenu = False
        Me.PictureEdit1.Properties.ShowZoomSubMenu = DevExpress.Utils.DefaultBoolean.[True]
        Me.PictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        Me.PictureEdit1.Size = New System.Drawing.Size(416, 533)
        Me.PictureEdit1.TabIndex = 0
        '
        'BSSFotoID
        '
        Me.BSSFotoID.Caption = "BSSFotoID"
        Me.BSSFotoID.FieldName = "bssFotosID"
        Me.BSSFotoID.Name = "BSSFotoID"
        Me.BSSFotoID.Visible = True
        Me.BSSFotoID.VisibleIndex = 0
        '
        'BSSFotoDebitor
        '
        Me.BSSFotoDebitor.Caption = "Debitor"
        Me.BSSFotoDebitor.FieldName = "debitoren_nummer"
        Me.BSSFotoDebitor.Name = "BSSFotoDebitor"
        Me.BSSFotoDebitor.Visible = True
        Me.BSSFotoDebitor.VisibleIndex = 1
        '
        'BSSFotoAktion
        '
        Me.BSSFotoAktion.Caption = "Aktionsnr."
        Me.BSSFotoAktion.FieldName = "aktionsnummer"
        Me.BSSFotoAktion.Name = "BSSFotoAktion"
        Me.BSSFotoAktion.Visible = True
        Me.BSSFotoAktion.VisibleIndex = 2
        Me.BSSFotoAktion.Width = 40
        '
        'BSSFotoMAID
        '
        Me.BSSFotoMAID.Caption = "MA_ID"
        Me.BSSFotoMAID.FieldName = "maID"
        Me.BSSFotoMAID.Name = "BSSFotoMAID"
        Me.BSSFotoMAID.Visible = True
        Me.BSSFotoMAID.VisibleIndex = 3
        Me.BSSFotoMAID.Width = 50
        '
        'BSSFotoADM
        '
        Me.BSSFotoADM.Caption = "ADM_Name"
        Me.BSSFotoADM.FieldName = "ADM_Name"
        Me.BSSFotoADM.Name = "BSSFotoADM"
        Me.BSSFotoADM.Visible = True
        Me.BSSFotoADM.VisibleIndex = 4
        Me.BSSFotoADM.Width = 100
        '
        'BSSFotoCID
        '
        Me.BSSFotoCID.Caption = "ComberaID"
        Me.BSSFotoCID.FieldName = "x1combera_id"
        Me.BSSFotoCID.Name = "BSSFotoCID"
        Me.BSSFotoCID.Visible = True
        Me.BSSFotoCID.VisibleIndex = 5
        Me.BSSFotoCID.Width = 70
        '
        'BSSFotoBesuchsdatum
        '
        Me.BSSFotoBesuchsdatum.Caption = "Besuchsdatum"
        Me.BSSFotoBesuchsdatum.FieldName = "x2besuchsdatum"
        Me.BSSFotoBesuchsdatum.Name = "BSSFotoBesuchsdatum"
        Me.BSSFotoBesuchsdatum.Visible = True
        Me.BSSFotoBesuchsdatum.VisibleIndex = 6
        Me.BSSFotoBesuchsdatum.Width = 100
        '
        'BSSFotoDatei
        '
        Me.BSSFotoDatei.Caption = "Dateiname"
        Me.BSSFotoDatei.FieldName = "dateiname"
        Me.BSSFotoDatei.Name = "BSSFotoDatei"
        Me.BSSFotoDatei.Visible = True
        Me.BSSFotoDatei.VisibleIndex = 7
        Me.BSSFotoDatei.Width = 170
        '
        'BSSFotoBezeichnung
        '
        Me.BSSFotoBezeichnung.Caption = "Bezeichnung"
        Me.BSSFotoBezeichnung.FieldName = "bezeichnung"
        Me.BSSFotoBezeichnung.Name = "BSSFotoBezeichnung"
        Me.BSSFotoBezeichnung.Visible = True
        Me.BSSFotoBezeichnung.VisibleIndex = 8
        Me.BSSFotoBezeichnung.Width = 130
        '
        'BSSFotoaktiv
        '
        Me.BSSFotoaktiv.Caption = "aktiv"
        Me.BSSFotoaktiv.FieldName = "aktiv"
        Me.BSSFotoaktiv.Name = "BSSFotoaktiv"
        Me.BSSFotoaktiv.Visible = True
        Me.BSSFotoaktiv.VisibleIndex = 9
        Me.BSSFotoaktiv.Width = 40
        '
        'BSSFotos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Name = "BSSFotos"
        Me.Size = New System.Drawing.Size(1321, 533)
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.gcBSSFotos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvBSSFotos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents gcBSSFotos As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvBSSFotos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents BSSFotoID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BSSFotoDebitor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BSSFotoAktion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BSSFotoMAID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BSSFotoADM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BSSFotoCID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BSSFotoBesuchsdatum As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BSSFotoDatei As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BSSFotoBezeichnung As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BSSFotoaktiv As DevExpress.XtraGrid.Columns.GridColumn
End Class
