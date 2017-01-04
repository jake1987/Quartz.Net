using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PBMSBatch.Model
{
    /// <summary>
    /// 配件包销售出货资料主表
    /// </summary>
    public class BMSSalesInfo
    {
        private System.Decimal m_BMS_SALES_ID;
        public System.Decimal BMS_SALES_ID
        {
            get
            {
                return m_BMS_SALES_ID;
            }
            set
            {
                m_BMS_SALES_ID = value;
            }
        }

        /// <summary> <summary>
        private System.String m_MANUAL_NO;
        public System.String MANUAL_NO
        {
            get
            {
                return m_MANUAL_NO;
            }
            set
            {
                m_MANUAL_NO = value;
            }
        }

        /// <summary> <summary>
        private System.String m_INVOICE_NO;
        public System.String INVOICE_NO
        {
            get
            {
                return m_INVOICE_NO;
            }
            set
            {
                m_INVOICE_NO = value;
            }
        }

        /// <summary> <summary>
        private System.String m_INVOICE_NO_SUM;
        public System.String INVOICE_NO_SUM
        {
            get
            {
                return m_INVOICE_NO_SUM;
            }
            set
            {
                m_INVOICE_NO_SUM = value;
            }
        }

        /// <summary> <summary>
        private System.String m_CUSTOMER_CODE;
        public System.String CUSTOMER_CODE
        {
            get
            {
                return m_CUSTOMER_CODE;
            }
            set
            {
                m_CUSTOMER_CODE = value;
            }
        }

        /// <summary> <summary>
        private System.String m_CUSTOMER_NAME;
        public System.String CUSTOMER_NAME
        {
            get
            {
                return m_CUSTOMER_NAME;
            }
            set
            {
                m_CUSTOMER_NAME = value;
            }
        }

        /// <summary> <summary>
        private System.String m_DELIVERY_CUSTOMER_CODE;
        public System.String DELIVERY_CUSTOMER_CODE
        {
            get
            {
                return m_DELIVERY_CUSTOMER_CODE;
            }
            set
            {
                m_DELIVERY_CUSTOMER_CODE = value;
            }
        }

        /// <summary> <summary>
        private System.String m_DELIVERY_CUSTOMER_NAME;
        public System.String DELIVERY_CUSTOMER_NAME
        {
            get
            {
                return m_DELIVERY_CUSTOMER_NAME;
            }
            set
            {
                m_DELIVERY_CUSTOMER_NAME = value;
            }
        }

        /// <summary> <summary>
        private System.String m_SHIP_TO;
        public System.String SHIP_TO
        {
            get
            {
                return m_SHIP_TO;
            }
            set
            {
                m_SHIP_TO = value;
            }
        }

        /// <summary> <summary>
        private System.String m_CONSIGNEE_ADDRESS;
        public System.String CONSIGNEE_ADDRESS
        {
            get
            {
                return m_CONSIGNEE_ADDRESS;
            }
            set
            {
                m_CONSIGNEE_ADDRESS = value;
            }
        }

        /// <summary> <summary>
        private System.String m_ATTN;
        public System.String ATTN
        {
            get
            {
                return m_ATTN;
            }
            set
            {
                m_ATTN = value;
            }
        }

        /// <summary> <summary>
        private System.String m_ATTN_TEL;
        public System.String ATTN_TEL
        {
            get
            {
                return m_ATTN_TEL;
            }
            set
            {
                m_ATTN_TEL = value;
            }
        }

        /// <summary> <summary>
        private System.String m_ATTN_FAX;
        public System.String ATTN_FAX
        {
            get
            {
                return m_ATTN_FAX;
            }
            set
            {
                m_ATTN_FAX = value;
            }
        }

        /// <summary> <summary>
        private System.String m_BILL_TO;
        public System.String BILL_TO
        {
            get
            {
                return m_BILL_TO;
            }
            set
            {
                m_BILL_TO = value;
            }
        }

        /// <summary> <summary>
        private System.String m_BILL_ADDRESS;
        public System.String BILL_ADDRESS
        {
            get
            {
                return m_BILL_ADDRESS;
            }
            set
            {
                m_BILL_ADDRESS = value;
            }
        }

        /// <summary> <summary>
        private System.String m_BILL_ATTN;
        public System.String BILL_ATTN
        {
            get
            {
                return m_BILL_ATTN;
            }
            set
            {
                m_BILL_ATTN = value;
            }
        }

        /// <summary> <summary>
        private System.String m_BILL_ATTN_TEL;
        public System.String BILL_ATTN_TEL
        {
            get
            {
                return m_BILL_ATTN_TEL;
            }
            set
            {
                m_BILL_ATTN_TEL = value;
            }
        }

        /// <summary> <summary>
        private System.String m_BILL_ATTN_FAX;
        public System.String BILL_ATTN_FAX
        {
            get
            {
                return m_BILL_ATTN_FAX;
            }
            set
            {
                m_BILL_ATTN_FAX = value;
            }
        }

        /// <summary> <summary>
        private System.String m_PO;
        public System.String PO
        {
            get
            {
                return m_PO;
            }
            set
            {
                m_PO = value;
            }
        }

        /// <summary> <summary>
        private System.String m_AIRWAY_BILL_NO;
        public System.String AIRWAY_BILL_NO
        {
            get
            {
                return m_AIRWAY_BILL_NO;
            }
            set
            {
                m_AIRWAY_BILL_NO = value;
            }
        }

        /// <summary> <summary>
        private System.String m_DELIVER_TYPE;
        public System.String DELIVER_TYPE
        {
            get
            {
                return m_DELIVER_TYPE;
            }
            set
            {
                m_DELIVER_TYPE = value;
            }
        }

        /// <summary> <summary>
        private System.String m_VIA;
        public System.String VIA
        {
            get
            {
                return m_VIA;
            }
            set
            {
                m_VIA = value;
            }
        }

        /// <summary> <summary>
        private System.String m_FROM_COUNTRY;
        public System.String FROM_COUNTRY
        {
            get
            {
                return m_FROM_COUNTRY;
            }
            set
            {
                m_FROM_COUNTRY = value;
            }
        }

        /// <summary> <summary>
        private System.String m_DESTINATION;
        public System.String DESTINATION
        {
            get
            {
                return m_DESTINATION;
            }
            set
            {
                m_DESTINATION = value;
            }
        }

        /// <summary> <summary>
        private System.DateTime m_SHIP_DATE;
        public System.DateTime SHIP_DATE
        {
            get
            {
                return m_SHIP_DATE;
            }
            set
            {
                m_SHIP_DATE = value;
            }
        }

        /// <summary> <summary>
        private System.String m_PAYMENT_TERM;
        public System.String PAYMENT_TERM
        {
            get
            {
                return m_PAYMENT_TERM;
            }
            set
            {
                m_PAYMENT_TERM = value;
            }
        }

        /// <summary> <summary>
        private System.String m_TRADE_TERM;
        public System.String TRADE_TERM
        {
            get
            {
                return m_TRADE_TERM;
            }
            set
            {
                m_TRADE_TERM = value;
            }
        }

        /// <summary> <summary>
        private System.String m_TRADE_TERM_DESC;
        public System.String TRADE_TERM_DESC
        {
            get
            {
                return m_TRADE_TERM_DESC;
            }
            set
            {
                m_TRADE_TERM_DESC = value;
            }
        }

        /// <summary> <summary>
        private System.String m_CURRENCY_CORP_CODE;
        public System.String CURRENCY_CORP_CODE
        {
            get
            {
                return m_CURRENCY_CORP_CODE;
            }
            set
            {
                m_CURRENCY_CORP_CODE = value;
            }
        }

        /// <summary> <summary>
        private System.String m_IS_APPLY;
        public System.String IS_APPLY
        {
            get
            {
                return m_IS_APPLY;
            }
            set
            {
                m_IS_APPLY = value;
            }
        }

        /// <summary> <summary>
        private System.String m_IS_PACK;
        public System.String IS_PACK
        {
            get
            {
                return m_IS_PACK;
            }
            set
            {
                m_IS_PACK = value;
            }
        }

        /// <summary> <summary>
        private System.String m_INVOICE_TYPE;
        public System.String INVOICE_TYPE
        {
            get
            {
                return m_INVOICE_TYPE;
            }
            set
            {
                m_INVOICE_TYPE = value;
            }
        }

        /// <summary> <summary>
        private System.String m_REMARK;
        public System.String REMARK
        {
            get
            {
                return m_REMARK;
            }
            set
            {
                m_REMARK = value;
            }
        }

        /// <summary> <summary>
        private System.String m_CUSTOMER_SITE_NUM;
        public System.String CUSTOMER_SITE_NUM
        {
            get
            {
                return m_CUSTOMER_SITE_NUM;
            }
            set
            {
                m_CUSTOMER_SITE_NUM = value;
            }
        }
        /// <summary> <summary>
        private System.String m_IS_PROCESS;
        public System.String IS_PROCESS
        {
            get
            {
                return m_IS_PROCESS;
            }
            set
            {
                m_IS_PROCESS = value;
            }
        }
        /// <summary> <summary>
        private System.String m_LINE_TYPE;
        public System.String LINE_TYPE
        {
            get
            {
                return m_LINE_TYPE;
            }
            set
            {
                m_LINE_TYPE = value;
            }
        }
        /// <summary> <summary>
        private System.String m_ORGANIZATION_CODE;
        public System.String ORGANIZATION_CODE
        {
            get
            {
                return m_ORGANIZATION_CODE;
            }
            set
            {
                m_ORGANIZATION_CODE = value;
            }
        }

        /// <summary> <summary>
        private System.String m_WAREHOUSE_TYPE;
        public System.String WAREHOUSE_TYPE
        {
            get
            {
                return m_WAREHOUSE_TYPE;
            }
            set
            {
                m_WAREHOUSE_TYPE = value;
            }
        }
        /// <summary> <summary>
        private System.Decimal m_CREATE_USER_ID;
        public System.Decimal CREATE_USER_ID
        {
            get
            {
                return m_CREATE_USER_ID;
            }
            set
            {
                m_CREATE_USER_ID = value;
            }
        }

        /// <summary> <summary>
        private System.DateTime m_CREATE_DATE;
        public System.DateTime CREATE_DATE
        {
            get
            {
                return m_CREATE_DATE;
            }
            set
            {
                m_CREATE_DATE = value;
            }
        }

        /// <summary> <summary>
        private System.Decimal m_LAST_UPDATE_USER_ID;
        public System.Decimal LAST_UPDATE_USER_ID
        {
            get
            {
                return m_LAST_UPDATE_USER_ID;
            }
            set
            {
                m_LAST_UPDATE_USER_ID = value;
            }
        }

        /// <summary> <summary>
        private System.DateTime m_LAST_UPDATE_DATE;
        public System.DateTime LAST_UPDATE_DATE
        {
            get
            {
                return m_LAST_UPDATE_DATE;
            }
            set
            {
                m_LAST_UPDATE_DATE = value;
            }
        }

        //newtea add 20090122
        private System.String m_DEPARTMENT_CODE;
        public System.String DEPARTMENT_CODE
        {
            get
            {
                return m_DEPARTMENT_CODE;
            }
            set
            {
                m_DEPARTMENT_CODE = value;
            }
        }

        private System.String m_DEPARTMENT_DESC;
        public System.String DEPARTMENT_DESC
        {
            get
            {
                return m_DEPARTMENT_DESC;
            }
            set
            {
                m_DEPARTMENT_DESC = value;
            }
        }
        //newtea end 

        /// <summary> </summary>
        private System.String m_TAX_TYPE;
        public System.String TAX_TYPE
        {
            get
            {
                return m_TAX_TYPE;
            }
            set
            {
                m_TAX_TYPE = value;
            }
        }

        /// <summary> </summary>
        private System.Decimal m_ORG_ID;
        public System.Decimal ORG_ID
        {
            get
            {
                return m_ORG_ID;
            }
            set
            {
                m_ORG_ID = value;
            }
        }

        /// <summary> </summary>
        private System.String m_NOTIFY1;
        public System.String NOTIFY1
        {
            get
            {
                return m_NOTIFY1;
            }
            set
            {
                m_NOTIFY1 = value;
            }
        }
    }
}
