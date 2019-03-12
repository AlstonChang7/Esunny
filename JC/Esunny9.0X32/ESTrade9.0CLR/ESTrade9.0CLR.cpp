// ������ DLL �ļ���
#include "stdafx.h"
#include <vcclr.h>

#include "ESTrade9.0CLR.h"
#include "Convert.h"
#include "Autority.h"
#include "RefHead\iTapAPICommDef.h"
#include "RefHead\iTapTradeAPIDataType.h"
#include "RefHead\iTapTradeAPI.h"

using namespace System;
using namespace ITapTrade;
using namespace System::Runtime::InteropServices;
using namespace std;

namespace global {

	//���׻ص�
	class EsTradeApiResonse :public ITapTradeAPINotify
	{

	private:
		//��gcroot�����й����͵�ȫ�ֱ���
		gcroot<DDEsunnyApiCallback^> tradeCallback;

	public:
		EsTradeApiResonse(DDEsunnyApiCallback^  callback) {
			tradeCallback = callback;
		}

		/**
		* @brief ���ӳɹ��ص�֪ͨ
		* @ingroup G_T_Login
		*/
		virtual void TAP_CDECL OnConnect() {
			tradeCallback->OnConnect();
		}

		/**
		* @brief	ϵͳ��¼���̻ص���
		* @details	�˺���ΪLogin()��¼�����Ļص�������Login()�ɹ���������·���ӣ�Ȼ��API������������͵�¼��֤��Ϣ��
		*			��¼�ڼ�����ݷ�������͵�¼�Ļ�����Ϣ���ݵ��˻ص������С�
		* @param[in] errorCode ���ش�����,0��ʾ�ɹ���
		* @param[in] loginRspInfo ��½Ӧ����Ϣ�����errorCode!=0����loginRspInfo=NULL��
		* @attention	�ûص����سɹ���˵���û���¼�ɹ������ǲ�����API׼����ϡ�
		* @ingroup G_T_Login
		*/
		virtual void TAP_CDECL OnRspLogin(TAPIINT32 errorCode, const TapAPITradeLoginRspInfo *loginRspInfo) {
			tradeCallback->OnRspLogin(errorCode, To_RspLoginField(loginRspInfo));
		}

		/**
		* @brief	������֤��ϵ��ʽ֪ͨ��
		* @details	��¼��ɺ������Ҫ������֤��9.2.7��̨�������յ���ϵ��ʽ��֪ͨ������ѡ��֪ͨ��Ϣ��һ����ϵ��ʽ��������ߵ绰��
		*			�����Ͷ�����֤��Ȩ�루RequestVertificateCode����
		* @param[in] errorCode ���ش�����,0��ʾ�ɹ�������˻�û�а󶨶�����֤��ϵ��ʽ���򷵻�10016����
		* @param[in] isLast,��ʶ�Ƿ������һ����ϵ��Ϣ��
		* @param[in]  ��֤��ʽ��Ϣ�����errorCode!=0����ContactInfoΪ�ա�
		* @attention	�ûص����سɹ���˵����Ҫ������֤��������Ҫѡ��һ����ϵ��ʽȻ�����RequestVertificateCode��
		* @ingroup G_T_Login
		*/
		virtual void TAP_CDECL OnRtnContactInfo(TAPIINT32 errorCode, TAPIYNFLAG isLast, const TAPISTR_40 ContactInfo) {
			tradeCallback->OnRtnContactInfo(errorCode, IsLast(isLast), gcnew String(ContactInfo));
		}

		/**
		* @brief	�����Ͷ�����֤��Ӧ��
		* @details	�����ȡ������֤��Ȩ�룬��̨�����ʼ����߶��ţ�������Ӧ�𣬰�����������Լ���֤����Ч�ڡ�
		*
		* @param[in] sessionID ���������֤��ỰID��
		* @param[in]  errorCode ���û�а���ϵ������10016����.
		* @param[in]  rsp������֤����Ч�ڣ����뷵�أ��ڶ�����֤��Ч���ڣ������ظ����ö�����֤�룬���ǲ������������������֤�롣
		* @attention	�ûص����سɹ���˵����Ҫ������֤��������Ҫѡ��һ����ϵ��ʽȻ�����RequestVertificateCode��
		* @ingroup G_T_Login
		*/
		virtual void TAP_CDECL OnRspRequestVertificateCode(TAPIUINT32 sessionID, TAPIINT32 errorCode, const TapAPIRequestVertificateCodeRsp *rsp) {
			tradeCallback->OnRspRequestVertificateCode(sessionID, errorCode, To_RspRequestVertificateCodeField(rsp));
		}

		/**
		* @brief	API�������ѻص�
		* @details	�˺���ΪLogin()��¼�ɹ�������������뵱ǰ����С��30�죬����лص����ѡ�
		* @param[in] date ����API��Ȩ�����ա�
		* @param[in] days ���ػ��м�����Ȩ���ڡ�
		* @attention	�ú����ص�����˵����Ȩ��һ����֮�ڵ��ڡ����򲻲����ûص���
		* @ingroup G_T_Login
		*/
		virtual void TAP_CDECL OnExpriationDate(TAPIDATE date, int days) {
			tradeCallback->OnExpriationDate(gcnew String(date), days);
		}

		/**
		* @brief	֪ͨ�û�API׼��������
		* @details	ֻ���û��ص��յ��˾���֪ͨʱ���ܽ��к����ĸ����������ݲ�ѯ������\n
		*			�˻ص�������API�ܷ����������ı�־��
		* @attention ������ſ��Խ��к�����������
		* @ingroup G_T_Login
		*/
		virtual void TAP_CDECL OnAPIReady(TAPIINT32 errorCode) {
			tradeCallback->OnAPIReady(errorCode);
		}

		/**
		* @brief	API�ͷ���ʧȥ���ӵĻص�
		* @details	��APIʹ�ù������������߱��������������ʧȥ���Ӻ󶼻ᴥ���˻ص�֪ͨ�û���������������Ѿ��Ͽ���
		* @param[in] reasonCode �Ͽ�ԭ����롣
		* @ingroup G_T_Disconnect
		*/
		virtual void TAP_CDECL OnDisconnect(TAPIINT32 reasonCode) {
			tradeCallback->OnDisconnect(reasonCode);
		}

		/**
		* @brief ֪ͨ�û������޸Ľ��
		* @param[in] sessionID �޸�����ĻỰID,��ChangePassword���صĻỰID��Ӧ��
		* @param[in] errorCode ���ش����룬0��ʾ�ɹ���
		* @ingroup G_T_UserInfo
		*/
		virtual void TAP_CDECL OnRspChangePassword(TAPIUINT32 sessionID, TAPIINT32 errorCode) {
			tradeCallback->OnRspChangePassword(sessionID, errorCode);
		}

		/**
		* @brief ��֤�˻����뷴��
		* @param[in] sessionID �޸�����ĻỰID,��AuthPassword���صĻỰID��Ӧ��
		* @param[in] errorCode ���ش����룬0��ʾ�ɹ���
		* @ingroup G_T_UserInfo
		*/
		virtual void TAP_CDECL OnRspAuthPassword(TAPIUINT32 sessionID, TAPIINT32 errorCode) {
			tradeCallback->OnRspAuthPassword(sessionID, errorCode);
		}

		/**
		* @brief �����û�Ԥ����Ϣ����
		* @param[in] sessionID �����û�Ԥ����Ϣ�ĻỰID
		* @param[in] errorCode ���ش����룬0��ʾ�ɹ���
		* @param[in] info ָ�򷵻ص���Ϣ�ṹ�塣��errorCode��Ϊ0ʱ��infoΪ�ա�
		* @attention ��Ҫ�޸ĺ�ɾ��info��ָʾ�����ݣ��������ý���������������Ч��
		* @note �ýӿ���δʵ��
		* @ingroup G_T_UserInfo
		*/
		virtual void TAP_CDECL OnRspSetReservedInfo(TAPIUINT32 sessionID, TAPIINT32 errorCode, const TAPISTR_50 info) {
			tradeCallback->OnRspSetReservedInfo(sessionID, errorCode, gcnew String(info));
		}

