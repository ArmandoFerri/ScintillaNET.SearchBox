namespace ScintillaNET_FindReplaceDialog
{
    partial class IncrementalSearcher
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Button btnClearHighlights;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IncrementalSearcher));
            this.lblFind = new System.Windows.Forms.Label();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnHighlightAll = new System.Windows.Forms.Button();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            btnClearHighlights = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClearHighlights
            // 
            resources.ApplyResources(btnClearHighlights, "btnClearHighlights");
            btnClearHighlights.FlatAppearance.BorderSize = 0;
            btnClearHighlights.Name = "btnClearHighlights";
            this.toolTip.SetToolTip(btnClearHighlights, resources.GetString("btnClearHighlights.ToolTip"));
            btnClearHighlights.UseVisualStyleBackColor = true;
            btnClearHighlights.Click += new System.EventHandler(this.btnClearHighlights_Click);
            // 
            // lblFind
            // 
            resources.ApplyResources(this.lblFind, "lblFind");
            this.lblFind.Name = "lblFind";
            this.toolTip.SetToolTip(this.lblFind, resources.GetString("lblFind.ToolTip"));
            // 
            // txtFind
            // 
            resources.ApplyResources(this.txtFind, "txtFind");
            this.txtFind.Name = "txtFind";
            this.toolTip.SetToolTip(this.txtFind, resources.GetString("txtFind.ToolTip"));
            this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
            this.txtFind.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFind_KeyDown);
            // 
            // flowLayoutPanel1
            // 
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Controls.Add(this.lblFind);
            this.flowLayoutPanel1.Controls.Add(this.txtFind);
            this.flowLayoutPanel1.Controls.Add(this.btnNext);
            this.flowLayoutPanel1.Controls.Add(this.btnPrevious);
            this.flowLayoutPanel1.Controls.Add(this.btnHighlightAll);
            this.flowLayoutPanel1.Controls.Add(btnClearHighlights);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.toolTip.SetToolTip(this.flowLayoutPanel1, resources.GetString("flowLayoutPanel1.ToolTip"));
            // 
            // btnNext
            // 
            resources.ApplyResources(this.btnNext, "btnNext");
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.Name = "btnNext";
            this.toolTip.SetToolTip(this.btnNext, resources.GetString("btnNext.ToolTip"));
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            resources.ApplyResources(this.btnPrevious, "btnPrevious");
            this.btnPrevious.FlatAppearance.BorderSize = 0;
            this.btnPrevious.Name = "btnPrevious";
            this.toolTip.SetToolTip(this.btnPrevious, resources.GetString("btnPrevious.ToolTip"));
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnHighlightAll
            // 
            resources.ApplyResources(this.btnHighlightAll, "btnHighlightAll");
            this.btnHighlightAll.FlatAppearance.BorderSize = 0;
            this.btnHighlightAll.Name = "btnHighlightAll";
            this.toolTip.SetToolTip(this.btnHighlightAll, resources.GetString("btnHighlightAll.ToolTip"));
            this.btnHighlightAll.UseVisualStyleBackColor = true;
            this.btnHighlightAll.Click += new System.EventHandler(this.btnHighlightAll_Click);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "DownButton.png");
            this.imageList.Images.SetKeyName(1, "Highlighter.png");
            this.imageList.Images.SetKeyName(2, "UpButton.png");
            this.imageList.Images.SetKeyName(3, "XToCloseButton.png");
            // 
            // IncrementalSearcher
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "IncrementalSearcher";
            this.toolTip.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFind;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnHighlightAll;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ImageList imageList;
    }
}
