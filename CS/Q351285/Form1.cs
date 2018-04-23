using System;
using System.IO;
using System.Windows.Forms;
using DevExpress.XtraTreeList;
using System.Collections.Generic;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraEditors;

namespace Q351285 {
    public partial class Form1 : XtraForm {
        private string treeListDataFile = "data.xml";
        public Form1() {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e) {
            InitData();
            InitTreeList();
        }
        private void InitTreeList() {
            treeList1.ForceInitialize();
            UpdateNodesPositions(treeList1.Nodes);
            treeList1.ExpandAll();
        }
        private void InitData() {
            if(File.Exists(treeListDataFile)) {
                dataTable1.ReadXml(treeListDataFile);
            } else {
                FillTable();
            }
        }
        private void FillTable() {
            dataTable1.Rows.Add(1, 0, "A", 0/*initially, this value is used to determine the node position*/);
            dataTable1.Rows.Add(2, 1, "B", 1);
            dataTable1.Rows.Add(3, 1, "C", 2);
            dataTable1.Rows.Add(4, 0, "D", 3);
            dataTable1.Rows.Add(5, 4, "E", 4);
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            SaveData();
        }
        private void SaveData() {
            dataTable1.WriteXml(treeListDataFile);
        }
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
    }
}
