A package of functions to supplement System.Reflections.

Functions are divided to several classes:
* DynamicTypeConverter - A non-static class that helps using <see cref="System.ComponentModel.TypeConverter"/> to change an object type in the runtime.
* EnumTypeConverter - A static class that helps to convert enum type values to/from string. It accepts shortcuts of enum value names.
* JointProperties - A non-class to copy properties marked with [DataMember] attribute from one object to another.
* ObjectComparer - A static class to compare two object by deep properties comparison.
* ObjectCopier - A static class to clone object with a deep copy of the object properties.
* StaticToStringConverter - A static class that provides methods to convert objects of various types to string.
* StaticTypeConverter - A static class that converts object type to another type.
* TypeCategoriation - A static class that defines several typ categories and provides methods to detect a type category.
* TypeNaming - A static class that provides more friendy type names than Type.GetName().
* TypeReflectionByInheritance - A static class that provides type extension methods for getting members in order of inheritance.
* TypeUtils - A static class that provides helper functions to operate on types and supplement <c>System.Reflection</c> library.