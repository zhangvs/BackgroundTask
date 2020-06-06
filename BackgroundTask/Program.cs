using BackgroundTask.data;
using Hsf.Redis.Service;
using log4net;
using Quartz;
using Quartz.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackgroundTask
{
    class Program
    {
        private static readonly ILog _log = LogManager.GetLogger(typeof(Program));

        private static readonly string tiggerName = "TestJobTrigger";
        private static readonly string gropName = "TestJobTriggerGrop";
        private static readonly string jobName = "TestJob";
        //从工厂中获取一个调度器实例化
        private static IScheduler scheduler = null;


        static void Main(string[] args)
        {
            Console.WriteLine("开始任务....");
            _log.Debug("开始任务....");
            Start();

        }

        private static async void Start()
        {
            //从工厂中获取一个调度器实例化
            scheduler = await StdSchedulerFactory.GetDefaultScheduler();
            await scheduler.Start();


            //创建一个作业
            IJobDetail job1 = JobBuilder.Create<TestJob>()
             .WithIdentity(jobName, gropName)
             .UsingJobData("key", "value")// 传递参数 在Execute方法中获取（以什么类型值传入，取值就用相应的类型方法取值）
             .Build();

            // 创建触发器
            ITrigger trigger1 = TriggerBuilder.Create()
                                        .WithIdentity(tiggerName, gropName)
                                        .StartNow()                        //现在开始
                                        .WithSimpleSchedule(x => x         //触发时间，1小时一次。
                                            .WithIntervalInHours(1)
                                            .RepeatForever())              //不间断重复执行
                                        .Build();


            await scheduler.ScheduleJob(job1, trigger1);      //把作业，触发器加入调度器。

            Console.ReadKey();

            // 清除任务和触发器
            ClearJobTrigger();
        }

        /// <summary>
        /// 清除任务和触发器
        /// </summary>
        private static void ClearJobTrigger()
        {
            TriggerKey triggerKey = new TriggerKey(tiggerName, gropName);
            JobKey jobKey = new JobKey(jobName, gropName);
            if (scheduler != null)
            {
                scheduler.PauseTrigger(triggerKey);
                scheduler.UnscheduleJob(triggerKey);
                scheduler.DeleteJob(jobKey);
                scheduler.Shutdown();// 关闭
            }

        }

    }

}