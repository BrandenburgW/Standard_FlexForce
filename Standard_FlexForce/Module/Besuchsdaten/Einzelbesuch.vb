
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.Utils
Imports DevExpress.Utils.Drawing

Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

Public Class Einzelbesuch
    Private Sub Einzelbesuch_Load(sender As Object, e As EventArgs) Handles Me.Load

        ' Grideinstellungen für die Rechte
        Select Case RECHTE
            Case 1


            Case 2

        End Select

        '' frmMain.tabbedView.Controller.View.ActiveDocument.Caption
        Dim sd = frmMain.BarEditItemBSSCID
        If sd.EditValue = "" Then
            FillGridEinzel(" AND x2Besuchsdatum >= DATEADD(mm, -1, GETDATE())")
        End If


    End Sub

    Public Sub FillGridEinzel(Filter As String)

        Dim sd = frmMain.BarEditItemBSSCID
        If Not sd.EditValue Is Nothing Then

            ' Lade Produkte zur Combera-ID  

            BssProdukte1.FillGridProdukte(" AND x1Combera_ID = " & sd.EditValue)


            ' Lade Fotos zur Combera-ID

            If Not frmMain.WaitFormManager.IsSplashFormVisible Then frmMain.WaitFormManager.ShowWaitForm()
            frmMain.WaitFormManager.SetWaitFormDescription("Lade Fotos")

            rst = readsql("SELECT bssFotosID, Fotos.debitoren_nummer, Fotos.aktionsnummer, maID, ADM_Name, x1combera_id, x2besuchsdatum, dateiname, bezeichnung, aktiv " &
                          "FROM Kunden.Std_Combera_PPC.Tbl_BSS_Fotos AS Fotos " &
                            "LEFT JOIN Kunden.Std_Combera_PPC.Tbl_Fotokategorien As FotoKat ON Fotos.debitoren_nummer = Fotokat.debitoren_nummer " &
                            "AND Fotos.aktionsnummer = FotoKat.aktionsnummer AND Fotos.schluessel = FotoKat.schluessel " &
                            "WHERE Fotos.debitoren_nummer = " & DEBITOR & " AND Fotos.aktionsnummer = " & AKTIONSNR & Filter & " ORDER BY x2Besuchsdatum DESC")

            If rst.Rows.Count = 0 Then
                MsgBox("Es sind keine Fotos in den letzten 7 Tagen bzw. im gewünschten Zeitraum vorhanden.", vbOKOnly, "Besuche")
            Else
                GalleryControl1.Gallery.ShowItemText = True

                Dim group1 As GalleryItemGroup = New GalleryItemGroup()
                group1.Caption = "Cars"
                GalleryControl1.Gallery.Groups.Add(group1)
                GalleryControl1.Gallery.ItemImageLayout = ImageLayoutMode.ZoomInside
                GalleryControl1.Gallery.ImageSize = New Size(120, 90)


                'For p = 0 To rst.Rows.Count - 1

                '    Dim thumbnail As Image = Image.FromFile(Settings.Default.Fotopfad & rst.Rows(p)("dateiname").ToString)
                '    group1.Items.Add(New DevExpress.XtraBars.Ribbon.GalleryItem(thumbnail, rst.Rows(p)("bezeichnung").ToString, ""))
                'Next



            End If

        End If
        If frmMain.WaitFormManager.IsSplashFormVisible Then frmMain.WaitFormManager.CloseWaitForm()

    End Sub

End Class
