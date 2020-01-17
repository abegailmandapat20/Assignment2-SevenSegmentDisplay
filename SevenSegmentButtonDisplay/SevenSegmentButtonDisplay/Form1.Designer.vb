<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.UpperMid = New System.Windows.Forms.Button()
        Me.Mid = New System.Windows.Forms.Button()
        Me.LowerMid = New System.Windows.Forms.Button()
        Me.LowerRight = New System.Windows.Forms.Button()
        Me.UpperLeft = New System.Windows.Forms.Button()
        Me.LowerLeft = New System.Windows.Forms.Button()
        Me.UpperRight = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Timer
        '
        Me.Timer.Enabled = True
        Me.Timer.Interval = 1000
        '
        'UpperMid
        '
        Me.UpperMid.Location = New System.Drawing.Point(312, 145)
        Me.UpperMid.Name = "UpperMid"
        Me.UpperMid.Size = New System.Drawing.Size(144, 27)
        Me.UpperMid.TabIndex = 0
        Me.UpperMid.UseVisualStyleBackColor = True
        '
        'Mid
        '
        Me.Mid.Location = New System.Drawing.Point(312, 314)
        Me.Mid.Name = "Mid"
        Me.Mid.Size = New System.Drawing.Size(144, 27)
        Me.Mid.TabIndex = 1
        Me.Mid.UseVisualStyleBackColor = True
        '
        'LowerMid
        '
        Me.LowerMid.Location = New System.Drawing.Point(312, 478)
        Me.LowerMid.Name = "LowerMid"
        Me.LowerMid.Size = New System.Drawing.Size(144, 27)
        Me.LowerMid.TabIndex = 2
        Me.LowerMid.UseVisualStyleBackColor = True
        '
        'LowerRight
        '
        Me.LowerRight.Location = New System.Drawing.Point(462, 339)
        Me.LowerRight.Name = "LowerRight"
        Me.LowerRight.Size = New System.Drawing.Size(27, 144)
        Me.LowerRight.TabIndex = 3
        Me.LowerRight.UseVisualStyleBackColor = True
        '
        'UpperLeft
        '
        Me.UpperLeft.Location = New System.Drawing.Point(281, 169)
        Me.UpperLeft.Name = "UpperLeft"
        Me.UpperLeft.Size = New System.Drawing.Size(27, 144)
        Me.UpperLeft.TabIndex = 4
        Me.UpperLeft.UseVisualStyleBackColor = True
        '
        'LowerLeft
        '
        Me.LowerLeft.Location = New System.Drawing.Point(279, 338)
        Me.LowerLeft.Name = "LowerLeft"
        Me.LowerLeft.Size = New System.Drawing.Size(27, 144)
        Me.LowerLeft.TabIndex = 5
        Me.LowerLeft.UseVisualStyleBackColor = True
        '
        'UpperRight
        '
        Me.UpperRight.Location = New System.Drawing.Point(460, 171)
        Me.UpperRight.Name = "UpperRight"
        Me.UpperRight.Size = New System.Drawing.Size(27, 144)
        Me.UpperRight.TabIndex = 6
        Me.UpperRight.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(795, 716)
        Me.Controls.Add(Me.UpperRight)
        Me.Controls.Add(Me.LowerLeft)
        Me.Controls.Add(Me.UpperLeft)
        Me.Controls.Add(Me.LowerRight)
        Me.Controls.Add(Me.LowerMid)
        Me.Controls.Add(Me.Mid)
        Me.Controls.Add(Me.UpperMid)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.Text = "SevenSegmentDisplay"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer As Timer
    Friend WithEvents UpperMid As Button
    Friend WithEvents Mid As Button
    Friend WithEvents LowerMid As Button
    Friend WithEvents LowerRight As Button
    Friend WithEvents UpperLeft As Button
    Friend WithEvents LowerLeft As Button
    Friend WithEvents UpperRight As Button
End Class
