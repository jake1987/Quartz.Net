using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using PBMSBatch.DBUtility;
using PBMSBatch.Model;

namespace PBMSBatch.DAL
{
    public class BMSSalesCKDDAL
    {
        public int GetCount(string DNNo, string CheckId)
        {
            string sql = "SELECT COUNT(*) FROM BMS_SALES_CKD WHERE INVOICE_NO='" + DNNo + "' AND (VIA='" + CheckId + "' OR IS_APPLY='Y')";
            return Convert.ToInt32(SqlHelper.GetSingle(SqlHelper.PBMSDBConnectionString, sql));
        }
        public int Delete(string DNNo)
        {
            string strSql="DELETE BMS_SALES_CKD WHERE INVOICE_NO='" + DNNo + "' AND IS_APPLY='N' ";
            int count = SqlHelper.ExecuteSql(SqlHelper.PBMSDBConnectionString, strSql);
            return count;

        }
        public int Insert(BMSSalesCKDInfo model)
        {
            StringBuilder sbSql = new StringBuilder();
            sbSql.Append(" INSERT INTO BMS_SALES_CKD (");
            sbSql.Append(" INVOICE_NO");
            sbSql.Append(" ,VIA");
            sbSql.Append(" ,CUSTOMER_CODE");
            sbSql.Append(" ,CUSTOMER_NAME");
            sbSql.Append(" ,DELIVERY_CUSTOMER_CODE");
            sbSql.Append(" ,DELIVERY_CUSTOMER_NAME");
            sbSql.Append(" ,SHIP_TO");
            sbSql.Append(" ,BILL_TO");
            sbSql.Append(" ,CONSIGNEE_ADDRESS");
            sbSql.Append(" ,CURRENCY_CORP_CODE");
            sbSql.Append(" ,DESTINATION");
            sbSql.Append(" ,SHIP_DATE");
            sbSql.Append(" ,CUSTOMER_SITE_NUM");
            sbSql.Append(" ,BILL_ADDRESS");
            sbSql.Append(" ,TRADE_TERM");
            sbSql.Append(" ,IS_APPLY");
            sbSql.Append(" ,BILL_ATTN_FAX");
            sbSql.Append(" ,REMARK");
            sbSql.Append(" ,DELIVER_TYPE");
            //------------------------------
            sbSql.Append(" ,IS_PROCESS");
            sbSql.Append(" ,LINE_TYPE");
            sbSql.Append(" ,WAREHOUSE_TYPE");
            sbSql.Append(" ,ORGANIZATION_CODE");
            sbSql.Append(" ,CREATE_USER_ID");
            sbSql.Append(" ,CREATE_DATE");
            sbSql.Append(" ,LAST_UPDATE_USER_ID");
            sbSql.Append(" ,LAST_UPDATE_DATE");
            sbSql.Append(" ,DEPARTMENT_CODE");
            sbSql.Append(" ,DEPARTMENT_DESC");
            sbSql.Append(" ,TAX_TYPE");
            sbSql.Append(" ,ORG_ID");
            sbSql.Append(" ,PAYMENT_TERM");
            sbSql.Append(" ,NOTIFY1");
            sbSql.Append(" )");
            sbSql.Append(" VALUES(");
            sbSql.Append(" @INVOICE_NO");
            sbSql.Append(" ,@VIA");
            sbSql.Append(" ,@CUSTOMER_CODE");
            sbSql.Append(" ,@CUSTOMER_NAME");
            sbSql.Append(" ,@DELIVERY_CUSTOMER_CODE");
            sbSql.Append(" ,@DELIVERY_CUSTOMER_NAME");
            sbSql.Append(" ,@SHIP_TO");
            sbSql.Append(" ,@BILL_TO");
            sbSql.Append(" ,@CONSIGNEE_ADDRESS");
            sbSql.Append(" ,@CURRENCY_CORP_CODE");
            sbSql.Append(" ,@DESTINATION");
            sbSql.Append(" ,@SHIP_DATE");
            sbSql.Append(" ,@CUSTOMER_SITE_NUM");
            sbSql.Append(" ,@BILL_ADDRESS");
            sbSql.Append(" ,@TRADE_TERM");
            sbSql.Append(" ,@IS_APPLY");
            sbSql.Append(" ,@BILL_ATTN_FAX");
            sbSql.Append(" ,@REMARK");
            sbSql.Append(" ,@DELIVER_TYPE");
            sbSql.Append(" ,@IS_PROCESS");
            sbSql.Append(" ,@LINE_TYPE");
            sbSql.Append(" ,@WAREHOUSE_TYPE");
            sbSql.Append(" ,@ORGANIZATION_CODE");
            sbSql.Append(" ,@CREATE_USER_ID");
            sbSql.Append(" ,@CREATE_DATE");
            sbSql.Append(" ,@LAST_UPDATE_USER_ID");
            sbSql.Append(" ,@LAST_UPDATE_DATE");
            sbSql.Append(" ,@DEPARTMENT_CODE");//newtea add 20090122
            sbSql.Append(" ,@DEPARTMENT_DESC");
            sbSql.Append(" ,@TAX_TYPE");
            sbSql.Append(" ,@ORG_ID");
            sbSql.Append(" ,@PAYMENT_TERM");
            sbSql.Append(" ,@NOTIFY1");
            sbSql.Append(" )");
            SqlParameter[] param = new SqlParameter[] { 
                new SqlParameter("@INVOICE_NO", model.INVOICE_NO)
                , new SqlParameter("@VIA", model.VIA)
                , new SqlParameter("@CUSTOMER_CODE", model.CUSTOMER_CODE)
                , new SqlParameter("@CUSTOMER_NAME", model.CUSTOMER_NAME)
                , new SqlParameter("@DELIVERY_CUSTOMER_CODE", model.DELIVERY_CUSTOMER_CODE)
                , new SqlParameter("@DELIVERY_CUSTOMER_NAME", model.DELIVERY_CUSTOMER_NAME)
                , new SqlParameter("@SHIP_TO", model.SHIP_TO)
                , new SqlParameter("@BILL_TO", model.BILL_TO)
                , new SqlParameter("@CONSIGNEE_ADDRESS", model.CONSIGNEE_ADDRESS)
                , new SqlParameter("@CURRENCY_CORP_CODE", model.CURRENCY_CORP_CODE)
                , new SqlParameter("@DESTINATION", model.DESTINATION)
                , new SqlParameter("@SHIP_DATE", model.SHIP_DATE)
                , new SqlParameter("@CUSTOMER_SITE_NUM", model.CUSTOMER_SITE_NUM)
                , new SqlParameter("@BILL_ADDRESS", model.BILL_ADDRESS)
                , new SqlParameter("@TRADE_TERM", model.TRADE_TERM)
                , new SqlParameter("@IS_APPLY", "N")
                , new SqlParameter("@BILL_ATTN_FAX", model.BILL_ATTN_FAX)
                , new SqlParameter("@REMARK", model.REMARK)
                , new SqlParameter("@DELIVER_TYPE", model.DELIVER_TYPE)
                , new SqlParameter("@IS_PROCESS", model.IS_PROCESS)
                , new SqlParameter("@LINE_TYPE", model.LINE_TYPE)
                , new SqlParameter("@WAREHOUSE_TYPE", model.WAREHOUSE_TYPE)
                , new SqlParameter("@ORGANIZATION_CODE", model.ORGANIZATION_CODE)
                , new SqlParameter("@CREATE_USER_ID", model.CREATE_USER_ID)
                , new SqlParameter("@CREATE_DATE", DateTime.Now)
                , new SqlParameter("@LAST_UPDATE_USER_ID", model.LAST_UPDATE_USER_ID)
                , new SqlParameter("@LAST_UPDATE_DATE", DateTime.Now)
                , new SqlParameter("@DEPARTMENT_CODE", model.DEPARTMENT_CODE)//newtea add 20090122
                , new SqlParameter("@DEPARTMENT_DESC", model.DEPARTMENT_DESC)
                , new SqlParameter("@TAX_TYPE", model.TAX_TYPE)
                , new SqlParameter("@ORG_ID", model.ORG_ID)
                , new SqlParameter("@PAYMENT_TERM", model.PAYMENT_TERM)
                , new SqlParameter("@NOTIFY1", model.NOTIFY1)
            };
            int count=SqlHelper.ExecuteSql(SqlHelper.PBMSDBConnectionString,sbSql.ToString(),param);
            return count;
        }

