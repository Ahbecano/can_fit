using Microsoft.Maui.Controls;
using System;

namespace CanFitApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnStartExerciseClicked(object sender, EventArgs e)
        {
            DisplayAlert("Egzersiz", "Egzersize başlıyorsunuz!", "Tamam");
        }

        private void OnViewProgressClicked(object sender, EventArgs e)
        {
            DisplayAlert("İlerleme", "İlerleme ekranı yakında gelecek!", "Tamam");
        }
    }
}
