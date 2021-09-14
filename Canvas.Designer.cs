namespace MacroHard_Paint
{
    partial class Canvas
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
                this.pen.Dispose();
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
            this.DrawingCanvas = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.lbRed = new System.Windows.Forms.Label();
            this.txtRed = new System.Windows.Forms.TextBox();
            this.txtGreen = new System.Windows.Forms.TextBox();
            this.lbGreen = new System.Windows.Forms.Label();
            this.txtBlue = new System.Windows.Forms.TextBox();
            this.lbBlue = new System.Windows.Forms.Label();
            this.txtOpacity = new System.Windows.Forms.TextBox();
            this.lbOpacity = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDrawingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DrawingCanvas
            // 
            this.DrawingCanvas.Location = new System.Drawing.Point(12, 64);
            this.DrawingCanvas.Name = "DrawingCanvas";
            this.DrawingCanvas.Size = new System.Drawing.Size(1314, 1141);
            this.DrawingCanvas.TabIndex = 0;
            this.DrawingCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            this.DrawingCanvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnMouseClick);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(1336, 1149);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(160, 56);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // lbRed
            // 
            this.lbRed.AutoSize = true;
            this.lbRed.Location = new System.Drawing.Point(1339, 262);
            this.lbRed.Name = "lbRed";
            this.lbRed.Size = new System.Drawing.Size(43, 32);
            this.lbRed.TabIndex = 2;
            this.lbRed.Text = "R:";
            // 
            // txtRed
            // 
            this.txtRed.Location = new System.Drawing.Point(1398, 256);
            this.txtRed.Name = "txtRed";
            this.txtRed.Size = new System.Drawing.Size(98, 38);
            this.txtRed.TabIndex = 3;
            this.txtRed.TextChanged += new System.EventHandler(this.TxtRed_TextChanged);
            // 
            // txtGreen
            // 
            this.txtGreen.Location = new System.Drawing.Point(1398, 379);
            this.txtGreen.Name = "txtGreen";
            this.txtGreen.Size = new System.Drawing.Size(98, 38);
            this.txtGreen.TabIndex = 5;
            this.txtGreen.TextChanged += new System.EventHandler(this.TxtGreen_TextChanged);
            // 
            // lbGreen
            // 
            this.lbGreen.AutoSize = true;
            this.lbGreen.Location = new System.Drawing.Point(1339, 385);
            this.lbGreen.Name = "lbGreen";
            this.lbGreen.Size = new System.Drawing.Size(45, 32);
            this.lbGreen.TabIndex = 4;
            this.lbGreen.Text = "G:";
            // 
            // txtBlue
            // 
            this.txtBlue.Location = new System.Drawing.Point(1398, 499);
            this.txtBlue.Name = "txtBlue";
            this.txtBlue.Size = new System.Drawing.Size(98, 38);
            this.txtBlue.TabIndex = 7;
            this.txtBlue.TextChanged += new System.EventHandler(this.TxtBlue_TextChanged);
            // 
            // lbBlue
            // 
            this.lbBlue.AutoSize = true;
            this.lbBlue.Location = new System.Drawing.Point(1339, 505);
            this.lbBlue.Name = "lbBlue";
            this.lbBlue.Size = new System.Drawing.Size(42, 32);
            this.lbBlue.TabIndex = 6;
            this.lbBlue.Text = "B:";
            // 
            // txtOpacity
            // 
            this.txtOpacity.Location = new System.Drawing.Point(1398, 609);
            this.txtOpacity.Name = "txtOpacity";
            this.txtOpacity.Size = new System.Drawing.Size(98, 38);
            this.txtOpacity.TabIndex = 9;
            this.txtOpacity.TextChanged += new System.EventHandler(this.TxtOpacity_TextChanged);
            // 
            // lbOpacity
            // 
            this.lbOpacity.AutoSize = true;
            this.lbOpacity.Location = new System.Drawing.Point(1339, 615);
            this.lbOpacity.Name = "lbOpacity";
            this.lbOpacity.Size = new System.Drawing.Size(42, 32);
            this.lbOpacity.TabIndex = 8;
            this.lbOpacity.Text = "A:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1509, 52);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveDrawingToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(87, 48);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveDrawingToolStripMenuItem
            // 
            this.saveDrawingToolStripMenuItem.Name = "saveDrawingToolStripMenuItem";
            this.saveDrawingToolStripMenuItem.Size = new System.Drawing.Size(448, 54);
            this.saveDrawingToolStripMenuItem.Text = "Save Drawing";
            this.saveDrawingToolStripMenuItem.Click += new System.EventHandler(this.SaveDrawingToolStripMenuItem_Click);
            // 
            // Canvas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1509, 1217);
            this.Controls.Add(this.txtOpacity);
            this.Controls.Add(this.lbOpacity);
            this.Controls.Add(this.txtBlue);
            this.Controls.Add(this.lbBlue);
            this.Controls.Add(this.txtGreen);
            this.Controls.Add(this.lbGreen);
            this.Controls.Add(this.txtRed);
            this.Controls.Add(this.lbRed);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.DrawingCanvas);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Canvas";
            this.Text = "MHPaint";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel DrawingCanvas;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lbRed;
        private System.Windows.Forms.TextBox txtRed;
        private System.Windows.Forms.TextBox txtGreen;
        private System.Windows.Forms.Label lbGreen;
        private System.Windows.Forms.TextBox txtBlue;
        private System.Windows.Forms.Label lbBlue;
        private System.Windows.Forms.TextBox txtOpacity;
        private System.Windows.Forms.Label lbOpacity;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveDrawingToolStripMenuItem;
    }
}

