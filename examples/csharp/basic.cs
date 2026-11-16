/*
 * Captcha Generator API - Basic Usage Example
 *
 * This example demonstrates the basic usage of the Captcha Generator API.
 * API Documentation: https://docs.apiverve.com/ref/captchagenerator
 */

using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Linq;

namespace APIVerve.Examples
{
    class CaptchaGeneratorExample
    {
        private static readonly string API_KEY = Environment.GetEnvironmentVariable("APIVERVE_API_KEY") ?? "YOUR_API_KEY_HERE";
        private static readonly string API_URL = "https://api.apiverve.com/v1/captchagenerator";

        /// <summary>
        /// Make a GET request to the Captcha Generator API
        /// </summary>
        static async Task<JsonDocument> CallCaptchaGeneratorAPI()
        {
            try
            {
                using var client = new HttpClient();
                client.DefaultRequestHeaders.Add("x-api-key", API_KEY);

                // Query parameters
                var queryParams &#x3D; new Dictionary&lt;string, string&gt; { [&quot;type&quot;] &#x3D; &quot;math&quot;, [&quot;length&quot;] &#x3D; 6, [&quot;charset&quot;] &#x3D; &quot;alphanumeric&quot;, [&quot;unambiguous&quot;] &#x3D; true, [&quot;difficulty&quot;] &#x3D; &quot;hard&quot;, [&quot;width&quot;] &#x3D; 240, [&quot;height&quot;] &#x3D; 80, [&quot;format&quot;] &#x3D; &quot;png&quot;, [&quot;audio&quot;] &#x3D; true, [&quot;audioNoise&quot;] &#x3D; &quot;low&quot;, [&quot;inline&quot;] &#x3D; true };

                var queryString = string.Join("&",
                    queryParams.Select(kvp => $"{kvp.Key}={Uri.EscapeDataString(kvp.Value)}"));
                var url = $"{API_URL}?{queryString}";

                var response = await client.GetAsync(url);

                // Check if response is successful
                response.EnsureSuccessStatusCode();

                var responseBody = await response.Content.ReadAsStringAsync();
                var data = JsonDocument.Parse(responseBody);

                // Check API response status
                if (data.RootElement.GetProperty("status").GetString() == "ok")
                {
                    Console.WriteLine("✓ Success!");
                    Console.WriteLine("Response data: " + data.RootElement.GetProperty("data"));
                    return data;
                }
                else
                {
                    var error = data.RootElement.TryGetProperty("error", out var errorProp)
                        ? errorProp.GetString()
                        : "Unknown error";
                    Console.WriteLine($"✗ API Error: {error}");
                    return null;
                }
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"✗ Request failed: {e.Message}");
                return null;
            }
        }

        static async Task Main(string[] args)
        {
            Console.WriteLine("📤 Calling Captcha Generator API...\n");

            var result = await CallCaptchaGeneratorAPI();

            if (result != null)
            {
                Console.WriteLine("\n📊 Final Result:");
                Console.WriteLine(result.RootElement.GetProperty("data"));
            }
            else
            {
                Console.WriteLine("\n✗ API call failed");
            }
        }
    }
}
