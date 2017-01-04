using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PBMSBatch.Model
{
    public class BMSSalesCItemInfo
    {
        private System.Decimal m_BMS_SALES_CITEM_ID;
        public System.Decimal BMS_SALES_CITEM_ID
        {
            get
            {
                return this.m_BMS_SALES_CITEM_ID;
            }
            set
            {
                this.m_BMS_SALES_CITEM_ID = value;
            }
        }
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
        private string m_ITEM_CODE;
        public string ITEM_CODE
        {
            get
            {
                return this.m_ITEM_CODE;
            }
            set
            {
                this.m_ITEM_CODE = value;
            }
        }
        private string m_ITEM_CODE_C;
        public string ITEM_CODE_C
        {
            get
            {
                return this.m_ITEM_CODE_C;
            }
            set
            {
                this.m_ITEM_CODE_C = value;
            }
        }
        private System.Decimal m_QUANTITY;
        public System.Decimal QUANTITY
        {
            get
            {
                return this.m_QUANTITY;
            }
            set
            {
                this.m_QUANTITY = value;
            }
        }
        private System.Decimal m_CTN_NW;
        public System.Decimal CTN_NW
        {
            get
            {
                return this.m_CTN_NW;
            }
            set
            {
                this.m_CTN_NW = value;
            }
        }
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
    }
}
