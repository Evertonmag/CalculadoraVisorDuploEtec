using System;
using Xamarin.Forms;

namespace AppCalc
{

    // Estou utilizando virgula inves de ponto mas se nao funcionar trocar virgula por ponto
    // pois no meu celular so funcionou com virgula

    public partial class MainPage : ContentPage
    {
        double pre = 0;
        double pos = 0;
        double resultado = 0;
        string tela = "";
        string calculo = "";
        string num = "";
        bool ponto = false;

        public MainPage()
        {
            InitializeComponent();
        }

        void operacoes()
        {
            switch (calculo)
            {
                case "+":
                    resultado = pre + pos;
                    txt_Resultado.Text = resultado.ToString();
                    break;
                case "-":
                    resultado = pre - pos;
                    txt_Resultado.Text = resultado.ToString();
                    break;
                case "×":
                    resultado = pre * pos;
                    txt_Resultado.Text = resultado.ToString();
                    break;
                case "÷":
                    resultado = pre / pos;
                    txt_Resultado.Text = resultado.ToString();
                    break;
            }
        }
        void teste_sinal()
        {
            if (txt_visor.Text.Contains("+") || txt_visor.Text.Contains("-") || 
                txt_visor.Text.Contains("×") || txt_visor.Text.Contains("÷"))
            {
                txt_visor.Text = "";
                txt_visor.Text = pos.ToString();
            }
        }
        void igual()
        {
            if (calculo == "+" || calculo == "-" || calculo == "×" || calculo == "÷")
            {
                if (calculo == "÷" && num == "0") { }

                else
                {
                    txt_visor.Text = "";
                    txt_visor.Text += txt_Resultado.Text;
                    pre = double.Parse(txt_Resultado.Text);
                    pos = 0;
                }
            }
        }
        void Calcular()
        {
            try
            {
                if (calculo == "+" || calculo == "-" || calculo == "×" || calculo == "÷")
                {
                    if (ponto == true)
                    {
                        teste_sinal();

                        txt_visor.Text += "," + num;
                        pos = double.Parse(txt_visor.Text);

                        txt_visor.Text = "";
                        txt_visor.Text = pre.ToString() + calculo + pos.ToString();
                        ponto = false;
                    }
                    else
                    {
                        teste_sinal();

                        txt_visor.Text += num;
                        pos = double.Parse(txt_visor.Text);

                        txt_visor.Text = "";
                        txt_visor.Text = pre.ToString() + calculo + pos.ToString();
                    }
                }
                else
                {
                    if (ponto == true)
                    {
                        txt_visor.Text += "," + num;
                        pre = double.Parse(txt_visor.Text);
                        ponto = false;
                    }
                    else
                    {
                        txt_visor.Text += num;
                        pre = double.Parse(txt_visor.Text);
                    }
                }
                if (calculo == "÷" && num == "0") { }
                else if (calculo == "+" || calculo == "-" || calculo == "×" || calculo == "÷")
                {
                    operacoes();
                }

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", "Algo não deu certo tente novamente mais tarde se persistir o erro " +
                                "envie para nos qual foi. O erro dado foi: " + ex.Message, "Ok");
            }
        }

        //Numeros
        private void Button_Clicked_7(object sender, EventArgs e)
        {
            num = "7";
            Calcular();
        }
        private void Button_Clicked_8(object sender, EventArgs e)
        {
            num = "8";
            Calcular();
        }
        private void Button_Clicked_9(object sender, EventArgs e)
        {
            num = "9";
            Calcular();
        }
        private void Button_Clicked_4(object sender, EventArgs e)
        {
            num = "4";
            Calcular();
        }
        private void Button_Clicked_5(object sender, EventArgs e)
        {
            num = "5";
            Calcular();
        }
        private void Button_Clicked_6(object sender, EventArgs e)
        {
            num = "6";
            Calcular();
        }
        private void Button_Clicked_1(object sender, EventArgs e)
        {
            num = "1";
            Calcular();
        }
        private void Button_Clicked_2(object sender, EventArgs e)
        {
            num = "2";
            Calcular();
        }
        private void Button_Clicked_3(object sender, EventArgs e)
        {
            num = "3";
            Calcular();
        }
        private void Button_Clicked_0(object sender, EventArgs e)
        {
            num = "0";
            Calcular();
        }

