<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmclass
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
        Me.btnMoring = New System.Windows.Forms.Button()
        Me.btnEvening = New System.Windows.Forms.Button()
        Me.btnAfternoon = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnMoring
        '
        Me.btnMoring.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMoring.Location = New System.Drawing.Point(24, 54)
        Me.btnMoring.Name = "btnMoring"
        Me.btnMoring.Size = New System.Drawing.Size(355, 134)
        Me.btnMoring.TabIndex = 0
        Me.btnMoring.Text = "Morning"
        Me.btnMoring.UseVisualStyleBackColor = True
        '
        'btnEvening
        '
        Me.btnEvening.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEvening.Location = New System.Drawing.Point(298, 291)
        Me.btnEvening.Name = "btnEvening"
        Me.btnEvening.Size = New System.Drawing.Size(355, 134)
        Me.btnEvening.TabIndex = 1
        Me.btnEvening.Text = "Evening"
        Me.btnEvening.UseVisualStyleBackColor = True
        '
        'btnAfternoon
        '
        Me.btnAfternoon.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAfternoon.Location = New System.Drawing.Point(478, 54)
        Me.btnAfternoon.Name = "btnAfternoon"
        Me.btnAfternoon.Size = New System.Drawing.Size(355, 134)
        Me.btnAfternoon.TabIndex = 2
        Me.btnAfternoon.Text = "Afternoon"
        Me.btnAfternoon.UseVisualStyleBackColor = True
        '
        'frmclass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1096, 560)
        Me.Controls.Add(Me.btnAfternoon)
        Me.Controls.Add(Me.btnEvening)
        Me.Controls.Add(Me.btnMoring)
        Me.Name = "frmclass"
        Me.Text = "frmclass"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnMoring As System.Windows.Forms.Button
    Friend WithEvents btnEvening As System.Windows.Forms.Button
    Friend WithEvents btnAfternoon As System.Windows.Forms.Button
End Class
