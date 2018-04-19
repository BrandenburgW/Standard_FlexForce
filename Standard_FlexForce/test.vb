
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.Utils
Imports DevExpress.Utils.Drawing


Public Class test
    Private Sub test_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Dim cEinzel = New Einzelbesuch


        'Dim Filter = " AND x1Combera_ID = 300799"


        'BssProdukte1.gcBSSProdukte.DataSource = Nothing

        'rst = readsql("SELECT * FROM Kunden.Std_Combera_PPC.Tbl_BSS_Produkte WHERE debitoren_nummer = " & DEBITOR & " AND aktionsnummer = " & AKTIONSNR & Filter & " ORDER BY x2Besuchsdatum DESC")

        'If rst.Rows.Count = 0 Then
        '    MsgBox("Es sind keine Besuche in den letzten 7 Tagen bzw. im gewünschten Zeitraum vorhanden.", vbOKOnly, "Besuche")
        'Else
        '    BssProdukte1.gcBSSProdukte.DataSource = rst
        'End If





        'rst = readsql("SELECT bssFotosID, Fotos.debitoren_nummer, Fotos.aktionsnummer, maID, ADM_Name, x1combera_id, x2besuchsdatum, dateiname, bezeichnung, aktiv " &
        '      "FROM Kunden.Std_Combera_PPC.Tbl_BSS_Fotos AS Fotos " &
        '        "LEFT JOIN Kunden.Std_Combera_PPC.Tbl_Fotokategorien As FotoKat ON Fotos.debitoren_nummer = Fotokat.debitoren_nummer " &
        '        "AND Fotos.aktionsnummer = FotoKat.aktionsnummer AND Fotos.schluessel = FotoKat.schluessel " &
        '        "WHERE Fotos.debitoren_nummer = " & DEBITOR & " AND Fotos.aktionsnummer = " & AKTIONSNR & Filter & " ORDER BY x2Besuchsdatum DESC")

        'If rst.Rows.Count = 0 Then
        '    MsgBox("Es sind keine Fotos in den letzten 7 Tagen bzw. im gewünschten Zeitraum vorhanden.", vbOKOnly, "Besuche")
        'Else
        '    cEinzel.GalleryControl1.Gallery.ShowItemText = True

        '    Dim group1 As GalleryItemGroup = New GalleryItemGroup()
        '    group1.Caption = "Cars"
        '    cEinzel.GalleryControl1.Gallery.Groups.Add(group1)
        '    cEinzel.GalleryControl1.Gallery.ItemImageLayout = ImageLayoutMode.ZoomInside
        '    cEinzel.GalleryControl1.Gallery.ImageSize = New Size(120, 90)


        '    'For p = 0 To rst.Rows.Count - 1

        '    '    Dim thumbnail As Image = Image.FromFile(Settings.Default.Fotopfad & rst.Rows(p)("dateiname").ToString)
        '    '    group1.Items.Add(New DevExpress.XtraBars.Ribbon.GalleryItem(thumbnail, rst.Rows(p)("bezeichnung").ToString, ""))
        '    'Next



        'End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        BssProdukte1.FillGridProdukte(" AND x1Combera_ID = 300799")


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


        BssProdukte1.FillGridProdukte(" AND x1Combera_ID = 29151")


    End Sub
End Class