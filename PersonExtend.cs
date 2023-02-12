using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod;

public static class PersonExtend
{
    /// <summary>
    /// the method that extra added into class "Person" without recompile on it.
    /// </summary>
    /// <param name="person"></param>
    public static void Playing(this Person person)
    {
        Console.WriteLine("Person is playing");
    }
}

