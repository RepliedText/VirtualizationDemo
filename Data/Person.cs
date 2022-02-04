﻿using System.Reflection;

namespace DummyBlazorServerApp.Data
{
    public class Person
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
    }
    public enum Gender
    {
        Male, Female, Other
    }
}
