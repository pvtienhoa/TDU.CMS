using DevExpress.Mvvm;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.DataModel.DesignTime;
using DevExpress.Mvvm.DataModel.EF6;
using System;
using System.Collections;
using System.Linq;
using TDU.CMS.DataBase;

namespace TDU.CMS.CMSDbContextDataModel
{

    /// <summary>
    /// Provides methods to obtain the relevant IUnitOfWorkFactory.
    /// </summary>
    public static class UnitOfWorkSource
    {

        /// <summary>
        /// Returns the IUnitOfWorkFactory implementation.
        /// </summary>
        public static IUnitOfWorkFactory<ICMSDbContextUnitOfWork> GetUnitOfWorkFactory()
        {
            return new DbUnitOfWorkFactory<ICMSDbContextUnitOfWork>(() => new CMSDbContextUnitOfWork(() => new CMSDbContext()));
        }
    }
}