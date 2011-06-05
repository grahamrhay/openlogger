using System;

namespace OpenLogger
{
    [AttributeUsage(AttributeTargets.Class, Inherited = true, AllowMultiple = false)]
    public class LogCategoryAttribute : Attribute
    {
        public LogCategoryAttribute(string categoryName)
        {
            CategoryName = categoryName;
        }

        public string CategoryName { get; private set; }
    }
}