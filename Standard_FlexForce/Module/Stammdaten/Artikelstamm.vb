
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports System.ComponentModel
Imports System.ComponentModel.Design


Public Class Artikelstamm
    Inherits UserControl
    Public Sub Artikelstamm_Load(sender As Object, e As EventArgs) Handles Me.Load


        Dim sd = frmMain.BarEditItemBSSCID
        If sd.EditValue = "" Then
            FillGrid("")
        End If

        ' setze alle Spalten auf editable = false
        For Each column As DevExpress.XtraGrid.Columns.GridColumn In gvArtstamm.Columns
            'check permission here
            column.OptionsColumn.AllowEdit = False
            column.OptionsColumn.ReadOnly = True
            column.OptionsColumn.AllowFocus = False
            column.BestFit()
        Next

        If gvArtstamm.Columns.Count > 0 Then

            ' Grideinstellungen für die Rechte
            Select Case RECHTE
            Case "Superuser", "Admin", "Benutzer"
                gvArtstamm.Columns.View.OptionsBehavior.Editable = True

                gvArtstamm.Columns.Item("Sort").OptionsColumn.AllowEdit = True
                gvArtstamm.Columns.Item("Sort").OptionsColumn.AllowFocus = True
                gvArtstamm.Columns.Item("Sort").OptionsColumn.ReadOnly = False
                gvArtstamm.Columns.Item("Sort").AppearanceCell.BackColor = Color.LightYellow

                gvArtstamm.Columns.Item("Artikel").OptionsColumn.AllowEdit = True
                gvArtstamm.Columns.Item("Artikel").OptionsColumn.AllowFocus = True
                gvArtstamm.Columns.Item("Artikel").OptionsColumn.ReadOnly = False
                gvArtstamm.Columns.Item("Artikel").AppearanceCell.BackColor = Color.LightYellow

                gvArtstamm.Columns.Item("aktiv").OptionsColumn.AllowEdit = True
                gvArtstamm.Columns.Item("aktiv").OptionsColumn.AllowFocus = True
                gvArtstamm.Columns.Item("aktiv").OptionsColumn.ReadOnly = False
                gvArtstamm.Columns.Item("aktiv").AppearanceCell.BackColor = Color.LightYellow

                gvArtstamm.Columns.Item("EAN").OptionsColumn.AllowEdit = True
                gvArtstamm.Columns.Item("EAN").OptionsColumn.AllowFocus = True
                gvArtstamm.Columns.Item("EAN").OptionsColumn.ReadOnly = False
                gvArtstamm.Columns.Item("EAN").AppearanceCell.BackColor = Color.LightYellow

                gvArtstamm.Columns.Item("Bemerkung").OptionsColumn.AllowEdit = True
                gvArtstamm.Columns.Item("Bemerkung").OptionsColumn.AllowFocus = True
                gvArtstamm.Columns.Item("Bemerkung").OptionsColumn.ReadOnly = False
                gvArtstamm.Columns.Item("Bemerkung").AppearanceCell.BackColor = Color.LightYellow

            Case "Superuser"
                gvArtstamm.Columns.View.OptionsBehavior.Editable = True

                gvArtstamm.Columns.Item("kundengruppe").OptionsColumn.AllowEdit = True
                gvArtstamm.Columns.Item("kundengruppe").OptionsColumn.AllowFocus = True
                gvArtstamm.Columns.Item("kundengruppe").OptionsColumn.ReadOnly = False
                gvArtstamm.Columns.Item("kundengruppe").AppearanceCell.BackColor = Color.LightYellow

                gvArtstamm.Columns.Item("Vertriebslinie").OptionsColumn.AllowEdit = True
                gvArtstamm.Columns.Item("Vertriebslinie").OptionsColumn.AllowFocus = True
                gvArtstamm.Columns.Item("Vertriebslinie").OptionsColumn.ReadOnly = False
                gvArtstamm.Columns.Item("Vertriebslinie").AppearanceCell.BackColor = Color.LightYellow
        End Select

        End If

    End Sub
    Private Sub gvBSS_RowUpdated(sender As Object, e As RowObjectEventArgs) Handles gvArtstamm.RowUpdated

        MsgBox("Hier werden die geänderten Daten gespeichert. Besuchsdatum in BSS, Produkte, TXT und Foto auf Basis der BSSID ändern.")

    End Sub

    Public Sub FillGrid(Filter As String)

        If Not frmMain.WaitFormManager.IsSplashFormVisible Then frmMain.WaitFormManager.ShowWaitForm()
        frmMain.WaitFormManager.SetWaitFormDescription("Lade Artikelstamm")

        rst = readsql("SELECT Vertriebslinie FROM Kunden.Std_Combera_PPC.vw_artikelzuordnung WHERE debitoren_nummer = " & DEBITOR & " AND aktionsnummer = " & AKTIONSNR & " GROUP BY Vertriebslinie ORDER BY Vertriebslinie")
        frmMain.RepositoryItemLookUpEdit2.DataSource = rst
        frmMain.RepositoryItemLookUpEdit2.DisplayMember = "Vertriebslinie"
        frmMain.RepositoryItemLookUpEdit2.ValueMember = "Vertriebslinie"

        gcArtstamm.DataSource = Nothing

        rst = readsql("SELECT * FROM Kunden.Std_Combera_PPC.vw_artikelzuordnung WHERE debitoren_nummer = " & DEBITOR & " AND aktionsnummer = " & AKTIONSNR & Filter & " ORDER BY Vertriebslinie, Sort")

        If rst.Rows.Count = 0 Then
            MsgBox("Es sind keine Artikel vorhanden.", vbOKOnly, "Artikelstamm")
        Else
            gcArtstamm.DataSource = rst
        End If

        frmMain.WaitFormManager.CloseWaitForm()


    End Sub

End Class
