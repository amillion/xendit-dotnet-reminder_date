﻿namespace XenditTest.EWalletChargeTest
{
    using System.Collections.Generic;
    using Xendit.net.Enum;
    using Xendit.net.Model;
    using Xendit.net.Model.EWallet;
    using Xendit.net.Struct;

    internal class Constant
    {
        internal static readonly EWalletCharge ExpectedEWalletCharge = new EWalletCharge
        {
            Id = "charge-id",
            BusinessId = "5f218745736e619164dc8608",
            ReferenceId = "test-reference-id",
            Status = EWalletEnum.Status.Pending,
            Currency = Xendit.net.Enum.Currency.IDR,
            ChargeAmount = 1000,
            CaptureAmount = 1000,
            CheckoutMethod = EWalletEnum.CheckoutMethod.OneTimePayment,
            ChannelCode = EWalletEnum.ChannelCode.IdShopeepay,
            ChannelProperties = new Dictionary<string, string>()
            {
                { "success_redirect_url",  "https://dashboard.xendit.co/register/1" },
            },
            Actions = new Dictionary<string, string>()
            {
                { "desktop_web_checkout_url",  "https://dashboard.xendit.co/register/1" },
                { "mobile_web_checkout_url", null },
                { "mobile_deeplink_checkout_url",  "https://deeplinkcheckout.this/" },
                { "qr_checkout_string", "ID123XenditQRTest321DI" },
            },
            IsRedirectRequired = true,
            CallbackUrl = "https://calling-back.com/xendit/shopeepay",
            Created = "2017-07-21T17:32:28Z",
            Updated = "2017-07-21T17:32:28Z",
            VoidedAt = null,
            CaptureNow = true,
            CustomerId = null,
            PaymentMethodId = null,
            FailureCode = null,
            Basket = null,
            Metadata = new Dictionary<string, object>()
            {
                { "branch_code", "tree_branch" },
            },
        };

        internal static readonly string ReferenceId = "test-reference-id";
        internal static readonly long Amount = 1000;
        internal static readonly EWalletChargeProperties ChannelProperties = new EWalletChargeProperties
        {
            SuccessRedirectUrl = "https://dashboard.xendit.co/register/1",
        };

        internal static readonly EWalletChargeParameter EWalletBody = new EWalletChargeParameter
        {
            ReferenceId = ReferenceId,
            Currency = Xendit.net.Enum.Currency.IDR,
            Amount = Amount,
            CheckoutMethod = EWalletEnum.CheckoutMethod.OneTimePayment,
            ChannelCode = EWalletEnum.ChannelCode.IdShopeepay,
            ChannelProperties = ChannelProperties,
        };

        internal static readonly HeaderParameter ApiVersionHeaders = new HeaderParameter
        {
            XApiVersion = ApiVersion.Version20210125,
        };

        internal static readonly HeaderParameter CustomHeaders = new HeaderParameter
        {
            ForUserId = "user-id",
            XApiVersion = ApiVersion.Version20210125,
        };

        internal static readonly string ChargeId = "charge-id";
        internal static readonly string EWalletChargeUrl = "https://api.xendit.co/ewallets/charges";
        internal static readonly string GetChargeUrl = string.Format("{0}/{1}", EWalletChargeUrl, ChargeId);
    }
}
