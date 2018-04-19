Public Class dashMarkt_HDB
    Friend dashMarkt_HDB As Object

    Public Sub dashMarkt_HDB_Load(sender As Object, e As EventArgs) Handles Me.Load

        ladeMarktdaten(CInt(frmMain.BarEditItemBSSCID.EditValue))

    End Sub

    Public Sub ladeMarktdaten(CID As Integer)

        rst = readsql("SELECT * FROM Kunden.STD_COMBERA_PPC.vw_FF_Verwaltung_Marktdaten WHERE x1combera_id = " & CID & " AND debitoren_nummer = " & DEBITOR & " AND aktionsnummer = " & AKTIONSNR)
        'gcHDB.DataSource = rst

        If rst.Rows.Count = 1 Then

            txtAktionnr.Text = rst.Rows(0)("aktionsnummer").ToString
            txtBundesland.Text = rst.Rows(0)("x7Land").ToString
            txtCID.Text = rst.Rows(0)("x1Combera_ID").ToString
            txtDebitor.Text = rst.Rows(0)("debitoren_nummer").ToString
            txtDublette.Text = rst.Rows(0)("x164Dublette_zu").ToString
            txtEmail.Text = rst.Rows(0)("x17eMail").ToString
            txteröffnet.Text = rst.Rows(0)("x37Eroeffnungsdatum").ToString
            txtFax.Text = rst.Rows(0)("x16Telefax").ToString
            txtLand.Text = rst.Rows(0)("x7Land").ToString
            txtADMName.Text = rst.Rows(0)("ADM_Name").ToString
            txtOrt.Text = rst.Rows(0)("x9Ort").ToString
            txtOrtsteil.Text = rst.Rows(0)("x10Ortsteil").ToString
            txtPLZ.Text = rst.Rows(0)("x8PLZ").ToString
            txtStrasse.Text = rst.Rows(0)("x11Strasse").ToString & " " & rst.Rows(0)("x12Hausnummer").ToString
            txtTel.Text = rst.Rows(0)("x14Telefon").ToString
            txtVorwahlFax.Text = rst.Rows(0)("x13Vorwahl_Telefon").ToString
            txtVorwahlTel.Text = rst.Rows(0)("x15Vorwahl_Telefax").ToString
            chkErloschen.Checked = CBool(rst.Rows(0)("x44erloschen"))
            txtHomepage.Text = rst.Rows(0)("x18Internet").ToString
            txtILN.Text = rst.Rows(0)("x100ILN").ToString
            txtlastVisit.Text = rst.Rows(0)("Besuch").ToString
            txtMAID.Text = rst.Rows(0)("maID").ToString
            txtGebiet.Text = rst.Rows(0)("gebiet_intern").ToString
            txtFirmengruppe.Text = rst.Rows(0)("x5firmengruppe").ToString

            txtKGR.Text = rst.Rows(0)("x23Kundengruppenschema").ToString
            txtKundeKGR.Text = rst.Rows(0)("kundengruppe").ToString
            txtKundengruppenschema.Text = ""
            chkinTour.CheckState = CType(CBool(rst.Rows(0)("in_Tour")), CheckState)
            txtBSR.Text = rst.Rows(0)("Besuchsrhythmus").ToString
            txtBSRVorgabe.Text = rst.Rows(0)("Besuchsrhythmus_Vorgabe").ToString

            txtArtOutlet.Text = rst.Rows(0)("x22Art_des_Outlet").ToString
            txtVKFläche.Text = rst.Rows(0)("x24Verkaufsflaeche").ToString
            txtHandelskundennr.Text = rst.Rows(0)("x25Handelskundennummer").ToString
            txtLagerstandort.Text = rst.Rows(0)("x26Lagerstandort").ToString
            txtMarktAnrede.Text = rst.Rows(0)("x34Marktleiter_Anrede").ToString
            txtMarktNName.Text = rst.Rows(0)("x36Marktleiter_Nachname").ToString
            txtMarktVName.Text = rst.Rows(0)("x35Marktleiter_Vorname").ToString
            txtZentrale.Text = rst.Rows(0)("x86Fil_Zentrale_Name").ToString
            txtEntscheiderNName.Text = rst.Rows(0)("x87Fil_Entscheider_Vorname").ToString
            txtEntscheiderVName.Text = rst.Rows(0)("x88Fil_Entscheider_Name").ToString
            txtVKGAM.Text = rst.Rows(0)("x165Verkaufsflaeche_GAM").ToString
            txtVKLEH.Text = rst.Rows(0)("x166Verkaufsflaeche_LEH").ToString

            chkFranchise.Checked = CBool(rst.Rows(0)("x83Fil_Besitzverhaeltnis_Franchise"))
            chkRegie.Checked = CBool(rst.Rows(0)("x81Fil_Besitzverhaeltnis_Regie"))
            chkSelbst.Checked = CBool(rst.Rows(0)("x82Fil_Besitzverhaeltnis_Selbstaendig"))

            If Not IsDBNull(rst.Rows(0)("x163EigenerGAM")) Then
                chkEigenerGAM.Checked = CBool(rst.Rows(0)("x163EigenerGAM"))

            End If
            chkFilalEK.Checked = CBool(rst.Rows(0)("x84Fil_selbst_EK_Ja"))

        Else
                MsgBox("Es sind für diesen Markt keine Daten vorhanden (Combera-ID nicht gefunden)", vbExclamation, "Suchfehler")
        End If

    End Sub

End Class
