﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;

namespace TDevs.Domain.Entities
{
    public class Role : IdentityRole
    {
        public string Description { get; set; }

        public string Predefined { get; set; }

        #region Permission
        public bool AccountCanEdit { get; set; }

        public bool AccountCanView { get; set; }

        public bool AgentCanCreate { get; set; }
        public bool MedallionCanDelete { get; set; }

        public bool ViewMemberData { get; set; }
        public bool EditMemberData { get; set; }

        public bool DeleteMemberData { get; set; }

        public bool ViewMemberCashiering { get; set; }
        public bool BillOutMember { get; set; }

        public bool ViewDeletedMembers { get; set; }

        public bool ReportCanMakeReport { get; set; }

        public bool ReportCanMakeEndOfDayTrans { get; set; }

        public bool RoleCanViewList { get; set; }

        public bool RoleCanEdit { get; set; }
        public bool RoleCanCreate { get; set; }
        public bool RoleCanDelete { get; set; }


        public bool UserCanViewList { get; set; }
        public bool UserCanEdit { get; set; }
        public bool UserCanCreate { get; set; }
        public bool UserCanDelete { get; set; }

        public bool ReferenceCanEdit { get; set; }

        public bool AllowDashboard { get; set; }
       
        public virtual ICollection<IdentityUserRole> UserRoles { get; set; }
        #endregion
    }
}
