using LINEStickersLib.Enums;
using Newtonsoft.Json;

namespace LINEStickersLib.Objects
{
    /// <summary>
    /// スタンプのパッケージ。
    /// </summary>
    public class Package
    {
        /// <summary>
        /// パッケージのユニークなID。
        /// </summary>
        [JsonProperty("id")]
        public long ID { get; set; }

        /// <summary>
        /// パッケージのタイトル。
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// パッケージの作者名。
        /// </summary>
        [JsonProperty("author")]
        public string Author { get; set; }

        /// <summary>
        /// パッケージの説明文。
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// パッケージの価格(円)。
        /// </summary>
        [JsonProperty("price")]
        public int Price { get; set; }

        /// <summary>
        /// 公式スタンプのパッケージかどうか。
        /// </summary>
        [JsonProperty("is_official")]
        public bool IsOfficial { get; set; }

        /// <summary>
        /// パッケージが含むメディアの種類。
        /// </summary>
        [JsonProperty("media")]
        public MediaType[] Media { get; set; }

        /// <summary>
        /// パッケージのサムネイルのURLのセット。
        /// </summary>
        [JsonProperty("thumbnail")]
        public MediaURL Thumbnail { get; set; }

        /// <summary>
        /// パッケージが含むスタンプ。
        /// </summary>
        [JsonProperty("stickers")]
        public Sticker[] Stickers { get; set; }
    }
}