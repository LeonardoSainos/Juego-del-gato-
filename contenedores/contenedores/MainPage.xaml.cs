using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace contenedores
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
          
        }
       public int count = 0;
        public int counto = 0;
        public int countx = 0;
        public int county = 0;
        public int[] array = new int[2];



        private async void Button_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

  
            if (btnuno.Text == null || btndos.Text == null || btntres.Text == null || btncuatro.Text == null || btncinco.Text == null || btnseis.Text == null || btnsiete.Text == null || btnocho.Text == null || btnueve.Text == null)
            {

            
                for (int x = 0; x <10; x++)
                {
                    count++;

                    if (count == 1)
                    {
                        btn.FontSize = 40;
                        btn.Text = "O";
                        btn.TextColor = Color.Red;
                        btn.BackgroundColor = Color.White;
                        btn.IsEnabled = false;

                        break;
                    }
                    if (count == 2)
                    {
                        btn.FontSize = 40;
                        btn.Text = "X";
                        btn.TextColor = Color.Blue;
                        btn.BackgroundColor = Color.White;
                        btn.IsEnabled = false;

                        break;
                    }
                    if (count == 3)
                    {
                        btn.FontSize = 40;
                        btn.Text = "O";
                        btn.TextColor = Color.Red;
                        btn.BackgroundColor = Color.White;
                        btn.IsEnabled = false;

                        break;
                    }
                    if (count == 4)
                    {
                        btn.FontSize = 40;
                        btn.Text = "X";
                        btn.TextColor = Color.Blue;
                        btn.BackgroundColor = Color.White;
                        btn.IsEnabled = false;

                        break;

                    }
                    if (count == 6)
                    {
                        btn.FontSize = 40;
                        btn.Text = "O";
                        btn.TextColor = Color.Red;
                        btn.BackgroundColor = Color.White;
                        btn.IsEnabled = false;

                        break;
                    }
                    if (count == 7)
                    {
                        btn.FontSize = 40;
                        btn.Text = "X";
                        btn.TextColor = Color.Blue;
                        btn.BackgroundColor = Color.White;
                        btn.IsEnabled = false;

                        break;

                    }
                    if (count == 8)
                    {
                        btn.FontSize = 40;
                        btn.Text = "O";
                        btn.TextColor = Color.Red;
                        btn.BackgroundColor = Color.White;
                        btn.IsEnabled = false;

                        break;

                    }
                    if (count == 9)
                    {
                        btn.FontSize = 40;
                        btn.Text = "X";
                        btn.TextColor = Color.Blue;
                        btn.BackgroundColor = Color.White;
                        btn.IsEnabled = false;

                        break;

                    }
                }
            }
         
        


           if(btn.Text=="X")
            {
                btn.FontSize = 40;
                btn.Text = "X";
                btn.TextColor = Color.White;
                btn.BackgroundColor = Color.Black;
            }
            else{
                btn.FontSize = 40;
                btn.Text = "O";
                btn.TextColor = Color.White;
                btn.BackgroundColor = Color.Purple;
            }
            if(btn.Text=="O")
            {
                btn.FontSize = 40;
                btn.Text = "O";
                btn.TextColor = Color.White;
                btn.BackgroundColor = Color.Purple;
            }
             else{
                btn.FontSize = 40;
                btn.Text = "X";
                btn.TextColor = Color.White;
                btn.BackgroundColor = Color.Black;

            }


            if ((btnuno.Text=="X" && btndos.Text=="X" && btntres.Text=="X"))
            {
                await DisplayAlert("Ganaste", "Felicidades gano el jugador X", "Aceptar");
                btnuno.Text = "";
                btndos.Text = "";
                btntres.Text = "";
                btncuatro.Text = "";
                btncinco.Text = "";
                btnseis.Text = "";
                btnsiete.Text = "";
                btnocho.Text = "";
                btnueve.Text = "";
                btnuno.IsEnabled = true;
                btndos.IsEnabled = true;
                btntres.IsEnabled = true;
                btncuatro.IsEnabled = true;
                btncinco.IsEnabled = true;
                btnseis.IsEnabled = true;
                btnsiete.IsEnabled = true;
                btnocho.IsEnabled = true;
                btnueve.IsEnabled = true;
                count = 0;

            }
            else if ((btnuno.Text == "X" && btncuatro.Text == "X" && btnsiete.Text == "X"))
            {
                await DisplayAlert("Ganaste", "Felicidades gano el jugador X", "Aceptar");
                btnuno.Text = "";
                btndos.Text = "";
                btntres.Text = "";
                btncuatro.Text = "";
                btncinco.Text = "";
                btnseis.Text = "";
                btnsiete.Text = "";
                btnocho.Text = "";
                btnueve.Text = "";
                btnuno.IsEnabled = true;
                btndos.IsEnabled = true;
                btntres.IsEnabled = true;
                btncuatro.IsEnabled = true;
                btncinco.IsEnabled = true;
                btnseis.IsEnabled = true;
                btnsiete.IsEnabled = true;
                btnocho.IsEnabled = true;
                btnueve.IsEnabled = true;
        
                count = 0;
            }
            else if ((btnsiete.Text == "X" && btnocho.Text == "X" && btnueve.Text == "X"))
            {
                await DisplayAlert("Ganaste", "Felicidades gano el jugador X", "Aceptar");
                btnuno.Text = "";
                btndos.Text = "";
                btntres.Text = "";
                btncuatro.Text = "";
                btncinco.Text = "";
                btnseis.Text = "";
                btnsiete.Text = "";
                btnocho.Text = "";
                btnueve.Text = "";
                btnuno.IsEnabled = true;
                btndos.IsEnabled = true;
                btntres.IsEnabled = true;
                btncuatro.IsEnabled = true;
                btncinco.IsEnabled = true;
                btnseis.IsEnabled = true;
                btnsiete.IsEnabled = true;
                btnocho.IsEnabled = true;
                btnueve.IsEnabled = true;
                count = 0;
            }
            else if ((btnueve.Text == "X" && btnseis.Text == "X" && btntres.Text == "X"))
            {
                await DisplayAlert("Ganaste", "Felicidades gano el jugador X", "Aceptar");
                btnuno.Text = "";
                btndos.Text = "";
                btntres.Text = "";
                btncuatro.Text = "";
                btncinco.Text = "";
                btnseis.Text = "";
                btnsiete.Text = "";
                btnocho.Text = "";
                btnueve.Text = "";
                btnuno.IsEnabled = true;
                btndos.IsEnabled = true;
                btntres.IsEnabled = true;
                btncuatro.IsEnabled = true;
                btncinco.IsEnabled = true;
                btnseis.IsEnabled = true;
                btnsiete.IsEnabled = true;
                btnocho.IsEnabled = true;
                btnueve.IsEnabled = true;
                count = 0;
            }
            else if ((btndos.Text == "X" && btncinco.Text == "X" && btnocho.Text == "X"))
            {
                await DisplayAlert("Ganaste", "Felicidades gano el jugador X", "Aceptar");
                btnuno.Text = "";
                btndos.Text = "";
                btntres.Text = "";
                btncuatro.Text = "";
                btncinco.Text = "";
                btnseis.Text = "";
                btnsiete.Text = "";
                btnocho.Text = "";
                btnueve.Text = "";
                btnuno.IsEnabled = true;
                btndos.IsEnabled = true;
                btntres.IsEnabled = true;
                btncuatro.IsEnabled = true;
                btncinco.IsEnabled = true;
                btnseis.IsEnabled = true;
                btnsiete.IsEnabled = true;
                btnocho.IsEnabled = true;
                btnueve.IsEnabled = true;
                count = 0;
            }
            else if ((btncuatro.Text == "X" && btncinco.Text == "X" && btnseis.Text == "X"))
            {
                await DisplayAlert("Ganaste", "Felicidades gano el jugador X", "Aceptar");
                btnuno.Text = "";
                btndos.Text = "";
                btntres.Text = "";
                btncuatro.Text = "";
                btncinco.Text = "";
                btnseis.Text = "";
                btnsiete.Text = "";
                btnocho.Text = "";
                btnueve.Text = "";
                btnuno.IsEnabled = true;
                btndos.IsEnabled = true;
                btntres.IsEnabled = true;
                btncuatro.IsEnabled = true;
                btncinco.IsEnabled = true;
                btnseis.IsEnabled = true;
                btnsiete.IsEnabled = true;
                btnocho.IsEnabled = true;
                btnueve.IsEnabled = true;
                count = 0;
            }
            else if ((btnuno.Text == "X" && btncinco.Text == "X" && btnueve.Text == "X"))
            {
                await DisplayAlert("Ganaste", "Felicidades gano el jugador X", "Aceptar");
                btnuno.Text = "";
                btndos.Text = "";
                btntres.Text = "";
                btncuatro.Text = "";
                btncinco.Text = "";
                btnseis.Text = "";
                btnsiete.Text = "";
                btnocho.Text = "";
                btnueve.Text = "";
                btnuno.IsEnabled = true;
                btndos.IsEnabled = true;
                btntres.IsEnabled = true;
                btncuatro.IsEnabled = true;
                btncinco.IsEnabled = true;
                btnseis.IsEnabled = true;
                btnsiete.IsEnabled = true;
                btnocho.IsEnabled = true;
                btnueve.IsEnabled = true;
                count = 0;
            }
            else if ((btntres.Text == "X" && btncinco.Text == "X" && btnsiete.Text == "X"))
            {
                await DisplayAlert("Ganaste", "Felicidades gano el jugador X", "Aceptar");
                btnuno.Text = "";
                btndos.Text = "";
                btntres.Text = "";
                btncuatro.Text = "";
                btncinco.Text = "";
                btnseis.Text = "";
                btnsiete.Text = "";
                btnocho.Text = "";
                btnueve.Text = "";
                btnuno.IsEnabled = true;
                btndos.IsEnabled = true;
                btntres.IsEnabled = true;
                btncuatro.IsEnabled = true;
                btncinco.IsEnabled = true;
                btnseis.IsEnabled = true;
                btnsiete.IsEnabled = true;
                btnocho.IsEnabled = true;
                btnueve.IsEnabled = true;
                count = 0;
            }

            else if ((btnuno.Text == "O" && btndos.Text == "O" && btntres.Text == "O"))
            {
                await DisplayAlert("Ganaste", "Felicidades gano el jugador O", "Aceptar");
                btnuno.Text = "";
                btndos.Text = "";
                btntres.Text = "";
                btncuatro.Text = "";
                btncinco.Text = "";
                btnseis.Text = "";
                btnsiete.Text = "";
                btnocho.Text = "";
                btnueve.Text = "";
                btnuno.IsEnabled = true;
                btndos.IsEnabled = true;
                btntres.IsEnabled = true;
                btncuatro.IsEnabled = true;
                btncinco.IsEnabled = true;
                btnseis.IsEnabled = true;
                btnsiete.IsEnabled = true;
                btnocho.IsEnabled = true;
                btnueve.IsEnabled = true;
                count = 0;
            }
            else if ((btnuno.Text == "O" && btncuatro.Text == "O" && btnsiete.Text == "O"))
            {
                await DisplayAlert("Ganaste", "Felicidades gano el jugador O", "Aceptar");
                btnuno.Text = "";
                btndos.Text = "";
                btntres.Text = "";
                btncuatro.Text = "";
                btncinco.Text = "";
                btnseis.Text = "";
                btnsiete.Text = "";
                btnocho.Text = "";
                btnueve.Text = "";
                btnuno.IsEnabled = true;
                btndos.IsEnabled = true;
                btntres.IsEnabled = true;
                btncuatro.IsEnabled = true;
                btncinco.IsEnabled = true;
                btnseis.IsEnabled = true;
                btnsiete.IsEnabled = true;
                btnocho.IsEnabled = true;
                btnueve.IsEnabled = true;
                count = 0;
            }
            else if ((btnsiete.Text == "O" && btnocho.Text == "O" && btnueve.Text == "O"))
            {
                await DisplayAlert("Ganaste", "Felicidades gano el jugador O", "Aceptar");
                btnuno.Text = "";
                btndos.Text = "";
                btntres.Text = "";
                btncuatro.Text = "";
                btncinco.Text = "";
                btnseis.Text = "";
                btnsiete.Text = "";
                btnocho.Text = "";
                btnueve.Text = "";
                btnuno.IsEnabled = true;
                btndos.IsEnabled = true;
                btntres.IsEnabled = true;
                btncuatro.IsEnabled = true;
                btncinco.IsEnabled = true;
                btnseis.IsEnabled = true;
                btnsiete.IsEnabled = true;
                btnocho.IsEnabled = true;
                btnueve.IsEnabled = true;
                count = 0;
            }
            else if ((btnueve.Text == "O" && btnseis.Text == "O" && btntres.Text == "O"))
            {
                await DisplayAlert("Ganaste", "Felicidades gano el jugador O", "Aceptar");
                btnuno.Text = "";
                btndos.Text = "";
                btntres.Text = "";
                btncuatro.Text = "";
                btncinco.Text = "";
                btnseis.Text = "";
                btnsiete.Text = "";
                btnocho.Text = "";
                btnueve.Text = "";
                btnuno.IsEnabled = true;
                btndos.IsEnabled = true;
                btntres.IsEnabled = true;
                btncuatro.IsEnabled = true;
                btncinco.IsEnabled = true;
                btnseis.IsEnabled = true;
                btnsiete.IsEnabled = true;
                btnocho.IsEnabled = true;
                btnueve.IsEnabled = true;
                count = 0;
            }
            else if ((btndos.Text == "O" && btncinco.Text == "O" && btnocho.Text == "O"))
            {
                await DisplayAlert("Ganaste", "Felicidades gano el jugador O", "Aceptar");
                btnuno.Text = "";
                btndos.Text = "";
                btntres.Text = "";
                btncuatro.Text = "";
                btncinco.Text = "";
                btnseis.Text = "";
                btnsiete.Text = "";
                btnocho.Text = "";
                btnueve.Text = "";
                btnuno.IsEnabled = true;
                btndos.IsEnabled = true;
                btntres.IsEnabled = true;
                btncuatro.IsEnabled = true;
                btncinco.IsEnabled = true;
                btnseis.IsEnabled = true;
                btnsiete.IsEnabled = true;
                btnocho.IsEnabled = true;
                btnueve.IsEnabled = true;
                count = 0;
            }

            else if ((btncuatro.Text == "O" && btncinco.Text == "O" && btnseis.Text == "O"))
            {
                await DisplayAlert("Ganaste", "Felicidades gano el jugador O", "Aceptar");
                btnuno.Text = "";
                btndos.Text = "";
                btntres.Text = "";
                btncuatro.Text = "";
                btncinco.Text = "";
                btnseis.Text = "";
                btnsiete.Text = "";
                btnocho.Text = "";
                btnueve.Text = "";
                btnuno.IsEnabled = true;
                btndos.IsEnabled = true;
                btntres.IsEnabled = true;
                btncuatro.IsEnabled = true;
                btncinco.IsEnabled = true;
                btnseis.IsEnabled = true;
                btnsiete.IsEnabled = true;
                btnocho.IsEnabled = true;
                btnueve.IsEnabled = true;
                count = 0;
            }
            else if ((btnuno.Text == "O" && btncinco.Text == "O" && btnueve.Text == "O"))
            {

                await DisplayAlert("Ganaste", "Felicidades gano el jugador O", "Aceptar");
                btnuno.Text = "";
                btndos.Text = "";
                btntres.Text = "";
                btncuatro.Text = "";
                btncinco.Text = "";
                btnseis.Text = "";
                btnsiete.Text = "";
                btnocho.Text = "";
                btnueve.Text = "";
                btnuno.IsEnabled = true;
                btndos.IsEnabled = true;
                btntres.IsEnabled = true;
                btncuatro.IsEnabled = true;
                btncinco.IsEnabled = true;
                btnseis.IsEnabled = true;
                btnsiete.IsEnabled = true;
                btnocho.IsEnabled = true;
                btnueve.IsEnabled = true;

                count = 0;
            }
            else if ((btntres.Text == "O" && btncinco.Text == "O" && btnsiete.Text == "O"))
            {
                await DisplayAlert("Ganaste", "Felicidades gano el jugador O", "Aceptar");
                btnuno.Text = "";
                btndos.Text = "";
                btntres.Text = "";
                btncuatro.Text = "";
                btncinco.Text = "";
                btnseis.Text = "";
                btnsiete.Text = "";
                btnocho.Text = "";
                btnueve.Text = "";
                btnuno.IsEnabled = true;
                btndos.IsEnabled = true;
                btntres.IsEnabled = true;
                btncuatro.IsEnabled =true;
                btncinco.IsEnabled = true;
                btnseis.IsEnabled = true;
                btnsiete.IsEnabled = true;
                btnocho.IsEnabled = true;
                btnueve.IsEnabled = true;
                count = 0;
            }


          

        }


        private void Button_Clicked_1(object sender, EventArgs e)
        {

        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {

        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {

        }

        private void Button_Clicked_4(object sender, EventArgs e)
        {

        }

        private void Button_Clicked_5(object sender, EventArgs e)
        {

        }

        private void Button_Clicked_6(object sender, EventArgs e)
        {

        }

        private void Button_Clicked_7(object sender, EventArgs e)
        {

        }

        private void Button_Clicked_8(object sender, EventArgs e)
        {

        }
    }
}
