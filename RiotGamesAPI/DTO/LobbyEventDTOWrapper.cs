using System.Collections.Generic;
using Newtonsoft.Json;

namespace RiotGamesAPI.DTO
{
    /// <summary>
    /// Lobby Event Informations Wrapper.
    /// </summary>
    public class LobbyEventDTOWrapper
    {
        [JsonProperty("eventList")]
        public List<LobbyEventDTO> eventList { get; set; }
    }
}
