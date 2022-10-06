using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace obs_net
{
    public partial class Obs
    {
        [DllImport(importLibrary, CallingConvention = importCall)]
        public static extern int obs_key_from_virtual_key(int code);

        [DllImport(importLibrary, CallingConvention = importCall, CharSet = importCharSet)]
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8StringMarshaler))]
        public static extern string obs_key_to_name(int key);
    }
}
