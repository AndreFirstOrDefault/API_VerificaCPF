using VerificaCPF.Controllers;

namespace API_VerificaCPF_Form
{
    public partial class Form1 : Form
    {
        ValidaCPFController controller = new ValidaCPFController();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonVerificaCPFMascara_Click(object sender, EventArgs e)
        {

            string cpf = maskedTextBoxCPF.Text;
            if (cpf.Length != 14)
            {
                MessageBox.Show("O CPF deve conter 11 números!", "CPF inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            var result = controller.ValidacaoCPFCompleto(cpf);
            string resultado = result.ToString();
            if (resultado == "Microsoft.AspNetCore.Mvc.OkObjectResult")
            {
                MessageBox.Show($"O cpf: {cpf} é válido!", "CPF válido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"O cpf: {cpf} é inválido!", "CPF inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void buttonGerarCPF_Click(object sender, EventArgs e)
        {
            var resultado = controller.GeradorDeCPF();
            maskedTextBoxCPFGerado.Text = resultado;
        }

        private void buttonGerarCPFSemMascara_Click(object sender, EventArgs e)
        {
            var resultado = controller.GeradorDeCPF();
            textBoxCPFGeradoSemMaskara.Text = resultado;
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            maskedTextBoxCPFGerado.Text = "";
            textBoxCPFGeradoSemMaskara.Text = "";
            maskedTextBoxCPF.Text = "";
            listView1.Visible = false;
        }

        private void buttonGeraCPFsMascara_Click(object sender, EventArgs e)
        {
            listView1.Clear();

            var qtde = numericUpDownqQtdeCpfs.Value;
            int qtdeCps = int.Parse(qtde.ToString());

            var listaCps = controller.GeradorDeCpfsComMascaraForms(qtdeCps);

            listView1.Visible = true;
            foreach (var item in listaCps)
            {
                listView1.Items.Add(item);
            }

            listView1.Show();
        }

        private void buttonGeraCPFs_Click(object sender, EventArgs e)
        {
            listView1.Clear();

            var qtde = numericUpDownqQtdeCpfs.Value;
            int qtdeCps = int.Parse(qtde.ToString());

            var listaCps = controller.GeradorDeCpfsForms(qtdeCps);

            listView1.Visible = true;
            foreach (var item in listaCps)
            {
                listView1.Items.Add(item);
            }

            listView1.Show();
        }
    }
}
