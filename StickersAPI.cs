using LINEStickersLib.Enums;
using LINEStickersLib.Exceptions;
using LINEStickersLib.Objects;
using Newtonsoft.Json;
using System.Net.Http;

namespace LINEStickersLib
{
    public static class StickersAPI
    {
        public const string API_URL = "https://api.sikeserver.com/sticker/v2/";

        /// <summary>
        /// 指定されたIDのパッケージを取得します。
        /// エラーが発生した場合はStickersAPIExceptionをスローします。
        /// </summary>
        /// <param name="ID">取得するパッケージのID。</param>
        /// <returns>取得したパッケージ。</returns>
        public static Package GetPackage(long ID)
        {
            using (var hc = new HttpClient())
            {
                var json = hc.GetStringAsync(API_URL + ID).Result;
                var res = JsonConvert.DeserializeObject<PackageResponse>(json);

                if (res.Status != APIStatus.Ok)
                {
                    throw new StickersAPIException(res.ErrorCode);
                }

                return res;
            }
        }
    }
}