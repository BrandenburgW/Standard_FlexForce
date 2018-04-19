Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports DevExpress.XtraBars.Docking2010
Imports DevExpress.XtraBars.Docking2010.Views.Widget
Imports DevExpress.XtraEditors
Imports DevExpress.XtraBars.Docking2010.Views

Public Class Einzelbesuch_widget

    Private sCID As Integer

    Public Sub New()
        InitializeComponent()
        AddHandler Me.WidgetView1.QueryControl, AddressOf WidgetView1_QueryControl
    End Sub
    Private Sub Einzelbesuch_widget_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub
    Public Sub ladeDaten(CID As Integer)

        sCID = CInt(frmMain.BarEditItemBSSCID.EditValue)


        '   doc1.(sCID)

    End Sub


    ' Assigning a required content for each auto generated Document
    Sub WidgetView1_QueryControl(sender As Object, e As Views.QueryControlEventArgs)

        If e.Document Is Marktdaten Then
            e.Control = New Standard_FlexForce.dashMarkt_HDB()
            '   For Each o In WidgetView1.Documents
            '    Debug.Print(o.ControlTypeName)
            'Dim o = WidgetView1.Documents
            '  Next


        End If
        If e.Document Is Besuchsfotos Then
            e.Control = New Standard_FlexForce.dashMarkt_Fotos()
        End If
        If e.Document Is Fragen Then
            e.Control = New Standard_FlexForce.dashMarkt_Fragen()
        End If
        If e.Document Is Bereich1 Then
            e.Control = New Standard_FlexForce.dashMarkt_Produkte()
        End If
        If e.Control Is Nothing Then
            e.Control = New System.Windows.Forms.Control()
        End If
    End Sub

End Class


