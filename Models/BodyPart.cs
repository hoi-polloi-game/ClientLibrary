using System;

namespace ClientLibrary.Models
{
    public class BodyPart
    {
        public const string Move = "Move";
        public const string Melee = "Melee";
        public const string Ranged = "Ranged";
        public const string Harvest = "Harvest";
        public const string Carry = "Carry";

        private string _part;
        public string Part
        {
            get => _part;
            set
            {
                switch (value)
                {
                    case Move:
                    case Melee:
                    case Ranged:
                    case Harvest:
                    case Carry:
                        _part = value;
                        break;
                    default:
                        throw new Exception("Invalid Body Part!");
                }
            }
        }

    }
}