﻿#if NETCOREAPP3_1

namespace Essensoft.AspNetCore.Payment.Alipay.Notify
{
    /// <summary>
    /// 收单资金结算到银行账户，结算成功的异步通知
    /// https://docs.open.alipay.com/msgapi_61/alipay.trade.settle.success/
    /// </summary>
    public class AlipayTradeSettleSuccessNotify : AlipayFromNotify
    {
    }
}

#endif
