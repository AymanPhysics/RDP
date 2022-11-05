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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.G = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RDP = New AxMSTSCLib.AxMsRdpClient9NotSafeForScripting()
        Me.ColName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColIP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColConnect = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.G, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RDP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'G
        '
        Me.G.AllowUserToAddRows = False
        Me.G.AllowUserToDeleteRows = False
        Me.G.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.G.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.G.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.G.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColName, Me.ColIP, Me.ColConnect})
        Me.G.Location = New System.Drawing.Point(12, 12)
        Me.G.Name = "G"
        Me.G.RowHeadersVisible = False
        Me.G.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.G.ShowEditingIcon = False
        Me.G.Size = New System.Drawing.Size(387, 271)
        Me.G.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(12, 290)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(387, 28)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Full Screen"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RDP
        '
        Me.RDP.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RDP.Enabled = True
        Me.RDP.Location = New System.Drawing.Point(405, 12)
        Me.RDP.Name = "RDP"
        Me.RDP.OcxState = CType(resources.GetObject("RDP.OcxState"), System.Windows.Forms.AxHost.State)
        Me.RDP.Size = New System.Drawing.Size(210, 306)
        Me.RDP.TabIndex = 0
        '
        'ColName
        '
        Me.ColName.FillWeight = 300.0!
        Me.ColName.HeaderText = "Name"
        Me.ColName.Name = "ColName"
        '
        'ColIP
        '
        Me.ColIP.FillWeight = 200.0!
        Me.ColIP.HeaderText = "IP"
        Me.ColIP.Name = "ColIP"
        '
        'ColConnect
        '
        Me.ColConnect.FillWeight = 150.0!
        Me.ColConnect.HeaderText = "Connect"
        Me.ColConnect.Name = "ColConnect"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(627, 330)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.G)
        Me.Controls.Add(Me.RDP)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.G, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RDP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RDP As AxMSTSCLib.AxMsRdpClient9NotSafeForScripting
    Friend WithEvents G As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ColName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColIP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColConnect As System.Windows.Forms.DataGridViewButtonColumn

End Class
