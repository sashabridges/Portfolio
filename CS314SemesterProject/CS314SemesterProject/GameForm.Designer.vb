<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GameForm
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FILEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EXITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VIEWToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewMostPopularToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewAverageGamePriceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewMyPreorderCountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewPreorderFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABOUTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblNumber = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboGame = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.radBtnConfirm = New System.Windows.Forms.RadioButton()
        Me.radBtnDeny = New System.Windows.Forms.RadioButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cboSearch = New System.Windows.Forms.ComboBox()
        Me.txtSearchValue = New System.Windows.Forms.TextBox()
        Me.cboConsole = New System.Windows.Forms.ComboBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.dgvMinimal = New System.Windows.Forms.DataGridView()
        Me.GameID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GamePublisherDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GameGenre2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GameTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CS314_SemesterProjectDataSet = New CS314SemesterProject.CS314_SemesterProjectDataSet()
        Me.dgvAll = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.radNewCustomer = New System.Windows.Forms.RadioButton()
        Me.radReturningCustomer = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgvHidden = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PreorderTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CS314SemesterProjectDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Game_TTableAdapter = New CS314SemesterProject.CS314_SemesterProjectDataSetTableAdapters.Game_TTableAdapter()
        Me.Customer_TTableAdapter = New CS314SemesterProject.CS314_SemesterProjectDataSetTableAdapters.Customer_TTableAdapter()
        Me.Preorder_TTableAdapter = New CS314SemesterProject.CS314_SemesterProjectDataSetTableAdapters.Preorder_TTableAdapter()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgvMinimal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GameTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CS314_SemesterProjectDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvAll, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvHidden, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PreorderTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CS314SemesterProjectDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FILEToolStripMenuItem, Me.VIEWToolStripMenuItem, Me.ABOUTToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(836, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FILEToolStripMenuItem
        '
        Me.FILEToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EXITToolStripMenuItem, Me.ClearToolStripMenuItem})
        Me.FILEToolStripMenuItem.Name = "FILEToolStripMenuItem"
        Me.FILEToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
        Me.FILEToolStripMenuItem.Text = "File"
        '
        'EXITToolStripMenuItem
        '
        Me.EXITToolStripMenuItem.Name = "EXITToolStripMenuItem"
        Me.EXITToolStripMenuItem.Size = New System.Drawing.Size(112, 24)
        Me.EXITToolStripMenuItem.Text = "Exit"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(112, 24)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'VIEWToolStripMenuItem
        '
        Me.VIEWToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewAllToolStripMenuItem, Me.ViewMostPopularToolStripMenuItem, Me.ViewAverageGamePriceToolStripMenuItem, Me.ViewMyPreorderCountToolStripMenuItem, Me.ViewPreorderFormToolStripMenuItem})
        Me.VIEWToolStripMenuItem.Name = "VIEWToolStripMenuItem"
        Me.VIEWToolStripMenuItem.Size = New System.Drawing.Size(53, 24)
        Me.VIEWToolStripMenuItem.Text = "View"
        '
        'ViewAllToolStripMenuItem
        '
        Me.ViewAllToolStripMenuItem.Name = "ViewAllToolStripMenuItem"
        Me.ViewAllToolStripMenuItem.Size = New System.Drawing.Size(248, 24)
        Me.ViewAllToolStripMenuItem.Text = "View All"
        '
        'ViewMostPopularToolStripMenuItem
        '
        Me.ViewMostPopularToolStripMenuItem.Name = "ViewMostPopularToolStripMenuItem"
        Me.ViewMostPopularToolStripMenuItem.Size = New System.Drawing.Size(248, 24)
        Me.ViewMostPopularToolStripMenuItem.Text = "View Most Popular"
        '
        'ViewAverageGamePriceToolStripMenuItem
        '
        Me.ViewAverageGamePriceToolStripMenuItem.Name = "ViewAverageGamePriceToolStripMenuItem"
        Me.ViewAverageGamePriceToolStripMenuItem.Size = New System.Drawing.Size(248, 24)
        Me.ViewAverageGamePriceToolStripMenuItem.Text = "View Average Game Price"
        '
        'ViewMyPreorderCountToolStripMenuItem
        '
        Me.ViewMyPreorderCountToolStripMenuItem.Name = "ViewMyPreorderCountToolStripMenuItem"
        Me.ViewMyPreorderCountToolStripMenuItem.Size = New System.Drawing.Size(248, 24)
        Me.ViewMyPreorderCountToolStripMenuItem.Text = "View Games Above $40"
        '
        'ViewPreorderFormToolStripMenuItem
        '
        Me.ViewPreorderFormToolStripMenuItem.Name = "ViewPreorderFormToolStripMenuItem"
        Me.ViewPreorderFormToolStripMenuItem.Size = New System.Drawing.Size(248, 24)
        Me.ViewPreorderFormToolStripMenuItem.Text = "View Preorder Form"
        '
        'ABOUTToolStripMenuItem
        '
        Me.ABOUTToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem1, Me.HelpToolStripMenuItem})
        Me.ABOUTToolStripMenuItem.Name = "ABOUTToolStripMenuItem"
        Me.ABOUTToolStripMenuItem.Size = New System.Drawing.Size(53, 24)
        Me.ABOUTToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem1
        '
        Me.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1"
        Me.AboutToolStripMenuItem1.Size = New System.Drawing.Size(119, 24)
        Me.AboutToolStripMenuItem1.Text = "About"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(119, 24)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(654, 41)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Which game would you like to pre-order today?"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(29, 410)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 41)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Pre-Order"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(88, 644)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(64, 28)
        Me.lblName.TabIndex = 8
        Me.lblName.Text = "Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(88, 591)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 28)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "CustomerID"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(88, 701)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(59, 28)
        Me.lblEmail.TabIndex = 10
        Me.lblEmail.Text = "Email"
        '
        'lblNumber
        '
        Me.lblNumber.AutoSize = True
        Me.lblNumber.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumber.Location = New System.Drawing.Point(437, 650)
        Me.lblNumber.Name = "lblNumber"
        Me.lblNumber.Size = New System.Drawing.Size(144, 28)
        Me.lblNumber.TabIndex = 11
        Me.lblNumber.Text = "Phone Number"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 28)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Pay in full?"
        '
        'cboGame
        '
        Me.cboGame.FormattingEnabled = True
        Me.cboGame.Location = New System.Drawing.Point(225, 530)
        Me.cboGame.Name = "cboGame"
        Me.cboGame.Size = New System.Drawing.Size(121, 24)
        Me.cboGame.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(88, 530)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 28)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Game ID:"
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(674, 171)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(150, 52)
        Me.btnAdd.TabIndex = 15
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(674, 242)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(150, 52)
        Me.btnDelete.TabIndex = 16
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(225, 638)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(144, 34)
        Me.txtName.TabIndex = 17
        '
        'txtID
        '
        Me.txtID.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(225, 585)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(144, 34)
        Me.txtID.TabIndex = 18
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(225, 698)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(144, 34)
        Me.txtEmail.TabIndex = 19
        '
        'txtNumber
        '
        Me.txtNumber.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumber.Location = New System.Drawing.Point(587, 644)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(100, 34)
        Me.txtNumber.TabIndex = 20
        '
        'txtAmount
        '
        Me.txtAmount.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmount.Location = New System.Drawing.Point(139, 21)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(100, 34)
        Me.txtAmount.TabIndex = 21
        '
        'radBtnConfirm
        '
        Me.radBtnConfirm.AutoSize = True
        Me.radBtnConfirm.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radBtnConfirm.Location = New System.Drawing.Point(11, 49)
        Me.radBtnConfirm.Name = "radBtnConfirm"
        Me.radBtnConfirm.Size = New System.Drawing.Size(62, 32)
        Me.radBtnConfirm.TabIndex = 22
        Me.radBtnConfirm.TabStop = True
        Me.radBtnConfirm.Text = "Yes"
        Me.radBtnConfirm.UseVisualStyleBackColor = True
        '
        'radBtnDeny
        '
        Me.radBtnDeny.AutoSize = True
        Me.radBtnDeny.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radBtnDeny.Location = New System.Drawing.Point(11, 87)
        Me.radBtnDeny.Name = "radBtnDeny"
        Me.radBtnDeny.Size = New System.Drawing.Size(60, 32)
        Me.radBtnDeny.TabIndex = 23
        Me.radBtnDeny.TabStop = True
        Me.radBtnDeny.Text = "No"
        Me.radBtnDeny.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 124)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(153, 41)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Search By:"
        '
        'cboSearch
        '
        Me.cboSearch.FormattingEnabled = True
        Me.cboSearch.Location = New System.Drawing.Point(225, 141)
        Me.cboSearch.Name = "cboSearch"
        Me.cboSearch.Size = New System.Drawing.Size(121, 24)
        Me.cboSearch.TabIndex = 25
        '
        'txtSearchValue
        '
        Me.txtSearchValue.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchValue.Location = New System.Drawing.Point(374, 131)
        Me.txtSearchValue.Name = "txtSearchValue"
        Me.txtSearchValue.Size = New System.Drawing.Size(100, 34)
        Me.txtSearchValue.TabIndex = 26
        '
        'cboConsole
        '
        Me.cboConsole.FormattingEnabled = True
        Me.cboConsole.Location = New System.Drawing.Point(374, 141)
        Me.cboConsole.Name = "cboConsole"
        Me.cboConsole.Size = New System.Drawing.Size(121, 24)
        Me.cboConsole.TabIndex = 27
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(674, 325)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(150, 52)
        Me.btnSearch.TabIndex = 28
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'dgvMinimal
        '
        Me.dgvMinimal.AllowUserToOrderColumns = True
        Me.dgvMinimal.AutoGenerateColumns = False
        Me.dgvMinimal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMinimal.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.GameID, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.GamePublisherDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn4, Me.GameGenre2DataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.dgvMinimal.DataSource = Me.GameTBindingSource
        Me.dgvMinimal.Location = New System.Drawing.Point(12, 171)
        Me.dgvMinimal.Name = "dgvMinimal"
        Me.dgvMinimal.RowTemplate.Height = 24
        Me.dgvMinimal.Size = New System.Drawing.Size(647, 206)
        Me.dgvMinimal.TabIndex = 29
        '
        'GameID
        '
        Me.GameID.DataPropertyName = "GameID"
        Me.GameID.HeaderText = "ID"
        Me.GameID.Name = "GameID"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "GameID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "GameID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "GameTitle"
        Me.DataGridViewTextBoxColumn2.HeaderText = "GameTitle"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "GamePrice"
        Me.DataGridViewTextBoxColumn3.HeaderText = "GamePrice"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'GamePublisherDataGridViewTextBoxColumn
        '
        Me.GamePublisherDataGridViewTextBoxColumn.DataPropertyName = "GamePublisher"
        Me.GamePublisherDataGridViewTextBoxColumn.HeaderText = "GamePublisher"
        Me.GamePublisherDataGridViewTextBoxColumn.Name = "GamePublisherDataGridViewTextBoxColumn"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "GameGenre1"
        Me.DataGridViewTextBoxColumn4.HeaderText = "GameGenre1"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'GameGenre2DataGridViewTextBoxColumn
        '
        Me.GameGenre2DataGridViewTextBoxColumn.DataPropertyName = "GameGenre2"
        Me.GameGenre2DataGridViewTextBoxColumn.HeaderText = "GameGenre2"
        Me.GameGenre2DataGridViewTextBoxColumn.Name = "GameGenre2DataGridViewTextBoxColumn"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Published"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Published"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Console"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Console"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'GameTBindingSource
        '
        Me.GameTBindingSource.DataMember = "Game_T"
        Me.GameTBindingSource.DataSource = Me.CS314_SemesterProjectDataSet
        '
        'CS314_SemesterProjectDataSet
        '
        Me.CS314_SemesterProjectDataSet.DataSetName = "CS314_SemesterProjectDataSet"
        Me.CS314_SemesterProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dgvAll
        '
        Me.dgvAll.AutoGenerateColumns = False
        Me.dgvAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAll.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.dgvAll.DataSource = Me.CustomerTBindingSource
        Me.dgvAll.Location = New System.Drawing.Point(115, 760)
        Me.dgvAll.Name = "dgvAll"
        Me.dgvAll.RowTemplate.Height = 24
        Me.dgvAll.Size = New System.Drawing.Size(503, 165)
        Me.dgvAll.TabIndex = 30
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "CustomerID"
        Me.DataGridViewTextBoxColumn7.HeaderText = "CustomerID"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "CustomerName"
        Me.DataGridViewTextBoxColumn8.HeaderText = "CustomerName"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "CustomerEmail"
        Me.DataGridViewTextBoxColumn9.HeaderText = "CustomerEmail"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "CustomerPhone"
        Me.DataGridViewTextBoxColumn10.HeaderText = "CustomerPhone"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'CustomerTBindingSource
        '
        Me.CustomerTBindingSource.DataMember = "Customer_T"
        Me.CustomerTBindingSource.DataSource = Me.CS314_SemesterProjectDataSet
        '
        'radNewCustomer
        '
        Me.radNewCustomer.AutoSize = True
        Me.radNewCustomer.Location = New System.Drawing.Point(6, 25)
        Me.radNewCustomer.Name = "radNewCustomer"
        Me.radNewCustomer.Size = New System.Drawing.Size(120, 21)
        Me.radNewCustomer.TabIndex = 31
        Me.radNewCustomer.TabStop = True
        Me.radNewCustomer.Text = "New Customer"
        Me.radNewCustomer.UseVisualStyleBackColor = True
        '
        'radReturningCustomer
        '
        Me.radReturningCustomer.AutoSize = True
        Me.radReturningCustomer.Location = New System.Drawing.Point(154, 25)
        Me.radReturningCustomer.Name = "radReturningCustomer"
        Me.radReturningCustomer.Size = New System.Drawing.Size(155, 21)
        Me.radReturningCustomer.TabIndex = 32
        Me.radReturningCustomer.TabStop = True
        Me.radReturningCustomer.Text = "Returning Customer"
        Me.radReturningCustomer.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.radBtnConfirm)
        Me.GroupBox1.Controls.Add(Me.radBtnDeny)
        Me.GroupBox1.Controls.Add(Me.txtAmount)
        Me.GroupBox1.Location = New System.Drawing.Point(442, 454)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(245, 147)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.radNewCustomer)
        Me.GroupBox2.Controls.Add(Me.radReturningCustomer)
        Me.GroupBox2.Location = New System.Drawing.Point(36, 454)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(364, 52)
        Me.GroupBox2.TabIndex = 34
        Me.GroupBox2.TabStop = False
        '
        'dgvHidden
        '
        Me.dgvHidden.AutoGenerateColumns = False
        Me.dgvHidden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHidden.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14})
        Me.dgvHidden.DataSource = Me.PreorderTBindingSource
        Me.dgvHidden.Location = New System.Drawing.Point(115, 862)
        Me.dgvHidden.Name = "dgvHidden"
        Me.dgvHidden.RowTemplate.Height = 24
        Me.dgvHidden.Size = New System.Drawing.Size(503, 115)
        Me.dgvHidden.TabIndex = 35
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "PreorderID"
        Me.DataGridViewTextBoxColumn11.HeaderText = "PreorderID"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "TotalPaid"
        Me.DataGridViewTextBoxColumn12.HeaderText = "TotalPaid"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "GameID"
        Me.DataGridViewTextBoxColumn13.HeaderText = "GameID"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "CustomerID"
        Me.DataGridViewTextBoxColumn14.HeaderText = "CustomerID"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'PreorderTBindingSource
        '
        Me.PreorderTBindingSource.DataMember = "Preorder_T"
        Me.PreorderTBindingSource.DataSource = Me.CS314_SemesterProjectDataSet
        '
        'Game_TTableAdapter
        '
        Me.Game_TTableAdapter.ClearBeforeFill = True
        '
        'Customer_TTableAdapter
        '
        Me.Customer_TTableAdapter.ClearBeforeFill = True
        '
        'Preorder_TTableAdapter
        '
        Me.Preorder_TTableAdapter.ClearBeforeFill = True
        '
        'GameForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(836, 1004)
        Me.Controls.Add(Me.dgvHidden)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvAll)
        Me.Controls.Add(Me.dgvMinimal)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.cboConsole)
        Me.Controls.Add(Me.txtSearchValue)
        Me.Controls.Add(Me.cboSearch)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtNumber)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cboGame)
        Me.Controls.Add(Me.lblNumber)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "GameForm"
        Me.Text = "GameViewer2000 - Sasha Bridges"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgvMinimal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GameTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CS314_SemesterProjectDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvAll, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvHidden, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PreorderTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CS314SemesterProjectDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FILEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EXITToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VIEWToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ABOUTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents lblNumber As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cboGame As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents radBtnConfirm As System.Windows.Forms.RadioButton
    Friend WithEvents radBtnDeny As System.Windows.Forms.RadioButton
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cboSearch As System.Windows.Forms.ComboBox
    Friend WithEvents txtSearchValue As System.Windows.Forms.TextBox
    Friend WithEvents ViewAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewMostPopularToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewAverageGamePriceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cboConsole As System.Windows.Forms.ComboBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents ViewPreorderFormToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dgvMinimal As System.Windows.Forms.DataGridView
    Friend WithEvents dgvAll As System.Windows.Forms.DataGridView
    Friend WithEvents radNewCustomer As System.Windows.Forms.RadioButton
    Friend WithEvents radReturningCustomer As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvHidden As System.Windows.Forms.DataGridView
    Friend WithEvents ViewMyPreorderCountToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GameTitleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GamePriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GameGenre1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PublishedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ConsoleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustomerIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustomerNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustomerEmailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustomerPhoneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PreorderIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalPaidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GameIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustomerIDDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CS314_SemesterProjectDataSet As CS314SemesterProject.CS314_SemesterProjectDataSet
    Friend WithEvents CS314SemesterProjectDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GameTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Game_TTableAdapter As CS314SemesterProject.CS314_SemesterProjectDataSetTableAdapters.Game_TTableAdapter
    Friend WithEvents CustomerTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Customer_TTableAdapter As CS314SemesterProject.CS314_SemesterProjectDataSetTableAdapters.Customer_TTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PreorderTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Preorder_TTableAdapter As CS314SemesterProject.CS314_SemesterProjectDataSetTableAdapters.Preorder_TTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GameID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GamePublisherDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GameGenre2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
