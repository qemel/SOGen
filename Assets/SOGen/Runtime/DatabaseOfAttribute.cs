using System;

namespace SOGen.Runtime
{
    [AttributeUsage(AttributeTargets.Class)]
    public class DatabaseOfAttribute : Attribute
    {
        public Type IDType { get; set; }
        public Type DataType { get; set; }
    }
}