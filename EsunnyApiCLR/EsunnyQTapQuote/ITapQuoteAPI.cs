//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace QTapQuoteWrapperApi
{
    /// <summary>
    /// TapQuoteAPI ���⹦�ܽӿڡ��������û����Ե��õĹ��ܺ�����
    /// </summary>
    public class ITapQuoteAPI : global::System.IDisposable
    {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;
        protected bool swigCMemOwn;

        internal ITapQuoteAPI(global::System.IntPtr cPtr, bool cMemoryOwn)
        {
            swigCMemOwn = cMemoryOwn;
            swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ITapQuoteAPI obj)
        {
            return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
        }

        ~ITapQuoteAPI()
        {
            Dispose();
        }

        public virtual void Dispose()
        {
            lock (this)
            {
                if (swigCPtr.Handle != global::System.IntPtr.Zero)
                {
                    if (swigCMemOwn)
                    {
                        swigCMemOwn = false;
                        QTapQuoteApiPINVOKE.delete_ITapQuoteAPI(swigCPtr);
                    }
                    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
                }
                global::System.GC.SuppressFinalize(this);
            }
        }

        /// <summary>
        /// ����API�Ļص��ӿڶ���
        /// ϵͳ��API��֪ͨ��ͨ�����õĻص�����֪ͨ��ʹ���ߡ�ITapQuoteAPINofify��API�Ļص��ӿڣ�
        /// �û���Ҫ�̳�ʵ�ִ˽ӿ������������û���Ҫ�Ĺ��ܡ�
        /// ����û�û�����ûص��ӿڣ���API�������û������κ����õ���Ϣ��
        /// ͬ������
        /// </summary>
        /// <param name="apiNotify">ʵ����ITapQuoteAPINotify�ӿڵĶ���</param>
        /// <returns>0 ����ɹ� ��0 ������</returns>
        public virtual int SetAPINotify(ITapQuoteAPINotify apiNotify)
        {
            int ret = QTapQuoteApiPINVOKE.ITapQuoteAPI_SetAPINotify(swigCPtr, ITapQuoteAPINotify.getCPtr(apiNotify));
            return ret;
        }

        /// <summary>
        /// ���÷�������IP��ַ�Ͷ˿ڡ��ȵ�����Loginʱ�����������ӡ�ͬ������
        /// </summary>
        /// <param name="IP">IP��ַ</param>
        /// <param name="port">�˿ں�</param>
        /// <returns>0 ����ɹ� ��0 ������</returns>
        public virtual int SetHostAddress(string IP, ushort port)
        {
            int ret = QTapQuoteApiPINVOKE.ITapQuoteAPI_SetHostAddress(swigCPtr, IP, port);
            return ret;
        }

        /// <summary>
        /// �����¼����API�������ӷ��񣬽�����·�������¼��֤��
        /// ��ʹ�ú�������ǰ�û���Ҫ��ɷ�����������SetHostAddress()�����Ҵ���TapAPIQuoteLoginAuth���͵��û���Ϣ��
        /// ������Ҫ���úûص��ӿڡ�
        /// ���ӽ�������û���֤������Ϣͨ���ص�OnLogin()���ظ��û���
        /// ��¼�ɹ���API���Զ�����API�ĳ�ʼ����API�����������������ݣ���ѯ���Ժ��ͨ���ص�OnAPIReady()
        /// ָʾ�û�API��ʼ����ɣ����Խ��к����Ĳ����ˡ�
        /// �첽����
        /// </summary>
        /// <param name="loginAuth">��¼��֤��Ϣ��������¼��Ҫ����֤��Ϣ��</param>
        /// <returns>0 ����ɹ� ��0 ������</returns>
        public virtual int Login(TapAPIQuoteLoginAuth loginAuth)
        {
            int ret = QTapQuoteApiPINVOKE.ITapQuoteAPI_Login(swigCPtr, TapAPIQuoteLoginAuth.getCPtr(loginAuth));
            return ret;
        }

        /// <summary>
        /// �Ͽ��ͷ���������·���ӡ�
        /// ���ú�����API���ǳ����Ͽ�������������ӡ�
        /// �첽����
        /// </summary>
        /// <returns>0 ����ɹ� ��0 ������</returns>
        public virtual int Disconnect()
        {
            int ret = QTapQuoteApiPINVOKE.ITapQuoteAPI_Disconnect(swigCPtr);
            return ret;
        }

        /// <summary>
        /// �õ�����Ʒ�֣��첽����
        /// </summary>
        /// <param name="sessionID">��������ĻỰID��</param>
        /// <returns>0 ����ɹ� ��0 ������</returns>
        public virtual int QryCommodity(out uint sessionID)
        {
            int ret = QTapQuoteApiPINVOKE.ITapQuoteAPI_QryCommodity(swigCPtr, out sessionID);
            return ret;
        }

        /// <summary>
        /// ��ѯϵͳ��ָ��Ʒ�ֵĺ�Լ��Ϣ
        /// ʹ�ô˺���ǰ��Ҫ��QryCommodity()ȡ��Ʒ����Ϣ��Ȼ��ѡ����Ҫ��Ʒ�ֽ���Ϣ����TapAPICommodity�ṹ������ɲ�ѯ����
        /// �첽����
        /// </summary>
        /// <param name="sessionID">��������ĻỰID;</param>
        /// <param name="qryReq">��ѯϵͳ��ָ��Ʒ�ֵĺ�Լ��Ϣ����Ľṹ�壬�ò������ֶ�Ϊ��ѡ�ֶΣ����������·�����ѯ��1.ȫ�����գ������к�Լ��
        /// 2.��������������Ч����ý�����������Ʒ�ֵĺ�Լ��
        /// 3.�����������Ʒ��������Ч����ý�������ָ��Ʒ�����͵ĺ�Լ��
        /// 4.���������롢Ʒ�����ͺ�Ʒ�ֱ��붼��Ч�����Ʒ���µ����к�Լ
        /// </param>
        /// <returns>0 ����ɹ�����0 ������</returns>
        public virtual int QryContract(out uint sessionID, TapAPICommodity qryReq)
        {
            int ret = QTapQuoteApiPINVOKE.ITapQuoteAPI_QryContract(swigCPtr, out sessionID, TapAPICommodity.getCPtr(qryReq));
            return ret;
        }

        /// <summary>
        /// ����ָ����Լ������
        /// ���������������contract�����ĺ�Լ��������Ϣ�����鶩�ĳɹ�����������������û�����������Ϣ��
        /// ֱ���û��˶�������Ϣ���߶Ͽ��ڷ�������ͨ�š����ô˺���ǰ�Ȼ�ȡ��Լ��Ϣ��Ȼ��Ӻ�Լ��Ϣ��ȡ����Լ����contract��
        /// �첽����
        /// </summary>
        /// <param name="sessionID">��������ĻỰID��</param>
        /// <param name="contract">ָ����Լ</param>
        /// <returns> 0 ����ɹ� ��0 ������</returns>
        public virtual int SubscribeQuote(out uint sessionID, TapAPIContract contract)
        {
            int ret = QTapQuoteApiPINVOKE.ITapQuoteAPI_SubscribeQuote(swigCPtr, out sessionID, TapAPIContract.getCPtr(contract));
            return ret;
        }

        /// <summary>
        /// �˶�ָ����Լ�����飬�˶��Ѿ����ĵ�������Ϣ���첽����
        /// </summary>
        /// <param name="sessionID">��������ĻỰID</param>
        /// <param name="contract">ָ����Լ</param>
        /// <returns>0 ����ɹ� ��0 ������</returns>
        public virtual int UnSubscribeQuote(out uint sessionID, TapAPIContract contract)
        {
            int ret = QTapQuoteApiPINVOKE.ITapQuoteAPI_UnSubscribeQuote(swigCPtr, out sessionID, TapAPIContract.getCPtr(contract));
            return ret;
        }

    }

}