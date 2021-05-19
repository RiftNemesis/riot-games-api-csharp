using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using RiotGamesAPI.DTO;

namespace RiotGamesAPI.API
{
    public class MatchV3 : ApiMethod
    {
        public MatchV3(ApiConnection apiConnection) : base(apiConnection) { }

        /// <summary>
        /// Get match by match ID.
        /// </summary>
        /// <param name="matchId">The match ID.</param>
        /// <returns>MatchDto</returns>
        public MatchDto GetMatch(long matchId)
        {
            string path = string.Format("/lol/match/v3/matches/{0}", matchId);
            return JsonConvert.DeserializeObject<MatchDto>(this.ApiConnection.GetResponseAsJson(path));
        }

        /// <summary>
        /// <para>Get matchlist for games played on given account ID</para>
        /// </summary>
        /// <param name="accountId">The account ID.</param>
        /// <returns>MatchlistDto</returns>
        public MatchlistDto GetMatchlist(long accountId)
        {
            string path = string.Format("/lol/match/v3/matchlists/by-account/{0}", accountId);
            return JsonConvert.DeserializeObject<MatchlistDto>(this.ApiConnection.GetResponseAsJson(path));
        }

        /// <summary>
        /// <para>Get matchlist for games played on given account ID</para>  
        /// <para>and platform ID and filtered using given filter parameters, if any.</para>
        /// <para>♠ Notes :</para>
        /// <para>A number of optional parameters are provided for filtering.</para>
        /// <para>It is up to the caller to ensure that the combination of filter parameters provided </para>
        /// <para>is valid for the requested account, otherwise, no matches may be returned. </para>
        /// <para>• If beginIndex is specified, but not endIndex, then endIndex defaults to beginIndex+100. </para>
        /// <para>• If endIndex is specified, but not beginIndex, then beginIndex defaults to 0. </para>
        /// <para>• If both are specified, then endIndex must be greater than beginIndex. </para>
        /// <para>• The maximum range allowed is 100, otherwise a 400 error code is returned. </para>
        /// <para>• If beginTime is specified, but not endTime, then these parameters are ignored. </para>
        /// <para>• If endTime is specified, but not beginTime, then beginTime defaults to the start of the account's match history. </para>
        /// <para>• If both are specified, then endTime should be greater than beginTime. </para>
        /// <para>• The maximum time range allowed is one week, otherwise a 400 error code is returned.</para>
        /// </summary>
        /// <param name="accountId">The account ID.</param>
        /// <param name="beginIndex">The begin index to use for filtering matchlist.</param>
        /// <param name="endIndex">The end index to use for filtering matchlist.</param>
        /// <param name="beginTime">The begin time to use for filtering matchlist specified as epoch milliseconds.</param>
        /// <param name="endTime">The end time to use for filtering matchlist specified as epoch milliseconds.</param>
        /// <param name="champion">Set of champion IDs for filtering the matchlist.</param>
        /// <param name="queue">Set of queue IDs for filtering the matchlist.</param>
        /// <param name="season">Set of season IDs for filtering the matchlist.</param>
        /// <returns>MatchlistDto</returns>
        public MatchlistDto GetMatchlist(long accountId, int beginIndex = -1, int endIndex = -1, 
            long beginTime = -1, long endTime = -1, int[] champion = null, int[] queue = null, int[] season = null)
        {
            string[] queryParameters = new string[7];
            // If beginIndex is specified, but not endIndex, then endIndex defaults to beginIndex+100.
            if (beginIndex >= 0 && endIndex < 0)
            {
                endIndex = beginIndex + 100;
            }
            // If endIndex is specified, but not beginIndex, then beginIndex defaults to 0.
            else if (beginIndex < 0 && endIndex >= 0)
            {
                beginIndex = 0;
            }
            // If both are specified, then... 
            else if (beginIndex >= 0 && endIndex >= 0)
            {
                // endIndex must be greater than beginIndex.
                if (beginIndex > endIndex)
                {
                    throw new Exception("The endIndex must be greater than the beginIndex.");
                }
                // The maximum range allowed is 100, otherwise a 400 error code is returned.
                else if (endIndex - beginIndex > 100)
                {
                    throw new Exception("The maximum range allowed is 100.");
                }
            }
            queryParameters[0] = string.Format("beginIndex={0}", beginIndex);
            queryParameters[1] = string.Format("endIndex={0}", endIndex);
            // If beginTime is specified, but not endTime, then these parameters are ignored.
            if (beginTime >= 0 && endTime < 0)
            {
                queryParameters[2] = string.Format("beginTime={0}", beginTime);
            }
            // If endTime is specified, but not beginTime, then beginTime 
            // defaults to  the start of the account's match history.
            else if (beginTime < 0 && endTime >= 0)
            {
                queryParameters[3] = string.Format("endTime={0}", endTime);
            }
            // If both are specified, then... 
            else if (beginTime >= 0 && endTime >= 0)
            {
                // endTime should be greater than beginTime. 
                if (beginIndex > endTime)
                {
                    throw new Exception("The endTime should be greater than the beginTime.");
                }
                // The maximum time range allowed is one week, otherwise a 400 error code is returned.
                else if (endTime - beginTime > 6.048e+8)
                {
                    throw new Exception("The maximum time range allowed is one week.");
                }
                queryParameters[2] = string.Format("beginTime={0}", beginTime);
                queryParameters[3] = string.Format("endTime={0}", endTime);
            }
            string[] tmp = new string[champion.Length];
            for (int i = 0; i < champion.Length; i++)
			{
                tmp[i] = string.Format("champion={0}", champion[i]);
			}
            queryParameters[4] = string.Join("&", tmp);
            tmp = new string[queue.Length];
            for (int i = 0; i < queue.Length; i++)
			{
                tmp[i] = string.Format("queue={0}", queue[i]);
			}
            queryParameters[5] = string.Join("&", tmp);
            tmp = new string[season.Length];
            for (int i = 0; i < season.Length; i++)
			{
                tmp[i] = string.Format("season={0}", season[i]);
			}
            queryParameters[6] = string.Join("&", tmp);
            string path = string.Format("/lol/match/v3/matchlists/by-account/{0}?{1}", 
                accountId, string.Join("&", queryParameters));
            return JsonConvert.DeserializeObject<MatchlistDto>(this.ApiConnection.GetResponseAsJson(path));
        }
        
