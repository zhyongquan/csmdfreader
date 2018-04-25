using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace csmdfreader
{

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public class IDBLOCK
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public byte[] FileIdentifier;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public byte[] FormatIdentifier;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public byte[] ProgramIdentifier;
        public ushort ByteOrder;
        public ushort FloatingPointFormat;
        public ushort VersionNumber;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 34)]
        public byte[] Reserved;

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.AppendLine("FileIdentifier:" + Encoding.ASCII.GetString(FileIdentifier));
            str.AppendLine("FormatIdentifier:" + Encoding.ASCII.GetString(FormatIdentifier));
            str.AppendLine("ProgramIdentifier:" + Encoding.ASCII.GetString(ProgramIdentifier));
            return str.ToString();
        }
    }
}
