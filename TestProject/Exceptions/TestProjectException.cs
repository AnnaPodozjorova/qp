using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject.Domain.Exceptions
{
    public class TestAppException : Exception
    {
        public TestAppException(string text, Exception ex)
           : base($"\"text\"", ex)
        {
        }
    }
}
