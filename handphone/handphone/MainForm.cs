/*
 * Created by SharpDevelop.
 * User: LENOVO
 * Date: 25/05/2022
 * Time: 7:04
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data;
using System.Data.OleDb;
using MySql.Data.MySqlClient;


namespace handphone
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		MySqlConnection co = new MySqlConnection("Server = localhost; Database = iphone; Uid = root;");
		MySqlCommand mycommand = new MySqlCommand();
		MySqlDataAdapter myadapter = new MySqlDataAdapter();
		
		public void ReadData(){
			try{
				mycommand.Connection = co;
				myadapter.SelectCommand = mycommand;
				mycommand.CommandText = "select * from tbl_hp";
				DataSet ds = new DataSet();

				if (myadapter.Fill(ds,"tbl_hp") > 0){
					dataGridView1.DataSource = ds;
					dataGridView1.DataMember = "tbl_hp";
				}
				else {
					MessageBox.Show("Data tabel sedang kosong");
				}
			}
			catch (Exception ex){
				MessageBox.Show("Data tidak dapat dimasukkan");
				MessageBox.Show(ex.ToString());
			}
		}
		 
		
		public void Bersihkan(){
			txtKode.Text="";
			comboBoxIP.Text="";
			comboBoxMemori.Text="";
			comboBoxWarna.Text="";
			txtHarga.Text="0";
			txtStok.Text="0";
			txtCari.Text="";
			ReadData();
			NoOtomatis();
		}
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			co.Open();
			ReadData();
			Bersihkan();
			NoOtomatis();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		
		void Button1Click(object sender, EventArgs e)
		{
			/* INSERT DATA */			
			// Memeriksa apakah kolom text kosong?
			if (txtKode.Text.Trim() == "" || comboBoxIP.Text.Trim() == "" || comboBoxMemori.Text.Trim() == "" || comboBoxWarna.Text.Trim() == "" || txtHarga.Text.Trim() == "" || txtStok.Text.Trim() == "")
			{
				MessageBox.Show("Mohon isikan dahulu kolom-kolom yang tersedia");
			}
			else
			{
				/* insert data */
				try{
					mycommand.Connection=co;
					mycommand.CommandText="insert into tbl_hp values('"+txtKode.Text+"','"+comboBoxIP.Text+"','"+comboBoxMemori.Text+"','"+comboBoxWarna.Text+"','"+txtHarga.Text+"','"+txtStok.Text+"')";
					myadapter.SelectCommand= mycommand;
					if (mycommand.ExecuteNonQuery()==1){
						MessageBox.Show("Data berhasil dimasukan","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
						ReadData();
						Bersihkan();
					}
				}
				catch(Exception ex){
					MessageBox.Show(ex.ToString());
				}
			}
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			/* UPDATE DATA */	
			// Memeriksa apakah kolom text kosong?
			if (txtKode.Text.Trim() == "" || comboBoxIP.Text.Trim() == "" || comboBoxMemori.Text.Trim() == "" || comboBoxWarna.Text.Trim() == "" || txtHarga.Text.Trim() == "" || txtStok.Text.Trim() == "")
			{
				MessageBox.Show("Mohon isikan dahulu kolom-kolom yang tersedia");
			}
			else
			{
				/* update data */
				try{
					mycommand.Connection=co;
					mycommand.CommandText="update tbl_hp set Kode='"+txtKode.Text+"', JenisIphone='"+comboBoxIP.Text+"', KapasitasPenyimpanan='"+comboBoxMemori.Text+"', Warna='"+comboBoxWarna.Text+"', Harga='"+txtHarga.Text+"', Stok='"+txtStok.Text+"' where Kode='"+txtKode.Text+"'";
					myadapter.SelectCommand= mycommand;
					if (mycommand.ExecuteNonQuery()==1){
						MessageBox.Show("Update data berhasil","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
						ReadData();
						Bersihkan();
					}
				}
				catch(Exception ex){
					MessageBox.Show(ex.ToString());
				}
			}
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			/* DELETE DATA */
			// Memeriksa apakah sudah ada data yang terpilih?
			if (txtKode.Text.Trim() == "" && comboBoxIP.Text.Trim() == "" && comboBoxMemori.Text.Trim() == "" && comboBoxWarna.Text.Trim() == "" && txtHarga.Text.Trim() == "" && txtStok.Text.Trim() == "")
			{
				MessageBox.Show("Belum ada data yang terpilih");
			}
			
			else if (MessageBox.Show(comboBoxIP.Text + ", Yakin ingin dihapus?", "Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				
				/* hapus data */
				try {
					mycommand.Connection=co;
					mycommand.CommandText="delete from tbl_hp where Kode='"+txtKode.Text+"'";
					myadapter.SelectCommand = mycommand;
					if (mycommand.ExecuteNonQuery()==1) {
						MessageBox.Show("Data berhasil dihapus");
						ReadData();
						Bersihkan();
					}
				}
				catch(Exception ex) {
					MessageBox.Show(ex.ToString());
				}
			}
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			Bersihkan();
		}
		
		public void CariData(){
			try{
				mycommand.Connection = co;
				myadapter.SelectCommand = mycommand;
				mycommand.CommandText = "select * from tbl_hp where Kode like '%"+txtCari.Text+"%' or JenisIphone like '%"+txtCari.Text+"%' ";
				DataSet ds = new DataSet();

				if (myadapter.Fill(ds,"tbl_hp") > 0){
					dataGridView1.DataSource = ds;
					dataGridView1.DataMember = "tbl_hp";
				}
				else {
					MessageBox.Show("Data tidak dapat ditemukan");
				}
			}
			catch (Exception ex){
				MessageBox.Show("Data tidak dapat dimasukkan");
				MessageBox.Show(ex.ToString());
			}
		} 
	
		void NoOtomatis()
		{
			long hitung;
			string urutan;
			mycommand.Connection=co;
			mycommand.CommandText="select Kode from tbl_hp where Kode in(select max(Kode) from tbl_hp) order by Kode desc";
			myadapter.SelectCommand = mycommand;
			MySqlDataReader reader1;
			reader1 = mycommand.ExecuteReader();
			reader1.Read();
			if(reader1.HasRows)
			{
				hitung = Convert.ToInt64(reader1[0].ToString().Substring(reader1["Kode"].ToString().Length - 3, 3))+1;
				string kodeurutan = "000"+hitung;
				urutan = "IP"+kodeurutan.Substring(kodeurutan.Length - 3,3);
			}
			else
			{
				urutan = "IP001";
			}
			reader1.Close();
			txtKode.Text = urutan;
		}
		
	
		
		void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try{
				txtKode.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
				comboBoxIP.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
				comboBoxMemori.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
				comboBoxWarna.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
				txtHarga.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
				txtStok.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
			}
			catch(Exception ex){
				MessageBox.Show(ex.ToString());
			}
		}
	
		void TxtCariTextChanged(object sender, EventArgs e)
		{
			CariData();
		}
		
		void TxtHargaKeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar)&& e.KeyChar != (char) Keys.Back;
		}
		
		void TxtStokKeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar)&& e.KeyChar != (char) Keys.Back;
		}
	}
}
