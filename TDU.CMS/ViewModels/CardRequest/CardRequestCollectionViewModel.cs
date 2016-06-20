using System;
using System.Linq;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.ViewModel;
using TDU.CMS.CMSDbContextDataModel;
using TDU.CMS.Common;
using TDU.CMS.Models;

namespace TDU.CMS.ViewModels
{

    /// <summary>
    /// Represents the CardRequests collection view model.
    /// </summary>
    public partial class CardRequestCollectionViewModel : CollectionViewModel<Models.CardRequest, long, ICMSDbContextUnitOfWork>
    {

        /// <summary>
        /// Creates a new instance of CardRequestCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static CardRequestCollectionViewModel Create(IUnitOfWorkFactory<ICMSDbContextUnitOfWork> unitOfWorkFactory = null)
        {
            return ViewModelSource.Create(() => new CardRequestCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the CardRequestCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the CardRequestCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected CardRequestCollectionViewModel(IUnitOfWorkFactory<ICMSDbContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.CardRequests)
        {
        }
    }
}