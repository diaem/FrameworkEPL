using System;
using FrameworkEPL.Abstract;
using FrameworkEPL.Abstract.Login;
using FrameworkEPL.Concret.Mock.Build;
using FrameworkEPL.Concret.Mock.Catalog;
using FrameworkEPL.Concret.Mock.Configuration;
using FrameworkEPL.Concret.Mock.Cupon;
using FrameworkEPL.Concret.Mock.Eviction;
using FrameworkEPL.Concret.Mock.FAQ;
using FrameworkEPL.Concret.Mock.Login;
using FrameworkEPL.Concret.Mock.PadLock;
using FrameworkEPL.Concret.Mock.Pricing;
using FrameworkEPL.Concret.Mock.QRCode;
using FrameworkEPL.Concret.Mock.RegulationUse;
using FrameworkEPL.Concret.Mock.Report;
using FrameworkEPL.Concret.Mock.School;
using FrameworkEPL.Concret.Mock.SearchUser;
using FrameworkEPL.Concret.Mock.Support;

namespace FrameworkEPL.Concret.Mock
{
    public class DataAccessMock : IDataAccess
    {
        public IBuildDataAccess BuildDataAccess
        {
            get
            {
                return new BuildDataAccessMock();
            }
        }

        public ICatalogDataAccess CatalogDataAccess
        {
            get
            {
                return new CatalogDataAccessMock();
            }
        }

        public IConfigurationDataAccess ConfigurationDataAccess
        {
            get
            {
                return new ConfigurationDataAccessMock();
            }
        }

        public ICuponDataAccess CuponDataAccess
        {
            get
            {
                return new CuponDataAccessMock();
            }
        }

        public IEvictionDataAccess EvictionDataAccess
        {
            get
            {
                return new EvictionDataAccessMock();
            }
        }

        public IFAQDataAccess FAQDataAccess
        {
            get
            {
                return new FAQDataAccessMock();
            }
        }

        public IPadLockDataAccess PadLockDataAccess
        {
            get
            {
                return new PadLockDataAccessMock();
            }
        }

        public IPricingDataAccess PricingDataAccess
        {
            get
            {
                return new PricingDataAccessMock();
            }
        }

        public IQRCodeDataAccess QRCodeDataAccess
        {
            get
            {
                return new QRCodeDataAccessMock();
            }
        }

        public IRegulationUseDataAccess RegulationUseDataAccess
        {
            get
            {
                return new RegulationUseDataAccessMock();
            }
        }

        public IReportDataAccess ReportDataAccess
        {
            get
            {
                return new ReportDataAccessMock();
            }
        }

        public ISchoolDataAccess SchoolDataAccess
        {
            get
            {
                return new SchoolDataAccessMock();
            }
        }

        public ISearchUserDataAccess SearchUserDataAccess
        {
            get
            {
                return new SearchUserDataAccessMock();
            }
        }

        public ISupportDataAccess SupportDataAccess
        {
            get
            {
                return new SupportDataAccessMock();
            }
        }

        public ILoginDataAccess LoginDataAccess
        {
            get
            {
                return new LoginDataAccessMock();
            }
        }
    }
}
