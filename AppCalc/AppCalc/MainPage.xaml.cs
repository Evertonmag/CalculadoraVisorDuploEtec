using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppCalc
{
    public partial class MainPage : ContentPage
    {
        double pre = 0;
        double pos = 0;
        double resultado = 0;
        string tela = "";
        string calculo = "";


        public MainPage()
        {
            InitializeComponent();

            //btnConvUni.Source = ImageSource.FromResource("AppCalc.Image.imgTemp.png");

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
            if (txt_visor.Text.Contains("+"))
            {
                txt_visor.Text = "";
                txt_visor.Text = pos.ToString();
            }
            if (txt_visor.Text.Contains("-"))
            {
                txt_visor.Text = "";
                txt_visor.Text = pos.ToString();
            }
            if (txt_visor.Text.Contains("×"))
            {
                txt_visor.Text = "";
                txt_visor.Text = pos.ToString();
            }
            if (txt_visor.Text.Contains("÷"))
            {
                txt_visor.Text = "";
                txt_visor.Text = pos.ToString();
            }
        }

        void igual()
        {
            if (calculo == "+" || calculo == "-" || calculo == "×" || calculo == "÷")
            {
                txt_visor.Text = "";
                txt_visor.Text += txt_Resultado.Text;
                pre = double.Parse(txt_Resultado.Text);
                pos = 0;

            }

        }

        private void Button_Clicked_7(object sender, EventArgs e)
        {
            try
            {
                if (calculo == "+" || calculo == "-" || calculo == "×" || calculo == "÷")
                {
                    teste_sinal();

                    txt_visor.Text += "7";
                    pos = double.Parse(txt_visor.Text);

                    txt_visor.Text = "";
                    if (tela == "")
                        txt_visor.Text = pre.ToString() + calculo + pos.ToString();
                    else
                        txt_visor.Text = tela + calculo + pos.ToString();

                    tela = txt_visor.Text;
                }
                else
                {
                    txt_visor.Text += "7";
                    pre = double.Parse(txt_visor.Text);

                }
                if (calculo == "+" || calculo == "-" || calculo == "×" || calculo == "÷")
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

        private void Button_Clicked_8(object sender, EventArgs e)
        {
            try
            {
                if (calculo == "+" || calculo == "-" || calculo == "×" || calculo == "÷")
                {
                    teste_sinal();

                    txt_visor.Text += "8";
                    pos = double.Parse(txt_visor.Text);

                    txt_visor.Text = "";
                    txt_visor.Text = pre.ToString() + calculo + pos.ToString();
                }
                else
                {
                    txt_visor.Text += "8";
                    pre = double.Parse(txt_visor.Text);

                }
                if (calculo == "+" || calculo == "-" || calculo == "×" || calculo == "÷")
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

        private void Button_Clicked_9(object sender, EventArgs e)
        {
            try
            {
                if (calculo == "+" || calculo == "-" || calculo == "×" || calculo == "÷")
                {
                    teste_sinal();

                    txt_visor.Text += "9";
                    pos = double.Parse(txt_visor.Text);

                    txt_visor.Text = "";
                    txt_visor.Text = pre.ToString() + calculo + pos.ToString();
                }
                else
                {
                    txt_visor.Text += "9";
                    pre = double.Parse(txt_visor.Text);

                }
                if (calculo == "+" || calculo == "-" || calculo == "×" || calculo == "÷")
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

        private void Button_Clicked_4(object sender, EventArgs e)
        {
            try
            {
                if (calculo == "+" || calculo == "-" || calculo == "×" || calculo == "÷")
                {
                    teste_sinal();

                    txt_visor.Text += "4";
                    pos = double.Parse(txt_visor.Text);

                    txt_visor.Text = "";
                    txt_visor.Text = pre.ToString() + calculo + pos.ToString();
                }
                else
                {
                    txt_visor.Text += "4";
                    pre = double.Parse(txt_visor.Text);

                }
                if (calculo == "+" || calculo == "-" || calculo == "×" || calculo == "÷")
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

        private void Button_Clicked_5(object sender, EventArgs e)
        {
            try
            {
                if (calculo == "+" || calculo == "-" || calculo == "×" || calculo == "÷")
                {
                    teste_sinal();

                    txt_visor.Text += "5";
                    pos = double.Parse(txt_visor.Text);

                    txt_visor.Text = "";
                    txt_visor.Text = pre.ToString() + calculo + pos.ToString();
                }
                else
                {
                    txt_visor.Text += "5";
                    pre = double.Parse(txt_visor.Text);

                }
                if (calculo == "+" || calculo == "-" || calculo == "×" || calculo == "÷")
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

        private void Button_Clicked_6(object sender, EventArgs e)
        {
            try
            {
                if (calculo == "+" || calculo == "-" || calculo == "×" || calculo == "÷")
                {
                    teste_sinal();

                    txt_visor.Text += "6";
                    pos = double.Parse(txt_visor.Text);

                    txt_visor.Text = "";
                    txt_visor.Text = pre.ToString() + calculo + pos.ToString();
                }
                else
                {
                    txt_visor.Text += "6";
                    pre = double.Parse(txt_visor.Text);

                }
                if (calculo == "+" || calculo == "-" || calculo == "×" || calculo == "÷")
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

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            try
            {
                if (calculo == "+" || calculo == "-" || calculo == "×" || calculo == "÷")
                {
                    teste_sinal();

                    txt_visor.Text += "1";
                    pos = double.Parse(txt_visor.Text);

                    txt_visor.Text = "";
                    txt_visor.Text = pre.ToString() + calculo + pos.ToString();
                }
                else
                {
                    txt_visor.Text += "1";
                    pre = double.Parse(txt_visor.Text);

                }
                if (calculo == "+" || calculo == "-" || calculo == "×" || calculo == "÷")
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

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            try
            {
                if (calculo == "+" || calculo == "-" || calculo == "×" || calculo == "÷")
                {
                    teste_sinal();

                    txt_visor.Text += "2";
                    pos = double.Parse(txt_visor.Text);

                    txt_visor.Text = "";
                    txt_visor.Text = pre.ToString() + calculo + pos.ToString();
                }
                else
                {
                    txt_visor.Text += "2";
                    pre = double.Parse(txt_visor.Text);

                }
                if (calculo == "+" || calculo == "-" || calculo == "×" || calculo == "÷")
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

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            try
            {
                if (calculo == "+" || calculo == "-" || calculo == "×" || calculo == "÷")
                {
                    teste_sinal();

                    txt_visor.Text += "3";
                    pos = double.Parse(txt_visor.Text);

                    txt_visor.Text = "";
                    txt_visor.Text = pre.ToString() + calculo + pos.ToString();
                }
                else
                {
                    txt_visor.Text += "3";
                    pre = double.Parse(txt_visor.Text);

                }
                if (calculo == "+" || calculo == "-" || calculo == "×" || calculo == "÷")
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

        private void Button_Clicked_0(object sender, EventArgs e)
        {
            try
            {
                if (calculo == "+" || calculo == "-" || calculo == "×" || calculo == "÷")
                {
                    teste_sinal();

                    txt_visor.Text += "0";
                    pos = double.Parse(txt_visor.Text);

                    txt_visor.Text = "";
                    txt_visor.Text = pre.ToString() + calculo + pos.ToString();
                }
                else
                {
                    txt_visor.Text += "0";
                    pre = double.Parse(txt_visor.Text);

                }
                if (calculo == "+" || calculo == "-" || calculo == "×" || calculo == "÷")
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
                                "envie para nos qual foi. O erro dado foi: " + ex.Message, "Ok");
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
                                "envie para nos qual foi. O erro dado foi: " + ex.Message, "Ok");
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
                                "envie para nos qual foi. O erro dado foi: " + ex.Message, "Ok");
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
                                "envie para nos qual foi. O erro dado foi: " + ex.Message, "Ok");
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
                                "envie para nos qual foi. O erro dado foi: " + ex.Message, "Ok");
            }
        }

        private void Button_Clicked_Igual(object sender, EventArgs e)
        {
            igual();
        }

        private void Button_Clicked_Inversor(object sender, EventArgs e)
        {
            try
            {
                if (txt_Resultado.Text != "")
                {
                    double inv = double.Parse(txt_Resultado.Text);
                    inv *= -1;
                    txt_Resultado.Text = inv.ToString();
                }
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", "Algo não deu certo tente novamente mais tarde se persistir o erro " +
                                "envie para nos qual foi. O erro dado foi: " + ex.Message, "Ok");
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
                                "envie para nos qual foi. O erro dado foi: " + ex.Message, "Ok");
            }
        }

        private void Button_Clicked_Ponto(object sender, EventArgs e)
        {
            try
            {
                ////Ainda não achei um jeito de funcionar corretamente
                //if (calculo == "")
                //{
                //    if (!txt_visor.Text.Contains("."))
                //    {
                //        txt_visor.Text += ".";

                //    }
                //}
                //else
                //{
                //    tela = txt_visor.Text;
                //    txt_visor.Text = "";
                //    if (!txt_visor.Text.Contains("."))
                //    {
                //        txt_visor.Text = tela;

                //        txt_visor.Text += ".";

                //    }
                //}
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", "Algo não deu certo tente novamente mais tarde se persistir o erro " +
                                "envie para nos qual foi. O erro dado foi: " + ex.Message, "Ok");
            }
        }
    }
}
