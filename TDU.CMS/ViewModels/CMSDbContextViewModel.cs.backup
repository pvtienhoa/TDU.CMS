using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.ViewModel;
using TDU.CMS.CMSDbContextDataModel;

namespace TDU.CMS.ViewModels
{
    /// <summary>
    /// Represents the root POCO view model for the CMSDbContext data model.
    /// </summary>
    public partial class CMSDbContextViewModel : DocumentsViewModel<CMSDbContextModuleDescription, ICMSDbContextUnitOfWork>
    {

        const string TablesGroup = "Tables";

        const string ViewsGroup = "Views";

        /// <summary>
        /// Creates a new instance of CMSDbContextViewModel as a POCO view model.
        /// </summary>
        public static CMSDbContextViewModel Create()
        {
            return ViewModelSource.Create(() => new CMSDbContextViewModel());
        }

        /// <summary>
        /// Initializes a new instance of the CMSDbContextViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the CMSDbContextViewModel type without the POCO proxy factory.
        /// </summary>
        protected CMSDbContextViewModel()
            : base(UnitOfWorkSource.GetUnitOfWorkFactory())
        {
        }

        protected override CMSDbContextModuleDescription[] CreateModules()
        {
            return new CMSDbContextModuleDescription[] {
                new CMSDbContextModuleDescription("Card Requests", "CardRequestCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.CardRequests)),
                new CMSDbContextModuleDescription("Cards", "CardCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Cards)),
                new CMSDbContextModuleDescription("Departments", "DepartmentCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Departments)),
                new CMSDbContextModuleDescription("Employees", "EmployeeCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Employees)),
            };
        }



    }

    public partial class CMSDbContextModuleDescription : ModuleDescription<CMSDbContextModuleDescription>
    {
        public CMSDbContextModuleDescription(string title, string documentType, string group, Func<CMSDbContextModuleDescription, object> peekCollectionViewModelFactory = null)
            : base(title, documentType, group, peekCollectionViewModelFactory)
        {
        }
    }
}