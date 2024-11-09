using System;
using Microsoft.Maui.Controls;

namespace MauiAppHotel.Views
{
    public partial class HospedagemContratada : ContentPage
    {
        
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public int Adultos { get; set; }
        public int Criancas { get; set; }


        public HospedagemContratada(DateTime checkIn, DateTime checkOut, int adultos, int criancas)
        {
            InitializeComponent();
            CheckInDate = checkIn;
            CheckOutDate = checkOut;
            Adultos = adultos;
            Criancas = criancas;
            DisplayDates();
        }

        
        private void DisplayDates()
        {
            
            CheckInLabel.Text = CheckInDate.ToString("dd/MM/yyyy");
            CheckOutLabel.Text = CheckOutDate.ToString("dd/MM/yyyy");

            AdultosLabel.Text = Adultos.ToString();
            CriancasLabel.Text = Criancas.ToString();

            int days = (CheckOutDate - CheckInDate).Days;
            EstadiaLabel.Text = $"{days} noites";
        }

        
        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PopAsync();
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops", ex.Message, "OK");
            }
        }
    }
}