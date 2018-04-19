
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports System.ComponentModel
Imports System.ComponentModel.Design


Public Class BSSTXT
    Inherits UserControl
    Public Sub BSSTXT_Load(sender As Object, e As EventArgs) Handles Me.Load

        ' Grideinstellungen für die Rechte
        Select Case RECHTE
            Case "Superuser"
                gvBSSTXT.Columns.View.OptionsBehavior.Editable = True

                gvBSSTXT.Columns.Item("Antwort").OptionsColumn.AllowEdit = True
                gvBSSTXT.Columns.Item("Antwort").OptionsColumn.AllowFocus = True
                gvBSSTXT.Columns.Item("Antwort").OptionsColumn.ReadOnly = False
                gvBSSTXT.Columns.Item("Antwort").AppearanceCell.BackColor = Color.LightYellow

            Case "Admin", "Benutzer"
                gvBSSTXT.Columns.View.OptionsBehavior.Editable = True

                gvBSSTXT.Columns.Item("Antwort").OptionsColumn.AllowEdit = True
                gvBSSTXT.Columns.Item("Antwort").OptionsColumn.AllowFocus = True
                gvBSSTXT.Columns.Item("Antwort").OptionsColumn.ReadOnly = False
                gvBSSTXT.Columns.Item("Antwort").AppearanceCell.BackColor = Color.LightYellow

        End Select

        Dim sd = frmMain.BarEditItemBSSCID
        If sd.EditValue = "" Then
            FillGrid(" AND x2Besuchsdatum >= DATEADD(dd, -7, GETDATE())")
        End If

        For Each column As DevExpress.XtraGrid.Columns.GridColumn In gvBSSTXT.Columns
            'check permission here
            column.OptionsColumn.AllowFocus = False
            column.BestFit()
        Next

    End Sub
    Private Sub InitData(txtid As Integer)

        rst = readsql("SELECT * FROM Kunden.Std_Combera_PPC.Tbl_TXT AS TXT WHERE txtid = " & txtid)

        If Not IsDBNull(rst.Rows(0)("txtdroplistid")) Then
            rst2 = readsql("SELECT txtDropItemID, Antwort FROM Kunden.Std_Combera_PPC.Tbl_TXT AS TXT LEFT JOIN Kunden.Std_Combera_PPC.Tbl_TXT_Droplists_Items AS TXTDRP " &
                      "ON TXT.txtDroplistID = TXTDRP.txtDroplistID WHERE TXTDRP.txtdroplistid = " & rst.Rows(0)("txtdroplistid").ToString)
            For x = 0 To rst2.Rows.Count - 1
                Antwort.Add(New UAntwort() With {.ID = CInt(rst2.Rows(x)("txtDropItemID")), .Antworttext = rst2.Rows(x)("Antwort").ToString})
            Next
        End If

        If CBool(rst.Rows(0)("janein")) = True Then
            Antwort.Add(New UAntwort() With {.ID = 1, .Antworttext = "Ja"})
            Antwort.Add(New UAntwort() With {.ID = 2, .Antworttext = "Nein"})
        End If

        If CBool(rst.Rows(0)("zahl")) = True Then
        End If

        If CBool(rst.Rows(0)("text")) = True Then
        End If

        If CBool(rst.Rows(0)("datum_von")) = True Then
        End If



    End Sub

    Private Sub gvBSSTXT_RowUpdated(sender As Object, e As RowObjectEventArgs) Handles gvBSSTXT.RowUpdated

        MsgBox("Hier werden die geänderten Daten gespeichert. Besuchsdatum in BSS, Produkte, TXT und Foto auf Basis der BSSID ändern.")

    End Sub

    Public Sub FillGrid(Filter As String)

        If Not frmMain.WaitFormManager.IsSplashFormVisible Then frmMain.WaitFormManager.ShowWaitForm()
        frmMain.WaitFormManager.SetWaitFormDescription("Lade Textfragen")

        rst = readsql("SELECT ADM_Name FROM Kunden.Std_Combera_PPC.Tbl_BSS WHERE debitoren_nummer = " & DEBITOR & " AND aktionsnummer = " & AKTIONSNR & " GROUP BY ADM_Name ORDER BY ADM_Name")
        frmMain.RepositoryItemLookUpEdit1.DataSource = rst
        frmMain.RepositoryItemLookUpEdit1.DisplayMember = "ADM_Name"
        frmMain.RepositoryItemLookUpEdit1.ValueMember = "ADM_Name"

        gcBSSTXT.DataSource = Nothing

        rst = readsql("SELECT * FROM Kunden.Std_Combera_PPC.vw_besuche_fragen WHERE debitoren_nummer = " & DEBITOR & " AND aktionsnummer = " & AKTIONSNR & Filter & " ORDER BY x2Besuchsdatum DESC, x1Combera_id, x3sort")

        If rst.Rows.Count = 0 Then
            MsgBox("Es sind keine Besuche in den 7 Tagen bzw. im gewünschten Zeitraum vorhanden.", vbOKOnly, "Besuche")
        Else
            gcBSSTXT.DataSource = rst
        End If

        frmMain.WaitFormManager.CloseWaitForm()

    End Sub

    Private Sub gvBSSTXT_RowStyle(sender As Object, e As RowStyleEventArgs) Handles gvBSSTXT.RowStyle

        ' Daten für Antworten holen
        'Dim row As System.Data.DataRow = gvBSSTXT.GetDataRow(gvBSSTXT.FocusedRowHandle)

        'InitData(CInt(row("txtid")))

        'Dim riLookup As New RepositoryItemLookUpEdit()
        'riLookup.DataSource = Antwort
        'riLookup.ValueMember = "Antwort"
        'riLookup.DisplayMember = "Antwort"
        'riLookup.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        'riLookup.DropDownRows = Antwort.Count

        'gvBSSTXT.Columns("Antwort").ColumnEdit = riLookup

    End Sub

    Private Antwort As New List(Of UAntwort)()
    Public Class UAntwort
        Public Property ID() As Integer
        Public Property Antworttext() As String
    End Class

End Class
