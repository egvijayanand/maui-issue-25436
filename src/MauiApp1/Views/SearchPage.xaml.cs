﻿namespace MauiApp1.Views
{
    public partial class SearchPage : ContentPage
    {
        public SearchPage(SearchViewModel viewModel)
        {
            InitializeComponent();
            viewModel.Title = "Search";
            BindingContext = viewModel;
        }
    }
}
