using FairyTalesApp.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairyTalesApp.ViewModels
{
    public class HomePageViewModel : BaseViewModel
    {
        public ObservableCollection<FairyTale> FairyTales { get; set; } = new ObservableCollection<FairyTale>();
        public ObservableCollection<FairyTale> RecommentFairyTales { get; set; } = new ObservableCollection<FairyTale>();
        public HomePageViewModel()
        {
            InitizeTale();           
        }

        private void InitizeTale()
        {
           FairyTales = new ObservableCollection<FairyTale> {
           new FairyTale {Name ="Cinderella", ReadTime = new TimeSpan(1,30,0), IsSave = false, ImageFairyTale = "pan.jpg" },
           new FairyTale {Name ="Snow White", ReadTime = new TimeSpan(0,15,0), IsSave = false, ImageFairyTale = "tyler.jpg" },
           new FairyTale {Name ="Rapunzed", ReadTime = new TimeSpan(0,45,0), IsSave = false, ImageFairyTale = "alison.jpg" },
           new FairyTale {Name ="Little Red Riding Hood", ReadTime = new TimeSpan(0,25,0), IsSave = false, ImageFairyTale = "justin.jpg" },
           new FairyTale {Name ="Beauty and the Beast", ReadTime = new TimeSpan(0,50,0), IsSave = false, ImageFairyTale = "stephen.jpg" },
       };
           RecommentFairyTales = new ObservableCollection<FairyTale> {
           new FairyTale {Name ="Cinderella", ReadTime = new TimeSpan(0,30,0), IsSave = false, ImageFairyTale = "vinayak.jpg" },
           new FairyTale {Name ="Snow White", ReadTime = new TimeSpan(0,30,0), IsSave = false, ImageFairyTale = "taha.jpg" },
           new FairyTale {Name ="Rapunzed", ReadTime = new TimeSpan(0,30,0), IsSave = false, ImageFairyTale = "pan.jpg" },
           new FairyTale {Name ="Little Red Riding Hood", ReadTime = new TimeSpan(0,30,0), IsSave = false, ImageFairyTale = "justin.jpg" },
           new FairyTale {Name ="Beauty and the Beast", ReadTime = new TimeSpan(0,30,0), IsSave = false, ImageFairyTale = "alison.jpg" }, new FairyTale {Name ="Cinderella", ReadTime = new TimeSpan(1,30,0), IsSave = false, ImageFairyTale = "pan.jpg" },
           new FairyTale {Name ="Snow White", ReadTime = new TimeSpan(0,15,0), IsSave = false, ImageFairyTale = "tyler.jpg" },
           new FairyTale {Name ="Rapunzed", ReadTime = new TimeSpan(0,45,0), IsSave = false, ImageFairyTale = "alison.jpg" }
       };

        }
    }
}
