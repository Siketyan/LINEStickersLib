using Newtonsoft.Json;

namespace LINEStickersLib.Objects
{
    /// <summary>
    /// スタンプ。
    /// </summary>
    public class Sticker
    {
        /// <summary>
        /// スタンプのユニークなID。
        /// </summary>
        [JsonProperty("id")]
        public long ID { get; set; }

        /// <summary>
        /// スタンプが含む各メディアへのURLのセット。
        /// </summary>
        [JsonProperty("url")]
        public MediaURL URL { get; set; }
    }
}