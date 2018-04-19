
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports System.ComponentModel
Imports System.ComponentModel.Design


Public Class BSS
    Inherits UserControl
    Public Sub BSS_Load(sender As Object, e As EventArgs) Handles Me.Load

        ' Grideinstellungen für die Rechte
        Select Case RECHTE
            Case "Superuser"
                gvBSS.Columns.View.OptionsBehavior.Editable = True

                gvBSS.Columns.Item("x2Besuchsdatum").OptionsColumn.AllowEdit = True
                gvBSS.Columns.Item("x2Besuchsdatum").OptionsColumn.AllowFocus = True
                gvBSS.Columns.Item("x2Besuchsdatum").OptionsColumn.ReadOnly = False
                gvBSS.Columns.Item("x2Besuchsdatum").AppearanceCell.BackColor = Color.LightYellow

                gvBSS.Columns.Item("x4gesprochen_mit").OptionsColumn.AllowEdit = True
                gvBSS.Columns.Item("x4gesprochen_mit").OptionsColumn.AllowFocus = True
                gvBSS.Columns.Item("x4gesprochen_mit").OptionsColumn.ReadOnly = False
                gvBSS.Columns.Item("x4gesprochen_mit").AppearanceCell.BackColor = Color.LightYellow

                gvBSS.Columns.Item("maID").OptionsColumn.AllowEdit = True
                gvBSS.Columns.Item("maID").OptionsColumn.AllowFocus = True
                gvBSS.Columns.Item("maID").OptionsColumn.ReadOnly = False
                gvBSS.Columns.Item("maID").AppearanceCell.BackColor = Color.LightYellow

                gvBSS.Columns.Item("ADM_Name").OptionsColumn.AllowEdit = True
                gvBSS.Columns.Item("ADM_Name").OptionsColumn.AllowFocus = True
                gvBSS.Columns.Item("ADM_Name").OptionsColumn.ReadOnly = False
                gvBSS.Columns.Item("ADM_Name").AppearanceCell.BackColor = Color.LightYellow

                gvBSS.Columns.Item("IMEI").OptionsColumn.AllowEdit = True
                gvBSS.Columns.Item("IMEI").OptionsColumn.AllowFocus = True
                gvBSS.Columns.Item("IMEI").OptionsColumn.ReadOnly = False
                gvBSS.Columns.Item("IMEI").AppearanceCell.BackColor = Color.LightYellow

            Case "Admin", "Benutzer"
                gvBSS.Columns.View.OptionsBehavior.Editable = True

                gvBSS.Columns.Item("x2Besuchsdatum").OptionsColumn.AllowEdit = True
                gvBSS.Columns.Item("x2Besuchsdatum").OptionsColumn.AllowFocus = True
                gvBSS.Columns.Item("x2Besuchsdatum").OptionsColumn.ReadOnly = False
                gvBSS.Columns.Item("x2Besuchsdatum").AppearanceCell.BackColor = Color.LightYellow

                gvBSS.Columns.Item("x4gesprochen_mit").OptionsColumn.AllowEdit = True
                gvBSS.Columns.Item("x4gesprochen_mit").OptionsColumn.AllowFocus = True
                gvBSS.Columns.Item("x4gesprochen_mit").OptionsColumn.ReadOnly = False
                gvBSS.Columns.Item("x4gesprochen_mit").AppearanceCell.BackColor = Color.LightYellow
        End Select

        Dim sd = frmMain.BarEditItemBSSCID
        If sd.EditValue = "" Then
            FillGrid(" AND x2Besuchsdatum >= DATEADD(dd, -7, GETDATE())")
        End If

        For Each column As DevExpress.XtraGrid.Columns.GridColumn In gvBSS.Columns
            'check permission here
            column.OptionsColumn.AllowFocus = False
            column.BestFit()
        Next

    End Sub
    Private Sub gvBSS_RowUpdated(sender As Object, e As RowObjectEventArgs) Handles gvBSS.RowUpdated

        MsgBox("Hier werden die geänderten Daten gespeichert. Besuchsdatum in BSS, Produkte, TXT und Foto auf Basis der BSSID ändern.")

    End Sub

    Public Sub FillGrid(Filter As String)

        'If Not frmMain.WaitFormManager.IsSplashFormVisible Then frmMain.WaitFormManager.ShowWaitForm()
        'frmMain.WaitFormManager.SetWaitFormDescription("Lade Besuche")

        rst = readsql("SELECT ADM_Name FROM Kunden.Std_Combera_PPC.Tbl_BSS WHERE debitoren_nummer = " & DEBITOR & " AND aktionsnummer = " & AKTIONSNR & " GROUP BY ADM_Name ORDER BY ADM_Name")
        frmMain.RepositoryItemLookUpEdit1.DataSource = rst
        frmMain.RepositoryItemLookUpEdit1.DisplayMember = "ADM_Name"
        frmMain.RepositoryItemLookUpEdit1.ValueMember = "ADM_Name"

        gcBSS.DataSource = Nothing

        rst = readsql("SELECT * FROM Kunden.Std_Combera_PPC.Tbl_BSS WHERE debitoren_nummer = " & DEBITOR & " AND aktionsnummer = " & AKTIONSNR & Filter & " ORDER BY x2Besuchsdatum DESC")

        If rst.Rows.Count = 0 Then
            MsgBox("Es sind keine Besuche in den 7 Tagen bzw. im gewünschten Zeitraum vorhanden.", vbOKOnly, "Besuche")
        Else
            gcBSS.DataSource = rst
        End If

        'frmMain.WaitFormManager.CloseWaitForm()


    End Sub

End Class
