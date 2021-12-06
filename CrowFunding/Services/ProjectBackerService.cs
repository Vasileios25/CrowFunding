using CrowFunding.Domain;
using CrowFunding.Dto;
using CrowFunding.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrowFunding.Service
{
    public class ProjectBackerService
    {
        private readonly CrmDbContext _db;

        public ProjectBackerService(CrmDbContext backer)
        {
            _db = backer;
        }


    }
}
