using System;

namespace InkTools
{

    [Serializable]
    /// <summary>
    /// Container for a variety of inputs that add particles to the 
    /// simulation.  Different parameters are passed to the simulation
    /// depending on the type and shape of particles to add.
    /// </summary>
    public struct InkParticleInput
    {

        [Serializable]
        public enum InkInputType
        {
            NoInput
        ,   AddParticles
        ,   AddParticlesByMask
        ,   AddVelocity
        ,   AddObstacleCircle
        ,   AddObstacleTriangle
        ,   AddSeed
        }   // InkInputType

        public InkInputType _Type;
        public InkParticle  _Particle;
        public InkFloat2    _Velocity;
        public InkFloat     _Divergence;
        public InkFloat     _Pressure;
        public InkFloat2    _Obstacle;
        public InkFloat     _Vorticity;
        public InkFloat2    _Force;
        public InkDouble2   _Position;
        public InkFloat2    _Direction;
        public InkFloat     _Radius;
        public InkFloat2    _Point1;
        public InkFloat2    _Point2;
        public InkFloat2    _Point3;

    }   // InkParticleInput

}   // InkTools
