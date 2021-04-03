namespace XCT_Bug.Views
{
    using System.ComponentModel;
    using Xamarin.Forms;
    using XCT_Bug.ViewModels;

    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}