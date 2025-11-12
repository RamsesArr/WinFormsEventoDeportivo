using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using WinFormsEventoDeportivo.Model;
using static System.Net.WebRequestMethods;
namespace WinFormsEventoDeportivo.Controller
{
    internal class APIController
    {
        private static readonly HttpClient _http = new HttpClient
        {
            Timeout = TimeSpan.FromSeconds(30)
        };
        public async Task<List<EventoDeportivoModel>> GetEventosDeportivosAsync(string url= "https://localhost:7199/api/EventoDeportivo")
        {
            using var resp = await _http.GetAsync(url).ConfigureAwait(false);
            resp.EnsureSuccessStatusCode();

            var stream = await resp.Content.ReadAsStreamAsync().ConfigureAwait(false);
            var opts = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

            var lista = await JsonSerializer.DeserializeAsync<List<EventoDeportivoModel>>(stream, opts).ConfigureAwait(false);
            return lista ?? new List<EventoDeportivoModel>();
        }
        public async Task<EventoDeportivoModel?> PostAlumnoAsync(EventoDeportivoModel alumno, string url = "https://localhost:7199/api/EventoDeportivo")
        {
            if (alumno == null) return null;

            try
            {
                var opts = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                var json = JsonSerializer.Serialize(alumno, opts);
                using var content = new StringContent(json, Encoding.UTF8, "application/json");

                using var resp = await _http.PostAsync(url, content).ConfigureAwait(false);
                resp.EnsureSuccessStatusCode();

                var stream = await resp.Content.ReadAsStreamAsync().ConfigureAwait(false);
                var created = await JsonSerializer.DeserializeAsync<EventoDeportivoModel>(stream, opts).ConfigureAwait(false);
                return created;
            }
            catch
            {
                // Podrías loguear aquí o propagar la excepción según prefieras
                return null;
            }
        }

        #region--> metodo PUT
        public async Task<bool> PutAlumnoAsync(int id, EventoDeportivoModel alumno, string baseUrl = "https://localhost:7199/api/EventoDeportivo")
        {
            if (alumno == null) return false;

            try
            {
                var url = $"{baseUrl}/{id}";
                var opts = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                var json = JsonSerializer.Serialize(alumno, opts);
                using var content = new StringContent(json, Encoding.UTF8, "application/json");

                using var resp = await _http.PutAsync(url, content).ConfigureAwait(false);
                return resp.IsSuccessStatusCode;
            }
            catch
            {
                return false;
            }
        }
        #endregion

        #region--> metodo DELETE
        public async Task<bool> DeleteAlumnoAsync(int id, string baseUrl = "https://localhost:7199/api/EventoDeportivo")
        {
            try
            {
                var url = $"{baseUrl}/{id}";
                using var resp = await _http.DeleteAsync(url).ConfigureAwait(false);
                return resp.IsSuccessStatusCode;
            }
            catch
            {
                return false;
            }
        }
        #endregion
    }
}
