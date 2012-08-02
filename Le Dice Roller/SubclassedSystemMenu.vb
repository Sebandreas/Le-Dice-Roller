'====================================================================================================
'
'	Class Name:  SubclassedSystemMenu
'	Description: Object that allows a modified system menu 
'                to be implemented and interacted with. The 
'                object is designed to add a new seperator and 
'                "About..." menu item to a windows system menu
' Please note: This is not as documented as the rest of the program. If you stuff up, don't blame us.
'=====================================================================================================

Public Class SubclassedSystemMenu
    Inherits System.Windows.Forms.NativeWindow
    Implements IDisposable

#Region "Win32 API Declares"
    Private Declare Function GetSystemMenu Lib "user32" (ByVal hwnd As Int32, _
                                                         ByVal bRevert As Boolean) As Int32

    Private Declare Function AppendMenu Lib "user32" Alias "AppendMenuA" (ByVal hMenu As Int32, _
                                                                          ByVal wFlags As Int32, _
                                                                          ByVal wIDNewItem As Int32, _
                                                                          ByVal lpNewItem As String) As Int32
#End Region

#Region "Constants"
    Private Const MF_STRING As Int32 = &H0       ' Menu string format
    Private Const MF_SEPARATOR As Int32 = &H800  ' Menu separator
    Private Const WM_SYSCOMMAND As Int32 = &H112 ' System menu 
    Private Const ID_ABOUT As Int32 = 1000       ' Our ID for the new menu item
#End Region

#Region "Member Variables"
    Private mintSystemMenu As Int32 = 0                 ' Parent system menu handle
    Private mintHandle As Int32 = 0                     ' Local parent window handle
    Private mstrMenuItemText As String = String.Empty   ' New menu item text
#End Region

#Region "Events"
    Public Event LaunchDialog()
#End Region

#Region "Constructor"
    '========================================================
    '
    '   Method Name:        New
    '	Description:	    Constructor. Creates menu items and assigns subclass
    '
    '   Inputs:             intWindowHandle : Parent window handle for message 
    '                                         subclass and adding new menu items 
    '                                         to parent system menu
    '
    '   Return Value:       None
    '
    '========================================================
    Public Sub New(ByVal intWindowHandle As Int32, _
                   ByVal strMenuItemText As String)

        Me.AssignHandle(New IntPtr(intWindowHandle))

        mintHandle = intWindowHandle
        mstrMenuItemText = strMenuItemText

        ' Retrieve the system menu handle
        mintSystemMenu = GetSystemMenu(mintHandle, 0)

        If AddNewSystemMenuItem() = False Then
            Throw New Exception("Unable to add new system menu items")
        End If

    End Sub
#End Region

#Region "Methods"
    '========================================================
    '
    '   Method Name:        WndProc
    '	Description:	    Subclassed window message delegate
    '
    '   Inputs:             m : Window Message 
    '
    '   Return Value:       None
    '
    '========================================================
    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)

        Select Case m.Msg
            Case WM_SYSCOMMAND

                MyBase.WndProc(m)

                If m.WParam.ToInt32 = ID_ABOUT Then
                    If mintSystemMenu <> 0 Then
                        RaiseEvent LaunchDialog()
                    End If
                End If

            Case Else
                MyBase.WndProc(m)
        End Select

    End Sub

    '========================================================
    '
    '   Method Name:        Dispose
    '	Description:	    IDispose interface implementation
    '
    '   Inputs:             None 
    '
    '   Return Value:       None
    '
    '========================================================
    Public Sub Dispose() Implements System.IDisposable.Dispose

        If Not Me.Handle.Equals(IntPtr.Zero) Then
            Me.ReleaseHandle()
        End If

    End Sub

    '========================================================
    '
    '   Method Name:        AddNewSystemMenuItem
    '	Description:	    Adds system menu items
    '
    '   Inputs:             None 
    '
    '   Return Value:       True if successful, False else
    '
    '========================================================
    Private Function AddNewSystemMenuItem() As Boolean
        Try
            ' Append the extra system menu items
            Return AppendToSystemMenu(mintSystemMenu, mstrMenuItemText)

        Catch ex As Exception
            Return False
        End Try
    End Function

    '========================================================
    '
    '   Method Name:        AppendToSystemMenu
    '	Description:	    Adds system menu items (Separator & About...?)
    '
    '   Inputs:             intHandle : System Menu handle 
    '                       strText : Text for new menu item
    '
    '   Return Value:       True if successful, False else
    '
    '========================================================
    Private Function AppendToSystemMenu(ByVal intHandle As Int32, _
                                        ByVal strText As String) As Boolean

        Try
            ' Add the seperator menu item
            Dim intRet As Int32 = AppendMenu(intHandle, MF_SEPARATOR, 0, String.Empty)

            ' Add the About... menu item
            intRet = AppendMenu(intHandle, MF_STRING, ID_ABOUT, strText)

            If intRet = 1 Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            Return False
        End Try
    End Function
#End Region

End Class
