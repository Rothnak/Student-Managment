﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmclassmornig
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
        Me.lvclassmoring = New System.Windows.Forms.ListView()
        Me.chId = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chfname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chlname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chgender = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chdob = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chaddress = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chphonenumber = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chcoruse = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lvclassmoring
        '
        Me.lvclassmoring.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvclassmoring.BackColor = System.Drawing.Color.White
        Me.lvclassmoring.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chId, Me.chfname, Me.chlname, Me.chgender, Me.chdob, Me.chaddress, Me.chphonenumber, Me.chcoruse})
        Me.lvclassmoring.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvclassmoring.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lvclassmoring.FullRowSelect = True
        Me.lvclassmoring.Location = New System.Drawing.Point(12, 131)
        Me.lvclassmoring.Name = "lvclassmoring"
        Me.lvclassmoring.Size = New System.Drawing.Size(1367, 441)
        Me.lvclassmoring.TabIndex = 1
        Me.lvclassmoring.UseCompatibleStateImageBehavior = False
        Me.lvclassmoring.View = System.Windows.Forms.View.Details
        '
        'chId
        '
        Me.chId.Text = "ល.រ​ សិស្ស"
        Me.chId.Width = 125
        '
        'chfname
        '
        Me.chfname.Text = "ត្រកូល"
        Me.chfname.Width = 150
        '
        'chlname
        '
        Me.chlname.Text = "ឈ្មោះ"
        Me.chlname.Width = 154
        '
        'chgender
        '
        Me.chgender.Text = "ភេទ"
        Me.chgender.Width = 85
        '
        'chdob
        '
        Me.chdob.Text = "ថ្ងៃខែឆ្នាំកំណើត"
        Me.chdob.Width = 185
        '
        'chaddress
        '
        Me.chaddress.Text = "អាស័យដ្ធាន"
        Me.chaddress.Width = 180
        '
        'chphonenumber
        '
        Me.chphonenumber.Text = "លេខទូរស័ព្ទ"
        Me.chphonenumber.Width = 200
        '
        'chcoruse
        '
        Me.chcoruse.Text = "ជំនាញ"
        Me.chcoruse.Width = 119
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Khmer OS Muol Light", 26.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(579, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(267, 93)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "ថ្នាក់ព្រឹក"
        '
        'frmclassmornig
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1391, 584)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lvclassmoring)
        Me.Name = "frmclassmornig"
        Me.Text = "frmclassmornig"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lvclassmoring As System.Windows.Forms.ListView
    Friend WithEvents chId As System.Windows.Forms.ColumnHeader
    Friend WithEvents chfname As System.Windows.Forms.ColumnHeader
    Friend WithEvents chlname As System.Windows.Forms.ColumnHeader
    Friend WithEvents chgender As System.Windows.Forms.ColumnHeader
    Friend WithEvents chdob As System.Windows.Forms.ColumnHeader
    Friend WithEvents chaddress As System.Windows.Forms.ColumnHeader
    Friend WithEvents chphonenumber As System.Windows.Forms.ColumnHeader
    Friend WithEvents chcoruse As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
