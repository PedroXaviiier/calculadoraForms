namespace calculadoraForms
{
    public partial class Form1 : Form
    {
        double numero1 = 0;
        double numero2 = 0;
        int tipoDeConta;
        double resposta;
        public Form1()
        {
            InitializeComponent();
        }



        private void button1Equal_Click(object sender, EventArgs e)
        {
            numero1 = Convert.ToDouble(textBox1Num1.Text);

            numero2 = Convert.ToDouble(textBox2Num2.Text);

            switch (tipoDeConta)
            {
                case 0:
                    resposta = numero1 + numero2;

                    textBox3Resposta.Text = "O resultado é: " + resposta;

                    break;

                case 1:
                    resposta = numero1 - numero2;

                    textBox3Resposta.Text = "O resultado é: " + resposta;

                    break;

                case 2:
                    resposta = numero1 / numero2;

                    if (numero2 == 0)
                        textBox3Resposta.Text = "Indefinido";

                    else
                        textBox3Resposta.Text = "O resultado é: " + resposta;

                    break;

                case 3:
                    resposta = numero1 * numero2;

                    textBox3Resposta.Text = "O resultado é: " + resposta;

                    break;

            }
        }

        private void button2AllClear_Click(object sender, EventArgs e)
        {
            textBox1Num1.Clear();
            textBox2Num2.Clear();
            
        }

        private void checkedListBox1Tipos_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (checkedListBox1Tipos.GetItemChecked(0).Equals(true))
            {
                
                tipoDeConta = 0;
            }

            else if (checkedListBox1Tipos.GetItemChecked(1).Equals(true))
            {
                
                tipoDeConta = 1;
            }

            else if (checkedListBox1Tipos.GetItemChecked(2).Equals(true))
            {
                tipoDeConta = 2;
            }

            else if (checkedListBox1Tipos.GetItemChecked(3).Equals(true))
            {

                tipoDeConta = 3;
            }
        }
    }
}
