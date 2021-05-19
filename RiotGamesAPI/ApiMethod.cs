namespace RiotGamesAPI
{
    public abstract class ApiMethod
    {
        public ApiConnection ApiConnection { get; set; }

        public ApiMethod(ApiConnection apiConnection)
        {
            this.ApiConnection = apiConnection;
        }
    }
}
