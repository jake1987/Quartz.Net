using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Quartz;
using System.Data;
using System.Data.SqlClient;
using System.Data.OracleClient;
using PBMSBatch.DBUtility;
using PBMSBatch.Common;
using PBMSBatch.BLL;

namespace PBMSBatch.Job.Jobs
{
    public class SalesJob:IJob
    {
        BMSSalesBLL bmsSalesBLL = new BMSSalesBLL();
        BMSSalesDBLL bmsSalesDBLL = new BMSSalesDBLL();
        BMSSalesCItemBLL bmsSalesCItemBLL = new BMSSalesCItemBLL();
        public void Execute(IJobExecutionContext context)
        {
            string strStartDate = XmlHelper.Read("TimeConfig.xml", "/Jobs/Job[@name='Sales']");
            string strEndDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            DataTable dt = GetSalesData(strStartDate, strEndDate);
            LogHelper.Write(DateTime.Now.ToString() + ",開始導入資料...");
            bool flag = false;
            int row = 0;
            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    string sInvoiceNo = "";
                    string sDate = "";
                    if (!string.IsNullOrEmpty(dr["DELIVERY_NO"].ToString()))
                    {
                        sInvoiceNo = dr["DELIVERY_NO"].ToString();
                        if (dr["DATE_SCHEDULED"].ToString() != "")
                        {
                            sDate = Convert.ToDateTime(dr["DATE_SCHEDULED"]).ToString("yyyyMMdd");
                        }
                        else
                        {
                            sDate = DateTime.MinValue.ToString("yyyyMMdd");
                        }
                        flag = bmsSalesBLL.makeSalesFiles(dr);
                        if (!flag)
                        {
                            LogHelper.Write("第：" + Convert.ToString(++row) + "行 DN:" + sInvoiceNo + " 数据已存在数据库！.\r\n");
                            continue;
                        }
                        else
                        {
                            //Insert资料到BMS_SALES_D
                            bmsSalesDBLL.makeSalesDFiles(dr);
                            //Insert资料到BMS_SALES_CITEM
                            bmsSalesCItemBLL.makeSalesCItemFiles(sInvoiceNo);
                            LogHelper.Write("第：" + Convert.ToString(++row) + "行 DN:" + sInvoiceNo + " 導入成功！.\r\n");
                        }
                    }
                    else
                    {
                        if (!flag)
                        {
                            LogHelper.Write("第：" + Convert.ToString(++row) + "行 DN:" + sInvoiceNo + " 数据已經導入！.\r\n");
                            continue;
                        }
                    }
                }
            }
            //更新XML中的最后更新日期
            XmlHelper.Update("TimeConfig.xml", "/Jobs/Job[@name='Sales']", strEndDate);
            LogHelper.Write(DateTime.Now.ToString() + ",資料導入結束");
        }

        public DataTable GetSalesData(string StartDate, string EndDate)
        {
            DataTable dt = new DataTable();
            try
            {
                OracleHelper.ExecuteNonQuery(OracleHelper.ERPPROConnectionString, "Alter Session Set NLS_LANGUAGE='AMERICAN'");
                string strSql = @"SELECT organization_id,
                                   organization_code,
                                   delivery_no,
                                   check_id,
                                   customer_number,
                                   customer_name,
                                   site_number,
                                   sagem_pn,
                                   notify,
                                   address1,
                                   site_use_code,
                                   delivery_detail_id,
                                   so_no,
                                   line,
                                   substr(item,1,12) as item,
                                          item_description,
                                   ship_qty,
                                   uom,
                                   currency,
                                   price,
                                   trade_term,
                                   deliver_type,
                                   last_update_date,
                                   date_scheduled,
                                   country,
                                   delivery_customer_code,
                                   delivery_customer_name,
                                   delivery_customer_address,
                                   main_mark,
                                   remarks,
                                   is_process,
                                   line_type,
                                   warehouse_type,
                                   customer_po_no,
                                   customer_part_no,
                                   department_code,
                                   department_desc,
                                   order_type,
                                   delivery_id,
                                   status_code,
                                   org_id,
                                   line_type_id,
                                   attribute1,
                                   reason_code,
                                   attribute13,
                                   return_number,
                                   return_line_num,
                                   shipping_org_id,       
                                   payment_term 
                              FROM a_ont_shipping_tw5_v_temp
                             WHERE TO_CHAR(LAST_UPDATE_DATE,'yyyy-MM-dd HH24:MI:ss')>= :STARTDATE
                               AND TO_CHAR(LAST_UPDATE_DATE,'yyyy-MM-dd HH24:MI:ss')<= :ENDDATE
                             ORDER BY DELIVERY_NO,CHECK_ID";
                OracleParameter[] param = new OracleParameter[2];
                param[0] = new OracleParameter(":STARTDATE", StartDate);
                param[1] = new OracleParameter(":ENDDATE", EndDate);
                dt = OracleHelper.Query(OracleHelper.ERPPROConnectionString, strSql, param).Tables[0];
            }
            catch (Exception ex)
            {
                LogHelper.Write(ex);
            }
            return dt;
        }
    }
}
