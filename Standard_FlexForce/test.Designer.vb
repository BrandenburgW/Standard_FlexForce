<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class test
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BssProdukte1 = New Standard_FlexForce.BSSProdukte()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.UserVerwaltung1 = New Standard_FlexForce.UserVerwaltung()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1289, 106)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(83, 75)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BssProdukte1
        '
        Me.BssProdukte1.Location = New System.Drawing.Point(1002, 27)
        Me.BssProdukte1.Name = "BssProdukte1"
        Me.BssProdukte1.Size = New System.Drawing.Size(253, 576)
        Me.BssProdukte1.TabIndex = 0
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1289, 197)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(83, 75)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'UserVerwaltung1
        '
        Me.UserVerwaltung1.Location = New System.Drawing.Point(12, 58)
        Me.UserVerwaltung1.Name = "UserVerwaltung1"
        Me.UserVerwaltung1.Size = New System.Drawing.Size(936, 441)
        Me.UserVerwaltung1.TabIndex = 3
        '
        'test
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1406, 772)
        Me.Controls.Add(Me.UserVerwaltung1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BssProdukte1)
        Me.Name = "test"
        Me.Text = "test"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BssProdukte1 As BSSProdukte
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents UserVerwaltung1 As UserVerwaltung
End Class
