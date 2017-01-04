using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using PBMSBatch.Common;
using PBMSBatch.DAL;
using PBMSBatch.DBUtility;
using PBMSBatch.Model;

namespace PBMSBatch.BLL
{
    public class BMSSalesCKDBLL
    {
        private BMSSalesCKDDAL dal = new BMSSalesCKDDAL();
        public bool makeSalesFiles(DataRow oRd)
        {
            BMSSalesCKDInfo Sales = new BMSSalesCKDInfo();
            try
            {
                string strShipType = oRd["IS_PROCESS"].ToString();
                if (oRd["DELIVERY_NO"].ToString().Length > 0)
                {
                    dal.DeleteByDn(oRd["DELIVERY_NO"].ToString());
                    if (oRd["DELIVERY_NO"].ToString().Substring(0, 1) == "P" || oRd["DELIVERY_NO"].ToString().Substring(0, 1) == "W")
                    {
                        strShipType = "P";
                    }
                    else if (oRd["DELIVERY_NO"].ToString().Substring(0, 1) == "T")
                    {
                        strShipType = "Y";
                    }
                    else if (oRd["DELIVERY_NO"].ToString().Substring(0, 1) == "D")//BY KAIJIE
                    {
                        strShipType = "D";
                    }
                    else
                    {
                        strShipType = "N";
                    }
                }
                Sales.INVOICE_NO = oRd["DELIVERY_NO"].ToString();
                Sales.CUSTOMER_CODE = oRd["CUSTOMER_NUMBER"].ToString();
                Sales.CUSTOMER_NAME = oRd["CUSTOMER_NAME"].ToString();
                Sales.DELIVERY_CUSTOMER_CODE = oRd["DELIVERY_CUSTOMER_CODE"].ToString();
                Sales.DELIVERY_CUSTOMER_NAME = oRd["DELIVERY_CUSTOMER_NAME"].ToString();
                Sales.SHIP_TO = oRd["DELIVERY_CUSTOMER_NAME"].ToString().Replace("'", "''");
                Sales.BILL_TO = oRd["CUSTOMER_NAME"].ToString().Replace("'", "''");
                Sales.CONSIGNEE_ADDRESS = oRd["DELIVERY_CUSTOMER_ADDRESS"].ToString();
                Sales.CURRENCY_CORP_CODE = oRd["CURRENCY"].ToString();
                Sales.DESTINATION = oRd["COUNTRY"].ToString();
                Sales.VIA = oRd["CHECK_ID"].ToString();
                Sales.IS_PROCESS = strShipType;
                Sales.LINE_TYPE = oRd["LINE_TYPE"].ToString();
                Sales.WAREHOUSE_TYPE = oRd["WAREHOUSE_TYPE"].ToString();
                Sales.NOTIFY1 = oRd["NOTIFY"].ToString();
                if (oRd["DATE_SCHEDULED"] != DBNull.Value)
                {
                    Sales.SHIP_DATE = Convert.ToDateTime(oRd["DATE_SCHEDULED"]);
                }
                else
                {
                    if (oRd["LAST_UPDATE_DATE"] != DBNull.Value)
                    {
                        Sales.SHIP_DATE = Convert.ToDateTime(oRd["LAST_UPDATE_DATE"]);
                    }
                    else
                    {
                        Sales.SHIP_DATE = Convert.ToDateTime("2000-01-01");
                    }
                }
                Sales.CUSTOMER_SITE_NUM = oRd["SITE_NUMBER"].ToString();
                Sales.BILL_ADDRESS = oRd["ADDRESS1"].ToString();
                Sales.TRADE_TERM = oRd["TRADE_TERM"].ToString().ToUpper();
                Sales.REMARK = oRd["REMARKS"].ToString().Replace("'", "''");
                Sales.BILL_ATTN_FAX = oRd["MAIN_MARK"].ToString();
                Sales.DELIVER_TYPE = oRd["DELIVER_TYPE"].ToString();
                Sales.ORGANIZATION_CODE = oRd["ORGANIZATION_CODE"].ToString();
                Sales.DEPARTMENT_CODE = oRd["DEPARTMENT_CODE"].ToString();
                Sales.DEPARTMENT_DESC = oRd["DEPARTMENT_DESC"].ToString().Replace("\r\n", "");
                Sales.TAX_TYPE = oRd["ATTRIBUTE13"].ToString();
                Sales.ORG_ID = Convert.ToDecimal(oRd["SHIPPING_ORG_ID"].ToString());		//for new org_id 
                Sales.PAYMENT_TERM = oRd["PAYMENT_TERM"].ToString();

                if (dal.GetCount(Sales.INVOICE_NO, Sales.VIA) > 0)
                {//已存在
                    return false;
                }
                else
                {//不存在，则先删除DN再做新增
                    dal.Delete(Sales.INVOICE_NO);
                    dal.Insert(Sales);
                }									
            }
            catch (Exception ex)
            {
                LogHelper.Write("行操作失败:" + ex.Message + "\r\nDN:" + oRd["DELIVERY_NO"].ToString() + "\r\n");
            }
            return true;
        }

        public decimal Select_By_ID(string v_INVOICE_NO)
        {
            StringBuilder sbSql = new StringBuilder();
            sbSql.Append(" SELECT BMS_SALES_ID FROM BMS_SALES_CKD ");
            sbSql.Append(" WHERE INVOICE_NO='" + v_INVOICE_NO + "'");

            object ID = SqlHelper.GetSingle(SqlHelper.PBMSDBConnectionString, sbSql.ToString());
            if (ID != null)
                return (decimal)ID;
            else return -1;
        }
    }
}
