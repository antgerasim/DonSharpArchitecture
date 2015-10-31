using NHibernate.Mapping.ByCode;

namespace DonSharpLite.NHibernateProvider.Overrides
{
    internal interface IOverride
    {
        void Override(ModelMapper mapper);
    }
}
