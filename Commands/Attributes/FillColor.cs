using CgmInfo.Traversal;
using CgmInfo.Utilities;

namespace CgmInfo.Commands.Attributes
{
    public class FillColor : Command
    {
        public FillColor(MetafileColor color)
            : base(5, 23)
        {
            Color = color;
        }

        public MetafileColor Color { get; private set; }

        public override void Accept<T>(ICommandVisitor<T> visitor, T parameter)
        {
            visitor.AcceptAttributeFillColor(this, parameter);
        }
    }
}
