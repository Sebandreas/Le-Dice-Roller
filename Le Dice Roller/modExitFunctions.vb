Module modExitFunctions
    Function ExitProgram()
        If My.Settings.VisEffectsChecked = True Then
            ' This dims the form when the program exits via clicking the 'Exit' 
            ' option in the menubar at the top or when clicking the X button
            ' at the top of the window. This is taken from an example in the book 
            ' "Learn VB2005 in 24 Hours" by James Foxall. Thanks for that, James!
            ' Also, this saves any settings in the options dialog,
            ' if not saved when closing the dialog box.
            My.Settings.Save()
            frmMain.ShowInTaskbar = False
            Dim sngOpacity As Single
            For sngOpacity = 1 To 0 Step -My.Settings.fxSpeed
                frmMain.Opacity = sngOpacity
                frmMain.Refresh()
                System.Threading.Thread.Sleep(200)
            Next
            'Closes and quits the program.
            frmMain.Close()
            Return True
        Else
            'The same.
            frmMain.Close()
            Return True
        End If
        Return True
    End Function

    Function ExitProgram2()
        If My.Settings.VisEffectsChecked = True Then
            ' This function is essentially the same thing as above, but without the close statment, as I don't need it.
            My.Settings.Save()
            frmMain.ShowInTaskbar = False
            Dim sngOpacity As Single
            For sngOpacity = 1 To 0 Step -0.045
                frmMain.Opacity = sngOpacity
                frmMain.Refresh()
                System.Threading.Thread.Sleep(200)
            Next
        End If
        Return True
    End Function
End Module
