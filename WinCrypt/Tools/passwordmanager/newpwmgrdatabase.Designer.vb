﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Newpwmgrdatabase
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(newpwmgrdatabase))
        Me.createdb_bt = New System.Windows.Forms.Button()
        Me.password_lb = New System.Windows.Forms.Label()
        Me.password_txt = New System.Windows.Forms.TextBox()
        Me.form_head = New System.Windows.Forms.MenuStrip()
        Me.exit_bt = New System.Windows.Forms.ToolStripMenuItem()
        Me.minimize_bt = New System.Windows.Forms.ToolStripMenuItem()
        Me.wincrypttitle = New System.Windows.Forms.Label()
        Me.wincrypt_icon = New System.Windows.Forms.PictureBox()
        Me.form_head.SuspendLayout()
        CType(Me.wincrypt_icon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'createdb_bt
        '
        Me.createdb_bt.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.createdb_bt.FlatAppearance.BorderSize = 0
        Me.createdb_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.createdb_bt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.createdb_bt.Location = New System.Drawing.Point(209, 68)
        Me.createdb_bt.Name = "createdb_bt"
        Me.createdb_bt.Size = New System.Drawing.Size(128, 23)
        Me.createdb_bt.TabIndex = 0
        Me.createdb_bt.Text = "Datenbank anlegen"
        Me.createdb_bt.UseVisualStyleBackColor = False
        '
        'password_lb
        '
        Me.password_lb.AutoSize = True
        Me.password_lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.password_lb.Location = New System.Drawing.Point(12, 45)
        Me.password_lb.Name = "password_lb"
        Me.password_lb.Size = New System.Drawing.Size(53, 13)
        Me.password_lb.TabIndex = 1
        Me.password_lb.Text = "Passwort:"
        '
        'password_txt
        '
        Me.password_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.password_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.password_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.password_txt.Location = New System.Drawing.Point(71, 42)
        Me.password_txt.Name = "password_txt"
        Me.password_txt.Size = New System.Drawing.Size(266, 20)
        Me.password_txt.TabIndex = 2
        Me.password_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.password_txt.UseSystemPasswordChar = True
        '
        'form_head
        '
        Me.form_head.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.form_head.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.exit_bt, Me.minimize_bt})
        Me.form_head.Location = New System.Drawing.Point(0, 0)
        Me.form_head.Name = "form_head"
        Me.form_head.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.form_head.Size = New System.Drawing.Size(347, 27)
        Me.form_head.TabIndex = 13
        Me.form_head.Text = "WinCrypt"
        '
        'exit_bt
        '
        Me.exit_bt.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exit_bt.ForeColor = System.Drawing.Color.White
        Me.exit_bt.Name = "exit_bt"
        Me.exit_bt.Size = New System.Drawing.Size(29, 23)
        Me.exit_bt.Text = "X"
        '
        'minimize_bt
        '
        Me.minimize_bt.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.minimize_bt.ForeColor = System.Drawing.Color.White
        Me.minimize_bt.Name = "minimize_bt"
        Me.minimize_bt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.minimize_bt.Size = New System.Drawing.Size(32, 23)
        Me.minimize_bt.Text = "─"
        '
        'wincrypttitle
        '
        Me.wincrypttitle.AutoSize = True
        Me.wincrypttitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wincrypttitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.wincrypttitle.Location = New System.Drawing.Point(34, 6)
        Me.wincrypttitle.Name = "wincrypttitle"
        Me.wincrypttitle.Size = New System.Drawing.Size(191, 16)
        Me.wincrypttitle.TabIndex = 14
        Me.wincrypttitle.Text = "Datenbank anlegen - Passwort"
        '
        'wincrypt_icon
        '
        Me.wincrypt_icon.Image = Global.Project_WinCrypt.My.Resources.Resources.icon
        Me.wincrypt_icon.Location = New System.Drawing.Point(9, 6)
        Me.wincrypt_icon.Name = "wincrypt_icon"
        Me.wincrypt_icon.Size = New System.Drawing.Size(16, 16)
        Me.wincrypt_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.wincrypt_icon.TabIndex = 15
        Me.wincrypt_icon.TabStop = False
        '
        'newpwmgrdatabase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(347, 104)
        Me.Controls.Add(Me.wincrypt_icon)
        Me.Controls.Add(Me.wincrypttitle)
        Me.Controls.Add(Me.form_head)
        Me.Controls.Add(Me.password_txt)
        Me.Controls.Add(Me.password_lb)
        Me.Controls.Add(Me.createdb_bt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "newpwmgrdatabase"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Datenbank anlegen"
        Me.form_head.ResumeLayout(False)
        Me.form_head.PerformLayout()
        CType(Me.wincrypt_icon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents createdb_bt As System.Windows.Forms.Button
    Friend WithEvents password_lb As System.Windows.Forms.Label
    Friend WithEvents password_txt As System.Windows.Forms.TextBox
    Friend WithEvents form_head As System.Windows.Forms.MenuStrip
    Friend WithEvents exit_bt As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents minimize_bt As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents wincrypttitle As System.Windows.Forms.Label
    Friend WithEvents wincrypt_icon As System.Windows.Forms.PictureBox
End Class
