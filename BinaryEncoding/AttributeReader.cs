using CgmInfo.Commands.Attributes;
using CgmInfo.Commands.Enums;

namespace CgmInfo.BinaryEncoding
{
    // [ISO/IEC 8632-3 8.7]
    internal static class AttributeReader
    {
        public static LineBundleIndex LineBundleIndex(MetafileReader reader, CommandHeader commandHeader)
        {
            // P1: (index) line bundle index
            return new LineBundleIndex(reader.ReadIndex());
        }

        public static LineType LineType(MetafileReader reader, CommandHeader commandHeader)
        {
            // P1: (index) line type: the following values are standardized:
            //      1 solid
            //      2 dash
            //      3 dot
            //      4 dash-dot
            //      5 dash-dot-dot
            //      >5 reserved for registered values
            //      negative for private use
            return new LineType(reader.ReadIndex());
        }

        public static LineWidth LineWidth(MetafileReader reader, CommandHeader commandHeader)
        {
            // P1: (size specification) line width: see Part 1, subclause 7.1 for its form.
            //      line width is affected by LINE WIDTH SPECIFICATION MODE
            return new LineWidth(reader.ReadSizeSpecification(reader.Descriptor.LineWidthSpecificationMode));
        }

        public static LineColor LineColor(MetafileReader reader, CommandHeader commandHeader)
        {
            // P1: (colour) line colour
            return new LineColor(reader.ReadColor());
        }

        public static MarkerBundleIndex MarkerBundleIndex(MetafileReader reader, CommandHeader commandHeader)
        {
            // P1: (index) marker bundle index
            return new MarkerBundleIndex(reader.ReadIndex());
        }

        public static MarkerType MarkerType(MetafileReader reader, CommandHeader commandHeader)
        {
            // P1: (index) marker type: the following values are standardized:
            //      1 dot
            //      2 plus
            //      3 asterisk
            //      4 circle
            //      5 cross
            //      >5 reserved for registered values
            //      negative for private use
            return new MarkerType(reader.ReadIndex());
        }

        public static MarkerSize MarkerSize(MetafileReader reader, CommandHeader commandHeader)
        {
            // P1: (size specification) marker size: see Part 1, subclause 7.1 for its form.
            //      marker size is affected by MARKER SIZE SPECIFICATION MODE
            return new MarkerSize(reader.ReadSizeSpecification(reader.Descriptor.MarkerSizeSpecificationMode));
        }

        public static MarkerColor MarkerColor(MetafileReader reader, CommandHeader commandHeader)
        {
            // P1: (colour) marker colour
            return new MarkerColor(reader.ReadColor());
        }

        public static TextBundleIndex TextBundleIndex(MetafileReader reader, CommandHeader commandHeader)
        {
            // P1: (index) text bundle index
            return new TextBundleIndex(reader.ReadIndex());
        }

        public static TextFontIndex TextFontIndex(MetafileReader reader, CommandHeader commandHeader)
        {
            // P1: (index) text font index
            return new TextFontIndex(reader.ReadIndex());
        }

        public static TextPrecision TextPrecision(MetafileReader reader, CommandHeader commandHeader)
        {
            // P1: (enumerated) text precision: valid values are
            //      0 string
            //      1 character
            //      2 stroke
            return new TextPrecision(reader.ReadEnum<TextPrecisionType>());
        }

        public static CharacterExpansionFactor CharacterExpansionFactor(MetafileReader reader, CommandHeader commandHeader)
        {
            // P1: (real) character expansion factor
            return new CharacterExpansionFactor(reader.ReadReal());
        }

        public static CharacterSpacing CharacterSpacing(MetafileReader reader, CommandHeader commandHeader)
        {
            // P1: (real) additional inter-character space
            return new CharacterSpacing(reader.ReadReal());
        }

        public static TextColor TextColor(MetafileReader reader, CommandHeader commandHeader)
        {
            // P1: (colour) text colour
            return new TextColor(reader.ReadColor());
        }

        public static CharacterHeight CharacterHeight(MetafileReader reader, CommandHeader commandHeader)
        {
            // P1: (vdc) character height
            return new CharacterHeight(reader.ReadVdc());
        }
    }
}
