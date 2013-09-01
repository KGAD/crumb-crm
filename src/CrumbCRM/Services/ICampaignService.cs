﻿using CreativeCRM.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrumbCRM.Services
{
    public interface ICampaignService
    {
        Campaign GetByID(int id);
        List<Campaign> GetAll(CampaignFilterOptions options = null);
        int Save(Campaign campaign);
    }
}
