<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IMSS_MAIN_CONTROL
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim _IMSS_ShowFolders As ComponentOwl.BetterListView.BetterListViewItem
        Dim _IMSS_TaskManager As ComponentOwl.BetterListView.BetterListViewItem
        Dim _IMSS_Regedit As ComponentOwl.BetterListView.BetterListViewItem
        Dim _IMSS_Cmd As ComponentOwl.BetterListView.BetterListViewItem
        Dim _IMSS_FolderOptions As ComponentOwl.BetterListView.BetterListViewItem
        Dim _IMSS_WindowsFirewall As ComponentOwl.BetterListView.BetterListViewItem
        Me._IMSS_FileFoldersProblems = New ComponentOwl.BetterListView.BetterListViewGroup()
        Me._IMSS_SystemProbelms = New ComponentOwl.BetterListView.BetterListViewGroup()
        Me._IMSS_MainListView = New ComponentOwl.BetterListView.BetterListView()
        Me._IMSS_ControlHolder_Panel = New DevComponents.DotNetBar.PanelEx()
        Me._IMSS_Close = New System.Windows.Forms.Button()
        Me._IMSS_Next = New System.Windows.Forms.Button()
        Me._IMSS_Description_Label = New DevComponents.DotNetBar.LabelX()
        Me._IMSS_Title_Label = New DevComponents.DotNetBar.LabelX()
        Me._IMSS_Loading_PictureBox = New System.Windows.Forms.PictureBox()
        _IMSS_ShowFolders = New ComponentOwl.BetterListView.BetterListViewItem()
        _IMSS_TaskManager = New ComponentOwl.BetterListView.BetterListViewItem()
        _IMSS_Regedit = New ComponentOwl.BetterListView.BetterListViewItem()
        _IMSS_Cmd = New ComponentOwl.BetterListView.BetterListViewItem()
        _IMSS_FolderOptions = New ComponentOwl.BetterListView.BetterListViewItem()
        _IMSS_WindowsFirewall = New ComponentOwl.BetterListView.BetterListViewItem()
        CType(Me._IMSS_MainListView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._IMSS_ControlHolder_Panel.SuspendLayout()
        CType(Me._IMSS_Loading_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_IMSS_ShowFolders
        '
        _IMSS_ShowFolders.Group = Me._IMSS_FileFoldersProblems
        _IMSS_ShowFolders.Name = "_IMSS_ShowFolders"
        _IMSS_ShowFolders.Text = "Reapir ""Show Heden Folder Not Working"""
        '
        '_IMSS_FileFoldersProblems
        '
        Me._IMSS_FileFoldersProblems.Font = New System.Drawing.Font("Segoe UI", 10.66667!)
        Me._IMSS_FileFoldersProblems.Header = "Problems working with files and folders"
        Me._IMSS_FileFoldersProblems.Name = "_IMSS_FileFoldersProblems"
        '
        '_IMSS_TaskManager
        '
        _IMSS_TaskManager.Group = Me._IMSS_SystemProbelms
        _IMSS_TaskManager.Name = "_IMSS_TaskManager"
        _IMSS_TaskManager.Text = """Task Manager"" Can not open"
        '
        '_IMSS_SystemProbelms
        '
        Me._IMSS_SystemProbelms.Font = New System.Drawing.Font("Segoe UI", 10.66667!)
        Me._IMSS_SystemProbelms.Header = "System problems"
        Me._IMSS_SystemProbelms.Name = "_IMSS_SystemProbelms"
        '
        '_IMSS_Regedit
        '
        _IMSS_Regedit.Group = Me._IMSS_SystemProbelms
        _IMSS_Regedit.Name = "_IMSS_Regedit"
        _IMSS_Regedit.Text = """Registry Editor"" Can not open "
        '
        '_IMSS_Cmd
        '
        _IMSS_Cmd.Group = Me._IMSS_SystemProbelms
        _IMSS_Cmd.Name = "_IMSS_Cmd"
        _IMSS_Cmd.Text = """Command Prompt"" Can not run"
        '
        '_IMSS_FolderOptions
        '
        _IMSS_FolderOptions.Group = Me._IMSS_FileFoldersProblems
        _IMSS_FolderOptions.Name = "_IMSS_FolderOptions"
        _IMSS_FolderOptions.Text = "Reapir disable ""Folder Options"""
        '
        '_IMSS_WindowsFirewall
        '
        _IMSS_WindowsFirewall.Group = Me._IMSS_SystemProbelms
        _IMSS_WindowsFirewall.Name = "_IMSS_WindowsFirewall"
        _IMSS_WindowsFirewall.Text = "Reapir ""Windows Firewail"""
        '
        '_IMSS_MainListView
        '
        Me._IMSS_MainListView.CheckBoxes = ComponentOwl.BetterListView.BetterListViewCheckBoxes.TwoState
        Me._IMSS_MainListView.Groups.AddRange(New Object() {Me._IMSS_FileFoldersProblems, Me._IMSS_SystemProbelms})
        Me._IMSS_MainListView.Items.AddRange(New Object() {_IMSS_ShowFolders, _IMSS_FolderOptions, _IMSS_TaskManager, _IMSS_Regedit, _IMSS_Cmd, _IMSS_WindowsFirewall})
        Me._IMSS_MainListView.Location = New System.Drawing.Point(7, 59)
        Me._IMSS_MainListView.MultiSelect = False
        Me._IMSS_MainListView.Name = "_IMSS_MainListView"
        Me._IMSS_MainListView.ShowEmptyGroups = True
        Me._IMSS_MainListView.ShowGroups = True
        Me._IMSS_MainListView.Size = New System.Drawing.Size(512, 326)
        Me._IMSS_MainListView.TabIndex = 0
        '
        '_IMSS_ControlHolder_Panel
        '
        Me._IMSS_ControlHolder_Panel.CanvasColor = System.Drawing.SystemColors.Control
        Me._IMSS_ControlHolder_Panel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_ControlHolder_Panel.Controls.Add(Me._IMSS_Loading_PictureBox)
        Me._IMSS_ControlHolder_Panel.Controls.Add(Me._IMSS_Close)
        Me._IMSS_ControlHolder_Panel.Controls.Add(Me._IMSS_Next)
        Me._IMSS_ControlHolder_Panel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me._IMSS_ControlHolder_Panel.Location = New System.Drawing.Point(0, 391)
        Me._IMSS_ControlHolder_Panel.Name = "_IMSS_ControlHolder_Panel"
        Me._IMSS_ControlHolder_Panel.Size = New System.Drawing.Size(527, 45)
        Me._IMSS_ControlHolder_Panel.Style.Alignment = System.Drawing.StringAlignment.Center
        Me._IMSS_ControlHolder_Panel.Style.BackColor1.Color = System.Drawing.Color.White
        Me._IMSS_ControlHolder_Panel.Style.BackColor2.Color = System.Drawing.Color.LightGray
        Me._IMSS_ControlHolder_Panel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me._IMSS_ControlHolder_Panel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me._IMSS_ControlHolder_Panel.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Top
        Me._IMSS_ControlHolder_Panel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me._IMSS_ControlHolder_Panel.Style.GradientAngle = 90
        Me._IMSS_ControlHolder_Panel.TabIndex = 1
        '
        '_IMSS_Close
        '
        Me._IMSS_Close.Location = New System.Drawing.Point(368, 11)
        Me._IMSS_Close.Name = "_IMSS_Close"
        Me._IMSS_Close.Size = New System.Drawing.Size(75, 23)
        Me._IMSS_Close.TabIndex = 1
        Me._IMSS_Close.Text = "Close"
        Me._IMSS_Close.UseVisualStyleBackColor = True
        '
        '_IMSS_Next
        '
        Me._IMSS_Next.Location = New System.Drawing.Point(449, 11)
        Me._IMSS_Next.Name = "_IMSS_Next"
        Me._IMSS_Next.Size = New System.Drawing.Size(75, 23)
        Me._IMSS_Next.TabIndex = 0
        Me._IMSS_Next.Text = "Repair"
        Me._IMSS_Next.UseVisualStyleBackColor = True
        '
        '_IMSS_Description_Label
        '
        '
        '
        '
        Me._IMSS_Description_Label.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_Description_Label.Location = New System.Drawing.Point(4, 23)
        Me._IMSS_Description_Label.Name = "_IMSS_Description_Label"
        Me._IMSS_Description_Label.Size = New System.Drawing.Size(511, 30)
        Me._IMSS_Description_Label.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me._IMSS_Description_Label.TabIndex = 2
        Me._IMSS_Description_Label.Text = "With this wizard, you can correct many frequent problems in Windows. if you are e" & _
            "xperiencing some of the problems below, select them and click ""Next""."
        Me._IMSS_Description_Label.WordWrap = True
        '
        '_IMSS_Title_Label
        '
        '
        '
        '
        Me._IMSS_Title_Label.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_Title_Label.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_Title_Label.Location = New System.Drawing.Point(3, 3)
        Me._IMSS_Title_Label.Name = "_IMSS_Title_Label"
        Me._IMSS_Title_Label.Size = New System.Drawing.Size(306, 23)
        Me._IMSS_Title_Label.TabIndex = 3
        Me._IMSS_Title_Label.Text = "Select the problems that you are experiencing"
        '
        '_IMSS_Loading_PictureBox
        '
        Me._IMSS_Loading_PictureBox.Enabled = False
        Me._IMSS_Loading_PictureBox.Image = Global.IMSS_Repair_Common_Problems.My.Resources.Resources._IMSS_ProcessesManager_Loading_Icon_400x50
        Me._IMSS_Loading_PictureBox.Location = New System.Drawing.Point(7, 11)
        Me._IMSS_Loading_PictureBox.Name = "_IMSS_Loading_PictureBox"
        Me._IMSS_Loading_PictureBox.Size = New System.Drawing.Size(355, 23)
        Me._IMSS_Loading_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me._IMSS_Loading_PictureBox.TabIndex = 2
        Me._IMSS_Loading_PictureBox.TabStop = False
        Me._IMSS_Loading_PictureBox.Visible = False
        '
        'IMSS_MAIN_CONTROL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me._IMSS_Title_Label)
        Me.Controls.Add(Me._IMSS_Description_Label)
        Me.Controls.Add(Me._IMSS_ControlHolder_Panel)
        Me.Controls.Add(Me._IMSS_MainListView)
        Me.Name = "IMSS_MAIN_CONTROL"
        Me.Size = New System.Drawing.Size(527, 436)
        CType(Me._IMSS_MainListView, System.ComponentModel.ISupportInitialize).EndInit()
        Me._IMSS_ControlHolder_Panel.ResumeLayout(False)
        CType(Me._IMSS_Loading_PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents _IMSS_MainListView As ComponentOwl.BetterListView.BetterListView
    Friend WithEvents _IMSS_ControlHolder_Panel As DevComponents.DotNetBar.PanelEx
    Friend WithEvents _IMSS_Close As System.Windows.Forms.Button
    Friend WithEvents _IMSS_Next As System.Windows.Forms.Button
    Friend WithEvents _IMSS_Description_Label As DevComponents.DotNetBar.LabelX
    Friend WithEvents _IMSS_Title_Label As DevComponents.DotNetBar.LabelX
    Friend WithEvents _IMSS_FileFoldersProblems As ComponentOwl.BetterListView.BetterListViewGroup
    Friend WithEvents _IMSS_SystemProbelms As ComponentOwl.BetterListView.BetterListViewGroup
    Friend WithEvents _IMSS_Loading_PictureBox As System.Windows.Forms.PictureBox

End Class
