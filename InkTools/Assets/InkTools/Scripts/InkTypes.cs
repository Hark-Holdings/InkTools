using System;
using System.Runtime.InteropServices;
using Double = System.Single;
using Double2 = Unity.Mathematics.float2;
using Half = Unity.Mathematics.half;
using Half2 = Unity.Mathematics.half2;
using Short = System.UInt16;

namespace InkTools
{

    // @TODO: Replace these wrappers with global usings whenever C# 10.0 is
    // supported.


    [StructLayout(LayoutKind.Sequential, Pack = 0)]
    [Serializable]
    /// <summary>
    /// A wrapper around <see cref="Unity.Mathematics.half"/>
    /// </summary>
    public struct InkFloat
    {

        // Wrap the value and constructor so that we only use as a wrapper
        private Half _Value;

        private InkFloat(Half Value)
        {
            this._Value = Value;
        }

        /// <summary>
        /// Implicitly converts a <see cref="Unity.Mathematics.half"/> to a
        /// InkFloat.
        /// </summary>
        /// <param name="Value">
        /// The <see cref="Unity.Mathematics.half"/> to convert.
        /// </param>
        /// <returns>
        /// A new InkFloat with the specified value.
        /// </returns>
        public static implicit operator InkFloat(Half Value)
        {
            return new InkFloat(Value);
        }

    }   // InkFloat

    [StructLayout(LayoutKind.Sequential, Pack = 0)]
    [Serializable]
    /// <summary>
    /// A wrapper around <see cref="Unity.Mathematics.half2"/>
    /// </summary>
    public struct InkFloat2
    {
        // Wrap the value and constructor so that we only use as a wrapper
        private Half2 _Value;

        private InkFloat2(Half2 Value)
        {
        this._Value = Value;
        }

        /// <summary>
        /// Implicitly converts a <see cref="Unity.Mathematics.half2"/> to a
        /// InkFloat2.
        /// </summary>
        /// <param name="Value">
        /// The <see cref="Unity.Mathematics.half2"/> to convert.
        /// </param>
        /// <returns>
        /// A new InkFloat2 with the specified value.
        /// </returns>
        public static implicit operator InkFloat2(Half2 Value)
        {
        return new InkFloat2(Value);
        }
    }   // InkFloat2

    [StructLayout(LayoutKind.Sequential, Pack = 0)]
    [Serializable]
    /// <summary>
    /// A wrapper around <see cref="System.Single"/>
    /// </summary>
    public struct InkDouble
    {
        // Wrap the value and constructor so that we only use as a wrapper
        private Double _Value;

        private InkDouble(Double Value)
        {
        this._Value = Value;
        }

        /// <summary>
        /// Implicitly converts a <see cref="System.Single"/> to a
        /// InkDouble.
        /// </summary>
        /// <param name="Value">
        /// The <see cref="System.Single"/> to convert.
        /// </param>
        /// <returns>
        /// A new InkDouble with the specified value.
        /// </returns>
        public static implicit operator InkDouble(Double Value)
        {
        return new InkDouble(Value);
        }
    }   // InkDouble

    [StructLayout(LayoutKind.Sequential, Pack = 0)]
    [Serializable]
    /// <summary>
    /// A wrapper around <see cref="Unity.Mathematics.float2"/>
    /// </summary>
    public struct InkDouble2
    {
        // Wrap the value and constructor so that we only use as a wrapper
        private Double2 _Value;

        private InkDouble2(Double2 Value)
        {
        this._Value = Value;
        }

        /// <summary>
        /// Implicitly converts a <see cref="Unity.Mathematics.float2"/> to a
        /// InkDouble2.
        /// </summary>
        /// <param name="Value">
        /// The <see cref="Unity.Mathematics.float2"/> to convert.
        /// </param>
        /// <returns>
        /// A new InkDouble2 with the specified value.
        /// </returns>
        public static implicit operator InkDouble2(Double2 Value)
        {
        return new InkDouble2(Value);
        }
    }   // InkDouble2

    [StructLayout(LayoutKind.Sequential, Pack = 0)]
    [Serializable]
    /// <summary>
    /// A wrapper around <see cref="System.UInt16"/>
    /// </summary>
    public struct InkShort
    {
        // Wrap the value and constructor so that we only use as a wrapper
        private Short _Value;

        private InkShort(Short Value)
        {
        this._Value = Value;
        }

        /// <summary>
        /// Implicitly converts a <see cref="System.UInt16"/> to a
        /// InkShort.
        /// </summary>
        /// <param name="Value">
        /// The <see cref="System.UInt16"/> to convert.
        /// </param>
        /// <returns>
        /// A new InkShort with the specified value.
        /// </returns>
        public static implicit operator InkShort(Short Value)
        {
        return new InkShort(Value);
        }
    }   // InkShort

}   // InkTools