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
        Me.lbl1st = New System.Windows.Forms.Label()
        Me.lbl4th = New System.Windows.Forms.Label()
        Me.lbl5th = New System.Windows.Forms.Label()
        Me.lbl3rd = New System.Windows.Forms.Label()
        Me.lbl2nd = New System.Windows.Forms.Label()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl1st
        '
        Me.lbl1st.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl1st.Location = New System.Drawing.Point(12, 58)
        Me.lbl1st.Name = "lbl1st"
        Me.lbl1st.Size = New System.Drawing.Size(63, 48)
        Me.lbl1st.TabIndex = 1
        '
        'lbl4th
        '
        Me.lbl4th.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl4th.Location = New System.Drawing.Point(230, 58)
        Me.lbl4th.Name = "lbl4th"
        Me.lbl4th.Size = New System.Drawing.Size(60, 48)
        Me.lbl4th.TabIndex = 2
        '
        'lbl5th
        '
        Me.lbl5th.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl5th.Location = New System.Drawing.Point(296, 58)
        Me.lbl5th.Name = "lbl5th"
        Me.lbl5th.Size = New System.Drawing.Size(55, 48)
        Me.lbl5th.TabIndex = 3
        '
        'lbl3rd
        '
        Me.lbl3rd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl3rd.Location = New System.Drawing.Point(155, 58)
        Me.lbl3rd.Name = "lbl3rd"
        Me.lbl3rd.Size = New System.Drawing.Size(69, 48)
        Me.lbl3rd.TabIndex = 4
        '
        'lbl2nd
        '
        Me.lbl2nd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl2nd.Location = New System.Drawing.Point(81, 58)
        Me.lbl2nd.Name = "lbl2nd"
        Me.lbl2nd.Size = New System.Drawing.Size(68, 48)
        Me.lbl2nd.TabIndex = 5
        '
        'btnGenerate
        '
        Me.btnGenerate.Location = New System.Drawing.Point(81, 152)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(75, 37)
        Me.btnGenerate.TabIndex = 6
        Me.btnGenerate.Text = "Generate Numbers"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(230, 152)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 37)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ClientSize = New System.Drawing.Size(376, 272)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.lbl2nd)
        Me.Controls.Add(Me.lbl3rd)
        Me.Controls.Add(Me.lbl5th)
        Me.Controls.Add(Me.lbl4th)
        Me.Controls.Add(Me.lbl1st)
        Me.Name = "Form1"
        Me.Text = "Lottery number"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbl1st As System.Windows.Forms.Label
    Friend WithEvents lbl4th As System.Windows.Forms.Label
    Friend WithEvents lbl5th As System.Windows.Forms.Label
    Friend WithEvents lbl3rd As System.Windows.Forms.Label
    Friend WithEvents lbl2nd As System.Windows.Forms.Label
    Friend WithEvents btnGenerate As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
