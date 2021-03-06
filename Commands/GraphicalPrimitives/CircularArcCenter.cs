using System.Drawing;
using CgmInfo.Traversal;

namespace CgmInfo.Commands.GraphicalPrimitives
{
    public class CircularArcCenter : Command
    {
        public CircularArcCenter(PointF center, PointF start, PointF end, double radius)
            : base(4, 15)
        {
            Center = center;
            Start = start;
            End = end;
            Radius = radius;
        }

        public PointF Center { get; private set; }
        public PointF Start { get; private set; }
        public PointF End { get; private set; }
        public double Radius { get; private set; }

        public override void Accept<T>(ICommandVisitor<T> visitor, T parameter)
        {
            visitor.AcceptGraphicalPrimitiveCircularArcCenter(this, parameter);
        }
    }
}
