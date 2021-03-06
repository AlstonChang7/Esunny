/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.12
 *
 * This file is not intended to be easily readable and contains a number of
 * coding conventions designed to improve portability and efficiency. Do not make
 * changes to this file unless you know what you are doing--modify the SWIG
 * interface file instead.
 * ----------------------------------------------------------------------------- */

#ifndef SWIG_TapTradeWrapper_WRAP_H_
#define SWIG_TapTradeWrapper_WRAP_H_

class SwigDirector_ITapTradeAPINotify : public ITapTrade::ITapTradeAPINotify, public Swig::Director {

public:
    SwigDirector_ITapTradeAPINotify();
    virtual void TAP_CDECL OnConnect();
    virtual void TAP_CDECL OnRspLogin(ITapTrade::TAPIINT32 errorCode, ITapTrade::TapAPITradeLoginRspInfo const *loginRspInfo);
    virtual void TAP_CDECL OnRtnContactInfo(ITapTrade::TAPIINT32 errorCode, ITapTrade::TAPIYNFLAG isLast, ITapTrade::TAPISTR_40 const ContactInfo);
    virtual void TAP_CDECL OnRspRequestVertificateCode(ITapTrade::TAPIUINT32 sessionID, ITapTrade::TAPIINT32 errorCode, ITapTrade::TapAPIRequestVertificateCodeRsp const *rsp);
    virtual void TAP_CDECL OnExpriationDate(ITapTrade::TAPIDATE date, int days);
    virtual void TAP_CDECL OnAPIReady(ITapTrade::TAPIINT32 errorCode);
    virtual void TAP_CDECL OnDisconnect(ITapTrade::TAPIINT32 reasonCode);
    virtual void TAP_CDECL OnRspChangePassword(ITapTrade::TAPIUINT32 sessionID, ITapTrade::TAPIINT32 errorCode);
    virtual void TAP_CDECL OnRspAuthPassword(ITapTrade::TAPIUINT32 sessionID, ITapTrade::TAPIINT32 errorCode);
    virtual void TAP_CDECL OnRspQryTradingDate(ITapTrade::TAPIUINT32 sessionID, ITapTrade::TAPIINT32 errorCode, ITapTrade::TapAPITradingCalendarQryRsp const *info);
    virtual void TAP_CDECL OnRspSetReservedInfo(ITapTrade::TAPIUINT32 sessionID, ITapTrade::TAPIINT32 errorCode, ITapTrade::TAPISTR_50 const info);
    virtual void TAP_CDECL OnRspQryAccount(ITapTrade::TAPIUINT32 sessionID, ITapTrade::TAPIUINT32 errorCode, ITapTrade::TAPIYNFLAG isLast, ITapTrade::TapAPIAccountInfo const *info);
    virtual void TAP_CDECL OnRspQryFund(ITapTrade::TAPIUINT32 sessionID, ITapTrade::TAPIINT32 errorCode, ITapTrade::TAPIYNFLAG isLast, ITapTrade::TapAPIFundData const *info);
    virtual void TAP_CDECL OnRtnFund(ITapTrade::TapAPIFundData const *info);
    virtual void TAP_CDECL OnRspQryExchange(ITapTrade::TAPIUINT32 sessionID, ITapTrade::TAPIINT32 errorCode, ITapTrade::TAPIYNFLAG isLast, ITapTrade::TapAPIExchangeInfo const *info);
    virtual void TAP_CDECL OnRspQryCommodity(ITapTrade::TAPIUINT32 sessionID, ITapTrade::TAPIINT32 errorCode, ITapTrade::TAPIYNFLAG isLast, ITapTrade::TapAPICommodityInfo const *info);
    virtual void TAP_CDECL OnRspQryContract(ITapTrade::TAPIUINT32 sessionID, ITapTrade::TAPIINT32 errorCode, ITapTrade::TAPIYNFLAG isLast, ITapTrade::TapAPITradeContractInfo const *info);
    virtual void TAP_CDECL OnRtnContract(ITapTrade::TapAPITradeContractInfo const *info);
    virtual void TAP_CDECL OnRspOrderAction(ITapTrade::TAPIUINT32 sessionID, ITapTrade::TAPIINT32 errorCode, ITapTrade::TapAPIOrderActionRsp const *info);
    virtual void TAP_CDECL OnRtnOrder(ITapTrade::TapAPIOrderInfoNotice const *info);
    virtual void TAP_CDECL OnRspQryOrder(ITapTrade::TAPIUINT32 sessionID, ITapTrade::TAPIINT32 errorCode, ITapTrade::TAPIYNFLAG isLast, ITapTrade::TapAPIOrderInfo const *info);
    virtual void TAP_CDECL OnRspQryOrderProcess(ITapTrade::TAPIUINT32 sessionID, ITapTrade::TAPIINT32 errorCode, ITapTrade::TAPIYNFLAG isLast, ITapTrade::TapAPIOrderInfo const *info);
    virtual void TAP_CDECL OnRspQryFill(ITapTrade::TAPIUINT32 sessionID, ITapTrade::TAPIINT32 errorCode, ITapTrade::TAPIYNFLAG isLast, ITapTrade::TapAPIFillInfo const *info);
    virtual void TAP_CDECL OnRtnFill(ITapTrade::TapAPIFillInfo const *info);
    virtual void TAP_CDECL OnRspQryPosition(ITapTrade::TAPIUINT32 sessionID, ITapTrade::TAPIINT32 errorCode, ITapTrade::TAPIYNFLAG isLast, ITapTrade::TapAPIPositionInfo const *info);
    virtual void TAP_CDECL OnRtnPosition(ITapTrade::TapAPIPositionInfo const *info);
    virtual void TAP_CDECL OnRspQryPositionSummary(ITapTrade::TAPIUINT32 sessionID, ITapTrade::TAPIINT32 errorCode, ITapTrade::TAPIYNFLAG isLast, ITapTrade::TapAPIPositionSummary const *info);
    virtual void TAP_CDECL OnRtnPositionSummary(ITapTrade::TapAPIPositionSummary const *info);
    virtual void TAP_CDECL OnRtnPositionProfit(ITapTrade::TapAPIPositionProfitNotice const *info);
    virtual void TAP_CDECL OnRspQryCurrency(ITapTrade::TAPIUINT32 sessionID, ITapTrade::TAPIINT32 errorCode, ITapTrade::TAPIYNFLAG isLast, ITapTrade::TapAPICurrencyInfo const *info);
    virtual void TAP_CDECL OnRspQryTradeMessage(ITapTrade::TAPIUINT32 sessionID, ITapTrade::TAPIINT32 errorCode, ITapTrade::TAPIYNFLAG isLast, ITapTrade::TapAPITradeMessage const *info);
    virtual void TAP_CDECL OnRtnTradeMessage(ITapTrade::TapAPITradeMessage const *info);
    virtual void TAP_CDECL OnRspQryHisOrder(ITapTrade::TAPIUINT32 sessionID, ITapTrade::TAPIINT32 errorCode, ITapTrade::TAPIYNFLAG isLast, ITapTrade::TapAPIHisOrderQryRsp const *info);
    virtual void TAP_CDECL OnRspQryHisOrderProcess(ITapTrade::TAPIUINT32 sessionID, ITapTrade::TAPIINT32 errorCode, ITapTrade::TAPIYNFLAG isLast, ITapTrade::TapAPIHisOrderProcessQryRsp const *info);
    virtual void TAP_CDECL OnRspQryHisMatch(ITapTrade::TAPIUINT32 sessionID, ITapTrade::TAPIINT32 errorCode, ITapTrade::TAPIYNFLAG isLast, ITapTrade::TapAPIHisMatchQryRsp const *info);
    virtual void TAP_CDECL OnRspQryHisPosition(ITapTrade::TAPIUINT32 sessionID, ITapTrade::TAPIINT32 errorCode, ITapTrade::TAPIYNFLAG isLast, ITapTrade::TapAPIHisPositionQryRsp const *info);
    virtual void TAP_CDECL OnRspQryHisDelivery(ITapTrade::TAPIUINT32 sessionID, ITapTrade::TAPIINT32 errorCode, ITapTrade::TAPIYNFLAG isLast, ITapTrade::TapAPIHisDeliveryQryRsp const *info);
    virtual void TAP_CDECL OnRspQryAccountCashAdjust(ITapTrade::TAPIUINT32 sessionID, ITapTrade::TAPIINT32 errorCode, ITapTrade::TAPIYNFLAG isLast, ITapTrade::TapAPIAccountCashAdjustQryRsp const *info);
    virtual void TAP_CDECL OnRspQryBill(ITapTrade::TAPIUINT32 sessionID, ITapTrade::TAPIINT32 errorCode, ITapTrade::TAPIYNFLAG isLast, ITapTrade::TapAPIBillQryRsp const *info);
    virtual void TAP_CDECL OnRspQryAccountFeeRent(ITapTrade::TAPIUINT32 sessionID, ITapTrade::TAPIINT32 errorCode, ITapTrade::TAPIYNFLAG isLast, ITapTrade::TapAPIAccountFeeRentQryRsp const *info);
    virtual void TAP_CDECL OnRspQryAccountMarginRent(ITapTrade::TAPIUINT32 sessionID, ITapTrade::TAPIINT32 errorCode, ITapTrade::TAPIYNFLAG isLast, ITapTrade::TapAPIAccountMarginRentQryRsp const *info);
    virtual void TAP_CDECL OnRspHKMarketOrderInsert(ITapTrade::TAPIUINT32 sessionID, ITapTrade::TAPIINT32 errorCode, ITapTrade::TapAPIOrderMarketInsertRsp const *info);
    virtual void TAP_CDECL OnRspHKMarketOrderDelete(ITapTrade::TAPIUINT32 sessionID, ITapTrade::TAPIINT32 errorCode, ITapTrade::TapAPIOrderMarketDeleteRsp const *info);
    virtual void TAP_CDECL OnHKMarketQuoteNotice(ITapTrade::TapAPIOrderQuoteMarketNotice const *info);
    virtual void TAP_CDECL OnRspOrderLocalRemove(ITapTrade::TAPIUINT32 sessionID, ITapTrade::TAPIINT32 errorCode, ITapTrade::TapAPIOrderLocalRemoveRsp const *info);
    virtual void TAP_CDECL OnRspOrderLocalInput(ITapTrade::TAPIUINT32 sessionID, ITapTrade::TAPIINT32 errorCode, ITapTrade::TapAPIOrderLocalInputRsp const *info);
    virtual void TAP_CDECL OnRspOrderLocalModify(ITapTrade::TAPIUINT32 sessionID, ITapTrade::TAPIINT32 errorCode, ITapTrade::TapAPIOrderLocalModifyRsp const *info);
    virtual void TAP_CDECL OnRspOrderLocalTransfer(ITapTrade::TAPIUINT32 sessionID, ITapTrade::TAPIINT32 errorCode, ITapTrade::TapAPIOrderLocalTransferRsp const *info);
    virtual void TAP_CDECL OnRspFillLocalInput(ITapTrade::TAPIUINT32 sessionID, ITapTrade::TAPIINT32 errorCode, ITapTrade::TapAPIFillLocalInputRsp const *info);
    virtual void TAP_CDECL OnRspFillLocalRemove(ITapTrade::TAPIUINT32 sessionID, ITapTrade::TAPIINT32 errorCode, ITapTrade::TapAPIFillLocalRemoveRsp const *info);

