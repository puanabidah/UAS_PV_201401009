/*
 * Created by SharpDevelop.
 * User: LENOVO
 * Date: 25/05/2022
 * Time: 7:04
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace handphone
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.txtKode = new System.Windows.Forms.TextBox();
			this.comboBoxIP = new System.Windows.Forms.ComboBox();
			this.comboBoxWarna = new System.Windows.Forms.ComboBox();
			this.txtHarga = new System.Windows.Forms.TextBox();
			this.txtStok = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.txtCari = new System.Windows.Forms.TextBox();
			this.comboBoxMemori = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.IBox = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Maiandra GD", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(137, 151);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(164, 45);
			this.label1.TabIndex = 0;
			this.label1.Text = "Kode IPhone :";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Maiandra GD", 13.8F);
			this.label2.Location = new System.Drawing.Point(137, 202);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(164, 32);
			this.label2.TabIndex = 1;
			this.label2.Text = "Jenis IPhone :";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Maiandra GD", 13.8F);
			this.label3.Location = new System.Drawing.Point(137, 252);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(212, 35);
			this.label3.TabIndex = 2;
			this.label3.Text = "Memori RAM :";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Maiandra GD", 13.8F);
			this.label4.Location = new System.Drawing.Point(137, 301);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(123, 32);
			this.label4.TabIndex = 3;
			this.label4.Text = "Warna :";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Maiandra GD", 13.8F);
			this.label5.Location = new System.Drawing.Point(137, 349);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 42);
			this.label5.TabIndex = 4;
			this.label5.Text = "Harga :";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Maiandra GD", 13.8F);
			this.label6.Location = new System.Drawing.Point(137, 402);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 5;
			this.label6.Text = "Stok :";
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.dataGridView1.GridColor = System.Drawing.SystemColors.MenuBar;
			this.dataGridView1.Location = new System.Drawing.Point(60, 609);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(883, 207);
			this.dataGridView1.TabIndex = 6;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellContentClick);
			// 
			// txtKode
			// 
			this.txtKode.Font = new System.Drawing.Font("Maiandra GD", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtKode.Location = new System.Drawing.Point(459, 148);
			this.txtKode.Name = "txtKode";
			this.txtKode.ReadOnly = true;
			this.txtKode.Size = new System.Drawing.Size(350, 35);
			this.txtKode.TabIndex = 7;
			// 
			// comboBoxIP
			// 
			this.comboBoxIP.BackColor = System.Drawing.Color.AntiqueWhite;
			this.comboBoxIP.Font = new System.Drawing.Font("Maiandra GD", 13.8F);
			this.comboBoxIP.FormattingEnabled = true;
			this.comboBoxIP.Items.AddRange(new object[] {
									"Apple Iphone 12",
									"Apple Iphone 12 Mini",
									"Apple Iphone 12 Pro",
									"Apple Iphone 12 Pro Max",
									"Apple Iphone 13",
									"Apple Iphone 13 Mini",
									"Apple Iphone 13 Pro",
									"Apple Iphone 13 Pro Max"});
			this.comboBoxIP.Location = new System.Drawing.Point(459, 199);
			this.comboBoxIP.Name = "comboBoxIP";
			this.comboBoxIP.Size = new System.Drawing.Size(350, 35);
			this.comboBoxIP.TabIndex = 1;
			// 
			// comboBoxWarna
			// 
			this.comboBoxWarna.BackColor = System.Drawing.Color.AntiqueWhite;
			this.comboBoxWarna.Font = new System.Drawing.Font("Maiandra GD", 13.8F);
			this.comboBoxWarna.FormattingEnabled = true;
			this.comboBoxWarna.Items.AddRange(new object[] {
									"Black",
									"White",
									"Blue",
									"Green",
									"Purple",
									"(PRODUCT) Red",
									"Pink",
									"Silver",
									"Graphite",
									"Sierra Blue",
									"Gold",
									"Midnight"});
			this.comboBoxWarna.Location = new System.Drawing.Point(459, 298);
			this.comboBoxWarna.Name = "comboBoxWarna";
			this.comboBoxWarna.Size = new System.Drawing.Size(350, 35);
			this.comboBoxWarna.TabIndex = 3;
			// 
			// txtHarga
			// 
			this.txtHarga.BackColor = System.Drawing.Color.AntiqueWhite;
			this.txtHarga.Font = new System.Drawing.Font("Maiandra GD", 13.8F);
			this.txtHarga.Location = new System.Drawing.Point(459, 346);
			this.txtHarga.Name = "txtHarga";
			this.txtHarga.Size = new System.Drawing.Size(350, 35);
			this.txtHarga.TabIndex = 4;
			this.txtHarga.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtHargaKeyPress);
			// 
			// txtStok
			// 
			this.txtStok.BackColor = System.Drawing.Color.AntiqueWhite;
			this.txtStok.Font = new System.Drawing.Font("Maiandra GD", 13.8F);
			this.txtStok.Location = new System.Drawing.Point(459, 399);
			this.txtStok.Name = "txtStok";
			this.txtStok.Size = new System.Drawing.Size(350, 35);
			this.txtStok.TabIndex = 5;
			this.txtStok.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtStokKeyPress);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Ivory;
			this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button1.Font = new System.Drawing.Font("Tw Cen MT Condensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.button1.Location = new System.Drawing.Point(137, 461);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(126, 49);
			this.button1.TabIndex = 17;
			this.button1.Text = "Insert";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Ivory;
			this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button2.Font = new System.Drawing.Font("Tw Cen MT Condensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.button2.Location = new System.Drawing.Point(327, 461);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(127, 48);
			this.button2.TabIndex = 18;
			this.button2.Text = "Update";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.Ivory;
			this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button3.Font = new System.Drawing.Font("Tw Cen MT Condensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.ForeColor = System.Drawing.Color.Red;
			this.button3.Location = new System.Drawing.Point(502, 461);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(123, 49);
			this.button3.TabIndex = 19;
			this.button3.Text = "Delete";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.Ivory;
			this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button4.Font = new System.Drawing.Font("Tw Cen MT Condensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.ForeColor = System.Drawing.Color.Blue;
			this.button4.Location = new System.Drawing.Point(679, 461);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(130, 49);
			this.button4.TabIndex = 20;
			this.button4.Text = "Clear";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// txtCari
			// 
			this.txtCari.Font = new System.Drawing.Font("Maiandra GD", 13.8F);
			this.txtCari.Location = new System.Drawing.Point(372, 549);
			this.txtCari.Name = "txtCari";
			this.txtCari.Size = new System.Drawing.Size(417, 35);
			this.txtCari.TabIndex = 22;
			this.txtCari.TextChanged += new System.EventHandler(this.TxtCariTextChanged);
			// 
			// comboBoxMemori
			// 
			this.comboBoxMemori.BackColor = System.Drawing.Color.AntiqueWhite;
			this.comboBoxMemori.Font = new System.Drawing.Font("Maiandra GD", 13.8F);
			this.comboBoxMemori.FormattingEnabled = true;
			this.comboBoxMemori.Items.AddRange(new object[] {
									"64 GB",
									"128 GB",
									"256 GB",
									"512 GB",
									"1 TB"});
			this.comboBoxMemori.Location = new System.Drawing.Point(459, 249);
			this.comboBoxMemori.Name = "comboBoxMemori";
			this.comboBoxMemori.Size = new System.Drawing.Size(350, 35);
			this.comboBoxMemori.TabIndex = 2;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.Brown;
			this.label7.Location = new System.Drawing.Point(118, 549);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(248, 35);
			this.label7.TabIndex = 24;
			this.label7.Text = "Search Data :";
			// 
			// IBox
			// 
			this.IBox.BackColor = System.Drawing.Color.MintCream;
			this.IBox.Font = new System.Drawing.Font("Goudy Stout", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.IBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.IBox.Location = new System.Drawing.Point(141, 43);
			this.IBox.Name = "IBox";
			this.IBox.Size = new System.Drawing.Size(668, 58);
			this.IBox.TabIndex = 25;
			this.IBox.Text = "IBox";
			this.IBox.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.PaleGoldenrod;
			this.ClientSize = new System.Drawing.Size(1012, 843);
			this.Controls.Add(this.IBox);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.comboBoxMemori);
			this.Controls.Add(this.txtCari);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.txtStok);
			this.Controls.Add(this.txtHarga);
			this.Controls.Add(this.comboBoxWarna);
			this.Controls.Add(this.comboBoxIP);
			this.Controls.Add(this.txtKode);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "handphone";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label IBox;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox comboBoxMemori;
		private System.Windows.Forms.TextBox txtCari;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox txtStok;
		private System.Windows.Forms.TextBox txtHarga;
		private System.Windows.Forms.ComboBox comboBoxWarna;
		private System.Windows.Forms.ComboBox comboBoxIP;
		private System.Windows.Forms.TextBox txtKode;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
