Imports DevExpress.XtraGrid.Views.Grid

Public Class BSSFotos

    Public Shared iName As Bitmap
    Public Sub BSSFotos_Load(sender As Object, e As EventArgs) Handles Me.Load

        ' Grideinstellungen für die Rechte
        Select Case RECHTE
            Case "Superuser"


            Case "Admin", "Benutzer"

        End Select

        '' frmMain.tabbedView.Controller.View.ActiveDocument.Caption
        If frmMain.BarEditItemBSSCID.EditValue = "" Then
            FillGrid(" AND x2Besuchsdatum >= DATEADD(mm, -1, GETDATE())")
        End If

        For Each column As DevExpress.XtraGrid.Columns.GridColumn In gvBSSFotos.Columns
            'check permission here
            column.OptionsColumn.AllowFocus = False
            column.BestFit()
        Next

    End Sub

    Public Sub FillGrid(Filter As String)

        'If Not frmMain.WaitFormManager.IsSplashFormVisible Then frmMain.WaitFormManager.ShowWaitForm()
        'frmMain.WaitFormManager.SetWaitFormDescription("Lade Fotos")

        gcBSSFotos.DataSource = Nothing

        rst = readsql("SELECT bssFotosID, Fotos.debitoren_nummer, Fotos.aktionsnummer, maID, ADM_Name, x1combera_id, x2besuchsdatum, dateiname, bezeichnung, aktiv " &
                      "FROM Kunden.Std_Combera_PPC.Tbl_BSS_Fotos AS Fotos " &
                        "LEFT JOIN Kunden.Std_Combera_PPC.Tbl_Fotokategorien As FotoKat ON Fotos.debitoren_nummer = Fotokat.debitoren_nummer " &
                        "AND Fotos.aktionsnummer = FotoKat.aktionsnummer AND Fotos.schluessel = FotoKat.schluessel " &
                        "WHERE Fotos.debitoren_nummer = " & DEBITOR & " AND Fotos.aktionsnummer = " & AKTIONSNR & Filter & " ORDER BY x2Besuchsdatum DESC")

        If rst.Rows.Count = 0 Then
            MsgBox("Es sind keine Fotos in den letzten 4 Wochen bzw. im gewünschten Zeitraum vorhanden.", vbOKOnly, "Besuche")
        Else
            gcBSSFotos.DataSource = rst
        End If

        'frmMain.WaitFormManager.CloseWaitForm()

    End Sub

    Private Sub gvBSSFotos_RowClick(sender As Object, e As RowClickEventArgs) Handles gvBSSFotos.RowClick

        If Not frmMain.WaitFormManager.IsSplashFormVisible Then frmMain.WaitFormManager.ShowWaitForm()
        frmMain.WaitFormManager.SetWaitFormDescription("Lade Foto")

        Dim row As System.Data.DataRow = gvBSSFotos.GetDataRow(gvBSSFotos.FocusedRowHandle)
        iName = CType(Bitmap.FromFile(Settings.Default.Fotopfad & row("dateiname").ToString), Bitmap)
        PictureEdit1.Image = iName   'Image.FromFile(Settings.Default.Fotopfad & row("dateiname").ToString)

        frmMain.WaitFormManager.CloseWaitForm()

    End Sub

    Public Sub RotateCounterclock()

        Dim cloneBitmap As Bitmap = iName

        If cloneBitmap IsNot Nothing Then
            cloneBitmap.RotateFlip(RotateFlipType.Rotate90FlipNone)
            PictureEdit1.Image = cloneBitmap
            PictureEdit1.Refresh()
            PictureEdit1.Image.RotateFlip(RotateFlipType.Rotate90FlipNone)
            '  PictureEdit1.Refresh()
        End If

    End Sub

End Class
