using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Text.Json;
using System.Threading.Tasks;

using Glossa_App.Data.Repository.Interfaces;

namespace Glossa_App.Data.Repository
{
    internal class AuthenticationRepository : IAuthenticationRepository
    {
        private const int SECRETKEY = 42;
        private const string URI = "http://192.168.0.12:8000";
        private HttpClient _httpClient;
        private static AuthenticationRepository authenticationInstance = null;

        private AuthenticationRepository(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri(URI);
        }

        public static AuthenticationRepository Initialize(HttpClient httpClient)
        {
            if (authenticationInstance == null)
                authenticationInstance = new AuthenticationRepository(httpClient);
            return authenticationInstance;
        }

        public async Task<string> AuthenticateUser(string _login, string _password)
        {
            using StringContent jsonContent = new(
                JsonSerializer.Serialize(new
                {
                    login = _login,
                    password = _password,
                    secretkey = SECRETKEY
                }),
                Encoding.UTF8,
                "application/json");
            using HttpResponseMessage response = await _httpClient.PostAsync(
                "login",
                jsonContent);
            string result = await response.Content.ReadAsStringAsync();
            JsonNode jsonResponse = JsonNode.Parse(result);
            return jsonResponse["status"].ToString();
        }

        public async Task<string> RegistrationUser(string _login, string _password, string _email)
        {
            using StringContent jsonContent = new(
                JsonSerializer.Serialize(new
                {
                    nickname = _login,
                    password = _password,
                    email = _email,
                    avatar = "null",
                    secretkey = SECRETKEY
                }),
                Encoding.UTF8,
                "application/json");
            using HttpResponseMessage response = await _httpClient.PostAsync(
                "register",
                jsonContent);
            string result = await response.Content.ReadAsStringAsync();
            JsonNode jsonResponse = JsonNode.Parse(result);
            return jsonResponse["status"].ToString();
        }
    }
}
