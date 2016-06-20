using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDU.CMS.Common;
using TDU.CMS.Models;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataModel;

namespace TDU.CMS.ViewModels
{
    public class CustomCardRequestViewModel
    {
        public virtual ObservableCollection<Models.CardRequest> Entities { get; set; }
        public virtual CardRequest SelectedEntity { get; set; }

        public CustomCardRequestViewModel()
        {
            Entities = new ObservableCollection<Models.CardRequest>();
        }
    }
}