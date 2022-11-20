Public Class FrmMain
    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ChkBxHide_UnHide_CheckedChanged(sender As Object, e As EventArgs) Handles ChkBxHide_UnHide.CheckedChanged
        If Me.ChkBxHide_UnHide.Checked = True Then
            TxtBxPassword.PasswordChar = "*"
        ElseIf ChkBxHide_UnHide.Checked = False Then
            TxtBxPassword.PasswordChar = Nothing
        End If
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub
End Class
