using System;
using DonSharpLite.Domain.Support;
using NHibernate.Type;

namespace DonSharpLite.NHibernateProvider
{
    [Serializable]
    public class StatusCustomType : PersistentEnumType
    {
        public StatusCustomType() : base(typeof (StatusType))
        {
        }
    }
}