using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using DevExpress.Persistent.Base;

namespace Brigader.Module.BusinessObjects.Brigader
{
    [DefaultClassOptions]
    [ImageName("BO_Contact")]
    public partial class Member
    {
        public Member(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
