﻿
using System;
using System.Diagnostics;
using Gdax.Serialization;
using Newtonsoft.Json;

namespace Gdax.Models
{
	public partial class PaymentMethod
	{
		[JsonProperty("allow_withdraw")]
		public bool AllowWithdraw { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("allow_deposit")]
		public bool AllowDeposit { get; set; }

		[JsonProperty("allow_buy")]
		public bool AllowBuy { get; set; }

		[JsonProperty("allow_sell")]
		public bool AllowSell { get; set; }

		[JsonProperty("id")]
		public Guid Id { get; set; }

		[JsonProperty("currency")]
		public string Currency { get; set; }

		[JsonProperty("limits")]
		public Limits Limits { get; set; }

		[JsonProperty("primary_sell")]
		public bool PrimarySell { get; set; }

		[JsonProperty("primary_buy")]
		public bool PrimaryBuy { get; set; }

		[JsonProperty("type")]
		public string Type { get; set; }
	}

	public partial class Limits
	{
		[JsonProperty("deposit")]
		public Buy[] Deposit { get; set; }

		[JsonProperty("buy")]
		public Buy[] Buy { get; set; }

		[JsonProperty("instant_buy")]
		public Buy[] InstantBuy { get; set; }

		[JsonProperty("sell")]
		public Buy[] Sell { get; set; }
	}

	public partial class Buy
	{
		[JsonProperty("remaining")]
		public Remaining Remaining { get; set; }

		[JsonProperty("period_in_days")]
		public long PeriodInDays { get; set; }

		[JsonProperty("total")]
		public Remaining Total { get; set; }
	}

	public partial class Remaining
	{
		[JsonProperty("amount")]
		public Decimal Amount { get; set; }

		[JsonProperty("currency")]
		public string Currency { get; set; }
	}


	public partial class PaymentMethod
	{
		public static PaymentMethod[] FromJson(string json)
		{
			return JsonConvert.DeserializeObject<PaymentMethod[]>(json, Converter.Settings);
		}
	}

	public static class SerializePaymentMethods
	{
		public static string ToJson(this PaymentMethod[] self)
		{
			return JsonConvert.SerializeObject(self, Converter.Settings);
		}
	}
}
