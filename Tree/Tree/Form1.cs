namespace Tree
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ApplyOptsBtn_Click(object sender, EventArgs e)
        {
            tv.ShowPlusMinus = PlusMinusCB.Checked;
            tv.ShowLines = LinesCB.Checked;
            tv.ShowRootLines = RootLinesCB.Checked;
            tv.CheckBoxes = CheckBoxesCB.Checked;
            tv.LabelEdit = LabelEditCB.Checked;
            tv.HotTracking = HotTrackCB.Checked;
        }


        private void AddNode()
        {
            TreeNode newNode = new TreeNode("[New Node]");
            TreeNode selNode = tv.SelectedNode;
            if (selNode != null)
            {
                selNode.Nodes.Add(newNode);
                tv.SelectedNode.Expand();
            }
            else
            {
                tv.Nodes.Add(newNode);
                tv.SelectedNode = newNode;
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            AddNode();
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            TreeNode selNode = tv.SelectedNode;
            DialogResult result;
            if (selNode != null)
            {
                if (selNode.Nodes.Count > 0)
                {
                    result = MessageBox.Show(
                        "There are branches beneath this node. Delete all?",
                        "Warning!",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
                    if(result == DialogResult.Yes)
                    {
                        tv.SelectedNode.Remove();
                    }
                }
                else
                {
                    tv.SelectedNode.Remove();
                }
            }
        }

        private void ExpandAllBtn_Click(object sender, EventArgs e)
        {
            tv.ExpandAll();
        }

        private void CollapseAllBtn_Click(object sender, EventArgs e)
        {
            tv.CollapseAll();
        }

        private void NewMI_Click(object sender, EventArgs e)
        {
            tv.Nodes.Clear();
        }

        // These variables store the final values
        String s = "";
        int NodeIndex = 0;

        private void TraverseNodes(TreeNode treeNode, int NodeLevel)
        {
            s += treeNode.Text + " [" + NodeIndex + "] at level " + NodeLevel + "\n";
            NodeIndex++;
            NodeLevel++;
            foreach(TreeNode childNode in treeNode.Nodes)
            {
                TraverseNodes(childNode, NodeLevel);
            }
        }

        private void IndexMI_Click(object sender, EventArgs e)
        {
            s = "";
            NodeIndex = 0;
            foreach(TreeNode treeNode in tv.Nodes)
            {
                TraverseNodes(treeNode, 0);
            }
            MessageBox.Show(s);
        }

        private void TestMI_Click(object sender, EventArgs e)
        {
            s = "";
            s += "tv.Nodes.Count= " + tv.Nodes.Count;
            s += "\ntv.SelectedNode.Nodes.Count=" + tv.SelectedNode.Nodes.Count;
            MessageBox.Show(s);
            s = "" + tv.GetNodeCount(true);
            MessageBox.Show(s);
        }
    }
}