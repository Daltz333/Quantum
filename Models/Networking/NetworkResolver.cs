using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quantum.Models.Networking
{
    public class NetworkResolver
    {
        /// <summary>
        /// Attempts to resolve an IP through several strategies <br/>
        /// 1. Check for dotted quad, attempt to resolve directly <br/>
        /// 2. Check if URL or team number, resolve IP <br/>
        /// 3. If team number, use MDNS or fallback to TEAM notation <br/>
        /// </summary>
        /// <param name="toResolve">Input to resolve IP for</param>
        /// <returns></returns>
        public async Task<(bool, string)> TryRetrieveIp(string toResolve)
        {
            throw new NotImplementedException();
        }
    }
}