        public int Update(BMSSalesCKDInfo model)
        {
            StringBuilder sbSql = new StringBuilder();
            sbSql.Append(" UPDATE BMS_SALES_CKD SET ");
            sbSql.Append(" INVOICE_NO=@INVOICE_NO");
            sbSql.Append(" ,VIA=@VIA");
            sbSql.Append(" ,CUSTOMER_CODE=@CUSTOMER_CODE");
            sbSql.Append(" ,CUSTOMER_NAME=@CUSTOMER_NAME");
            sbSql.Append(" ,DELIVERY_CUSTOMER_CODE=@DELIVERY_CUSTOMER_CODE");
            sbSql.Append(" ,DELIVERY_CUSTOMER_NAME=@DELIVERY_CUSTOMER_NAME");
            sbSql.Append(" ,SHIP_TO=@SHIP_TO");
            sbSql.Append(" ,BILL_TO=@BILL_TO");
            sbSql.Append(" ,CONSIGNEE_ADDRESS=@CONSIGNEE_ADDRESS");
            sbSql.Append(" ,CURRENCY_CORP_CODE=@CURRENCY_CORP_CODE");
            sbSql.Append(" ,DESTINATION=@DESTINATION");
            sbSql.Append(" ,SHIP_DATE=@SHIP_DATE");
            sbSql.Append(" ,CUSTOMER_SITE_NUM=@CUSTOMER_SITE_NUM");
            sbSql.Append(" ,BILL_ADDRESS=@BILL_ADDRESS");
            sbSql.Append(" ,TRADE_TERM=@TRADE_TERM");
            sbSql.Append(" ,BILL_ATTN_FAX=@BILL_ATTN_FAX");
            sbSql.Append(" ,REMARK=@REMARK");
            sbSql.Append(" ,DELIVER_TYPE=@DELIVER_TYPE");
            sbSql.Append(" ,IS_PROCESS=@IS_PROCESS");
            sbSql.Append(" ,LINE_TYPE=@LINE_TYPE");
            sbSql.Append(" ,WAREHOUSE_TYPE=@WAREHOUSE_TYPE");
            sbSql.Append(" ,ORGANIZATION_CODE=@ORGANIZATION_CODE");
            sbSql.Append(" ,TAX_TYPE=@TAX_TYPE");
            sbSql.Append(" ,ORG_ID=@ORG_ID");
            sbSql.Append(" ,NOTIFY1=@NOTIFY1");
            sbSql.Append(" ,PAYMENT_TERM=@PAYMENT_TERM");
            sbSql.Append(" ,CREATE_USER_ID=@CREATE_USER_ID");
            sbSql.Append(" ,CREATE_DATE=@CREATE_DATE");
            sbSql.Append(" ,LAST_UPDATE_USER_ID=@LAST_UPDATE_USER_ID");
            sbSql.Append(" ,LAST_UPDATE_DATE=@LAST_UPDATE_DATE");
            sbSql.Append(" WHERE INVOICE_NO=@c_INVOICE_NO AND IS_APPLY='N' ");
            sbSql.Append(" AND VIA<>@c_VIA ");
            SqlParameter[] param = new SqlParameter[] { 
                new SqlParameter("@INVOICE_NO", model.INVOICE_NO)
                , new SqlParameter("@VIA", model.VIA)
                , new SqlParameter("@CUSTOMER_CODE", model.CUSTOMER_CODE)
                , new SqlParameter("@CUSTOMER_NAME", model.CUSTOMER_NAME)
                , new SqlParameter("@DELIVERY_CUSTOMER_CODE", model.DELIVERY_CUSTOMER_CODE)
                , new SqlParameter("@DELIVERY_CUSTOMER_NAME", model.DELIVERY_CUSTOMER_NAME)
                , new SqlParameter("@SHIP_TO", model.SHIP_TO)
                , new SqlParameter("@BILL_TO", model.BILL_TO)
                , new SqlParameter("@CONSIGNEE_ADDRESS", model.CONSIGNEE_ADDRESS)
                , new SqlParameter("@CURRENCY_CORP_CODE", model.CURRENCY_CORP_CODE)
                , new SqlParameter("@DESTINATION", model.DESTINATION)
                , new SqlParameter("@SHIP_DATE", model.SHIP_DATE)
                , new SqlParameter("@CUSTOMER_SITE_NUM", model.CUSTOMER_SITE_NUM)
                , new SqlParameter("@BILL_ADDRESS", model.BILL_ADDRESS)
                , new SqlParameter("@TRADE_TERM", model.TRADE_TERM)
                , new SqlParameter("@BILL_ATTN_FAX", model.BILL_ATTN_FAX)
                , new SqlParameter("@REMARK", model.REMARK)
                , new SqlParameter("@DELIVER_TYPE", model.DELIVER_TYPE)
                , new SqlParameter("@IS_PROCESS", model.IS_PROCESS)
                , new SqlParameter("@LINE_TYPE", model.LINE_TYPE)
                , new SqlParameter("@WAREHOUSE_TYPE", model.WAREHOUSE_TYPE)
                , new SqlParameter("@ORGANIZATION_CODE", model.ORGANIZATION_CODE)
                , new SqlParameter("@TAX_TYPE", model.TAX_TYPE)
                , new SqlParameter("@ORG_ID", model.ORG_ID)
                , new SqlParameter("@NOTIFY1", model.NOTIFY1)
                , new SqlParameter("@PAYMENT_TERM", model.PAYMENT_TERM)
                , new SqlParameter("@CREATE_USER_ID", model.CREATE_USER_ID)
                , new SqlParameter("@CREATE_DATE", DateTime.Now)
                , new SqlParameter("@LAST_UPDATE_USER_ID", model.LAST_UPDATE_USER_ID)
                , new SqlParameter("@LAST_UPDATE_DATE", DateTime.Now)
                , new SqlParameter("@c_INVOICE_NO", model.INVOICE_NO)
                , new SqlParameter("@c_VIA", model.VIA)
            };
            int count= SqlHelper.ExecuteSql(SqlHelper.PBMSDBConnectionString, sbSql.ToString(), param);
            return count;
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

        public string CheckLine(string[] strTemp)
        {
            StringBuilder sbError = new StringBuilder();
            if (strTemp.Length != 6)
                sbError.Append("与规格要求的数据列数(6列)不相同。");
            else
            {
                for (int i = 0; i < strTemp.Length; i++)
                    strTemp[i] = strTemp[i].Trim();

                if (strTemp[0] == null || strTemp[0].Length == 0)
                    sbError.Append("字段对应的第(0)列数据不能为空。");

                if (strTemp[2] == null || strTemp[2].Length == 0)
                    sbError.Append("字段对应的第(2)列数据不能为空。");

                if (strTemp[3] == null || strTemp[3].Length == 0)
                    sbError.Append("字段对应的第(3)列数据不能为空。");

                //				if(!MoonRegex.IsDate2(strTemp[4]))
                //					sbError.Append("字段的值为:" + strTemp[4] + ",格式错误,应为Datetime(yyyyMMdd)类型。");
            }
            return sbError.ToString();
        }

        public void DeleteByDn(string DN)
        {
            string strSql = "select bms_sales_ckd_d.bms_sales_d_id as bms_sales_d_id from bms_sales_ckd bms_sales_ckd inner join bms_sales_ckd_d bms_sales_ckd_d on bms_sales_ckd.bms_sales_id=bms_sales_ckd_d.bms_sales_id where bms_sales_ckd.invoice_no='" + DN + "'";
            DataTable dt = SqlHelper.Query(SqlHelper.PBMSDBConnectionString, strSql).Tables[0];
            SqlHelper.ExecuteSql(SqlHelper.PBMSDBConnectionString,"delete from bms_sales_ckd where invoice_no='" + DN + "'");
            if (dt != null && dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    SqlHelper.ExecuteSql(SqlHelper.PBMSDBConnectionString, "delete from bms_sales_ckd_d where bms_sales_d_id=" + dt.Rows[i][0].ToString());
                }
            }
        }

    }
}
