<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCatering
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCatering))
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.grpBoxSelections = New System.Windows.Forms.GroupBox()
        Me.radBtnFruit = New System.Windows.Forms.RadioButton()
        Me.radBtnSausage = New System.Windows.Forms.RadioButton()
        Me.radBtnVeggie = New System.Windows.Forms.RadioButton()
        Me.radBtnPinwheel = New System.Windows.Forms.RadioButton()
        Me.radBtnGourmet = New System.Windows.Forms.RadioButton()
        Me.grpBoxPayment = New System.Windows.Forms.GroupBox()
        Me.radBtnPayPickup = New System.Windows.Forms.RadioButton()
        Me.radBtnPrePay = New System.Windows.Forms.RadioButton()
        Me.picBoxCatering = New System.Windows.Forms.PictureBox()
        Me.lblPoints = New System.Windows.Forms.Label()
        Me.txtBoxPoints = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblPay = New System.Windows.Forms.Label()
        Me.grpBoxSelections.SuspendLayout()
        Me.grpBoxPayment.SuspendLayout()
        CType(Me.picBoxCatering, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(112, 12)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(125, 31)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "Catering"
        '
        'grpBoxSelections
        '
        Me.grpBoxSelections.BackColor = System.Drawing.SystemColors.Window
        Me.grpBoxSelections.Controls.Add(Me.radBtnFruit)
        Me.grpBoxSelections.Controls.Add(Me.radBtnSausage)
        Me.grpBoxSelections.Controls.Add(Me.radBtnVeggie)
        Me.grpBoxSelections.Controls.Add(Me.radBtnPinwheel)
        Me.grpBoxSelections.Controls.Add(Me.radBtnGourmet)
        Me.grpBoxSelections.Location = New System.Drawing.Point(23, 74)
        Me.grpBoxSelections.Name = "grpBoxSelections"
        Me.grpBoxSelections.Size = New System.Drawing.Size(294, 211)
        Me.grpBoxSelections.TabIndex = 1
        Me.grpBoxSelections.TabStop = False
        '
        'radBtnFruit
        '
        Me.radBtnFruit.AutoSize = True
        Me.radBtnFruit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radBtnFruit.Location = New System.Drawing.Point(13, 171)
        Me.radBtnFruit.Name = "radBtnFruit"
        Me.radBtnFruit.Size = New System.Drawing.Size(92, 20)
        Me.radBtnFruit.TabIndex = 4
        Me.radBtnFruit.TabStop = True
        Me.radBtnFruit.Text = "Fruit $29.99"
        Me.radBtnFruit.UseVisualStyleBackColor = True
        '
        'radBtnSausage
        '
        Me.radBtnSausage.AutoSize = True
        Me.radBtnSausage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radBtnSausage.Location = New System.Drawing.Point(13, 133)
        Me.radBtnSausage.Name = "radBtnSausage"
        Me.radBtnSausage.Size = New System.Drawing.Size(198, 20)
        Me.radBtnSausage.TabIndex = 3
        Me.radBtnSausage.TabStop = True
        Me.radBtnSausage.Text = "Sausage and Cheese $49.99"
        Me.radBtnSausage.UseVisualStyleBackColor = True
        '
        'radBtnVeggie
        '
        Me.radBtnVeggie.AutoSize = True
        Me.radBtnVeggie.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radBtnVeggie.Location = New System.Drawing.Point(13, 94)
        Me.radBtnVeggie.Name = "radBtnVeggie"
        Me.radBtnVeggie.Size = New System.Drawing.Size(111, 20)
        Me.radBtnVeggie.TabIndex = 2
        Me.radBtnVeggie.TabStop = True
        Me.radBtnVeggie.Text = "Veggie $29.99"
        Me.radBtnVeggie.UseVisualStyleBackColor = True
        '
        'radBtnPinwheel
        '
        Me.radBtnPinwheel.AutoSize = True
        Me.radBtnPinwheel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radBtnPinwheel.Location = New System.Drawing.Point(13, 54)
        Me.radBtnPinwheel.Name = "radBtnPinwheel"
        Me.radBtnPinwheel.Size = New System.Drawing.Size(164, 20)
        Me.radBtnPinwheel.TabIndex = 1
        Me.radBtnPinwheel.TabStop = True
        Me.radBtnPinwheel.Text = "Pinwheel Wraps $59.99"
        Me.radBtnPinwheel.UseVisualStyleBackColor = True
        '
        'radBtnGourmet
        '
        Me.radBtnGourmet.AutoSize = True
        Me.radBtnGourmet.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radBtnGourmet.Location = New System.Drawing.Point(13, 19)
        Me.radBtnGourmet.Name = "radBtnGourmet"
        Me.radBtnGourmet.Size = New System.Drawing.Size(168, 20)
        Me.radBtnGourmet.TabIndex = 0
        Me.radBtnGourmet.TabStop = True
        Me.radBtnGourmet.Text = "Gourmet Cheese $49.99"
        Me.radBtnGourmet.UseVisualStyleBackColor = True
        '
        'grpBoxPayment
        '
        Me.grpBoxPayment.BackColor = System.Drawing.SystemColors.Window
        Me.grpBoxPayment.Controls.Add(Me.radBtnPayPickup)
        Me.grpBoxPayment.Controls.Add(Me.radBtnPrePay)
        Me.grpBoxPayment.Location = New System.Drawing.Point(82, 300)
        Me.grpBoxPayment.Name = "grpBoxPayment"
        Me.grpBoxPayment.Size = New System.Drawing.Size(166, 78)
        Me.grpBoxPayment.TabIndex = 2
        Me.grpBoxPayment.TabStop = False
        '
        'radBtnPayPickup
        '
        Me.radBtnPayPickup.AutoSize = True
        Me.radBtnPayPickup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radBtnPayPickup.Location = New System.Drawing.Point(7, 42)
        Me.radBtnPayPickup.Name = "radBtnPayPickup"
        Me.radBtnPayPickup.Size = New System.Drawing.Size(127, 20)
        Me.radBtnPayPickup.TabIndex = 1
        Me.radBtnPayPickup.TabStop = True
        Me.radBtnPayPickup.Text = "Pay upon Pickup"
        Me.radBtnPayPickup.UseVisualStyleBackColor = True
        '
        'radBtnPrePay
        '
        Me.radBtnPrePay.AutoSize = True
        Me.radBtnPrePay.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radBtnPrePay.Location = New System.Drawing.Point(7, 19)
        Me.radBtnPrePay.Name = "radBtnPrePay"
        Me.radBtnPrePay.Size = New System.Drawing.Size(75, 20)
        Me.radBtnPrePay.TabIndex = 0
        Me.radBtnPrePay.TabStop = True
        Me.radBtnPrePay.Text = "Pre-Pay"
        Me.radBtnPrePay.UseVisualStyleBackColor = True
        '
        'picBoxCatering
        '
        Me.picBoxCatering.Image = CType(resources.GetObject("picBoxCatering.Image"), System.Drawing.Image)
        Me.picBoxCatering.Location = New System.Drawing.Point(360, 12)
        Me.picBoxCatering.Name = "picBoxCatering"
        Me.picBoxCatering.Size = New System.Drawing.Size(360, 233)
        Me.picBoxCatering.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBoxCatering.TabIndex = 3
        Me.picBoxCatering.TabStop = False
        '
        'lblPoints
        '
        Me.lblPoints.AutoSize = True
        Me.lblPoints.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPoints.Location = New System.Drawing.Point(411, 273)
        Me.lblPoints.Name = "lblPoints"
        Me.lblPoints.Size = New System.Drawing.Size(114, 18)
        Me.lblPoints.TabIndex = 4
        Me.lblPoints.Text = "Loyalty Points"
        '
        'txtBoxPoints
        '
        Me.txtBoxPoints.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxPoints.Location = New System.Drawing.Point(580, 269)
        Me.txtBoxPoints.Name = "txtBoxPoints"
        Me.txtBoxPoints.Size = New System.Drawing.Size(38, 26)
        Me.txtBoxPoints.TabIndex = 5
        Me.txtBoxPoints.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.Beige
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(391, 355)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(109, 33)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(221, 430)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(64, 20)
        Me.lblTotal.TabIndex = 8
        Me.lblTotal.Text = "$00.00"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(107, 43)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(103, 20)
        Me.lblTitle.TabIndex = 9
        Me.lblTitle.Text = "Star Market"
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Beige
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(568, 355)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(109, 33)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'lblPay
        '
        Me.lblPay.AutoSize = True
        Me.lblPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPay.Location = New System.Drawing.Point(64, 430)
        Me.lblPay.Name = "lblPay"
        Me.lblPay.Size = New System.Drawing.Size(102, 20)
        Me.lblPay.TabIndex = 11
        Me.lblPay.Text = "Please Pay:"
        '
        'frmCatering
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Beige
        Me.ClientSize = New System.Drawing.Size(739, 495)
        Me.Controls.Add(Me.lblPay)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtBoxPoints)
        Me.Controls.Add(Me.lblPoints)
        Me.Controls.Add(Me.picBoxCatering)
        Me.Controls.Add(Me.grpBoxPayment)
        Me.Controls.Add(Me.grpBoxSelections)
        Me.Controls.Add(Me.lblHeader)
        Me.Name = "frmCatering"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Catering"
        Me.grpBoxSelections.ResumeLayout(False)
        Me.grpBoxSelections.PerformLayout()
        Me.grpBoxPayment.ResumeLayout(False)
        Me.grpBoxPayment.PerformLayout()
        CType(Me.picBoxCatering, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeader As Label
    Friend WithEvents grpBoxSelections As GroupBox
    Friend WithEvents radBtnFruit As RadioButton
    Friend WithEvents radBtnSausage As RadioButton
    Friend WithEvents radBtnVeggie As RadioButton
    Friend WithEvents radBtnPinwheel As RadioButton
    Friend WithEvents radBtnGourmet As RadioButton
    Friend WithEvents grpBoxPayment As GroupBox
    Friend WithEvents radBtnPayPickup As RadioButton
    Friend WithEvents radBtnPrePay As RadioButton
    Friend WithEvents picBoxCatering As PictureBox
    Friend WithEvents lblPoints As Label
    Friend WithEvents txtBoxPoints As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents lblPay As Label
End Class
