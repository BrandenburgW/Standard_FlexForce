Public Class LoginForm
    Public Sub New()

        InitializeComponent()

        Try

            If My.Computer.Network.Ping("dmsql01") Then
                '  MsgBox("Connection ok", vbExclamation)
            Else
                MsgBox("Es besteht keine Verbindung zum Datenbankserver. Das Programm wird beendet", vbExclamation, "Verbindungsfehler")
                End
            End If

        Catch
            Dim Fehler = Err.Number
            Dim des = Err.Description

            MsgBox(des, vbOKOnly, "Verbindungsfehler")
        End Try


    End Sub
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        DEBITOR = CInt(splitString(cboUserAktionen.Text, "|", 2))
        AKTIONSNR = CInt(splitString(cboUserAktionen.Text, "| lfd. Aktionsnr.", 2))
        AKTION = splitString(cboUserAktionen.Text, "|", 1)

        frmMain.Show()
        Me.Hide()

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        SaveOptions()
        Me.Close()
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles Me.Load

        UsernameTextBox.Text = GetUserName()
        cboUserAktionen.Items.Clear()
        OK.Enabled = False

        rst = readsql("SELECT Kunden.Std_Combera_PPC.Tbl_STD_BO_User.*, Kunden.Std_Combera_PPC.Tbl_STD_BO_Rechte.*, Bezeichnung FROM Kunden.Std_Combera_PPC.Tbl_STD_BO_User " &
                        "LEFT JOIN Kunden.Std_Combera_PPC.Tbl_STD_BO_Rechte ON Kunden.Std_Combera_PPC.Tbl_STD_BO_User.STD_FF_ID = Kunden.Std_Combera_PPC.Tbl_STD_BO_Rechte.STD_FF_ID " &
                        "LEFT JOIN Kunden.Std_Combera_PPC.Tbl_Optionen ON Kunden.Std_Combera_PPC.Tbl_STD_BO_Rechte.Debitorennummer = Kunden.Std_Combera_PPC.Tbl_Optionen.Debitoren_Nummer " &
                        "WHERE UserName = '" & UsernameTextBox.Text & "' ANd GETDATE() BETWEEN GueltigVon AND GueltigBis AND (Kunden.Std_Combera_PPC.Tbl_Optionen.aktiv = 1 OR Kunden.Std_Combera_PPC.Tbl_Optionen.aktiv IS NULL) " &
                        "ORDER By Bezeichnung")


        If rst.Rows.Count = 0 Then
            MsgBox("Es gibt für diesen Mitarbeiter keine hinterlegte Aktion", vbOKOnly, "Fehler bei der Anmeldung")
        ElseIf rst.Rows.Count = 1 And rst.Rows(0)("Berechtigung").ToString <> "Superuser" Then
            OK.Enabled = True
            cboUserAktionen.Text = rst.Rows(0)("Bezeichnung").ToString & "|" & rst.Rows(0)("debitorennummer").ToString & "| lfd. Aktionsnr." & rst.Rows(0)("Aktionsnummer").ToString
            cboUserAktionen.Enabled = False
            USERNAME = UsernameTextBox.Text
            RECHTE = rst.Rows(0)("Berechtigung").ToString
            AKTION = rst.Rows(0)("Bezeichnung").ToString
        Else
            OK.Enabled = True
            If CInt(rst.Rows(0)("Debitorennummer")) = 0 Then
                rst2 = readsql("SELECT Bezeichnung, debitoren_nummer, Aktionsnummer FROM Kunden.Std_Combera_PPC.Tbl_Optionen ORDER BY Debitoren_Nummer")
                For x = 0 To rst2.Rows.Count - 1
                    cboUserAktionen.Items.Add(rst2.Rows(x)("Bezeichnung").ToString & "|" & rst2.Rows(x)("debitoren_nummer").ToString & "| lfd. Aktionsnr." & rst2.Rows(x)("Aktionsnummer").ToString)
                Next
            Else
                For x = 0 To rst.Rows.Count - 1
                    cboUserAktionen.Items.Add(rst.Rows(x)("Bezeichnung").ToString & "|" & rst.Rows(x)("debitorennummer").ToString & "| lfd. Aktionsnr." & rst.Rows(x)("Aktionsnummer").ToString)
                Next
            End If

            cboUserAktionen.Enabled = True
            USERNAME = UsernameTextBox.Text
            RECHTE = rst.Rows(0)("Berechtigung").ToString
            AKTION = rst.Rows(0)("Bezeichnung").ToString
        End If

    End Sub
End Class
