using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Security.Cryptography;
using System.IO;
using System.Text; 

namespace SymmetricAlgorithms
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class SymmetricAlgorithms : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button buttonEncrypt;
		private System.Windows.Forms.TextBox textPlaintext;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox textRecoveredPlaintext;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.TextBox textCiphertext;
		private System.Windows.Forms.Button buttonDecrypt;
		private System.Windows.Forms.RadioButton radioButtonRijndael;
		private System.Windows.Forms.RadioButton radioButtonDES;
		private System.Windows.Forms.RadioButton radioButtonRC2;
		private System.Windows.Forms.GroupBox groupBoxSymmetricAlgorithm;
		private System.Windows.Forms.Button buttonGenKey;
		private System.Windows.Forms.TextBox textBoxKey;
		private System.Windows.Forms.TextBox textBoxIV;
		private System.Windows.Forms.Button buttonGenIV;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.RadioButton radioButtonTripleDES;
		private System.Windows.Forms.TextBox textCipherbytes;
		private System.Windows.Forms.GroupBox groupBoxMode;
		private System.Windows.Forms.RadioButton radioButtonECB;
		private System.Windows.Forms.RadioButton radioButtonCBC;
		private System.Windows.Forms.RadioButton radioButtonCFB;
		private System.Windows.Forms.RadioButton radioButtonOFB;
		private System.Windows.Forms.RadioButton radioButtonCTS;
		private System.Windows.Forms.GroupBox groupBoxPadding;
		private System.Windows.Forms.RadioButton radioButtonPKCS7;
		private System.Windows.Forms.RadioButton radioButtonZeros;
		private System.Windows.Forms.RadioButton radioButtonNone;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public SymmetricAlgorithms()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.textPlaintext = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textRecoveredPlaintext = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textCiphertext = new System.Windows.Forms.TextBox();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.groupBoxSymmetricAlgorithm = new System.Windows.Forms.GroupBox();
            this.radioButtonDES = new System.Windows.Forms.RadioButton();
            this.radioButtonRC2 = new System.Windows.Forms.RadioButton();
            this.radioButtonTripleDES = new System.Windows.Forms.RadioButton();
            this.radioButtonRijndael = new System.Windows.Forms.RadioButton();
            this.buttonGenKey = new System.Windows.Forms.Button();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.textBoxIV = new System.Windows.Forms.TextBox();
            this.buttonGenIV = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textCipherbytes = new System.Windows.Forms.TextBox();
            this.groupBoxMode = new System.Windows.Forms.GroupBox();
            this.radioButtonECB = new System.Windows.Forms.RadioButton();
            this.radioButtonCBC = new System.Windows.Forms.RadioButton();
            this.radioButtonCFB = new System.Windows.Forms.RadioButton();
            this.radioButtonOFB = new System.Windows.Forms.RadioButton();
            this.radioButtonCTS = new System.Windows.Forms.RadioButton();
            this.groupBoxPadding = new System.Windows.Forms.GroupBox();
            this.radioButtonPKCS7 = new System.Windows.Forms.RadioButton();
            this.radioButtonZeros = new System.Windows.Forms.RadioButton();
            this.radioButtonNone = new System.Windows.Forms.RadioButton();
            this.groupBoxSymmetricAlgorithm.SuspendLayout();
            this.groupBoxMode.SuspendLayout();
            this.groupBoxPadding.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Location = new System.Drawing.Point(8, 224);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(75, 23);
            this.buttonEncrypt.TabIndex = 17;
            this.buttonEncrypt.Text = "Encrypt";
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);
            // 
            // textPlaintext
            // 
            this.textPlaintext.Location = new System.Drawing.Point(104, 152);
            this.textPlaintext.Multiline = true;
            this.textPlaintext.Name = "textPlaintext";
            this.textPlaintext.Size = new System.Drawing.Size(512, 48);
            this.textPlaintext.TabIndex = 16;
            this.textPlaintext.TextChanged += new System.EventHandler(this.textPlaintext_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(96, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(528, 72);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Plaintext";
            // 
            // textRecoveredPlaintext
            // 
            this.textRecoveredPlaintext.Location = new System.Drawing.Point(104, 392);
            this.textRecoveredPlaintext.Multiline = true;
            this.textRecoveredPlaintext.Name = "textRecoveredPlaintext";
            this.textRecoveredPlaintext.ReadOnly = true;
            this.textRecoveredPlaintext.Size = new System.Drawing.Size(512, 48);
            this.textRecoveredPlaintext.TabIndex = 21;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(96, 376);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(528, 72);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recovered Plaintext";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(96, 216);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(528, 72);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ciphertext Displayed as Text String";
            // 
            // textCiphertext
            // 
            this.textCiphertext.Location = new System.Drawing.Point(104, 232);
            this.textCiphertext.Multiline = true;
            this.textCiphertext.Name = "textCiphertext";
            this.textCiphertext.ReadOnly = true;
            this.textCiphertext.Size = new System.Drawing.Size(512, 48);
            this.textCiphertext.TabIndex = 18;
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Enabled = false;
            this.buttonDecrypt.Location = new System.Drawing.Point(8, 384);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(75, 23);
            this.buttonDecrypt.TabIndex = 20;
            this.buttonDecrypt.Text = "Decrypt";
            this.buttonDecrypt.Click += new System.EventHandler(this.buttonDecrypt_Click);
            // 
            // groupBoxSymmetricAlgorithm
            // 
            this.groupBoxSymmetricAlgorithm.Controls.Add(this.radioButtonDES);
            this.groupBoxSymmetricAlgorithm.Controls.Add(this.radioButtonRC2);
            this.groupBoxSymmetricAlgorithm.Controls.Add(this.radioButtonTripleDES);
            this.groupBoxSymmetricAlgorithm.Controls.Add(this.radioButtonRijndael);
            this.groupBoxSymmetricAlgorithm.Location = new System.Drawing.Point(8, 8);
            this.groupBoxSymmetricAlgorithm.Name = "groupBoxSymmetricAlgorithm";
            this.groupBoxSymmetricAlgorithm.Size = new System.Drawing.Size(136, 120);
            this.groupBoxSymmetricAlgorithm.TabIndex = 0;
            this.groupBoxSymmetricAlgorithm.TabStop = false;
            this.groupBoxSymmetricAlgorithm.Text = "Symmetric Algorithms";
            // 
            // radioButtonDES
            // 
            this.radioButtonDES.Checked = true;
            this.radioButtonDES.Location = new System.Drawing.Point(16, 16);
            this.radioButtonDES.Name = "radioButtonDES";
            this.radioButtonDES.Size = new System.Drawing.Size(80, 24);
            this.radioButtonDES.TabIndex = 0;
            this.radioButtonDES.TabStop = true;
            this.radioButtonDES.Text = "DES";
            this.radioButtonDES.CheckedChanged += new System.EventHandler(this.radioButtonSA_Changed);
            // 
            // radioButtonRC2
            // 
            this.radioButtonRC2.Location = new System.Drawing.Point(16, 88);
            this.radioButtonRC2.Name = "radioButtonRC2";
            this.radioButtonRC2.Size = new System.Drawing.Size(80, 24);
            this.radioButtonRC2.TabIndex = 3;
            this.radioButtonRC2.Text = "RC2";
            this.radioButtonRC2.CheckedChanged += new System.EventHandler(this.radioButtonSA_Changed);
            // 
            // radioButtonTripleDES
            // 
            this.radioButtonTripleDES.Location = new System.Drawing.Point(16, 40);
            this.radioButtonTripleDES.Name = "radioButtonTripleDES";
            this.radioButtonTripleDES.Size = new System.Drawing.Size(80, 24);
            this.radioButtonTripleDES.TabIndex = 1;
            this.radioButtonTripleDES.Text = "Triple DES";
            this.radioButtonTripleDES.CheckedChanged += new System.EventHandler(this.radioButtonSA_Changed);
            // 
            // radioButtonRijndael
            // 
            this.radioButtonRijndael.Location = new System.Drawing.Point(16, 64);
            this.radioButtonRijndael.Name = "radioButtonRijndael";
            this.radioButtonRijndael.Size = new System.Drawing.Size(80, 24);
            this.radioButtonRijndael.TabIndex = 2;
            this.radioButtonRijndael.Text = "Rijndael";
            this.radioButtonRijndael.CheckedChanged += new System.EventHandler(this.radioButtonSA_Changed);
            // 
            // buttonGenKey
            // 
            this.buttonGenKey.Location = new System.Drawing.Point(152, 8);
            this.buttonGenKey.Name = "buttonGenKey";
            this.buttonGenKey.Size = new System.Drawing.Size(136, 23);
            this.buttonGenKey.TabIndex = 4;
            this.buttonGenKey.Text = "New Random Key";
            this.buttonGenKey.Click += new System.EventHandler(this.buttonGenKey_Click);
            // 
            // textBoxKey
            // 
            this.textBoxKey.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKey.Location = new System.Drawing.Point(296, 8);
            this.textBoxKey.Multiline = true;
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.ReadOnly = true;
            this.textBoxKey.Size = new System.Drawing.Size(328, 40);
            this.textBoxKey.TabIndex = 5;
            // 
            // textBoxIV
            // 
            this.textBoxIV.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIV.Location = new System.Drawing.Point(296, 56);
            this.textBoxIV.Multiline = true;
            this.textBoxIV.Name = "textBoxIV";
            this.textBoxIV.ReadOnly = true;
            this.textBoxIV.Size = new System.Drawing.Size(328, 40);
            this.textBoxIV.TabIndex = 7;
            // 
            // buttonGenIV
            // 
            this.buttonGenIV.Location = new System.Drawing.Point(152, 56);
            this.buttonGenIV.Name = "buttonGenIV";
            this.buttonGenIV.Size = new System.Drawing.Size(136, 23);
            this.buttonGenIV.TabIndex = 6;
            this.buttonGenIV.Text = "New Random Init Vector";
            this.buttonGenIV.Click += new System.EventHandler(this.buttonGenIV_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(96, 296);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(528, 72);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ciphertext Displayed as Byte Array";
            // 
            // textCipherbytes
            // 
            this.textCipherbytes.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCipherbytes.Location = new System.Drawing.Point(104, 312);
            this.textCipherbytes.Multiline = true;
            this.textCipherbytes.Name = "textCipherbytes";
            this.textCipherbytes.ReadOnly = true;
            this.textCipherbytes.Size = new System.Drawing.Size(512, 48);
            this.textCipherbytes.TabIndex = 19;
            // 
            // groupBoxMode
            // 
            this.groupBoxMode.Controls.Add(this.radioButtonECB);
            this.groupBoxMode.Controls.Add(this.radioButtonCBC);
            this.groupBoxMode.Controls.Add(this.radioButtonCFB);
            this.groupBoxMode.Controls.Add(this.radioButtonOFB);
            this.groupBoxMode.Controls.Add(this.radioButtonCTS);
            this.groupBoxMode.Location = new System.Drawing.Point(152, 96);
            this.groupBoxMode.Name = "groupBoxMode";
            this.groupBoxMode.Size = new System.Drawing.Size(256, 40);
            this.groupBoxMode.TabIndex = 8;
            this.groupBoxMode.TabStop = false;
            this.groupBoxMode.Text = "Mode";
            // 
            // radioButtonECB
            // 
            this.radioButtonECB.Checked = true;
            this.radioButtonECB.Location = new System.Drawing.Point(8, 16);
            this.radioButtonECB.Name = "radioButtonECB";
            this.radioButtonECB.Size = new System.Drawing.Size(48, 16);
            this.radioButtonECB.TabIndex = 8;
            this.radioButtonECB.TabStop = true;
            this.radioButtonECB.Text = "ECB";
            this.radioButtonECB.CheckedChanged += new System.EventHandler(this.radioButtonMode_Changed);
            // 
            // radioButtonCBC
            // 
            this.radioButtonCBC.Location = new System.Drawing.Point(56, 16);
            this.radioButtonCBC.Name = "radioButtonCBC";
            this.radioButtonCBC.Size = new System.Drawing.Size(48, 16);
            this.radioButtonCBC.TabIndex = 9;
            this.radioButtonCBC.Text = "CBC";
            this.radioButtonCBC.CheckedChanged += new System.EventHandler(this.radioButtonMode_Changed);
            // 
            // radioButtonCFB
            // 
            this.radioButtonCFB.Location = new System.Drawing.Point(104, 16);
            this.radioButtonCFB.Name = "radioButtonCFB";
            this.radioButtonCFB.Size = new System.Drawing.Size(48, 16);
            this.radioButtonCFB.TabIndex = 10;
            this.radioButtonCFB.Text = "CFB";
            this.radioButtonCFB.CheckedChanged += new System.EventHandler(this.radioButtonMode_Changed);
            // 
            // radioButtonOFB
            // 
            this.radioButtonOFB.Location = new System.Drawing.Point(152, 16);
            this.radioButtonOFB.Name = "radioButtonOFB";
            this.radioButtonOFB.Size = new System.Drawing.Size(48, 16);
            this.radioButtonOFB.TabIndex = 11;
            this.radioButtonOFB.Text = "OFB";
            this.radioButtonOFB.CheckedChanged += new System.EventHandler(this.radioButtonMode_Changed);
            // 
            // radioButtonCTS
            // 
            this.radioButtonCTS.Location = new System.Drawing.Point(200, 16);
            this.radioButtonCTS.Name = "radioButtonCTS";
            this.radioButtonCTS.Size = new System.Drawing.Size(48, 16);
            this.radioButtonCTS.TabIndex = 12;
            this.radioButtonCTS.Text = "CTS";
            this.radioButtonCTS.CheckedChanged += new System.EventHandler(this.radioButtonMode_Changed);
            // 
            // groupBoxPadding
            // 
            this.groupBoxPadding.Controls.Add(this.radioButtonPKCS7);
            this.groupBoxPadding.Controls.Add(this.radioButtonZeros);
            this.groupBoxPadding.Controls.Add(this.radioButtonNone);
            this.groupBoxPadding.Location = new System.Drawing.Point(424, 96);
            this.groupBoxPadding.Name = "groupBoxPadding";
            this.groupBoxPadding.Size = new System.Drawing.Size(200, 40);
            this.groupBoxPadding.TabIndex = 13;
            this.groupBoxPadding.TabStop = false;
            this.groupBoxPadding.Text = "Padding";
            // 
            // radioButtonPKCS7
            // 
            this.radioButtonPKCS7.Checked = true;
            this.radioButtonPKCS7.Location = new System.Drawing.Point(16, 16);
            this.radioButtonPKCS7.Name = "radioButtonPKCS7";
            this.radioButtonPKCS7.Size = new System.Drawing.Size(64, 16);
            this.radioButtonPKCS7.TabIndex = 13;
            this.radioButtonPKCS7.TabStop = true;
            this.radioButtonPKCS7.Text = "PKCS7";
            this.radioButtonPKCS7.Click += new System.EventHandler(this.radioButtonPadding_Changed);
            // 
            // radioButtonZeros
            // 
            this.radioButtonZeros.Location = new System.Drawing.Point(80, 16);
            this.radioButtonZeros.Name = "radioButtonZeros";
            this.radioButtonZeros.Size = new System.Drawing.Size(56, 16);
            this.radioButtonZeros.TabIndex = 14;
            this.radioButtonZeros.Text = "Zeros";
            this.radioButtonZeros.Click += new System.EventHandler(this.radioButtonPadding_Changed);
            // 
            // radioButtonNone
            // 
            this.radioButtonNone.Location = new System.Drawing.Point(136, 16);
            this.radioButtonNone.Name = "radioButtonNone";
            this.radioButtonNone.Size = new System.Drawing.Size(56, 16);
            this.radioButtonNone.TabIndex = 15;
            this.radioButtonNone.Text = "None";
            // 
            // SymmetricAlgorithms
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.textBoxKey);
            this.Controls.Add(this.buttonGenKey);
            this.Controls.Add(this.groupBoxSymmetricAlgorithm);
            this.Controls.Add(this.textPlaintext);
            this.Controls.Add(this.buttonEncrypt);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textRecoveredPlaintext);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.textCiphertext);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.buttonDecrypt);
            this.Controls.Add(this.textBoxIV);
            this.Controls.Add(this.buttonGenIV);
            this.Controls.Add(this.textCipherbytes);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBoxMode);
            this.Controls.Add(this.groupBoxPadding);
            this.Name = "SymmetricAlgorithms";
            this.Text = "Symmetric Algorithms";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxSymmetricAlgorithm.ResumeLayout(false);
            this.groupBoxMode.ResumeLayout(false);
            this.groupBoxPadding.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new SymmetricAlgorithms());
		}

		private void Form1_Load(
			object sender, System.EventArgs e)
		{
			//setup initial key, iv, mode, and padding
			GenIV();
			GenKey();
			EstablishMode();
			EstablishPadding();
		}

		private void buttonEncrypt_Click(
			object sender, System.EventArgs e)
		{
			//do UI stuff
			ClearOutputFields();

			//establish symmetric algorithm
			SymmetricAlgorithm sa = 
				CreateSymmetricAlgorithm();

			//use current key and iv
			sa.Key = Key;
			sa.IV = IV;

			//use current mode and padding
			sa.Mode = Mode;
			sa.Padding = Padding;

			//establish crypto stream
			MemoryStream ms = new MemoryStream();
			CryptoStream cs = new CryptoStream(
				ms,
				sa.CreateEncryptor(),
				CryptoStreamMode.Write);

			//write plaintext bytes to crypto stream
			byte[] plainbytes = 
				Encoding.UTF8.GetBytes(textPlaintext.Text);
			cs.Write(plainbytes, 0, plainbytes.Length);
			cs.Close();
			cipherbytes = ms.ToArray();
			ms.Close();

			//display ciphertext as text string
			textCiphertext.Text = 
				Encoding.UTF8.GetString(cipherbytes);

			//display ciphertext byte array in hex format
			StringBuilder sb = new StringBuilder();
			for (int i=0; i<cipherbytes.Length; i++)
			{
				sb.Append(String.Format(
					"{0:X2} ", cipherbytes[i]));
			}
			textCipherbytes.Text = sb.ToString();

			//do UI stuff
			buttonEncrypt.Enabled = false;
			buttonDecrypt.Enabled = true;
			buttonGenKey.Enabled = false;
			buttonGenIV.Enabled = false;
			radioButtonDES.Enabled = false;
			radioButtonTripleDES.Enabled = false;
			radioButtonRijndael.Enabled = false;
			radioButtonRC2.Enabled = false;
			radioButtonECB.Enabled = false;
			radioButtonCBC.Enabled = false;
			radioButtonCFB.Enabled = false;
			radioButtonOFB.Enabled = false;
			radioButtonCTS.Enabled = false;
			radioButtonPKCS7.Enabled = false;
			radioButtonZeros.Enabled = false;
			radioButtonNone.Enabled = false;
			textPlaintext.Enabled = false;
			buttonDecrypt.Select();
		}

		private void buttonDecrypt_Click(
			object sender, System.EventArgs e)
		{
			//establish symmetric algorithm
			SymmetricAlgorithm sa = 
				CreateSymmetricAlgorithm();

			//use current key and iv
			sa.Key = Key;
			sa.IV = IV;

			//use current mode and padding
			sa.Mode = Mode;
			sa.Padding = Padding;
            
			//establish crypto stream
			MemoryStream ms = new MemoryStream(cipherbytes);
			CryptoStream cs = new CryptoStream(
				ms, 
				sa.CreateDecryptor(),
				CryptoStreamMode.Read);

			//read plaintext bytes from crypto stream
			byte[] plainbytes = 
				new Byte[cipherbytes.Length];
			cs.Read(plainbytes, 0, cipherbytes.Length);
			cs.Close();
			ms.Close();

			//display recovered plaintext
			textRecoveredPlaintext.Text = 
				Encoding.UTF8.GetString(plainbytes);

			//do UI stuff
			buttonDecrypt.Enabled = false;
			buttonEncrypt.Enabled = true;
			buttonGenKey.Enabled = true;
			buttonGenIV.Enabled = true;
			radioButtonDES.Enabled = true;
			radioButtonTripleDES.Enabled = true;
			radioButtonRijndael.Enabled = true;
			radioButtonRC2.Enabled = true;
			radioButtonECB.Enabled = true;
			radioButtonCBC.Enabled = true;
			radioButtonCFB.Enabled = true;
			radioButtonOFB.Enabled = true;
			radioButtonCTS.Enabled = true;
			radioButtonPKCS7.Enabled = true;
			radioButtonZeros.Enabled = true;
			radioButtonNone.Enabled = true;
			textPlaintext.Enabled = true;
			buttonEncrypt.Select();
		}

		private void buttonGenKey_Click(
			object sender, System.EventArgs e)
		{
			GenKey();
		}

		private void GenKey()
		{
			//Generate new random IV
			SymmetricAlgorithm  sa = 
				CreateSymmetricAlgorithm();
			sa.GenerateKey();
			Key = sa.Key;

			//do UI stuff
			UpdateKeyTextBox();
			ClearOutputFields();
		}
		private void buttonGenIV_Click(
			object sender, System.EventArgs e)
		{
			GenIV();
		}

		private void GenIV()
		{
			//Generate new random IV
			SymmetricAlgorithm  sa = 
				CreateSymmetricAlgorithm();
			sa.GenerateIV();
			IV = sa.IV;

			//do UI stuff
			UpdateIVTextBox();
			ClearOutputFields();
		}

		private void radioButtonSA_Changed(
			object sender, System.EventArgs e)
		{
			if (((RadioButton)sender).Checked == true)
			{
				//setup new initial symmetric algorithm
				SymmetricAlgorithm sa = 
					CreateSymmetricAlgorithm();
				Key = sa.Key;
				IV = sa.IV;

				//do UI stuff
				UpdateKeyTextBox();
				UpdateIVTextBox();
				ClearOutputFields();
			}
		}

		private void UpdateKeyTextBox()
		{
			StringBuilder sb = new StringBuilder();
			for (int i=0; i<Key.Length; i++)
			{
				sb.Append(
					String.Format("{0:X2} ", Key[i]));
			}
			textBoxKey.Text = sb.ToString();
		}

		private void UpdateIVTextBox()
		{
			StringBuilder sb = new StringBuilder();
			for (int i=0; i<IV.Length; i++)
			{
				sb.Append(
					String.Format("{0:X2} ", IV[i]));
			}
			textBoxIV.Text = sb.ToString();
		}

		private void textPlaintext_TextChanged(
			object sender, System.EventArgs e)
		{
			ClearOutputFields();
		}
		private void ClearOutputFields()
		{
			textCiphertext.Text = "";
			textCipherbytes.Text = "";
			textRecoveredPlaintext.Text = "";
		}

		SymmetricAlgorithm CreateSymmetricAlgorithm()
		{
			//create new instance of symmetric algorithm
			if (radioButtonRC2.Checked == true)
				return RC2.Create();
			if (radioButtonRijndael.Checked == true)
				return Rijndael.Create();
			if (radioButtonDES.Checked == true)
				return DES.Create();
			if (radioButtonTripleDES.Checked == true)
				return TripleDES.Create();
			return null;
		}

		private void radioButtonMode_Changed(
			object sender, System.EventArgs e)
		{
			EstablishMode();
		}

		void EstablishMode()
		{
			//determine current mode
			if (radioButtonECB.Checked == true)
				Mode = CipherMode.ECB;
			if (radioButtonCBC.Checked == true)
				Mode = CipherMode.CBC;
			if (radioButtonCFB.Checked == true)
				Mode = CipherMode.CFB;
			if (radioButtonOFB.Checked == true)
				Mode = CipherMode.OFB;
			if (radioButtonCTS.Checked == true)
				Mode = CipherMode.CTS;
		}

		private void radioButtonPadding_Changed(
			object sender, System.EventArgs e)
		{
			EstablishPadding();
		}

		void EstablishPadding()
		{
			//determine current padding
			if (radioButtonPKCS7.Checked == true)
				Padding =  PaddingMode.PKCS7;
			if (radioButtonZeros.Checked == true)
				Padding =  PaddingMode.Zeros;
			if (radioButtonNone.Checked == true)
				Padding =  PaddingMode.None;
		}

		//variables communicated from encrypt to decrypt
		byte[] Key;
		byte[] IV;
		CipherMode Mode;
		PaddingMode Padding;
		byte[] cipherbytes;
	}
}
