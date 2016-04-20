Imports System.Drawing.Printing

Imports System.IO

Public Class Form1

    Dim Output As StreamWriter

    ' determine validity of file type
    Private Function CheckValidity(name As String) As Boolean
        If name.EndsWith(".txt") = False Then
            MessageBox.Show("Filename must end with .txt", "Invalid File Type", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False ' to indicate invalid file type
            ' change status of buttons if filename is valid
        Else
            OpenButton.Enabled = False
            SaveButton.Enabled = True
            CloseButton.Enabled = True
            Return True ' to indicate text file specified
        End If
    End Function

    Private Sub OpenButton_Click(sender As System.Object, e As System.EventArgs) Handles OpenButton.Click
        ' display open dialog
        Dim OFD As OpenFileDialog = New OpenFileDialog()
        Dim Result As DialogResult = OFD.ShowDialog

        ' open specified file if user did not click cnacel button
        If Result <> Windows.Forms.DialogResult.Cancel Then
            ' get specified filename
            Dim FileName As String = OFD.FileName
            ' validate filename
            If CheckValidity(FileName) = True Then
                ' enable user to append data to file via StreamWriter
                Output = New StreamWriter(FileName, True)
            End If
        End If
    End Sub

    Private Sub ClearUserInput()
        ' clear all fields
        QuantityNumericUpDown.Value = "0.00"
        IngredientNameTextBox.Text = ""
        RecipeNameTextBox.Text = ""
        NotesTextBox.Text = ""
        MeasurementComboBox.SelectedItem = ""
        IngredientListBox.Items.Clear()
        QuantityListBox.Items.Clear()
        MeasureListBox.Items.Clear()
    End Sub

    Private Sub SaveButton_Click(sender As System.Object, e As System.EventArgs) Handles SaveButton.Click
        ' use StreamWriter to write data to a file
        Output.Write(QuantityListBox.Text & ControlChars.Tab)
        Output.Write(MeasureListBox.Text & ControlChars.Tab)
        Output.Write(IngredientListBox.Text)
        ClearUserInput() ' prepare GUI for more user input
    End Sub

    Private Sub CloseButton_Click(sender As System.Object, e As System.EventArgs) Handles CloseButton.Click
        ' close StreamWriter
        Output.Close()

        ' allow user to open another file
        OpenButton.Enabled = True
        SaveButton.Enabled = False
        CloseButton.Enabled = False
    End Sub

    ' PrintPage event raised for each page to be printed
    Private Sub Document_PrintPage(Sender As System.Object, e As PrintPageEventArgs)
        Dim FontObject As Font ' variable to store font

        ' store a control's x- and y-coordinates
        Dim YPosition As Single
        Dim XPosition As Single

        ' represent left margin of page
        Dim LeftMargin As Single = e.MarginBounds.Left

        ' represent top margin of page
        Dim TopMargin As Single = e.MarginBounds.Top

        ' store a control's text
        Dim ControlText As String = Nothing

        ' iterate over the controls on the form, printing the text displayed in each control
        For Each ControlObject As Control In Me.Controls
            ' do not print Buttons
            If Not (TypeOf ControlObject Is Button) Then
                ControlText = ControlObject.Text
                FontObject = New Font("Segoe UI", 9.0F, FontStyle.Regular)

                ' set string positions relative to page margins
                XPosition = LeftMargin + ControlObject.Location.X
                YPosition = TopMargin + ControlObject.Location.Y

                ' draw text in graphics object
                e.Graphics.DrawString(ControlText, FontObject, Brushes.Black, XPosition, YPosition)
            End If
        Next ControlObject

        ' draw line under the recipe's name
        e.Graphics.DrawLine(Pens.Black,
            RecipeNameTextBox.Location.X + LeftMargin,
            RecipeNameTextBox.Location.Y + TopMargin + 15,
            RecipeNameTextBox.Location.X + RecipeNameTextBox.Width + LeftMargin,
            RecipeNameTextBox.Location.Y + TopMargin + 15)

        ' draw box around recipe card
        e.Graphics.DrawRectangle(Pens.Black, LeftMargin, TopMargin, Me.Width, Me.Height - 60)
    End Sub

    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        End
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' declare variable and assign value
        Dim Ml As Double = 1 ' milliliter

        ' create an array for combobox

        Dim Measurements As String() = New String() {"Pinch", "Teaspoon", "Tablespoon", "Cup", "Ounce", "Pint", "Quart", "Millileter", "Grams", "Pounds", ""}

        Array.Sort(Measurements) ' sort the measurements alphabetically

        ' display array in combobox
        MeasurementComboBox.DataSource = Measurements

        ' create the milliliter equivalent of each measurement for a common measurement for conversions
        Measurements(0) = (1 * Ml) ' Pinch = 1ml
        Measurements(1) = (5 * Ml) ' Teaspoon = 5ml
        Measurements(2) = (15 * Ml) ' Tablespoon = 15ml
        Measurements(3) = (240 * Ml) ' Cup = 240ml
        Measurements(4) = (30 * Ml) ' Ounce = 30ml
        Measurements(5) = (470 * Ml) ' Pint = 470ml
        Measurements(6) = (950 * Ml) ' Quart = 950ml
        Measurements(7) = (1 * Ml) ' Milliliter = 1ml
        Measurements(8) = (1 * Ml) ' Grams = 1ml
        Measurements(9) = (480 * Ml) ' Pounds = 480ml
        Measurements(10) = (0 * Ml) ' Null
    End Sub

    Private Sub AddButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddButton.Click
        ' declare variables and assign value
        Dim Quantity As Double = QuantityNumericUpDown.Value ' quantity of measurement
        Dim Measure As String = MeasurementComboBox.SelectedItem ' type of measurement
        Dim Ingredient As String = IngredientNameTextBox.Text ' name of ingredient
        Dim Recipe As String = RecipeNameTextBox.Text ' name of recipe
        Dim Notes As String = NotesTextBox.Text ' recipe notes

        ' output to listboxes
        QuantityListBox.Items.Add(Quantity)
        MeasureListBox.Items.Add(Measure)
        IngredientListBox.Items.Add(Ingredient)

        ' generate an error message if a UI field is missing information
        If (QuantityNumericUpDown.Value = 0.0) OrElse (MeasurementComboBox.SelectedItem = "") OrElse (IngredientNameTextBox.Text = "") Then
            MessageBox.Show("Please enter in the requested information to add the ingredient to the recipe card.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            IngredientListBox.Items.Clear()
            QuantityListBox.Items.Clear()
            MeasureListBox.Items.Clear()
        End If

        ' once an ingredient is added to the listboxes, clear the ingredient input panel
        QuantityNumericUpDown.Value = "0.00"
        IngredientNameTextBox.Text = ""
        MeasurementComboBox.SelectedItem = ""
    End Sub

    Private Sub ClearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearButton.Click
        ' clear ingredient input fields
        QuantityNumericUpDown.Value = "0.00"
        IngredientNameTextBox.Text = ""
        MeasurementComboBox.SelectedItem = ""
    End Sub

    Private Sub ClearAllButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearAllButton.Click
        ' clear all fields
        ClearUserInput()
    End Sub

    Private Sub DoubleButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DoubleButton.Click
        ' initialization phase
        Dim Total As Double = 0
        Dim XQuantity As Double = 0
        Dim QuantityCounter As Integer = 0

        Do
            XQuantity = QuantityListBox.Items(QuantityCounter) ' read quantity from quantity listbox
            XQuantity *= 2 ' double the quantity
            QuantityListBox.Items.RemoveAt(QuantityCounter) ' remove previous values
            QuantityListBox.Items.Insert(QuantityCounter, XQuantity) ' insert the new values
            QuantityCounter += 1 ' incriment counter
        Loop While QuantityCounter < QuantityListBox.Items.Count
    End Sub

    Private Sub HalfButton_Click(sender As System.Object, e As System.EventArgs) Handles HalfButton.Click
        ' initialization phase
        Dim Total As Double = 0
        Dim XQuantity As Double = 0
        Dim QuantityCounter As Integer = 0

        Do
            XQuantity = QuantityListBox.Items(QuantityCounter) ' read quantity from quantity listbox
            XQuantity *= 0.5 ' half the quantity
            QuantityListBox.Items.RemoveAt(QuantityCounter) ' remove previous values
            QuantityListBox.Items.Insert(QuantityCounter, XQuantity) ' insert the new values
            QuantityCounter += 1 ' incriment counter
        Loop While QuantityCounter < QuantityListBox.Items.Count
    End Sub

    Private Sub PrintButton_Click(sender As System.Object, e As System.EventArgs) Handles PrintButton.Click
        ' clear out intro label
        IntroLabel.Text = ""

        ' create new object to assist in printing
        Dim Document As New PrintDocument()

        ' tell PrintDocument where to find PrintPage event handler
        AddHandler Document.PrintPage,
            AddressOf Document_PrintPage

        ' if no printers are installed, display error message
        If PrinterSettings.InstalledPrinters.Count = 0 Then
            ErrorMessage()
            Return ' exit event handler
        End If

        ' print the document
        Document.Print()
    End Sub

    Private Sub PreviewButton_Click(sender As System.Object, e As System.EventArgs) Handles PreviewButton.Click
        ' clear out intro label
        IntroLabel.Text = ""

        ' create new object to assist in previewing
        Dim Document As New PrintDocument()

        ' tell PrintDocument where to find PrintPage event handler
        AddHandler Document.PrintPage,
            AddressOf Document_PrintPage

        ' if no printers are installed, display error message
        If PrinterSettings.InstalledPrinters.Count = 0 Then
            ErrorMessage()
            Return ' exit event handler
        End If

        PreviewObject.Document = Document ' specify document
        PreviewObject.ShowDialog() ' show print preview
    End Sub

    Sub ErrorMessage()
        MessageBox.Show("No printers are installed. Please make install a printer to preview or print the document.", "Print Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

End Class