using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using PBMSBatch.DBUtility;
using PBMSBatch.Model;

namespace PBMSBatch.DAL
{
    public class BMSSalesDDAL
    {
        public int Insert(BMSSalesDInfo model)
        {
            StringBuilder sbSql = new StringBuilder();
            sbSql.Append(" INSERT INTO BMS_SALES_D (");
            sbSql.Append(" BMS_SALES_ID");
            sbSql.Append(" ,TRANSACTION_ID");
            sbSql.Append(" ,SO");
            sbSql.Append(" ,SEQ_NO");
            sbSql.Append(" ,SHIP_QTY");
            sbSql.Append(" ,APPLY_QTY");
            sbSql.Append(" ,MEASURE_CORP_CODE_W");
            sbSql.Append(" ,ITEM_CODE");
            sbSql.Append(" ,ITEM_DESC_CUS");
            sbSql.Append(" ,PRICE");
            sbSql.Append(" ,AMOUNT");
            sbSql.Append(" ,CUSTOMER_PART_NO");
            sbSql.Append(" ,PO");
            sbSql.Append(" ,CREATE_USER_ID");
            sbSql.Append(" ,CREATE_DATE");
            sbSql.Append(" ,LAST_UPDATE_USER_ID");
            sbSql.Append(" ,LAST_UPDATE_DATE");
            sbSql.Append(" ,RETURN_NO");
            sbSql.Append(" ,RETURN_LINE");
            sbSql.Append(" ,WAREHOUSE_TYPE");
            sbSql.Append(" ,SAGEM_PN");
            sbSql.Append(" )");
            sbSql.Append(" VALUES(");
            sbSql.Append(" @BMS_SALES_ID");
            sbSql.Append(" ,@TRANSACTION_ID");
            sbSql.Append(" ,@SO");
            sbSql.Append(" ,@SEQ_NO");
            sbSql.Append(" ,@SHIP_QTY");
            sbSql.Append(" ,@APPLY_QTY");
            sbSql.Append(" ,@MEASURE_CORP_CODE_W");
            sbSql.Append(" ,@ITEM_CODE");
            sbSql.Append(" ,@ITEM_DESC_CUS");
            sbSql.Append(" ,@PRICE");
            sbSql.Append(" ,@AMOUNT");
            sbSql.Append(" ,@CUSTOMER_PART_NO");
            sbSql.Append(" ,@CUSTOMER_PO_NO");
            sbSql.Append(" ,@CREATE_USER_ID");
            sbSql.Append(" ,@CREATE_DATE");
            sbSql.Append(" ,@LAST_UPDATE_USER_ID");
            sbSql.Append(" ,@LAST_UPDATE_DATE");
            sbSql.Append(" ,@RETURN_NO");
            sbSql.Append(" ,@RETURN_LINE");
            sbSql.Append(" ,@WAREHOUSE_TYPE");
            sbSql.Append(" ,@SAGEM_PN");
            sbSql.Append(" )");
            SqlParameter[] param = new SqlParameter[] { 
                new SqlParameter("@BMS_SALES_ID", model.BMS_SALES_ID)
                , new SqlParameter("@TRANSACTION_ID", model.TRANSACTION_ID)
                , new SqlParameter("@SO", model.SO)
                , new SqlParameter("@SEQ_NO", model.SEQ_NO)
                , new SqlParameter("@SHIP_QTY", model.SHIP_QTY)
                , new SqlParameter("@APPLY_QTY", model.APPLY_QTY)
                , new SqlParameter("@MEASURE_CORP_CODE_W", model.MEASURE_CORP_CODE_W)
                , new SqlParameter("@ITEM_CODE", model.ITEM_CODE)
                , new SqlParameter("@ITEM_DESC_CUS", model.ITEM_DESC_CUS)
                , new SqlParameter("@PRICE", model.PRICE)
                , new SqlParameter("@AMOUNT", model.AMOUNT)
                , new SqlParameter("@CUSTOMER_PART_NO", model.CUSTOMER_PART_NO)
                , new SqlParameter("@CUSTOMER_PO_NO", model.PO)
                , new SqlParameter("@CREATE_USER_ID", model.CREATE_USER_ID)
                , new SqlParameter("@CREATE_DATE", DateTime.Now)
                , new SqlParameter("@LAST_UPDATE_USER_ID", model.LAST_UPDATE_USER_ID)
                , new SqlParameter("@LAST_UPDATE_DATE", DateTime.Now)
                , new SqlParameter("@RETURN_NO", model.RETURN_NO)
                , new SqlParameter("@RETURN_LINE", model.RETURN_LINE)
                , new SqlParameter("@WAREHOUSE_TYPE", model.WAREHOUSE_TYPE)
                , new SqlParameter("@SAGEM_PN", model.SAGEM_PN)
            };
            int count = SqlHelper.ExecuteSql(SqlHelper.PBMSDBConnectionString, sbSql.ToString());
            return count;
        }