		/**
		* @brief	�����û���Ϣ
		* @details	�˻ص��ӿ����û����ز�ѯ���ʽ��˺ŵ���ϸ��Ϣ���û��б�Ҫ���õ����˺ű�ű���������Ȼ���ں����ĺ���������ʹ�á�
		* @param[in] sessionID ����ĻỰID��
		* @param[in] errorCode �����롣0 ��ʾ�ɹ���
		* @param[in] isLast ��ʾ�Ƿ������һ�����ݣ�
		* @param[in] info ָ�򷵻ص���Ϣ�ṹ�塣��errorCode��Ϊ0ʱ��infoΪ�ա�
		* @attention ��Ҫ�޸ĺ�ɾ��info��ָʾ�����ݣ��������ý���������������Ч��
		* @ingroup G_T_AccountInfo
		*/
		virtual void TAP_CDECL OnRspQryAccount(TAPIUINT32 sessionID, TAPIUINT32 errorCode, TAPIYNFLAG isLast, const TapAPIAccountInfo *rsp) {
			tradeCallback->OnRspQryAccount(sessionID, errorCode, IsLast(isLast), To_RspQryAccountField(rsp));
		}

		/**
		* @brief �����ʽ��˻����ʽ���Ϣ
		* @param[in] sessionID ����ĻỰID��
		* @param[in] errorCode �����롣0 ��ʾ�ɹ���
		* @param[in] isLast 	��ʾ�Ƿ������һ�����ݣ�
		* @param[in] info		ָ�򷵻ص���Ϣ�ṹ�塣��errorCode��Ϊ0ʱ��infoΪ�ա�
		* @attention ��Ҫ�޸ĺ�ɾ��info��ָʾ�����ݣ��������ý���������������Ч��
		* @ingroup G_T_AccountDetails
		*/
		virtual void TAP_CDECL OnRspQryFund(TAPIUINT32 sessionID, TAPIINT32 errorCode, TAPIYNFLAG isLast, const TapAPIFundData *rsp) {
			tradeCallback->OnRspQryFund(sessionID, errorCode, IsLast(isLast), To_QryFundRspField(rsp));
		}

		/**
		* @brief	�û��ʽ�仯֪ͨ
		* @details	�û���ί�гɽ���������ʽ����ݵı仯�������Ҫ���û�ʵʱ������
		* @param[in] info		ָ�򷵻ص���Ϣ�ṹ�塣��errorCode��Ϊ0ʱ��infoΪ�ա�
		* @note �������ע�������ݣ������趨Loginʱ��NoticeIgnoreFlag�����Ρ�
		* @attention ��Ҫ�޸ĺ�ɾ��info��ָʾ�����ݣ��������ý���������������Ч��
		* @ingroup G_T_AccountDetails
		*/
		virtual void TAP_CDECL OnRtnFund(const TapAPIFundData *info) {
			tradeCallback->OnRtnFund(To_QryFundRspField(info));
		}

		/**
		* @brief ����ϵͳ�еĽ�������Ϣ
		* @param[in] sessionID ����ĻỰID��
		* @param[in] errorCode �����롣0 ��ʾ�ɹ���
		* @param[in] isLast 	��ʾ�Ƿ������һ�����ݣ�
		* @param[in] info		ָ�򷵻ص���Ϣ�ṹ�塣��errorCode��Ϊ0ʱ��infoΪ�ա�
		* @attention ��Ҫ�޸ĺ�ɾ��info��ָʾ�����ݣ��������ý���������������Ч��
		* @ingroup G_T_TradeSystem
		*/
		virtual void TAP_CDECL OnRspQryExchange(TAPIUINT32 sessionID, TAPIINT32 errorCode, TAPIYNFLAG isLast, const TapAPIExchangeInfo *rsp) {
			tradeCallback->OnRspQryExchange(sessionID, errorCode, IsLast(isLast), To_QryExchangeRspField(rsp));
		}

		/**
		* @brief	����ϵͳ��Ʒ����Ϣ
		* @details	�˻ص��ӿ��������û����صõ�������Ʒ����Ϣ��
		* @param[in] sessionID ����ĻỰID����GetAllCommodities()�������ض�Ӧ��
		* @param[in] errorCode �����롣0 ��ʾ�ɹ���
		* @param[in] isLast 	��ʾ�Ƿ������һ�����ݣ�
		* @param[in] info		ָ�򷵻ص���Ϣ�ṹ�塣��errorCode��Ϊ0ʱ��infoΪ�ա�
		* @attention ��Ҫ�޸ĺ�ɾ��info��ָʾ�����ݣ��������ý���������������Ч��
		* @ingroup G_T_Commodity
		*/
		virtual void TAP_CDECL OnRspQryCommodity(TAPIUINT32 sessionID, TAPIINT32 errorCode, TAPIYNFLAG isLast, const TapAPICommodityInfo *rsp) {
			tradeCallback->OnRspQryCommodity(sessionID, errorCode, IsLast(isLast), To_QryCommodityRspField(rsp));
		}

		/**
		* @brief ����ϵͳ�к�Լ��Ϣ
		* @param[in] sessionID ����ĻỰID��
		* @param[in] errorCode �����롣0 ��ʾ�ɹ���
		* @param[in] isLast 	��ʾ�Ƿ������һ�����ݣ�
		* @param[in] info		ָ�򷵻ص���Ϣ�ṹ�塣��errorCode��Ϊ0ʱ��infoΪ�ա�
		* @attention ��Ҫ�޸ĺ�ɾ��info��ָʾ�����ݣ��������ý���������������Ч��
		* @ingroup G_T_Contract
		*/
		virtual void TAP_CDECL OnRspQryContract(TAPIUINT32 sessionID, TAPIINT32 errorCode, TAPIYNFLAG isLast, const TapAPITradeContractInfo *rsp) {
			tradeCallback->OnRspQryContract(sessionID, errorCode, IsLast(isLast), To_QryContractRspField(rsp));
		}

		/**
		* @brief	����������Լ��Ϣ
		* @details	���û������µĺ�Լ����Ҫ���������ڽ���ʱ����з�����������º�Լʱ�����û����������Լ����Ϣ��
		* @param[in] info		ָ�򷵻ص���Ϣ�ṹ�塣��errorCode��Ϊ0ʱ��infoΪ�ա�
		* @attention ��Ҫ�޸ĺ�ɾ��info��ָʾ�����ݣ��������ý���������������Ч��
		* @ingroup G_T_Contract
		*/
		virtual void TAP_CDECL OnRtnContract(const TapAPITradeContractInfo *rsp) {
			tradeCallback->OnRtnContract(To_QryContractRspField(rsp));
		}

		/**
		* @brief	��������Ӧ��
		* @details	�µ����������ĵ�Ӧ���µ������д�Ӧ��ص�������µ�����ṹ��û����д��Լ�����ʽ��˺ţ�������ش���š�
		* �������ĵ�������Ӧ���OnRtnOrder���ɹ�������OnRtnOrder�ص���
		* sessionID��ʶ�����Ӧ��sessionID���Ա�ȷ���ñ�Ӧ���Ӧ������
		*
		* @param[in] sessionID ����ĻỰID��
		* @param[in] errorCode �����롣0 ��ʾ�ɹ���
		* @param[in] info ����Ӧ��������ͣ����������������ͺͶ�����Ϣָ�롣
		* ������Ϣָ�벿������¿���Ϊ�գ����Ϊ�գ�����ͨ��SessiuonID�ҵ���Ӧ�����ȡ�������͡�
		* @attention ��Ҫ�޸ĺ�ɾ��info��ָʾ�����ݣ��������ý���������������Ч��
		* @ingroup G_T_TradeActions
		*/
		virtual void TAP_CDECL OnRspOrderAction(TAPIUINT32 sessionID, TAPIINT32 errorCode, const TapAPIOrderActionRsp *rsp) {
			tradeCallback->OnRspOrderAction(sessionID, errorCode, To_QryOrderRspField_2(rsp));
		}

		/**
		* @brief ������ί�С����µĻ��������ط��µ����͹����ġ�
		* @details	���������յ��ͻ��µ�ί�����ݺ�ͻᱣ�������ȴ�������ͬʱ���û�����һ��
		*			��ί����Ϣ˵����������ȷ�������û������󣬷��ص���Ϣ�а�����ȫ����ί����Ϣ��
		*			ͬʱ��һ��������ʾ��ί�е�ί�кš�
		* @param[in] info ָ�򷵻ص���Ϣ�ṹ�塣��errorCode��Ϊ0ʱ��infoΪ�ա�
		* @note �������ע�������ݣ������趨Loginʱ��NoticeIgnoreFlag�����Ρ�
		* @attention ��Ҫ�޸ĺ�ɾ��info��ָʾ�����ݣ��������ý���������������Ч��
		* @ingroup G_T_TradeActions
		*/
		virtual void TAP_CDECL OnRtnOrder(const TapAPIOrderInfoNotice *info) {
			tradeCallback->OnRtnOrder(To_QryOrderRspField_3(info));
		}

