

namespace Atributo.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class DisplayPropertyAttribute : Attribute
    {
        public string Label { get; }
        public ConsoleColor Color { get; }
        public DisplayPropertyAttribute(string label, ConsoleColor color = ConsoleColor.Cyan)
        {
            Label = label ?? throw new ArgumentNullException(nameof(label));
            Color = color;
        }
    }
}
