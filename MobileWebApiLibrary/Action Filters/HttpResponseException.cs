using Microsoft.AspNetCore.Mvc;
using System;

namespace MobileWebApiLibrary.Action_Filters
{
    public class HttpResponseException : Exception
    {
        public int Status { get; set; } = 500;

        public ProblemDetails Value { get; set; }
    }
}