using System.Linq;
using CgmInfo.Commands;
using CgmInfo.Commands.Delimiter;
using CgmInfo.Commands.Enums;
using CgmInfo.Commands.MetafileDescriptor;
using CgmInfo.Traversal;

namespace CgmInfoCmd
{
    public class PrintCommandVisitor : ICommandVisitor<PrintContext>
    {
        public void AcceptDelimiterBeginMetafile(BeginMetafile beginMetafile, PrintContext parameter)
        {
            parameter.WriteLine("{0} - {1}", parameter.FileName, beginMetafile.Name);
            parameter.BeginLevel();
        }
        public void AcceptDelimiterEndMetafile(EndMetafile endMetafile, PrintContext parameter)
        {
            parameter.EndLevel();
        }
        public void AcceptDelimiterBeginPicture(BeginPicture beginPicture, PrintContext parameter)
        {
            parameter.WriteLine("Begin Picture: '{0}'", beginPicture.Name);
            parameter.BeginLevel();
        }
        public void AcceptDelimiterBeginPictureBody(BeginPictureBody beginPictureBody, PrintContext parameter)
        {
            parameter.WriteLine("Begin Picture Body");
        }
        public void AcceptDelimiterEndPicture(EndPicture endPicture, PrintContext parameter)
        {
            parameter.EndLevel();
        }
        public void AcceptDelimiterBeginSegment(BeginSegment beginSegment, PrintContext parameter)
        {
            parameter.WriteLine("Begin Segment: '{0}'", beginSegment.Identifier);
            parameter.BeginLevel();
        }
        public void AcceptDelimiterEndSegment(EndSegment endSegment, PrintContext parameter)
        {
            parameter.EndLevel();
        }
        public void AcceptDelimiterBeginFigure(BeginFigure beginFigure, PrintContext parameter)
        {
            parameter.WriteLine("Begin Figure");
            parameter.BeginLevel();
        }
        public void AcceptDelimiterEndFigure(EndFigure endFigure, PrintContext parameter)
        {
            parameter.EndLevel();
        }
        public void AcceptDelimiterBeginProtectionRegion(BeginProtectionRegion beginProtectionRegion, PrintContext parameter)
        {
            parameter.WriteLine("Begin Protection Region: {0}", beginProtectionRegion.RegionIndex);
            parameter.BeginLevel();
        }
        public void AcceptDelimiterEndProtectionRegion(EndProtectionRegion endProtectionRegion, PrintContext parameter)
        {
            parameter.EndLevel();
        }

        public void AcceptMetafileDescriptorMetafileVersion(MetafileVersion metafileVersion, PrintContext parameter)
        {
            parameter.WriteLine("Metafile Version: {0}", metafileVersion.Version);
        }
        public void AcceptMetafileDescriptorMetafileDescription(MetafileDescription metafileDescription, PrintContext parameter)
        {
            parameter.WriteLine("Metafile Description: {0}", metafileDescription.Description);
        }
        public void AcceptMetafileDescriptorVdcType(VdcType vdcType, PrintContext parameter)
        {
            parameter.WriteLine("VDC Type: {0}", vdcType.Specification);
        }
        public void AcceptMetafileDescriptorIntegerPrecision(IntegerPrecision integerPrecision, PrintContext parameter)
        {
            parameter.WriteLine("Integer Precision: {0} bit", integerPrecision.Precision);
        }
        public void AcceptMetafileDescriptorRealPrecision(RealPrecision realPrecision, PrintContext parameter)
        {
            if (realPrecision.Specification == RealPrecisionSpecification.Unsupported)
                parameter.WriteLine("Real Precision: Unsupported ({0}, {1} bit Exponent width, {2} bit Fraction width)",
                    realPrecision.RepresentationForm, realPrecision.ExponentWidth, realPrecision.FractionWidth);
            else
                parameter.WriteLine("Real Precision: {0}", realPrecision.Specification);
        }
        public void AcceptMetafileDescriptorIndexPrecision(IndexPrecision indexPrecision, PrintContext parameter)
        {
            parameter.WriteLine("Index Precision: {0} bit", indexPrecision.Precision);
        }
        public void AcceptMetafileDescriptorColorPrecision(ColorPrecision colorPrecision, PrintContext parameter)
        {
            parameter.WriteLine("Color Precision: {0} bit", colorPrecision.Precision);
        }
        public void AcceptMetafileDescriptorColorIndexPrecision(ColorIndexPrecision colorIndexPrecision, PrintContext parameter)
        {
            parameter.WriteLine("Color Index Precision: {0} bit", colorIndexPrecision.Precision);
        }
        public void AcceptMetafileDescriptorMaximumColorIndex(MaximumColorIndex maximumColorIndex, PrintContext parameter)
        {
            parameter.WriteLine("Maximum Color Index: {0}", maximumColorIndex.Index);
        }
        public void AcceptMetafileDescriptorColorValueExtent(ColorValueExtent colorValueExtent, PrintContext parameter)
        {
            if (colorValueExtent.ColorSpace == ColorSpace.Unknown)
                parameter.WriteLine("Color Value Extent: Unknown Color Space");
            else if (colorValueExtent.ColorSpace == ColorSpace.CIE)
                parameter.WriteLine("Color Value Extent: CIE {0}/{1}/{2}",
                    colorValueExtent.FirstComponent, colorValueExtent.SecondComponent, colorValueExtent.ThirdComponent);
            else // RGB or CMYK
                parameter.WriteLine("Color Value Extent: {0} {1}/{2}",
                    colorValueExtent.ColorSpace, colorValueExtent.Minimum, colorValueExtent.Maximum);
        }
        public void AcceptMetafileDescriptorFontList(FontList fontList, PrintContext parameter)
        {
            parameter.WriteLine("Font List: {0} entries", fontList.Fonts.Count());
            parameter.BeginLevel();
            foreach (string font in fontList.Fonts)
                parameter.WriteLine(font);
            parameter.EndLevel();
        }
        public void AcceptMetafileDescriptorNamePrecision(NamePrecision namePrecision, PrintContext parameter)
        {
            parameter.WriteLine("Name Precision: {0} bit", namePrecision.Precision);
        }
        public void AcceptMetafileDescriptorMaximumVdcExtent(MaximumVdcExtent maximumVdcExtent, PrintContext parameter)
        {
            parameter.WriteLine("Maximum VDC Extent: {0} - {1}", maximumVdcExtent.FirstCorner, maximumVdcExtent.SecondCorner);
        }
        public void AcceptMetafileDescriptorColorModel(ColorModelCommand colorModel, PrintContext parameter)
        {
            parameter.WriteLine("Color Model: {0}", colorModel.ColorModel);
        }

        public void AcceptUnsupportedCommand(UnsupportedCommand unsupportedCommand, PrintContext parameter)
        {
            // do nothing; otherwise we'd probably spam the command line
        }
    }
}
