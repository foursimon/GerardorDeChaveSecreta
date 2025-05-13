namespace GerardorDeChave
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			TitleLabel = new Label();
			SubTitleLabel = new Label();
			ChaveLabel = new Label();
			BytesBox = new ComboBox();
			ChaveGerada = new Label();
			ChaveTextBox = new TextBox();
			ChaveButton = new Button();
			CopiarButton = new Button();
			panel1 = new Panel();
			label1 = new Label();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// TitleLabel
			// 
			TitleLabel.AutoSize = true;
			TitleLabel.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
			TitleLabel.Location = new Point(80, 7);
			TitleLabel.Name = "TitleLabel";
			TitleLabel.Size = new Size(531, 54);
			TitleLabel.TabIndex = 0;
			TitleLabel.Text = "Gerador de chave aleatória";
			// 
			// SubTitleLabel
			// 
			SubTitleLabel.AutoSize = true;
			SubTitleLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			SubTitleLabel.Location = new Point(70, 61);
			SubTitleLabel.Name = "SubTitleLabel";
			SubTitleLabel.Size = new Size(541, 38);
			SubTitleLabel.TabIndex = 1;
			SubTitleLabel.Text = "Crie uma chave secreta para seus sistemas";
			// 
			// ChaveLabel
			// 
			ChaveLabel.AutoSize = true;
			ChaveLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
			ChaveLabel.Location = new Point(109, 10);
			ChaveLabel.Name = "ChaveLabel";
			ChaveLabel.Size = new Size(208, 31);
			ChaveLabel.TabIndex = 2;
			ChaveLabel.Text = "Tamanho da chave:";
			// 
			// BytesBox
			// 
			BytesBox.AutoCompleteMode = AutoCompleteMode.Append;
			BytesBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
			BytesBox.FormattingEnabled = true;
			BytesBox.Items.AddRange(new object[] { "16", "32", "64" });
			BytesBox.Location = new Point(136, 55);
			BytesBox.Name = "BytesBox";
			BytesBox.Size = new Size(79, 39);
			BytesBox.TabIndex = 3;
			// 
			// ChaveGerada
			// 
			ChaveGerada.AutoSize = true;
			ChaveGerada.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
			ChaveGerada.Location = new Point(131, 112);
			ChaveGerada.Name = "ChaveGerada";
			ChaveGerada.Size = new Size(159, 31);
			ChaveGerada.TabIndex = 4;
			ChaveGerada.Text = "Chave gerada:";
			// 
			// ChaveTextBox
			// 
			ChaveTextBox.BackColor = Color.AliceBlue;
			ChaveTextBox.BorderStyle = BorderStyle.FixedSingle;
			ChaveTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			ChaveTextBox.Location = new Point(80, 157);
			ChaveTextBox.Name = "ChaveTextBox";
			ChaveTextBox.ReadOnly = true;
			ChaveTextBox.Size = new Size(263, 34);
			ChaveTextBox.TabIndex = 5;
			ChaveTextBox.TabStop = false;
			// 
			// ChaveButton
			// 
			ChaveButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			ChaveButton.Location = new Point(80, 213);
			ChaveButton.Name = "ChaveButton";
			ChaveButton.Size = new Size(121, 36);
			ChaveButton.TabIndex = 6;
			ChaveButton.Text = "Criar chave";
			ChaveButton.UseVisualStyleBackColor = true;
			ChaveButton.Click += ChaveButton_Click;
			// 
			// CopiarButton
			// 
			CopiarButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			CopiarButton.Location = new Point(222, 213);
			CopiarButton.Name = "CopiarButton";
			CopiarButton.Size = new Size(121, 36);
			CopiarButton.TabIndex = 7;
			CopiarButton.Text = "Copiar";
			CopiarButton.UseVisualStyleBackColor = true;
			CopiarButton.Click += CopiarButton_Click;
			// 
			// panel1
			// 
			panel1.BackColor = Color.LightCyan;
			panel1.BorderStyle = BorderStyle.FixedSingle;
			panel1.Controls.Add(label1);
			panel1.Controls.Add(BytesBox);
			panel1.Controls.Add(ChaveGerada);
			panel1.Controls.Add(ChaveLabel);
			panel1.Controls.Add(ChaveTextBox);
			panel1.Controls.Add(ChaveButton);
			panel1.Controls.Add(CopiarButton);
			panel1.Location = new Point(121, 120);
			panel1.Name = "panel1";
			panel1.Size = new Size(429, 272);
			panel1.TabIndex = 8;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label1.Location = new Point(221, 58);
			label1.Name = "label1";
			label1.Size = new Size(69, 31);
			label1.TabIndex = 8;
			label1.Text = "bytes";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.PaleTurquoise;
			ClientSize = new Size(667, 450);
			Controls.Add(SubTitleLabel);
			Controls.Add(TitleLabel);
			Controls.Add(panel1);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "Form1";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Gerador de chave";
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Panel panel1;
		private Label TitleLabel;
		private Label SubTitleLabel;
		private Label ChaveLabel;
		private ComboBox BytesBox;
		private Label ChaveGerada;
		private TextBox ChaveTextBox;
		private Button ChaveButton;
		private Button CopiarButton;
		private Label label1;
	}
}