    typedef void (SWIGSTDCALL* SWIG_Callback0_t)();
    typedef void (SWIGSTDCALL* SWIG_Callback1_t)(int, void *);
    typedef void (SWIGSTDCALL* SWIG_Callback2_t)(int, char, char *);
    typedef void (SWIGSTDCALL* SWIG_Callback3_t)(unsigned int, int, void *);
    typedef void (SWIGSTDCALL* SWIG_Callback4_t)(char *, int);
    typedef void (SWIGSTDCALL* SWIG_Callback5_t)(int);
    typedef void (SWIGSTDCALL* SWIG_Callback6_t)(int);
    typedef void (SWIGSTDCALL* SWIG_Callback7_t)(unsigned int, int);
    typedef void (SWIGSTDCALL* SWIG_Callback8_t)(unsigned int, int);
    typedef void (SWIGSTDCALL* SWIG_Callback9_t)(unsigned int, int, void *);
    typedef void (SWIGSTDCALL* SWIG_Callback10_t)(unsigned int, int, char *);
    typedef void (SWIGSTDCALL* SWIG_Callback11_t)(unsigned int, unsigned int, char, void *);
    typedef void (SWIGSTDCALL* SWIG_Callback12_t)(unsigned int, int, char, void *);
    typedef void (SWIGSTDCALL* SWIG_Callback13_t)(void *);
    typedef void (SWIGSTDCALL* SWIG_Callback14_t)(unsigned int, int, char, void *);
    typedef void (SWIGSTDCALL* SWIG_Callback15_t)(unsigned int, int, char, void *);
    typedef void (SWIGSTDCALL* SWIG_Callback16_t)(unsigned int, int, char, void *);
    typedef void (SWIGSTDCALL* SWIG_Callback17_t)(void *);
    typedef void (SWIGSTDCALL* SWIG_Callback18_t)(unsigned int, int, void *);
    typedef void (SWIGSTDCALL* SWIG_Callback19_t)(void *);
    typedef void (SWIGSTDCALL* SWIG_Callback20_t)(unsigned int, int, char, void *);
    typedef void (SWIGSTDCALL* SWIG_Callback21_t)(unsigned int, int, char, void *);
    typedef void (SWIGSTDCALL* SWIG_Callback22_t)(unsigned int, int, char, void *);
    typedef void (SWIGSTDCALL* SWIG_Callback23_t)(void *);
    typedef void (SWIGSTDCALL* SWIG_Callback24_t)(unsigned int, int, char, void *);
    typedef void (SWIGSTDCALL* SWIG_Callback25_t)(void *);
    typedef void (SWIGSTDCALL* SWIG_Callback26_t)(unsigned int, int, char, void *);
    typedef void (SWIGSTDCALL* SWIG_Callback27_t)(void *);
    typedef void (SWIGSTDCALL* SWIG_Callback28_t)(void *);
    typedef void (SWIGSTDCALL* SWIG_Callback29_t)(unsigned int, int, char, void *);
    typedef void (SWIGSTDCALL* SWIG_Callback30_t)(unsigned int, int, char, void *);
    typedef void (SWIGSTDCALL* SWIG_Callback31_t)(void *);
    typedef void (SWIGSTDCALL* SWIG_Callback32_t)(unsigned int, int, char, void *);
    typedef void (SWIGSTDCALL* SWIG_Callback33_t)(unsigned int, int, char, void *);
    typedef void (SWIGSTDCALL* SWIG_Callback34_t)(unsigned int, int, char, void *);
    typedef void (SWIGSTDCALL* SWIG_Callback35_t)(unsigned int, int, char, void *);
    typedef void (SWIGSTDCALL* SWIG_Callback36_t)(unsigned int, int, char, void *);
    typedef void (SWIGSTDCALL* SWIG_Callback37_t)(unsigned int, int, char, void *);
    typedef void (SWIGSTDCALL* SWIG_Callback38_t)(unsigned int, int, char, void *);
    typedef void (SWIGSTDCALL* SWIG_Callback39_t)(unsigned int, int, char, void *);
    typedef void (SWIGSTDCALL* SWIG_Callback40_t)(unsigned int, int, char, void *);
    typedef void (SWIGSTDCALL* SWIG_Callback41_t)(unsigned int, int, void *);
    typedef void (SWIGSTDCALL* SWIG_Callback42_t)(unsigned int, int, void *);
    typedef void (SWIGSTDCALL* SWIG_Callback43_t)(void *);
    typedef void (SWIGSTDCALL* SWIG_Callback44_t)(unsigned int, int, void *);
    typedef void (SWIGSTDCALL* SWIG_Callback45_t)(unsigned int, int, void *);
    typedef void (SWIGSTDCALL* SWIG_Callback46_t)(unsigned int, int, void *);
    typedef void (SWIGSTDCALL* SWIG_Callback47_t)(unsigned int, int, void *);
    typedef void (SWIGSTDCALL* SWIG_Callback48_t)(unsigned int, int, void *);
    typedef void (SWIGSTDCALL* SWIG_Callback49_t)(unsigned int, int, void *);
    void swig_connect_director(SWIG_Callback0_t callbackOnConnect, SWIG_Callback1_t callbackOnRspLogin, SWIG_Callback2_t callbackOnRtnContactInfo, SWIG_Callback3_t callbackOnRspRequestVertificateCode, SWIG_Callback4_t callbackOnExpriationDate, SWIG_Callback5_t callbackOnAPIReady, SWIG_Callback6_t callbackOnDisconnect, SWIG_Callback7_t callbackOnRspChangePassword, SWIG_Callback8_t callbackOnRspAuthPassword, SWIG_Callback9_t callbackOnRspQryTradingDate, SWIG_Callback10_t callbackOnRspSetReservedInfo, SWIG_Callback11_t callbackOnRspQryAccount, SWIG_Callback12_t callbackOnRspQryFund, SWIG_Callback13_t callbackOnRtnFund, SWIG_Callback14_t callbackOnRspQryExchange, SWIG_Callback15_t callbackOnRspQryCommodity, SWIG_Callback16_t callbackOnRspQryContract, SWIG_Callback17_t callbackOnRtnContract, SWIG_Callback18_t callbackOnRspOrderAction, SWIG_Callback19_t callbackOnRtnOrder, SWIG_Callback20_t callbackOnRspQryOrder, SWIG_Callback21_t callbackOnRspQryOrderProcess, SWIG_Callback22_t callbackOnRspQryFill, SWIG_Callback23_t callbackOnRtnFill, SWIG_Callback24_t callbackOnRspQryPosition, SWIG_Callback25_t callbackOnRtnPosition, SWIG_Callback26_t callbackOnRspQryPositionSummary, SWIG_Callback27_t callbackOnRtnPositionSummary, SWIG_Callback28_t callbackOnRtnPositionProfit, SWIG_Callback29_t callbackOnRspQryCurrency, SWIG_Callback30_t callbackOnRspQryTradeMessage, SWIG_Callback31_t callbackOnRtnTradeMessage, SWIG_Callback32_t callbackOnRspQryHisOrder, SWIG_Callback33_t callbackOnRspQryHisOrderProcess, SWIG_Callback34_t callbackOnRspQryHisMatch, SWIG_Callback35_t callbackOnRspQryHisPosition, SWIG_Callback36_t callbackOnRspQryHisDelivery, SWIG_Callback37_t callbackOnRspQryAccountCashAdjust, SWIG_Callback38_t callbackOnRspQryBill, SWIG_Callback39_t callbackOnRspQryAccountFeeRent, SWIG_Callback40_t callbackOnRspQryAccountMarginRent, SWIG_Callback41_t callbackOnRspHKMarketOrderInsert, SWIG_Callback42_t callbackOnRspHKMarketOrderDelete, SWIG_Callback43_t callbackOnHKMarketQuoteNotice, SWIG_Callback44_t callbackOnRspOrderLocalRemove, SWIG_Callback45_t callbackOnRspOrderLocalInput, SWIG_Callback46_t callbackOnRspOrderLocalModify, SWIG_Callback47_t callbackOnRspOrderLocalTransfer, SWIG_Callback48_t callbackOnRspFillLocalInput, SWIG_Callback49_t callbackOnRspFillLocalRemove);

private:
    SWIG_Callback0_t swig_callbackOnConnect;
    SWIG_Callback1_t swig_callbackOnRspLogin;
    SWIG_Callback2_t swig_callbackOnRtnContactInfo;
    SWIG_Callback3_t swig_callbackOnRspRequestVertificateCode;
    SWIG_Callback4_t swig_callbackOnExpriationDate;
    SWIG_Callback5_t swig_callbackOnAPIReady;
    SWIG_Callback6_t swig_callbackOnDisconnect;
    SWIG_Callback7_t swig_callbackOnRspChangePassword;
    SWIG_Callback8_t swig_callbackOnRspAuthPassword;
    SWIG_Callback9_t swig_callbackOnRspQryTradingDate;
    SWIG_Callback10_t swig_callbackOnRspSetReservedInfo;
    SWIG_Callback11_t swig_callbackOnRspQryAccount;
    SWIG_Callback12_t swig_callbackOnRspQryFund;
    SWIG_Callback13_t swig_callbackOnRtnFund;
    SWIG_Callback14_t swig_callbackOnRspQryExchange;
    SWIG_Callback15_t swig_callbackOnRspQryCommodity;
    SWIG_Callback16_t swig_callbackOnRspQryContract;
    SWIG_Callback17_t swig_callbackOnRtnContract;
    SWIG_Callback18_t swig_callbackOnRspOrderAction;
    SWIG_Callback19_t swig_callbackOnRtnOrder;
    SWIG_Callback20_t swig_callbackOnRspQryOrder;
    SWIG_Callback21_t swig_callbackOnRspQryOrderProcess;
    SWIG_Callback22_t swig_callbackOnRspQryFill;
    SWIG_Callback23_t swig_callbackOnRtnFill;
    SWIG_Callback24_t swig_callbackOnRspQryPosition;
    SWIG_Callback25_t swig_callbackOnRtnPosition;
    SWIG_Callback26_t swig_callbackOnRspQryPositionSummary;
    SWIG_Callback27_t swig_callbackOnRtnPositionSummary;
    SWIG_Callback28_t swig_callbackOnRtnPositionProfit;
    SWIG_Callback29_t swig_callbackOnRspQryCurrency;
    SWIG_Callback30_t swig_callbackOnRspQryTradeMessage;
    SWIG_Callback31_t swig_callbackOnRtnTradeMessage;
    SWIG_Callback32_t swig_callbackOnRspQryHisOrder;
    SWIG_Callback33_t swig_callbackOnRspQryHisOrderProcess;
    SWIG_Callback34_t swig_callbackOnRspQryHisMatch;
    SWIG_Callback35_t swig_callbackOnRspQryHisPosition;
    SWIG_Callback36_t swig_callbackOnRspQryHisDelivery;
    SWIG_Callback37_t swig_callbackOnRspQryAccountCashAdjust;
    SWIG_Callback38_t swig_callbackOnRspQryBill;
    SWIG_Callback39_t swig_callbackOnRspQryAccountFeeRent;
    SWIG_Callback40_t swig_callbackOnRspQryAccountMarginRent;
    SWIG_Callback41_t swig_callbackOnRspHKMarketOrderInsert;
    SWIG_Callback42_t swig_callbackOnRspHKMarketOrderDelete;
    SWIG_Callback43_t swig_callbackOnHKMarketQuoteNotice;
    SWIG_Callback44_t swig_callbackOnRspOrderLocalRemove;
    SWIG_Callback45_t swig_callbackOnRspOrderLocalInput;
    SWIG_Callback46_t swig_callbackOnRspOrderLocalModify;
    SWIG_Callback47_t swig_callbackOnRspOrderLocalTransfer;
    SWIG_Callback48_t swig_callbackOnRspFillLocalInput;
    SWIG_Callback49_t swig_callbackOnRspFillLocalRemove;
    void swig_init_callbacks();
};


#endif