        public int Update(BMSSalesDInfo model)
        {
            StringBuilder sbSql = new StringBuilder();
            sbSql.Append(" UPDATE BMS_SALES_D SET ");
            sbSql.Append(" SO=@SO");
            sbSql.Append(" ,SEQ_NO=@SEQ_NO");
            sbSql.Append(" ,SHIP_QTY=@SHIP_QTY");
            sbSql.Append(" ,APPLY_QTY=@APPLY_QTY");
            sbSql.Append(" ,MEASURE_CORP_CODE_W=@MEASURE_CORP_CODE_W");
            sbSql.Append(" ,ITEM_CODE=@ITEM_CODE");
            sbSql.Append(" ,ITEM_DESC_CUS=@ITEM_DESC_CUS");
            sbSql.Append(" ,PRICE=@PRICE");
            sbSql.Append(" ,AMOUNT=@AMOUNT");
            sbSql.Append(" ,CUSTOMER_PART_NO=@CUSTOMER_PART_NO");
            sbSql.Append(" ,PO=@CUSTOMER_PO_NO");
            sbSql.Append(" ,CREATE_USER_ID=@CREATE_USER_ID");
            sbSql.Append(" ,CREATE_DATE=@CREATE_DATE");
            sbSql.Append(" ,LAST_UPDATE_USER_ID=@LAST_UPDATE_USER_ID");
            sbSql.Append(" ,LAST_UPDATE_DATE=@LAST_UPDATE_DATE");
            sbSql.Append(" ,RETURN_NO=@RETURN_NO");
            sbSql.Append(" ,RETURN_LINE=@RETURN_LINE");
            sbSql.Append(" ,WAREHOUSE_TYPE=@WAREHOUSE_TYPE");
            sbSql.Append(" ,SAGEM_PN=@SAGEM_PN");
            sbSql.Append(" WHERE BMS_SALES_ID=@BMS_SALES_ID");
            sbSql.Append(" AND ITEM_CODE=@ITEM_CODE");
            sbSql.Append(" AND TRANSACTION_ID=@TRANSACTION_ID");
            SqlParameter[] param = new SqlParameter[] { 
                new SqlParameter("@SO", model.SO)
                , new SqlParameter("@SEQ_NO", model.SEQ_NO)
                , new SqlParameter("@SHIP_QTY", model.SHIP_QTY)
                , new SqlParameter("@APPLY_QTY", model.APPLY_QTY)
                , new SqlParameter("@MEASURE_CORP_CODE_W", model.MEASURE_CORP_CODE_W)
                , new SqlParameter("@ITEM_CODE", model.ITEM_CODE)
                , new SqlParameter("@ITEM_DESC_CUS", model.ITEM_DESC_CUS)
                , new SqlParameter("@PRICE", model.PRICE)
                , new SqlParameter("@AMOUNT", model.AMOUNT)
                , new SqlParameter("@CUSTOMER_PART_NO", model.CUSTOMER_PART_NO)
                , new SqlParameter("@CUSTOMER_PO_NO", model.PO)
                , new SqlParameter("@CREATE_USER_ID", model.CREATE_USER_ID)
                , new SqlParameter("@CREATE_DATE", DateTime.Now)
                , new SqlParameter("@LAST_UPDATE_USER_ID", model.LAST_UPDATE_USER_ID)
                , new SqlParameter("@LAST_UPDATE_DATE", DateTime.Now)
                , new SqlParameter("@RETURN_NO", model.RETURN_NO)
                , new SqlParameter("@RETURN_LINE", model.RETURN_LINE)
                , new SqlParameter("@WAREHOUSE_TYPE", model.WAREHOUSE_TYPE)
                , new SqlParameter("@BMS_SALES_ID", model.BMS_SALES_ID)
                , new SqlParameter("@TRANSACTION_ID", model.TRANSACTION_ID)
                , new SqlParameter("@SAGEM_PN", model.SAGEM_PN)
            };
            int count = SqlHelper.ExecuteSql(SqlHelper.PBMSDBConnectionString, sbSql.ToString());
            return count;
        }
    }
}
