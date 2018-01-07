using System;
using System.Collections.Generic;
using System.Linq;

namespace ClientLibrary.Models.Results
{
    public class SpawnResult : IResult
    {
        public const string AlreadySpawningError = "AlreadySpawningError";
        public const string NotEnoughEnergyError = "NotEnoughEnergyError";

        public bool Success { get; set; }
        public Exception Exception { get; set; }
        public string HumanReadableError { get; set; }
        private string _spawnError;

        public string SpawnError
        {
            get => _spawnError;
            set
            {
                switch (value)
                {
                    case AlreadySpawningError:
                    case NotEnoughEnergyError:
                        _spawnError = value;
                        break;
                    default:
                        throw new Exception("Invalid Spawn Error!");
                }
            }
        }
    }
}