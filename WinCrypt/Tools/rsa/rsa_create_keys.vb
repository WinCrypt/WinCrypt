﻿Option Strict On
Namespace tools.rsa
    Public Class rsa_create_keys
        Private Sub rsa_create_keys_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            private_key_path_txt.Text = String.Format("{0}\Private Key.xml", My.Computer.FileSystem.SpecialDirectories.Desktop)
            public_key_path_txt.Text = String.Format("{0}\Public Key.xml", My.Computer.FileSystem.SpecialDirectories.Desktop)
        End Sub

        Private Sub Button3_Click(sender As Object, e As EventArgs) Handles generate_key_bt.Click
            Dim rsaKey As classes.RsaKeyStruct = classes.Create_RSA_Key
            privatekey_txt.Text = rsaKey.PrivatKey
            publickey_txt.Text = rsaKey.OpenKey
            save_bt.Enabled = True
        End Sub

        Private Sub Button1_Click(sender As Object, e As EventArgs) Handles save_privkey_bt.Click
            save_keys_dialog.FileName = "Private Key.xml"
            save_keys_dialog.ShowDialog()
            private_key_path_txt.Text = save_keys_dialog.FileName
        End Sub

        Private Sub Button2_Click(sender As Object, e As EventArgs) Handles save_pubkey_bt.Click
            save_keys_dialog.FileName = "Public Key.xml"
            save_keys_dialog.ShowDialog()
            public_key_path_txt.Text = save_keys_dialog.FileName
        End Sub

        Private Sub Button4_Click(sender As Object, e As EventArgs) Handles save_bt.Click
            My.Computer.FileSystem.WriteAllText(private_key_path_txt.Text, privatekey_txt.Text, True)
            My.Computer.FileSystem.WriteAllText(public_key_path_txt.Text, publickey_txt.Text, True)
        End Sub

        Private Sub XToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles exit_bt.Click
            Close()
        End Sub

        Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles minimize_bt.Click
            WindowState = FormWindowState.Minimized
        End Sub

        Private Sub wincrypttitle_MouseDown(sender As Object, e As MouseEventArgs) Handles wincrypttitle.MouseDown
            If (e.Button = MouseButtons.Left) Then
                wincrypttitle.Capture = False
                WndProc(Message.Create(Handle, &HA1, CType(&H2, IntPtr), IntPtr.Zero))
            Else
            End If
        End Sub

        Private Sub MenuStrip1_MouseDown(sender As Object, e As MouseEventArgs) Handles form_head.MouseDown
            If (e.Button = MouseButtons.Left) Then
                form_head.Capture = False
                WndProc(Message.Create(Handle, &HA1, CType(&H2, IntPtr), IntPtr.Zero))
            Else
            End If
        End Sub
    End Class
End Namespace