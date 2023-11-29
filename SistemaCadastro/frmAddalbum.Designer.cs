namespace SistemaCadastro
{
    partial class frmAddalbum
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label15 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnConfirmaCadastro = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtaddAlbum = new System.Windows.Forms.TextBox();
            this.dgAlbum = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.btnRemoveAlbum = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAlbum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Green;
            this.panel2.Controls.Add(this.linkLabel1);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(719, 23);
            this.panel2.TabIndex = 18;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(367, 5);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(80, 13);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Lucas Fonseca";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(271, 5);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(96, 13);
            this.label15.TabIndex = 5;
            this.label15.Text = "Desenvolvido por -";
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(45, 37);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(125, 131);
            this.panel3.TabIndex = 2;
            // 
            // BtnConfirmaCadastro
            // 
            this.BtnConfirmaCadastro.BackColor = System.Drawing.Color.Transparent;
            this.BtnConfirmaCadastro.FlatAppearance.BorderSize = 0;
            this.BtnConfirmaCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfirmaCadastro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.BtnConfirmaCadastro.ForeColor = System.Drawing.Color.White;
            this.BtnConfirmaCadastro.Image = global::SistemaCadastro.Properties.Resources._5;
            this.BtnConfirmaCadastro.Location = new System.Drawing.Point(476, 66);
            this.BtnConfirmaCadastro.Name = "BtnConfirmaCadastro";
            this.BtnConfirmaCadastro.Size = new System.Drawing.Size(147, 60);
            this.BtnConfirmaCadastro.TabIndex = 20;
            this.BtnConfirmaCadastro.Text = "&Cadastrar";
            this.BtnConfirmaCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConfirmaCadastro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnConfirmaCadastro.UseVisualStyleBackColor = false;
            this.BtnConfirmaCadastro.Click += new System.EventHandler(this.BtnConfirmaCadastro_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(144, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Album para adicionar:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtaddAlbum
            // 
            this.txtaddAlbum.Location = new System.Drawing.Point(309, 66);
            this.txtaddAlbum.Name = "txtaddAlbum";
            this.txtaddAlbum.Size = new System.Drawing.Size(100, 20);
            this.txtaddAlbum.TabIndex = 22;
            // 
            // dgAlbum
            // 
            this.dgAlbum.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgAlbum.BackgroundColor = System.Drawing.Color.Black;
            this.dgAlbum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAlbum.Location = new System.Drawing.Point(139, 104);
            this.dgAlbum.Margin = new System.Windows.Forms.Padding(2);
            this.dgAlbum.Name = "dgAlbum";
            this.dgAlbum.ReadOnly = true;
            this.dgAlbum.RowHeadersWidth = 51;
            this.dgAlbum.RowTemplate.Height = 29;
            this.dgAlbum.Size = new System.Drawing.Size(270, 112);
            this.dgAlbum.TabIndex = 23;
            this.dgAlbum.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAlbum_CellContentClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::SistemaCadastro.Properties.Resources._6;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(673, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(34, 33);
            this.button2.TabIndex = 24;
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnRemoveAlbum
            // 
            this.btnRemoveAlbum.BackColor = System.Drawing.Color.Black;
            this.btnRemoveAlbum.FlatAppearance.BorderSize = 0;
            this.btnRemoveAlbum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveAlbum.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnRemoveAlbum.ForeColor = System.Drawing.Color.White;
            this.btnRemoveAlbum.Image = global::SistemaCadastro.Properties.Resources._7;
            this.btnRemoveAlbum.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveAlbum.Location = new System.Drawing.Point(476, 132);
            this.btnRemoveAlbum.Name = "btnRemoveAlbum";
            this.btnRemoveAlbum.Size = new System.Drawing.Size(147, 57);
            this.btnRemoveAlbum.TabIndex = 25;
            this.btnRemoveAlbum.Text = "Remover";
            this.btnRemoveAlbum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveAlbum.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRemoveAlbum.UseVisualStyleBackColor = false;
            this.btnRemoveAlbum.Click += new System.EventHandler(this.btnRemoveAlbum_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::SistemaCadastro.Properties.Resources.logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::SistemaCadastro.Properties.Resources.ankh;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(685, 194);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(22, 22);
            this.pictureBox4.TabIndex = 33;
            this.pictureBox4.TabStop = false;
            // 
            // frmAddalbum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(719, 227);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRemoveAlbum);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgAlbum);
            this.Controls.Add(this.txtaddAlbum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnConfirmaCadastro);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddalbum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddalbum";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAlbum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BtnConfirmaCadastro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtaddAlbum;
        private System.Windows.Forms.DataGridView dgAlbum;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnRemoveAlbum;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}