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
        Me.lvclassmoring = New System.Windows.Forms.ListView()
        Me.chId = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chfname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chlname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chgender = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chdob = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chaddress = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chphonenumber = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chcoruse = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chclass = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'lvclassmoring
        '
        Me.lvclassmoring.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvclassmoring.BackColor = System.Drawing.Color.White
        Me.lvclassmoring.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lvclassmoring.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chId, Me.chfname, Me.chlname, Me.chgender, Me.chdob, Me.chaddress, Me.chphonenumber, Me.chcoruse, Me.chclass})
        Me.lvclassmoring.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvclassmoring.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lvclassmoring.FullRowSelect = True
        Me.lvclassmoring.Location = New System.Drawing.Point(-8, 131)
        Me.lvclassmoring.Name = "lvclassmoring"
        Me.lvclassmoring.Size = New System.Drawing.Size(1407, 322)
        Me.lvclassmoring.TabIndex = 1
        Me.lvclassmoring.UseCompatibleStateImageBehavior = False
        Me.lvclassmoring.View = System.Windows.Forms.View.Details
        '
        'chId
        '
        Me.chId.Text = "Student ID"
        Me.chId.Width = 110
        '
        'chfname
        '
        Me.chfname.Text = "Firstname"
        Me.chfname.Width = 150
        '
        'chlname
        '
        Me.chlname.Text = "Lastname"
        Me.chlname.Width = 141
        '
        'chgender
        '
        Me.chgender.Text = "Gender"
        Me.chgender.Width = 114
        '
        'chdob
        '
        Me.chdob.Text = "DOB"
        Me.chdob.Width = 162
        '
        'chaddress
        '
        Me.chaddress.Text = "Address"
        Me.chaddress.Width = 180
        '
        'chphonenumber
        '
        Me.chphonenumber.Text = "PhoneNumber"
        Me.chphonenumber.Width = 130
        '
        'chcoruse
        '
        Me.chcoruse.Text = "Course"
        '
        'chclass
        '
        Me.chclass.Text = "Class"
        '
        'frmclassmornig
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1391, 584)
        Me.Controls.Add(Me.lvclassmoring)
        Me.Name = "frmclassmornig"
        Me.Text = "frmclassmornig"
        Me.ResumeLayout(False)

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
    Friend WithEvents chclass As System.Windows.Forms.ColumnHeader
End Class
