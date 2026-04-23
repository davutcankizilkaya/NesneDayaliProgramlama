namespace ders1_ornek2_finalcalismasi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            sayigirstxt = new TextBox();
            lblsayi = new Label();
            hesaplabutton = new Button();
            Sonuclbl = new Label();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // sayigirstxt
            // 
            sayigirstxt.Location = new Point(236, 43);
            sayigirstxt.Name = "sayigirstxt";
            sayigirstxt.Size = new Size(125, 27);
            sayigirstxt.TabIndex = 1;
            sayigirstxt.TextChanged += sayigirstxt_TextChanged;
            // 
            // lblsayi
            // 
            lblsayi.AutoSize = true;
            lblsayi.Location = new Point(125, 50);
            lblsayi.Name = "lblsayi";
            lblsayi.Size = new Size(84, 20);
            lblsayi.TabIndex = 2;
            lblsayi.Text = "Sayi Girişi : ";
            lblsayi.Click += lblsayi_Click;
            // 
            // hesaplabutton
            // 
            hesaplabutton.Location = new Point(236, 167);
            hesaplabutton.Name = "hesaplabutton";
            hesaplabutton.Size = new Size(107, 58);
            hesaplabutton.TabIndex = 3;
            hesaplabutton.Text = "Faktöriyel Hesapla";
            hesaplabutton.UseVisualStyleBackColor = true;
            hesaplabutton.Click += hesaplabutton_Click;
            // 
            // Sonuclbl
            // 
            Sonuclbl.AutoSize = true;
            Sonuclbl.Font = new Font("Segoe UI", 12F);
            Sonuclbl.Location = new Point(143, 109);
            Sonuclbl.Name = "Sonuclbl";
            Sonuclbl.Size = new Size(66, 28);
            Sonuclbl.TabIndex = 4;
            Sonuclbl.Text = "Sonuc";
            Sonuclbl.Click += Sonuclbl_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Sonuclbl);
            Controls.Add(hesaplabutton);
            Controls.Add(lblsayi);
            Controls.Add(sayigirstxt);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private TextBox sayigirstxt;
        private Label lblsayi;
        private Button hesaplabutton;
        private Label Sonuclbl;
    }
}
