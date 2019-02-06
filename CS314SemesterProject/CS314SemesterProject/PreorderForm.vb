' Name:         CS314 Semester Project - PreOrder Form
' Purpose:      Selects preorders based on user id
'               Displays records and allows user to update their preorders
' Programmer:   <Sasha Bridges> on <11/20/16>


Option Explicit On
Option Strict On
Option Infer On
Public Class PreorderForm
    Private Sub GameForm_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        ' close gameform when preorderform closes
        GameForm.Close()
    End Sub

    Private Sub PreorderForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CS314_SemesterProjectDataSet1.Game_T' table. You can move, or remove it, as needed.
        Me.Game_TTableAdapter.Fill(Me.CS314_SemesterProjectDataSet.Game_T)
        Me.Customer_TTableAdapter.Fill(Me.CS314_SemesterProjectDataSet.Customer_T)
        'TODO: This line of code loads data into the 'CS314_SemesterProjectDataSet1.Preorder_T' table. You can move, or remove it, as needed.
        Me.Preorder_TTableAdapter.Fill(Me.CS314_SemesterProjectDataSet.Preorder_T)

        ' set defaults
        radPreorder.Select()
        lblName.Visible = False
        lblPhone.Visible = False
        lblMail.Visible = False
        txtChangeName.Visible = False
        txtChangeNumber.Visible = False
        txtChangeEmail.Visible = False
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        ' close the form
        Me.Close()
    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        ' reset the form
        txtID.Clear()
        txtChangeEmail.Clear()
        txtChangeNumber.Clear()
        txtChangePaid.Clear()
        txtPreID.Clear()
    End Sub

    Private Sub ViewPreordersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewPreordersToolStripMenuItem.Click
        ' populate the form with the user's preorder info
        Dim intID As Integer
        Integer.TryParse(txtID.Text, intID)
        Preorder_TTableAdapter.FillByPreorderID(CS314_SemesterProjectDataSet.Preorder_T, intID)

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        ' About Menu
        MessageBox.Show("This program was created by Sasha Bridges. This form lets you view games and add them to your preorders.", "About")
    End Sub

    Private Sub HelpToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem1.Click
        ' Help Menu
        MessageBox.Show("Under Construction", "Help")
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        ' allows the user to add a new preorder
        Me.Hide()
        GameForm.Show()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        ' allows the user to edit a preorder
        If (radInfo.Checked) Then
            Dim custID As String = txtID.Text
            Dim custName As String = txtChangeName.Text
            Dim custEmail As String = txtChangeEmail.Text
            Dim custNumber As String = txtChangeNumber.Text
            Dim intCustNum As Integer
            Dim custNum As Integer
            Dim dlgBtn As DialogResult



            Integer.TryParse(custID, intCustNum)
            Integer.TryParse(custID, custNum)
            If (intCustNum < 0) Then
                intCustNum = 1
            End If
            intCustNum = intCustNum - 1

            dlgBtn = MessageBox.Show("Are you sure you want to change name to " + custName + ", email to " + custEmail +
                                     ", and phone number to " + custNumber + "?", "Confirm Edit", MessageBoxButtons.YesNo)
            If (dlgBtn = Windows.Forms.DialogResult.Yes) Then
                ' edit the user's info
                Dim customerRow As CS314_SemesterProjectDataSet.Customer_TRow = Me.CS314_SemesterProjectDataSet.Customer_T.FindByCustomerID(custNum)
                CS314_SemesterProjectDataSet.Customer_T(intCustNum).CustomerName = custName
                CS314_SemesterProjectDataSet.Customer_T(intCustNum).CustomerEmail = custEmail
                CS314_SemesterProjectDataSet.Customer_T(intCustNum).CustomerPhone = custNumber
                Try
                    ' update the db
                    Customer_TTableAdapter.Update(CS314_SemesterProjectDataSet.Customer_T)
                    Me.Customer_TTableAdapter.Fill(Me.CS314_SemesterProjectDataSet.Customer_T)
                    MessageBox.Show("Update successful", "Update the customer table", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show(ex.Message,
                        "Update the customer table",MessageBoxButtons.OK,MessageBoxIcon.Information)
                End Try
            End If


        ElseIf (radPreorder.Checked) Then
            Dim custID As Integer
            Dim gameID As Integer
            Dim totalPaid As Decimal
            Dim preID As Integer
            Dim dlgBtn As DialogResult

            Integer.TryParse(txtPreID.Text, preID)
            preID = preID - 1

            Dim results = From game In CS314_SemesterProjectDataSet.Preorder_T
                            Where game.PreorderID = preID
                            Select game

            Integer.TryParse(txtID.Text, custID)
            Integer.TryParse(results.ToString, gameID)
            Decimal.TryParse(txtChangePaid.Text, totalPaid)

            dlgBtn = MessageBox.Show("Are you sure you want to game to " + gameID.ToString +
                         ", and amount paid to " + totalPaid.ToString("C2") + "?", "Confirm Edit", MessageBoxButtons.YesNo)
            If (dlgBtn = Windows.Forms.DialogResult.Yes) Then
                ' edit the game & amount paid
                ' Dim customerRow As CS314_SemesterProjectDataSet.Customer_TRow = Me.CS314_SemesterProjectDataSet1.Customer_T.FindByCustomerID(Integer.Parse(txtID.Text))
                CS314_SemesterProjectDataSet.Preorder_T(preID).TotalPaid = totalPaid
                ' Preorder_TTableAdapter.InsertQuery(totalPaid, preID, custID)
                Try
                    ' update the table
                    Preorder_TTableAdapter.Update(CS314_SemesterProjectDataSet.Preorder_T)
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Update the preorder table", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
            End If

        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        ' allows the user to delete a preorder
        Dim preID As Integer
        Dim dlgBtn As DialogResult

        Dim records = From id In CS314_SemesterProjectDataSet.Preorder_T
            Where id.PreorderID = preID
        Select Name

        Integer.TryParse(txtPreID.Text, preID)
        ' ask user if they want to delete
        dlgBtn = MessageBox.Show("Are you sure you want to delete the preorder for " + records.ToString + "?", "Confirm Deletion", MessageBoxButtons.YesNo)
        If (dlgBtn = Windows.Forms.DialogResult.Yes) Then
            ' delete based on preorder
            preID = preID - 1
            CS314_SemesterProjectDataSet.Preorder_T.Rows(preID).Delete()
            Try
                ' update database
                Preorder_TTableAdapter.Update(CS314_SemesterProjectDataSet.Preorder_T)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Deletion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If
    End Sub

    Private Sub ViewGameListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewGameListToolStripMenuItem.Click
        ' change which form is visible
        Me.Hide()
        GameForm.Show()
    End Sub

    Private Sub radPreorder_CheckedChanged(sender As Object, e As EventArgs) Handles radPreorder.CheckedChanged
        lblName.Visible = False
        lblPhone.Visible = False
        lblMail.Visible = False
        lblPreorder.Visible = True
        lblPaid.Visible = True
        txtPreID.Visible = True
        txtChangePaid.Visible = True
        txtChangeName.Visible = False
        txtChangeNumber.Visible = False
        txtChangeEmail.Visible = False
    End Sub

    Private Sub radInfo_CheckedChanged(sender As Object, e As EventArgs) Handles radInfo.CheckedChanged
        lblName.Visible = True
        lblPhone.Visible = True
        lblMail.Visible = True
        lblPreorder.Visible = False
        lblPaid.Visible = False
        txtPreID.Visible = False
        txtChangeNumber.Visible = True
        txtChangeEmail.Visible = True
        txtChangeName.Visible = True
        txtChangePaid.Visible = False
    End Sub

    Private Sub txtID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtID.KeyPress
        ' only handles numeric characters
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtPreID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPreID.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtChangePaid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtChangePaid.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") AndAlso
            e.KeyChar <> "." AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtChangeNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtChangeNumber.KeyPress
        ' only allows numeric values and "("  ")"  "-" symbols
        If (e.KeyChar < "0" Or e.KeyChar > "9") AndAlso
            e.KeyChar <> "." AndAlso e.KeyChar <> "(" AndAlso e.KeyChar <> ")" AndAlso e.KeyChar <> "-" AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub ViewAllPreorderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewAllPreorderToolStripMenuItem.Click
        Dim records = From id In CS314_SemesterProjectDataSet.Preorder_T Select id
        dgvPreorder.DataSource = records.AsDataView
    End Sub
End Class