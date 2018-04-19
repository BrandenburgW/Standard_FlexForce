Imports DevExpress.XtraVerticalGrid.Rows
Imports DevExpress.XtraVerticalGrid
Imports DevExpress.Utils
Imports DevExpress.XtraEditors.Repository

Public Class dashMarkt_Fragen
    Private Sub dashMarkt_Fragen_Load(sender As Object, e As EventArgs) Handles Me.Load

        ladeFragen(89198)

    End Sub

    Public Sub ladeFragen(CID As Integer)

        If Not frmMain.WaitFormManager.IsSplashFormVisible Then frmMain.WaitFormManager.ShowWaitForm()
        frmMain.WaitFormManager.SetWaitFormDescription("Lade Fragen")

        rst = readsql("SELECT x4Fragetext, Antwort FROM Kunden.Std_Combera_PPC.vw_besuche_fragen AS txt LEFT JOIN Kunden.Std_Combera_PPC.vw_letzte_Besuche AS bes " &
                        "ON txt.x1combera_id = bes.x1combera_id WHERE txt.x2Besuchsdatum =bes.x2Besuchsdatum AND txt.x1combera_id = " & CID & " AND txt.debitoren_nummer = " & DEBITOR &
                        " AND txt.aktionsnummer = " & AKTIONSNR)

        Dim row As EditorRow

        For x = 0 To rst.Rows.Count - 1
            row = New EditorRow()
            row.Properties.Caption = rst.Rows(x)("x4Fragetext").ToString
            row.Properties.FieldName = "Frage" & x
            row.Properties.Value = rst.Rows(x)("Antwort")
            vgFragen.Rows.Add(row)

        Next

        frmMain.WaitFormManager.CloseWaitForm()

    End Sub




End Class
