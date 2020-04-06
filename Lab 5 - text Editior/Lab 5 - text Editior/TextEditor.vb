' Name:     Christian Shank-Martel
' Prgram:   Lab 5- Text Editor
' Purpose:  A client has contracted your company to create a text editor. 
'           It may seem silly to create another basic text editor, but it
'           is anticipated that if this is done well it will become part 
'           of a larger application
' 
'  Refrencing: stackOverFlow, MSDN, VBForms, along with lecture videos given by Prof

Option Strict On
Imports System.IO

Public Class TextEditor

#Region "Variables"

    Dim filePath As String = String.Empty

#End Region

#Region "mnuFile"

    ''' <summary>
    ''' Me Close Form
    ''' </summary>
    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click

        If Not ConfirmClose() Then


        Else

            Me.Close()

        End If


    End Sub

    ''' <summary>
    ''' Blanks the textbox and filepath for new file creation
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuNewFile_Click(sender As Object, e As EventArgs) Handles mnuNewFile.Click

        If Not ConfirmClose() Then


        Else

            txtOutput.Text = ""

            filePath = String.Empty
            UpdateFormTitle()

        End If


    End Sub

    ''' <summary>
    '''  open a text file and prints it to the textbox
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuOpenFile_Click(sender As Object, e As EventArgs) Handles mnuOpenFile.Click

        If Not ConfirmClose() Then


        Else

            If (ofdOpen.ShowDialog = DialogResult.OK) Then

                filePath = ofdOpen.FileName
                UpdateFormTitle()

                Dim fileToAccess As New FileStream(filePath, FileMode.Open, FileAccess.Read)
                Dim reader As New StreamReader(fileToAccess)

                txtOutput.Text = reader.ReadToEnd()

                reader.Close()

            End If

        End If



    End Sub

    ''' <summary>
    ''' Saves file if it has a filepath
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuSaveFile_Click(sender As Object, e As EventArgs) Handles mnuSaveFile.Click

        If filePath = String.Empty Then

            ' If there isnt a file path
            ' call save as to get the enital filePath
            mnuSaveAs_Click(sender, e)

        Else
            ' Save the file
            SaveTextFile(filePath)

        End If

    End Sub

    ''' <summary>
    ''' Set the filepath and saves the file
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuSaveAs_Click(sender As Object, e As EventArgs) Handles mnuSaveAs.Click

        sfdSaveAs.Filter = "*.txt | *.doc "

        If sfdSaveAs.ShowDialog() = DialogResult.OK Then

            ' set the filepath
            filePath = sfdSaveAs.FileName
            UpdateFormTitle()

            'Safe the Txt File
            SaveTextFile(filePath)

        End If

    End Sub

#End Region

#Region "mnuAbout"

    ''' <summary>
    ''' Prints a messageBox with the needed information
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuAbout_Click(sender As Object, e As EventArgs) Handles mnuAbout.Click

        MessageBox.Show("NETD-2202" & vbCrLf & "Lab 5" & vbCrLf & "C. Shank-Martel", "About")

    End Sub

#End Region

#Region "mnuEdit"

    ''' <summary>
    ''' Saves text to the clipboard
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuCopy_Click(sender As Object, e As EventArgs) Handles mnuCopy.Click

        Clipboard.SetText(Me.txtOutput.SelectedText)

    End Sub

    ''' <summary>
    ''' Pastes the text stored in the clipboard
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuPaste_Click(sender As Object, e As EventArgs) Handles mnuPaste.Click

        txtOutput.Text += Clipboard.GetText

    End Sub

    ''' <summary>
    ''' Cuts highlighted text from the textbox after saving it to the clipboard
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuCut_Click(sender As Object, e As EventArgs) Handles mnuCut.Click

        Clipboard.SetText(Me.txtOutput.SelectedText)
        txtOutput.Cut()

    End Sub

#End Region

#Region "sub"

    ''' <summary>
    ''' Updates the form title woth the file path of the current working file
    ''' </summary>
    Sub UpdateFormTitle()

        Me.Text = "Text Editor"

        If Not filePath = String.Empty Then

            Me.Text &= " - " & filePath

        End If

    End Sub

    ''' <summary>
    ''' Actully saves the file to the system
    ''' </summary>
    ''' <param name="path"></param>
    Sub SaveTextFile(path As String)

        Dim fileToAccess As New FileStream(path, FileMode.Create, FileAccess.Write)
        Dim writer As New StreamWriter(fileToAccess)

        writer.Write(txtOutput.Text)

        writer.Close()

    End Sub

    Function ConfirmClose() As Boolean
        Dim confirm As Boolean = False

        Dim result = MessageBox.Show("Are you sure you wish to leave this document unsaved?", "Oh??", MessageBoxButtons.YesNo)

        If result = DialogResult.No Then

        Else
            confirm = True
        End If

        Return confirm
    End Function

    ''' <summary>
    ''' Catches the user pressing the (X) button
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Form1_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing

        If Not ConfirmClose() Then

            e.Cancel = True

        Else



        End If


    End Sub

#End Region

End Class
