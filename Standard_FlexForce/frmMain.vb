Imports DevExpress.XtraEditors
Imports DevExpress.XtraBars.Docking2010.Views
Imports DevExpress.XtraBars.Docking2010.Views.Tabbed
Imports DevExpress.XtraBars.Docking2010.Views.Widget

Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Navigation
Imports DevExpress.XtraBars.Docking2010
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraGrid.Views

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
Partial Public Class frmMain

    Private ArtikelstammClass As Artikelstamm = Nothing
    Private KundengruppenClass As Kundengruppen = Nothing
    Private GebieteClass As Gebiete = Nothing
    'Private HDBUserClass As HDBUser = Nothing
    'Private FotokategorienUserClass As FotokategorienUser = Nothing

    'Private FragenUserClass As FragenUser = Nothing

    Public BSSSingleUserClass As Einzelbesuch_widget = Nothing
    'Private BSSSingleHDBClass As dashMarkt_HDB = Nothing
    Private BSSClass As BSS = Nothing
    Private BSSProdUserClass As BSSProdukte = Nothing
    Private BSSTXTUserClass As BSSTXT = Nothing
    Private BSSFotoUserClass As BSSFotos = Nothing
    'Private EinwahlUserClass As EinwahlUser = Nothing

    Private UserAccessUserClass As UserVerwaltung = Nothing


    Public Sub New()
        InitializeComponent()

        accordionControl.SelectedElement = Nothing    'AccordionControlArtikelstamm

        Dim Nutzung() As String = Split(Settings.Default.Rechte, ";")
        Dim RechteBeschreibung As String = ""

        For Each r In Nutzung
            Dim rRechte() As String = Split(r, "|")
            If rRechte(0) = RECHTE Then
                RechteBeschreibung = rRechte(1)
            End If
        Next

        Select Case RECHTE
            Case "Superuser"
                accordionControl.Elements.Item("AccordionControlReporting").Visible = True
                accordionControl.Elements.Item("AccordionControlAdmin").Visible = True
                accordionControl.Elements.Item("AccordionControlAdmin").Expanded = True
            Case "Admin"
                accordionControl.Elements.Item("AccordionControlReporting").Visible = True
        End Select

        BarStaticItemAktion.Caption = "Login: " & USERNAME & " (" & RechteBeschreibung & ") - Aktion: " & AKTION & " - Debitor: " & DEBITOR & " - Aktionsnr.: " & AKTIONSNR

    End Sub

    Private Sub CreateArtikelstamm(o As AccordionControlElement)
        Dim doc As BaseDocument

        accordionControl.SelectedElement = o
        Application.DoEvents()

        If Not Me.WaitFormManager.IsSplashFormVisible Then
            Me.WaitFormManager.ShowWaitForm()
            Me.WaitFormManager.SetWaitFormCaption("Lade " & o.Text)
        End If

        If IsNothing(ArtikelstammClass) Then
            ArtikelstammClass = New Artikelstamm
            ArtikelstammClass.Dock = DockStyle.Fill
            ArtikelstammClass.Name = o.Text

            doc = tabbedView.AddDocument(ArtikelstammClass)
            doc.Caption = o.Text
            doc.ImageOptions.Image = o.ImageOptions.Image
            'doc.Form.MinimumSize = New Size(600, 800)
            'doc.Form.MaximumSize = New Size(800, 900)

            tabbedView.ActivateDocument(ArtikelstammClass)
        Else
            tabbedView.ActivateDocument(ArtikelstammClass)
        End If

        If Me.WaitFormManager.IsSplashFormVisible Then
            Me.WaitFormManager.CloseWaitForm()
        End If


    End Sub

    Private Sub CreateKGR(o As AccordionControlElement)
        Dim doc As BaseDocument

        accordionControl.SelectedElement = o
        Application.DoEvents()

        If Not Me.WaitFormManager.IsSplashFormVisible Then
            Me.WaitFormManager.ShowWaitForm()
            Me.WaitFormManager.SetWaitFormCaption("Lade " & o.Text)
        End If

        If IsNothing(KundengruppenClass) Then
            KundengruppenClass = New Kundengruppen
            KundengruppenClass.Dock = DockStyle.Fill
            KundengruppenClass.Name = o.Text

            doc = tabbedView.AddDocument(KundengruppenClass)
            doc.Caption = o.Text
            doc.ImageOptions.Image = o.ImageOptions.Image
            'doc.Form.MinimumSize = New Size(600, 800)
            'doc.Form.MaximumSize = New Size(800, 900)

            tabbedView.ActivateDocument(KundengruppenClass)
        Else
            tabbedView.ActivateDocument(KundengruppenClass)
        End If

        If Me.WaitFormManager.IsSplashFormVisible Then
            Me.WaitFormManager.CloseWaitForm()
        End If


    End Sub
    Private Sub CreateGebiete(o As AccordionControlElement)
        Dim doc As BaseDocument

        accordionControl.SelectedElement = o
        Application.DoEvents()

        If Not Me.WaitFormManager.IsSplashFormVisible Then
            Me.WaitFormManager.ShowWaitForm()
            Me.WaitFormManager.SetWaitFormCaption("Lade " & o.Text)
        End If

        If IsNothing(GebieteClass) Then
            GebieteClass = New Gebiete
            GebieteClass.Dock = DockStyle.Fill
            GebieteClass.Name = o.Text

            doc = tabbedView.AddDocument(GebieteClass)
            doc.Caption = o.Text
            doc.ImageOptions.Image = o.ImageOptions.Image
            'doc.Form.MinimumSize = New Size(600, 800)
            'doc.Form.MaximumSize = New Size(800, 900)

            tabbedView.ActivateDocument(GebieteClass)
        Else
            tabbedView.ActivateDocument(GebieteClass)
        End If

        If Me.WaitFormManager.IsSplashFormVisible Then
            Me.WaitFormManager.CloseWaitForm()
        End If


    End Sub

    Private Sub CreateBSSSingle(o As AccordionControlElement)
        Dim doc As BaseDocument

        accordionControl.SelectedElement = o
        Application.DoEvents()

        If Not Me.WaitFormManager.IsSplashFormVisible Then
            Me.WaitFormManager.ShowWaitForm()
            Me.WaitFormManager.SetWaitFormCaption("Lade " & o.Text)
        End If

        If IsNothing(BSSSingleUserClass) Then
            BSSSingleUserClass = New Einzelbesuch_widget
            BSSSingleUserClass.Dock = DockStyle.Fill
            BSSSingleUserClass.Name = o.Text

            doc = tabbedView.AddDocument(BSSSingleUserClass)
            doc.Caption = o.Text
            doc.ImageOptions.Image = o.ImageOptions.Image
            'doc.Form.MinimumSize = New Size(600, 800)
            'doc.Form.MaximumSize = New Size(800, 900)

            tabbedView.ActivateDocument(BSSSingleUserClass)
        Else
            tabbedView.ActivateDocument(BSSSingleUserClass)
        End If

        If Me.WaitFormManager.IsSplashFormVisible Then
            Me.WaitFormManager.CloseWaitForm()
        End If


    End Sub
    Private Sub CreateBSS(o As AccordionControlElement)
        Dim doc As BaseDocument

        accordionControl.SelectedElement = o
        Application.DoEvents()

        If Not Me.WaitFormManager.IsSplashFormVisible Then
            Me.WaitFormManager.ShowWaitForm()
            Me.WaitFormManager.SetWaitFormCaption("Lade " & o.Text)
        End If

        If IsNothing(BSSClass) Then
            BSSClass = New BSS
            BSSClass.Dock = DockStyle.Fill
            BSSClass.Name = o.Text

            doc = tabbedView.AddDocument(BSSClass)
            doc.Caption = o.Text
            doc.ImageOptions.Image = o.ImageOptions.Image
            'doc.Form.MinimumSize = New Size(600, 800)
            'doc.Form.MaximumSize = New Size(800, 900)

            tabbedView.ActivateDocument(BSSClass)
        Else
            tabbedView.ActivateDocument(BSSClass)
        End If

        If Me.WaitFormManager.IsSplashFormVisible Then
            Me.WaitFormManager.CloseWaitForm()
        End If


    End Sub

    Private Sub CreateBSSProd(o As AccordionControlElement)
        Dim doc As BaseDocument

        accordionControl.SelectedElement = o
        Application.DoEvents()

        If Not Me.WaitFormManager.IsSplashFormVisible Then
            Me.WaitFormManager.ShowWaitForm()
            Me.WaitFormManager.SetWaitFormCaption("Lade " & o.Text)
        End If

        If IsNothing(BSSProdUserClass) Then
            BSSProdUserClass = New BSSProdukte
            BSSProdUserClass.Dock = DockStyle.Fill
            BSSProdUserClass.Name = o.Text

            doc = tabbedView.AddDocument(BSSProdUserClass)
            doc.Caption = o.Text
            doc.ImageOptions.Image = o.ImageOptions.Image
            'doc.Form.MinimumSize = New Size(600, 800)
            'doc.Form.MaximumSize = New Size(800, 900)

        Else
            tabbedView.ActivateDocument(BSSProdUserClass)
        End If

        If Me.WaitFormManager.IsSplashFormVisible Then
            Me.WaitFormManager.CloseWaitForm()
        End If


    End Sub

    Private Sub CreateBSSTXT(o As AccordionControlElement)
        Dim doc As BaseDocument

        accordionControl.SelectedElement = o
        Application.DoEvents()

        If Not Me.WaitFormManager.IsSplashFormVisible Then
            Me.WaitFormManager.ShowWaitForm()
            Me.WaitFormManager.SetWaitFormCaption("Lade " & o.Text)
        End If

        If IsNothing(BSSTXTUserClass) Then
            BSSTXTUserClass = New BSSTXT
            BSSTXTUserClass.Dock = DockStyle.Fill
            BSSTXTUserClass.Name = o.Text

            doc = tabbedView.AddDocument(BSSTXTUserClass)
            doc.Caption = o.Text
            doc.ImageOptions.Image = o.ImageOptions.Image
            'doc.Form.MinimumSize = New Size(600, 800)
            'doc.Form.MaximumSize = New Size(800, 900)

            tabbedView.ActivateDocument(BSSTXTUserClass)
        Else
            tabbedView.ActivateDocument(BSSTXTUserClass)
        End If

        If Me.WaitFormManager.IsSplashFormVisible Then
            Me.WaitFormManager.CloseWaitForm()
        End If


    End Sub

    Private Sub CreateBSSFotos(o As AccordionControlElement)
        Dim doc As BaseDocument

        accordionControl.SelectedElement = o
        Application.DoEvents()

        If Not Me.WaitFormManager.IsSplashFormVisible Then
            Me.WaitFormManager.ShowWaitForm()
            Me.WaitFormManager.SetWaitFormCaption("Lade " & o.Text)
        End If

        If IsNothing(BSSFotoUserClass) Then
            BSSFotoUserClass = New BSSFotos
            BSSFotoUserClass.Dock = DockStyle.Fill
            BSSFotoUserClass.Name = o.Text

            doc = tabbedView.AddDocument(BSSFotoUserClass)
            doc.Caption = o.Text
            doc.ImageOptions.Image = o.ImageOptions.Image
            'doc.Form.MinimumSize = New Size(600, 800)
            'doc.Form.MaximumSize = New Size(800, 900)

            tabbedView.ActivateDocument(BSSFotoUserClass)

        Else
            tabbedView.ActivateDocument(BSSFotoUserClass)
        End If

        If Me.WaitFormManager.IsSplashFormVisible Then
            Me.WaitFormManager.CloseWaitForm()
        End If


    End Sub

    Private Sub CreateUserAdmin(o As AccordionControlElement)
        Dim doc As BaseDocument

        accordionControl.SelectedElement = o
        Application.DoEvents()

        If Not Me.WaitFormManager.IsSplashFormVisible Then
            Me.WaitFormManager.ShowWaitForm()
            Me.WaitFormManager.SetWaitFormCaption("Lade " & o.Text)
        End If

        If IsNothing(UserAccessUserClass) Then
            UserAccessUserClass = New UserVerwaltung
            UserAccessUserClass.Dock = DockStyle.Fill
            UserAccessUserClass.Name = o.Text

            doc = tabbedView.AddDocument(UserAccessUserClass)
            doc.Caption = o.Text
            doc.ImageOptions.Image = o.ImageOptions.Image
            'doc.Form.MinimumSize = New Size(600, 800)
            'doc.Form.MaximumSize = New Size(800, 900)

            tabbedView.ActivateDocument(UserAccessUserClass)
        Else
            tabbedView.ActivateDocument(UserAccessUserClass)
        End If

        If Me.WaitFormManager.IsSplashFormVisible Then
            Me.WaitFormManager.CloseWaitForm()
        End If


    End Sub
    Private Sub accordionControl_SelectedElementChanged(ByVal sender As Object, ByVal e As SelectedElementChangedEventArgs) Handles accordionControl.SelectedElementChanged

        Dim userControl As New XtraUserControl

        If e.Element Is Nothing Then
            Return
        End If

        Select Case e.Element.Text
            Case "Artikelstamm"
                CreateArtikelstamm(AccordionControlArtikelstamm)
            Case "Kundengruppen"
                CreateKGR(AccordionControlKGR)
            Case "Gebiete"
                CreateGebiete(AccordionControlGebiete)
        '    Case "Handelsdatenbank"
        '        userControl = HDBUserControl
        '    Case "Fotokategorien"
        '        userControl = FotokategorienUserControl
        '    Case "Fragen"
        '        userControl = FragenUserControl
            Case "Einzelbesuch"
                CreateBSSSingle(AccordionControlEinzelbesuch)
            Case "Besuche"
                'userControl = BSSUserControl)
                CreateBSS(AccordionControlBesuche)
            Case "Produkte"
                CreateBSSProd(AccordionControlBSSProdukte)
            Case "variable Fragen"
                CreateBSSTXT(AccordionControlBSSTXT)
            Case "Fotos"
                CreateBSSFotos(AccordionControlBSSFoto)
                '    Case "Einwahlzeit"
                '        userControl = EinwahlUserControl
            Case "Anwenderverwaltung"
                CreateUserAdmin(AccordionControlAdmin)
        End Select

    End Sub

    Private Sub tabbedView_DocumentClosed(ByVal sender As Object, ByVal e As DocumentEventArgs) Handles tabbedView.DocumentClosed

        ArtikelstammClass = Nothing
        KundengruppenClass = Nothing
        GebieteClass = Nothing
        'HDBUserClass = Nothing
        'FotokategorienUserClass = Nothing
        'FragenUserClass = Nothing


        BSSClass = Nothing
        BSSSingleUserClass = Nothing
        BSSClass = Nothing
        BSSProdUserClass = Nothing
        BSSTXTUserClass = Nothing
        BSSFotoUserClass = Nothing
        'EinwahlUserClass = Nothing

        UserAccessUserClass = Nothing

        If tabbedView.Documents.Count = 0 Then removeTopButtons()

    End Sub
    Private Sub tabbedView_DocumentActivated(sender As Object, e As DocumentEventArgs) Handles tabbedView.DocumentActivated

        removeTopButtons()

        Select Case e.Document.Caption
            Case "Artikelstamm"
                RibbonPageGroupArtikelstamm.Visible = True
            Case "Kundengruppen"
            Case "Gebiete"
            Case "Handelsdatenbank"
            Case "Fotokategorien"
            Case "Fragen"
            Case "Einzelbesuch"
                RibbonPageGroupEinzelbesuch.Visible = True
            Case "Besuche"
                RibbonPageGroupBSS.Visible = True

            Case "Produkte"
                RibbonPageGroupBSSProdukte.Visible = True
            Case "variable Fragen"
                RibbonPageGroupFragen.Visible = True
            Case "Fotos"
                RibbonPageGroupBSSFotos.Visible = True
            Case "Einwahlzeit"
            Case "Anwenderverwaltung"
        End Select

    End Sub
    Private Sub removeTopButtons()
        For Each pag As RibbonPage In ribbonControl.Pages
            For Each pagGroup In pag.Groups
                pagGroup.visible = False
            Next
        Next
        RibbonPageGroupMain.Visible = True
    End Sub

    Private Sub BarButtonItemExit_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItemExit.ItemClick

        Dim ans = MsgBox("Programm wirklich beenden?", vbYesNo, "Programmende")
        If ans = vbYes Then
            Me.Close()
            End
        End If

    End Sub

    Private Sub BarButtonItemLogOff_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItemLogOff.ItemClick

        Dim ans = MsgBox("Abmelden und mit anderer Aktion anmelden?", vbYesNo, "Abmelden")
        If ans = vbYes Then
            documentManager.View.Controller.CloseAll()
            Me.Hide()
            LoginForm.Show()
        End If

    End Sub


    Private Sub AccordionControlArtikelstamm_Click(sender As Object, e As EventArgs) Handles AccordionControlArtikelstamm.Click

        CreateArtikelstamm(AccordionControlArtikelstamm)

    End Sub
    Private Sub AccordionControlKGR_Click(sender As Object, e As EventArgs) Handles AccordionControlKGR.Click

        CreateKGR(AccordionControlKGR)

    End Sub
    Private Sub AccordionControlGebiete_Click(sender As Object, e As EventArgs) Handles AccordionControlGebiete.Click

        CreateGebiete(AccordionControlGebiete)

    End Sub

    Private Sub AccordionControlEinzelbesuch_Click(sender As Object, e As EventArgs) Handles AccordionControlEinzelbesuch.Click

        CreateBSSSingle(AccordionControlEinzelbesuch)

    End Sub
    Private Sub AccordionControlBesuche_Click(sender As Object, e As EventArgs) Handles AccordionControlBesuche.Click

        CreateBSS(AccordionControlBesuche)

    End Sub
    Private Sub AccordionControlBSSProdukte_Click(sender As Object, e As EventArgs) Handles AccordionControlBSSProdukte.Click

        CreateBSSProd(AccordionControlBSSProdukte)

    End Sub
    Private Sub AccordionControlBSSTXT_Click(sender As Object, e As EventArgs) Handles AccordionControlBSSTXT.Click

        CreateBSSTXT(AccordionControlBSSTXT)

    End Sub
    Private Sub AccordionControlBSSFoto_Click(sender As Object, e As EventArgs) Handles AccordionControlBSSFoto.Click

        CreateBSSFotos(AccordionControlBSSFoto)

    End Sub
    Private Sub AccordionControlUserControl_Click(sender As Object, e As EventArgs) Handles AccordionControlUserControl.Click

        CreateUserAdmin(AccordionControlAdmin)

    End Sub

    Private Sub BarButtonItemBSSLast4week_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItemBSSLast4week.ItemClick

        BSSClass.FillGrid(" AND x2Besuchsdatum >= DATEADD(mm, -1, GETDATE())")

    End Sub

    Private Sub BarButtonItemBSSall_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItemBSSall.ItemClick

        BSSClass.FillGrid("")

    End Sub
    Private Sub BarEditItemBSSam_EditValueChanged(sender As Object, e As EventArgs) Handles BarEditItemBSSam.EditValueChanged

        BarEditItemBSSADM.EditValue = Nothing

        If Not BarEditItemBSSam.EditValue Is Nothing Then
            Dim Tag As Date = CDate(BarEditItemBSSam.EditValue)
            BSSClass.FillGrid(" AND x2Besuchsdatum = '" & Tag & "'")
        End If

    End Sub
    Private Sub BarEditItemBSSADM_EditValueChanged(sender As Object, e As EventArgs) Handles BarEditItemBSSADM.EditValueChanged

        BarEditItemBSSam.EditValue = Nothing
        If Not BarEditItemBSSADM.EditValue Is Nothing Then
            Dim ADM As String = BarEditItemBSSADM.EditValue.ToString
            BSSClass.FillGrid(" AND ADM_Name LIKE '" & ADM & "'")
        End If

    End Sub
    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        SaveOptions()

    End Sub
    Private Sub BarButtonItemPicRotCounterClock_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItemPicRotCounterClock.ItemClick

        BSSFotoUserClass.RotateCounterclock()

    End Sub
    Private Sub BarEditItemBSSCID_EditValueChanged(sender As Object, e As EventArgs) Handles BarEditItemBSSCID.EditValueChanged

        If BarEditItemBSSCID.EditValue <> "" Then
            BSSSingleUserClass.ladeDaten(CInt(BarEditItemBSSCID.EditValue))
            '  BarEditItemBSSCID.EditValue = ""
        End If

    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem2.ItemClick

        test.Show()

    End Sub
    Private Sub BarEditItemBSSProdCID_EditValueChanged(sender As Object, e As EventArgs) Handles BarEditItemBSSProdCID.EditValueChanged

        BSSProdUserClass.FillGridProdukte(" AND x1Combera_ID = " & BarEditItemBSSProdCID.EditValue.ToString)

    End Sub

    Private Sub BarEditItemArtikelVertrieb_EditValueChanged(sender As Object, e As EventArgs) Handles BarEditItemArtikelVertrieb.EditValueChanged

        ArtikelstammClass.FillGrid(" AND Vertriebslinie LIKE '" & BarEditItemArtikelVertrieb.EditValue.ToString & "'")

    End Sub

End Class
