<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.headerPanel = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.burritosButton = New System.Windows.Forms.Button()
        Me.bowlsButton = New System.Windows.Forms.Button()
        Me.tacosButton = New System.Windows.Forms.Button()
        Me.drinksButton = New System.Windows.Forms.Button()
        Me.extrasButton = New System.Windows.Forms.Button()
        Me.nachosButton = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.productPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.headerPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'headerPanel
        '
        Me.headerPanel.BackColor = System.Drawing.Color.White
        Me.headerPanel.Controls.Add(Me.Label2)
        Me.headerPanel.Controls.Add(Me.Label1)
        Me.headerPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.headerPanel.Location = New System.Drawing.Point(0, 0)
        Me.headerPanel.Name = "headerPanel"
        Me.headerPanel.Size = New System.Drawing.Size(874, 90)
        Me.headerPanel.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(53, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "VERDE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 7.875!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(655, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(174, 30)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Build your order"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.Panel1.Controls.Add(Me.nachosButton)
        Me.Panel1.Controls.Add(Me.extrasButton)
        Me.Panel1.Controls.Add(Me.drinksButton)
        Me.Panel1.Controls.Add(Me.tacosButton)
        Me.Panel1.Controls.Add(Me.bowlsButton)
        Me.Panel1.Controls.Add(Me.burritosButton)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 90)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(180, 539)
        Me.Panel1.TabIndex = 1
        '
        'burritosButton
        '
        Me.burritosButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.burritosButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.burritosButton.ForeColor = System.Drawing.Color.White
        Me.burritosButton.Location = New System.Drawing.Point(12, 16)
        Me.burritosButton.Name = "burritosButton"
        Me.burritosButton.Size = New System.Drawing.Size(160, 65)
        Me.burritosButton.TabIndex = 0
        Me.burritosButton.Text = "🌯 Burritos"
        Me.burritosButton.UseVisualStyleBackColor = False
        '
        'bowlsButton
        '
        Me.bowlsButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.bowlsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bowlsButton.ForeColor = System.Drawing.Color.White
        Me.bowlsButton.Location = New System.Drawing.Point(12, 97)
        Me.bowlsButton.Name = "bowlsButton"
        Me.bowlsButton.Size = New System.Drawing.Size(160, 65)
        Me.bowlsButton.TabIndex = 1
        Me.bowlsButton.Text = "🥗 Bowls"
        Me.bowlsButton.UseVisualStyleBackColor = False
        '
        'tacosButton
        '
        Me.tacosButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.tacosButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tacosButton.ForeColor = System.Drawing.Color.White
        Me.tacosButton.Location = New System.Drawing.Point(12, 177)
        Me.tacosButton.Name = "tacosButton"
        Me.tacosButton.Size = New System.Drawing.Size(160, 65)
        Me.tacosButton.TabIndex = 2
        Me.tacosButton.Text = "🌮 Tacos"
        Me.tacosButton.UseVisualStyleBackColor = False
        '
        'drinksButton
        '
        Me.drinksButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.drinksButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.drinksButton.ForeColor = System.Drawing.Color.White
        Me.drinksButton.Location = New System.Drawing.Point(12, 354)
        Me.drinksButton.Name = "drinksButton"
        Me.drinksButton.Size = New System.Drawing.Size(160, 65)
        Me.drinksButton.TabIndex = 3
        Me.drinksButton.Text = "🥤 Drinks"
        Me.drinksButton.UseVisualStyleBackColor = False
        '
        'extrasButton
        '
        Me.extrasButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.extrasButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.extrasButton.ForeColor = System.Drawing.Color.White
        Me.extrasButton.Location = New System.Drawing.Point(12, 448)
        Me.extrasButton.Name = "extrasButton"
        Me.extrasButton.Size = New System.Drawing.Size(160, 65)
        Me.extrasButton.TabIndex = 4
        Me.extrasButton.Text = "🍪 Extras"
        Me.extrasButton.UseVisualStyleBackColor = False
        '
        'nachosButton
        '
        Me.nachosButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.nachosButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.nachosButton.ForeColor = System.Drawing.Color.White
        Me.nachosButton.Location = New System.Drawing.Point(12, 265)
        Me.nachosButton.Name = "nachosButton"
        Me.nachosButton.Size = New System.Drawing.Size(160, 65)
        Me.nachosButton.TabIndex = 5
        Me.nachosButton.Text = "🧀 Nachos"
        Me.nachosButton.UseVisualStyleBackColor = False
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(200, 100)
        Me.FlowLayoutPanel1.TabIndex = 2
        '
        'productPanel
        '
        Me.productPanel.AutoScroll = True
        Me.productPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.productPanel.Location = New System.Drawing.Point(180, 90)
        Me.productPanel.Name = "productPanel"
        Me.productPanel.Size = New System.Drawing.Size(694, 539)
        Me.productPanel.TabIndex = 3
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(874, 629)
        Me.Controls.Add(Me.productPanel)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.headerPanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VERDE POS"
        Me.headerPanel.ResumeLayout(False)
        Me.headerPanel.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents headerPanel As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents burritosButton As Button
    Friend WithEvents extrasButton As Button
    Friend WithEvents drinksButton As Button
    Friend WithEvents tacosButton As Button
    Friend WithEvents bowlsButton As Button
    Friend WithEvents nachosButton As Button
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents productPanel As FlowLayoutPanel
End Class