		/**
		* @brief	���ز�ѯ��ί����Ϣ
		* @details	�����û���ѯ��ί�еľ�����Ϣ��
		* @param[in] sessionID ����ĻỰID��
		* @param[in] errorCode �����롣0 ��ʾ�ɹ���
		* @param[in] isLast ��ʾ�Ƿ������һ�����ݣ�
		* @param[in] info ָ�򷵻ص���Ϣ�ṹ�塣��errorCode��Ϊ0ʱ��infoΪ�ա�
		* @attention ��Ҫ�޸ĺ�ɾ��info��ָʾ�����ݣ��������ý���������������Ч��
		* @ingroup G_T_TradeInfo
		*/
		virtual void TAP_CDECL OnRspQryOrder(TAPIUINT32 sessionID, TAPIINT32 errorCode, TAPIYNFLAG isLast, const TapAPIOrderInfo *rsp) {
			tradeCallback->OnRspQryOrder(sessionID, errorCode, IsLast(isLast), To_QryOrderRspField(rsp));
		}

		/**
		* @brief ���ز�ѯ��ί�б仯������Ϣ
		* @param[in] sessionID ����ĻỰID��
		* @param[in] errorCode �����룬��errorCode==0ʱ��infoָ�򷵻ص�ί�б仯���̽ṹ�壬��ȻΪNULL��
		* @param[in] isLast ��ʾ�Ƿ������һ�����ݣ�
		* @param[in] info ���ص�ί�б仯����ָ�롣
		* @attention ��Ҫ�޸ĺ�ɾ��info��ָʾ�����ݣ��������ý���������������Ч��
		* @ingroup G_T_TradeInfo
		*/
		virtual void TAP_CDECL OnRspQryOrderProcess(TAPIUINT32 sessionID, TAPIINT32 errorCode, TAPIYNFLAG isLast, const TapAPIOrderInfo *info) {
		}

		/**
		* @brief ���ز�ѯ�ĳɽ���Ϣ
		* @param[in] sessionID ����ĻỰID��
		* @param[in] errorCode �����롣0 ��ʾ�ɹ���
		* @param[in] isLast 	��ʾ�Ƿ������һ�����ݣ�
		* @param[in] info		ָ�򷵻ص���Ϣ�ṹ�塣��errorCode��Ϊ0ʱ��infoΪ�ա�
		* @attention ��Ҫ�޸ĺ�ɾ��info��ָʾ�����ݣ��������ý���������������Ч��
		* @ingroup G_T_TradeInfo
		*/
		virtual void TAP_CDECL OnRspQryFill(TAPIUINT32 sessionID, TAPIINT32 errorCode, TAPIYNFLAG isLast, const TapAPIFillInfo *rsp) {
			tradeCallback->OnRspQryFill(sessionID, errorCode, IsLast(isLast), To_QryFillRspField(rsp));
		}

		/**
		* @brief	�������ĳɽ���Ϣ
		* @details	�û���ί�гɽ������û����ͳɽ���Ϣ��
		* @param[in] info		ָ�򷵻ص���Ϣ�ṹ�塣��errorCode��Ϊ0ʱ��infoΪ�ա�
		* @note �������ע�������ݣ������趨Loginʱ��NoticeIgnoreFlag�����Ρ�
		* @attention ��Ҫ�޸ĺ�ɾ��info��ָʾ�����ݣ��������ý���������������Ч��
		* @ingroup G_T_TradeActions
		*/
		virtual void TAP_CDECL OnRtnFill(const TapAPIFillInfo *rsp) {
			tradeCallback->OnRtnFill(To_QryFillRspField(rsp));
		}

		/**
		* @brief ���ز�ѯ�ĳֲ�
		* @param[in] sessionID ����ĻỰID��
		* @param[in] errorCode �����롣0 ��ʾ�ɹ���
		* @param[in] isLast 	��ʾ�Ƿ������һ�����ݣ�
		* @param[in] info		ָ�򷵻ص���Ϣ�ṹ�塣��errorCode��Ϊ0ʱ��infoΪ�ա�
		* @attention ��Ҫ�޸ĺ�ɾ��info��ָʾ�����ݣ��������ý���������������Ч��
		* @ingroup G_T_TradeInfo
		*/
		virtual void TAP_CDECL OnRspQryPosition(TAPIUINT32 sessionID, TAPIINT32 errorCode, TAPIYNFLAG isLast, const TapAPIPositionInfo *rsp) {
			tradeCallback->OnRspQryPosition(sessionID, errorCode, IsLast(isLast), To_QryPositionRspField(rsp));
		}

		/**
		* @brief �ֱֲ仯����֪ͨ
		* @param[in] info		ָ�򷵻ص���Ϣ�ṹ�塣��errorCode��Ϊ0ʱ��infoΪ�ա�
		* @note �������ע�������ݣ������趨Loginʱ��NoticeIgnoreFlag�����Ρ�
		* @attention ��Ҫ�޸ĺ�ɾ��info��ָʾ�����ݣ��������ý���������������Ч��
		* @ingroup G_T_TradeActions
		*/
		virtual void TAP_CDECL OnRtnPosition(const TapAPIPositionInfo *rsp) {
			tradeCallback->OnRtnPosition(To_QryPositionRspField(rsp));
		}

		/**
		* @brief ���ز�ѯ�ĳֲֻ���
		* @param[in] sessionID ����ĻỰID��
		* @param[in] errorCode �����롣0 ��ʾ�ɹ���
		* @param[in] isLast 	��ʾ�Ƿ������һ�����ݣ�
		* @param[in] info		ָ�򷵻ص���Ϣ�ṹ�塣��errorCode��Ϊ0ʱ��infoΪ�ա�
		* @attention ��Ҫ�޸ĺ�ɾ��info��ָʾ�����ݣ��������ý���������������Ч��
		* @ingroup G_T_TradeInfo
		*/
		virtual void TAP_CDECL OnRspQryPositionSummary(TAPIUINT32 sessionID, TAPIINT32 errorCode, TAPIYNFLAG isLast, const TapAPIPositionSummary *rsp) {
			tradeCallback->OnRspQryPositionSummary(sessionID, errorCode, (DDEnumYNFlag)isLast, To_QryPositionSummaryRspField(rsp));
		}

		/**
		* @brief �ֲֻ��ܱ仯����֪ͨ
		* @param[in] info		ָ�򷵻ص���Ϣ�ṹ�塣��errorCode��Ϊ0ʱ��infoΪ�ա�
		* @note �������ע�������ݣ������趨Loginʱ��NoticeIgnoreFlag�����Ρ�
		* @attention ��Ҫ�޸ĺ�ɾ��info��ָʾ�����ݣ��������ý���������������Ч��
		* @ingroup G_T_TradeActions
		*/
		virtual void TAP_CDECL OnRtnPositionSummary(const TapAPIPositionSummary *rsp) {
			tradeCallback->OnRtnPositionSummary(To_QryPositionSummaryRspField(rsp));
		}

		/**
		* @brief �ֲ�ӯ��֪ͨ
		* @param[in] info		ָ�򷵻ص���Ϣ�ṹ�塣��errorCode��Ϊ0ʱ��infoΪ�ա�
		* @note �������ע�������ݣ������趨Loginʱ��NoticeIgnoreFlag�����Ρ�
		* @attention ��Ҫ�޸ĺ�ɾ��info��ָʾ�����ݣ��������ý���������������Ч��
		* @ingroup G_T_TradeActions
		*/
		virtual void TAP_CDECL OnRtnPositionProfit(const TapAPIPositionProfitNotice *rsp) {
			tradeCallback->OnRtnPositionProfit(To_RtnPositionProfitField(rsp));
		}


