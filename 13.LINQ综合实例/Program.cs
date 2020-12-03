using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.LINQ综合实例
{
    class Program
    {
        static void Main(string[] args)
        {
            //初始化武林高手
            var master = new List<MartialArtsMaster>()
            {
                new MartialArtsMaster()
                {
                    Id =1,
                    Name ="黄蓉",
                    Age =18,
                    MenPai="丐帮",
                    Kungfu="打狗棒法",
                    Level=9
                },
                new MartialArtsMaster()
                {
                    Id =2,
                    Name ="洪七公",
                    Age =70,
                    MenPai="丐帮",
                    Kungfu="打狗棒法",
                    Level=10
                },
                new MartialArtsMaster()
                {
                    Id =3,
                    Name ="郭靖",
                    Age =22,
                    MenPai="丐帮",
                    Kungfu="降龙十八掌",
                    Level=10
                },
                new MartialArtsMaster()
                {
                    Id =4,
                    Name ="任我行",
                    Age =50,
                    MenPai="明教",
                    Kungfu="吸星大法",
                    Level=10
                },
                new MartialArtsMaster()
                {
                    Id =5,
                    Name ="东方不败",
                    Age =35,
                    MenPai="明教",
                    Kungfu="葵花宝典",
                    Level=10
                },
                new MartialArtsMaster()
                {
                    Id =6,
                    Name ="林平之",
                    Age =23,
                    MenPai="华山",
                    Kungfu="葵花宝典",
                    Level=7
                },
                new MartialArtsMaster()
                {
                    Id =7,
                    Name ="岳不群",
                    Age =50,
                    MenPai="华山",
                    Kungfu="葵花宝典",
                    Level=8
                }

            };

            //初始化
            var kongfu = new List<Kongfu>()
            {
                new Kongfu()
                {
                    KongfuId=1,
                    KongfuName="打狗棒法",
                    Lethality=90

                },
                new Kongfu()
                {
                    KongfuId=2,
                    KongfuName="降龙十八掌",
                    Lethality=95

                },
                new Kongfu()
                {
                    KongfuId=1,
                    KongfuName="葵花宝典",
                    Lethality=93

                }
            };


            /*
             * 示例一
             * 
             */
            //var GaiBangMaster = from m in master
            //                    where m.Level > 8 && m.MenPai == "丐帮"
            //                    select m;

            //string GaiBangMasterResult = "查询丐帮中大于8级的大侠";

            //foreach (var m in GaiBangMaster)
            //{
            //    GaiBangMasterResult = m.Id + " " + m.Name + " " + m.Age + " " + m.MenPai + " " + m.Kungfu + " " + m.Level + " " + "\n";
            //    Console.WriteLine(GaiBangMasterResult);
            //}


            //另一种
            //Console.WriteLine("另一种");

            //string GaiBangMasterMethodResult = "查询丐帮中大于8级的大侠";

            //var GaiBangMaterMethod = master.Where(m => m.Level > 8 && m.MenPai == "丐帮");

            //foreach (var m in GaiBangMaterMethod)
            //{
            //    GaiBangMasterMethodResult = m.Id + " " + m.Name + " " + m.Age + " " + m.MenPai + " " + m.Kungfu + " " + m.Level + " " + "\n";
            //    Console.WriteLine(GaiBangMasterMethodResult);
            //}

            /*
             * 示例二
             * 
             */

            //表达式
            //var masterKongfu =from m in master
            //                  from k in kongfu
            //                  where k.Lethality>90 && m.Kungfu == k.KongfuName
            //                  orderby m.Level
            //                  select m.Id + " " + m.Name + " " + m.Age + " " + m.MenPai + " " + m.Kungfu + " " + m.Level + " " + "\n";

            //string masterKongfuResult = "过滤所学武功杀伤力大于90的大侠";

            //foreach (var item in masterKongfu)
            //{
            //    masterKongfuResult = item;
            //    Console.WriteLine(masterKongfuResult);
            //}

            ////扩展方法
            //var masterKongfuMethod = master.SelectMany(k => kongfu, (m, k) => new { mt = m, kf = k })//连接
            //    .Where(x => x.kf.Lethality > 90 && x.mt.Kungfu == x.kf.KongfuName)
            //    .OrderBy(m => m.mt.Level)
            //    .Select(m => m.mt.Id + " " + m.mt.Name + " " + m.mt.Age + " " + m.mt.MenPai + " " + m.mt.Kungfu + " " + m.mt.Level + " ");

            //string masterKongfuMethodResult = "过滤所学武功杀伤力大于90的大侠:\n";

            //foreach (var item in masterKongfuMethod)
            //{
            //    masterKongfuMethodResult = item.ToString();

            //    Console.WriteLine(masterKongfuMethodResult);
            //}


            /*
             * 示例三
             * 
             */

            //武林排行榜

            //表达式
            //var topMater =from m in master
            //              from k in kongfu
            //              where m.Kungfu==k.KongfuName
            //              orderby m.Level*k.Lethality descending,m.Age,m.Name
            //              select m.Id + " " + m.Name + " " + m.Age + " " + m.MenPai + " " + m.Kungfu + " " + m.Level + " " + "\n";

            //string topMaterResult = "武林排行榜";

            //foreach (var m in topMater)
            //{
            //    topMaterResult = m.ToString();
            //    Console.WriteLine(topMaterResult);
            //}

            //扩展方式
            //var topMaterMethod = master.SelectMany(k => kongfu, (m, k) => new { mt = m, ku = k })
            //    .Where(x => x.mt.Kungfu == x.ku.KongfuName)
            //    .OrderByDescending(m => m.mt.Level * m.ku.Lethality).
            //    ThenBy(m => m.mt.Age)
            //    .ThenBy(m => m.mt.Name)
            //    .Select(m => m.mt.Id + " " + m.mt.Name + " " + m.mt.Age + " " + m.mt.MenPai + " " + m.mt.Kungfu + " " + m.mt.Level + " ");

            //string topMaterMethodResult = "武林排名";

            //foreach (var m in topMaterMethod)
            //{
            //    topMaterMethodResult = m.ToString();

            //    Console.WriteLine(topMaterMethodResult);
            //}

            /*
             * 示例四
             * 
             */

            //第一武林高手
            int i = 0;
            var masterTop = master.OrderByDescending(x => x.Level)
                .Select(x => new { x.Id, x.Name, x.Age, x.MenPai, x.Kungfu, x.Level, Top = (++i) });

            int i2 = 0;
            var KongfuTop = from k in kongfu
                            orderby k.Lethality descending
                            select new { Id = k.KongfuId, Name = k.KongfuName, k.Lethality ,KongfuTop=(i2++)};

            //表达式
            var masterLethalityTop = from m in masterTop
                                     join k in KongfuTop on m.Kungfu equals k.Name
                                     orderby m.Level * k.Lethality descending
                                     
                                     select new { m.Id, m.Name, m.Kungfu, m.MenPai, m.Level, Kill = m.Level * k.Lethality };

            foreach (var item in masterLethalityTop)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("下面是扩展方式");

            //扩展方式
            var masterLethalityTopMethod = masterTop.Join(KongfuTop, m => m.Kungfu, k => k.Name, (m, k) => new { mt = m, kf = k })
                .OrderByDescending(x => x.mt.Level * x.kf.Lethality)
                .Select(x => new { x.mt.Id, x.mt.Name, x.mt.Kungfu, x.mt.MenPai, x.mt.Level, Kill = x.mt.Level * x.kf.Lethality });

            foreach (var item in masterLethalityTopMethod)
            {
                Console.WriteLine(item);
            }
        }
    }
}
