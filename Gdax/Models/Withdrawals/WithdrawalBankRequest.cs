﻿using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Gdax.Models
{
    public class WithdrawalBankRequest
	{
		[JsonProperty("amount")]
		public Decimal Amount { get; set; }

		[JsonProperty("currency")]
		public String Currency { get; set; }

		[JsonProperty("payment_method_id")]
		public Guid Payment_Method_Id { get; set; }
	}
}
