using FairyTalesApp.Model;
using Microsoft.Maui.Handlers;
using System.Collections.ObjectModel;

namespace FairyTalesApp.Views;

public partial class HomePage : ContentPage
{
    public ObservableCollection<FairyTale> FairyTales =new ObservableCollection<FairyTale>();
    public ObservableCollection<FairyTale> FairyTales2 = new ObservableCollection<FairyTale>();
    public HomePage()
	{
		InitializeComponent();
        // ModifySearchBar();
        InitizeTale();
        BindingContext = this;
	}

    private void InitizeTale()
    {
       FairyTales = new ObservableCollection<FairyTale> { 
           new FairyTale {Name ="Cinderella", ReadTime = new TimeSpan(0,30,0), IsSave = false, ImageFairyTale = "" },
           new FairyTale {Name ="Snow White", ReadTime = new TimeSpan(0,30,0), IsSave = false, ImageFairyTale = "" },
           new FairyTale {Name ="Rapunzed", ReadTime = new TimeSpan(0,30,0), IsSave = false, ImageFairyTale = "" },
           new FairyTale {Name ="Little Red Riding Hood", ReadTime = new TimeSpan(0,30,0), IsSave = false, ImageFairyTale = "" },
           new FairyTale {Name ="Beauty and the Beast", ReadTime = new TimeSpan(0,30,0), IsSave = false, ImageFairyTale = "" },
       };
        FairyTales2 = new ObservableCollection<FairyTale> {
           new FairyTale {Name ="Cinderella", ReadTime = new TimeSpan(0,30,0), IsSave = false, ImageFairyTale = "" },
           new FairyTale {Name ="Snow White", ReadTime = new TimeSpan(0,30,0), IsSave = false, ImageFairyTale = "" },
           new FairyTale {Name ="Rapunzed", ReadTime = new TimeSpan(0,30,0), IsSave = false, ImageFairyTale = "" },
           new FairyTale {Name ="Little Red Riding Hood", ReadTime = new TimeSpan(0,30,0), IsSave = false, ImageFairyTale = "" },
           new FairyTale {Name ="Beauty and the Beast", ReadTime = new TimeSpan(0,30,0), IsSave = false, ImageFairyTale = "" },
       };

    }

    private void ModifySearchBar()
    {
        SearchBarHandler.Mapper.AppendToMapping("CustomSerchBarIconColor", (handler, view) =>
        {

//#if ANDROID
//            var context = handler.PlatformView.Context;
//            var searchIconId = context.Resources.GetIdentifier("search_mag_icon", "id", context.PackageName);
//            if(searchIconId != 0)
//            {
//              var searchIcon = handler.PlatformView.FindViewById<Android.Widget.ImageView>(searchIconId);
//             // searchIcon.SetColorFilter(Android.Graphics.Color.Rgb(172, 157 ,185),Android.Graphics.PorterDuff.d)
//            }
//#endif
        });



    }
}