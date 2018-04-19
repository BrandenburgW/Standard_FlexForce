
Imports System.Data.OleDb
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Globalization

Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.Strings

Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Layout
Imports System.Text

Module Tools

    Public con As SqlConnection
    Public cmd As SqlCommand
    Public rst As System.Data.DataTable
    Public rst2 As System.Data.DataTable
    Public rst3 As System.Data.DataTable

    Public TESTVERSION As Boolean
    Public TESTSERVER As String
    Public DATABASE_SQL02 As String = "POS_Intern"
    Public DATABASE_SQL01 As String = "Kunden"
    Public DATABASE As String

    Public USERNAME As String
    Public AKTION As String
    Public DEBITOR As Integer
    Public AKTIONSNR As Integer
    Public RECHTE As String

    Public Function readsql(ByVal StrSql As String) As System.Data.DataTable  ' SqlDataReader

        Dim conn As OleDb.OleDbConnection
        Dim da As OleDb.OleDbDataAdapter
        Dim cb As OleDb.OleDbCommandBuilder
        Dim data As System.Data.DataTable
        Dim connStr As String

        If TESTVERSION = False Then
            connStr = String.Format("Provider=SQLOLEDB.1;Persist Security Info=False;Integrated Security=SSPI;Data Source=DMSQL01;Initial Catalog=" & DATABASE, "", "", "")
        Else
            If TESTSERVER = "lokal" Then
                connStr = String.Format("Provider=SQLOLEDB.1;Persist Security Info=False;Integrated Security=SSPI;Data Source=LT-5075\SQLEXPRESS;Initial Catalog=" & DATABASE, "", "", "")
            Else
                connStr = String.Format("Provider=SQLOLEDB.1;Persist Security Info=False;Integrated Security=SSPI;Data Source=DMSQL02;Initial Catalog=" & DATABASE_SQL02, "", "", "")
            End If
        End If


        Try
            conn = New OleDb.OleDbConnection(connStr)
            conn.Open()

            '   conn.ChangeDatabase(TABLE)
            data = New System.Data.DataTable

            da = New OleDb.OleDbDataAdapter(StrSql, conn)
            cb = New OleDb.OleDbCommandBuilder(da)

            da.Fill(data)
            readsql = data

            conn.Close()

        Catch ex As OleDb.OleDbException
            '  MsgBox(data.AsDataView)

            Dim fehler = Err.Number
            Dim des = Err.Description

            Select Case fehler
                Case 5
                    MsgBox(des, vbOKOnly, "!! Schwerwiegender Fehler !!")
                    ' MsgBox("Es kann keine Verbindung zum Datenbank-Server hergestellt werden." & vbCrLf & vbCrLf & "Programm wird beendet", vbOKOnly, "!! Schwerwiegender Fehler !!")
                    ' Application.Exit()
                Case Else
                    MsgBox("Error connecting to the server: " + ex.Message)
            End Select

            End     ' Programm beenden
            Application.Exit()

        End Try


    End Function

    Public Function GetUserName() As String
        ' Returns the network login name

        If TypeOf My.User.CurrentPrincipal Is Security.Principal.WindowsPrincipal Then
            ' The application is using Windows authentication.
            ' The name format is DOMAIN\USERNAME.
            Dim parts() As String = Split(My.User.Name, "\")
            Dim username As String = parts(1)
            Return username
        Else
            ' The application is using custom authentication.
            Return My.User.Name
        End If

    End Function

    Public Function GetMachineName() As String
        'Returns the computername

        Dim ComputerName As String
        ComputerName = System.Net.Dns.GetHostName
        Return ComputerName

    End Function

    Public Function splitString(str As String, trenner As String, teilzurueck As Integer) As String

        Dim parts = Split(StrConv(str, vbProperCase), StrConv(trenner, vbProperCase))

        If parts.Length > 1 Then

            If Len(str) > 0 Then
                Return parts(teilzurueck - 1)
            Else
                Return ""
            End If
        Else
            Return str
        End If

    End Function

    Public Function FromUnixTime(UnixTime As Double) As Date
        Dim date1 As Date = #1/1/1970#
        FromUnixTime = date1.AddSeconds(UnixTime)
        ' FromUnixTime = DateAdd("s", UnixTime, DateSerial(1970, 1, 1))
    End Function

    Public Function ToUnixTime(time As Date) As Long
        ToUnixTime = DateDiff("s", DateSerial(1970, 1, 1), time)
    End Function


    Public Function GetMondayDateOfWeek(week As Integer, year As Integer) As DateTime
        Dim i As Integer = CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(New DateTime(year, 1, 1), CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday)

        If i = 1 Then
            Return CultureInfo.CurrentCulture.Calendar.AddDays(New DateTime(year, 1, 1), ((week - 1) * 7 - GetDayCountFromMonday(CultureInfo.CurrentCulture.Calendar.GetDayOfWeek(New DateTime(year, 1, 1))) + 1))
        Else
            Dim x As Integer = Convert.ToInt32(CultureInfo.CurrentCulture.Calendar.GetDayOfWeek(New DateTime(year, 1, 1)))
            Return CultureInfo.CurrentCulture.Calendar.AddDays(New DateTime(year, 1, 1), ((week - 1) * 7 + (7 - GetDayCountFromMonday(CultureInfo.CurrentCulture.Calendar.GetDayOfWeek(New DateTime(year, 1, 1)))) + 1))
        End If
    End Function

    'Gibt den Wochentag als Zahl zurück, Montag entspricht 1
    Public Function GetDayCountFromMonday(dow As DayOfWeek) As Integer
        Select Case dow
            Case DayOfWeek.Monday
                Return 1
            Case DayOfWeek.Tuesday
                Return 2
            Case DayOfWeek.Wednesday
                Return 3
            Case DayOfWeek.Thursday
                Return 4
            Case DayOfWeek.Friday
                Return 5
            Case DayOfWeek.Saturday
                Return 6
            Case Else
                'Sunday
                Return 7
        End Select
    End Function
    Public Function CalcHardwarePreis(preis As Double, anschaffung As Date) As Double

        Dim AnzTage = DateDiff(DateInterval.Day, anschaffung, Now)
        ' Der Wert eines Gerätes wird ermittelt aus dem Anfangspreis abzgl. 3% pro 100 Tage auf den Ausgangspreis
        Dim Abschlag = preis - Math.Round(preis * AnzTage / 100 * 0.03)
        Return Abschlag

    End Function

    Public Sub OpenMail(MailEmpfaenger As String)

        Try

            Dim Outl As Object
            Outl = CreateObject("Outlook.Application")
            If Outl IsNot Nothing Then
                Dim omsg As Object
                omsg = Outl.CreateItem(0)
                omsg.To = MailEmpfaenger
                ' omsg.bcc = "yusuf@gmail.com"
                ' omsg.subject = "Hello"
                ' omsg.body = "godmorning"
                ' omsg.Attachments.Add("c:\HP\opcserver.txt")
                'set message properties here...'
                omsg.Display(True) 'will display message to user
            End If

        Catch
            MsgBox("Microsoft Outlook ist nicht installiert oder richtig eingerichtet.", vbOKOnly, "Fehler")
        End Try

    End Sub
    Public Sub SaveOptions()

        Dim User = GetUserName()
        Dim chkSave As Boolean = False

        rst = readsql("UPDATE Kunden.Std_Combera_PPC.Tbl_STD_BO_User Set LastLogin =  + CONVERT(datetime,GETDATE()) WHERE UserName Like '" & User & "'")

    End Sub
    Public Sub ReadOptions()

        Dim User = GetUserName()
        Dim Machine = GetMachineName()

        'rst3 = readsql("SELECT * FROM tbl_POS_intern_Optionen WHERE UserName LIKE '" & User & "' AND UserComputer LIKE '" & Machine & "'")

        'With StartMenue
        '    If CInt(rst3(0)("OptLastPage")) = 1 Then
        '        If .chkLastMitarbeiter.Checked = True Then
        '            rst = readsql("SELECT * FROM dbo.vw_POSI_read_customer ORDER BY Name ASC")
        '            .GridControlMitarbeiter.DataSource = rst

        '            Dim rowTarget = .GridViewMitarbeiter.LocateByValue("Ident_Nummer", rst3(0)("OptLastMitarbeiterID"), Nothing)
        '            If (rowTarget <> DevExpress.XtraGrid.GridControl.InvalidRowHandle) Then
        '                .GridViewMitarbeiter.FocusedRowHandle = rowTarget
        '                .GridViewMitarbeiter.TopRowIndex = rowTarget
        '                .TabPane1.SelectedPageIndex = 0
        '                .NavBarControlMitarbeiter.SelectedLink = .NavBarControlMitarbeiter.Groups(0).ItemLinks(0)
        '            End If
        '            StartMenue.ChangeOfficeNavigator("Mitarbeiter")
        '            ' StartMenue.Refresh()
        '        End If
        '    End If

        '    If CInt(rst3(0)("OptLastPage")) = 2 Then
        '        If .chkLastHardware.Checked = True Then
        '            rst = readsql("SELECT Control.Tbl_Android_Devices_User.*, Control.Tbl_POSI_Geraete.Geraetetyp FROM Control.Tbl_Android_Devices_User LEFT JOIN Control.Tbl_POSI_Geraete ON Tbl_Android_Devices_User.mod_id= Tbl_POSI_Geraete.mod_id ORDER BY owner ASC")
        '            .GridControlHardware.DataSource = rst

        '            StartMenue.ChangeOfficeNavigator("Hardware")

        '            Dim rowTargetHW = .GridViewHardware.LocateByValue("DevicesUserID", rst3(0)("OptLastHardwareID"), Nothing)
        '            If (rowTargetHW <> DevExpress.XtraGrid.GridControl.InvalidRowHandle) Then
        '                .GridViewHardware.FocusedRowHandle = rowTargetHW
        '                .GridViewHardware.TopRowIndex = rowTargetHW
        '                .TabPane2.SelectedPageIndex = 0
        '                .NavBarControlHardware.SelectedLink = .NavBarControlHardware.Groups(0).ItemLinks(0)
        '            End If
        '        End If
        '    End If

        '    If .chkLastPage.Checked = True Then
        '        .NavigationFrame1.SelectedPageIndex = CInt(rst3(0)("OptLastPage"))

        '        Select Case CInt(rst3(0)("OptLastPage"))
        '            Case 3 ' SyncFiles
        '                .ChangeOfficeNavigator("SyncFiles")
        '            Case 4 ' Tools
        '                .NavBarControlTools.SelectedLink = StartMenue.NavBarControlTools.Groups(0).ItemLinks(1)  ' rst2(0)("ToolsEntry")
        '                .NavBarControlTools.SelectedLink.PerformClick()
        '                .ChangeOfficeNavigator("Tools")
        '            Case 5 'Jobseite

        '                .ChangeOfficeNavigator("Jobs")
        '        End Select

        '    End If

        ' End With

    End Sub

    Public Function calcPrio(StartDatum As Date, EndeDatum As Date) As Integer

        Dim Delta = DateDiff(DateInterval.Day, StartDatum, EndeDatum)

        Select Case Delta
            Case 0 To 3
                Return 1
            Case 4 To 6
                Return 2
            Case 7 To 10
                Return 3
            Case > 11
                Return 4
            Case < 0
                Return 1
            Case Else
                Return 0
        End Select

    End Function

    Public Function ErsetzeUmlaute(Originaltext As String) As String

        Dim NeuerText As String

        NeuerText = Replace(Originaltext, "ä", "ae")
        NeuerText = Replace(NeuerText, "ö", "oe")
        NeuerText = Replace(NeuerText, "ü", "ue")
        NeuerText = Replace(NeuerText, "ß", "ss")

        Return NeuerText

    End Function

    Public Function CheckSyncFileName(Original As String) As String

        Dim ZeichenOld = New String() {" ", "ö", "ä", "ü", "ß"}
        Dim ZeichenNew = New String() {"_", "oe", "ae", "ue", "ss"}
        Dim INVALID As Boolean = False

        For x = 0 To ZeichenOld.Length - 1
            If InStr(Original, ZeichenOld(x)) > 1 Then
                Original = Replace(Original, ZeichenOld(x), ZeichenNew(x))
                INVALID = True
            End If
        Next

        If INVALID = True Then
            MsgBox("Der Dateiname enthielt ungültige Zeichen wie Umlaute oder Leerzeichen. Dies wurde korrigiert. Bitte auch Dateinamen anpassen", vbOKOnly, "Fehlerhafter Dateiname")
        End If

        Return Original

    End Function

    Public Function ConvertFileNameDate2Date(FileNameDate As String) As Date

        If Not FileNameDate = Nothing Then
            Dim Jahr As String = Left(FileNameDate, 4)
            Dim Monat As String = FileNameDate.Substring(4, 2)
            Dim Tag As String = Right(FileNameDate, 2)

            Return CDate(Tag & "." & Monat & "." & Jahr)

        Else
            Return Nothing
        End If
    End Function

    Public Function RemoveLastCharacter(Original As String, LastChar As String) As String

        Dim retString As String

        If Right(Original, 1) = LastChar Then
            retString = Left(Original, Len(Original) - 1)
        Else
            retString = Original
        End If

        Return retString

    End Function

    Public Function getNumeric(value As String) As String
        Dim output As StringBuilder = New StringBuilder
        For i = 0 To value.Length - 1
            If IsNumeric(value(i)) Then
                output.Append(value(i))
            End If
        Next
        Return output.ToString()

    End Function

End Module
