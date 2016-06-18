using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.ViewModel;
using TDU.CMS.CMSDbContextDataModel;
using TDU.CMS.Common;
using TDU.CMS.Models;

namespace TDU.CMS.ViewModels
{

    /// <summary>
    /// Represents the single Card object view model.
    /// </summary>
    public partial class CardViewModel : SingleObjectViewModel<Card, long, ICMSDbContextUnitOfWork>
    {

        /// <summary>
        /// Creates a new instance of CardViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static CardViewModel Create(IUnitOfWorkFactory<ICMSDbContextUnitOfWork> unitOfWorkFactory = null)
        {
            return ViewModelSource.Create(() => new CardViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the CardViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the CardViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected CardViewModel(IUnitOfWorkFactory<ICMSDbContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Cards, x => x.CardNumber)
        {
        }



    }
}