		/**
		* @brief ����ϵͳ�еı�����Ϣ
		* @param[in] sessionID ����ĻỰID��
		* @param[in] errorCode �����롣0 ��ʾ�ɹ���
		* @param[in] isLast 	��ʾ�Ƿ������һ�����ݣ�
		* @param[in] info		ָ�򷵻ص���Ϣ�ṹ�塣��errorCode��Ϊ0ʱ��infoΪ�ա�
		* @attention ��Ҫ�޸ĺ�ɾ��info��ָʾ�����ݣ��������ý���������������Ч��
		* @ingroup G_T_TradeSystem
		*/
		virtual void TAP_CDECL OnRspQryCurrency(TAPIUINT32 sessionID, TAPIINT32 errorCode, TAPIYNFLAG isLast, const TapAPICurrencyInfo *rsp) {
			tradeCallback->OnRspQryCurrency(sessionID, errorCode, IsLast(isLast), To_QryCurrencyRspField(rsp));
		}

		/**
		* @brief	������Ϣ֪ͨ
		* @details	���ز�ѯ���û��ʽ�״̬��Ϣ����Ϣ˵�����û����ʽ�״̬���û���Ҫ��ϸ�鿴��Щ��Ϣ��
		* @param[in] sessionID ����ĻỰID��
		* @param[in] errorCode �����롣0 ��ʾ�ɹ���
		* @param[in] isLast 	��ʾ�Ƿ������һ�����ݣ�
		* @param[in] info		ָ�򷵻ص���Ϣ�ṹ�塣��errorCode��Ϊ0ʱ��infoΪ�ա�
		* @attention ��Ҫ�޸ĺ�ɾ��info��ָʾ�����ݣ��������ý���������������Ч��
		* @ingroup G_T_AccountDetails
		*/
		virtual void TAP_CDECL OnRspQryTradeMessage(TAPIUINT32 sessionID, TAPIINT32 errorCode, TAPIYNFLAG isLast, const TapAPITradeMessage *rsp) {
			tradeCallback->OnRspQryTradeMessage(sessionID, errorCode, IsLast(isLast), To_QryTradeMessageRspField(rsp));
		}

		/**
		* @brief	������Ϣ֪ͨ
		* @details	�û��ڽ��׹����п�����Ϊ�ʽ𡢳ֲ֡�ƽ�ֵ�״̬�䶯ʹ�˻�����ĳЩΣ��״̬������ĳЩ��Ҫ����Ϣ��Ҫ���û�֪ͨ��
		* @param[in] info		ָ�򷵻ص���Ϣ�ṹ�塣��errorCode��Ϊ0ʱ��infoΪ�ա�
		* @attention ��Ҫ�޸ĺ�ɾ��info��ָʾ�����ݣ��������ý���������������Ч��
		* @ingroup G_T_AccountDetails
		*/
		virtual void TAP_CDECL OnRtnTradeMessage(const TapAPITradeMessage *rsp) {
			tradeCallback->OnRtnTradeMessage(To_QryTradeMessageRspField(rsp));
		}

		/**
		* @brief ��ʷί�в�ѯӦ��
		* @param[in] sessionID ����ĻỰID��
		* @param[in] errorCode �����롣0 ��ʾ�ɹ���
		* @param[in] isLast 	��ʾ�Ƿ������һ������
		* @param[in] info		ָ�򷵻ص���Ϣ�ṹ�塣��errorCode��Ϊ0ʱ��infoΪ�ա�
		* @attention ��Ҫ�޸ĺ�ɾ��info��ָʾ�����ݣ��������ý���������������Ч��
		* @ingroup G_T_HisInfo
		*/
		virtual void TAP_CDECL OnRspQryHisOrder(TAPIUINT32 sessionID, TAPIINT32 errorCode, TAPIYNFLAG isLast, const TapAPIHisOrderQryRsp *rsp) {
			tradeCallback->OnRspQryHisOrder(sessionID, errorCode, IsLast(isLast), To_QryHisOrderRspField(rsp));
		}

		/**
		* @brief ��ʷί�����̲�ѯӦ��
		* @param[in] sessionID ����ĻỰID��
		* @param[in] errorCode �����롣0 ��ʾ�ɹ���
		* @param[in] isLast 	��ʾ�Ƿ������һ������
		* @param[in] info		ָ�򷵻ص���Ϣ�ṹ�塣��errorCode��Ϊ0ʱ��infoΪ�ա�
		* @attention ��Ҫ�޸ĺ�ɾ��info��ָʾ�����ݣ��������ý���������������Ч��
		* @ingroup G_T_HisInfo
		*/
		virtual void TAP_CDECL OnRspQryHisOrderProcess(TAPIUINT32 sessionID, TAPIINT32 errorCode, TAPIYNFLAG isLast, const TapAPIHisOrderProcessQryRsp *info) {
		}

		/**
		* @brief ��ʷ�ɽ���ѯӦ��
		* @param[in] sessionID ����ĻỰID��
		* @param[in] errorCode �����롣0 ��ʾ�ɹ���
		* @param[in] isLast 	��ʾ�Ƿ������һ������
		* @param[in] info		ָ�򷵻ص���Ϣ�ṹ�塣��errorCode��Ϊ0ʱ��infoΪ�ա�
		* @attention ��Ҫ�޸ĺ�ɾ��info��ָʾ�����ݣ��������ý���������������Ч��
		* @ingroup G_T_HisInfo
		*/
		virtual void TAP_CDECL OnRspQryHisMatch(TAPIUINT32 sessionID, TAPIINT32 errorCode, TAPIYNFLAG isLast, const TapAPIHisMatchQryRsp *rsp) {
			tradeCallback->OnRspQryHisMatch(sessionID, errorCode, IsLast(isLast), To_QryHisMatchRspField(rsp));
		}

		/**
		* @brief ��ʷ�ֲֲ�ѯӦ��
		* @param[in] sessionID ����ĻỰID��
		* @param[in] errorCode �����롣0 ��ʾ�ɹ���
		* @param[in] isLast 	��ʾ�Ƿ������һ������
		* @param[in] info		ָ�򷵻ص���Ϣ�ṹ�塣��errorCode��Ϊ0ʱ��infoΪ�ա�
		* @attention ��Ҫ�޸ĺ�ɾ��info��ָʾ�����ݣ��������ý���������������Ч��
		* @ingroup G_T_HisInfo
		*/
		virtual void TAP_CDECL OnRspQryHisPosition(TAPIUINT32 sessionID, TAPIINT32 errorCode, TAPIYNFLAG isLast, const TapAPIHisPositionQryRsp *rsp) {
			tradeCallback->OnRspQryHisPosition(sessionID, errorCode, IsLast(isLast), To_QryHisPositionRspField(rsp));
		}

		/**
		* @brief ��ʷ�����ѯӦ��
		* @param[in] sessionID ����ĻỰID��
		* @param[in] errorCode �����롣0 ��ʾ�ɹ���
		* @param[in] isLast 	��ʾ�Ƿ������һ������
		* @param[in] info		ָ�򷵻ص���Ϣ�ṹ�塣��errorCode��Ϊ0ʱ��infoΪ�ա�
		* @attention ��Ҫ�޸ĺ�ɾ��info��ָʾ�����ݣ��������ý���������������Ч��
		* @ingroup G_T_HisInfo
		*/
		virtual void TAP_CDECL OnRspQryHisDelivery(TAPIUINT32 sessionID, TAPIINT32 errorCode, TAPIYNFLAG isLast, const TapAPIHisDeliveryQryRsp *info) {
		}

		/**
		* @brief �ʽ������ѯӦ��
		* @param[in] sessionID ����ĻỰID��
		* @param[in] errorCode �����롣0 ��ʾ�ɹ���
		* @param[in] isLast 	��ʾ�Ƿ������һ������
		* @param[in] info		ָ�򷵻ص���Ϣ�ṹ�塣��errorCode��Ϊ0ʱ��infoΪ�ա�
		* @attention ��Ҫ�޸ĺ�ɾ��info��ָʾ�����ݣ��������ý���������������Ч��
		* @ingroup G_T_HisInfo
		*/
		virtual void TAP_CDECL OnRspQryAccountCashAdjust(TAPIUINT32 sessionID, TAPIINT32 errorCode, TAPIYNFLAG isLast, const TapAPIAccountCashAdjustQryRsp *info) {
		}

