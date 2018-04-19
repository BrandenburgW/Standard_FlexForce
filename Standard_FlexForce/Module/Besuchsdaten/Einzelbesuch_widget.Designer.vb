<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Einzelbesuch_widget
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Einzelbesuch_widget))
        Me.DocumentManager1 = New DevExpress.XtraBars.Docking2010.DocumentManager(Me.components)
        Me.WidgetView1 = New DevExpress.XtraBars.Docking2010.Views.Widget.WidgetView(Me.components)
        Me.Marktdaten = New DevExpress.XtraBars.Docking2010.Views.Widget.Document(Me.components)
        Me.Besuchsfotos = New DevExpress.XtraBars.Docking2010.Views.Widget.Document(Me.components)
        Me.Fragen = New DevExpress.XtraBars.Docking2010.Views.Widget.Document(Me.components)
        Me.Bereich1 = New DevExpress.XtraBars.Docking2010.Views.Widget.Document(Me.components)
        Me.StackGroup1 = New DevExpress.XtraBars.Docking2010.Views.Widget.StackGroup(Me.components)
        Me.StackGroup2 = New DevExpress.XtraBars.Docking2010.Views.Widget.StackGroup(Me.components)
        CType(Me.DocumentManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WidgetView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Marktdaten, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Besuchsfotos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fragen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bereich1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StackGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StackGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DocumentManager1
        '
        Me.DocumentManager1.ContainerControl = Me
        Me.DocumentManager1.View = Me.WidgetView1
        Me.DocumentManager1.ViewCollection.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseView() {Me.WidgetView1})
        '
        'WidgetView1
        '
        Me.WidgetView1.Documents.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseDocument() {Me.Marktdaten, Me.Besuchsfotos, Me.Fragen, Me.Bereich1})
        Me.WidgetView1.RootContainer.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.WidgetView1.StackGroups.AddRange(New DevExpress.XtraBars.Docking2010.Views.Widget.StackGroup() {Me.StackGroup1, Me.StackGroup2})
        '
        'Marktdaten
        '
        Me.Marktdaten.AppearanceActiveCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Marktdaten.AppearanceActiveCaption.Options.UseBackColor = True
        Me.Marktdaten.AppearanceCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Marktdaten.AppearanceCaption.Options.UseBackColor = True
        Me.Marktdaten.Caption = "HDB"
        Me.Marktdaten.ControlName = "document1"
        Me.Marktdaten.FreeLayoutWidth.UnitValue = 2.0R
        Me.Marktdaten.Height = 600
        Me.Marktdaten.ImageOptions.Image = CType(resources.GetObject("Marktdaten.ImageOptions.Image"), System.Drawing.Image)
        Me.Marktdaten.Properties.AllowClose = DevExpress.Utils.DefaultBoolean.[False]
        Me.Marktdaten.Properties.AllowDragging = DevExpress.Utils.DefaultBoolean.[False]
        Me.Marktdaten.Properties.AllowResize = DevExpress.Utils.DefaultBoolean.[False]
        '
        'Besuchsfotos
        '
        Me.Besuchsfotos.AppearanceActiveCaption.BackColor = System.Drawing.Color.LavenderBlush
        Me.Besuchsfotos.AppearanceActiveCaption.Options.UseBackColor = True
        Me.Besuchsfotos.AppearanceCaption.BackColor = System.Drawing.Color.LavenderBlush
        Me.Besuchsfotos.AppearanceCaption.Options.UseBackColor = True
        Me.Besuchsfotos.Caption = "Foto"
        Me.Besuchsfotos.ControlName = "document2"
        Me.Besuchsfotos.Height = 500
        Me.Besuchsfotos.ImageOptions.Image = CType(resources.GetObject("Besuchsfotos.ImageOptions.Image"), System.Drawing.Image)
        Me.Besuchsfotos.Properties.AllowClose = DevExpress.Utils.DefaultBoolean.[False]
        '
        'Fragen
        '
        Me.Fragen.AppearanceActiveCaption.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Fragen.AppearanceActiveCaption.Options.UseBackColor = True
        Me.Fragen.AppearanceCaption.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Fragen.AppearanceCaption.Options.UseBackColor = True
        Me.Fragen.Caption = "variable Fragen"
        Me.Fragen.ControlName = "document3"
        Me.Fragen.ImageOptions.Image = CType(resources.GetObject("Fragen.ImageOptions.Image"), System.Drawing.Image)
        Me.Fragen.Properties.AllowClose = DevExpress.Utils.DefaultBoolean.[False]
        '
        'Bereich1
        '
        Me.Bereich1.AppearanceActiveCaption.BackColor = System.Drawing.Color.Moccasin
        Me.Bereich1.AppearanceActiveCaption.Options.UseBackColor = True
        Me.Bereich1.AppearanceCaption.BackColor = System.Drawing.Color.Moccasin
        Me.Bereich1.AppearanceCaption.Options.UseBackColor = True
        Me.Bereich1.Caption = "Bereich1"
        Me.Bereich1.ControlName = "document4"
        Me.Bereich1.ImageOptions.Image = CType(resources.GetObject("Bereich1.ImageOptions.Image"), System.Drawing.Image)
        Me.Bereich1.Properties.AllowClose = DevExpress.Utils.DefaultBoolean.[False]
        '
        'StackGroup1
        '
        Me.StackGroup1.Items.AddRange(New DevExpress.XtraBars.Docking2010.Views.Widget.Document() {Me.Marktdaten, Me.Bereich1})
        Me.StackGroup1.Length.UnitValue = 2.0R
        '
        'StackGroup2
        '
        Me.StackGroup2.Items.AddRange(New DevExpress.XtraBars.Docking2010.Views.Widget.Document() {Me.Besuchsfotos, Me.Fragen})
        '
        'Einzelbesuch_widget
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Name = "Einzelbesuch_widget"
        Me.Size = New System.Drawing.Size(895, 550)
        CType(Me.DocumentManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WidgetView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Marktdaten, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Besuchsfotos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fragen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bereich1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StackGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StackGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DocumentManager1 As DevExpress.XtraBars.Docking2010.DocumentManager
    Friend WithEvents WidgetView1 As DevExpress.XtraBars.Docking2010.Views.Widget.WidgetView
    Friend WithEvents Marktdaten As DevExpress.XtraBars.Docking2010.Views.Widget.Document
    Friend WithEvents Besuchsfotos As DevExpress.XtraBars.Docking2010.Views.Widget.Document
    Friend WithEvents Fragen As DevExpress.XtraBars.Docking2010.Views.Widget.Document
    Friend WithEvents Bereich1 As DevExpress.XtraBars.Docking2010.Views.Widget.Document
    Friend WithEvents StackGroup1 As DevExpress.XtraBars.Docking2010.Views.Widget.StackGroup
    Friend WithEvents StackGroup2 As DevExpress.XtraBars.Docking2010.Views.Widget.StackGroup
End Class
