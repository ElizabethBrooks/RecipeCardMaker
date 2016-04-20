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
        Me.IngredientPanel = New System.Windows.Forms.Panel()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.MeasurementComboBox = New System.Windows.Forms.ComboBox()
        Me.QuantityNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.IngredientNameTextBox = New System.Windows.Forms.TextBox()
        Me.IngredientNameLabel = New System.Windows.Forms.Label()
        Me.MeasurementLabel = New System.Windows.Forms.Label()
        Me.QuantityLabel = New System.Windows.Forms.Label()
        Me.RecipeNameLabel = New System.Windows.Forms.Label()
        Me.RecipeNameTextBox = New System.Windows.Forms.TextBox()
        Me.NotesLabel = New System.Windows.Forms.Label()
        Me.NotesTextBox = New System.Windows.Forms.TextBox()
        Me.IngredientsListLabel = New System.Windows.Forms.Label()
        Me.DoubleButton = New System.Windows.Forms.Button()
        Me.HalfButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.PreviewObject = New System.Windows.Forms.PrintPreviewDialog()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.PreviewButton = New System.Windows.Forms.Button()
        Me.ClearAllButton = New System.Windows.Forms.Button()
        Me.IntroLabel = New System.Windows.Forms.Label()
        Me.QuantityListBox = New System.Windows.Forms.ListBox()
        Me.MeasureListBox = New System.Windows.Forms.ListBox()
        Me.IngredientListBox = New System.Windows.Forms.ListBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.OpenButton = New System.Windows.Forms.Button()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.IngredientPanel.SuspendLayout()
        CType(Me.QuantityNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'IngredientPanel
        '
        Me.IngredientPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IngredientPanel.Controls.Add(Me.ClearButton)
        Me.IngredientPanel.Controls.Add(Me.AddButton)
        Me.IngredientPanel.Controls.Add(Me.MeasurementComboBox)
        Me.IngredientPanel.Controls.Add(Me.QuantityNumericUpDown)
        Me.IngredientPanel.Controls.Add(Me.IngredientNameTextBox)
        Me.IngredientPanel.Controls.Add(Me.IngredientNameLabel)
        Me.IngredientPanel.Controls.Add(Me.MeasurementLabel)
        Me.IngredientPanel.Controls.Add(Me.QuantityLabel)
        Me.IngredientPanel.Location = New System.Drawing.Point(10, 169)
        Me.IngredientPanel.Name = "IngredientPanel"
        Me.IngredientPanel.Size = New System.Drawing.Size(609, 98)
        Me.IngredientPanel.TabIndex = 0
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(15, 68)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(75, 23)
        Me.ClearButton.TabIndex = 7
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'AddButton
        '
        Me.AddButton.Location = New System.Drawing.Point(519, 68)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(75, 23)
        Me.AddButton.TabIndex = 6
        Me.AddButton.Text = "Add"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'MeasurementComboBox
        '
        Me.MeasurementComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MeasurementComboBox.FormattingEnabled = True
        Me.MeasurementComboBox.Location = New System.Drawing.Point(200, 42)
        Me.MeasurementComboBox.MaxDropDownItems = 4
        Me.MeasurementComboBox.Name = "MeasurementComboBox"
        Me.MeasurementComboBox.Size = New System.Drawing.Size(121, 21)
        Me.MeasurementComboBox.TabIndex = 5
        '
        'QuantityNumericUpDown
        '
        Me.QuantityNumericUpDown.DecimalPlaces = 2
        Me.QuantityNumericUpDown.Increment = New Decimal(New Integer() {25, 0, 0, 131072})
        Me.QuantityNumericUpDown.Location = New System.Drawing.Point(15, 42)
        Me.QuantityNumericUpDown.Name = "QuantityNumericUpDown"
        Me.QuantityNumericUpDown.Size = New System.Drawing.Size(120, 20)
        Me.QuantityNumericUpDown.TabIndex = 4
        '
        'IngredientNameTextBox
        '
        Me.IngredientNameTextBox.Location = New System.Drawing.Point(397, 42)
        Me.IngredientNameTextBox.Name = "IngredientNameTextBox"
        Me.IngredientNameTextBox.Size = New System.Drawing.Size(197, 20)
        Me.IngredientNameTextBox.TabIndex = 3
        '
        'IngredientNameLabel
        '
        Me.IngredientNameLabel.AutoSize = True
        Me.IngredientNameLabel.Location = New System.Drawing.Point(469, 15)
        Me.IngredientNameLabel.Name = "IngredientNameLabel"
        Me.IngredientNameLabel.Size = New System.Drawing.Size(57, 13)
        Me.IngredientNameLabel.TabIndex = 2
        Me.IngredientNameLabel.Text = "Ingredient:"
        '
        'MeasurementLabel
        '
        Me.MeasurementLabel.AutoSize = True
        Me.MeasurementLabel.Location = New System.Drawing.Point(224, 15)
        Me.MeasurementLabel.Name = "MeasurementLabel"
        Me.MeasurementLabel.Size = New System.Drawing.Size(74, 13)
        Me.MeasurementLabel.TabIndex = 1
        Me.MeasurementLabel.Text = "Measurement:"
        '
        'QuantityLabel
        '
        Me.QuantityLabel.AutoSize = True
        Me.QuantityLabel.Location = New System.Drawing.Point(49, 15)
        Me.QuantityLabel.Name = "QuantityLabel"
        Me.QuantityLabel.Size = New System.Drawing.Size(49, 13)
        Me.QuantityLabel.TabIndex = 0
        Me.QuantityLabel.Text = "Quantity:"
        '
        'RecipeNameLabel
        '
        Me.RecipeNameLabel.AutoSize = True
        Me.RecipeNameLabel.Location = New System.Drawing.Point(7, 45)
        Me.RecipeNameLabel.Name = "RecipeNameLabel"
        Me.RecipeNameLabel.Size = New System.Drawing.Size(75, 13)
        Me.RecipeNameLabel.TabIndex = 1
        Me.RecipeNameLabel.Text = "Recipe Name:"
        '
        'RecipeNameTextBox
        '
        Me.RecipeNameTextBox.Location = New System.Drawing.Point(93, 42)
        Me.RecipeNameTextBox.Name = "RecipeNameTextBox"
        Me.RecipeNameTextBox.Size = New System.Drawing.Size(526, 20)
        Me.RecipeNameTextBox.TabIndex = 2
        '
        'NotesLabel
        '
        Me.NotesLabel.AutoSize = True
        Me.NotesLabel.Location = New System.Drawing.Point(44, 71)
        Me.NotesLabel.Name = "NotesLabel"
        Me.NotesLabel.Size = New System.Drawing.Size(38, 13)
        Me.NotesLabel.TabIndex = 3
        Me.NotesLabel.Text = "Notes:"
        '
        'NotesTextBox
        '
        Me.NotesTextBox.Location = New System.Drawing.Point(93, 68)
        Me.NotesTextBox.Multiline = True
        Me.NotesTextBox.Name = "NotesTextBox"
        Me.NotesTextBox.Size = New System.Drawing.Size(526, 95)
        Me.NotesTextBox.TabIndex = 4
        '
        'IngredientsListLabel
        '
        Me.IngredientsListLabel.AutoSize = True
        Me.IngredientsListLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IngredientsListLabel.Location = New System.Drawing.Point(277, 270)
        Me.IngredientsListLabel.Name = "IngredientsListLabel"
        Me.IngredientsListLabel.Size = New System.Drawing.Size(83, 15)
        Me.IngredientsListLabel.TabIndex = 5
        Me.IngredientsListLabel.Text = "Ingredients:"
        '
        'DoubleButton
        '
        Me.DoubleButton.Location = New System.Drawing.Point(10, 429)
        Me.DoubleButton.Name = "DoubleButton"
        Me.DoubleButton.Size = New System.Drawing.Size(98, 23)
        Me.DoubleButton.TabIndex = 7
        Me.DoubleButton.Text = "Double Recipe"
        Me.DoubleButton.UseVisualStyleBackColor = True
        '
        'HalfButton
        '
        Me.HalfButton.Location = New System.Drawing.Point(114, 429)
        Me.HalfButton.Name = "HalfButton"
        Me.HalfButton.Size = New System.Drawing.Size(98, 23)
        Me.HalfButton.TabIndex = 8
        Me.HalfButton.Text = "Half Recipe"
        Me.HalfButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(544, 482)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 9
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'PreviewObject
        '
        Me.PreviewObject.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PreviewObject.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PreviewObject.ClientSize = New System.Drawing.Size(400, 300)
        Me.PreviewObject.Enabled = True
        Me.PreviewObject.Icon = CType(resources.GetObject("PreviewObject.Icon"), System.Drawing.Icon)
        Me.PreviewObject.Name = "RecipePrintPreviewDialog"
        Me.PreviewObject.Visible = False
        '
        'ResetButton
        '
        Me.ResetButton.Location = New System.Drawing.Point(218, 429)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(142, 23)
        Me.ResetButton.TabIndex = 10
        Me.ResetButton.Text = "Reset Measurements"
        Me.ResetButton.UseVisualStyleBackColor = True
        '
        'PrintButton
        '
        Me.PrintButton.Location = New System.Drawing.Point(544, 429)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(75, 23)
        Me.PrintButton.TabIndex = 11
        Me.PrintButton.Text = "Print"
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'PreviewButton
        '
        Me.PreviewButton.Location = New System.Drawing.Point(463, 429)
        Me.PreviewButton.Name = "PreviewButton"
        Me.PreviewButton.Size = New System.Drawing.Size(75, 23)
        Me.PreviewButton.TabIndex = 12
        Me.PreviewButton.Text = "Preview"
        Me.PreviewButton.UseVisualStyleBackColor = True
        '
        'ClearAllButton
        '
        Me.ClearAllButton.Location = New System.Drawing.Point(12, 482)
        Me.ClearAllButton.Name = "ClearAllButton"
        Me.ClearAllButton.Size = New System.Drawing.Size(75, 23)
        Me.ClearAllButton.TabIndex = 13
        Me.ClearAllButton.Text = "Clear All"
        Me.ClearAllButton.UseVisualStyleBackColor = True
        '
        'IntroLabel
        '
        Me.IntroLabel.AutoSize = True
        Me.IntroLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IntroLabel.Location = New System.Drawing.Point(214, 9)
        Me.IntroLabel.Name = "IntroLabel"
        Me.IntroLabel.Size = New System.Drawing.Size(200, 24)
        Me.IntroLabel.TabIndex = 14
        Me.IntroLabel.Text = "Recipe Card Creator"
        '
        'QuantityListBox
        '
        Me.QuantityListBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.QuantityListBox.FormattingEnabled = True
        Me.QuantityListBox.Location = New System.Drawing.Point(10, 289)
        Me.QuantityListBox.Name = "QuantityListBox"
        Me.QuantityListBox.Size = New System.Drawing.Size(100, 130)
        Me.QuantityListBox.TabIndex = 16
        '
        'MeasureListBox
        '
        Me.MeasureListBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MeasureListBox.FormattingEnabled = True
        Me.MeasureListBox.Location = New System.Drawing.Point(106, 289)
        Me.MeasureListBox.Name = "MeasureListBox"
        Me.MeasureListBox.Size = New System.Drawing.Size(130, 130)
        Me.MeasureListBox.TabIndex = 17
        '
        'IngredientListBox
        '
        Me.IngredientListBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.IngredientListBox.FormattingEnabled = True
        Me.IngredientListBox.Location = New System.Drawing.Point(230, 289)
        Me.IngredientListBox.Name = "IngredientListBox"
        Me.IngredientListBox.Size = New System.Drawing.Size(389, 130)
        Me.IngredientListBox.TabIndex = 18
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.CloseButton)
        Me.Panel1.Controls.Add(Me.OpenButton)
        Me.Panel1.Controls.Add(Me.SaveButton)
        Me.Panel1.Location = New System.Drawing.Point(93, 472)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(445, 45)
        Me.Panel1.TabIndex = 19
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(21, 10)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(104, 23)
        Me.SaveButton.TabIndex = 0
        Me.SaveButton.Text = "Save..."
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'OpenButton
        '
        Me.OpenButton.Location = New System.Drawing.Point(176, 10)
        Me.OpenButton.Name = "OpenButton"
        Me.OpenButton.Size = New System.Drawing.Size(102, 23)
        Me.OpenButton.TabIndex = 1
        Me.OpenButton.Text = "Open File"
        Me.OpenButton.UseVisualStyleBackColor = True
        '
        'CloseButton
        '
        Me.CloseButton.Location = New System.Drawing.Point(325, 10)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(99, 23)
        Me.CloseButton.TabIndex = 2
        Me.CloseButton.Text = "Close File"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(630, 517)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.IngredientListBox)
        Me.Controls.Add(Me.MeasureListBox)
        Me.Controls.Add(Me.QuantityListBox)
        Me.Controls.Add(Me.IntroLabel)
        Me.Controls.Add(Me.ClearAllButton)
        Me.Controls.Add(Me.PreviewButton)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.ResetButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.HalfButton)
        Me.Controls.Add(Me.DoubleButton)
        Me.Controls.Add(Me.IngredientsListLabel)
        Me.Controls.Add(Me.NotesTextBox)
        Me.Controls.Add(Me.NotesLabel)
        Me.Controls.Add(Me.RecipeNameTextBox)
        Me.Controls.Add(Me.RecipeNameLabel)
        Me.Controls.Add(Me.IngredientPanel)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.IngredientPanel.ResumeLayout(False)
        Me.IngredientPanel.PerformLayout()
        CType(Me.QuantityNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IngredientPanel As System.Windows.Forms.Panel
    Friend WithEvents ClearButton As System.Windows.Forms.Button
    Friend WithEvents AddButton As System.Windows.Forms.Button
    Friend WithEvents MeasurementComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents QuantityNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents IngredientNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IngredientNameLabel As System.Windows.Forms.Label
    Friend WithEvents MeasurementLabel As System.Windows.Forms.Label
    Friend WithEvents QuantityLabel As System.Windows.Forms.Label
    Friend WithEvents RecipeNameLabel As System.Windows.Forms.Label
    Friend WithEvents RecipeNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NotesLabel As System.Windows.Forms.Label
    Friend WithEvents NotesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IngredientsListLabel As System.Windows.Forms.Label
    Friend WithEvents DoubleButton As System.Windows.Forms.Button
    Friend WithEvents HalfButton As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents PreviewObject As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents ResetButton As System.Windows.Forms.Button
    Friend WithEvents PrintButton As System.Windows.Forms.Button
    Friend WithEvents PreviewButton As System.Windows.Forms.Button
    Friend WithEvents ClearAllButton As System.Windows.Forms.Button
    Friend WithEvents IntroLabel As System.Windows.Forms.Label
    Friend WithEvents QuantityListBox As System.Windows.Forms.ListBox
    Friend WithEvents MeasureListBox As System.Windows.Forms.ListBox
    Friend WithEvents IngredientListBox As System.Windows.Forms.ListBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents OpenButton As System.Windows.Forms.Button
    Friend WithEvents SaveButton As System.Windows.Forms.Button
    Friend WithEvents CloseButton As System.Windows.Forms.Button

End Class
