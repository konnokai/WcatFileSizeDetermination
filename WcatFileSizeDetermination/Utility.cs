namespace Wcat_Index_Decide
{
    public static class Utility
	{
		public static string JPServer { get; set; } = "https://i-cf.wcat.colopl.jp/assets/2018/a/";
		public static string TWServer { get; set; } = "http://img.wcproject.so-net.tw/assets/2018/a/";
		public static string SeleteIndex { get; set; } = "";

        static HttpClient httpClient = new HttpClient();

        public static long GetWebFileSize(string url)
        {
            long result = -1;

            try
            {
                var httpResult = httpClient.Send(new HttpRequestMessage(HttpMethod.Head, url));
                httpResult.EnsureSuccessStatusCode();

                if (!httpResult.Content.Headers.TryGetValues("Content-Length", out var strings))
                    return result;

                if (long.TryParse(strings.First(), out long ContentLength))
                    result = ContentLength;
            }
            catch (Exception) { }

            return result;
        }        
    }
}
