Imports System
Imports System.IO
Imports System.Windows.Forms
Imports DevExpress.XtraTreeList
Imports System.Collections.Generic
Imports DevExpress.XtraTreeList.Nodes
Imports DevExpress.XtraEditors

Namespace Q351285

    Public Partial Class Form1
        Inherits XtraForm

        Private treeListDataFile As String = "data.xml"

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            InitData()
            InitTreeList()
        End Sub

        Private Sub InitTreeList()
            treeList1.ForceInitialize()
            UpdateNodesPositions(treeList1.Nodes)
            treeList1.ExpandAll()
        End Sub

        Private Sub InitData()
            If File.Exists(treeListDataFile) Then
                dataTable1.ReadXml(treeListDataFile)
            Else
                FillTable()
            End If
        End Sub

        Private Sub FillTable()
            dataTable1.Rows.Add(1, 0, "A", 0)
            dataTable1.Rows.Add(2, 1, "B", 1)
            dataTable1.Rows.Add(3, 1, "C", 2)
            dataTable1.Rows.Add(4, 0, "D", 3)
            dataTable1.Rows.Add(5, 4, "E", 4)
        End Sub

        Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs)
            SaveData()
        End Sub

        Private Sub SaveData()
            dataTable1.WriteXml(treeListDataFile)
        End Sub

        Private Sub UpdateNodesPositions(ByVal nodes As TreeListNodes)
            Dim ns = New List(Of TreeListNode)()
            For Each n As TreeListNode In nodes
                ns.Add(n)
            Next

            For Each n As TreeListNode In ns
                UpdateNodesPositions(n.Nodes)
                n.TreeList.SetNodeIndex(n, Convert.ToInt32(n.GetValue("Order")))
            Next
        End Sub

        Private Sub treeList1_AfterDragNode(ByVal sender As Object, ByVal e As NodeEventArgs)
            SaveNewRecordPosition(e)
        End Sub

        Private Sub SaveNewRecordPosition(ByVal e As NodeEventArgs)
            Dim nodes = If(e.Node.ParentNode Is Nothing, e.Node.TreeList.Nodes, e.Node.ParentNode.Nodes)
            For i = 0 To nodes.Count - 1
                nodes(i).SetValue(colSort, i)
            Next
        End Sub
    End Class
End Namespace
