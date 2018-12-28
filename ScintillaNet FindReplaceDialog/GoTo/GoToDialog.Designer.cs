namespace ScintillaNET_FindReplaceDialog
{
    partial class GoToDialog
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GoToDialog));
            this.lblCurrentLine = new System.Windows.Forms.Label();
            this.txtCurrentLine = new System.Windows.Forms.TextBox();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtMaxLine = new System.Windows.Forms.TextBox();
            this.lblMaxLine = new System.Windows.Forms.Label();
            this.txtGotoLine = new System.Windows.Forms.TextBox();
            this.lblGotoLine = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCurrentLine
            // 
            resources.ApplyResources(this.lblCurrentLine, "lblCurrentLine");
            this.err.SetError(this.lblCurrentLine, resources.GetString("lblCurrentLine.Error"));
            this.err.SetIconAlignment(this.lblCurrentLine, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblCurrentLine.IconAlignment"))));
            this.err.SetIconPadding(this.lblCurrentLine, ((int)(resources.GetObject("lblCurrentLine.IconPadding"))));
            this.lblCurrentLine.Name = "lblCurrentLine";
            // 
            // txtCurrentLine
            // 
            resources.ApplyResources(this.txtCurrentLine, "txtCurrentLine");
            this.err.SetError(this.txtCurrentLine, resources.GetString("txtCurrentLine.Error"));
            this.err.SetIconAlignment(this.txtCurrentLine, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtCurrentLine.IconAlignment"))));
            this.err.SetIconPadding(this.txtCurrentLine, ((int)(resources.GetObject("txtCurrentLine.IconPadding"))));
            this.txtCurrentLine.Name = "txtCurrentLine";
            this.txtCurrentLine.ReadOnly = true;
            // 
            // err
            // 
            this.err.ContainerControl = this;
            resources.ApplyResources(this.err, "err");
            // 
            // txtMaxLine
            // 
            resources.ApplyResources(this.txtMaxLine, "txtMaxLine");
            this.err.SetError(this.txtMaxLine, resources.GetString("txtMaxLine.Error"));
            this.err.SetIconAlignment(this.txtMaxLine, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtMaxLine.IconAlignment"))));
            this.err.SetIconPadding(this.txtMaxLine, ((int)(resources.GetObject("txtMaxLine.IconPadding"))));
            this.txtMaxLine.Name = "txtMaxLine";
            this.txtMaxLine.ReadOnly = true;
            // 
            // lblMaxLine
            // 
            resources.ApplyResources(this.lblMaxLine, "lblMaxLine");
            this.err.SetError(this.lblMaxLine, resources.GetString("lblMaxLine.Error"));
            this.err.SetIconAlignment(this.lblMaxLine, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblMaxLine.IconAlignment"))));
            this.err.SetIconPadding(this.lblMaxLine, ((int)(resources.GetObject("lblMaxLine.IconPadding"))));
            this.lblMaxLine.Name = "lblMaxLine";
            // 
            // txtGotoLine
            // 
            resources.ApplyResources(this.txtGotoLine, "txtGotoLine");
            this.err.SetError(this.txtGotoLine, resources.GetString("txtGotoLine.Error"));
            this.err.SetIconAlignment(this.txtGotoLine, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtGotoLine.IconAlignment"))));
            this.err.SetIconPadding(this.txtGotoLine, ((int)(resources.GetObject("txtGotoLine.IconPadding"))));
            this.txtGotoLine.Name = "txtGotoLine";
            // 
            // lblGotoLine
            // 
            resources.ApplyResources(this.lblGotoLine, "lblGotoLine");
            this.err.SetError(this.lblGotoLine, resources.GetString("lblGotoLine.Error"));
            this.err.SetIconAlignment(this.lblGotoLine, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblGotoLine.IconAlignment"))));
            this.err.SetIconPadding(this.lblGotoLine, ((int)(resources.GetObject("lblGotoLine.IconPadding"))));
            this.lblGotoLine.Name = "lblGotoLine";
            // 
            // btnOK
            // 
            resources.ApplyResources(this.btnOK, "btnOK");
            this.err.SetError(this.btnOK, resources.GetString("btnOK.Error"));
            this.err.SetIconAlignment(this.btnOK, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnOK.IconAlignment"))));
            this.err.SetIconPadding(this.btnOK, ((int)(resources.GetObject("btnOK.IconPadding"))));
            this.btnOK.Name = "btnOK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.err.SetError(this.btnCancel, resources.GetString("btnCancel.Error"));
            this.err.SetIconAlignment(this.btnCancel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnCancel.IconAlignment"))));
            this.err.SetIconPadding(this.btnCancel, ((int)(resources.GetObject("btnCancel.IconPadding"))));
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // GoToDialog
            // 
            this.AcceptButton = this.btnOK;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtGotoLine);
            this.Controls.Add(this.lblGotoLine);
            this.Controls.Add(this.txtMaxLine);
            this.Controls.Add(this.lblMaxLine);
            this.Controls.Add(this.txtCurrentLine);
            this.Controls.Add(this.lblCurrentLine);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GoToDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Activated += new System.EventHandler(this.GoToDialog_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GoToDialog_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCurrentLine;
        private System.Windows.Forms.TextBox txtCurrentLine;
        private System.Windows.Forms.ErrorProvider err;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtGotoLine;
        private System.Windows.Forms.Label lblGotoLine;
        private System.Windows.Forms.TextBox txtMaxLine;
        private System.Windows.Forms.Label lblMaxLine;
    }
}