using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.OracleClient;
using PBMSBatch.DBUtility;
using PBMSBatch.Model;

namespace PBMSBatch.DAL
{
    public class BMSSalesCItemDAL
    {
        public int Insert(BMSSalesCItemInfo model)
        {
            StringBuilder sbSql = new StringBuilder();
            sbSql.Append(" INSERT INTO BMS_SALES_CITEM (");
            sbSql.Append(" BMS_SALES_D_ID");
            sbSql.Append(" ,ITEM_CODE");
            sbSql.Append(" ,ITEM_CODE_C");
            sbSql.Append(" ,QUANTITY");
            sbSql.Append(" ,CTN_NW");
            sbSql.Append(" ,CREATE_USER_ID");
            sbSql.Append(" ,CREATE_DATE");
            sbSql.Append(" ,LAST_UPDATE_USER_ID");
            sbSql.Append(" ,LAST_UPDATE_DATE");
            sbSql.Append(" )");
            sbSql.Append(" VALUES(");
            sbSql.Append(" @BMS_SALES_D_ID");
            sbSql.Append(" ,@ITEM_CODE");
            sbSql.Append(" ,@ITEM_CODE_C");
            sbSql.Append(" ,@QUANTITY");
            sbSql.Append(" ,@CTN_NW");
            sbSql.Append(" ,@CREATE_USER_ID");
            sbSql.Append(" ,@CREATE_DATE");
            sbSql.Append(" ,@LAST_UPDATE_USER_ID");
            sbSql.Append(" ,@LAST_UPDATE_DATE");
            sbSql.Append(" )");
            SqlParameter[] param = new SqlParameter[] { 
                new SqlParameter("@BMS_SALES_D_ID", model.BMS_SALES_D_ID)
                , new SqlParameter("@ITEM_CODE", model.ITEM_CODE)
                , new SqlParameter("@ITEM_CODE_C", model.ITEM_CODE_C)
                , new SqlParameter("@QUANTITY", model.QUANTITY)
                //,new SqlParameter("@CTN_NW",CTN_NW*Get58CtnQty(ITEM_CODE))
                , new SqlParameter("@CTN_NW", model.CTN_NW)
                , new SqlParameter("@CREATE_USER_ID", model.CREATE_USER_ID)
                , new SqlParameter("@CREATE_DATE", DateTime.Now)
                , new SqlParameter("@LAST_UPDATE_USER_ID", model.LAST_UPDATE_USER_ID)
                , new SqlParameter("@LAST_UPDATE_DATE", DateTime.Now)
            };
            int count=SqlHelper.ExecuteSql(SqlHelper.PBMSDBConnectionString,sbSql.ToString(),param);
            return count;
        }

        public int Update(BMSSalesCItemInfo model)
        {
            StringBuilder sbSql = new StringBuilder();
            sbSql.Append(" UPDATE BMS_SALES_CITEM SET ");
            sbSql.Append(" QUANTITY=@QUANTITY");
            sbSql.Append(" ,CTN_NW=@CTN_NW");
            sbSql.Append(" ,LAST_UPDATE_USER_ID=@LAST_UPDATE_USER_ID");
            sbSql.Append(" ,LAST_UPDATE_DATE=@LAST_UPDATE_DATE");
            sbSql.Append(" WHERE BMS_SALES_D_ID=@BMS_SALES_D_ID");
            sbSql.Append(" AND ITEM_CODE=@ITEM_CODE");
            sbSql.Append(" AND ITEM_CODE_C=@ITEM_CODE_C");
            SqlParameter[] param = new SqlParameter[] { 
                new SqlParameter("@QUANTITY", model.QUANTITY)
                //,new SqlParameter("@CTN_NW",CTN_NW*Get58CtnQty(ITEM_CODE))
                , new SqlParameter("@CTN_NW", model.CTN_NW)
                , new SqlParameter("@LAST_UPDATE_USER_ID", model.LAST_UPDATE_USER_ID)
                , new SqlParameter("@LAST_UPDATE_DATE", DateTime.Now)
                , new SqlParameter("@BMS_SALES_D_ID", model.BMS_SALES_D_ID)
                , new SqlParameter("@ITEM_CODE", model.ITEM_CODE)
                , new SqlParameter("@ITEM_CODE_C", model.ITEM_CODE_C)
            };
            int count=SqlHelper.ExecuteSql(SqlHelper.PBMSDBConnectionString,sbSql.ToString(),param);
            return count;
        }
        public DataTable GetCItem(string InvoiceNo, string ItemCode)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("select d.segment1 item_code, c.segment1 item_code_c,b.Quantity_Per_Assembly quantity,");
                sb.Append("CASE when upper(C.weight_uom_code) like 'G' then C.UNIT_WEIGHT / 1000 ELSE c.unit_weight END WEIGHT ");
                sb.Append(" from wip_entities a,wip_requirement_operations b,mtl_system_items_b c,mtl_system_items_b d,wip_discrete_jobs f, ");
                sb.Append("(select ooh.order_number, ool.line_number from wsh_new_deliveries wnd,wsh_delivery_assignments wda,wsh_delivery_details wdd,oe_order_headers_all ooh, ");
                sb.Append(" oe_order_lines_all ool where wnd.delivery_id = wda.delivery_id and wda.delivery_detail_id = wdd.delivery_detail_id and wdd.source_header_id = ooh.header_id ");
                sb.Append(" and wdd.source_line_id = ool.line_id and ooh.header_id = ool.header_id and wnd.name in ('" + InvoiceNo + "')) g where a.organization_id = 851 and a.organization_id = b.organization_id ");
                sb.Append(" and a.wip_entity_id = b.wip_entity_id and b.organization_id = c.organization_id and b.inventory_item_id = c.inventory_item_id and a.wip_entity_id = f.wip_entity_id ");
                sb.Append(" and a.organization_id = f.organization_id and f.attribute5 = g.order_number and f.attribute4 = g.line_number and a.organization_id = d.organization_id ");
                sb.Append(" and a.primary_item_id = d.inventory_item_id and exists (select 1 from mtl_material_transactions where organization_id = a.organization_id and transaction_source_id = a.wip_entity_id ");
                sb.Append(" AND INVENTORY_ITEM_ID = b.INVENTORY_ITEM_ID and subinventory_code in ('CN-331', 'CN-531')) and a_wip_status_for_58(" + InvoiceNo + @") = 'Y' and d.segment1='" + ItemCode + "' ");
                DataTable dt = OracleHelper.Query(OracleHelper.ERPPROConnectionString, sb.ToString()).Tables[0];
                return dt;
            }
            catch
            {
                return null;
            }
        }

        public decimal Get58CtnQty(string ItemCode)
        {
            try
            {
                string strSql = "SELECT CTN_QTY FROM BMS_PACKING_STD WHERE ITEM_CODE='" + ItemCode + "'";
                DataTable dt = SqlHelper.Query(SqlHelper.PBMSDBConnectionString, strSql).Tables[0];
                if (dt != null && dt.Rows.Count > 0)
                {
                    return Convert.ToDecimal(dt.Rows[0][0].ToString());
                }
                else
                {
                    return 1;
                }
            }
            catch
            {
                return 1;
            }
        }
    }
}
