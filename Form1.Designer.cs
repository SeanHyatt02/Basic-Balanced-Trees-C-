namespace HyattBasicTrees {
    partial class BasicTrees {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            label1 = new Label();
            fileNameTextBox = new TextBox();
            groupBox1 = new GroupBox();
            btnBrowse = new Button();
            btnLoad = new Button();
            preOrderListBox = new ListBox();
            InOrderListBox = new ListBox();
            PostOrderListBox = new ListBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnClear = new Button();
            btnPreOrder = new Button();
            btnInOrder = new Button();
            btnPostOrder = new Button();
            treeView1 = new TreeView();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 18);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 0;
            label1.Text = "File:";
            // 
            // fileNameTextBox
            // 
            fileNameTextBox.Location = new Point(63, 15);
            fileNameTextBox.Name = "fileNameTextBox";
            fileNameTextBox.Size = new Size(292, 23);
            fileNameTextBox.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(treeView1);
            groupBox1.Location = new Point(12, 44);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(594, 241);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tree";
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(361, 14);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(75, 23);
            btnBrowse.TabIndex = 3;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(442, 14);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(75, 23);
            btnLoad.TabIndex = 4;
            btnLoad.Text = "Load Data";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // preOrderListBox
            // 
            preOrderListBox.FormattingEnabled = true;
            preOrderListBox.ItemHeight = 15;
            preOrderListBox.Location = new Point(12, 313);
            preOrderListBox.Name = "preOrderListBox";
            preOrderListBox.Size = new Size(183, 154);
            preOrderListBox.TabIndex = 5;
            // 
            // InOrderListBox
            // 
            InOrderListBox.FormattingEnabled = true;
            InOrderListBox.ItemHeight = 15;
            InOrderListBox.Location = new Point(220, 313);
            InOrderListBox.Name = "InOrderListBox";
            InOrderListBox.Size = new Size(195, 154);
            InOrderListBox.TabIndex = 6;
            // 
            // PostOrderListBox
            // 
            PostOrderListBox.FormattingEnabled = true;
            PostOrderListBox.ItemHeight = 15;
            PostOrderListBox.Location = new Point(433, 313);
            PostOrderListBox.Name = "PostOrderListBox";
            PostOrderListBox.Size = new Size(173, 154);
            PostOrderListBox.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 295);
            label2.Name = "label2";
            label2.Size = new Size(102, 15);
            label2.TabIndex = 8;
            label2.Text = "PreOrder Traversal";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(220, 295);
            label3.Name = "label3";
            label3.Size = new Size(95, 15);
            label3.TabIndex = 9;
            label3.Text = "InOrder Traversal";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(422, 295);
            label4.Name = "label4";
            label4.Size = new Size(108, 15);
            label4.TabIndex = 10;
            label4.Text = "PostOrder Traversal";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(523, 15);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 11;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnPreOrder
            // 
            btnPreOrder.Location = new Point(120, 291);
            btnPreOrder.Name = "btnPreOrder";
            btnPreOrder.Size = new Size(75, 23);
            btnPreOrder.TabIndex = 12;
            btnPreOrder.Text = "Go";
            btnPreOrder.UseVisualStyleBackColor = true;
            btnPreOrder.Click += btnPreOrder_Click;
            // 
            // btnInOrder
            // 
            btnInOrder.Location = new Point(321, 291);
            btnInOrder.Name = "btnInOrder";
            btnInOrder.Size = new Size(75, 23);
            btnInOrder.TabIndex = 13;
            btnInOrder.Text = "Go";
            btnInOrder.UseVisualStyleBackColor = true;
            btnInOrder.Click += btnInOrder_Click;
            // 
            // btnPostOrder
            // 
            btnPostOrder.Location = new Point(536, 291);
            btnPostOrder.Name = "btnPostOrder";
            btnPostOrder.Size = new Size(75, 23);
            btnPostOrder.TabIndex = 14;
            btnPostOrder.Text = "Go";
            btnPostOrder.UseVisualStyleBackColor = true;
            btnPostOrder.Click += btnPostOrder_Click;
            // 
            // treeView1
            // 
            treeView1.Location = new Point(7, 15);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(581, 220);
            treeView1.TabIndex = 0;
            // 
            // BasicTrees
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(618, 481);
            Controls.Add(btnPostOrder);
            Controls.Add(btnInOrder);
            Controls.Add(btnPreOrder);
            Controls.Add(btnClear);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(PostOrderListBox);
            Controls.Add(InOrderListBox);
            Controls.Add(preOrderListBox);
            Controls.Add(btnLoad);
            Controls.Add(btnBrowse);
            Controls.Add(groupBox1);
            Controls.Add(fileNameTextBox);
            Controls.Add(label1);
            Name = "BasicTrees";
            Text = "Basic Trees";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox fileNameTextBox;
        private GroupBox groupBox1;
        private Button btnBrowse;
        private Button btnLoad;
        private ListBox preOrderListBox;
        private ListBox InOrderListBox;
        private ListBox PostOrderListBox;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnClear;
        private Button btnPreOrder;
        private Button btnInOrder;
        private Button btnPostOrder;
        private TreeView treeView1;
    }
}
