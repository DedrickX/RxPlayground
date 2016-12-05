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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnUsnubscribe
        '
        Me.BtnUsnubscribe.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnUsnubscribe.Location = New System.Drawing.Point(12, 466)
        Me.BtnUsnubscribe.Name = "BtnUsnubscribe"
        Me.BtnUsnubscribe.Size = New System.Drawing.Size(134, 23)
        Me.BtnUsnubscribe.TabIndex = 1
        Me.BtnUsnubscribe.Text = "Unsubscribe"
        Me.BtnUsnubscribe.UseVisualStyleBackColor = True
        '
        'BtnClick
        '
        Me.BtnClick.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.BtnClick.Location = New System.Drawing.Point(6, 19)
        Me.BtnClick.Name = "BtnClick"
        Me.BtnClick.Size = New System.Drawing.Size(122, 23)
        Me.BtnClick.TabIndex = 0
        Me.BtnClick.Text = "Klikni"
        Me.BtnClick.UseVisualStyleBackColor = True
        '
        'BtnRandomExceptions
        '
        Me.BtnRandomExceptions.Location = New System.Drawing.Point(6, 19)
        Me.BtnRandomExceptions.Name = "BtnRandomExceptions"
        Me.BtnRandomExceptions.Size = New System.Drawing.Size(122, 23)
        Me.BtnRandomExceptions.TabIndex = 0
        Me.BtnRandomExceptions.Text = "Bude exception?"
        Me.BtnRandomExceptions.UseVisualStyleBackColor = True
        '
        'TxtOutput
        '
        Me.TxtOutput.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtOutput.Location = New System.Drawing.Point(347, 28)
        Me.TxtOutput.Name = "TxtOutput"
        Me.TxtOutput.Size = New System.Drawing.Size(405, 461)
        Me.TxtOutput.TabIndex = 0
        Me.TxtOutput.Text = ""
        '
        'TxtInput
        '
        Me.TxtInput.Location = New System.Drawing.Point(6, 19)
        Me.TxtInput.Name = "TxtInput"
        Me.TxtInput.Size = New System.Drawing.Size(291, 20)
        Me.TxtInput.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.Location = New System.Drawing.Point(344, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Výstup"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnClick)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(303, 72)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Oneskorený klik"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnRandomExceptions)
        Me.GroupBox2.Location = New System.Drawing.Point(18, 100)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(303, 100)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Náhodné Exceptions"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TxtInput)
        Me.GroupBox3.Location = New System.Drawing.Point(18, 206)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(303, 100)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Písanie textu"
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(764, 501)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtOutput)
        Me.Controls.Add(Me.BtnUsnubscribe)
        Me.Name = "FrmMain"
        Me.Text = "Reactive Extensions Example"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtOutput As RichTextBox
    Friend WithEvents BtnClick As Button
    Friend WithEvents BtnUsnubscribe As Button
    Friend WithEvents BtnRandomExceptions As Button
    Friend WithEvents TxtInput As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
End Class
