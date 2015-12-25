Imports System.ComponentModel
Imports System.Net
Imports System.IO.Compression
Imports System.IO
Public Class firstStartSetup
    Private Sub firstStartSetup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Computer.Network.IsAvailable = True Then 'Check if the User has active Internet connection
            dlGradle()
        Else
            MessageBox.Show("You don't have an active Internet connection available. Craftbyte Mod IDE needs to download some things to be fully functionally!", "No network connection available", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Application.Exit()
        End If
    End Sub
    Public WithEvents download As WebClient 'Declaring the Downloader, with Events
#Region "Download progress sub"
    Private Sub download_DownloadProgressChanged(sender As Object, e As DownloadProgressChangedEventArgs) Handles download.DownloadProgressChanged
        ProgressBar1.Value = e.ProgressPercentage
        Label6.Text = e.ProgressPercentage & "%"
        Label5.Text = e.BytesReceived & " bytes of " & e.TotalBytesToReceive

        If Label2.Text = "Downloading Gradle..." And e.BytesReceived = e.TotalBytesToReceive Then
            Label2.Text = "Downloading Forge..."
            Label6.Text = "0%"
            Label5.Text = "0 bytes Of 0"
            dlMCP()
        End If

        If Label2.Text = "Downloading MCP..." And e.BytesReceived = e.TotalBytesToReceive Then
            Label2.Text = "Downloading Forge..."
            Label6.Text = "0%"
            Label5.Text = "0 bytes Of 0"
            dlForge()
        End If

        If Label2.Text = "Downloading Forge..." And e.BytesReceived = e.TotalBytesToReceive Then

        End If

    End Sub
#End Region
#Region "Download region (Gradle, Forge And MCP, JDK If no JDK Is installed)"
    Private Sub dlGradle()
        Try
            download = New WebClient
            download.DownloadFileAsync(New Uri("https://downloads.gradle.org/distributions/gradle-2.9-all.zip"), "C:\Craftbyte Mod IDE\cmi_gradle-2.9.zip")
        Catch ex As Exception
            MessageBox.Show("An error occured while trying to download Gradle. Gradle is needed to compile Mods and files. Try later again. Full error information: " & ex.Message & " - Craftbyte Mod IDE will now exit.", "Error while trying to download Gradle", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dlForge()
        Try
            download = New WebClient
            download.DownloadFileAsync(New Uri("http://files.minecraftforge.net/maven/net/minecraftforge/forge/1.7.10-10.13.4.1558-1.7.10/forge-1.7.10-10.13.4.1558-1.7.10-src.zip"), "C:\Craftbyte Mod IDE\cmi_forge-dev-1558.zip")
        Catch ex As Exception
            MessageBox.Show("An error occured while trying to download Forge. Forge is needed to develop Mods. Try later again. Full error information: " & ex.Message & " - Craftbyte Mod IDE will now exit.", "Error while trying to download Forge", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dlMCP()
        Try
            download = New WebClient
            download.DownloadFileAsync(New Uri("http://www.modcoderpack.com/website/sites/default/files/releases/mcp908.zip"), "C:\Craftbyte Mod IDE\cmi_mcp-dev-9.08.zip")
        Catch ex As Exception
            MessageBox.Show("An error occured while trying to download MCP. MCP is needed to develop Mods. Try later again. Full error information: " & ex.Message & " - Craftbyte Mod IDE will now exit.", "Error while trying to download MCP", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region
#Region "Unpacking Region, where everything gets unpacked."
    Private Sub PrepareToUnpack()
        Label2.Text = "Preparing to unpack downloaded files..."
        Label6.Text = "0%"
        Label7.Text = "Need to unpack:"
        Label5.Text = "Preparing..."
        Label3.Text = "Step 2 of 5"
        ProgressBar1.Style = ProgressBarStyle.Marquee
        ProgressBar1.MarqueeAnimationSpeed = 35
        unzipWorker1.RunWorkerAsync()
    End Sub

    Private Sub unzipWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles unzipWorker1.DoWork
        Try
            ZipFile.ExtractToDirectory("C:\Craftbyte Mod IDE\cmi_gradle-2.9.zip", "C:\Craftbyte Mod IDE\gradle")
            ZipFile.ExtractToDirectory("C:\Craftbyte Mod IDE\cmi_forge-dev-1558.zip", "C:\Craftbyte Mod IDE\forge-1558")
            ZipFile.ExtractToDirectory("C:\Craftbyte Mod IDE\cmi_mcp-dev-9.08.zip", "C:\Craftbyte Mod IDE\mcp-9.08")
        Catch ex As Exception

        End Try

    End Sub

#End Region
#Region "Other things"
    Private Sub firstStartSetup_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If MessageBox.Show("The first start Setup is still running! Are you sure you want to exit? At the next start you will need to go to the whole process again!", "First Start Setup still running!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            e.Cancel = False
            Application.Exit()
        Else
            e.Cancel = True

        End If
    End Sub
#End Region
End Class
