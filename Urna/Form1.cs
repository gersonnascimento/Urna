using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Urna
{
    public partial class Form1 : Form
    {
        int contaTempo = 180, contaFim = 2;
        double pRussomano, pHaddad, pDoria, pErundina, pMarta, pBrancoNulo;
        int voto = 0;//voto digitado na urna pelo eleitor.
        int total_votos = 0;//total de votos para calcular a porcentagem para os candidatos.
        int[] votos_de_cada = new int[7];
        int vencedor; //índice do vencedor [i]
        
        /*votos_de_cada:
        [0] Celso Russomano
        [1] Fernando Haddad
        [2] João Doria
        [3] Luiza Erundina
        [4] Marta Suplicy
        [5] Votos Nulos
        [6] Votos em branco
            */

        public Form1()
        {
            InitializeComponent();
            
        }
        public void habilitabtn()//habilita os botões do teclado
        {
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;
            btn0.Enabled = true;
            btnConfirma.Enabled = true;
            btnCorrige.Enabled = true;
            btnBranco.Enabled = true;
        }
        public void desabilitabtn()//desabilita os botões do teclado
        {
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
            btn7.Enabled = false;
            btn8.Enabled = false;
            btn9.Enabled = false;
            btn0.Enabled = false;
            btnConfirma.Enabled = false;
            btnCorrige.Enabled = false;
            btnBranco.Enabled = false;
        }
  
        public void habilitaNum()//Habilitar apenas os números
        {
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;
            btn0.Enabled = true;
        }

        public void desabilitaNum()//Desabilitar apenas os números(para o usuario não digitar mais de dois caracteres.
        {
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
            btn7.Enabled = false;
            btn8.Enabled = false;
            btn9.Enabled = false;
            btn0.Enabled = false;
        }


        private void button5_Click(object sender, EventArgs e)
        {
            System.Console.Beep(750, 100);
            painelNum.Text += "2";
            if (painelNum.Text.Length == 2)
            {
                btnConfirma.Enabled = true;
                voto = Convert.ToInt16(painelNum.Text);
                this.desabilitaNum();

                switch (voto)
                {
                    case 45:
                        painelFoto.Image = Properties.Resources.joao_doria_c;
                        break;

                    case 13:
                        painelFoto.Image = Properties.Resources.fernando_haddad_c;
                        break;

                    case 10:
                        painelFoto.Image = Properties.Resources.celso_russomanno_c;
                        break;

                    case 15:
                        painelFoto.Image = Properties.Resources.marta_suplicy_c;
                        break;
                    case 50:
                        painelFoto.Image = Properties.Resources.luiza_erundina_c;
                        break;
                    default:
                        painelFoto.Image = Properties.Resources.nulo;
                        break;

                }
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            System.Console.Beep(750, 100);
            painelNum.Text += "3";
            if (painelNum.Text.Length == 2)
            {
                btnConfirma.Enabled = true;
                voto = Convert.ToInt16(painelNum.Text);
                this.desabilitaNum();
                switch (voto)
                {
                    case 45:
                        painelFoto.Image = Properties.Resources.joao_doria_c;
                        break;

                    case 13:
                        painelFoto.Image = Properties.Resources.fernando_haddad_c;
                        break;

                    case 10:
                        painelFoto.Image = Properties.Resources.celso_russomanno_c;
                        break;

                    case 15:
                        painelFoto.Image = Properties.Resources.marta_suplicy_c;
                        break;
                    case 50:
                        painelFoto.Image = Properties.Resources.luiza_erundina_c;
                        break;
                    default:
                        painelFoto.Image = Properties.Resources.nulo;
                        break;
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            System.Console.Beep(750, 100);
            painelNum.Text += "4";
            if (painelNum.Text.Length == 2)
            {
                btnConfirma.Enabled = true;
                voto = Convert.ToInt16(painelNum.Text);
                this.desabilitaNum();
                switch (voto)
                {
                    case 45:
                        painelFoto.Image = Properties.Resources.joao_doria_c;
                        break;

                    case 13:
                        painelFoto.Image = Properties.Resources.fernando_haddad_c;
                        break;

                    case 10:
                        painelFoto.Image = Properties.Resources.celso_russomanno_c;
                        break;

                    case 15:
                        painelFoto.Image = Properties.Resources.marta_suplicy_c;
                        break;
                    case 50:
                        painelFoto.Image = Properties.Resources.luiza_erundina_c;
                        break;
                    default:
                        painelFoto.Image = Properties.Resources.nulo;
                        break;

                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            System.Console.Beep(750, 100);
            painelNum.Text += "5";
            if (painelNum.Text.Length == 2)
            {
                btnConfirma.Enabled = true;
                voto = Convert.ToInt16(painelNum.Text);
                this.desabilitaNum();
                switch (voto)
                {
                    case 45:
                        painelFoto.Image = Properties.Resources.joao_doria_c;
                        break;

                    case 13:
                        painelFoto.Image = Properties.Resources.fernando_haddad_c;
                        break;

                    case 10:
                        painelFoto.Image = Properties.Resources.celso_russomanno_c;
                        break;

                    case 15:
                        painelFoto.Image = Properties.Resources.marta_suplicy_c;
                        break;
                    case 50:
                        painelFoto.Image = Properties.Resources.luiza_erundina_c;
                        break;
                    default:
                        painelFoto.Image = Properties.Resources.nulo;
                        break;

                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            System.Console.Beep(750, 100);
            painelNum.Text += "6";
            if (painelNum.Text.Length == 2)
            {
                btnConfirma.Enabled = true;
                voto = Convert.ToInt16(painelNum.Text);
                this.desabilitaNum();
                switch (voto)
                {
                    case 45:
                        painelFoto.Image = Properties.Resources.joao_doria_c;
                        break;

                    case 13:
                        painelFoto.Image = Properties.Resources.fernando_haddad_c;
                        break;

                    case 10:
                        painelFoto.Image = Properties.Resources.celso_russomanno_c;
                        break;

                    case 15:
                        painelFoto.Image = Properties.Resources.marta_suplicy_c;
                        break;
                    case 50:
                        painelFoto.Image = Properties.Resources.luiza_erundina_c;
                        break;
                    default:
                        painelFoto.Image = Properties.Resources.nulo;
                        break;

                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            System.Console.Beep(750, 100);
            painelNum.Text += "7";
            if (painelNum.Text.Length == 2)
            {
                btnConfirma.Enabled = true;
                voto = Convert.ToInt16(painelNum.Text);
                this.desabilitaNum();
                switch (voto)
                {
                    case 45:
                        painelFoto.Image = Properties.Resources.joao_doria_c;
                        break;

                    case 13:
                        painelFoto.Image = Properties.Resources.fernando_haddad_c;
                        break;

                    case 10:
                        painelFoto.Image = Properties.Resources.celso_russomanno_c;
                        break;

                    case 15:
                        painelFoto.Image = Properties.Resources.marta_suplicy_c;
                        break;
                    case 50:
                        painelFoto.Image = Properties.Resources.luiza_erundina_c;
                        break;
                    default:
                        painelFoto.Image = Properties.Resources.nulo;
                        break;

                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            System.Console.Beep(750, 100);
            painelNum.Text += "8";
            if (painelNum.Text.Length == 2)
            {
                btnConfirma.Enabled = true;
                voto = Convert.ToInt16(painelNum.Text);
                this.desabilitaNum();
                switch (voto)
                {
                    case 45:
                        painelFoto.Image = Properties.Resources.joao_doria_c;
                        break;

                    case 13:
                        painelFoto.Image = Properties.Resources.fernando_haddad_c;
                        break;

                    case 10:
                        painelFoto.Image = Properties.Resources.celso_russomanno_c;
                        break;

                    case 15:
                        painelFoto.Image = Properties.Resources.marta_suplicy_c;
                        break;
                    case 50:
                        painelFoto.Image = Properties.Resources.luiza_erundina_c;
                        break;
                    default:
                        painelFoto.Image = Properties.Resources.nulo;
                        break;

                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            System.Console.Beep(750, 100);
            painelNum.Text += "9";
            if (painelNum.Text.Length == 2)
            {
                btnConfirma.Enabled = true;
                voto = Convert.ToInt16(painelNum.Text);
                this.desabilitaNum();
                switch (voto)
                {
                    case 45:
                        painelFoto.Image = Properties.Resources.joao_doria_c;
                        break;

                    case 13:
                        painelFoto.Image = Properties.Resources.fernando_haddad_c;
                        break;

                    case 10:
                        painelFoto.Image = Properties.Resources.celso_russomanno_c;
                        break;

                    case 15:
                        painelFoto.Image = Properties.Resources.marta_suplicy_c;
                        break;
                    case 50:
                        painelFoto.Image = Properties.Resources.luiza_erundina_c;
                        break;
                    default:
                        painelFoto.Image = Properties.Resources.nulo;
                        break;

                }
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            
            System.Console.Beep(750, 100);
            painelNum.Text += "0";
            if (painelNum.Text.Length == 2)
            {
                btnConfirma.Enabled = true;
                voto = Convert.ToInt16(painelNum.Text);
                this.desabilitaNum();
                switch (voto)
                {
                    case 45:
                        painelFoto.Image = Properties.Resources.joao_doria_c;
                        break;

                    case 13:
                        painelFoto.Image = Properties.Resources.fernando_haddad_c;
                        break;

                    case 10:
                        painelFoto.Image = Properties.Resources.celso_russomanno_c;
                        break;

                    case 15:
                        painelFoto.Image = Properties.Resources.marta_suplicy_c;
                        break;
                    case 50:
                        painelFoto.Image = Properties.Resources.luiza_erundina_c;
                        break;
                    default:
                        painelFoto.Image = Properties.Resources.nulo;
                        break;

                }
            }

        }

        private void button16_Click(object sender, EventArgs e)
        {
            painelNum.Clear();
            System.Console.Beep(750, 100);
            painelFoto.Image = Properties.Resources.tela_inicial1;
            this.habilitaNum();

        }
        
        private void button15_Click(object sender, EventArgs e)
        {
            voto = 9999;
            System.Console.Beep(750, 100);
            painelNum.Clear();
            this.desabilitaNum();
            painelFoto.Image = Properties.Resources.voto_em_branco;
            btnConfirma.Enabled = true;
        }

        private void lblVencedorDoria_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tempoZeraTudo_Tick(object sender, EventArgs e)
        {
            if (contaFim > 0)
            {
               
                contaFim = contaFim - 1;
            }
            else
            {
              
                tempoZeraTudo.Stop();
                painelNum.Clear();
                this.habilitaNum();
                painelFoto.Image = Properties.Resources.tela_inicial1;
                this.habilitabtn();
                btnConfirma.Enabled = false;

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            painelFoto.Image = Properties.Resources.Integrantes;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (contaTempo > 0)
            {
   
                contaTempo = contaTempo - 1;
                if (contaTempo > 60)
                    lblTempo.Text = "Faltam " + ((contaTempo / 60)+1) + " minutos para o fim da votação.";
                else
                {
                    lblTempo.ForeColor = Color.Red;
                    lblTempo.Text = "Faltam " + contaTempo + " segundos para o fim da votação.";
                }
                }
            else
            {

                tempoVotacao.Stop();

                if (total_votos == 0)
                {
                    MessageBox.Show("Ninguém votou.");
                    lblTempo.Text = "Votação Encerrada sem nenhum voto :(";
                }
                else
                {
                    MessageBox.Show("Votação encerrada!");
                    lblTempo.Text = "Votação Encerrada!";
                    painelFoto.Image = Properties.Resources.encerrado;


                    btn0.Enabled = false;
                    this.desabilitabtn();
                    //Passando o valor dos votos para o Painel de resultado:

                    nVotosRussomano.Text = Convert.ToString(votos_de_cada[0]) + " voto(s).";

                    nVotosHaddad.Text = Convert.ToString(votos_de_cada[1]) + " voto(s).";

                    nVotosDoria.Text = Convert.ToString(votos_de_cada[2]) + " voto(s).";

                    nVotosErundina.Text = Convert.ToString(votos_de_cada[3]) + " voto(s).";

                    nVotosMarta.Text = Convert.ToString(votos_de_cada[4]) + " voto(s).";

                    nVotosBrancoNulo.Text = Convert.ToString(votos_de_cada[5] + votos_de_cada[6]) + " voto(s).";

                    //Calculando a porcentagem e passando para o painel:
                    pRussomano = (100.0 / (total_votos) * votos_de_cada[0]);
                    pHaddad = (100.0 / (total_votos) * votos_de_cada[1]);
                    pDoria = (100.0 / (total_votos) * votos_de_cada[2]);
                    pErundina = (100.0 / (total_votos) * votos_de_cada[3]);
                    pMarta = (100.0 / (total_votos) * votos_de_cada[4]);
                    pBrancoNulo = (100.0 / (total_votos) * (votos_de_cada[5] + votos_de_cada[6]));

                    pcRussomano.Text = String.Format("{0:n2}%",
                             pRussomano);
                    pcHaddad.Text = String.Format("{0:n2}%",
                             pHaddad);
                    pcDoria.Text = String.Format("{0:n2}%",
                             pDoria);
                    pcErundina.Text = String.Format("{0:n2}%",
                             pErundina);
                    pcMarta.Text = String.Format("{0:n2}%",
                             pMarta);
                    pcBrancoNulo.Text = String.Format("{0:n2}%",
                             pBrancoNulo);


                    int contador = 0;


                    //Ver qual é o maior número.]
                    int maior = 0;

                    for (int i = 0; i < 5; i++)
                    {

                        if (votos_de_cada[i] > maior)
                        {
                            maior = votos_de_cada[i];
                            vencedor = i;
                        }
                    }

                    //Ver se tem empate entre maior nota.
                    for (int i = 0; i < 5; i++)
                    {
                        if (votos_de_cada[i] == maior)
                            contador++;
                    }

                    if (contador != 1)//se tiver empate nos votos
                    {
                        if (contador == 2)
                        {
                            for (int i = 0; i < 5; i++)
                            {
                                if (votos_de_cada[i] == maior)
                                {
                                    switch (i)
                                    {
                                        case 0:
                                            segTRussomano.Visible = true;
                                            break;
                                        case 1:
                                            segTHaddad.Visible = true;
                                            break;
                                        case 2:
                                            segTDoria.Visible = true;
                                            break;
                                        case 3:
                                            segTErundina.Visible = true;
                                            break;
                                        case 4:
                                            segTMarta.Visible = true;
                                            break;
                                    }
                                }
                            }
                        }
                        else
                        MessageBox.Show("Houve empate entre mais de dois candidatos.");
                        painelResultado.Visible = true;

                    }


                    else// se não tiver empate nos votos
                    {

                        switch (vencedor)
                        {
                            case 0:
                                lblVencedorRussomano.Visible = true;
                                pcRussomano.BackColor = Color.LawnGreen;  
                                break;
                            case 1:
                                lblVencedorHaddad.Visible = true;
                                pcHaddad.BackColor = Color.LawnGreen;
                                break;
                            case 2:
                                lblVencedorDoria.Visible = true;
                                pcDoria.BackColor = Color.LawnGreen;
                                break;
                            case 3:
                                lblVencedorErundina.Visible = true;
                                pcErundina.BackColor = Color.LawnGreen;
                                break;
                            case 4:
                                lblVencedorMarta.Visible = true;
                                pcMarta.BackColor = Color.LawnGreen;
                                break;
                        }
                        painelResultado.Visible = true;
                    }

                    /*votos_de_cada:
                    [0] Celso Russomano
                    [1] Fernando Haddad
                    [2] João Doria
                    [3] Luiza Erundina
                    [4] Marta Suplicy
                    [5] Votos Nulos
                    [6] Votos em branco
                        */
                }
        }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            total_votos++;
            System.Media.SoundPlayer MeuPlayer = new System.Media.SoundPlayer(@"C:\Users\gerso\Desktop\Urna\songcortado.wav");
            MeuPlayer.Play();
            painelFoto.Image = Properties.Resources.fim;
            this.desabilitabtn();

            if (voto!=9999)//voto = 9999 quando o usuário vota em branco
            voto = Convert.ToInt16(painelNum.Text);

            tempoZeraTudo.Start();
            switch (voto)
            {
                case 45:
                   votos_de_cada[2] += 1;
                    break;

                case 13:
                    votos_de_cada[1] += 1;
                    break;

                case 15:
                    votos_de_cada[4] += 1;
                    break;

                case 10:
                    votos_de_cada[0] += 1;
                    break;
                case 50:
                    votos_de_cada[3] += 1;
                    break;
                case 9999:
                    votos_de_cada[6] += 1;
                    break;
                default:
                    votos_de_cada[5] += 1;
                    break;


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            painelFoto.Image = Properties.Resources.Viola;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            painelFoto.Image = Properties.Resources.Marina;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            painelNum.Text += "1";
            System.Console.Beep(750, 100);
            if (painelNum.Text.Length == 2)
            {
                btnConfirma.Enabled = true;
                voto = Convert.ToInt16(painelNum.Text);
                this.desabilitaNum();
                switch (voto)
                {
                    case 45:
                        painelFoto.Image = Properties.Resources.joao_doria_c;
                        break;

                    case 13:
                        painelFoto.Image = Properties.Resources.fernando_haddad_c;
                        break;

                    case 10:
                        painelFoto.Image = Properties.Resources.celso_russomanno_c;
                        break;

                    case 15:
                        painelFoto.Image = Properties.Resources.marta_suplicy_c;
                        break;
                    case 50:
                        painelFoto.Image = Properties.Resources.luiza_erundina_c;
                        break;
                    default:
                        painelFoto.Image = Properties.Resources.nulo;
                        break;

                }
            }
        }
    }
}



