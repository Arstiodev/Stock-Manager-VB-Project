<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TableuDuBordButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Stock1 = New Stock_Manager_VB_Project.Stock()
        Me.Achat1 = New Stock_Manager_VB_Project.Achat()
        Me.Home1 = New Stock_Manager_VB_Project.Home()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.Panel9)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.TableuDuBordButton)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(205, 455)
        Me.Panel1.TabIndex = 0
        '
        'Panel9
        '
        Me.Panel9.BackgroundImage = CType(resources.GetObject("Panel9.BackgroundImage"), System.Drawing.Image)
        Me.Panel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel9.Location = New System.Drawing.Point(6, 17)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(186, 67)
        Me.Panel9.TabIndex = 4
        '
        'Button4
        '
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(2, 384)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(200, 48)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Quit"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(3, 293)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(200, 48)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Clients"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(2, 239)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(200, 48)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Gestion de stock"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TableuDuBordButton
        '
        Me.TableuDuBordButton.FlatAppearance.BorderSize = 0
        Me.TableuDuBordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TableuDuBordButton.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableuDuBordButton.Image = CType(resources.GetObject("TableuDuBordButton.Image"), System.Drawing.Image)
        Me.TableuDuBordButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.TableuDuBordButton.Location = New System.Drawing.Point(3, 131)
        Me.TableuDuBordButton.Name = "TableuDuBordButton"
        Me.TableuDuBordButton.Size = New System.Drawing.Size(200, 48)
        Me.TableuDuBordButton.TabIndex = 3
        Me.TableuDuBordButton.Text = "Tableau du bord"
        Me.TableuDuBordButton.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(4, 185)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(200, 48)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = " Nouvel achat"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SlateBlue
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(204, 1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(749, 54)
        Me.Panel2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label1.Location = New System.Drawing.Point(148, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(544, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "GESTION DE STOCK APPLICATION BY AMINE ET HAJAR"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(16, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Tableau de bord"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Location = New System.Drawing.Point(204, 52)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(749, 44)
        Me.Panel3.TabIndex = 2
        '
        'Timer1
        '
        '
        'Stock1
        '
        Me.Stock1.AutoSize = True
        Me.Stock1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Stock1.Location = New System.Drawing.Point(204, 87)
        Me.Stock1.Name = "Stock1"
        Me.Stock1.Size = New System.Drawing.Size(692, 403)
        Me.Stock1.TabIndex = 5
        Me.Stock1.Visible = False
        '
        'Achat1
        '
        Me.Achat1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Achat1.Location = New System.Drawing.Point(204, 87)
        Me.Achat1.Name = "Achat1"
        Me.Achat1.Size = New System.Drawing.Size(692, 403)
        Me.Achat1.TabIndex = 4
        Me.Achat1.Visible = False
        '
        'Home1
        '
        Me.Home1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Home1.Location = New System.Drawing.Point(204, 87)
        Me.Home1.Name = "Home1"
        Me.Home1.Size = New System.Drawing.Size(692, 403)
        Me.Home1.TabIndex = 3
        Me.Home1.Visible = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(897, 455)
        Me.Controls.Add(Me.Stock1)
        Me.Controls.Add(Me.Achat1)
        Me.Controls.Add(Me.Home1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents TableuDuBordButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Home1 As Home
    Friend WithEvents Achat1 As Achat
    Friend WithEvents Stock1 As Stock
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Timer1 As Timer
End Class
