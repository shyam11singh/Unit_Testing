using System.Net.Http;
using System.Threading.Tasks;
using Xunit;
using HelloWorldApp;

namespace HelloWorldApp.Tests;
  
 public class HelloWorldAppTests
    {
        private readonly HttpClient _client;
        public HelloWorldAppTests()
        {
            _client = new HttpClient();
        }
        [Fact]
        public async Task Get_Endpoint_ReturnsHelloWorld()
        {
            // Arrange
            var response = await _client.GetAsync("http://localhost:5000");
            // Assert
            response.EnsureSuccessStatusCode();
            Assert.Equal("Hello World!", await response.Content.ReadAsStringAsync());
        }
    }
  

