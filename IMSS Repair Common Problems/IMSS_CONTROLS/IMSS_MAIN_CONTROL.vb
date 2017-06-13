Public Class IMSS_MAIN_CONTROL
    Private Shared _IMSS_CONTROL As IMSS_MAIN_CONTROL
    Friend Shared Function _IMSS_CREATE_CONTROl() As IMSS_MAIN_CONTROL
        If _IMSS_CONTROL Is Nothing Then
            _IMSS_CONTROL = New IMSS_MAIN_CONTROL
        End If
        Return _IMSS_CONTROL
    End Function

    Private Sub _IMSS_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_Close.Click
        Application.Exit()
    End Sub

    Private Sub _IMSS_Next_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_Next.Click
        Dim _IMSS_CheckedItems As Boolean = False
        _IMSS_Next.Enabled = False
        _IMSS_LoadingUint(True)
        _IMSS_MainCore_Starts()
        _IMSS_LoadingUint(False)
        _IMSS_Next.Enabled = True
        For Each _IMSS_Item In _IMSS_MainListView
            If _IMSS_Item.Checked = True Then
                _IMSS_CheckedItems = True
                _IMSS_Item.Checked = False
            End If
        Next _IMSS_Item
        If _IMSS_CheckedItems = True Then
            MessageBox.Show("All selected option have been restored successfully !", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        End If
    End Sub
    Private Sub _IMSS_LoadingUint(ByVal _IMSS_STATUS As Boolean)
        _IMSS_Loading_PictureBox.Enabled = _IMSS_STATUS
        _IMSS_Loading_PictureBox.Visible = _IMSS_STATUS
    End Sub
    Private Function _IMSS_CheckItem(ByVal _IMSS_ITEM_INDEX As Short)
        If _IMSS_MainListView.Items(_IMSS_ITEM_INDEX).Checked = True Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Sub _IMSS_MainCore_Starts()
        If _IMSS_CheckItem(0) = True Then
            Dim regloc As String = "HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced"
            My.Computer.Registry.SetValue(regloc, "Hidden", "2", Microsoft.Win32.RegistryValueKind.DWord)
        End If
        If _IMSS_CheckItem(1) = True Then
            Dim regloc As String = "HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Policies"
            My.Computer.Registry.SetValue(regloc, "NoFolderOptions", "0", Microsoft.Win32.RegistryValueKind.DWord)
        End If
        If _IMSS_CheckItem(2) = True Then
            Shell("REG add HKCU\Software\Microsoft\Windows\CurrentVersion\Policies\System  /v  DisableTaskMgr  /t REG_DWORD  /d /0 /f")
        End If
        If _IMSS_CheckItem(3) = True Then
            Shell("REG add HKCU\Software\Microsoft\Windows\CurrentVersion\Policies\System /v DisableRegistryTools /t REG_DWORD /d 0 /f")
        End If
        If _IMSS_CheckItem(4) = True Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Policies\Microsoft\Windows\System", "DisableCMD", "0", Microsoft.Win32.RegistryValueKind.DWord)
        End If
        If _IMSS_CheckItem(5) = True Then
            Try
                Dim Proc As Process = New Process
                Dim top As String = "netsh.exe"
                Proc.StartInfo.Arguments = ("firewall set opmode enable")
                Proc.StartInfo.FileName = top
                Proc.StartInfo.UseShellExecute = False
                Proc.StartInfo.RedirectStandardOutput = True
                Proc.StartInfo.CreateNoWindow = True
                Proc.Start()
                Proc.WaitForExit()
            Catch : End Try
        End If
    End Sub
End Class
