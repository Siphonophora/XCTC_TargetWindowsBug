namespace XCT_Bug.Views
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;

    using XCT_Bug.Models;
    using XCT_Bug.ViewModels;

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