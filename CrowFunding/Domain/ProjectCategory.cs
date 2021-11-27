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
        [Description("Fresh products")]
        FRESH,
        [Description("Food")]
        FOOD,
        [Description("Small snack")]
        SNACK,
        [Description("Beverages")]
        BEVERAGES,
        [Description("Other")]
        OTHER

    }
}
