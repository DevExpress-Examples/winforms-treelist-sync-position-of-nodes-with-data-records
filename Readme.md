<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Q351285/Form1.cs) (VB: [Form1.vb](./VB/Q351285/Form1.vb))
* [Program.cs](./CS/Q351285/Program.cs) (VB: [Program.vb](./VB/Q351285/Program.vb))
<!-- default file list end -->
# How to change a TreeList node position along with a corresponding record's position in the database


<p>TreeList allows users to reorder nodes by dragging them with the mouse. If a node was moved from one parent to another, its position will be saved automatically, because it depends on the ParentID column value which is stored in the database. However, when nodes are reordered within the child collection, their position will be reset after the application is closed and opened again, or after reloading data.</p><p>To keep nodes positions, it is necessary to add additional column to the datasource to store the node index. In this situation, nodes positions can be restored after loading the data into the TreeList. This task can be accomplished by iterating all the nodes and updating the node index via the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraTreeListTreeList_SetNodeIndextopic"><u>TreeList.SetNodeIndex</u></a> method.</p>

```cs
void UpdateNodesPositions(TreeListNodes nodes) {
   List<TreeListNode> ns = new List<TreeListNode>();
   foreach (TreeListNode n in nodes)
     ns.Add(n);
   foreach (TreeListNode n in ns) {
     UpdateNodesPositions(n.Nodes);
     n.TreeList.SetNodeIndex(n, Convert.ToInt32(n.GetValue("Order")));
   }
}
```



```vb
Private Sub UpdateNodesPositions(ByVal nodes As TreeListNodes)
    Dim ns As New List(Of TreeListNode)()
    For Each n As TreeListNode In nodes
        ns.Add(n)
        Next n
    For Each n As TreeListNode In ns
        UpdateNodesPositions(n.Nodes)
        n.TreeList.SetNodeIndex(n, Convert.ToInt32(n.GetValue("Order")))
    Next n
End Sub
```

<p> </p>


<h3>Description</h3>

The signature of the&nbsp;AfterDragNode event's delegate has been changed.&nbsp;<br>TreeList's&nbsp;OptionsBehavior.DragNodes property is now obsolete. Use TreeList's&nbsp;<a href="https://docs.devexpress.com/WindowsForms/DevExpress.XtraTreeList.TreeListOptionsDragAndDrop.DragNodesMode">OptionsDragAndDrop.DragNodesMode</a> property instead.

<br/>


