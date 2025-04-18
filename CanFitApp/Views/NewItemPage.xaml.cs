﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using CanFitApp.Models;
using CanFitApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CanFitApp.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}