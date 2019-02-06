<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PreorderForm
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
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewPreordersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewGameListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvPreorder = New System.Windows.Forms.DataGridView()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.txtChangeName = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblMail = New System.Windows.Forms.Label()
        Me.lblPaid = New System.Windows.Forms.Label()
        Me.lblPreorder = New System.Windows.Forms.Label()
        Me.txtChangeNumber = New System.Windows.Forms.TextBox()
        Me.txtChangeEmail = New System.Windows.Forms.TextBox()
        Me.txtChangePaid = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radInfo = New System.Windows.Forms.RadioButton()
        Me.radPreorder = New System.Windows.Forms.RadioButton()
        Me.txtPreID = New System.Windows.Forms.TextBox()
        Me.CS314_SemesterProjectDataSet = New CS314SemesterProject.CS314_SemesterProjectDataSet()
        Me.Customer_TTableAdapter = New CS314SemesterProject.CS314_SemesterProjectDataSetTableAdapters.Customer_TTableAdapter()
        Me.Game_TTableAdapter = New CS314SemesterProject.CS314_SemesterProjectDataSetTableAdapters.Game_TTableAdapter()
        Me.Preorder_TTableAdapter = New CS314SemesterProject.CS314_SemesterProjectDataSetTableAdapters.Preorder_TTableAdapter()
        Me.TableAdapterManager = New CS314SemesterProject.CS314_SemesterProjectDataSetTableAdapters.TableAdapterManager()
        Me.BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PreorderTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PreorderIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalPaidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GameIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GameTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ViewAllPreorderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CustomerNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerEmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerPhoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgvPreorder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.CS314_SemesterProjectDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PreorderTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GameTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ViewToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(606, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.ClearToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(163, 24)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(163, 24)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewPreordersToolStripMenuItem, Me.ViewGameListToolStripMenuItem, Me.ViewAllPreorderToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(53, 24)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'ViewPreordersToolStripMenuItem
        '
        Me.ViewPreordersToolStripMenuItem.Name = "ViewPreordersToolStripMenuItem"
        Me.ViewPreordersToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.ViewPreordersToolStripMenuItem.Size = New System.Drawing.Size(228, 24)
        Me.ViewPreordersToolStripMenuItem.Text = "View Preorders"
        '
        'ViewGameListToolStripMenuItem
        '
        Me.ViewGameListToolStripMenuItem.Name = "ViewGameListToolStripMenuItem"
        Me.ViewGameListToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.ViewGameListToolStripMenuItem.Size = New System.Drawing.Size(228, 24)
        Me.ViewGameListToolStripMenuItem.Text = "View Game List"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.HelpToolStripMenuItem1})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(53, 24)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(171, 24)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'HelpToolStripMenuItem1
        '
        Me.HelpToolStripMenuItem1.Name = "HelpToolStripMenuItem1"
        Me.HelpToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.H), System.Windows.Forms.Keys)
        Me.HelpToolStripMenuItem1.Size = New System.Drawing.Size(171, 24)
        Me.HelpToolStripMenuItem1.Text = "Help"
        '
        'txtID
        '
        Me.txtID.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(139, 36)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(100, 34)
        Me.txtID.TabIndex = 23
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 28)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "PreorderID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(38, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 41)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Pre-Order"
        '
        'dgvPreorder
        '
        Me.dgvPreorder.AutoGenerateColumns = False
        Me.dgvPreorder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPreorder.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PreorderIDDataGridViewTextBoxColumn, Me.TotalPaidDataGridViewTextBoxColumn, Me.GameIDDataGridViewTextBoxColumn, Me.CustomerIDDataGridViewTextBoxColumn})
        Me.dgvPreorder.DataSource = Me.PreorderTBindingSource
        Me.dgvPreorder.Location = New System.Drawing.Point(173, 175)
        Me.dgvPreorder.Name = "dgvPreorder"
        Me.dgvPreorder.RowTemplate.Height = 24
        Me.dgvPreorder.Size = New System.Drawing.Size(399, 237)
        Me.dgvPreorder.TabIndex = 24
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(17, 360)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(150, 52)
        Me.btnDelete.TabIndex = 25
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(17, 278)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(150, 52)
        Me.btnEdit.TabIndex = 26
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.Location = New System.Drawing.Point(17, 195)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(150, 52)
        Me.btnNew.TabIndex = 27
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'txtChangeName
        '
        Me.txtChangeName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChangeName.Location = New System.Drawing.Point(208, 454)
        Me.txtChangeName.Name = "txtChangeName"
        Me.txtChangeName.Size = New System.Drawing.Size(100, 34)
        Me.txtChangeName.TabIndex = 29
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(44, 454)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(64, 28)
        Me.lblName.TabIndex = 28
        Me.lblName.Text = "Name"
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhone.Location = New System.Drawing.Point(44, 499)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(144, 28)
        Me.lblPhone.TabIndex = 30
        Me.lblPhone.Text = "Phone Number"
        '
        'lblMail
        '
        Me.lblMail.AutoSize = True
        Me.lblMail.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMail.Location = New System.Drawing.Point(44, 543)
        Me.lblMail.Name = "lblMail"
        Me.lblMail.Size = New System.Drawing.Size(59, 28)
        Me.lblMail.TabIndex = 31
        Me.lblMail.Text = "Email"
        '
        'lblPaid
        '
        Me.lblPaid.AutoSize = True
        Me.lblPaid.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaid.Location = New System.Drawing.Point(334, 499)
        Me.lblPaid.Name = "lblPaid"
        Me.lblPaid.Size = New System.Drawing.Size(126, 28)
        Me.lblPaid.TabIndex = 32
        Me.lblPaid.Text = "Amount Paid"
        '
        'lblPreorder
        '
        Me.lblPreorder.AutoSize = True
        Me.lblPreorder.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPreorder.Location = New System.Drawing.Point(334, 454)
        Me.lblPreorder.Name = "lblPreorder"
        Me.lblPreorder.Size = New System.Drawing.Size(123, 28)
        Me.lblPreorder.TabIndex = 33
        Me.lblPreorder.Text = "Pre-Order ID"
        '
        'txtChangeNumber
        '
        Me.txtChangeNumber.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChangeNumber.Location = New System.Drawing.Point(208, 499)
        Me.txtChangeNumber.Name = "txtChangeNumber"
        Me.txtChangeNumber.Size = New System.Drawing.Size(100, 34)
        Me.txtChangeNumber.TabIndex = 34
        '
        'txtChangeEmail
        '
        Me.txtChangeEmail.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChangeEmail.Location = New System.Drawing.Point(208, 543)
        Me.txtChangeEmail.Name = "txtChangeEmail"
        Me.txtChangeEmail.Size = New System.Drawing.Size(100, 34)
        Me.txtChangeEmail.TabIndex = 35
        '
        'txtChangePaid
        '
        Me.txtChangePaid.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChangePaid.Location = New System.Drawing.Point(479, 496)
        Me.txtChangePaid.Name = "txtChangePaid"
        Me.txtChangePaid.Size = New System.Drawing.Size(100, 34)
        Me.txtChangePaid.TabIndex = 36
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtID)
        Me.GroupBox1.Location = New System.Drawing.Point(34, 89)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(250, 76)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Alt + V to View Your Pre-Orders!"
        '
        'radInfo
        '
        Me.radInfo.AutoSize = True
        Me.radInfo.Location = New System.Drawing.Point(208, 427)
        Me.radInfo.Name = "radInfo"
        Me.radInfo.Size = New System.Drawing.Size(149, 21)
        Me.radInfo.TabIndex = 40
        Me.radInfo.TabStop = True
        Me.radInfo.Text = "Edit My Information"
        Me.radInfo.UseVisualStyleBackColor = True
        '
        'radPreorder
        '
        Me.radPreorder.AutoSize = True
        Me.radPreorder.Location = New System.Drawing.Point(49, 430)
        Me.radPreorder.Name = "radPreorder"
        Me.radPreorder.Size = New System.Drawing.Size(113, 21)
        Me.radPreorder.TabIndex = 41
        Me.radPreorder.TabStop = True
        Me.radPreorder.Text = "Edit Preorder"
        Me.radPreorder.UseVisualStyleBackColor = True
        '
        'txtPreID
        '
        Me.txtPreID.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPreID.Location = New System.Drawing.Point(479, 448)
        Me.txtPreID.Name = "txtPreID"
        Me.txtPreID.Size = New System.Drawing.Size(100, 34)
        Me.txtPreID.TabIndex = 42
        '
        'CS314_SemesterProjectDataSet
        '
        Me.CS314_SemesterProjectDataSet.DataSetName = "CS314_SemesterProjectDataSet"
        Me.CS314_SemesterProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Customer_TTableAdapter
        '
        Me.Customer_TTableAdapter.ClearBeforeFill = True
        '
        'Game_TTableAdapter
        '
        Me.Game_TTableAdapter.ClearBeforeFill = True
        '
        'Preorder_TTableAdapter
        '
        Me.Preorder_TTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Customer_TTableAdapter = Me.Customer_TTableAdapter
        Me.TableAdapterManager.Game_TTableAdapter = Me.Game_TTableAdapter
        Me.TableAdapterManager.Preorder_TTableAdapter = Me.Preorder_TTableAdapter
        Me.TableAdapterManager.UpdateOrder = CS314SemesterProject.CS314_SemesterProjectDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PreorderTBindingSource
        '
        Me.PreorderTBindingSource.DataMember = "Preorder_T"
        Me.PreorderTBindingSource.DataSource = Me.CS314_SemesterProjectDataSet
        '
        'PreorderIDDataGridViewTextBoxColumn
        '
        Me.PreorderIDDataGridViewTextBoxColumn.DataPropertyName = "PreorderID"
        Me.PreorderIDDataGridViewTextBoxColumn.HeaderText = "PreorderID"
        Me.PreorderIDDataGridViewTextBoxColumn.Name = "PreorderIDDataGridViewTextBoxColumn"
        '
        'TotalPaidDataGridViewTextBoxColumn
        '
        Me.TotalPaidDataGridViewTextBoxColumn.DataPropertyName = "TotalPaid"
        Me.TotalPaidDataGridViewTextBoxColumn.HeaderText = "TotalPaid"
        Me.TotalPaidDataGridViewTextBoxColumn.Name = "TotalPaidDataGridViewTextBoxColumn"
        '
        'GameIDDataGridViewTextBoxColumn
        '
        Me.GameIDDataGridViewTextBoxColumn.DataPropertyName = "GameID"
        Me.GameIDDataGridViewTextBoxColumn.HeaderText = "GameID"
        Me.GameIDDataGridViewTextBoxColumn.Name = "GameIDDataGridViewTextBoxColumn"
        '
        'CustomerIDDataGridViewTextBoxColumn
        '
        Me.CustomerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID"
        Me.CustomerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID"
        Me.CustomerIDDataGridViewTextBoxColumn.Name = "CustomerIDDataGridViewTextBoxColumn"
        '
        'GameTBindingSource
        '
        Me.GameTBindingSource.DataMember = "Game_T"
        Me.GameTBindingSource.DataSource = Me.CS314_SemesterProjectDataSet
        '
        'CustomerTBindingSource
        '
        Me.CustomerTBindingSource.DataMember = "Customer_T"
        Me.CustomerTBindingSource.DataSource = Me.CS314_SemesterProjectDataSet
        '
        'ViewAllPreorderToolStripMenuItem
        '
        Me.ViewAllPreorderToolStripMenuItem.Name = "ViewAllPreorderToolStripMenuItem"
        Me.ViewAllPreorderToolStripMenuItem.Size = New System.Drawing.Size(228, 24)
        Me.ViewAllPreorderToolStripMenuItem.Text = "View All Preorders"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CustomerNameDataGridViewTextBoxColumn, Me.CustomerEmailDataGridViewTextBoxColumn, Me.CustomerPhoneDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CustomerTBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(375, 47)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(162, 112)
        Me.DataGridView1.TabIndex = 43
        '
        'CustomerNameDataGridViewTextBoxColumn
        '
        Me.CustomerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName"
        Me.CustomerNameDataGridViewTextBoxColumn.HeaderText = "CustomerName"
        Me.CustomerNameDataGridViewTextBoxColumn.Name = "CustomerNameDataGridViewTextBoxColumn"
        '
        'CustomerEmailDataGridViewTextBoxColumn
        '
        Me.CustomerEmailDataGridViewTextBoxColumn.DataPropertyName = "CustomerEmail"
        Me.CustomerEmailDataGridViewTextBoxColumn.HeaderText = "CustomerEmail"
        Me.CustomerEmailDataGridViewTextBoxColumn.Name = "CustomerEmailDataGridViewTextBoxColumn"
        '
        'CustomerPhoneDataGridViewTextBoxColumn
        '
        Me.CustomerPhoneDataGridViewTextBoxColumn.DataPropertyName = "CustomerPhone"
        Me.CustomerPhoneDataGridViewTextBoxColumn.HeaderText = "CustomerPhone"
        Me.CustomerPhoneDataGridViewTextBoxColumn.Name = "CustomerPhoneDataGridViewTextBoxColumn"
        '
        'PreorderForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(606, 605)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtPreID)
        Me.Controls.Add(Me.radPreorder)
        Me.Controls.Add(Me.radInfo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtChangePaid)
        Me.Controls.Add(Me.txtChangeEmail)
        Me.Controls.Add(Me.txtChangeNumber)
        Me.Controls.Add(Me.lblPreorder)
        Me.Controls.Add(Me.lblPaid)
        Me.Controls.Add(Me.lblMail)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.txtChangeName)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.dgvPreorder)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "PreorderForm"
        Me.Text = "GamePreOrder2000 - Sasha Bridges"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgvPreorder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.CS314_SemesterProjectDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PreorderTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GameTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgvPreorder As System.Windows.Forms.DataGridView
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents txtChangeName As System.Windows.Forms.TextBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblPhone As System.Windows.Forms.Label
    Friend WithEvents lblMail As System.Windows.Forms.Label
    Friend WithEvents lblPaid As System.Windows.Forms.Label
    Friend WithEvents lblPreorder As System.Windows.Forms.Label
    Friend WithEvents txtChangeNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtChangeEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtChangePaid As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ViewPreordersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewGameListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents radInfo As System.Windows.Forms.RadioButton
    Friend WithEvents radPreorder As System.Windows.Forms.RadioButton
    Friend WithEvents txtPreID As System.Windows.Forms.TextBox
    Friend WithEvents CS314_SemesterProjectDataSet As CS314SemesterProject.CS314_SemesterProjectDataSet
    Friend WithEvents Customer_TTableAdapter As CS314SemesterProject.CS314_SemesterProjectDataSetTableAdapters.Customer_TTableAdapter
    Friend WithEvents Game_TTableAdapter As CS314SemesterProject.CS314_SemesterProjectDataSetTableAdapters.Game_TTableAdapter
    Friend WithEvents Preorder_TTableAdapter As CS314SemesterProject.CS314_SemesterProjectDataSetTableAdapters.Preorder_TTableAdapter
    Friend WithEvents TableAdapterManager As CS314SemesterProject.CS314_SemesterProjectDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PreorderIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalPaidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GameIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustomerIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PreorderTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GameTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CustomerTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ViewAllPreorderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents CustomerNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustomerEmailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustomerPhoneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
