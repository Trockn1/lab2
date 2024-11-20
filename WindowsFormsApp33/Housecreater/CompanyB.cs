using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp33
{
    public class CompanyB:DelivCreater
    {
      public override Deliv createDeliv()
        {
            return new DelivCompanyB();
        }
    }
}
