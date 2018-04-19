
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports System.ComponentModel
Imports System.ComponentModel.Design


Public Class Kundengruppen
    Inherits UserControl
    Public Sub Kundengruppen_Load(sender As Object, e As EventArgs) Handles Me.Load


        Dim sd = frmMain.BarEditItemBSSCID
        If sd.EditValue = "" Then
            FillGrid("")
        End If

        ' setze alle Spalten auf editable = false
        For Each column As DevExpress.XtraGrid.Columns.GridColumn In gvKGR.Columns
            'check permission here
            column.OptionsColumn.AllowEdit = False
            column.OptionsColumn.ReadOnly = True
            column.OptionsColumn.AllowFocus = False
            column.BestFit()
        Next

        If gvKGR.Columns.Count > 0 Then

            ' Grideinstellungen für die Rechte
            Select Case RECHTE
                Case "Superuser", "Admin", "Benutzer"
                    gvKGR.Columns.View.OptionsBehavior.Editable = True

                    gvKGR.Columns.Item("KeyAccount").OptionsColumn.AllowEdit = True
                    gvKGR.Columns.Item("KeyAccount").OptionsColumn.AllowFocus = True
                    gvKGR.Columns.Item("KeyAccount").OptionsColumn.ReadOnly = False
                    gvKGR.Columns.Item("KeyAccount").AppearanceCell.BackColor = Color.LightYellow

                    gvKGR.Columns.Item("Vertriebslinie").OptionsColumn.AllowEdit = True
                    gvKGR.Columns.Item("Vertriebslinie").OptionsColumn.AllowFocus = True
                    gvKGR.Columns.Item("Vertriebslinie").OptionsColumn.ReadOnly = False
                    gvKGR.Columns.Item("Vertriebslinie").AppearanceCell.BackColor = Color.LightYellow

                    gvKGR.Columns.Item("Baustein").OptionsColumn.AllowEdit = True
                    gvKGR.Columns.Item("Baustein").OptionsColumn.AllowFocus = True
                    gvKGR.Columns.Item("Baustein").OptionsColumn.ReadOnly = False
                    gvKGR.Columns.Item("Baustein").AppearanceCell.BackColor = Color.LightYellow

                    gvKGR.Columns.Item("Zahl_Kunde_1").OptionsColumn.AllowEdit = True
                    gvKGR.Columns.Item("Zahl_Kunde_1").OptionsColumn.AllowFocus = True
                    gvKGR.Columns.Item("Zahl_Kunde_1").OptionsColumn.ReadOnly = False
                    gvKGR.Columns.Item("Zahl_Kunde_1").AppearanceCell.BackColor = Color.LightYellow

                    gvKGR.Columns.Item("Zahl_Kunde_2").OptionsColumn.AllowEdit = True
                    gvKGR.Columns.Item("Zahl_Kunde_2").OptionsColumn.AllowFocus = True
                    gvKGR.Columns.Item("Zahl_Kunde_2").OptionsColumn.ReadOnly = False
                    gvKGR.Columns.Item("Zahl_Kunde_2").AppearanceCell.BackColor = Color.LightYellow

                Case "Superuser"
                    gvKGR.Columns.View.OptionsBehavior.Editable = True

                    gvKGR.Columns.Item("kundengruppe").OptionsColumn.AllowEdit = True
                    gvKGR.Columns.Item("kundengruppe").OptionsColumn.AllowFocus = True
                    gvKGR.Columns.Item("kundengruppe").OptionsColumn.ReadOnly = False
                    gvKGR.Columns.Item("kundengruppe").AppearanceCell.BackColor = Color.LightYellow

                    'gvKGR.Columns.Item("Vertriebslinie").OptionsColumn.AllowEdit = True
                    'gvKGR.Columns.Item("Vertriebslinie").OptionsColumn.AllowFocus = True
                    'gvKGR.Columns.Item("Vertriebslinie").OptionsColumn.ReadOnly = False
                    'gvKGR.Columns.Item("Vertriebslinie").AppearanceCell.BackColor = Color.LightYellow
            End Select

        End If

    End Sub
    Private Sub gvKGR_RowUpdated(sender As Object, e As RowObjectEventArgs) Handles gvKGR.RowUpdated

        MsgBox("Hier werden die geänderten Daten gespeichert. Besuchsdatum in BSS, Produkte, TXT und Foto auf Basis der BSSID ändern.")

    End Sub

    Public Sub FillGrid(Filter As String)

        'rst = readsql("SELECT Vertriebslinie FROM Kunden.Std_Combera_PPC.vw_artikelzuordnung WHERE debitoren_nummer = " & DEBITOR & " AND aktionsnummer = " & AKTIONSNR & " GROUP BY Vertriebslinie ORDER BY Vertriebslinie")
        'frmMain.RepositoryItemLookUpEdit2.DataSource = rst
        'frmMain.RepositoryItemLookUpEdit2.DisplayMember = "Vertriebslinie"
        'frmMain.RepositoryItemLookUpEdit2.ValueMember = "Vertriebslinie"

        gcKGR.DataSource = Nothing

        rst = readsql("SELECT kgrID, debitoren_nummer, aktionsnummer, kundengruppe, KeyAccount, Vertriebslinie, Baustein, Zahl_Kunde_1, Zahl_Kunde_2, Zahl_Kunde_3, Zahl_Kunde_4, Zahl_Kunde_5, " &
                      "Zahl_Kunde_6, Zahl_Kunde_7, Text_Kunde_1 ,x900CreateDate, x901CreateUser, x902EditDate, x903EditUser " &
                      "FROM Kunden.Std_Combera_PPC.Tbl_KGR " &
                      "WHERE debitoren_nummer = " & DEBITOR & " AND aktionsnummer = " & AKTIONSNR & Filter & " ORDER BY kundengruppe")

        If rst.Rows.Count = 0 Then
            MsgBox("Es sind keine Kundengruppen vorhanden.", vbOKOnly, "Kundengruppen")
        Else
            gcKGR.DataSource = rst
        End If


    End Sub

End Class
