using Newtonsoft.Json;

namespace RiotGamesAPI.DTO
{
    /// <summary>
    /// The observer information.
    /// </summary>
    public class Observer
    {
        /// <summary>
        /// Key used to decrypt the spectator grid game data for playback.
        /// </summary>
        [JsonProperty("encryptionKey")]
        public string EncryptionKey { get; set; }

        public override string ToString()
        {
            return string.Format("Encryption Key : {0}", this.EncryptionKey);
        }
    }
}
