using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    class EmptyFieldsException : Exception
    {
        public EmptyFieldsException():base("Please enter all necessary fields!")
        {

        }
        public EmptyFieldsException(string messageValue):base(messageValue)
        {

        }
        public EmptyFieldsException(string messageValue, Exception inner):base(messageValue,inner)
        {

        }
    }
}
