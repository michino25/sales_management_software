﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sales_management_software
{
    public class KhoBLL
    {
        public static List<KhoDTO> EF_GetAll()
        {
            return KhoDAL.EF_GetAll();
        }
    }
}