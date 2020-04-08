using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace BmsRestApi.Messages.Response
{
    public class ResponseBase
    {
        public ResponseBase()
        {
            Messages = new List<String>();
        }
        public HttpStatusCode StatusCode { get; set; }

        public List<String> Messages { get; set; }
    }
}
