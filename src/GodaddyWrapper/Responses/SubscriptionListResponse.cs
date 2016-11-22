﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GodaddyWrapper.Responses
{
    public class SubscriptionListResponse
    {
        public List<SubscriptionResponse> Subscriptions { get; set; }
        public PaginationResponse Pagination { get; set; }
    }
}
