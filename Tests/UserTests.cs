using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using dotNetCore.Models;
using FluentAssertions;
using NUnit.Framework;

namespace Testing
{
    [TestFixture]
    public class UserTests
    {
        public HttpClient httpClient;

        [SetUp]
        public void Setup()
        {
            httpClient = new HttpClient();
        }
        [TearDown]
        public void End()
        {
            httpClient.Dispose();
        }

        [Test]
        public async Task http_response_should_204_status_code()
        {
            var response=await httpClient.GetAsync("http://httpstat.us/204");
            Assert.AreEqual(response.StatusCode,HttpStatusCode.NoContent);
        }

     
    }
}