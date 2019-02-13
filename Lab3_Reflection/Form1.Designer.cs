namespace Lab3_Reflection
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openButton = new System.Windows.Forms.Button();
            this.runButton = new System.Windows.Forms.Button();
            this.folderTree = new System.Windows.Forms.TreeView();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.argumentBox = new System.Windows.Forms.TextBox();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(6, 49);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(90, 23);
            this.openButton.TabIndex = 0;
            this.openButton.Text = "Open Folder";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.OpenFolder_Click);
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(713, 218);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(75, 23);
            this.runButton.TabIndex = 1;
            this.runButton.Text = "Run ";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.Run_Click);
            // 
            // folderTree
            // 
            this.folderTree.Location = new System.Drawing.Point(102, 49);
            this.folderTree.Name = "folderTree";
            this.folderTree.Size = new System.Drawing.Size(298, 389);
            this.folderTree.TabIndex = 2;
            this.folderTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.FolderTree_AfterSelect);
            // 
            // descriptionBox
            // 
            this.descriptionBox.Location = new System.Drawing.Point(436, 52);
            this.descriptionBox.Multiline = true;
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(352, 113);
            this.descriptionBox.TabIndex = 3;
            // 
            // argumentBox
            // 
            this.argumentBox.Location = new System.Drawing.Point(436, 221);
            this.argumentBox.Name = "argumentBox";
            this.argumentBox.Size = new System.Drawing.Size(240, 20);
            this.argumentBox.TabIndex = 4;
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(436, 288);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(352, 20);
            this.resultBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "File Structure";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(433, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Class Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(433, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Argument";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(433, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.argumentBox);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.folderTree);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.openButton);
            this.Name = "Form1";
            this.Text = "Lab3_Reflection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.TreeView folderTree;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.TextBox argumentBox;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

