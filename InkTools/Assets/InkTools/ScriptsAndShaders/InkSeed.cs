#if CSHARP_7_3_OR_NEWER
using System;
using System.Runtime.InteropServices;

namespace InkTools
{

    [StructLayout(LayoutKind.Sequential, Pack = 0)]
    [Serializable]
#endif

    /// <summary>
    /// A seed for plant growth, lighting strikes, and similar effects that
    /// originate from a point.  Contains an initial Position, Direction of
    /// growth, combined Force applied to the object, total Size (in pixels)
    /// of the object, and the Type of the grown object.
    /// </summary>
    public struct InkSeed
    {
        public InkDouble2 _Position;
        public InkFloat2  _Direction;
        public InkFloat2  _Force;
        public InkShort   _Size;
        public InkShort   _Type;

#if CSHARP_7_3_OR_NEWER

    }   // InkSeed

}   // InkTools

#else

    };  // InkSeed

#endif