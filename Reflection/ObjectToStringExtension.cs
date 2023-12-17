using System;
using System.Linq;
using System.Reflection;

public static class ObjectToStringExtension
{
    public static string ObjectToString(object obj)
    {
        var type = obj.GetType();
        var fields = type.GetFields(BindingFlags.Public | BindingFlags.Instance);

        var result = string.Join(", ", fields.Select(field =>
        {
            var customNameAttribute = (CustomNameAttribute)field.GetCustomAttribute(typeof(CustomNameAttribute));
            var propertyName = customNameAttribute?.CustomFieldName ?? field.Name;
            var propertyValue = field.GetValue(obj);
            return $"{propertyName}:{propertyValue}";
        }));

        return result;
    }
}
