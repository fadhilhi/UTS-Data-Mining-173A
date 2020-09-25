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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label_Hasil = New System.Windows.Forms.Label()
        Me.cb_humadity = New System.Windows.Forms.ComboBox()
        Me.cb_outlook = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.b_hitung = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(37, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(371, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PENENTUAN PERTANDINGAN GOLF "
        '
        'Label_Hasil
        '
        Me.Label_Hasil.AutoSize = True
        Me.Label_Hasil.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Hasil.Location = New System.Drawing.Point(261, 192)
        Me.Label_Hasil.Name = "Label_Hasil"
        Me.Label_Hasil.Size = New System.Drawing.Size(68, 24)
        Me.Label_Hasil.TabIndex = 1
        Me.Label_Hasil.Text = "HASIL"
        '
        'cb_humadity
        '
        Me.cb_humadity.FormattingEnabled = True
        Me.cb_humadity.Items.AddRange(New Object() {"Normal", "Tinggi"})
        Me.cb_humadity.Location = New System.Drawing.Point(140, 83)
        Me.cb_humadity.Name = "cb_humadity"
        Me.cb_humadity.Size = New System.Drawing.Size(121, 21)
        Me.cb_humadity.TabIndex = 2
        '
        'cb_outlook
        '
        Me.cb_outlook.FormattingEnabled = True
        Me.cb_outlook.Items.AddRange(New Object() {"Berawan", "Cerah", "Hujan"})
        Me.cb_outlook.Location = New System.Drawing.Point(140, 143)
        Me.cb_outlook.Name = "cb_outlook"
        Me.cb_outlook.Size = New System.Drawing.Size(121, 21)
        Me.cb_outlook.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "HUMADITY"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(38, 151)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "OUTLOOK"
        '
        'b_hitung
        '
        Me.b_hitung.Location = New System.Drawing.Point(140, 192)
        Me.b_hitung.Name = "b_hitung"
        Me.b_hitung.Size = New System.Drawing.Size(75, 23)
        Me.b_hitung.TabIndex = 6
        Me.b_hitung.Text = "YA/TIDAK"
        Me.b_hitung.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 372)
        Me.Controls.Add(Me.b_hitung)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cb_outlook)
        Me.Controls.Add(Me.cb_humadity)
        Me.Controls.Add(Me.Label_Hasil)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label_Hasil As System.Windows.Forms.Label
    Friend WithEvents cb_humadity As System.Windows.Forms.ComboBox
    Friend WithEvents cb_outlook As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents b_hitung As System.Windows.Forms.Button

End Class
