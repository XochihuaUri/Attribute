

namespace Atributo.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class DisplayClassAttribute : Attribute
    {
        public ConsoleColor Color { get; set; } = ConsoleColor.Magenta;
    }
}
