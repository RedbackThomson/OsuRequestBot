using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace OsuRequestBot
{
    class BeatmapFetcher
    {
        private const string BeatmapString = "http://api.osu.miz.hexide.com/beatmaps/{0}";
        public static BeatmapInfo FetchInfo(int rankedId)
        {
            string jsonInfo = "";
            using (WebClient client = new WebClient())
            {
                string url = string.Format(BeatmapString, rankedId);
                try
                {
                    jsonInfo = client.DownloadString(url);
                }
                catch(Exception)
                {
                    return null;
                }
            }
            if (string.IsNullOrEmpty(jsonInfo)) return null;

            var info = Newtonsoft.Json.JsonConvert.DeserializeObject<BeatmapInfo>(jsonInfo);
            return info;
        }
    }

    public class BeatmapInfo
    {
        public int id, ranked_id, size;
        public DateTime date;
        public string name, title, type, hash_md5, hash_sha1;
    }
}
