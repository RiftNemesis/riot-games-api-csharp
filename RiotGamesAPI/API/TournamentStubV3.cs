using System.Collections.Generic;
using Newtonsoft.Json;
using RiotGamesAPI.DTO;

namespace RiotGamesAPI.API
{
    public class TournamentStubV3 : ApiMethod
    {
        public TournamentStubV3(ApiConnection apiConnection) : base(apiConnection) { }

        /// <summary>
        /// Create a mock tournament code for the given tournament.
        /// </summary>
        /// <param name="count">The number of codes to create (max 1000).</param>
        /// <param name="tournamentId">The tournament ID.</param>
        /// <param name="tournamentCodeParameters">Metadata for the generated code.</param>
        /// <returns>List<string></returns>
        public List<string> CreateMockTournamentCode(int count, long tournamentId,
            TournamentCodeParameters tournamentCodeParameters)
        {
            string path = "/lol/tournament-stub/v3/codes";
            return JsonConvert.DeserializeObject<List<string>>(this.ApiConnection.GetResponseAsJson(path));
        }

        // Gets a mock list of lobby events by tournament code.
        public LobbyEventDTOWrapper GetMockLobbyEvents(string tournamentCode)
        {
            throw new System.NotImplementedException();
        }

        // Creates a mock tournament provider and returns its ID.
        public int CreateMockTournamentProvider(ProviderRegistrationParameters providerRegistrationParameters)
        {
            throw new System.NotImplementedException();
        }

        // Creates a mock tournament and returns its ID.
        public int CreateMockTournament(TournamentRegistrationParameters tournamentRegistrationParameters)
        {
            throw new System.NotImplementedException();
        }
    }
}
