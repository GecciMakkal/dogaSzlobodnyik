namespace dogaSzlobodnyik
{
    partial class MainForm : Form
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
            tbxNev = new TextBox();
            btnKoszonj = new Button();
            lblUdvozles = new Label();
            lblPiros = new Label();
            lblZold = new Label();
            lblKek = new Label();
            btnPlusz = new Button();
            btnMinusz = new Button();
            btnSzorzas = new Button();
            btnOsztas = new Button();
            tbxElsoadat = new TextBox();
            label2 = new Label();
            tbxMasodikAdat = new TextBox();
            lblEredmeny = new Label();
            btnSzamolj = new Button();
            btnAlaphelyzet = new Button();
            btnKilepes = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 37);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 0;
            label1.Text = "név:";
            // 
            // tbxNev
            // 
            tbxNev.Location = new Point(74, 37);
            tbxNev.Name = "tbxNev";
            tbxNev.Size = new Size(135, 23);
            tbxNev.TabIndex = 1;
            // 
            // btnKoszonj
            // 
            btnKoszonj.Location = new Point(223, 37);
            btnKoszonj.Name = "btnKoszonj";
            btnKoszonj.Size = new Size(75, 23);
            btnKoszonj.TabIndex = 2;
            btnKoszonj.Text = "Köszönj!";
            btnKoszonj.UseVisualStyleBackColor = true;
            // 
            // lblUdvozles
            // 
            lblUdvozles.BackColor = Color.PaleGoldenrod;
            lblUdvozles.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblUdvozles.Location = new Point(39, 73);
            lblUdvozles.Name = "lblUdvozles";
            lblUdvozles.Size = new Size(259, 34);
            lblUdvozles.TabIndex = 3;
            lblUdvozles.Text = "###UDVOZLES###";
            lblUdvozles.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPiros
            // 
            lblPiros.BackColor = Color.Red;
            lblPiros.Location = new Point(330, 52);
            lblPiros.Name = "lblPiros";
            lblPiros.Size = new Size(40, 40);
            lblPiros.TabIndex = 5;
            lblPiros.Text = "piros";
            // 
            // lblZold
            // 
            lblZold.BackColor = Color.Lime;
            lblZold.Location = new Point(376, 52);
            lblZold.Name = "lblZold";
            lblZold.Size = new Size(40, 40);
            lblZold.TabIndex = 5;
            lblZold.Text = "zöld";
            // 
            // lblKek
            // 
            lblKek.BackColor = Color.Blue;
            lblKek.Location = new Point(422, 52);
            lblKek.Name = "lblKek";
            lblKek.Size = new Size(40, 40);
            lblKek.TabIndex = 5;
            lblKek.Text = "kék";
            // 
            // btnPlusz
            // 
            btnPlusz.BackColor = Color.Silver;
            btnPlusz.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnPlusz.Location = new Point(119, 133);
            btnPlusz.Name = "btnPlusz";
            btnPlusz.Size = new Size(22, 23);
            btnPlusz.TabIndex = 6;
            btnPlusz.Text = "+";
            btnPlusz.UseVisualStyleBackColor = false;
            // 
            // btnMinusz
            // 
            btnMinusz.BackColor = Color.Silver;
            btnMinusz.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnMinusz.Location = new Point(147, 133);
            btnMinusz.Name = "btnMinusz";
            btnMinusz.Size = new Size(22, 23);
            btnMinusz.TabIndex = 6;
            btnMinusz.Text = "-";
            btnMinusz.UseVisualStyleBackColor = false;
            // 
            // btnSzorzas
            // 
            btnSzorzas.BackColor = Color.Silver;
            btnSzorzas.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnSzorzas.Location = new Point(119, 162);
            btnSzorzas.Name = "btnSzorzas";
            btnSzorzas.Size = new Size(22, 23);
            btnSzorzas.TabIndex = 6;
            btnSzorzas.Text = "*";
            btnSzorzas.UseVisualStyleBackColor = false;
            // 
            // btnOsztas
            // 
            btnOsztas.BackColor = Color.Silver;
            btnOsztas.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnOsztas.Location = new Point(147, 162);
            btnOsztas.Name = "btnOsztas";
            btnOsztas.Size = new Size(22, 23);
            btnOsztas.TabIndex = 6;
            btnOsztas.Text = "/";
            btnOsztas.UseVisualStyleBackColor = false;
            // 
            // tbxElsoadat
            // 
            tbxElsoadat.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            tbxElsoadat.Location = new Point(49, 133);
            tbxElsoadat.Name = "tbxElsoadat";
            tbxElsoadat.Size = new Size(55, 43);
            tbxElsoadat.TabIndex = 7;
            tbxElsoadat.TextChanged += tbxElsoadat_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(274, 148);
            label2.Name = "label2";
            label2.Size = new Size(21, 21);
            label2.TabIndex = 8;
            label2.Text = "=";
            // 
            // tbxMasodikAdat
            // 
            tbxMasodikAdat.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            tbxMasodikAdat.Location = new Point(190, 133);
            tbxMasodikAdat.Name = "tbxMasodikAdat";
            tbxMasodikAdat.Size = new Size(55, 43);
            tbxMasodikAdat.TabIndex = 7;
            tbxMasodikAdat.TextChanged += tbxElsoadat_TextChanged;
            // 
            // lblEredmeny
            // 
            lblEredmeny.BackColor = Color.White;
            lblEredmeny.BorderStyle = BorderStyle.FixedSingle;
            lblEredmeny.Location = new Point(316, 140);
            lblEredmeny.Name = "lblEredmeny";
            lblEredmeny.Size = new Size(100, 36);
            lblEredmeny.TabIndex = 9;
            lblEredmeny.Text = "#eredmeny#";
            lblEredmeny.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSzamolj
            // 
            btnSzamolj.Location = new Point(28, 191);
            btnSzamolj.Name = "btnSzamolj";
            btnSzamolj.Size = new Size(469, 23);
            btnSzamolj.TabIndex = 10;
            btnSzamolj.Text = "Számolj!";
            btnSzamolj.UseVisualStyleBackColor = true;
            // 
            // btnAlaphelyzet
            // 
            btnAlaphelyzet.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAlaphelyzet.Location = new Point(274, 268);
            btnAlaphelyzet.Name = "btnAlaphelyzet";
            btnAlaphelyzet.Size = new Size(80, 23);
            btnAlaphelyzet.TabIndex = 11;
            btnAlaphelyzet.Text = "Alaphelyzet";
            btnAlaphelyzet.UseVisualStyleBackColor = true;
            // 
            // btnKilepes
            // 
            btnKilepes.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnKilepes.Location = new Point(382, 268);
            btnKilepes.Name = "btnKilepes";
            btnKilepes.Size = new Size(80, 23);
            btnKilepes.TabIndex = 11;
            btnKilepes.Text = "Kilépés";
            btnKilepes.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 317);
            Controls.Add(btnKilepes);
            Controls.Add(btnAlaphelyzet);
            Controls.Add(btnSzamolj);
            Controls.Add(lblEredmeny);
            Controls.Add(label2);
            Controls.Add(tbxMasodikAdat);
            Controls.Add(tbxElsoadat);
            Controls.Add(btnOsztas);
            Controls.Add(btnSzorzas);
            Controls.Add(btnMinusz);
            Controls.Add(btnPlusz);
            Controls.Add(lblKek);
            Controls.Add(lblZold);
            Controls.Add(lblPiros);
            Controls.Add(lblUdvozles);
            Controls.Add(btnKoszonj);
            Controls.Add(tbxNev);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "MainForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbxNev;
        private Button btnKoszonj;
        private Label lblUdvozles;
        private Label lblPiros;
        private Label lblZold;
        private Label lblKek;
        private Button btnPlusz;
        private Button btnMinusz;
        private Button btnSzorzas;
        private Button btnOsztas;
        private TextBox tbxElsoadat;
        private Label label2;
        private TextBox tbxMasodikAdat;
        private Label lblEredmeny;
        private Button btnSzamolj;
        private Button btnAlaphelyzet;
        private Button btnKilepes;
    }
}