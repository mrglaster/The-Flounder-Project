using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Text.Json;
using System.Threading.Tasks;

namespace Glossa_App.Data.Repository
{
    internal class ModuleRepository
    {
        private const int SECRETKEY = 42;
        private const string URI = "http://192.168.0.12:8000";
        private readonly HttpClient _httpClient;
        private static ModuleRepository moduleInstance = null;
        const int _page_size = 5;

        private ModuleRepository(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri(URI);
        }

        public static ModuleRepository Initialize(HttpClient httpClient)
        {
            if (moduleInstance == null)
                moduleInstance = new ModuleRepository(httpClient);
            return moduleInstance;
        }

        public async Task<JsonNode> getModules(int _page)
        {
            using StringContent jsonContent = new(
                JsonSerializer.Serialize(new
                {
                    page = _page,
                    page_size = _page_size,
                    secretkey = SECRETKEY
                }),
                Encoding.UTF8,
                "application/json"); ;
            using HttpResponseMessage response = await _httpClient.PostAsync(
                "study/latest_modules",
                jsonContent);
            string result = await response.Content.ReadAsStringAsync();
            JsonNode jsonResponse = JsonNode.Parse(result);
            return jsonResponse;
        }
    }
}
