
namespace WindowsFormsApp1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxIDLokasi = new System.Windows.Forms.TextBox();
            this.textBoxJumlah = new System.Windows.Forms.TextBox();
            this.textBoxNoTelf = new System.Windows.Forms.TextBox();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.btSimpan = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.btHapus = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.dtPemesanan = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtPemesanan)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Reservasi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID Lokasi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Jumlah Pemesanan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "No. Telpon";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nama";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(189, 31);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(267, 22);
            this.textBoxID.TabIndex = 6;
            this.textBoxID.TextChanged += new System.EventHandler(this.textBoxID_TextChanged);
            // 
            // textBoxIDLokasi
            // 
            this.textBoxIDLokasi.Location = new System.Drawing.Point(189, 193);
            this.textBoxIDLokasi.Name = "textBoxIDLokasi";
            this.textBoxIDLokasi.Size = new System.Drawing.Size(267, 22);
            this.textBoxIDLokasi.TabIndex = 7;
            // 
            // textBoxJumlah
            // 
            this.textBoxJumlah.Location = new System.Drawing.Point(189, 153);
            this.textBoxJumlah.Name = "textBoxJumlah";
            this.textBoxJumlah.Size = new System.Drawing.Size(267, 22);
            this.textBoxJumlah.TabIndex = 8;
            // 
            // textBoxNoTelf
            // 
            this.textBoxNoTelf.Location = new System.Drawing.Point(189, 109);
            this.textBoxNoTelf.Name = "textBoxNoTelf";
            this.textBoxNoTelf.Size = new System.Drawing.Size(267, 22);
            this.textBoxNoTelf.TabIndex = 9;
            // 
            // textBoxNama
            // 
            this.textBoxNama.Location = new System.Drawing.Point(189, 69);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(267, 22);
            this.textBoxNama.TabIndex = 10;
            // 
            // btSimpan
            // 
            this.btSimpan.Location = new System.Drawing.Point(496, 63);
            this.btSimpan.Name = "btSimpan";
            this.btSimpan.Size = new System.Drawing.Size(75, 23);
            this.btSimpan.TabIndex = 11;
            this.btSimpan.Text = "Simpan";
            this.btSimpan.UseVisualStyleBackColor = true;
            this.btSimpan.Click += new System.EventHandler(this.btSimpan_Click);
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(496, 196);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(75, 23);
            this.btClear.TabIndex = 12;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btHapus
            // 
            this.btHapus.Location = new System.Drawing.Point(496, 153);
            this.btHapus.Name = "btHapus";
            this.btHapus.Size = new System.Drawing.Size(75, 23);
            this.btHapus.TabIndex = 13;
            this.btHapus.Text = "Hapus";
            this.btHapus.UseVisualStyleBackColor = true;
            this.btHapus.Click += new System.EventHandler(this.btHapus_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(496, 109);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(75, 23);
            this.btUpdate.TabIndex = 14;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // dtPemesanan
            // 
            this.dtPemesanan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtPemesanan.Location = new System.Drawing.Point(16, 243);
            this.dtPemesanan.Name = "dtPemesanan";
            this.dtPemesanan.RowHeadersWidth = 51;
            this.dtPemesanan.RowTemplate.Height = 24;
            this.dtPemesanan.Size = new System.Drawing.Size(555, 150);
            this.dtPemesanan.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 413);
            this.Controls.Add(this.dtPemesanan);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btHapus);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btSimpan);
            this.Controls.Add(this.textBoxNama);
            this.Controls.Add(this.textBoxNoTelf);
            this.Controls.Add(this.textBoxJumlah);
            this.Controls.Add(this.textBoxIDLokasi);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dtPemesanan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxIDLokasi;
        private System.Windows.Forms.TextBox textBoxJumlah;
        private System.Windows.Forms.TextBox textBoxNoTelf;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.Button btSimpan;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btHapus;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.DataGridView dtPemesanan;
    }
}

