using UAM.Models;

namespace UAM.Services
{
    public class Tbl_Rev_per_MaterialServices : ITbl_Rev_per_MaterialServices
    {
        private readonly HttpClient httpClient;
        string _baseAddress = "https://localhost:44348/";
        private readonly HttpClient client = new HttpClient(new HttpClientHandler() { UseDefaultCredentials = true });


        public Tbl_Rev_per_MaterialServices(HttpClient httpClient)
        {
            this.httpClient = client;
            if(httpClient.BaseAddress == null)
            this.httpClient.BaseAddress = new Uri(_baseAddress);            
        }        

        public async Task<IEnumerable<tbl_Rev_per_Material>> GetTbl_Rev_per_Material()
        {
           return await httpClient.GetFromJsonAsync<IEnumerable<tbl_Rev_per_Material>>("api/Tbl_Rev_per_Material/index");
        }
         
    }
}
//https://localhost:44348/api/Tbl_Rev_per_Material/index