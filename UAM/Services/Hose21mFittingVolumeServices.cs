using UAM.Models;

namespace UAM.Services
{
    public class Hose21mFittingVolumeServices : IHose21mFittingVolumeServices
    {
        private readonly HttpClient httpClient;
        string _baseAddress = "https://localhost:44348/";
        private readonly HttpClient client = new HttpClient(new HttpClientHandler() { UseDefaultCredentials = true });


        public Hose21mFittingVolumeServices(HttpClient httpClient)
        {
            this.httpClient = client;
            if(httpClient.BaseAddress == null)
            this.httpClient.BaseAddress = new Uri(_baseAddress);
            
        }
 
        public async Task<IEnumerable<Hose21mFittingVolume>> GetHose21mFittingVolume()
        {
           return await httpClient.GetFromJsonAsync<IEnumerable<Hose21mFittingVolume>>("api/Hose21mFittingVolume/Index");
        }

        public Uri GetBaseAddress()
        {
            return new Uri(this._baseAddress);
        }

        public async Task AddHose21mFittingVolume(Hose21mFittingVolume Hose21mFittingVolume)
        {
            var response =  await httpClient.PostAsJsonAsync("api/Hose21mFittingVolume/Create", Hose21mFittingVolume);
        }

        public async Task<Pagination> GetPagination()
        {
            return await httpClient.GetFromJsonAsync<Pagination>("api/Hose21mFittingVolume/GetPagination");
        }

        public async Task<IEnumerable<Hose21mFittingVolume>> GetHose21mFittingVolume(int PageNo)
        {
            return await httpClient.GetFromJsonAsync<IEnumerable<Hose21mFittingVolume>>($"api/Hose21mFittingVolume/Index?pageNo={PageNo}");
        }
    }
}
