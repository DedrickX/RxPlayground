<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
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
        Me.BtnUsnubscribe = New System.Windows.Forms.Button()
        Me.BtnClick = New System.Windows.Forms.Button()
        Me.BtnRandomExceptions = New System.Windows.Forms.Button()
        Me.TxtOutput = New System.Windows.Forms.RichTextBox()
        Me.TxtInput = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'BtnUsnubscribe
        '
        Me.BtnUsnubscribe.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnUsnubscribe.Location = New System.Drawing.Point(12, 466)
        Me.BtnUsnubscribe.Name = "BtnUsnubscribe"
        Me.BtnUsnubscribe.Size = New System.Drawing.Size(151, 23)
        Me.BtnUsnubscribe.TabIndex = 1
        Me.BtnUsnubscribe.Text = "Unsubscribe"
        Me.BtnUsnubscribe.UseVisualStyleBackColor = True
        '
        'BtnClick
        '
        Me.BtnClick.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.BtnClick.Location = New System.Drawing.Point(12, 12)
        Me.BtnClick.Name = "BtnClick"
        Me.BtnClick.Size = New System.Drawing.Size(151, 23)
        Me.BtnClick.TabIndex = 0
        Me.BtnClick.Text = "Oneskorený klik"
        Me.BtnClick.UseVisualStyleBackColor = True
        '
        'BtnRandomExceptions
        '
        Me.BtnRandomExceptions.Location = New System.Drawing.Point(12, 41)
        Me.BtnRandomExceptions.Name = "BtnRandomExceptions"
        Me.BtnRandomExceptions.Size = New System.Drawing.Size(151, 23)
        Me.BtnRandomExceptions.TabIndex = 0
        Me.BtnRandomExceptions.Text = "Random Exceptions"
        Me.BtnRandomExceptions.UseVisualStyleBackColor = True
        '
        'TxtOutput
        '
        Me.TxtOutput.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtOutput.Location = New System.Drawing.Point(180, 12)
        Me.TxtOutput.Name = "TxtOutput"
        Me.TxtOutput.Size = New System.Drawing.Size(572, 477)
        Me.TxtOutput.TabIndex = 0
        Me.TxtOutput.Text = ""
        '
        'TxtInput
        '
        Me.TxtInput.Location = New System.Drawing.Point(12, 112)
        Me.TxtInput.Name = "TxtInput"
        Me.TxtInput.Size = New System.Drawing.Size(151, 20)
        Me.TxtInput.TabIndex = 2
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(764, 501)
        Me.Controls.Add(Me.TxtInput)
        Me.Controls.Add(Me.TxtOutput)
        Me.Controls.Add(Me.BtnUsnubscribe)
        Me.Controls.Add(Me.BtnRandomExceptions)
        Me.Controls.Add(Me.BtnClick)
        Me.Name = "FrmMain"
        Me.Text = "Rx Playground"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtOutput As RichTextBox
    Friend WithEvents BtnClick As Button
    Friend WithEvents BtnUsnubscribe As Button
    Friend WithEvents BtnRandomExceptions As Button
    Friend WithEvents TxtInput As TextBox
End Class
