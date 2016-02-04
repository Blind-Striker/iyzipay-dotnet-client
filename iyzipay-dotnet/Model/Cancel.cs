﻿using Iyzipay.Request;
using System;

namespace Iyzipay.Model
{
    public class Cancel : IyzipayResource
    {
        public String PaymentId { get; set; }
        public String Price { get; set; }

        public static Cancel Create(CreateCancelRequest request, Options options)
        {
            return RestHttpClient.Create().Post<Cancel>(options.BaseUrl + "/payment/iyzipos/cancel", GetHttpHeaders(request, options), request);
        }
    }
}