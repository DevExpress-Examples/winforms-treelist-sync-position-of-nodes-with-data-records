<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128637290/15.2.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3577)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# WinForms TreeList - Sync the position of child nodes with the position of corresponding records in the datasource

The TreeList control allows users to reorder nodes by dragging them with the mouse. If the user moves a node from one parent to another, the node's position is automatically saved in the data source (because it depends on the `ParentID` column value that is stored in the data source). When the user reorders the nodes in a child collection, the position of the nodes is reset after the application is closed and reopened (or after the data is reloaded).

To store the position of child nodes, do the following:

* Add an additional column to the data source to hold node indexes (in this example this is the `Order` column).
* Handle the TreeList's `AfterDragNode` event to save the new position of a node after the user has moved it to another position.

  ```csharp
   private void treeList1_AfterDragNode(object sender, AfterDragNodeEventArgs e) {
       SaveNewRecordPosition(e);
   }
   private void SaveNewRecordPosition(NodeEventArgs e) {
       var nodes = e.Node.ParentNode == null ? e.Node.TreeList.Nodes
                   : e.Node.ParentNode.Nodes;
       for(var i = 0; i < nodes.Count; i++) {
           nodes[i].SetValue(colSort, i);
       }
   }
  ```
* Iterate through child nodes and update their position using the [TreeList.SetNodeIndex](https://docs.devexpress.com/WindowsForms/DevExpress.XtraTreeList.TreeList.SetNodeIndex(DevExpress.XtraTreeList.Nodes.TreeListNode-System.Int32)) method when the application is loaded.
   
   ```cs
   private void UpdateNodesPositions(TreeListNodes nodes) {
       var ns = new List<TreeListNode>();
       foreach (TreeListNode n in nodes) {
           ns.Add(n);
       }
       foreach (TreeListNode n in ns) {
           UpdateNodesPositions(n.Nodes);
           n.TreeList.SetNodeIndex(n, Convert.ToInt32(n.GetValue("Order")));
       }
   }
   ```

> **Note**
> 
> Newer versions have the following changes:
> * The signature of the `AfterDragNode` event's delegate has been changed.
> * TreeList's `OptionsBehavior.DragNodes` property is now obsolete. Use the [OptionsDragAndDrop.DragNodesMode](https://docs.devexpress.com/WindowsForms/DevExpress.XtraTreeList.TreeListOptionsDragAndDrop.DragNodesMode) property instead.


## Files to Review

* [Form1.cs](./CS/Q351285/Form1.cs) (VB: [Form1.vb](./VB/Q351285/Form1.vb))
