using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PBMSBatch.Model
{
    /// <summary>
    /// 配件包销售出货资料子表
    /// </summary>
    public class BMSSalesDInfo
    {
        /// <summary> <summary>
        private System.Decimal m_BMS_SALES_D_ID;
        public System.Decimal BMS_SALES_D_ID
        {
            get
            {
                return m_BMS_SALES_D_ID;
            }
            set
            {
                m_BMS_SALES_D_ID = value;
            }
        }

        /// <summary> <summary>
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
        private System.Decimal m_TRANSACTION_ID;
        public System.Decimal TRANSACTION_ID
        {
            get
            {
                return m_TRANSACTION_ID;
            }
            set
            {
                m_TRANSACTION_ID = value;
            }
        }

        /// <summary> <summary>
        private System.String m_TRANSACTION_TYPE_NAME;
        public System.String TRANSACTION_TYPE_NAME
        {
            get
            {
                return m_TRANSACTION_TYPE_NAME;
            }
            set
            {
                m_TRANSACTION_TYPE_NAME = value;
            }
        }

        /// <summary> <summary>
        private System.String m_SEQ_NO;
        public System.String SEQ_NO
        {
            get
            {
                return m_SEQ_NO;
            }
            set
            {
                m_SEQ_NO = value;
            }
        }

        /// <summary> <summary>
        private System.String m_SO;
        public System.String SO
        {
            get
            {
                return m_SO;
            }
            set
            {
                m_SO = value;
            }
        }

        /// <summary> <summary>
        private System.String m_ITEM_CODE;
        public System.String ITEM_CODE
        {
            get
            {
                return m_ITEM_CODE;
            }
            set
            {
                m_ITEM_CODE = value;
            }
        }

        /// <summary> <summary>
        private System.String m_CUSTOMER_PART_NO;
        public System.String CUSTOMER_PART_NO
        {
            get
            {
                return m_CUSTOMER_PART_NO;
            }
            set
            {
                m_CUSTOMER_PART_NO = value;
            }
        }

        /// <summary> <summary>
        private System.String m_ITEM_DESC_CUS;
        public System.String ITEM_DESC_CUS
        {
            get
            {
                return m_ITEM_DESC_CUS;
            }
            set
            {
                m_ITEM_DESC_CUS = value;
            }
        }

        /// <summary> <summary>
        private System.String m_RMA_NO;
        public System.String RMA_NO
        {
            get
            {
                return m_RMA_NO;
            }
            set
            {
                m_RMA_NO = value;
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
        private System.String m_ORIGIN_INVOICE;
        public System.String ORIGIN_INVOICE
        {
            get
            {
                return m_ORIGIN_INVOICE;
            }
            set
            {
                m_ORIGIN_INVOICE = value;
            }
        }

        /// <summary> <summary>
        private System.Decimal m_SHIP_QTY;
        public System.Decimal SHIP_QTY
        {
            get
            {
                return m_SHIP_QTY;
            }
            set
            {
                m_SHIP_QTY = value;
            }
        }

        /// <summary> <summary>
        private System.Decimal m_PRICE;
        public System.Decimal PRICE
        {
            get
            {
                return m_PRICE;
            }
            set
            {
                m_PRICE = value;
            }
        }

        /// <summary> <summary>
        private System.Decimal m_AMOUNT;
        public System.Decimal AMOUNT
        {
            get
            {
                return m_AMOUNT;
            }
            set
            {
                m_AMOUNT = value;
            }
        }

        /// <summary> <summary>
        private System.Decimal m_NET_WEIGHT;
        public System.Decimal NET_WEIGHT
        {
            get
            {
                return m_NET_WEIGHT;
            }
            set
            {
                m_NET_WEIGHT = value;
            }
        }

        /// <summary> <summary>
        private System.Decimal m_GROSS_WEIGHT;
        public System.Decimal GROSS_WEIGHT
        {
            get
            {
                return m_GROSS_WEIGHT;
            }
            set
            {
                m_GROSS_WEIGHT = value;
            }
        }

        /// <summary> <summary>
        private System.String m_MEASURE_CORP_CODE_W;
        public System.String MEASURE_CORP_CODE_W
        {
            get
            {
                return m_MEASURE_CORP_CODE_W;
            }
            set
            {
                m_MEASURE_CORP_CODE_W = value;
            }
        }

        /// <summary> <summary>
        private System.Decimal m_REG_QTY;
        public System.Decimal REG_QTY
        {
            get
            {
                return m_REG_QTY;
            }
            set
            {
                m_REG_QTY = value;
            }
        }

        /// <summary> <summary>
        private System.Decimal m_APPLY_QTY;
        public System.Decimal APPLY_QTY
        {
            get
            {
                return m_APPLY_QTY;
            }
            set
            {
                m_APPLY_QTY = value;
            }
        }

        /// <summary> <summary>
        private System.Decimal m_REG_AMOUNT;
        public System.Decimal REG_AMOUNT
        {
            get
            {
                return m_REG_AMOUNT;
            }
            set
            {
                m_REG_AMOUNT = value;
            }
        }

        /// <summary> <summary>
        private System.Decimal m_APPLY_AMOUNT;
        public System.Decimal APPLY_AMOUNT
        {
            get
            {
                return m_APPLY_AMOUNT;
            }
            set
            {
                m_APPLY_AMOUNT = value;
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
        private System.String m_CUSTOM_NO;
        public System.String CUSTOM_NO
        {
            get
            {
                return m_CUSTOM_NO;
            }
            set
            {
                m_CUSTOM_NO = value;
            }
        }

        /// <summary> <summary>
        private System.Decimal m_ITEM_SEQ;
        public System.Decimal ITEM_SEQ
        {
            get
            {
                return m_ITEM_SEQ;
            }
            set
            {
                m_ITEM_SEQ = value;
            }
        }

        /// <summary> <summary>
        private System.Decimal m_ORDER_SEQ;
        public System.Decimal ORDER_SEQ
        {
            get
            {
                return m_ORDER_SEQ;
            }
            set
            {
                m_ORDER_SEQ = value;
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

        /// <summary> </summary>
        private System.String m_RETURN_NO;
        public System.String RETURN_NO
        {
            get
            {
                return m_RETURN_NO;
            }
            set
            {
                m_RETURN_NO = value;
            }
        }

        /// <summary> </summary>
        private System.String m_RETURN_LINE;
        public System.String RETURN_LINE
        {
            get
            {
                return m_RETURN_LINE;
            }
            set
            {
                m_RETURN_LINE = value;
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
        private System.String m_SAGEM_PN;
        public System.String SAGEM_PN
        {
            get
            {
                return m_SAGEM_PN;
            }
            set
            {
                m_SAGEM_PN = value;
            }
        }
    }
}
