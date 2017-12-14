<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmclassevening
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lvclassevening = New System.Windows.Forms.ListView()
        Me.chId = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chfname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chlname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chgender = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chdob = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chaddress = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chphonenumber = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chcoruse = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Khmer OS Muol Light", 26.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(558, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(277, 93)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "ថ្នាក់ល្ងាច"
        '
        'lvclassevening
        '
        Me.lvclassevening.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvclassevening.BackColor = System.Drawing.Color.White
        Me.lvclassevening.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chId, Me.chfname, Me.chlname, Me.chgender, Me.chdob, Me.chaddress, Me.chphonenumber, Me.chcoruse})
        Me.lvclassevening.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvclassevening.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lvclassevening.FullRowSelect = True
        Me.lvclassevening.Location = New System.Drawing.Point(16, 198)
        Me.lvclassevening.Name = "lvclassevening"
        Me.lvclassevening.Size = New System.Drawing.Size(1333, 341)
        Me.lvclassevening.TabIndex = 3
        Me.lvclassevening.UseCompatibleStateImageBehavior = False
        Me.lvclassevening.View = System.Windows.Forms.View.Details
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
        'frmclassevening
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1365, 687)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lvclassevening)
        Me.Name = "frmclassevening"
        Me.Text = "frmclassevening"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lvclassevening As System.Windows.Forms.ListView
    Friend WithEvents chId As System.Windows.Forms.ColumnHeader
    Friend WithEvents chfname As System.Windows.Forms.ColumnHeader
    Friend WithEvents chlname As System.Windows.Forms.ColumnHeader
    Friend WithEvents chgender As System.Windows.Forms.ColumnHeader
    Friend WithEvents chdob As System.Windows.Forms.ColumnHeader
    Friend WithEvents chaddress As System.Windows.Forms.ColumnHeader
    Friend WithEvents chphonenumber As System.Windows.Forms.ColumnHeader
    Friend WithEvents chcoruse As System.Windows.Forms.ColumnHeader
End Class
