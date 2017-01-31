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
        Me.components = New System.ComponentModel.Container()
        Me.btnNewDwarf = New System.Windows.Forms.Button()
        Me.lbDwarves = New System.Windows.Forms.ListBox()
        Me.rtbOutput = New System.Windows.Forms.RichTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lblLumber = New System.Windows.Forms.Label()
        Me.lblFood = New System.Windows.Forms.Label()
        Me.tmrDataRefresh = New System.Windows.Forms.Timer(Me.components)
        Me.lblSelectedState = New System.Windows.Forms.Label()
        Me.lblStrength = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblCoords = New System.Windows.Forms.Label()
        Me.lbldamage = New System.Windows.Forms.Label()
        Me.lblHP = New System.Windows.Forms.Label()
        Me.lblWeight = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.txtRandom = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.lblSpeed = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnNewDwarf
        '
        Me.btnNewDwarf.Location = New System.Drawing.Point(12, 12)
        Me.btnNewDwarf.Name = "btnNewDwarf"
        Me.btnNewDwarf.Size = New System.Drawing.Size(75, 23)
        Me.btnNewDwarf.TabIndex = 0
        Me.btnNewDwarf.Text = "New Dwarf"
        Me.btnNewDwarf.UseVisualStyleBackColor = True
        '
        'lbDwarves
        '
        Me.lbDwarves.FormattingEnabled = True
        Me.lbDwarves.Location = New System.Drawing.Point(12, 52)
        Me.lbDwarves.Name = "lbDwarves"
        Me.lbDwarves.Size = New System.Drawing.Size(155, 277)
        Me.lbDwarves.TabIndex = 1
        '
        'rtbOutput
        '
        Me.rtbOutput.BackColor = System.Drawing.Color.Black
        Me.rtbOutput.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.rtbOutput.Location = New System.Drawing.Point(173, 52)
        Me.rtbOutput.Name = "rtbOutput"
        Me.rtbOutput.ReadOnly = True
        Me.rtbOutput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.rtbOutput.Size = New System.Drawing.Size(341, 277)
        Me.rtbOutput.TabIndex = 2
        Me.rtbOutput.Text = ""
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(174, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Give Item"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(255, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Inventory"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'lblLumber
        '
        Me.lblLumber.AutoSize = True
        Me.lblLumber.Location = New System.Drawing.Point(6, 16)
        Me.lblLumber.Name = "lblLumber"
        Me.lblLumber.Size = New System.Drawing.Size(45, 13)
        Me.lblLumber.TabIndex = 5
        Me.lblLumber.Text = "Lumber:"
        '
        'lblFood
        '
        Me.lblFood.AutoSize = True
        Me.lblFood.Location = New System.Drawing.Point(6, 34)
        Me.lblFood.Name = "lblFood"
        Me.lblFood.Size = New System.Drawing.Size(34, 13)
        Me.lblFood.TabIndex = 6
        Me.lblFood.Text = "Food:"
        '
        'tmrDataRefresh
        '
        '
        'lblSelectedState
        '
        Me.lblSelectedState.AutoSize = True
        Me.lblSelectedState.Location = New System.Drawing.Point(6, 16)
        Me.lblSelectedState.Name = "lblSelectedState"
        Me.lblSelectedState.Size = New System.Drawing.Size(38, 13)
        Me.lblSelectedState.TabIndex = 7
        Me.lblSelectedState.Text = "Curent"
        '
        'lblStrength
        '
        Me.lblStrength.AutoSize = True
        Me.lblStrength.Location = New System.Drawing.Point(5, 33)
        Me.lblStrength.Name = "lblStrength"
        Me.lblStrength.Size = New System.Drawing.Size(50, 13)
        Me.lblStrength.TabIndex = 8
        Me.lblStrength.Text = "Strength:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.lblLumber)
        Me.GroupBox1.Controls.Add(Me.lblFood)
        Me.GroupBox1.Location = New System.Drawing.Point(520, 52)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(288, 277)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblSpeed)
        Me.GroupBox2.Controls.Add(Me.lblCoords)
        Me.GroupBox2.Controls.Add(Me.lbldamage)
        Me.GroupBox2.Controls.Add(Me.lblHP)
        Me.GroupBox2.Controls.Add(Me.lblWeight)
        Me.GroupBox2.Controls.Add(Me.lblSelectedState)
        Me.GroupBox2.Controls.Add(Me.lblStrength)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 142)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(273, 129)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Selected Dwarf"
        '
        'lblCoords
        '
        Me.lblCoords.AutoSize = True
        Me.lblCoords.Location = New System.Drawing.Point(6, 95)
        Me.lblCoords.Name = "lblCoords"
        Me.lblCoords.Size = New System.Drawing.Size(69, 13)
        Me.lblCoords.TabIndex = 12
        Me.lblCoords.Text = "Coordinates: "
        '
        'lbldamage
        '
        Me.lbldamage.AutoSize = True
        Me.lbldamage.Location = New System.Drawing.Point(6, 80)
        Me.lbldamage.Name = "lbldamage"
        Me.lbldamage.Size = New System.Drawing.Size(50, 13)
        Me.lbldamage.TabIndex = 11
        Me.lbldamage.Text = "Damage:"
        '
        'lblHP
        '
        Me.lblHP.AutoSize = True
        Me.lblHP.Location = New System.Drawing.Point(6, 66)
        Me.lblHP.Name = "lblHP"
        Me.lblHP.Size = New System.Drawing.Size(28, 13)
        Me.lblHP.TabIndex = 10
        Me.lblHP.Text = "HP: "
        '
        'lblWeight
        '
        Me.lblWeight.AutoSize = True
        Me.lblWeight.Location = New System.Drawing.Point(6, 50)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(94, 13)
        Me.lblWeight.TabIndex = 9
        Me.lblWeight.Text = "Inventory Weight: "
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(92, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Fire Dwarf"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(407, 12)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(106, 23)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = "Generate Random"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'txtRandom
        '
        Me.txtRandom.Location = New System.Drawing.Point(520, 14)
        Me.txtRandom.Name = "txtRandom"
        Me.txtRandom.Size = New System.Drawing.Size(65, 20)
        Me.txtRandom.TabIndex = 12
        Me.txtRandom.Text = "1"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(733, 14)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 13
        Me.Button5.Text = "Tree Map"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'lblSpeed
        '
        Me.lblSpeed.AutoSize = True
        Me.lblSpeed.Location = New System.Drawing.Point(6, 110)
        Me.lblSpeed.Name = "lblSpeed"
        Me.lblSpeed.Size = New System.Drawing.Size(41, 13)
        Me.lblSpeed.TabIndex = 13
        Me.lblSpeed.Text = "Speed:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(820, 343)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.txtRandom)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.rtbOutput)
        Me.Controls.Add(Me.lbDwarves)
        Me.Controls.Add(Me.btnNewDwarf)
        Me.Name = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnNewDwarf As System.Windows.Forms.Button
    Friend WithEvents lbDwarves As System.Windows.Forms.ListBox
    Friend WithEvents rtbOutput As System.Windows.Forms.RichTextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents lblLumber As System.Windows.Forms.Label
    Friend WithEvents lblFood As System.Windows.Forms.Label
    Friend WithEvents tmrDataRefresh As System.Windows.Forms.Timer
    Friend WithEvents lblSelectedState As System.Windows.Forms.Label
    Friend WithEvents lblStrength As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents lblWeight As System.Windows.Forms.Label
    Friend WithEvents lblHP As System.Windows.Forms.Label
    Friend WithEvents lbldamage As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents txtRandom As System.Windows.Forms.TextBox
    Friend WithEvents lblCoords As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents lblSpeed As System.Windows.Forms.Label

End Class
