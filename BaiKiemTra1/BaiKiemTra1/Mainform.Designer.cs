using System;
using System.Drawing;
using System.Windows.Forms;

namespace BaiKiemTra1
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Button btnAddToCart;
        private Button btnRemoveFromCart;
        private Button btnCheckout;
        private Label lblTotal;
        private object listViewProducts;
        private ListView listViewCart;
        private string text;

        public new SizeF AutoScaleDimensions { get; private set; }
        public new AutoScaleMode AutoScaleMode { get; private set; }
        public new Size ClientSize { get; private set; }
        public new object Controls { get; private set; }
        public new string Name { get; private set; }

        public string GetText()
        {
            return text;
        }

        private void SetText(string value)
        {
            text = value;
        }

        public MainForm(string text)
        {
            SetText(text);
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>

        private void InitializeComponent()
        {

        }


        private new void ResumeLayout(bool v)
        {
            throw new NotImplementedException();
        }

        private void btnRemoveFromCart_Click(object sender, EventArgs e) => throw new NotImplementedException();

        private void btnCheckout_Click(object sender, EventArgs e) => throw new NotImplementedException();

        private void btnAddToCart_Click(object sender, EventArgs e) => throw new NotImplementedException();
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(1299, 531);
            this.Name = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion
    }
}

