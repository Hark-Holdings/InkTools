#if CSHARP_7_3_OR_NEWER
using System;
using System.Runtime.InteropServices;

namespace InkTools
{

    [StructLayout(LayoutKind.Sequential, Pack = 0)]
    [Serializable]
#endif

    /// <summary>
    /// The center of mass for each ink.  Contains both the Center (relative
    /// to _Position) and the Mass of each ink.  Primarily used for sensory
    /// or perceptin data for gameplay logic.
    /// </summary>
    public struct InkCenterOfMass
    {

        public InkDouble2 _Position;    

        public InkFloat2  _AirCenter;
        public InkFloat2  _BlackBodyCenter;       
        public InkFloat2  _DustCenter;
        public InkFloat2  _ElectricityCenter;
        public InkFloat2  _FireCenter;            
        public InkFloat2  _GlitterCenter;         
        public InkFloat2  _IceCenter;
        public InkFloat2  _MetalCenter;
        public InkFloat2  _PlantCenter;           
        public InkFloat2  _SteamCenter;           
        public InkFloat2  _WaterCenter;
        
        public InkFloat2  _RedCenter;             
        public InkFloat2  _GreenCenter;           
        public InkFloat2  _BlueCenter;            
        public InkFloat2  _AlphaCenter;
        
        public InkFloat   _AirMass;
        public InkFloat   _BlackBodyMass;         
        public InkFloat   _DustMass;
        public InkFloat   _ElectricityMass;
        public InkFloat   _FireMass;              
        public InkFloat   _GlitterMass;           
        public InkFloat   _IceMass;
        public InkFloat   _MetalMass;
        public InkFloat   _PlantMass;             
        public InkFloat   _SteamMass;             
        public InkFloat   _WaterMass;
        
        public InkFloat   _RedMass;               
        public InkFloat   _GreenMass;             
        public InkFloat   _BlueMass;              
        public InkFloat   _AlphaMass;             

#if CSHARP_7_3_OR_NEWER

    }   // InkCenterOfMass

}   // InkTools

#else

    };  // InkCenterOfMass

#endif