<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmlvICT
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
        Me.txtcurrentuser = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.btnclose = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btndelete = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnupdate = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnadd = New System.Windows.Forms.ToolStripButton()
        Me.st_Menu = New System.Windows.Forms.ToolStrip()
        Me.chclass = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chcoruse = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chphonenumber = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chaddress = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chdob = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chgender = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chlname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chfname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chId = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvICT = New System.Windows.Forms.ListView()
        Me.chhyear = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chhpayment = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Image = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ToolStrip1.SuspendLayout()
        Me.st_Menu.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtcurrentuser
        '
        Me.txtcurrentuser.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtcurrentuser.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcurrentuser.Name = "txtcurrentuser"
        Me.txtcurrentuser.Size = New System.Drawing.Size(100, 39)
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton6.Image = Global.StudentForm.My.Resources.Resources.if_windows_2333413
        Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton6.Text = "ToolStripButton6"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton6, Me.ToolStripTextBox1, Me.txtcurrentuser})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 562)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1440, 39)
        Me.ToolStrip1.TabIndex = 5
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ToolStripTextBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(100, 39)
        Me.ToolStripTextBox1.Text = "User:"
        '
        'btnclose
        '
        Me.btnclose.Image = Global.StudentForm.My.Resources.Resources.if_103_111043
        Me.btnclose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(55, 79)
        Me.btnclose.Text = "បិទ"
        Me.btnclose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 82)
        '
        'btndelete
        '
        Me.btndelete.Image = Global.StudentForm.My.Resources.Resources.if_200_CircledMinus_183317
        Me.btndelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(64, 79)
        Me.btndelete.Text = "លុប"
        Me.btndelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 82)
        '
        'btnupdate
        '
        Me.btnupdate.Image = Global.StudentForm.My.Resources.Resources.if_folder_sans_edit_103560
        Me.btnupdate.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(79, 79)
        Me.btnupdate.Text = "កែប្រែ"
        Me.btnupdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 82)
        '
        'btnadd
        '
        Me.btnadd.Image = Global.StudentForm.My.Resources.Resources.if_group_full_add_103573
        Me.btnadd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(79, 79)
        Me.btnadd.Text = "បន្ថែម"
        Me.btnadd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'st_Menu
        '
        Me.st_Menu.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.st_Menu.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.st_Menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnadd, Me.ToolStripSeparator1, Me.btnupdate, Me.ToolStripSeparator2, Me.btndelete, Me.ToolStripSeparator3, Me.btnclose})
        Me.st_Menu.Location = New System.Drawing.Point(0, 0)
        Me.st_Menu.Name = "st_Menu"
        Me.st_Menu.Size = New System.Drawing.Size(1440, 82)
        Me.st_Menu.TabIndex = 4
        Me.st_Menu.Text = "ToolStrip Menu"
        '
        'chclass
        '
        Me.chclass.Text = "Shift"
        '
        'chcoruse
        '
        Me.chcoruse.Text = "Course"
        '
        'chphonenumber
        '
        Me.chphonenumber.DisplayIndex = 6
        Me.chphonenumber.Text = "PhoneNumber"
        Me.chphonenumber.Width = 130
        '
        'chaddress
        '
        Me.chaddress.DisplayIndex = 5
        Me.chaddress.Text = "Address"
        Me.chaddress.Width = 180
        '
        'chdob
        '
        Me.chdob.Text = "DOB"
        Me.chdob.Width = 162
        '
        'chgender
        '
        Me.chgender.Text = "Gender"
        Me.chgender.Width = 114
        '
        'chlname
        '
        Me.chlname.Text = "Lastname"
        Me.chlname.Width = 141
        '
        'chfname
        '
        Me.chfname.Text = "Firstname"
        Me.chfname.Width = 150
        '
        'chId
        '
        Me.chId.Text = "Student ID"
        Me.chId.Width = 110
        '
        'lvICT
        '
        Me.lvICT.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvICT.BackColor = System.Drawing.Color.White
        Me.lvICT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lvICT.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chId, Me.chfname, Me.chlname, Me.chgender, Me.chdob, Me.chphonenumber, Me.chaddress, Me.chcoruse, Me.chclass, Me.chhyear, Me.chhpayment, Me.Image})
        Me.lvICT.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvICT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lvICT.FullRowSelect = True
        Me.lvICT.Location = New System.Drawing.Point(38, 120)
        Me.lvICT.Name = "lvICT"
        Me.lvICT.Size = New System.Drawing.Size(1300, 322)
        Me.lvICT.TabIndex = 3
        Me.lvICT.UseCompatibleStateImageBehavior = False
        Me.lvICT.View = System.Windows.Forms.View.Details
        '
        'chhyear
        '
        Me.chhyear.Text = "Year"
        '
        'chhpayment
        '
        Me.chhpayment.Text = "Payment"
        '
        'Image
        '
        Me.Image.Text = "Image"
        '
        'frmlvICT
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1440, 601)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.st_Menu)
        Me.Controls.Add(Me.lvICT)
        Me.Name = "frmlvICT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmlvICT"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.st_Menu.ResumeLayout(False)
        Me.st_Menu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtcurrentuser As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripButton6 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents btnclose As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btndelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnupdate As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnadd As System.Windows.Forms.ToolStripButton
    Friend WithEvents st_Menu As System.Windows.Forms.ToolStrip
    Friend WithEvents chclass As System.Windows.Forms.ColumnHeader
    Friend WithEvents chcoruse As System.Windows.Forms.ColumnHeader
    Friend WithEvents chphonenumber As System.Windows.Forms.ColumnHeader
    Friend WithEvents chaddress As System.Windows.Forms.ColumnHeader
    Friend WithEvents chdob As System.Windows.Forms.ColumnHeader
    Friend WithEvents chgender As System.Windows.Forms.ColumnHeader
    Friend WithEvents chlname As System.Windows.Forms.ColumnHeader
    Friend WithEvents chfname As System.Windows.Forms.ColumnHeader
    Friend WithEvents chId As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvICT As System.Windows.Forms.ListView
    Friend WithEvents chhyear As System.Windows.Forms.ColumnHeader
    Friend WithEvents chhpayment As System.Windows.Forms.ColumnHeader
    Friend WithEvents Image As System.Windows.Forms.ColumnHeader
End Class
