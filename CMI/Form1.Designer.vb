<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.mainIDEStr = New System.Windows.Forms.MenuStrip()
        Me.ProjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewProjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadProjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveProjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ProjectInformationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProjectSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UndoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeselectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchReplaceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchForToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchAndReplaceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowFilesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateAndCompileModToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MinecraftToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StartTheMinecraftEnvironmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StartTheMinecraftServerEnvironmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsForMinecraftToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompileFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompileModToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RunGradleTaskToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckForNewVersionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WEBSITEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportAnBugToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ideStatStr1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.checkTmr1 = New System.Windows.Forms.Timer(Me.components)
        Me.mainIDEStr.SuspendLayout()
        Me.ideStatStr1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'mainIDEStr
        '
        Me.mainIDEStr.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProjectToolStripMenuItem, Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.SearchReplaceToolStripMenuItem, Me.ModToolStripMenuItem, Me.MinecraftToolStripMenuItem, Me.CompileToolStripMenuItem, Me.HelpToolStripMenuItem, Me.ReportAnBugToolStripMenuItem})
        Me.mainIDEStr.Location = New System.Drawing.Point(0, 0)
        Me.mainIDEStr.Name = "mainIDEStr"
        Me.mainIDEStr.Size = New System.Drawing.Size(905, 24)
        Me.mainIDEStr.TabIndex = 0
        Me.mainIDEStr.Text = "MenuStrip1"
        '
        'ProjectToolStripMenuItem
        '
        Me.ProjectToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewProjectToolStripMenuItem, Me.LoadProjectToolStripMenuItem, Me.SaveProjectToolStripMenuItem, Me.ToolStripSeparator1, Me.ProjectInformationsToolStripMenuItem, Me.ProjectSettingsToolStripMenuItem})
        Me.ProjectToolStripMenuItem.Name = "ProjectToolStripMenuItem"
        Me.ProjectToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.ProjectToolStripMenuItem.Text = "Project"
        '
        'NewProjectToolStripMenuItem
        '
        Me.NewProjectToolStripMenuItem.Name = "NewProjectToolStripMenuItem"
        Me.NewProjectToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.NewProjectToolStripMenuItem.Text = "New Project"
        '
        'LoadProjectToolStripMenuItem
        '
        Me.LoadProjectToolStripMenuItem.Name = "LoadProjectToolStripMenuItem"
        Me.LoadProjectToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.LoadProjectToolStripMenuItem.Text = "Load Project"
        '
        'SaveProjectToolStripMenuItem
        '
        Me.SaveProjectToolStripMenuItem.Name = "SaveProjectToolStripMenuItem"
        Me.SaveProjectToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.SaveProjectToolStripMenuItem.Text = "Save Project"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(179, 6)
        '
        'ProjectInformationsToolStripMenuItem
        '
        Me.ProjectInformationsToolStripMenuItem.Name = "ProjectInformationsToolStripMenuItem"
        Me.ProjectInformationsToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.ProjectInformationsToolStripMenuItem.Text = "Project Informations"
        '
        'ProjectSettingsToolStripMenuItem
        '
        Me.ProjectSettingsToolStripMenuItem.Name = "ProjectSettingsToolStripMenuItem"
        Me.ProjectSettingsToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.ProjectSettingsToolStripMenuItem.Text = "Project Settings"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewFileToolStripMenuItem, Me.OpenFileToolStripMenuItem, Me.SaveFileToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewFileToolStripMenuItem
        '
        Me.NewFileToolStripMenuItem.Name = "NewFileToolStripMenuItem"
        Me.NewFileToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.NewFileToolStripMenuItem.Text = "New File"
        '
        'OpenFileToolStripMenuItem
        '
        Me.OpenFileToolStripMenuItem.Name = "OpenFileToolStripMenuItem"
        Me.OpenFileToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.OpenFileToolStripMenuItem.Text = "Open File"
        '
        'SaveFileToolStripMenuItem
        '
        Me.SaveFileToolStripMenuItem.Name = "SaveFileToolStripMenuItem"
        Me.SaveFileToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.SaveFileToolStripMenuItem.Text = "Save File"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UndoToolStripMenuItem, Me.RedoToolStripMenuItem, Me.CopyToolStripMenuItem, Me.PasteToolStripMenuItem, Me.CutToolStripMenuItem, Me.SelectAllToolStripMenuItem, Me.DeselectAllToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'UndoToolStripMenuItem
        '
        Me.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem"
        Me.UndoToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.UndoToolStripMenuItem.Text = "Undo"
        '
        'RedoToolStripMenuItem
        '
        Me.RedoToolStripMenuItem.Name = "RedoToolStripMenuItem"
        Me.RedoToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.RedoToolStripMenuItem.Text = "Redo"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.CopyToolStripMenuItem.Text = "Copy"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.PasteToolStripMenuItem.Text = "Paste"
        '
        'CutToolStripMenuItem
        '
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.CutToolStripMenuItem.Text = "Cut"
        '
        'SelectAllToolStripMenuItem
        '
        Me.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        Me.SelectAllToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.SelectAllToolStripMenuItem.Text = "Select all"
        '
        'DeselectAllToolStripMenuItem
        '
        Me.DeselectAllToolStripMenuItem.Name = "DeselectAllToolStripMenuItem"
        Me.DeselectAllToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.DeselectAllToolStripMenuItem.Text = "Deselect all"
        '
        'SearchReplaceToolStripMenuItem
        '
        Me.SearchReplaceToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SearchForToolStripMenuItem, Me.SearchAndReplaceToolStripMenuItem})
        Me.SearchReplaceToolStripMenuItem.Name = "SearchReplaceToolStripMenuItem"
        Me.SearchReplaceToolStripMenuItem.Size = New System.Drawing.Size(111, 20)
        Me.SearchReplaceToolStripMenuItem.Text = "Search && Replace"
        '
        'SearchForToolStripMenuItem
        '
        Me.SearchForToolStripMenuItem.Name = "SearchForToolStripMenuItem"
        Me.SearchForToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.SearchForToolStripMenuItem.Text = "Search for"
        '
        'SearchAndReplaceToolStripMenuItem
        '
        Me.SearchAndReplaceToolStripMenuItem.Name = "SearchAndReplaceToolStripMenuItem"
        Me.SearchAndReplaceToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.SearchAndReplaceToolStripMenuItem.Text = "Search and Replace"
        '
        'ModToolStripMenuItem
        '
        Me.ModToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowFilesToolStripMenuItem, Me.OptionsToolStripMenuItem, Me.CreateAndCompileModToolStripMenuItem})
        Me.ModToolStripMenuItem.Name = "ModToolStripMenuItem"
        Me.ModToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ModToolStripMenuItem.Text = "Mod"
        '
        'ShowFilesToolStripMenuItem
        '
        Me.ShowFilesToolStripMenuItem.Name = "ShowFilesToolStripMenuItem"
        Me.ShowFilesToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.ShowFilesToolStripMenuItem.Text = "Files"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.OptionsToolStripMenuItem.Text = "Options"
        '
        'CreateAndCompileModToolStripMenuItem
        '
        Me.CreateAndCompileModToolStripMenuItem.Name = "CreateAndCompileModToolStripMenuItem"
        Me.CreateAndCompileModToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.CreateAndCompileModToolStripMenuItem.Text = "Create and Compile Mod"
        '
        'MinecraftToolStripMenuItem
        '
        Me.MinecraftToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartTheMinecraftEnvironmentToolStripMenuItem, Me.StartTheMinecraftServerEnvironmentToolStripMenuItem, Me.SettingsForMinecraftToolStripMenuItem})
        Me.MinecraftToolStripMenuItem.Name = "MinecraftToolStripMenuItem"
        Me.MinecraftToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.MinecraftToolStripMenuItem.Text = "Minecraft"
        '
        'StartTheMinecraftEnvironmentToolStripMenuItem
        '
        Me.StartTheMinecraftEnvironmentToolStripMenuItem.Name = "StartTheMinecraftEnvironmentToolStripMenuItem"
        Me.StartTheMinecraftEnvironmentToolStripMenuItem.Size = New System.Drawing.Size(278, 22)
        Me.StartTheMinecraftEnvironmentToolStripMenuItem.Text = "Start the Minecraft Environment"
        '
        'StartTheMinecraftServerEnvironmentToolStripMenuItem
        '
        Me.StartTheMinecraftServerEnvironmentToolStripMenuItem.Name = "StartTheMinecraftServerEnvironmentToolStripMenuItem"
        Me.StartTheMinecraftServerEnvironmentToolStripMenuItem.Size = New System.Drawing.Size(278, 22)
        Me.StartTheMinecraftServerEnvironmentToolStripMenuItem.Text = "Start the Minecraft Server Environment"
        '
        'SettingsForMinecraftToolStripMenuItem
        '
        Me.SettingsForMinecraftToolStripMenuItem.Name = "SettingsForMinecraftToolStripMenuItem"
        Me.SettingsForMinecraftToolStripMenuItem.Size = New System.Drawing.Size(278, 22)
        Me.SettingsForMinecraftToolStripMenuItem.Text = "Settings for Minecraft"
        '
        'CompileToolStripMenuItem
        '
        Me.CompileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CompileFileToolStripMenuItem, Me.CompileModToolStripMenuItem, Me.RunGradleTaskToolStripMenuItem})
        Me.CompileToolStripMenuItem.Name = "CompileToolStripMenuItem"
        Me.CompileToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.CompileToolStripMenuItem.Text = "Compile"
        '
        'CompileFileToolStripMenuItem
        '
        Me.CompileFileToolStripMenuItem.Name = "CompileFileToolStripMenuItem"
        Me.CompileFileToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.CompileFileToolStripMenuItem.Text = "Compile File"
        '
        'CompileModToolStripMenuItem
        '
        Me.CompileModToolStripMenuItem.Name = "CompileModToolStripMenuItem"
        Me.CompileModToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.CompileModToolStripMenuItem.Text = "Compile Mod"
        '
        'RunGradleTaskToolStripMenuItem
        '
        Me.RunGradleTaskToolStripMenuItem.Name = "RunGradleTaskToolStripMenuItem"
        Me.RunGradleTaskToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.RunGradleTaskToolStripMenuItem.Text = "Run Gradle Task"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.CheckForNewVersionsToolStripMenuItem, Me.WEBSITEToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'CheckForNewVersionsToolStripMenuItem
        '
        Me.CheckForNewVersionsToolStripMenuItem.Name = "CheckForNewVersionsToolStripMenuItem"
        Me.CheckForNewVersionsToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.CheckForNewVersionsToolStripMenuItem.Text = "Check for new Versions"
        '
        'WEBSITEToolStripMenuItem
        '
        Me.WEBSITEToolStripMenuItem.Name = "WEBSITEToolStripMenuItem"
        Me.WEBSITEToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.WEBSITEToolStripMenuItem.Text = "Website"
        '
        'ReportAnBugToolStripMenuItem
        '
        Me.ReportAnBugToolStripMenuItem.Name = "ReportAnBugToolStripMenuItem"
        Me.ReportAnBugToolStripMenuItem.Size = New System.Drawing.Size(94, 20)
        Me.ReportAnBugToolStripMenuItem.Text = "Report an Bug"
        '
        'ideStatStr1
        '
        Me.ideStatStr1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.ideStatStr1.Location = New System.Drawing.Point(0, 521)
        Me.ideStatStr1.Name = "ideStatStr1"
        Me.ideStatStr1.Size = New System.Drawing.Size(905, 22)
        Me.ideStatStr1.TabIndex = 1
        Me.ideStatStr1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(311, 17)
        Me.ToolStripStatusLabel1.Text = "Craftbyte Mod IDE - Version PREVIEW-002-0.0.0.1prealpha"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox1.Location = New System.Drawing.Point(0, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(212, 497)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Project && File"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(6, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 17)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "%modName%"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.Label6.Location = New System.Drawing.Point(6, 58)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 18)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Current Mod:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(6, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "%fileName%"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.Label4.Location = New System.Drawing.Point(6, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 18)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Current File:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(6, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "%prjName%"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Current Project:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.RichTextBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(212, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(693, 497)
        Me.Panel1.TabIndex = 4
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox1.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(0, 0)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(693, 497)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'checkTmr1
        '
        Me.checkTmr1.Enabled = True
        Me.checkTmr1.Interval = 10000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(905, 543)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ideStatStr1)
        Me.Controls.Add(Me.mainIDEStr)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.mainIDEStr
        Me.Name = "Form1"
        Me.Text = "Craftbyte Mod IDE - %prjName%"
        Me.mainIDEStr.ResumeLayout(False)
        Me.mainIDEStr.PerformLayout()
        Me.ideStatStr1.ResumeLayout(False)
        Me.ideStatStr1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mainIDEStr As MenuStrip
    Friend WithEvents ideStatStr1 As StatusStrip
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents ProjectToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SearchReplaceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MinecraftToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CompileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents NewProjectToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoadProjectToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveProjectToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UndoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RedoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelectAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeselectAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SearchForToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SearchAndReplaceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ProjectInformationsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProjectSettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheckForNewVersionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WEBSITEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents checkTmr1 As Timer
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ReportAnBugToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ShowFilesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CreateAndCompileModToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StartTheMinecraftEnvironmentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StartTheMinecraftServerEnvironmentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingsForMinecraftToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CompileFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CompileModToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RunGradleTaskToolStripMenuItem As ToolStripMenuItem
End Class
