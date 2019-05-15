Imports System
Imports System.IO
Namespace My

    ' Les événements suivants sont disponibles pour MyApplication :
    ' 
    ' Startup : déclenché au démarrage de l'application avant la création du formulaire de démarrage.
    ' Shutdown : déclenché après la fermeture de tous les formulaires de l'application. Cet événement n'est pas déclenché si l'application se termine de façon anormale.
    ' UnhandledException : déclenché si l'application rencontre une exception non gérée.
    ' StartupNextInstance : déclenché lors du lancement d'une application à instance unique et si cette application est déjà active. 
    ' NetworkAvailabilityChanged : déclenché lorsque la connexion réseau est connectée ou déconnectée.
    Partial Friend Class MyApplication
        Private WithEvents Domain As AppDomain = AppDomain.CurrentDomain
        Private Sub MyApplication_Startup(ByVal sender As Object, ByVal e As ApplicationServices.StartupEventArgs) Handles Me.Startup      'Extract DLLs from ressources
            Try
                Using ExtractDLL As New System.IO.FileStream(Directory.GetCurrentDirectory() & "\AxInterop.WMPLib.dll", FileMode.Create)
                    ExtractDLL.Write(My.Resources.AxInterop_WMPLib, 0, My.Resources.AxInterop_WMPLib.Length)
                End Using
                Using ExtractDLL As New System.IO.FileStream(Directory.GetCurrentDirectory() & "\Interop.WMPLib.dll", FileMode.Create)
                    ExtractDLL.Write(My.Resources.Interop_WMPLib, 0, My.Resources.Interop_WMPLib.Length)
                End Using
                Using ExtractDLL As New System.IO.FileStream(System.IO.Directory.GetCurrentDirectory() & "\AxInterop.AXVLC.dll", System.IO.FileMode.Create)
                    ExtractDLL.Write(My.Resources.AxInterop_AXVLC, 0, My.Resources.AxInterop_AXVLC.Length)
                End Using
                Using ExtractDLL As New System.IO.FileStream(System.IO.Directory.GetCurrentDirectory() & "\Interop.AXVLC.dll", System.IO.FileMode.Create)
                    ExtractDLL.Write(My.Resources.Interop_AXVLC, 0, My.Resources.Interop_AXVLC.Length)
                End Using
            Catch ex As Exception
                'TODO : i really need to fix this shit
            End Try
            'Throw New System.Exception("Debug Exception, no need to worry") 'For Debug
        End Sub
        Private Sub ExError(ByVal sender As Object, ByVal e As ApplicationServices.UnhandledExceptionEventArgs) Handles Me.UnhandledException
            Dim ex As Exception
            ex = e.Exception
            MessageBox.Show( _
"████░█░░█░░███░█░░" & vbNewLine & _
"█░░░░█░░█░█░░░░█░█" & vbNewLine & _
"███░░█░░█░█░░░░██░" & vbNewLine & _
"█░░░░████░░███░█░█" & vbNewLine & _
"> Ho well, TurionVids à rencontré une exception non-gérée :" & vbNewLine & vbNewLine & _
"[_____________¯\_(ツ)_/¯____________]" & vbNewLine & _
ex.ToString & vbNewLine & _
"[___________________________________]" & vbNewLine & vbNewLine & _
"Pas de CHANCE..." & vbNewLine & _
"##############################" & vbNewLine & _
"# L'application va se fermer #" & vbNewLine & _
"##############################", "TurionVids s'est suicidé : Unhandled Exception", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Sub
    End Class
End Namespace

