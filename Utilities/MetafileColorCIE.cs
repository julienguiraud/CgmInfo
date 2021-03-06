using System;
using System.Drawing;
using CgmInfo.Commands.Enums;

namespace CgmInfo.Utilities
{
    public class MetafileColorCIE : MetafileColor
    {
        public ColorModel ColorModel { get; private set; }
        public double Component1 { get; private set; }
        public double Component2 { get; private set; }
        public double Component3 { get; private set; }

        public MetafileColorCIE(ColorModel colorModel, double component1, double component2, double component3)
        {
            ColorModel = colorModel;
            Component1 = component1;
            Component2 = component2;
            Component3 = component3;
        }
        public override Color GetColor()
        {
            // CIELAB/CIELUV/RGB-related are not exactly .NET Color values, and need to be converted first.
            // TODO: actually convert them to RGB (using CIEXYZ for example, [ISO/IEC 8632-1 Annex G])
            throw new NotSupportedException("CIE* Color Model conversions are not supported right now, sorry.");
        }
        protected override string GetStringValue()
        {
            return string.Format("{0} {1}/{2}/{3}", ColorModel, Component1, Component2, Component3);
        }
    }
}
