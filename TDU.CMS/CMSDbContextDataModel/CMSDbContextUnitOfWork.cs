using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.DataModel.EF6;
using System;
using System.Collections.Generic;
using System.Linq;
using TDU.CMS.DataBase;
using TDU.CMS.Models;

namespace TDU.CMS.CMSDbContextDataModel
{

    /// <summary>
    /// A CMSDbContextUnitOfWork instance that represents the run-time implementation of the ICMSDbContextUnitOfWork interface.
    /// </summary>
    public class CMSDbContextUnitOfWork : DbUnitOfWork<CMSDbContext>, ICMSDbContextUnitOfWork
    {

        public CMSDbContextUnitOfWork(Func<CMSDbContext> contextFactory)
            : base(contextFactory)
        {
        }

        IRepository<CardRequest, long> ICMSDbContextUnitOfWork.CardRequests
        {
            get { return GetRepository(x => x.Set<CardRequest>(), (CardRequest x) => x.ID); }
        }

        IRepository<Card, long> ICMSDbContextUnitOfWork.Cards
        {
            get { return GetRepository(x => x.Set<Card>(), (Card x) => x.ID); }
        }

        IRepository<Department, long> ICMSDbContextUnitOfWork.Departments
        {
            get { return GetRepository(x => x.Set<Department>(), (Department x) => x.ID); }
        }

        IRepository<Employee, long> ICMSDbContextUnitOfWork.Employees
        {
            get { return GetRepository(x => x.Set<Employee>(), (Employee x) => x.ID); }
        }

        IRepository<RequestHistory, long> ICMSDbContextUnitOfWork.RequestHistories
        {
            get { return GetRepository(x => x.Set<RequestHistory>(), (RequestHistory x) => x.ID); }
        }
    }
}
