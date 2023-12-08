using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quantum.Models
{
    public static class AppProperties
    {
        /// <summary>
        /// Application version
        /// </summary>
        public static readonly Version Version = new(2024, 0, 0, 0);

        /// <summary>
        /// Whether we are in release mode or not
        /// </summary>
#if DEBUG
        public const bool IsRelease = false;
#else
        public const bool IsRelease = true;
#endif
    }
}
