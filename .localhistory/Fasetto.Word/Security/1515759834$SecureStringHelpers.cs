using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Fasetto.Word
{
    /// <summary>
    /// Helpers for the <see cref="SecureString"/> class
    /// </summary>
    public static class SecureStringHelpers
    {
        /// <summary>
        /// Unsecures a <see cref="SecureString"/> to plain text
        /// </summary>
        /// <param name="p_secureString">The secure string</param>
        /// <returns></returns>
        public static string Unsecure(this SecureString p_secureString)
        {
            // Make sure we have a secure string
            if (p_secureString == null)
                return string.Empty;
        }
    }
}
