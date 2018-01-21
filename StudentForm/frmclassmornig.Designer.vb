<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lvclassmorning = New System.Windows.Forms.ListView()
        Me.chId = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chfname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chlname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chgender = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chdob = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chphonenumber = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chaddress = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chcoruse = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chshift = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chyear = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chpayment = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Khmer OS Muol Light", 26.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(624, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(267, 93)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "ថ្នាក់ព្រឹក"
        '
        'lvclassmorning
        '
        Me.lvclassmorning.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvclassmorning.BackColor = System.Drawing.Color.White
        Me.lvclassmorning.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chId, Me.chfname, Me.chlname, Me.chgender, Me.chdob, Me.chphonenumber, Me.chaddress, Me.chcoruse, Me.chshift, Me.chyear, Me.chpayment})
        Me.lvclassmorning.Font = New System.Drawing.Font("Khmer OS Battambang", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvclassmorning.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lvclassmorning.FullRowSelect = True
        Me.lvclassmorning.Location = New System.Drawing.Point(33, 130)
        Me.lvclassmorning.Name = "lvclassmorning"
        Me.lvclassmorning.Size = New System.Drawing.Size(1416, 296)
        Me.lvclassmorning.TabIndex = 4
        Me.lvclassmorning.UseCompatibleStateImageBehavior = False
        Me.lvclassmorning.View = System.Windows.Forms.View.Details
        '
        'chId
        '
        Me.chId.Text = "ល.រ​ សិស្ស"
        Me.chId.Width = 100
        '
        'chfname
        '
        Me.chfname.Text = "ត្រកូល"
        Me.chfname.Width = 110
        '
        'chlname
        '
        Me.chlname.Text = "ឈ្មោះ"
        Me.chlname.Width = 110
        '
        'chgender
        '
        Me.chgender.Text = "ភេទ"
        Me.chgender.Width = 90
        '
        'chdob
        '
        Me.chdob.Text = "ថ្ងៃខែឆ្នាំកំណើត"
        Me.chdob.Width = 160
        '
        'chphonenumber
        '
        Me.chphonenumber.Text = "លេខទូរស័ព្ទ"
        Me.chphonenumber.Width = 100
        '
        'chaddress
        '
        Me.chaddress.Text = "អាស័យដ្ធាន"
        Me.chaddress.Width = 160
        '
        'chcoruse
        '
        Me.chcoruse.Text = "ជំនាញ"
        Me.chcoruse.Width = 90
        '
        'chshift
        '
        Me.chshift.Text = "Shift"
        Me.chshift.Width = 90
        '
        'chyear
        '
        Me.chyear.Text = "ឆ្នាំ"
        Me.chyear.Width = 101
        '
        'chpayment
        '
        Me.chpayment.Text = "Payment"
        Me.chpayment.Width = 144
        '
        'frmclassmornig
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1480, 543)
        Me.Controls.Add(Me.lvclassmorning)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmclassmornig"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmclassmornig"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lvclassmorning As System.Windows.Forms.ListView
    Friend WithEvents chId As System.Windows.Forms.ColumnHeader
    Friend WithEvents chfname As System.Windows.Forms.ColumnHeader
    Friend WithEvents chlname As System.Windows.Forms.ColumnHeader
    Friend WithEvents chgender As System.Windows.Forms.ColumnHeader
    Friend WithEvents chdob As System.Windows.Forms.ColumnHeader
    Friend WithEvents chphonenumber As System.Windows.Forms.ColumnHeader
    Friend WithEvents chaddress As System.Windows.Forms.ColumnHeader
    Friend WithEvents chcoruse As System.Windows.Forms.ColumnHeader
    Friend WithEvents chshift As System.Windows.Forms.ColumnHeader
    Friend WithEvents chyear As System.Windows.Forms.ColumnHeader
    Friend WithEvents chpayment As System.Windows.Forms.ColumnHeader
End Class
