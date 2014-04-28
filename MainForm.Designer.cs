/*
 * Created by SharpDevelop.
 * User: Ivette
 * Date: 18/04/2014
 * Time: 10:18 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Aceros8DeJulio
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.txtnom = new System.Windows.Forms.TextBox();
			this.btnentrar = new System.Windows.Forms.Button();
			this.txtcontra = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// txtnom
			// 
			this.txtnom.Location = new System.Drawing.Point(67, 165);
			this.txtnom.Name = "txtnom";
			this.txtnom.Size = new System.Drawing.Size(220, 20);
			this.txtnom.TabIndex = 0;
			this.txtnom.TextChanged += new System.EventHandler(this.TxtnomTextChanged);
			// 
			// btnentrar
			// 
			this.btnentrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnentrar.Location = new System.Drawing.Point(106, 341);
			this.btnentrar.Name = "btnentrar";
			this.btnentrar.Size = new System.Drawing.Size(127, 43);
			this.btnentrar.TabIndex = 1;
			this.btnentrar.Text = "Entrar";
			this.btnentrar.UseVisualStyleBackColor = true;
			this.btnentrar.Click += new System.EventHandler(this.BtnentrarClick);
			// 
			// txtcontra
			// 
			this.txtcontra.Location = new System.Drawing.Point(67, 238);
			this.txtcontra.Name = "txtcontra";
			this.txtcontra.PasswordChar = '*';
			this.txtcontra.Size = new System.Drawing.Size(220, 20);
			this.txtcontra.TabIndex = 2;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(134, 36);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(80, 85);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(67, 139);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 4;
			this.label1.Text = "Cuenta";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(67, 212);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(114, 23);
			this.label2.TabIndex = 5;
			this.label2.Text = "Contraseña";
			// 
			// linkLabel1
			// 
			this.linkLabel1.Location = new System.Drawing.Point(83, 272);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(193, 23);
			this.linkLabel1.TabIndex = 6;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "¿No puedes acceder a tu cuenta?";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.ClientSize = new System.Drawing.Size(344, 420);
			this.Controls.Add(this.linkLabel1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.txtcontra);
			this.Controls.Add(this.btnentrar);
			this.Controls.Add(this.txtnom);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "Iniciar sesión";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox txtcontra;
		private System.Windows.Forms.Button btnentrar;
		private System.Windows.Forms.TextBox txtnom;
	}
}
