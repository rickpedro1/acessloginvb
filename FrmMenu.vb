Public Class FrmMenu
    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub CadastrarUsuárioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastrarUsuárioToolStripMenuItem.Click
        FrmUsuarioCadastro.Show()
    End Sub
End Class
