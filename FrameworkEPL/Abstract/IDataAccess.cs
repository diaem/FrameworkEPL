using System;
using FrameworkEPL.Abstract.Login;

namespace FrameworkEPL.Abstract
{
    public interface IDataAccess
    {
        IBuildDataAccess            BuildDataAccess             { get; }
        ICatalogDataAccess          CatalogDataAccess           { get; }
        IConfigurationDataAccess    ConfigurationDataAccess     { get; }
        ICuponDataAccess            CuponDataAccess             { get; }
        IEvictionDataAccess         EvictionDataAccess          { get; }
        IFAQDataAccess              FAQDataAccess               { get; }
        IPadLockDataAccess          PadLockDataAccess           { get; }
        IPricingDataAccess          PricingDataAccess           { get; }
        IQRCodeDataAccess           QRCodeDataAccess            { get; }
        IRegulationUseDataAccess    RegulationUseDataAccess     { get; }
        IReportDataAccess           ReportDataAccess            { get; }
        ISchoolDataAccess           SchoolDataAccess            { get; }
        ISearchUserDataAccess       SearchUserDataAccess        { get; }
        ISupportDataAccess          SupportDataAccess           { get; }
        ILoginDataAccess            LoginDataAccess             { get; }
    }
}
