<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RichTextBoxInput = New System.Windows.Forms.RichTextBox()
        Me.ButtonCutInput = New System.Windows.Forms.Button()
        Me.ButtonClearInput = New System.Windows.Forms.Button()
        Me.ButtonPasteInput = New System.Windows.Forms.Button()
        Me.ButtonProcess = New System.Windows.Forms.Button()
        Me.ComboBoxCryp = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RichTextBoxOutput = New System.Windows.Forms.RichTextBox()
        Me.ButtonCutOutput = New System.Windows.Forms.Button()
        Me.ButtonClearOutput = New System.Windows.Forms.Button()
        Me.Paste = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RichTextBoxInput)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(372, 184)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "INPUT"
        '
        'RichTextBoxInput
        '
        Me.RichTextBoxInput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBoxInput.Location = New System.Drawing.Point(3, 19)
        Me.RichTextBoxInput.Name = "RichTextBoxInput"
        Me.RichTextBoxInput.Size = New System.Drawing.Size(366, 162)
        Me.RichTextBoxInput.TabIndex = 0
        Me.RichTextBoxInput.Text = ""
        '
        'ButtonCutInput
        '
        Me.ButtonCutInput.Location = New System.Drawing.Point(433, 31)
        Me.ButtonCutInput.Name = "ButtonCutInput"
        Me.ButtonCutInput.Size = New System.Drawing.Size(104, 23)
        Me.ButtonCutInput.TabIndex = 1
        Me.ButtonCutInput.Text = "Cut Input"
        Me.ButtonCutInput.UseVisualStyleBackColor = True
        '
        'ButtonClearInput
        '
        Me.ButtonClearInput.Location = New System.Drawing.Point(433, 151)
        Me.ButtonClearInput.Name = "ButtonClearInput"
        Me.ButtonClearInput.Size = New System.Drawing.Size(104, 23)
        Me.ButtonClearInput.TabIndex = 2
        Me.ButtonClearInput.Text = "Clear Input"
        Me.ButtonClearInput.UseVisualStyleBackColor = True
        '
        'ButtonPasteInput
        '
        Me.ButtonPasteInput.Location = New System.Drawing.Point(433, 95)
        Me.ButtonPasteInput.Name = "ButtonPasteInput"
        Me.ButtonPasteInput.Size = New System.Drawing.Size(104, 23)
        Me.ButtonPasteInput.TabIndex = 3
        Me.ButtonPasteInput.Text = "Paste"
        Me.ButtonPasteInput.UseVisualStyleBackColor = True
        '
        'ButtonProcess
        '
        Me.ButtonProcess.Location = New System.Drawing.Point(26, 237)
        Me.ButtonProcess.Name = "ButtonProcess"
        Me.ButtonProcess.Size = New System.Drawing.Size(156, 24)
        Me.ButtonProcess.TabIndex = 4
        Me.ButtonProcess.Text = "Process"
        Me.ButtonProcess.UseVisualStyleBackColor = True
        '
        'ComboBoxCryp
        '
        Me.ComboBoxCryp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxCryp.FormattingEnabled = True
        Me.ComboBoxCryp.Items.AddRange(New Object() {"Encryption", "Decryption"})
        Me.ComboBoxCryp.Location = New System.Drawing.Point(304, 238)
        Me.ComboBoxCryp.Name = "ComboBoxCryp"
        Me.ComboBoxCryp.Size = New System.Drawing.Size(121, 23)
        Me.ComboBoxCryp.TabIndex = 5
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RichTextBoxOutput)
        Me.GroupBox2.Location = New System.Drawing.Point(15, 319)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(366, 162)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "OUTPUT"
        '
        'RichTextBoxOutput
        '
        Me.RichTextBoxOutput.BackColor = System.Drawing.SystemColors.Window
        Me.RichTextBoxOutput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBoxOutput.Location = New System.Drawing.Point(3, 19)
        Me.RichTextBoxOutput.Name = "RichTextBoxOutput"
        Me.RichTextBoxOutput.ReadOnly = True
        Me.RichTextBoxOutput.Size = New System.Drawing.Size(360, 140)
        Me.RichTextBoxOutput.TabIndex = 0
        Me.RichTextBoxOutput.Text = ""
        '
        'ButtonCutOutput
        '
        Me.ButtonCutOutput.Location = New System.Drawing.Point(433, 353)
        Me.ButtonCutOutput.Name = "ButtonCutOutput"
        Me.ButtonCutOutput.Size = New System.Drawing.Size(95, 23)
        Me.ButtonCutOutput.TabIndex = 7
        Me.ButtonCutOutput.Text = "Cut Output"
        Me.ButtonCutOutput.UseVisualStyleBackColor = True
        '
        'ButtonClearOutput
        '
        Me.ButtonClearOutput.Location = New System.Drawing.Point(433, 455)
        Me.ButtonClearOutput.Name = "ButtonClearOutput"
        Me.ButtonClearOutput.Size = New System.Drawing.Size(95, 23)
        Me.ButtonClearOutput.TabIndex = 8
        Me.ButtonClearOutput.Text = "Clear Output"
        Me.ButtonClearOutput.UseVisualStyleBackColor = True
        '
        'Paste
        '
        Me.Paste.Location = New System.Drawing.Point(433, 401)
        Me.Paste.Name = "Paste"
        Me.Paste.Size = New System.Drawing.Size(95, 23)
        Me.Paste.TabIndex = 9
        Me.Paste.Text = "Paste"
        Me.Paste.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(575, 581)
        Me.Controls.Add(Me.Paste)
        Me.Controls.Add(Me.ButtonClearOutput)
        Me.Controls.Add(Me.ButtonCutOutput)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ComboBoxCryp)
        Me.Controls.Add(Me.ButtonProcess)
        Me.Controls.Add(Me.ButtonPasteInput)
        Me.Controls.Add(Me.ButtonClearInput)
        Me.Controls.Add(Me.ButtonCutInput)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Encryption and Decryption"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RichTextBoxInput As RichTextBox
    Friend WithEvents ButtonCutInput As Button
    Friend WithEvents ButtonClearInput As Button
    Friend WithEvents ButtonPasteInput As Button
    Friend WithEvents ButtonProcess As Button
    Friend WithEvents ComboBoxCryp As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RichTextBoxOutput As RichTextBox
    Friend WithEvents ButtonCutOutput As Button
    Friend WithEvents ButtonClearOutput As Button
    Friend WithEvents Paste As Button
End Class
