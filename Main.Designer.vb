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
        Me.gateBackground = New System.Windows.Forms.Panel()
        Me.glyphContainer = New System.Windows.Forms.Panel()
        Me.gateBackground.SuspendLayout()
        Me.SuspendLayout()
        '
        'gateBackground
        '
        Me.gateBackground.BackgroundImage = Global.Stargate_Simulator.My.Resources.Resources.Milky_Way_stargate
        Me.gateBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.gateBackground.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.gateBackground.Controls.Add(Me.glyphContainer)
        Me.gateBackground.Location = New System.Drawing.Point(394, 72)
        Me.gateBackground.Name = "gateBackground"
        Me.gateBackground.Size = New System.Drawing.Size(690, 690)
        Me.gateBackground.TabIndex = 0
        '
        'glyphContainer
        '
        Me.glyphContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.glyphContainer.Location = New System.Drawing.Point(174, 174)
        Me.glyphContainer.Name = "glyphContainer"
        Me.glyphContainer.Size = New System.Drawing.Size(340, 340)
        Me.glyphContainer.TabIndex = 0
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1479, 834)
        Me.Controls.Add(Me.gateBackground)
        Me.Name = "Main"
        Me.Text = "Main"
        Me.gateBackground.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gateBackground As Panel
    Friend WithEvents glyphContainer As Panel
End Class
