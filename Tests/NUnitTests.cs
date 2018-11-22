using dotNetCore.Models;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
 

        [Test]
        public void Test1()
        {
           var user=new User("mateuszmajer1992@gmail.com","secret");;
        }
    }
}