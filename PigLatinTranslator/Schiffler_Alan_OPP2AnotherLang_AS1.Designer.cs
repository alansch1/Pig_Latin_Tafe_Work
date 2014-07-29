namespace PigLatinTranslator
{
	partial class frmPigLatin
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
			this.lblText = new System.Windows.Forms.Label();
			this.lblText2 = new System.Windows.Forms.Label();
			this.txtEnglish = new System.Windows.Forms.TextBox();
			this.txtLatin = new System.Windows.Forms.TextBox();
			this.btnTranslate = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblText
			// 
			this.lblText.AutoSize = true;
			this.lblText.Location = new System.Drawing.Point(45, 19);
			this.lblText.Name = "lblText";
			this.lblText.Size = new System.Drawing.Size(122, 13);
			this.lblText.TabIndex = 0;
			this.lblText.Text = "Enter English Text Here:";
			// 
			// lblText2
			// 
			this.lblText2.AutoSize = true;
			this.lblText2.Location = new System.Drawing.Point(45, 142);
			this.lblText2.Name = "lblText2";
			this.lblText2.Size = new System.Drawing.Size(106, 13);
			this.lblText2.TabIndex = 1;
			this.lblText2.Text = "Pig Latin Translation:";
			// 
			// txtEnglish
			// 
			this.txtEnglish.Location = new System.Drawing.Point(48, 44);
			this.txtEnglish.Multiline = true;
			this.txtEnglish.Name = "txtEnglish";
			this.txtEnglish.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtEnglish.Size = new System.Drawing.Size(244, 84);
			this.txtEnglish.TabIndex = 1;
			this.txtEnglish.TextChanged += new System.EventHandler(this.txtEnglish_TextChanged);
			// 
			// txtLatin
			// 
			this.txtLatin.Location = new System.Drawing.Point(48, 175);
			this.txtLatin.Multiline = true;
			this.txtLatin.Name = "txtLatin";
			this.txtLatin.ReadOnly = true;
			this.txtLatin.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtLatin.Size = new System.Drawing.Size(244, 84);
			this.txtLatin.TabIndex = 2;
			// 
			// btnTranslate
			// 
			this.btnTranslate.Location = new System.Drawing.Point(48, 282);
			this.btnTranslate.Name = "btnTranslate";
			this.btnTranslate.Size = new System.Drawing.Size(75, 23);
			this.btnTranslate.TabIndex = 3;
			this.btnTranslate.Text = "&Translate";
			this.btnTranslate.UseVisualStyleBackColor = true;
			this.btnTranslate.Click += new System.EventHandler(this.btnTranslate_Click);
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(141, 282);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(75, 23);
			this.btnClear.TabIndex = 4;
			this.btnClear.Text = "&Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// btnExit
			// 
			this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnExit.Location = new System.Drawing.Point(290, 282);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(75, 23);
			this.btnExit.TabIndex = 5;
			this.btnExit.Text = "E&xit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// frmPigLatin
			// 
			this.AcceptButton = this.btnTranslate;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnExit;
			this.ClientSize = new System.Drawing.Size(384, 309);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnTranslate);
			this.Controls.Add(this.txtLatin);
			this.Controls.Add(this.txtEnglish);
			this.Controls.Add(this.lblText2);
			this.Controls.Add(this.lblText);
			this.Name = "frmPigLatin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Pig Latin Translator";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblText;
		private System.Windows.Forms.Label lblText2;
		private System.Windows.Forms.TextBox txtEnglish;
		private System.Windows.Forms.TextBox txtLatin;
		private System.Windows.Forms.Button btnTranslate;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button btnExit;
	}
}

