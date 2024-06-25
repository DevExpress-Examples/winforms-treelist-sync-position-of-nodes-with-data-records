<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128637290/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3577)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* **[Form1.cs](./CS/Q351285/Form1.cs) (VB: [Form1.vb](./VB/Q351285/Form1.vb))**
* [Program.cs](./CS/Q351285/Program.cs) (VB: [Program.vb](./VB/Q351285/Program.vb))
<!-- default file list end -->
# How to change a TreeList node position along with a corresponding record's position in the database


<p>TreeList allows users to reorder nodes by dragging them with the mouse. If a node was moved from one parent to another, its position will be saved automatically, because it depends on the ParentID column value which is stored in the database. However, when nodes are reordered within the child collection, their position will be reset after the application is closed and opened again, or after reloading data.</p><p>To keep nodes positions, it is necessary to add additional column to the datasource to store the node index. In this situation, nodes positions can be restored after loading the data into the TreeList. This task can be accomplished by iterating all the nodes and updating the node index via the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraTreeListTreeList_SetNodeIndextopic"><u>TreeList.SetNodeIndex</u></a> method.</p>

```cs
void UpdateNodesPositions(TreeListNodes nodes) {<newline/>    List<TreeListNode> ns = new List<TreeListNode>();<newline/>    foreach (TreeListNode n in nodes)<newline/>        ns.Add(n);<newline/>    foreach (TreeListNode n in ns) {<newline/>        UpdateNodesPositions(n.Nodes);<newline/>        n.TreeList.SetNodeIndex(n, Convert.ToInt32(n.GetValue("Order")));<newline/>    }<newline/>}<newline/>
```



```vb
Private Sub UpdateNodesPositions(ByVal nodes As TreeListNodes)<newline/>	Dim ns As New List(Of TreeListNode)()<newline/>	For Each n As TreeListNode In nodes<newline/>		ns.Add(n)<newline/>	Next n<newline/>	For Each n As TreeListNode In ns<newline/>		UpdateNodesPositions(n.Nodes)<newline/>		n.TreeList.SetNodeIndex(n, Convert.ToInt32(n.GetValue("Order")))<newline/>	Next n<newline/>End Sub
```

<p> </p>

<br/>


<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-treelist-sync-position-of-nodes-with-data-records&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-treelist-sync-position-of-nodes-with-data-records&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