		/**
		* @brief ��ѯ�û��˵�Ӧ�� Add:2013.12.11
		* @param[in] sessionID ����ĻỰID��
		* @param[in] errorCode �����롣0 ��ʾ�ɹ���
		* @param[in] info		ָ�򷵻ص���Ϣ�ṹ�塣��errorCode��Ϊ0ʱ��infoΪ�ա�
		* @attention ��Ҫ�޸ĺ�ɾ��info��ָʾ�����ݣ��������ý���������������Ч��
		* @ingroup G_T_Bill
		*/
		virtual void TAP_CDECL OnRspQryBill(TAPIUINT32 sessionID, TAPIINT32 errorCode, TAPIYNFLAG isLast, const TapAPIBillQryRsp *rsp) {
			tradeCallback->OnRspQryBill(sessionID, errorCode, IsLast(isLast), To_QryBillRspField(rsp));
		}

		/**
		* @brief ��ѯ�˻������Ѽ������ Add:2017.01.14
		* @param[in] sessionID ����ĻỰID��
		* @param[in] errorCode �����롣0 ��ʾ�ɹ���
		* @param[in] info		ָ�򷵻ص���Ϣ�ṹ�塣��errorCode��Ϊ0ʱ��infoΪ�ա�
		* @attention ��Ҫ�޸ĺ�ɾ��info��ָʾ�����ݣ��������ý���������������Ч��
		* @ingroup G_T_Rent
		*/
		virtual void TAP_CDECL OnRspQryAccountFeeRent(TAPIUINT32 sessionID, TAPIINT32 errorCode, TAPIYNFLAG isLast, const TapAPIAccountFeeRentQryRsp *rsp) {
			tradeCallback->OnRspQryAccountFeeRent(sessionID, errorCode, IsLast(isLast), To_QryAccountFeeRentRspField(rsp));
		}

		/**
		* @brief ��ѯ�˻���֤�������� Add:2017.01.14
		* @param[in] sessionID ����ĻỰID��
		* @param[in] errorCode �����롣0 ��ʾ�ɹ���
		* @param[in] info		ָ�򷵻ص���Ϣ�ṹ�塣��errorCode��Ϊ0ʱ��infoΪ�ա�
		* @attention ��Ҫ�޸ĺ�ɾ��info��ָʾ�����ݣ��������ý���������������Ч��
		* @ingroup G_T_Rent
		*/
		virtual void TAP_CDECL OnRspQryAccountMarginRent(TAPIUINT32 sessionID, TAPIINT32 errorCode, TAPIYNFLAG isLast, const TapAPIAccountMarginRentQryRsp *rsp) {
			tradeCallback->OnRspQryAccountMarginRent(sessionID, errorCode, IsLast(isLast), To_QryAccountMarginRentRspField(rsp));
		}

		/**
		* @brief �۽���������˫�߱���Ӧ�� Add:2017.08.29
		* @param[in] sessionID ����ĻỰID��
		* @param[in] errorCode �����롣0 ��ʾ�ɹ���
		* @param[in] info		ָ�򷵻ص���Ϣ�ṹ�塣��errorCode��Ϊ0ʱ��infoΪ�ա�
		* @attention ��Ҫ�޸ĺ�ɾ��info��ָʾ�����ݣ��������ý���������������Ч��
		* @ingroup G_T_HKMarket
		*/
		virtual void TAP_CDECL OnRspHKMarketOrderInsert(TAPIUINT32 sessionID, TAPIINT32 errorCode, const TapAPIOrderMarketInsertRsp *info) {
		}

		/**
		* @brief �۽���������˫�߳���Ӧ�� Add:2017.08.29
		* @param[in] sessionID ����ĻỰID��
		* @param[in] errorCode �����롣0 ��ʾ�ɹ���
		* @param[in] info		ָ�򷵻ص���Ϣ�ṹ�塣��errorCode��Ϊ0ʱ��infoΪ�ա�
		* @attention ��Ҫ�޸ĺ�ɾ��info��ָʾ�����ݣ��������ý���������������Ч��
		* @ingroup G_T_HKMarket
		*/
		virtual void TAP_CDECL OnRspHKMarketOrderDelete(TAPIUINT32 sessionID, TAPIINT32 errorCode, const TapAPIOrderMarketDeleteRsp *info) {
		}

		/**
		* @brief �۽���ѯ��֪ͨ Add:2017.08.29
		* @param[in] info		ָ�򷵻ص���Ϣ�ṹ�塣��errorCode��Ϊ0ʱ��infoΪ�ա�
		* @attention ��Ҫ�޸ĺ�ɾ��info��ָʾ�����ݣ��������ý���������������Ч��
		* @ingroup G_T_HKMarket
		*/
		virtual void TAP_CDECL OnHKMarketQuoteNotice(const TapAPIOrderQuoteMarketNotice *info) {
		}

		/**
		* @brief ����ɾ��Ӧ�� Add:2017.12.05
		* @param[in] sessionID ����ĻỰID��
		* @param[in] errorCode �����롣0 ��ʾ�ɹ���
		* @param[in] info		ָ�򷵻ص���Ϣ�ṹ�塣��errorCode��Ϊ0ʱ��infoΪ�ա�
		* @attention ��Ҫ�޸ĺ�ɾ��info��ָʾ�����ݣ��������ý���������������Ч��
		* @ingroup G_T_LocalAction
		*/
		virtual void TAP_CDECL OnRspOrderLocalRemove(TAPIUINT32 sessionID, TAPIINT32 errorCode, const TapAPIOrderLocalRemoveRsp *info) {
		}

		/**
		* @brief ����¼��Ӧ�� Add:2017.12.05
		* @param[in] sessionID ����ĻỰID��
		* @param[in] errorCode �����롣0 ��ʾ�ɹ���
		* @param[in] info		ָ�򷵻ص���Ϣ�ṹ�塣��errorCode��Ϊ0ʱ��infoΪ�ա�
		* @attention ��Ҫ�޸ĺ�ɾ��info��ָʾ�����ݣ��������ý���������������Ч��
		* @ingroup G_T_LocalAction
		*/
		virtual void TAP_CDECL OnRspOrderLocalInput(TAPIUINT32 sessionID, TAPIINT32 errorCode, const TapAPIOrderLocalInputRsp *info) {
		}

		/**
		* @brief �����޸�Ӧ�� Add:2017.12.05
		* @param[in] sessionID ����ĻỰID��
		* @param[in] errorCode �����롣0 ��ʾ�ɹ���
		* @param[in] info		ָ�򷵻ص���Ϣ�ṹ�塣��errorCode��Ϊ0ʱ��infoΪ�ա�
		* @attention ��Ҫ�޸ĺ�ɾ��info��ָʾ�����ݣ��������ý���������������Ч��
		* @ingroup G_T_LocalAction
		*/
		virtual void TAP_CDECL OnRspOrderLocalModify(TAPIUINT32 sessionID, TAPIINT32 errorCode, const TapAPIOrderLocalModifyRsp *info) {
		}

		/**
		* @brief ����ת��Ӧ�� Add:2017.12.05
		* @param[in] sessionID ����ĻỰID��
		* @param[in] errorCode �����롣0 ��ʾ�ɹ���
		* @param[in] info		ָ�򷵻ص���Ϣ�ṹ�塣��errorCode��Ϊ0ʱ��infoΪ�ա�
		* @attention ��Ҫ�޸ĺ�ɾ��info��ָʾ�����ݣ��������ý���������������Ч��
		* @ingroup G_T_LocalAction
		*/
		virtual void TAP_CDECL OnRspOrderLocalTransfer(TAPIUINT32 sessionID, TAPIINT32 errorCode, const TapAPIOrderLocalTransferRsp *info) {
		}

		/**
		* @brief �ɽ�¼��Ӧ�� Add:2017.12.05
		* @param[in] sessionID ����ĻỰID��
		* @param[in] errorCode �����롣0 ��ʾ�ɹ���
		* @param[in] info		ָ�򷵻ص���Ϣ�ṹ�塣��errorCode��Ϊ0ʱ��infoΪ�ա�
		* @attention ��Ҫ�޸ĺ�ɾ��info��ָʾ�����ݣ��������ý���������������Ч��
		* @ingroup G_T_LocalAction
		*/
		virtual void TAP_CDECL OnRspFillLocalInput(TAPIUINT32 sessionID, TAPIINT32 errorCode, const TapAPIFillLocalInputRsp *info) {
		}

