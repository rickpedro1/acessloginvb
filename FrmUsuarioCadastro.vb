Imports System.Data.OleDb

Public Class FrmUsuarioCadastro
    Private Sub ChkAtivo_CheckedChanged(sender As Object, e As EventArgs) Handles ChkAtivo.CheckedChanged

    End Sub

    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click
        If ValidarForm() Then
            SalvarUsuario()
        End If
    End Sub

    Private Function ValidarForm() As Boolean
        Dim result As Boolean
        If TxtLogin.Text = "" Then
            MsgBox("Informe o nome de login do usuario.", vbExclamation, sistema)
            TxtLogin.Focus()
            result = False
        ElseIf TxtNome.Text = "" Then
            MsgBox("Informe o nome real do usuário.", vbExclamation, sistema)
            TxtLogin.Focus()
            result = False
        ElseIf TxtEmail.Text = "" Then
            MsgBox("Informe o email do usuário.", vbExclamation, sistema)
            TxtEmail.Focus()
            result = False
        ElseIf TxtSenha.TextLength < 4 Then
            MsgBox("a senha tem que ter pelo menos 4 caracteres.", vbExclamation, sistema)
            TxtSenha.Focus()
            result = False
        Else
            result = True
        End If

        Return result
    End Function



    Private Sub SalvarUsuario()
        Dim Sql = ""
        If CLng(0 & LblID.Text) = 0 Then
            Sql = "INSERT INTO Usuarios (login, nome, email, senha, adminstrador, ativo) VALUES
              (login, @nome, @email, @senha, @adminstrador, @ativo)"
        Else
            Sql = ("UPDATE Usuarios SET login=@login, nome=@nome, email=@email, senha=@senha,
              administrador=@senha, ativo=@ativo WHERE id=" & LblID.Text)
        End If

        Using cn = New OleDbConnection(conn)
            cn.Open()
            Using cmd = New OleDbCommand(Sql, cn)
                cmd.Parameters.AddWithValue("@login", TxtLogin.Text)
                cmd.Parameters.AddWithValue("@nome", TxtLogin.Text)
                cmd.Parameters.AddWithValue("@email", TxtLogin.Text)
                cmd.Parameters.AddWithValue("@senha", TxtLogin.Text)
                cmd.Parameters.AddWithValue("@adminstrador", IIf(ChkAdminstrador.Checked, "S",
                  "N"))
                cmd.Parameters.AddWithValue("@Ativo", IIf(ChkAtivo.Checked, "S", "N"))
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

End Class