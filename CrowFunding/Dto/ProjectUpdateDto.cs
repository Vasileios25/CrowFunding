﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrowFunding.Dto
{
    public class ProjectUpdateDto : ProjectDto
    {
        public UserDto Update { get; set; }
    }
}
