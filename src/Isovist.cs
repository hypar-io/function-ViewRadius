using Elements;
using Elements.Geometry;
using Elements.Geometry.Solids;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ViewRadius
{
    public class Isovist : MeshElement
    {

        public double Score { get; set; }
        public Isovist(Mesh mesh) : base(mesh, null, new Material(new Color(0.6, 0.6, 0.6, 0.6), 0, 0, true, null, true, false, null, false, null, 0, false, Guid.NewGuid(), "WhiteBaseMaterial"))
        {

        }
    }
}