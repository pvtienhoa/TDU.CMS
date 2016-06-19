using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace TDU.CMS.Views.CardRequest
{
    [DevExpress.Utils.MVVM.UI.ViewType("CardRequestView")]
    public partial class CardRequestEditFormView : DevExpress.XtraEditors.XtraUserControl
    {
        public CardRequestEditFormView()
        {
            InitializeComponent();
        }
    }
}
