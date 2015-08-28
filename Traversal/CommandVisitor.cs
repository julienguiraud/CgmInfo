using CgmInfo.Commands;
using CgmInfo.Commands.ApplicationStructureDescriptor;
using CgmInfo.Commands.Delimiter;
using CgmInfo.Commands.GraphicalPrimitives;
using CgmInfo.Commands.MetafileDescriptor;

namespace CgmInfo.Traversal
{
    /// <summary>
    /// Base class for <see cref="ICommandVisitor{T}"/> providing no-op implementations
    /// for easier/cleaner overriding of methods necessary for derived logic.
    /// </summary>
    /// <typeparam name="T">Any parameter type to be passed back by the visited classes</typeparam>
    public abstract class CommandVisitor<T> : ICommandVisitor<T>
    {
        #region Application Structure Descriptor elements
        public virtual void AcceptApplicationStructureDescriptorAttribute(ApplicationStructureAttribute applicationStructureAttribute, T parameter)
        {
            // intentionally left blank
        }
        #endregion

        #region Delimiter elements
        public virtual void AcceptDelimiterBeginApplicationStructure(BeginApplicationStructure beginApplicationStructure, T parameter)
        {
            // intentionally left blank
        }

        public virtual void AcceptDelimiterBeginApplicationStructureBody(BeginApplicationStructureBody beginApplicationStructureBody, T parameter)
        {
            // intentionally left blank
        }

        public virtual void AcceptDelimiterBeginCompoundLine(BeginCompoundLine beginCompoundLine, T parameter)
        {
            // intentionally left blank
        }

        public virtual void AcceptDelimiterBeginCompoundTextPath(BeginCompoundTextPath beginCompoundTextPath, T parameter)
        {
            // intentionally left blank
        }

        public virtual void AcceptDelimiterBeginFigure(BeginFigure beginFigure, T parameter)
        {
            // intentionally left blank
        }

        public virtual void AcceptDelimiterBeginMetafile(BeginMetafile beginMetafile, T parameter)
        {
            // intentionally left blank
        }

        public virtual void AcceptDelimiterBeginPicture(BeginPicture beginPicture, T parameter)
        {
            // intentionally left blank
        }

        public virtual void AcceptDelimiterBeginPictureBody(BeginPictureBody beginPictureBody, T parameter)
        {
            // intentionally left blank
        }

        public virtual void AcceptDelimiterBeginProtectionRegion(BeginProtectionRegion beginProtectionRegion, T parameter)
        {
            // intentionally left blank
        }

        public virtual void AcceptDelimiterBeginSegment(BeginSegment beginSegment, T parameter)
        {
            // intentionally left blank
        }

        public virtual void AcceptDelimiterBeginTileArray(BeginTileArray beginTileArray, T parameter)
        {
            // intentionally left blank
        }

        public virtual void AcceptDelimiterEndApplicationStructure(EndApplicationStructure endApplicationStructure, T parameter)
        {
            // intentionally left blank
        }

        public virtual void AcceptDelimiterEndCompoundLine(EndCompoundLine endCompoundLine, T parameter)
        {
            // intentionally left blank
        }

        public virtual void AcceptDelimiterEndCompoundTextPath(EndCompoundTextPath endCompoundTextPath, T parameter)
        {
            // intentionally left blank
        }

        public virtual void AcceptDelimiterEndFigure(EndFigure endFigure, T parameter)
        {
            // intentionally left blank
        }

        public virtual void AcceptDelimiterEndMetafile(EndMetafile endMetafile, T parameter)
        {
            // intentionally left blank
        }

        public virtual void AcceptDelimiterEndPicture(EndPicture endPicture, T parameter)
        {
            // intentionally left blank
        }

        public virtual void AcceptDelimiterEndProtectionRegion(EndProtectionRegion endProtectionRegion, T parameter)
        {
            // intentionally left blank
        }

        public virtual void AcceptDelimiterEndSegment(EndSegment endSegment, T parameter)
        {
            // intentionally left blank
        }

        public virtual void AcceptDelimiterEndTileArray(EndTileArray endTileArray, T parameter)
        {
            // intentionally left blank
        }
        #endregion

        #region Graphical Primitive elements
        public virtual void AcceptGraphicalPrimitiveAppendText(AppendText appendText, T parameter)
        {
            // intentionally left blank
        }

        public virtual void AcceptGraphicalPrimitiveRestrictedText(RestrictedText restrictedText, T parameter)
        {
            // intentionally left blank
        }

        public virtual void AcceptGraphicalPrimitiveText(TextCommand text, T parameter)
        {
            // intentionally left blank
        }
        #endregion

        #region Metafile Descriptor elements
        public virtual void AcceptMetafileDescriptorCharacterCodingAnnouncer(CharacterCodingAnnouncer characterCodingAnnouncer, T parameter)
        {
            // intentionally left blank
        }

        public virtual void AcceptMetafileDescriptorCharacterSetList(CharacterSetList characterSetList, T parameter)
        {
            // intentionally left blank
        }

        public virtual void AcceptMetafileDescriptorColorIndexPrecision(ColorIndexPrecision colorIndexPrecision, T parameter)
        {
            // intentionally left blank
        }

        public virtual void AcceptMetafileDescriptorColorModel(ColorModelCommand colorModel, T parameter)
        {
            // intentionally left blank
        }

        public virtual void AcceptMetafileDescriptorColorPrecision(ColorPrecision colorPrecision, T parameter)
        {
            // intentionally left blank
        }

        public virtual void AcceptMetafileDescriptorColorValueExtent(ColorValueExtent colorValueExtent, T parameter)
        {
            // intentionally left blank
        }

        public virtual void AcceptMetafileDescriptorFontList(FontList fontList, T parameter)
        {
            // intentionally left blank
        }

        public virtual void AcceptMetafileDescriptorIndexPrecision(IndexPrecision indexPrecision, T parameter)
        {
            // intentionally left blank
        }

        public virtual void AcceptMetafileDescriptorIntegerPrecision(IntegerPrecision integerPrecision, T parameter)
        {
            // intentionally left blank
        }

        public virtual void AcceptMetafileDescriptorMaximumColorIndex(MaximumColorIndex maximumColorIndex, T parameter)
        {
            // intentionally left blank
        }

        public virtual void AcceptMetafileDescriptorMaximumVdcExtent(MaximumVdcExtent maximumVdcExtent, T parameter)
        {
            // intentionally left blank
        }

        public virtual void AcceptMetafileDescriptorMetafileDescription(MetafileDescription metafileDescription, T parameter)
        {
            // intentionally left blank
        }

        public virtual void AcceptMetafileDescriptorMetafileVersion(MetafileVersion metafileVersion, T parameter)
        {
            // intentionally left blank
        }

        public virtual void AcceptMetafileDescriptorNamePrecision(NamePrecision namePrecision, T parameter)
        {
            // intentionally left blank
        }

        public virtual void AcceptMetafileDescriptorRealPrecision(RealPrecision realPrecision, T parameter)
        {
            // intentionally left blank
        }

        public virtual void AcceptMetafileDescriptorVdcType(VdcType vdcType, T parameter)
        {
            // intentionally left blank
        }
        #endregion

        public virtual void AcceptUnsupportedCommand(UnsupportedCommand unsupportedCommand, T parameter)
        {
            // intentionally left blank
        }
    }
}