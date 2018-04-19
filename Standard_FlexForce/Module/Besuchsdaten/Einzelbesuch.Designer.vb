<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Einzelbesuch
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
        Me.SplitContainerControl2 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.SplitContainerControl3 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.BssProdukte1 = New Standard_FlexForce.BSSProdukte()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.GalleryControl1 = New DevExpress.XtraBars.Ribbon.GalleryControl()
        Me.GalleryControlClient1 = New DevExpress.XtraBars.Ribbon.GalleryControlClient()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.SplitContainerControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl2.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl3.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GalleryControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GalleryControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.SplitContainerControl2)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.GalleryControl1)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(1373, 737)
        Me.SplitContainerControl1.SplitterPosition = 1066
        Me.SplitContainerControl1.TabIndex = 0
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'SplitContainerControl2
        '
        Me.SplitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl2.Horizontal = False
        Me.SplitContainerControl2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl2.Name = "SplitContainerControl2"
        Me.SplitContainerControl2.Panel1.Controls.Add(Me.GroupControl1)
        Me.SplitContainerControl2.Panel1.Text = "Panel1"
        Me.SplitContainerControl2.Panel2.Controls.Add(Me.SplitContainerControl3)
        Me.SplitContainerControl2.Panel2.Text = "Panel2"
        Me.SplitContainerControl2.Size = New System.Drawing.Size(1066, 737)
        Me.SplitContainerControl2.SplitterPosition = 279
        Me.SplitContainerControl2.TabIndex = 0
        Me.SplitContainerControl2.Text = "SplitContainerControl2"
        '
        'GroupControl1
        '
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1066, 279)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Besuchsdaten"
        '
        'SplitContainerControl3
        '
        Me.SplitContainerControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl3.Horizontal = False
        Me.SplitContainerControl3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl3.Name = "SplitContainerControl3"
        Me.SplitContainerControl3.Panel1.Controls.Add(Me.GroupControl2)
        Me.SplitContainerControl3.Panel1.Text = "Panel1"
        Me.SplitContainerControl3.Panel2.Controls.Add(Me.GroupControl3)
        Me.SplitContainerControl3.Panel2.Text = "Panel2"
        Me.SplitContainerControl3.Size = New System.Drawing.Size(1066, 453)
        Me.SplitContainerControl3.SplitterPosition = 228
        Me.SplitContainerControl3.TabIndex = 0
        Me.SplitContainerControl3.Text = "SplitContainerControl3"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.BssProdukte1)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl2.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(1066, 228)
        Me.GroupControl2.TabIndex = 0
        Me.GroupControl2.Text = "Produkte"
        '
        'BssProdukte1
        '
        Me.BssProdukte1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BssProdukte1.Location = New System.Drawing.Point(2, 20)
        Me.BssProdukte1.Name = "BssProdukte1"
        Me.BssProdukte1.Size = New System.Drawing.Size(1062, 206)
        Me.BssProdukte1.TabIndex = 0
        '
        'GroupControl3
        '
        Me.GroupControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl3.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(1066, 220)
        Me.GroupControl3.TabIndex = 0
        Me.GroupControl3.Text = "variable Textfragen"
        '
        'GalleryControl1
        '
        Me.GalleryControl1.Controls.Add(Me.GalleryControlClient1)
        Me.GalleryControl1.DesignGalleryGroupIndex = 0
        Me.GalleryControl1.DesignGalleryItemIndex = 0
        Me.GalleryControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GalleryControl1.Location = New System.Drawing.Point(0, 0)
        Me.GalleryControl1.Name = "GalleryControl1"
        Me.GalleryControl1.Size = New System.Drawing.Size(302, 737)
        Me.GalleryControl1.TabIndex = 0
        Me.GalleryControl1.Text = "GalleryControl1"
        '
        'GalleryControlClient1
        '
        Me.GalleryControlClient1.GalleryControl = Me.GalleryControl1
        Me.GalleryControlClient1.Location = New System.Drawing.Point(2, 2)
        Me.GalleryControlClient1.Size = New System.Drawing.Size(281, 733)
        '
        'Einzelbesuch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Name = "Einzelbesuch"
        Me.Size = New System.Drawing.Size(1373, 737)
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.SplitContainerControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl2.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl3.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GalleryControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GalleryControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents SplitContainerControl2 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SplitContainerControl3 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents BssProdukte1 As BSSProdukte
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GalleryControl1 As DevExpress.XtraBars.Ribbon.GalleryControl
    Friend WithEvents GalleryControlClient1 As DevExpress.XtraBars.Ribbon.GalleryControlClient
End Class
