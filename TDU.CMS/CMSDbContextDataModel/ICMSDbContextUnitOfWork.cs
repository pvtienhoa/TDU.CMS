using DevExpress.Mvvm.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using TDU.CMS.DataBase;
using TDU.CMS.Models;

namespace TDU.CMS.CMSDbContextDataModel
{

    /// <summary>
    /// ICMSDbContextUnitOfWork extends the IUnitOfWork interface with repositories representing specific entities.
    /// </summary>
    public interface ICMSDbContextUnitOfWork : IUnitOfWork
    {

        /// <summary>
        /// The CardRequest entities repository.
        /// </summary>
        IRepository<CardRequest, long> CardRequests { get; }

        /// <summary>
        /// The Card entities repository.
        /// </summary>
        IRepository<Card, long> Cards { get; }

        /// <summary>
        /// The Department entities repository.
        /// </summary>
        IRepository<Department, long> Departments { get; }

        /// <summary>
        /// The Employee entities repository.
        /// </summary>
        IRepository<Employee, long> Employees { get; }
    }
}
