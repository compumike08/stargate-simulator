<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.components = New System.ComponentModel.Container()
        Me.tmrDialClockwise = New System.Windows.Forms.Timer(Me.components)
        Me.tmrDialCounterclockwise = New System.Windows.Forms.Timer(Me.components)
        Me.encoded1 = New System.Windows.Forms.Panel()
        Me.encoded2 = New System.Windows.Forms.Panel()
        Me.encoded3 = New System.Windows.Forms.Panel()
        Me.encoded4 = New System.Windows.Forms.Panel()
        Me.encoded5 = New System.Windows.Forms.Panel()
        Me.encoded6 = New System.Windows.Forms.Panel()
        Me.encoded7 = New System.Windows.Forms.Panel()
        Me.cmdDial = New System.Windows.Forms.Button()
        Me.cmdAbort = New System.Windows.Forms.Button()
        Me.gateBackground = New System.Windows.Forms.Panel()
        Me.glyphContainer = New System.Windows.Forms.Panel()
        Me.txtLocked = New System.Windows.Forms.TextBox()
        Me.gateBackground.SuspendLayout()
        Me.glyphContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'tmrDialClockwise
        '
        Me.tmrDialClockwise.Interval = 500
        '
        'tmrDialCounterclockwise
        '
        Me.tmrDialCounterclockwise.Interval = 500
        '
        'encoded1
        '
        Me.encoded1.BackColor = System.Drawing.Color.LightGray
        Me.encoded1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.encoded1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.encoded1.Location = New System.Drawing.Point(1332, 36)
        Me.encoded1.Name = "encoded1"
        Me.encoded1.Size = New System.Drawing.Size(115, 115)
        Me.encoded1.TabIndex = 1
        '
        'encoded2
        '
        Me.encoded2.BackColor = System.Drawing.Color.LightGray
        Me.encoded2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.encoded2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.encoded2.Location = New System.Drawing.Point(1332, 157)
        Me.encoded2.Name = "encoded2"
        Me.encoded2.Size = New System.Drawing.Size(115, 115)
        Me.encoded2.TabIndex = 2
        '
        'encoded3
        '
        Me.encoded3.BackColor = System.Drawing.Color.LightGray
        Me.encoded3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.encoded3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.encoded3.Location = New System.Drawing.Point(1332, 278)
        Me.encoded3.Name = "encoded3"
        Me.encoded3.Size = New System.Drawing.Size(115, 115)
        Me.encoded3.TabIndex = 2
        '
        'encoded4
        '
        Me.encoded4.BackColor = System.Drawing.Color.LightGray
        Me.encoded4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.encoded4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.encoded4.Location = New System.Drawing.Point(1332, 399)
        Me.encoded4.Name = "encoded4"
        Me.encoded4.Size = New System.Drawing.Size(115, 115)
        Me.encoded4.TabIndex = 2
        '
        'encoded5
        '
        Me.encoded5.BackColor = System.Drawing.Color.LightGray
        Me.encoded5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.encoded5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.encoded5.Location = New System.Drawing.Point(1332, 520)
        Me.encoded5.Name = "encoded5"
        Me.encoded5.Size = New System.Drawing.Size(115, 115)
        Me.encoded5.TabIndex = 2
        '
        'encoded6
        '
        Me.encoded6.BackColor = System.Drawing.Color.LightGray
        Me.encoded6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.encoded6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.encoded6.Location = New System.Drawing.Point(1332, 641)
        Me.encoded6.Name = "encoded6"
        Me.encoded6.Size = New System.Drawing.Size(115, 115)
        Me.encoded6.TabIndex = 2
        '
        'encoded7
        '
        Me.encoded7.BackColor = System.Drawing.Color.LightGray
        Me.encoded7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.encoded7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.encoded7.Location = New System.Drawing.Point(1332, 762)
        Me.encoded7.Name = "encoded7"
        Me.encoded7.Size = New System.Drawing.Size(115, 115)
        Me.encoded7.TabIndex = 3
        '
        'cmdDial
        '
        Me.cmdDial.Enabled = False
        Me.cmdDial.Location = New System.Drawing.Point(1137, 705)
        Me.cmdDial.Name = "cmdDial"
        Me.cmdDial.Size = New System.Drawing.Size(165, 62)
        Me.cmdDial.TabIndex = 4
        Me.cmdDial.Text = "DIAL"
        Me.cmdDial.UseVisualStyleBackColor = True
        '
        'cmdAbort
        '
        Me.cmdAbort.Enabled = False
        Me.cmdAbort.Location = New System.Drawing.Point(1137, 798)
        Me.cmdAbort.Name = "cmdAbort"
        Me.cmdAbort.Size = New System.Drawing.Size(165, 62)
        Me.cmdAbort.TabIndex = 5
        Me.cmdAbort.Text = "ABORT"
        Me.cmdAbort.UseVisualStyleBackColor = True
        '
        'gateBackground
        '
        Me.gateBackground.BackgroundImage = Global.Stargate_Simulator.My.Resources.Resources.Milky_Way_stargate
        Me.gateBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.gateBackground.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.gateBackground.Controls.Add(Me.glyphContainer)
        Me.gateBackground.Location = New System.Drawing.Point(394, 98)
        Me.gateBackground.Name = "gateBackground"
        Me.gateBackground.Size = New System.Drawing.Size(690, 690)
        Me.gateBackground.TabIndex = 0
        '
        'glyphContainer
        '
        Me.glyphContainer.BackgroundImage = Global.Stargate_Simulator.My.Resources.Resources.MilkyWayGlyph01
        Me.glyphContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.glyphContainer.Controls.Add(Me.txtLocked)
        Me.glyphContainer.Location = New System.Drawing.Point(174, 174)
        Me.glyphContainer.Name = "glyphContainer"
        Me.glyphContainer.Size = New System.Drawing.Size(340, 340)
        Me.glyphContainer.TabIndex = 0
        '
        'txtLocked
        '
        Me.txtLocked.BackColor = System.Drawing.Color.Black
        Me.txtLocked.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLocked.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLocked.ForeColor = System.Drawing.Color.Red
        Me.txtLocked.Location = New System.Drawing.Point(79, 144)
        Me.txtLocked.Name = "txtLocked"
        Me.txtLocked.Size = New System.Drawing.Size(182, 53)
        Me.txtLocked.TabIndex = 0
        Me.txtLocked.Text = "LOCKED"
        Me.txtLocked.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtLocked.Visible = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1479, 887)
        Me.Controls.Add(Me.cmdAbort)
        Me.Controls.Add(Me.cmdDial)
        Me.Controls.Add(Me.encoded7)
        Me.Controls.Add(Me.encoded6)
        Me.Controls.Add(Me.encoded5)
        Me.Controls.Add(Me.encoded4)
        Me.Controls.Add(Me.encoded3)
        Me.Controls.Add(Me.encoded2)
        Me.Controls.Add(Me.encoded1)
        Me.Controls.Add(Me.gateBackground)
        Me.Name = "Main"
        Me.Text = "Main"
        Me.gateBackground.ResumeLayout(False)
        Me.glyphContainer.ResumeLayout(False)
        Me.glyphContainer.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gateBackground As Panel
    Friend WithEvents glyphContainer As Panel
    Friend WithEvents tmrDialClockwise As Timer
    Friend WithEvents tmrDialCounterclockwise As Timer
    Friend WithEvents encoded1 As Panel
    Friend WithEvents encoded2 As Panel
    Friend WithEvents encoded3 As Panel
    Friend WithEvents encoded4 As Panel
    Friend WithEvents encoded5 As Panel
    Friend WithEvents encoded6 As Panel
    Friend WithEvents encoded7 As Panel
    Friend WithEvents cmdDial As Button
    Friend WithEvents txtLocked As TextBox
    Friend WithEvents cmdAbort As Button
End Class
