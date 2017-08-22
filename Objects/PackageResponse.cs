using LINEStickersLib.Enums;
using Newtonsoft.Json;

namespace LINEStickersLib.Objects
{
    /// <summary>
    /// Package APIの応答。
    /// </summary>
    public class PackageResponse : Package
    {
        /// <summary>
        /// APIの処理が正常に終了したかどうか。
        /// </summary>
        [JsonProperty("status")]
        public APIStatus Status { get; set; }

        /// <summary>
        /// APIのエラーコード。
        /// StatusがOkのときは空になります。
        /// </summary>
        [JsonProperty("error")]
        public string ErrorCode { get; set; }
    }
}