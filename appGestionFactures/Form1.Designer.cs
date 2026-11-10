namespace GestiondeFactures
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
            DTG_main = new DataGridView();
            NUM_DATA = new DataGridViewTextBoxColumn();
            MNT = new DataGridViewTextBoxColumn();
            TXT_num = new TextBox();
            TXT_TotalFactureJours = new TextBox();
            TXT_mnt = new TextBox();
            TXT_ListeTotaleFacture = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            BTN_ajt = new Button();
            BTN_sup = new Button();
            BTN_rch = new Button();
            BTN_mdf = new Button();
            BTN_aff = new Button();
            BTN_frm = new Button();
            ((System.ComponentModel.ISupportInitialize)DTG_main).BeginInit();
            SuspendLayout();
            // 
            // DTG_main
            // 
            DTG_main.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DTG_main.Columns.AddRange(new DataGridViewColumn[] { NUM_DATA, MNT });
            DTG_main.BackgroundColor = Color.White;
            DTG_main.BorderStyle = BorderStyle.None;
            DTG_main.EnableHeadersVisualStyles = false;
            DTG_main.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(22, 101, 52);
            DTG_main.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DTG_main.ColumnHeadersHeight = 36;
            DTG_main.DefaultCellStyle.SelectionBackColor = Color.FromArgb(220, 252, 231);
            DTG_main.DefaultCellStyle.SelectionForeColor = Color.FromArgb(20, 83, 45);
            DTG_main.GridColor = Color.FromArgb(226, 232, 240);
            DTG_main.Location = new Point(550, 82);
            DTG_main.Name = "DTG_main";
            DTG_main.Size = new Size(350, 410);
            DTG_main.TabIndex = 0;
            // 
            // NUM_DATA
            // 
            NUM_DATA.DataPropertyName = "NUM_DATA";
            NUM_DATA.HeaderText = "Numero";
            NUM_DATA.Name = "NUM_DATA";
            // 
            // MNT
            // 
            MNT.DataPropertyName = "MNT_DATA";
            MNT.HeaderText = "Montant";
            MNT.Name = "MNT";
            // 
            // TXT_num
            // 
            TXT_num.Font = new Font("Segoe UI", 11F);
            TXT_num.Location = new Point(220, 86);
            TXT_num.Name = "TXT_num";
            TXT_num.Size = new Size(290, 27);
            TXT_num.TabIndex = 1;
            // 
            // TXT_TotalFactureJours
            // 
            TXT_TotalFactureJours.Font = new Font("Segoe UI", 11F);
            TXT_TotalFactureJours.Location = new Point(220, 510);
            TXT_TotalFactureJours.Name = "TXT_TotalFactureJours";
            TXT_TotalFactureJours.Size = new Size(290, 27);
            TXT_TotalFactureJours.TabIndex = 2;
            // 
            // TXT_mnt
            // 
            TXT_mnt.Font = new Font("Segoe UI", 11F);
            TXT_mnt.Location = new Point(220, 128);
            TXT_mnt.Name = "TXT_mnt";
            TXT_mnt.Size = new Size(290, 27);
            TXT_mnt.TabIndex = 3;
            // 
            // TXT_ListeTotaleFacture
            // 
            TXT_ListeTotaleFacture.Font = new Font("Segoe UI", 10F);
            TXT_ListeTotaleFacture.Location = new Point(40, 305);
            TXT_ListeTotaleFacture.Multiline = true;
            TXT_ListeTotaleFacture.Name = "TXT_ListeTotaleFacture";
            TXT_ListeTotaleFacture.ScrollBars = ScrollBars.Vertical;
            TXT_ListeTotaleFacture.Size = new Size(470, 190);
            TXT_ListeTotaleFacture.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.Location = new Point(40, 88);
            label1.Name = "label1";
            label1.Size = new Size(196, 26);
            label1.TabIndex = 5;
            label1.Text = "Numero de facture :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.Location = new Point(40, 130);
            label2.Name = "label2";
            label2.Size = new Size(203, 26);
            label2.TabIndex = 6;
            label2.Text = "Montant de facture :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.Location = new Point(40, 275);
            label3.Name = "label3";
            label3.Size = new Size(180, 20);
            label3.TabIndex = 7;
            label3.Text = "Liste des factures :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label4.Location = new Point(40, 513);
            label4.Name = "label4";
            label4.Size = new Size(160, 20);
            label4.TabIndex = 8;
            label4.Text = "Total des factures :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(22, 101, 52);
            label5.AutoSize = false;
            label5.Location = new Point(0, 18);
            label5.Name = "label5";
            label5.Size = new Size(940, 40);
            label5.TabIndex = 9;
            label5.TextAlign = ContentAlignment.MiddleCenter;
            label5.Text = "Montant Total Des Factures";
            // 
            // BTN_ajt
            // 
            BTN_ajt.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BTN_ajt.BackColor = Color.FromArgb(34, 139, 70);
            BTN_ajt.ForeColor = Color.White;
            BTN_ajt.FlatStyle = FlatStyle.Flat;
            BTN_ajt.FlatAppearance.BorderSize = 0;
            BTN_ajt.Location = new Point(40, 180);
            BTN_ajt.Name = "BTN_ajt";
            BTN_ajt.Size = new Size(110, 36);
            BTN_ajt.TabIndex = 10;
            BTN_ajt.Text = "Ajouter";
            BTN_ajt.UseVisualStyleBackColor = false;
            BTN_ajt.Click += BTN_ajt_Click;
            // 
            // BTN_sup
            // 
            BTN_sup.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BTN_sup.Location = new Point(400, 180);
            BTN_sup.Name = "BTN_sup";
            BTN_sup.Size = new Size(110, 36);
            BTN_sup.TabIndex = 11;
            BTN_sup.Text = "Supprimer";
            BTN_sup.UseVisualStyleBackColor = true;
            BTN_sup.Click += BTN_sup_Click;
            // 
            // BTN_rch
            // 
            BTN_rch.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BTN_rch.Location = new Point(160, 180);
            BTN_rch.Name = "BTN_rch";
            BTN_rch.Size = new Size(110, 36);
            BTN_rch.TabIndex = 12;
            BTN_rch.Text = "Rechercher";
            BTN_rch.UseVisualStyleBackColor = true;
            BTN_rch.Click += BTN_rch_Click;
            // 
            // BTN_mdf
            // 
            BTN_mdf.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BTN_mdf.Location = new Point(280, 180);
            BTN_mdf.Name = "BTN_mdf";
            BTN_mdf.Size = new Size(110, 36);
            BTN_mdf.TabIndex = 13;
            BTN_mdf.Text = "Modifier";
            BTN_mdf.UseVisualStyleBackColor = true;
            BTN_mdf.Click += BTN_mdf_Click;
            // 
            // BTN_aff
            // 
            BTN_aff.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BTN_aff.Location = new Point(40, 225);
            BTN_aff.Name = "BTN_aff";
            BTN_aff.Size = new Size(110, 36);
            BTN_aff.TabIndex = 14;
            BTN_aff.Text = "Afficher";
            BTN_aff.UseVisualStyleBackColor = true;
            BTN_aff.Click += BTN_aff_Click;
            // 
            // BTN_frm
            // 
            BTN_frm.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BTN_frm.Location = new Point(160, 225);
            BTN_frm.Name = "BTN_frm";
            BTN_frm.Size = new Size(110, 36);
            BTN_frm.TabIndex = 15;
            BTN_frm.Text = "Fermer";
            BTN_frm.UseVisualStyleBackColor = true;
            BTN_frm.Click += BTN_frm_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(940, 560);
            Font = new Font("Segoe UI", 10F);
            StartPosition = FormStartPosition.CenterScreen;
            Controls.Add(BTN_frm);
            Controls.Add(BTN_aff);
            Controls.Add(BTN_mdf);
            Controls.Add(BTN_rch);
            Controls.Add(BTN_sup);
            Controls.Add(BTN_ajt);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TXT_ListeTotaleFacture);
            Controls.Add(TXT_mnt);
            Controls.Add(TXT_TotalFactureJours);
            Controls.Add(TXT_num);
            Controls.Add(DTG_main);
            Name = "Form1";
            Text = "Gestion de factures";
            ((System.ComponentModel.ISupportInitialize)DTG_main).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DTG_main;
        private TextBox TXT_num;
        private TextBox TXT_TotalFactureJours;
        private TextBox TXT_mnt;
        private TextBox TXT_ListeTotaleFacture;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button BTN_ajt;
        private Button BTN_sup;
        private Button BTN_rch;
        private Button BTN_mdf;
        private Button BTN_aff;
        private Button BTN_frm;
        private DataGridViewTextBoxColumn NUM_DATA;
        private DataGridViewTextBoxColumn MNT;
    }
}

