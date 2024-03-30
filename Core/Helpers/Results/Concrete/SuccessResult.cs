using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Helpers.Results.Concrete
{
    public class SuccessResult : Result
    {
        public SuccessResult() : base(true)
        {

        }

        public SuccessResult(string message) : base(true, message)
        {

        }

        public SuccessResult(List<string> messages) : base(true, messages)
        {

        }
    }
}
