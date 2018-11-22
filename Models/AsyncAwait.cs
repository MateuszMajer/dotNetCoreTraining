using System;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace dotNetCore.Models
{
    public class AsyncAwait
    {
        public async Task Test()
        {
            var content = await GetContetAsync();
            Console.WriteLine(content);
        }

        public async Task<string> GetContetAsync()
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync("https://jsonplaceholder.typicode.com/photos");
            var content = await response.Content.ReadAsStringAsync();

            return content;
        }
    }

    public class Pararellism
    {
        public void Test()
        {
            var values= Enumerable.Range(1,100);
            Parallel.ForEach(values,value=>Console.WriteLine($"Number: {value} on {Thread.CurrentThread.ManagedThreadId}"));
        }

    }
}