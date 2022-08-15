using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Test
{
    public class StringListRequest
    {
        public string key { get; set; }
    }

    public class Response <T>
    {
        public bool status { get; set; }
        public string message { get; set; }
        public T result { get; set; }
    }
}