        /// <summary>
        /// <para>Get match timeline by match ID.</para>
        /// <para>Not all matches have timeline data.</para>
        /// </summary>
        /// <param name="matchId">The match ID.</param>
        /// <returns>MatchTimelineDto</returns>
        public MatchTimelineDto GetMatchTimeline(long matchId)
        {
            string path = string.Format("/lol/match/v3/timelines/by-match/{0}", matchId);
            return JsonConvert.DeserializeObject<MatchTimelineDto>(this.ApiConnection.GetResponseAsJson(path));
        }

        /// <summary>
        /// Get match IDs by tournament code.
        /// </summary>
        /// <param name="tournamentCode">The tournament code.</param>
        /// <returns>List<long></returns>
        public List<long> GetMatchIDs(string tournamentCode)
        {
            string path = string.Format("/lol/match/v3/matches/by-tournament-code/{0}/ids", tournamentCode);
            return JsonConvert.DeserializeObject<List<long>>(this.ApiConnection.GetResponseAsJson(path));
        }

        /// <summary>
        /// Get match by match ID and tournament code.
        /// </summary>
        /// <param name="matchId">The match ID.</param>
        /// <param name="tournamentCode">The tournament code.</param>
        /// <returns>MatchDto</returns>
        public MatchDto GetMatch(long matchId, string tournamentCode)
        {
            string path = string.Format("/lol/match/v3/matches/{0}/by-tournament-code/{1}", matchId, tournamentCode);
            return JsonConvert.DeserializeObject<MatchDto>(this.ApiConnection.GetResponseAsJson(path));
        }
    }
}
