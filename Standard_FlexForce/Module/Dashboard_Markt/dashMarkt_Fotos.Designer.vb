<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dashMarkt_Fotos
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
        Dim ContextButton5 As DevExpress.Utils.ContextButton = New DevExpress.Utils.ContextButton()
        Dim ContextButton6 As DevExpress.Utils.ContextButton = New DevExpress.Utils.ContextButton()
        Dim ContextButton7 As DevExpress.Utils.ContextButton = New DevExpress.Utils.ContextButton()
        Dim ContextButton8 As DevExpress.Utils.ContextButton = New DevExpress.Utils.ContextButton()
        Me.ImgSliderDash_Foto = New DevExpress.XtraEditors.Controls.ImageSlider()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.txtFotoAnzahl = New DevExpress.XtraEditors.TextEdit()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtFotoID = New DevExpress.XtraEditors.TextEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDateiname = New DevExpress.XtraEditors.TextEdit()
        Me.txtFotoSchluessel = New DevExpress.XtraEditors.TextEdit()
        Me.txtBezeichnung = New DevExpress.XtraEditors.TextEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.ImgSliderDash_Foto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.txtFotoAnzahl.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFotoID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateiname.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFotoSchluessel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBezeichnung.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImgSliderDash_Foto
        '
        ContextButton5.Id = New System.Guid("656bcbb6-a4c7-496c-bb7d-cc5021d4f13b")
        ContextButton5.Name = "cbtnKey"
        ContextButton5.Visibility = DevExpress.Utils.ContextItemVisibility.Hidden
        ContextButton6.Id = New System.Guid("875ac636-1ffc-424c-a4f6-9cbcb30121a1")
        ContextButton6.Name = "cbtnBez"
        ContextButton6.Visibility = DevExpress.Utils.ContextItemVisibility.Hidden
        ContextButton7.Id = New System.Guid("2f2ca529-87e9-43a5-b945-3232dd56ed96")
        ContextButton7.Name = "cbtnFile"
        ContextButton7.Visibility = DevExpress.Utils.ContextItemVisibility.Hidden
        ContextButton8.Id = New System.Guid("0a2d5917-2dbd-4c23-8452-0dfcc0ea1cb4")
        ContextButton8.Name = "cbtnFotoID"
        ContextButton8.Visibility = DevExpress.Utils.ContextItemVisibility.Hidden
        Me.ImgSliderDash_Foto.ContextButtons.Add(ContextButton5)
        Me.ImgSliderDash_Foto.ContextButtons.Add(ContextButton6)
        Me.ImgSliderDash_Foto.ContextButtons.Add(ContextButton7)
        Me.ImgSliderDash_Foto.ContextButtons.Add(ContextButton8)
        Me.ImgSliderDash_Foto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ImgSliderDash_Foto.LayoutMode = DevExpress.Utils.Drawing.ImageLayoutMode.ZoomInside
        Me.ImgSliderDash_Foto.Location = New System.Drawing.Point(0, 0)
        Me.ImgSliderDash_Foto.Name = "ImgSliderDash_Foto"
        Me.ImgSliderDash_Foto.ScrollButtonVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Me.ImgSliderDash_Foto.Size = New System.Drawing.Size(424, 286)
        Me.ImgSliderDash_Foto.TabIndex = 0
        Me.ImgSliderDash_Foto.Text = "ImageSlider1"
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Horizontal = False
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.ImgSliderDash_Foto)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.txtFotoAnzahl)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.Label5)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.txtFotoID)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.Label4)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.txtDateiname)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.txtFotoSchluessel)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.txtBezeichnung)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.Label3)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.Label2)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.Label1)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(424, 424)
        Me.SplitContainerControl1.SplitterPosition = 286
        Me.SplitContainerControl1.TabIndex = 1
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'txtFotoAnzahl
        '
        Me.txtFotoAnzahl.Location = New System.Drawing.Point(224, 82)
        Me.txtFotoAnzahl.Name = "txtFotoAnzahl"
        Me.txtFotoAnzahl.Properties.ReadOnly = True
        Me.txtFotoAnzahl.Size = New System.Drawing.Size(26, 20)
        Me.txtFotoAnzahl.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(179, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Anzahl"
        '
        'txtFotoID
        '
        Me.txtFotoID.Location = New System.Drawing.Point(88, 82)
        Me.txtFotoID.Name = "txtFotoID"
        Me.txtFotoID.Properties.ReadOnly = True
        Me.txtFotoID.Size = New System.Drawing.Size(65, 20)
        Me.txtFotoID.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(38, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Foto-ID"
        '
        'txtDateiname
        '
        Me.txtDateiname.Location = New System.Drawing.Point(88, 47)
        Me.txtDateiname.Name = "txtDateiname"
        Me.txtDateiname.Properties.ReadOnly = True
        Me.txtDateiname.Size = New System.Drawing.Size(273, 20)
        Me.txtDateiname.TabIndex = 5
        '
        'txtFotoSchluessel
        '
        Me.txtFotoSchluessel.Location = New System.Drawing.Point(88, 16)
        Me.txtFotoSchluessel.Name = "txtFotoSchluessel"
        Me.txtFotoSchluessel.Properties.ReadOnly = True
        Me.txtFotoSchluessel.Size = New System.Drawing.Size(28, 20)
        Me.txtFotoSchluessel.TabIndex = 4
        '
        'txtBezeichnung
        '
        Me.txtBezeichnung.Location = New System.Drawing.Point(198, 16)
        Me.txtBezeichnung.Name = "txtBezeichnung"
        Me.txtBezeichnung.Properties.ReadOnly = True
        Me.txtBezeichnung.Size = New System.Drawing.Size(163, 20)
        Me.txtBezeichnung.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Schlüssel"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(125, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Bezeichnung"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(50, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Datei"
        '
        'dashMarkt_Fotos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Name = "dashMarkt_Fotos"
        Me.Size = New System.Drawing.Size(424, 424)
        CType(Me.ImgSliderDash_Foto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.txtFotoAnzahl.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFotoID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateiname.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFotoSchluessel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBezeichnung.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ImgSliderDash_Foto As DevExpress.XtraEditors.Controls.ImageSlider
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents txtFotoAnzahl As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label5 As Label
    Friend WithEvents txtFotoID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDateiname As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtFotoSchluessel As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtBezeichnung As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
