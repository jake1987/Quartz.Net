using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using PBMSBatch.Common;
using PBMSBatch.Job;
using Quartz;
using Quartz.Impl;
using System.Runtime.Remoting.Channels;

namespace PBMSBatch.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            //指定程式运行的端口号
            System.Runtime.Remoting.Channels.Tcp.TcpChannel chan = new System.Runtime.Remoting.Channels.Tcp.TcpChannel(Convert.ToInt32(ConfigurationManager.AppSettings["RunningPort"]));
            ChannelServices.RegisterChannel(chan);
            LogHelper.Write("时间:" + DateTime.Now.ToString() + ", Service Start...");
            try
            {
                //CKDSalesJob job = new CKDSalesJob();
                //job.Execute(null);
                ISchedulerFactory factory = new StdSchedulerFactory(); //新建一个调度器工厂
                IScheduler scheduler = factory.GetScheduler();//工厂生成一个调度器
                scheduler.Start();//启动调度器

                IDictionary<IJobDetail, Quartz.Collection.ISet<ITrigger>> jobs = new Dictionary<IJobDetail, Quartz.Collection.ISet<ITrigger>>();

                #region 增加导入CKD销售出货资料的Job到列表中
                IJobDetail CKDSalesJob = JobBuilder.Create<CKDSalesJob>().WithIdentity("CKDSalesJob", "PBMS").Build();
                Quartz.Collection.ISet<ITrigger> CKDSalesTrigger = new Quartz.Collection.HashSet<ITrigger>();
                //1小时执行1次
                CKDSalesTrigger.Add(TriggerBuilder.Create().WithCronSchedule("0 0 0/1 1/1 * ? *").Build());//http://www.cronmaker.com/
                jobs.Add(CKDSalesJob, CKDSalesTrigger);
                #endregion

                scheduler.ScheduleJobs(jobs, true);
            }
            catch (Exception ex)
            {
                LogHelper.Write(ex);
            }
        }
    }
}
