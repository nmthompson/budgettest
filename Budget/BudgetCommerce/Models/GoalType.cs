//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BudgetCommerce.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class GoalType
    {
        public int GoalTableID { get; set; }
        public string CustomerID { get; set; }
        public string GoalType1 { get; set; }
        public Nullable<System.DateTime> StartDateTime { get; set; }
        public Nullable<System.DateTime> EndDateTime { get; set; }
        public Nullable<decimal> AmountEntered { get; set; }
        public string GoalAchieved { get; set; }
        public string TenPercentToGoal { get; set; }
    
        public virtual CustomerInfo CustomerInfo { get; set; }
    }
}
