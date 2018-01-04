using System;
using System.Runtime.InteropServices;
using System.Security;

namespace WindowBeginningEduGame
{
    public static class SecurityStringHelper
    {

        /// <summary>
        /// Unsecures a <see cref="SecureString"/> to plain text
        /// </summary>
        /// <param name="secureString"></param>
        /// <returns></returns>
        public static string Unsecure(this SecureString secureString)
        {
            //Make sure we have a secure string
            if(null == secureString)
            {
                return string.Empty;
            }

            //Get a pointer for an unsecure string in memory
            var unmaginedString = IntPtr.Zero;

            try
            {
                //Unsecures the password
                unmaginedString = Marshal.SecureStringToGlobalAllocUnicode(secureString);
                return Marshal.PtrToStringUni(unmaginedString);
            }
            finally
            {
                //Clean up the allocated memory
                Marshal.ZeroFreeGlobalAllocUnicode(unmaginedString);
            }
        }
    }
}
