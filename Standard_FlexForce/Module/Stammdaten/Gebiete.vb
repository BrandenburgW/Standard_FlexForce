
Imports DevExpress.Data
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports System.ComponentModel
Imports System.ComponentModel.Design


Public Class Gebiete
    Inherits UserControl
    Public Sub Gebiete_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim sd = frmMain.BarEditItemBSSCID
        If sd.EditValue = "" Then
            FillGrid("")
        End If

        ' setze alle Spalten auf editable = false
        For Each column As DevExpress.XtraGrid.Columns.GridColumn In gvGebiete.Columns
            'check permission here
            column.OptionsColumn.AllowEdit = False
            column.OptionsColumn.ReadOnly = True
            column.OptionsColumn.AllowFocus = False
            column.BestFit()
        Next

        If gvGebiete.Columns.Count > 0 Then

            ' Grideinstellungen für die Rechte
            Select Case RECHTE
                Case "Superuser", "Admin", "Benutzer"
                    gvGebiete.Columns.View.OptionsBehavior.Editable = True

                    gvGebiete.Columns.Item("ADM_Name").OptionsColumn.AllowEdit = True
                    gvGebiete.Columns.Item("ADM_Name").OptionsColumn.AllowFocus = True
                    gvGebiete.Columns.Item("ADM_Name").OptionsColumn.ReadOnly = False
                    gvGebiete.Columns.Item("ADM_Name").AppearanceCell.BackColor = Color.LightYellow

                    gvGebiete.Columns.Item("in_Tour").OptionsColumn.AllowEdit = True
                    gvGebiete.Columns.Item("in_Tour").OptionsColumn.AllowFocus = True
                    gvGebiete.Columns.Item("in_Tour").OptionsColumn.ReadOnly = False
                    gvGebiete.Columns.Item("in_Tour").AppearanceCell.BackColor = Color.LightYellow

                    gvGebiete.Columns.Item("Bemerkung").OptionsColumn.AllowEdit = True
                    gvGebiete.Columns.Item("Bemerkung").OptionsColumn.AllowFocus = True
                    gvGebiete.Columns.Item("Bemerkung").OptionsColumn.ReadOnly = False
                    gvGebiete.Columns.Item("Bemerkung").AppearanceCell.BackColor = Color.LightYellow

                    gvGebiete.Columns.Item("Besuchsrhythmus").OptionsColumn.AllowEdit = True
                    gvGebiete.Columns.Item("Besuchsrhythmus").OptionsColumn.AllowFocus = True
                    gvGebiete.Columns.Item("Besuchsrhythmus").OptionsColumn.ReadOnly = False
                    gvGebiete.Columns.Item("Besuchsrhythmus").AppearanceCell.BackColor = Color.LightYellow

                    gvGebiete.Columns.Item("Besuchsrhythmus_Vorgabe").OptionsColumn.AllowEdit = True
                    gvGebiete.Columns.Item("Besuchsrhythmus_Vorgabe").OptionsColumn.AllowFocus = True
                    gvGebiete.Columns.Item("Besuchsrhythmus_Vorgabe").OptionsColumn.ReadOnly = False
                    gvGebiete.Columns.Item("Besuchsrhythmus_Vorgabe").AppearanceCell.BackColor = Color.LightYellow

                Case "Superuser"
                    gvGebiete.Columns.View.OptionsBehavior.Editable = True

                    gvGebiete.Columns.Item("kundengruppe").OptionsColumn.AllowEdit = True
                    gvGebiete.Columns.Item("kundengruppe").OptionsColumn.AllowFocus = True
                    gvGebiete.Columns.Item("kundengruppe").OptionsColumn.ReadOnly = False
                    gvGebiete.Columns.Item("kundengruppe").AppearanceCell.BackColor = Color.LightYellow

                    'gvKGR.Columns.Item("Vertriebslinie").OptionsColumn.AllowEdit = True
                    'gvKGR.Columns.Item("Vertriebslinie").OptionsColumn.AllowFocus = True
                    'gvKGR.Columns.Item("Vertriebslinie").OptionsColumn.ReadOnly = False
                    'gvKGR.Columns.Item("Vertriebslinie").AppearanceCell.BackColor = Color.LightYellow
            End Select

        End If

    End Sub
    Private Sub gvKGR_RowUpdated(sender As Object, e As RowObjectEventArgs) Handles gvGebiete.RowUpdated

        MsgBox("Hier werden die geänderten Daten gespeichert. Besuchsdatum in BSS, Produkte, TXT und Foto auf Basis der BSSID ändern.")

    End Sub

    Public Sub FillGrid(Filter As String)

        'rst = readsql("SELECT Vertriebslinie FROM Kunden.Std_Combera_PPC.vw_artikelzuordnung WHERE debitoren_nummer = " & DEBITOR & " AND aktionsnummer = " & AKTIONSNR & " GROUP BY Vertriebslinie ORDER BY Vertriebslinie")
        'frmMain.RepositoryItemLookUpEdit2.DataSource = rst
        'frmMain.RepositoryItemLookUpEdit2.DisplayMember = "Vertriebslinie"
        'frmMain.RepositoryItemLookUpEdit2.ValueMember = "Vertriebslinie"

        gcGebiete.DataSource = Nothing

        rst = readsql("SELECT gebieteID, Geb.debitoren_nummer, Geb.aktionsnummer, x1combera_id, kundengruppe, Geb.gebiet_intern, ADM_Name, in_Tour, Bemerkung, automatisch_aus_tour_datum, automatisch_aus_tour_grund, " &
                        " automatisch_aus_tourHDB_datum, automatisch_aus_tourHDB_grund, automatisch_angelegt_datum, automatisch_angelegt_bssID, automatisch_in_tourHDB_datum, " &
                      " automatisch_in_tourHDB_grund, versanddatum_an_sachbearb, Besuchsrhythmus, Besuchsrhythmus_Vorgabe, ID_Kunde_1, ID_Kunde_2, Zahl_Kunde_1, Text_Kunde_1, Text_Kunde_2, " &
                      " aufgenommen_am, Geb.x900CreateDate, Geb.x901CreateUser, Geb.x902EditDate, Geb.x903EditUser " &
                      " FROM Kunden.Std_Combera_PPC.Tbl_Gebiete AS Geb LEFT JOIN Kunden.Std_Combera_PPC.Tbl_ADMs AS ADM" &
                      " ON Geb.gebiet_intern = ADM.Gebiet_intern AND Geb.debitoren_nummer = ADM.debitoren_nummer AND Geb.aktionsnummer = ADM.aktionsnummer " &
                        " WHERE Geb.debitoren_nummer = " & DEBITOR & " AND Geb.aktionsnummer = " & AKTIONSNR & Filter & " ORDER BY kundengruppe")

        If rst.Rows.Count = 0 Then
            MsgBox("Es sind keine Gebiete vorhanden.", vbOKOnly, "Gebiete")
        Else
            gcGebiete.DataSource = rst

            Dim colADM As GridColumn = gvGebiete.Columns.Item("ADM_Name")
            Dim colGebIntern As GridColumn = gvGebiete.Columns.Item("gebiet_intern")

            gvGebiete.SortInfo.ClearAndAddRange({New GridMergedColumnSortInfo({colADM, colGebIntern}, {ColumnSortOrder.Ascending}),
                                                                                  New GridColumnSortInfo(colADM, ColumnSortOrder.Ascending)}, 2)
        End If


    End Sub

End Class
