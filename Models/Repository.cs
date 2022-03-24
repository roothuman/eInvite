using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eInvite.Models
{
    public class Repository
    {
        private static List<GetResponse> responses = new List<GetResponse>();
        public static IEnumerable<GetResponse> Responses => responses;
        public static void AddResponse(GetResponse response)
        {
            responses.Add(response);
        }
    }
}
