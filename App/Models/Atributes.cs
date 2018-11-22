using System;
using System.Linq;
using System.Reflection;
using System.Dynamic;

namespace dotNetCore.Models
{
    [AttributeUsage(AttributeTargets.Property)]
    public class UserPasswordAttribute : Attribute
    {
        public int Length { get; }
        public UserPasswordAttribute(int length)
        {
            Length = length;
        }
    }
}