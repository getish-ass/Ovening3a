using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    abstract class UserError
    {
        public abstract string UEMessage();

    }
    class NumericInputError : UserError
    {
      // private string error;
      // public NumericInputError()
      // {
      //     error = "First error";
      // }
        public override string UEMessage()
        {
            return "You tried to use a numeric input in a text only field";
        }

    }
    class TextInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a text input in a numeric only. This fires error";
        }
    }
    class LongLengthInputError : UserError
    {
        public override string UEMessage()
        {
            return "You wrote more than the limitted number of character.";
        }
    }
    class ShortLengthInputError : UserError
    {
        public override string UEMessage()
        {
            return "You entered less character than the limmit.";
        }
    }
    class WrongInputError : UserError
    {
        public override string UEMessage()
        {
            return "You entered a wrong input";
        }
    }
}
