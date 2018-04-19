
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

Public Class BSSProdukte

    Public Sub BSSProdukte_Load(sender As Object, e As EventArgs) Handles Me.Load

        Try

            ' Aktionsspezifische Spalten benennen
            rst = readsql("SELECT Prod.debitoren_nummer, Prod.aktionsnummer, Prod.bereich, ProdBereich.bereich, ProdBereich.zahl1_name, ProdBereich.zahl2_name, " &
                      "ProdBereich.zahl3_name, ProdBereich.jn1_name,ProdBereich.jn2_name " &
                        "FROM Kunden.Std_Combera_PPC.Tbl_BSS_Produkte AS Prod " &
                        "INNER JOIN Kunden.Std_Combera_PPC.Tbl_Bereiche_Produkte AS ProdBereich ON Prod.debitoren_nummer = ProdBereich.debitoren_nummer " &
                        "AND Prod.aktionsnummer = ProdBereich.aktionsnummer " &
                        "AND Prod.bereich = ProdBereich.bereich " &
                        "WHERE Prod.debitoren_nummer = " & DEBITOR & " AND Prod.aktionsnummer = " & AKTIONSNR &
                        "GROUP BY Prod.bereich, Prod.debitoren_nummer, Prod.aktionsnummer, Prod.bereich, ProdBereich.bereich, ProdBereich.zahl1_name, " &
                        "ProdBereich.zahl2_name,ProdBereich.zahl3_name, ProdBereich.jn1_name,ProdBereich.jn2_name")



            ' Grideinstellungen für die Rechte
            Select Case RECHTE
                Case "Superuser"
                    gvBSSProdukte.Columns.View.OptionsBehavior.Editable = True

                    gvBSSProdukte.Columns.Item("Zahl1").OptionsColumn.AllowEdit = True
                    gvBSSProdukte.Columns.Item("Zahl1").OptionsColumn.AllowFocus = True
                    gvBSSProdukte.Columns.Item("Zahl1").OptionsColumn.ReadOnly = False
                    gvBSSProdukte.Columns.Item("Zahl1").AppearanceCell.BackColor = Color.LightYellow

                    gvBSSProdukte.Columns.Item("Zahl2").OptionsColumn.AllowEdit = True
                    gvBSSProdukte.Columns.Item("Zahl2").OptionsColumn.AllowFocus = True
                    gvBSSProdukte.Columns.Item("Zahl2").OptionsColumn.ReadOnly = False
                    gvBSSProdukte.Columns.Item("Zahl2").AppearanceCell.BackColor = Color.LightYellow

                    gvBSSProdukte.Columns.Item("Zahl3").OptionsColumn.AllowEdit = True
                    gvBSSProdukte.Columns.Item("Zahl3").OptionsColumn.AllowFocus = True
                    gvBSSProdukte.Columns.Item("Zahl3").OptionsColumn.ReadOnly = False
                    gvBSSProdukte.Columns.Item("Zahl3").AppearanceCell.BackColor = Color.LightYellow

                    gvBSSProdukte.Columns.Item("JN1").OptionsColumn.AllowEdit = True
                    gvBSSProdukte.Columns.Item("JN1").OptionsColumn.AllowFocus = True
                    gvBSSProdukte.Columns.Item("JN1").OptionsColumn.ReadOnly = False
                    gvBSSProdukte.Columns.Item("JN1").AppearanceCell.BackColor = Color.LightYellow

                    gvBSSProdukte.Columns.Item("JN2").OptionsColumn.AllowEdit = True
                    gvBSSProdukte.Columns.Item("JN2").OptionsColumn.AllowFocus = True
                    gvBSSProdukte.Columns.Item("JN2").OptionsColumn.ReadOnly = False
                    gvBSSProdukte.Columns.Item("JN2").AppearanceCell.BackColor = Color.LightYellow

                    gvBSSProdukte.Columns.Item("droplisttext").OptionsColumn.AllowEdit = True
                    gvBSSProdukte.Columns.Item("droplisttext").OptionsColumn.AllowFocus = True
                    gvBSSProdukte.Columns.Item("droplisttext").OptionsColumn.ReadOnly = False
                    gvBSSProdukte.Columns.Item("droplisttext").AppearanceCell.BackColor = Color.LightYellow

                Case "Admin", "Benutzer"
                    gvBSSProdukte.Columns.View.OptionsBehavior.Editable = True

                    gvBSSProdukte.Columns.Item("Zahl1").OptionsColumn.AllowEdit = True
                    gvBSSProdukte.Columns.Item("Zahl1").OptionsColumn.AllowFocus = True
                    gvBSSProdukte.Columns.Item("Zahl1").OptionsColumn.ReadOnly = False
                    gvBSSProdukte.Columns.Item("Zahl1").AppearanceCell.BackColor = Color.LightYellow

                    gvBSSProdukte.Columns.Item("Zahl2").OptionsColumn.AllowEdit = True
                    gvBSSProdukte.Columns.Item("Zahl2").OptionsColumn.AllowFocus = True
                    gvBSSProdukte.Columns.Item("Zahl2").OptionsColumn.ReadOnly = False
                    gvBSSProdukte.Columns.Item("Zahl2").AppearanceCell.BackColor = Color.LightYellow

                    gvBSSProdukte.Columns.Item("Zahl3").OptionsColumn.AllowEdit = True
                    gvBSSProdukte.Columns.Item("Zahl3").OptionsColumn.AllowFocus = True
                    gvBSSProdukte.Columns.Item("Zahl3").OptionsColumn.ReadOnly = False
                    gvBSSProdukte.Columns.Item("Zahl3").AppearanceCell.BackColor = Color.LightYellow

                    gvBSSProdukte.Columns.Item("JN1").OptionsColumn.AllowEdit = True
                    gvBSSProdukte.Columns.Item("JN1").OptionsColumn.AllowFocus = True
                    gvBSSProdukte.Columns.Item("JN1").OptionsColumn.ReadOnly = False
                    gvBSSProdukte.Columns.Item("JN1").AppearanceCell.BackColor = Color.LightYellow

                    gvBSSProdukte.Columns.Item("JN2").OptionsColumn.AllowEdit = True
                    gvBSSProdukte.Columns.Item("JN2").OptionsColumn.AllowFocus = True
                    gvBSSProdukte.Columns.Item("JN2").OptionsColumn.ReadOnly = False
                    gvBSSProdukte.Columns.Item("JN2").AppearanceCell.BackColor = Color.LightYellow

                    gvBSSProdukte.Columns.Item("droplisttext").OptionsColumn.AllowEdit = True
                    gvBSSProdukte.Columns.Item("droplisttext").OptionsColumn.AllowFocus = True
                    gvBSSProdukte.Columns.Item("droplisttext").OptionsColumn.ReadOnly = False
                    gvBSSProdukte.Columns.Item("droplisttext").AppearanceCell.BackColor = Color.LightYellow
            End Select

            Dim sd = frmMain.BarEditItemBSSCID
            Dim tab = frmMain.tabbedView.Controller.View.ActiveDocument

            If sd.EditValue Is Nothing And Not tab Is Nothing Then
                FillGridProdukte(" AND x2Besuchsdatum >= DATEADD(d, -7, GETDATE())")
            End If

            For Each column As DevExpress.XtraGrid.Columns.GridColumn In gvBSSProdukte.Columns
                'check permission here
                column.OptionsColumn.AllowFocus = False
                column.BestFit()
            Next
        Catch
        End Try

    End Sub
    Public Sub gvBSSProdukte_RowUpdated(sender As Object, e As RowObjectEventArgs) Handles gvBSSProdukte.RowUpdated

        MsgBox("Hier werden die geänderten Daten gespeichert. Besuchsdatum in BSS, Produkte, TXT und Foto auf Basis der BSSID ändern.")

    End Sub

    Public Sub FillGridProdukte(Filter As String)

        If Not frmMain.WaitFormManager.IsSplashFormVisible Then frmMain.WaitFormManager.ShowWaitForm()
        frmMain.WaitFormManager.SetWaitFormDescription("Lade Produkte")

        rst = readsql("SELECT ADM_Name FROM Kunden.Std_Combera_PPC.Tbl_BSS_Produkte WHERE debitoren_nummer = " & DEBITOR & " AND aktionsnummer = " & AKTIONSNR & " GROUP BY ADM_Name ORDER BY ADM_Name")

        gcBSSProdukte.DataSource = Nothing

        rst = readsql("SELECT * FROM Kunden.Std_Combera_PPC.Tbl_BSS_Produkte WHERE debitoren_nummer = " & DEBITOR & " AND aktionsnummer = " & AKTIONSNR & Filter & " ORDER BY x2Besuchsdatum DESC")

        If rst.Rows.Count = 0 Then
            MsgBox("Es sind keine Besuche in den letzten 7 Tagen bzw. im gewünschten Zeitraum vorhanden.", vbOKOnly, "Besuche")
        Else
            gcBSSProdukte.DataSource = rst
        End If

        frmMain.WaitFormManager.CloseWaitForm()
        Me.Update()
        Me.Refresh()
    End Sub

End Class
