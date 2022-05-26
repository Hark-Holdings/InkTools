#if CSHARP_7_3_OR_NEWER
using System;
using System.Runtime.InteropServices;

namespace InkTools
{

    [StructLayout(LayoutKind.Sequential, Pack = 0)]
    [Serializable]
#endif

    /// <summary>
    /// A particle of ink.  Includes several channels, where 0 = no ink and 
    /// 1 = full ink.  For example, _Fire = 0 means there's no fire and 
    /// _Fire = 1 means the particle is full of maximum intensity fire.
    /// The color overrides are exceptional, as they refer to specific
    /// colors in the final rendering, rather than inks.  Even if _Fire = 1,
    /// the final particle color may appear green if _Green = 1.
    /// </summary>
    public struct InkParticle
    {

        public InkFloat _Air;
        public InkFloat _BlackBody;
        public InkFloat _Dust;
        public InkFloat _Electricity;
        public InkFloat _Fire;
        public InkFloat _Glitter;
        public InkFloat _Ice;
        public InkFloat _Metal;
        public InkFloat _Plant;
        public InkFloat _Steam;
        public InkFloat _Water;

        public InkFloat _Red;
        public InkFloat _Green;
        public InkFloat _Blue;
        public InkFloat _Alpha;

#if CSHARP_7_3_OR_NEWER

    }   // InkParticle

}   // InkTools

#else

    };  // InkParticle

#endif