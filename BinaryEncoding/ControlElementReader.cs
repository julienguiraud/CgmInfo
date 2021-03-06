using CgmInfo.Commands.Enums;
using CgmInfo.Commands.MetafileDescriptor;

namespace CgmInfo.BinaryEncoding
{
    // [ISO/IEC 8632-3 8.5]
    internal static class ControlElementReader
    {
        public static VdcIntegerPrecision VdcIntegerPrecision(MetafileReader reader, CommandHeader commandHeader)
        {
            // P1: (integer) VDC integer precision; legal values are 16, 24 or 32; the value 8 is not permitted.
            return new VdcIntegerPrecision(reader.ReadInteger());
        }

        public static VdcRealPrecision VdcRealPrecision(MetafileReader reader, CommandHeader commandHeader)
        {
            // P1: (enumerated) form of representation for real values: valid values are
            //      0 floating point format
            //      1 fixed point format
            // P2: (integer) field width for exponent or whole part (including 1 bit for sign)
            // P3: (integer) field width for fraction or fractional part
            return new VdcRealPrecision(reader.ReadEnum<RealRepresentation>(), reader.ReadInteger(), reader.ReadInteger());
        }

        public static AuxiliaryColor AuxiliaryColor(MetafileReader reader, CommandHeader commandHeader)
        {
            // P1: (colour) auxiliary colour
            return new AuxiliaryColor(reader.ReadColor());
        }

        public static Transparency Transparency(MetafileReader reader, CommandHeader commandHeader)
        {
            // P1: (enumerated) on - off indicator: valid values are
            //      0 off: auxiliary colour background is required
            //      1 on: transparent background is required
            return new Transparency(reader.ReadEnum<OnOffIndicator>());
        }

        public static ClipRectangle ClipRectangle(MetafileReader reader, CommandHeader commandHeader)
        {
            // P1: (point) first corner
            // P2: (point) second corner
            return new ClipRectangle(reader.ReadPoint(), reader.ReadPoint());
        }

        public static ClipIndicator ClipIndicator(MetafileReader reader, CommandHeader commandHeader)
        {
            // P1: (enumerated) clip indicator: valid values are
            //      0 off
            //      1 on
            return new ClipIndicator(reader.ReadEnum<OnOffIndicator>());
        }

        public static LineClippingMode LineClippingMode(MetafileReader reader, CommandHeader commandHeader)
        {
            // P1: (enumerated) clipping mode: valid values are
            //      0 locus
            //      1 shape
            //      2 locus then shape
            return new LineClippingMode(reader.ReadEnum<ClippingMode>());
        }

        public static MarkerClippingMode MarkerClippingMode(MetafileReader reader, CommandHeader commandHeader)
        {
            // P1: (enumerated) clipping mode: valid values are
            //      0 locus
            //      1 shape
            //      2 locus then shape
            return new MarkerClippingMode(reader.ReadEnum<ClippingMode>());
        }

        public static EdgeClippingMode EdgeClippingMode(MetafileReader reader, CommandHeader commandHeader)
        {
            // P1: (enumerated) clipping mode: valid values are
            //      0 locus
            //      1 shape
            //      2 locus then shape
            return new EdgeClippingMode(reader.ReadEnum<ClippingMode>());
        }

        public static NewRegion NewRegion(MetafileReader reader, CommandHeader commandHeader)
        {
            // NEW REGION: has no parameters
            return new NewRegion();
        }

        public static SavePrimitiveContext SavePrimitiveContext(MetafileReader reader, CommandHeader commandHeader)
        {
            // P1: (name) context name
            return new SavePrimitiveContext(reader.ReadName());
        }

        public static RestorePrimitiveContext RestorePrimitiveContext(MetafileReader reader, CommandHeader commandHeader)
        {
            // P1: (name) context name
            return new RestorePrimitiveContext(reader.ReadName());
        }

        public static ProtectionRegionIndicator ProtectionRegionIndicator(MetafileReader reader, CommandHeader commandHeader)
        {
            // P1: (index) region index
            // P2: (index) region indicator: valid values are
            //      1 off
            //      2 clip
            //      3 shield
            return new ProtectionRegionIndicator(reader.ReadIndex(), reader.ReadEnum<RegionIndicator>());
        }

        public static GeneralizedTextPathMode GeneralizedTextPathMode(MetafileReader reader, CommandHeader commandHeader)
        {
            // P1: (enumerated) text path mode: valid values are
            //      0 off
            //      1 non - tangential
            //      2 axis - tangential
            return new GeneralizedTextPathMode(reader.ReadEnum<TextPathMode>());
        }

        public static MiterLimit MiterLimit(MetafileReader reader, CommandHeader commandHeader)
        {
            // P1: (real) mitre limit
            return new MiterLimit(reader.ReadReal());
        }
    }
}
