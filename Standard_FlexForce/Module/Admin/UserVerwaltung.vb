
Imports System.ComponentModel
Imports DevExpress.Data
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

Public Class UserVerwaltung

    Dim SELECTACTIVE As Boolean = False
    Dim SELECTACTIVEUSER As Boolean = False

    Public Sub New()

        InitializeComponent()

    End Sub

    Public Sub UserVerwaltung_Load(sender As Object, e As EventArgs) Handles Me.Load
        InitData()

        readUser()
        readAllUser()

        Dim riLookup As New RepositoryItemLookUpEdit()
        riLookup.DataSource = UserRights
        riLookup.ValueMember = "Bezeichnung"
        riLookup.DisplayMember = "Bezeichnung"
        riLookup.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        riLookup.DropDownRows = UserRights.Count

        gvUser.Columns("Berechtigung").ColumnEdit = riLookup

    End Sub

    Private UserRights As New List(Of URights)()

    Public Class URights
        Public Property ID() As Integer
        Public Property Bezeichnung() As String
    End Class

    Private Sub InitData()

        Dim Nutzung() As String = Split(Settings.Default.Rechte, ";")

        For Each r In Nutzung
            Dim rRechte() As String = Split(r, "|")
            UserRights.Add(New URights() With {.ID = CInt(rRechte(0)), .Bezeichnung = rRechte(1)})
        Next


    End Sub



    Private Sub gvUser_RowClick(sender As Object, e As RowClickEventArgs) Handles gvUser.RowClick

        Dim row As System.Data.DataRow = gvUser.GetDataRow(gvUser.FocusedRowHandle)
        gcRechte.DataSource = Nothing
        gvUser.OptionsBehavior.Editable = False

        readAktionen()

        If row("STD_FF_ID").ToString <> "" Then
            readRechte()
        Else
            gcRechte.DataSource = Nothing
        End If

    End Sub

    Private Sub gvUser_DoubleClick(sender As Object, e As EventArgs) Handles gvUser.DoubleClick

        EditUser()

    End Sub

    Private Sub gvAllUser_SelectionChanged(sender As Object, e As SelectionChangedEventArgs) Handles gvAllUser.SelectionChanged

        If SELECTACTIVEUSER = True Then

            Dim row As System.Data.DataRow = gvAllUser.GetDataRow(gvAllUser.FocusedRowHandle)

            If gvAllUser.IsRowSelected(gvAllUser.FocusedRowHandle) Then

                gvUser.AddNewRow()
                Dim newRowHandle As Integer = gvUser.FocusedRowHandle
                gvUser.SetRowCellValue(newRowHandle, gvUser.Columns("UserName"), row("Name").ToString)

                saveUser(row("Name").ToString, , 2)
                readUser()

                gcRechte.DataSource = Nothing
                EditUser()
            Else

                Dim delRowhandle As Integer = GetRowHandleByColumnValue(gvUser, "UserName", gvAllUser.GetRowCellDisplayText(gvAllUser.FocusedRowHandle, gvAllUser.Columns(0)))
                Dim delID = gvUser.GetRowCellDisplayText(delRowhandle, gvUser.Columns(0))
                If delID <> "" Then delUser(delID)
                gvUser.DeleteRow(delRowhandle)
                readUser()
                readRechte()
                readAktionen()
            End If

            gcUser.RefreshDataSource()
            readAllUser()

        End If

        SELECTACTIVEUSER = False

    End Sub

    Private Sub gvAllUser_RowClick(sender As Object, e As RowClickEventArgs) Handles gvAllUser.RowClick

        SELECTACTIVEUSER = True

    End Sub
    Private Sub EditUser()

        With gvUser
            .OptionsBehavior.Editable = True
            .Columns.Item("STD_FF_ID").OptionsColumn.AllowEdit = False
            .Columns.Item("UserName").OptionsColumn.AllowEdit = False
            .Columns.Item("Mailadresse").OptionsColumn.AllowEdit = True
            .Columns.Item("Berechtigung").OptionsColumn.AllowEdit = True
            .Columns.Item("LastLogin").OptionsColumn.AllowEdit = False
            .RefreshData()
        End With

    End Sub

    Private Sub gvUser_ShowingEditor(sender As Object, e As CancelEventArgs) Handles gvUser.ShowingEditor

        Dim view As GridView = gvUser

        If view.FocusedRowHandle <> view.FocusedRowHandle Then
            e.Cancel = True
        End If

    End Sub
    Private Sub gvAllUser_RowStyle(sender As Object, e As RowStyleEventArgs) Handles gvAllUser.RowStyle

        For x = 0 To gvUser.RowCount - 1

            Dim View As GridView = sender

            If (e.RowHandle >= 0) And gvUser.GetRowCellDisplayText(x, gvUser.Columns(0)) <> "" Then
                Dim UName As String = gvUser.GetRowCellDisplayText(x, gvUser.Columns(1))

                Select Case UName
                    Case View.GetRowCellDisplayText(e.RowHandle, View.Columns(0))
                        gvAllUser.SelectRow(e.RowHandle)
                End Select

            End If
        Next

    End Sub
    Private Sub gvAktionen_RowStyle(sender As Object, e As RowStyleEventArgs) Handles gvAktionen.RowStyle

        If SELECTACTIVE = False Then

            For x = 0 To gvRechte.RowCount - 1

                Dim View As GridView = sender

                If (e.RowHandle >= 0) And gvRechte.GetRowCellDisplayText(x, gvRechte.Columns(0)) <> "" Then
                    Dim Debitor As Integer = gvRechte.GetRowCellDisplayText(x, gvRechte.Columns(2))
                    Dim Aktion As Integer = gvRechte.GetRowCellDisplayText(x, gvRechte.Columns(3))
                    Dim DebitorAll As Integer = View.GetRowCellDisplayText(e.RowHandle, View.Columns(1))
                    Dim AktionAll As Integer = View.GetRowCellDisplayText(e.RowHandle, View.Columns(2))


                    Select Case Debitor & Aktion
                        Case DebitorAll & AktionAll
                            gvAktionen.SelectRow(e.RowHandle)
                     '   e.Appearance.BackColor = Color.Empty
                        Case CStr("00")
                            gvAktionen.SelectRow(0)
                            '   e.Appearance.BackColor = Color.LightSalmon

                    End Select
                End If
            Next

        End If

    End Sub

    Private Sub gvAktionen_SelectionChanged(sender As Object, e As SelectionChangedEventArgs) Handles gvAktionen.SelectionChanged

        If SELECTACTIVE = True Then

            If gvAktionen.IsRowSelected(gvAktionen.FocusedRowHandle) Then

                If CDbl(gvAktionen.GetRowCellDisplayText(gvAktionen.FocusedRowHandle, gvAktionen.Columns(1))) = 0 Then
                    'For x = 0 To gvRechte.RowCount - 1
                    Dim delUID = gvRechte.GetRowCellDisplayText(0, gvRechte.Columns(1))
                    '    gvRechte.DeleteRow(x)
                    '    If delID <> "" Then delRechte(delID)
                    'Next
                    rst = readsql("DELETE FROM Kunden.Std_Combera_PPC.Tbl_STD_BO_Rechte WHERE STD_FF_ID = " & delUID)
                    readRechte()
                    gcRechte.RefreshDataSource()
                End If

                If gvRechte.RowCount > 0 And gvRechte.GetRowCellDisplayText(0, gvRechte.Columns(2)) <> "" Then
                    If CDbl(gvRechte.GetRowCellDisplayText(0, gvRechte.Columns(2))) = 0 Then
                        Dim delID = gvRechte.GetRowCellDisplayText(0, gvRechte.Columns(0))
                        gvRechte.DeleteRow(0)
                        delRechte(delID)
                    End If
                    readRechte()
                    gcRechte.RefreshDataSource()
                End If

                gvRechte.AddNewRow()
                Dim newRowHandle As Integer = gvRechte.FocusedRowHandle

                Dim UserID = gvUser.GetRowCellDisplayText(gvUser.FocusedRowHandle, gvUser.Columns(0))
                Dim Debit = gvAktionen.GetRowCellDisplayText(gvAktionen.FocusedRowHandle, gvAktionen.Columns(1))
                Dim AktNr = gvAktionen.GetRowCellDisplayText(gvAktionen.FocusedRowHandle, gvAktionen.Columns(2))
                Dim GuelVon = Format(Date.Now, "dd.MM.yyyy")
                Dim GuelBis = "31.12.2099"

                gvRechte.SetRowCellValue(newRowHandle, gvRechte.Columns("STD_FF_ID"), UserID)
                gvRechte.SetRowCellValue(newRowHandle, gvRechte.Columns("Debitorennummer"), Debit)
                gvRechte.SetRowCellValue(newRowHandle, gvRechte.Columns("Aktionsnummer"), AktNr)
                gvRechte.SetRowCellValue(newRowHandle, gvRechte.Columns("GueltigVon"), GuelVon)
                gvRechte.SetRowCellValue(newRowHandle, gvRechte.Columns("GueltigBis"), GuelBis)

                gvRechte.UpdateCurrentRow()
                saveRechte(CInt(UserID), CInt(Debit), CInt(AktNr), CDate(GuelVon), CDate(GuelBis))
                readRechte()
            Else
                Dim delRowhandle As Integer = GetRowHandleByColumnValue(gvRechte, "Debitorennummer", gvAktionen.GetRowCellDisplayText(gvAktionen.FocusedRowHandle, gvAktionen.Columns(1)), "Aktionsnummer", gvAktionen.GetRowCellDisplayText(gvAktionen.FocusedRowHandle, gvAktionen.Columns(2)))
                Dim delID = gvRechte.GetRowCellDisplayText(delRowhandle, gvRechte.Columns(0))
                If delID <> "" Then delRechte(delID)
                gvRechte.DeleteRow(delRowhandle)
                readRechte()
            End If
            gcRechte.RefreshDataSource()
            readAktionen()

        End If

        SELECTACTIVE = False

    End Sub

    Private Sub gvAktionen_RowClick(sender As Object, e As RowClickEventArgs) Handles gvAktionen.RowClick

        SELECTACTIVE = True

    End Sub
    Private Function GetRowHandleByColumnValue(ByVal view As GridView, ByVal ColumnFieldName As String, ByVal value As Object, Optional ByVal ColumnFieldName2 As String = "", Optional ByVal value2 As Object = Nothing) As Integer
        Dim result As Integer = gcRechte.InvalidRowHandle
        Dim Search2
        Dim i As Integer

        For i = 0 To view.RowCount - 1
            If Search2 Is Nothing Then
                If view.GetDataRow(i)(ColumnFieldName) = value Then
                    Return i
                End If
            Else
                If view.GetDataRow(i)(ColumnFieldName) = value And view.GetDataRow(i)(ColumnFieldName2) = value2 Then
                    Return i
                End If
            End If

        Next
        Return result
    End Function
    Private Sub saveRechte(UserID As Integer, Debit As Integer, AktNr As Integer, GuelVon As Date, GuelBis As Date)

        rst = readsql(String.Concat("INSERT INTO Kunden.Std_Combera_PPC.Tbl_STD_BO_Rechte (STD_FF_ID, Debitorennummer, Aktionsnummer, GueltigVon, GueltigBis ) VALUES (",
                                    UserID, ",", Debit, ",", AktNr, ",'", GuelVon, "','", GuelBis, "')"))
    End Sub

    Private Sub readAktionen()

        rst2 = readsql("SELECT Bezeichnung, debitoren_nummer, Aktionsnummer FROM Kunden.Std_Combera_PPC.Tbl_Optionen ORDER BY Debitoren_Nummer")
        gcAktionen.DataSource = rst2

        ' =============================================
        ' add new row for Admin entry
        Dim newRow As DataRow = (TryCast(gcAktionen.DataSource, DataTable)).NewRow()
        newRow("Bezeichnung") = "Admin"
        newRow("debitoren_nummer") = 0
        newRow("Aktionsnummer") = 0

        TryCast(gcAktionen.DataSource, DataTable).Rows.InsertAt(newRow, 0)   ' .Add(newRow)
        gcAktionen.RefreshDataSource()
        ' =============================================

    End Sub

    Private Sub delRechte(DelID As Integer)

        rst = readsql("DELETE FROM Kunden.Std_Combera_PPC.Tbl_STD_BO_Rechte WHERE STD_FF_Access_ID = " & DelID)

    End Sub

    Private Sub readRechte()

        Dim row As System.Data.DataRow = gvUser.GetDataRow(gvUser.FocusedRowHandle)
        rst = readsql("SELECT * FROM Kunden.Std_Combera_PPC.Tbl_STD_BO_Rechte WHERE STD_FF_ID = " & row("STD_FF_ID").ToString)
        gcRechte.DataSource = rst

    End Sub

    Private Sub saveUser(UName As String, Optional ByVal Mail As String = "", Optional ByVal Rights As String = "")

        rst = readsql(String.Concat("INSERT INTO Kunden.Std_Combera_PPC.Tbl_STD_BO_User (UserName, Mailadresse, Berechtigung) VALUES ('", UName, "', '", Mail, "','", Rights, "')"))
        gcUser.DataSource = rst

    End Sub
    Private Sub readUser()

        rst = readsql("SELECT * FROM Kunden.Std_Combera_PPC.Tbl_STD_BO_User ORDER BY UserName")
        gcUser.DataSource = rst
        gvUser.OptionsBehavior.Editable = False

    End Sub

    Private Sub delUser(DelID As Integer)

        SELECTACTIVEUSER = False

        Dim ans = MsgBox("Soll der Benutzer wirklich gelöscht werden? Es werden auch alle zugehörigen Aktionen gelöscht.", vbYesNo, "Benutzer löschen")

        If ans = vbYes Then
            rst = readsql("DELETE FROM Kunden.Std_Combera_PPC.Tbl_STD_BO_User WHERE STD_FF_ID = " & DelID)
            rst = readsql("DELETE FROM Kunden.Std_Combera_PPC.Tbl_STD_BO_Rechte WHERE STD_FF_ID = " & DelID)
        End If

    End Sub

    Private Sub readAllUser()

        rst2 = readsql("SELECT name AS Name FROM sysusers where status = 12 order by name")
        gcAllUser.DataSource = rst2

    End Sub

    Private Sub gvUser_FocusedColumnChanged(sender As Object, e As FocusedColumnChangedEventArgs) Handles gvUser.FocusedColumnChanged

        Dim Mail = gvUser.GetFocusedRowCellDisplayText("Mailadresse").ToString
        Dim Rights = gvUser.GetFocusedRowCellDisplayText("Berechtigung").ToString
        Dim UID = gvUser.GetFocusedRowCellDisplayText("STD_FF_ID").ToString

        If Rights <> "" Then
            rst = readsql(String.Concat("UPDATE Kunden.Std_Combera_PPC.Tbl_STD_BO_User SET Mailadresse = '", Mail, "', Berechtigung = '", Rights, "' WHERE STD_FF_ID = ", UID))
        End If

    End Sub
    Private Sub gvRechte_FocusedColumnChanged(sender As Object, e As FocusedColumnChangedEventArgs) Handles gvRechte.FocusedColumnChanged

        Dim Von = gvRechte.GetFocusedRowCellDisplayText("GueltigVon")
        Dim Bis = gvRechte.GetFocusedRowCellDisplayText("GueltigBis")
        Dim RID = gvRechte.GetFocusedRowCellDisplayText("STD_FF_Access_ID")

        If RID <> "" Then
            rst = readsql(String.Concat("UPDATE Kunden.Std_Combera_PPC.Tbl_STD_BO_Rechte SET GueltigVon = '", Von, "', GueltigBis = '", Bis, "' WHERE STD_FF_Access_ID = ", RID))
        End If
    End Sub
End Class
