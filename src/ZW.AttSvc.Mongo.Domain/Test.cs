using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace ZW.AttSvc.Mongo
{
    public class Test: AggregateRoot<Guid>, IMultiTenant
    {
        public virtual Guid? TenantId { get; set; }
        public virtual string Name { get; set; }
    }
}
