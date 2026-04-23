namespace Ders1_Finalcalismasi
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
            label1 = new Label();
            label2 = new Label();
            sayi1txt = new TextBox();
            sayi2txt = new TextBox();
            hesapla = new Button();
            sonuc = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(136, 77);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 0;
            label1.Text = "Sayi 1 :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(136, 137);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 1;
            label2.Text = "Sayi 2 :";
            // 
            // sayi1txt
            // 
            sayi1txt.Location = new Point(256, 77);
            sayi1txt.Name = "sayi1txt";
            sayi1txt.Size = new Size(125, 27);
            sayi1txt.TabIndex = 2;
            // 
            // sayi2txt
            // 
            sayi2txt.Location = new Point(256, 130);
            sayi2txt.Name = "sayi2txt";
            sayi2txt.Size = new Size(125, 27);
            sayi2txt.TabIndex = 3;
            // 
            // hesapla
            // 
            hesapla.Location = new Point(247, 237);
            hesapla.Name = "hesapla";
            hesapla.Size = new Size(94, 29);
            hesapla.TabIndex = 4;
            hesapla.Text = "HESAPLA";
            hesapla.UseVisualStyleBackColor = true;
            hesapla.Click += hesapla_Click;
            // 
            // sonuc
            // 
            sonuc.AutoSize = true;
            sonuc.Location = new Point(136, 193);
            sonuc.Name = "sonuc";
            sonuc.Size = new Size(56, 20);
            sonuc.TabIndex = 6;
            sonuc.Text = "Sonuç :";
            sonuc.Click += sonuc_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(sonuc);
            Controls.Add(hesapla);
            Controls.Add(sayi2txt);
            Controls.Add(sayi1txt);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox sayi1txt;
        private TextBox sayi2txt;
        private Button hesapla;
        private Label sonuc;
    }
}
