<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUsuarioCadastro
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtNome = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtSenha = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtLogin = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblID = New System.Windows.Forms.Label()
        Me.ChkAdminstrador = New System.Windows.Forms.CheckBox()
        Me.ChkAtivo = New System.Windows.Forms.CheckBox()
        Me.BtnSalvar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(122, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nome real"
        '
        'TxtNome
        '
        Me.TxtNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNome.Location = New System.Drawing.Point(248, 86)
        Me.TxtNome.MaxLength = 70
        Me.TxtNome.Name = "TxtNome"
        Me.TxtNome.Size = New System.Drawing.Size(336, 22)
        Me.TxtNome.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(122, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Email"
        '
        'TxtEmail
        '
        Me.TxtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEmail.Location = New System.Drawing.Point(248, 122)
        Me.TxtEmail.MaxLength = 70
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(336, 22)
        Me.TxtEmail.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(122, 161)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Senha"
        '
        'TxtSenha
        '
        Me.TxtSenha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSenha.Location = New System.Drawing.Point(248, 161)
        Me.TxtSenha.MaxLength = 30
        Me.TxtSenha.Name = "TxtSenha"
        Me.TxtSenha.Size = New System.Drawing.Size(336, 22)
        Me.TxtSenha.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(226, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 13)
        Me.Label5.TabIndex = 9
        '
        'TxtLogin
        '
        Me.TxtLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLogin.Location = New System.Drawing.Point(248, 46)
        Me.TxtLogin.MaxLength = 15
        Me.TxtLogin.Name = "TxtLogin"
        Me.TxtLogin.Size = New System.Drawing.Size(336, 22)
        Me.TxtLogin.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(135, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(25, 20)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "ID"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(122, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 20)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Nome de login"
        '
        'LblID
        '
        Me.LblID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblID.Location = New System.Drawing.Point(248, 9)
        Me.LblID.Name = "LblID"
        Me.LblID.Size = New System.Drawing.Size(99, 20)
        Me.LblID.TabIndex = 16
        Me.LblID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ChkAdminstrador
        '
        Me.ChkAdminstrador.AutoSize = True
        Me.ChkAdminstrador.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkAdminstrador.Location = New System.Drawing.Point(195, 198)
        Me.ChkAdminstrador.Name = "ChkAdminstrador"
        Me.ChkAdminstrador.Size = New System.Drawing.Size(106, 20)
        Me.ChkAdminstrador.TabIndex = 17
        Me.ChkAdminstrador.Text = "Adminstrador"
        Me.ChkAdminstrador.UseVisualStyleBackColor = True
        '
        'ChkAtivo
        '
        Me.ChkAtivo.AutoSize = True
        Me.ChkAtivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkAtivo.Location = New System.Drawing.Point(509, 198)
        Me.ChkAtivo.Name = "ChkAtivo"
        Me.ChkAtivo.Size = New System.Drawing.Size(56, 20)
        Me.ChkAtivo.TabIndex = 18
        Me.ChkAtivo.Text = "Ativo"
        Me.ChkAtivo.UseVisualStyleBackColor = True
        '
        'BtnSalvar
        '
        Me.BtnSalvar.Location = New System.Drawing.Point(271, 255)
        Me.BtnSalvar.Name = "BtnSalvar"
        Me.BtnSalvar.Size = New System.Drawing.Size(150, 41)
        Me.BtnSalvar.TabIndex = 19
        Me.BtnSalvar.Text = "Salvar"
        Me.BtnSalvar.UseVisualStyleBackColor = True
        '
        'FrmUsuarioCadastro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(649, 308)
        Me.Controls.Add(Me.BtnSalvar)
        Me.Controls.Add(Me.ChkAtivo)
        Me.Controls.Add(Me.ChkAdminstrador)
        Me.Controls.Add(Me.LblID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtLogin)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtSenha)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtEmail)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtNome)
        Me.Controls.Add(Me.Label2)
        Me.Name = "FrmUsuarioCadastro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents TxtNome As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtSenha As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtLogin As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LblID As Label
    Friend WithEvents ChkAdminstrador As CheckBox
    Friend WithEvents ChkAtivo As CheckBox
    Friend WithEvents BtnSalvar As Button
End Class
