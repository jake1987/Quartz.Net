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
    public class BMSSalesCItemBLL
    {
        private BMSSalesDDAL bmsSalesDDAL = new BMSSalesDDAL();
        private BMSSalesCItemDAL bmsSalesCItemDAL = new BMSSalesCItemDAL();
        public void makeSalesCItemFiles(string InvoiceNo)
        {
            try
            {
                string strSql = "SELECT B.BMS_SALES_D_ID,B.ITEM_CODE FROM BMS_SALES A INNER JOIN BMS_SALES_D B ON A.BMS_SALES_ID=B.BMS_SALES_ID WHERE A.INVOICE_NO='" + InvoiceNo + "'";
                DataTable dtSalesD = SqlHelper.Query(SqlHelper.PBMSDBConnectionString, strSql).Tables[0];
                if (dtSalesD != null && dtSalesD.Rows.Count > 0)
                {
                    for (int i = 0; i < dtSalesD.Rows.Count; i++)
                    {
                        DataTable dtCItem = bmsSalesCItemDAL.GetCItem(InvoiceNo, dtSalesD.Rows[i]["ITEM_CODE"].ToString());
                        if (dtCItem != null && dtCItem.Rows.Count > 0)
                        {
                            for (int j = 0; j < dtCItem.Rows.Count; j++)
                            {
                                BMSSalesCItemInfo SalesCItem = new BMSSalesCItemInfo();
                                SalesCItem.BMS_SALES_D_ID = Convert.ToDecimal(dtSalesD.Rows[i]["BMS_SALES_D_ID"].ToString());
                                SalesCItem.ITEM_CODE = dtSalesD.Rows[i]["ITEM_CODE"].ToString();
                                SalesCItem.ITEM_CODE_C = dtCItem.Rows[j]["ITEM_CODE_C"].ToString();
                                SalesCItem.QUANTITY = Convert.ToDecimal(dtCItem.Rows[j]["QUANTITY"].ToString());
                                SalesCItem.CTN_NW = Convert.ToDecimal(dtCItem.Rows[j]["WEIGHT"].ToString());
                                SalesCItem.CREATE_USER_ID = 1;
                                SalesCItem.LAST_UPDATE_USER_ID = 1;
                                if (bmsSalesCItemDAL.Update(SalesCItem) > 0)
                                {
                                    LogHelper.Write("行为重复值。\r\n");
                                }
                                else
                                {
                                    if (bmsSalesCItemDAL.Insert(SalesCItem) > 0)
                                    {
                                        LogHelper.Write("行更新成功。\r\n");
                                    }
                                    else
                                    {
                                        LogHelper.Write("行更新失败。\r\n");
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LogHelper.Write("行操作失败:" + ex.Message + "\r\n");
            }
        }
    }
}
