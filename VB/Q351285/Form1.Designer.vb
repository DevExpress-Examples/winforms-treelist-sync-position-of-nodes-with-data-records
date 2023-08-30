Namespace Q351285

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.bindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
            Me.dataSet1 = New System.Data.DataSet()
            Me.dataTable1 = New System.Data.DataTable()
            Me.dataColumn1 = New System.Data.DataColumn()
            Me.dataColumn2 = New System.Data.DataColumn()
            Me.dataColumn3 = New System.Data.DataColumn()
            Me.dataColumn4 = New System.Data.DataColumn()
            Me.treeList1 = New DevExpress.XtraTreeList.TreeList()
            Me.colText = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.colSort = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            CType((Me.bindingSource1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.dataSet1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.dataTable1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.treeList1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' bindingSource1
            ' 
            Me.bindingSource1.DataMember = "Table1"
            Me.bindingSource1.DataSource = Me.dataSet1
            ' 
            ' dataSet1
            ' 
            Me.dataSet1.DataSetName = "NewDataSet"
            Me.dataSet1.Tables.AddRange(New System.Data.DataTable() {Me.dataTable1})
            ' 
            ' dataTable1
            ' 
            Me.dataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.dataColumn1, Me.dataColumn2, Me.dataColumn3, Me.dataColumn4})
            Me.dataTable1.TableName = "Table1"
            ' 
            ' dataColumn1
            ' 
            Me.dataColumn1.ColumnName = "ID"
            Me.dataColumn1.DataType = GetType(Integer)
            ' 
            ' dataColumn2
            ' 
            Me.dataColumn2.ColumnName = "ParentID"
            Me.dataColumn2.DataType = GetType(Integer)
            ' 
            ' dataColumn3
            ' 
            Me.dataColumn3.ColumnName = "Text"
            ' 
            ' dataColumn4
            ' 
            Me.dataColumn4.ColumnName = "Order"
            Me.dataColumn4.DataType = GetType(Integer)
            ' 
            ' treeList1
            ' 
            Me.treeList1.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.colText, Me.colSort})
            Me.treeList1.CustomizationFormBounds = New System.Drawing.Rectangle(1703, 737, 208, 176)
            Me.treeList1.DataSource = Me.bindingSource1
            Me.treeList1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.treeList1.Location = New System.Drawing.Point(0, 0)
            Me.treeList1.Name = "treeList1"
            'this.treeList1.OptionsBehavior.DragNodes = true;
            Me.treeList1.OptionsDragAndDrop.DragNodesMode = DevExpress.XtraTreeList.DragNodesMode.Multiple
            Me.treeList1.OptionsBehavior.PopulateServiceColumns = True
            Me.treeList1.OptionsBehavior.ShowEditorOnMouseUp = True
            Me.treeList1.Size = New System.Drawing.Size(428, 268)
            Me.treeList1.TabIndex = 0
            AddHandler Me.treeList1.AfterDragNode, New DevExpress.XtraTreeList.AfterDragNodeEventHandler(AddressOf Me.treeList1_AfterDragNode)
            ' 
            ' colText
            ' 
            Me.colText.FieldName = "Text"
            Me.colText.Name = "colText"
            Me.colText.Visible = True
            Me.colText.VisibleIndex = 0
            Me.colText.Width = 410
            ' 
            ' colSort
            ' 
            Me.colSort.Caption = "treeListColumn1"
            Me.colSort.FieldName = "Order"
            Me.colSort.Name = "colSort"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(428, 268)
            Me.Controls.Add(Me.treeList1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            AddHandler Me.FormClosing, New System.Windows.Forms.FormClosingEventHandler(AddressOf Me.Form1_FormClosing)
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.Form1_Load)
            CType((Me.bindingSource1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.dataSet1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.dataTable1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.treeList1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private bindingSource1 As System.Windows.Forms.BindingSource

        Private dataSet1 As System.Data.DataSet

        Private dataTable1 As System.Data.DataTable

        Private dataColumn1 As System.Data.DataColumn

        Private dataColumn2 As System.Data.DataColumn

        Private dataColumn3 As System.Data.DataColumn

        Private treeList1 As DevExpress.XtraTreeList.TreeList

        Private colText As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private dataColumn4 As System.Data.DataColumn

        Private colSort As DevExpress.XtraTreeList.Columns.TreeListColumn
    End Class
End Namespace
