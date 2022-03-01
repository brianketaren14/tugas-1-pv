/*
 * Created by SharpDevelop.
 * User: User
 * Date: 15/12/2021
 * Time: 11:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Kalkulator
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
			this.txtAngka1 = new System.Windows.Forms.TextBox();
			this.txtAngka2 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.lblHasil = new System.Windows.Forms.Label();
			this.btnKali = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnBagi = new System.Windows.Forms.Button();
			this.btnTambah = new System.Windows.Forms.Button();
			this.btnKurang = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.riwayatKalkulator = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Location = new System.Drawing.Point(39, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Angka 1";
			this.label1.Click += new System.EventHandler(this.Label1Click);
			// 
			// label2
			// 
			this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label2.Location = new System.Drawing.Point(39, 62);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Angka 2";
			this.label2.Click += new System.EventHandler(this.Label2Click);
			// 
			// txtAngka1
			// 
			this.txtAngka1.Location = new System.Drawing.Point(96, 30);
			this.txtAngka1.Name = "txtAngka1";
			this.txtAngka1.Size = new System.Drawing.Size(214, 20);
			this.txtAngka1.TabIndex = 2;
			// 
			// txtAngka2
			// 
			this.txtAngka2.Location = new System.Drawing.Point(96, 59);
			this.txtAngka2.Name = "txtAngka2";
			this.txtAngka2.Size = new System.Drawing.Size(214, 20);
			this.txtAngka2.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label3.Location = new System.Drawing.Point(39, 85);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(59, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "Hasil";
			// 
			// lblHasil
			// 
			this.lblHasil.BackColor = System.Drawing.SystemColors.Window;
			this.lblHasil.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblHasil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblHasil.ForeColor = System.Drawing.SystemColors.WindowText;
			this.lblHasil.Location = new System.Drawing.Point(96, 85);
			this.lblHasil.Name = "lblHasil";
			this.lblHasil.Size = new System.Drawing.Size(214, 23);
			this.lblHasil.TabIndex = 20;
			this.lblHasil.Click += new System.EventHandler(this.LblHasilClick);
			// 
			// btnKali
			// 
			this.btnKali.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnKali.Location = new System.Drawing.Point(96, 180);
			this.btnKali.Name = "btnKali";
			this.btnKali.Size = new System.Drawing.Size(62, 48);
			this.btnKali.TabIndex = 8;
			this.btnKali.Text = "*";
			this.btnKali.UseVisualStyleBackColor = true;
			this.btnKali.Click += new System.EventHandler(this.BtnKaliClick);
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(239, 126);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(71, 102);
			this.btnClear.TabIndex = 10;
			this.btnClear.Text = "C";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.BtnClearClick);
			// 
			// btnBagi
			// 
			this.btnBagi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBagi.Location = new System.Drawing.Point(171, 180);
			this.btnBagi.Name = "btnBagi";
			this.btnBagi.Size = new System.Drawing.Size(62, 48);
			this.btnBagi.TabIndex = 11;
			this.btnBagi.Text = "/";
			this.btnBagi.UseVisualStyleBackColor = true;
			this.btnBagi.Click += new System.EventHandler(this.BtnBagiClick);
			// 
			// btnTambah
			// 
			this.btnTambah.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTambah.Location = new System.Drawing.Point(96, 126);
			this.btnTambah.Name = "btnTambah";
			this.btnTambah.Size = new System.Drawing.Size(62, 48);
			this.btnTambah.TabIndex = 12;
			this.btnTambah.Text = "+";
			this.btnTambah.UseVisualStyleBackColor = true;
			this.btnTambah.Click += new System.EventHandler(this.Button2Click);
			// 
			// btnKurang
			// 
			this.btnKurang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnKurang.Location = new System.Drawing.Point(171, 126);
			this.btnKurang.Name = "btnKurang";
			this.btnKurang.Size = new System.Drawing.Size(62, 48);
			this.btnKurang.TabIndex = 13;
			this.btnKurang.Text = "-";
			this.btnKurang.UseVisualStyleBackColor = true;
			this.btnKurang.Click += new System.EventHandler(this.BtnKurangClick);
			// 
			// label4
			// 
			this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label4.Location = new System.Drawing.Point(369, 27);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 14;
			this.label4.Text = "Riwayat Kalkulator";
			this.label4.Click += new System.EventHandler(this.Label4Click);
			// 
			// riwayatKalkulator
			// 
			this.riwayatKalkulator.FormattingEnabled = true;
			this.riwayatKalkulator.Location = new System.Drawing.Point(369, 53);
			this.riwayatKalkulator.Name = "riwayatKalkulator";
			this.riwayatKalkulator.Size = new System.Drawing.Size(272, 173);
			this.riwayatKalkulator.TabIndex = 15;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.WindowFrame;
			this.ClientSize = new System.Drawing.Size(668, 294);
			this.Controls.Add(this.riwayatKalkulator);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnKurang);
			this.Controls.Add(this.btnTambah);
			this.Controls.Add(this.btnBagi);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnKali);
			this.Controls.Add(this.lblHasil);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtAngka2);
			this.Controls.Add(this.txtAngka1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "Kalkulator Sederhana";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ListBox riwayatKalkulator;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnKurang;
		private System.Windows.Forms.Button btnTambah;
		private System.Windows.Forms.Button btnBagi;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button btnKali;
		private System.Windows.Forms.Label lblHasil;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtAngka2;
		private System.Windows.Forms.TextBox txtAngka1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		
		void LblHasilClick(object sender, System.EventArgs e)
		{
			
		}
		
		void Label4Click(object sender, System.EventArgs e)
		{
			
		}
	}
}
