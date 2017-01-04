using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using PBMSBatch.Job;
using PBMSBatch.Common;
using Quartz;
using Quartz.Impl;

namespace PBMSBatch.Service
{
    partial class BatchService : ServiceBase
    {
        public BatchService()
        {
            InitializeComponent();
        }

        //public void OnStart()
        protected override void OnStart(string[] args)
        {
            LogHelper.Write("时间:" + DateTime.Now.ToString() + ", Service Start...");
            try
            {
                // TODO:  在此加入啟動服務的程式碼。
                ISchedulerFactory factory = new StdSchedulerFactory(); //新建一个调度器工厂
                IScheduler scheduler = factory.GetScheduler();//工厂生成一个调度器
                scheduler.Start();//启动调度器

                IDictionary<IJobDetail, Quartz.Collection.ISet<ITrigger>> jobs = new Dictionary<IJobDetail, Quartz.Collection.ISet<ITrigger>>();

                #region 新增一个Job到列表中
                IJobDetail CKDSalesJob = JobBuilder.Create<CKDSalesJob>().WithIdentity("CKDSalesJob", "PBMS").Build();
                Quartz.Collection.ISet<ITrigger> CKDSalesTrigger = new Quartz.Collection.HashSet<ITrigger>();
                CKDSalesTrigger.Add(TriggerBuilder.Create().WithCronSchedule("0 0/1 * 1/1 * ? *").Build());//http://www.cronmaker.com/
                jobs.Add(CKDSalesJob, CKDSalesTrigger);
                #endregion

                scheduler.ScheduleJobs(jobs, true);
                LogHelper.Write("时间:" + DateTime.Now.ToString() + ", Service Start...");
            }
            catch (Exception ex)
            {
                LogHelper.Write(ex);
            }
        }

        protected override void OnStop()
        {
            LogHelper.Write("时间:" + DateTime.Now.ToString() + ", Service Stop...");
        }
    }
}
