﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMenu
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ZToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ControleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrocarSenhaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastrarUsuárioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarUsuárioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ZToolStripMenuItem, Me.ConsultaToolStripMenuItem, Me.ControleToolStripMenuItem, Me.SairToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ZToolStripMenuItem
        '
        Me.ZToolStripMenuItem.Name = "ZToolStripMenuItem"
        Me.ZToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.ZToolStripMenuItem.Text = "Cadastro"
        '
        'ConsultaToolStripMenuItem
        '
        Me.ConsultaToolStripMenuItem.Name = "ConsultaToolStripMenuItem"
        Me.ConsultaToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.ConsultaToolStripMenuItem.Text = "Consulta"
        '
        'ControleToolStripMenuItem
        '
        Me.ControleToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TrocarSenhaToolStripMenuItem, Me.CadastrarUsuárioToolStripMenuItem, Me.ConsultarUsuárioToolStripMenuItem})
        Me.ControleToolStripMenuItem.Name = "ControleToolStripMenuItem"
        Me.ControleToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ControleToolStripMenuItem.Text = "Controle"
        '
        'TrocarSenhaToolStripMenuItem
        '
        Me.TrocarSenhaToolStripMenuItem.Name = "TrocarSenhaToolStripMenuItem"
        Me.TrocarSenhaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.TrocarSenhaToolStripMenuItem.Text = "Trocar senha"
        '
        'CadastrarUsuárioToolStripMenuItem
        '
        Me.CadastrarUsuárioToolStripMenuItem.Name = "CadastrarUsuárioToolStripMenuItem"
        Me.CadastrarUsuárioToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.CadastrarUsuárioToolStripMenuItem.Text = "Cadastro de usuários"
        '
        'ConsultarUsuárioToolStripMenuItem
        '
        Me.ConsultarUsuárioToolStripMenuItem.Name = "ConsultarUsuárioToolStripMenuItem"
        Me.ConsultarUsuárioToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ConsultarUsuárioToolStripMenuItem.Text = "Consultar usuários"
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(38, 20)
        Me.SairToolStripMenuItem.Text = "Sair"
        '
        'FrmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ZToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ControleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TrocarSenhaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CadastrarUsuárioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarUsuárioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As ToolStripMenuItem
End Class
