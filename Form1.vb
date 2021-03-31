Public Class Form1
    Private Sub ComboBoxCryp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxCryp.SelectedIndexChanged
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        ComboBoxCryp.SelectedItem = "Encryption"

    End Sub

    Private Sub ButtonProcess_Click(sender As Object, e As EventArgs) Handles ButtonProcess.Click
        If ComboBoxCryp.SelectedItem = "Encryption" Then
            Dim Encryption As New Process
            RichTextBoxOutput.Text = Encryption.Cryptographic_encryption(RichTextBoxInput.Text)
        Else
            Dim Decryption As New Process
            RichTextBoxOutput.Text = Decryption.Cryptographic_decryption(RichTextBoxInput.Text)
        End If
    End Sub

    Private Sub ButtonCutOutput_Click(sender As Object, e As EventArgs) Handles ButtonCutOutput.Click
        RichTextBoxOutput.ReadOnly = False
        RichTextBoxOutput.SelectAll()
        RichTextBoxOutput.Cut()
        RichTextBoxOutput.ReadOnly = True
    End Sub

    Private Sub ButtonCutInput_Click(sender As Object, e As EventArgs) Handles ButtonCutInput.Click
        RichTextBoxInput.SelectAll()
        RichTextBoxInput.Cut()
    End Sub

    Private Sub ButtonPasteInput_Click(sender As Object, e As EventArgs) Handles ButtonPasteInput.Click
        RichTextBoxInput.Paste()
    End Sub

    Private Sub ButtonClearInput_Click(sender As Object, e As EventArgs) Handles ButtonClearInput.Click
        RichTextBoxInput.Clear()
    End Sub

    Private Sub Paste_Click(sender As Object, e As EventArgs) Handles Paste.Click
        RichTextBoxOutput.ReadOnly = False
        RichTextBoxOutput.Paste()
        RichTextBoxOutput.ReadOnly = True
    End Sub

    Private Sub ButtonClearOutput_Click(sender As Object, e As EventArgs) Handles ButtonClearOutput.Click
        RichTextBoxOutput.ReadOnly = False
        RichTextBoxOutput.Clear()
        RichTextBoxOutput.ReadOnly = True
    End Sub
End Class
