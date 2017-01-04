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
    public class BMSSalesDBLL
    {
        private BMSSalesDAL bmsSalesDAL = new BMSSalesDAL();
        private BMSSalesDDAL bmsSalesDDAL = new BMSSalesDDAL();
        public void makeSalesDFiles(DataRow oRd)
        {
            BMSSalesDInfo SalesD = new BMSSalesDInfo();
            try
            {
                SalesD.BMS_SALES_ID = bmsSalesDAL.Select_By_ID(oRd["DELIVERY_NO"].ToString());
                SalesD.TRANSACTION_ID = Convert.ToDecimal(oRd["DELIVERY_DETAIL_ID"].ToString());
                SalesD.SO = oRd["SO_NO"].ToString();
                SalesD.SEQ_NO = oRd["LINE"].ToString();
                SalesD.SHIP_QTY = Convert.ToDecimal(oRd["SHIP_QTY"].ToString());
                SalesD.APPLY_QTY = Convert.ToDecimal(oRd["SHIP_QTY"].ToString());//预计出货数量
                SalesD.MEASURE_CORP_CODE_W = oRd["UOM"].ToString();
                SalesD.ITEM_CODE = oRd["ITEM"].ToString();
                SalesD.ITEM_DESC_CUS = oRd["ITEM_DESCRIPTION"].ToString();
                SalesD.PRICE = Convert.ToDecimal(oRd["PRICE"].ToString());
                SalesD.AMOUNT = SalesD.SHIP_QTY * SalesD.PRICE;
                SalesD.CUSTOMER_PART_NO = oRd["CUSTOMER_PART_NO"].ToString().Replace("'", "");
                SalesD.PO = oRd["CUSTOMER_PO_NO"].ToString().Replace("'", "");
                SalesD.RETURN_NO = oRd["RETURN_NUMBER"].ToString();
                SalesD.RETURN_LINE = oRd["RETURN_LINE_NUM"].ToString();
                SalesD.WAREHOUSE_TYPE = oRd["WAREHOUSE_TYPE"].ToString();
                SalesD.SAGEM_PN = oRd["SAGEM_PN"].ToString();
                if (bmsSalesDDAL.Update(SalesD) > 0)
                {
                    LogHelper.Write("行为重复值。\r\n");
                }
                else
                {
                    if (bmsSalesDDAL.Insert(SalesD) > 0)
                        LogHelper.Write("行更新成功。\r\n");
                    else LogHelper.Write("行更新失败。\r\n");
                }
            }
            catch (Exception ex)
            {
                LogHelper.Write("行操作失败:" + ex.Message + "\r\n");
            }
        }
    }
}
