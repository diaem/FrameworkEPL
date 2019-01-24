using System;
using FrameworkEPL.Abstract;
using FrameworkEPL.Abstract.Login;
using FrameworkEPL.Concret.SQL.Build;
using FrameworkEPL.Concret.SQL.Catalog;
using FrameworkEPL.Concret.SQL.Configuration;
using FrameworkEPL.Concret.SQL.Cupon;
using FrameworkEPL.Concret.SQL.Eviction;
using FrameworkEPL.Concret.SQL.FAQ;
using FrameworkEPL.Concret.SQL.Login;
using FrameworkEPL.Concret.SQL.PadLock;
using FrameworkEPL.Concret.SQL.Pricing;
using FrameworkEPL.Concret.SQL.QRCode;
using FrameworkEPL.Concret.SQL.RegulationUse;
using FrameworkEPL.Concret.SQL.Report;
using FrameworkEPL.Concret.SQL.School;
using FrameworkEPL.Concret.SQL.SearchUser;
using FrameworkEPL.Concret.SQL.Support;

namespace FrameworkEPL.Concret.SQL
{
    public class DataAccessSQL : IDataAccess
    {
        public IBuildDataAccess BuildDataAccess
        {
            get
            {
                return new BuildDataAccessSQL();
            }
        }

        public ICatalogDataAccess CatalogDataAccess
        {
            get
            {
                return new CatalogDataAccessSQL();
            }
        }

        public IConfigurationDataAccess ConfigurationDataAccess
        {
            get
            {
                return new ConfigurationDataAccessSQL();
            }
        }

        public ICuponDataAccess CuponDataAccess
        {
            get
            {
                return new CuponDataAccessSQL();
            }
        }

        public IEvictionDataAccess EvictionDataAccess
        {
            get
            {
                return new EvictionDataAccessSQL();
            }
        }

        public IFAQDataAccess FAQDataAccess
        {
            get
            {
                return new FAQDataAccessSQL();
            }
        }

        public IPadLockDataAccess PadLockDataAccess
        {
            get
            {
                return new PadLockDataAccessSQL();
            }
        }

        public IPricingDataAccess PricingDataAccess
        {
            get
            {
                return new PricingDataAccessSQL();
            }
        }

        public IQRCodeDataAccess QRCodeDataAccess
        {
            get
            {
                return new QRCodeDataAccessSQL();
            }
        }

        public IRegulationUseDataAccess RegulationUseDataAccess
        {
            get
            {
                return new RegulationUseDataAccessSQL();
            }
        }

        public IReportDataAccess ReportDataAccess
        {
            get
            {
                return new ReportDataAccessSQL();
            }
        }

        public ISchoolDataAccess SchoolDataAccess
        {
            get
            {
                return new SchoolDataAccessSQL();
            }
        }

        public ISearchUserDataAccess SearchUserDataAccess
        {
            get
            {
                return new SearchUserDataAccessSQL();
            }
        }

        public ISupportDataAccess SupportDataAccess
        {
            get
            {
                return new SupportDataAccessSQL();
            }
        }

        public ILoginDataAccess LoginDataAccess
        {
            get
            {
                return new LoginDataAccessSQL();
            }
        }
    }
}
