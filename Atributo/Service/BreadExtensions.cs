
using Atributo.Attributes;
using Atributo.models;
using System.Reflection;
using System.Text;

namespace Atributo.Service
{
    public static class BreadExtensions
    {
        public static void Write(this Bread bread)
        {
            GetClassColor(bread);
            ConsoleColor defaultColor = Console.ForegroundColor;
            var breadProperties = bread.GetType().GetProperties();
            
            foreach (var property in breadProperties)
            {
                StringBuilder tabs = new StringBuilder("");
                int NumOfTabs = GetNumOfTabs(bread, property.Name);
                for(int i = 0; i < NumOfTabs; i++)
                {
                    tabs.Append("    ");
                }

                Console.WriteLine(tabs + property.Name);
            }
        }

        private static string GetPropertyAttribute(Bread bread, string propertyName)
        {
            PropertyInfo nameProperty = bread.GetType().GetProperty(propertyName);
            DisplayPropertyAttribute attribute = (DisplayPropertyAttribute)Attribute.GetCustomAttribute(nameProperty, typeof(DisplayPropertyAttribute));

            if (attribute != null)
            {
                Console.ForegroundColor = attribute.Color;
                return attribute.Label;
            }
            return null;
        }

        private static  int GetNumOfTabs(Bread bread, string propertyName)
        {
            PropertyInfo nameProperty = bread.GetType().GetProperty(propertyName);
            int numOfTabs = (int)Attribute.GetCustomAttributes(nameProperty, typeof(TabAttribute)).Count();
            return numOfTabs;
        }

        private static void GetClassColor(Bread bread)
        {
            if (bread == null)
                throw new NullReferenceException("this obj is null");

            DisplayClassAttribute attribute = (DisplayClassAttribute)Attribute.GetCustomAttribute(bread.GetType(), typeof(DisplayClassAttribute));

            if (attribute != null)
                Console.ForegroundColor = attribute.Color;
            else
                throw new NullReferenceException("Display attribute doesn'e exist, please add one to the class: " + bread.GetType());

        }
    }
}
