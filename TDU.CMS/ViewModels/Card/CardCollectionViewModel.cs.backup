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
    /// Represents the Cards collection view model.
    /// </summary>
    public partial class CardCollectionViewModel : CollectionViewModel<Card, long, ICMSDbContextUnitOfWork>
    {

        /// <summary>
        /// Creates a new instance of CardCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static CardCollectionViewModel Create(IUnitOfWorkFactory<ICMSDbContextUnitOfWork> unitOfWorkFactory = null)
        {
            return ViewModelSource.Create(() => new CardCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the CardCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the CardCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected CardCollectionViewModel(IUnitOfWorkFactory<ICMSDbContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Cards)
        {
        }
    }
}