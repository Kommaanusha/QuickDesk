﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketManagement.ViewModels
{
    public class ViewMenuRoleModel
    {
        public int SaveId { get; set; }
        public int? RoleId { get; set; }
        public string MenuName { get; set; }
        public string RoleName { get; set; }
        public bool Status { get; set; }
    }
}
