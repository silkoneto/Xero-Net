﻿using System;
using System.Runtime.Serialization;
using Xero.Api.Payroll.Australia.Model.Types;

namespace Xero.Api.Payroll.Australia.Model
{
    [DataContract(Namespace = "")]
    public class SuperannuationLine
    {
        [DataMember(Name = "SuperMembershipID")]
        public Guid SuperMembershipId { get; set; }

        [DataMember]
        public SuperannuationContributionType ContributionType { get; set; }

        [DataMember]
        public SuperannuationCalculationType CalculationType { get; set; }

        [DataMember]
        public decimal MinimumMonthlyEarnings { get; set; }

        [DataMember]
        public int ExpenseAccountCode { get; set; }

        [DataMember]
        public int LiabilityAccountCode { get; set; }

        [DataMember]
        public DateTime? PaymentDateForThisPeriod { get; set; }

        [DataMember]
        public decimal? Percentage { get; set; }

        [DataMember]
        public decimal? Amount { get; set; }
    }
}