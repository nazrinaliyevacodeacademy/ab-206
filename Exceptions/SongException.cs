using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music.Exceptions;

public class SongException:Exception
{
    public SongException(string message) : base(message)
    {

    }
}
