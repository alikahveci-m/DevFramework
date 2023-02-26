using DevFramework.Core.DataAccess.NHibernate;
using NHibernate;
using System;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using System.Reflection;

namespace DevFramework.Northwind.DataAccess.Concrete.NHibernate.Helpers
{
    public class SqlServerHelper : NHibernateHelper
    {
        protected override ISessionFactory InitializeFactory()
        {
            return Fluently.Configure().Database(MsSqlConfiguration.MsSql2012
                .ConnectionString(c => c.FromConnectionStringWithKey("NorthwindContext"))
                ).Mappings(t => t.FluentMappings.AddFromAssembly
                (Assembly.GetExecutingAssembly())).BuildSessionFactory();
        }
    }
}
