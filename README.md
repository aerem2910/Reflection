Программа реализует работу с рефлексией для объекта класса `MyClass`. В этом классе есть поле `I`, которое имеет атрибут `CustomNameAttribute` с именем `CustomFieldName`. 

Программа содержит следующие методы:

1. **CustomNameAttribute.cs**: Этот файл содержит определение атрибута `CustomNameAttribute`, который используется для задания пользовательского имени поля.

2. **MyClass.cs**: В этом файле определен класс `MyClass`, в котором есть поле `I` с атрибутом `CustomName("CustomFieldName")`.

3. **ObjectToStringExtension.cs**: Это расширение для объектов. Метод `ObjectToString` принимает объект и возвращает строку, представляющую его значения полей. Если у поля есть атрибут `CustomNameAttribute`, то используется его имя.

4. **StringToObjectExtension.cs**: Это еще одно расширение для объектов. Метод `StringToObject` принимает строку и объект, присваивая значения полям объекта на основе строки. Если имя поля в строке соответствует имени, указанному в атрибуте `CustomNameAttribute`, то это имя используется.

5. **Program.cs**: В этом файле в методе `Main` создается объект класса `MyClass`, выводится его текущее состояние с использованием метода `ObjectToString`, затем изменяется значение поля `I`, снова выводится новое состояние, и, наконец, строка "CustomFieldName:100" преобразуется в объект с использованием метода `StringToObject` и снова выводится состояние объекта.

Таким образом, программа демонстрирует, как использовать атрибуты для задания имен полей и как с помощью рефлексии записывать и считывать значения этих полей.
