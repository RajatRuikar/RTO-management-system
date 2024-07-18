<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class charep
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(charep))
        Me.DBDataSet2 = New RTO.DBDataSet2()
        Me.ChallanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ChallanTableAdapter = New RTO.DBDataSet2TableAdapters.ChallanTableAdapter()
        Me.TableAdapterManager = New RTO.DBDataSet2TableAdapters.TableAdapterManager()
        Me.ChallanBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ChallanBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ChallanDataGridView = New System.Windows.Forms.DataGridView()
        Me.FullNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MobDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LicnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LictypDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VehnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VehtypDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PayDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChallanBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DBDataSet5 = New RTO.DBDataSet5()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DBDataSet4 = New RTO.DBDataSet4()
        Me.ChallanBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ChallanTableAdapter1 = New RTO.DBDataSet4TableAdapters.ChallanTableAdapter()
        Me.TableAdapterManager1 = New RTO.DBDataSet4TableAdapters.TableAdapterManager()
        Me.ChallanTableAdapter2 = New RTO.DBDataSet5TableAdapters.ChallanTableAdapter()
        Me.TableAdapterManager2 = New RTO.DBDataSet5TableAdapters.TableAdapterManager()
        CType(Me.DBDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChallanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChallanBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ChallanBindingNavigator.SuspendLayout()
        CType(Me.ChallanDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChallanBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBDataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBDataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChallanBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DBDataSet2
        '
        Me.DBDataSet2.DataSetName = "DBDataSet2"
        Me.DBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ChallanBindingSource
        '
        Me.ChallanBindingSource.DataMember = "Challan"
        Me.ChallanBindingSource.DataSource = Me.DBDataSet2
        '
        'ChallanTableAdapter
        '
        Me.ChallanTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ChallanTableAdapter = Me.ChallanTableAdapter
        Me.TableAdapterManager.LearningTableAdapter = Nothing
        Me.TableAdapterManager.loginTableAdapter = Nothing
        Me.TableAdapterManager.PermanentTableAdapter = Nothing
        Me.TableAdapterManager.RegistrationTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = RTO.DBDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VehicleTableAdapter = Nothing
        '
        'ChallanBindingNavigator
        '
        Me.ChallanBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ChallanBindingNavigator.BindingSource = Me.ChallanBindingSource
        Me.ChallanBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ChallanBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ChallanBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ChallanBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ChallanBindingNavigatorSaveItem})
        Me.ChallanBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ChallanBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ChallanBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ChallanBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ChallanBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ChallanBindingNavigator.Name = "ChallanBindingNavigator"
        Me.ChallanBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ChallanBindingNavigator.Size = New System.Drawing.Size(1251, 27)
        Me.ChallanBindingNavigator.TabIndex = 0
        Me.ChallanBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 24)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'ChallanBindingNavigatorSaveItem
        '
        Me.ChallanBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ChallanBindingNavigatorSaveItem.Image = CType(resources.GetObject("ChallanBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ChallanBindingNavigatorSaveItem.Name = "ChallanBindingNavigatorSaveItem"
        Me.ChallanBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 24)
        Me.ChallanBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ChallanDataGridView
        '
        Me.ChallanDataGridView.AutoGenerateColumns = False
        Me.ChallanDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ChallanDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FullNameDataGridViewTextBoxColumn, Me.GenDataGridViewTextBoxColumn, Me.AddDataGridViewTextBoxColumn, Me.MobDataGridViewTextBoxColumn, Me.LicnoDataGridViewTextBoxColumn, Me.LictypDataGridViewTextBoxColumn, Me.VehnoDataGridViewTextBoxColumn, Me.VehtypDataGridViewTextBoxColumn, Me.ChasDataGridViewTextBoxColumn, Me.DescDataGridViewTextBoxColumn, Me.PayDataGridViewTextBoxColumn, Me.TotalDataGridViewTextBoxColumn})
        Me.ChallanDataGridView.DataSource = Me.ChallanBindingSource2
        Me.ChallanDataGridView.Location = New System.Drawing.Point(48, 136)
        Me.ChallanDataGridView.Name = "ChallanDataGridView"
        Me.ChallanDataGridView.RowHeadersWidth = 51
        Me.ChallanDataGridView.RowTemplate.Height = 24
        Me.ChallanDataGridView.Size = New System.Drawing.Size(1120, 388)
        Me.ChallanDataGridView.TabIndex = 1
        '
        'FullNameDataGridViewTextBoxColumn
        '
        Me.FullNameDataGridViewTextBoxColumn.DataPropertyName = "Full_Name"
        Me.FullNameDataGridViewTextBoxColumn.HeaderText = "Full_Name"
        Me.FullNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.FullNameDataGridViewTextBoxColumn.Name = "FullNameDataGridViewTextBoxColumn"
        Me.FullNameDataGridViewTextBoxColumn.Width = 125
        '
        'GenDataGridViewTextBoxColumn
        '
        Me.GenDataGridViewTextBoxColumn.DataPropertyName = "Gen"
        Me.GenDataGridViewTextBoxColumn.HeaderText = "Gen"
        Me.GenDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.GenDataGridViewTextBoxColumn.Name = "GenDataGridViewTextBoxColumn"
        Me.GenDataGridViewTextBoxColumn.Width = 125
        '
        'AddDataGridViewTextBoxColumn
        '
        Me.AddDataGridViewTextBoxColumn.DataPropertyName = "Add"
        Me.AddDataGridViewTextBoxColumn.HeaderText = "Add"
        Me.AddDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.AddDataGridViewTextBoxColumn.Name = "AddDataGridViewTextBoxColumn"
        Me.AddDataGridViewTextBoxColumn.Width = 125
        '
        'MobDataGridViewTextBoxColumn
        '
        Me.MobDataGridViewTextBoxColumn.DataPropertyName = "Mob"
        Me.MobDataGridViewTextBoxColumn.HeaderText = "Mob"
        Me.MobDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MobDataGridViewTextBoxColumn.Name = "MobDataGridViewTextBoxColumn"
        Me.MobDataGridViewTextBoxColumn.Width = 125
        '
        'LicnoDataGridViewTextBoxColumn
        '
        Me.LicnoDataGridViewTextBoxColumn.DataPropertyName = "Licno"
        Me.LicnoDataGridViewTextBoxColumn.HeaderText = "Licno"
        Me.LicnoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.LicnoDataGridViewTextBoxColumn.Name = "LicnoDataGridViewTextBoxColumn"
        Me.LicnoDataGridViewTextBoxColumn.Width = 125
        '
        'LictypDataGridViewTextBoxColumn
        '
        Me.LictypDataGridViewTextBoxColumn.DataPropertyName = "Lictyp"
        Me.LictypDataGridViewTextBoxColumn.HeaderText = "Lictyp"
        Me.LictypDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.LictypDataGridViewTextBoxColumn.Name = "LictypDataGridViewTextBoxColumn"
        Me.LictypDataGridViewTextBoxColumn.Width = 125
        '
        'VehnoDataGridViewTextBoxColumn
        '
        Me.VehnoDataGridViewTextBoxColumn.DataPropertyName = "Vehno"
        Me.VehnoDataGridViewTextBoxColumn.HeaderText = "Vehno"
        Me.VehnoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.VehnoDataGridViewTextBoxColumn.Name = "VehnoDataGridViewTextBoxColumn"
        Me.VehnoDataGridViewTextBoxColumn.Width = 125
        '
        'VehtypDataGridViewTextBoxColumn
        '
        Me.VehtypDataGridViewTextBoxColumn.DataPropertyName = "vehtyp"
        Me.VehtypDataGridViewTextBoxColumn.HeaderText = "vehtyp"
        Me.VehtypDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.VehtypDataGridViewTextBoxColumn.Name = "VehtypDataGridViewTextBoxColumn"
        Me.VehtypDataGridViewTextBoxColumn.Width = 125
        '
        'ChasDataGridViewTextBoxColumn
        '
        Me.ChasDataGridViewTextBoxColumn.DataPropertyName = "chas"
        Me.ChasDataGridViewTextBoxColumn.HeaderText = "chas"
        Me.ChasDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ChasDataGridViewTextBoxColumn.Name = "ChasDataGridViewTextBoxColumn"
        Me.ChasDataGridViewTextBoxColumn.Width = 125
        '
        'DescDataGridViewTextBoxColumn
        '
        Me.DescDataGridViewTextBoxColumn.DataPropertyName = "desc"
        Me.DescDataGridViewTextBoxColumn.HeaderText = "desc"
        Me.DescDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DescDataGridViewTextBoxColumn.Name = "DescDataGridViewTextBoxColumn"
        Me.DescDataGridViewTextBoxColumn.Width = 125
        '
        'PayDataGridViewTextBoxColumn
        '
        Me.PayDataGridViewTextBoxColumn.DataPropertyName = "pay"
        Me.PayDataGridViewTextBoxColumn.HeaderText = "pay"
        Me.PayDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PayDataGridViewTextBoxColumn.Name = "PayDataGridViewTextBoxColumn"
        Me.PayDataGridViewTextBoxColumn.Width = 125
        '
        'TotalDataGridViewTextBoxColumn
        '
        Me.TotalDataGridViewTextBoxColumn.DataPropertyName = "total"
        Me.TotalDataGridViewTextBoxColumn.HeaderText = "total"
        Me.TotalDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TotalDataGridViewTextBoxColumn.Name = "TotalDataGridViewTextBoxColumn"
        Me.TotalDataGridViewTextBoxColumn.Width = 125
        '
        'ChallanBindingSource2
        '
        Me.ChallanBindingSource2.DataMember = "Challan"
        Me.ChallanBindingSource2.DataSource = Me.DBDataSet5
        '
        'DBDataSet5
        '
        Me.DBDataSet5.DataSetName = "DBDataSet5"
        Me.DBDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(981, 568)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(243, 69)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(66, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(238, 32)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Challan Report:-"
        '
        'DBDataSet4
        '
        Me.DBDataSet4.DataSetName = "DBDataSet4"
        Me.DBDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ChallanBindingSource1
        '
        Me.ChallanBindingSource1.DataMember = "Challan"
        Me.ChallanBindingSource1.DataSource = Me.DBDataSet4
        '
        'ChallanTableAdapter1
        '
        Me.ChallanTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.ChallanTableAdapter = Me.ChallanTableAdapter1
        Me.TableAdapterManager1.LearningTableAdapter = Nothing
        Me.TableAdapterManager1.loginTableAdapter = Nothing
        Me.TableAdapterManager1.PermanentTableAdapter = Nothing
        Me.TableAdapterManager1.RegistrationTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = RTO.DBDataSet4TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager1.VehicleTableAdapter = Nothing
        '
        'ChallanTableAdapter2
        '
        Me.ChallanTableAdapter2.ClearBeforeFill = True
        '
        'TableAdapterManager2
        '
        Me.TableAdapterManager2.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager2.ChallanTableAdapter = Me.ChallanTableAdapter2
        Me.TableAdapterManager2.LearningTableAdapter = Nothing
        Me.TableAdapterManager2.loginTableAdapter = Nothing
        Me.TableAdapterManager2.PermanentTableAdapter = Nothing
        Me.TableAdapterManager2.RegistrationTableAdapter = Nothing
        Me.TableAdapterManager2.UpdateOrder = RTO.DBDataSet5TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager2.VehicleTableAdapter = Nothing
        '
        'charep
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1251, 667)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ChallanDataGridView)
        Me.Controls.Add(Me.ChallanBindingNavigator)
        Me.Name = "charep"
        Me.Text = "charep"
        CType(Me.DBDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChallanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChallanBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ChallanBindingNavigator.ResumeLayout(False)
        Me.ChallanBindingNavigator.PerformLayout()
        CType(Me.ChallanDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChallanBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DBDataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DBDataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChallanBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DBDataSet2 As DBDataSet2
    Friend WithEvents ChallanBindingSource As BindingSource
    Friend WithEvents ChallanTableAdapter As DBDataSet2TableAdapters.ChallanTableAdapter
    Friend WithEvents TableAdapterManager As DBDataSet2TableAdapters.TableAdapterManager
    Friend WithEvents ChallanBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents ChallanBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ChallanDataGridView As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents DBDataSet4 As DBDataSet4
    Friend WithEvents ChallanBindingSource1 As BindingSource
    Friend WithEvents ChallanTableAdapter1 As DBDataSet4TableAdapters.ChallanTableAdapter
    Friend WithEvents TableAdapterManager1 As DBDataSet4TableAdapters.TableAdapterManager
    Friend WithEvents DBDataSet5 As DBDataSet5
    Friend WithEvents ChallanBindingSource2 As BindingSource
    Friend WithEvents ChallanTableAdapter2 As DBDataSet5TableAdapters.ChallanTableAdapter
    Friend WithEvents TableAdapterManager2 As DBDataSet5TableAdapters.TableAdapterManager
    Friend WithEvents FullNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GenDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MobDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LicnoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LictypDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VehnoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VehtypDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ChasDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PayDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
