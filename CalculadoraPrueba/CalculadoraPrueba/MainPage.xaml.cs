using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CalculadoraPrueba
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Base.Text) && !string.IsNullOrEmpty(Lado1.Text) && !string.IsNullOrEmpty(Lado2.Text) && !string.IsNullOrEmpty(Altura.Text))
            {

                var basexd = Double.Parse(Base.Text);
                var lado1 = Double.Parse(Lado1.Text);
                var lado2 = Double.Parse(Lado2.Text);
                var altura = Double.Parse(Altura.Text);
                var area = (basexd * altura) / 2;
                Area.Text = area.ToString();

                string resultado = "";


                if (basexd == lado1 && basexd == lado1 && lado1 == lado2) 
                {
                    resultado = "Triangulo equilatero";
                    imgEquilatero.IsVisible = true;
                    imgEscaleno.IsVisible= false;
                    imgIsoceles.IsVisible= false;

                }

                DisplayAlert("Tu triangulo es un:", $"{resultado}", "salir alv");




            }
            else 
            {
                DisplayAlert("Puto", "ingresa todos los campos", "Salir alv");
            }


        }
    }
}
