<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class prjInformations
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.prjNameLbl1 = New System.Windows.Forms.Label()
        Me.modNameLbl1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.prjNameLbl2 = New System.Windows.Forms.Label()
        Me.modNameLbl2 = New System.Windows.Forms.Label()
        Me.prjDirName1 = New System.Windows.Forms.Label()
        Me.prjSolFileNameLbl1 = New System.Windows.Forms.Label()
        Me.overallFilesNameLbl1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.25!)
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(306, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Project Informations"
        '
        'prjNameLbl1
        '
        Me.prjNameLbl1.AutoSize = True
        Me.prjNameLbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.25!)
        Me.prjNameLbl1.Location = New System.Drawing.Point(14, 51)
        Me.prjNameLbl1.Name = "prjNameLbl1"
        Me.prjNameLbl1.Size = New System.Drawing.Size(153, 29)
        Me.prjNameLbl1.TabIndex = 1
        Me.prjNameLbl1.Text = "%prjName%"
        '
        'modNameLbl1
        '
        Me.modNameLbl1.AutoSize = True
        Me.modNameLbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.modNameLbl1.Location = New System.Drawing.Point(16, 80)
        Me.modNameLbl1.Name = "modNameLbl1"
        Me.modNameLbl1.Size = New System.Drawing.Size(129, 24)
        Me.modNameLbl1.TabIndex = 2
        Me.modNameLbl1.Text = "%modName%"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(17, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Main Informations"
        '
        'prjNameLbl2
        '
        Me.prjNameLbl2.AutoSize = True
        Me.prjNameLbl2.Location = New System.Drawing.Point(17, 132)
        Me.prjNameLbl2.Name = "prjNameLbl2"
        Me.prjNameLbl2.Size = New System.Drawing.Size(74, 13)
        Me.prjNameLbl2.TabIndex = 4
        Me.prjNameLbl2.Text = "Project Name:"
        '
        'modNameLbl2
        '
        Me.modNameLbl2.AutoSize = True
        Me.modNameLbl2.Location = New System.Drawing.Point(17, 145)
        Me.modNameLbl2.Name = "modNameLbl2"
        Me.modNameLbl2.Size = New System.Drawing.Size(62, 13)
        Me.modNameLbl2.TabIndex = 5
        Me.modNameLbl2.Text = "Mod Name:"
        '
        'prjDirName1
        '
        Me.prjDirName1.AutoSize = True
        Me.prjDirName1.Location = New System.Drawing.Point(17, 158)
        Me.prjDirName1.Name = "prjDirName1"
        Me.prjDirName1.Size = New System.Drawing.Size(88, 13)
        Me.prjDirName1.TabIndex = 6
        Me.prjDirName1.Text = "Project Directory:"
        '
        'prjSolFileNameLbl1
        '
        Me.prjSolFileNameLbl1.AutoSize = True
        Me.prjSolFileNameLbl1.Location = New System.Drawing.Point(17, 171)
        Me.prjSolFileNameLbl1.Name = "prjSolFileNameLbl1"
        Me.prjSolFileNameLbl1.Size = New System.Drawing.Size(103, 13)
        Me.prjSolFileNameLbl1.TabIndex = 7
        Me.prjSolFileNameLbl1.Text = "Project Solution File:"
        '
        'overallFilesNameLbl1
        '
        Me.overallFilesNameLbl1.AutoSize = True
        Me.overallFilesNameLbl1.Location = New System.Drawing.Point(17, 184)
        Me.overallFilesNameLbl1.Name = "overallFilesNameLbl1"
        Me.overallFilesNameLbl1.Size = New System.Drawing.Size(139, 13)
        Me.overallFilesNameLbl1.TabIndex = 8
        Me.overallFilesNameLbl1.Text = "Overall files: - coming soon -"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(439, 165)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 41)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Ok"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'prjInformations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(553, 218)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.overallFilesNameLbl1)
        Me.Controls.Add(Me.prjSolFileNameLbl1)
        Me.Controls.Add(Me.prjDirName1)
        Me.Controls.Add(Me.modNameLbl2)
        Me.Controls.Add(Me.prjNameLbl2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.modNameLbl1)
        Me.Controls.Add(Me.prjNameLbl1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "prjInformations"
        Me.Text = "Craftbyte Mod IDE - Project Informations"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents prjNameLbl1 As Label
    Friend WithEvents modNameLbl1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents prjNameLbl2 As Label
    Friend WithEvents modNameLbl2 As Label
    Friend WithEvents prjDirName1 As Label
    Friend WithEvents prjSolFileNameLbl1 As Label
    Friend WithEvents overallFilesNameLbl1 As Label
    Friend WithEvents Button1 As Button
End Class
