<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcourse
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
        Me.btnICT = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnElectric = New System.Windows.Forms.Button()
        Me.btnAirconditioner = New System.Windows.Forms.Button()
        Me.btnMakarting = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnICT
        '
        Me.btnICT.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnICT.Location = New System.Drawing.Point(69, 46)
        Me.btnICT.Name = "btnICT"
        Me.btnICT.Size = New System.Drawing.Size(290, 141)
        Me.btnICT.TabIndex = 0
        Me.btnICT.Text = "ICT"
        Me.btnICT.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(529, 351)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(290, 141)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "ICT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnElectric
        '
        Me.btnElectric.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnElectric.Location = New System.Drawing.Point(69, 351)
        Me.btnElectric.Name = "btnElectric"
        Me.btnElectric.Size = New System.Drawing.Size(290, 141)
        Me.btnElectric.TabIndex = 2
        Me.btnElectric.Text = "Electic"
        Me.btnElectric.UseVisualStyleBackColor = True
        '
        'btnAirconditioner
        '
        Me.btnAirconditioner.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAirconditioner.Location = New System.Drawing.Point(1035, 46)
        Me.btnAirconditioner.Name = "btnAirconditioner"
        Me.btnAirconditioner.Size = New System.Drawing.Size(358, 141)
        Me.btnAirconditioner.TabIndex = 3
        Me.btnAirconditioner.Text = "Airconditioner"
        Me.btnAirconditioner.UseVisualStyleBackColor = True
        '
        'btnMakarting
        '
        Me.btnMakarting.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMakarting.Location = New System.Drawing.Point(529, 46)
        Me.btnMakarting.Name = "btnMakarting"
        Me.btnMakarting.Size = New System.Drawing.Size(420, 141)
        Me.btnMakarting.TabIndex = 4
        Me.btnMakarting.Text = "Makarting"
        Me.btnMakarting.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(1035, 351)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(290, 141)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "ICT"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'frmcourse
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1761, 654)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.btnMakarting)
        Me.Controls.Add(Me.btnAirconditioner)
        Me.Controls.Add(Me.btnElectric)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnICT)
        Me.Name = "frmcourse"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmcourse"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnICT As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnElectric As System.Windows.Forms.Button
    Friend WithEvents btnAirconditioner As System.Windows.Forms.Button
    Friend WithEvents btnMakarting As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
End Class
