Public Class dashMarkt_Produkte
    Private Sub dash_markt_Produkte_Load(sender As Object, e As EventArgs) Handles Me.Load

        loadProd(89198)

    End Sub

    Public Sub loadProd(CID As Integer)

        If Not frmMain.WaitFormManager.IsSplashFormVisible Then frmMain.WaitFormManager.ShowWaitForm()
        frmMain.WaitFormManager.SetWaitFormDescription("Lade Produkte")

        rst = readsql("SELECT bssProdID, Prod.bssID, ADM_Name, bereich, x3Sort, artID, x5Artikelname, Zahl1, Zahl2, Zahl3, JN1, JN2, droplistItemID, droplist_text " &
                      "FROM Kunden.Std_Combera_PPC.Tbl_BSS_Produkte AS Prod RIGHT JOIN Kunden.Std_Combera_PPC.vw_letzte_Besuche AS bes ON Prod.x1combera_id = bes.x1combera_id " &
                      "WHERE Prod.x2Besuchsdatum = bes.x2Besuchsdatum AND Prod.x1combera_id = " & CID & " AND Prod.debitoren_nummer = " & DEBITOR & " AND Prod.aktionsnummer = " & AKTIONSNR &
                      " AND bereich = 1")

        gcdashProd.DataSource = rst

        frmMain.WaitFormManager.CloseWaitForm()



    End Sub

End Class
