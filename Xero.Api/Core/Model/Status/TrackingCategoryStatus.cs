﻿using System.Runtime.Serialization;

namespace Xero.Api.Core.Model.Status
{
    [DataContract(Namespace = "")]
    public enum TrackingCategoryStatus
    {
        [EnumMember(Value = "ACTIVE")]
        Active        
    }
}