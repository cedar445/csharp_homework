using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SimpleCrawler
{
    class SimpleCrawler
    {
        private ConcurrentDictionary<string, bool> urls = new ConcurrentDictionary<string, bool>();
        private int count = 0;
        private static int maxCount = 10; // 最大下载数量，可以根据需要调整

        static void Main(string[] args)
        {
            SimpleCrawler myCrawler = new SimpleCrawler();
            string startUrl = "http://www.cnblogs.com/dstang2000/";
            if (args.Length >= 1) startUrl = args[0];
            myCrawler.urls.TryAdd(startUrl, false); // 加入初始页面
            Task task = myCrawler.CrawlAsync();
            task.Wait(); // 等待任务完成
        }

        private async Task CrawlAsync()
        {
            Console.WriteLine("开始爬行了.... ");
            while (urls.Any(url => !url.Value) && count < maxCount)
            {
                var toCrawl = urls.Where(url => !url.Value).ToList();
                List<Task> tasks = new List<Task>();

                foreach (var url in toCrawl)
                {
                    if (count >= maxCount) break;

                    string current = url.Key;
                    urls[current] = true; // 标记为已处理
                    Console.WriteLine("爬行" + current + "页面!");
                    Task crawlTask = Task.Run(() => ProcessUrl(current));
                    tasks.Add(crawlTask);

                    if (++count >= maxCount) break;
                }

                await Task.WhenAll(tasks);
                Console.WriteLine("爬行结束");
            }
        }

        private async Task ProcessUrl(string url)
        {
            string html = await DownLoadAsync(url); // 异步下载
            Parse(html); // 解析, 并加入新的链接
        }

        public async Task<string> DownLoadAsync(string url)
        {
            using (WebClient webClient = new WebClient())
            {
                webClient.Encoding = Encoding.UTF8;
                try
                {
                    string html = await webClient.DownloadStringTaskAsync(url);
                    string fileName = count.ToString();
                    File.WriteAllText(fileName, html, Encoding.UTF8);
                    return html;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return "";
                }
            }
        }

        private void Parse(string html)
        {
            string strRef = @"(href|HREF)[]*=[]*[""'][^""'#>]+[""']";
            MatchCollection matches = new Regex(strRef).Matches(html);
            foreach (Match match in matches)
            {
                strRef = match.Value.Substring(match.Value.IndexOf('=') + 1)
                          .Trim('"', '\"', '#', '>');
                if (strRef.Length == 0 || urls.ContainsKey(strRef)) continue;
                urls.TryAdd(strRef, false);
            }
        }
    }
}