        //Operações
        private void Button_Clicked_Limpar(object sender, EventArgs e)
        {
            try
            {
                txt_visor.Text = "";
                calculo = "";
                txt_Resultado.Text = "";
                tela = "";

                pre = 0;
                pos = 0;
                resultado = 0;
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", "Algo não deu certo tente novamente mais tarde se persistir o erro " +
                                $"envie para nos qual foi. O erro dado foi: {ex.Message}", "Ok");
            }
        }
        private void Button_Clicked_Somar(object sender, EventArgs e)
        {
            try
            {
                if (txt_visor.Text != "")
                {
                    igual();

                    txt_visor.Text += "+";
                    calculo = "+";
                }
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", "Algo não deu certo tente novamente mais tarde se persistir o erro " +
                                $"envie para nos qual foi. O erro dado foi: {ex.Message}", "Ok");
            }
        }
        private void Button_Clicked_Subtrair(object sender, EventArgs e)
        {
            try
            {
                if (txt_visor.Text != "")
                {
                    igual();

                    txt_visor.Text += "-";
                    calculo = "-";
                }
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", "Algo não deu certo tente novamente mais tarde se persistir o erro " +
                                 $"envie para nos qual foi. O erro dado foi: {ex.Message}", "Ok");
            }
        }
        private void Button_Clicked_Multiplicar(object sender, EventArgs e)
        {
            try
            {
                if (txt_visor.Text != "")
                {
                    igual();

                    txt_visor.Text += "×";
                    calculo = "×";
                }
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", "Algo não deu certo tente novamente mais tarde se persistir o erro " +
                                $"envie para nos qual foi. O erro dado foi: {ex.Message}", "Ok");
            }
        }
        private void Button_Clicked_Dividir(object sender, EventArgs e)
        {
            try
            {
                if (txt_visor.Text != "")
                {
                    igual();

                    txt_visor.Text += "÷";
                    calculo = "÷";
                }
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", "Algo não deu certo tente novamente mais tarde se persistir o erro " +
                                $"envie para nos qual foi. O erro dado foi: {ex.Message}", "Ok");
            }
        }
        private void Button_Clicked_Igual(object sender, EventArgs e)
        {
            if (calculo == "÷" && num == "0")
                DisplayAlert("Ops", "Não é possivel Dividir por ZERO (0)", "Ok");

            igual();
        }
        private void Button_Clicked_Inversor(object sender, EventArgs e)
        {
            try
            {
                if (txt_Resultado.Text != null)
                {
                    double inv = double.Parse(txt_Resultado.Text);
                    inv *= -1;
                    txt_Resultado.Text = inv.ToString();
                }
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", "Algo não deu certo tente novamente mais tarde se persistir o erro " +
                                $"envie para nos qual foi. O erro dado foi: {ex.Message}", "Ok");
            }

        }
        private void Button_Clicked_Porcento(object sender, EventArgs e)
        {
            try
            {
                double porcentagem = 0;
                switch (calculo)
                {
                    case "+":
                        txt_visor.Text += "%";
                        porcentagem = pre * (1 + (pos / 100));
                        txt_Resultado.Text = porcentagem.ToString();
                        break;
                    case "-":
                        txt_visor.Text += "%";
                        porcentagem = pre * (1 - (pos / 100));
                        txt_Resultado.Text = porcentagem.ToString();
                        break;
                    case "×":
                        txt_visor.Text += "%";
                        porcentagem = pre * (pos / 100);
                        txt_Resultado.Text = porcentagem.ToString();
                        break;
                    case "÷":
                        txt_visor.Text += "%";
                        porcentagem = pre / (pos / 100);
                        txt_Resultado.Text = porcentagem.ToString();
                        break;
                }

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", "Algo não deu certo tente novamente mais tarde se persistir o erro " +
                                $"envie para nos qual foi. O erro dado foi: {ex.Message}", "Ok");
            }
        }
        private void Button_Clicked_Ponto(object sender, EventArgs e)
        {
            try
            {
                // Ha um jeito mais facil, mas ainda não implementei

                if (calculo == "")
                {
                    if (!txt_visor.Text.Contains("."))
                        ponto = true;
                }
                else
                {
                    tela = txt_visor.Text;
                    txt_visor.Text = "";
                    if (!txt_visor.Text.Contains("."))
                        ponto = true;
                    txt_visor.Text = tela;
                }
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", "Algo não deu certo tente novamente mais tarde se persistir o erro " +
                                $"envie para nos qual foi. O erro dado foi: {ex.Message}", "Ok");
            }
        }
    }
}
