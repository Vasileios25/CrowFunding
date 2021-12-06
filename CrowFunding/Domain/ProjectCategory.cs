using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrowFunding.Domain
{
    public enum ProjectCategory
    {
        [Description("Technology stuff")]
        TECH,
        [Description("Science stuff")]
        SCIENCE,
        [Description("Car stuff")]
        CARS,
        [Description("Video Games stuff")]
        VIDEO_GAMES,
        [Description ("Art stuff")]
        ART,
        [Description("Food stuff")]
        FOOD,
        [Description ("Kids stuff")]
        FOR_KIDS,
        [Description ("Cinema stuff")]
        MOVIES,
        [Description("Other")]
        OTHER

   
    
    }
}
