<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserVerwaltung
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserVerwaltung))
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.SplitContainerControl2 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.gcAllUser = New DevExpress.XtraGrid.GridControl()
        Me.gvAllUser = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.gcUser = New DevExpress.XtraGrid.GridControl()
        Me.gvUser = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.SplitContainerControl3 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        Me.gcAktionen = New DevExpress.XtraGrid.GridControl()
        Me.gvAktionen = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.gcRechte = New DevExpress.XtraGrid.GridControl()
        Me.gvRechte = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.SplitContainerControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl2.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.gcAllUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvAllUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.gcUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl3.SuspendLayout()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.gcAktionen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvAktionen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.gcRechte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvRechte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Horizontal = False
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.SplitContainerControl2)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.SplitContainerControl3)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(1029, 586)
        Me.SplitContainerControl1.SplitterPosition = 303
        Me.SplitContainerControl1.TabIndex = 0
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'SplitContainerControl2
        '
        Me.SplitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl2.Name = "SplitContainerControl2"
        Me.SplitContainerControl2.Panel1.Controls.Add(Me.GroupControl2)
        Me.SplitContainerControl2.Panel1.Controls.Add(Me.GroupControl1)
        Me.SplitContainerControl2.Panel1.Text = "Panel1"
        Me.SplitContainerControl2.Panel2.Controls.Add(Me.RichTextBox1)
        Me.SplitContainerControl2.Panel2.Text = "Panel2"
        Me.SplitContainerControl2.Size = New System.Drawing.Size(1029, 303)
        Me.SplitContainerControl2.SplitterPosition = 695
        Me.SplitContainerControl2.TabIndex = 0
        Me.SplitContainerControl2.Text = "SplitContainerControl2"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.gcAllUser)
        Me.GroupControl2.Location = New System.Drawing.Point(450, 13)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(232, 273)
        Me.GroupControl2.TabIndex = 2
        Me.GroupControl2.Text = "alle Benutzer"
        '
        'gcAllUser
        '
        Me.gcAllUser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcAllUser.Location = New System.Drawing.Point(2, 21)
        Me.gcAllUser.MainView = Me.gvAllUser
        Me.gcAllUser.Name = "gcAllUser"
        Me.gcAllUser.Size = New System.Drawing.Size(228, 250)
        Me.gcAllUser.TabIndex = 1
        Me.gcAllUser.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvAllUser})
        '
        'gvAllUser
        '
        Me.gvAllUser.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn7})
        Me.gvAllUser.GridControl = Me.gcAllUser
        Me.gvAllUser.Name = "gvAllUser"
        Me.gvAllUser.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gvAllUser.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gvAllUser.OptionsBehavior.Editable = False
        Me.gvAllUser.OptionsSelection.CheckBoxSelectorColumnWidth = 30
        Me.gvAllUser.OptionsSelection.MultiSelect = True
        Me.gvAllUser.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.gvAllUser.OptionsView.ShowGroupPanel = False
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Name"
        Me.GridColumn7.FieldName = "Name"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 1
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.gcUser)
        Me.GroupControl1.Location = New System.Drawing.Point(15, 13)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(428, 273)
        Me.GroupControl1.TabIndex = 1
        Me.GroupControl1.Text = "Benutzer"
        '
        'gcUser
        '
        Me.gcUser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcUser.Location = New System.Drawing.Point(2, 21)
        Me.gcUser.MainView = Me.gvUser
        Me.gcUser.Name = "gcUser"
        Me.gcUser.Size = New System.Drawing.Size(424, 250)
        Me.gcUser.TabIndex = 0
        Me.gcUser.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvUser})
        '
        'gvUser
        '
        Me.gvUser.GridControl = Me.gcUser
        Me.gvUser.Name = "gvUser"
        Me.gvUser.OptionsView.ShowGroupPanel = False
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.SystemColors.Control
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Location = New System.Drawing.Point(7, 23)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(307, 277)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        '
        'SplitContainerControl3
        '
        Me.SplitContainerControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl3.Name = "SplitContainerControl3"
        Me.SplitContainerControl3.Panel1.Controls.Add(Me.GroupControl4)
        Me.SplitContainerControl3.Panel1.Controls.Add(Me.GroupControl3)
        Me.SplitContainerControl3.Panel1.Text = "Panel1"
        Me.SplitContainerControl3.Panel2.Text = "Panel2"
        Me.SplitContainerControl3.Size = New System.Drawing.Size(1029, 271)
        Me.SplitContainerControl3.SplitterPosition = 813
        Me.SplitContainerControl3.TabIndex = 0
        Me.SplitContainerControl3.Text = "SplitContainerControl3"
        '
        'GroupControl4
        '
        Me.GroupControl4.Controls.Add(Me.gcAktionen)
        Me.GroupControl4.Location = New System.Drawing.Point(463, 3)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(349, 250)
        Me.GroupControl4.TabIndex = 3
        Me.GroupControl4.Text = "Aktionen"
        '
        'gcAktionen
        '
        Me.gcAktionen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcAktionen.Location = New System.Drawing.Point(2, 21)
        Me.gcAktionen.MainView = Me.gvAktionen
        Me.gcAktionen.Name = "gcAktionen"
        Me.gcAktionen.Size = New System.Drawing.Size(345, 227)
        Me.gcAktionen.TabIndex = 1
        Me.gcAktionen.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvAktionen})
        '
        'gvAktionen
        '
        Me.gvAktionen.GridControl = Me.gcAktionen
        Me.gvAktionen.Name = "gvAktionen"
        Me.gvAktionen.OptionsBehavior.Editable = False
        Me.gvAktionen.OptionsSelection.CheckBoxSelectorColumnWidth = 30
        Me.gvAktionen.OptionsSelection.MultiSelect = True
        Me.gvAktionen.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.gvAktionen.OptionsView.ShowGroupPanel = False
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.gcRechte)
        Me.GroupControl3.Location = New System.Drawing.Point(15, 3)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(428, 250)
        Me.GroupControl3.TabIndex = 2
        Me.GroupControl3.Text = "Benutzerrechte"
        '
        'gcRechte
        '
        Me.gcRechte.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcRechte.Location = New System.Drawing.Point(2, 21)
        Me.gcRechte.MainView = Me.gvRechte
        Me.gcRechte.Name = "gcRechte"
        Me.gcRechte.Size = New System.Drawing.Size(424, 227)
        Me.gcRechte.TabIndex = 1
        Me.gcRechte.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvRechte})
        '
        'gvRechte
        '
        Me.gvRechte.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6})
        Me.gvRechte.GridControl = Me.gcRechte
        Me.gvRechte.Name = "gvRechte"
        Me.gvRechte.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.gvRechte.OptionsNavigation.AutoFocusNewRow = True
        Me.gvRechte.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Rechte_ID"
        Me.GridColumn1.FieldName = "STD_FF_Access_ID"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "UserID"
        Me.GridColumn2.FieldName = "STD_FF_ID"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Debitor"
        Me.GridColumn3.FieldName = "Debitorennummer"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Aktionnr."
        Me.GridColumn4.FieldName = "Aktionsnummer"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.AllowEdit = False
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Gültig von"
        Me.GridColumn5.FieldName = "GueltigVon"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 4
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Gültig bis"
        Me.GridColumn6.FieldName = "GueltigBis"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 5
        '
        'UserVerwaltung
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Name = "UserVerwaltung"
        Me.Size = New System.Drawing.Size(1029, 586)
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.SplitContainerControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl2.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.gcAllUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvAllUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.gcUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl3.ResumeLayout(False)
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        CType(Me.gcAktionen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvAktionen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.gcRechte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvRechte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents SplitContainerControl2 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents gcUser As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvUser As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gcAllUser As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvAllUser As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SplitContainerControl3 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents gcRechte As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvRechte As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gcAktionen As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvAktionen As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RichTextBox1 As RichTextBox
End Class
