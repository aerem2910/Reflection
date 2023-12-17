using System;

class Program
{
    static void Main()
    {
        MyClass obj = new MyClass();
        Console.WriteLine("Original Object: " + ObjectToStringExtension.ObjectToString(obj));

        // Меняем значение свойства
        obj.I = 42;
        Console.WriteLine("Object after changing property value: " + ObjectToStringExtension.ObjectToString(obj));

        // Преобразуем строку в объект и выводим
        StringToObjectExtension.StringToObject("CustomFieldName:100", obj);
        Console.WriteLine("Object after converting string to object: " + ObjectToStringExtension.ObjectToString(obj));
    }
}
