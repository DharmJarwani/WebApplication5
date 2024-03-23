using Microsoft.AspNetCore.Mvc.Testing;
using WebApplication5.Models;
using System.Net.Http.Json;


namespace IntegrationTests
{
    public class StudentsControllerIntegrationTests : IClassFixture<WebApplicationFactory<TestStartup>>
    {
        private readonly WebApplicationFactory<TestStartup> _factory;

        public StudentsControllerIntegrationTests(WebApplicationFactory<TestStartup> factory)
        {
            _factory = factory;
        }

        [Fact]
        public async Task GetStudents_ReturnsSuccessAndStudents()
        {
            // Arrange
            HttpClient client = _factory.CreateClient();

            // Act
            HttpResponseMessage response = await client.GetAsync("/Students");
            response.EnsureSuccessStatusCode();
            IEnumerable<Student>? students = await response.Content.ReadFromJsonAsync<IEnumerable<Student>>();

            // Assert
            Assert.NotNull(students);
            Assert.NotEmpty(students);
        }

    }
}