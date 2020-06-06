using BackgroundTask.data;
using Hsf.Redis.Service;
using log4net;
using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackgroundTask
{
    public class TestJob : IJob
    {
        private readonly ILog _log = LogManager.GetLogger(typeof(TestJob));
        /// <summary>
        /// 测试作业
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public async Task Execute(IJobExecutionContext context)
        {
            //JobDataMap dataMap = context.JobDetail.JobDataMap;
            //string k = dataMap.GetString("key");//获取参数(可根据传递的类型使用GetInt、GetFloat、GetString.....)
            //_log.Debug("run TestJob debug");
            //_log.Error("run TestJob error");
            //_log.Info("run TestJob info");
            // 在这里处理你的任务
            using (HmkDBContext hmkDBContext = new HmkDBContext())
            {
                hmkDBContext.Database.CommandTimeout = 120;
                int seeCount = 3052851 + hmkDBContext.TelphoneLiangSee.Count();//浏览记录老bak表总数量3052851
                var shareCount = hmkDBContext.TelphoneLiangShare.Count();
                var joinCount = hmkDBContext.TelphoneLiangJoin.Count();
                var orgCount = hmkDBContext.Base_Organize.Count();
                var telCount = hmkDBContext.TelphoneLiang.Count();

                using (RedisHashService service = new RedisHashService())
                {
                    service.SetEntryInHash("Hmk_Count", "seeCount", seeCount.ToString());
                    service.SetEntryInHash("Hmk_Count", "shareCount", shareCount.ToString());
                    service.SetEntryInHash("Hmk_Count", "joinCount", joinCount.ToString());
                    service.SetEntryInHash("Hmk_Count", "orgCount", orgCount.ToString());
                    service.SetEntryInHash("Hmk_Count", "telCount", telCount.ToString());
                }
                _log.Info("存入缓存--》seeCount：" + seeCount + " 分享：" + shareCount + " 加盟：" + joinCount + " 机构：" + orgCount + " 号码：" + telCount);
            }
            

        }
    }
}
