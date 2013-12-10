using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace OsuRequestBot
{
    class BeatmapFetcher
    {
        private const string APIURL = "http://osu.ppy.sh/api/get_beatmaps?k={0}&{1}={2}";
        private const string APIKey = "378965a078e0a0a9d0bdd4632139ce42ac35d9e2";

        private static string GetBeatmapURL(int rankedID)
        {
            return string.Format(APIURL, APIKey, "b", rankedID);
        }

        private static string GetSetURL(int rankedID)
        {
            return string.Format(APIURL, APIKey, "s", rankedID);
        }

        public static BeatmapInfo[] FetchSetInfo(int rankedId)
        {
            string jsonInfo = "";
            using (WebClient client = new WebClient())
            {
                string url = GetSetURL(rankedId);
                try
                {
                    jsonInfo = client.DownloadString(url);
                }
                catch (Exception)
                {
                    return null;
                }
            }
            if (string.IsNullOrEmpty(jsonInfo)) return null;

            var info = Newtonsoft.Json.JsonConvert.DeserializeObject<BeatmapInfo[]>(jsonInfo);
            return info;
        }

        public static BeatmapInfo FetchBeatmapInfo(int rankedId)
        {
            string jsonInfo = "";
            using (WebClient client = new WebClient())
            {
                string url = GetBeatmapURL(rankedId);
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

            var info = Newtonsoft.Json.JsonConvert.DeserializeObject<BeatmapInfo[]>(jsonInfo);
            return info[0];
        }
    }

    public class BeatmapInfo
    {
        public int beatmapset_id, beatmap_id, approved, total_length, hit_length, bpm, mode;
        public double difficultyrating;
        public string creator, title, artist, version;
        public DateTime? approved_date, last_update;
    }
}
