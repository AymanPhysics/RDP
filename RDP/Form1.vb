Imports System.IO
Imports MSTSCLib

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetIPs()
        WindowState = FormWindowState.Maximized
    End Sub

    Private Sub GetIPs()
        Dim sr As New StreamReader(Application.StartupPath & "\IPs.txt")
        Try
            While True
                Dim L As String = sr.ReadLine
                G.Rows.Add({L.Split(":")(0), L.Split(":")(1), "Connect"})
            End While
        Catch ex As Exception
        End Try
        G.Sort(G.Columns(0), System.ComponentModel.ListSortDirection.Ascending)
        G.CurrentCell = G.Rows(0).Cells(2)
        sr.Close()
        G.AllowUserToResizeColumns = False
        G.AllowUserToResizeRows = False
    End Sub

    Dim CurrentCell As DataGridViewCell
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles G.CellClick
        If G.CurrentRow Is Nothing Then Return
        If RDP.Connected <> 0 Then
            RDP.Disconnect()
            If CurrentCell Is G.CurrentRow.Cells(2) Then Return
        End If
        Try
            If Not CurrentCell Is Nothing Then CurrentCell.Value = "Connect"
            CurrentCell = G.CurrentRow.Cells(2)
            CurrentCell.Value = "Connecting..."
            RDP.Server = G.CurrentRow.Cells(1).Value
            RDP.UserName = "Physics"
            Dim secured As IMsTscNonScriptable = RDP.GetOcx()
            secured.ClearTextPassword = "Phy123!@#"
            
            RDP.AdvancedSettings9.RedirectClipboard = True
            RDP.AdvancedSettings9.RedirectDrives = True
            'RDP.AdvancedSettings9.WorkDir = "F:\"

            RDP.AdvancedSettings9.AuthenticationLevel = 0
            RDP.AdvancedSettings9.EnableCredSspSupport = True
            RDP.DesktopWidth = SystemInformation.VirtualScreen.Width
            RDP.DesktopHeight = SystemInformation.VirtualScreen.Height
            RDP.FullScreen = IsFullScreen
            RDP.Connect()
            Text = RDP.Server & " : " & RDP.ConnectingText
        Catch
        End Try
    End Sub

    Private Sub RDP_OnConnected(sender As Object, e As EventArgs) Handles RDP.OnConnected
        CurrentCell.Value = "Disconnect"
        Text = RDP.Server & " : " & RDP.ConnectingText
    End Sub

    Private Sub AxMsRdpClient9NotSafeForScripting1_OnDisconnected(sender As Object, e As AxMSTSCLib.IMsTscAxEvents_OnDisconnectedEvent) Handles RDP.OnDisconnected
        CurrentCell.Value = "Connect"
        Text = RDP.Server & " : " & RDP.ConnectingText
    End Sub

    Dim IsFullScreen As Boolean = True
    Dim RDP_Width As Double = 0
    Dim RDP_Height As Double = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        IsFullScreen = Not IsFullScreen
        RDP.FullScreen = IsFullScreen
    End Sub

    Private Sub RDP_OnEnterFullScreenMode(sender As Object, e As EventArgs) Handles RDP.OnEnterFullScreenMode
        Try
            IsFullScreen = True
            RDP_Width = RDP.DesktopWidth
            RDP_Height = RDP.DesktopHeight
            RDP.DesktopWidth = SystemInformation.VirtualScreen.Width
            RDP.DesktopHeight = SystemInformation.VirtualScreen.Height
        Catch ex As Exception
            RDP.Reconnect(SystemInformation.VirtualScreen.Width, SystemInformation.VirtualScreen.Height)
        End Try
    End Sub

    Private Sub RDP_OnLeaveFullScreenMode(sender As Object, e As EventArgs) Handles RDP.OnLeaveFullScreenMode
        Try
            IsFullScreen = False
            RDP.DesktopWidth = RDP.Width
            RDP.DesktopHeight = RDP.Height
        Catch ex As Exception
            RDP.Reconnect(RDP.Width, RDP.Height)
        End Try
    End Sub
End Class
