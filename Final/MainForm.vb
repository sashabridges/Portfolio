' Fall 2016 CS314 Final Exam
' Project: Mini Bookstore
' This project allows search by book title, search by subject string, and add a new book

Public Class MainForm

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BookStoreDataSet.Subjects' table. You can move, or remove it, as needed.
        Me.SubjectsTableAdapter.Fill(Me.BookStoreDataSet.Subjects)
        'TODO: This line of code loads data into the 'BookStoreDataSet.Books' table. You can move, or remove it, as needed.
        Me.BooksTableAdapter.Fill(Me.BookStoreDataSet.Books)

        ' initialize search option combo box
        cboOptions.Items.Add("By Book Title")
        cboOptions.Items.Add("By Subject String")
        cboOptions.SelectedIndex = 0  ' default on search by book title

    End Sub

    Private Sub txtSearch_Enter(sender As Object, e As EventArgs) Handles txtSearch.Enter, txtSearch.Click
        ' select contents when the textbox receives focus via tab or mouse click
        txtSearch.SelectAll()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' clear the add book area

        ' clear fields
        txtISBN.Text = String.Empty
        txtTitle.Text = String.Empty
        txtAuthor.Text = String.Empty
        txtPublisher.Text = String.Empty
        txtSubjectCode.Text = String.Empty

        ' refocus
        txtISBN.Focus()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        ' handles searching for book by title or subject string

        ' case 0 - by book title
        ' case 1 - by subject string
        Select Case cboOptions.SelectedIndex
            Case 0
                Dim strSearch As String = txtSearch.Text.Trim.ToUpper

                ' check if empty string
                ' if empty, tell user its empty, reload datagridview to be reset
                ' if not empty, resume search
                If (strSearch = String.Empty) Then
                    Dim results = From empty In BookStoreDataSet.Books
                                  Select empty

                    BooksDataGridView.DataSource = results.AsDataView
                    MessageBox.Show("Empty search!!", "No Value Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                Else
                    Dim records = From title In BookStoreDataSet.Books
            Where title.Title.ToUpper Like strSearch & "*"
            Select title
                    BooksDataGridView.DataSource = records.AsDataView
                End If
            Case 1
                Dim strSearch As String = txtSearch.Text.Trim.ToUpper

                ' check if empty string
                ' if empty, tell user its empty, reload datagridview to be reset
                ' if not empty, resume search
                If (strSearch = String.Empty) Then
                    Dim results = From empty In BookStoreDataSet.Books
              Select empty

                    BooksDataGridView.DataSource = results.AsDataView
                    MessageBox.Show("Empty search!!", "No Value Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else

                    Dim records = From bookID In BookStoreDataSet.Books Join book In BookStoreDataSet.Subjects
On bookID.SubjectCode Equals book.SubjectCode
Where book.Subject.Trim.ToUpper Like strSearch & "*"
Select bookID.ISBN, bookID.Title, bookID.Author, bookID.Publisher, bookID.SubjectCode

                    BooksDataGridView.DataSource = records.ToList
                End If
        End Select
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' add a book to the database

        ' check if ISBN, title, or SubjectCode is empty



        If (txtISBN.Text = String.Empty) Then
            MessageBox.Show("No ISBN entered.", "Warning: No ISBN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf (txtTitle.Text = String.Empty) Then
            MessageBox.Show("No Title entered.", "Warning: No Title", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf (txtSubjectCode.Text = String.Empty) Then
            MessageBox.Show("No Subject Code entered.", "Warning: No Subject Code", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            ' continue on with adding the book
            Dim dlgBtn As DialogResult
            ' confirm add with user and only proceed if user says yes
            dlgBtn = MessageBox.Show("The title for this book is: " + txtTitle.Text + ", the ISBN for this book is: " + txtISBN.Text + ", and the subject code for this book is: " + txtSubjectCode.Text + ". Do you want to continue?", "Confirm Addition", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If (dlgBtn = Windows.Forms.DialogResult.Yes) Then
                ' check if ISBN already exists
                Try
                    Dim subjectCodeRow As FinalExam2015.BookStoreDataSet.SubjectsRow = BookStoreDataSet.Subjects.FindBySubjectCode(txtSubjectCode.Text)
                    ' check if invalid subject code
                    Try
                        BookStoreDataSet.Books.AddBooksRow(txtISBN.Text, txtTitle.Text, txtAuthor.Text, txtPublisher.Text, subjectCodeRow)
                        Try
                            BooksTableAdapter.Update(BookStoreDataSet.Books)
                        Catch ex As Exception
                            MessageBox.Show("Error adding book to table!!", "Addition Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End Try
                    Catch ex As Exception
                        MessageBox.Show("Invalid Subject Code", "Add Record", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                Catch ex As Exception
                    MessageBox.Show("Duplicate record", "Add Record", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
                Me.BooksTableAdapter.Fill(Me.BookStoreDataSet.Books)

                ' end dialogButton if
            End If
        End If
    End Sub

End Class
