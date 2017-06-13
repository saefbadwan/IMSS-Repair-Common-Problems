Public Class MainWindow
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me._IMSS_MainPanel.Controls.Add(IMSS_MAIN_CONTROL._IMSS_CREATE_CONTROl())
    End Sub
End Class
