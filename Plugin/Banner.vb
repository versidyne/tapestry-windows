Imports System.Runtime.InteropServices
Imports System.Windows.Forms

Public Class Banner

    Implements Versidyne.Plugins.Plugin

    Private ObjHost As Versidyne.Plugins.Host


    Public Sub Initialize(ByVal Host As Versidyne.Plugins.Host) Implements Versidyne.Plugins.Plugin.Initialize

        ObjHost = Host

        'Create the form
        Me.ShowInTaskbar = False
        Me.BackColor = Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(Screen.PrimaryScreen.Bounds.Width, 13)
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None

        'Set the text
        Label1.Text = "Vexis 0.7"

        'Center the Text
        Dim Width As Integer = Screen.PrimaryScreen.Bounds.Width / 2
        Dim LabelWidth As Integer = Label1.Width / 2
        Label1.Location = New System.Drawing.Point(Width - LabelWidth, 0)

        'Create Bar
        RegisterBar()

    End Sub

    Public ReadOnly Property Title() As String Implements Versidyne.Plugins.Plugin.Title

        Get
            Return "Banner"
        End Get

    End Property

    Public Function Main(ByVal Args As Array) As Integer Implements Versidyne.Plugins.Plugin.Main

        ObjHost.ShowFeedback("Banner ran successfully.")
        Return 0

    End Function

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Make automatically loading
        'Start.Add(Application.ProductName, Application.ExecutablePath)

        'Create the form
        Me.ShowInTaskbar = False
        Me.BackColor = Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(Screen.PrimaryScreen.Bounds.Width, 13)
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None

        'Set the text
        Label1.Text = "Vexis 0.7"

        'Center the Text
        Dim Width As Integer = Screen.PrimaryScreen.Bounds.Width / 2
        Dim LabelWidth As Integer = Label1.Width / 2
        Label1.Location = New System.Drawing.Point(Width - LabelWidth, 0)

        'Create Bar
        RegisterBar()

    End Sub

    Structure RECT
        Public left As Integer
        Public top As Integer
        Public right As Integer
        Public bottom As Integer
    End Structure 'RECT

    Structure APPBARDATA
        Public cbSize As Integer
        Public hWnd As IntPtr
        Public uCallbackMessage As Integer
        Public uEdge As Integer
        Public rc As RECT
        Public lParam As IntPtr
    End Structure 'APPBARDATA
    Enum ABMsg

        ABM_NEW = 0
        ABM_REMOVE = 1
        ABM_QUERYPOS = 2
        ABM_SETPOS = 3
        ABM_GETSTATE = 4
        ABM_GETTASKBARPOS = 5
        ABM_ACTIVATE = 6
        ABM_GETAUTOHIDEBAR = 7
        ABM_SETAUTOHIDEBAR = 8
        ABM_WINDOWPOSCHANGED = 9
        ABM_SETSTATE = 10

    End Enum
    Enum ABNotify

        ABN_STATECHANGE = 0
        ABN_POSCHANGED
        ABN_FULLSCREENAPP
        ABN_WINDOWARRANGE

    End Enum
    Enum ABEdge

        ABE_LEFT = 0
        ABE_TOP
        ABE_RIGHT
        ABE_BOTTOM
    End Enum

    Private fBarRegistered As Boolean = False

    Public Declare Function SHAppBarMessage Lib "shell32.dll" Alias "SHAppBarMessage" (ByVal dwMessage As Integer, ByRef pData As APPBARDATA) As System.UInt32
    Public Declare Function GetSystemMetrics Lib "User32.dll" Alias "GetSystemMetrics" (ByVal index As Integer) As Integer
    Public Declare Function MoveWindow Lib "User32.dll" Alias "MoveWindow" (ByVal hWnd As IntPtr, ByVal x As Integer, ByVal y As Integer, ByVal cx As Integer, ByVal cy As Integer, ByVal repaint As Boolean) As Boolean
    Private Declare Auto Function RegisterWindowMessage Lib "User32.dll" (ByVal msg As String) As Integer
    Private uCallBack As Integer

    Private Sub RegisterBar()
        Dim abd As New APPBARDATA()
        abd.cbSize = Marshal.SizeOf(abd)
        abd.hWnd = Me.Handle
        If Not fBarRegistered Then
            uCallBack = RegisterWindowMessage("AppBarMessage")
            abd.uCallbackMessage = uCallBack

            Dim ret As System.UInt32 = SHAppBarMessage(CInt(ABMsg.ABM_NEW), abd) 'ToDo: Unsigned Integers not supported
            fBarRegistered = True

            ABSetPos()

        Else
            SHAppBarMessage(CInt(ABMsg.ABM_REMOVE), abd)
            fBarRegistered = False
        End If
    End Sub 'RegisterBar

    Private Sub ABSetPos()
        Dim abd As New APPBARDATA()
        abd.cbSize = Marshal.SizeOf(abd)
        abd.hWnd = Me.Handle
        abd.uEdge = CInt(ABEdge.ABE_TOP)

        If abd.uEdge = CInt(ABEdge.ABE_LEFT) Or abd.uEdge = CInt(ABEdge.ABE_RIGHT) Then
            abd.rc.top = 0
            abd.rc.bottom = SystemInformation.PrimaryMonitorSize.Height
            If abd.uEdge = CInt(ABEdge.ABE_LEFT) Then
                abd.rc.left = 0
                abd.rc.right = Size.Width
            Else
                abd.rc.right = SystemInformation.PrimaryMonitorSize.Width
                abd.rc.left = abd.rc.right - Size.Width
            End If

        Else
            abd.rc.left = 0
            abd.rc.right = SystemInformation.PrimaryMonitorSize.Width
            If abd.uEdge = CInt(ABEdge.ABE_TOP) Then
                abd.rc.top = 0
                abd.rc.bottom = Size.Height
            Else
                abd.rc.bottom = SystemInformation.PrimaryMonitorSize.Height
                abd.rc.top = abd.rc.bottom - Size.Height
            End If
        End If

        ' Query the system for an approved size and position. 
        SHAppBarMessage(CInt(ABMsg.ABM_QUERYPOS), abd)

        ' Adjust the rectangle, depending on the edge to which the 
        ' appbar is anchored. 
        Select Case abd.uEdge
            Case CInt(ABEdge.ABE_LEFT)
                abd.rc.right = abd.rc.left + Size.Width
            Case CInt(ABEdge.ABE_RIGHT)
                abd.rc.left = abd.rc.right - Size.Width
            Case CInt(ABEdge.ABE_TOP)
                abd.rc.bottom = abd.rc.top + Size.Height
            Case CInt(ABEdge.ABE_BOTTOM)
                abd.rc.top = abd.rc.bottom - Size.Height
        End Select

        ' Pass the final bounding rectangle to the system. 
        SHAppBarMessage(CInt(ABMsg.ABM_SETPOS), abd)

        ' Move and size the appbar so that it conforms to the 
        ' bounding rectangle passed to the system. 
        MoveWindow(abd.hWnd, abd.rc.left, abd.rc.top, abd.rc.right - abd.rc.left, abd.rc.bottom - abd.rc.top, True)
    End Sub 'ABSetPos

    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        If m.Msg = uCallBack Then
            Select Case m.WParam.ToInt32()
                Case CInt(ABNotify.ABN_POSCHANGED)
                    ABSetPos()
            End Select
        End If

        MyBase.WndProc(m)
    End Sub 'WndProc

    Protected Overrides ReadOnly Property CreateParams() As System.Windows.Forms.CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.Style = cp.Style And Not &HC00000 ' WS_CAPTION
            cp.Style = cp.Style And Not &H800000 ' WS_BORDER
            cp.ExStyle = &H80 Or &H8 ' WS_EX_TOOLWINDOW | WS_EX_TOPMOST
            Return cp
        End Get
    End Property

    Private Sub HideToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HideToolStripMenuItem.Click

        Me.Hide()

        RegisterBar()

    End Sub

    Private Sub ShowToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        RegisterBar()

        Me.Show()

    End Sub

End Class