using System;
using System.Collections.Generic;
using System.Text;

namespace ClientLibrary.Models.Results
{
    public class PolloiResult : IResult
    {
        public const string InvalidActionError = "InvalidActionError";
        public const string MoveBlockedError = "MoveBlockedError";
        public const string CarryCapacityFullError = "CarryCapacityFullError";

        public bool Success { get; set; }
        public Exception Exception { get; set; }
        public string HumanReadableError { get; set; }
        private string _polloiError;

        public string PolloiError
        {
            get => _polloiError;
            set
            {
                switch (value)
                {
                    case InvalidActionError:
                    case MoveBlockedError:
                    case CarryCapacityFullError:
                        _polloiError = value;
                        break;
                    default:
                        throw new Exception("Invalid Spawn Error!");
                }
            }
        }
    }
}
