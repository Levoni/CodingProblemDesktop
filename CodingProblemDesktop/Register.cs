using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblemDesktop
{
    class Register: IEvent
    {
        private const int RegisterInt = 3;
        private const string RegisterString = "Register";
        private const int PatientInt = 5;
        private const string PatientString = "Patient";

        public string ReadIntAndPrint(int curNumber)
        {
            StringBuilder sb = new StringBuilder(string.Empty);

            if (curNumber % RegisterInt == 0 && curNumber % PatientInt == 0)
            {
                sb.Append($"{RegisterString} {PatientString}");
            }
            else if (curNumber % RegisterInt == 0)
            {
                sb.Append(RegisterString);
            }
            else if (curNumber % PatientInt == 0)
            {
                sb.Append(PatientString);
            }
            else
            {
                sb.Append(curNumber.ToString());
            }
            return sb.ToString();
        }

    }
}
