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
using DevExpress.Utils.MVVM.Services;
using System.Data.Entity;
using DevExpress.XtraGrid.Views.Base;

namespace TDU.CMS.Views.CardRequest
{
    [DevExpress.Utils.MVVM.UI.ViewType("CardRequestCollectionView")]
    public partial class CardRequestsView : DevExpress.XtraEditors.XtraUserControl
    {
        public CardRequestsView()
        {
            InitializeComponent();
            InitBindings();
        }

        private void InitBindings()
        {
            //throw new NotImplementedException();
            var fluentAPI = mvvmContext1.OfType<TDU.CMS.ViewModels.CustomCardRequestViewModel>();
            //fluentAPI.SetBinding(gridView1, gView => gView.LoadingPanelVisible, x => x.IsLoading);
            fluentAPI.SetBinding(gridControl1, gControl => gControl.DataSource, x => x.Entities);

            fluentAPI
                .WithEvent
                <DevExpress.XtraGrid.Views.Base.ColumnView,
                    DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs>(gridView1,
                        "FocusedRowObjectChanged")
                .SetBinding(x => x.SelectedEntity,
                    args => args.Row as Models.CardRequest,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));

            //fluentAPI.WithEvent<RowObjectEventArgs>(gridView1, "RowUpdated")
                //.EventToCommand(x => x.Save(null), new Func<RowObjectEventArgs, object>(e => e.Row));
        }
    }
}