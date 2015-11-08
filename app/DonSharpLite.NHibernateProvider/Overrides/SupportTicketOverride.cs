using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DonSharpLite.Domain.Support;
using NHibernate.Mapping.ByCode;

namespace DonSharpLite.NHibernateProvider.Overrides
{
   public class SupportTicketOverride :IOverride
    {
       public void Override(ModelMapper mapper)
       {
           mapper.Class<SupportTicket>(map => map.Property(x => x.Status,
               status =>
               {
                   status.Type<StatusCustomType>();
                   status.Column("StatusTypeFk");
               }));
       }
    }
}