		/** f
		* @brief ����ɾ��Ӧ�� Add:2017.12.05
		* @param[in] sessionID ����ĻỰID��
		* @param[in] errorCode �����롣0 ��ʾ�ɹ���
		* @param[in] info		ָ�򷵻ص���Ϣ�ṹ�塣��errorCode��Ϊ0ʱ��infoΪ�ա�
		* @attention ��Ҫ�޸ĺ�ɾ��info��ָʾ�����ݣ��������ý���������������Ч��
		* @ingroup G_T_LocalAction
		*/
		virtual void TAP_CDECL OnRspFillLocalRemove(TAPIUINT32 sessionID, TAPIINT32 errorCode, const TapAPIFillLocalRemoveRsp *info) {
		}

	};


	//---------------------------------------------------------------------
	/// <summary>
	/// �й���,����
	/// </summary>
	public ref class DDEsunnyApi :public IDisposable
	{

		static DDEsunnyApi() {
			Check();
		}

		ITapTradeAPI *api;
		EsTradeApiResonse *apiCallback;
		int _reqeutId;
		//-------------------
	public:

		int RequestId() {
			return System::Threading::Interlocked::Increment(_reqeutId);
		}

		//����API
		virtual	~DDEsunnyApi() {
			if (nullptr != api) {
				api->Disconnect();
				FreeITapTradeAPI(api);
				if (nullptr != apiCallback) {
					delete apiCallback;
				}
				api = nullptr;
				apiCallback = nullptr;
			}
		}

		DDEsunnyApi() {
		}

		//---------------------------------------------------------------------------------------------my
		//---------------------------------------------------------------------------------------------my
		int CreateApi(String^ authCode, String^ path, DDEsunnyApiCallback^  callback) {
			//no create again
			if (nullptr != api) {
				return 0;
			}
			//
			TapAPIApplicationInfo info = {};
			strcpy(info.AuthCode, CAutoStrPtr(authCode).m_pChar);
			strcpy(info.KeyOperationLogPath, CAutoStrPtr(path).m_pChar);
			//
			int result = 0;
			api = CreateITapTradeAPI(&info, result);
			if (0 == result) {
				apiCallback = new EsTradeApiResonse(callback);
				api->SetAPINotify(apiCallback);
			}
			return result;
		}

		/**
		* @brief	�Ͽ��ͷ���������·���ӡ�
		* @details	���ú�����API���ǳ����Ͽ�������������ӡ�
		* @operationtype ͬ������
		* @ingroup G_T_Disconnect
		*/
		virtual int Disconnect() {
			return	api->Disconnect();
		}

		/**
		* @brief ���÷�������IP��ַ�Ͷ˿ڡ�
		* @param[in] IP   IP��ַ
		* @param[in] port �˿ں�
		* @operationtype ͬ������
		* @ingroup G_T_Login
		*/
		virtual int SetHostAddress(String^ ip, int port) {
			return api->SetHostAddress(CAutoStrPtr(ip).m_pChar, port);
		}

		/**
		* @brief	�����¼����API�������ӷ��񣬽�����·�������¼��֤��
		* @details	��ʹ�ú���ǰ�û���Ҫ��ɷ�����������SetHostAddress()�����Ҵ���TapAPITradeLoginAuth���͵��û���Ϣ��
		*			������Ҫ���úûص��ӿڡ�\n
		*			��¼�����н������ӵķ�����Ϣͨ���ص�OnConnect���ظ��û���\n
		*			���ӽ�������û���֤������Ϣͨ���ص�OnLogin()���ظ��û���\n
		*			��¼�ɹ���API���Զ�����API�ĳ�ʼ����API�����������������ݣ���ѯ���Ժ��ͨ���ص�OnAPIReady()
		*			ָʾ�û�API��ʼ����ɣ����Խ��к����Ĳ����ˡ�
		* @param[in] loginAuth ��¼��֤��Ϣ�ṹָ�롣������¼��Ҫ����֤��Ϣ��
		* @retval 0 ��¼�ɹ���API��ʼ׼����̨����
		* @retval ��0 ������
		* @operationtype �첽����
		* @note TapAPITradeLoginAuth�е�NoticeIgnoreFlag���ڱ���Ƿ�����ض���֪ͨ�ص���\n
		*       ���磺����Ҫ����OnRtnFund��OnRtnPositionProfit,������ô�趨��\n
		*       NoticeIgnoreFlag = TAPI_NOTICE_IGNORE_FUND | TAPI_NOTICE_IGNORE_POSITIONPROFIT;
		* @attention Login()�������óɹ�ֻ�Ǵ����ڷ�������������·���ӣ�ֻ�лص�OnLogin()�ķ�����ָʾ�û��Ƿ�ɹ���¼�ˡ�
		* @ingroup G_T_Login
		*/
		virtual int Login(DDTradeLoginAuth^ loginAuth) {
			TapAPITradeLoginAuth field = To_ReqLoginField(loginAuth);
			return  api->Login(&field);
		}

		/**
		* @brief	�����Ͷ�����֤��֤��
		* @details	�˺�����Ҫ9.2.7��̨�����ݻص�����OnRtnContactInfo�е���ϵ��ʽ��ѡ������һ�����������֤��
		*			�յ���ȷӦ������ͨ��SetVertificateCode ���ö�����֤��Ȩ����ɵ�½���̡�
		* @param[out] sessionID��������ĻỰID��
		* @param[in]  ContractInfo,Ҫ���ն�����֤���������ߵ绰��
		* @attention �ú���������Ҫ�ڵ�½Ӧ��󷵻�10003����API��ص��ͻ����� ��֤����ϵ��ʽ���û�ѡ������һ����ϵ��ʽ��������ߵ绰�����������֤����ͨ�����ö�����֤��Ȩ����ɵ�½��
		*/
		virtual int RequestVertificateCode(int requestId, String^ ContactInfo)
		{
			TAPIUINT32 sessionID = requestId;
			return api->RequestVertificateCode(&sessionID, CAutoStrPtr(ContactInfo).m_pChar);
		}

		/**
		* @brief	���ö�����֤��Ϣ��
		* @details	��¼��ɺ����ϵͳ������Ҫ���ж�����֤�����룬���¼�����ʾ��Ҫ���ж�����֤��
		*			��ʱ���øú������������֤����ɵ�¼��
		*			��¼��ɺ������ٵ��ô˺���������ԭ������ĵ�¼ʧ��Ҳ���ܵ��ôκ���������᷵�ض�Ӧ�Ĵ�����Ϣ��
		*			���ô˽ӿں󣬻᷵�ص�¼Ӧ��ɹ����ı�ǣ�����ɹ���ʾ��¼��ɣ����Եȴ�OnAPIReady API��ɻص���
		*			�����ʱ���ص���ɺ�API�������Ͽ����ӣ���Ҫ�ٴν��е�¼������
		*			�����֤�����������ٴε��ô˺���������ȷ����֤�������֤��
		* @param[in] VertificateCode������֤�롣
		* @retval 0 ������֤��ɹ�
		* @retval ��0 ������
		* @operationtype �첽����
		* @ingroup G_T_Login
		*/
		virtual int SetVertificateCode(String^ VertificateCode)
		{
			return api->SetVertificateCode(CAutoStrPtr(VertificateCode).m_pChar);
		}

		/**
		* @brief	�޸����롣
		* @details	�ɹ����û����뽫�����ó�newPassword��
		* @param[out]	sessionID ���ش˴��޸�����ĻỰID;
		* @param[in]	req �����޸�����Ľṹ��ָ��
		* @retval 0 �ɹ�
		* @retval ��0 ������
		* @operationtype �첽����
		* @ingroup G_T_UserInfo
		*/
		virtual int ChangePassword(int requestId, DDChangePasswordReq^ req) {

			TAPIUINT32 sessionID = requestId;
			TapAPIChangePasswordReq entity = To_ChangePasswordField(req);
			return api->ChangePassword(&sessionID, &entity);
		}


		/**
		* @brief	��֤���롣
		* @details	����Ա��֤ĳ���˻������Ƿ���ȷ��
		* @param[out]	sessionID ���ش˴��޸�����ĻỰID;
		* @param[in]	req ������֤����Ľṹ��ָ��
		* @retval 0 �ɹ�
		* @retval ��0 ������
		* @operationtype �첽����
		* @ingroup G_T_UserInfo
		*/
		virtual int AuthPassword(int requestId, DDAuthPasswordReq^ req) {
			TAPIUINT32 sessionID = requestId;
			TapAPIAuthPasswordReq entity = To_AuthPasswordField(req);
			//
			return api->AuthPassword(&sessionID, &entity);
		}

		/**
		* @brief ��ѯ�û��������ʽ��˺�
		* @details	TapAPIAccQryReq�ǰ����ʽ��˺Žṹ�Ľṹ�壬�û���Ҫʵ�����˽ṹ�壬
		*			���ǲ���Ҫ��д������ṹ����Ҫ�����������û������ʽ��˺ţ��ʽ��˺�
		*			�ں����ĺ��������кܶຯ������Ҫʹ�õ���
		* @param[out]	sessionID ��������ĻỰID;
		* @param[in]	qryReq ��ѯ�û��������ʽ��˺ŵĽṹ��ָ��
		* @retval 0 ����ɹ�
		* @retval ��0 ������
		* @operationtype �첽����
		* @ingroup G_T_AccountInfo
		*/
		virtual int QryAccount(int requestId, DDAccQryReq^ info) {
			TAPIUINT32 sessionID = requestId;
			TapAPIAccQryReq entity = To_QryAccountField(info);
			return api->QryAccount(&sessionID, &entity);
		}

		/**
		* @brief	��ѯ�ͻ��ʽ�
		* @details	TapAPIFundReq��ҪQryAccount()��ȡ���ʽ��˺š�
		*			�����Ļص��������ʽ��˺ŵ��ʽ���Ϣ��\n
		* @param[out] sessionID ��������ĻỰID;
		* @param[in] qryReq	��ѯ�ͻ��ʽ�����Ľṹ��ָ��
		* @retval 0 ����ɹ�
		* @retval ��0 ������
		* @operationtype �첽����
		* @ingroup G_T_AccountDetails
		* @attention ÿ�ε�½���ýӿ�ֻ�ܽ���һ�ε��á������ʼ��ʱ����һ�Σ�������֪ͨͨ��OnRtnFundȡ�á�
		*/
		virtual int QryFund(int requestId, DDFundReq^ info) {
			TAPIUINT32 sessionID = requestId;
			TapAPIFundReq entity = To_QryFundField(info);
			return api->QryFund(&sessionID, &entity);
		}

		/**
		* @brief ��ѯ����ϵͳ��������Ϣ
		* @param[out] sessionID ��������ĻỰID;
		* @retval 0 ����ɹ�
		* @retval ��0 ������
		* @operationtype �첽����
		* @ingroup G_T_TradeSystem
		*/
		virtual int QryExchange(int requestId) {
			TAPIUINT32 sessionID = requestId;
			return api->QryExchange(&sessionID);
		}

		/**
		* @brief	��ѯϵͳƷ����Ϣ
		* @details	���������ȡ���е�Ʒ����Ϣ��
		* @param[out] sessionID ��������ĻỰID;
		* @retval 0 ����ɹ�
		* @retval ��0 ������
		* @operationtype �첽����
		* @ingroup G_T_Commodity
		*/
		virtual int QryCommodity(int requestId) {
			TAPIUINT32 sessionID = requestId;
			return api->QryCommodity(&sessionID);
		}

		/**
		* @brief	��ѯϵͳ��ָ��Ʒ�ֵĺ�Լ��Ϣ
		* @details	ʹ�ô˺���ǰ��Ҫ��Qrycommodity()ȡ��Ʒ����Ϣ��
		*			Ȼ��ѡ����Ҫ��Ʒ�ֽ���Ϣ����TapAPICommodity�ṹ������ɲ�ѯ����
		*			����TapAPICommodity����򷵻�������Ϣ��
		* @param[out] sessionID ��������ĻỰID;
		* @param[in] qryReq ��ѯϵͳ��ָ��Ʒ�ֵĺ�Լ��Ϣ����Ľṹ��ָ��;\n
		*				    �ò������ֶ�Ϊ��ѡ�ֶΣ����������·�����ѯ��\n
		*					1.ȫ�����գ������к�Լ\n
		*					2.��������������Ч����ý�����������Ʒ�ֵĺ�Լ\n
		*					3.�����������Ʒ��������Ч����ý�������ָ��Ʒ�����͵ĺ�Լ\n
		*					4.���������롢Ʒ�����ͺ�Ʒ�ֱ��붼��Ч�����Ʒ���µ����к�Լ
		* @retval 0 ����ɹ�
		* @retval ��0 ������
		* @operationtype �첽����
		* @ingroup G_T_Contract
		*/
		virtual int QryContract(int requestId, DDCommodity^ info) {
			TAPIUINT32 sessionID = requestId;
			TapAPICommodity entity = To_QryContractFiled(info);
			//
			return api->QryContract(&sessionID, &entity);
		}

		/**
		* @brief	�µ�
		* @details	�û��µ��Ĳ���������
		*			�û����µ�����������û����ʽ𡢳ֲ֡�ƽ�֡��ʽ𡢷�ر�ǵȶ������ݵı仯�������û��µĵ��ɽ���
		*			���ж���ص�֪ͨ�����û�չʾ���ݵı仯��
		* @param[out]	sessionID ��������ĻỰID;
		* @param[out]	ClientOrderNo ���ؿͻ�����ί�кš�
		* @param[in]	order �µ�ί��
		* @retval 0 ����ɹ�
		* @retval ��0 ������
		* @operationtype �첽����
		* @ingroup G_T_TradeActions
		*/
		virtual int InsertOrder(int requestId, String^ ClientOrderNo, DDNewOrder^ info) {
			TAPIUINT32 sessionID = requestId;
			TAPISTR_50 nn;
			strcpy(nn, CAutoStrPtr(ClientOrderNo).m_pChar);
			//
			TapAPINewOrder entity = To_InsertOrderField(info);
			return api->InsertOrder(&sessionID, &nn, &entity);
		}

		/**
		* @brief	����
		* @details	�û�ί��û����ȫ�ɽ�֮ǰ����ʣ���ί�С�
		* @param[out]	sessionID ��������ĻỰID;
		* @param[in]	order ������ί��
		* @retval 0 ����ɹ�
		* @retval ��0 ������
		* @operationtype �첽����
		* @ingroup G_T_TradeActions
		*/
		virtual int CancelOrder(int requestId, DDOrderCancelReq^ info) {
			TAPIUINT32 sessionID = requestId;
			TapAPIOrderCancelReq entity = To_CancelOrderField(info);
			return api->CancelOrder(&sessionID, &entity);
		}

		/**
		* @brief	�ĵ�
		* @details	�û���ί��û����ȫ�ɽ�֮ǰ���Խ��иĵ��������޸�ʣ���δ�ɽ���ί�С�\n
		*			�û���д�µ�ί�����޸�ԭ����δ�ɽ��Ĳ��֡��������޸Ļ�Ա��Ѿ��ɽ��Ĳ������۳��ɽ����֡�
		* @param[out]	sessionID ��������ĻỰID;
		* @param[in]	order �޸ĵ�ί��
		* @retval 0 ����ɹ�
		* @retval ��0 ������
		* @operationtype �첽����
		* @ingroup G_T_TradeActions
		*/
		virtual int AmendOrder(int requestId, DDAmendOrder^ info) {
			TAPIUINT32 sessionID = requestId;
			TapAPIAmendOrder entity = To_AmendOrderField(info);
			return api->AmendOrder(&sessionID, &entity);
		}


		/**
		* @brief	��ѯί����Ϣ
		* @details	���ص�ǰ��ί����Ϣ�����Բ�ѯ����ί�У�Ҳ���Բ�ѯ����δ������ί�С�\n
		* @retval 0 ����ɹ�
		* @retval ��0 ������
		* @operationtype �첽����
		* @ingroup G_T_TradeInfo
		* @attention ÿ�ε�½���ýӿ�ֻ�ܽ���һ�ε��á������ʼ��ʱ����һ�Σ�������֪ͨͨ��OnRtnOrderȡ�á�
		*/
		virtual int QryOrder(int requestId, DDOrderQryReq^ info) {
			TAPIUINT32 sessionID = requestId;
			TapAPIOrderQryReq entity = To_QryOrderField(info);
			return api->QryOrder(&sessionID, &entity);
		}


		/**
		* @brief ��ѯ�ɽ���Ϣ
		* @details	��ѯϵͳ�гɽ�����Ϣ��
		* @param[out] sessionID ��������ĻỰID;
		* @param[in] qryReq �ɽ���ѯ��Ϣ�ṹ��ָ�롣
		* @retval 0 ����ɹ�
		* @retval ��0 ������
		* @operationtype �첽����
		* @ingroup G_T_TradeInfo
		* @attention ÿ�ε�½���ýӿ�ֻ�ܽ���һ�ε��á������ʼ��ʱ����һ�Σ�������֪ͨͨ��OnRtnFillȡ�á�
		*/
		virtual int QryFill(int requestId, DDFillQryReq^ info) {
			TAPIUINT32 sessionID = requestId;
			TapAPIFillQryReq entity = To_QryFillField(info);
			return api->QryFill(&sessionID, &entity);
		}

		/**
		* @brief	��ѯ�û��ֲ�
		* @details	��ѯ�û������гֲ���Ϣ��
		* @param[out] sessionID ��������ĻỰID;
		* @param[in] qryReq	��ѯ�û��ֲ�����Ľṹ��ָ��
		* @retval 0 ����ɹ�
		* @retval ��0 ������
		* @operationtype �첽����
		* @ingroup G_T_TradeInfo
		* @attention ÿ�ε�½���ýӿ�ֻ�ܽ���һ�ε��á������ʼ��ʱ����һ�Σ�������֪ͨͨ��OnRtnPositionȡ�á�
		*/
		virtual int QryPosition(int requestId, DDPositionQryReq^ info) {
			TAPIUINT32 sessionID = requestId;
			TapAPIPositionQryReq entity = To_QryPositionField(info);
			return api->QryPosition(&sessionID, &entity);
		}

		/**
		* @brief	��ѯ�û��ֲֻ���
		* @details	��ѯ�û������гֲ���Ϣ��
		* @param[out] sessionID ��������ĻỰID;
		* @param[in] qryReq	��ѯ�û��ֲ�����Ľṹ��ָ��
		* @retval 0 ����ɹ�
		* @retval ��0 ������
		* @operationtype �첽����
		* @ingroup G_T_TradeInfo
		* @attention ÿ�ε�½���ýӿ�ֻ�ܽ���һ�ε��á������ʼ��ʱ����һ�Σ�������֪ͨͨ��OnRtnPositionȡ�á�
		*/
		virtual int QryPositionSummary(int requestId, DDPositionQryReq^ info) {
			TAPIUINT32 sessionID = requestId;
			TapAPIPositionQryReq entity = To_QryPositionSummaryField(info);
			return api->QryPositionSummary(&sessionID, &entity);
		}

		/**
		* @brief ��ȡ�������ñ��ֵ���Ϣ
		* @param[out] sessionID ��������ĻỰID;
		* @retval 0 ����ɹ�
		* @retval ��0 ������
		* @operationtype �첽����
		* @ingroup G_T_TradeSystem
		*/
		virtual int QryCurrency(int requestId) {
			TAPIUINT32 sessionID = requestId;
			return api->QryCurrency(&sessionID);
		}


		/**
		* @brief	��ȡ���׻�����Ϣ
		* @details	�˺�������������ȡ�˺ŵĽ��׻��߷����Ϣ�����׻��߷����Ϣ������ʶ�˺ŵ�״̬��
		* @param[out] sessionID ��������ĻỰID;
		* @param[in] qryReq ��ȡ���׻�����Ϣ����Ľṹ��ָ��;
		* @retval 0 ����ɹ�
		* @retval ��0 ������
		* @operationtype �첽����
		˵������ʢ�����ӿ�
		* @ingroup G_T_AccountDetails
		*/
		virtual int QryTradeMessage(int requestId, DDTradeMessageReq^ info) {
			TAPIUINT32 sessionID = requestId;
			TapAPITradeMessageReq entity = To_QryTradeMessageField(info);
			return api->QryTradeMessage(&sessionID, &entity);
		}

		/**
		* @brief ��ѯ�û��˵�
		* @param[out]	sessionID ��������ĻỰID;
		* @param[in]	qryReq	��ѯ�ʵ�����Ľṹ��ָ��
		* @retval 0 ����ɹ�
		* @retval ��0 ������
		* @operationtype �첽����
		* @ingroup G_T_Bill
		*/
		virtual int QryBill(int requestId, DDBillQryReq^ info) {
			TAPIUINT32 sessionID = requestId;
			TapAPIBillQryReq entity = To_QryBillField(info);
			return api->QryBill(&sessionID, &entity);
		}

		/**
		* @brief ��ʷί�в�ѯ����
		* @param[out]	sessionID ��������ĻỰID;
		* @param[in]	Req	��ʷί�в�ѯ����Ľṹ��ָ��
		* @retval 0 ����ɹ�
		* @retval ��0 ������
		* @operationtype �첽����
		* @ingroup G_T_HisInfo
		*/
		virtual int QryHisOrder(int requestId, DDHisOrderQryReq^ info) {
			TAPIUINT32 sessionID = requestId;
			TapAPIHisOrderQryReq entity = To_QryHisOrderField(info);
			return api->QryHisOrder(&sessionID, &entity);
		}


		/**
		* @brief ��ʷ�ɽ���ѯ����
		* @param[out] sessionID ��������ĻỰID;
		* @param[in]	Req	��ʷ�ɽ���ѯ����Ľṹ��ָ��
		* @retval 0 ����ɹ�
		* @retval ��0 ������
		* @operationtype �첽����
		* @ingroup G_T_HisInfo
		*/
		virtual int QryHisMatch(int requestId, DDHisMatchQryReq^ info) {
			TAPIUINT32 sessionID = requestId;
			TapAPIHisMatchQryReq entity = To_QryHisMatchField(info);
			return api->QryHisMatch(&sessionID, &entity);
		}

		/**
		* @brief ��ʷ�ֲֲ�ѯ����
		* @param[out] sessionID ��������ĻỰID;
		* @param[in]	Req	��ʷ�ֲֲ�ѯ����Ľṹ��ָ��
		* @retval 0 ����ɹ�
		* @retval ��0 ������
		* @operationtype �첽����
		* @ingroup G_T_HisInfo
		*/
		virtual int QryHisPosition(int requestId, DDHisPositionQryReq^ info) {
			TAPIUINT32 sessionID = requestId;
			TapAPIHisPositionQryReq entity = To_QryHisPositionField(info);
			return api->QryHisPosition(&sessionID, &entity);
		}



		/**
		* @brief �ͻ������Ѽ��������ѯ����
		* @param[out] sessionID ��������ĻỰID;
		* @param[in]	Req	�ͻ������Ѽ��������ѯ����ṹ
		* @retval 0 ����ɹ�
		* @retval ��0 ������
		* @operationtype �첽����
		* @ingroup G_T_Rent
		*/
		virtual int QryAccountFeeRent(int requestId, DDAccountFeeRentQryReq^ info) {
			TAPIUINT32 sessionID = requestId;
			TapAPIAccountFeeRentQryReq entity = To_QryAccountFeeRentField(info);
			return api->QryAccountFeeRent(&sessionID, &entity);
		}

		/**
		* @brief �ͻ���֤����������ѯ����
		* @param[out] sessionID ��������ĻỰID;
		* @param[in]	Req	�ͻ���֤����������ѯ����ṹ
		* @retval 0 ����ɹ�
		* @retval ��0 ������
		* @operationtype �첽����
		* @ingroup G_T_Rent
		*/
		virtual int QryAccountMarginRent(int requestId, DDAccountMarginRentQryReq^ info) {
			TAPIUINT32 sessionID = requestId;
			TapAPIAccountMarginRentQryReq entity = To_QryAccountMarginRentField(info);
			return api->QryAccountMarginRent(&sessionID, &entity);
		}









		//---------------------------------------------------------------------------------------------static
		//---------------------------------------------------------------------------------------------static
	public:

		static String^ GetAPIVersion() {
			String^ str = gcnew String(GetITapTradeAPIVersion());
			return str;
		}

		static	String^  GetErrorDescribe(int iErrcode) {
			return gcnew String(GetITapErrorDescribe(iErrcode));
		}

		static	int  SetAPILogLevel(DDEnumLogLevel level) {
			return SetITapTradeAPILogLevel((TAPILOGLEVEL)level);
		}


		static	int  SetAPIDataPath(String^ path) {
			return SetITapTradeAPIDataPath(CAutoStrPtr(path).m_pChar);
		}

	};

};