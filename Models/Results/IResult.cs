using System;
using System.Collections.Generic;
using System.Linq;

namespace ClientLibrary.Models.Results
{
    public interface IResult
    {
        bool Success { get; set; }
        Exception Exception { get; set; }
        string HumanReadableError { get; set; }
    }
}