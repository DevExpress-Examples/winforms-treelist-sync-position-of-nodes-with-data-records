Imports DevExpress.Skins
Imports System
Imports System.Windows.Forms

Namespace Q351285

    Friend Module Program

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread>
        Sub Main()
            Call Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Call SkinManager.EnableFormSkins()
            Call Application.Run(New Form1())
        End Sub
    End Module
End Namespace
