using CgmInfo.Commands.Enums;
using CgmInfo.Traversal;

namespace CgmInfo.Commands.MetafileDescriptor
{
    public class ClipIndicator : Command
    {
        public ClipIndicator(OnOffIndicator indicator)
            : base(3, 6)
        {
            Indicator = indicator;
        }

        public OnOffIndicator Indicator { get; private set; }

        public override void Accept<T>(ICommandVisitor<T> visitor, T parameter)
        {
            visitor.AcceptControlClipIndicator(this, parameter);
        }
    }
}
