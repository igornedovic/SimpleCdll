using System.Runtime.InteropServices;

namespace Wrapper
{
    public class ConnectSessionWrapper
    {
        [DllImport("CLibrary.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern void ConnectSession(uint sessionNumber);

        public static void SetConnectSession(uint sessionNumber)
        {
            ConnectSession(sessionNumber);
        }
    }
}