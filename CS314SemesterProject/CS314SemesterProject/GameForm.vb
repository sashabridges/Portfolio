' Name:         CS314 Semester Project - GameForm
' Purpose:      Selects specific records
'               Displays records and allows uuser to update their preorders
' Programmer:   <Sasha Bridges> on <11/20/16>


Option Explicit On
Option Strict On
Option Infer On
Public Class GameForm
    Private Sub GameForm_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        ' close preorder form when gameform closes
        PreorderForm.Close()
    End Sub

    Private Sub GameForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' initializes the form and loads the dataviews/cbos
        'TODO: This line of code loads data into the 'CS314_SemesterProjectDataSet.Customer_T' table. You can move, or remove it, as needed.
        Me.Customer_TTableAdapter.Fill(Me.CS314_SemesterProjectDataSet.Customer_T)
        'TODO: This line of code loads data into the 'CS314_SemesterProjectDataSet.Game_T' table. You can move, or remove it, as needed.
        Me.Preorder_TTableAdapter.Fill(Me.CS314_SemesterProjectDataSet.Preorder_T)
        Me.Game_TTableAdapter.Fill(Me.CS314_SemesterProjectDataSet.Game_T)

        ' loads the initial dataviews
        ' dgvMinimal loads up the preorders of the person with the most preorders with title, release date, price, and system

        ' populate cbos: cboSearch, cboGame, & cboConsole
        cboSearch.Items.Add("Title") ' searching for title & publisher should be CONTAINS user string
        cboSearch.Items.Add("Price")
        cboSearch.Items.Add("Publisher")
        cboSearch.Items.Add("Console") ' links to another cbo for consoles, only visible when console is selected

        ' populate by searching through the database and returning a title
        cboGame.DataSource = CS314_SemesterProjectDataSet.Game_T
        cboGame.DisplayMember = "Title"
        cboGame.ValueMember = "GameID"


        cboConsole.Items.Add("PS4")
        cboConsole.Items.Add("Xbox One")
        cboConsole.Items.Add("PC")
        cboConsole.Items.Add("Wii U")
        cboConsole.Items.Add("Nintendo Switch")
        cboConsole.Items.Add("PS3")
        cboConsole.Items.Add("Xbox 360")
        cboConsole.Items.Add("3DS")
        cboConsole.Items.Add("Playstation Vita")

        ' set confirm as default radio button, txtAmount isnt visible
        radBtnConfirm.Checked = True
        radReturningCustomer.Checked = True
        txtAmount.Visible = False
        cboConsole.Visible = False
        txtName.Visible = False
        lblName.Visible = False
        txtNumber.Visible = False
        txtEmail.Visible = False
        lblEmail.Visible = False
        lblNumber.Visible = False
        dgvHidden.Visible = False
        cboSearch.SelectedValue = 0
        cboGame.SelectedValue = 0
    End Sub

    Private Sub ViewAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewAllToolStripMenuItem.Click
        ' allow the user to view ALL of the games
        Dim records = From game In CS314_SemesterProjectDataSet.Game_T
         Select game
        dgvMinimal.DataSource = records.AsDataView
    End Sub

    Private Sub ViewMostPopularToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewMostPopularToolStripMenuItem.Click
        ' allow the user to view the most popular games, ie the games with the most preorders
        ' Select Top 5 GameTitle, GameID FROM Game_T g JOIN Preorder_T p ON g.GameID = p.GameID

        Dim queryResult = (From gameID In CS314_SemesterProjectDataSet.Game_T Join id In CS314_SemesterProjectDataSet.Preorder_T
        On gameID.GameID Equals id.GameID Select gameID.GameTitle, gameID.GamePublisher, gameID.GameID).Take(5)

        dgvMinimal.DataSource = queryResult.ToList
    End Sub

    Private Sub ViewMyPreorderCountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewMyPreorderCountToolStripMenuItem.Click
        ' show games and preorder ids with prices over $40

        Dim queryResult = From gameID In CS314_SemesterProjectDataSet.Game_T Join id In CS314_SemesterProjectDataSet.Preorder_T
        On gameID.GameID Equals id.GameID
        Where gameID.GamePrice > 39.99
        Select gameID.GameTitle, id.PreorderID, gameID.GamePublisher

        dgvMinimal.DataSource = queryResult.ToList

    End Sub

    Private Sub ViewAverageGamePriceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewAverageGamePriceToolStripMenuItem.Click
        ' allow the user to view the average price of the games
        Dim dblAvg As Double = Aggregate price In CS314_SemesterProjectDataSet.Game_T
            Select price.GamePrice Into Average()
        MessageBox.Show(dblAvg.ToString("C2"), "Average Price of Games")
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        ' handles searching the database for a specific view
        ' case 0 - title
        ' case 1 - price
        ' case 2 - publisher
        ' case 3 - console
        Dim strName As String = txtSearchValue.Text.Trim.ToUpper
        Dim dblPrice As Double
        Select Case cboSearch.SelectedIndex
            Case 0
                Dim records = From title In CS314_SemesterProjectDataSet.Game_T
                            Where title.GameTitle.ToUpper Like strName & "*"
                            Select title
                dgvMinimal.DataSource = records.AsDataView
            Case 1
                Double.TryParse(strName, dblPrice)
                Dim records = From price In CS314_SemesterProjectDataSet.Game_T
                            Where price.GamePrice = dblPrice
                Select price
                dgvMinimal.DataSource = records.AsDataView
                dgvMinimal.DataSource = records.AsDataView
            Case 2
                Dim records = From publisher In CS314_SemesterProjectDataSet.Game_T
                            Where publisher.GamePublisher.ToUpper Like strName & "*"
                            Select publisher
                dgvMinimal.DataSource = records.AsDataView
            Case 3
                strName = cboConsole.SelectedItem.ToString
                Dim records = From console In CS314_SemesterProjectDataSet.Game_T
                            Where console.Console.ToUpper Like strName
                            Select console
                dgvMinimal.DataSource = records.AsDataView

        End Select
    End Sub

    Private Sub EXITToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EXITToolStripMenuItem.Click
        ' Exit the window
        Me.Close()
    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        ' Clear the window

        txtSearchValue.Clear()
        txtName.Clear()
        txtNumber.Clear()
        txtAmount.Clear()
        txtID.Clear()
        radBtnConfirm.Checked = True
        txtAmount.Visible = False
        cboSearch.SelectedIndex = 0
        cboConsole.SelectedIndex = 0
        cboGame.SelectedIndex = 0
    End Sub

    Private Sub AboutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem1.Click
        ' About menu
        MessageBox.Show("This program was created by Sasha Bridges. This form lets you view games and add them to your preorders.", "About")
    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        ' Help menu
        MessageBox.Show("Under Construction", "Help")
    End Sub

    Private Sub ViewPreorderFormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewPreorderFormToolStripMenuItem.Click
        ' Launch the Preorder Form back up, in case it was closed
        Me.Hide()
        PreorderForm.Show()
    End Sub

    Private Sub cboSearch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSearch.SelectedIndexChanged
        ' handles if cboSearch & txtSearchValue is visible or not

        Select Case cboSearch.SelectedIndex
            Case 0
                txtSearchValue.Visible = True
                cboConsole.Visible = False
            Case 1
                txtSearchValue.Visible = True
                cboConsole.Visible = False
            Case 2
                txtSearchValue.Visible = True
                cboConsole.Visible = False
            Case 3
                cboConsole.Visible = True
                txtSearchValue.Visible = False
        End Select

    End Sub

    Private Sub txtID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtID.KeyPress
        ' only allows numeric values
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumber.KeyPress
        ' only allows numeric values and "("  ")"  "-" symbols
        If (e.KeyChar < "0" Or e.KeyChar > "9") AndAlso
    e.KeyChar <> "." AndAlso e.KeyChar <> "(" AndAlso e.KeyChar <> ")" AndAlso e.KeyChar <> "-" AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtAmount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAmount.KeyPress
        ' only allows numeric values and "."
        If (e.KeyChar < "0" Or e.KeyChar > "9") AndAlso
    e.KeyChar <> "." AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' adds a game to their preorder list
        ' verify information first
        Dim dblPaid As Decimal
        Dim intGameID As Integer
        Dim intCustID As Integer

        Integer.TryParse(cboGame.SelectedText, intGameID)

        ' if the customer wants to pay all or if they want to enter their own amount
        If (radBtnConfirm.Checked) Then
            ' find game price in database
            ' put into dblPaid
            Dim gamePrice As CS314_SemesterProjectDataSet.Game_TRow = CS314_SemesterProjectDataSet.Game_T.FindByGameID(intGameID)
            dblPaid = 60
        Else
            Decimal.TryParse(txtAmount.Text, dblPaid)
        End If


        ' if the customer is a new customer
        If (radNewCustomer.Checked) Then
            Dim custName As String = txtName.Text.Trim.ToUpper
            Dim custEmail As String = txtEmail.Text.Trim.ToUpper
            Dim custPhone As String = txtNumber.Text

            ' add new customer to table
            CS314_SemesterProjectDataSet.Customer_T.AddCustomer_TRow(custName, custEmail, custPhone)
            Try
                ' update tables
                Customer_TTableAdapter.Update(CS314_SemesterProjectDataSet.Customer_T)
                Preorder_TTableAdapter.Update(CS314_SemesterProjectDataSet.Preorder_T)
                Me.Customer_TTableAdapter.Fill(Me.CS314_SemesterProjectDataSet.Customer_T)
                Me.Preorder_TTableAdapter.Fill(Me.CS314_SemesterProjectDataSet.Preorder_T)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Add new customer to table", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try

            ' get the new customer's auto-generated id
            Dim records = From id In CS314_SemesterProjectDataSet.Customer_T
            Where id.CustomerName.Trim.ToUpper Like custName & "*"
            Select id.CustomerID

            Integer.TryParse(records.ToString, intCustID)

            Dim customerRow As CS314_SemesterProjectDataSet.Customer_TRow = CS314_SemesterProjectDataSet.Customer_T.FindByCustomerID(intCustID)
            Dim gameRow As CS314_SemesterProjectDataSet.Game_TRow = CS314_SemesterProjectDataSet.Game_T.FindByGameID(intGameID)
            CS314_SemesterProjectDataSet.Preorder_T.AddPreorder_TRow(dblPaid, Integer.Parse(gameRow.ToString()), Integer.Parse(customerRow.ToString()))
            Me.Preorder_TTableAdapter.Fill(Me.CS314_SemesterProjectDataSet.Preorder_T)

            ' Update the table
            Preorder_TTableAdapter.Update(CS314_SemesterProjectDataSet.Preorder_T)

            MessageBox.Show("Welcome, " + custName + " and thank you for your preorder!", "Welcome!", MessageBoxButtons.OK)

            ' if the customer is a returning customer
        ElseIf (radReturningCustomer.Checked) Then

            ' customer
            Integer.TryParse(txtID.Text, intCustID)
            Dim customerRow As CS314_SemesterProjectDataSet.Customer_TRow = CS314_SemesterProjectDataSet.Customer_T.FindByCustomerID(intCustID)
            ' game: in intGameID
            Dim gameRow As CS314_SemesterProjectDataSet.Game_TRow = CS314_SemesterProjectDataSet.Game_T.FindByGameID(intGameID)
            'Dim game As Integer
            'Dim customer As Integer
            'Integer.TryParse(gameRow.ToString(), game)
            'Integer.TryParse(customerRow.ToString(), customer)
            Dim countBeforeAdd As Integer = CS314_SemesterProjectDataSet.Preorder_T.Count
            ' add.
            CS314_SemesterProjectDataSet.Preorder_T.AddPreorder_TRow(dblPaid, Integer.Parse(gameRow.ToString()), Integer.Parse(customerRow.ToString()))
            Dim countAfterAdd As Integer = CS314_SemesterProjectDataSet.Preorder_T.Count

            ' try to update
            Try
                'update table
                Preorder_TTableAdapter.Update(CS314_SemesterProjectDataSet.Preorder_T)

            Catch ex As Exception
                MessageBox.Show("Can't preorder", "Preorder Not Confirmed", MessageBoxButtons.OK)
            End Try
            ' 
            Me.Preorder_TTableAdapter.Fill(Me.CS314_SemesterProjectDataSet.Preorder_T)
            MessageBox.Show("Thank you for your preorder! count from " & countBeforeAdd & " to " & countAfterAdd, "Preorder Confirmed", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        ' checks if game is in their preorder list
        ' if so, ask to confirm deletion
        ' stop if no, continue if yes
        Dim preID As Integer
        Dim dlgBtn As DialogResult
        Integer.TryParse(cboGame.SelectedText, preID)

        ' fish the name of the game from the preorder's id
        Dim queryResult = From gameID In CS314_SemesterProjectDataSet.Game_T Join id In CS314_SemesterProjectDataSet.Preorder_T
        On gameID.GameID Equals id.GameID
        Where id.GameID = preID
        Select gameID.GameTitle

        dlgBtn = MessageBox.Show("Are you sure you want to delete the preorder for " + queryResult.ToString + "?", "Confirm Deletion", MessageBoxButtons.YesNo)
        If (dlgBtn = Windows.Forms.DialogResult.Yes) Then
            Try
                CS314_SemesterProjectDataSet.Preorder_T.Rows(preID).Delete()
                Try
                    Preorder_TTableAdapter.Update(CS314_SemesterProjectDataSet.Preorder_T)
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Deletion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Deletion Failed", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
            
        End If

    End Sub

    Private Sub radBtnDeny_CheckedChanged(sender As Object, e As EventArgs) Handles radBtnDeny.CheckedChanged
        ' if user denies paying in full, allow them to enter how much they want to pay
        txtAmount.Visible = True
    End Sub

    Private Sub radBtnConfirm_CheckedChanged(sender As Object, e As EventArgs) Handles radBtnConfirm.CheckedChanged
        ' if user wants to pay in full, hide text box, input the full price of game as paid
        txtAmount.Visible = False
    End Sub

    Private Sub radNewCustomer_CheckedChanged(sender As Object, e As EventArgs) Handles radNewCustomer.CheckedChanged
        ' change if these are visible or not based on if customer is a returning customer or not
        txtEmail.Visible = True
        txtNumber.Visible = True
        lblEmail.Visible = True
        lblNumber.Visible = True
        lblName.Visible = True
        txtName.Visible = True
    End Sub

    Private Sub radReturningCustomer_CheckedChanged(sender As Object, e As EventArgs) Handles radReturningCustomer.CheckedChanged
        ' change if these are visible or not based on if customer is a returning customer or not
        txtEmail.Visible = False
        txtNumber.Visible = False
        txtName.Visible = False
        lblName.Visible = False
        lblEmail.Visible = False
        lblNumber.Visible = False
    End Sub
End Class
