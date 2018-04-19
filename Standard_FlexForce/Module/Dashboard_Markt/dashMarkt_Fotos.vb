Public Class dashMarkt_Fotos
    Private Sub dashMarkt_Fotos_Load(sender As Object, e As EventArgs) Handles Me.Load

        If frmMain.BarEditItemBSSCID.EditValue <> "" Then
            ladeFotos(CInt(frmMain.BarEditItemBSSCID.EditValue.ToString))
        End If

    End Sub

    Public Sub ladeFotos(CID As Integer)

        If Not frmMain.WaitFormManager.IsSplashFormVisible Then frmMain.WaitFormManager.ShowWaitForm()
        frmMain.WaitFormManager.SetWaitFormDescription("Lade Fotos")

        rst = readsql("SELECT bssFotosID, dateiname, FOTO.schluessel, bemerkung, foto_exists, bezeichnung, aktiv " &
                        "FROM Kunden.Std_Combera_PPC.Tbl_BSS_Fotos AS FOTO RIGHT JOIN Kunden.Std_Combera_PPC.vw_letzte_Besuche AS bes ON FOTO.x1combera_id = bes.x1combera_id " &
                        "RIGHT JOIN Kunden.Std_Combera_PPC.Tbl_Fotokategorien AS FKat ON FOTO.schluessel = FKat.schluessel AND FOTO.debitoren_nummer = FKAT.debitoren_nummer " &
                        "AND FOTO.aktionsnummer = FKAT.aktionsnummer " &
                        "WHERE FOTO.x1combera_id = " & CID & " AND FOTO.debitoren_nummer = " & DEBITOR & " AND FOTO.aktionsnummer = " & AKTIONSNR &
                        " AND FOTO.x2Besuchsdatum = bes.x2Besuchsdatum AND aktiv = 1")
        For x = 0 To rst.Rows.Count - 1
            ImgSliderDash_Foto.Images.Add(Image.FromFile(Settings.Default.Fotopfad & rst.Rows(x).Item("dateiname").ToString))
        Next
        txtFotoAnzahl.Text = rst.Rows.Count.ToString

        frmMain.WaitFormManager.CloseWaitForm()
    End Sub

End Class
