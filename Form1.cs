/**********************************************************************
 *  Project:        Balanced Trees
 *  File:           Form1.cs
 *  Language:       C#
 *  
 *  Description:    This file is the form for building a Balanced binary search tree.
 *                  
 *  College:        Husson University
 *  Course:         IT 325
 *  
 *  Change Log
 *  Date        Notes
 *  --------    -------------------------------------
 *  4/11/25     Updated Form Desgin
 *  4/13/24     Finished code and testing
 *  **/
namespace HyattBasicTrees {
    public partial class BasicTrees : Form {

        #region data
        Tree tTree = new Tree();
        #endregion data

        #region constructor
        public BasicTrees() {
            InitializeComponent();
        }

        #endregion constructor

        #region events

        /// <summary>
        /// Browse file button clicked to find a file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBrowse_Click(object sender, EventArgs e) {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK) {
                fileNameTextBox.Text = File.ReadAllText(ofd.FileName);
            }
        }

        /// <summary>
        /// Load data button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLoad_Click(object sender, EventArgs e) {
            FillTreeValues();
            DisplayTreeInTreeView();
        }

        /// <summary>
        /// Clear button to clear all list boxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e) {
            treeView1.Nodes.Clear();
            preOrderListBox.Items.Clear();
            InOrderListBox.Items.Clear();
            PostOrderListBox.Items.Clear();
            fileNameTextBox.Clear();
            tTree = new Tree(); // reset the tree
        }

        /// <summary>
        /// Pre-Order Traversal Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPreOrder_Click(object sender, EventArgs e) {
            preOrderListBox.Items.Clear();
            recursivePreOrder(tTree.root);
        }

        /// <summary>
        /// In-order traversal clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInOrder_Click(object sender, EventArgs e) {
            InOrderListBox.Items.Clear();
            recursiveInOrder(tTree.root);
        }

        /// <summary>
        /// Post-Order Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPostOrder_Click(object sender, EventArgs e) {
            PostOrderListBox.Items.Clear();
            recursivePostOrder(tTree.root);
        }

        #endregion events

        #region methods

        /// <summary>
        /// Method to fill the tree with values from the text files
        /// </summary>
        private void FillTreeValues() {

            //Logic to catch files that aren't only comma-separated
            string cleaned = fileNameTextBox.Text
               .Replace("\r\n", ",")
               .Replace("\n", ",")
               .Replace(" ", ",");

            //New array of cleaned up values
            string[] sValues = cleaned.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            //Loop through and insert or give error
            foreach (string s in sValues) {
                if (int.TryParse(s.Trim(), out int value)) {
                    tTree.insert(value);
                }
                else {
                    MessageBox.Show($"Invalid input: '{s}'");
                }
            }
        }

        /// <summary>
        /// Recursivley Pre-Order Tree Method
        /// </summary>
        /// <param name="node"></param>
        private void recursivePreOrder(Node node) {
            if (node == null) return;

            preOrderListBox.Items.Add(node.data);
            recursivePreOrder(node.left);
            recursivePreOrder(node.right);
        }

        /// <summary>
        /// Recursivley In-Order Tree Method
        /// </summary>
        /// <param name="node"></param>
        private void recursiveInOrder(Node node) {
            if (node == null) return;

            recursiveInOrder(node.left);
            InOrderListBox.Items.Add(node.data);
            recursiveInOrder(node.right);
        }

        /// <summary>
        /// Recursivley Post-Order Tree Method
        /// </summary>
        /// <param name="node"></param>
        private void recursivePostOrder(Node node) {
            if (node == null) return;

            recursivePostOrder(node.left);
            recursivePostOrder(node.right);
            PostOrderListBox.Items.Add(node.data);
        }

        /// <summary>
        /// Display the tree in the TreeView
        /// </summary>
        private void DisplayTreeInTreeView() {
            treeView1.Nodes.Clear();

            //If it has root - display
            if (tTree.root != null) {
                string rootText = string.Format("Root: {0} ({1})", tTree.root.data, tTree.root.color);
                TreeNode rootNode = treeView1.Nodes.Add(rootText);
                ShowNode(tTree.root, rootNode);
                treeView1.ExpandAll();
            }
        }

        /// <summary>
        /// Method to show the node and its position
        /// </summary>
        /// <param name="node"></param>
        /// <param name="treeNode"></param>
        private void ShowNode(Node node, TreeNode treeNode) {
            if (node.left != null) {
                string text = string.Format("Left: {0} ({1})", node.left.data, node.left.color);

                TreeNode leftNode = treeNode.Nodes.Add(text);
                ShowNode(node.left, leftNode);
            }

            if (node.right != null) {
                string text = string.Format("Right: {0} ({1})", node.right.data, node.right.color);
                TreeNode rightNode = treeNode.Nodes.Add(text);
                ShowNode(node.right, rightNode);
            }
        }

        #endregion methods

        private void label2_Click(object sender, EventArgs e) {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e) {

        }
    }
}
