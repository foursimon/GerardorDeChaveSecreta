using System.Security.Cryptography;

namespace GerardorDeChave
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void ChaveButton_Click(object sender, EventArgs e)
		{
			int tamanhoDaChave = 0;
			if (BytesBox.Text == "16" || BytesBox.Text == "32" || BytesBox.Text == "64")
			{
				tamanhoDaChave = Convert.ToInt32(BytesBox.Text);
				ChaveTextBox.Text = GerarChave(tamanhoDaChave);
				return;

			}
			MessageBox.Show("O tamanho da chave deve ser 16, 32 ou 64 bytes");
			BytesBox.Focus();
		}

		private static string GerarChave(int tamanho)
		{
			byte[] chave = new byte[tamanho];
			using var rng = RandomNumberGenerator.Create();
			rng.GetBytes(chave);
			return Convert.ToBase64String(chave);
		}

		[STAThread]
		private void CopiarButton_Click(object sender, EventArgs e)
		{
			if (ChaveTextBox.Text == "")
			{
				MessageBox.Show("Não há nada para copiar");
				BytesBox.Focus();
				return;
			}
			string chave = ChaveTextBox.Text;
			Clipboard.SetText(chave);
			MessageBox.Show("Chave copiada para área de transferência");
			BytesBox.Focus();
		}
	}
}
