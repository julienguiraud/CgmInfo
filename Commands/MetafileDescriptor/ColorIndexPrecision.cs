﻿using CgmInfo.Traversal;

namespace CgmInfo.Commands.MetafileDescriptor
{
    public class ColorIndexPrecision : Command
    {
        public ColorIndexPrecision(int precision)
            : base(1, 8)
        {
            Precision = precision;
        }

        public int Precision { get; private set; }

        public override void Accept<T>(ICommandVisitor<T> visitor, T parameter)
        {
            visitor.AcceptMetafileDescriptorColorIndexPrecision(this, parameter);
        }
    }
}
