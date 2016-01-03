Module Compiler
    Class Main
        Sub RefreshDependencies()
            Dim cmdinf As New ProcessStartInfo
            With cmdinf
                .CreateNoWindow = True
                .UseShellExecute = True
                .WindowStyle = ProcessWindowStyle.Minimized
            End With
        End Sub

        Sub PrepareGradleCompiler()

        End Sub
    End Class
End Module
