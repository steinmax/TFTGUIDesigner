namespace TFTGUIDesigner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lvControls = new System.Windows.Forms.ListView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSave = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExportCode = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSetTFTLibname = new System.Windows.Forms.ToolStripMenuItem();
            this.canvasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSetCanvasSize = new System.Windows.Forms.ToolStripMenuItem();
            this.lbCurrentSize = new System.Windows.Forms.ToolStripMenuItem();
            this.designerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnCanvas = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.addTestControlRectangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lvControls
            // 
            this.lvControls.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lvControls.HideSelection = false;
            this.lvControls.Location = new System.Drawing.Point(0, 27);
            this.lvControls.Name = "lvControls";
            this.lvControls.Size = new System.Drawing.Size(121, 575);
            this.lvControls.TabIndex = 0;
            this.lvControls.UseCompatibleStateImageBehavior = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.canvasToolStripMenuItem,
            this.designerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(635, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOpen,
            this.btnSave,
            this.btnExportCode,
            this.btnSetTFTLibname});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // btnOpen
            // 
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(161, 22);
            this.btnOpen.Text = "Open";
            // 
            // btnSave
            // 
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(161, 22);
            this.btnSave.Text = "Save";
            // 
            // btnExportCode
            // 
            this.btnExportCode.Name = "btnExportCode";
            this.btnExportCode.Size = new System.Drawing.Size(161, 22);
            this.btnExportCode.Text = "Export Code";
            // 
            // btnSetTFTLibname
            // 
            this.btnSetTFTLibname.Name = "btnSetTFTLibname";
            this.btnSetTFTLibname.Size = new System.Drawing.Size(161, 22);
            this.btnSetTFTLibname.Text = "Set object Name";
            // 
            // canvasToolStripMenuItem
            // 
            this.canvasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSetCanvasSize,
            this.lbCurrentSize,
            this.addTestControlRectangleToolStripMenuItem});
            this.canvasToolStripMenuItem.Name = "canvasToolStripMenuItem";
            this.canvasToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.canvasToolStripMenuItem.Text = "Canvas";
            // 
            // btnSetCanvasSize
            // 
            this.btnSetCanvasSize.Name = "btnSetCanvasSize";
            this.btnSetCanvasSize.Size = new System.Drawing.Size(225, 22);
            this.btnSetCanvasSize.Text = "Set Size";
            // 
            // lbCurrentSize
            // 
            this.lbCurrentSize.Name = "lbCurrentSize";
            this.lbCurrentSize.Size = new System.Drawing.Size(225, 22);
            this.lbCurrentSize.Text = "<current size>";
            // 
            // designerToolStripMenuItem
            // 
            this.designerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.designerToolStripMenuItem.Name = "designerToolStripMenuItem";
            this.designerToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.designerToolStripMenuItem.Text = "Designer";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Menu;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.pnCanvas);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(127, 27);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(354, 508);
            this.flowLayoutPanel1.TabIndex = 2;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // pnCanvas
            // 
            this.pnCanvas.AutoScroll = true;
            this.pnCanvas.BackColor = System.Drawing.SystemColors.InfoText;
            this.pnCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnCanvas.Location = new System.Drawing.Point(10, 10);
            this.pnCanvas.Margin = new System.Windows.Forms.Padding(10, 10, 3, 3);
            this.pnCanvas.Name = "pnCanvas";
            this.pnCanvas.Size = new System.Drawing.Size(320, 480);
            this.pnCanvas.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(487, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(148, 575);
            this.dataGridView1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 550);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "TFT-GUI Desiner 0.1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addTestControlRectangleToolStripMenuItem
            // 
            this.addTestControlRectangleToolStripMenuItem.Name = "addTestControlRectangleToolStripMenuItem";
            this.addTestControlRectangleToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.addTestControlRectangleToolStripMenuItem.Text = "Add Test Control (Rectangle)";
            this.addTestControlRectangleToolStripMenuItem.Click += new System.EventHandler(this.addTestControlRectangleToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 601);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lvControls);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "TFT GUI Designer";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvControls;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnOpen;
        private System.Windows.Forms.ToolStripMenuItem btnSave;
        private System.Windows.Forms.ToolStripMenuItem btnExportCode;
        private System.Windows.Forms.ToolStripMenuItem btnSetTFTLibname;
        private System.Windows.Forms.ToolStripMenuItem designerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem canvasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnSetCanvasSize;
        private System.Windows.Forms.ToolStripMenuItem lbCurrentSize;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnCanvas;
        private System.Windows.Forms.ToolStripMenuItem addTestControlRectangleToolStripMenuItem;
    }
}

