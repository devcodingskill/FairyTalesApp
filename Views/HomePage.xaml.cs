using FairyTalesApp.Model;
using FairyTalesApp.ViewModels;
using Microsoft.Maui.Handlers;
using System.Collections.ObjectModel;

namespace FairyTalesApp.Views;

public partial class HomePage : ContentPage
{
    public HomePage(HomePageViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;
        ModifySearchBar(); 
	}
    private void ModifySearchBar()
    {
        SearchBarHandler.Mapper.AppendToMapping("CustomSerchBarIconColor", (handler, view) =>
        {
#if ANDROID
            var context = handler.PlatformView.Context;
            var searchIconId = context.Resources.GetIdentifier("search_mag_icon", "id", context.PackageName);
            if(searchIconId != 0)
            {
              var searchIcon = handler.PlatformView.FindViewById<Android.Widget.ImageView>(searchIconId);
              searchIcon.SetColorFilter(Android.Graphics.Color.Rgb(172, 157 ,100),Android.Graphics.PorterDuff.Mode.SrcIn);
            }
#endif
        });
    }
}