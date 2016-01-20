namespace Pleb_Paint
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.squarebrushButton = new System.Windows.Forms.Button();
            this.circlebrushButton = new System.Windows.Forms.Button();
            this.largebrushButton = new System.Windows.Forms.Button();
            this.colourpickerButton = new System.Windows.Forms.Button();
            this.saveasButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.clearcanvasButton = new System.Windows.Forms.Button();
            this.currentcolourPanel = new System.Windows.Forms.Panel();
            this.smallbrushButton = new System.Windows.Forms.Button();
            this.mediumbrushButton = new System.Windows.Forms.Button();
            this.colourDialog = new System.Windows.Forms.ColorDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // squarebrushButton
            // 
            this.squarebrushButton.BackColor = System.Drawing.Color.NavajoWhite;
            this.squarebrushButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.squarebrushButton.Location = new System.Drawing.Point(0, -1);
            this.squarebrushButton.Name = "squarebrushButton";
            this.squarebrushButton.Size = new System.Drawing.Size(142, 33);
            this.squarebrushButton.TabIndex = 0;
            this.squarebrushButton.Text = "Square";
            this.squarebrushButton.UseVisualStyleBackColor = false;
            this.squarebrushButton.Click += new System.EventHandler(this.squarebrushButton_Click);
            // 
            // circlebrushButton
            // 
            this.circlebrushButton.BackColor = System.Drawing.Color.NavajoWhite;
            this.circlebrushButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.circlebrushButton.Location = new System.Drawing.Point(142, -1);
            this.circlebrushButton.Name = "circlebrushButton";
            this.circlebrushButton.Size = new System.Drawing.Size(143, 33);
            this.circlebrushButton.TabIndex = 1;
            this.circlebrushButton.Text = "Circle";
            this.circlebrushButton.UseVisualStyleBackColor = false;
            this.circlebrushButton.Click += new System.EventHandler(this.circlebrushButton_Click);
            // 
            // largebrushButton
            // 
            this.largebrushButton.BackColor = System.Drawing.Color.NavajoWhite;
            this.largebrushButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.largebrushButton.Location = new System.Drawing.Point(285, -1);
            this.largebrushButton.Name = "largebrushButton";
            this.largebrushButton.Size = new System.Drawing.Size(79, 33);
            this.largebrushButton.TabIndex = 2;
            this.largebrushButton.Text = "Large Brush";
            this.largebrushButton.UseVisualStyleBackColor = false;
            this.largebrushButton.Click += new System.EventHandler(this.largebrushButton_Click);
            // 
            // colourpickerButton
            // 
            this.colourpickerButton.BackColor = System.Drawing.Color.NavajoWhite;
            this.colourpickerButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.colourpickerButton.Location = new System.Drawing.Point(544, -1);
            this.colourpickerButton.Name = "colourpickerButton";
            this.colourpickerButton.Size = new System.Drawing.Size(86, 33);
            this.colourpickerButton.TabIndex = 3;
            this.colourpickerButton.Text = "Colour:";
            this.colourpickerButton.UseVisualStyleBackColor = false;
            this.colourpickerButton.Click += new System.EventHandler(this.colourpickerButton_Click);
            // 
            // saveasButton
            // 
            this.saveasButton.BackColor = System.Drawing.Color.NavajoWhite;
            this.saveasButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveasButton.Location = new System.Drawing.Point(726, -1);
            this.saveasButton.Name = "saveasButton";
            this.saveasButton.Size = new System.Drawing.Size(108, 33);
            this.saveasButton.TabIndex = 4;
            this.saveasButton.Text = "Save as JPG";
            this.saveasButton.UseVisualStyleBackColor = false;
            this.saveasButton.Click += new System.EventHandler(this.saveasButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BurlyWood;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.clearcanvasButton);
            this.panel1.Controls.Add(this.currentcolourPanel);
            this.panel1.Controls.Add(this.circlebrushButton);
            this.panel1.Controls.Add(this.smallbrushButton);
            this.panel1.Controls.Add(this.mediumbrushButton);
            this.panel1.Controls.Add(this.colourpickerButton);
            this.panel1.Controls.Add(this.saveasButton);
            this.panel1.Controls.Add(this.largebrushButton);
            this.panel1.Controls.Add(this.squarebrushButton);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(835, 42);
            this.panel1.TabIndex = 5;
            // 
            // clearcanvasButton
            // 
            this.clearcanvasButton.BackColor = System.Drawing.Color.NavajoWhite;
            this.clearcanvasButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearcanvasButton.Location = new System.Drawing.Point(630, -1);
            this.clearcanvasButton.Name = "clearcanvasButton";
            this.clearcanvasButton.Size = new System.Drawing.Size(96, 33);
            this.clearcanvasButton.TabIndex = 7;
            this.clearcanvasButton.Text = "Clear Canvas";
            this.clearcanvasButton.UseVisualStyleBackColor = false;
            this.clearcanvasButton.Click += new System.EventHandler(this.clearcanvasButton_Click);
            // 
            // currentcolourPanel
            // 
            this.currentcolourPanel.BackColor = System.Drawing.Color.NavajoWhite;
            this.currentcolourPanel.Location = new System.Drawing.Point(605, 3);
            this.currentcolourPanel.Name = "currentcolourPanel";
            this.currentcolourPanel.Size = new System.Drawing.Size(18, 26);
            this.currentcolourPanel.TabIndex = 0;
            this.currentcolourPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.currentcolourPanel_Paint);
            // 
            // smallbrushButton
            // 
            this.smallbrushButton.BackColor = System.Drawing.Color.NavajoWhite;
            this.smallbrushButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.smallbrushButton.Location = new System.Drawing.Point(454, -1);
            this.smallbrushButton.Name = "smallbrushButton";
            this.smallbrushButton.Size = new System.Drawing.Size(90, 33);
            this.smallbrushButton.TabIndex = 6;
            this.smallbrushButton.Text = "Small Brush";
            this.smallbrushButton.UseVisualStyleBackColor = false;
            this.smallbrushButton.Click += new System.EventHandler(this.smallbrushButton_Click);
            // 
            // mediumbrushButton
            // 
            this.mediumbrushButton.BackColor = System.Drawing.Color.NavajoWhite;
            this.mediumbrushButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mediumbrushButton.Location = new System.Drawing.Point(364, -1);
            this.mediumbrushButton.Name = "mediumbrushButton";
            this.mediumbrushButton.Size = new System.Drawing.Size(90, 33);
            this.mediumbrushButton.TabIndex = 5;
            this.mediumbrushButton.Text = "Medium Brush";
            this.mediumbrushButton.UseVisualStyleBackColor = false;
            this.mediumbrushButton.Click += new System.EventHandler(this.mediumbrushButton_Click);
            // 
            // colourDialog
            // 
            this.colourDialog.AnyColor = true;
            this.colourDialog.Color = System.Drawing.Color.White;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(835, 490);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Pleb Paint";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseUp);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button squarebrushButton;
        private System.Windows.Forms.Button circlebrushButton;
        private System.Windows.Forms.Button largebrushButton;
        private System.Windows.Forms.Button colourpickerButton;
        private System.Windows.Forms.Button saveasButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ColorDialog colourDialog;
        private System.Windows.Forms.Button smallbrushButton;
        private System.Windows.Forms.Button mediumbrushButton;
        private System.Windows.Forms.Panel currentcolourPanel;
        private System.Windows.Forms.Button clearcanvasButton;
    }
}

