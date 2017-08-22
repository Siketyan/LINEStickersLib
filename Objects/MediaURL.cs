using Newtonsoft.Json;

namespace LINEStickersLib.Objects
{
    /// <summary>
    /// スタンプまたはサムネイルの各メディアへのURLのセット。
    /// </summary>
    public class MediaURL
    {
        /// <summary>
        /// 画像(.png)へのURL。
        /// </summary>
        [JsonProperty("image")]
        public string Image { get; set; }

        /// <summary>
        /// サウンド(.m4a)へのURL。
        /// パッケージ及びスタンプがサウンドを含まない場合、空になります。
        /// </summary>
        [JsonProperty("sound")]
        public string Sound { get; set; }

        /// <summary>
        /// アニメーション(.png)へのURL。
        /// パッケージ及びスタンプがアニメーションを含まない場合、空になります。
        /// </summary>
        [JsonProperty("animation")]
        public string Animation { get; set; }

        /// <summary>
        /// ポップアップ(.png)へのURL。
        /// パッケージ及びスタンプがポップアップを含まない場合、空になります。
        /// </summary>
        [JsonProperty("popup")]
        public string Popup { get; set; }
    }
}