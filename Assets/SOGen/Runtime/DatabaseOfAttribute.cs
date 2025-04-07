using System;

namespace SOGen
{
    [AttributeUsage(AttributeTargets.Class)]
    public class DatabaseOfAttribute : Attribute
    {
        public Type IDType { get; }
        public Type DataType { get; }

        public DatabaseOfAttribute(Type idType, Type dataType)
        {
            IDType = idType;
            DataType = dataType;
        }
    }
}