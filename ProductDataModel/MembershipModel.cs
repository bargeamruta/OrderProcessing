using System;
using System.Collections.Generic;
using System.Text;

namespace ProductDataModel
{
    public class MembershipModel:ProductBaseModel
    {
        public bool IsUpgrade { get; set; }
        public bool IsActivation { get; set; }
    }
}
