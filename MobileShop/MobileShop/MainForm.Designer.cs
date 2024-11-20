using System.Drawing;
using System.Windows.Forms;
using System;

namespace MobileShop
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem sảnPhẩmToolStripMenuItem;
        private ToolStripMenuItem kháchHàngToolStripMenuItem;
        private ToolStripMenuItem đơnHàngToolStripMenuItem;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.menuStrip1 = new MenuStrip();
            this.sảnPhẩmToolStripMenuItem = new ToolStripMenuItem();
            this.kháchHàngToolStripMenuItem = new ToolStripMenuItem();
            this.đơnHàngToolStripMenuItem = new ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();

            // menuStrip1
            this.menuStrip1.Items.AddRange(new ToolStripItem[] {
            this.sảnPhẩmToolStripMenuItem,
            this.kháchHàngToolStripMenuItem,
            this.đơnHàngToolStripMenuItem});
            this.menuStrip1.Location = new Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";

            // sảnPhẩmToolStripMenuItem
            this.sảnPhẩmToolStripMenuItem.Name = "sảnPhẩmToolStripMenuItem";
            this.sảnPhẩmToolStripMenuItem.Size = new Size(72, 20);
            this.sảnPhẩmToolStripMenuItem.Text = "Sản phẩm";
            this.sảnPhẩmToolStripMenuItem.Click += new EventHandler(this.sảnPhẩmToolStripMenuItem_Click);

            // kháchHàngToolStripMenuItem
            this.kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            this.kháchHàngToolStripMenuItem.Size = new Size(82, 20);
            this.kháchHàngToolStripMenuItem.Text = "Khách hàng";
            this.kháchHàngToolStripMenuItem.Click += new EventHandler(this.kháchHàngToolStripMenuItem_Click);

            // đơnHàngToolStripMenuItem
            this.đơnHàngToolStripMenuItem.Name = "đơnHàngToolStripMenuItem";
            this.đơnHàngToolStripMenuItem.Size = new Size(72, 20);
            this.đơnHàngToolStripMenuItem.Text = "Đơn hàng";
            this.đơnHàngToolStripMenuItem.Click += new EventHandler(this.đơnHàngToolStripMenuItem_Click);

            // MainForm
            this.ClientSize = new Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.FormClosing += new FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
