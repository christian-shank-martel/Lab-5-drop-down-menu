<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TextEditor
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.mnuTopMenu = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuNewFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOpenFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSaveFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSaveAs = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPaste = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCut = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.sfdSaveAs = New System.Windows.Forms.SaveFileDialog()
        Me.ttpTextEditor = New System.Windows.Forms.ToolTip(Me.components)
        Me.ofdOpen = New System.Windows.Forms.OpenFileDialog()
        Me.mnuTopMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuTopMenu
        '
        Me.mnuTopMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuEdit, Me.HelpToolStripMenuItem})
        Me.mnuTopMenu.Location = New System.Drawing.Point(0, 0)
        Me.mnuTopMenu.Name = "mnuTopMenu"
        Me.mnuTopMenu.Size = New System.Drawing.Size(336, 24)
        Me.mnuTopMenu.TabIndex = 0
        Me.mnuTopMenu.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNewFile, Me.mnuOpenFile, Me.mnuSaveFile, Me.mnuSaveAs, Me.mnuExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "&File"
        Me.mnuFile.ToolTipText = "File options"
        '
        'mnuNewFile
        '
        Me.mnuNewFile.Name = "mnuNewFile"
        Me.mnuNewFile.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.mnuNewFile.Size = New System.Drawing.Size(146, 22)
        Me.mnuNewFile.Text = "&New"
        '
        'mnuOpenFile
        '
        Me.mnuOpenFile.Name = "mnuOpenFile"
        Me.mnuOpenFile.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.mnuOpenFile.Size = New System.Drawing.Size(146, 22)
        Me.mnuOpenFile.Text = "&Open"
        '
        'mnuSaveFile
        '
        Me.mnuSaveFile.Name = "mnuSaveFile"
        Me.mnuSaveFile.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuSaveFile.Size = New System.Drawing.Size(146, 22)
        Me.mnuSaveFile.Text = "&Save"
        '
        'mnuSaveAs
        '
        Me.mnuSaveAs.Name = "mnuSaveAs"
        Me.mnuSaveAs.Size = New System.Drawing.Size(146, 22)
        Me.mnuSaveAs.Text = "Save As..."
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(146, 22)
        Me.mnuExit.Text = "Exit"
        '
        'mnuEdit
        '
        Me.mnuEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCopy, Me.mnuPaste, Me.mnuCut})
        Me.mnuEdit.Name = "mnuEdit"
        Me.mnuEdit.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.mnuEdit.Size = New System.Drawing.Size(39, 20)
        Me.mnuEdit.Text = "&Edit"
        Me.mnuEdit.ToolTipText = "Cut, Copy, and paste text"
        '
        'mnuCopy
        '
        Me.mnuCopy.Name = "mnuCopy"
        Me.mnuCopy.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.mnuCopy.Size = New System.Drawing.Size(144, 22)
        Me.mnuCopy.Text = "Copy"
        '
        'mnuPaste
        '
        Me.mnuPaste.Name = "mnuPaste"
        Me.mnuPaste.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.mnuPaste.Size = New System.Drawing.Size(144, 22)
        Me.mnuPaste.Text = "Paste"
        '
        'mnuCut
        '
        Me.mnuCut.Name = "mnuCut"
        Me.mnuCut.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.mnuCut.Size = New System.Drawing.Size(144, 22)
        Me.mnuCut.Text = "Cut"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAbout})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.H), System.Windows.Forms.Keys)
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        Me.HelpToolStripMenuItem.ToolTipText = "About this application"
        '
        'mnuAbout
        '
        Me.mnuAbout.Name = "mnuAbout"
        Me.mnuAbout.Size = New System.Drawing.Size(107, 22)
        Me.mnuAbout.Text = "About"
        '
        'txtOutput
        '
        Me.txtOutput.Location = New System.Drawing.Point(0, 19)
        Me.txtOutput.Margin = New System.Windows.Forms.Padding(10)
        Me.txtOutput.Multiline = True
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtOutput.Size = New System.Drawing.Size(333, 245)
        Me.txtOutput.TabIndex = 1
        '
        'TextEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(336, 263)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.mnuTopMenu)
        Me.Name = "TextEditor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Text Editor"
        Me.mnuTopMenu.ResumeLayout(False)
        Me.mnuTopMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuTopMenu As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuEdit As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuNewFile As ToolStripMenuItem
    Friend WithEvents mnuOpenFile As ToolStripMenuItem
    Friend WithEvents mnuSaveFile As ToolStripMenuItem
    Friend WithEvents mnuSaveAs As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents txtOutput As TextBox
    Friend WithEvents mnuCopy As ToolStripMenuItem
    Friend WithEvents mnuPaste As ToolStripMenuItem
    Friend WithEvents mnuCut As ToolStripMenuItem
    Friend WithEvents mnuAbout As ToolStripMenuItem
    Friend WithEvents sfdSaveAs As SaveFileDialog
    Friend WithEvents ttpTextEditor As ToolTip
    Friend WithEvents ofdOpen As OpenFileDialog
End Class
