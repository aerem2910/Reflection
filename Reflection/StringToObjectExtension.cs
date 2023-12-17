using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

public static class StringToObjectExtension
{
    public static void StringToObject(string str, object obj)
    {
        var type = obj.GetType();
        var fields = type.GetFields(BindingFlags.Public | BindingFlags.Instance);

        var keyValuePairs = str.Split(',').Select(pair =>
        {
            var parts = pair.Split(':');
            return new KeyValuePair<string, string>(parts[0], parts[1]);
        });

        foreach (var keyValue in keyValuePairs)
        {
            var field = fields.FirstOrDefault(f =>
            {
                var customNameAttribute = (CustomNameAttribute)f.GetCustomAttribute(typeof(CustomNameAttribute));
                var propertyName = customNameAttribute?.CustomFieldName ?? f.Name;
                return propertyName == keyValue.Key;
            });

            if (field != null)
            {
                var value = Convert.ChangeType(keyValue.Value, field.FieldType);
                field.SetValue(obj, value);
            }
        }
    }
}
