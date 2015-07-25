﻿Imports System.IO
Public Class safedelete
    Dim newbyte As String
    Dim index As Integer
    Dim combo As String
    Dim convertcombo As Integer
    Dim itemselect As String
    Dim errordel As String
    Private Function UnicodeStringToBytes(ByVal str As String) As Byte()
        Return System.Text.Encoding.Unicode.GetBytes(str)
    End Function
    Private Sub deletebt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deletebt.Click
        Try
            deletfilelist.SelectedIndex = deletfilelist.SelectedIndex + 1
            statuslb.Text = "Status: " & deletfilelist.SelectedIndex + 1 & " von " & deletfilelist.Items.Count & " gelöscht"
            deletebt.Enabled = False
            combo = overwritecb.Text.Replace("x", "").ToString
            bgwrk.RunWorkerAsync()
        Catch ex As Exception
            If startwindow.langname = "English" Then
                MsgBox("No file added!", MsgBoxStyle.Exclamation)
            Else
                MsgBox("Es wurde keine Datei hinzugefügt!", MsgBoxStyle.Exclamation)
            End If
        End Try

    End Sub

    Private Sub selectpathbt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles selectpathbt.Click
        FolderBrowserDialog.ShowDialog()
        TextBox1.Text = FolderBrowserDialog.SelectedPath
        If My.Computer.FileSystem.DirectoryExists(FolderBrowserDialog.SelectedPath) Then
            Dim di As New System.IO.DirectoryInfo(TextBox1.Text)
            For Each fi As System.IO.FileInfo In di.GetFiles("*.*", System.IO.SearchOption.AllDirectories)
                deletfilelist.Items.Add(fi.FullName)
            Next
            SucheAlleOrdner(TextBox1.Text)
            deletfilelist.Items.Add(FolderBrowserDialog.SelectedPath)
        Else : End If
    End Sub
    Private Sub SucheAlleOrdner(ByVal Pfad As String)
        Dim AlleOrdner() As String
        AlleOrdner = Directory.GetDirectories(Pfad)
        For i As Integer = 0 To AlleOrdner.Length - 1
            If AlleOrdner(i) <> Pfad Then
                deletfilelist.Items.Add(AlleOrdner(i))
                Call SucheAlleOrdner(AlleOrdner(i))
            End If
        Next i
    End Sub
    Private Function keystring() As String
        Dim num_characters As Integer
        Dim i As Integer
        Dim txt As String = ""
        Dim ch As Integer
        Randomize()
        num_characters = CInt(30000)
        For i = 1 To num_characters
            ch = CInt(Int((26 + 26 + 10) * Rnd()))
            If ch < 26 Then
                txt = txt & Chr(ch + Asc("A"))
            ElseIf ch < 2 * 26 Then
                ch = ch - 26
                txt = txt & Chr(ch + Asc("a"))
            Else
                ch = ch - 26 - 26
                txt = txt & Chr(ch + Asc("0"))
            End If
        Next i
        keystring = txt
    End Function

    Private Sub bgwrk_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgwrk.DoWork
        index = 0
        convertcombo = CInt(Val(combo))
        Do
            If My.Computer.FileSystem.FileExists(itemselect) Then
                Try
                    My.Computer.FileSystem.WriteAllBytes(itemselect, UnicodeStringToBytes(keystring), False)
                Catch ex As Exception
                    errordel = ErrorToString()
                End Try
                index += 1
                bgwrk.ReportProgress(index)
            Else
                Try
                    My.Computer.FileSystem.DeleteDirectory(itemselect, FileIO.DeleteDirectoryOption.DeleteAllContents)
                Catch ex As Exception

                End Try
                index += 1
            End If
        Loop Until index > convertcombo
    End Sub

    Private Sub bgwrk_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles bgwrk.ProgressChanged
        progressstatus.Maximum = convertcombo
        If startwindow.langname = "English" Then
            generatebytelb.Text = "generated bytes: " & keystring.Substring(0, 50)
        Else
            generatebytelb.Text = "Generierte bytes: " & keystring.Substring(0, 50)
        End If
        progressstatus.Value = CInt(CDbl(e.ProgressPercentage.ToString) - 1)
        If startwindow.langname = "English" Then
            Label5.Text = e.ProgressPercentage - 1 & "x override..."
        Else
            Label5.Text = e.ProgressPercentage - 1 & "x überschrieben..."
        End If
        If progressstatus.Value = progressstatus.Maximum Then
            bgwrk.Dispose()
            My.Computer.FileSystem.DeleteFile(CStr(deletfilelist.SelectedItem))
            Label5.Text = ""
            index = 0
            progressstatus.Value = 0
        End If
    End Sub
    Private Sub delete()
        bgwrk.Dispose()
        deletfilelist.SelectedIndex = deletfilelist.SelectedIndex + 1
        If startwindow.langname = "English" Then
            statuslb.Text = "Status: " & deletfilelist.SelectedIndex + 1 & " of " & deletfilelist.Items.Count & " deleted"
        Else
            statuslb.Text = "Status: " & deletfilelist.SelectedIndex + 1 & " von " & deletfilelist.Items.Count & " gelöscht"
        End If
        deletebt.Enabled = False
        combo = overwritecb.Text.Replace("x", "").ToString
        bgwrk.RunWorkerAsync()
    End Sub

    Private Sub deletefilelist_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles deletfilelist.DragEnter
        e.Effect = e.AllowedEffect
    End Sub

    Private Sub deletefilelist_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deletfilelist.SelectedIndexChanged
        itemselect = CStr(deletfilelist.SelectedItem)
    End Sub

    Private Sub bgwrk_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwrk.RunWorkerCompleted
        If deletfilelist.SelectedIndex + 1 = deletfilelist.Items.Count Then
            If startwindow.langname = "English" Then
                MsgBox(deletfilelist.Items.Count & " files and folders deleted!", MsgBoxStyle.Information)
            Else
                MsgBox(deletfilelist.Items.Count & " Dateien und Ordner gelöscht!", MsgBoxStyle.Information)
            End If
            deletebt.Enabled = True
            deletfilelist.Items.Clear()
        Else
            delete()
        End If
    End Sub

    Private Sub fileaddbt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fileaddbt.Click
        OpenFileDialog.ShowDialog()
        If OpenFileDialog.FileName.Length > 0 Then
            deletfilelist.Items.Add(OpenFileDialog.FileName)
            OpenFileDialog.FileName = ""
        Else : End If
    End Sub

    Private Sub deletefilelist_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles deletfilelist.DragDrop
        Dim filestr() As String
        Dim str As String
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            filestr = CType(e.Data.GetData(DataFormats.FileDrop), String())
            str = filestr(0)
            If My.Computer.FileSystem.FileExists(str) Then
                deletfilelist.Items.Add(str)
            Else
                If My.Computer.FileSystem.DirectoryExists(str) Then
                    If My.Computer.FileSystem.DirectoryExists(str) Then
                        Dim di As New System.IO.DirectoryInfo(str)
                        For Each fi As System.IO.FileInfo In di.GetFiles("*.*", System.IO.SearchOption.AllDirectories)
                            deletfilelist.Items.Add(fi.FullName)
                        Next
                        SucheAlleOrdner(str)
                        deletfilelist.Items.Add(str)
                    Else : End If
                End If
            End If
        End If
    End Sub

    Private Sub removeentrybt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles removeentrybt.Click
        deletfilelist.Items.Remove(deletfilelist.SelectedItem)
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub XToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles XToolStripMenuItem.Click
        Me.Close()
    End Sub
    Private Sub wincrypttitle_MouseDown(sender As Object, e As MouseEventArgs) Handles wincrypttitle.MouseDown
        If (e.Button = Windows.Forms.MouseButtons.Left) Then
            wincrypttitle.Capture = False
            Me.WndProc(Message.Create(Me.Handle, &HA1, CType(&H2, IntPtr), IntPtr.Zero))
        Else : End If
    End Sub
    Private Sub MenuStrip1_MouseDown(sender As Object, e As MouseEventArgs) Handles MenuStrip1.MouseDown
        If (e.Button = Windows.Forms.MouseButtons.Left) Then
            MenuStrip1.Capture = False
            Me.WndProc(Message.Create(Me.Handle, &HA1, CType(&H2, IntPtr), IntPtr.Zero))
        Else : End If
    End Sub
End Class