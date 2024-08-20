namespace MasterMind
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_verif = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_verif = new System.Windows.Forms.Button();
            this.btn_color1 = new System.Windows.Forms.Button();
            this.btn_color2 = new System.Windows.Forms.Button();
            this.btn_color3 = new System.Windows.Forms.Button();
            this.btn_color4 = new System.Windows.Forms.Button();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.btn_rdm = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_mal_placer = new System.Windows.Forms.Label();
            this.lbl_vrai = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_victoire = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbx_essais = new System.Windows.Forms.ListBox();
            this.btn_rep = new System.Windows.Forms.Button();
            this.lbl_apresvictoire = new System.Windows.Forms.Label();
            this.pnl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(331, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "MASTERMIND";
            // 
            // lbl_verif
            // 
            this.lbl_verif.AutoSize = true;
            this.lbl_verif.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_verif.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_verif.Location = new System.Drawing.Point(290, 791);
            this.lbl_verif.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_verif.Name = "lbl_verif";
            this.lbl_verif.Size = new System.Drawing.Size(197, 27);
            this.lbl_verif.TabIndex = 1;
            this.lbl_verif.Text = "label réponse";
            this.lbl_verif.Visible = false;
            this.lbl_verif.Click += new System.EventHandler(this.lbl_test_Click);
            // 
            // btn_start
            // 
            this.btn_start.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_start.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_start.Location = new System.Drawing.Point(411, 98);
            this.btn_start.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(125, 30);
            this.btn_start.TabIndex = 6;
            this.btn_start.Text = "START";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_verif
            // 
            this.btn_verif.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_verif.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_verif.Location = new System.Drawing.Point(308, 90);
            this.btn_verif.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_verif.Name = "btn_verif";
            this.btn_verif.Size = new System.Drawing.Size(125, 30);
            this.btn_verif.TabIndex = 8;
            this.btn_verif.Text = "VERIF";
            this.btn_verif.UseVisualStyleBackColor = true;
            this.btn_verif.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_color1
            // 
            this.btn_color1.Location = new System.Drawing.Point(14, 13);
            this.btn_color1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_color1.Name = "btn_color1";
            this.btn_color1.Size = new System.Drawing.Size(118, 26);
            this.btn_color1.TabIndex = 2;
            this.btn_color1.UseVisualStyleBackColor = true;
            this.btn_color1.Click += new System.EventHandler(this.btn_color1_Click);
            // 
            // btn_color2
            // 
            this.btn_color2.Location = new System.Drawing.Point(207, 13);
            this.btn_color2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_color2.Name = "btn_color2";
            this.btn_color2.Size = new System.Drawing.Size(118, 26);
            this.btn_color2.TabIndex = 3;
            this.btn_color2.UseVisualStyleBackColor = true;
            this.btn_color2.Click += new System.EventHandler(this.btn_color2_Click);
            // 
            // btn_color3
            // 
            this.btn_color3.Location = new System.Drawing.Point(405, 13);
            this.btn_color3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_color3.Name = "btn_color3";
            this.btn_color3.Size = new System.Drawing.Size(118, 26);
            this.btn_color3.TabIndex = 4;
            this.btn_color3.UseVisualStyleBackColor = true;
            this.btn_color3.Click += new System.EventHandler(this.btn_color3_Click);
            // 
            // btn_color4
            // 
            this.btn_color4.Location = new System.Drawing.Point(596, 13);
            this.btn_color4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_color4.Name = "btn_color4";
            this.btn_color4.Size = new System.Drawing.Size(118, 26);
            this.btn_color4.TabIndex = 5;
            this.btn_color4.UseVisualStyleBackColor = true;
            this.btn_color4.Click += new System.EventHandler(this.btn_color4_Click);
            // 
            // pnl1
            // 
            this.pnl1.Controls.Add(this.btn_rdm);
            this.pnl1.Controls.Add(this.label4);
            this.pnl1.Controls.Add(this.lbl_mal_placer);
            this.pnl1.Controls.Add(this.lbl_vrai);
            this.pnl1.Controls.Add(this.btn_color4);
            this.pnl1.Controls.Add(this.label3);
            this.pnl1.Controls.Add(this.btn_color3);
            this.pnl1.Controls.Add(this.btn_color2);
            this.pnl1.Controls.Add(this.btn_color1);
            this.pnl1.Controls.Add(this.btn_verif);
            this.pnl1.Location = new System.Drawing.Point(103, 158);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(731, 134);
            this.pnl1.TabIndex = 9;
            this.pnl1.Visible = false;
            // 
            // btn_rdm
            // 
            this.btn_rdm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_rdm.Location = new System.Drawing.Point(14, 94);
            this.btn_rdm.Name = "btn_rdm";
            this.btn_rdm.Size = new System.Drawing.Size(105, 29);
            this.btn_rdm.TabIndex = 17;
            this.btn_rdm.Text = "Aléatoire";
            this.btn_rdm.UseVisualStyleBackColor = true;
            this.btn_rdm.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(405, 60);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 27);
            this.label4.TabIndex = 14;
            this.label4.Text = ": mal placer";
            this.label4.Visible = false;
            // 
            // lbl_mal_placer
            // 
            this.lbl_mal_placer.AutoSize = true;
            this.lbl_mal_placer.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_mal_placer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_mal_placer.Location = new System.Drawing.Point(370, 60);
            this.lbl_mal_placer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_mal_placer.Name = "lbl_mal_placer";
            this.lbl_mal_placer.Size = new System.Drawing.Size(26, 27);
            this.lbl_mal_placer.TabIndex = 15;
            this.lbl_mal_placer.Text = "0";
            this.lbl_mal_placer.Visible = false;
            this.lbl_mal_placer.Click += new System.EventHandler(this.label5_Click);
            // 
            // lbl_vrai
            // 
            this.lbl_vrai.AutoSize = true;
            this.lbl_vrai.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_vrai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_vrai.Location = new System.Drawing.Point(228, 60);
            this.lbl_vrai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_vrai.Name = "lbl_vrai";
            this.lbl_vrai.Size = new System.Drawing.Size(26, 27);
            this.lbl_vrai.TabIndex = 16;
            this.lbl_vrai.Text = "0";
            this.lbl_vrai.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(253, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 27);
            this.label3.TabIndex = 13;
            this.label3.Text = ": vrai";
            this.label3.Visible = false;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbl_victoire
            // 
            this.lbl_victoire.AutoSize = true;
            this.lbl_victoire.Font = new System.Drawing.Font("Stencil", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_victoire.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_victoire.Location = new System.Drawing.Point(290, 298);
            this.lbl_victoire.Name = "lbl_victoire";
            this.lbl_victoire.Size = new System.Drawing.Size(387, 71);
            this.lbl_victoire.TabIndex = 17;
            this.lbl_victoire.Text = "Victoire !!!";
            this.lbl_victoire.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(103, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(287, 33);
            this.label2.TabIndex = 11;
            this.label2.Text = "essai précédent :";
            this.label2.Visible = false;
            // 
            // lbx_essais
            // 
            this.lbx_essais.BackColor = System.Drawing.SystemColors.InfoText;
            this.lbx_essais.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbx_essais.FormattingEnabled = true;
            this.lbx_essais.ItemHeight = 18;
            this.lbx_essais.Location = new System.Drawing.Point(396, 327);
            this.lbx_essais.Name = "lbx_essais";
            this.lbx_essais.Size = new System.Drawing.Size(462, 436);
            this.lbx_essais.TabIndex = 12;
            this.lbx_essais.Visible = false;
            // 
            // btn_rep
            // 
            this.btn_rep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_rep.Location = new System.Drawing.Point(12, 789);
            this.btn_rep.Name = "btn_rep";
            this.btn_rep.Size = new System.Drawing.Size(263, 29);
            this.btn_rep.TabIndex = 18;
            this.btn_rep.Text = "afficher / cacher réponse";
            this.btn_rep.UseVisualStyleBackColor = true;
            this.btn_rep.Visible = false;
            this.btn_rep.Click += new System.EventHandler(this.btn_rep_Click);
            // 
            // lbl_apresvictoire
            // 
            this.lbl_apresvictoire.AutoSize = true;
            this.lbl_apresvictoire.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_apresvictoire.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_apresvictoire.Location = new System.Drawing.Point(310, 369);
            this.lbl_apresvictoire.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_apresvictoire.Name = "lbl_apresvictoire";
            this.lbl_apresvictoire.Size = new System.Drawing.Size(0, 27);
            this.lbl_apresvictoire.TabIndex = 18;
            this.lbl_apresvictoire.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1017, 830);
            this.Controls.Add(this.lbl_apresvictoire);
            this.Controls.Add(this.btn_rep);
            this.Controls.Add(this.lbl_victoire);
            this.Controls.Add(this.lbx_essais);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnl1);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.lbl_verif);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "MasterMind V3 (Axel.B)";
            this.pnl1.ResumeLayout(false);
            this.pnl1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label lbl_verif;
        private Button btn_start;
        private Button btn_verif;
        private Button btn_color1;
        private Button btn_color2;
        private Button btn_color3;
        private Button btn_color4;
        private Panel pnl1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lbl_mal_placer;
        private Label lbl_vrai;
        private ListBox lbx_essais;
        private Label lbl_victoire;
        private Button btn_rep;
        private Button btn_rdm;
        private Label lbl_apresvictoire;
    }
}